// <auto-generated />
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HairSalon.Migrations
{
  [DbContext(typeof(HairSalonContext))]
  partial class HairSalonContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
    modelBuilder
      .HasAnnotation("ProductVersion", "6.0.0")
      .HasAnnotation("Relational:MaxIdentifierLength", 64);

  modelBuilder.Entity("HairSalon.Models.Stylist", b =>
      {
        b.Property<int>("StylistId")
        .ValueGeneratedOnAdd()
        .HasColumnType("int");

        b.Property<string>("Name")
        .HasColumnType("longtext");
            
        b.Property<string>("TalentSpec")
        .HasColumnType("longtext");

        b.HasKey("StylistId");

        b.ToTable("Stylists");
      });

  modelBuilder.Entity("HairSalon.Models.Client", b =>
      {
        b.Property<int>("ClientId")
        .ValueGeneratedOnAdd()
        .HasColumnType("int");

        b.Property<int>("StylistId")
        .HasColumnType("int");

        b.Property<string>("Name")
        .HasColumnType("longtext");

        b.Property<string>("PhoneNumber")
        .HasColumnType("longtext");

        b.HasKey("ClientId");

        b.HasIndex("StylistId");

        b.ToTable("Clients");
      });

  modelBuilder.Entity("HairSalon.Models.Client", b =>
      {
        b.HasOne("HairSalon.Models.Stylist", "stylist")
        .WithMany("Clients")
        .HasForeignKey("StylistId")
        .OnDelete(DeleteBehavior.Cascade)
        .IsRequired();

        b.Navigation("stylist");
      });

  modelBuilder.Entity("HairSalon.Models.Stylist", b =>
      {
        b.Navigation("Clients");
      });
#pragma warning restore 612, 618
    }
  }
}