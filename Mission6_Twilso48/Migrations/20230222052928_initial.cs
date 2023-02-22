using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_Twilso48.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Responses_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Family" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Adventure" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Thriller" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "John Lasseter", null, null, "Best Movie Ever", "G", "Cars", 2006 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 2, "Cary Joji Fukunaga", null, null, "Enough to make a man cry", "PG-13", "007: No Time to Die", 2021 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, "John Lasseter", null, null, "Not as good as the first", "G", "Cars 2", 2011 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryID",
                table: "Responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
