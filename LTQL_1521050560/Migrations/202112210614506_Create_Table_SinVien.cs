namespace LTQL_1521050560.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NVCSinhVien560",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        MaLop = c.String(),
                        LopHoc560_MaLop = c.Int(),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHoc560", t => t.LopHoc560_MaLop)
                .Index(t => t.LopHoc560_MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NVCSinhVien560", "LopHoc560_MaLop", "dbo.LopHoc560");
            DropIndex("dbo.NVCSinhVien560", new[] { "LopHoc560_MaLop" });
            DropTable("dbo.NVCSinhVien560");
        }
    }
}
