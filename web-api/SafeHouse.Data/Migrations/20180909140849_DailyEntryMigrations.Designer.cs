﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafeHouse.Data;

namespace SafeHouse.Data.Migrations
{
    [DbContext(typeof(SafeHouseContext))]
    [Migration("20180909140849_DailyEntryMigrations")]
    partial class DailyEntryMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SafeHouse.Data.Entities.ActivityDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity")
                        .HasMaxLength(512);

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<string>("ResponiblePerson")
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

            modelBuilder.Entity("SafeHouse.Data.Entities.Carton", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressStreetName")
                        .HasMaxLength(100);

                    b.Property<string>("AddressStreetNumber")
                        .HasMaxLength(32);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<bool>("EvaluationDone");

                    b.Property<string>("FathersName")
                        .HasMaxLength(32);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int>("Gender");

                    b.Property<bool>("IndividualPlanDone");

                    b.Property<bool>("IndividualPlanRevised");

                    b.Property<bool>("InitialEvaluationDone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("MothersName")
                        .HasMaxLength(32);

                    b.Property<string>("Nickname")
                        .HasMaxLength(32);

                    b.Property<int>("NumberOfVisits");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Carton");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.DailyEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Arrival");

                    b.Property<bool>("Bath");

                    b.Property<Guid?>("CartonId");

                    b.Property<int>("Clothing");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Departure");

                    b.Property<bool>("LiecesRemoval");

                    b.Property<int>("Meal");

                    b.Property<int>("MediationSpeaking");

                    b.Property<string>("MediationSpeakingDescription");

                    b.Property<int>("MediationWriting");

                    b.Property<string>("MediationWritingDescription")
                        .HasMaxLength(512);

                    b.Property<int>("MedicalInterventions");

                    b.Property<string>("ParentsContact");

                    b.Property<bool>("PsihosocialSupport");

                    b.Property<bool>("Stay");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("DailyEntry");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.Evaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdvicedLevelOfSupport")
                        .HasMaxLength(512);

                    b.Property<int>("Age");

                    b.Property<string>("BasicPhysicalNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("BehaviorRisks")
                        .HasMaxLength(512);

                    b.Property<string>("Capabilities")
                        .HasMaxLength(512);

                    b.Property<Guid?>("CartonId");

                    b.Property<string>("CaseLeader")
                        .HasMaxLength(32);

                    b.Property<string>("CulturalSpecifics")
                        .HasMaxLength(512);

                    b.Property<DateTime>("Date");

                    b.Property<string>("DedicatedWorker")
                        .HasMaxLength(32);

                    b.Property<string>("DominantBehaviors")
                        .HasMaxLength(512);

                    b.Property<string>("DominantEmotions")
                        .HasMaxLength(512);

                    b.Property<string>("EducationalNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("EvaluationDoneBy")
                        .HasMaxLength(512);

                    b.Property<string>("FamilyMembers")
                        .HasMaxLength(32);

                    b.Property<string>("FamilyRisks")
                        .HasMaxLength(512);

                    b.Property<string>("FamilyStrenghts")
                        .HasMaxLength(512);

                    b.Property<string>("OtherMembers")
                        .HasMaxLength(512);

                    b.Property<string>("OtherNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("OtherRisks")
                        .HasMaxLength(512);

                    b.Property<string>("OtherStrenghts")
                        .HasMaxLength(512);

                    b.Property<string>("PersonalStrenghts")
                        .HasMaxLength(512);

                    b.Property<string>("PsyhoSocialNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("SchoolStatus")
                        .HasMaxLength(32);

                    b.Property<string>("SurroundRisks")
                        .HasMaxLength(512);

                    b.Property<string>("SurroundStrenghts")
                        .HasMaxLength(512);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.FirstEvaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attitude")
                        .HasMaxLength(512);

                    b.Property<bool>("Capability");

                    b.Property<Guid?>("CartonId");

                    b.Property<string>("CaseLeaderName")
                        .HasMaxLength(256);

                    b.Property<string>("DiagnosedDisease")
                        .HasMaxLength(512);

                    b.Property<string>("DirectedFromName")
                        .HasMaxLength(512);

                    b.Property<string>("DirectedToName")
                        .HasMaxLength(512);

                    b.Property<string>("EvaluationDoneBy")
                        .HasMaxLength(256);

                    b.Property<string>("EvaluationRevisedBy")
                        .HasMaxLength(256);

                    b.Property<string>("Expectations")
                        .HasMaxLength(512);

                    b.Property<DateTime>("FinishedEvaluation");

                    b.Property<string>("GuardiansName")
                        .HasMaxLength(512);

                    b.Property<bool>("HealthCard");

                    b.Property<string>("IndividualMovementAbility")
                        .HasMaxLength(512);

                    b.Property<string>("Languages")
                        .HasMaxLength(256);

                    b.Property<string>("LivingSpace")
                        .HasMaxLength(128);

                    b.Property<bool>("OnTheWaitingList");

                    b.Property<string>("Other")
                        .HasMaxLength(512);

                    b.Property<string>("OtherChildernName")
                        .HasMaxLength(512);

                    b.Property<string>("OtherMembersName")
                        .HasMaxLength(512);

                    b.Property<string>("PhysicalDescription")
                        .HasMaxLength(512);

                    b.Property<string>("PriorityNeeds")
                        .HasMaxLength(512);

                    b.Property<string>("SchoolAndGrade")
                        .HasMaxLength(512);

                    b.Property<DateTime>("ServiceStart");

                    b.Property<DateTime>("StartedEvaluation");

                    b.Property<Guid?>("SuitabilityId");

                    b.Property<string>("VerbalComunicationAbility")
                        .HasMaxLength(512);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.HasIndex("SuitabilityId");

                    b.ToTable("FirstEvaluation");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.GoalAndResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Goal")
                        .HasMaxLength(100);

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<string>("Result")
                        .HasMaxLength(100);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("GoalAndResult");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.IncludedPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasMaxLength(32);

                    b.Property<string>("Function")
                        .HasMaxLength(32);

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<string>("LastName")
                        .HasMaxLength(32);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("IncludedPerson");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.IndividualServicePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age")
                        .HasMaxLength(8);

                    b.Property<Guid?>("CartonId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DedicatedWorker")
                        .HasMaxLength(32);

                    b.Property<DateTime>("TimeLimitForNextAppointment");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("IndividualServicePlan");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.LifeSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsGroupSkill");

                    b.Property<int>("LifeSkillType")
                        .HasMaxLength(1024);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("LifeSkill");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.LifeSkillDailyEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DailyEntryId");

                    b.Property<Guid?>("LifeSkillId");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryId");

                    b.HasIndex("LifeSkillId");

                    b.ToTable("LifeSkillDailyEntry");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.SafeHouseUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommonName")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("SafeHouseUser");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.SchoolActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DailyEntryId");

                    b.Property<int>("Type");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryId");

                    b.ToTable("SchoolActivity");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.Suitability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1024);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Suitabilities");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.SuitabilityCache", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(80);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("SuitabilityCache");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.SuitabilityItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1024);

                    b.Property<Guid?>("SuitabilityCacheId");

                    b.Property<Guid?>("SuitabilityId");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("SuitabilityCacheId");

                    b.HasIndex("SuitabilityId");

                    b.ToTable("SuitabilityItem");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.Workshop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DailyEntryId");

                    b.Property<int>("Number");

                    b.Property<int>("Type");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryId");

                    b.ToTable("Workshop");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.ActivityDetails", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.DailyEntry", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.Evaluation", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.FirstEvaluation", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");

                    b.HasOne("SafeHouse.Data.Entities.Suitability", "Suitability")
                        .WithMany()
                        .HasForeignKey("SuitabilityId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.GoalAndResult", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.IncludedPerson", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.IndividualServicePlan", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.LifeSkillDailyEntry", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.DailyEntry", "DailyEntry")
                        .WithMany()
                        .HasForeignKey("DailyEntryId");

                    b.HasOne("SafeHouse.Data.Entities.LifeSkill", "LifeSkill")
                        .WithMany()
                        .HasForeignKey("LifeSkillId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.SchoolActivity", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.DailyEntry", "DailyEntry")
                        .WithMany()
                        .HasForeignKey("DailyEntryId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.SuitabilityItem", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.SuitabilityCache", "SuitabilityCache")
                        .WithMany()
                        .HasForeignKey("SuitabilityCacheId");

                    b.HasOne("SafeHouse.Data.Entities.Suitability", "Suitability")
                        .WithMany("SuitabilityItems")
                        .HasForeignKey("SuitabilityId");
                });

            modelBuilder.Entity("SafeHouse.Data.Entities.Workshop", b =>
                {
                    b.HasOne("SafeHouse.Data.Entities.DailyEntry", "DailyEntry")
                        .WithMany()
                        .HasForeignKey("DailyEntryId");
                });
#pragma warning restore 612, 618
        }
    }
}
