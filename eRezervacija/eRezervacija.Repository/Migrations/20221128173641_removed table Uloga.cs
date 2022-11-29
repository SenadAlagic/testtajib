using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eRezervacija.Repository.Migrations
{
    /// <inheritdoc />
    public partial class removedtableUloga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Uloge_UlogaID",
                table: "Korisnici");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropIndex(
                name: "IX_Korisnici_UlogaID",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "UlogaID",
                table: "Korisnici");

            migrationBuilder.AddColumn<string>(
                name: "Uloga",
                table: "Korisnici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uloga",
                table: "Korisnici");

            migrationBuilder.AddColumn<int>(
                name: "UlogaID",
                table: "Korisnici",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogaID",
                table: "Korisnici",
                column: "UlogaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Uloge_UlogaID",
                table: "Korisnici",
                column: "UlogaID",
                principalTable: "Uloge",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
