using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Olympics.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    SportTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_SportTypes_SportTypeId",
                        column: x => x.SportTypeId,
                        principalTable: "SportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Summer Olympics" },
                    { 2, "Winter Olympics" },
                    { 3, "Paralympics" },
                    { 4, "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "SportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Indoor" },
                    { 2, "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "GameId", "Name", "SportTypeId" },
                values: new object[,]
                {
                    { 1, "CA", 2, "Canada", 1 },
                    { 2, "SE", 2, "Sweden", 1 },
                    { 3, "GB", 2, "Great Britain", 1 },
                    { 4, "JM", 2, "Jamaica", 2 },
                    { 5, "IT", 2, "Italy", 2 },
                    { 6, "JP", 2, "Japan", 2 },
                    { 7, "DE", 1, "Germany", 1 },
                    { 8, "CN", 1, "China", 1 },
                    { 9, "MX", 1, "Mexico", 1 },
                    { 10, "BR", 1, "Brazil", 2 },
                    { 11, "NL", 1, "Netherlands", 2 },
                    { 12, "US", 1, "USA", 2 },
                    { 13, "TH", 3, "Thailand", 1 },
                    { 14, "UY", 3, "Uruguay", 1 },
                    { 15, "UA", 3, "Ukraine", 1 },
                    { 16, "AT", 3, "Austria", 2 },
                    { 17, "PK", 3, "Pakistan", 2 },
                    { 18, "ZW", 3, "Zimbabwe", 2 },
                    { 19, "FR", 4, "France", 1 },
                    { 20, "CY", 4, "Cyprus", 1 },
                    { 21, "RU", 4, "Russia", 1 },
                    { 22, "FI", 4, "Finland", 2 },
                    { 23, "SK", 4, "Slovakia", 2 },
                    { 24, "PT", 4, "Portugal", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameId",
                table: "Countries",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportTypeId",
                table: "Countries",
                column: "SportTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "SportTypes");
        }
    }
}
