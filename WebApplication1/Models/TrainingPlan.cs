//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainingPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrainingPlan()
        {
            this.PlanDetails = new HashSet<PlanDetails>();
        }
    
        public long ID { get; set; }
        public string Project_Name { get; set; }
        public string Target { get; set; }
        public Nullable<long> Team_ID { get; set; }
        public Nullable<System.DateTime> Open_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Schedule { get; set; }
        public Nullable<System.DateTime> CloseCase_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanDetails> PlanDetails { get; set; }
        public virtual TeamList TeamList { get; set; }
    }
}
