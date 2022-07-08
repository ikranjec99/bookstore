using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.Migrations
{
    public partial class AddBorrowedBookEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IdentityUserId = table.Column<string>(type: "text", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    BorrowedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ReturnedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookId",
                table: "BorrowedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_IdentityUserId_BookId_BorrowedAt",
                table: "BorrowedBooks",
                columns: new[] { "IdentityUserId", "BookId", "BorrowedAt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBooks");
        }
    }
}
