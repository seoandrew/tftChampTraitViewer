using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tftChampTraitViewer.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Champion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChampName = table.Column<string>(type: "TEXT", nullable: false),
                    ChampGender = table.Column<string>(type: "TEXT", nullable: false),
                    ChampOrigin = table.Column<string>(type: "TEXT", nullable: false),
                    ChampClass = table.Column<string>(type: "TEXT", nullable: false),
                    ChampCost = table.Column<string>(type: "TEXT", nullable: false),
                    ChampRange = table.Column<string>(type: "TEXT", nullable: false),
                    ChampPosition = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champion", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Champion");
        }
    }
}
