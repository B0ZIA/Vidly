namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOneBrithdayToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Brithday = '2012-07-04T00:00:00.000' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
