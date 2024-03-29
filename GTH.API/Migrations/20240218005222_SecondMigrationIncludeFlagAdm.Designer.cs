﻿// <auto-generated />
using GTH.API.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GTH.API.Migrations
{
    [DbContext(typeof(PJGTHContext))]
    [Migration("20240218005222_SecondMigrationIncludeFlagAdm")]
    partial class SecondMigrationIncludeFlagAdm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GTH.API.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("ADMINISTRADOR")
                        .HasColumnType("bit");

                    b.Property<string>("CPFCNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENDERECO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SENHA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOBRENOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
