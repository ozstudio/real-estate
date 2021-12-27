using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace realEstate.Migrations
{
    public partial class tableWithAgentPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgentPhoto",
                table: "Agents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentPhoto",
                table: "Agents");
        }
    }
}
