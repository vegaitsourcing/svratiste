﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
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
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Stay = table.Column<bool>(nullable: false),
                    Meal = table.Column<int>(nullable: false),
                    Bath = table.Column<bool>(nullable: false),
                    LiecesRemoval = table.Column<bool>(nullable: false),
                    Clothing = table.Column<int>(nullable: false),
                    MediationWriting = table.Column<int>(nullable: false),
                    MediationWritingDescription = table.Column<string>(maxLength: 512, nullable: true),
                    MediationSpeaking = table.Column<int>(nullable: false),
                    MediationSpeakingDescription = table.Column<string>(nullable: true),
                    PsychosocialSupport = table.Column<bool>(nullable: false),
                    ParentsContact = table.Column<string>(nullable: true),
                    MedicalInterventions = table.Column<int>(nullable: false),
                    Arrival = table.Column<DateTime>(nullable: false),
                    Departure = table.Column<DateTime>(nullable: false)
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
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluations_Cartons_CartonId",
                        column: x => x.CartonId,
                        principalTable: "Cartons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndividualServicePlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModificationDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CartonId = table.Column<Guid>(nullable: true),
                    Age = table.Column<string>(maxLength: 8, nullable: true),
                    DedicatedWorker = table.Column<string>(maxLength: 32, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TimeLimitForNextAppointment = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualServicePlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndividualServicePlans_Cartons_CartonId",
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
                    OtherChildrenName = table.Column<string>(maxLength: 512, nullable: true),
                    OtherMembersName = table.Column<string>(maxLength: 512, nullable: true),
                    GuardiansName = table.Column<string>(maxLength: 512, nullable: true),
                    LivingSpace = table.Column<int>(nullable: false),
                    SchoolAndGrade = table.Column<string>(maxLength: 512, nullable: true),
                    Languages = table.Column<string>(maxLength: 256, nullable: true),
                    HealthCard = table.Column<bool>(nullable: false),
                    CaseLeaderName = table.Column<string>(maxLength: 256, nullable: true),
                    SuitabilityId = table.Column<Guid>(nullable: true),
                    Capability = table.Column<bool>(nullable: false),
                    OnTheWaitingList = table.Column<bool>(nullable: false),
                    ServiceStart = table.Column<DateTime>(nullable: false),
                    DirectedToName = table.Column<string>(maxLength: 512, nullable: true),
                    IndividualMovementAbility = table.Column<int>(nullable: false),
                    VerbalCommunicationAbility = table.Column<string>(maxLength: 512, nullable: true),
                    PhysicalDescription = table.Column<string>(maxLength: 512, nullable: true),
                    DiagnosedDisease = table.Column<string>(maxLength: 512, nullable: true),
                    PriorityNeeds = table.Column<string>(maxLength: 512, nullable: true),
                    Attitude = table.Column<string>(maxLength: 512, nullable: true),
                    Expectations = table.Column<string>(maxLength: 512, nullable: true),
                    DirectedFromName = table.Column<string>(maxLength: 512, nullable: true),
                    Other = table.Column<string>(maxLength: 512, nullable: true),
                    StartedEvaluation = table.Column<DateTime>(nullable: true),
                    FinishedEvaluation = table.Column<DateTime>(nullable: true),
                    EvaluationDoneBy = table.Column<string>(maxLength: 256, nullable: true),
                    EvaluationRevisedBy = table.Column<string>(maxLength: 256, nullable: true)
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
                    table.ForeignKey(
                        name: "FK_FirstEvaluations_Suitabilities_SuitabilityId",
                        column: x => x.SuitabilityId,
                        principalTable: "Suitabilities",
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
                    IndividualServicePlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityDetails_IndividualServicePlans_IndividualServicePlanId",
                        column: x => x.IndividualServicePlanId,
                        principalTable: "IndividualServicePlans",
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
                    IndividualServicePlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalAndResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoalAndResults_IndividualServicePlans_IndividualServicePlanId",
                        column: x => x.IndividualServicePlanId,
                        principalTable: "IndividualServicePlans",
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
                    IndividualServicePlanId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncludedPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncludedPersons_IndividualServicePlans_IndividualServicePlanId",
                        column: x => x.IndividualServicePlanId,
                        principalTable: "IndividualServicePlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityDetails_IndividualServicePlanId",
                table: "ActivityDetails",
                column: "IndividualServicePlanId");

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
                name: "IX_FirstEvaluations_SuitabilityId",
                table: "FirstEvaluations",
                column: "SuitabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalAndResults_IndividualServicePlanId",
                table: "GoalAndResults",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IncludedPersons_IndividualServicePlanId",
                table: "IncludedPersons",
                column: "IndividualServicePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualServicePlans_CartonId",
                table: "IndividualServicePlans",
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
                name: "IndividualServicePlans");

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
