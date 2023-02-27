using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class sanjay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    restaurant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    foodtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "generalProblems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_generalProblems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moviename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieStory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    budget = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "politics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    politicianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    party = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_politics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "startupIdeas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    investmentAmount = table.Column<int>(type: "int", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_startupIdeas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "technology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gadgetname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    launchdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    prize = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_technology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryUploadedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Universityname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    courseOffered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fee = table.Column<int>(type: "int", nullable: true),
                    EstablishedYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_universities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "food");

            migrationBuilder.DropTable(
                name: "generalProblems");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "politics");

            migrationBuilder.DropTable(
                name: "startupIdeas");

            migrationBuilder.DropTable(
                name: "technology");

            migrationBuilder.DropTable(
                name: "universities");
        }
    }
}
