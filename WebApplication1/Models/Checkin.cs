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
    
    public partial class Checkin
    {
        public long ID { get; set; }
        public Nullable<long> Account { get; set; }
        public Nullable<System.DateTime> Work_Date { get; set; }
        public Nullable<System.DateTime> Getoff_Date { get; set; }
        public Nullable<int> time { get; set; }
        public string Note { get; set; }
    
        public virtual AccountData AccountData { get; set; }
    }
}