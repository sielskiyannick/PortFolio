﻿// <auto-generated />
using System;
using Data.EF.Contexts.Portfolio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.EF.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    partial class PortfolioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.CV", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("CVs");
                });

            modelBuilder.Entity("Domain.Entities.CVEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CVId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("CVEntries");
                });

            modelBuilder.Entity("Domain.Entities.CVEntry", b =>
                {
                    b.HasOne("Domain.Entities.CV", "CV")
                        .WithMany("CVEntries")
                        .HasForeignKey("CVId");
                });
#pragma warning restore 612, 618
        }
    }
}
