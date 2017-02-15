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
    
    public partial class Module
    {
        public Module()
        {
            this.ModuleItems = new HashSet<ModuleItem>();
            this.Permissions = new HashSet<Permission>();
        }
    
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsCustom { get; set; }
        public Nullable<int> SiteId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsVisible { get; set; }
    
        public virtual ICollection<ModuleItem> ModuleItems { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
