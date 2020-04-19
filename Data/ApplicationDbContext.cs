using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFReverse.Models;

namespace EFReverse.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CashToBank> CashToBank { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CenterData> CenterData { get; set; }
        public virtual DbSet<CustAccount> CustAccount { get; set; }
        public virtual DbSet<CustAccountTracking> CustAccountTracking { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerTracking> CustomerTracking { get; set; }
        public virtual DbSet<DamageDetails> DamageDetails { get; set; }
        public virtual DbSet<DamageDetailsTracking> DamageDetailsTracking { get; set; }
        public virtual DbSet<DamageHead> DamageHead { get; set; }
        public virtual DbSet<DamageHeadTracking> DamageHeadTracking { get; set; }
        public virtual DbSet<Dim> Dim { get; set; }
        public virtual DbSet<ExpAcc> ExpAcc { get; set; }
        public virtual DbSet<ExpAccTracking> ExpAccTracking { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseTracking> ExpenseTracking { get; set; }
        public virtual DbSet<HistoryStore> HistoryStore { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryTracking> InventoryTracking { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceTracking> InvoiceTracking { get; set; }
        public virtual DbSet<PosData> PosData { get; set; }
        public virtual DbSet<PosDataTracking> PosDataTracking { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<ProductDetailsTracking> ProductDetailsTracking { get; set; }
        public virtual DbSet<ProductTracking> ProductTracking { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<ProductTypeTracking> ProductTypeTracking { get; set; }
        public virtual DbSet<PurchasessPhoto> PurchasessPhoto { get; set; }
        public virtual DbSet<PurchasessPhotoTracking> PurchasessPhotoTracking { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleTracking> RoleTracking { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<ScreenPhoto> ScreenPhoto { get; set; }
        public virtual DbSet<ScreenPhotoTracking> ScreenPhotoTracking { get; set; }
        public virtual DbSet<StockTaking> StockTaking { get; set; }
        public virtual DbSet<StockTakingDetails> StockTakingDetails { get; set; }
        public virtual DbSet<StockTakingDetailsTracking> StockTakingDetailsTracking { get; set; }
        public virtual DbSet<StockTakingTracking> StockTakingTracking { get; set; }
        public virtual DbSet<SupInvo> SupInvo { get; set; }
        public virtual DbSet<SupInvoTracking> SupInvoTracking { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SuppliersTracking> SuppliersTracking { get; set; }
        public virtual DbSet<Suppliersaccount> Suppliersaccount { get; set; }
        public virtual DbSet<SuppliersaccountTracking> SuppliersaccountTracking { get; set; }
        public virtual DbSet<TItems> TItems { get; set; }
        public virtual DbSet<TItemsPurchase> TItemsPurchase { get; set; }
        public virtual DbSet<TItemsPurchaseDetails> TItemsPurchaseDetails { get; set; }
        public virtual DbSet<TItemsPurchaseDetailsTracking> TItemsPurchaseDetailsTracking { get; set; }
        public virtual DbSet<TItemsPurchaseTracking> TItemsPurchaseTracking { get; set; }
        public virtual DbSet<TItemsTracking> TItemsTracking { get; set; }
        public virtual DbSet<TRecipe> TRecipe { get; set; }
        public virtual DbSet<TRecipeDetails> TRecipeDetails { get; set; }
        public virtual DbSet<TRecipeDetailsTracking> TRecipeDetailsTracking { get; set; }
        public virtual DbSet<TRecipeTracking> TRecipeTracking { get; set; }
        public virtual DbSet<TblOnlineProduct> TblOnlineProduct { get; set; }
        public virtual DbSet<TblOnlineUser> TblOnlineUser { get; set; }
        public virtual DbSet<TransDetails> TransDetails { get; set; }
        public virtual DbSet<TransDetailsTracking> TransDetailsTracking { get; set; }
        public virtual DbSet<TransHead> TransHead { get; set; }
        public virtual DbSet<TransHeadTracking> TransHeadTracking { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersTracking> UsersTracking { get; set; }
        public virtual DbSet<Usersession> Usersession { get; set; }
        public virtual DbSet<UsersessionTracking> UsersessionTracking { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=alhamor.database.windows.net;Database=Restaurant;User Id=huper;Password=team.1986");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CashToBank>(entity =>
            {
                entity.HasKey(e => e.CashId)
                    .HasName("PK_cash_ctb");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK_T_Famille");

                entity.Property(e => e.CatNameen).IsUnicode(false);
            });

            modelBuilder.Entity<CenterData>(entity =>
            {
                entity.HasKey(e => e.CenterId)
                    .HasName("PK__center_d__29093C6F1D8C5D44");
            });

            modelBuilder.Entity<CustAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__cust_acc_");
            });

            modelBuilder.Entity<CustAccountTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__customer__7B8E5D0F90382864");
            });

            modelBuilder.Entity<CustomerTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DamageDetails>(entity =>
            {
                entity.HasKey(e => e.DdId)
                    .HasName("PK__damage_d__D31D613C9F87BF5E");
            });

            modelBuilder.Entity<DamageDetailsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DamageHeadTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Dim>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__dim__D9DE21FC16EE63E9");

                entity.Property(e => e.Day).HasComputedColumnSql("(datepart(day,[date]))");

                entity.Property(e => e.DayOfWeek).HasComputedColumnSql("(datepart(weekday,[date]))");

                entity.Property(e => e.FirstOfMonth).HasComputedColumnSql("(CONVERT([date],dateadd(month,datediff(month,(0),[date]),(0))))");

                entity.Property(e => e.FirstOfYear).HasComputedColumnSql("(CONVERT([date],dateadd(year,datediff(year,(0),[date]),(0))))");

                entity.Property(e => e.Isoweek).HasComputedColumnSql("(datepart(iso_week,[date]))");

                entity.Property(e => e.Month).HasComputedColumnSql("(datepart(month,[date]))");

                entity.Property(e => e.MonthName).HasComputedColumnSql("(datename(month,[date]))");

                entity.Property(e => e.Quarter).HasComputedColumnSql("(datepart(quarter,[date]))");

                entity.Property(e => e.Style101)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComputedColumnSql("(CONVERT([char](10),[date],(101)))");

                entity.Property(e => e.Style112)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComputedColumnSql("(CONVERT([char](8),[date],(112)))");

                entity.Property(e => e.Week).HasComputedColumnSql("(datepart(week,[date]))");

                entity.Property(e => e.Year).HasComputedColumnSql("(datepart(year,[date]))");
            });

            modelBuilder.Entity<ExpAcc>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__exp_acc__9A20D554A83B888C");
            });

            modelBuilder.Entity<ExpAccTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PK__expense__FED8E5E9869250FA");
            });

