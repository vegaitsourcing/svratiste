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

                    b.Property<Guid?>("CartonId");

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

            modelBuilder.Entity("SafeHouse.Model.Suitability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Suitability");
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
#pragma warning restore 612, 618
        }
    }
}
