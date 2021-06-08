using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMSASP.Core.Data.Migrations
{
    public partial class _addHomepageModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderUrl1 = table.Column<string>(nullable: true),
                    SliderUrl2 = table.Column<string>(nullable: true),
                    SliderUrl3 = table.Column<string>(nullable: true),
                    Caption1 = table.Column<string>(nullable: true),
                    Caption2 = table.Column<string>(nullable: true),
                    Caption3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePage", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePage");
        }
    }
}
