﻿using LLAH.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class StudentSchool : BaseModel
    {
        public int StudentId { get; set; }
        public int SchoolId { get; set; }
    }
}
