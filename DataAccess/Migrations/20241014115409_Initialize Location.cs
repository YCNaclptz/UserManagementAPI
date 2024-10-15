using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitializeLocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Province = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => new { x.Province, x.City });
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "City", "Province" },
                values: new object[,]
                {
                    { "上海", "上海" },
                    { "北京", "北京" },
                    { "廈門", "福建" },
                    { "福州", "福建" },
                    { "南寧", "廣西" },
                    { "桂林", "廣西" },
                    { "珠海", "廣東" },
                    { "深圳", "廣東" },
                    { "廣州", "廣東" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Province_City",
                table: "Users",
                columns: new[] { "Province", "City" });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Locations_Province_City",
                table: "Users",
                columns: new[] { "Province", "City" },
                principalTable: "Locations",
                principalColumns: new[] { "Province", "City" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Locations_Province_City",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Users_Province_City",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
