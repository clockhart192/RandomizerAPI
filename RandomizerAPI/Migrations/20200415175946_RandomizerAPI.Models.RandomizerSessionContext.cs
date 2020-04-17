using Microsoft.EntityFrameworkCore.Migrations;

namespace RandomizerAPI.Migrations
{
    public partial class RandomizerAPIModelsRandomizerSessionContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RandomizerSessions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionID = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Game = table.Column<int>(nullable: false),
                    SpoilerLog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandomizerSessions", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RandomizerSessions");
        }
    }
}
