using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class FluentApiOTM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Ucrania");

            migrationBuilder.AddColumn<int>(
                name: "FKCountry",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_FKCountry",
                table: "Cities",
                column: "FKCountry");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_FKCountry",
                table: "Cities",
                column: "FKCountry",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_FKCountry",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_FKCountry",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "FKCountry",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Ucrania",
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Countries",
                type: "date",
                nullable: false,
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
