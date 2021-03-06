// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticeFinal.Models;

namespace PracticeFinal.Migrations
{
    [DbContext(typeof(RestaurantsContext))]
    partial class RestaurantsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("PracticeFinal.Models.RestaurantInfo", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RestaurantId");

                    b.ToTable("Info");
                });
#pragma warning restore 612, 618
        }
    }
}
