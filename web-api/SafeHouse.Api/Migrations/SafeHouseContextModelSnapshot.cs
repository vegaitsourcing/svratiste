﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafeHouse.Model;

namespace SafeHouse.Migrations
{
    [DbContext(typeof(SafeHouseContext))]
    partial class SafeHouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SafeHouse.Model.ActivityDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Activity");

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<string>("ResponiblePerson");

                    b.Property<string>("TimeLimit");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("ActivityDetails");
                });

            modelBuilder.Entity("SafeHouse.Model.Carton", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressStreetName")
                        .HasMaxLength(100);

                    b.Property<string>("AddressStreetNumber")
                        .HasMaxLength(32);

                    b.Property<DateTime>("Birthday");

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

            modelBuilder.Entity("SafeHouse.Model.DailyEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bath");

                    b.Property<bool>("Breakfast");

                    b.Property<Guid?>("CartonId");

                    b.Property<bool>("Clothing");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Dinner");

                    b.Property<bool>("LiecesRemoval");

                    b.Property<bool>("Lunch");

                    b.Property<bool>("Stay");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("DailyEntry");
                });

            modelBuilder.Entity("SafeHouse.Model.Evaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdvicedLevelOfSupport");

                    b.Property<int>("Age");

                    b.Property<string>("BasicPhysicalNeeds");

                    b.Property<string>("BehaviorRisks");

                    b.Property<string>("Capabilities");

                    b.Property<Guid?>("CartonId");

                    b.Property<string>("CaseLeader");

                    b.Property<string>("CulturalSpecifics");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DedicatedWorker");

                    b.Property<string>("DominantBehaviors");

                    b.Property<string>("DominantEmotions");

                    b.Property<string>("EducationalNeeds");

                    b.Property<string>("EvaluationDoneBy");

                    b.Property<string>("FamilyMembers");

                    b.Property<string>("FamilyRisks");

                    b.Property<string>("FamilyStrenghts");

                    b.Property<string>("OtherMembers");

                    b.Property<string>("OtherNeeds");

                    b.Property<string>("OtherRisks");

                    b.Property<string>("OtherStrenghts");

                    b.Property<string>("PersonalStrenghts");

                    b.Property<string>("PsyhoSocialNeeds");

                    b.Property<string>("SchoolStatus");

                    b.Property<string>("SurroundRisks");

                    b.Property<string>("SurroundStrenghts");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("SafeHouse.Model.FirstEvaluation", b =>
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

                    b.Property<int>("MyProperty");

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

                    b.Property<Guid?>("SuitabilityIdId");

                    b.Property<string>("VerbalComunicationAbility")
                        .HasMaxLength(512);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CartonId");

                    b.HasIndex("SuitabilityIdId");

                    b.ToTable("FirstEvaluation");
                });

            modelBuilder.Entity("SafeHouse.Model.GoalAndResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Goal");

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<string>("Result");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("GoalAndResult");
                });

            modelBuilder.Entity("SafeHouse.Model.IncludedPerson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("Function");

                    b.Property<Guid?>("IndividualServicePlanId");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("IndividualServicePlanId");

                    b.ToTable("IncludedPerson");
                });

            modelBuilder.Entity("SafeHouse.Model.IndividualServicePlan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DedicatedWorker");

                    b.Property<DateTime>("TimeLimitForNextAppointment");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("IndividualServicePlan");
                });

            modelBuilder.Entity("SafeHouse.Model.LifeSkillDailyEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DailyEntryIdId");

                    b.Property<Guid?>("LifeSkillIdId");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryIdId");

                    b.HasIndex("LifeSkillIdId");

                    b.ToTable("LifeSkillDailyEntry");
                });

            modelBuilder.Entity("SafeHouse.Model.LifeSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(1024);

                    b.Property<bool>("IsGroupSkill");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("LifeSkills");
                });

            modelBuilder.Entity("SafeHouse.Model.SafeHouseUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommonName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordSalt");

                    b.HasKey("Id");

                    b.ToTable("SafeHouseUser");
                });

            modelBuilder.Entity("SafeHouse.Model.SchoolActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DailyEntryIdId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryIdId");

                    b.ToTable("SchoolActivity");
                });

            modelBuilder.Entity("SafeHouse.Model.Suitability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Suitability");
                });

            modelBuilder.Entity("SafeHouse.Model.SuitabilityItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<Guid?>("SuitabilityIdId");

                    b.HasKey("Id");

                    b.HasIndex("SuitabilityIdId");

                    b.ToTable("SuitabilityItem");
                });

            modelBuilder.Entity("SafeHouse.Model.Workshop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DailyEntryIdId");

                    b.Property<int>("Number");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("DailyEntryIdId");

                    b.ToTable("Workshop");
                });

            modelBuilder.Entity("SafeHouse.Model.ActivityDetails", b =>
                {
                    b.HasOne("SafeHouse.Model.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Model.DailyEntry", b =>
                {
                    b.HasOne("SafeHouse.Model.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Model.Evaluation", b =>
                {
                    b.HasOne("SafeHouse.Model.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");
                });

            modelBuilder.Entity("SafeHouse.Model.FirstEvaluation", b =>
                {
                    b.HasOne("SafeHouse.Model.Carton", "Carton")
                        .WithMany()
                        .HasForeignKey("CartonId");

                    b.HasOne("SafeHouse.Model.Suitability", "SuitabilityId")
                        .WithMany()
                        .HasForeignKey("SuitabilityIdId");
                });

            modelBuilder.Entity("SafeHouse.Model.GoalAndResult", b =>
                {
                    b.HasOne("SafeHouse.Model.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Model.IncludedPerson", b =>
                {
                    b.HasOne("SafeHouse.Model.IndividualServicePlan", "IndividualServicePlan")
                        .WithMany()
                        .HasForeignKey("IndividualServicePlanId");
                });

            modelBuilder.Entity("SafeHouse.Model.LifeSkillDailyEntry", b =>
                {
                    b.HasOne("SafeHouse.Model.DailyEntry", "DailyEntryId")
                        .WithMany()
                        .HasForeignKey("DailyEntryIdId");

                    b.HasOne("SafeHouse.Model.LifeSkills", "LifeSkillId")
                        .WithMany()
                        .HasForeignKey("LifeSkillIdId");
                });

            modelBuilder.Entity("SafeHouse.Model.SchoolActivity", b =>
                {
                    b.HasOne("SafeHouse.Model.DailyEntry", "DailyEntryId")
                        .WithMany()
                        .HasForeignKey("DailyEntryIdId");
                });

            modelBuilder.Entity("SafeHouse.Model.SuitabilityItem", b =>
                {
                    b.HasOne("SafeHouse.Model.Suitability", "SuitabilityId")
                        .WithMany()
                        .HasForeignKey("SuitabilityIdId");
                });

            modelBuilder.Entity("SafeHouse.Model.Workshop", b =>
                {
                    b.HasOne("SafeHouse.Model.DailyEntry", "DailyEntryId")
                        .WithMany()
                        .HasForeignKey("DailyEntryIdId");
                });
#pragma warning restore 612, 618
        }
    }
}
