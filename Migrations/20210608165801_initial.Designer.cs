﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using realEstate.DATA;
using System;

namespace realEstate.Migrations
{
    [DbContext(typeof(RealEstateDbContext))]
    [Migration("20210608165801_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("realEstate.Models.SellingAgent", b =>
                {
                    b.Property<int>("SellingAgentId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("RealEstateModelId");

                    b.Property<string>("SellingAgentName");

                    b.HasKey("SellingAgentId");

                    b.ToTable("Agents");
                });
#pragma warning restore 612, 618
        }
    }
}
