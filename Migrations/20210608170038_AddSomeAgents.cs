using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace realEstate.Migrations
{
    public partial class AddSomeAgents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Agents(SellingAgentName,AgentPhoto) VALUES ('Alex','~/images/agent.png')");
            migrationBuilder.Sql("INSERT INTO Agents(SellingAgentName,AgentPhoto) VALUES ('Sonia','~/images/agent.png')");
            migrationBuilder.Sql("INSERT INTO Agents(SellingAgentName,AgentPhoto) VALUES ('Josh','~/images/agent.png')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
