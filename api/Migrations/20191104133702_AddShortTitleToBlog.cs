using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddShortTitleToBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortTitle",
                table: "Posts",
                maxLength: 25,
                nullable: false);

            migrationBuilder.Sql(
                @"
                    UPDATE Customer
                    SET ShortTitle = SUBSTRING(Title,1,25);
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortTitle",
                table: "Posts");
        }
    }
}
