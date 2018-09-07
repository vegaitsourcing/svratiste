using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Migrations
{
    public partial class CartonModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressStreetName",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "AddressStreetNumber",
                table: "Evaluation");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Carton");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Carton",
                newName: "MothersLastName");

            migrationBuilder.RenameColumn(
                name: "CartonNumber",
                table: "Carton",
                newName: "MothersFirstName");

            migrationBuilder.AddColumn<string>(
                name: "AddressStreetName",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressStreetNumber",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Carton",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "EvaluationDone",
                table: "Carton",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FatherLastName",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersFirstName",
                table: "Carton",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IndividualPlanDone",
                table: "Carton",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IndividualPlanRevised",
                table: "Carton",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InitialEvaluationDone",
                table: "Carton",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressStreetName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "AddressStreetNumber",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "EvaluationDone",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "FatherLastName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "FathersFirstName",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "IndividualPlanDone",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "IndividualPlanRevised",
                table: "Carton");

            migrationBuilder.DropColumn(
                name: "InitialEvaluationDone",
                table: "Carton");

            migrationBuilder.RenameColumn(
                name: "MothersLastName",
                table: "Carton",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "MothersFirstName",
                table: "Carton",
                newName: "CartonNumber");

            migrationBuilder.AddColumn<string>(
                name: "AddressStreetName",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressStreetNumber",
                table: "Evaluation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Carton",
                nullable: false,
                defaultValue: 0);
        }
    }
}
