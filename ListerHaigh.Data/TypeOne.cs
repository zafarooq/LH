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
    
    public partial class TypeOne
    {
        public TypeOne()
        {
            this.ComparableRecords = new HashSet<ComparableRecord>();
            this.JobEvents = new HashSet<JobEvent>();
            this.Jobs = new HashSet<Job>();
        }
    
        public int TypeId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<ComparableRecord> ComparableRecords { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<JobEvent> JobEvents { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
