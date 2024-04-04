using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachCrud.Server.Migrations
{
    /// <inheritdoc />
    public partial class newDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, "schuster9@uia.no", "Schuster", "Aaron", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "davis11@uia.no", "Davis", "Hank", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 3, "solberg16@uia.no", "Solberg", "Monte", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 3, "soukup22@uia.no", "Soukup", "David", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "LastName", "RegistrationDate" },
                values: new object[] { 29, "Edward", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, 1, "knutson25@uia.no", "Knutson", "Edward", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, "allyson27@uia.no", "Allyson", "Bula", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 1, "linde33@uia.no", "Linde", "Buford", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "dugan34@uia.no", "Dugan", "Caleb", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 2, "sellon36@uia.no", "Sellon", "Otto", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 40, "nelson38@uia.no", "Nelson", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, "tiernan39@uia.no", "Tiernan", "Victor", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 3, "allene41@uia.no", "Allene", "Calista", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 3, "lulloff47@uia.no", "Lulloff", "Ben", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "linde48@uia.no", "Linde", "Caleb", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, 2, "pettigrew49@uia.no", "Pettigrew", "Burt", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 18, 1, "ulrich50@uia.no", "Ulrich", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "allene51@uia.no", "Allene", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 3, "allyson52@uia.no", "Allyson", "Caleb", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 2, "leisinger54@uia.no", "Leisinger", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 2, "pettigrew55@uia.no", "Pettigrew", "Steve", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, 1, "trusela56@uia.no", "Trusela", "Roger", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 2, "vail60@uia.no", "Vail", "John", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 1, "keller64@uia.no", "Keller", "Fred", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 2, "fietzer66@uia.no", "Fietzer", "Ike", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 3, "cataldi71@uia.no", "Cataldi", "Camellia", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "schlicht72@uia.no", "Schlicht", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, "schwager76@uia.no", "Schwager", "Hal", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, "dinkins77@uia.no", "Dinkins", "Tim", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "keller79@uia.no", "Keller", "Buffy", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, "tisler85@uia.no", "Tisler", "Caitlin", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "orwig86@uia.no", "Orwig", "Mark", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 2, "caswell87@uia.no", "Caswell", "Nathan", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 2, "lepage88@uia.no", "LePage", "Burton", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 2, "nugent89@uia.no", "Nugent", "Burt", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 23, "mcginnis90@uia.no", "McGinnis", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 2, "trussel91@uia.no", "Trussel", "Ty", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, 1, "tandy92@uia.no", "Tandy", "Caitlyn", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 1, "rogers94@uia.no", "Rogers", "Otto", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 1, "ostrander95@uia.no", "Ostrander", "Peter", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 1, "chambers96@uia.no", "Chambers", "Monte", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 2, "sweeney1@uia.no", "Sweeney", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 1, "root2@uia.no", "Root", "John", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "lepage3@uia.no", "LePage", "George", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 3, "bateman4@uia.no", "Bateman", "Dan", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 3, "severson5@uia.no", "Severson", "Burt", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 2, "allie6@uia.no", "Allie", "Byron", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 3, "ventotla7@uia.no", "Ventotla", "Bunny", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 2, "vader8@uia.no", "Vader", "Edward", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, "thompson9@uia.no", "Thompson", "Matthew", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 1, "rogers10@uia.no", "Rogers", "Thomas", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, "johnson11@uia.no", "Johnson", "Camellia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, 1, "allena12@uia.no", "Allena", "Camellia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, 3, "trusela13@uia.no", "Trusela", "Caleb", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, 2, "schickowski14@uia.no", "Schickowski", "Jack", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, 1, "reyes15@uia.no", "Reyes", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 1, "uflan16@uia.no", "Uflan", "Calvin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, "olson17@uia.no", "Olson", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 3, "vail18@uia.no", "Vail", "Camelia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "van zandt19@uia.no", "Van Zandt", "Camellia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 3, "frick20@uia.no", "Frick", "Calandra", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, "chapman21@uia.no", "Chapman", "Calvin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 1, "kalleg22@uia.no", "Kalleg", "Frank", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "LastName", "RegistrationDate" },
                values: new object[] { 40, "Carl", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 3, "roberts24@uia.no", "Roberts", "Calvin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 31, 3, "trebil25@uia.no", "Trebil", "Camelia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 1, "vader26@uia.no", "Vader", "Callie", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, "yocum27@uia.no", "Yocum", "Roger", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 1, "napier28@uia.no", "Napier", "Tim", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 1, "johnsen29@uia.no", "Johnsen", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 3, "myers30@uia.no", "Myers", "Matthew", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, "illingsworth31@uia.no", "Illingsworth", "Camelia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, "ferry32@uia.no", "Ferry", "David", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, 2, "ulrich33@uia.no", "Ulrich", "Otto", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "ventotla34@uia.no", "Ventotla", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, "dinkins35@uia.no", "Dinkins", "Peter", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 1, "schiebel36@uia.no", "Schiebel", "Calista", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 1, "allene37@uia.no", "Allene", "Edward", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 29, "celedon38@uia.no", "Celedon", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, "lulloff39@uia.no", "Lulloff", "Caitlin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, 3, "napier40@uia.no", "Napier", "Hal", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 1, "keller41@uia.no", "Keller", "Otto", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 3, "vanderpoel42@uia.no", "Vanderpoel", "Matthew", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 19, "turco43@uia.no", "Turco", "Tim", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 3, "jones44@uia.no", "Jones", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, "chapman45@uia.no", "Chapman", "Thomas", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 2, "dewalt46@uia.no", "Dewalt", "Frank", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, 1, "anderson47@uia.no", "Anderson", "Calista", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, "lulloff48@uia.no", "Lulloff", "Hank", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 3, "trebil49@uia.no", "Trebil", "Caitlyn", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 33, 2, "jones50@uia.no", "Jones", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "ashwoon51@uia.no", "Ashwoon", "Jack", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 2, "delorenzo52@uia.no", "DeLorenzo", "Matthew", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, "dewalt53@uia.no", "Dewalt", "Bunny", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 3, "ashwoon54@uia.no", "Ashwoon", "Calvin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 36, 3, "alla55@uia.no", "Alla", "Roger", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, 2, "olson56@uia.no", "Olson", "Buffy", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, "cataldi57@uia.no", "Cataldi", "Calvin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 43, 1, "orwig58@uia.no", "Orwig", "Camelia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 2, "illingsworth59@uia.no", "Illingsworth", "Monte", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 32, 3, "reyes60@uia.no", "Reyes", "Bunny", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 2, "paiser61@uia.no", "Paiser", "Burl", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 26, 2, "allena62@uia.no", "Allena", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 3, "ebner63@uia.no", "Ebner", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 2, "vogal64@uia.no", "Vogal", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 1, "paiser65@uia.no", "Paiser", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 3, "reamer66@uia.no", "Reamer", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 2, "alix67@uia.no", "Alix", "Aaron", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 33, 1, "ziegler68@uia.no", "Ziegler", "Burt", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, 3, "mccormack69@uia.no", "McCormack", "George", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, "allyson70@uia.no", "Allyson", "Buster", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 2, "dugan71@uia.no", "Dugan", "Jack", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 24, "nugent72@uia.no", "Nugent", "Camellia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 2, "rice73@uia.no", "Rice", "Mark", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, 2, "johnsen74@uia.no", "Johnsen", "Bula", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, 2, "delorenzo75@uia.no", "DeLorenzo", "Joe", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 39, "darnell76@uia.no", "Darnell", "Callie", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, "mcginnis77@uia.no", "McGinnis", "John", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 2, "jagtap78@uia.no", "Jagtap", "Dan", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 23, "mills79@uia.no", "Mills", "Joe", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 1, "zeller80@uia.no", "Zeller", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, 1, "allison81@uia.no", "Allison", "Jack", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 1, "uflan82@uia.no", "Uflan", "Callie", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, "lawless83@uia.no", "Lawless", "Camelia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 2, "weinstein84@uia.no", "Weinstein", "Bunny", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 28, "maki85@uia.no", "Maki", "Bunny", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 1, "alisain86@uia.no", "Alisain", "Roger", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 1, "vogal87@uia.no", "Vogal", "Paul", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, 1, "allen88@uia.no", "Allen", "George", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 3, "cannon89@uia.no", "Cannon", "Paul", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "Email", "FirstName", "RegistrationDate" },
                values: new object[] { 42, "alix90@uia.no", "Alix", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 35, 1, "kalleg91@uia.no", "Kalleg", "Byron", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 41, 2, "ferry92@uia.no", "Ferry", "Calandra", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 1, "allyn93@uia.no", "Allyn", "Ike", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 22, 2, "pettigrew94@uia.no", "Pettigrew", "Dan", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, 2, "maki95@uia.no", "Maki", "Camellia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, 2, "dugan96@uia.no", "Dugan", "Buford", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
