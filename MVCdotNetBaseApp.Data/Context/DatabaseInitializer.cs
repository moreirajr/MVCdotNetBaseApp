using System.Data.Entity;


namespace MVCdotNetBaseApp.Data.Context
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<ApplicationDatabaseContext>
    {
        public DatabaseInitializer(ApplicationDatabaseContext databaseContext)
        {
            Seed(databaseContext);
        }

        protected override void Seed(ApplicationDatabaseContext databaseContext)
        {
            //Seed Database

            //if(!databaseContext.EntityName.Any())
            //{
            //    databaseContext.Set<EntityName>().Add(entity);
            //    databaseContext.SaveChanges();
            //}

        }
    }
}
