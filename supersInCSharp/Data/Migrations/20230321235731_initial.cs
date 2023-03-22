using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace supersInCSharp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlterEgo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryAbility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryAbility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatchPhrase = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}
