using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Migrations
{
    public partial class MajorModelUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressStreetName",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "AddressStreetNumber",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "ParentsName",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "FatherLastName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "FathersFirstName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "MothersFirstName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "MothersLastName",
                table: "Carton");

            migrationBuilder.AlterColumn<string>(
                name: "OtherMembersName",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherChildernName",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attitude",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Capability",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CaseLeaderName",
                table: "FirstEvaluation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosedDisease",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectedFromName",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectedToName",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationDoneBy",
                table: "FirstEvaluation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvaluationRevisedBy",
                table: "FirstEvaluation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Expectations",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishedEvaluation",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GuardiansName",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HealthCard",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IndividualMovementAbility",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "FirstEvaluation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LivingSpace",
                table: "FirstEvaluation",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OnTheWaitingList",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalDescription",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriorityNeeds",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolAndGrade",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ServiceStart",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedEvaluation",
                table: "FirstEvaluation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "SuitabilityIdId",
                table: "FirstEvaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VerbalComunicationAbility",
                table: "FirstEvaluation",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "FirstEvaluation",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Evaluation",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "DailyEntry",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Carton",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Carton",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressStreetNumber",
                table: "Carton",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressStreetName",
                table: "Carton",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Carton",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersName",
                table: "Carton",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "Carton",
                maxLength: 32,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Carton",
                rowVersion: true,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Suitability",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suitability", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FirstEvaluation_SuitabilityIdId",
                table: "FirstEvaluation",
                column: "SuitabilityIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstEvaluation_Suitability_SuitabilityIdId",
                table: "FirstEvaluation",
                column: "SuitabilityIdId",
                principalTable: "Suitability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstEvaluation_Suitability_SuitabilityIdId",
                table: "FirstEvaluation");

            migrationBuilder.DropTable(
                name: "Suitability");

            migrationBuilder.DropIndex(
                name: "IX_FirstEvaluation_SuitabilityIdId",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Attitude",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Capability",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "CaseLeaderName",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "DiagnosedDisease",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "DirectedFromName",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "DirectedToName",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "EvaluationDoneBy",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "EvaluationRevisedBy",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Expectations",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "FinishedEvaluation",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "GuardiansName",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "HealthCard",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "IndividualMovementAbility",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "LivingSpace",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "OnTheWaitingList",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "PhysicalDescription",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "PriorityNeeds",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "SchoolAndGrade",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "ServiceStart",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "StartedEvaluation",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "SuitabilityIdId",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "VerbalComunicationAbility",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "FirstEvaluation");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "DailyEntry");

            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "MothersName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Carton");

            migrationBuilder.AlterColumn<string>(
                name: "OtherMembersName",
                table: "FirstEvaluation",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherChildernName",
                table: "FirstEvaluation",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressStreetName",
                table: "FirstEvaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressStreetNumber",
                table: "FirstEvaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "FirstEvaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentsName",
                table: "FirstEvaluation",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Carton",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Carton",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "AddressStreetNumber",
                table: "Carton",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressStreetName",
                table: "Carton",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherLastName",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersFirstName",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersFirstName",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersLastName",
                table: "Carton",
                nullable: true);
        }
    }
}