            modelBuilder.Entity<ExpenseTracking>(entity =>
            {
                entity.Property(e => e.ExpId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<HistoryStore>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.PkDateDest })
                    .HasName("history_store_primary")
                    .IsClustered(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.Property(e => e.InventoryId).IsUnicode(false);
            });

            modelBuilder.Entity<InventoryTracking>(entity =>
            {
                entity.Property(e => e.InventoryId).IsUnicode(false);

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.InvoiceId).IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceTracking>(entity =>
            {
                entity.Property(e => e.InvoiceId).IsUnicode(false);

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PosData>(entity =>
            {
                entity.HasKey(e => e.PosId)
                    .HasName("PK__pos_data__D1A5EFDA1FA8A251");

                entity.Property(e => e.PosId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PosDataTracking>(entity =>
            {
                entity.Property(e => e.PosId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK_T_Article");

                entity.Property(e => e.ProdNameEn).IsUnicode(false);
            });

            modelBuilder.Entity<ProductDetails>(entity =>
            {
                entity.HasKey(e => e.ProdCentId)
                    .HasName("PK_T_details");
            });

            modelBuilder.Entity<ProductDetailsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ProductTracking>(entity =>
            {
                entity.Property(e => e.ProdId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__type_760965CC5132EC61");

                entity.HasIndex(e => e.TypeId)
                    .HasName("AK_pp")
                    .IsUnique();
            });

            modelBuilder.Entity<ProductTypeTracking>(entity =>
            {
                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PurchasessPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PK_photo_id");
            });

            modelBuilder.Entity<PurchasessPhotoTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("AK_ppp")
                    .IsUnique();
            });

            modelBuilder.Entity<RoleTracking>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.SaleId)
                    .HasName("PK__sales__E1EB00B20508BDA3");

                entity.Property(e => e.InvoiceId).IsUnicode(false);
            });

            modelBuilder.Entity<ScreenPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoCentId)
                    .HasName("PK_screen_details");
            });

