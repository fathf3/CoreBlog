﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230501201737_add_mig_message2")]
    partial class add_mig_message2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("aboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("aboutId"), 1L, 1);

                    b.Property<string>("aboutDetails1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutDetails2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutImage2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutMapLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("aboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("aboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Property<int>("blogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("blogId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("blogContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("blogCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("blogStatus")
                        .HasColumnType("bit");

                    b.Property<string>("blogThumbnailImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blogTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloglImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("writerId")
                        .HasColumnType("int");

                    b.HasKey("blogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("writerId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.BlogRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.Property<int>("blogRaytingCount")
                        .HasColumnType("int");

                    b.Property<int>("blogTotalScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BlogRatings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"), 1L, 1);

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("categoryStatus")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.Property<int>("blogScore")
                        .HasColumnType("int");

                    b.Property<string>("commentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("commentCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("commentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("commentTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("commentUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("blogId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contactId"), 1L, 1);

                    b.Property<DateTime>("contactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("contactMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("contactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("contactSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("contactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message", b =>
                {
                    b.Property<int>("messageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("messageId"), 1L, 1);

                    b.Property<DateTime>("messageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("messageDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("messageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("receiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messageId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.Property<int>("messageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("messageId"), 1L, 1);

                    b.Property<DateTime>("messageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("messageDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("messageStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("receiverId")
                        .HasColumnType("int");

                    b.Property<int?>("senderId")
                        .HasColumnType("int");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messageId");

                    b.HasIndex("receiverId");

                    b.HasIndex("senderId");

                    b.ToTable("Messages2");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLatter", b =>
                {
                    b.Property<int>("mailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("mailId"), 1L, 1);

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("mailStatus")
                        .HasColumnType("bit");

                    b.HasKey("mailId");

                    b.ToTable("NewsLatters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Notification", b =>
                {
                    b.Property<int>("notificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("notificationId"), 1L, 1);

                    b.Property<DateTime>("notificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("notificationDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("notificationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("notificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notificationTypeSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("notificationId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriterId"), 1L, 1);

                    b.Property<string>("writerAbout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("writerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("writerStatus")
                        .HasColumnType("bit");

                    b.HasKey("WriterId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Writer", "writer")
                        .WithMany("blogs")
                        .HasForeignKey("writerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("writer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Blog", "blogs")
                        .WithMany("comments")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Writer", "ReceiverUser")
                        .WithMany("WriterReceiver")
                        .HasForeignKey("receiverId");

                    b.HasOne("EntityLayer.Concrete.Writer", "SenderUser")
                        .WithMany("WriterSender")
                        .HasForeignKey("senderId");

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Blog", b =>
                {
                    b.Navigation("comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Writer", b =>
                {
                    b.Navigation("WriterReceiver");

                    b.Navigation("WriterSender");

                    b.Navigation("blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
