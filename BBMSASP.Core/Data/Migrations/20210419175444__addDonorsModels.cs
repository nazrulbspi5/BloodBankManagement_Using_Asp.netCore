using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMSASP.Core.Data.Migrations
{
    public partial class _addDonorsModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    DonorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    BloodGroupId = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false),
                    LastDonationDate = table.Column<DateTime>(nullable: false),
                    Division = table.Column<int>(nullable: false),
                    District = table.Column<int>(nullable: false),
                    Upazila = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.DonorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donors");
        }
    }
}
