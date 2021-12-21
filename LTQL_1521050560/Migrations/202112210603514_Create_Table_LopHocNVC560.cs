namespace LTQL_1521050560.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LopHocNVC560 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHoc560",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LopHoc560");
        }
    }
}
