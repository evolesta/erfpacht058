﻿// <auto-generated />
using System;
using Erfpacht058_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Erfpacht058_API.Migrations
{
    [DbContext(typeof(Erfpacht058_APIContext))]
    partial class Erfpacht058_APIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EigenaarEigendom", b =>
                {
                    b.Property<int>("EigenaarId")
                        .HasColumnType("int");

                    b.Property<int>("EigendomId")
                        .HasColumnType("int");

                    b.HasKey("EigenaarId", "EigendomId");

                    b.HasIndex("EigendomId");

                    b.ToTable("EigenaarEigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Bestand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EigendomId")
                        .HasColumnType("int");

                    b.Property<long>("GrootteInKb")
                        .HasColumnType("bigint");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoortBestand")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EigendomId");

                    b.ToTable("Bestand");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EigendomId")
                        .HasColumnType("int");

                    b.Property<int>("Huisnummer")
                        .HasColumnType("int");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straatnaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toevoeging")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Woonplaats")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EigendomId")
                        .IsUnique()
                        .HasFilter("[EigendomId] IS NOT NULL");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Eigenaar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Debiteurnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Huisnummer")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ingangsdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straatnaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toevoeging")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voorletters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornamen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Woonplaats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eigenaar");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Eigendom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Complexnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("EconomischeWaarde")
                        .HasColumnType("real");

                    b.Property<DateTime?>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ingangsdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relatienummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("VerzekerdeWaarde")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Eigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Herziening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EigendomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Herzieningsdatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("VolgendeHerziening")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EigendomId")
                        .IsUnique()
                        .HasFilter("[EigendomId] IS NOT NULL");

                    b.ToTable("Herziening");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Kadaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Deeloppervlakte")
                        .HasColumnType("real");

                    b.Property<int?>("EigendomId")
                        .HasColumnType("int");

                    b.Property<string>("KadastraalNummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("KadastraleGrootte")
                        .HasColumnType("real");

                    b.Property<DateTime?>("LaatsteSynchronisatie")
                        .HasColumnType("datetime2");

                    b.Property<string>("ObjectType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EigendomId")
                        .IsUnique()
                        .HasFilter("[EigendomId] IS NOT NULL");

                    b.ToTable("Kadaster");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Gebruiker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Actief")
                        .HasColumnType("bit");

                    b.Property<string>("Emailadres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExportId")
                        .HasColumnType("int");

                    b.Property<int>("LogingPoging")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Voornamen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExportId")
                        .IsUnique()
                        .HasFilter("[ExportId] IS NOT NULL");

                    b.ToTable("Gebruiker");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Actief = true,
                            Emailadres = "test@gebruiker.nl",
                            LogingPoging = 0,
                            Naam = "Gebruiker",
                            Role = 1,
                            Voornamen = "Eerste",
                            Wachtwoord = "$2a$11$SOlz6ulWACMQo6xrytW6MuOcZ0bTE/XplzVKw2CPm14ZaG3IFaHAK"
                        });
                });

            modelBuilder.Entity("Erfpacht058_API.Models.OvereenkomstNS.Financien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Bedrag")
                        .HasColumnType("real");

                    b.Property<int>("FactureringsWijze")
                        .HasColumnType("int");

                    b.Property<int>("Frequentie")
                        .HasColumnType("int");

                    b.Property<int>("OvereenkomstId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OvereenkomstId")
                        .IsUnique();

                    b.ToTable("Financien");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.OvereenkomstNS.Overeenkomst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatumAkte")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dossiernummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EigendomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Einddatum")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Grondwaarde")
                        .HasColumnType("real");

                    b.Property<DateTime>("Ingangsdatum")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Rentepercentage")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("EigendomId");

                    b.ToTable("Overeenkomst");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Export", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Formaat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Export");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Operation")
                        .HasColumnType("int");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.RapportData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("RapportData");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.TaskQueue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AfgerondDatum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExportId")
                        .HasColumnType("int");

                    b.Property<int>("Prioriteit")
                        .HasColumnType("int");

                    b.Property<int>("SoortTaak")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExportId")
                        .IsUnique()
                        .HasFilter("[ExportId] IS NOT NULL");

                    b.ToTable("TaskQueue");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Template", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExportId")
                        .HasColumnType("int");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WijzigingsDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExportId")
                        .IsUnique()
                        .HasFilter("[ExportId] IS NOT NULL");

                    b.ToTable("Template");
                });

            modelBuilder.Entity("EigenaarEigendom", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigenaar", null)
                        .WithMany()
                        .HasForeignKey("EigenaarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigendom", null)
                        .WithMany()
                        .HasForeignKey("EigendomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Bestand", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigendom", "Eigendom")
                        .WithMany("Bestand")
                        .HasForeignKey("EigendomId");

                    b.Navigation("Eigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Adres", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigendom", "Eigendom")
                        .WithOne("Adres")
                        .HasForeignKey("Erfpacht058_API.Models.Eigendom.Adres", "EigendomId");

                    b.Navigation("Eigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Herziening", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigendom", "Eigendom")
                        .WithOne("Herziening")
                        .HasForeignKey("Erfpacht058_API.Models.Eigendom.Herziening", "EigendomId");

                    b.Navigation("Eigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Kadaster", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigendom", "Eigendom")
                        .WithOne("Kadaster")
                        .HasForeignKey("Erfpacht058_API.Models.Eigendom.Kadaster", "EigendomId");

                    b.Navigation("Eigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Gebruiker", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Rapport.Export", "Export")
                        .WithOne("Gebruiker")
                        .HasForeignKey("Erfpacht058_API.Models.Gebruiker", "ExportId");

                    b.Navigation("Export");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.OvereenkomstNS.Financien", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.OvereenkomstNS.Overeenkomst", "Overeenkomst")
                        .WithOne("Financien")
                        .HasForeignKey("Erfpacht058_API.Models.OvereenkomstNS.Financien", "OvereenkomstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Overeenkomst");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.OvereenkomstNS.Overeenkomst", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Eigendom.Eigendom", "Eigendom")
                        .WithMany("Overeenkomst")
                        .HasForeignKey("EigendomId");

                    b.Navigation("Eigendom");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Filter", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Rapport.Template", "Template")
                        .WithMany("Filters")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.RapportData", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Rapport.Template", "Template")
                        .WithMany("RapportData")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Template");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.TaskQueue", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Rapport.Export", "Export")
                        .WithOne("Task")
                        .HasForeignKey("Erfpacht058_API.Models.Rapport.TaskQueue", "ExportId");

                    b.Navigation("Export");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Template", b =>
                {
                    b.HasOne("Erfpacht058_API.Models.Rapport.Export", "Export")
                        .WithOne("Template")
                        .HasForeignKey("Erfpacht058_API.Models.Rapport.Template", "ExportId");

                    b.Navigation("Export");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Eigendom.Eigendom", b =>
                {
                    b.Navigation("Adres");

                    b.Navigation("Bestand");

                    b.Navigation("Herziening");

                    b.Navigation("Kadaster");

                    b.Navigation("Overeenkomst");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.OvereenkomstNS.Overeenkomst", b =>
                {
                    b.Navigation("Financien");
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Export", b =>
                {
                    b.Navigation("Gebruiker")
                        .IsRequired();

                    b.Navigation("Task")
                        .IsRequired();

                    b.Navigation("Template")
                        .IsRequired();
                });

            modelBuilder.Entity("Erfpacht058_API.Models.Rapport.Template", b =>
                {
                    b.Navigation("Filters");

                    b.Navigation("RapportData");
                });
#pragma warning restore 612, 618
        }
    }
}
