using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class FluentApiModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_City_TBL_Country_FKid",
                table: "TBL_City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_Country",
                table: "TBL_Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_City",
                table: "TBL_City");

            migrationBuilder.DropIndex(
                name: "IX_TBL_City_FKid",
                table: "TBL_City");

            migrationBuilder.DropColumn(
                name: "KeyId",
                table: "TBL_Country");

            migrationBuilder.DropColumn(
                name: "FKid",
                table: "TBL_City");

            migrationBuilder.RenameTable(
                name: "TBL_Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "TBL_City",
                newName: "Cities");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Cities",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldUnicode: false,
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Countries",
                nullable: false,
                defaultValue: "Ucrania",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Countries",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Countries",
                type: "date",
                nullable: false,
                defaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Population",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "TBL_Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "TBL_City");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "TBL_Country",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TBL_City",
                newName: "CityName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employee",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Employee",
                type: "varchar(25)",
                unicode: false,
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TBL_Country",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldDefaultValue: "Ucrania");

            migrationBuilder.AddColumn<int>(
                name: "KeyId",
                table: "TBL_Country",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "TBL_City",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FKid",
                table: "TBL_City",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_Country",
                table: "TBL_Country",
                column: "KeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_City",
                table: "TBL_City",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_City_FKid",
                table: "TBL_City",
                column: "FKid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_City_TBL_Country_FKid",
                table: "TBL_City",
                column: "FKid",
                principalTable: "TBL_Country",
                principalColumn: "KeyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
