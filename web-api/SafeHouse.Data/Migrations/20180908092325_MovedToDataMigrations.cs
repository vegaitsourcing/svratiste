using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Data.Migrations
{
    public partial class MovedToDataMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carton",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FirstName = table.Column<string>(maxLength: 32, nullable: false),
                    LastName = table.Column<string>(maxLength: 32, nullable: false),
                    Nickname = table.Column<string>(maxLength: 32, nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    NumberOfVisits = table.Column<int>(nullable: false),
                    AddressStreetName = table.Column<string>(maxLength: 100, nullable: true),
                    AddressStreetNumber = table.Column<string>(maxLength: 32, nullable: true),
                    FathersName = table.Column<string>(maxLength: 32, nullable: true),
                    MothersName = table.Column<string>(maxLength: 32, nullable: true),
                    InitialEvaluationDone = table.Column<bool>(nullable: false),
                    EvaluationDone = table.Column<bool>(nullable: false),
                    IndividualPlanDone = table.Column<bool>(nullable: false),
                    IndividualPlanRevised = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualServicePlan",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Age = table.Column<string>(maxLength: 8, nullable: true),
                    DedicatedWorker = table.Column<string>(maxLength: 32, nullable: true),
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
                name: "SafeHouseUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CommonName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeHouseUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suitability",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suitability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyEntry",
                columns: table => new
                {
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    CartonId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Stay = table.Column<bool>(nullable: false),
                    Meal = table.Column<int>(nullable: false),
                    Bath = table.Column<bool>(nullable: false),
                    LiecesRemoval = table.Column<bool>(nullable: false),
                    Clothing = table.Column<int>(nullable: false),
                    MediationWriting = table.Column<int>(nullable: false),
                    MediationSpeaking = table.Column<int>(nullable: false),
                    PsihosocialSupport = table.Column<bool>(nullable: false),
                    ParentsContact = table.Column<int>(nullable: false),
                    MedicalInterventions = table.Column<int>(nullable: false),
                    Arrival = table.Column<DateTime>(nullable: false),
                    Departure = table.Column<DateTime>(nullable: false)
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
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    FamilyMembers = table.Column<string>(maxLength: 32, nullable: true),
                    SchoolStatus = table.Column<string>(maxLength: 32, nullable: true),
                    CaseLeader = table.Column<string>(maxLength: 32, nullable: true),
                    DedicatedWorker = table.Column<string>(maxLength: 32, nullable: true),
                    OtherMembers = table.Column<string>(maxLength: 512, nullable: true),
                    BasicPhysicalNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    PsyhoSocialNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    EducationalNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    OtherNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    DominantEmotions = table.Column<string>(maxLength: 512, nullable: true),
                    DominantBehaviors = table.Column<string>(maxLength: 512, nullable: true),
                    SurroundStrenghts = table.Column<string>(maxLength: 512, nullable: true),
                    FamilyStrenghts = table.Column<string>(maxLength: 512, nullable: true),
                    PersonalStrenghts = table.Column<string>(maxLength: 512, nullable: true),
                    OtherStrenghts = table.Column<string>(maxLength: 512, nullable: true),
                    SurroundRisks = table.Column<string>(maxLength: 512, nullable: true),
                    FamilyRisks = table.Column<string>(maxLength: 512, nullable: true),
                    BehaviorRisks = table.Column<string>(maxLength: 512, nullable: true),
                    OtherRisks = table.Column<string>(maxLength: 512, nullable: true),
                    Capabilities = table.Column<string>(maxLength: 512, nullable: true),
                    CulturalSpecifics = table.Column<string>(maxLength: 512, nullable: true),
                    AdvicedLevelOfSupport = table.Column<string>(maxLength: 512, nullable: true),
                    EvaluationDoneBy = table.Column<string>(maxLength: 512, nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
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
                name: "ActivityDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Activity = table.Column<string>(maxLength: 512, nullable: true),
                    ResponiblePerson = table.Column<string>(maxLength: 32, nullable: true),
                    TimeLimit = table.Column<string>(maxLength: 32, nullable: true),
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
                    Goal = table.Column<string>(maxLength: 100, nullable: true),
                    Result = table.Column<string>(maxLength: 100, nullable: true),
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
                    FirstName = table.Column<string>(maxLength: 32, nullable: true),
                    LastName = table.Column<string>(maxLength: 32, nullable: true),
                    Function = table.Column<string>(maxLength: 32, nullable: true),
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
                name: "FirstEvaluation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    OtherChildernName = table.Column<string>(maxLength: 512, nullable: true),
                    OtherMembersName = table.Column<string>(maxLength: 512, nullable: true),
                    GuardiansName = table.Column<string>(maxLength: 512, nullable: true),
                    LivingSpace = table.Column<string>(maxLength: 128, nullable: true),
                    SchoolAndGrade = table.Column<string>(maxLength: 512, nullable: true),
                    Languages = table.Column<string>(maxLength: 256, nullable: true),
                    HealthCard = table.Column<bool>(nullable: false),
                    CaseLeaderName = table.Column<string>(maxLength: 256, nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    SuitabilityIdId = table.Column<Guid>(nullable: true),
                    Capability = table.Column<bool>(nullable: false),
                    OnTheWaitingList = table.Column<bool>(nullable: false),
                    ServiceStart = table.Column<DateTime>(nullable: false),
                    DirectedToName = table.Column<string>(maxLength: 512, nullable: true),
                    IndividualMovementAbility = table.Column<string>(maxLength: 512, nullable: true),
                    VerbalComunicationAbility = table.Column<string>(maxLength: 512, nullable: true),
                    PhysicalDescription = table.Column<string>(maxLength: 512, nullable: true),
                    DiagnosedDisease = table.Column<string>(maxLength: 512, nullable: true),
                    PriorityNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    Attitude = table.Column<string>(maxLength: 512, nullable: true),
                    Expectations = table.Column<string>(maxLength: 512, nullable: true),
                    DirectedFromName = table.Column<string>(maxLength: 512, nullable: true),
                    Other = table.Column<string>(maxLength: 512, nullable: true),
                    StartedEvaluation = table.Column<DateTime>(nullable: false),
                    FinishedEvaluation = table.Column<DateTime>(nullable: false),
                    EvaluationDoneBy = table.Column<string>(maxLength: 256, nullable: true),
                    EvaluationRevisedBy = table.Column<string>(maxLength: 256, nullable: true)
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
                    table.ForeignKey(
                        name: "FK_FirstEvaluation_Suitability_SuitabilityIdId",
                        column: x => x.SuitabilityIdId,
                        principalTable: "Suitability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuitabilityItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    SuitabilityId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitabilityItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitabilityItem_Suitability_SuitabilityId",
                        column: x => x.SuitabilityId,
                        principalTable: "Suitability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LifeSkillDailyEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    LifeSkillId = table.Column<Guid>(nullable: true),
                    DailyEntryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeSkillDailyEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LifeSkillDailyEntry_DailyEntry_DailyEntryId",
                        column: x => x.DailyEntryId,
                        principalTable: "DailyEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LifeSkillDailyEntry_LifeSkills_LifeSkillId",
                        column: x => x.LifeSkillId,
                        principalTable: "LifeSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DailyEntryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolActivity_DailyEntry_DailyEntryId",
                        column: x => x.DailyEntryId,
                        principalTable: "DailyEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DailyEntryId = table.Column<Guid>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workshop_DailyEntry_DailyEntryId",
                        column: x => x.DailyEntryId,
                        principalTable: "DailyEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityDetails_IndividualServicePlanId",
                table: "ActivityDetails",
                column: "IndividualServicePlanId");

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

            migrationBuilder.CreateIndex(
                name: "IX_FirstEvaluation_SuitabilityIdId",
                table: "FirstEvaluation",
                column: "SuitabilityIdId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalAndResult_IndividualServicePlanId",
                table: "GoalAndResult",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IncludedPerson_IndividualServicePlanId",
                table: "IncludedPerson",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeSkillDailyEntry_DailyEntryId",
                table: "LifeSkillDailyEntry",
                column: "DailyEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeSkillDailyEntry_LifeSkillId",
                table: "LifeSkillDailyEntry",
                column: "LifeSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolActivity_DailyEntryId",
                table: "SchoolActivity",
                column: "DailyEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitabilityItem_SuitabilityId",
                table: "SuitabilityItem",
                column: "SuitabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_DailyEntryId",
                table: "Workshop",
                column: "DailyEntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityDetails");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "FirstEvaluation");

            migrationBuilder.DropTable(
                name: "GoalAndResult");

            migrationBuilder.DropTable(
                name: "IncludedPerson");

            migrationBuilder.DropTable(
                name: "LifeSkillDailyEntry");

            migrationBuilder.DropTable(
                name: "SafeHouseUser");

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

            migrationBuilder.DropTable(
                name: "Suitability");

            migrationBuilder.DropTable(
                name: "DailyEntry");

            migrationBuilder.DropTable(
                name: "Carton");
        }
    }
}
