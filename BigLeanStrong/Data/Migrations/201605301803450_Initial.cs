namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Day",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DayName = c.String(),
                        DayDate = c.DateTime(nullable: false),
                        BodyArea = c.String(),
                        WeekPlan_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.WeekPlan", t => t.WeekPlan_ID)
                .Index(t => t.WeekPlan_ID);
            
            CreateTable(
                "dbo.Exercise",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExerciseName = c.String(),
                        BarType = c.String(),
                        Weight = c.Int(nullable: false),
                        Dificulty = c.String(),
                        Day_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Day", t => t.Day_ID)
                .Index(t => t.Day_ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WeekPlan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WeekName = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeekPlan", "User_ID", "dbo.User");
            DropForeignKey("dbo.Day", "WeekPlan_ID", "dbo.WeekPlan");
            DropForeignKey("dbo.Exercise", "Day_ID", "dbo.Day");
            DropIndex("dbo.WeekPlan", new[] { "User_ID" });
            DropIndex("dbo.Exercise", new[] { "Day_ID" });
            DropIndex("dbo.Day", new[] { "WeekPlan_ID" });
            DropTable("dbo.WeekPlan");
            DropTable("dbo.User");
            DropTable("dbo.Exercise");
            DropTable("dbo.Day");
        }
    }
}
