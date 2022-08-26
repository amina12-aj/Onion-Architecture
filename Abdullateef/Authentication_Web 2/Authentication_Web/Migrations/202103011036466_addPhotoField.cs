namespace Authentication_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhotoField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Photo");
        }
    }
}
