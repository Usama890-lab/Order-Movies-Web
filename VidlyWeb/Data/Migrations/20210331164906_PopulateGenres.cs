using Microsoft.EntityFrameworkCore.Migrations;

namespace VidlyWeb.Data.Migrations
{
    public partial class PopulateGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Horror')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Children')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (5, 'Thriller')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (6, 'Fantasy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (7, 'Sci-Fi')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (8, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (9, 'Drama')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (10, 'Romantic-Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (11, 'Western')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
