﻿namespace DTO.ViewModels
{
    using System.ComponentModel;

    public class Registration : UserViewModel
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string Lastname { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone number")]
        public string Phone { get; set; }
    }
}
