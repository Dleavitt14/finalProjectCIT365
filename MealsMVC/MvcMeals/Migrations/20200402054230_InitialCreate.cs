using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMeals.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DayOfWeek = table.Column<string>(nullable: true),
                    RecipeLink = table.Column<string>(nullable: true),
                    Cook = table.Column<string>(nullable: true),
                    MainDish = table.Column<string>(nullable: true),
                    SideDish1 = table.Column<string>(nullable: true),
                    SideDish2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meal");
        }
    }
}
