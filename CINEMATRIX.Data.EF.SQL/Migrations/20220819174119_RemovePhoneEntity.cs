using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class RemovePhoneEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_Phones_PhoneId",
                table: "PersonalData");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_PhoneId",
                table: "PersonalData");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "PersonalData");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PersonalData",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PersonalData");

            migrationBuilder.AddColumn<long>(
                name: "PhoneId",
                table: "PersonalData",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_PhoneId",
                table: "PersonalData",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_Phones_PhoneId",
                table: "PersonalData",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
