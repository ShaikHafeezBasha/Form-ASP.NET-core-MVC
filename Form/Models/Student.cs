﻿using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Student
    {
        public int? StudentId { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(500)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Branch is required")]
        public Branch Branch { get; set; }

        public bool TermsAndConditions { get; set; }

        public List<string> Hobbies { get; set; } = new List<string>();

        [Required(ErrorMessage = "At least one skill is required")]
        public List<string> Skills { get; set; } = new List<string>();

    }
}
