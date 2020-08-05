namespace ManageProjectStudent_ViewModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Language_Word", "Module", c => c.String(maxLength: 100));
            DropColumn("dbo.Word", "Module");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Word", "Module", c => c.String(maxLength: 100));
            DropColumn("dbo.Language_Word", "Module");
        }
    }
}
