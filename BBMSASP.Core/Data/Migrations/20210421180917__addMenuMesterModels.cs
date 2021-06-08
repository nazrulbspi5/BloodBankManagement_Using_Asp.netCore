using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMSASP.Core.Data.Migrations
{
    public partial class _addMenuMesterModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuMasters",
                columns: table => new
                {
                    MenuIdentity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: true),
                    Parent_MenuID = table.Column<string>(nullable: true),
                    User_Roll = table.Column<string>(nullable: true),
                    MenuFileName = table.Column<string>(nullable: true),
                    MenuURL = table.Column<string>(nullable: true),
                    USE_YN = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMasters", x => x.MenuIdentity);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuMasters");
        }
    }
}
