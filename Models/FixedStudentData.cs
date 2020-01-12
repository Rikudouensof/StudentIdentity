using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentIdentity.Models
{
    public class FixedStudentData
    {
        public int Id { get; set; }

        [Key, Required(ErrorMessage = "Please Log in")]
        public string RegNumber { get; set; }
        
        [Required(ErrorMessage = "Enter Student Surname"), Display(Name ="Student Surname")]
        public string Surname { get; set; }



        public SexModelClass SexModelClass { get; set; }

        [Display(Name = "Sex"), Required(ErrorMessage = "Select Student Sex")]
        public int SexModelClassId { get; set; }

        //[Required(ErrorMessage = "Select Student Sex"), Display(Name = "Sex")]
        //public string Sex { get; set; }



        [Required(ErrorMessage = "Enter Student First name"), Display(Name = "Student First")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Student Other name"), Display(Name = "Second Name")]
        public string OtherName { get; set; }

      
        [Required(ErrorMessage = "Enter Student Jamb Registration"), Display(Name = "Jamb Reg")]
        public string JambRegNumber { get; set; }




        public Department Department{ get; set; }

        [Display(Name = "Department")]
        public string DepartmentId { get; set; }


        public StudentType StudentType { get; set; }
        [Display(Name = "Student Type")]
        public string StudentTypeId { get; set; }


        public Programme Programme { get; set; }
        [Display(Name = "Programme")]
        public string ProgrammeId { get; set; }


        public StudentMode StudentMode { get; set; }
        [Display(Name = "Student Mode")]
        public string StudentModeId { get; set; }


        public ModeOfStudy ModeOfStudy { get; set; }
        [Display(Name = "Mode Of Study")]
        public string ModeOfStudyId { get; set; }

        [Display(Name = "Entry Year")]
        public int EntryYear { get; set; }

        [Display(Name = "Year Of Gradution")]
        public string YearOfGradution { get; set; }

        [Display(Name = "Year Of Study")]
        public string YearOfStudy { get; set; }

    }
}