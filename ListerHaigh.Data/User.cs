//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListerHaigh.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.JobAllocations = new HashSet<JobAllocation>();
            this.Preferences = new HashSet<Preference>();
        }
    
        public int Id { get; set; }
        public Nullable<int> UserProfileId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Village { get; set; }
        public Nullable<int> Town { get; set; }
        public Nullable<int> County { get; set; }
        public Nullable<bool> IsBackend { get; set; }
        public bool Enabled { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public bool Deleted { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> DefaultView { get; set; }
    
        public virtual ICollection<JobAllocation> JobAllocations { get; set; }
        public virtual Office Office { get; set; }
        public virtual ICollection<Preference> Preferences { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
