using Microsoft.EntityFrameworkCore.Migrations;

namespace SafeHouse.Data.Migrations
{
    public partial class DailyEntryMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ParentsContact",
                table: "DailyEntry",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentsContact",
                table: "DailyEntry",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
