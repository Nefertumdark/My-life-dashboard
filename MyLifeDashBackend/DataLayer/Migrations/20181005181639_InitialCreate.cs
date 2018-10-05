using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatInstruments",
                columns: table => new
                {
                    CatInstrumentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatInstruments", x => x.CatInstrumentId);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    ConfigurationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Taxes = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.ConfigurationId);
                });

            migrationBuilder.CreateTable(
                name: "Plugins",
                columns: table => new
                {
                    PluginId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plugins", x => x.PluginId);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationInstruments",
                columns: table => new
                {
                    ConfigurationInstrumentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Percentaje = table.Column<float>(nullable: false),
                    CatInstrumentsCatInstrumentId = table.Column<int>(nullable: true),
                    ConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationInstruments", x => x.ConfigurationInstrumentId);
                    table.ForeignKey(
                        name: "FK_ConfigurationInstruments_CatInstruments_CatInstrumentsCatInstrumentId",
                        column: x => x.CatInstrumentsCatInstrumentId,
                        principalTable: "CatInstruments",
                        principalColumn: "CatInstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfigurationInstruments_Configuration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configuration",
                        principalColumn: "ConfigurationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Total = table.Column<float>(nullable: false),
                    Gain = table.Column<float>(nullable: false),
                    ConfigurationRefId = table.Column<int>(nullable: false),
                    PluginId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionId);
                    table.ForeignKey(
                        name: "FK_Sections_Configuration_ConfigurationRefId",
                        column: x => x.ConfigurationRefId,
                        principalTable: "Configuration",
                        principalColumn: "ConfigurationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Plugins_PluginId",
                        column: x => x.PluginId,
                        principalTable: "Plugins",
                        principalColumn: "PluginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricalEntries",
                columns: table => new
                {
                    HistoricalEntryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Total = table.Column<float>(nullable: false),
                    Gain = table.Column<float>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    SectionId = table.Column<int>(nullable: true),
                    ConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalEntries", x => x.HistoricalEntryId);
                    table.ForeignKey(
                        name: "FK_HistoricalEntries_Configuration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configuration",
                        principalColumn: "ConfigurationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricalEntries_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 1, "Savings" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 2, "Equity MX" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 3, "Debt MX" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 4, "Others MX" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 5, "Equity Tech USA" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 6, "Equity USA" });

            migrationBuilder.InsertData(
                table: "CatInstruments",
                columns: new[] { "CatInstrumentId", "Name" },
                values: new object[] { 7, "Debt USA" });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationInstruments_CatInstrumentsCatInstrumentId",
                table: "ConfigurationInstruments",
                column: "CatInstrumentsCatInstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationInstruments_ConfigurationId",
                table: "ConfigurationInstruments",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalEntries_ConfigurationId",
                table: "HistoricalEntries",
                column: "ConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricalEntries_SectionId",
                table: "HistoricalEntries",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ConfigurationRefId",
                table: "Sections",
                column: "ConfigurationRefId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_PluginId",
                table: "Sections",
                column: "PluginId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigurationInstruments");

            migrationBuilder.DropTable(
                name: "HistoricalEntries");

            migrationBuilder.DropTable(
                name: "CatInstruments");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Plugins");
        }
    }
}
