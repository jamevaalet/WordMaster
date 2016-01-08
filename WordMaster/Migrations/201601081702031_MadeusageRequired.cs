namespace WordMaster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeusageRequired : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.WordUsages", name: "Word_WordID", newName: "WordID");
            RenameIndex(table: "dbo.WordUsages", name: "IX_Word_WordID", newName: "IX_WordID");
            AlterColumn("dbo.WordUsages", "Usage", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WordUsages", "Usage", c => c.String());
            RenameIndex(table: "dbo.WordUsages", name: "IX_WordID", newName: "IX_Word_WordID");
            RenameColumn(table: "dbo.WordUsages", name: "WordID", newName: "Word_WordID");
        }
    }
}
