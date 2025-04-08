using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settlement_Regions_RegionID",
                table: "Settlement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settlement",
                table: "Settlement");

            migrationBuilder.RenameTable(
                name: "Settlement",
                newName: "Settlements");

            migrationBuilder.RenameIndex(
                name: "IX_Settlement_RegionID",
                table: "Settlements",
                newName: "IX_Settlements_RegionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settlements",
                table: "Settlements",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Settlements_Regions_RegionID",
                table: "Settlements",
                column: "RegionID",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settlements_Regions_RegionID",
                table: "Settlements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settlements",
                table: "Settlements");

            migrationBuilder.RenameTable(
                name: "Settlements",
                newName: "Settlement");

            migrationBuilder.RenameIndex(
                name: "IX_Settlements_RegionID",
                table: "Settlement",
                newName: "IX_Settlement_RegionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settlement",
                table: "Settlement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Settlement_Regions_RegionID",
                table: "Settlement",
                column: "RegionID",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
