using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Infrastructure.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FirstName = table.Column<string>(maxLength: 32, nullable: true),
                    LastName = table.Column<string>(maxLength: 32, nullable: true),
                    FathersName = table.Column<string>(maxLength: 32, nullable: true),
                    FathersLastName = table.Column<string>(maxLength: 32, nullable: true),
                    MothersName = table.Column<string>(maxLength: 32, nullable: true),
                    MothersLastName = table.Column<string>(maxLength: 32, nullable: true),
                    Nickname = table.Column<string>(maxLength: 32, nullable: true),
                    GenderOptions = table.Column<int>(nullable: true),
                    AddressStreetName = table.Column<string>(maxLength: 100, nullable: true),
                    AddressStreetNumber = table.Column<string>(maxLength: 32, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    InitialEvaluationDone = table.Column<bool>(nullable: true),
                    EvaluationDone = table.Column<bool>(nullable: true),
                    IndividualPlanDone = table.Column<bool>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LifeSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    LifeSkillType = table.Column<int>(maxLength: 1024, nullable: false),
                    IsGroupSkill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SafeHouseUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CommonName = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafeHouseUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suitabilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suitabilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuitabilityCaches",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitabilityCaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    LastModificationDate = table.Column<DateTime>(nullable: true),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: false),
                    Gender = table.Column<int>(nullable: true),
                    Stay = table.Column<bool>(nullable: true),
                    Breakfast = table.Column<bool>(nullable: true),
                    Lunch = table.Column<bool>(nullable: true),
                    Bath = table.Column<bool>(nullable: true),
                    LiecesRemoval = table.Column<bool>(nullable: true),
                    Clothes = table.Column<int>(nullable: true),
                    MediationWriting = table.Column<int>(nullable: true),
                    MediationWritingDescription = table.Column<string>(nullable: true),
                    MediationSpeaking = table.Column<int>(nullable: true),
                    MediationSpeakingDescription = table.Column<string>(nullable: true),
                    LifeSkills = table.Column<int>(nullable: true),
                    SchoolAcivities = table.Column<int>(nullable: true),
                    PsihosocialSupport = table.Column<bool>(nullable: true),
                    ParentsContact = table.Column<int>(nullable: true),
                    MedicalInterventions = table.Column<int>(nullable: true),
                    Arrival = table.Column<DateTime>(nullable: true),
                    EducationWorkshop = table.Column<int>(nullable: true),
                    CreativeWorkshop = table.Column<int>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTIme = table.Column<DateTime>(nullable: true)
    },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyEntries_Cartons_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Cartons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    DedicatedWorker = table.Column<string>(maxLength: 256, nullable: true),
                    OtherMembers = table.Column<string>(maxLength: 256, nullable: true),
                    BasicPhysicalNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    PsyhoSocialNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    EducationalNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    OtherNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    DominantEmotions = table.Column<string>(maxLength: 512, nullable: true),
                    DominantBehaviors = table.Column<string>(maxLength: 512, nullable: true),
                    SurroundStrenghts = table.Column<string>(maxLength: 256, nullable: true),
                    FamilyStrenghts = table.Column<string>(maxLength: 256, nullable: true),
                    PersonalStrenghts = table.Column<string>(maxLength: 256, nullable: true),
                    OtherStrenghts = table.Column<string>(maxLength: 256, nullable: true),
                    SurroundRisks = table.Column<string>(maxLength: 256, nullable: true),
                    FamilyRisks = table.Column<string>(maxLength: 256, nullable: true),
                    BehaviorRisks = table.Column<string>(maxLength: 256, nullable: true),
                    OtherRisks = table.Column<string>(maxLength: 256, nullable: true),
                    Capabilities = table.Column<string>(maxLength: 512, nullable: true),
                    CulturalSpecifics = table.Column<string>(maxLength: 512, nullable: true),
                    AdvicedLevelOfSupport = table.Column<string>(maxLength: 256, nullable: true),
                    EvaluationDoneBy = table.Column<string>(maxLength: 256, nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Cartons_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Cartons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FirstEvaluations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    GuardiansName = table.Column<string>(maxLength: 512, nullable: true),
                    OtherChildrenName = table.Column<string>(maxLength: 512, nullable: true),
                    OtherMembersName = table.Column<string>(maxLength: 512, nullable: true),
                    LivingSpace = table.Column<int>(nullable: true),
                    SchoolAndGrade = table.Column<string>(maxLength: 512, nullable: true),
                    Languages = table.Column<string>(maxLength: 512, nullable: true),
                    HealthCard = table.Column<string>(maxLength: 512, nullable: true),
                    CaseLeaderName = table.Column<string>(maxLength: 512, nullable: true),
                    SleepOnStreet = table.Column<bool>(nullable: true),
                    DumpsterDiving = table.Column<bool>(nullable: true),
                    Begging = table.Column<bool>(nullable: true),
                    Prostituting = table.Column<bool>(nullable: true),
                    SellsOnStreet = table.Column<bool>(nullable: true),
                    HelpingFamilyOnStreet = table.Column<bool>(nullable: true),
                    ExtremelyPoor = table.Column<bool>(nullable: true),
                    OtherSuitability = table.Column<string>(maxLength: 512, nullable: true),
                    Explanation = table.Column<string>(maxLength: 512, nullable: true),
                    Capability = table.Column<bool>(nullable: true),
                    OnTheWaitingList = table.Column<bool>(nullable: true),
                    ServiceStart = table.Column<DateTime>(nullable: true),
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
                    StartedEvaluation = table.Column<DateTime>(nullable: true),
                    FinishedEvaluation = table.Column<DateTime>(nullable: true),
                    EvaluationDoneBy = table.Column<string>(maxLength: 512, nullable: true),
                    EvaluationRevisedBy = table.Column<string>(maxLength: 512, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirstEvaluations_Cartons_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Cartons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndividualPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    GoalsAndResults = table.Column<string>(maxLength: 1024, nullable: true),
                    ActivitiesAndDue = table.Column<string>(maxLength: 1024, nullable: true),
                    InvolvedPersons = table.Column<string>(maxLength: 1024, nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Due = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualPlans_Cartons_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Cartons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuitabilityItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    SuitabilityCacheId = table.Column<Guid>(nullable: true),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
                    SuitabilityId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuitabilityItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuitabilityItems_SuitabilityCaches_SuitabilityCacheId",
                        column: x => x.SuitabilityCacheId,
                        principalTable: "SuitabilityCaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuitabilityItems_Suitabilities_SuitabilityId",
                        column: x => x.SuitabilityId,
                        principalTable: "Suitabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LifeSkillDailyEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    LifeSkillId = table.Column<Guid>(nullable: true),
                    DailyEntryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeSkillDailyEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LifeSkillDailyEntries_DailyEntries_DailyEntryId",
                        column: x => x.DailyEntryId,
                        principalTable: "DailyEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LifeSkillDailyEntries_LifeSkills_LifeSkillId",
                        column: x => x.LifeSkillId,
                        principalTable: "LifeSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DailyEntryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolActivities_DailyEntries_DailyEntryId",
                        column: x => x.DailyEntryId,
                        principalTable: "DailyEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Type = table.Column<int>(nullable: false),
                    DailyEntryId = table.Column<Guid>(nullable: true),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workshops_DailyEntries_DailyEntryId",
                        column: x => x.DailyEntryId,
                        principalTable: "DailyEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivityDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Activity = table.Column<string>(maxLength: 512, nullable: true),
                    ResponsiblePerson = table.Column<string>(maxLength: 32, nullable: true),
                    TimeLimit = table.Column<string>(maxLength: 32, nullable: true),
                    IndividualPlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityDetails_IndividualPlans_IndividualePlanId",
                        column: x => x.IndividualPlanId,
                        principalTable: "IndividualPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GoalAndResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Goal = table.Column<string>(maxLength: 100, nullable: true),
                    Result = table.Column<string>(maxLength: 100, nullable: true),
                    IndividualPlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalAndResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoalAndResults_IndividualPlans_IndividualPlanId",
                        column: x => x.IndividualPlanId,
                        principalTable: "IndividualPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncludedPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    FirstName = table.Column<string>(maxLength: 32, nullable: true),
                    LastName = table.Column<string>(maxLength: 32, nullable: true),
                    Function = table.Column<string>(maxLength: 32, nullable: true),
                    IndividualPlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncludedPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncludedPersons_IndividuaPlans_IndividualPlanId",
                        column: x => x.IndividualPlanId,
                        principalTable: "IndividualPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityDetails_IndividualPlanId",
                table: "ActivityDetails",
                column: "IndividualPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyEntries_CartonId",
                table: "DailyEntries",
                column: "CartonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_CartonId",
                table: "Evaluations",
                column: "CartonId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstEvaluations_CartonId",
                table: "FirstEvaluations",
                column: "CartonId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalAndResults_IndividualPlanId",
                table: "GoalAndResults",
                column: "IndividualPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IncludedPersons_IndividualPlanId",
                table: "IncludedPersons",
                column: "IndividualPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualPlans_CartonId",
                table: "IndividualPlans",
                column: "CartonId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeSkillDailyEntries_DailyEntryId",
                table: "LifeSkillDailyEntries",
                column: "DailyEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_LifeSkillDailyEntries_LifeSkillId",
                table: "LifeSkillDailyEntries",
                column: "LifeSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolActivities_DailyEntryId",
                table: "SchoolActivities",
                column: "DailyEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitabilityItems_SuitabilityCacheId",
                table: "SuitabilityItems",
                column: "SuitabilityCacheId");

            migrationBuilder.CreateIndex(
                name: "IX_SuitabilityItems_SuitabilityId",
                table: "SuitabilityItems",
                column: "SuitabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshops_DailyEntryId",
                table: "Workshops",
                column: "DailyEntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityDetails");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "FirstEvaluations");

            migrationBuilder.DropTable(
                name: "GoalAndResults");

            migrationBuilder.DropTable(
                name: "IncludedPersons");

            migrationBuilder.DropTable(
                name: "LifeSkillDailyEntries");

            migrationBuilder.DropTable(
                name: "SafeHouseUsers");

            migrationBuilder.DropTable(
                name: "SchoolActivities");

            migrationBuilder.DropTable(
                name: "SuitabilityItems");

            migrationBuilder.DropTable(
                name: "Workshops");

            migrationBuilder.DropTable(
                name: "IndividualPlans");

            migrationBuilder.DropTable(
                name: "LifeSkills");

            migrationBuilder.DropTable(
                name: "SuitabilityCaches");

            migrationBuilder.DropTable(
                name: "Suitabilities");

            migrationBuilder.DropTable(
                name: "DailyEntries");

            migrationBuilder.DropTable(
                name: "Cartons");
        }
    }
}
