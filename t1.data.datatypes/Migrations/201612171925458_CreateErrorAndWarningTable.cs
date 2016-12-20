namespace t1.data.datatypes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateErrorAndWarningTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ErrorAndWarning",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    VehicleName = c.String(maxLength: 50),
                    Message = c.String(),
                    CreatedDateTime = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.ErrorAndWarning");
        }
    }
}
