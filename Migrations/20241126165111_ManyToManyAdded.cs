using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel.Migrations
{
    public partial class ManyToManyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_Habitaciones_HabitacionesIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Usuarios_UsuarioIdUsuario",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UsuarioIdUsuario",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_HabitacionesIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "HabitacionesIdHabitacion",
                table: "Habitaciones");

            migrationBuilder.CreateTable(
                name: "Reservaciones",
                columns: table => new
                {
                    IdReservaciones = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHabitaciones = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Noches = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservaciones", x => x.IdReservaciones);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Habitaciones_IdHabitaciones",
                        column: x => x.IdHabitaciones,
                        principalTable: "Habitaciones",
                        principalColumn: "IdHabitacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservaciones_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_IdHabitaciones",
                table: "Reservaciones",
                column: "IdHabitaciones");

            migrationBuilder.CreateIndex(
                name: "IX_Reservaciones_IdUsuario",
                table: "Reservaciones",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservaciones");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HabitacionesIdHabitacion",
                table: "Habitaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioIdUsuario",
                table: "Usuarios",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_HabitacionesIdHabitacion",
                table: "Habitaciones",
                column: "HabitacionesIdHabitacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_Habitaciones_HabitacionesIdHabitacion",
                table: "Habitaciones",
                column: "HabitacionesIdHabitacion",
                principalTable: "Habitaciones",
                principalColumn: "IdHabitacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Usuarios_UsuarioIdUsuario",
                table: "Usuarios",
                column: "UsuarioIdUsuario",
                principalTable: "Usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
