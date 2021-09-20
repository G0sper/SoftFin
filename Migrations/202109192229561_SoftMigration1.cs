namespace SoftFin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SoftMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.iOrders", "product_name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.iOrders", "product_name");
        }
    }
}
