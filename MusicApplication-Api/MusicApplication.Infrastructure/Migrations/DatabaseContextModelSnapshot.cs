﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApp.Infrastructure;

namespace MusicApplication.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicApp.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hip Hop"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blues"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dance"
                        });
                });

            modelBuilder.Entity("MusicApp.Core.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistName = "Eminem",
                            CategoryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990),
                            IsFavourite = true,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990),
                            Rating = 5,
                            SongName = "Lose Urself",
                            SongUrl = "https://www.youtube.com/watch?v=_Yhyp-_hX2s"
                        },
                        new
                        {
                            Id = 2,
                            ArtistName = "50 Cent",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2021, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            IsFavourite = true,
                            ModifiedAt = new DateTime(2021, 8, 2, 9, 30, 52, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            SongName = "In Da Club",
                            SongUrl = "https://www.youtube.com/watch?v=5qm8PH4xAss"
                        },
                        new
                        {
                            Id = 3,
                            ArtistName = "The Rolling Stones",
                            CategoryId = 3,
                            CreatedAt = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            IsFavourite = false,
                            ModifiedAt = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            SongName = "Paint It, Black",
                            SongUrl = "https://www.youtube.com/watch?v=O4irXQhgMqg"
                        },
                        new
                        {
                            Id = 4,
                            ArtistName = "The Rolling Stones",
                            CategoryId = 3,
                            CreatedAt = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            IsFavourite = false,
                            ModifiedAt = new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            SongName = "Miss You",
                            SongUrl = "https://www.youtube.com/watch?v=KuRxXRuAz-I"
                        },
                        new
                        {
                            Id = 5,
                            ArtistName = "Stromae",
                            CategoryId = 4,
                            CreatedAt = new DateTime(2012, 2, 2, 1, 30, 52, 0, DateTimeKind.Unspecified),
                            IsFavourite = true,
                            ModifiedAt = new DateTime(2020, 1, 3, 5, 30, 52, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            SongName = "Alors On Danse",
                            SongUrl = "https://www.youtube.com/watch?v=VHoT4N43jK8"
                        });
                });

            modelBuilder.Entity("MusicApp.Core.Entities.Song", b =>
                {
                    b.HasOne("MusicApp.Core.Entities.Category", "Category")
                        .WithMany("Songs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MusicApp.Core.Entities.Category", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
