using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VTQNetCoreCrud.Data;

#nullable disable

namespace VTQNetCoreCrud.Migrations
{
    [DbContext(typeof(VTQAppDbContext))]
    partial class VTQAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("VTQNetCoreCrud.Models.VTQCategory", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<byte>("Status")
                    .HasColumnType("tinyint");

                b.HasKey("Id");

                b.ToTable("VTQCategory");
            });

            modelBuilder.Entity("VTQNetCoreCrud.Models.VTQProduct", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int>("CategoryId")
                    .HasColumnType("int");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Descriptions")
                    .HasMaxLength(1000)
                    .HasColumnType("ntext");

                b.Property<string>("Image")
                    .HasMaxLength(150)
                    .HasColumnType("varchar(150)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnType("nvarchar(150)");

                b.Property<float>("Price")
                    .HasColumnType("real");

                b.Property<float>("SalePrice")
                    .HasColumnType("real");

                b.Property<byte>("Status")
                    .HasColumnType("tinyint");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("VTQProduct");
            });

            modelBuilder.Entity("VTQNetCoreCrud.Models.VTQProduct", b =>
            {
                b.HasOne("VTQNetCoreCrud.Models.VTQCategory", "Category")
                    .WithMany("Products")
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Category");
            });

            modelBuilder.Entity("VTQNetCoreCrud.Models.VTQCategory", b =>
            {
                b.Navigation("Products");
            });
#pragma warning restore 612, 618
        }
    }
}
