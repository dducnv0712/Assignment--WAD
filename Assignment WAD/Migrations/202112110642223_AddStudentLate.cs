namespace Assignment_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentLate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentLates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        rollNumber = c.String(nullable: false),
                        fullName = c.String(nullable: false),
                        Method = c.String(nullable: false),
                        Fines = c.Int(nullable: false),
                        Cause = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentLates");
        }
    }
}
