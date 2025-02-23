using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NbnBotClean.Infrastructure.Migrations.NbnBotDb
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "service_classes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_class = table.Column<int>(type: "int", nullable: true),
                    technology = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_types = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("service_classes_PRIMARY", x => x.id);
                });
				
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "service_classes");
        }
    }
}
