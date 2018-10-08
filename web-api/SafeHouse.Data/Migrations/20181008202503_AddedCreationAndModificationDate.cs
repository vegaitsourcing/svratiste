using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Data.Migrations
{
    public partial class AddedCreationAndModificationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Workshop",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "Workshop",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SuitabilityItem",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "SuitabilityItem",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SuitabilityCache",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "SuitabilityCache",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Suitabilities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "Suitabilities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SchoolActivity",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "SchoolActivity",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "SafeHouseUser",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "SafeHouseUser",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "LifeSkillDailyEntry",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "LifeSkillDailyEntry",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "LifeSkill",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "LifeSkill",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "IndividualServicePlan",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "IndividualServicePlan",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "IncludedPerson",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "IncludedPerson",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "GoalAndResult",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "GoalAndResult",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Evaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "Evaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "DailyEntry",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "DailyEntry",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Carton",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "Carton",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ActivityDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationDate",
                table: "ActivityDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SuitabilityItem");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "SuitabilityItem");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SuitabilityCache");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "SuitabilityCache");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Suitabilities");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "Suitabilities");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SchoolActivity");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "SchoolActivity");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "SafeHouseUser");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "SafeHouseUser");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "LifeSkillDailyEntry");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "LifeSkillDailyEntry");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "LifeSkill");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "LifeSkill");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "IndividualServicePlan");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "IndividualServicePlan");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "IncludedPerson");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "IncludedPerson");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "GoalAndResult");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "GoalAndResult");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "DailyEntry");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "DailyEntry");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ActivityDetails");

            migrationBuilder.DropColumn(
                name: "LastModificationDate",
                table: "ActivityDetails");
        }
    }
}
