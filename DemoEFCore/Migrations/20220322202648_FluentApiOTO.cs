using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class FluentApiOTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CityInformationId",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Cities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CityInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Population = table.Column<int>(nullable: false),
                    OtherName = table.Column<string>(nullable: true),
                    MayorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityInformation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityInformationId",
                table: "Cities",
                column: "CityInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CityInformation_CityInformationId",
                table: "Cities",
                column: "CityInformationId",
                principalTable: "CityInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CityInformation_CityInformationId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "CityInformation");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CityInformationId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityInformationId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "FKCountry",
                table: "Cities",
                type: "int",
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
    }
}
