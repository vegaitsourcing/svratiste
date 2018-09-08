using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Data.Migrations
{
    public partial class NamingConsistencyMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstEvaluation_Suitability_SuitabilityIdId",
                table: "FirstEvaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_LifeSkillDailyEntry_LifeSkills_LifeSkillId",
                table: "LifeSkillDailyEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_SuitabilityItem_Suitability_SuitabilityId",
                table: "SuitabilityItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suitability",
                table: "Suitability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LifeSkills",
                table: "LifeSkills");

            migrationBuilder.RenameTable(
                name: "Suitability",
                newName: "Suitabilities");

            migrationBuilder.RenameTable(
                name: "LifeSkills",
                newName: "LifeSkill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suitabilities",
                table: "Suitabilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LifeSkill",
                table: "LifeSkill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstEvaluation_Suitabilities_SuitabilityIdId",
                table: "FirstEvaluation",
                column: "SuitabilityIdId",
                principalTable: "Suitabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LifeSkillDailyEntry_LifeSkill_LifeSkillId",
                table: "LifeSkillDailyEntry",
                column: "LifeSkillId",
                principalTable: "LifeSkill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuitabilityItem_Suitabilities_SuitabilityId",
                table: "SuitabilityItem",
                column: "SuitabilityId",
                principalTable: "Suitabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstEvaluation_Suitabilities_SuitabilityIdId",
                table: "FirstEvaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_LifeSkillDailyEntry_LifeSkill_LifeSkillId",
                table: "LifeSkillDailyEntry");

            migrationBuilder.DropForeignKey(
                name: "FK_SuitabilityItem_Suitabilities_SuitabilityId",
                table: "SuitabilityItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suitabilities",
                table: "Suitabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LifeSkill",
                table: "LifeSkill");

            migrationBuilder.RenameTable(
                name: "Suitabilities",
                newName: "Suitability");

            migrationBuilder.RenameTable(
                name: "LifeSkill",
                newName: "LifeSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suitability",
                table: "Suitability",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LifeSkills",
                table: "LifeSkills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstEvaluation_Suitability_SuitabilityIdId",
                table: "FirstEvaluation",
                column: "SuitabilityIdId",
                principalTable: "Suitability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LifeSkillDailyEntry_LifeSkills_LifeSkillId",
                table: "LifeSkillDailyEntry",
                column: "LifeSkillId",
                principalTable: "LifeSkills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuitabilityItem_Suitability_SuitabilityId",
                table: "SuitabilityItem",
                column: "SuitabilityId",
                principalTable: "Suitability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
