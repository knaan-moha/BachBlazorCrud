using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BachCrud.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, "severson5@uia.no", "Severson", "Burt", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, "vader8@uia.no", "Vader", "Edward", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 42, 1, "thompson9@uia.no", "Thompson", "Matthew", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, "rogers10@uia.no", "Rogers", "Thomas", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 25, "trusela13@uia.no", "Trusela", "Caleb", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, "reyes15@uia.no", "Reyes", "Ty", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 38, "uflan16@uia.no", "Uflan", "Calvin", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "van zandt19@uia.no", "Van Zandt", "Camellia", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, 3, "frick20@uia.no", "Frick", "Calandra", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "Email", "FirstName", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[,]
                {
                    { 25, 20, 2, "chapman21@uia.no", "Chapman", "Calvin", "48679721", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 26, 42, 1, "kalleg22@uia.no", "Kalleg", "Frank", "48679722", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 27, 40, 1, "sonderling23@uia.no", "Sonderling", "Carl", "48679723", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 28, 35, 3, "roberts24@uia.no", "Roberts", "Calvin", "48679724", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 29, 31, 3, "trebil25@uia.no", "Trebil", "Camelia", "48679725", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 30, 40, 1, "vader26@uia.no", "Vader", "Callie", "48679726", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 31, 25, 2, "yocum27@uia.no", "Yocum", "Roger", "48679727", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 32, 28, 1, "napier28@uia.no", "Napier", "Tim", "48679728", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 33, 43, 1, "johnsen29@uia.no", "Johnsen", "Buford", "48679729", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 34, 33, 3, "myers30@uia.no", "Myers", "Matthew", "48679730", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 35, 27, 3, "illingsworth31@uia.no", "Illingsworth", "Camelia", "48679731", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 36, 41, 1, "ferry32@uia.no", "Ferry", "David", "48679732", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 37, 19, 2, "ulrich33@uia.no", "Ulrich", "Otto", "48679733", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 38, 38, 3, "ventotla34@uia.no", "Ventotla", "Buford", "48679734", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 39, 42, 1, "dinkins35@uia.no", "Dinkins", "Peter", "48679735", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 40, 40, 1, "schiebel36@uia.no", "Schiebel", "Calista", "48679736", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 41, 26, 1, "allene37@uia.no", "Allene", "Edward", "48679737", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 42, 29, 1, "celedon38@uia.no", "Celedon", "Nathan", "48679738", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 43, 22, 2, "lulloff39@uia.no", "Lulloff", "Caitlin", "48679739", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 44, 19, 3, "napier40@uia.no", "Napier", "Hal", "48679740", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 45, 29, 1, "keller41@uia.no", "Keller", "Otto", "48679741", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 46, 42, 3, "vanderpoel42@uia.no", "Vanderpoel", "Matthew", "48679742", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 47, 19, 1, "turco43@uia.no", "Turco", "Tim", "48679743", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 48, 37, 3, "jones44@uia.no", "Jones", "Buford", "48679744", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 49, 35, 1, "chapman45@uia.no", "Chapman", "Thomas", "48679745", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 50, 28, 2, "dewalt46@uia.no", "Dewalt", "Frank", "48679746", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 51, 39, 1, "anderson47@uia.no", "Anderson", "Calista", "48679747", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 52, 34, 1, "lulloff48@uia.no", "Lulloff", "Hank", "48679748", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 53, 36, 3, "trebil49@uia.no", "Trebil", "Caitlyn", "48679749", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 54, 33, 2, "jones50@uia.no", "Jones", "Thomas", "48679750", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 55, 39, 2, "ashwoon51@uia.no", "Ashwoon", "Jack", "48679751", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 56, 26, 2, "delorenzo52@uia.no", "DeLorenzo", "Matthew", "48679752", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 57, 18, 2, "dewalt53@uia.no", "Dewalt", "Bunny", "48679753", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 58, 37, 3, "ashwoon54@uia.no", "Ashwoon", "Calvin", "48679754", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 59, 36, 3, "alla55@uia.no", "Alla", "Roger", "48679755", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 60, 21, 2, "olson56@uia.no", "Olson", "Buffy", "48679756", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 61, 29, 1, "cataldi57@uia.no", "Cataldi", "Calvin", "48679757", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 62, 43, 1, "orwig58@uia.no", "Orwig", "Camelia", "48679758", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 63, 18, 2, "illingsworth59@uia.no", "Illingsworth", "Monte", "48679759", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 64, 32, 3, "reyes60@uia.no", "Reyes", "Bunny", "48679760", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 65, 27, 2, "paiser61@uia.no", "Paiser", "Burl", "48679761", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 66, 26, 2, "allena62@uia.no", "Allena", "Buford", "48679762", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 67, 33, 3, "ebner63@uia.no", "Ebner", "Ty", "48679763", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 68, 28, 2, "vogal64@uia.no", "Vogal", "Ty", "48679764", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 69, 44, 1, "paiser65@uia.no", "Paiser", "Ty", "48679765", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 70, 18, 3, "reamer66@uia.no", "Reamer", "Ty", "48679766", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 71, 30, 2, "alix67@uia.no", "Alix", "Aaron", "48679767", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 72, 33, 1, "ziegler68@uia.no", "Ziegler", "Burt", "48679768", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 73, 28, 3, "mccormack69@uia.no", "McCormack", "George", "48679769", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 74, 27, 1, "allyson70@uia.no", "Allyson", "Buster", "48679770", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 75, 27, 2, "dugan71@uia.no", "Dugan", "Jack", "48679771", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 76, 24, 1, "nugent72@uia.no", "Nugent", "Camellia", "48679772", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 77, 35, 2, "rice73@uia.no", "Rice", "Mark", "48679773", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 78, 34, 2, "johnsen74@uia.no", "Johnsen", "Bula", "48679774", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 79, 27, 2, "delorenzo75@uia.no", "DeLorenzo", "Joe", "48679775", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 80, 39, 1, "darnell76@uia.no", "Darnell", "Callie", "48679776", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 81, 34, 2, "mcginnis77@uia.no", "McGinnis", "John", "48679777", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 82, 40, 2, "jagtap78@uia.no", "Jagtap", "Dan", "48679778", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 83, 23, 1, "mills79@uia.no", "Mills", "Joe", "48679779", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 84, 42, 1, "zeller80@uia.no", "Zeller", "Ty", "48679780", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 85, 22, 1, "allison81@uia.no", "Allison", "Jack", "48679781", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 86, 40, 1, "uflan82@uia.no", "Uflan", "Callie", "48679782", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 87, 37, 1, "lawless83@uia.no", "Lawless", "Camelia", "48679783", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 88, 35, 2, "weinstein84@uia.no", "Weinstein", "Bunny", "48679784", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 89, 28, 3, "maki85@uia.no", "Maki", "Bunny", "48679785", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 90, 29, 1, "alisain86@uia.no", "Alisain", "Roger", "48679786", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 91, 37, 1, "vogal87@uia.no", "Vogal", "Paul", "48679787", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 92, 18, 1, "allen88@uia.no", "Allen", "George", "48679788", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 93, 42, 3, "cannon89@uia.no", "Cannon", "Paul", "48679789", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 94, 42, 2, "alix90@uia.no", "Alix", "Ben", "48679790", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 95, 35, 1, "kalleg91@uia.no", "Kalleg", "Byron", "48679791", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 96, 41, 2, "ferry92@uia.no", "Ferry", "Calandra", "48679792", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 97, 40, 1, "allyn93@uia.no", "Allyn", "Ike", "48679793", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 98, 22, 2, "pettigrew94@uia.no", "Pettigrew", "Dan", "48679794", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 99, 30, 2, "maki95@uia.no", "Maki", "Camellia", "48679795", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 100, 38, 2, "dugan96@uia.no", "Dugan", "Buford", "48679796", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100);

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 2, "allena2@uia.no", "Allena", "Calista", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 27, "allene3@uia.no", "Allene", "Calvin", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 21, "aliza5@uia.no", "Aliza", "Calista", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 29, 1, "alla7@uia.no", "Alla", "Calandra", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 18, "allyn8@uia.no", "Allyn", "Bulah", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 40, "allan11@uia.no", "Allan", "Calvin", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, 3, "allie12@uia.no", "Allie", "Camelia", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 20, "alisia13@uia.no", "Alisia", "Buster", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 30, "allen15@uia.no", "Allen", "Camelia", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 44, "alex 16@uia.no", "Alex ", "Buffy", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 34, "alita17@uia.no", "Alita", "Callie", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

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
                columns: new[] { "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { "allie19@uia.no", "Allie", "Caitlin", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName", "RegistrationDate" },
                values: new object[] { 37, 1, "allie20@uia.no", "Allie", "Bunny", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
