using Microsoft.EntityFrameworkCore.Migrations;

namespace DronOfFuture.App.Persistencia.Migrations
{
    public partial class newM2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contenido",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fecha",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDron",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEncargado",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Satisfaccion",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPedido",
                table: "Estados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temperatura",
                table: "Estados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TiempoFaltante",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Encargado",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contenido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdDron",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdEncargado",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Satisfaccion",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "Temperatura",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "TiempoFaltante",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Encargado");
        }
    }
}
