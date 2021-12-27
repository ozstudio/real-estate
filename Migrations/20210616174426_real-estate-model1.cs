using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace realEstate.Migrations
{
    public partial class realestatemodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "realEstateModels",
                columns: table => new
                {
                    RealEstateModelId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AC = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Elevator = table.Column<string>(nullable: true),
                    Floor = table.Column<int>(nullable: false),
                    Image1 = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Meters = table.Column<int>(nullable: false),
                    Parking = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PropertyStatus = table.Column<string>(nullable: true),
                    Rooms = table.Column<int>(nullable: false),
                    image3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_realEstateModels", x => x.RealEstateModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "realEstateModels");
        }
    }
}
