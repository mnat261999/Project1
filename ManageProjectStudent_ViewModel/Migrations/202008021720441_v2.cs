namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Language_Word", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Language_Word", "Status", c => c.Boolean(nullable: false));
        }
    }
}
