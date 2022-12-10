using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInvestmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    existingCustomer = table.Column<bool>(type: "INTEGER", nullable: false),
                    emailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    phoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    inquiryOptions = table.Column<string>(type: "TEXT", nullable: false),
                    userInquiry = table.Column<string>(type: "TEXT", nullable: false),
                    isTesolved = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "investmentCalcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    principle = table.Column<int>(type: "INTEGER", nullable: false),
                    intrest = table.Column<int>(type: "INTEGER", nullable: false),
                    years = table.Column<int>(type: "INTEGER", nullable: false),
                    compoundsPerYear = table.Column<int>(type: "INTEGER", nullable: false),
                    whichUser = table.Column<string>(type: "TEXT", nullable: false),
                    futureValue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_investmentCalcs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "investmentCalcs");
        }
    }
}
