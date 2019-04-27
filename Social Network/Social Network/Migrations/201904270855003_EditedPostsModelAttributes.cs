namespace Social_Network.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedPostsModelAttributes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Comment", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Comment", c => c.String());
        }
    }
}