            modelBuilder.Entity<ScreenPhotoTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<StockTaking>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK__stock_ta__E86668627AD6D5DF");
            });

            modelBuilder.Entity<StockTakingDetails>(entity =>
            {
                entity.HasKey(e => e.StockingId)
                    .HasName("PK__stock_ta__633FDC2A1FF05277");
            });

            modelBuilder.Entity<StockTakingDetailsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<StockTakingTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SupInvoTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SuppliersTracking>(entity =>
            {
                entity.Property(e => e.SuppliersId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Suppliersaccount>(entity =>
            {
                entity.HasIndex(e => e.InvoNo)
                    .HasName("UQ__supplier__FEADAEAB71175609")
                    .IsUnique();
            });

            modelBuilder.Entity<SuppliersaccountTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TItems>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_T_item");

                entity.Property(e => e.ItemNameEn).IsUnicode(false);
            });

            modelBuilder.Entity<TItemsPurchase>(entity =>
            {
                entity.HasIndex(e => e.InvoNo)
                    .HasName("UQ__T_items___FEADAEABAE5995CD")
                    .IsUnique();
            });

            modelBuilder.Entity<TItemsPurchaseDetailsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TItemsPurchaseTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TItemsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TRecipe>(entity =>
            {
                entity.Property(e => e.RecipeId).IsUnicode(false);
            });

            modelBuilder.Entity<TRecipeDetails>(entity =>
            {
                entity.HasKey(e => e.DId)
                    .HasName("PK__T_recipe__D95F582B0B44F244");

                entity.Property(e => e.RecipeId).IsUnicode(false);
            });

            modelBuilder.Entity<TRecipeDetailsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TRecipeTracking>(entity =>
            {
                entity.Property(e => e.RecipeId).IsUnicode(false);

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TblOnlineProduct>(entity =>
            {
                entity.Property(e => e.Vissible).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblOnlineUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Phone).IsFixedLength();
            });

            modelBuilder.Entity<TransDetails>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("PK__trans_de__438CAC1858A65B6E");
            });

            modelBuilder.Entity<TransDetailsTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TransHeadTracking>(entity =>
            {
                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__users__B9BE370FB9513240");

                entity.HasIndex(e => e.UserName)
                    .HasName("UQ__users__7C9273C4F4C9985D")
                    .IsUnique();
            });

            modelBuilder.Entity<UsersTracking>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Usersession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK__usersess__69B13FDCEB838E5F");

                entity.HasIndex(e => e.SessionTime)
                    .HasName("IX_usersession")
                    .IsUnique();
            });

            modelBuilder.Entity<UsersessionTracking>(entity =>
            {
                entity.Property(e => e.SessionId).ValueGeneratedNever();

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.HasSequence("S_Cash_id").StartsAt(1100);

            modelBuilder.HasSequence("S_damage_details").StartsAt(1001);

            modelBuilder.HasSequence("S_damage_head").StartsAt(1001);

            modelBuilder.HasSequence("S_expense").StartsAt(1450);

            modelBuilder.HasSequence("S_INVent").StartsAt(1001);

            modelBuilder.HasSequence("S_invo").StartsAt(100001);

            modelBuilder.HasSequence("S_pdetails").StartsAt(1200);

            modelBuilder.HasSequence("S_purchase_photo").StartsAt(1001);

            modelBuilder.HasSequence("S_recipe_details").StartsAt(1001);

            modelBuilder.HasSequence("S_recipe_head").StartsAt(1001);

            modelBuilder.HasSequence("S_Sale").StartsAt(100001);

            modelBuilder.HasSequence("S_STK_DETAILS").StartsAt(1001);

            modelBuilder.HasSequence("S_STK_HEAD").StartsAt(1001);

            modelBuilder.HasSequence("S_sup_acc").StartsAt(1500);

            modelBuilder.HasSequence("S_sup_invo").StartsAt(1450);

            modelBuilder.HasSequence("S_T_items_id").StartsAt(1001);

            modelBuilder.HasSequence("S_tblonlineproduct").StartsAt(1001);

            modelBuilder.HasSequence("S_TRdetail").StartsAt(1001);

            modelBuilder.HasSequence("S_TRhead").StartsAt(1001);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
