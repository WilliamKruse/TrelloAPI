using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrelloEF.Migrations
{
    public partial class title : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Todos",
                nullable: true);

            migrationBuilder.Sql(
                @"
                UPDATE Todos
                SET Title = Name || ':' || Category;

                ");
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Todos");
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Todos",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Todos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
