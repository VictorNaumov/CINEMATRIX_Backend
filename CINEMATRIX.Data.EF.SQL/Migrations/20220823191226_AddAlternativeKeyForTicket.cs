using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class AddAlternativeKeyForTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_SessionId",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SessionId_SeatId",
                table: "Tickets",
                columns: new[] { "SessionId", "SeatId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_SessionId_SeatId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "Sessions");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SessionId",
                table: "Tickets",
                column: "SessionId");
        }
    }
}
