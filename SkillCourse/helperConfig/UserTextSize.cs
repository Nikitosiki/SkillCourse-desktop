﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCourse.helperConfig
{
    public static class UserTextSize
    {
        public class Course
        {
            public static readonly int maxLenghtName = 80;
            public static readonly int maxLenghtDescription = 500;
        }

        public class Task
        {
            public static readonly int maxLenghtName = 300;
        }

        public class AnswerTask
        {
            public static readonly int maxLenghtName = 500;
        }
    }
}
