using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carton",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CartonNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    NumberOfVisits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SafeHouseUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CommonName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeHouseUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CartonId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Stay = table.Column<bool>(nullable: false),
                    Breakfast = table.Column<bool>(nullable: false),
                    Lunch = table.Column<bool>(nullable: false),
                    Dinner = table.Column<bool>(nullable: false),
                    Bath = table.Column<bool>(nullable: false),
                    LiecesRemoval = table.Column<bool>(nullable: false),
                    Clothing = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyEntry_Carton_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Carton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CartonId = table.Column<Guid>(nullable: true),
                    AddressStreetName = table.Column<string>(nullable: true),
                    AddressStreetNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluation_Carton_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Carton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FirstEvaluation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CartonId = table.Column<Guid>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    ParentsName = table.Column<string>(nullable: true),
                    OtherChildernName = table.Column<string>(nullable: true),
                    OtherMembersName = table.Column<string>(nullable: true),
                    AddressStreetName = table.Column<string>(nullable: true),
                    AddressStreetNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstEvaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirstEvaluation_Carton_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Carton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyEntry_CartonId",
                table: "DailyEntry",
                column: "CartonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_CartonId",
                table: "Evaluation",
                column: "CartonId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstEvaluation_CartonId",
                table: "FirstEvaluation",
                column: "CartonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyEntry");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "FirstEvaluation");

            migrationBuilder.DropTable(
                name: "SafeHouseUser");

            migrationBuilder.DropTable(
                name: "Carton");
        }
    }
}
