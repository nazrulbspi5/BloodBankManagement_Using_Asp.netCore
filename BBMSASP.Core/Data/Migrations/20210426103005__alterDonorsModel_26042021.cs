using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMSASP.Core.Data.Migrations
{
    public partial class _alterDonorsModel_26042021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropColumn(
                name: "Division",
                table: "Donors");

            migrationBuilder.DropColumn(
               name: "District",
               table: "Donors");

            migrationBuilder.DropColumn(
                name: "Upazila",
                table: "Donors");

            migrationBuilder.AddColumn<int>(
               name: "DivisionId",
               table: "Donors",
               nullable: false,
               defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Donors",
                nullable: false,
                defaultValue: 0);


            migrationBuilder.AddColumn<int>(
                name: "UpazilaId",
                table: "Donors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Donors_DivisionId",
                table: "Donors",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_DistrictId",
                table: "Donors",
                column: "DistrictId");


            migrationBuilder.CreateIndex(
                name: "IX_Donors_UpazilaId",
                table: "Donors",
                column: "UpazilaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Divisions_DivisionId",
                table: "Donors",
                column: "DivisionId",
                principalTable: "Divisions",
                principalColumn: "DivisionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Districts_DistrictId",
                table: "Donors",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.NoAction);

            

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Upazilas_UpazilaId",
                table: "Donors",
                column: "UpazilaId",
                principalTable: "Upazilas",
                principalColumn: "UpazilaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Divisions_DivisionId",
                table: "Donors");

            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Districts_DistrictId",
                table: "Donors");

            

            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Upazilas_UpazilaId",
                table: "Donors");
            migrationBuilder.DropIndex(
               name: "IX_Donors_DivisionId",
               table: "Donors");


            migrationBuilder.DropIndex(
                name: "IX_Donors_DistrictId",
                table: "Donors");

           
            migrationBuilder.DropIndex(
                name: "IX_Donors_UpazilaId",
                table: "Donors");

            migrationBuilder.DropColumn(
               name: "DivisionId",
               table: "Donors");
            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Donors");

           

            migrationBuilder.DropColumn(
                name: "UpazilaId",
                table: "Donors");

            migrationBuilder.AddColumn<int>(
                name: "District",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Division",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Upazila",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
