using Microsoft.EntityFrameworkCore.Migrations;

namespace DronOfFuture.App.Persistencia.Migrations
{
    public partial class NewM3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Pedidos");
        }
    }
}
