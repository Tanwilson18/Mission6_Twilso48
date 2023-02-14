using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_Twilso48.Migrations
{
    public partial class intialmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Stalker",
                table: "response");

            migrationBuilder.DropColumn(
                name: "age",
                table: "response");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "response");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "response",
                newName: "MovieID");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "response",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "response",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Edited",
                table: "response",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LentTo",
                table: "response",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "response",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "response",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "response",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "response",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "response",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Family", "John Lasseter", null, null, "Best Movie Ever", "G", "Cars", 2006 });

            migrationBuilder.InsertData(
                table: "response",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action", "Cary Joji Fukunaga", null, null, "Enough to make a man cry", "PG-13", "007: No Time to Die", 2021 });

            migrationBuilder.InsertData(
                table: "response",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Family", "John Lasseter", null, null, "Not as good as the first", "G", "Cars 2", 2011 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "response",
                keyColumn: "MovieID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "response",
                keyColumn: "MovieID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "response",
                keyColumn: "MovieID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Category",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "response");

            migrationBuilder.DropColumn(
                name: "LentTo",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "response");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "response");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "response",
                newName: "MovieId");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "response",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "response",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "response",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Stalker",
                table: "response",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte>(
                name: "age",
                table: "response",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "response",
                type: "TEXT",
                nullable: true);
        }
    }
}
