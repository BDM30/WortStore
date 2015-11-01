using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace WortStore.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomWord",
                columns: table => new
                {
                    CustomWordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdditionalMeaning = table.Column<string>(nullable: true),
                    CustomImage = table.Column<string>(nullable: true),
                    WordID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomWord", x => x.CustomWordID);
                });
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageID);
                });
            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleID);
                });
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    WordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescrioptionID = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Inscription = table.Column<string>(nullable: true),
                    LanguageFromID = table.Column<int>(nullable: false),
                    LanguageToID = table.Column<int>(nullable: false),
                    Meaning = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.WordID);
                });
            migrationBuilder.CreateTable(
                name: "WordDescription",
                columns: table => new
                {
                    WordDescriptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Additional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordDescription", x => x.WordDescriptionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("CustomWord");
            migrationBuilder.DropTable("Language");
            migrationBuilder.DropTable("Module");
            migrationBuilder.DropTable("User");
            migrationBuilder.DropTable("Word");
            migrationBuilder.DropTable("WordDescription");
        }
    }
}
