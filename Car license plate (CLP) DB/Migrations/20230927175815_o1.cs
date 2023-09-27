using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_license_plate__CLP__DB.Migrations
{
    /// <inheritdoc />
    public partial class o1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<double>(type: "float", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWanted = table.Column<bool>(type: "bit", nullable: false),
                    DriveId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Drives_DriveId",
                        column: x => x.DriveId,
                        principalTable: "Drives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Red" },
                    { 2, "Orange" },
                    { 3, "Yellow" },
                    { 4, "Lime" },
                    { 5, "Green" },
                    { 6, "Blue" },
                    { 7, "Purple" },
                    { 8, "Silver" },
                    { 9, "Gold" },
                    { 10, "Black" },
                    { 11, "White" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "USA" },
                    { 3, "Poland" },
                    { 4, "Sweden" },
                    { 5, "German" },
                    { 6, "Turkey" },
                    { 7, "Japan" },
                    { 8, "China" },
                    { 9, "Greenland" },
                    { 10, "Iceland" },
                    { 11, "UK" },
                    { 12, "Czech" },
                    { 13, "Italy" },
                    { 14, "Canada" },
                    { 15, "Belgium" },
                    { 16, "Netherlands" },
                    { 17, "Spain" }
                });

            migrationBuilder.InsertData(
                table: "Drives",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Back" },
                    { 2, "Front" },
                    { 3, "Full" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 5, "Audi" },
                    { 2, 5, "Mercedes" },
                    { 3, 5, "Fiat" },
                    { 4, 5, "BMW" },
                    { 5, 11, "Škoda" },
                    { 6, 2, "Jeep" },
                    { 7, 13, "Maseratti" },
                    { 8, 14, "Koenigsegg" },
                    { 9, 13, "Lamborghini" },
                    { 10, 11, "McLaren" },
                    { 11, 2, "Delorean" },
                    { 12, 5, "Siat" },
                    { 13, 7, "Nisan" },
                    { 14, 5, "Opel" },
                    { 15, 2, "Lincoln" },
                    { 16, 7, "Suzuki" },
                    { 17, 4, "Volvo" },
                    { 18, 15, "Scania" },
                    { 19, 16, "DAF" },
                    { 20, 2, "Tesla" },
                    { 21, 5, "Volkswagen" },
                    { 22, 17, "Cupra" },
                    { 23, 7, "Toyota" },
                    { 24, 7, "Subaru" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BrandId", "ColorId", "DriveId", "IsWanted", "LicensePlate", "Mileage", "Model", "Owner", "Year" },
                values: new object[,]
                {
                    { 1, 1, 10, 3, false, "BK6969TR", 0.0, "RS 7", "ANDRII HRITSIUK", 2023 },
                    { 2, 2, 8, 2, false, "BK1986CH", 1986.04, "220", "SVIATOSLAV SAPACH", 2015 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_CountryId",
                table: "Brands",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DriveId",
                table: "Cars",
                column: "DriveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Drives");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
