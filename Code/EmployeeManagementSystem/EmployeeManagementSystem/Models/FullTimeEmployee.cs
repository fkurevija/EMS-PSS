//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FullTimeEmployee
    {
        public int EmployeeRefId { get; set; }
        public int EmployedWithId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Date of Hire", Prompt = "Enter Date of Hire: ", Description = "Date of Hire", ShortName = "Date of Hire")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime DateOfHire { get; set; }

        [Display(Name = "Date of Termination", Prompt = "Enter Date of Termination: ", Description = "Date of Termination", ShortName = "Date of Termination")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> DateOfTermination { get; set; }

        [Display(Name = "Salary", Prompt = "Enter Salary: ", Description = "Salary", ShortName = "Salary")]
        [Range(5, double.MaxValue, ErrorMessage = "{0} must be above 0")]
        public Nullable<double> Salary { get; set; }
        public Nullable<int> ReasonForLeavingId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ReasonForLeaving ReasonForLeaving { get; set; }
    }
}