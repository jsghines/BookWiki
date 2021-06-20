using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookWiki.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TagName = table.Column<string>(type: "text", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InsertedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TagId = table.Column<Guid>(type: "uuid", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InsertedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WikiEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    EntryName = table.Column<string>(type: "text", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InsertedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WikiEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WikiEntry_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WikiEntrySubheading",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EntryId = table.Column<Guid>(type: "uuid", nullable: true),
                    SubheadingName = table.Column<string>(type: "text", nullable: true),
                    EntryText = table.Column<string>(type: "text", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InsertedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WikiEntrySubheading", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WikiEntrySubheading_WikiEntry_EntryId",
                        column: x => x.EntryId,
                        principalTable: "WikiEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WikiEntryTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EntryId = table.Column<Guid>(type: "uuid", nullable: true),
                    TagId = table.Column<Guid>(type: "uuid", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InsertedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WikiEntryTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WikiEntryTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WikiEntryTag_WikiEntry_EntryId",
                        column: x => x.EntryId,
                        principalTable: "WikiEntry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_TagId",
                table: "Category",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_WikiEntry_CategoryId",
                table: "WikiEntry",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WikiEntrySubheading_EntryId",
                table: "WikiEntrySubheading",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_WikiEntryTag_EntryId",
                table: "WikiEntryTag",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_WikiEntryTag_TagId",
                table: "WikiEntryTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WikiEntrySubheading");

            migrationBuilder.DropTable(
                name: "WikiEntryTag");

            migrationBuilder.DropTable(
                name: "WikiEntry");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Tag");
        }
    }
}
