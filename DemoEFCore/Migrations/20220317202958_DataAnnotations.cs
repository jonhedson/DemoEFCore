using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "TBL_Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "TBL_City");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TBL_City",
                newName: "CityName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TBL_Country",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KeyId",
                table: "TBL_Country",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "TBL_City",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FKid",
                table: "TBL_City",
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
                name: "FK_TBL_City_TBL_Country_FKid",
                table: "TBL_City",
                column: "FKid",
                principalTable: "TBL_Country",
                principalColumn: "KeyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CityName",
                table: "Cities",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
