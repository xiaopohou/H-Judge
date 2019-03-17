using System;

namespace hjudgeWebHost.Models.Problem
{
    public class ProblemModel : ResultModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreationTime { get; set; }
        public int Level { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Type { get; set; }
        public int AcceptCount { get; set; }
        public int SubmissionCount { get; set; }
        public string[] Languages { get; set; } = new string[0];
        public int Status { get; set; }
        public bool Hidden { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }
    }
}