using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCars.Data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(maxLength: 15, nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ImgURL = table.Column<string>(nullable: true),
                    Mileage = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Engine = table.Column<int>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    Transmission = table.Column<int>(nullable: false),
                    ProductionDate = table.Column<DateTime>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
