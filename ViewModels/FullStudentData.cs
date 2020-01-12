using StudentIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentIdentity.ViewModels
{
    public class FullStudentData
    {
        public FixedStudentData FixedStudentData  { get; set; }
        public VarStudentData  VarStudentData { get; set; }
    }
}