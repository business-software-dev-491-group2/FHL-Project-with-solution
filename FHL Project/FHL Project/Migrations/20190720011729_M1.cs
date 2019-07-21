using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHLProject.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CDs",
                columns: table => new
                {
                    cdID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CD_Number = table.Column<int>(nullable: false),
                    QS_Number = table.Column<int>(nullable: false),
                    Concurrent = table.Column<int>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: false),
                    CD_Titles = table.Column<string>(nullable: true),
                    Title_Number = table.Column<int>(nullable: false),
                    CD_Surname = table.Column<string>(nullable: true),
                    CD_Place = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDs", x => x.cdID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CDs");
        }
    }
}
