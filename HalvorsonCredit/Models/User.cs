﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HalvorsonCredit.Models
{
    public partial class User
    {
        public User()
        {
            UserInstitutions = new HashSet<UserInstitution>();
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<UserInstitution> UserInstitutions { get; set; }
    }
}