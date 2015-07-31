namespace Scrawl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotebookModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        user_Email = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserDetails", t => t.user_Email)
                .Index(t => t.user_Email);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IsStudent = c.Boolean(nullable: false),
                        SchoolName = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotebookModels", "user_Email", "dbo.UserDetails");
            DropIndex("dbo.NotebookModels", new[] { "user_Email" });
            DropTable("dbo.UserDetails");
            DropTable("dbo.NotebookModels");
        }
    }
}
