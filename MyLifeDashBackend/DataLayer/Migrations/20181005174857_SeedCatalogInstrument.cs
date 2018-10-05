using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class SeedCatalogInstrument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Savings" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Equity MX" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Debt MX" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Others MX" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Equity Tech USA" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Equity USA" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Debt USA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CatInstruments",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
