using Beautique.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Beautique.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Company> Companies{ get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Shampoos & Conditioners", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Body Washes & Soaps", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Facial Care", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Body Care", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Deodorants & Antiperspirants", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Shaving Products", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Nail Care", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Perfumes & Fragrances", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Lip Care", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Hand Care", DisplayOrder = 10 },
                new Category { Id = 11, Name = "Hair Care", DisplayOrder = 11 },
                new Category { Id = 12, Name = "Eye & Eyelid Care", DisplayOrder = 12 },
                new Category { Id = 13, Name = "Cleansing & Makeup Removal", DisplayOrder = 13 },
                new Category { Id = 14, Name = "Organic & Bio Cosmetics", DisplayOrder = 14 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "ShineWave",
                    Maker = "SparkLife",
                    Description = "A premium shampoo that provides ultimate shine and smoothness.",
                    BarCode = "SW123456789",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 45,
                    Price100 = 40,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "PureGlow",
                    Maker = "CleanseCo",
                    Description = "A gentle body wash that leaves your skin refreshed and hydrated.",
                    BarCode = "PG987654321",
                    ListPrice = 40,
                    Price = 35,
                    Price50 = 30,
                    Price100 = 25,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "SoftTouch",
                    Maker = "VelvetSkin",
                    Description = "A soft and nourishing facial cream for smooth and glowing skin.",
                    BarCode = "ST111223344",
                    ListPrice = 65,
                    Price = 60,
                    Price50 = 55,
                    Price100 = 50,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "ClearSpark",
                    Maker = "LushCare",
                    Description = "A refreshing deodorant spray that keeps you fresh all day long.",
                    BarCode = "CS554433221",
                    ListPrice = 20,
                    Price = 18,
                    Price50 = 16,
                    Price100 = 14,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "FreshCut",
                    Maker = "SharpEdge",
                    Description = "A shaving gel that provides a smooth and irritation-free shave.",
                    BarCode = "FC998877665",
                    ListPrice = 35,
                    Price = 30,
                    Price50 = 28,
                    Price100 = 25,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "GlowNail",
                    Maker = "NailArt",
                    Description = "A long-lasting nail polish with vibrant colors and a glossy finish.",
                    BarCode = "GN332211445",
                    ListPrice = 15,
                    Price = 13,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 7,
                    Title = "EauVibe",
                    Maker = "ScentAura",
                    Description = "A fresh and uplifting fragrance that is perfect for daily wear.",
                    BarCode = "EV776655443",
                    ListPrice = 50,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 8,
                    Title = "SoftKiss",
                    Maker = "LipsCare",
                    Description = "A hydrating lip balm with a smooth texture and subtle scent.",
                    BarCode = "SK223344556",
                    ListPrice = 10,
                    Price = 9,
                    Price50 = 8,
                    Price100 = 7,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 9,
                    Title = "HandHeal",
                    Maker = "SkinGuard",
                    Description = "A nourishing hand cream that keeps your skin soft and hydrated.",
                    BarCode = "HH556677889",
                    ListPrice = 18,
                    Price = 16,
                    Price50 = 14,
                    Price100 = 12,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 10,
                    Title = "EyeLuxe",
                    Maker = "VisionGlow",
                    Description = "A rejuvenating eye cream that targets puffiness and dark circles.",
                    BarCode = "EL998877665",
                    ListPrice = 45,
                    Price = 40,
                    Price50 = 35,
                    Price100 = 30,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 11,
                    Title = "ShineElixir",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000011",
                    ListPrice = 33,
                    Price = 28,
                    Price50 = 23,
                    Price100 = 18,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 12,
                    Title = "CalmBright",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000012",
                    ListPrice = 58,
                    Price = 53,
                    Price50 = 48,
                    Price100 = 43,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 13,
                    Title = "MicellarWipe",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000013",
                    ListPrice = 50,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 14,
                    Title = "BioVital",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000014",
                    ListPrice = 45,
                    Price = 40,
                    Price50 = 35,
                    Price100 = 30,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 15,
                    Title = "HydraBounce",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000015",
                    ListPrice = 20,
                    Price = 15,
                    Price50 = 10,
                    Price100 = 5,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 16,
                    Title = "ZenAqua",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000016",
                    ListPrice = 36,
                    Price = 31,
                    Price50 = 26,
                    Price100 = 21,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 17,
                    Title = "ToneCare",
                    Maker = "DermaGlow",
                    Description = "A facial cream enriched with vitamins.",
                    BarCode = "BC000000017",
                    ListPrice = 23,
                    Price = 18,
                    Price50 = 13,
                    Price100 = 8,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 18,
                    Title = "SmoothHydra",
                    Maker = "SmoothCare",
                    Description = "A hydrating lotion for silky skin.",
                    BarCode = "BC000000018",
                    ListPrice = 41,
                    Price = 36,
                    Price50 = 31,
                    Price100 = 26,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 19,
                    Title = "BlockActive",
                    Maker = "FreshShield",
                    Description = "A long-lasting deodorant for active days.",
                    BarCode = "BC000000019",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 45,
                    Price100 = 40,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 20,
                    Title = "BladeSmooth",
                    Maker = "BladeGuard",
                    Description = "A rich shaving cream for sensitive skin.",
                    BarCode = "BC000000020",
                    ListPrice = 27,
                    Price = 22,
                    Price50 = 17,
                    Price100 = 12,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 21,
                    Title = "TintSparkle",
                    Maker = "ColorShine",
                    Description = "Bright nail polish with lasting power.",
                    BarCode = "BC000000021",
                    ListPrice = 60,
                    Price = 55,
                    Price50 = 50,
                    Price100 = 45,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 22,
                    Title = "AuraMist",
                    Maker = "EssenceMist",
                    Description = "A light perfume with floral notes.",
                    BarCode = "BC000000022",
                    ListPrice = 54,
                    Price = 49,
                    Price50 = 44,
                    Price100 = 39,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 23,
                    Title = "SilkSoft",
                    Maker = "LipSilk",
                    Description = "A soothing balm for chapped lips.",
                    BarCode = "BC000000023",
                    ListPrice = 58,
                    Price = 53,
                    Price50 = 48,
                    Price100 = 43,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 24,
                    Title = "HealCare",
                    Maker = "PalmSoft",
                    Description = "A cream to restore dry hands.",
                    BarCode = "BC000000024",
                    ListPrice = 47,
                    Price = 42,
                    Price50 = 37,
                    Price100 = 32,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 25,
                    Title = "NourishSilk",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000025",
                    ListPrice = 58,
                    Price = 53,
                    Price50 = 48,
                    Price100 = 43,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 26,
                    Title = "FreshEye",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000026",
                    ListPrice = 50,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 27,
                    Title = "WashMicellar",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000027",
                    ListPrice = 57,
                    Price = 52,
                    Price50 = 47,
                    Price100 = 42,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 28,
                    Title = "HerbalOrganic",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000028",
                    ListPrice = 53,
                    Price = 48,
                    Price50 = 43,
                    Price100 = 38,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 29,
                    Title = "SmoothGlow",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000029",
                    ListPrice = 61,
                    Price = 56,
                    Price50 = 51,
                    Price100 = 46,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 30,
                    Title = "PureCleanse",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000030",
                    ListPrice = 36,
                    Price = 31,
                    Price50 = 26,
                    Price100 = 21,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 31,
                    Title = "ToneBalance",
                    Maker = "DermaGlow",
                    Description = "A facial cream enriched with vitamins.",
                    BarCode = "BC000000031",
                    ListPrice = 25,
                    Price = 20,
                    Price50 = 15,
                    Price100 = 10,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 32,
                    Title = "HydraSilk",
                    Maker = "SmoothCare",
                    Description = "A hydrating lotion for silky skin.",
                    BarCode = "BC000000032",
                    ListPrice = 61,
                    Price = 56,
                    Price50 = 51,
                    Price100 = 46,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 33,
                    Title = "BlockPower",
                    Maker = "FreshShield",
                    Description = "A long-lasting deodorant for active days.",
                    BarCode = "BC000000033",
                    ListPrice = 43,
                    Price = 38,
                    Price50 = 33,
                    Price100 = 28,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 34,
                    Title = "FreshCalm",
                    Maker = "BladeGuard",
                    Description = "A rich shaving cream for sensitive skin.",
                    BarCode = "BC000000034",
                    ListPrice = 49,
                    Price = 44,
                    Price50 = 39,
                    Price100 = 34,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 35,
                    Title = "PopTint",
                    Maker = "ColorShine",
                    Description = "Bright nail polish with lasting power.",
                    BarCode = "BC000000035",
                    ListPrice = 23,
                    Price = 18,
                    Price50 = 13,
                    Price100 = 8,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 36,
                    Title = "MistDream",
                    Maker = "EssenceMist",
                    Description = "A light perfume with floral notes.",
                    BarCode = "BC000000036",
                    ListPrice = 31,
                    Price = 26,
                    Price50 = 21,
                    Price100 = 16,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 37,
                    Title = "SilkSmooth",
                    Maker = "LipSilk",
                    Description = "A soothing balm for chapped lips.",
                    BarCode = "BC000000037",
                    ListPrice = 42,
                    Price = 37,
                    Price50 = 32,
                    Price100 = 27,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 38,
                    Title = "CalmShield",
                    Maker = "PalmSoft",
                    Description = "A cream to restore dry hands.",
                    BarCode = "BC000000038",
                    ListPrice = 25,
                    Price = 20,
                    Price50 = 15,
                    Price100 = 10,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 39,
                    Title = "ShineCare",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000039",
                    ListPrice = 56,
                    Price = 51,
                    Price50 = 46,
                    Price100 = 41,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 40,
                    Title = "LuxeEye",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000040",
                    ListPrice = 54,
                    Price = 49,
                    Price50 = 44,
                    Price100 = 39,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 41,
                    Title = "FoamWash",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000041",
                    ListPrice = 53,
                    Price = 48,
                    Price50 = 43,
                    Price100 = 38,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 42,
                    Title = "BioOrganic",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000042",
                    ListPrice = 58,
                    Price = 53,
                    Price50 = 48,
                    Price100 = 43,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 43,
                    Title = "SilkBounce",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000043",
                    ListPrice = 60,
                    Price = 55,
                    Price50 = 50,
                    Price100 = 45,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 44,
                    Title = "PureBloom",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000044",
                    ListPrice = 51,
                    Price = 46,
                    Price50 = 41,
                    Price100 = 36,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 45,
                    Title = "FreshBalance",
                    Maker = "DermaGlow",
                    Description = "A facial cream enriched with vitamins.",
                    BarCode = "BC000000045",
                    ListPrice = 30,
                    Price = 25,
                    Price50 = 20,
                    Price100 = 15,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 46,
                    Title = "TouchSmooth",
                    Maker = "SmoothCare",
                    Description = "A hydrating lotion for silky skin.",
                    BarCode = "BC000000046",
                    ListPrice = 35,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 47,
                    Title = "GuardZone",
                    Maker = "FreshShield",
                    Description = "A long-lasting deodorant for active days.",
                    BarCode = "BC000000047",
                    ListPrice = 27,
                    Price = 22,
                    Price50 = 17,
                    Price100 = 12,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 48,
                    Title = "FoamSmooth",
                    Maker = "BladeGuard",
                    Description = "A rich shaving cream for sensitive skin.",
                    BarCode = "BC000000048",
                    ListPrice = 51,
                    Price = 46,
                    Price50 = 41,
                    Price100 = 36,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 49,
                    Title = "TintGlam",
                    Maker = "ColorShine",
                    Description = "Bright nail polish with lasting power.",
                    BarCode = "BC000000049",
                    ListPrice = 65,
                    Price = 60,
                    Price50 = 55,
                    Price100 = 50,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 50,
                    Title = "DreamBloom",
                    Maker = "EssenceMist",
                    Description = "A light perfume with floral notes.",
                    BarCode = "BC000000050",
                    ListPrice = 27,
                    Price = 22,
                    Price50 = 17,
                    Price100 = 12,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 51,
                    Title = "SoftSilk",
                    Maker = "LipSilk",
                    Description = "A soothing balm for chapped lips.",
                    BarCode = "BC000000051",
                    ListPrice = 51,
                    Price = 46,
                    Price50 = 41,
                    Price100 = 36,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 52,
                    Title = "RepairCalm",
                    Maker = "PalmSoft",
                    Description = "A cream to restore dry hands.",
                    BarCode = "BC000000052",
                    ListPrice = 54,
                    Price = 49,
                    Price50 = 44,
                    Price100 = 39,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 53,
                    Title = "OilCare",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000053",
                    ListPrice = 42,
                    Price = 37,
                    Price50 = 32,
                    Price100 = 27,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 54,
                    Title = "CalmLuxe",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000054",
                    ListPrice = 23,
                    Price = 18,
                    Price50 = 13,
                    Price100 = 8,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 55,
                    Title = "MicellarClean",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000055",
                    ListPrice = 54,
                    Price = 49,
                    Price50 = 44,
                    Price100 = 39,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 56,
                    Title = "NatureGreen",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000056",
                    ListPrice = 52,
                    Price = 47,
                    Price50 = 42,
                    Price100 = 37,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 57,
                    Title = "ShineSilk",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000057",
                    ListPrice = 62,
                    Price = 57,
                    Price50 = 52,
                    Price100 = 47,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 58,
                    Title = "BloomFoam",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000058",
                    ListPrice = 17,
                    Price = 12,
                    Price50 = 7,
                    Price100 = 2,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 59,
                    Title = "VelvetGlow",
                    Maker = "DermaGlow",
                    Description = "A facial cream enriched with vitamins.",
                    BarCode = "BC000000059",
                    ListPrice = 47,
                    Price = 42,
                    Price50 = 37,
                    Price100 = 32,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 60,
                    Title = "ButterSilk",
                    Maker = "SmoothCare",
                    Description = "A hydrating lotion for silky skin.",
                    BarCode = "BC000000060",
                    ListPrice = 53,
                    Price = 48,
                    Price50 = 43,
                    Price100 = 38,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 61,
                    Title = "FreshShield",
                    Maker = "FreshShield",
                    Description = "A long-lasting deodorant for active days.",
                    BarCode = "BC000000061",
                    ListPrice = 43,
                    Price = 38,
                    Price50 = 33,
                    Price100 = 28,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 62,
                    Title = "SmoothCalm",
                    Maker = "BladeGuard",
                    Description = "A rich shaving cream for sensitive skin.",
                    BarCode = "BC000000062",
                    ListPrice = 53,
                    Price = 48,
                    Price50 = 43,
                    Price100 = 38,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 63,
                    Title = "GlamTint",
                    Maker = "ColorShine",
                    Description = "Bright nail polish with lasting power.",
                    BarCode = "BC000000063",
                    ListPrice = 42,
                    Price = 37,
                    Price50 = 32,
                    Price100 = 27,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 64,
                    Title = "EssenceAura",
                    Maker = "EssenceMist",
                    Description = "A light perfume with floral notes.",
                    BarCode = "BC000000064",
                    ListPrice = 62,
                    Price = 57,
                    Price50 = 52,
                    Price100 = 47,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 65,
                    Title = "GlowSilk",
                    Maker = "LipSilk",
                    Description = "A soothing balm for chapped lips.",
                    BarCode = "BC000000065",
                    ListPrice = 30,
                    Price = 25,
                    Price50 = 20,
                    Price100 = 15,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 66,
                    Title = "CareGuard",
                    Maker = "PalmSoft",
                    Description = "A cream to restore dry hands.",
                    BarCode = "BC000000066",
                    ListPrice = 19,
                    Price = 14,
                    Price50 = 9,
                    Price100 = 4,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 67,
                    Title = "ElixirSilk",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000067",
                    ListPrice = 19,
                    Price = 14,
                    Price50 = 9,
                    Price100 = 4,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 68,
                    Title = "GlowBright",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000068",
                    ListPrice = 21,
                    Price = 16,
                    Price50 = 11,
                    Price100 = 6,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 69,
                    Title = "WashFoam",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000069",
                    ListPrice = 48,
                    Price = 43,
                    Price50 = 38,
                    Price100 = 33,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 70,
                    Title = "PureBio",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000070",
                    ListPrice = 23,
                    Price = 18,
                    Price50 = 13,
                    Price100 = 8,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 71,
                    Title = "LusterHydra",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000071",
                    ListPrice = 30,
                    Price = 25,
                    Price50 = 20,
                    Price100 = 15,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 72,
                    Title = "BloomWave",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000072",
                    ListPrice = 46,
                    Price = 41,
                    Price50 = 36,
                    Price100 = 31,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 73,
                    Title = "VelvetTone",
                    Maker = "DermaGlow",
                    Description = "A facial cream enriched with vitamins.",
                    BarCode = "BC000000073",
                    ListPrice = 35,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 74,
                    Title = "TouchSilk",
                    Maker = "SmoothCare",
                    Description = "A hydrating lotion for silky skin.",
                    BarCode = "BC000000074",
                    ListPrice = 25,
                    Price = 20,
                    Price50 = 15,
                    Price100 = 10,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 75,
                    Title = "GuardPower",
                    Maker = "FreshShield",
                    Description = "A long-lasting deodorant for active days.",
                    BarCode = "BC000000075",
                    ListPrice = 16,
                    Price = 11,
                    Price50 = 6,
                    Price100 = 1,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 76,
                    Title = "EdgeFoam",
                    Maker = "BladeGuard",
                    Description = "A rich shaving cream for sensitive skin.",
                    BarCode = "BC000000076",
                    ListPrice = 52,
                    Price = 47,
                    Price50 = 42,
                    Price100 = 37,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 77,
                    Title = "TintGloss",
                    Maker = "ColorShine",
                    Description = "Bright nail polish with lasting power.",
                    BarCode = "BC000000077",
                    ListPrice = 27,
                    Price = 22,
                    Price50 = 17,
                    Price100 = 12,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 78,
                    Title = "ScentBloom",
                    Maker = "EssenceMist",
                    Description = "A light perfume with floral notes.",
                    BarCode = "BC000000078",
                    ListPrice = 59,
                    Price = 54,
                    Price50 = 49,
                    Price100 = 44,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 79,
                    Title = "HydraGlow",
                    Maker = "LipSilk",
                    Description = "A soothing balm for chapped lips.",
                    BarCode = "BC000000079",
                    ListPrice = 22,
                    Price = 17,
                    Price50 = 12,
                    Price100 = 7,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 80,
                    Title = "VelvetSoft",
                    Maker = "PalmSoft",
                    Description = "A cream to restore dry hands.",
                    BarCode = "BC000000080",
                    ListPrice = 17,
                    Price = 12,
                    Price50 = 7,
                    Price100 = 2,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 81,
                    Title = "OilSilk",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000081",
                    ListPrice = 47,
                    Price = 42,
                    Price50 = 37,
                    Price100 = 32,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 82,
                    Title = "CalmLift",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000082",
                    ListPrice = 42,
                    Price = 37,
                    Price50 = 32,
                    Price100 = 27,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 83,
                    Title = "CleanMicellar",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000083",
                    ListPrice = 16,
                    Price = 11,
                    Price50 = 6,
                    Price100 = 1,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 84,
                    Title = "OrganicBio",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000084",
                    ListPrice = 49,
                    Price = 44,
                    Price50 = 39,
                    Price100 = 34,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 85,
                    Title = "FreshSilk",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000085",
                    ListPrice = 62,
                    Price = 57,
                    Price50 = 52,
                    Price100 = 47,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 86,
                    Title = "CleanseMist",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000086",
                    ListPrice = 49,
                    Price = 44,
                    Price50 = 39,
                    Price100 = 34,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 87,
                    Title = "FreshSoft",
                    Maker = "DermaGlow",
                    Description = "A facial cream enriched with vitamins.",
                    BarCode = "BC000000087",
                    ListPrice = 37,
                    Price = 32,
                    Price50 = 27,
                    Price100 = 22,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 88,
                    Title = "EssenceHydra",
                    Maker = "SmoothCare",
                    Description = "A hydrating lotion for silky skin.",
                    BarCode = "BC000000088",
                    ListPrice = 19,
                    Price = 14,
                    Price50 = 9,
                    Price100 = 4,
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 89,
                    Title = "ZonePower",
                    Maker = "FreshShield",
                    Description = "A long-lasting deodorant for active days.",
                    BarCode = "BC000000089",
                    ListPrice = 37,
                    Price = 32,
                    Price50 = 27,
                    Price100 = 22,
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 90,
                    Title = "BladeEdge",
                    Maker = "BladeGuard",
                    Description = "A rich shaving cream for sensitive skin.",
                    BarCode = "BC000000090",
                    ListPrice = 50,
                    Price = 45,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 91,
                    Title = "PopColor",
                    Maker = "ColorShine",
                    Description = "Bright nail polish with lasting power.",
                    BarCode = "BC000000091",
                    ListPrice = 36,
                    Price = 31,
                    Price50 = 26,
                    Price100 = 21,
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 92,
                    Title = "BloomAura",
                    Maker = "EssenceMist",
                    Description = "A light perfume with floral notes.",
                    BarCode = "BC000000092",
                    ListPrice = 60,
                    Price = 55,
                    Price50 = 50,
                    Price100 = 45,
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 93,
                    Title = "BalmCare",
                    Maker = "LipSilk",
                    Description = "A soothing balm for chapped lips.",
                    BarCode = "BC000000093",
                    ListPrice = 30,
                    Price = 25,
                    Price50 = 20,
                    Price100 = 15,
                    CategoryId = 9,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 94,
                    Title = "CareHeal",
                    Maker = "PalmSoft",
                    Description = "A cream to restore dry hands.",
                    BarCode = "BC000000094",
                    ListPrice = 58,
                    Price = 53,
                    Price50 = 48,
                    Price100 = 43,
                    CategoryId = 10,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 95,
                    Title = "DropNourish",
                    Maker = "GlowHair",
                    Description = "A nourishing oil for damaged hair.",
                    BarCode = "BC000000095",
                    ListPrice = 16,
                    Price = 11,
                    Price50 = 6,
                    Price100 = 1,
                    CategoryId = 11,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 96,
                    Title = "LiftSoft",
                    Maker = "BrightEyes",
                    Description = "Targets dark circles and fine lines.",
                    BarCode = "BC000000096",
                    ListPrice = 27,
                    Price = 22,
                    Price50 = 17,
                    Price100 = 12,
                    CategoryId = 12,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 97,
                    Title = "CleanWash",
                    Maker = "CleanSwipe",
                    Description = "A gentle remover for all makeup types.",
                    BarCode = "BC000000097",
                    ListPrice = 53,
                    Price = 48,
                    Price50 = 43,
                    Price100 = 38,
                    CategoryId = 13,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 98,
                    Title = "HerbalNature",
                    Maker = "BioCare",
                    Description = "An organic skin lotion with no parabens.",
                    BarCode = "BC000000098",
                    ListPrice = 63,
                    Price = 58,
                    Price50 = 53,
                    Price100 = 48,
                    CategoryId = 14,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 99,
                    Title = "FreshSmooth",
                    Maker = "ShinyLocks",
                    Description = "A revitalizing shampoo for daily use.",
                    BarCode = "BC000000099",
                    ListPrice = 52,
                    Price = 47,
                    Price50 = 42,
                    Price100 = 37,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 100,
                    Title = "ZenWave",
                    Maker = "AquaFresh",
                    Description = "A moisturizing body wash with essential oils.",
                    BarCode = "BC000000100",
                    ListPrice = 23,
                    Price = 18,
                    Price50 = 13,
                    Price100 = 8,
                    CategoryId = 2,
                    ImageUrl = ""
                }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Glow & Care",
                    StreetAddress = "123 Beauty Ave",
                    City = "SkinCare City",
                    PostalCode = "54321",
                    State = "CA",
                    PhoneNumber = "5557778888"
                },
                new Company
                {
                    Id = 2,
                    Name = "Nature's Touch",
                    StreetAddress = "456 Herbal Rd",
                    City = "GreenVille",
                    PostalCode = "67890",
                    State = "OR",
                    PhoneNumber = "4446669999"
                },
                new Company
                {
                    Id = 3,
                    Name = "Silky Locks",
                    StreetAddress = "789 Hair Blvd",
                    City = "Shampoo Town",
                    PostalCode = "11223",
                    State = "TX",
                    PhoneNumber = "3335557777"
                }
            );

        }
    }
}
