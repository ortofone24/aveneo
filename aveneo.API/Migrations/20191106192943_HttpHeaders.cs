using Microsoft.EntityFrameworkCore.Migrations;

namespace aveneo.API.Migrations
{
    public partial class HttpHeaders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HttpHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accept = table.Column<string>(nullable: true),
                    AcceptEncoding = table.Column<string>(nullable: true),
                    AcceptLanguage = table.Column<string>(nullable: true),
                    Connection = table.Column<string>(nullable: true),
                    Host = table.Column<string>(nullable: true),
                    Referer = table.Column<string>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    Dnt = table.Column<string>(nullable: true),
                    SecFetchSite = table.Column<string>(nullable: true),
                    SecFetchMode = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HttpHeaders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HttpHeaders");
        }
    }
}
