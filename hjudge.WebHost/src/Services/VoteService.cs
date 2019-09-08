﻿using hjudge.WebHost.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using EFSecondLevelCache.Core;
using Microsoft.EntityFrameworkCore;

namespace hjudge.WebHost.Services
{
    public interface IVoteService
    {
        Task<bool> UpvoteProblemAsync(string userId, int problemId, string? title = null, string? content = null);
        Task<bool> UpvoteContestAsync(string userId, int contestId, string? title = null, string? content = null);
        Task<bool> DownvoteProblemAsync(string userId, int problemId, string? title = null, string? content = null);
        Task<bool> DownvoteContestAsync(string userId, int contestId, string? title = null, string? content = null);
        Task<bool> CancelVoteProblemAsync(string userId, int problemId);
        Task<bool> CancelVoteContestAsync(string userId, int contestId);
        Task<VotesRecord?> GetVoteAsync(string userId, int? problemId, int? contestId);
    }
    public class VoteService : IVoteService
    {
        private readonly IProblemService problemService;
        private readonly IContestService contestService;
        private readonly WebHostDbContext dbContext;

        public VoteService(IProblemService problemService, IContestService contestService, WebHostDbContext dbContext)
        {
            this.problemService = problemService;
            this.contestService = contestService;
            this.dbContext = dbContext;
        }

        public async Task<bool> CancelVoteContestAsync(string userId, int contestId)
        {
            var contest = await contestService.GetContestAsync(contestId);
            if (contest == null) return false;
            var exists = await dbContext.VotesRecord.Where(i => i.UserId == userId && i.ProblemId == null && i.ContestId == contestId).Cacheable().FirstOrDefaultAsync();
            if (exists != null)
            {
                if (exists.VoteType == 1) contest.Upvote = Math.Max(0, contest.Upvote - 1);
                else contest.Downvote = Math.Max(0, contest.Downvote - 1);
                dbContext.VotesRecord.Remove(exists);
                dbContext.Contest.Update(contest);
            }
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CancelVoteProblemAsync(string userId, int problemId)
        {
            var problem = await problemService.GetProblemAsync(problemId);
            if (problem == null) return false;
            var exists = await dbContext.VotesRecord.Where(i => i.UserId == userId && i.ProblemId == problemId && i.ContestId == null).Cacheable().FirstOrDefaultAsync();
            if (exists != null)
            {
                if (exists.VoteType == 1) problem.Upvote = Math.Max(0, problem.Upvote - 1);
                else problem.Downvote = Math.Max(0, problem.Downvote - 1);
                dbContext.VotesRecord.Remove(exists);
                dbContext.Problem.Update(problem);
            }
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DownvoteContestAsync(string userId, int contestId, string? title = null, string? content = null)
        {
            var contest = await contestService.GetContestAsync(contestId);
            if (contest == null) return false;
            var exists = await dbContext.VotesRecord.Where(i => i.UserId == userId && i.ProblemId == null && i.ContestId == contestId).Cacheable().AnyAsync();
            if (exists) return false;
            ++contest.Downvote;
            await dbContext.VotesRecord.AddAsync(new VotesRecord
            {
                ContestId = contestId,
                UserId = userId,
                ProblemId = null,
                VoteType = 2,
                VoteTime = DateTime.Now,
                Title = title ?? string.Empty,
                Content = string.IsNullOrEmpty(title) ? string.Empty : (content ?? string.Empty)
            });
            dbContext.Contest.Update(contest);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DownvoteProblemAsync(string userId, int problemId, string? title = null, string? content = null)
        {
            var problem = await problemService.GetProblemAsync(problemId);
            if (problem == null) return false;
            var exists = await dbContext.VotesRecord.Where(i => i.UserId == userId && i.ProblemId == problemId && i.ContestId == null).Cacheable().AnyAsync();
            if (exists) return false;
            ++problem.Downvote;
            await dbContext.VotesRecord.AddAsync(new VotesRecord
            {
                ProblemId = problemId,
                UserId = userId,
                ContestId = null,
                VoteType = 2,
                VoteTime = DateTime.Now,
                Title = title ?? string.Empty,
                Content = string.IsNullOrEmpty(title) ? string.Empty : (content ?? string.Empty)
            });
            dbContext.Problem.Update(problem);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public Task<VotesRecord?> GetVoteAsync(string userId, int? problemId, int? contestId)
        {
            return dbContext.VotesRecord.AsNoTracking().Where(i => i.UserId == userId && i.ProblemId == problemId && i.ContestId == contestId).Cacheable().FirstOrDefaultAsync();
        }

        public async Task<bool> UpvoteContestAsync(string userId, int contestId, string? title = null, string? content = null)
        {
            var contest = await contestService.GetContestAsync(contestId);
            if (contest == null) return false;
            var exists = await dbContext.VotesRecord.Where(i => i.UserId == userId && i.ProblemId == null && i.ContestId == contestId).Cacheable().AnyAsync();
            if (exists) return false;
            ++contest.Upvote;
            await dbContext.VotesRecord.AddAsync(new VotesRecord
            {
                ContestId = contestId,
                UserId = userId,
                ProblemId = null,
                VoteType = 1,
                VoteTime = DateTime.Now,
                Title = title ?? string.Empty,
                Content = string.IsNullOrEmpty(title) ? string.Empty : (content ?? string.Empty)
            });
            dbContext.Contest.Update(contest);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpvoteProblemAsync(string userId, int problemId, string? title = null, string? content = null)
        {
            var problem = await problemService.GetProblemAsync(problemId);
            if (problem == null) return false;
            var exists = await dbContext.VotesRecord.Where(i => i.UserId == userId && i.ProblemId == problemId && i.ContestId == null).Cacheable().AnyAsync();
            if (exists) return false;
            ++problem.Upvote;
            await dbContext.VotesRecord.AddAsync(new VotesRecord
            {
                ProblemId = problemId,
                UserId = userId,
                ContestId = null,
                VoteType = 1,
                VoteTime = DateTime.Now,
                Title = title ?? string.Empty,
                Content = string.IsNullOrEmpty(title) ? string.Empty : (content ?? string.Empty)
            });
            dbContext.Problem.Update(problem);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
