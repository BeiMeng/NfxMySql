namespace ConsoleMySql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Auother", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Auother");
        }
    }
}
