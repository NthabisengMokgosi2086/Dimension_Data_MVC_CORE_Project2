using Microsoft.EntityFrameworkCore.Migrations;

namespace Dimension_Data_MVC_CORE_Project2.Data.Migrations
{
    public partial class InitialManagerContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attrition = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    DailyRate = table.Column<float>(nullable: false),
                    Department = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EmployeeCount = table.Column<float>(nullable: false),
                    EmployeeNumber = table.Column<float>(nullable: false),
                    HourlyRate = table.Column<float>(nullable: false),
                    JobInvolvement = table.Column<float>(nullable: false),
                    JobRole = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    MonthlyIncome = table.Column<float>(nullable: false),
                    MonthlyRate = table.Column<float>(nullable: false),
                    OverTime = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    PercentSalaryHike = table.Column<float>(nullable: false),
                    PerformanceRating = table.Column<float>(nullable: false),
                    StandardHours = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
