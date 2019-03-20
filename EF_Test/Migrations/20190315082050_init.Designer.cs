﻿// <auto-generated />
using EF_Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Test.Migrations
{
    [DbContext(typeof(TibosDbContext))]
    [Migration("20190315082050_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Test.Dict", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<int>("Sort");

                    b.Property<int>("Status");

                    b.Property<string>("Tid");

                    b.HasKey("Id");

                    b.ToTable("Dict");
                });

            modelBuilder.Entity("EF_Test.DictType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Mark");

                    b.Property<string>("Name");

                    b.Property<int>("Sort");

                    b.HasKey("Id");

                    b.ToTable("DictType");
                });
#pragma warning restore 612, 618
        }
    }
}
