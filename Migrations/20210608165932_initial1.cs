using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace realEstate.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RealEstateModelId",
                table: "Agents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "RealEstateModelId",
                table: "Agents",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
