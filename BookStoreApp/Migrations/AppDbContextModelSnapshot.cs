﻿// <auto-generated />
using System;
using VirginMegastoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VirginMegastoreApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookStoreApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Electronics"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Clothes"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Books"
                        });
                });

            modelBuilder.Entity("BookStoreApp.Models.Product", b =>
                {
                    b.Property<int>("Product_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_ID"), 1L, 1);

                    b.Property<int?>("CategoryID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("CoverPhoto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Product_ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_ID = 1,
                            CategoryID = 1,
                            CoverPhoto = "pic1.jpg",
                            Description = "Quiet Click Mouse with Ultra - Quiet Scrolling: Enjoy an ultra - quiet experience with over 90 % noise reduction(1) on the click sound - even the wide rubber scroll wheel glides in silence",
                            Price = 109.0,
                            Product_Name = "Logitech Pebble Wireless Mouse"
                        },
                        new
                        {
                            Product_ID = 2,
                            CategoryID = 1,
                            CoverPhoto = "pic2.jpg",
                            Description = "PRO-II EVO is the Ducati electric scooter that surprises and conquers the road thanks to the double suspension and the control offered by the connection to the Ducati Urban e-Mobility App",
                            Price = 3499.0,
                            Product_Name = "Ducati Pro II Evo Electric Scooter"
                        },
                        new
                        {
                            Product_ID = 3,
                            CategoryID = 1,
                            CoverPhoto = "pic3.jpg",
                            Description = "The original Hypervolt with some serious upgrades - lighter, more powerful, and a newly designed ergonomic handle. Give your muscles the daily relief they've been asking for with the Hypervolt 2's percussion massage. Warm up quickly, stay loose, and accelerate recovery at home and beyond - so you're ready to tackle whatever comes next. ",
                            Price = 1049.0,
                            Product_Name = "Hyperice Hypervolt 2 - Percussion Massager"
                        },
                        new
                        {
                            Product_ID = 4,
                            CategoryID = 1,
                            CoverPhoto = "pic4.jpg",
                            Description = "Apple Watch Series 8 is a powerful health companion. Featuring advanced health sensors and apps, so you can take an ECG, measure heart rate and blood oxygen, and track temperature changes for advanced insights into your menstrual cycle",
                            Price = 3199.0,
                            Product_Name = "Apple Watch Ultra GPS + Cellular 49mm Gold Titanium Case with Starlight Alpine Loop - Medium"
                        },
                        new
                        {
                            Product_ID = 5,
                            CategoryID = 2,
                            CoverPhoto = "pic5.jpg",
                            Description = "Is your little one into video games? Do you feel a sense of nostalgia when it comes to Super Mario? We've got the answer to your sentimentality and his gaming right here. Power-up his wardrobe with this colorful Super Mario™ suit. Covered in an all-over print with all the iconic characters from the Mushroom Kingdom, he’ll win the outfit game for sure.",
                            Price = 279.0,
                            Product_Name = "Opposuits Nintendo Super Mario Kids Costume Suit"
                        },
                        new
                        {
                            Product_ID = 6,
                            CategoryID = 2,
                            CoverPhoto = "pic6.jpg",
                            Description = "Crew neck, short-sleeved t-shirt",
                            Price = 159.0,
                            Product_Name = "Mister Tee Le Papillon Men's Oversize T-Shirt - White"
                        },
                        new
                        {
                            Product_ID = 7,
                            CategoryID = 2,
                            CoverPhoto = "pic7.jpg",
                            Description = "Trucker Snapback Cap with Cotton Sweatband ",
                            Price = 169.0,
                            Product_Name = "Goorin Bros The Panther Unisex Trucker Cap Orange"
                        },
                        new
                        {
                            Product_ID = 8,
                            CategoryID = 2,
                            CoverPhoto = "pic8.jpg",
                            Description = "This cap is made from premium quality material with professional stitching, for excellent comfort and is official licensed merchandise from Star Wars",
                            Price = 26.0,
                            Product_Name = "Difuzed Star Wars Galaxy Snapback Cap Black"
                        },
                        new
                        {
                            Product_ID = 9,
                            CategoryID = 3,
                            CoverPhoto = "pic9.jpg",
                            Description = "It's time for bed but Peppa and George are absolutely, definitely, not even a little bit tired in this delightful brand new picture book. A bedtime story from Granny Pig, Grandpa Pig, Daddy Pig AND Mummy Pig should send them to sleep ...Shouldn't it? This picture book story is perfect for reading at bedtime, playtime and over and over again! Based on the hit preschool animation Peppa Pig, shown daily on Five's Milkshake and Nick Jnr. ",
                            Price = 49.0,
                            Product_Name = "Peppa Pig Goodnight Peppa | Peppa Pig"
                        },
                        new
                        {
                            Product_ID = 10,
                            CategoryID = 3,
                            CoverPhoto = "pic10.jpg",
                            Description = "Read, hear, and sing the hit song from Frozen 2, Into the Unknown, with this gorgeous illustrated songbook. Press 5 buttons to play the melody and practice on your own, then press the big button to sing the whole song with Elsa! Lyrics are printed in the book.",
                            Price = 69.0,
                            Product_Name = "Little Music Note | Pi Kids"
                        },
                        new
                        {
                            Product_ID = 11,
                            CategoryID = 3,
                            CoverPhoto = "pic11.jpg",
                            Description = "Go back to the Space Race with No.1 bestselling author David Walliams for a breathless cinematic adventure full of mystery, action, laughs and surprises - and a secret that could change the course of history..",
                            Price = 85.0,
                            Product_Name = "Spaceboy | David Walliams"
                        },
                        new
                        {
                            Product_ID = 12,
                            CategoryID = 3,
                            CoverPhoto = "pic12.jpg",
                            Description = "Learn 1000 first words with Peppa Pig in this fantastic new bumper sticker book! ",
                            Price = 55.0,
                            Product_Name = "Peppa Pig 1000 First Words Sticker Book | Peppa Pig"
                        });
                });

            modelBuilder.Entity("BookStoreApp.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewID"), 1L, 1);

                    b.Property<string>("AppUserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Product_ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewID = 1,
                            Comment = "A nice mouse to use",
                            Product_ID = 1,
                            Rating = 3,
                            ReviewDate = new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 2,
                            Comment = "best electric scooter",
                            Product_ID = 2,
                            Rating = 4,
                            ReviewDate = new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 3,
                            Comment = "Good for back massage",
                            Product_ID = 3,
                            Rating = 3,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 4,
                            Comment = "Very advanced",
                            Product_ID = 4,
                            Rating = 4,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 5,
                            Comment = " I love the color",
                            Product_ID = 5,
                            Rating = 4,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 6,
                            Comment = "Not the best fabric",
                            Product_ID = 6,
                            Rating = 1,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 7,
                            Comment = "didn’t like it",
                            Product_ID = 7,
                            Rating = 2,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 8,
                            Comment = "very comfy",
                            Product_ID = 8,
                            Rating = 3,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 9,
                            Comment = "useful",
                            Product_ID = 9,
                            Rating = 4,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 10,
                            Comment = "my kid enjoyed the book",
                            Product_ID = 10,
                            Rating = 4,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 11,
                            Comment = "very entertaining for kids",
                            Product_ID = 11,
                            Rating = 3,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReviewID = 12,
                            Comment = "A good book",
                            Product_ID = 12,
                            Rating = 4,
                            ReviewDate = new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "06bf33f6-a357-4e06-ba96-a2423df97e1e",
                            ConcurrencyStamp = "0a8f4ba9-5f83-4a2b-aa84-8562ca517d1a",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "7f638a0d-592b-4ed9-bfaf-25a32bcd330f",
                            ConcurrencyStamp = "4839a0f6-0942-47b8-84ed-fa3e163aaf89",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1d5189a3-bf38-4859-be69-ef4167259d2c",
                            RoleId = "06bf33f6-a357-4e06-ba96-a2423df97e1e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookStoreApp.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "1d5189a3-bf38-4859-be69-ef4167259d2c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "057ec276-b2eb-4633-8638-cea983ba55f4",
                            Email = "admin@virginMegastore.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@VIRGINMEGASTORE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECWGmsdu45wMS+hCT94B7AfYnPgzWyhjy06ZqBrvDsCAAUILeT3IIwWHMWn3oVIA1Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "31b551c0-137d-4035-a6bf-81a7d10e7071",
                            TwoFactorEnabled = false,
                            UserName = "admin@virginMegastore.com",
                            FirstName = "Admin",
                            LastName = "User"
                        });
                });

            modelBuilder.Entity("BookStoreApp.Models.Product", b =>
                {
                    b.HasOne("BookStoreApp.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookStoreApp.Models.Review", b =>
                {
                    b.HasOne("BookStoreApp.Models.ApplicationUser", null)
                        .WithMany("Reviews")
                        .HasForeignKey("AppUserID");

                    b.HasOne("BookStoreApp.Models.Product", "product")
                        .WithMany("Reviews")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStoreApp.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BookStoreApp.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookStoreApp.Models.ApplicationUser", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
