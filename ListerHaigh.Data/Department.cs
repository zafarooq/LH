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
    
    public partial class Department
    {
        public Department()
        {
            this.ComparableRecords = new HashSet<ComparableRecord>();
            this.CustomerSubscriptions = new HashSet<CustomerSubscription>();
            this.Events = new HashSet<Event>();
            this.JobCodes = new HashSet<JobCode>();
            this.JobEvents = new HashSet<JobEvent>();
            this.Jobs = new HashSet<Job>();
            this.TypeOnes = new HashSet<TypeOne>();
            this.TypeTwoes = new HashSet<TypeTwo>();
        }
    
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<ComparableRecord> ComparableRecords { get; set; }
        public virtual ICollection<CustomerSubscription> CustomerSubscriptions { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<JobCode> JobCodes { get; set; }
        public virtual ICollection<JobEvent> JobEvents { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<TypeOne> TypeOnes { get; set; }
        public virtual ICollection<TypeTwo> TypeTwoes { get; set; }
    }
}
