//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderBentoSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetial
    {
        public int Id { get; set; }
        public int stuId { get; set; }
        public Nullable<int> MenuId { get; set; }
        public int Num { get; set; }
        public Nullable<int> OrderId { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Student Student { get; set; }
    }
}
