using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Beautique.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Shampoos & Conditioners" },
                    { 2, 2, "Body Washes & Soaps" },
                    { 3, 3, "Facial Care" },
                    { 4, 4, "Body Care" },
                    { 5, 5, "Deodorants & Antiperspirants" },
                    { 6, 6, "Shaving Products" },
                    { 7, 7, "Nail Care" },
                    { 8, 8, "Perfumes & Fragrances" },
                    { 9, 9, "Lip Care" },
                    { 10, 10, "Hand Care" },
                    { 11, 11, "Hair Care" },
                    { 12, 12, "Eye & Eyelid Care" },
                    { 13, 13, "Cleansing & Makeup Removal" },
                    { 14, 14, "Organic & Bio Cosmetics" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "CompanyId", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "SkinCare City", null, "Glow & Care", "5557778888", "54321", "CA", "123 Beauty Ave" },
                    { 2, "GreenVille", null, "Nature's Touch", "4446669999", "67890", "OR", "456 Herbal Rd" },
                    { 3, "Shampoo Town", null, "Silky Locks", "3335557777", "11223", "TX", "789 Hair Blvd" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "CategoryId", "Description", "ImageUrl", "ListPrice", "Maker", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "SW123456789", 1, "A premium shampoo that provides ultimate shine and smoothness.", "", 55.0, "SparkLife", 50.0, 40.0, 45.0, "ShineWave" },
                    { 2, "PG987654321", 2, "A gentle body wash that leaves your skin refreshed and hydrated.", "", 40.0, "CleanseCo", 35.0, 25.0, 30.0, "PureGlow" },
                    { 3, "ST111223344", 3, "A soft and nourishing facial cream for smooth and glowing skin.", "", 65.0, "VelvetSkin", 60.0, 50.0, 55.0, "SoftTouch" },
                    { 4, "CS554433221", 5, "A refreshing deodorant spray that keeps you fresh all day long.", "", 20.0, "LushCare", 18.0, 14.0, 16.0, "ClearSpark" },
                    { 5, "FC998877665", 6, "A shaving gel that provides a smooth and irritation-free shave.", "", 35.0, "SharpEdge", 30.0, 25.0, 28.0, "FreshCut" },
                    { 6, "GN332211445", 7, "A long-lasting nail polish with vibrant colors and a glossy finish.", "", 15.0, "NailArt", 13.0, 10.0, 12.0, "GlowNail" },
                    { 7, "EV776655443", 8, "A fresh and uplifting fragrance that is perfect for daily wear.", "", 50.0, "ScentAura", 45.0, 35.0, 40.0, "EauVibe" },
                    { 8, "SK223344556", 9, "A hydrating lip balm with a smooth texture and subtle scent.", "", 10.0, "LipsCare", 9.0, 7.0, 8.0, "SoftKiss" },
                    { 9, "HH556677889", 10, "A nourishing hand cream that keeps your skin soft and hydrated.", "", 18.0, "SkinGuard", 16.0, 12.0, 14.0, "HandHeal" },
                    { 10, "EL998877665", 12, "A rejuvenating eye cream that targets puffiness and dark circles.", "", 45.0, "VisionGlow", 40.0, 30.0, 35.0, "EyeLuxe" },
                    { 11, "BC000000011", 11, "A nourishing oil for damaged hair.", "", 33.0, "GlowHair", 28.0, 18.0, 23.0, "ShineElixir" },
                    { 12, "BC000000012", 12, "Targets dark circles and fine lines.", "", 58.0, "BrightEyes", 53.0, 43.0, 48.0, "CalmBright" },
                    { 13, "BC000000013", 13, "A gentle remover for all makeup types.", "", 50.0, "CleanSwipe", 45.0, 35.0, 40.0, "MicellarWipe" },
                    { 14, "BC000000014", 14, "An organic skin lotion with no parabens.", "", 45.0, "BioCare", 40.0, 30.0, 35.0, "BioVital" },
                    { 15, "BC000000015", 1, "A revitalizing shampoo for daily use.", "", 20.0, "ShinyLocks", 15.0, 5.0, 10.0, "HydraBounce" },
                    { 16, "BC000000016", 2, "A moisturizing body wash with essential oils.", "", 36.0, "AquaFresh", 31.0, 21.0, 26.0, "ZenAqua" },
                    { 17, "BC000000017", 3, "A facial cream enriched with vitamins.", "", 23.0, "DermaGlow", 18.0, 8.0, 13.0, "ToneCare" },
                    { 18, "BC000000018", 4, "A hydrating lotion for silky skin.", "", 41.0, "SmoothCare", 36.0, 26.0, 31.0, "SmoothHydra" },
                    { 19, "BC000000019", 5, "A long-lasting deodorant for active days.", "", 55.0, "FreshShield", 50.0, 40.0, 45.0, "BlockActive" },
                    { 20, "BC000000020", 6, "A rich shaving cream for sensitive skin.", "", 27.0, "BladeGuard", 22.0, 12.0, 17.0, "BladeSmooth" },
                    { 21, "BC000000021", 7, "Bright nail polish with lasting power.", "", 60.0, "ColorShine", 55.0, 45.0, 50.0, "TintSparkle" },
                    { 22, "BC000000022", 8, "A light perfume with floral notes.", "", 54.0, "EssenceMist", 49.0, 39.0, 44.0, "AuraMist" },
                    { 23, "BC000000023", 9, "A soothing balm for chapped lips.", "", 58.0, "LipSilk", 53.0, 43.0, 48.0, "SilkSoft" },
                    { 24, "BC000000024", 10, "A cream to restore dry hands.", "", 47.0, "PalmSoft", 42.0, 32.0, 37.0, "HealCare" },
                    { 25, "BC000000025", 11, "A nourishing oil for damaged hair.", "", 58.0, "GlowHair", 53.0, 43.0, 48.0, "NourishSilk" },
                    { 26, "BC000000026", 12, "Targets dark circles and fine lines.", "", 50.0, "BrightEyes", 45.0, 35.0, 40.0, "FreshEye" },
                    { 27, "BC000000027", 13, "A gentle remover for all makeup types.", "", 57.0, "CleanSwipe", 52.0, 42.0, 47.0, "WashMicellar" },
                    { 28, "BC000000028", 14, "An organic skin lotion with no parabens.", "", 53.0, "BioCare", 48.0, 38.0, 43.0, "HerbalOrganic" },
                    { 29, "BC000000029", 1, "A revitalizing shampoo for daily use.", "", 61.0, "ShinyLocks", 56.0, 46.0, 51.0, "SmoothGlow" },
                    { 30, "BC000000030", 2, "A moisturizing body wash with essential oils.", "", 36.0, "AquaFresh", 31.0, 21.0, 26.0, "PureCleanse" },
                    { 31, "BC000000031", 3, "A facial cream enriched with vitamins.", "", 25.0, "DermaGlow", 20.0, 10.0, 15.0, "ToneBalance" },
                    { 32, "BC000000032", 4, "A hydrating lotion for silky skin.", "", 61.0, "SmoothCare", 56.0, 46.0, 51.0, "HydraSilk" },
                    { 33, "BC000000033", 5, "A long-lasting deodorant for active days.", "", 43.0, "FreshShield", 38.0, 28.0, 33.0, "BlockPower" },
                    { 34, "BC000000034", 6, "A rich shaving cream for sensitive skin.", "", 49.0, "BladeGuard", 44.0, 34.0, 39.0, "FreshCalm" },
                    { 35, "BC000000035", 7, "Bright nail polish with lasting power.", "", 23.0, "ColorShine", 18.0, 8.0, 13.0, "PopTint" },
                    { 36, "BC000000036", 8, "A light perfume with floral notes.", "", 31.0, "EssenceMist", 26.0, 16.0, 21.0, "MistDream" },
                    { 37, "BC000000037", 9, "A soothing balm for chapped lips.", "", 42.0, "LipSilk", 37.0, 27.0, 32.0, "SilkSmooth" },
                    { 38, "BC000000038", 10, "A cream to restore dry hands.", "", 25.0, "PalmSoft", 20.0, 10.0, 15.0, "CalmShield" },
                    { 39, "BC000000039", 11, "A nourishing oil for damaged hair.", "", 56.0, "GlowHair", 51.0, 41.0, 46.0, "ShineCare" },
                    { 40, "BC000000040", 12, "Targets dark circles and fine lines.", "", 54.0, "BrightEyes", 49.0, 39.0, 44.0, "LuxeEye" },
                    { 41, "BC000000041", 13, "A gentle remover for all makeup types.", "", 53.0, "CleanSwipe", 48.0, 38.0, 43.0, "FoamWash" },
                    { 42, "BC000000042", 14, "An organic skin lotion with no parabens.", "", 58.0, "BioCare", 53.0, 43.0, 48.0, "BioOrganic" },
                    { 43, "BC000000043", 1, "A revitalizing shampoo for daily use.", "", 60.0, "ShinyLocks", 55.0, 45.0, 50.0, "SilkBounce" },
                    { 44, "BC000000044", 2, "A moisturizing body wash with essential oils.", "", 51.0, "AquaFresh", 46.0, 36.0, 41.0, "PureBloom" },
                    { 45, "BC000000045", 3, "A facial cream enriched with vitamins.", "", 30.0, "DermaGlow", 25.0, 15.0, 20.0, "FreshBalance" },
                    { 46, "BC000000046", 4, "A hydrating lotion for silky skin.", "", 35.0, "SmoothCare", 30.0, 20.0, 25.0, "TouchSmooth" },
                    { 47, "BC000000047", 5, "A long-lasting deodorant for active days.", "", 27.0, "FreshShield", 22.0, 12.0, 17.0, "GuardZone" },
                    { 48, "BC000000048", 6, "A rich shaving cream for sensitive skin.", "", 51.0, "BladeGuard", 46.0, 36.0, 41.0, "FoamSmooth" },
                    { 49, "BC000000049", 7, "Bright nail polish with lasting power.", "", 65.0, "ColorShine", 60.0, 50.0, 55.0, "TintGlam" },
                    { 50, "BC000000050", 8, "A light perfume with floral notes.", "", 27.0, "EssenceMist", 22.0, 12.0, 17.0, "DreamBloom" },
                    { 51, "BC000000051", 9, "A soothing balm for chapped lips.", "", 51.0, "LipSilk", 46.0, 36.0, 41.0, "SoftSilk" },
                    { 52, "BC000000052", 10, "A cream to restore dry hands.", "", 54.0, "PalmSoft", 49.0, 39.0, 44.0, "RepairCalm" },
                    { 53, "BC000000053", 11, "A nourishing oil for damaged hair.", "", 42.0, "GlowHair", 37.0, 27.0, 32.0, "OilCare" },
                    { 54, "BC000000054", 12, "Targets dark circles and fine lines.", "", 23.0, "BrightEyes", 18.0, 8.0, 13.0, "CalmLuxe" },
                    { 55, "BC000000055", 13, "A gentle remover for all makeup types.", "", 54.0, "CleanSwipe", 49.0, 39.0, 44.0, "MicellarClean" },
                    { 56, "BC000000056", 14, "An organic skin lotion with no parabens.", "", 52.0, "BioCare", 47.0, 37.0, 42.0, "NatureGreen" },
                    { 57, "BC000000057", 1, "A revitalizing shampoo for daily use.", "", 62.0, "ShinyLocks", 57.0, 47.0, 52.0, "ShineSilk" },
                    { 58, "BC000000058", 2, "A moisturizing body wash with essential oils.", "", 17.0, "AquaFresh", 12.0, 2.0, 7.0, "BloomFoam" },
                    { 59, "BC000000059", 3, "A facial cream enriched with vitamins.", "", 47.0, "DermaGlow", 42.0, 32.0, 37.0, "VelvetGlow" },
                    { 60, "BC000000060", 4, "A hydrating lotion for silky skin.", "", 53.0, "SmoothCare", 48.0, 38.0, 43.0, "ButterSilk" },
                    { 61, "BC000000061", 5, "A long-lasting deodorant for active days.", "", 43.0, "FreshShield", 38.0, 28.0, 33.0, "FreshShield" },
                    { 62, "BC000000062", 6, "A rich shaving cream for sensitive skin.", "", 53.0, "BladeGuard", 48.0, 38.0, 43.0, "SmoothCalm" },
                    { 63, "BC000000063", 7, "Bright nail polish with lasting power.", "", 42.0, "ColorShine", 37.0, 27.0, 32.0, "GlamTint" },
                    { 64, "BC000000064", 8, "A light perfume with floral notes.", "", 62.0, "EssenceMist", 57.0, 47.0, 52.0, "EssenceAura" },
                    { 65, "BC000000065", 9, "A soothing balm for chapped lips.", "", 30.0, "LipSilk", 25.0, 15.0, 20.0, "GlowSilk" },
                    { 66, "BC000000066", 10, "A cream to restore dry hands.", "", 19.0, "PalmSoft", 14.0, 4.0, 9.0, "CareGuard" },
                    { 67, "BC000000067", 11, "A nourishing oil for damaged hair.", "", 19.0, "GlowHair", 14.0, 4.0, 9.0, "ElixirSilk" },
                    { 68, "BC000000068", 12, "Targets dark circles and fine lines.", "", 21.0, "BrightEyes", 16.0, 6.0, 11.0, "GlowBright" },
                    { 69, "BC000000069", 13, "A gentle remover for all makeup types.", "", 48.0, "CleanSwipe", 43.0, 33.0, 38.0, "WashFoam" },
                    { 70, "BC000000070", 14, "An organic skin lotion with no parabens.", "", 23.0, "BioCare", 18.0, 8.0, 13.0, "PureBio" },
                    { 71, "BC000000071", 1, "A revitalizing shampoo for daily use.", "", 30.0, "ShinyLocks", 25.0, 15.0, 20.0, "LusterHydra" },
                    { 72, "BC000000072", 2, "A moisturizing body wash with essential oils.", "", 46.0, "AquaFresh", 41.0, 31.0, 36.0, "BloomWave" },
                    { 73, "BC000000073", 3, "A facial cream enriched with vitamins.", "", 35.0, "DermaGlow", 30.0, 20.0, 25.0, "VelvetTone" },
                    { 74, "BC000000074", 4, "A hydrating lotion for silky skin.", "", 25.0, "SmoothCare", 20.0, 10.0, 15.0, "TouchSilk" },
                    { 75, "BC000000075", 5, "A long-lasting deodorant for active days.", "", 16.0, "FreshShield", 11.0, 1.0, 6.0, "GuardPower" },
                    { 76, "BC000000076", 6, "A rich shaving cream for sensitive skin.", "", 52.0, "BladeGuard", 47.0, 37.0, 42.0, "EdgeFoam" },
                    { 77, "BC000000077", 7, "Bright nail polish with lasting power.", "", 27.0, "ColorShine", 22.0, 12.0, 17.0, "TintGloss" },
                    { 78, "BC000000078", 8, "A light perfume with floral notes.", "", 59.0, "EssenceMist", 54.0, 44.0, 49.0, "ScentBloom" },
                    { 79, "BC000000079", 9, "A soothing balm for chapped lips.", "", 22.0, "LipSilk", 17.0, 7.0, 12.0, "HydraGlow" },
                    { 80, "BC000000080", 10, "A cream to restore dry hands.", "", 17.0, "PalmSoft", 12.0, 2.0, 7.0, "VelvetSoft" },
                    { 81, "BC000000081", 11, "A nourishing oil for damaged hair.", "", 47.0, "GlowHair", 42.0, 32.0, 37.0, "OilSilk" },
                    { 82, "BC000000082", 12, "Targets dark circles and fine lines.", "", 42.0, "BrightEyes", 37.0, 27.0, 32.0, "CalmLift" },
                    { 83, "BC000000083", 13, "A gentle remover for all makeup types.", "", 16.0, "CleanSwipe", 11.0, 1.0, 6.0, "CleanMicellar" },
                    { 84, "BC000000084", 14, "An organic skin lotion with no parabens.", "", 49.0, "BioCare", 44.0, 34.0, 39.0, "OrganicBio" },
                    { 85, "BC000000085", 1, "A revitalizing shampoo for daily use.", "", 62.0, "ShinyLocks", 57.0, 47.0, 52.0, "FreshSilk" },
                    { 86, "BC000000086", 2, "A moisturizing body wash with essential oils.", "", 49.0, "AquaFresh", 44.0, 34.0, 39.0, "CleanseMist" },
                    { 87, "BC000000087", 3, "A facial cream enriched with vitamins.", "", 37.0, "DermaGlow", 32.0, 22.0, 27.0, "FreshSoft" },
                    { 88, "BC000000088", 4, "A hydrating lotion for silky skin.", "", 19.0, "SmoothCare", 14.0, 4.0, 9.0, "EssenceHydra" },
                    { 89, "BC000000089", 5, "A long-lasting deodorant for active days.", "", 37.0, "FreshShield", 32.0, 22.0, 27.0, "ZonePower" },
                    { 90, "BC000000090", 6, "A rich shaving cream for sensitive skin.", "", 50.0, "BladeGuard", 45.0, 35.0, 40.0, "BladeEdge" },
                    { 91, "BC000000091", 7, "Bright nail polish with lasting power.", "", 36.0, "ColorShine", 31.0, 21.0, 26.0, "PopColor" },
                    { 92, "BC000000092", 8, "A light perfume with floral notes.", "", 60.0, "EssenceMist", 55.0, 45.0, 50.0, "BloomAura" },
                    { 93, "BC000000093", 9, "A soothing balm for chapped lips.", "", 30.0, "LipSilk", 25.0, 15.0, 20.0, "BalmCare" },
                    { 94, "BC000000094", 10, "A cream to restore dry hands.", "", 58.0, "PalmSoft", 53.0, 43.0, 48.0, "CareHeal" },
                    { 95, "BC000000095", 11, "A nourishing oil for damaged hair.", "", 16.0, "GlowHair", 11.0, 1.0, 6.0, "DropNourish" },
                    { 96, "BC000000096", 12, "Targets dark circles and fine lines.", "", 27.0, "BrightEyes", 22.0, 12.0, 17.0, "LiftSoft" },
                    { 97, "BC000000097", 13, "A gentle remover for all makeup types.", "", 53.0, "CleanSwipe", 48.0, 38.0, 43.0, "CleanWash" },
                    { 98, "BC000000098", 14, "An organic skin lotion with no parabens.", "", 63.0, "BioCare", 58.0, 48.0, 53.0, "HerbalNature" },
                    { 99, "BC000000099", 1, "A revitalizing shampoo for daily use.", "", 52.0, "ShinyLocks", 47.0, 37.0, 42.0, "FreshSmooth" },
                    { 100, "BC000000100", 2, "A moisturizing body wash with essential oils.", "", 23.0, "AquaFresh", 18.0, 8.0, 13.0, "ZenWave" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyId",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
