using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMSASP.Core.Data.Migrations
{
    public partial class _updateDonorsModel26042021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Donors_BloodGroupId",
                table: "Donors",
                column: "BloodGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_BloodGroups_BloodGroupId",
                table: "Donors",
                column: "BloodGroupId",
                principalTable: "BloodGroups",
                principalColumn: "BloodGroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donors_BloodGroups_BloodGroupId",
                table: "Donors");

            migrationBuilder.DropIndex(
                name: "IX_Donors_BloodGroupId",
                table: "Donors");
        }
    }
}
