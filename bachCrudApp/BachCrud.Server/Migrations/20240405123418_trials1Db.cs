using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BachCrud.Server.Migrations
{
    /// <inheritdoc />
    public partial class trials1Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 32, 3, "alix1@uia.no", "Alix", "Calvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 43, "baxster2@uia.no", "Baxster", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 26, 1, "jenson3@uia.no", "Jenson", "Burma" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 23, 2, "reamer4@uia.no", "Reamer", "Aaron" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 37, 1, "davis5@uia.no", "Davis", "Calvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 43, 1, "weinstein6@uia.no", "Weinstein", "Burt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 1, "pettigrew7@uia.no", "Pettigrew", "Caitlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 19, 2, "allyson8@uia.no", "Allyson", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 26, 1, "norquist9@uia.no", "Norquist", "Buster" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "moore10@uia.no", "Moore", "Paul" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 36, 3, "tapia11@uia.no", "Tapia", "Ike" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 28, "martin12@uia.no", "Martin", "Calista" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 24, 1, "ebner13@uia.no", "Ebner", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 35, 3, "vail14@uia.no", "Vail", "Burt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 33, 2, "myers15@uia.no", "Myers", "Carl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 32, "weinstein16@uia.no", "Weinstein", "Ben" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 19, "Ben" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 43, "deitz18@uia.no", "Deitz", "Steve" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 34, 3, "mccormack19@uia.no", "McCormack", "Frank" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 40, 1, "tiernan20@uia.no", "Tiernan", "Callie" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "CourseId", "Email", "FirstName" },
                values: new object[] { 24, 3, "kaskel21@uia.no", "Kaskel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 1, "sweeney22@uia.no", "Sweeney", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 30, "bauer23@uia.no", "Bauer", "Carl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 29, 1, "alisain24@uia.no", "Alisain", "George" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 32, "alisia25@uia.no", "Alisia", "Burt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 30, "bauer26@uia.no", "Bauer", "Calandra" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 28, 2, "deitz27@uia.no", "Deitz", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 40, 3, "keller28@uia.no", "Keller", "Calista" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "roberts29@uia.no", "Roberts", "Camellia" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 35, "chambers30@uia.no", "Chambers", "Hal" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "keller31@uia.no", "Keller", "Calandra" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 36, 2, "turco32@uia.no", "Turco", "Fred" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "jones33@uia.no", "Jones", "Camelia" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "allyson34@uia.no", "Allyson", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "ferry35@uia.no", "Ferry", "Otto" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 32, 1, "schwager36@uia.no", "Schwager", "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 30, 2, "dugan37@uia.no", "Dugan", "Monte" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 37, 2, "rogers38@uia.no", "Rogers", "Ike" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 19, "trussel39@uia.no", "Trussel", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "johnsen40@uia.no", "Johnsen", "Caitlyn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 30, 2, "lulloff41@uia.no", "Lulloff", "Fred" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 31, 2, "jenson42@uia.no", "Jenson", "Bula" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 19, 2, "sweeney43@uia.no", "Sweeney", "Monte" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 34, 2, "trebil44@uia.no", "Trebil", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 30, 3, "keller45@uia.no", "Keller", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "schuster46@uia.no", "Schuster", "Camelia" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 34, 2, "allyson47@uia.no", "Allyson", "Steve" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 27, "sawyer48@uia.no", "Sawyer", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 29, 3, "trussel49@uia.no", "Trussel", "George" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 32, 2, "moore50@uia.no", "Moore", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 37, 1, "paiser51@uia.no", "Paiser", "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 2, "miller52@uia.no", "Miller", "Buster" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 1, "bongard53@uia.no", "Bongard", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 19, "eastman54@uia.no", "Eastman", "Mark" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 1, "tapia55@uia.no", "Tapia", "Burton" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 39, 2, "stahl56@uia.no", "Stahl", "Calvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 19, 3, "aikin57@uia.no", "Aikin", "Aaron" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "maki58@uia.no", "Maki", "Bulah" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 30, "reyes59@uia.no", "Reyes", "Joe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 24, 1, "shaffer60@uia.no", "Shaffer", "Otto" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 43, 3, "lewis61@uia.no", "Lewis", "John" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 35, 3, "moody62@uia.no", "Moody", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 25, 1, "alisia63@uia.no", "Alisia", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 31, 3, "schickowski64@uia.no", "Schickowski", "Bulah" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 36, "reyes65@uia.no", "Reyes", "John" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 32, 3, "doran66@uia.no", "Doran", "Byron" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 42, 3, "nuttle67@uia.no", "Nuttle", "Mark" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 44, 2, "ramachandran68@uia.no", "Ramachandran", "Tim" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 42, "bowers69@uia.no", "Bowers", "Ben" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 3, "yates70@uia.no", "Yates", "Calvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 41, "fletcher71@uia.no", "Fletcher", "Bulah" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 26, 1, "quinn72@uia.no", "Quinn", "Bula" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 40, 3, "mccormack73@uia.no", "McCormack", "Ben" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "pak74@uia.no", "Pak", "Victor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 44, 3, "maki75@uia.no", "Maki", "Buster" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 35, "norquist76@uia.no", "Norquist", "Caitlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 39, 2, "zeller77@uia.no", "Zeller", "Joe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 32, 3, "sandstrom78@uia.no", "Sandstrom", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "shaffer79@uia.no", "Shaffer", "Frank" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 38, 3, "weiss80@uia.no", "Weiss", "Joe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "hesch81@uia.no", "Hesch", "Calista" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 1, "ventotla82@uia.no", "Ventotla", "Caitlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 28, 3, "ferro83@uia.no", "Ferro", "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 43, "ventotla84@uia.no", "Ventotla", "Burt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "boyd85@uia.no", "Boyd", "Calvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 38, 1, "nugent86@uia.no", "Nugent", "Mark" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 28, "moore87@uia.no", "Moore", "Caitlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 25, "aikin88@uia.no", "Aikin", "Callie" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "schuster89@uia.no", "Schuster", "Ben" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 24, 2, "nugent90@uia.no", "Nugent", "Calandra" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 1, "dewalt91@uia.no", "Dewalt", "Calvin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 40, 3, "alix92@uia.no", "Alix", "Callie" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 40, 3, "quinn93@uia.no", "Quinn", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 3, "dewalt94@uia.no", "Dewalt", "George" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "Email", "FirstName" },
                values: new object[] { 35, "turco95@uia.no", "Turco" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 27, "frick96@uia.no", "Frick", "Caleb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 43, 1, "moody1@uia.no", "Moody", "Joe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 19, "alisa2@uia.no", "Alisa", "Nathan" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 3, "trussel3@uia.no", "Trussel", "Buffy" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 35, 3, "schlicht4@uia.no", "Schlicht", "Joe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 43, 3, "allen5@uia.no", "Allen", "Camelia" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 44, 2, "roberts6@uia.no", "Roberts", "Ty" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 26, 3, "lepage7@uia.no", "LePage", "Camellia" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 34, 1, "mccormack8@uia.no", "McCormack", "Calista" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 19, 3, "boyd9@uia.no", "Boyd", "Larry" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "lawless10@uia.no", "Lawless", "Monte" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 41, 1, "fletcher11@uia.no", "Fletcher", "Jack" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 33, "sellon12@uia.no", "Sellon", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 40, 2, "anderson13@uia.no", "Anderson", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 44, 2, "allyn14@uia.no", "Allyn", "Caleb" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 36, 3, "chapman15@uia.no", "Chapman", "Paul" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 39, "solberg16@uia.no", "Solberg", "Byron" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "LastName" },
                values: new object[] { 44, "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 35, "reamer18@uia.no", "Reamer", "Ben" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 2, "tisler19@uia.no", "Tisler", "John" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 20, 2, "celedon20@uia.no", "Celedon", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "CourseId", "Email", "FirstName" },
                values: new object[] { 26, 2, "schutz21@uia.no", "Schutz" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 36, 3, "allyn22@uia.no", "Allyn", "Fred" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 39, "eastman23@uia.no", "Eastman", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 20, 3, "root24@uia.no", "Root", "Fred" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "nuttle25@uia.no", "Nuttle", "Camellia" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "uddin26@uia.no", "Uddin", "Frank" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 25, 1, "soulis27@uia.no", "Soulis", "Ty" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 34, 2, "tandy28@uia.no", "Tandy", "Aaron" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "wagner29@uia.no", "Wagner", "Burt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "trussel30@uia.no", "Trussel", "Dan" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 3, "allen31@uia.no", "Allen", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 29, 1, "sweeney32@uia.no", "Sweeney", "Larry" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 35, "alla33@uia.no", "Alla", "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 32, "pak34@uia.no", "Pak", "Hank" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 32, "lewis35@uia.no", "Lewis", "Caitlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 2, "allen36@uia.no", "Allen", "Buford" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 42, 3, "yates37@uia.no", "Yates", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 1, "soloman38@uia.no", "Soloman", "Victor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 37, "ashwoon39@uia.no", "Ashwoon", "Paul" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "alleen40@uia.no", "Alleen", "Bula" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 22, 3, "allegra41@uia.no", "Allegra", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 34, 3, "jagtap42@uia.no", "Jagtap", "Dan" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 28, 1, "norquist43@uia.no", "Norquist", "Ty" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 37, 1, "anderson44@uia.no", "Anderson", "Hank" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 37, 1, "alline45@uia.no", "Alline", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 43, "zeller46@uia.no", "Zeller", "Burton" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 38, 3, "allen47@uia.no", "Allen", "Victor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "kaskel48@uia.no", "Kaskel", "Frank" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 43, 2, "trebil49@uia.no", "Trebil", "Tim" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 18, 1, "allegra50@uia.no", "Allegra", "John" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 31, 3, "lewis51@uia.no", "Lewis", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 41, 3, "deitz52@uia.no", "Deitz", "Burl" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 33, 2, "aikin53@uia.no", "Aikin", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 24, "hylan54@uia.no", "Hylan", "Bula" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 33, 2, "mcginnis55@uia.no", "McGinnis", "Burma" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 18, 1, "baxster56@uia.no", "Baxster", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 26, 1, "mccord57@uia.no", "Mccord", "Joe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 30, "soulis58@uia.no", "Soulis", "Thomas" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 41, "soukup59@uia.no", "Soukup", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 38, 2, "nelson60@uia.no", "Nelson", "Caleb" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 29, 1, "thompson61@uia.no", "Thompson", "Calandra" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 29, 2, "orwig62@uia.no", "Orwig", "Callie" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 32, 3, "norquist63@uia.no", "Norquist", "Buford" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 43, 1, "yates64@uia.no", "Yates", "Peter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 27, "haworth65@uia.no", "Haworth", "Calista" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 28, 2, "soloman66@uia.no", "Soloman", "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 39, 2, "bauer67@uia.no", "Bauer", "George" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 30, 1, "allena68@uia.no", "Allena", "Burt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "allegra69@uia.no", "Allegra", "Tim" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 28, 1, "aliza70@uia.no", "Aliza", "Otto" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "irwin71@uia.no", "Irwin", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 18, 2, "orwig72@uia.no", "Orwig", "Ike" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 41, 1, "bauer73@uia.no", "Bauer", "Nathan" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "quizoz74@uia.no", "Quizoz", "Ty" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 27, 2, "tapia75@uia.no", "Tapia", "Fred" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "cannon76@uia.no", "Cannon", "Buford" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 33, 1, "schlicht77@uia.no", "Schlicht", "Caitlyn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 21, 2, "cannon78@uia.no", "Cannon", "Calandra" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 38, "soulis79@uia.no", "Soulis", "Paul" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 28, 1, "ferro80@uia.no", "Ferro", "Caitlyn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 18, "lawicki81@uia.no", "Lawicki", "Roger" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 36, 3, "bongard82@uia.no", "Bongard", "Mark" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 39, 1, "kassing83@uia.no", "Kassing", "Buffy" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 26, "wakefield84@uia.no", "Wakefield", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "uddin85@uia.no", "Uddin", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 29, 3, "allie86@uia.no", "Allie", "Victor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 34, "yang87@uia.no", "Yang", "Caitlyn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 21, "davis88@uia.no", "Davis", "Edward" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 31, "trussel89@uia.no", "Trussel", "Matthew" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 35, 3, "pak90@uia.no", "Pak", "David" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 41, 2, "olson91@uia.no", "Olson", "Mark" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 24, 1, "caswell92@uia.no", "Caswell", "Victor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 26, 1, "allie93@uia.no", "Allie", "Calista" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Age", "CourseId", "Email", "FirstName", "LastName" },
                values: new object[] { 33, 1, "baxster94@uia.no", "Baxster", "Walter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Age", "Email", "FirstName" },
                values: new object[] { 20, "mcginnis95@uia.no", "McGinnis" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Age", "Email", "FirstName", "LastName" },
                values: new object[] { 29, "weiss96@uia.no", "Weiss", "Mark" });
        }
    }
}
