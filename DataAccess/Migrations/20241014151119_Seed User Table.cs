using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "City", "Email", "Gender", "Name", "Password", "Province" },
                values: new object[,]
                {
                    { -15, 23, "上海", "zhaoliu2@example.com", 1, "孫七二", "password123", "上海" },
                    { -14, 31, "珠海", "zhaoliu2@example.com", 1, "趙六二", "password123", "廣東" },
                    { -13, 22, "深圳", "wangwu2@example.com", 0, "王五二", "password123", "廣東" },
                    { -12, 26, "廣州", "lisi2@example.com", 1, "李四二", "password123", "廣東" },
                    { -11, 21, "北京", "zhangsan2@example.com", 0, "張三二", "password123", "北京" },
                    { -10, 29, "上海", "liuer@example.com", 1, "李二", "password123", "上海" },
                    { -9, 23, "福州", "wangyi@example.com", 0, "王一", "password123", "福建" },
                    { -8, 27, "廈門", "zhengshi@example.com", 1, "鄭十", "password123", "福建" },
                    { -7, 24, "桂林", "wujia@example.com", 0, "吳九", "password123", "廣西" },
                    { -6, 28, "南寧", "zhouba@example.com", 1, "周八", "password123", "廣西" },
                    { -5, 22, "珠海", "sunqi@example.com", 0, "孫七", "password123", "廣東" },
                    { -4, 30, "深圳", "zhaoliu@example.com", 1, "趙六", "password123", "廣東" },
                    { -3, 20, "廣州", "wangwu@example.com", 0, "王五", "password123", "廣東" },
                    { -2, 25, "北京", "lisi@example.com", 1, "李四", "password123", "北京" },
                    { -1, 26, "上海", "zhangsan@example.com", 0, "張三", "password123", "上海" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
