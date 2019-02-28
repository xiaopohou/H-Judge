﻿using hjudgeWebHost.Data.Identity;
using System;

namespace hjudgeWebHost.Data
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public DateTime PublishTime { get; set; }
        public bool Hidden { get; set; }
        public int? GroupId { get; set; }

        public UserInfo? UserInfo { get; set; }
        public Group? Group { get; set; }
    }
}
