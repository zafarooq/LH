using System;

namespace ListerHaigh.Models
{
    public class BaseViewModel
    {
        #region Ctors
        public BaseViewModel()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        } 
        #endregion

        #region Properties
        public DateTime? CreatedOn { get; private set; }
        public DateTime? ModifiedOn { get; private set; }
        public int? CreatedBy { get; private set; }
        public int? ModifiedBy { get; private set; } 
        #endregion
    }
}
