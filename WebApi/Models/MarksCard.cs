﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MarksCard
    {
        public int RollNo
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public int FullMarks
        {
            get;
            set;
        }
        public int Obtained { get; set; }
    }
}