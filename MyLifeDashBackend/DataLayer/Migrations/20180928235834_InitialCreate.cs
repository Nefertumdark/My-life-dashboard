using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatInstrumments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatInstrumments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plugins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plugins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Total = table.Column<float>(nullable: false),
                    Gain = table.Column<float>(nullable: false),
                    PluginId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Plugins_PluginId",
                        column: x => x.PluginId,
                        principalTable: "Plugins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Taxes = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configuration_Sections_Id",
                        column: x => x.Id,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationInstruments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Percentaje = table.Column<float>(nullable: false),
                    CatInstrumentsId = table.Column<int>(nullable: true),
                    ConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationInstruments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigurationInstruments_CatInstrumments_CatInstrumentsId",
                        column: x => x.CatInstrumentsId,
                        principalTable: "CatInstrumments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfigurationInstruments_Configuration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configuration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricalEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Total = table.Column<float>(nullable: false),
                    Gain = table.Column<float>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    SectionId = table.Column<int>(nullable: true),
                    ConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricalEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricalEntries_Configuration_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configuration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricalEntries_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationInstruments_CatInstrumentsId",
                table: "ConfigurationInstruments",
                column: "CatInstrumentsId");

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
                name: "CatInstrumments");

            migrationBuilder.DropTable(
                name: "Configuration");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Plugins");
        }
    }
}
