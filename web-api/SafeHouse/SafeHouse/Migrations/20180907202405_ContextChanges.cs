using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Migrations
{
    public partial class ContextChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdvicedLevelOfSupport",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Evaluation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BasicPhysicalNeeds",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BehaviorRisks",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Capabilities",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CaseLeader",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CulturalSpecifics",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Evaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DedicatedWorker",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DominantBehaviors",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DominantEmotions",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationalNeeds",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationDoneBy",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyMembers",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyRisks",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyStrenghts",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherMembers",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherNeeds",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherRisks",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherStrenghts",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalStrenghts",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PsyhoSocialNeeds",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolStatus",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurroundRisks",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurroundStrenghts",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IndividualServicePlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Age = table.Column<string>(nullable: true),
                    DedicatedWorker = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TimeLimitForNextAppointment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualServicePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LifeSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
                    IsGroupSkill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DailyEntryIdId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolActivity_DailyEntry_DailyEntryIdId",
                        column: x => x.DailyEntryIdId,
                        principalTable: "DailyEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuitabilityItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SuitabilityIdId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitabilityItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitabilityItem_Suitability_SuitabilityIdId",
                        column: x => x.SuitabilityIdId,
                        principalTable: "Suitability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    DailyEntryIdId = table.Column<Guid>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workshop_DailyEntry_DailyEntryIdId",
                        column: x => x.DailyEntryIdId,
                        principalTable: "DailyEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Activity = table.Column<string>(nullable: true),
                    ResponiblePerson = table.Column<string>(nullable: true),
                    TimeLimit = table.Column<string>(nullable: true),
                    IndividualServicePlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityDetails_IndividualServicePlan_IndividualServicePlanId",
                        column: x => x.IndividualServicePlanId,
                        principalTable: "IndividualServicePlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GoalAndResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Goal = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    IndividualServicePlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalAndResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoalAndResult_IndividualServicePlan_IndividualServicePlanId",
                        column: x => x.IndividualServicePlanId,
                        principalTable: "IndividualServicePlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncludedPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Function = table.Column<string>(nullable: true),
                    IndividualServicePlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncludedPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncludedPerson_IndividualServicePlan_IndividualServicePlanId",
                        column: x => x.IndividualServicePlanId,
                        principalTable: "IndividualServicePlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LifeSkillDailyEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    LifeSkillIdId = table.Column<Guid>(nullable: true),
                    DailyEntryIdId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeSkillDailyEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LifeSkillDailyEntry_DailyEntry_DailyEntryIdId",
                        column: x => x.DailyEntryIdId,
                        principalTable: "DailyEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LifeSkillDailyEntry_LifeSkills_LifeSkillIdId",
                        column: x => x.LifeSkillIdId,
                        principalTable: "LifeSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityDetails_IndividualServicePlanId",
                table: "ActivityDetails",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalAndResult_IndividualServicePlanId",
                table: "GoalAndResult",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IncludedPerson_IndividualServicePlanId",
                table: "IncludedPerson",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeSkillDailyEntry_DailyEntryIdId",
                table: "LifeSkillDailyEntry",
                column: "DailyEntryIdId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeSkillDailyEntry_LifeSkillIdId",
                table: "LifeSkillDailyEntry",
                column: "LifeSkillIdId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolActivity_DailyEntryIdId",
                table: "SchoolActivity",
                column: "DailyEntryIdId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitabilityItem_SuitabilityIdId",
                table: "SuitabilityItem",
                column: "SuitabilityIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_DailyEntryIdId",
                table: "Workshop",
                column: "DailyEntryIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityDetails");

            migrationBuilder.DropTable(
                name: "GoalAndResult");

            migrationBuilder.DropTable(
                name: "IncludedPerson");

            migrationBuilder.DropTable(
                name: "LifeSkillDailyEntry");

            migrationBuilder.DropTable(
                name: "SchoolActivity");

            migrationBuilder.DropTable(
                name: "SuitabilityItem");

            migrationBuilder.DropTable(
                name: "Workshop");

            migrationBuilder.DropTable(
                name: "IndividualServicePlan");

            migrationBuilder.DropTable(
                name: "LifeSkills");

            migrationBuilder.DropColumn(
                name: "AdvicedLevelOfSupport",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "BasicPhysicalNeeds",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "BehaviorRisks",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "Capabilities",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "CaseLeader",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "CulturalSpecifics",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "DedicatedWorker",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "DominantBehaviors",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "DominantEmotions",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "EducationalNeeds",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "EvaluationDoneBy",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "FamilyMembers",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "FamilyRisks",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "FamilyStrenghts",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "OtherMembers",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "OtherNeeds",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "OtherRisks",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "OtherStrenghts",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "PersonalStrenghts",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "PsyhoSocialNeeds",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "SchoolStatus",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "SurroundRisks",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "SurroundStrenghts",
                table: "Evaluation");
        }
    }
}
