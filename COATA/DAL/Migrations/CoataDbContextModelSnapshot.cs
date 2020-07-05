﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(CoataDbContext))]
    partial class CoataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.6.20312.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Tables.UnitClassification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypeId");

                    b.ToTable("UnitClassifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Області",
                            UnitTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "РАЙОНИ ВІННИЦЬКОЇ ОБЛАСТІ",
                            UnitTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "РАЙОНИ ВОЛИНСЬКОЇ ОБЛАСТІ",
                            UnitTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "РАЙОНИ ДНІПРОПЕТРОВСЬКОЇ ОБЛАСТІ",
                            UnitTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "МІСТА ОБЛАСНОГО ПІДПОРЯДКУВАННЯ ВІННИЦЬКОЇ ОБЛАСТІ",
                            UnitTypeId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "МІСТА ОБЛАСНОГО ПІДПОРЯДКУВАННЯ ВОЛИНСЬКОЇ ОБЛАСТІ",
                            UnitTypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "МІСТА РАЙОННОГО ПІДПОРЯДКУВАННЯ БАРСЬКОГО Р-НУ",
                            UnitTypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "МІСТА РАЙОННОГО ПІДПОРЯДКУВАННЯ БЕРШАДСЬКОГО Р-НУ",
                            UnitTypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "СІЛЬРАДИ БАРСЬКОГО Р-НУ",
                            UnitTypeId = 5
                        },
                        new
                        {
                            Id = 10,
                            Name = "СІЛЬРАДИ БЕРШАДСЬКОГО Р-НУ",
                            UnitTypeId = 5
                        },
                        new
                        {
                            Id = 11,
                            Name = "СЕЛИЩА МІСЬКОГО ТИПУ ВІННИЦЬКОГО Р-НУ",
                            UnitTypeId = 4
                        },
                        new
                        {
                            Id = 12,
                            Name = "СЕЛИЩА МІСЬКОГО ТИПУ ЖМЕРИНСЬКОГО Р-НУ",
                            UnitTypeId = 4
                        },
                        new
                        {
                            Id = 15,
                            Name = "СЕЛИЩА МІСЬКОГО ТИПУ ГОРОХІВСЬКОГО Р-НУ",
                            UnitTypeId = 4
                        },
                        new
                        {
                            Id = 17,
                            Name = "СЕЛИЩА МІСЬКОГО ТИПУ ІВАНИЧІВСЬКОГО Р-НУ",
                            UnitTypeId = 4
                        },
                        new
                        {
                            Id = 20,
                            Name = "СЕЛИЩА МІСЬКОГО ТИПУ ВАСИЛЬКІВСЬКОГО Р-НУ",
                            UnitTypeId = 4
                        },
                        new
                        {
                            Id = 25,
                            Name = "СЕЛИЩА МІСЬКОГО ТИПУ ВЕРХНЬОДНІПРОВСЬКОГО Р-НУ",
                            UnitTypeId = 4
                        },
                        new
                        {
                            Id = 35,
                            Name = "ROOT",
                            UnitTypeId = 7
                        });
                });

            modelBuilder.Entity("DAL.Entities.Tables.UnitTree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Lft")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Rgt")
                        .HasColumnType("int");

                    b.Property<int>("UnitClassificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("UnitClassificationId");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lft = 1,
                            Name = "ROOT",
                            Rgt = 102,
                            UnitClassificationId = 35
                        },
                        new
                        {
                            Id = 2,
                            Lft = 2,
                            Name = "ВІННИЦЬКА ОБЛАСТЬ/М.ВІННИЦЯ",
                            ParentId = 1,
                            Rgt = 49,
                            UnitClassificationId = 1
                        },
                        new
                        {
                            Id = 3,
                            Lft = 50,
                            Name = "ВОЛИНСЬКА ОБЛАСТЬ/М.ЛУЦЬК",
                            ParentId = 1,
                            Rgt = 73,
                            UnitClassificationId = 1
                        },
                        new
                        {
                            Id = 4,
                            Lft = 74,
                            Name = "ДНІПРОПЕТРОВСЬКА ОБЛАСТЬ/М.ДНІПРО",
                            ParentId = 1,
                            Rgt = 95,
                            UnitClassificationId = 1
                        },
                        new
                        {
                            Id = 5,
                            Lft = 96,
                            Name = "ДОНЕЦЬКА ОБЛАСТЬ/М.ДОНЕЦЬК",
                            ParentId = 1,
                            Rgt = 97,
                            UnitClassificationId = 1
                        },
                        new
                        {
                            Id = 6,
                            Lft = 98,
                            Name = "ЖИТОМИРСЬКА ОБЛАСТЬ/М.ЖИТОМИР",
                            ParentId = 1,
                            Rgt = 99,
                            UnitClassificationId = 1
                        },
                        new
                        {
                            Id = 7,
                            Lft = 100,
                            Name = "ЗАКАРПАТСЬКА ОБЛАСТЬ/М.УЖГОРОД",
                            ParentId = 1,
                            Rgt = 101,
                            UnitClassificationId = 1
                        },
                        new
                        {
                            Id = 8,
                            Lft = 3,
                            Name = "БАРСЬКИЙ РАЙОН/М.БАР",
                            ParentId = 2,
                            Rgt = 12,
                            UnitClassificationId = 2
                        },
                        new
                        {
                            Id = 9,
                            Lft = 13,
                            Name = "БЕРШАДСЬКИЙ РАЙОН/М.БЕРШАДЬ",
                            ParentId = 2,
                            Rgt = 24,
                            UnitClassificationId = 2
                        },
                        new
                        {
                            Id = 10,
                            Lft = 25,
                            Name = "ВІННИЦЬКИЙ РАЙОН/М.ВІННИЦЯ",
                            ParentId = 2,
                            Rgt = 32,
                            UnitClassificationId = 2
                        },
                        new
                        {
                            Id = 11,
                            Lft = 33,
                            Name = "ГАЙСИНСЬКИЙ РАЙОН/М.ГАЙСИН",
                            ParentId = 2,
                            Rgt = 34,
                            UnitClassificationId = 2
                        },
                        new
                        {
                            Id = 12,
                            Lft = 35,
                            Name = "ЖМЕРИНСЬКИЙ РАЙОН/М.ЖМЕРИНКА",
                            ParentId = 2,
                            Rgt = 38,
                            UnitClassificationId = 2
                        },
                        new
                        {
                            Id = 13,
                            Lft = 51,
                            Name = "ВОЛОДИМИР-ВОЛИНСЬКИЙ РАЙОН/М.ВОЛОДИМИР-ВОЛИНСЬКИЙ",
                            ParentId = 3,
                            Rgt = 52,
                            UnitClassificationId = 3
                        },
                        new
                        {
                            Id = 14,
                            Lft = 53,
                            Name = "ВОЛОДИМИР-ВОЛИНСЬКИЙ РАЙОН/М.ВОЛОДИМИР-ВОЛИНСЬКИЙ",
                            ParentId = 3,
                            Rgt = 54,
                            UnitClassificationId = 3
                        },
                        new
                        {
                            Id = 15,
                            Lft = 55,
                            Name = "ГОРОХІВСЬКИЙ РАЙОН/М.ГОРОХІВ",
                            ParentId = 3,
                            Rgt = 60,
                            UnitClassificationId = 3
                        },
                        new
                        {
                            Id = 16,
                            Lft = 61,
                            Name = "ІВАНИЧІВСЬКИЙ РАЙОН/СМТ ІВАНИЧІ",
                            ParentId = 3,
                            Rgt = 64,
                            UnitClassificationId = 3
                        },
                        new
                        {
                            Id = 17,
                            Lft = 75,
                            Name = "АПОСТОЛІВСЬКИЙ РАЙОН/М.АПОСТОЛОВЕ",
                            ParentId = 4,
                            Rgt = 76,
                            UnitClassificationId = 4
                        },
                        new
                        {
                            Id = 18,
                            Lft = 77,
                            Name = "ВАСИЛЬКІВСЬКИЙ РАЙОН/СМТ ВАСИЛЬКІВКА",
                            ParentId = 4,
                            Rgt = 84,
                            UnitClassificationId = 4
                        },
                        new
                        {
                            Id = 19,
                            Lft = 85,
                            Name = "ВЕРХНЬОДНІПРОВСЬКИЙ РАЙОН/М.ВЕРХНЬОДНІПРОВСЬК",
                            ParentId = 4,
                            Rgt = 90,
                            UnitClassificationId = 4
                        },
                        new
                        {
                            Id = 20,
                            Lft = 91,
                            Name = "ДНІПРОВСЬКИЙ РАЙОН/М.ДНІПРО",
                            ParentId = 4,
                            Rgt = 92,
                            UnitClassificationId = 4
                        },
                        new
                        {
                            Id = 21,
                            Lft = 93,
                            Name = "КРИВОРІЗЬКИЙ РАЙОН/М.КРИВИЙ РІГ",
                            ParentId = 4,
                            Rgt = 94,
                            UnitClassificationId = 4
                        },
                        new
                        {
                            Id = 22,
                            Lft = 39,
                            Name = "ВІННИЦЯ",
                            ParentId = 2,
                            Rgt = 40,
                            UnitClassificationId = 5
                        },
                        new
                        {
                            Id = 23,
                            Lft = 41,
                            Name = "МОГИЛІВ-ПОДІЛЬСЬКИЙ",
                            ParentId = 2,
                            Rgt = 42,
                            UnitClassificationId = 5
                        },
                        new
                        {
                            Id = 24,
                            Lft = 43,
                            Name = "КОЗЯТИН",
                            ParentId = 2,
                            Rgt = 44,
                            UnitClassificationId = 5
                        },
                        new
                        {
                            Id = 25,
                            Lft = 45,
                            Name = "ЛАДИЖИН",
                            ParentId = 2,
                            Rgt = 46,
                            UnitClassificationId = 5
                        },
                        new
                        {
                            Id = 26,
                            Lft = 47,
                            Name = "ХМІЛЬНИК",
                            ParentId = 2,
                            Rgt = 48,
                            UnitClassificationId = 5
                        },
                        new
                        {
                            Id = 27,
                            Lft = 65,
                            Name = "ЛУЦЬК",
                            ParentId = 3,
                            Rgt = 66,
                            UnitClassificationId = 6
                        },
                        new
                        {
                            Id = 28,
                            Lft = 67,
                            Name = "ВОЛОДИМИР-ВОЛИНСЬКИЙ",
                            ParentId = 3,
                            Rgt = 68,
                            UnitClassificationId = 6
                        },
                        new
                        {
                            Id = 29,
                            Lft = 69,
                            Name = "КОВЕЛЬ",
                            ParentId = 3,
                            Rgt = 70,
                            UnitClassificationId = 6
                        },
                        new
                        {
                            Id = 30,
                            Lft = 71,
                            Name = "НОВОВОЛИНСЬК",
                            ParentId = 3,
                            Rgt = 72,
                            UnitClassificationId = 6
                        },
                        new
                        {
                            Id = 31,
                            Lft = 4,
                            Name = "БАР",
                            ParentId = 8,
                            Rgt = 5,
                            UnitClassificationId = 7
                        },
                        new
                        {
                            Id = 32,
                            Lft = 14,
                            Name = "БЕРШАДЬ",
                            ParentId = 9,
                            Rgt = 15,
                            UnitClassificationId = 8
                        },
                        new
                        {
                            Id = 50,
                            Lft = 6,
                            Name = "АНТОНІВИІВСЬКА/С.АНТОНІВКА",
                            ParentId = 8,
                            Rgt = 7,
                            UnitClassificationId = 9
                        },
                        new
                        {
                            Id = 51,
                            Lft = 8,
                            Name = "БАЛКІВСЬКА/С.БАЛКИ",
                            ParentId = 8,
                            Rgt = 9,
                            UnitClassificationId = 9
                        },
                        new
                        {
                            Id = 52,
                            Lft = 10,
                            Name = "ВЕРХІВСЬКА/С.ВЕРХІВКА",
                            ParentId = 8,
                            Rgt = 11,
                            UnitClassificationId = 9
                        },
                        new
                        {
                            Id = 60,
                            Lft = 16,
                            Name = "БАЛАНІВСЬКА C",
                            ParentId = 9,
                            Rgt = 17,
                            UnitClassificationId = 10
                        },
                        new
                        {
                            Id = 61,
                            Lft = 18,
                            Name = "БИРЛІВСЬКА C",
                            ParentId = 9,
                            Rgt = 19,
                            UnitClassificationId = 10
                        },
                        new
                        {
                            Id = 62,
                            Lft = 20,
                            Name = "ВЕЛИКОКИРІЇВСЬКА/С.ВЕЛИКА КИРІЇВКА",
                            ParentId = 9,
                            Rgt = 21,
                            UnitClassificationId = 10
                        },
                        new
                        {
                            Id = 63,
                            Lft = 22,
                            Name = "ГОЛДАШІВСЬКА/С.ГОЛДАШІВКА",
                            ParentId = 9,
                            Rgt = 23,
                            UnitClassificationId = 10
                        },
                        new
                        {
                            Id = 80,
                            Lft = 26,
                            Name = "ВОРОНОВИЦЯ",
                            ParentId = 10,
                            Rgt = 27,
                            UnitClassificationId = 11
                        },
                        new
                        {
                            Id = 81,
                            Lft = 28,
                            Name = "ДЕСНА",
                            ParentId = 10,
                            Rgt = 29,
                            UnitClassificationId = 11
                        },
                        new
                        {
                            Id = 82,
                            Lft = 30,
                            Name = "СТРИЖАВКА",
                            ParentId = 10,
                            Rgt = 31,
                            UnitClassificationId = 11
                        },
                        new
                        {
                            Id = 85,
                            Lft = 36,
                            Name = "БРАЇЛІВ",
                            ParentId = 12,
                            Rgt = 37,
                            UnitClassificationId = 12
                        },
                        new
                        {
                            Id = 95,
                            Lft = 56,
                            Name = "МАР'ЯНІВКА",
                            ParentId = 15,
                            Rgt = 57,
                            UnitClassificationId = 15
                        },
                        new
                        {
                            Id = 96,
                            Lft = 58,
                            Name = "СЕНКЕВИЧІВКА",
                            ParentId = 15,
                            Rgt = 59,
                            UnitClassificationId = 15
                        },
                        new
                        {
                            Id = 100,
                            Lft = 62,
                            Name = "ІВАНИЧІ",
                            ParentId = 16,
                            Rgt = 63,
                            UnitClassificationId = 17
                        },
                        new
                        {
                            Id = 110,
                            Lft = 78,
                            Name = "ВАСИЛЬКІВКА",
                            ParentId = 18,
                            Rgt = 79,
                            UnitClassificationId = 20
                        },
                        new
                        {
                            Id = 111,
                            Lft = 80,
                            Name = "ПИСЬМЕННЕ",
                            ParentId = 18,
                            Rgt = 81,
                            UnitClassificationId = 20
                        },
                        new
                        {
                            Id = 112,
                            Lft = 82,
                            Name = "ЧАПЛИНЕ",
                            ParentId = 18,
                            Rgt = 83,
                            UnitClassificationId = 20
                        },
                        new
                        {
                            Id = 120,
                            Lft = 86,
                            Name = "НОВОМИКОЛАЇВКА",
                            ParentId = 19,
                            Rgt = 87,
                            UnitClassificationId = 25
                        },
                        new
                        {
                            Id = 121,
                            Lft = 88,
                            Name = "ДНІПРОВСЬКЕ",
                            ParentId = 19,
                            Rgt = 89,
                            UnitClassificationId = 25
                        });
                });

            modelBuilder.Entity("DAL.Entities.Tables.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Області"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Райони"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Міста"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Селища"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Сільради"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Села"
                        },
                        new
                        {
                            Id = 7,
                            Name = "root"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Tables.UnitTypeParentShip", b =>
                {
                    b.Property<int>("UnitTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ParentUnitTypeId")
                        .HasColumnType("int");

                    b.HasKey("UnitTypeId", "ParentUnitTypeId");

                    b.HasIndex("ParentUnitTypeId");

                    b.ToTable("UnitTypeHierarchy");

                    b.HasData(
                        new
                        {
                            UnitTypeId = 2,
                            ParentUnitTypeId = 1
                        },
                        new
                        {
                            UnitTypeId = 3,
                            ParentUnitTypeId = 1
                        },
                        new
                        {
                            UnitTypeId = 3,
                            ParentUnitTypeId = 2
                        },
                        new
                        {
                            UnitTypeId = 5,
                            ParentUnitTypeId = 2
                        },
                        new
                        {
                            UnitTypeId = 4,
                            ParentUnitTypeId = 2
                        },
                        new
                        {
                            UnitTypeId = 6,
                            ParentUnitTypeId = 2
                        },
                        new
                        {
                            UnitTypeId = 4,
                            ParentUnitTypeId = 3
                        },
                        new
                        {
                            UnitTypeId = 2,
                            ParentUnitTypeId = 3
                        },
                        new
                        {
                            UnitTypeId = 6,
                            ParentUnitTypeId = 3
                        },
                        new
                        {
                            UnitTypeId = 5,
                            ParentUnitTypeId = 4
                        },
                        new
                        {
                            UnitTypeId = 5,
                            ParentUnitTypeId = 6
                        });
                });

            modelBuilder.Entity("DAL.Entities.Tables.UnitClassification", b =>
                {
                    b.HasOne("DAL.Entities.Tables.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Tables.UnitTree", b =>
                {
                    b.HasOne("DAL.Entities.Tables.UnitTree", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("DAL.Entities.Tables.UnitClassification", "UnitClassification")
                        .WithMany()
                        .HasForeignKey("UnitClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Tables.UnitTypeParentShip", b =>
                {
                    b.HasOne("DAL.Entities.Tables.UnitType", "ParentUnitType")
                        .WithMany()
                        .HasForeignKey("ParentUnitTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Tables.UnitType", "UnitType")
                        .WithMany()
                        .HasForeignKey("UnitTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
