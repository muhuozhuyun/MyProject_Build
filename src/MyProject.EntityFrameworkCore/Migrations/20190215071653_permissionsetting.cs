using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class permissionsetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermissionSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PermissionId = table.Column<int>(nullable: false),
                    PermissionCode = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(maxLength: 256, nullable: true),
                    Index = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissionSettings_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionSettings_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PermissionSettings_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PermissionSettings_PermissionId",
                table: "PermissionSettings",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionSettings_RoleId",
                table: "PermissionSettings",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionSettings_UserId",
                table: "PermissionSettings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionSettings");
        }
    }
}
