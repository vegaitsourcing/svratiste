﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafeHouse.Infrastructure.Data;

namespace SafeHouse.Infrastructure.Migrations
{
    [DbContext(typeof(SafeHouseDbContext))]
    [Migration("20190906145028_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SafeHouse.Core.Entities.ActivityDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity")
                        .HasMaxLength(512);

                    b.Property<DateTime>("CreationDate");

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("ResponsiblePerson")
                        .HasMaxLength(32);

                    b.Property<string>("TimeLimit")
                        .HasMaxLength(32);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("ActivityDetails");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.Carton", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressStreetName")
                        .HasMaxLength(100);

                    b.Property<string>("AddressStreetNumber")
                        .HasMaxLength(32);

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<bool>("EvaluationDone");

                    b.Property<string>("FathersLastName")
                        .HasMaxLength(32);

                    b.Property<string>("FathersName")
                        .HasMaxLength(32);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("Gender");

                    b.Property<bool>("IndividualPlanDone");

                    b.Property<bool>("IndividualPlanRevised");

                    b.Property<bool>("InitialEvaluationDone");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("MothersLastName")
                        .HasMaxLength(32);

                    b.Property<string>("MothersName")
                        .HasMaxLength(32);

                    b.Property<string>("Nickname")
                        .HasMaxLength(32);

                    b.Property<bool>("NotificationsEnabled");

