using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachCrud.Server.Migrations
{
    /// <inheritdoc />
    public partial class productionDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 3, "allan1@uia.no", "Allan", "Caleb", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, "allena2@uia.no", "Allena", "Calista", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 3, "allene3@uia.no", "Allene", "Calvin", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 1, "allene4@uia.no", "Allene", "Buford", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 21, 3, "aliza5@uia.no", "Aliza", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 3, "alisia6@uia.no", "Alisia", "Camelia", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "alla7@uia.no", "Alla", "Calandra", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 2, "allyn8@uia.no", "Allyn", "Bulah", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 2, "aliza9@uia.no", "Aliza", "Bunny", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, "alita10@uia.no", "Alita", "Camellia", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "LastName", "RegistrationDate" },
                values: new object[] { 40, "Calvin", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, "allie12@uia.no", "Allie", "Camelia", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "LastName", "RegistrationDate" },
                values: new object[] { 20, 3, "Buster", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 1, "allyn14@uia.no", "Allyn", "Buffy", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 1, "allen15@uia.no", "Allen", "Camelia", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 1, "alex 16@uia.no", "Alex ", "Buffy", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 3, "alita17@uia.no", "Alita", "Callie", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 2, "allison18@uia.no", "Allison", "Caitlyn", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "allie19@uia.no", "Allie", "Caitlin", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 1, "allie20@uia.no", "Allie", "Bunny", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 1, "alix1@uia.no", "Alix", "Buster", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "allyson2@uia.no", "Allyson", "Burma", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, 2, "alisa3@uia.no", "Alisa", "Burt", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, 3, "alisa4@uia.no", "Alisa", "Buster", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 32, 2, "alita5@uia.no", "Alita", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 2, "alline6@uia.no", "Alline", "Bulah", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, "allyn7@uia.no", "Allyn", "Caitlyn", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 3, "allyson8@uia.no", "Allyson", "Callie", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 3, "allan9@uia.no", "Allan", "Buster", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, "alex 10@uia.no", "Alex ", "Buffy", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "LastName", "RegistrationDate" },
                values: new object[] { 33, "Caitlin", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, "alisa12@uia.no", "Alisa", "Buster", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "LastName", "RegistrationDate" },
                values: new object[] { 31, 2, "Camellia", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 3, "alix14@uia.no", "Alix", "Calista", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 2, "alla15@uia.no", "Alla", "Burt", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 2, "alisia16@uia.no", "Alisia", "Byron", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 2, "allene17@uia.no", "Allene", "Burt", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 1, "allan18@uia.no", "Allan", "Bulah", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "alleen19@uia.no", "Alleen", "Buffy", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 2, "allyson20@uia.no", "Allyson", "Caitlyn", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
