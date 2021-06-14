﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scruffy.Data.Entity;

namespace Scruffy.Data.Entity.Migrations
{
    [DbContext(typeof(ScruffyDbContext))]
    partial class ScruffyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.CoreData.ServerConfigurationEntity", b =>
                {
                    b.Property<decimal>("ServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServerId");

                    b.ToTable("ServerConfigurationEntity");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.CoreData.UserEntity", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<DateTime>("CreationTimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Fractals.FractalAppointmentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<long>("ConfigurationId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("MessageId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("ConfigurationId");

                    b.ToTable("FractalAppointments");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Fractals.FractalLfgConfigurationEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AliasName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MessageId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FractalLfgConfigurations");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Fractals.FractalRegistrationEntity", b =>
                {
                    b.Property<long>("ConfigurationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("AppointmentTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<long?>("AppointmentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("RegistrationTimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ConfigurationId", "AppointmentTimeStamp", "UserId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("FractalRegistrations");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.General.LogEntryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualifiedCommandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LogEntries");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidAppointmentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ConfigurationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ConfigurationId");

                    b.ToTable("RaidAppointments");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidDayConfigurationEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AdministrationRoleId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<decimal>("MessageId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<TimeSpan>("RegistrationDeadline")
                        .HasColumnType("time");

                    b.Property<decimal?>("ReminderChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<TimeSpan?>("ReminderTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("ResetTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("RaidDayConfigurations");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidDayTemplateEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AliasName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RaidDayTemplates");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidExperienceAssignmentEntity", b =>
                {
                    b.Property<long>("ConfigurationId")
                        .HasColumnType("bigint");

                    b.Property<long>("ExperienceLevelId")
                        .HasColumnType("bigint");

                    b.Property<long>("Count")
                        .HasColumnType("bigint");

                    b.HasKey("ConfigurationId", "ExperienceLevelId");

                    b.HasIndex("ExperienceLevelId");

                    b.ToTable("RaidExperienceAssignments");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidExperienceLevelEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("DiscordRoleId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<long?>("SuperiorExperienceLevelId")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SuperiorExperienceLevelId");

                    b.ToTable("RaidExperienceLevels");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRegistrationEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AppointmentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("Points")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("RegistrationTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("UserId");

                    b.ToTable("RaidRegistrations");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRegistrationRoleAssignmentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MainRoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("RegistrationId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SubRoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MainRoleId");

                    b.HasIndex("RegistrationId");

                    b.HasIndex("SubRoleId");

                    b.ToTable("RaidRegistrationRoleAssignments");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRequiredRoleEntity", b =>
                {
                    b.Property<long>("ConfigurationId")
                        .HasColumnType("bigint");

                    b.Property<long>("Index")
                        .HasColumnType("bigint");

                    b.Property<long>("MainRoleId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SubRoleId")
                        .HasColumnType("bigint");

                    b.HasKey("ConfigurationId", "Index");

                    b.HasIndex("MainRoleId");

                    b.HasIndex("SubRoleId");

                    b.ToTable("RaidRequiredRoles");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRoleAliasNameEntity", b =>
                {
                    b.Property<string>("AliasName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("MainRoleId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SubRoleId")
                        .HasColumnType("bigint");

                    b.HasKey("AliasName");

                    b.HasIndex("MainRoleId");

                    b.HasIndex("SubRoleId");

                    b.ToTable("RaidRoleAliasNames");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscordEmojiId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("MainRoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MainRoleId");

                    b.ToTable("RaidRoles");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidUserRoleEntity", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<long>("MainRoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("SubRoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "MainRoleId", "SubRoleId");

                    b.HasIndex("MainRoleId");

                    b.HasIndex("SubRoleId");

                    b.ToTable("RaidUserRoles");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Reminder.OneTimeReminderEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<bool>("IsExecuted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("OneTimeReminders");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Reminder.WeeklyReminderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("DeletionTime")
                        .HasColumnType("time");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MessageId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<TimeSpan>("PostTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("WeeklyReminders");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Fractals.FractalAppointmentEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Fractals.FractalLfgConfigurationEntity", "FractalLfgConfiguration")
                        .WithMany()
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FractalLfgConfiguration");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Fractals.FractalRegistrationEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Fractals.FractalAppointmentEntity", "FractalAppointmentEntity")
                        .WithMany()
                        .HasForeignKey("AppointmentId");

                    b.HasOne("Scruffy.Data.Entity.Tables.Fractals.FractalLfgConfigurationEntity", "FractalLfgConfiguration")
                        .WithMany("FractalRegistrations")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FractalAppointmentEntity");

                    b.Navigation("FractalLfgConfiguration");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidAppointmentEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidDayConfigurationEntity", "RaidDayConfiguration")
                        .WithMany("RaidAppointments")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RaidDayConfiguration");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidExperienceAssignmentEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidDayConfigurationEntity", "RaidDayConfiguration")
                        .WithMany("RaidExperienceAssignments")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidExperienceLevelEntity", "RaidExperienceLevel")
                        .WithMany("RaidExperienceAssignments")
                        .HasForeignKey("ExperienceLevelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RaidDayConfiguration");

                    b.Navigation("RaidExperienceLevel");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidExperienceLevelEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidExperienceLevelEntity", "SuperiorRaidExperienceLevel")
                        .WithMany("InferiorRaidExperienceLevels")
                        .HasForeignKey("SuperiorExperienceLevelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SuperiorRaidExperienceLevel");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRegistrationEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidAppointmentEntity", "RaidAppointment")
                        .WithMany("RaidRegistrations")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.CoreData.UserEntity", "User")
                        .WithMany("RaidRegistrations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("RaidAppointment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRegistrationRoleAssignmentEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "MainRaidRole")
                        .WithMany()
                        .HasForeignKey("MainRoleId");

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRegistrationEntity", "RaidRegistration")
                        .WithMany("RaidRegistrationRoleAssignments")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "SubRaidRole")
                        .WithMany()
                        .HasForeignKey("SubRoleId");

                    b.Navigation("MainRaidRole");

                    b.Navigation("RaidRegistration");

                    b.Navigation("SubRaidRole");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRequiredRoleEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidDayConfigurationEntity", "RaidDayConfiguration")
                        .WithMany("RaidRequiredRoles")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "MainRaidRole")
                        .WithMany()
                        .HasForeignKey("MainRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "SubRaidRole")
                        .WithMany()
                        .HasForeignKey("SubRoleId");

                    b.Navigation("MainRaidRole");

                    b.Navigation("RaidDayConfiguration");

                    b.Navigation("SubRaidRole");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRoleAliasNameEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "MainRaidRole")
                        .WithMany()
                        .HasForeignKey("MainRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "SubRaidRole")
                        .WithMany()
                        .HasForeignKey("SubRoleId");

                    b.Navigation("MainRaidRole");

                    b.Navigation("SubRaidRole");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "MainRaidRole")
                        .WithMany("SubRaidRoles")
                        .HasForeignKey("MainRoleId");

                    b.Navigation("MainRaidRole");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidUserRoleEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "MainRaidRole")
                        .WithMany()
                        .HasForeignKey("MainRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", "SubRaidRole")
                        .WithMany()
                        .HasForeignKey("SubRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scruffy.Data.Entity.Tables.CoreData.UserEntity", "User")
                        .WithMany("RaidUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("MainRaidRole");

                    b.Navigation("SubRaidRole");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Reminder.OneTimeReminderEntity", b =>
                {
                    b.HasOne("Scruffy.Data.Entity.Tables.CoreData.UserEntity", "User")
                        .WithMany("OneTimeReminders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.CoreData.UserEntity", b =>
                {
                    b.Navigation("OneTimeReminders");

                    b.Navigation("RaidRegistrations");

                    b.Navigation("RaidUserRoles");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Fractals.FractalLfgConfigurationEntity", b =>
                {
                    b.Navigation("FractalRegistrations");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidAppointmentEntity", b =>
                {
                    b.Navigation("RaidRegistrations");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidDayConfigurationEntity", b =>
                {
                    b.Navigation("RaidAppointments");

                    b.Navigation("RaidExperienceAssignments");

                    b.Navigation("RaidRequiredRoles");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidExperienceLevelEntity", b =>
                {
                    b.Navigation("InferiorRaidExperienceLevels");

                    b.Navigation("RaidExperienceAssignments");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRegistrationEntity", b =>
                {
                    b.Navigation("RaidRegistrationRoleAssignments");
                });

            modelBuilder.Entity("Scruffy.Data.Entity.Tables.Raid.RaidRoleEntity", b =>
                {
                    b.Navigation("SubRaidRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
