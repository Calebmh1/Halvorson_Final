﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HalvorsonCredit.Models
{
    public partial class Institution
    {
        public Institution()
        {
            UserInstitutions = new HashSet<UserInstitution>();
        }

        public int InstitutionId { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionDescription { get; set; }
        public string RoutingNumber { get; set; }
        public string InstitutionAddress { get; set; }

        public virtual ICollection<UserInstitution> UserInstitutions { get; set; }
    }
}