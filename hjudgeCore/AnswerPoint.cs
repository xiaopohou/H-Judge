﻿using System;

namespace hjudgeCore
{
    public class AnswerPoint : ICloneable
    {
        public string AnswerFile { get; set; } = string.Empty;
        public float Score { get; set; } = 0;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}