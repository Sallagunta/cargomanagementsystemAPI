﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cargomanagementsystem.DAL.DATA;

namespace cargomanagementsystem.DAL.Migrations
{
    [DbContext(typeof(cargomanagementDbcontext))]
    partial class cargomanagementDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Admin", b =>
                {
                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminEmail");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Customerdetails", b =>
                {
                    b.Property<int>("custId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("custAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("custPhone")
                        .HasColumnType("int");

                    b.Property<string>("custname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("custpincode")
                        .HasColumnType("int");

                    b.Property<string>("recAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("recID")
                        .HasColumnType("int");

                    b.Property<string>("recNmae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("recPhone")
                        .HasColumnType("int");

                    b.Property<int>("recpincode")
                        .HasColumnType("int");

                    b.Property<string>("rectCity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("custId");

                    b.ToTable("customer_details");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Transaction", b =>
                {
                    b.Property<int>("Bill_no")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Goods_Qty")
                        .HasColumnType("int");

                    b.Property<string>("Receiver_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sender_id")
                        .HasColumnType("int");

                    b.Property<string>("Sending_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trans_amount")
                        .HasColumnType("int");

                    b.Property<string>("Type_of_goods")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bill_no");

                    b.HasIndex("Sender_id");

                    b.ToTable("transaction");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.cargomanagementRegister", b =>
                {
                    b.Property<string>("CustEmailid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Confirmpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mobile")
                        .HasColumnType("int");

                    b.HasKey("CustEmailid");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("cargomanagementsystem.Entity.Model.Transaction", b =>
                {
                    b.HasOne("cargomanagementsystem.Entity.Model.Customerdetails", "cust_id")
                        .WithMany()
                        .HasForeignKey("Sender_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cust_id");
                });
#pragma warning restore 612, 618
        }
    }
}
