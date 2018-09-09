using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Data.Migrations
{
    public partial class SmallRenaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstEvaluation_Suitabilities_SuitabilityIdId",
                table: "FirstEvaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_SuitabilityItem_SuitabilityCache_NameId",
                table: "SuitabilityItem");

            migrationBuilder.RenameColumn(
                name: "NameId",
                table: "SuitabilityItem",
                newName: "SuitabilityCacheId");

            migrationBuilder.RenameIndex(
                name: "IX_SuitabilityItem_NameId",
                table: "SuitabilityItem",
                newName: "IX_SuitabilityItem_SuitabilityCacheId");

            migrationBuilder.RenameColumn(
                name: "SuitabilityIdId",
                table: "FirstEvaluation",
                newName: "SuitabilityId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstEvaluation_SuitabilityIdId",
                table: "FirstEvaluation",
                newName: "IX_FirstEvaluation_SuitabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstEvaluation_Suitabilities_SuitabilityId",
                table: "FirstEvaluation",
                column: "SuitabilityId",
                principalTable: "Suitabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuitabilityItem_SuitabilityCache_SuitabilityCacheId",
                table: "SuitabilityItem",
                column: "SuitabilityCacheId",
                principalTable: "SuitabilityCache",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstEvaluation_Suitabilities_SuitabilityId",
                table: "FirstEvaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_SuitabilityItem_SuitabilityCache_SuitabilityCacheId",
                table: "SuitabilityItem");

            migrationBuilder.RenameColumn(
                name: "SuitabilityCacheId",
                table: "SuitabilityItem",
                newName: "NameId");

            migrationBuilder.RenameIndex(
                name: "IX_SuitabilityItem_SuitabilityCacheId",
                table: "SuitabilityItem",
                newName: "IX_SuitabilityItem_NameId");

            migrationBuilder.RenameColumn(
                name: "SuitabilityId",
                table: "FirstEvaluation",
                newName: "SuitabilityIdId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstEvaluation_SuitabilityId",
                table: "FirstEvaluation",
                newName: "IX_FirstEvaluation_SuitabilityIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstEvaluation_Suitabilities_SuitabilityIdId",
                table: "FirstEvaluation",
                column: "SuitabilityIdId",
                principalTable: "Suitabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuitabilityItem_SuitabilityCache_NameId",
                table: "SuitabilityItem",
                column: "NameId",
                principalTable: "SuitabilityCache",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
