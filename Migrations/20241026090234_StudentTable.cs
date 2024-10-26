using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentRegistration.Core.Migrations
{
    /// <inheritdoc />
    public partial class StudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentReg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "Varchar(30)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "Varchar(30)", nullable: false),
                    MobileNumber = table.Column<string>(type: "Varchar(10)", nullable: false),
                    Country = table.Column<string>(type: "Varchar(30)", nullable: false),
                    State = table.Column<string>(type: "Varchar(30)", nullable: false),
                    City = table.Column<string>(type: "Varchar(30)", nullable: false),
                    Address = table.Column<string>(type: "Varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentReg", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentReg");
        }
    }
}
