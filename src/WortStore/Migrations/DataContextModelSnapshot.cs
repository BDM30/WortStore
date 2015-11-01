using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WortStore.Models;

namespace WortStore.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta8-15964")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WortStore.Models.Entities.CustomWord", b =>
                {
                    b.Property<int>("CustomWordID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalMeaning");

                    b.Property<string>("CustomImage");

                    b.Property<int>("WordID");

                    b.HasKey("CustomWordID");
                });

            modelBuilder.Entity("WortStore.Models.Entities.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("LanguageID");
                });

            modelBuilder.Entity("WortStore.Models.Entities.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("ModuleID");
                });

            modelBuilder.Entity("WortStore.Models.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("UserID");
                });

            modelBuilder.Entity("WortStore.Models.Entities.Word", b =>
                {
                    b.Property<int>("WordID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DescrioptionID");

                    b.Property<string>("Image");

                    b.Property<string>("Inscription");

                    b.Property<int>("LanguageFromID");

                    b.Property<int>("LanguageToID");

                    b.Property<string>("Meaning");

                    b.HasKey("WordID");
                });

            modelBuilder.Entity("WortStore.Models.Entities.WordDescription", b =>
                {
                    b.Property<int>("WordDescriptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Additional");

                    b.HasKey("WordDescriptionID");
                });
        }
    }
}
