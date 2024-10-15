using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SetEmailAsKeyforUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Email");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Email", "Age", "City", "Gender", "Name", "Password", "Province" },
                values: new object[,]
                {
                    { "lisi@example.com", 25, "北京", 1, "李四", "password123", "北京" },
                    { "lisi2@example.com", 26, "廣州", 1, "李四二", "password123", "廣東" },
                    { "liuer@example.com", 29, "上海", 1, "李二", "password123", "上海" },
                    { "sunqi@example.com", 22, "珠海", 0, "孫七", "password123", "廣東" },
                    { "sunqi2@example.com", 23, "上海", 1, "孫七二", "password123", "上海" },
                    { "wangwu@example.com", 20, "廣州", 0, "王五", "password123", "廣東" },
                    { "wangwu2@example.com", 22, "深圳", 0, "王五二", "password123", "廣東" },
                    { "wangyi@example.com", 23, "福州", 0, "王一", "password123", "福建" },
                    { "wujia@example.com", 24, "桂林", 0, "吳九", "password123", "廣西" },
                    { "zhangsan@example.com", 26, "上海", 0, "張三", "password123", "上海" },
                    { "zhangsan2@example.com", 21, "北京", 0, "張三二", "password123", "北京" },
                    { "zhaoliu@example.com", 30, "深圳", 1, "趙六", "password123", "廣東" },
                    { "zhaoliu2@example.com", 31, "珠海", 1, "趙六二", "password123", "廣東" },
                    { "zhengshi@example.com", 27, "廈門", 1, "鄭十", "password123", "福建" },
                    { "zhouba@example.com", 28, "南寧", 1, "周八", "password123", "廣西" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "lisi@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "lisi2@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "liuer@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "sunqi@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "sunqi2@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "wangwu@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "wangwu2@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "wangyi@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "wujia@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "zhangsan@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "zhangsan2@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "zhaoliu@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "zhaoliu2@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "zhengshi@example.com");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Email",
                keyValue: "zhouba@example.com");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

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
    }
}
