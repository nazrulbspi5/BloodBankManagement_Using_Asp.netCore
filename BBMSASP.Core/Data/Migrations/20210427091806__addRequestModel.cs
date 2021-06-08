using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBMSASP.Core.Data.Migrations
{
    public partial class _addRequestModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodRequests",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: false),
                    BloodGroupId = table.Column<int>(nullable: false),
                    DivisionId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    UpazilaId = table.Column<int>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: false),
                    BloodUnit = table.Column<int>(nullable: false),
                    HospitalName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodRequests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_BloodRequests_BloodGroups_BloodGroupId",
                        column: x => x.BloodGroupId,
                        principalTable: "BloodGroups",
                        principalColumn: "BloodGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodRequests_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodRequests_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BloodRequests_Upazilas_UpazilaId",
                        column: x => x.UpazilaId,
                        principalTable: "Upazilas",
                        principalColumn: "UpazilaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodRequests_BloodGroupId",
                table: "BloodRequests",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodRequests_DistrictId",
                table: "BloodRequests",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodRequests_DivisionId",
                table: "BloodRequests",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_BloodRequests_UpazilaId",
                table: "BloodRequests",
                column: "UpazilaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodRequests");
        }
    }
}
