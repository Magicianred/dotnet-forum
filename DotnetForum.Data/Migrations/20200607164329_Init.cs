using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetForum.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agreements",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    effective_datetime = table.Column<DateTime>(nullable: false),
                    lang_region = table.Column<string>(nullable: false),
                    statements = table.Column<string>(nullable: false),
                    version = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agreements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    inactive_datetime = table.Column<DateTime>(nullable: true),
                    profile_image_url = table.Column<string>(nullable: false),
                    member_description = table.Column<string>(nullable: false),
                    rating = table.Column<int>(nullable: false),
                    is_active = table.Column<bool>(nullable: false),
                    is_admin = table.Column<bool>(nullable: false),
                    member_since = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "forums",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    forum_name = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    image_url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_forums", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    tag_name = table.Column<string>(nullable: false),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.tag_name);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "member_agreements",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    AgreementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member_agreements", x => x.id);
                    table.ForeignKey(
                        name: "FK_member_agreements_agreements_AgreementId",
                        column: x => x.AgreementId,
                        principalTable: "agreements",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_member_agreements_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    message = table.Column<string>(nullable: false),
                    FromId = table.Column<int>(nullable: true),
                    ToId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_messages_AspNetUsers_FromId",
                        column: x => x.FromId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_messages_AspNetUsers_ToId",
                        column: x => x.ToId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    title = table.Column<string>(maxLength: 128, nullable: false),
                    body = table.Column<string>(type: "text", nullable: false),
                    upvote = table.Column<int>(nullable: false),
                    downvote = table.Column<int>(nullable: false),
                    archived = table.Column<bool>(nullable: false),
                    ForumId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_posts_forums_ForumId",
                        column: x => x.ForumId,
                        principalTable: "forums",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_posts_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "attachments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    file_name = table.Column<string>(nullable: false),
                    file_size = table.Column<long>(nullable: false),
                    file_content_type = table.Column<string>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachments", x => x.id);
                    table.ForeignKey(
                        name: "FK_attachments_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "posts_tags",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false),
                    TagName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts_tags", x => new { x.PostId, x.TagName });
                    table.ForeignKey(
                        name: "FK_posts_tags_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_posts_tags_tags_TagName",
                        column: x => x.TagName,
                        principalTable: "tags",
                        principalColumn: "tag_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "replies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    created_datetime_utc = table.Column<DateTime>(nullable: false),
                    last_modified_datetime_utc = table.Column<DateTime>(nullable: true),
                    message = table.Column<string>(nullable: false),
                    upvote = table.Column<int>(nullable: false),
                    downvote = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_replies", x => x.id);
                    table.ForeignKey(
                        name: "FK_replies_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_replies_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_attachments_PostId",
                table: "attachments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_forums_forum_name",
                table: "forums",
                column: "forum_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_member_agreements_AgreementId",
                table: "member_agreements",
                column: "AgreementId");

            migrationBuilder.CreateIndex(
                name: "IX_member_agreements_MemberId",
                table: "member_agreements",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_FromId",
                table: "messages",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_ToId",
                table: "messages",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_ForumId",
                table: "posts",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_MemberId",
                table: "posts",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_tags_TagName",
                table: "posts_tags",
                column: "TagName");

            migrationBuilder.CreateIndex(
                name: "IX_replies_MemberId",
                table: "replies",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_replies_PostId",
                table: "replies",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "attachments");

            migrationBuilder.DropTable(
                name: "member_agreements");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "posts_tags");

            migrationBuilder.DropTable(
                name: "replies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "agreements");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "forums");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
