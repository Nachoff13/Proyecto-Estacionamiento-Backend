﻿// <auto-generated />
using System;
using Data.Models;
using Data.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackendEstacionamiento.Migrations
{
    [DbContext(typeof(DbEstacionamientoContext))]
    partial class DbEstacionamientoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend_Estacionamiento.Models.Garaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("integer")
                        .HasColumnName("altura");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("calle");

                    b.Property<int>("Capacidad")
                        .HasColumnType("integer")
                        .HasColumnName("capacidad");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text")
                        .HasColumnName("descripcion");

                    b.Property<bool?>("Disponible")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("disponible");

                    b.Property<int?>("Idlocalidad")
                        .HasColumnType("integer")
                        .HasColumnName("idlocalidad");

                    b.Property<int?>("Idpropietario")
                        .HasColumnType("integer")
                        .HasColumnName("idpropietario");

                    b.Property<decimal>("Preciohora")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("preciohora");

                    b.HasKey("Id")
                        .HasName("garaje_pkey");

                    b.HasIndex("Idlocalidad");

                    b.HasIndex("Idpropietario");

                    b.ToTable("garaje", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Garajefoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Foto")
                        .HasColumnType("bytea")
                        .HasColumnName("foto");

                    b.Property<int?>("Idgaraje")
                        .HasColumnType("integer")
                        .HasColumnName("idgaraje");

                    b.HasKey("Id")
                        .HasName("garajefoto_pkey");

                    b.HasIndex("Idgaraje");

                    b.ToTable("garajefoto", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codpostal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("codpostal");

                    b.Property<int?>("Idprovincia")
                        .HasColumnType("integer")
                        .HasColumnName("idprovincia");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("localidad_pkey");

                    b.HasIndex("Idprovincia");

                    b.ToTable("localidad", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("marca_pkey");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Metodopago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("metodopago_pkey");

                    b.ToTable("metodopago", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Idmarca")
                        .HasColumnType("integer")
                        .HasColumnName("idmarca");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("modelo_pkey");

                    b.HasIndex("Idmarca");

                    b.ToTable("modelo", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Fecha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fecha")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("Idmetodopago")
                        .HasColumnType("integer")
                        .HasColumnName("idmetodopago");

                    b.Property<int?>("Idreserva")
                        .HasColumnType("integer")
                        .HasColumnName("idreserva");

                    b.Property<decimal>("Monto")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("monto");

                    b.HasKey("Id")
                        .HasName("pago_pkey");

                    b.HasIndex("Idmetodopago");

                    b.HasIndex("Idreserva");

                    b.ToTable("pago", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("provincia_pkey");

                    b.ToTable("provincia", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fechafin")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fechafin");

                    b.Property<DateTime>("Fechainicio")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("fechainicio");

                    b.Property<int?>("Idconductor")
                        .HasColumnType("integer")
                        .HasColumnName("idconductor");

                    b.Property<int?>("Idgaraje")
                        .HasColumnType("integer")
                        .HasColumnName("idgaraje");

                    b.Property<int?>("Idreservaestado")
                        .HasColumnType("integer")
                        .HasColumnName("idreservaestado");

                    b.HasKey("Id")
                        .HasName("reserva_pkey");

                    b.HasIndex("Idconductor");

                    b.HasIndex("Idgaraje");

                    b.HasIndex("Idreservaestado");

                    b.ToTable("reserva", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.ReservaEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("reservaestado_pkey");

                    b.ToTable("reservaestado", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("apellido");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("contrasena");

                    b.Property<bool?>("Esconductor")
                        .HasColumnType("boolean")
                        .HasColumnName("esconductor");

                    b.Property<bool?>("Espropietario")
                        .HasColumnType("boolean")
                        .HasColumnName("espropietario");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("mail");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("nombre");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("usuario_pkey");

                    b.HasIndex(new[] { "Mail" }, "usuario_mail_key")
                        .IsUnique();

                    b.HasIndex(new[] { "Username" }, "usuario_username_key")
                        .IsUnique();

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("Idconductor")
                        .HasColumnType("integer")
                        .HasColumnName("idconductor");

                    b.Property<int?>("Idmodelo")
                        .HasColumnType("integer")
                        .HasColumnName("idmodelo");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("matricula");

                    b.HasKey("Id")
                        .HasName("vehiculo_pkey");

                    b.HasIndex("Idconductor");

                    b.HasIndex("Idmodelo");

                    b.ToTable("vehiculo", (string)null);
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Garaje", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Localidad", "IdlocalidadNavigation")
                        .WithMany("Garajes")
                        .HasForeignKey("Idlocalidad")
                        .HasConstraintName("garaje_idlocalidad_fkey");

                    b.HasOne("Backend_Estacionamiento.Models.Usuario", "IdpropietarioNavigation")
                        .WithMany("Garajes")
                        .HasForeignKey("Idpropietario")
                        .HasConstraintName("garaje_idpropietario_fkey");

                    b.Navigation("IdlocalidadNavigation");

                    b.Navigation("IdpropietarioNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Garajefoto", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Garaje", "IdgarajeNavigation")
                        .WithMany("Garajefotos")
                        .HasForeignKey("Idgaraje")
                        .HasConstraintName("garajefoto_idgaraje_fkey");

                    b.Navigation("IdgarajeNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Localidad", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Provincia", "IdprovinciaNavigation")
                        .WithMany("Localidads")
                        .HasForeignKey("Idprovincia")
                        .HasConstraintName("localidad_idprovincia_fkey");

                    b.Navigation("IdprovinciaNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Modelo", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Marca", "IdmarcaNavigation")
                        .WithMany("Modelos")
                        .HasForeignKey("Idmarca")
                        .HasConstraintName("modelo_idmarca_fkey");

                    b.Navigation("IdmarcaNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Pago", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Metodopago", "IdmetodopagoNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("Idmetodopago")
                        .HasConstraintName("pago_idmetodopago_fkey");

                    b.HasOne("Backend_Estacionamiento.Models.Reserva", "IdreservaNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("Idreserva")
                        .HasConstraintName("pago_idreserva_fkey");

                    b.Navigation("IdmetodopagoNavigation");

                    b.Navigation("IdreservaNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Reserva", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Usuario", "IdconductorNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("Idconductor")
                        .HasConstraintName("reserva_idconductor_fkey");

                    b.HasOne("Backend_Estacionamiento.Models.Garaje", "IdgarajeNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("Idgaraje")
                        .HasConstraintName("reserva_idgaraje_fkey");

                    b.HasOne("Backend_Estacionamiento.Models.ReservaEstado", "IdreservaestadoNavigation")
                        .WithMany("Reservas")
                        .HasForeignKey("Idreservaestado")
                        .HasConstraintName("reserva_idreservaestado_fkey");

                    b.Navigation("IdconductorNavigation");

                    b.Navigation("IdgarajeNavigation");

                    b.Navigation("IdreservaestadoNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Vehiculo", b =>
                {
                    b.HasOne("Backend_Estacionamiento.Models.Usuario", "IdconductorNavigation")
                        .WithMany("Vehiculos")
                        .HasForeignKey("Idconductor")
                        .HasConstraintName("vehiculo_idconductor_fkey");

                    b.HasOne("Backend_Estacionamiento.Models.Modelo", "IdmodeloNavigation")
                        .WithMany("Vehiculos")
                        .HasForeignKey("Idmodelo")
                        .HasConstraintName("vehiculo_idmodelo_fkey");

                    b.Navigation("IdconductorNavigation");

                    b.Navigation("IdmodeloNavigation");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Garaje", b =>
                {
                    b.Navigation("Garajefotos");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Localidad", b =>
                {
                    b.Navigation("Garajes");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Marca", b =>
                {
                    b.Navigation("Modelos");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Metodopago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Modelo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Provincia", b =>
                {
                    b.Navigation("Localidads");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Reserva", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.ReservaEstado", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Backend_Estacionamiento.Models.Usuario", b =>
                {
                    b.Navigation("Garajes");

                    b.Navigation("Reservas");

                    b.Navigation("Vehiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
