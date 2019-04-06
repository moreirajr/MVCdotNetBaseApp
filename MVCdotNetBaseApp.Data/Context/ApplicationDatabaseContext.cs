using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MVCdotNetBaseApp.Data.Context
{
    public class ApplicationDatabaseContext : DbContext
    {
        public ApplicationDatabaseContext() : base("ApplicationConnection")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;

            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            //if (Database.Exists())
            //    Database.Delete();

            if (!Database.Exists())
            {
                Database.Initialize(true);
                new DatabaseInitializer(this);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(255));

            InitializeTablesConfiguration(modelBuilder);
        }

        private void InitializeTablesConfiguration(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new EntityMapping());
        }

        #region Db Sets
        //public DbSet<EntityName> EntityNamePlural {get;set;}
        #endregion
    }
}
