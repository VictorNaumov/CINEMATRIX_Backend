using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class AddedFieldMovieTitileInSessions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieTitle",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieTitle",
                table: "Sessions");
        }
    }
}
