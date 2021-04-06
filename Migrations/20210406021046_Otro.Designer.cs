﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerCuatro.Models.DAL;

namespace TallerCuatro.Migrations
{
    [DbContext(typeof(DbContextTaller))]
    [Migration("20210406021046_Otro")]
    partial class Otro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TallerCuatro.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TallerCuatro.Models.Entities.Paquete", b =>
                {
                    b.Property<int>("PaqueteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("CodigoMIA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GuiaColombia")
                        .HasColumnType("int");

                    b.Property<string>("NombreImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<int>("TipoMercanciaId")
                        .HasColumnType("int");

                    b.Property<int>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<float>("ValorAPAgar")
                        .HasColumnType("real");

                    b.HasKey("PaqueteId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TipoMercanciaId");

                    b.HasIndex("TransportadoraId");

                    b.ToTable("Paquetes");
                });

            modelBuilder.Entity("TallerCuatro.Models.Entities.TipoMercancia", b =>
                {
                    b.Property<int>("TipoMercanciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoMercanciaId");

                    b.ToTable("TiposMercancias");
                });

            modelBuilder.Entity("TallerCuatro.Models.Entities.Transportadora", b =>
                {
                    b.Property<int>("TransportadoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransportadoraId");

                    b.ToTable("Transportadoras");
                });

            modelBuilder.Entity("TallerCuatro.Models.Entities.Paquete", b =>
                {
                    b.HasOne("TallerCuatro.Models.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerCuatro.Models.Entities.TipoMercancia", "TipoMercancia")
                        .WithMany()
                        .HasForeignKey("TipoMercanciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TallerCuatro.Models.Entities.Transportadora", "Transportadora")
                        .WithMany()
                        .HasForeignKey("TransportadoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
