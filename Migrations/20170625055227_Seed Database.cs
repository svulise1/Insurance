using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Companies(Name) VALUES ('StateFarm')");
            migrationBuilder.Sql("INSERT INTO Companies(Name) VALUES ('Geico')");
            migrationBuilder.Sql("INSERT INTO Companies(Name) VALUES ('Progressive')");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('StateFarm-Vechile',(SELECT Id FROM Companies WHERE Name='StateFarm')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('StateFarm-Home',(SELECT Id FROM Companies WHERE Name='StateFarm')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('StateFarm-Life',(SELECT Id FROM Companies WHERE Name='StateFarm')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('Geico-Vechile',(SELECT Id FROM Companies WHERE Name='Geico')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('Geico-Home',(SELECT Id FROM Companies WHERE Name='Geico')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('Geico-Life',(SELECT Id FROM Companies WHERE Name='Geico')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('Progressive-Vechile',(SELECT Id FROM Companies WHERE Name='Progressive')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('Progressive-Home',(SELECT Id FROM Companies WHERE Name='Progressive')) ");
            migrationBuilder.Sql("INSERT INTO InsType(Name,CompanyId) VALUES('Progressive-Life',(SELECT Id FROM Companies WHERE Name='Progressive')) ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Companies WHERE Name IN('StateFarm','Geico','Progressive')");
        }
    }
}