                    b.Property<int>("NumberOfVisits");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Cartons");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.DailyEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Arrival");

                    b.Property<bool>("Bath");

                    b.Property<Guid?>("CartonId");

                    b.Property<int>("Clothing");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Departure");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<bool>("LiecesRemoval");

                    b.Property<int>("Meal");

                    b.Property<int>("MediationSpeaking");

                    b.Property<string>("MediationSpeakingDescription");

                    b.Property<int>("MediationWriting");

                    b.Property<string>("MediationWritingDescription")
                        .HasMaxLength(512);

                    b.Property<int>("MedicalInterventions");

                    b.Property<string>("ParentsContact");

                    b.Property<bool>("PsychosocialSupport");

                    b.Property<bool>("Stay");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("DailyEntries");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.Evaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdvicedLevelOfSupport")
                        .HasMaxLength(256);

                    b.Property<int>("Age");

                    b.Property<string>("BasicPhysicalNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("BehaviorRisks")
                        .HasMaxLength(256);

                    b.Property<string>("Capabilities")
                        .HasMaxLength(512);

                    b.Property<Guid?>("CartonId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CulturalSpecifics")
                        .HasMaxLength(512);

                    b.Property<DateTime>("Date");

                    b.Property<string>("DedicatedWorker")
                        .HasMaxLength(256);

                    b.Property<string>("DominantBehaviors")
                        .HasMaxLength(512);

                    b.Property<string>("DominantEmotions")
                        .HasMaxLength(512);

                    b.Property<string>("EducationalNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("EvaluationDoneBy")
                        .HasMaxLength(256);

                    b.Property<string>("FamilyMembers")
                        .HasMaxLength(32);

                    b.Property<string>("FamilyRisks")
                        .HasMaxLength(256);

                    b.Property<string>("FamilyStrenghts")
                        .HasMaxLength(256);

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("OtherMembers")
                        .HasMaxLength(256);

                    b.Property<string>("OtherNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("OtherRisks")
                        .HasMaxLength(256);

                    b.Property<string>("OtherStrenghts")
                        .HasMaxLength(256);

                    b.Property<string>("PersonalStrenghts")
                        .HasMaxLength(256);

                    b.Property<string>("PsyhoSocialNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("SchoolStatus")
                        .HasMaxLength(32);

                    b.Property<string>("SurroundRisks")
                        .HasMaxLength(256);

                    b.Property<string>("SurroundStrenghts")
                        .HasMaxLength(256);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.FirstEvaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attitude")
                        .HasMaxLength(512);

                    b.Property<bool>("Begging");

                    b.Property<bool>("Capability");

                    b.Property<Guid?>("CartonId");

                    b.Property<string>("CaseLeaderName")
                        .HasMaxLength(512);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("DiagnosedDisease")
                        .HasMaxLength(512);

                    b.Property<string>("DirectedFromName")
                        .HasMaxLength(512);

                    b.Property<string>("DirectedToName")
                        .HasMaxLength(512);

                    b.Property<bool>("DumpsterDiving");

                    b.Property<string>("EvaluationDoneBy")
                        .HasMaxLength(512);

                    b.Property<string>("EvaluationRevisedBy")
                        .HasMaxLength(512);

                    b.Property<string>("Expectations")
                        .HasMaxLength(512);

                    b.Property<string>("Explanation")
                        .HasMaxLength(512);

                    b.Property<bool>("ExtremelyPoor");

                    b.Property<DateTime?>("FinishedEvaluation");

                    b.Property<string>("GuardiansName")
                        .HasMaxLength(512);

                    b.Property<string>("HealthCard")
                        .HasMaxLength(512);

                    b.Property<bool>("HelpingFamilyOnStreet");

                    b.Property<string>("IndividualMovementAbility")
                        .HasMaxLength(512);

                    b.Property<string>("Languages")
                        .HasMaxLength(512);

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<int>("LivingSpace");

                    b.Property<bool>("OnTheWaitingList");

                    b.Property<string>("Other")
                        .HasMaxLength(512);

                    b.Property<string>("OtherChildrenName")
                        .HasMaxLength(512);

                    b.Property<string>("OtherMembersName")
                        .HasMaxLength(512);

                    b.Property<string>("OtherSuitability")
                        .HasMaxLength(512);

                    b.Property<string>("PhysicalDescription")
                        .HasMaxLength(512);

                    b.Property<string>("PriorityNeeds")
                        .HasMaxLength(512);

                    b.Property<bool>("Prostituting");

                    b.Property<string>("SchoolAndGrade")
                        .HasMaxLength(512);

                    b.Property<bool>("SellsOnStreet");

                    b.Property<DateTime?>("ServiceStart");

                    b.Property<bool>("SleepOnStreet");

                    b.Property<DateTime?>("StartedEvaluation");

                    b.Property<string>("VerbalComunicationAbility")
                        .HasMaxLength(512);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("FirstEvaluations");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.GoalAndResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Goal")
                        .HasMaxLength(100);

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("Result")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("GoalAndResults");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.IncludedPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32);

                    b.Property<string>("Function")
                        .HasMaxLength(32);

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("LastName")
                        .HasMaxLength(32);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("IncludedPersons");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.IndividualServicePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age")
                        .HasMaxLength(8);

                    b.Property<Guid?>("CartonId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DedicatedWorker")
                        .HasMaxLength(32);

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<DateTime>("TimeLimitForNextAppointment");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("IndividualServicePlans");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.LifeSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsGroupSkill");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<int>("LifeSkillType")
                        .HasMaxLength(1024);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("LifeSkills");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.LifeSkillDailyEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<Guid?>("DailyEntryId");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<Guid?>("LifeSkillId");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryId");

                    b.HasIndex("LifeSkillId");

                    b.ToTable("LifeSkillDailyEntries");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.SafeHouseUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommonName")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("SafeHouseUsers");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.SchoolActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<Guid?>("DailyEntryId");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<int>("Type");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryId");

                    b.ToTable("SchoolActivities");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.Suitability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Suitabilities");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.SuitabilityCache", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<string>("Name")
                        .HasMaxLength(80);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("SuitabilityCaches");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.SuitabilityItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<Guid?>("SuitabilityCacheId");

                    b.Property<Guid?>("SuitabilityId");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("SuitabilityCacheId");

                    b.HasIndex("SuitabilityId");

                    b.ToTable("SuitabilityItems");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.Workshop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<Guid?>("DailyEntryId");

                    b.Property<DateTime>("LastModificationDate");

                    b.Property<int>("Number");

                    b.Property<int>("Type");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryId");

                    b.ToTable("Workshops");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.ActivityDetails", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.DailyEntry", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.Evaluation", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.FirstEvaluation", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.GoalAndResult", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.IncludedPerson", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.IndividualServicePlan", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.LifeSkillDailyEntry", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.DailyEntry", "DailyEntry")
                        .WithMany()
                        .HasForeignKey("DailyEntryId");

                    b.HasOne("SafeHouse.Core.Entities.LifeSkill", "LifeSkill")
                        .WithMany()
                        .HasForeignKey("LifeSkillId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.SchoolActivity", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.DailyEntry", "DailyEntry")
                        .WithMany()
                        .HasForeignKey("DailyEntryId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.SuitabilityItem", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.SuitabilityCache", "SuitabilityCache")
                        .WithMany()
                        .HasForeignKey("SuitabilityCacheId");

                    b.HasOne("SafeHouse.Core.Entities.Suitability")
                        .WithMany("SuitabilityItems")
                        .HasForeignKey("SuitabilityId");
                });

            modelBuilder.Entity("SafeHouse.Core.Entities.Workshop", b =>
                {
                    b.HasOne("SafeHouse.Core.Entities.DailyEntry", "DailyEntry")
                        .WithMany()
                        .HasForeignKey("DailyEntryId");
                });
#pragma warning restore 612, 618
        }
    }
}
