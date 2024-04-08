using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachCrud.Server.Migrations
{
    /// <inheritdoc />
    public partial class trialsDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 1, "moody1@uia.no", "Moody", "Joe", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, 3, "alisa2@uia.no", "Alisa", "Nathan", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "trussel3@uia.no", "Trussel", "Buffy", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "schlicht4@uia.no", "Schlicht", "Joe", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 3, "allen5@uia.no", "Allen", "Camelia", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 2, "roberts6@uia.no", "Roberts", "Ty", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 3, "lepage7@uia.no", "LePage", "Camellia", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 1, "mccormack8@uia.no", "McCormack", "Calista", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, 3, "boyd9@uia.no", "Boyd", "Larry", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 1, "lawless10@uia.no", "Lawless", "Monte", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 1, "fletcher11@uia.no", "Fletcher", "Jack", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 3, "sellon12@uia.no", "Sellon", "Roger", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 2, "anderson13@uia.no", "Anderson", "David", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 2, "allyn14@uia.no", "Allyn", "Caleb", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 3, "chapman15@uia.no", "Chapman", "Paul", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "LastName", "RegistrationDate" },
                values: new object[] { 39, 2, "Byron", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, "tiernan17@uia.no", "Tiernan", "Edward", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "reamer18@uia.no", "Reamer", "Ben", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "tisler19@uia.no", "Tisler", "John", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 2, "celedon20@uia.no", "Celedon", "Walter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, "schutz21@uia.no", "Schutz", "Joe", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, "allyn22@uia.no", "Allyn", "Fred", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, 2, "eastman23@uia.no", "Eastman", "Roger", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 3, "root24@uia.no", "Root", "Fred", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "nuttle25@uia.no", "Nuttle", "Camellia", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 1, "uddin26@uia.no", "Uddin", "Frank", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, 1, "soulis27@uia.no", "Soulis", "Ty", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 2, "tandy28@uia.no", "Tandy", "Aaron", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 2, "wagner29@uia.no", "Wagner", "Burt", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 3, "trussel30@uia.no", "Trussel", "Dan", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, "allen31@uia.no", "Allen", "Burl", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "sweeney32@uia.no", "Sweeney", "Larry", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, "alla33@uia.no", "Alla", "Edward", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 1, "pak34@uia.no", "Pak", "Hank", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, "lewis35@uia.no", "Lewis", "Caitlin", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "allen36@uia.no", "Allen", "Buford", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 3, "yates37@uia.no", "Yates", "Walter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, "soloman38@uia.no", "Soloman", "Victor", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 1, "ashwoon39@uia.no", "Ashwoon", "Paul", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 2, "alleen40@uia.no", "Alleen", "Bula", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, "allegra41@uia.no", "Allegra", "Burl", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 3, "jagtap42@uia.no", "Jagtap", "Dan", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, "norquist43@uia.no", "Norquist", "Ty", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 1, "anderson44@uia.no", "Anderson", "Hank", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, "alline45@uia.no", "Alline", "Walter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 2, "zeller46@uia.no", "Zeller", "Burton", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "allen47@uia.no", "Allen", "Victor", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 2, "kaskel48@uia.no", "Kaskel", "Frank", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, "trebil49@uia.no", "Trebil", "Tim", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "allegra50@uia.no", "Allegra", "John", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 3, "lewis51@uia.no", "Lewis", "Roger", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, "deitz52@uia.no", "Deitz", "Burl", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, "aikin53@uia.no", "Aikin", "Walter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, "hylan54@uia.no", "Hylan", "Bula", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, "mcginnis55@uia.no", "McGinnis", "Burma", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, "baxster56@uia.no", "Baxster", "David", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, "mccord57@uia.no", "Mccord", "Joe", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 3, "soulis58@uia.no", "Soulis", "Thomas", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 3, "soukup59@uia.no", "Soukup", "Walter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "nelson60@uia.no", "Nelson", "Caleb", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 1, "thompson61@uia.no", "Thompson", "Calandra", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 2, "orwig62@uia.no", "Orwig", "Callie", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 3, "norquist63@uia.no", "Norquist", "Buford", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, "yates64@uia.no", "Yates", "Peter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 2, "haworth65@uia.no", "Haworth", "Calista", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, "soloman66@uia.no", "Soloman", "Edward", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, 2, "bauer67@uia.no", "Bauer", "George", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 1, "allena68@uia.no", "Allena", "Burt", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 3, "allegra69@uia.no", "Allegra", "Tim", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, "aliza70@uia.no", "Aliza", "Otto", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 1, "irwin71@uia.no", "Irwin", "Matthew", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 2, "orwig72@uia.no", "Orwig", "Ike", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 1, "bauer73@uia.no", "Bauer", "Nathan", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 2, "quizoz74@uia.no", "Quizoz", "Ty", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 2, "tapia75@uia.no", "Tapia", "Fred", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 3, "cannon76@uia.no", "Cannon", "Buford", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 1, "schlicht77@uia.no", "Schlicht", "Caitlyn", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 2, "cannon78@uia.no", "Cannon", "Calandra", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 3, "soulis79@uia.no", "Soulis", "Paul", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 1, "ferro80@uia.no", "Ferro", "Caitlyn", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 1, "lawicki81@uia.no", "Lawicki", "Roger", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 3, "bongard82@uia.no", "Bongard", "Mark", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "kassing83@uia.no", "Kassing", "Buffy", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 2, "wakefield84@uia.no", "Wakefield", "Matthew", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 2, "uddin85@uia.no", "Uddin", "David", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "allie86@uia.no", "Allie", "Victor", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, "yang87@uia.no", "Yang", "Caitlyn", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "davis88@uia.no", "Davis", "Edward", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, "trussel89@uia.no", "Trussel", "Matthew", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "pak90@uia.no", "Pak", "David", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, "olson91@uia.no", "Olson", "Mark", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, "caswell92@uia.no", "Caswell", "Victor", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 1, "allie93@uia.no", "Allie", "Calista", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, "baxster94@uia.no", "Baxster", "Walter", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, "mcginnis95@uia.no", "McGinnis", "Nathan", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "weiss96@uia.no", "Weiss", "Mark", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 3, "ulrich1@uia.no", "Ulrich", "Victor", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, 2, "doran2@uia.no", "Doran", "Edward", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, "casal3@uia.no", "Casal", "Buford", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 1, "tandy4@uia.no", "Tandy", "Roger", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, 2, "uddin5@uia.no", "Uddin", "Bunny", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 3, "kassing6@uia.no", "Kassing", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 1, "weinstein7@uia.no", "Weinstein", "Buffy", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "tiernan8@uia.no", "Tiernan", "Steve", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 1, "schuster9@uia.no", "Schuster", "Aaron", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 2, "sweeney10@uia.no", "Sweeney", "Calandra", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 2, "davis11@uia.no", "Davis", "Hank", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, 2, "sonderling12@uia.no", "Sonderling", "Carl", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 1, "schwager13@uia.no", "Schwager", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "davidson14@uia.no", "Davidson", "Larry", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, 2, "allie15@uia.no", "Allie", "Caitlin", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "LastName", "RegistrationDate" },
                values: new object[] { 36, 3, "Monte", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, "johnson17@uia.no", "Johnson", "Fred", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 1, "hoffman18@uia.no", "Hoffman", "Caitlin", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, "mccormack19@uia.no", "McCormack", "Buster", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 1, "nugent20@uia.no", "Nugent", "Callie", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, "leisinger21@uia.no", "Leisinger", "Callie", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "soukup22@uia.no", "Soukup", "David", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 1, "sonderling23@uia.no", "Sonderling", "Edward", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 1, "alline24@uia.no", "Alline", "Bulah", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "knutson25@uia.no", "Knutson", "Edward", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 2, "allene26@uia.no", "Allene", "Burton", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, 2, "allyson27@uia.no", "Allyson", "Bula", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 3, "fietzer28@uia.no", "Fietzer", "Buster", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, 3, "schickowski29@uia.no", "Schickowski", "Thomas", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 2, "sawyer30@uia.no", "Sawyer", "Bunny", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, "hancock31@uia.no", "Hancock", "Buster", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, "mccormack32@uia.no", "McCormack", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, "linde33@uia.no", "Linde", "Buford", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 3, "dugan34@uia.no", "Dugan", "Caleb", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "fletcher35@uia.no", "Fletcher", "Calista", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, "sellon36@uia.no", "Sellon", "Otto", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, 2, "ulrich37@uia.no", "Ulrich", "Hank", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "nelson38@uia.no", "Nelson", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 2, "tiernan39@uia.no", "Tiernan", "Victor", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 1, "alline40@uia.no", "Alline", "Steve", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, "allene41@uia.no", "Allene", "Calista", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 2, "trussel42@uia.no", "Trussel", "Paul", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, "sandstrom43@uia.no", "Sandstrom", "Paul", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 2, "tiernan44@uia.no", "Tiernan", "Otto", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, "jurgenson45@uia.no", "Jurgenson", "Steve", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 3, "delorenzo46@uia.no", "DeLorenzo", "Buford", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, "lulloff47@uia.no", "Lulloff", "Ben", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, 1, "linde48@uia.no", "Linde", "Caleb", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, "pettigrew49@uia.no", "Pettigrew", "Burt", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "ulrich50@uia.no", "Ulrich", "Thomas", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 2, "allene51@uia.no", "Allene", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "allyson52@uia.no", "Allyson", "Caleb", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "napier53@uia.no", "Napier", "Bulah", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, "leisinger54@uia.no", "Leisinger", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "pettigrew55@uia.no", "Pettigrew", "Steve", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, "trusela56@uia.no", "Trusela", "Roger", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "keller57@uia.no", "Keller", "Carl", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 2, "valente58@uia.no", "Valente", "Burton", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 1, "roberts59@uia.no", "Roberts", "Calvin", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, "vail60@uia.no", "Vail", "John", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, 3, "allen61@uia.no", "Allen", "Bula", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 3, "wagle62@uia.no", "Wagle", "Burl", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, 2, "vail63@uia.no", "Vail", "Bulah", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, "keller64@uia.no", "Keller", "Fred", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 3, "allena65@uia.no", "Allena", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, "fietzer66@uia.no", "Fietzer", "Ike", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 1, "maki67@uia.no", "Maki", "Jack", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 2, "johnsen68@uia.no", "Johnsen", "Roger", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 1, "baxster69@uia.no", "Baxster", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, "pettigrew70@uia.no", "Pettigrew", "Roger", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 3, "cataldi71@uia.no", "Cataldi", "Camellia", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 1, "schlicht72@uia.no", "Schlicht", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 3, "mccord73@uia.no", "Mccord", "Ike", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 3, "cataldi74@uia.no", "Cataldi", "Burl", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 1, "pak75@uia.no", "Pak", "Burt", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 1, "schwager76@uia.no", "Schwager", "Hal", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 2, "dinkins77@uia.no", "Dinkins", "Tim", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 3, "eastman78@uia.no", "Eastman", "Fred", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 1, "keller79@uia.no", "Keller", "Buffy", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 3, "alix80@uia.no", "Alix", "Joe", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, 2, "solberg81@uia.no", "Solberg", "Buffy", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 2, "uddin82@uia.no", "Uddin", "Paul", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "aliza83@uia.no", "Aliza", "Byron", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 1, "bongard84@uia.no", "Bongard", "Camelia", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 3, "tisler85@uia.no", "Tisler", "Caitlin", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, "orwig86@uia.no", "Orwig", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, "caswell87@uia.no", "Caswell", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, "lepage88@uia.no", "LePage", "Burton", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, "nugent89@uia.no", "Nugent", "Burt", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, 2, "mcginnis90@uia.no", "McGinnis", "Ben", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, "trussel91@uia.no", "Trussel", "Ty", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "tandy92@uia.no", "Tandy", "Caitlyn", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 2, "christensen93@uia.no", "Christensen", "Ben", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, "rogers94@uia.no", "Rogers", "Otto", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, "ostrander95@uia.no", "Ostrander", "Peter", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, "chambers96@uia.no", "Chambers", "Monte", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
