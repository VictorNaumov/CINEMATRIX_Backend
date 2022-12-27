using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class AddMovieCommentFavoriteMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteMovies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileId = table.Column<long>(type: "bigint", nullable: false),
                    MovieId = table.Column<long>(type: "bigint", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteMovies_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCommentId = table.Column<long>(type: "bigint", nullable: true),
                    MovieId = table.Column<long>(type: "bigint", nullable: false),
                    ProfileId = table.Column<long>(type: "bigint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieComments_MovieComments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "MovieComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovieComments_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteMovies_ProfileId",
                table: "FavoriteMovies",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieComments_ParentCommentId",
                table: "MovieComments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieComments_ProfileId",
                table: "MovieComments",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteMovies");

            migrationBuilder.DropTable(
                name: "MovieComments");
        }
    }
}
