﻿// <auto-generated />
using System;
using JM_Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JM_Api.Migrations
{
    [DbContext(typeof(JMContext))]
    [Migration("20200503123526_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JM_Api.Models.Administrador", b =>
                {
                    b.Property<int>("AdministradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("AdministradorId");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("JM_Api.Models.DireccionEnvio", b =>
                {
                    b.Property<int>("DireccionEnvioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Calle")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Ciudad")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("CodPostal")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("NumDomicilio")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Poblacion")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Provincia")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DireccionEnvioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DireccionesEnvio");
                });

            modelBuilder.Entity("JM_Api.Models.InformacionPago", b =>
                {
                    b.Property<int>("InformacionPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodSeguridad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCaducidad")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NumTarjeta")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Tipo")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("InformacionPagoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("InformacionPagos");
                });

            modelBuilder.Entity("JM_Api.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DireccionEnvioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NotasEntrega")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("PedidoId");

                    b.HasIndex("DireccionEnvioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("JM_Api.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("JM_Api.Models.ProductoPedido", b =>
                {
                    b.Property<int>("ProductoPedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("ProductoPedidoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("ProductosPedidos");
                });

            modelBuilder.Entity("JM_Api.Models.Transaccion", b =>
                {
                    b.Property<int>("TransaccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(12) CHARACTER SET utf8mb4")
                        .HasMaxLength(12);

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("InformacionPagoId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("double");

                    b.HasKey("TransaccionId");

                    b.HasIndex("InformacionPagoId");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("JM_Api.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(12) CHARACTER SET utf8mb4")
                        .HasMaxLength(12);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("JM_Api.Models.DireccionEnvio", b =>
                {
                    b.HasOne("JM_Api.Models.Usuario", "Usuario")
                        .WithMany("DireccionesEnvio")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JM_Api.Models.InformacionPago", b =>
                {
                    b.HasOne("JM_Api.Models.Usuario", "Usuario")
                        .WithMany("InformacionPagos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JM_Api.Models.Pedido", b =>
                {
                    b.HasOne("JM_Api.Models.DireccionEnvio", "DireccionEnvio")
                        .WithMany("Pedidos")
                        .HasForeignKey("DireccionEnvioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JM_Api.Models.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JM_Api.Models.ProductoPedido", b =>
                {
                    b.HasOne("JM_Api.Models.Pedido", "Pedido")
                        .WithMany("ProductosPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JM_Api.Models.Producto", "Producto")
                        .WithMany("ProductosPedidos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JM_Api.Models.Transaccion", b =>
                {
                    b.HasOne("JM_Api.Models.InformacionPago", "InformacionPago")
                        .WithMany("Transacciones")
                        .HasForeignKey("InformacionPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JM_Api.Models.Pedido", "Pedido")
                        .WithOne("Transaccion")
                        .HasForeignKey("JM_Api.Models.Transaccion", "PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
