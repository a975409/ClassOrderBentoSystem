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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OrderBentoSystemEntities : DbContext
    {
        public OrderBentoSystemEntities()
            : base("name=OrderBentoSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClassRoom> ClassRoom { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<FavoriteDetial> FavoriteDetial { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetial> OrderDetial { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}
