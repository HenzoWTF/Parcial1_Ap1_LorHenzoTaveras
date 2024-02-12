﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_Ap1_LorHenzoTaveras.DAL;

#nullable disable

namespace Parcial1_Ap1_LorHenzoTaveras.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240212225847_Metas")]
    partial class Metas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Parcial1_Ap1_LorHenzoTaveras.Model.MetasFinancieras", b =>
                {
                    b.Property<int?>("MetaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("MetaId");

                    b.ToTable("Metas");
                });
#pragma warning restore 612, 618
        }
    }
}
