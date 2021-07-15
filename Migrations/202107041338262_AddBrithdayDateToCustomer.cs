namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBrithdayDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Brithday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Brithday");
        }
    }
}
