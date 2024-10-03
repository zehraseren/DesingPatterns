﻿// <auto-generated />
using DP.Decorator.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DP.Decorator.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241003081341_add-notifier-entity")]
    partial class addnotifierentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DP.Decorator.DAL.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"), 1L, 1);

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageReceiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DP.Decorator.DAL.Notifier", b =>
                {
                    b.Property<int>("NotifierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotifierID"), 1L, 1);

                    b.Property<string>("NotifierChannel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierCreator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotifierID");

                    b.ToTable("Notifiers");
                });
#pragma warning restore 612, 618
        }
    }
}
