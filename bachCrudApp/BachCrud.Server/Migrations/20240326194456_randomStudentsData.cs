using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BachCrud.Server.Migrations
{
    /// <inheritdoc />
    public partial class randomStudentsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IKT-205" },
                    { 2, "IKT-206" },
                    { 3, "IKT-203" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[,]
                {
                    { 1, 23, 1, "mohamedzekaria@uia.no", "knaan", "Mohamed", "0045845858", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 24, 2, "moham@uia.no", "zeka", "Mohamed", "0045845858", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 25, 3, "mo@uia.no", "Mo", "Ali", "004348", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 25, 2, "mo@uia.no", "Mo", "Ali", "004348", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 32, 1, "alix1@uia.no", "Alix", "Buster", "4867971", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 40, 2, "allyson2@uia.no", "Allyson", "Burma", "4867972", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 7, 25, 2, "alisa3@uia.no", "Alisa", "Burt", "4867973", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 8, 24, 3, "alisa4@uia.no", "Alisa", "Buster", "4867974", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 9, 32, 2, "alita5@uia.no", "Alita", "Calista", "4867975", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 10, 41, 2, "alline6@uia.no", "Alline", "Bulah", "4867976", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 11, 35, 1, "allyn7@uia.no", "Allyn", "Caitlyn", "4867977", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 12, 37, 3, "allyson8@uia.no", "Allyson", "Callie", "4867978", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 13, 44, 3, "allan9@uia.no", "Allan", "Buster", "4867979", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 14, 41, 1, "alex 10@uia.no", "Alex ", "Buffy", "48679710", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 15, 33, 2, "allan11@uia.no", "Allan", "Caitlin", "48679711", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 16, 34, 3, "alisa12@uia.no", "Alisa", "Buster", "48679712", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 17, 31, 2, "alisia13@uia.no", "Alisia", "Camellia", "48679713", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 18, 40, 3, "alix14@uia.no", "Alix", "Calista", "48679714", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 19, 33, 2, "alla15@uia.no", "Alla", "Burt", "48679715", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 20, 36, 2, "alisia16@uia.no", "Alisia", "Byron", "48679716", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 21, 28, 2, "allene17@uia.no", "Allene", "Burt", "48679717", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 22, 36, 1, "allan18@uia.no", "Allan", "Bulah", "48679718", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 23, 38, 2, "alleen19@uia.no", "Alleen", "Buffy", "48679719", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 24, 30, 2, "allyson20@uia.no", "Allyson", "Caitlyn", "48679720", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
