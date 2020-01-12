using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentIdentity.Models
{
    public class VarStudentData
    {
        public int Id { get; set; }

        [Key, Required(ErrorMessage = "Please Log in")]
        public string RegNumber { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime DateofBirth { get; set; }


        [Display(Name="Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "State of Origin")]
        public string StateofOrigin { get; set; }


        [Display(Name = "Local Government")]
        public string LGAofOrigin { get; set; }

        [Display(Name = "Home Town")]
        public string HomeTown { get; set; }


        [MinLength(10),Display(Name = "Parmanent Address")]
        public string ParmanentAddress { get; set; }


        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }


        [Display(Name = "Student Address"),MinLength(10)]
        public string ContactAddress { get; set; }


        [Display(Name = "Blood Group")]
        public string Bloodgroup { get; set; }


        [Display(Name = "Genotype")]
        public string Genotype { get; set; }


        public string Religion { get; set; }

        [Display(Name = "Email"), EmailAddress]
        public string Email { get; set; }



        [Display(Name = "Sponsor's Name")]
        public string SponsorName { get; set; }

        [Display(Name = "Sponsor's Address"), MinLength(10)]
        public string SponsorAddress { get; set; }

        [Display(Name = "Sponsor's Phone Number")]
        public int SponsorPhoneNumber { get; set; }

        [Display(Name = "Sponsor's Email"), EmailAddress]
        public string SponsorEmail { get; set; }


        [Display(Name = "Sponsor's Relation to you")]
        public string SponsorRelationship { get; set; }




        [Display(Name = "NextOfKin Name")]
        public string NextOfKinName { get; set; }

        [Display(Name = "NextOfKin Address"), MinLength(10)]
        public string NextOfKinAddress { get; set; }

        [Display(Name = "NextOfKin Phone Number")]
        public int NextOfKinPhoneNumber { get; set; }

        [Display(Name = "NextOfKin Email"), EmailAddress]
        public string NextOfKinEmail { get; set; }


        [Display(Name = "NextOfKin Relation to you")]
        public string NextOfKinRelationship { get; set; }










        public bool Diabeties { get; set; }

        public bool Hypertention { get; set; }

        public bool Disabilities { get; set; }

        public bool Blind { get; set; }

        public bool Epilepsy { get; set; }

        public bool Asthma { get; set; }

        [Display(Name = "Spectacle Use")]
        public bool SpectacleUse { get; set; }

        [Display(Name = "Sickle Cell")]
        public bool SickleCell { get; set; }

        public bool Allergies { get; set; }


        [Display(Name = "Previous Surgery")]
        public bool PreviousSurgery { get; set; }
    }
}