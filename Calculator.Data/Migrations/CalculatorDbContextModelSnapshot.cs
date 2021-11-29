﻿// <auto-generated />
using System;
using Calculator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calculator.Data.Migrations
{
    [DbContext(typeof(CalculatorDbContext))]
    partial class CalculatorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Calculator.Domain.Models.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PoliticalPartyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surename")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PoliticalPartyId");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5d44ab60-4280-439c-8143-2d932a273b5e"),
                            Name = "Mieszko",
                            PoliticalPartyId = new Guid("7082c8dc-3124-4b46-9225-aa9f721fe718"),
                            Surename = "I"
                        },
                        new
                        {
                            Id = new Guid("7f257c8f-dc60-4dba-b642-b3b9c6a21266"),
                            Name = "Bolesław",
                            PoliticalPartyId = new Guid("7082c8dc-3124-4b46-9225-aa9f721fe718"),
                            Surename = "Chrobry"
                        },
                        new
                        {
                            Id = new Guid("f3b0001e-9a37-4955-8b40-05cccdea8572"),
                            Name = "Władysław",
                            PoliticalPartyId = new Guid("7082c8dc-3124-4b46-9225-aa9f721fe718"),
                            Surename = "Łokietek"
                        },
                        new
                        {
                            Id = new Guid("aee075de-3257-44ad-83a6-664460327912"),
                            Name = "Kazimierz",
                            PoliticalPartyId = new Guid("7082c8dc-3124-4b46-9225-aa9f721fe718"),
                            Surename = "Wielki"
                        },
                        new
                        {
                            Id = new Guid("699ff9be-471a-41f6-afc6-e534c7aa6250"),
                            Name = "Władysław",
                            PoliticalPartyId = new Guid("cb905638-5031-4ac0-8fb9-856fbe1dadc4"),
                            Surename = "Jagiełło"
                        },
                        new
                        {
                            Id = new Guid("13920626-d15e-4766-b595-5fef5369dae5"),
                            Name = "Władysław",
                            PoliticalPartyId = new Guid("cb905638-5031-4ac0-8fb9-856fbe1dadc4"),
                            Surename = "Warneńczyk"
                        },
                        new
                        {
                            Id = new Guid("e912608b-98f1-4d31-8c42-07b4435ff4fc"),
                            Name = "Zygmunt",
                            PoliticalPartyId = new Guid("cb905638-5031-4ac0-8fb9-856fbe1dadc4"),
                            Surename = "Stary"
                        },
                        new
                        {
                            Id = new Guid("98f1d798-f4db-4619-815e-fb740afdaa7c"),
                            Name = "Henryk",
                            PoliticalPartyId = new Guid("6f7b4461-7f99-4a9a-aa18-21e6e1c17ada"),
                            Surename = "Walezy"
                        },
                        new
                        {
                            Id = new Guid("6c99866a-a474-469b-aafd-30e7d1b387b8"),
                            Name = "Anna",
                            PoliticalPartyId = new Guid("6f7b4461-7f99-4a9a-aa18-21e6e1c17ada"),
                            Surename = "Jagiellonka"
                        },
                        new
                        {
                            Id = new Guid("f9fe4093-59f2-401f-b391-1763ff4821db"),
                            Name = "Stefan",
                            PoliticalPartyId = new Guid("6f7b4461-7f99-4a9a-aa18-21e6e1c17ada"),
                            Surename = "Batory"
                        },
                        new
                        {
                            Id = new Guid("2e63f181-537a-4f87-b687-fa2c6615c14a"),
                            Name = "Zygmunt",
                            PoliticalPartyId = new Guid("91ad0f92-4218-453e-946a-1ddab5def81f"),
                            Surename = "Waza"
                        },
                        new
                        {
                            Id = new Guid("a4e24540-2136-4e85-8188-a9f37220f30f"),
                            Name = "Władysław",
                            PoliticalPartyId = new Guid("91ad0f92-4218-453e-946a-1ddab5def81f"),
                            Surename = "Waza"
                        },
                        new
                        {
                            Id = new Guid("6af5a729-f1bd-4778-b20e-9a98ded92dd9"),
                            Name = "Jan",
                            PoliticalPartyId = new Guid("91ad0f92-4218-453e-946a-1ddab5def81f"),
                            Surename = "Kazimierz"
                        });
                });

            modelBuilder.Entity("Calculator.Domain.Models.PoliticalParty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PoliticalParties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7082c8dc-3124-4b46-9225-aa9f721fe718"),
                            Name = "Piastowie"
                        },
                        new
                        {
                            Id = new Guid("cb905638-5031-4ac0-8fb9-856fbe1dadc4"),
                            Name = "Dynastia Jagiellonów"
                        },
                        new
                        {
                            Id = new Guid("6f7b4461-7f99-4a9a-aa18-21e6e1c17ada"),
                            Name = "Elekcyjni dla Polski"
                        },
                        new
                        {
                            Id = new Guid("91ad0f92-4218-453e-946a-1ddab5def81f"),
                            Name = "Wazowie"
                        });
                });

            modelBuilder.Entity("Calculator.Domain.Models.UnauthorizedAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UnauthorizedAttempts");
                });

            modelBuilder.Entity("Calculator.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasVoteRight")
                        .HasColumnType("bit");

                    b.Property<bool>("HasVoted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PeselHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PeselSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SureName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Calculator.Domain.Models.Vote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CandidateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Calculator.Domain.Models.Candidate", b =>
                {
                    b.HasOne("Calculator.Domain.Models.PoliticalParty", "PoliticalParty")
                        .WithMany("Candidates")
                        .HasForeignKey("PoliticalPartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PoliticalParty");
                });

            modelBuilder.Entity("Calculator.Domain.Models.Vote", b =>
                {
                    b.HasOne("Calculator.Domain.Models.Candidate", "Candidate")
                        .WithMany("Votes")
                        .HasForeignKey("CandidateId");

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("Calculator.Domain.Models.Candidate", b =>
                {
                    b.Navigation("Votes");
                });

            modelBuilder.Entity("Calculator.Domain.Models.PoliticalParty", b =>
                {
                    b.Navigation("Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
