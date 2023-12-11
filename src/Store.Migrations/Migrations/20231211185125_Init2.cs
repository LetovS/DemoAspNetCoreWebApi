using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "ProviderName" },
                values: new object[,]
                {
                    { new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2"), "Provider name 2" },
                    { new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56"), "Provider name 9" },
                    { new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c"), "Provider name 10" },
                    { new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e"), "Provider name 7" },
                    { new Guid("a4c3112d-38b9-490c-8759-420a24352125"), "Provider name 6" },
                    { new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3"), "Provider name 8" },
                    { new Guid("b25bcd85-0d3f-493b-949b-381d7f4e3aa2"), "Provider name 1" },
                    { new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1"), "Provider name 4" },
                    { new Guid("eac41c07-cecf-4298-adb6-879caff5e60f"), "Provider name 3" },
                    { new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49"), "Provider name 5" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "ProviderId" },
                values: new object[,]
                {
                    { new Guid("01526436-ef97-49fb-a116-79ea2f3bd998"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7717), "Order number 59", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("04bf5f18-89a5-4514-a894-91ef8fc8da8d"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7732), "Order number 68", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7586), "Order number 3", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("084931b4-a40a-4138-ba24-76cdf9211a7f"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7724), "Order number 63", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("090153e9-e8c7-4a5e-a5c3-2fa167c428cd"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7808), "Order number 97", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("0b465603-7552-4166-9bb7-45f0eb417942"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7804), "Order number 94", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("0c1a3180-bea8-47a7-9ac9-be086b2c5827"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7793), "Order number 88", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("0d72980c-51d6-42fd-ad27-d17d3643fc17"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7739), "Order number 72", new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3") },
                    { new Guid("10719052-86d2-4211-9a9d-56253f755e2f"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7668), "Order number 33", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("11d09bd2-1668-4e35-925f-c53b64a72183"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7805), "Order number 95", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("1262a8ad-7bc8-489a-a7ad-ab5ea39c2cad"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7672), "Order number 35", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("12803dd8-5796-4a50-9728-fc28923f5c3f"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7680), "Order number 40", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("145ec164-05ca-40bd-baed-65609836a604"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7666), "Order number 32", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("160099d9-a007-4483-b2e3-e62804f45764"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7700), "Order number 50", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("1838b2a4-5cff-496d-bac6-c57af3f77e45"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7568), "Order number 1", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("19572e85-a7da-4e36-81fb-829598fe5e1c"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7812), "Order number 99", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7596), "Order number 8", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("1a6b264b-8ad3-41ab-a41f-678eda249305"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7621), "Order number 22", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("1bb6129a-bac2-4cc0-958e-633b55e0fbdb"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7691), "Order number 45", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("1e1330d7-a965-44bd-9547-0822e5ea7b85"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7719), "Order number 60", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("272db8a6-f1ac-40f2-b953-616c64e35e36"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7789), "Order number 86", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("2a4b0e0d-af54-49c0-87fe-de44fbc2f0d0"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7802), "Order number 93", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("2cd61684-e451-4000-a710-89e34f1e6570"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7786), "Order number 84", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("2fd775e2-18f1-4b4d-810f-b0fe37364a5c"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7605), "Order number 12", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("3ba8f6b5-f798-4222-8671-8f4ca198785a"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7707), "Order number 54", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("3bb4e587-2af3-413a-aa80-22fcb8c467cb"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7754), "Order number 81", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7598), "Order number 9", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("3f1ab819-5eb6-4148-8dd7-6361a82a6e6e"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7709), "Order number 55", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("46617cb6-7616-4d03-bb54-2506a58cd806"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7623), "Order number 23", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("4b05c169-11a7-4961-acc7-2dd219e38dc9"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7712), "Order number 57", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("4b60d0e2-c619-45e4-8551-6b0903ac4f63"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7736), "Order number 70", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("4bfc294a-f523-4c65-9a20-a98dcb111bca"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7811), "Order number 98", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7589), "Order number 4", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("4cdae84a-81c2-4970-8020-068df69e59bf"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7801), "Order number 92", new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3") },
                    { new Guid("52d02f35-2684-45f0-9cb3-3ac27164908c"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7695), "Order number 48", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("5385b7cf-d465-433f-8f44-af9be6d701e0"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7685), "Order number 42", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("57dfb404-75de-4511-9c2e-c5b56ed50d60"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7611), "Order number 16", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("595a083d-f3d3-45b8-b61c-278639cebdc4"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7756), "Order number 82", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("597e5628-6694-48ce-bac6-29845d4b336b"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7751), "Order number 79", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("59d779df-d7fe-41b6-ab0e-6c6aeb167575"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7752), "Order number 80", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("5ad0e195-ddc9-4a82-bcdd-3d29c56623c0"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7655), "Order number 26", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("5b2ba735-71f0-4f75-8a03-9a10b5e37d64"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7692), "Order number 46", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "ProviderId" },
                values: new object[,]
                {
                    { new Guid("6493bb8a-6c60-4606-871f-cf24588d140f"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7705), "Order number 53", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("64f69b25-90f8-44fb-bfae-989315b7e1a5"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7722), "Order number 62", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("6561f98a-6215-4f2e-a046-540efb80a9dd"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7725), "Order number 64", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("68bc16d1-a4f2-4242-81e7-4ea75f210924"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7711), "Order number 56", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("68cbf284-e3a0-42a7-9cb5-7145bf3d8050"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7610), "Order number 15", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("6ed839fe-65f5-420e-9a9f-33cec41e200e"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7734), "Order number 69", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("74e6aa6f-01c6-4125-a8f0-31244ab09b86"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7743), "Order number 74", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("7654dc0b-184c-4cb4-978c-088576a561f5"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7676), "Order number 37", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("784ff4fa-5323-494a-882e-66247bdb05b9"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7737), "Order number 71", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("7a985332-b894-4a3f-86a5-6d1fada79be2"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7740), "Order number 73", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("7b338430-7f6e-4c73-a08b-f5660dffce91"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7677), "Order number 38", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("7b8b3bff-ef52-45fd-afd3-a1317c49ec42"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7745), "Order number 75", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("7d2271c0-dcea-4815-8bad-4ed558a5f515"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7617), "Order number 19", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7594), "Order number 7", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("8266f08d-5a7c-48b1-ac90-d399ec096a02"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7715), "Order number 58", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("82d7d2b0-5123-4fa2-8d4d-82dc94904801"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7731), "Order number 67", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("8300a4fe-0b4e-4494-9294-c4421207c32b"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7729), "Order number 66", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("83a62f53-8afc-490b-8c17-208a08182865"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7746), "Order number 76", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("86cf6bdc-26b6-477c-befe-a7138456c191"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7671), "Order number 34", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("8de743b4-55ca-47f6-9f96-95b3da4734d4"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7758), "Order number 83", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("93895494-a7b9-413c-a5cf-72875d731d12"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7661), "Order number 29", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("93d1b04d-52c7-4b96-9bce-d5dca899c6ec"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7620), "Order number 21", new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3") },
                    { new Guid("962396dc-815b-4e11-8ebc-b11b918f93c9"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7720), "Order number 61", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("987ad455-25de-45f3-b5c0-ea0c483b176d"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7797), "Order number 90", new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3") },
                    { new Guid("9b31f26c-c4fa-4440-87d1-b83ae27774f9"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7618), "Order number 20", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("9c55efaf-841c-4983-b9c9-5f3269af1462"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7748), "Order number 77", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("9d86c5d4-b981-433b-89de-b27910f40459"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7659), "Order number 28", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("a069f4bf-9872-41cf-a9a5-74859b5043c3"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7664), "Order number 31", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("a4923ad7-01d2-4dad-9437-6af33551b66a"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7814), "Order number 100", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("a6203626-9654-4f13-a2a0-9062f639a934"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7682), "Order number 41", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("ab8df664-2d2a-4d4e-95d4-cdbbdd7c9df6"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7749), "Order number 78", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("ac4cd0e2-22ad-442b-924f-d9b4bd1a1ebe"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7615), "Order number 18", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7583), "Order number 2", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7593), "Order number 6", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("b514bea5-743e-4eb1-bb2b-b0b8af4fa852"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7697), "Order number 49", new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49") },
                    { new Guid("b59c5966-75b8-4941-90a4-7a7171926864"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7687), "Order number 43", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("b61aa13e-ebe9-4ca8-94dd-2bfff574ff41"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7679), "Order number 39", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("be1c761a-b85f-4766-b9f6-876b137f35fd"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7791), "Order number 87", new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3") },
                    { new Guid("c1c732db-f42a-4b10-aa52-5e2e26cd6b16"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7612), "Order number 17", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("c2a4d653-2702-4c1d-adf0-05d0529afc0c"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7663), "Order number 30", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("ce6341d3-a77f-4a3e-bdc7-396e0d1ad83f"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7794), "Order number 89", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("d393093c-63f7-4fe7-8c61-2cd5427cb240"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7652), "Order number 25", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "ProviderId" },
                values: new object[,]
                {
                    { new Guid("d4aa2494-1833-4c5a-af24-1ce3fbca45a3"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7603), "Order number 11", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("d5da9966-419f-414e-ab40-854bf5289321"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7606), "Order number 13", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("d8699396-f62a-41ad-a43a-deb410155039"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7694), "Order number 47", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7591), "Order number 5", new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56") },
                    { new Guid("e12c0168-11d8-4ec0-bd3e-3d09b9ed80e6"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7674), "Order number 36", new Guid("eac41c07-cecf-4298-adb6-879caff5e60f") },
                    { new Guid("e98e0ee3-a240-47da-bd32-c91836f28499"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7649), "Order number 24", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("eac29e7d-3190-4b9f-8641-0d66e82189f5"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7787), "Order number 85", new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2") },
                    { new Guid("ed179fc1-63ba-4d8d-9f2e-a139a1d60bb2"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7704), "Order number 52", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("f03e13e5-a1f6-44be-973e-7608cb4f6c34"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7608), "Order number 14", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7601), "Order number 10", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("f19c473a-5027-4d87-9240-ca414d15d070"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7727), "Order number 65", new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c") },
                    { new Guid("f2c1bdfc-e74e-4a76-8465-e805916fbb20"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7657), "Order number 27", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("f83e6284-5958-4602-8632-0c193868430e"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7799), "Order number 91", new Guid("a4c3112d-38b9-490c-8759-420a24352125") },
                    { new Guid("f938b536-0ab5-4fff-9a3d-bde888e29966"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7689), "Order number 44", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") },
                    { new Guid("fe3b902c-6e65-491a-9faa-bacbcc0e9f63"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7702), "Order number 51", new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1") },
                    { new Guid("fff0888a-9780-42de-8541-aee3bbe01f4b"), new DateTime(2023, 12, 11, 21, 51, 22, 963, DateTimeKind.Local).AddTicks(7807), "Order number 96", new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e") }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("001a2108-8ca3-4b92-8a86-c77f5fee1f1c"), "Order name 1474", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 233.753312151171m, "усл. ед" },
                    { new Guid("001dc2f3-107b-4a46-92ef-f57f3f3689b9"), "Order name 63", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 328.670422416823m, "усл. ед" },
                    { new Guid("00291f5d-fa17-4b3d-aeb7-d39b53a4ee12"), "Order name 1905", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 471.80330383083m, "усл. ед" },
                    { new Guid("002fe6e0-63ad-432f-9561-38770abba875"), "Order name 1613", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 243.009596906909m, "усл. ед" },
                    { new Guid("003acff3-78bd-417a-ba76-548d5fb0356c"), "Order name 907", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 149.429375923413m, "усл. ед" },
                    { new Guid("007765f0-2a07-4447-887d-40dd30a04245"), "Order name 2483", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 151.1059733512m, "усл. ед" },
                    { new Guid("007a4898-017b-4b24-808e-c79692b4877a"), "Order name 434", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 172.62598908742m, "усл. ед" },
                    { new Guid("007a96b6-2607-4220-83ad-912ee1009fc3"), "Order name 1658", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 584.381425646504m, "усл. ед" },
                    { new Guid("00d31a14-4475-443e-87af-45307543a4e6"), "Order name 850", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 161.207090173597m, "усл. ед" },
                    { new Guid("01799c79-df7e-4dc3-b880-9336d2831e64"), "Order name 2287", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 107.14629085924m, "усл. ед" },
                    { new Guid("018ab7aa-c904-4f9d-918c-817869c42dce"), "Order name 1350", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 119.389992910013m, "усл. ед" },
                    { new Guid("019b1a2c-aa41-4cff-9a62-7d40a8ef9c9b"), "Order name 773", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 313.790922088549m, "усл. ед" },
                    { new Guid("01bd4069-21f9-4254-a248-04b92e560abb"), "Order name 1157", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 30.0176703330527m, "усл. ед" },
                    { new Guid("01c8c4b4-a105-4b73-9b8d-625628c717d5"), "Order name 2456", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 326.918248267626m, "усл. ед" },
                    { new Guid("01f00d18-740a-4293-8135-e51c10e76935"), "Order name 1974", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 87.5703353298989m, "усл. ед" },
                    { new Guid("020a6e09-db53-4d86-8b3e-dcbf59ee52a4"), "Order name 556", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 22.3205334574847m, "усл. ед" },
                    { new Guid("020f6443-9431-4799-b5b6-2bbb641f2815"), "Order name 2343", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 592.527644577199m, "усл. ед" },
                    { new Guid("024dc8f8-87b0-4085-9f27-747523fb4bca"), "Order name 2481", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 157.137344099588m, "усл. ед" },
                    { new Guid("0253303f-1d6c-4c3c-88ea-11e23aa16c1b"), "Order name 650", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 661.397967732427m, "усл. ед" },
                    { new Guid("026ea321-f2a5-412d-aaa0-ac73a28d2867"), "Order name 2232", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 296.484336725793m, "усл. ед" },
                    { new Guid("027cb3b1-b4aa-460d-ae71-6f22b84b8cdb"), "Order name 400", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 340.298561216183m, "усл. ед" },
                    { new Guid("02826810-8136-4f4c-9338-ce9205c4aa67"), "Order name 91", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 152.03998752149m, "усл. ед" },
                    { new Guid("02bb59a9-b9a0-4983-b4ce-4626902adf20"), "Order name 657", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 147.565259003692m, "усл. ед" },
                    { new Guid("02d8520e-ab0d-414c-b906-d75ec689c598"), "Order name 164", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 135.609701108862m, "усл. ед" },
                    { new Guid("030dc9f5-440d-42de-b7a8-b90c03f4f984"), "Order name 1428", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 598.56900529584m, "усл. ед" },
                    { new Guid("03214401-5337-449f-95de-a107489283d9"), "Order name 2049", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 103.601111676524m, "усл. ед" },
                    { new Guid("0345adfd-4d90-4d9d-b8a0-b3048e7480d3"), "Order name 1150", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 25.0278476321288m, "усл. ед" },
                    { new Guid("034efe5d-ea68-4632-a67a-b5cd887b9c32"), "Order name 902", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 340.279148963121m, "усл. ед" },
                    { new Guid("035ab447-abd7-489c-a3db-1fefe48e0faf"), "Order name 1741", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 80.9266679377346m, "усл. ед" },
                    { new Guid("0381b2b0-5681-4a5e-8437-ed0215a05ff7"), "Order name 997", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 386.957436674153m, "усл. ед" },
                    { new Guid("03a3ddff-de65-4eda-b92e-2ab45cf44e69"), "Order name 2347", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 623.025325949922m, "усл. ед" },
                    { new Guid("03d55b5f-964f-45c5-a0c5-a25945c03c3e"), "Order name 927", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 33.9197156674684m, "усл. ед" },
                    { new Guid("03d7cb86-5384-4ddc-89fa-e178301e510f"), "Order name 681", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 983.632972847236m, "усл. ед" },
                    { new Guid("03f05adb-e824-4507-823c-a5d0bdcc87f6"), "Order name 1512", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 128.52097971949m, "усл. ед" },
                    { new Guid("040199cc-97dd-465c-a6ed-b0136d89f363"), "Order name 2372", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 851.478197507732m, "усл. ед" },
                    { new Guid("044f204c-fe8c-467c-90ff-585c6fb416ea"), "Order name 1064", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 420.80716138115m, "усл. ед" },
                    { new Guid("0459b543-85e9-44f0-af33-d9498e5770d5"), "Order name 2156", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 88.9838193387455m, "усл. ед" },
                    { new Guid("04a30e9e-4c1d-4cc3-a085-d817ae2d026f"), "Order name 483", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 32.789306135504m, "усл. ед" },
                    { new Guid("04b2b899-34a7-4a91-89d5-1c9faf9b5594"), "Order name 1462", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 116.8648141715m, "усл. ед" },
                    { new Guid("052b03ba-7b3a-4745-a73d-d3ffa1f7ad23"), "Order name 1190", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 631.926006287766m, "усл. ед" },
                    { new Guid("0548e6ed-1740-419f-982f-a5fc6b9c6afe"), "Order name 29", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 80.1432438844682m, "усл. ед" },
                    { new Guid("054a5100-0c81-4c23-b6eb-7b783bd993e2"), "Order name 1502", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 298.325682458832m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("05a38850-b7bb-462c-860e-8b18d0491d24"), "Order name 1485", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 94.6583954968316m, "усл. ед" },
                    { new Guid("05a9d378-c9b9-4dad-960f-c8d709f1c06f"), "Order name 163", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 56.2413544056781m, "усл. ед" },
                    { new Guid("05c280fa-e64f-417a-8674-34d9efdd057a"), "Order name 722", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 287.78420835203m, "усл. ед" },
                    { new Guid("05c4119a-b972-4435-8606-08c11c9be0f4"), "Order name 643", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 202.637700754458m, "усл. ед" },
                    { new Guid("05c9694b-0bda-4aea-92e1-8511018c0790"), "Order name 2100", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 637.618665180997m, "усл. ед" },
                    { new Guid("0619d5ee-fba6-4acd-85a2-10105322bb1b"), "Order name 1240", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 55.9184204857829m, "усл. ед" },
                    { new Guid("062c31ca-d2c2-409b-b38f-f7a80c81994d"), "Order name 119", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 42.2950915835462m, "усл. ед" },
                    { new Guid("062d4d90-ecc8-401f-9923-cccca8b7c2a1"), "Order name 1491", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 89.378995233611m, "усл. ед" },
                    { new Guid("0653cbaa-89bd-47f7-8cea-8b8c659533b7"), "Order name 1295", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 464.942529999002m, "усл. ед" },
                    { new Guid("067a7510-d8ca-4957-94f7-104a65343dd8"), "Order name 45", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 556.730798860286m, "усл. ед" },
                    { new Guid("068883f5-aaa6-48c6-8b5c-fe64cdbbebe1"), "Order name 1341", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 102.977616244425m, "усл. ед" },
                    { new Guid("068accf0-901f-4bcd-9143-09e452b5e6ac"), "Order name 1219", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 283.422243580919m, "усл. ед" },
                    { new Guid("068d402c-5136-451e-9531-81a32ff13a2b"), "Order name 1070", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 252.566466543541m, "усл. ед" },
                    { new Guid("06991f0e-d160-442b-bfd6-db4e85f0afe9"), "Order name 1320", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 207.631463794706m, "усл. ед" },
                    { new Guid("06c4320e-8564-4bf2-86d4-a4151274ab9c"), "Order name 759", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 53.1883510133081m, "усл. ед" },
                    { new Guid("06fb58b1-0fa6-4fc2-8974-f219a2993450"), "Order name 1590", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 669.905610925028m, "усл. ед" },
                    { new Guid("076c68d2-7182-4e1f-90d1-4eb83b73d7d3"), "Order name 2238", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 32.6861989148238m, "усл. ед" },
                    { new Guid("0775b64f-8535-4e22-8a7c-c919e12ffd16"), "Order name 2171", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 57.8163791935903m, "усл. ед" },
                    { new Guid("0780eedb-b3bb-406d-bf1c-593c0783cc94"), "Order name 1058", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 106.016214884519m, "усл. ед" },
                    { new Guid("078af6fa-7469-4d07-9ae9-740f9591ec53"), "Order name 247", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 477.113219150549m, "усл. ед" },
                    { new Guid("07d453d6-f00d-417e-b0c9-df25dbf16c1a"), "Order name 357", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 599.944261861556m, "усл. ед" },
                    { new Guid("07e6b139-cd73-4e92-99f9-55fbf3255cbc"), "Order name 2004", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 363.195696913286m, "усл. ед" },
                    { new Guid("07f939ea-7f2b-4113-b265-c0d95466c7aa"), "Order name 1587", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 18.0267072369239m, "усл. ед" },
                    { new Guid("07fd449e-0e1e-4393-982c-2b5fe1c69664"), "Order name 663", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 26.2997367500896m, "усл. ед" },
                    { new Guid("07fe6eaf-07eb-4fe6-9bd6-56f0d1978003"), "Order name 558", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 106.313374671439m, "усл. ед" },
                    { new Guid("080abe67-77ba-4a95-a0f9-d15b547c3634"), "Order name 207", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 366.157608636886m, "усл. ед" },
                    { new Guid("0811fa0f-3f8c-42b0-b420-a145bea01fc7"), "Order name 662", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 269.55667355465m, "усл. ед" },
                    { new Guid("0819c5fb-38ee-4d6e-bbe8-14252230568e"), "Order name 2461", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 386.093925313272m, "усл. ед" },
                    { new Guid("08334c9a-742e-4773-8d11-eabd36ecc610"), "Order name 565", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 102.074896551949m, "усл. ед" },
                    { new Guid("0836375c-e069-4fe4-9f4c-8836200c9349"), "Order name 1077", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 813.485659396837m, "усл. ед" },
                    { new Guid("0838c9c3-38cd-4310-9f2d-4a24603129a6"), "Order name 914", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 179.167768375906m, "усл. ед" },
                    { new Guid("084283f5-30df-4ee0-a491-939184f951ad"), "Order name 77", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 109.999389050841m, "усл. ед" },
                    { new Guid("0860ac36-db12-4967-9e3b-0111d1f8711d"), "Order name 646", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 113.038086536427m, "усл. ед" },
                    { new Guid("087345b7-959e-4047-846a-c53c2f078de6"), "Order name 757", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 1.74486558884971m, "усл. ед" },
                    { new Guid("0883e527-9bfe-40c0-a459-f833c90fa396"), "Order name 576", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 380.615149995513m, "усл. ед" },
                    { new Guid("08d02302-3a89-4902-9b2a-6a54afe98882"), "Order name 102", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 154.450459745637m, "усл. ед" },
                    { new Guid("08d06c7f-0819-4e72-a5b8-384e52513283"), "Order name 2431", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 536.203620585866m, "усл. ед" },
                    { new Guid("08db1b8d-6d1a-4a1e-961e-1bd5a5ab5be9"), "Order name 1543", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 369.654744217772m, "усл. ед" },
                    { new Guid("08f45c84-b4ed-4c18-81f2-ce53184ad620"), "Order name 1060", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 63.1746162153954m, "усл. ед" },
                    { new Guid("090cd5c1-5445-4acd-ae53-b1880cfddf7d"), "Order name 1396", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 103.759896988789m, "усл. ед" },
                    { new Guid("0912fe2c-40a1-4277-aab4-48fb55b065ba"), "Order name 1161", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 265.211078860187m, "усл. ед" },
                    { new Guid("0933706f-9eb9-4771-afc5-4f5728939ef6"), "Order name 836", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 295.320573542805m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("0947d409-a573-4214-8486-32ad43568f0d"), "Order name 1820", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 402.964958363746m, "усл. ед" },
                    { new Guid("094c70e2-7a17-4cba-a536-0fdc23ae7b6b"), "Order name 1966", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 146.462880559179m, "усл. ед" },
                    { new Guid("0956ff99-8d96-4762-a05f-62f2a906586e"), "Order name 365", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 284.14826278936m, "усл. ед" },
                    { new Guid("0968a6e6-5809-4bfe-a19e-c6f9f7d6f88b"), "Order name 1", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 404.107343427132m, "усл. ед" },
                    { new Guid("099c5a75-32ef-4a9f-8745-7f7e9b340a98"), "Order name 395", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 217.649081239658m, "усл. ед" },
                    { new Guid("099c6277-1ada-4682-b1b9-c50bd8af944d"), "Order name 673", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 190.345839599183m, "усл. ед" },
                    { new Guid("09ba6ea7-85e3-4a76-a5ec-24c8ab657e33"), "Order name 242", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 522.624629248714m, "усл. ед" },
                    { new Guid("09c3277f-1159-4b46-8252-af0b18538b58"), "Order name 328", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 427.202410087786m, "усл. ед" },
                    { new Guid("09c935d5-a82e-4c71-8ca6-fd16fb0a674f"), "Order name 1197", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 204.813405928131m, "усл. ед" },
                    { new Guid("09d73000-11d7-491e-bc53-75ed4fcdc7a9"), "Order name 1988", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 221.300458791119m, "усл. ед" },
                    { new Guid("09da24c5-f071-4481-9b8a-8c3d353aa7e8"), "Order name 1777", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 547.16415089324m, "усл. ед" },
                    { new Guid("09e330c6-9682-47a9-8d4d-414092c6ffa2"), "Order name 97", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 355.280166248034m, "усл. ед" },
                    { new Guid("09ea2050-c710-4fbf-89d7-cbb2e631d05d"), "Order name 462", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 366.373166188878m, "усл. ед" },
                    { new Guid("0a01af49-404f-4278-876c-0394f5cbe384"), "Order name 855", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 109.760460665276m, "усл. ед" },
                    { new Guid("0a38aa33-0836-45ab-b7c4-45494f34fc60"), "Order name 1467", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 99.4205020290732m, "усл. ед" },
                    { new Guid("0a6ddc8d-e2dc-4ccb-87c5-db4615ee9653"), "Order name 1206", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 191.747041150258m, "усл. ед" },
                    { new Guid("0a81e32a-0799-4313-a9f5-ab63124883cf"), "Order name 1705", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 120.852080542325m, "усл. ед" },
                    { new Guid("0aa3db71-492e-4684-9b4d-e20be1ccecb1"), "Order name 1034", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 700.755405280476m, "усл. ед" },
                    { new Guid("0ac69804-5586-41c6-b183-5f4c4cd31360"), "Order name 1793", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 65.7182579028328m, "усл. ед" },
                    { new Guid("0add9829-1d1f-48eb-8ebf-34d538dbb49f"), "Order name 93", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 573.486824896344m, "усл. ед" },
                    { new Guid("0ae096ff-470a-42c8-baec-7e287c7adf74"), "Order name 1515", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 316.947636768967m, "усл. ед" },
                    { new Guid("0aedb046-6b3f-466c-915c-4414e176d2b1"), "Order name 852", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 803.208496158628m, "усл. ед" },
                    { new Guid("0b12ed7e-ccd6-4230-8050-5362ff496f4c"), "Order name 908", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 53.6717096793358m, "усл. ед" },
                    { new Guid("0b2acfb9-861e-4d79-9e27-1e941d74df61"), "Order name 20", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 108.988363248992m, "усл. ед" },
                    { new Guid("0b405fb4-b85c-441a-8aa4-d3e15d331763"), "Order name 491", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 627.680936072177m, "усл. ед" },
                    { new Guid("0b5a6d3b-a13f-4ca8-b1d4-433391539f34"), "Order name 2271", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 636.994577215559m, "усл. ед" },
                    { new Guid("0b931010-6d55-493b-a499-da9ba12eb508"), "Order name 2297", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 119.299805604777m, "усл. ед" },
                    { new Guid("0b98e2ed-1bfe-4233-a52c-7451808d8991"), "Order name 170", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 122.964955044235m, "усл. ед" },
                    { new Guid("0bbcb5b3-1f98-45b5-a348-bb41fd6da180"), "Order name 963", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 165.292711177772m, "усл. ед" },
                    { new Guid("0bcb3134-f15e-459c-a3d1-9ef7db1ef8fb"), "Order name 2253", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 287.964745573901m, "усл. ед" },
                    { new Guid("0bd199a6-60ac-4278-ab50-cfdd3d2e8fc0"), "Order name 1036", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 14.0065183651634m, "усл. ед" },
                    { new Guid("0c0b3c31-b29e-44c5-af28-0a65a576cf6a"), "Order name 1890", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 438.933802576782m, "усл. ед" },
                    { new Guid("0c7bb548-3a29-4abf-94c7-0ead86ca13d4"), "Order name 669", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 563.02914628131m, "усл. ед" },
                    { new Guid("0c8e3910-ad56-4783-acb3-670236f32680"), "Order name 153", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 157.667555455663m, "усл. ед" },
                    { new Guid("0ca8746e-a1d4-4898-b155-c5517bb5d212"), "Order name 1243", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 109.614735364312m, "усл. ед" },
                    { new Guid("0cba4068-a8e5-45b0-8883-1e7b78895080"), "Order name 672", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 596.433298300266m, "усл. ед" },
                    { new Guid("0ce64f7c-d980-481f-84a3-aaac24cb614d"), "Order name 867", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 154.297448851338m, "усл. ед" },
                    { new Guid("0cea65c1-6597-4547-a0e5-37b38618f4a0"), "Order name 1291", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 539.24806954121m, "усл. ед" },
                    { new Guid("0cf1e676-3797-46db-95a8-bbec3b404115"), "Order name 1167", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 45.6027169223461m, "усл. ед" },
                    { new Guid("0d004afb-412e-4dca-821e-025156b79f59"), "Order name 2465", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 107.322194122773m, "усл. ед" },
                    { new Guid("0d08a697-4815-42de-a3ac-f78167849d50"), "Order name 2069", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 376.240497905616m, "усл. ед" },
                    { new Guid("0d4987be-0e30-4923-b302-188261768153"), "Order name 2198", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 190.792378286089m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("0d62a51b-1bfe-48c9-8c3b-c92d0bee820f"), "Order name 1371", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 30.5688923780174m, "усл. ед" },
                    { new Guid("0d7b1bc2-f55d-4afa-8ba5-3858a3be93fa"), "Order name 1431", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 444.171796256667m, "усл. ед" },
                    { new Guid("0d7c2f99-09be-4115-bb36-a6cc1e036747"), "Order name 2057", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 18.451010405186m, "усл. ед" },
                    { new Guid("0d930677-f3cf-4a35-b088-fa8e4fec5bbe"), "Order name 881", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 77.9914008421971m, "усл. ед" },
                    { new Guid("0d9bad56-ce35-4573-9c34-adaab83c624c"), "Order name 352", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 878.334106812017m, "усл. ед" },
                    { new Guid("0dc3ab65-4f9d-4ed1-af5e-e598e0e4cff9"), "Order name 37", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 300.457846475628m, "усл. ед" },
                    { new Guid("0dc40599-54ce-4ecb-aa0b-cd3300cc88d5"), "Order name 1765", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 329.705642677676m, "усл. ед" },
                    { new Guid("0dd3e57f-0a8f-49ce-82de-fa26987deae8"), "Order name 1109", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 87.7054234783286m, "усл. ед" },
                    { new Guid("0ddd5e50-10e5-4665-b9fd-cf8927123c51"), "Order name 2237", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 121.814009021061m, "усл. ед" },
                    { new Guid("0df08ffb-5c88-470e-958b-c19012113e8a"), "Order name 2337", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 221.449312102722m, "усл. ед" },
                    { new Guid("0e1f7c32-cc1b-4027-9006-85b5c936eb90"), "Order name 939", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 265.252542676843m, "усл. ед" },
                    { new Guid("0e36f6d8-4801-43b0-803c-7884457cd3ad"), "Order name 1174", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 313.590514949468m, "усл. ед" },
                    { new Guid("0e4117bb-24e8-431b-92ab-9905cbc18971"), "Order name 2117", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 245.592654522838m, "усл. ед" },
                    { new Guid("0e565715-1c4b-48be-a3f3-a916f8403247"), "Order name 1991", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 16.3802298707489m, "усл. ед" },
                    { new Guid("0e649abb-1a77-4670-b302-0640a2e00fa6"), "Order name 200", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 87.743631768687m, "усл. ед" },
                    { new Guid("0e86dcfd-2336-4cad-8e8c-65bd24b33d8e"), "Order name 688", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 413.793445244127m, "усл. ед" },
                    { new Guid("0ea45977-06ff-4337-a16b-f91e725d5328"), "Order name 372", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 37.9389706110406m, "усл. ед" },
                    { new Guid("0ece095f-2161-4aef-a0c7-7f02f96b990a"), "Order name 2418", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 1.13588672384532m, "усл. ед" },
                    { new Guid("0ecf16ae-a0e5-484b-861e-57e19451e9f8"), "Order name 2113", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 501.889312034679m, "усл. ед" },
                    { new Guid("0ee5850e-8a40-4a19-be51-8e38391091be"), "Order name 1196", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 149.948292794534m, "усл. ед" },
                    { new Guid("0eed1a5a-caea-42ee-a834-1b6e62d32116"), "Order name 2317", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 70.897985424015m, "усл. ед" },
                    { new Guid("0ef5155e-2c10-4216-9169-409545babf25"), "Order name 1753", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 380.495504285549m, "усл. ед" },
                    { new Guid("0f30a008-4404-4f7e-a68e-33bce744384e"), "Order name 2059", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 343.858957554034m, "усл. ед" },
                    { new Guid("0f4183c5-8918-47b1-9d79-094ad7545385"), "Order name 1227", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 61.8453019371819m, "усл. ед" },
                    { new Guid("0f4979f6-2f40-47cf-9090-fe1476b9869a"), "Order name 1940", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 239.10271508413m, "усл. ед" },
                    { new Guid("0f5b0735-b09c-486d-b796-d661152fdf5f"), "Order name 1321", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 6.65955981718382m, "усл. ед" },
                    { new Guid("0fa5d9a0-bac1-4c62-8ab1-cf9ad70bddc8"), "Order name 198", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 42.6371203603871m, "усл. ед" },
                    { new Guid("0fc0b1e7-6b40-4d21-84d8-95b24850a8be"), "Order name 325", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 220.396207794057m, "усл. ед" },
                    { new Guid("0fe157ab-ef1e-4876-8849-2e19efca6011"), "Order name 2072", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 52.2989160507016m, "усл. ед" },
                    { new Guid("0fedf0d1-f4c2-4a40-95fd-885ca036ccd5"), "Order name 1750", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 111.711106503817m, "усл. ед" },
                    { new Guid("0ffd71e0-8ca9-4629-b524-9aebe71b0799"), "Order name 219", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 70.5252114129503m, "усл. ед" },
                    { new Guid("10266060-7a18-40c4-9e5e-e937b4a237ba"), "Order name 901", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 23.7081594266204m, "усл. ед" },
                    { new Guid("102ade4a-0a0b-45a6-9c41-0582ef4b9e13"), "Order name 551", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 591.848424965845m, "усл. ед" },
                    { new Guid("10662180-6b7b-4c2c-9369-e1a22ed22573"), "Order name 183", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 174.628737646065m, "усл. ед" },
                    { new Guid("10b187fa-2d72-4dfe-9263-b45afecff182"), "Order name 581", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 175.071394132347m, "усл. ед" },
                    { new Guid("10b634aa-d539-4565-a6a6-d2a9566d57c9"), "Order name 1164", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 220.262689733836m, "усл. ед" },
                    { new Guid("10cd66d1-da6e-47c1-96b6-0d849b2af4c6"), "Order name 1008", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 146.094729469188m, "усл. ед" },
                    { new Guid("10d9ce50-6e06-4274-b437-3fd1b5b39eb1"), "Order name 511", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 39.4326683017126m, "усл. ед" },
                    { new Guid("10dcf379-603c-4400-9696-effb4f3809c0"), "Order name 769", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 87.1106820038914m, "усл. ед" },
                    { new Guid("110c2321-19fb-499a-9248-00a3980f0fc6"), "Order name 1186", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 175.905175472615m, "усл. ед" },
                    { new Guid("11231a20-1b68-48a5-84cb-a6ef920d84a5"), "Order name 2346", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 155.959243543418m, "усл. ед" },
                    { new Guid("11313b33-c12a-46ff-950b-ab72d29fcdd9"), "Order name 616", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 80.3011531884234m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("114567a1-5880-499e-a2f6-036104117888"), "Order name 1480", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 371.765415380613m, "усл. ед" },
                    { new Guid("11500121-c574-4764-802d-941c99c107b8"), "Order name 2077", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 154.785266641748m, "усл. ед" },
                    { new Guid("1163fdfe-3800-4aa6-84d5-475fff7f0003"), "Order name 742", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 403.449283758168m, "усл. ед" },
                    { new Guid("11bf60f0-948c-4da2-9c5c-db673787cee5"), "Order name 719", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 112.291253412548m, "усл. ед" },
                    { new Guid("11c48230-cb80-4e48-b721-44b496f77f87"), "Order name 1524", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 8.6971953037834m, "усл. ед" },
                    { new Guid("11c536ec-2076-4e8e-9ce7-dcb9afbe11b3"), "Order name 1285", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 658.47015285188m, "усл. ед" },
                    { new Guid("11d1dfd5-5b5a-4a53-9be5-b4e5ee31d6c4"), "Order name 1920", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 116.97018808749m, "усл. ед" },
                    { new Guid("11dbb989-662f-4534-82a7-310d28e4943b"), "Order name 1536", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 16.6651782631443m, "усл. ед" },
                    { new Guid("11e3a1b8-7c1f-43b1-a54c-a510673b7486"), "Order name 604", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 19.1427924987289m, "усл. ед" },
                    { new Guid("1202dfde-74d6-4b36-86f7-b007dc9f3089"), "Order name 1596", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 12.9871465300995m, "усл. ед" },
                    { new Guid("120ce2c1-e145-49af-a3c9-e62ac85afb0e"), "Order name 1984", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 48.7693052596968m, "усл. ед" },
                    { new Guid("12238a2f-ee98-49cd-943e-01f6421e6ee6"), "Order name 904", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 309.908469117549m, "усл. ед" },
                    { new Guid("122d7a13-0133-47ab-896e-e6c9e6a3eb05"), "Order name 1482", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 28.2540814891082m, "усл. ед" },
                    { new Guid("122eeab0-35a9-45dc-8b78-f3f4843a9526"), "Order name 307", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 488.130087390071m, "усл. ед" },
                    { new Guid("125d6b76-ecff-4dfa-8e83-7a472c6c85a9"), "Order name 2419", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 273.896524800409m, "усл. ед" },
                    { new Guid("126c4ea3-ccba-4ceb-b5b6-a3c2f1077d75"), "Order name 781", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 272.697042003759m, "усл. ед" },
                    { new Guid("12a4d1bf-9ef0-435e-8c15-1b5235064432"), "Order name 2318", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 177.944700084818m, "усл. ед" },
                    { new Guid("12aa9ad6-8619-427f-a1e4-50a2359bf62e"), "Order name 984", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 134.956396158595m, "усл. ед" },
                    { new Guid("12e721f6-9918-4fb5-a627-370d5f0dbfb7"), "Order name 16", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 215.236751857095m, "усл. ед" },
                    { new Guid("12e8fdb6-3aef-4fc8-be73-2ffeb8ecf873"), "Order name 1214", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 130.649674775491m, "усл. ед" },
                    { new Guid("12f62493-3f1c-4a1d-89ae-2c0a52f10b58"), "Order name 255", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 32.251002971763m, "усл. ед" },
                    { new Guid("1300d0a6-c5bd-4595-87ce-049c292147c4"), "Order name 2022", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 423.916410254136m, "усл. ед" },
                    { new Guid("1314df3b-a18d-4d79-a7aa-da3b4de42ab4"), "Order name 213", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 150.714375969849m, "усл. ед" },
                    { new Guid("135f7e53-796e-425a-94cf-a2697d40f6b4"), "Order name 2038", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 4.24699425223941m, "усл. ед" },
                    { new Guid("1391745b-abff-445a-bec1-de70fa5bd72b"), "Order name 404", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 427.396804280911m, "усл. ед" },
                    { new Guid("139d1919-a604-424c-b9ba-5b16eeea55a7"), "Order name 1566", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 494.393546090163m, "усл. ед" },
                    { new Guid("13b3c5f0-ddd2-438c-8187-b212df656da1"), "Order name 2490", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 644.641201211293m, "усл. ед" },
                    { new Guid("13d4673a-0572-4695-940d-60da051b615b"), "Order name 627", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 81.0467712065236m, "усл. ед" },
                    { new Guid("13d75ebd-3b7f-4882-ba6f-75fb245aabea"), "Order name 1175", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 86.7806313425243m, "усл. ед" },
                    { new Guid("13f9cc2b-27d3-402e-8621-45a8c4167167"), "Order name 253", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 595.492374465764m, "усл. ед" },
                    { new Guid("142daea7-19b2-48f5-a298-122aa04cbf58"), "Order name 2316", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 191.708956444837m, "усл. ед" },
                    { new Guid("14418a1a-3b74-4046-bbe2-2c1adb337fe3"), "Order name 1698", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 106.565493389955m, "усл. ед" },
                    { new Guid("144369be-ce6b-496a-9175-ee2f3cf3e91b"), "Order name 57", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 120.05506949707m, "усл. ед" },
                    { new Guid("144bbbcb-8e1f-405b-91fc-16d1f8fe05b7"), "Order name 218", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 413.033379242497m, "усл. ед" },
                    { new Guid("1450768d-8df6-4284-b80a-0256c1c2180d"), "Order name 2486", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 99.8094050676015m, "усл. ед" },
                    { new Guid("145e4575-3f00-406c-bba8-02bf4cb291b6"), "Order name 1531", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 13.5815837355468m, "усл. ед" },
                    { new Guid("146b4078-38d7-4f1c-81e2-f462434aba75"), "Order name 2006", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 102.278127402838m, "усл. ед" },
                    { new Guid("14c97146-b3b1-458f-8b6b-46430ddd7790"), "Order name 1500", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 43.567588347652m, "усл. ед" },
                    { new Guid("14cc381b-4c36-4a63-8098-ea075ba40bab"), "Order name 1930", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 189.416254383056m, "усл. ед" },
                    { new Guid("14d0247a-5939-4380-9f0d-57fcfcd08101"), "Order name 839", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 88.5768404463269m, "усл. ед" },
                    { new Guid("14efd7ed-bf44-4f60-aaa6-4052eabe047b"), "Order name 573", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 678.972425416231m, "усл. ед" },
                    { new Guid("14f89b0c-caaf-4364-8796-a719df2a08c0"), "Order name 132", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 514.42122428879m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("15112501-5f23-43a4-b116-75831680a7df"), "Order name 1084", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 484.664719179546m, "усл. ед" },
                    { new Guid("151c299a-53b7-460a-a8c9-4178f82792a2"), "Order name 169", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 296.081713689229m, "усл. ед" },
                    { new Guid("1560289b-869a-4702-9e34-73b91690c174"), "Order name 966", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 181.823954386351m, "усл. ед" },
                    { new Guid("1575734e-000a-4897-b3d5-47b8ecb46172"), "Order name 498", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 86.4936984638742m, "усл. ед" },
                    { new Guid("15adb229-e9e9-47b9-98ba-cf559730a76e"), "Order name 2386", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 182.046396813594m, "усл. ед" },
                    { new Guid("1604d424-c94f-4499-9222-a23675b034d8"), "Order name 2128", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 283.948364064579m, "усл. ед" },
                    { new Guid("16064017-392b-4729-8f62-bcb5ecef3251"), "Order name 1745", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 171.778909901578m, "усл. ед" },
                    { new Guid("163b7212-38f6-4000-8900-1d18ad705ddb"), "Order name 990", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 305.703294164501m, "усл. ед" },
                    { new Guid("1668a9b7-36aa-4d3e-9db0-38818188c421"), "Order name 1210", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 442.22641100241m, "усл. ед" },
                    { new Guid("169fa834-c0a9-4986-a830-97ebaa39f0ba"), "Order name 2345", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 97.1860936517993m, "усл. ед" },
                    { new Guid("16b5fae3-e34d-48c0-bced-d8bda4175667"), "Order name 1306", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 433.142689302833m, "усл. ед" },
                    { new Guid("16e5cc0d-16b4-4bc7-929e-10a18e611a86"), "Order name 2360", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 249.1077791117m, "усл. ед" },
                    { new Guid("1702c952-d63c-4603-af8e-679ede5f0391"), "Order name 1185", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 240.668179644088m, "усл. ед" },
                    { new Guid("1703603f-65e6-439e-a796-211b6dff35f3"), "Order name 115", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 285.978062185253m, "усл. ед" },
                    { new Guid("17073229-2fd1-4763-a8a9-333cce382a33"), "Order name 233", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 545.571139577844m, "усл. ед" },
                    { new Guid("172b2816-4c4f-42ba-8346-a21fad73465b"), "Order name 1945", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 230.217126957747m, "усл. ед" },
                    { new Guid("1737633f-6a86-4030-8246-9b52fe4df563"), "Order name 1916", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 200.872251591516m, "усл. ед" },
                    { new Guid("1748e162-be24-470a-98fa-226215176d81"), "Order name 1558", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 653.521691860635m, "усл. ед" },
                    { new Guid("174909af-dbaa-44c8-9802-2bde2259ede3"), "Order name 401", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 154.964743158231m, "усл. ед" },
                    { new Guid("175ab321-a685-4b3b-a33a-60af446bd9b9"), "Order name 282", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 52.3137604089073m, "усл. ед" },
                    { new Guid("17636fff-4289-4fe2-95c0-edc26f83261e"), "Order name 661", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 125.016888486259m, "усл. ед" },
                    { new Guid("17785a9b-6347-4d54-9732-f8331eb26806"), "Order name 2186", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 204.521496267726m, "усл. ед" },
                    { new Guid("17c05ea9-7819-4dbb-b4aa-7e6f14b30596"), "Order name 1179", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 117.005906193144m, "усл. ед" },
                    { new Guid("17c8f198-c85d-4ff0-8a86-6cb9fb59fce9"), "Order name 1648", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 378.743321126264m, "усл. ед" },
                    { new Guid("17d2f9cc-d65e-402d-bb4c-6f436064205d"), "Order name 2063", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 44.328993121337m, "усл. ед" },
                    { new Guid("180a4518-03b0-4c19-9fdb-6d5954bcf5ab"), "Order name 758", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 46.1193843238769m, "усл. ед" },
                    { new Guid("183d334f-537e-4d6d-a9b6-2f27c9932e92"), "Order name 311", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 563.079709657335m, "усл. ед" },
                    { new Guid("1846ba64-a71b-4024-bc16-f7cba0e90e46"), "Order name 592", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 364.72701678185m, "усл. ед" },
                    { new Guid("186214b7-b4db-44d8-bce8-878fd1b239b5"), "Order name 2247", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 162.77627066216m, "усл. ед" },
                    { new Guid("186f2f64-2505-4da6-9029-bc10e1cf22fc"), "Order name 666", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 214.991583627265m, "усл. ед" },
                    { new Guid("18708277-ebd7-4e9c-a03f-5f47a5ba264a"), "Order name 441", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 163.51713425373m, "усл. ед" },
                    { new Guid("189911ef-57cb-4fd6-8a6a-f7b96fafa0aa"), "Order name 1332", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 330.68856331322m, "усл. ед" },
                    { new Guid("18a270cd-27cd-428a-8597-f0e83ae55435"), "Order name 1805", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 135.678696259097m, "усл. ед" },
                    { new Guid("18acfbbb-a384-4a88-9088-e8757c84b0df"), "Order name 1712", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 331.101852636892m, "усл. ед" },
                    { new Guid("18d0fbf7-f2cf-498e-86dd-ac5e370cf443"), "Order name 2420", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 422.555606767627m, "усл. ед" },
                    { new Guid("18d5b65e-46e3-4748-a79b-d934f35da86f"), "Order name 424", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 437.546115936782m, "усл. ед" },
                    { new Guid("18d61502-5d11-45a2-826e-238558baad91"), "Order name 1496", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 631.869996172345m, "усл. ед" },
                    { new Guid("18d62501-5e74-4462-acf1-a250fca564e0"), "Order name 794", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 51.8194437373057m, "усл. ед" },
                    { new Guid("18f104f9-0019-4648-ae12-ac2881023b1c"), "Order name 1790", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 98.1367376887724m, "усл. ед" },
                    { new Guid("18f9768d-5734-445a-a6f6-5cb4b7f9526e"), "Order name 680", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 267.663220469801m, "усл. ед" },
                    { new Guid("18fdeb7a-2b5c-40fe-bec4-8b0cf7f488a2"), "Order name 1315", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 371.36773189107m, "усл. ед" },
                    { new Guid("1921b60c-90cb-4e5d-8f2c-ecd873af8290"), "Order name 1978", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 520.22860674828m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("192b7252-8159-4f31-9069-5b93268478a8"), "Order name 2467", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 154.983335755901m, "усл. ед" },
                    { new Guid("193f017c-3c6b-4aaa-8ede-0060fc519b59"), "Order name 519", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 240.116037778041m, "усл. ед" },
                    { new Guid("194d958e-d119-4110-bfd9-97586ba51884"), "Order name 1679", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 120.067015076337m, "усл. ед" },
                    { new Guid("196845b8-f72d-4de8-aef7-44af0b886bc3"), "Order name 1523", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 901.775916110897m, "усл. ед" },
                    { new Guid("196b9143-d025-4ae7-b51d-e435033a2c2c"), "Order name 398", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 392.876361210092m, "усл. ед" },
                    { new Guid("197d7446-36bb-459d-9a1a-fd804167ccbe"), "Order name 2048", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 259.890585342847m, "усл. ед" },
                    { new Guid("19862f77-6709-4cc0-aef6-f58e940936c3"), "Order name 1042", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 591.823497857327m, "усл. ед" },
                    { new Guid("198d7173-5696-4bff-a3f5-ac933a28b452"), "Order name 585", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 42.2961629756271m, "усл. ед" },
                    { new Guid("198e6abf-247a-42a5-abee-3865445565e9"), "Order name 415", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 288.78195939712m, "усл. ед" },
                    { new Guid("19990c3e-74ef-42e8-a2d5-f8670304c95a"), "Order name 1795", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 475.416767354092m, "усл. ед" },
                    { new Guid("19ad521b-1d44-417d-8bf8-0fd38e1ef661"), "Order name 440", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 303.330059950994m, "усл. ед" },
                    { new Guid("19c249bc-ae0c-4268-a8d8-aac6fe0f3a2a"), "Order name 319", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 122.315214385536m, "усл. ед" },
                    { new Guid("19db33bd-b967-42bc-90ae-1d47377de7fa"), "Order name 707", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 33.753964008712m, "усл. ед" },
                    { new Guid("19ddc90d-6563-4f8e-ad83-de349834295f"), "Order name 848", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 465.278082091436m, "усл. ед" },
                    { new Guid("19f13593-94dc-45e1-ac42-e045e314c6bf"), "Order name 2039", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 76.0944336228482m, "усл. ед" },
                    { new Guid("19f57228-5e0d-456a-a52e-e52b37ea1a23"), "Order name 1499", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 86.3511671527915m, "усл. ед" },
                    { new Guid("1a35f355-12d9-41ea-8f7f-a18d2118c90c"), "Order name 1387", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 107.32908832503m, "усл. ед" },
                    { new Guid("1a456bec-53c0-44e9-880a-53e770bd8c2f"), "Order name 318", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 272.213450280098m, "усл. ед" },
                    { new Guid("1a765bba-74c2-46da-b576-a705ab65ffcf"), "Order name 2319", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 784.289852254022m, "усл. ед" },
                    { new Guid("1a7f4989-8180-4709-bd03-23b9f7015bbf"), "Order name 1022", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 156.432859097353m, "усл. ед" },
                    { new Guid("1abe1748-9ad5-420a-85a0-cff8f44a9517"), "Order name 1184", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 226.639052722219m, "усл. ед" },
                    { new Guid("1b396783-90e1-4504-9e2c-be9231309bf3"), "Order name 2322", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 155.998236021784m, "усл. ед" },
                    { new Guid("1b4ff530-c46d-41e6-8e81-bf46d5222668"), "Order name 658", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 277.522553287124m, "усл. ед" },
                    { new Guid("1b6e6ab6-0902-416f-bd23-35bdf0eb8334"), "Order name 74", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 696.611856002438m, "усл. ед" },
                    { new Guid("1bae668c-33b6-4fc1-88ac-d7f2aeb77640"), "Order name 568", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 508.497108934558m, "усл. ед" },
                    { new Guid("1bb16770-5502-498e-bc26-102170bae759"), "Order name 853", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 201.60625311755m, "усл. ед" },
                    { new Guid("1bb8820c-6a65-4737-a7a2-7e6a5697b3c5"), "Order name 600", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 336.187927780749m, "усл. ед" },
                    { new Guid("1be3fa74-1834-45aa-9f89-12adbe937d70"), "Order name 267", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 103.234079077052m, "усл. ед" },
                    { new Guid("1bf61ae3-2ed4-4efc-a713-56c771ea989e"), "Order name 2254", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 403.624679496336m, "усл. ед" },
                    { new Guid("1c2e6271-a1ec-466f-b70b-bf4a49a2f3d7"), "Order name 1610", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 178.327716952335m, "усл. ед" },
                    { new Guid("1cce263e-a7be-43d1-b51f-5ce6a3d3379a"), "Order name 2012", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 189.476020671474m, "усл. ед" },
                    { new Guid("1ce9ca4b-eb87-41b1-a6b6-9b42f49dab10"), "Order name 1532", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 216.554736117702m, "усл. ед" },
                    { new Guid("1cec41c6-44d1-4df3-b70e-697698783969"), "Order name 1193", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 376.16612255457m, "усл. ед" },
                    { new Guid("1cf14ac1-92f4-44fa-8316-700d3297b5fb"), "Order name 1933", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 53.2204787557371m, "усл. ед" },
                    { new Guid("1d66f3b3-cf59-440c-91dd-8d46155ee3dc"), "Order name 2071", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 416.837136788403m, "усл. ед" },
                    { new Guid("1d98e58f-f273-4675-8435-087444874035"), "Order name 1459", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 2.0563935104383m, "усл. ед" },
                    { new Guid("1dae81ad-ddda-45c9-8d5a-fddaed8f3153"), "Order name 2256", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 631.127874674502m, "усл. ед" },
                    { new Guid("1db5f9ad-17bf-4a58-992b-1c4a511ee604"), "Order name 1141", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 345.635637650041m, "усл. ед" },
                    { new Guid("1dbe896c-2025-4fbe-97fd-6efa7dfe7dfe"), "Order name 484", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 311.106355261383m, "усл. ед" },
                    { new Guid("1ddda406-6ee6-4b34-b3a4-495dc2cb5bd9"), "Order name 1445", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 174.746692332522m, "усл. ед" },
                    { new Guid("1e062d39-e5c3-4632-90b3-561f2e495c5a"), "Order name 129", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 275.832800306947m, "усл. ед" },
                    { new Guid("1e13d7e3-8a22-4a70-a0d6-d05fd2de83fa"), "Order name 1327", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 745.764798966239m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("1e28ea08-035b-439f-b168-9ada092eb920"), "Order name 1828", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 506.607974340416m, "усл. ед" },
                    { new Guid("1e321f9a-1bbd-4bd6-8b28-b21252372fda"), "Order name 101", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 173.502063634069m, "усл. ед" },
                    { new Guid("1e69dcdb-a2ec-42d4-885c-b7267238942e"), "Order name 1744", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 505.591799506926m, "усл. ед" },
                    { new Guid("1e8273b0-55ee-4856-8ff9-6451ac557c99"), "Order name 1079", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 69.0652858006691m, "усл. ед" },
                    { new Guid("1e924c92-0855-4c0f-b92b-76c33e9788d4"), "Order name 1420", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 149.966594555893m, "усл. ед" },
                    { new Guid("1e93fda4-3e15-45ac-baa4-e1d95748ce7f"), "Order name 336", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 111.417054900149m, "усл. ед" },
                    { new Guid("1ebce3c5-bf70-4fc5-b94e-6d76a46f3846"), "Order name 705", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 86.7500090294725m, "усл. ед" },
                    { new Guid("1ef8abbc-ce19-4159-99b3-995691f5bc9c"), "Order name 2087", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 12.9035468988703m, "усл. ед" },
                    { new Guid("1efcc774-3346-4b4e-a2a8-ef8882837b80"), "Order name 2470", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 400.171940128155m, "усл. ед" },
                    { new Guid("1f09bc22-ad17-4ee9-b6b9-e703557e131e"), "Order name 1273", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 6.0183415166237m, "усл. ед" },
                    { new Guid("1f30247b-8660-4142-a9de-508923523020"), "Order name 489", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 48.8014298686084m, "усл. ед" },
                    { new Guid("1f54dc6c-d578-4989-a6fc-82058c9f548b"), "Order name 1181", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 326.713678786654m, "усл. ед" },
                    { new Guid("1f5fc438-64a4-4b63-9721-6f2710cec3d4"), "Order name 168", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 81.1033667708197m, "усл. ед" },
                    { new Guid("1f72901c-b772-455f-94f8-851d58996d96"), "Order name 1623", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 85.5785564064924m, "усл. ед" },
                    { new Guid("1f8d1aa7-df7a-4648-83b5-51c8b1970606"), "Order name 1160", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 256.991337346284m, "усл. ед" },
                    { new Guid("1f8f659b-2589-4c7d-9be3-bc9cebb8261c"), "Order name 1302", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 93.3812275367856m, "усл. ед" },
                    { new Guid("1faa73fd-d969-4827-8756-15d8de165224"), "Order name 878", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 19.3504680450915m, "усл. ед" },
                    { new Guid("1fde05d6-b8c6-4838-98a0-47c86c4fbcf3"), "Order name 715", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 261.439897835444m, "усл. ед" },
                    { new Guid("1fe70050-9067-4a3a-b82a-7520e04afa8b"), "Order name 1099", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 792.13862188298m, "усл. ед" },
                    { new Guid("20567d15-8dc7-4712-b799-8456992868ed"), "Order name 895", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 37.7853027851829m, "усл. ед" },
                    { new Guid("2065f983-78cb-4f4e-a79c-0a9ec1eedbd8"), "Order name 2385", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 383.623096102584m, "усл. ед" },
                    { new Guid("206a7a2e-3c9a-46e4-ad2d-54e0a994a4d7"), "Order name 2381", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 124.223294153365m, "усл. ед" },
                    { new Guid("206dbc0f-c0cf-4e27-8d17-0b4149a665b5"), "Order name 2110", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 12.3637634386182m, "усл. ед" },
                    { new Guid("206dd2dd-5d93-44e5-9649-24e161940f8d"), "Order name 1646", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 206.539470001437m, "усл. ед" },
                    { new Guid("207766b5-20dd-49cf-a2c3-b8a2d1f97c3f"), "Order name 125", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 241.78526739601m, "усл. ед" },
                    { new Guid("207b963d-9f48-4638-8d65-9ccc0e91e6b8"), "Order name 2307", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 115.175292240433m, "усл. ед" },
                    { new Guid("20821be8-a33d-495f-ab90-669e68df87f3"), "Order name 1694", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 307.663956347755m, "усл. ед" },
                    { new Guid("208dd436-fb55-45e4-af63-a37a469f35c3"), "Order name 468", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 271.436031383095m, "усл. ед" },
                    { new Guid("2097f0b4-bc55-4e75-9f15-6e4dfd1b3551"), "Order name 760", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 632.415761385903m, "усл. ед" },
                    { new Guid("20e53c33-2047-4f64-a4d7-ed260bece7f5"), "Order name 289", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 563.566168142818m, "усл. ед" },
                    { new Guid("21026fb7-352e-4900-b145-8100f46b0429"), "Order name 825", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 100.231735175686m, "усл. ед" },
                    { new Guid("21134a21-13f6-484a-b598-a3b09f2673f4"), "Order name 1236", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 4.12856635467918m, "усл. ед" },
                    { new Guid("2167608b-f7d0-447b-8839-3adbf2099570"), "Order name 1282", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 138.586206122257m, "усл. ед" },
                    { new Guid("217d45a1-a68e-4509-9f00-f66517db6d28"), "Order name 580", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 677.05662737816m, "усл. ед" },
                    { new Guid("218f9e9e-d98a-4bc7-9b84-a79a4614752a"), "Order name 1834", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 292.557038665551m, "усл. ед" },
                    { new Guid("21c8fd14-b87b-4c40-afe6-3f853672c620"), "Order name 2390", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 77.5372218289489m, "усл. ед" },
                    { new Guid("221d717c-8fe2-4361-8ac0-c938866662bd"), "Order name 935", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 316.597451276308m, "усл. ед" },
                    { new Guid("22321b41-24e1-4297-b0da-8d54e213cedf"), "Order name 2446", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 485.45939384262m, "усл. ед" },
                    { new Guid("2252b75a-053d-4c4c-a14f-edc29270738a"), "Order name 2094", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 111.852092229888m, "усл. ед" },
                    { new Guid("226a95cb-4e43-480c-8598-104112f92663"), "Order name 2289", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 39.9555308625177m, "усл. ед" },
                    { new Guid("228d8017-a930-4061-9663-db802523c4a9"), "Order name 232", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 99.6116711237789m, "усл. ед" },
                    { new Guid("22b8d321-6b2d-4b94-b4c5-c0443d1d388e"), "Order name 526", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 304.546772212974m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("22c159ca-f8d0-4879-b1ae-9bccfed4b140"), "Order name 1095", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 263.52397928539m, "усл. ед" },
                    { new Guid("22f5a087-a96a-4cae-9f77-4b9fa0a460e3"), "Order name 837", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 99.0527736461411m, "усл. ед" },
                    { new Guid("2314d820-e03f-44f6-8d07-ac99ef6ca502"), "Order name 1632", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 619.653978503367m, "усл. ед" },
                    { new Guid("2355c00a-c5f1-4bf7-a5e0-6576e179abb6"), "Order name 222", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 611.039802083406m, "усл. ед" },
                    { new Guid("23593f95-8d45-40dd-8035-8b1fcd521954"), "Order name 137", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 395.666209419512m, "усл. ед" },
                    { new Guid("23bcaf3d-56c8-4dc7-9909-365f868dbd40"), "Order name 1634", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 580.796527211031m, "усл. ед" },
                    { new Guid("2405487a-b972-44e1-9261-ed92d04a8c7d"), "Order name 1547", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 660.599826639877m, "усл. ед" },
                    { new Guid("2408d1fc-d4ea-4b65-82e4-0d7dfcf13d84"), "Order name 1477", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 254.187168044791m, "усл. ед" },
                    { new Guid("24113990-6687-4ea2-843c-849b1d419efa"), "Order name 1061", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 760.345688460257m, "усл. ед" },
                    { new Guid("2430b65a-728d-4f41-9c40-e6e1b53ebccc"), "Order name 428", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 230.86249842435m, "усл. ед" },
                    { new Guid("246a4b17-e75a-4560-a2ae-8483736d4284"), "Order name 175", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 8.64188294339343m, "усл. ед" },
                    { new Guid("248a0956-8fcb-4f05-a42c-dd31ab029989"), "Order name 1699", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 154.71395436296m, "усл. ед" },
                    { new Guid("24d6590f-ad64-4c5b-914b-afb13b4f3e1e"), "Order name 1349", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 253.791244532954m, "усл. ед" },
                    { new Guid("24f23c5d-86b5-4453-b70a-65d369e9be4c"), "Order name 2379", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 179.430582510985m, "усл. ед" },
                    { new Guid("25079c3b-e715-47d9-a96d-a5e7d9dd995c"), "Order name 60", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 84.8038397566264m, "усл. ед" },
                    { new Guid("25151089-f308-4ec1-a9b0-41aa5cfd196d"), "Order name 1815", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 270.452022610102m, "усл. ед" },
                    { new Guid("2515306a-9878-4623-b33b-4b38c5ebdc27"), "Order name 1382", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 268.641666036753m, "усл. ед" },
                    { new Guid("2561af09-0346-4b87-ab91-63f6777eb58e"), "Order name 1339", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 408.948950176204m, "усл. ед" },
                    { new Guid("25629676-5c7d-4754-99d1-482ab5d40ce0"), "Order name 1304", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 437.946168126212m, "усл. ед" },
                    { new Guid("256f0ba7-9069-42f0-ad3c-f1cbd07224a9"), "Order name 2210", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 682.066622956167m, "усл. ед" },
                    { new Guid("258ec2d9-fc09-4f4c-9423-5be9e16dee8b"), "Order name 522", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 279.382008219653m, "усл. ед" },
                    { new Guid("259ebb59-203d-4a9c-9591-758bec3e101c"), "Order name 1139", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 78.2566977190892m, "усл. ед" },
                    { new Guid("25d17e78-b2f1-4e48-a171-d4f1b5f28ae7"), "Order name 187", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 206.420896691877m, "усл. ед" },
                    { new Guid("25f1b6ac-9337-43af-894a-80ade87d14d1"), "Order name 118", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 105.596728903627m, "усл. ед" },
                    { new Guid("262f4451-7f8a-41e6-a6d9-2d9272a65409"), "Order name 960", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 94.4897090283155m, "усл. ед" },
                    { new Guid("26d3462e-350d-4f43-9a66-c349213583eb"), "Order name 1501", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 57.9991204972109m, "усл. ед" },
                    { new Guid("26dfc5ce-6bec-4cc8-bc98-3ef114919be1"), "Order name 1766", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 85.78167348164m, "усл. ед" },
                    { new Guid("26ebd9ff-bb17-44d9-ab42-72b5a1c04f0a"), "Order name 2493", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 234.479593310243m, "усл. ед" },
                    { new Guid("27080de3-cadf-4712-adb7-89430c118aac"), "Order name 2489", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 162.287605746008m, "усл. ед" },
                    { new Guid("271c7b7e-dd07-49f3-b8b3-357cc2a2a159"), "Order name 602", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 377.204368146821m, "усл. ед" },
                    { new Guid("274bef20-8c9a-45aa-8fed-5c7af75d465c"), "Order name 355", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 378.82525191232m, "усл. ед" },
                    { new Guid("27597e71-1869-4bf4-bfec-b617d34f7dba"), "Order name 2076", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 132.086484022584m, "усл. ед" },
                    { new Guid("27783a0e-cba3-4cd5-9774-169bc79c4203"), "Order name 329", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 330.672843890311m, "усл. ед" },
                    { new Guid("278fc94a-2559-4b26-a467-9898edc9567e"), "Order name 1361", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 760.623603184336m, "усл. ед" },
                    { new Guid("27926465-37d9-43c2-8ec5-4dd92f6b50a7"), "Order name 2193", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 119.720206093116m, "усл. ед" },
                    { new Guid("27961e26-314d-4983-b4cc-f5d68e9b3557"), "Order name 1023", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 442.602579565342m, "усл. ед" },
                    { new Guid("27a7000b-bbd8-4d81-b97e-741fa34b5c2c"), "Order name 2148", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 86.5015047946706m, "усл. ед" },
                    { new Guid("27b622d7-bc77-43a0-9cc6-91d21cd86629"), "Order name 172", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 101.527486504251m, "усл. ед" },
                    { new Guid("27bf4ab4-8207-429a-9ac6-319ddded1326"), "Order name 106", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 9.71994739456896m, "усл. ед" },
                    { new Guid("27ef9146-eb9b-4ecf-96f1-516c7f2537c6"), "Order name 1498", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 198.219967693255m, "усл. ед" },
                    { new Guid("28280c20-ec9f-4313-a875-d4c07f91b76c"), "Order name 1468", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 11.1002306483811m, "усл. ед" },
                    { new Guid("2835fc4b-5bdf-4036-af2f-96575b9927f2"), "Order name 1846", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 23.7304568496158m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("2842b3ae-84b9-451d-ad6d-15abf9df5ebd"), "Order name 212", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 258.406910308862m, "усл. ед" },
                    { new Guid("2868891a-04dd-44fe-803b-d4f630ae3747"), "Order name 506", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 84.9581689551254m, "усл. ед" },
                    { new Guid("286adb0b-a7cc-4749-9b0d-1848926d1f52"), "Order name 1917", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 319.546764601761m, "усл. ед" },
                    { new Guid("28a2a333-b150-4e58-a168-3d9c76e594fc"), "Order name 2095", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 541.240910788076m, "усл. ед" },
                    { new Guid("28aae314-b760-4644-adae-275ea39fdc32"), "Order name 951", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 1.40702971892374m, "усл. ед" },
                    { new Guid("28bd80e7-2853-4358-b566-e2dfc809c6c3"), "Order name 2166", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 694.685631891518m, "усл. ед" },
                    { new Guid("28f76412-8b1d-411a-9be0-7565a4e2f824"), "Order name 2377", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 403.593141119523m, "усл. ед" },
                    { new Guid("2926e3f1-edb4-465c-aa17-f16592756387"), "Order name 679", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 798.497275200024m, "усл. ед" },
                    { new Guid("29330684-556b-43b7-890a-f2d91adf9215"), "Order name 1882", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 69.4922889252674m, "усл. ед" },
                    { new Guid("29334b34-79ad-4f30-b605-4847a65bfa08"), "Order name 2101", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 263.499931613285m, "усл. ед" },
                    { new Guid("29554099-d81b-4bef-add0-bc1e622bd2e8"), "Order name 1329", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 439.066302553709m, "усл. ед" },
                    { new Guid("296cac93-21af-433d-9e28-0ad1a9d9b776"), "Order name 2000", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 171.808813585086m, "усл. ед" },
                    { new Guid("2985379d-905d-4d8c-9691-c1caf8671a89"), "Order name 1142", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 62.062499325367m, "усл. ед" },
                    { new Guid("2990a680-38d9-4463-8dde-dfdf1c15a450"), "Order name 517", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 526.018068508931m, "усл. ед" },
                    { new Guid("2991398a-8191-42c7-be54-d925d3d4b9e5"), "Order name 2411", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 50.5130888414971m, "усл. ед" },
                    { new Guid("29aad370-ceab-44d3-b221-d386877e0ac0"), "Order name 443", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 135.961340746713m, "усл. ед" },
                    { new Guid("29ea3eed-e4bd-42ba-a177-04090e8d2997"), "Order name 2084", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 18.9893530296377m, "усл. ед" },
                    { new Guid("2a086083-b604-4a82-9698-57d67c610dc9"), "Order name 815", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 568.705986885151m, "усл. ед" },
                    { new Guid("2a10e27c-3835-4995-9175-7793f79263c0"), "Order name 2028", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 341.402737530755m, "усл. ед" },
                    { new Guid("2a1a93e0-bfe6-46a7-b2d7-7f74224bf163"), "Order name 995", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 0.707498772182258m, "усл. ед" },
                    { new Guid("2a201c71-e18b-4187-8dff-74f0d9574045"), "Order name 1906", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 489.902967443849m, "усл. ед" },
                    { new Guid("2a4fdb6e-bc3f-480b-9114-22b70b5219e5"), "Order name 2370", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 641.099842258399m, "усл. ед" },
                    { new Guid("2a8d68c7-c18d-42e5-8ae5-848347027635"), "Order name 148", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 116.959974188365m, "усл. ед" },
                    { new Guid("2ac033d4-cbb4-4c53-86a4-f755737dacd5"), "Order name 1380", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 149.338268641365m, "усл. ед" },
                    { new Guid("2ac58ed5-be65-44cb-8882-f022e8b7c2ed"), "Order name 1322", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 48.9930483969832m, "усл. ед" },
                    { new Guid("2aca3cba-9de4-4ab6-b3a1-f311a19bc119"), "Order name 618", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 442.510837965408m, "усл. ед" },
                    { new Guid("2ace4f38-6269-4524-becd-9a7302f6001e"), "Order name 1409", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 595.511424925903m, "усл. ед" },
                    { new Guid("2ad4f820-4754-418c-8ac4-c0f468360c97"), "Order name 2255", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 258.856674659159m, "усл. ед" },
                    { new Guid("2adfb9cb-91a5-4399-aac5-a36e70f61786"), "Order name 2291", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 35.7274975157445m, "усл. ед" },
                    { new Guid("2b0e7a2d-65cb-483d-958a-820b2f7e5d95"), "Order name 96", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 67.0831835966266m, "усл. ед" },
                    { new Guid("2b3f2773-3c67-4c89-b80e-e927536443f3"), "Order name 2408", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 257.825822903616m, "усл. ед" },
                    { new Guid("2b520892-fcd0-4b4b-b5be-1d9d4259d03b"), "Order name 1245", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 387.534248685042m, "усл. ед" },
                    { new Guid("2b718da6-09e2-42be-9087-7be44e8f9f5a"), "Order name 1789", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 41.841355232628m, "усл. ед" },
                    { new Guid("2bb58cbf-e648-4d2f-b269-7deb82e46999"), "Order name 1202", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 115.781992302937m, "усл. ед" },
                    { new Guid("2bbe8303-b8d8-468f-8387-c981b454c3c0"), "Order name 258", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 182.595647052736m, "усл. ед" },
                    { new Guid("2bcbb369-20db-4338-af03-b573fb1e95cc"), "Order name 1481", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 22.21099487528m, "усл. ед" },
                    { new Guid("2bd381a1-27ac-42d2-b28c-f48dba38adec"), "Order name 829", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 109.949266595512m, "усл. ед" },
                    { new Guid("2bec21b2-c8bf-4ed9-b6db-750ad231026b"), "Order name 611", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 175.280950227229m, "усл. ед" },
                    { new Guid("2c36edf2-8a0d-423d-8782-92f178aa618d"), "Order name 1404", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 349.902444811529m, "усл. ед" },
                    { new Guid("2c3a3058-12f6-415c-a847-5ccd3bc8b3b1"), "Order name 1517", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 151.286851596916m, "усл. ед" },
                    { new Guid("2c65680b-75a2-4520-8a94-22fda6b4ca56"), "Order name 2213", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 305.201593316271m, "усл. ед" },
                    { new Guid("2c69a676-8a2f-4741-93f2-c9fa04e5257a"), "Order name 682", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 95.9462091839644m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("2c8ce22f-9d3e-4346-9e20-2db6ceb443cc"), "Order name 2487", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 190.512776442423m, "усл. ед" },
                    { new Guid("2c901d83-b6e2-48df-b6c3-7b05588865bb"), "Order name 1020", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 644.25095651812m, "усл. ед" },
                    { new Guid("2c95b5c4-d7ac-4c75-8f97-ce39a1e80590"), "Order name 1038", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 269.039128112499m, "усл. ед" },
                    { new Guid("2c9cf941-4d80-4d7e-8f41-d8c300973aac"), "Order name 90", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 228.665600138932m, "усл. ед" },
                    { new Guid("2cdb0ab5-5e3c-48b2-9a84-a788c17610da"), "Order name 632", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 17.9795641056411m, "усл. ед" },
                    { new Guid("2cf56870-2c52-4afa-8b42-08866ac2854e"), "Order name 1112", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 67.5223103856238m, "усл. ед" },
                    { new Guid("2d307287-05b6-4d74-a439-14cc1c22ef10"), "Order name 346", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 88.3890523294728m, "усл. ед" },
                    { new Guid("2d70e7e7-4452-4603-981d-6119427eadbb"), "Order name 1821", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 20.2795349377976m, "усл. ед" },
                    { new Guid("2d84495b-91fe-4af7-be66-c70925ccffb3"), "Order name 2383", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 91.030023984933m, "усл. ед" },
                    { new Guid("2dc31fb1-cb1c-4a76-8802-fb9db45f5110"), "Order name 1641", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 780.489584101113m, "усл. ед" },
                    { new Guid("2dcbc560-9e5d-43a0-a7f1-2a656c5f6edf"), "Order name 14", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 836.016345904141m, "усл. ед" },
                    { new Guid("2df1ea53-5518-4240-965a-da997b57db4b"), "Order name 1110", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 474.542587931807m, "усл. ед" },
                    { new Guid("2df55467-06a7-47e4-ae92-342fe4c869bd"), "Order name 481", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 228.806566860637m, "усл. ед" },
                    { new Guid("2dff57c5-3847-440b-b9dd-d6989b8bb55a"), "Order name 1004", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 394.929155058356m, "усл. ед" },
                    { new Guid("2e0504ab-7600-4419-b0fb-a3c3af00e50c"), "Order name 1816", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 708.282529408718m, "усл. ед" },
                    { new Guid("2e4377bd-3926-410a-a41a-80d4e9a1908d"), "Order name 248", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 38.1468778744535m, "усл. ед" },
                    { new Guid("2e457111-4751-4108-bf05-4cb31b526d03"), "Order name 1050", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 322.371555942336m, "усл. ед" },
                    { new Guid("2e8a0608-a585-48bf-b65c-e3858023b830"), "Order name 2348", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 111.471476779896m, "усл. ед" },
                    { new Guid("2eb53fe3-b887-4b54-bfdd-2fd267017ac1"), "Order name 1368", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 69.8129753229796m, "усл. ед" },
                    { new Guid("2ec1d6b5-2559-48a9-81f6-560243f0768b"), "Order name 2231", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 652.446466213313m, "усл. ед" },
                    { new Guid("2ed86ed1-9eb5-42bf-a0e8-b32fcc8f4ef0"), "Order name 228", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 158.415949334097m, "усл. ед" },
                    { new Guid("2eed6404-de97-4a06-a925-0e51d76ac330"), "Order name 2468", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 74.5365281728042m, "усл. ед" },
                    { new Guid("2ef347c8-5132-4b34-8ca5-24319086be1f"), "Order name 1422", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 305.816260550551m, "усл. ед" },
                    { new Guid("2f1cf0f4-544b-4c89-a50a-014ebe875d50"), "Order name 1335", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 271.163841920701m, "усл. ед" },
                    { new Guid("2f505606-0cac-450b-a58f-eeed53e698c0"), "Order name 726", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 210.127549637972m, "усл. ед" },
                    { new Guid("2f6f168c-d7f2-4150-a7ce-d6995112fe0c"), "Order name 875", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 357.824211202953m, "усл. ед" },
                    { new Guid("2f78c97c-af6d-45f5-99f4-87bb5c14041f"), "Order name 180", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 50.0648434982948m, "усл. ед" },
                    { new Guid("300dd8c5-452d-4e4e-b31f-a933c91a2d59"), "Order name 777", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 223.42062395716m, "усл. ед" },
                    { new Guid("301f5c8c-fdb1-45e0-ae57-1247e67adf04"), "Order name 2326", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 238.881474812841m, "усл. ед" },
                    { new Guid("302d13e1-adf3-4be6-83c9-893de626a679"), "Order name 2019", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 116.343639723364m, "усл. ед" },
                    { new Guid("303820e6-0e4c-4580-b250-97cc752d2cce"), "Order name 1714", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 104.776574944657m, "усл. ед" },
                    { new Guid("303b06c2-5b7e-4db0-9466-2a6364b146ba"), "Order name 1995", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 131.053265179065m, "усл. ед" },
                    { new Guid("305d64fc-656a-456f-b390-d96fb6b685df"), "Order name 803", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 50.8169707984577m, "усл. ед" },
                    { new Guid("3070781b-ff1a-4b36-8691-f6ab4f0fefc3"), "Order name 668", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 586.277570923482m, "усл. ед" },
                    { new Guid("30919909-0440-49eb-a87b-1ae559ff1a22"), "Order name 2104", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 53.3153983646446m, "усл. ед" },
                    { new Guid("30bb95e2-1f1f-45b0-aa31-f2005de6e6a2"), "Order name 1131", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 426.626425760921m, "усл. ед" },
                    { new Guid("30bd268d-17d8-4218-8e37-3f2643937251"), "Order name 1116", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 79.9092457196483m, "усл. ед" },
                    { new Guid("30cdb3d1-4de0-4f4a-9bed-32357a54efcf"), "Order name 910", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 392.158163251606m, "усл. ед" },
                    { new Guid("30ef6d01-7061-4937-adad-fedd187728af"), "Order name 621", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 769.738401958418m, "усл. ед" },
                    { new Guid("3106bda0-b5a7-4364-b069-c99486bd12d3"), "Order name 114", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 690.650906877623m, "усл. ед" },
                    { new Guid("3119ba5d-ec02-4bca-a3a5-fb7d672965de"), "Order name 968", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 89.4033933819294m, "усл. ед" },
                    { new Guid("311c2ae7-d001-4bae-9717-b70fbfb6ede2"), "Order name 2103", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 127.002160140594m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("316f4490-96df-4d4f-a25e-0c5dd06da9a2"), "Order name 2242", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 494.732691555793m, "усл. ед" },
                    { new Guid("31c03c75-6e24-441c-b7f2-7811e4c3cb42"), "Order name 2035", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 134.710610871389m, "усл. ед" },
                    { new Guid("31f2b0b1-c975-4dda-a7b4-5ae18d368c02"), "Order name 1432", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 30.9446294725223m, "усл. ед" },
                    { new Guid("321224fc-03bc-46e2-91b7-85e0d9ec9927"), "Order name 605", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 127.171350059093m, "усл. ед" },
                    { new Guid("3218f193-c698-474d-ac39-a89a43636930"), "Order name 1746", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 68.7855063046674m, "усл. ед" },
                    { new Guid("3235a74e-d54d-4bf6-956c-ff6a94ca9fdb"), "Order name 938", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 69.9890652914117m, "усл. ед" },
                    { new Guid("3245b676-2321-4ffc-aa96-f271ea973e29"), "Order name 1000", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 105.026257481019m, "усл. ед" },
                    { new Guid("325d8b9e-65fc-45f9-aade-acac3cb7307f"), "Order name 323", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 242.239767781593m, "усл. ед" },
                    { new Guid("32643896-d09c-4394-a8d0-85752971c095"), "Order name 540", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 215.728326956677m, "усл. ед" },
                    { new Guid("3273052e-6f69-492c-8855-b7b0367cd5df"), "Order name 1113", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 526.454403960267m, "усл. ед" },
                    { new Guid("32848ca9-f61b-420e-8898-e5780379a501"), "Order name 906", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 204.560075499126m, "усл. ед" },
                    { new Guid("3312a8af-6e0a-4648-b6ac-2966bb36fe57"), "Order name 1115", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 3.15864250855779m, "усл. ед" },
                    { new Guid("3315e0f2-d51b-4f00-801f-cde13ac76382"), "Order name 1654", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 288.239223479035m, "усл. ед" },
                    { new Guid("332fa9dc-59b5-4618-a7cd-536784385e12"), "Order name 606", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 642.360468336687m, "усл. ед" },
                    { new Guid("338d1d2f-3e9c-4298-beeb-2cbca99e24d4"), "Order name 2366", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 5.92985032620135m, "усл. ед" },
                    { new Guid("33a2275f-e2c7-4e8d-a2e1-254573e51bbe"), "Order name 1098", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 421.920444340058m, "усл. ед" },
                    { new Guid("33a9e048-7ae4-415d-9c52-954eb7a8252c"), "Order name 1053", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 196.29894977107m, "усл. ед" },
                    { new Guid("33aa8150-51a4-4e0f-8d3f-7d5e9c8a5db2"), "Order name 205", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 369.186368301632m, "усл. ед" },
                    { new Guid("33b5ec6a-f6d3-406f-bce9-52486eb2f0fb"), "Order name 479", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 177.446122323252m, "усл. ед" },
                    { new Guid("33b6faed-e046-4db4-9d0b-92bc5e8093e0"), "Order name 876", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 191.410122276924m, "усл. ед" },
                    { new Guid("33c448da-ce73-4735-89fd-0602ece01dfc"), "Order name 849", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 400.372732360905m, "усл. ед" },
                    { new Guid("33df96de-80cb-4176-bb51-2221b0ee5865"), "Order name 2184", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 627.420557535438m, "усл. ед" },
                    { new Guid("33e80db8-1fa2-4d81-b5ec-6c9ad7b8e67a"), "Order name 1375", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 291.651004965888m, "усл. ед" },
                    { new Guid("33eda944-5f10-4ac6-9479-dbf91e709d86"), "Order name 1293", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 323.57055822133m, "усл. ед" },
                    { new Guid("33f4ecc5-45b7-4782-8e10-348d4644360a"), "Order name 590", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 365.57246072669m, "усл. ед" },
                    { new Guid("34028ee4-4a63-4910-a81d-75d489b7bb7a"), "Order name 813", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 272.534043533676m, "усл. ед" },
                    { new Guid("343edb2b-03bb-4cf6-892e-21715f4dce73"), "Order name 160", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 4.64082486137447m, "усл. ед" },
                    { new Guid("3459b40e-0b2f-4155-9278-177d607bed57"), "Order name 361", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 904.475419132842m, "усл. ед" },
                    { new Guid("345b0d67-b6d8-4d8e-814f-f037927ad1c0"), "Order name 2264", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 262.820587370411m, "усл. ед" },
                    { new Guid("34757354-6f5a-4bd5-a4d6-542433316f1c"), "Order name 2252", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 50.529660995027m, "усл. ед" },
                    { new Guid("3481cc85-0b39-4c56-9458-9e23478ea0b8"), "Order name 369", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 30.518416359318m, "усл. ед" },
                    { new Guid("348452a6-9ed6-45bf-9388-d6c45f2fcecd"), "Order name 1362", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 389.265769649681m, "усл. ед" },
                    { new Guid("348df6d5-2a96-4ed9-8af7-b83754689c4e"), "Order name 2437", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 88.0687848963175m, "усл. ед" },
                    { new Guid("34cc5eae-feac-4ec2-9ef8-0d09a74e53b0"), "Order name 143", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 346.897647244113m, "усл. ед" },
                    { new Guid("34e18843-ac87-43d7-bcf1-a8c9e8f88241"), "Order name 1800", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 79.9027868835823m, "усл. ед" },
                    { new Guid("34e9335e-9787-441b-9f84-e126c0fe6116"), "Order name 1005", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 321.290937996033m, "усл. ед" },
                    { new Guid("34fa72b4-1aad-402f-b6a7-717c4b80bc7d"), "Order name 149", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 225.901240446147m, "усл. ед" },
                    { new Guid("34ff295c-d5f5-4b3c-87df-8b251a1946e8"), "Order name 1955", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 32.7044258505544m, "усл. ед" },
                    { new Guid("35090ba0-cf8e-4ca9-b071-27111444acb6"), "Order name 349", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 645.786278660017m, "усл. ед" },
                    { new Guid("3520957d-a1a2-4b25-959d-4e94eb171880"), "Order name 547", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 626.734799945255m, "усл. ед" },
                    { new Guid("35230d70-f616-4505-9370-d74bb0b28e07"), "Order name 1318", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 322.827882463958m, "усл. ед" },
                    { new Guid("3526be1f-e8f4-4d16-be5b-d7153f1ac37c"), "Order name 817", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 238.524954501109m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("353612cb-7759-449c-af97-311f7d0b0f59"), "Order name 667", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 77.8748478922724m, "усл. ед" },
                    { new Guid("35397ba2-e0eb-4b53-bd3f-cc30075d9e89"), "Order name 367", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 76.3716867538879m, "усл. ед" },
                    { new Guid("35475998-d28f-4f3d-bd1c-930d6bd6aa48"), "Order name 2494", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 143.825948109608m, "усл. ед" },
                    { new Guid("35563c92-2894-4f44-a490-7fe514f141ed"), "Order name 1649", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 172.355453973217m, "усл. ед" },
                    { new Guid("35593bc9-c493-476b-9017-2c45c66d877e"), "Order name 2464", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 4.86729143848796m, "усл. ед" },
                    { new Guid("355d5674-d438-46ad-9f9e-536e583acfd4"), "Order name 1195", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 197.129654248855m, "усл. ед" },
                    { new Guid("3566360d-7b13-4a31-9845-dfedfc8133a5"), "Order name 649", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 89.2450415190725m, "усл. ед" },
                    { new Guid("356c0087-ecd1-4d15-b17e-4f02da960a10"), "Order name 1360", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 129.116770102337m, "усл. ед" },
                    { new Guid("357876c9-dcc4-4a43-9afb-0e9a67253780"), "Order name 2207", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 509.46739706442m, "усл. ед" },
                    { new Guid("358004ee-f039-4a48-bb60-75012a1b1567"), "Order name 835", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 208.841991977115m, "усл. ед" },
                    { new Guid("3587644d-8345-4e05-a79b-54364dba1a87"), "Order name 2284", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 484.463888680424m, "усл. ед" },
                    { new Guid("359b0bd5-4b68-4f31-a9ad-9c1738a13125"), "Order name 1619", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 15.038699389184m, "усл. ед" },
                    { new Guid("35a8f050-f222-4a73-8894-487da29d8c9c"), "Order name 2017", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 467.397353417064m, "усл. ед" },
                    { new Guid("35bc52f1-07c8-4254-98b4-9e86c5a7e70a"), "Order name 422", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 605.839312831776m, "усл. ед" },
                    { new Guid("35ddaa15-75c0-4a10-9705-60b925927427"), "Order name 900", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 348.502736543936m, "усл. ед" },
                    { new Guid("35ed1ec6-5570-4f17-8aee-ad55c96eb479"), "Order name 946", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 391.621725875436m, "усл. ед" },
                    { new Guid("360808ca-1327-4d37-a88b-bbb3216b2fb9"), "Order name 1269", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 232.256817139881m, "усл. ед" },
                    { new Guid("362463c3-a837-4652-95cb-9123b8b1bbca"), "Order name 1469", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 499.197614916593m, "усл. ед" },
                    { new Guid("3634e64c-6461-4d66-9c50-e34ddd4781e3"), "Order name 683", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 122.368301301568m, "усл. ед" },
                    { new Guid("363b9c3a-7a3b-482d-9dac-01e816590f11"), "Order name 437", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 194.90150142702m, "усл. ед" },
                    { new Guid("3663a7bf-6af2-4b96-aaee-ba383ad7c01b"), "Order name 302", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 272.445789500445m, "усл. ед" },
                    { new Guid("36681169-a306-47a1-81ad-8f274ece72d2"), "Order name 2051", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 99.746588604874m, "усл. ед" },
                    { new Guid("36827779-1a3c-47b8-b01a-471fabc193f6"), "Order name 107", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 7.96524916281233m, "усл. ед" },
                    { new Guid("36b13b75-58b5-42d1-983b-3e9bcecb522f"), "Order name 2393", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 783.914275815791m, "усл. ед" },
                    { new Guid("36c02911-463d-4602-bcd7-994939ecac19"), "Order name 1784", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 75.8318089032619m, "усл. ед" },
                    { new Guid("36d967fc-d8ae-430b-befc-8424cfcfa184"), "Order name 2112", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 594.625878875516m, "усл. ед" },
                    { new Guid("36fac5ae-46ac-45a5-9b6e-f5cf2d6e4e51"), "Order name 1446", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 12.9362991712311m, "усл. ед" },
                    { new Guid("3710a4cf-f4e6-4077-8534-8b92d5b0a86d"), "Order name 1612", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 231.31142015812m, "усл. ед" },
                    { new Guid("3737f7d6-76a7-49e5-a1b8-3e7031ba89e3"), "Order name 95", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 69.8020655958271m, "усл. ед" },
                    { new Guid("376ab6fd-842c-44c6-a262-f809a584b0a0"), "Order name 347", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 100.609957204676m, "усл. ед" },
                    { new Guid("3770e7a4-afdc-4b52-a838-61e5fc10f114"), "Order name 2132", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 311.658554528702m, "усл. ед" },
                    { new Guid("3776bf9d-f828-4939-b4b7-9ad33f39592f"), "Order name 980", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 4.33852250357941m, "усл. ед" },
                    { new Guid("37c0aeb0-e110-4696-baf6-5d6a36a2b838"), "Order name 793", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 193.877454981781m, "усл. ед" },
                    { new Guid("38098f57-ea4f-4715-bb80-d1d811912b4d"), "Order name 2088", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 160.697247813048m, "усл. ед" },
                    { new Guid("3814a24d-7f04-459e-a243-627f2fa7afd3"), "Order name 210", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 701.395885902491m, "усл. ед" },
                    { new Guid("387a6d6f-9dda-45ee-818f-9b19aaf4c79f"), "Order name 216", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 731.724130179031m, "усл. ед" },
                    { new Guid("38824a93-e431-495e-8a0d-6e961c75f578"), "Order name 73", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 122.332450263073m, "усл. ед" },
                    { new Guid("38b0ce1e-e886-4cf5-b7f1-67b86bc9dc9f"), "Order name 2462", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 144.804573610166m, "усл. ед" },
                    { new Guid("38c11a02-5dca-45e8-b4d5-d0ed7ea18e8a"), "Order name 2469", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 168.666307115723m, "усл. ед" },
                    { new Guid("3959f1c1-201a-4ab0-8ecf-fecc10c9991e"), "Order name 1868", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 64.8202144595614m, "усл. ед" },
                    { new Guid("3964ba30-c2cd-4e50-830c-203fdc7def99"), "Order name 457", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 775.112605206195m, "усл. ед" },
                    { new Guid("3976cdf7-0e39-480c-9dad-65fbe9b5cfb2"), "Order name 2426", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 130.336941087639m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("3982a006-86fc-4a9a-9abd-6a5bef1604f2"), "Order name 888", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 368.818279584731m, "усл. ед" },
                    { new Guid("398ab8a1-dde5-4869-a22a-1d8b4d74ce6e"), "Order name 104", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 873.792434149282m, "усл. ед" },
                    { new Guid("398e7a52-c4ec-421f-9545-bcc9cddad5ce"), "Order name 659", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 90.3464939911404m, "усл. ед" },
                    { new Guid("39ab4df2-36dd-41f3-9e32-0c795fe3e5ed"), "Order name 287", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 186.394381956856m, "усл. ед" },
                    { new Guid("39bd62b7-afd1-41bf-a633-c72abb85c7c8"), "Order name 2387", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 54.3639566817198m, "усл. ед" },
                    { new Guid("39ce811b-5c66-4775-b36e-1df9124c213c"), "Order name 1943", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 14.2564600018303m, "усл. ед" },
                    { new Guid("39ef8f5c-02b9-4708-a5f0-a319cba08d1e"), "Order name 786", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 381.51788753445m, "усл. ед" },
                    { new Guid("3a26e08d-53a7-49e7-8c25-9b3e935bf96f"), "Order name 2121", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 687.939438177197m, "усл. ед" },
                    { new Guid("3a29850d-0107-4b24-8e49-1cf923cb18b1"), "Order name 1788", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 187.928682014098m, "усл. ед" },
                    { new Guid("3a44ed50-9694-4083-a035-32424baab993"), "Order name 1419", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 545.966902260992m, "усл. ед" },
                    { new Guid("3a55d681-dfbc-4b66-83af-237386865932"), "Order name 1402", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 62.7711526148602m, "усл. ед" },
                    { new Guid("3a6ce34a-ab1d-4985-a3d7-ef614b8c7012"), "Order name 1617", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 349.523312014932m, "усл. ед" },
                    { new Guid("3a6ff30f-826c-49a1-8331-6d7a0c8c29aa"), "Order name 598", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 35.8995410901868m, "усл. ед" },
                    { new Guid("3a92a6a8-a5ef-45e6-9255-e72da8835866"), "Order name 1860", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 807.318680906961m, "усл. ед" },
                    { new Guid("3aa9fbcc-06e2-42b8-912b-ff28e0f5ca5f"), "Order name 10", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 518.72161625585m, "усл. ед" },
                    { new Guid("3abbfc74-fd6e-47f8-af40-d22e5914d378"), "Order name 386", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 148.806745712052m, "усл. ед" },
                    { new Guid("3ae2e067-35c2-4499-afc3-422830972b41"), "Order name 1704", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 430.714806261461m, "усл. ед" },
                    { new Guid("3ae90e29-532e-46ee-946f-4f343e37e717"), "Order name 1803", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 90.5459353889246m, "усл. ед" },
                    { new Guid("3af691ed-5572-4b9b-8e92-a5186ec8a68f"), "Order name 2179", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 32.0642425558293m, "усл. ед" },
                    { new Guid("3afc0b1b-6444-4d93-9314-529dff7bb1a6"), "Order name 549", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 64.3854098233351m, "усл. ед" },
                    { new Guid("3b0d0391-72e3-408d-b027-2f1477329e99"), "Order name 1735", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 65.9311254468842m, "усл. ед" },
                    { new Guid("3b1c02d5-8489-4cbf-ac20-a6601eae34c8"), "Order name 588", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 193.986873197817m, "усл. ед" },
                    { new Guid("3b1c049d-d065-47d0-9ae9-834a1794a5fe"), "Order name 1495", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 146.173308265071m, "усл. ед" },
                    { new Guid("3b3b75f7-fda3-4d3d-b56a-d45d0f1ad0e6"), "Order name 82", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 112.677286936184m, "усл. ед" },
                    { new Guid("3b5812b3-6bef-4460-8ad3-5027453fb36f"), "Order name 275", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 219.413986907508m, "усл. ед" },
                    { new Guid("3ba16e83-d3a3-4738-ab91-0c3b9611ac85"), "Order name 339", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 471.316829154645m, "усл. ед" },
                    { new Guid("3baa047b-fd26-47d6-9a01-b71e89b288a1"), "Order name 2034", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 560.109617827773m, "усл. ед" },
                    { new Guid("3bd91ac4-d5d1-4839-b81f-45b96bfddf17"), "Order name 393", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 4.33692412202213m, "усл. ед" },
                    { new Guid("3bdab7dc-0dad-40d3-9355-6d1a9948393d"), "Order name 2251", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 48.262697442644m, "усл. ед" },
                    { new Guid("3c4594b1-9e98-4d2e-b1b7-f797e5846fd2"), "Order name 2001", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 24.6856899974326m, "усл. ед" },
                    { new Guid("3c8f8ac0-87ab-422a-9d15-88424823b61c"), "Order name 1229", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 84.6311824104235m, "усл. ед" },
                    { new Guid("3c92efd6-fb16-436c-97a2-b5714aa31ffe"), "Order name 1370", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 303.56271984919m, "усл. ед" },
                    { new Guid("3cb8f5c5-c208-4ccd-baf1-ce5e37df20bd"), "Order name 1669", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 26.3543108845494m, "усл. ед" },
                    { new Guid("3ccf203d-88c2-43d6-812c-3cd49bcaf239"), "Order name 775", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 514.856319514571m, "усл. ед" },
                    { new Guid("3ce6ac97-4c23-4724-8a9c-3cb77eb5be53"), "Order name 1049", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 387.642118322403m, "усл. ед" },
                    { new Guid("3cec0baf-1176-4568-821b-4fc9860efe7f"), "Order name 1633", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 210.188687815648m, "усл. ед" },
                    { new Guid("3cf392f8-2031-4b5a-8efc-62d62d53241b"), "Order name 690", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 333.730249096342m, "усл. ед" },
                    { new Guid("3d1ab66d-3d83-4ea7-9ff6-23066d8dac06"), "Order name 1026", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 408.622684019792m, "усл. ед" },
                    { new Guid("3d1bdc9f-17e8-40d3-90de-6c226cdd9e50"), "Order name 1946", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 199.0774064573m, "усл. ед" },
                    { new Guid("3d1ca5e5-9339-4f6e-b36a-a4324226bd5e"), "Order name 1982", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 376.548921644938m, "усл. ед" },
                    { new Guid("3d2ebee0-8e23-4af4-a2ad-ffdc3eaa5daa"), "Order name 1979", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 340.037966803085m, "усл. ед" },
                    { new Guid("3d4e0af9-211e-4ade-95fe-cc5504d3ae1c"), "Order name 1029", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 313.884524925141m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("3d82851d-edd7-45e0-8e73-de2b4fcc8d2e"), "Order name 1785", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 177.197580736016m, "усл. ед" },
                    { new Guid("3dbbc695-c581-4f21-8fa9-04c044d25eef"), "Order name 411", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 480.353666486599m, "усл. ед" },
                    { new Guid("3dbeb699-2154-4dbf-bbe7-7a9e6a1132cb"), "Order name 694", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 158.588034967878m, "усл. ед" },
                    { new Guid("3de32a8a-f2a7-4d65-98d8-469cf18ad19d"), "Order name 2480", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 375.739406178059m, "усл. ед" },
                    { new Guid("3e00ea17-e219-4415-bd7b-96eece32132e"), "Order name 544", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 9.3818609552342m, "усл. ед" },
                    { new Guid("3e36445f-8716-4b4e-8b23-984b897ca55b"), "Order name 1845", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 492.231779768389m, "усл. ед" },
                    { new Guid("3e6d51e4-7224-4b26-a4e8-adcac5417ebe"), "Order name 399", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 650.514289240219m, "усл. ед" },
                    { new Guid("3e832ca0-b4e7-4872-b522-f2ba19a0e3f6"), "Order name 1111", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 607.944396338053m, "усл. ед" },
                    { new Guid("3ebf1c9c-acc4-4f5c-8562-db7f8f703191"), "Order name 2111", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 287.557661104089m, "усл. ед" },
                    { new Guid("3ebfd36e-5901-440a-9098-ba3bb4df1cfa"), "Order name 550", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 205.115603620839m, "усл. ед" },
                    { new Guid("3ec68aad-bb34-4a7e-938a-c55079c5852b"), "Order name 1826", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 559.629445673874m, "усл. ед" },
                    { new Guid("3eeb285a-f30f-4da7-9d4f-fcfcf1f63f4f"), "Order name 785", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 307.824651044813m, "усл. ед" },
                    { new Guid("3f02f4d4-5695-4848-95e8-e56513e9b8b5"), "Order name 702", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 175.7658331139m, "усл. ед" },
                    { new Guid("3f05c7cc-e5af-451d-b25f-912bf3ba060d"), "Order name 1478", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 325.161019280762m, "усл. ед" },
                    { new Guid("3f3c866d-3c76-4f63-9758-fa4d9c6206ae"), "Order name 2396", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 173.075660931566m, "усл. ед" },
                    { new Guid("3f4ca354-220b-4da6-9eee-894ff4657599"), "Order name 1044", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 228.606105180801m, "усл. ед" },
                    { new Guid("3f6a861e-e695-4f22-94d5-b0f98241354c"), "Order name 2450", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 313.72033462285m, "усл. ед" },
                    { new Guid("3f73e559-980d-4330-85fd-fe389c8b529c"), "Order name 971", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 503.516961673094m, "усл. ед" },
                    { new Guid("3feb464a-7cb5-4e5b-8639-a4624d9ee541"), "Order name 1625", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 207.967907617007m, "усл. ед" },
                    { new Guid("3ff10718-dc5c-4a82-b8d1-ef66acbca291"), "Order name 2062", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 205.365580842015m, "усл. ед" },
                    { new Guid("4009028f-7b0b-4045-8bd5-5c471ed77179"), "Order name 1647", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 66.0643629436655m, "усл. ед" },
                    { new Guid("40246848-b063-4823-b01e-e51bee28786f"), "Order name 2163", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 209.655816353408m, "усл. ед" },
                    { new Guid("403cb780-34e0-49a5-862d-bf21bb223d78"), "Order name 2438", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 525.103417569779m, "усл. ед" },
                    { new Guid("404af286-1b44-4b33-a9df-aad92ea748bf"), "Order name 1416", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 187.374258036227m, "усл. ед" },
                    { new Guid("406033d9-e495-4f47-bc72-45d3cfba887f"), "Order name 2220", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 160.635228390298m, "усл. ед" },
                    { new Guid("40617073-fac5-48de-a981-2494ed805fd9"), "Order name 745", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 259.276233942209m, "усл. ед" },
                    { new Guid("406a2310-b170-4852-a0fd-5b674ea8e513"), "Order name 1961", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 144.356273403025m, "усл. ед" },
                    { new Guid("406ce06b-df00-49d6-a00e-dc13b577bfea"), "Order name 1007", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 67.5284454383216m, "усл. ед" },
                    { new Guid("407fb29d-e480-4a99-b214-2e457f2e0356"), "Order name 975", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 55.9486777200378m, "усл. ед" },
                    { new Guid("40becd5d-4e53-4d9e-b015-8a74729714c2"), "Order name 2172", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 375.029490963896m, "усл. ед" },
                    { new Guid("40ccaeae-d086-4368-94e6-6791d5e64f72"), "Order name 1555", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 885.607630419275m, "усл. ед" },
                    { new Guid("4118604c-5b85-4010-8f25-dddf93f7dfd0"), "Order name 1114", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 131.4861429856m, "усл. ед" },
                    { new Guid("41337758-89df-4dba-acdd-4899ccae8248"), "Order name 2026", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 135.598445246411m, "усл. ед" },
                    { new Guid("41496f48-d3ab-4cc2-9d10-cedeba341764"), "Order name 1054", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 128.040857911695m, "усл. ед" },
                    { new Guid("4161f370-0689-4dab-86dc-e8d7f9689f27"), "Order name 2161", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 42.0378327679059m, "усл. ед" },
                    { new Guid("4184eeed-6338-45c2-a1f6-264c100f3559"), "Order name 1618", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 701.114238334374m, "усл. ед" },
                    { new Guid("418ca577-e89e-4073-872c-00c6999b3ba7"), "Order name 67", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 219.633684742972m, "усл. ед" },
                    { new Guid("41ab665a-1039-41b8-9ee3-e34f65973a7f"), "Order name 1379", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 82.9434384443986m, "усл. ед" },
                    { new Guid("41abf746-8279-49e5-9e22-a3041b0a7d2e"), "Order name 687", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 25.0078785108222m, "усл. ед" },
                    { new Guid("41d60631-66c4-425c-b637-ed452821e029"), "Order name 1372", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 63.7590625959418m, "усл. ед" },
                    { new Guid("41d80b5e-e7d4-4f33-9db4-943e95a2924a"), "Order name 1873", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 185.678952050598m, "усл. ед" },
                    { new Guid("41e8475e-8b98-41cc-a970-b57cc8a26955"), "Order name 1344", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 302.099271451352m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("41fb40f4-69f6-4857-af38-a008115aacf0"), "Order name 2052", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 166.148953539432m, "усл. ед" },
                    { new Guid("42299701-689c-44e0-b205-bcf1dee7a402"), "Order name 179", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 27.574535522331m, "усл. ед" },
                    { new Guid("423df230-f21e-4a5b-aad8-d70b57d8388a"), "Order name 1635", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 0.274473375018333m, "усл. ед" },
                    { new Guid("429c2df7-e2fa-44eb-b4b1-3379af3ca78a"), "Order name 1252", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 67.7094059552497m, "усл. ед" },
                    { new Guid("42a42d12-63df-4a1c-8f09-34f3d2931958"), "Order name 1548", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 139.275871388348m, "усл. ед" },
                    { new Guid("42ad4464-c5bf-4d5e-b2f0-26e2cc0bca70"), "Order name 238", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 128.82018057087m, "усл. ед" },
                    { new Guid("42b13967-a8e8-4082-8030-38ab0d79c8cb"), "Order name 2183", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 344.677509679656m, "усл. ед" },
                    { new Guid("42e7127a-5993-418b-91a8-cafab6e8ff5f"), "Order name 2224", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 30.7349152555608m, "усл. ед" },
                    { new Guid("42eb188d-5381-413e-98cf-0b19d07c8a7e"), "Order name 1691", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 346.427754564808m, "усл. ед" },
                    { new Guid("430a6095-0370-4967-9ba4-0b23e294e47c"), "Order name 2178", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 90.4028164514999m, "усл. ед" },
                    { new Guid("430b3991-4067-4e9d-a981-0d4c674b7d2e"), "Order name 1844", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 629.956905691922m, "усл. ед" },
                    { new Guid("4314db52-7a99-4619-ab6e-1f369d4a8904"), "Order name 1902", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 354.565598209869m, "усл. ед" },
                    { new Guid("4335e85e-a40e-4459-b941-8baf3ad3099a"), "Order name 54", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 54.9519604606894m, "усл. ед" },
                    { new Guid("433b9d3e-3ddb-4ce2-b4e4-8dfa47dcf5ca"), "Order name 1492", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 68.7291048852092m, "усл. ед" },
                    { new Guid("435b57fb-b62e-4f4c-af46-f8410e6133af"), "Order name 2320", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 13.0486962300475m, "усл. ед" },
                    { new Guid("435b7158-524b-4078-af84-56300fd8bca1"), "Order name 714", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 218.156433774393m, "усл. ед" },
                    { new Guid("4386a3b6-a2b6-4aa3-9ab2-aba3951c3a01"), "Order name 2226", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 378.349946944909m, "усл. ед" },
                    { new Guid("4386ec1a-8a78-4642-a489-1d479da1b672"), "Order name 1323", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 439.922352443865m, "усл. ед" },
                    { new Guid("438ceff2-a576-42fe-a7bb-82da9739367f"), "Order name 2394", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 473.218391307602m, "усл. ед" },
                    { new Guid("4391607d-701a-4335-b83d-5872ef39837b"), "Order name 2196", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 139.727176921355m, "усл. ед" },
                    { new Guid("43993116-fbe1-4209-b52d-e5cb2e5b74dc"), "Order name 1353", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 0.210360745793326m, "усл. ед" },
                    { new Guid("43e1f9d0-f36e-42e6-b3f5-fa92df40b380"), "Order name 2008", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 516.633113741389m, "усл. ед" },
                    { new Guid("43ef1129-ade9-42e4-b14f-f716273f7755"), "Order name 452", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 212.408922752014m, "усл. ед" },
                    { new Guid("43f44989-03e9-491e-a7e6-c922d7450356"), "Order name 2433", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 144.314164888685m, "усл. ед" },
                    { new Guid("43fddd10-1106-4f52-91a6-a01fd1e81e1a"), "Order name 729", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 162.762167101586m, "усл. ед" },
                    { new Guid("444b894b-881c-4909-96c0-cc60044a504d"), "Order name 584", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 510.338771565363m, "усл. ед" },
                    { new Guid("447ef4a8-5279-4460-9995-67730a2cf931"), "Order name 2496", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 143.91759337809m, "усл. ед" },
                    { new Guid("4484931e-d8c5-4092-96ae-53a012490c61"), "Order name 381", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 141.290535550681m, "усл. ед" },
                    { new Guid("44b745dd-a255-4969-bb45-b700531c726e"), "Order name 2350", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 529.429685860364m, "усл. ед" },
                    { new Guid("44ce55e1-78bb-433a-bc5f-0af2fb2f6c9c"), "Order name 1479", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 103.286083542711m, "усл. ед" },
                    { new Guid("44d81048-e052-407d-ac13-4065db71fc14"), "Order name 1384", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 423.004138717965m, "усл. ед" },
                    { new Guid("44d9a0ff-bf29-4880-9b5e-b2bd3c487e8b"), "Order name 320", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 174.108016518425m, "усл. ед" },
                    { new Guid("44f04795-0a56-45b5-b1a2-4d906a238dbd"), "Order name 872", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 108.059045965361m, "усл. ед" },
                    { new Guid("44fc9936-3299-4424-94ee-aa50f8f0a325"), "Order name 2281", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 314.805837036809m, "усл. ед" },
                    { new Guid("4517a8db-3917-4d7c-921b-2a9063512c4e"), "Order name 1899", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 74.1537212578381m, "усл. ед" },
                    { new Guid("45463435-4040-4914-a0d2-0bd0acdfe42e"), "Order name 1257", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 115.950874307528m, "усл. ед" },
                    { new Guid("457dad94-01d9-4dc3-985f-422d0a55eb51"), "Order name 53", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 573.33490543347m, "усл. ед" },
                    { new Guid("4582da4a-a8ef-4927-8ed5-3e8f2d295803"), "Order name 1626", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 760.955293050634m, "усл. ед" },
                    { new Guid("45965b74-dd19-4dd2-bd05-a51d55418d7d"), "Order name 4", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 70.2975811456203m, "усл. ед" },
                    { new Guid("45b6efb8-a423-4e41-b6e8-262aeffd8f20"), "Order name 1239", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 186.521504145537m, "усл. ед" },
                    { new Guid("45dfc0b7-9b88-4e1f-826b-83438a36a0bf"), "Order name 2313", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 251.041736281976m, "усл. ед" },
                    { new Guid("45fe0574-ba61-45d1-92cd-932751175d8f"), "Order name 1309", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 173.201821514309m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("4613509d-abcd-4b39-b832-2add77de9e1c"), "Order name 2425", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 24.0343295496576m, "усл. ед" },
                    { new Guid("4613b5fe-fe26-4d35-8ecb-d4f01c4a8dcc"), "Order name 1910", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 99.9738820895341m, "усл. ед" },
                    { new Guid("462212f1-d31a-4fae-88ac-896f15c1e89f"), "Order name 2398", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 244.089071776941m, "усл. ед" },
                    { new Guid("4630d95f-3e15-4e53-b1b6-89a3597fb964"), "Order name 343", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 81.0329403963308m, "усл. ед" },
                    { new Guid("4642aa84-905a-4b6d-b6ba-91f5bc38e7c3"), "Order name 847", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 245.161317395698m, "усл. ед" },
                    { new Guid("4665f205-f955-4b06-b67a-26364d1ae7c1"), "Order name 2142", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 23.0565815703969m, "усл. ед" },
                    { new Guid("46da5c31-2625-444f-bac7-10b7a632d07c"), "Order name 1519", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 711.289885799657m, "усл. ед" },
                    { new Guid("46e460be-b239-4024-a5bd-e7ec9c4862c1"), "Order name 1089", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 917.057695487292m, "усл. ед" },
                    { new Guid("46ec0780-65a4-43d0-830e-c3955ea499e7"), "Order name 528", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 222.126350892432m, "усл. ед" },
                    { new Guid("474ded5a-79e9-4977-85e4-6e314baaef1f"), "Order name 1475", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 154.556179818856m, "усл. ед" },
                    { new Guid("4754a800-1503-42bf-ad00-d332f83027be"), "Order name 1137", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 94.4064097057144m, "усл. ед" },
                    { new Guid("47684194-fc4d-4859-bdbf-24986b6e59db"), "Order name 1301", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 507.985035929706m, "усл. ед" },
                    { new Guid("4771b853-63f5-4d03-84a7-764887716c26"), "Order name 1188", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 5.20179187549252m, "усл. ед" },
                    { new Guid("47973501-48e7-47a9-a805-cda0896528b5"), "Order name 167", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 341.706193727966m, "усл. ед" },
                    { new Guid("479dfce4-05c2-48e7-a0da-68c26b072ab5"), "Order name 1472", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 172.678843922038m, "усл. ед" },
                    { new Guid("47b7dd65-bbc6-408e-b4ec-226745ec5cb0"), "Order name 324", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 127.486108808949m, "усл. ед" },
                    { new Guid("47d5e737-da38-44fa-ba74-b392b173d85d"), "Order name 930", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 11.8583060300068m, "усл. ед" },
                    { new Guid("47f62dff-5f2b-4196-a49a-c15ec5cb32b6"), "Order name 224", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 48.0338314188215m, "усл. ед" },
                    { new Guid("483a347f-0658-470f-9155-651a7d663219"), "Order name 1287", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 17.8369061361147m, "усл. ед" },
                    { new Guid("48570b03-c597-4672-95b8-5727ace8fc25"), "Order name 2208", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 79.8998232900842m, "усл. ед" },
                    { new Guid("48bc7576-716f-445d-b080-85b206addfa3"), "Order name 1426", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 154.652420601158m, "усл. ед" },
                    { new Guid("48d7b877-62a5-4cc4-b2d6-a702a149588b"), "Order name 615", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 67.1749596766603m, "усл. ед" },
                    { new Guid("48db5e84-0d0c-415c-b65d-9d5993cdf8ee"), "Order name 961", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 303.590508865719m, "усл. ед" },
                    { new Guid("48efe6d1-cbcd-46d1-8491-12df649d6bc5"), "Order name 1680", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 774.939096042497m, "усл. ед" },
                    { new Guid("49004aaf-f85c-4e56-b394-3d14b8e18e11"), "Order name 303", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 196.492178607262m, "усл. ед" },
                    { new Guid("4915a543-dfcf-4e9a-8162-7e40d5df134e"), "Order name 154", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 41.9286321377722m, "усл. ед" },
                    { new Guid("4915e8a3-359b-4e6f-b442-f6a239e56eb1"), "Order name 1194", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 391.638825899622m, "усл. ед" },
                    { new Guid("4948d85c-de96-453b-b9a5-48d9c7dbd924"), "Order name 1272", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 812.270447115864m, "усл. ед" },
                    { new Guid("49503316-7340-4ccf-9e8a-6897963ef42f"), "Order name 725", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 217.305989579477m, "усл. ед" },
                    { new Guid("49562187-ebf9-4c32-ad51-6c7d6a2d3e77"), "Order name 296", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 339.828862796502m, "усл. ед" },
                    { new Guid("4961add2-0958-4e9c-a86a-1eeaf70d0c1b"), "Order name 1223", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 82.7527467612867m, "усл. ед" },
                    { new Guid("49886294-4420-4270-9160-641c8cbc6091"), "Order name 656", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 282.010368072777m, "усл. ед" },
                    { new Guid("499d4c21-154c-47dc-881e-d7368eb2ef61"), "Order name 915", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 360.443754189225m, "усл. ед" },
                    { new Guid("49c781ff-46fa-464f-841b-a6177807ddbb"), "Order name 1516", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 220.762668543744m, "усл. ед" },
                    { new Guid("49fc91ef-397c-40bc-8d2f-c21bd5cc4074"), "Order name 1241", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 251.183560917452m, "усл. ед" },
                    { new Guid("4a0f7eea-6081-4d45-8c7f-e584b8ec3941"), "Order name 1464", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 96.1704449830705m, "усл. ед" },
                    { new Guid("4a268ca5-d146-4b4b-a784-5b72ae8fdde2"), "Order name 955", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 138.759970369153m, "усл. ед" },
                    { new Guid("4a2b32d0-3250-45f7-a994-d099b3de755a"), "Order name 2107", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 320.426422759523m, "усл. ед" },
                    { new Guid("4a2d4002-180e-4e7c-9b87-cdb2d577444e"), "Order name 1707", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 14.591488537761m, "усл. ед" },
                    { new Guid("4a34b54c-2f55-4408-bdd4-8381ad176a23"), "Order name 1525", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 34.965985910792m, "усл. ед" },
                    { new Guid("4a3a059f-6109-40dc-88c2-97c485266c8f"), "Order name 873", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 368.56475279392m, "усл. ед" },
                    { new Guid("4a3b4548-101a-4b45-afe0-91dca6a2829e"), "Order name 692", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 486.651120985673m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("4a6e05fc-1b0b-4b2b-acf3-0fb609bb1bae"), "Order name 1438", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 157.247530028183m, "усл. ед" },
                    { new Guid("4a74d186-1c36-48fd-8811-85c99ad33c95"), "Order name 193", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 215.344176720172m, "усл. ед" },
                    { new Guid("4ac51abd-8066-4e6d-9e18-3d64e08cdb82"), "Order name 2060", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 82.9358828805318m, "усл. ед" },
                    { new Guid("4aebc8ac-1539-47f5-857a-dfa270a432f0"), "Order name 332", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 318.442021810284m, "усл. ед" },
                    { new Guid("4b02581f-8708-4c0e-9ffd-d4347457725d"), "Order name 739", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 424.818152206569m, "усл. ед" },
                    { new Guid("4b1a215c-d7fb-4900-a21d-accf31b08ea8"), "Order name 527", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 166.005853970329m, "усл. ед" },
                    { new Guid("4b367f56-1e89-4ab2-92c9-e6a08ddaa4e1"), "Order name 270", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 462.103695962926m, "усл. ед" },
                    { new Guid("4b4f356f-30cd-4598-a836-68770ada5dc0"), "Order name 2160", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 269.265963976523m, "усл. ед" },
                    { new Guid("4b6000c8-d56b-469b-9f5a-066b6540faef"), "Order name 755", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 453.029376525959m, "усл. ед" },
                    { new Guid("4b615f36-4a32-4528-a81e-a147cf7e9f52"), "Order name 932", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 257.473320448091m, "усл. ед" },
                    { new Guid("4b664d63-92c0-41fa-9895-2f568cb84cb4"), "Order name 1962", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 436.913340168068m, "усл. ед" },
                    { new Guid("4b806e50-487c-43f3-a1de-41ec85706d13"), "Order name 520", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 350.281373710353m, "усл. ед" },
                    { new Guid("4bc7db3d-1004-4780-80b0-dbc57a3aa996"), "Order name 787", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 100.043849772466m, "усл. ед" },
                    { new Guid("4bc92514-9229-4dae-9a2f-4d3dbc142ef9"), "Order name 447", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 460.760039556905m, "усл. ед" },
                    { new Guid("4bdad751-f217-4e15-a8b9-b6d874278e9c"), "Order name 264", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 65.5642737110318m, "усл. ед" },
                    { new Guid("4bdea723-c313-44b8-925f-9c6f9e98f65e"), "Order name 1286", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 513.435892179035m, "усл. ед" },
                    { new Guid("4bf7f365-a589-4fe8-b086-a39586e30674"), "Order name 1251", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 59.9976694450481m, "усл. ед" },
                    { new Guid("4c0d17a9-6fd7-453b-9578-31291de955e7"), "Order name 589", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 125.934270655035m, "усл. ед" },
                    { new Guid("4c14aaa6-140b-4dab-adde-54b2597b5c43"), "Order name 862", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 511.787599412277m, "усл. ед" },
                    { new Guid("4c17d13f-2494-4096-a0f2-edc79dfb3001"), "Order name 2155", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 943.70791955977m, "усл. ед" },
                    { new Guid("4c1eee5a-f7b9-42a9-a3fb-86bc23a1968e"), "Order name 1466", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 46.3707479598391m, "усл. ед" },
                    { new Guid("4c2fa627-8b83-461c-b235-2b9378159485"), "Order name 2427", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 900.4368307938m, "усл. ед" },
                    { new Guid("4c305855-3125-4e00-9251-4f09a26cde22"), "Order name 790", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 215.046947869265m, "усл. ед" },
                    { new Guid("4c6a22a5-39a6-41ed-b9df-1a713ca843c1"), "Order name 1463", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 81.9641233167762m, "усл. ед" },
                    { new Guid("4c7feb40-c4ec-4da8-9f05-3d9b58eede5a"), "Order name 1009", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 41.9935283395997m, "усл. ед" },
                    { new Guid("4c937327-50c5-4b48-92f9-d48fcc7e9b92"), "Order name 2482", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 152.849309824199m, "усл. ед" },
                    { new Guid("4c9c4c95-5516-470f-8877-e72f417f43a2"), "Order name 2403", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 54.4186424175888m, "усл. ед" },
                    { new Guid("4ccf487d-5954-4dbe-99cd-a329703b4a15"), "Order name 2323", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 35.4795543458461m, "усл. ед" },
                    { new Guid("4cd6191b-ed74-4af6-8834-a3eeca6cd4d2"), "Order name 2342", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 437.042714415266m, "усл. ед" },
                    { new Guid("4cd98b38-bc6c-4583-bc7a-3a896a6d05a9"), "Order name 2143", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 82.902115142941m, "усл. ед" },
                    { new Guid("4d18e4ba-61e1-4e56-b689-2b0fb32d9cbf"), "Order name 2056", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 42.1118008794798m, "усл. ед" },
                    { new Guid("4d300d91-868a-4de8-973c-26ef8fc27637"), "Order name 2262", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 376.097789652804m, "усл. ед" },
                    { new Guid("4d62c9ab-808a-4dd1-ab4c-3ed0022048a3"), "Order name 466", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 806.833198445689m, "усл. ед" },
                    { new Guid("4dde7722-3195-469d-abdb-d71be611a707"), "Order name 1031", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 421.727852718577m, "усл. ед" },
                    { new Guid("4e01019c-b86e-4b0c-ae3b-aa9500194916"), "Order name 331", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 71.1730673132421m, "усл. ед" },
                    { new Guid("4e0b272e-cafc-4fa2-9254-ef5f3c6b6b74"), "Order name 392", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 0.0129616556580054m, "усл. ед" },
                    { new Guid("4e18f8a4-e4f4-4aeb-9c2b-d731ad656e16"), "Order name 844", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 97.1526686824771m, "усл. ед" },
                    { new Guid("4e2306e6-75e3-4725-af06-b49b6b6c2129"), "Order name 634", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 149.892571543077m, "усл. ед" },
                    { new Guid("4e6086d9-53b4-4d75-9db6-c68afd0e2e0d"), "Order name 2290", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 24.1907656116453m, "усл. ед" },
                    { new Guid("4e632b47-2901-4942-bea1-5c326a850442"), "Order name 2", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 250.750093386831m, "усл. ед" },
                    { new Guid("4e8924fd-5267-4265-8417-f66de2b705e5"), "Order name 1324", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 188.374587165281m, "усл. ед" },
                    { new Guid("4ea5b173-9510-4060-8d21-e9c41e5de127"), "Order name 353", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 32.8174241840523m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("4eb0cf0e-955c-409c-8268-07ff4966f70e"), "Order name 1388", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 383.241247658061m, "усл. ед" },
                    { new Guid("4ecd9325-9864-4b1d-ad20-c040cd5c88be"), "Order name 1631", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 147.678447175376m, "усл. ед" },
                    { new Guid("4f17728b-3ef0-4b77-b1e1-a927bf04de6f"), "Order name 730", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 192.565254139177m, "усл. ед" },
                    { new Guid("4f216ffe-05be-41cd-83c0-de065eac4763"), "Order name 531", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 48.7464004050267m, "усл. ед" },
                    { new Guid("4f75ac22-d281-4679-9041-e83785e29044"), "Order name 595", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 156.964428514174m, "усл. ед" },
                    { new Guid("4f9370bb-d953-4971-8e7c-78cca470332e"), "Order name 2329", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 180.537725791524m, "усл. ед" },
                    { new Guid("4faa153a-ce3f-42cb-a5ae-696088966a18"), "Order name 2295", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 224.944247345112m, "усл. ед" },
                    { new Guid("4fb195f7-457e-4ca2-965b-1924bf44e2b2"), "Order name 1838", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 278.586126019441m, "усл. ед" },
                    { new Guid("4fba176a-93db-463d-bc5a-86bc93287aea"), "Order name 1015", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 96.3392281273022m, "усл. ед" },
                    { new Guid("4fcd4f3a-28cb-4ad8-9117-8e8c26c04573"), "Order name 678", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 154.016426388285m, "усл. ед" },
                    { new Guid("4fd35175-03da-4e42-9d11-a125471d549c"), "Order name 1990", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 449.551441629701m, "усл. ед" },
                    { new Guid("4fd5bb86-e504-4c7e-91cd-2a7f0f8e45e4"), "Order name 1366", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 440.091676352596m, "усл. ед" },
                    { new Guid("4fdb31f7-170b-4fcc-890e-96136a772125"), "Order name 2016", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 94.1351503192248m, "усл. ед" },
                    { new Guid("50205bb0-ba9e-4916-a994-25de7f4911ff"), "Order name 243", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 163.087681061698m, "усл. ед" },
                    { new Guid("5025e014-8e57-4e5b-a077-cf30ad03b012"), "Order name 828", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 40.7407910482904m, "усл. ед" },
                    { new Guid("50625626-fad0-4cf9-9b68-54aaa747c13d"), "Order name 2046", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 197.725673734202m, "усл. ед" },
                    { new Guid("5070a4cc-9097-41b3-a8a1-8e4403074ada"), "Order name 2018", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 152.180184297884m, "усл. ед" },
                    { new Guid("50907af5-db12-4ad0-a2bf-7eeae7490f1d"), "Order name 2165", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 65.1536525494112m, "усл. ед" },
                    { new Guid("5099ecab-a7a9-4e8e-8513-83733f1684b3"), "Order name 723", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 82.0203364693786m, "усл. ед" },
                    { new Guid("50b734cf-7fb8-4cfb-a81f-e7547da1469b"), "Order name 905", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 794.970012044698m, "усл. ед" },
                    { new Guid("50bb4d15-ecaa-4fd9-b0de-be26d909ccc8"), "Order name 83", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 239.115325872214m, "усл. ед" },
                    { new Guid("50e3bcdc-73bc-4a5c-8105-785c4d530467"), "Order name 458", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 241.635389682767m, "усл. ед" },
                    { new Guid("50f4f3b2-5411-4578-ba6c-56be43eb6686"), "Order name 664", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 271.585769858989m, "усл. ед" },
                    { new Guid("50f56c1b-9f13-49bf-9dfc-fa38335e337a"), "Order name 1801", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 141.545603883301m, "усл. ед" },
                    { new Guid("511615bd-1a8e-481f-99ff-a537b9edfea9"), "Order name 2274", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 133.126763756412m, "усл. ед" },
                    { new Guid("51585654-84c6-4640-abc6-cad98f4433e3"), "Order name 1851", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 360.438494298777m, "усл. ед" },
                    { new Guid("515e85e5-3607-446f-b09d-6d244daba3dd"), "Order name 335", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 534.732981557656m, "усл. ед" },
                    { new Guid("51b50b7f-2156-4818-ac18-3e6a1bd63d1f"), "Order name 1296", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 511.785039427364m, "усл. ед" },
                    { new Guid("51e967fd-fc78-4c26-b752-0f86467ecd5e"), "Order name 2033", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 127.264377491012m, "усл. ед" },
                    { new Guid("520d836a-ef23-419c-8b1d-5f68359e4760"), "Order name 1665", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 55.1967617851963m, "усл. ед" },
                    { new Guid("525a2001-b215-4ad0-beb3-88d3eaefa58d"), "Order name 827", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 476.774429637889m, "усл. ед" },
                    { new Guid("5270f01a-6027-4a96-95e9-985499fa69fe"), "Order name 1123", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 251.255525082378m, "усл. ед" },
                    { new Guid("529d393f-63e2-45fc-b6be-2dfe46cd3db4"), "Order name 66", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 518.812728523816m, "усл. ед" },
                    { new Guid("52dc23c3-f354-4764-b605-0d842e4e70ce"), "Order name 1100", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 131.189432768121m, "усл. ед" },
                    { new Guid("5316b843-51c9-4674-bb4a-82105b21ccff"), "Order name 1373", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 538.14388063682m, "усл. ед" },
                    { new Guid("53310eb0-1a02-48ce-bd9e-a6d2f411c405"), "Order name 1859", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 42.932621238418m, "усл. ед" },
                    { new Guid("535a4fb8-7631-4e03-aff1-f2cc53236c3c"), "Order name 448", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 380.869227235961m, "усл. ед" },
                    { new Guid("539f527b-09f3-4ff9-8f4f-0edfea42b4c2"), "Order name 936", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 84.9039896113686m, "усл. ед" },
                    { new Guid("53aa364c-a130-4494-838c-b5f249ffcf0e"), "Order name 1814", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 134.76539922778m, "усл. ед" },
                    { new Guid("53b83884-47c7-409d-92b1-950aca380a6c"), "Order name 271", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 623.998291930223m, "усл. ед" },
                    { new Guid("53c68bbb-c133-47fa-bf2c-bf6cbc9f8546"), "Order name 979", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 94.1234519822629m, "усл. ед" },
                    { new Guid("53c9f3e7-f2e9-4116-a6e5-b9bf24686162"), "Order name 1259", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 358.788687472918m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("53e8603f-5be9-487d-81a9-b60150105624"), "Order name 1367", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 55.8581574881115m, "усл. ед" },
                    { new Guid("5407e1a8-11cb-48db-b415-9dee2b61e487"), "Order name 1843", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 451.980295035399m, "усл. ед" },
                    { new Guid("5410a0b7-9c73-4fb9-99d0-f2ec62c965d5"), "Order name 1856", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 5.4891389046745m, "усл. ед" },
                    { new Guid("54384381-fb0d-41b9-85a4-6a175ba24659"), "Order name 5", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 395.592878704945m, "усл. ед" },
                    { new Guid("5449fa05-0186-44ae-991c-e29440848405"), "Order name 131", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 40.7566653042794m, "усл. ед" },
                    { new Guid("5456a02b-4a82-459c-acc4-47e42d5fc398"), "Order name 273", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 271.245144598144m, "усл. ед" },
                    { new Guid("547b9c7c-f1e1-4770-81e8-d671d2f42010"), "Order name 2260", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 98.0209476974324m, "усл. ед" },
                    { new Guid("54b7af70-e470-4798-9a82-9447cd4e275c"), "Order name 1576", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 155.612496884325m, "усл. ед" },
                    { new Guid("54ebce93-1c57-40e8-a4bc-158d3e7c6a55"), "Order name 2361", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 254.682115569485m, "усл. ед" },
                    { new Guid("54ef99d4-84c4-4615-90a3-2c7ab90b6fb6"), "Order name 378", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 119.020538429962m, "усл. ед" },
                    { new Guid("54fc01bd-408d-43c2-8ede-6cd4e05de146"), "Order name 512", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 354.332144492188m, "усл. ед" },
                    { new Guid("5501225d-0560-40e3-b900-a8b9a73c7f6f"), "Order name 494", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 190.192328333904m, "усл. ед" },
                    { new Guid("552d967f-022c-48a9-bad3-21f803266182"), "Order name 2292", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 140.924020596902m, "усл. ед" },
                    { new Guid("55377d2f-bb91-4e27-bb83-04063aee89ec"), "Order name 262", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 903.139558146093m, "усл. ед" },
                    { new Guid("5557be34-5520-43b3-90f7-bfc6b2a937d9"), "Order name 485", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 0.624209646051492m, "усл. ед" },
                    { new Guid("555a2fda-1a98-42be-b9d3-388af1113e19"), "Order name 69", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 76.9131503584462m, "усл. ед" },
                    { new Guid("557ca2fe-7049-4911-80ab-bd16fdfc52a8"), "Order name 2404", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 562.6483686853m, "усл. ед" },
                    { new Guid("55a1327c-92bc-4499-8cfe-96aaa36547aa"), "Order name 159", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 159.683913108058m, "усл. ед" },
                    { new Guid("55a56377-da90-415c-8c58-f9d999f57e47"), "Order name 833", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 51.7797473801045m, "усл. ед" },
                    { new Guid("55b7e6c7-ba4d-4a88-9ca1-b6ab059c4cef"), "Order name 2009", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 2.81184765971675m, "усл. ед" },
                    { new Guid("55de2d1f-60b4-40c4-af63-a4d3a33be102"), "Order name 280", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 100.172894187999m, "усл. ед" },
                    { new Guid("56654f6b-28da-4669-a8fb-0e1bccce270d"), "Order name 1221", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 383.446265675185m, "усл. ед" },
                    { new Guid("5679a5ac-2642-4e22-8701-8b1633242d98"), "Order name 1356", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 197.915358520199m, "усл. ед" },
                    { new Guid("56826478-8707-41df-869c-c714bdf9514d"), "Order name 237", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 599.430564973774m, "усл. ед" },
                    { new Guid("5695835f-db04-4e9d-a80e-051e7248a527"), "Order name 1204", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 12.0727612137383m, "усл. ед" },
                    { new Guid("569a94f7-608d-4aad-80cb-d7fe22cbbf41"), "Order name 1346", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 274.336135285542m, "усл. ед" },
                    { new Guid("56a97307-9b7d-46d3-bdd0-da0ed9e93b15"), "Order name 1941", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 687.092799769808m, "усл. ед" },
                    { new Guid("5734d4e7-7107-4ffc-a0f5-473ca0049696"), "Order name 1305", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 395.67060815832m, "усл. ед" },
                    { new Guid("577092c9-aa29-4c30-b921-c0d158acc3a0"), "Order name 408", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 255.942639589614m, "усл. ед" },
                    { new Guid("58013aff-e33f-466b-a2ab-e8beb1badaf9"), "Order name 1127", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 20.2440088849332m, "усл. ед" },
                    { new Guid("580cfc41-bc35-498a-b338-712209a3a96d"), "Order name 171", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 221.397335864688m, "усл. ед" },
                    { new Guid("5817140c-1d18-462d-82b0-a6e1296ad1ac"), "Order name 140", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 488.618960057842m, "усл. ед" },
                    { new Guid("582cbc3d-7f8e-4dec-abeb-07f301d03e3f"), "Order name 1866", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 221.017592165736m, "усл. ед" },
                    { new Guid("583921c2-22cd-46d6-9074-bb9cf29ef3d8"), "Order name 1189", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 902.098428675077m, "усл. ед" },
                    { new Guid("583dfc0b-cae6-4948-ba57-2c8cbfa2d3f5"), "Order name 596", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 297.978169377996m, "усл. ед" },
                    { new Guid("58464870-4a8c-4d8a-8cbc-7a91737714e9"), "Order name 1668", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 211.693507399179m, "усл. ед" },
                    { new Guid("5858a839-049b-4a35-b960-128053df7777"), "Order name 272", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 339.782174464232m, "усл. ед" },
                    { new Guid("588055ad-0de7-4fed-b5c6-33132301b753"), "Order name 142", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 564.510087805079m, "усл. ед" },
                    { new Guid("588bc6fa-80e6-4ebc-81f8-4b9e657bf1f6"), "Order name 235", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 541.207752782298m, "усл. ед" },
                    { new Guid("58aad8c6-7ce2-4391-bd40-8902e810723b"), "Order name 899", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 93.8593705154654m, "усл. ед" },
                    { new Guid("58e4cc10-1f44-4025-ae6a-ed28b66963d2"), "Order name 977", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 590.825741493564m, "усл. ед" },
                    { new Guid("58eb5839-4cc4-4b82-879a-9bdf1d5ba50e"), "Order name 1606", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 282.393737078899m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("590d9861-2d5f-43a7-8207-dee23c9a5f4a"), "Order name 1248", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 169.464082414577m, "усл. ед" },
                    { new Guid("591c8eeb-681b-45fe-a701-f233b8601daa"), "Order name 1224", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 53.8747012348618m, "усл. ед" },
                    { new Guid("591d5878-d9e9-468e-9066-9b633cea6946"), "Order name 1148", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 11.2031624296394m, "усл. ед" },
                    { new Guid("592dcd76-c6bf-48e4-84aa-41602d91d729"), "Order name 535", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 708.01050218522m, "усл. ед" },
                    { new Guid("59384444-d89a-43fd-8d90-9b358d59b191"), "Order name 2096", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 107.781840296698m, "усл. ед" },
                    { new Guid("593c22fb-2b0d-4a07-bebd-ebbb33cd7e79"), "Order name 2352", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 131.906060718433m, "усл. ед" },
                    { new Guid("5946ad22-1ba5-4bc8-ac61-4a04429f4b15"), "Order name 1258", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 247.018916892224m, "усл. ед" },
                    { new Guid("59657796-dab8-4c4e-8dba-4386a5238d3e"), "Order name 1170", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 334.974268397111m, "усл. ед" },
                    { new Guid("59705217-6c45-4c45-88c6-c384817f9c50"), "Order name 1997", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 47.8943925470971m, "усл. ед" },
                    { new Guid("5976608c-cfb1-413c-b33a-2578d5191f57"), "Order name 1256", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 577.278081358448m, "усл. ед" },
                    { new Guid("599ee65f-9a81-4bda-a7a4-dd81fd9b6ac8"), "Order name 177", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 203.950175204066m, "усл. ед" },
                    { new Guid("5a104114-8c41-4a23-a2f9-72a38033ec20"), "Order name 290", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 364.658114556031m, "усл. ед" },
                    { new Guid("5a16e59f-3960-49ff-84e0-bbfd4edfd71a"), "Order name 1087", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 138.708333467218m, "усл. ед" },
                    { new Guid("5a314010-c6e4-4fa6-baad-8d2cd802d65e"), "Order name 1644", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 333.701872484567m, "усл. ед" },
                    { new Guid("5a3cc180-0693-45fd-9ea2-a0551677359e"), "Order name 1827", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 46.1057401032179m, "усл. ед" },
                    { new Guid("5a50b0f3-1c7d-4eb2-8bfe-51c5bdc2fbf3"), "Order name 1871", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 24.0659156247311m, "усл. ед" },
                    { new Guid("5a72fd81-1c99-43fa-9a4b-9bbcd77179ec"), "Order name 85", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 299.46871769311m, "усл. ед" },
                    { new Guid("5a7e9f63-a243-4f4a-9888-9fd5dafdd7ce"), "Order name 2460", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 8.11924818352788m, "усл. ед" },
                    { new Guid("5ab1391d-5ee7-4484-9d2d-29ec914108ac"), "Order name 1797", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 186.922164214612m, "усл. ед" },
                    { new Guid("5acea618-7d29-420a-b1c9-6f07229b64e4"), "Order name 1600", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 322.780544331687m, "усл. ед" },
                    { new Guid("5ad4261e-dc93-40b8-aa94-32e433961f6f"), "Order name 1048", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 120.803776933731m, "усл. ед" },
                    { new Guid("5ad71012-3b70-4fde-987f-dbc534c649ee"), "Order name 55", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 347.581270522771m, "усл. ед" },
                    { new Guid("5afd9938-457d-4a88-9102-f8b843226cd2"), "Order name 1528", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 162.105393772393m, "усл. ед" },
                    { new Guid("5b0c4fe1-849d-4880-8b33-c353cc679c8e"), "Order name 1703", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 852.726601263074m, "усл. ед" },
                    { new Guid("5b100e96-d83a-4385-80be-4a0b835187fe"), "Order name 933", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 81.971617996327m, "усл. ед" },
                    { new Guid("5b13bab9-d6a2-4b26-97e2-c0968cdaffcd"), "Order name 281", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 137.587903791511m, "усл. ед" },
                    { new Guid("5b312f4a-e2f7-48cf-9bd5-07208bfdebfc"), "Order name 278", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 89.094519542812m, "усл. ед" },
                    { new Guid("5b6e8cb3-71c4-438a-a24c-dc57359dabc1"), "Order name 1284", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 169.751412970587m, "усл. ед" },
                    { new Guid("5b73dbb4-c08e-47c9-9fb2-7fa96df114c4"), "Order name 1522", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 231.737899454253m, "усл. ед" },
                    { new Guid("5b875032-c278-435f-b3c1-1c2bbd927f12"), "Order name 948", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 384.566369271158m, "усл. ед" },
                    { new Guid("5b8c2a46-e5e6-4a72-a52c-6b48811557cb"), "Order name 1870", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 540.436587645897m, "усл. ед" },
                    { new Guid("5ba96b27-674d-4cd3-a7f0-3e3eff05e5df"), "Order name 2441", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 540.560707036575m, "усл. ед" },
                    { new Guid("5badf873-1dd1-4b50-b6ba-b27210a4072d"), "Order name 1608", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 465.207307135183m, "усл. ед" },
                    { new Guid("5bbc2faa-2bf5-4144-ae22-54a26baece70"), "Order name 728", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 150.37666505126m, "усл. ед" },
                    { new Guid("5be32d93-293e-42b3-aa14-8fa96defa68a"), "Order name 917", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 285.230206134962m, "усл. ед" },
                    { new Guid("5bfbbe05-2422-4a86-98f7-68cbceb2fa1f"), "Order name 529", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 190.617734707102m, "усл. ед" },
                    { new Guid("5c2a4659-24b4-481a-886d-8afbeea524de"), "Order name 2471", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 151.899305163321m, "усл. ед" },
                    { new Guid("5c41d63d-33f5-4c24-94c0-e2b4d95b4741"), "Order name 1977", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 314.817133187521m, "усл. ед" },
                    { new Guid("5c41e1d5-fc4c-4ec1-9e21-7d3603fdc9e7"), "Order name 1507", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 323.595484248188m, "усл. ед" },
                    { new Guid("5c4290cf-25f3-4b2a-a87c-9fc3e363caec"), "Order name 79", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 230.154775399999m, "усл. ед" },
                    { new Guid("5c6c6809-0b8c-42ba-90d5-c07bcba044a6"), "Order name 2299", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 266.438710952003m, "усл. ед" },
                    { new Guid("5cb3008b-76f8-425b-8577-c96c042013c3"), "Order name 2239", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 821.286642097037m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("5cbd2af4-7559-44ba-b83b-94dd30b842a5"), "Order name 1347", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 16.2548473728442m, "усл. ед" },
                    { new Guid("5ceb0f01-f88b-4b72-9528-f9135511cbdf"), "Order name 2485", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 169.761963023885m, "усл. ед" },
                    { new Guid("5cf37d49-dd74-4506-910a-dc3c5e84d953"), "Order name 1932", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 814.239561357709m, "усл. ед" },
                    { new Guid("5d243432-91c3-4301-b0ab-a4784dc25d04"), "Order name 2257", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 458.765001252037m, "усл. ед" },
                    { new Guid("5d41c3ad-19ec-4d51-b482-0002dae479c5"), "Order name 47", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 90.0311248659626m, "усл. ед" },
                    { new Guid("5d4fb5e3-a825-426d-a9c4-0183e3c0c22a"), "Order name 1575", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 319.709056186343m, "усл. ед" },
                    { new Guid("5d79c2bf-e3f0-42ab-9750-993618ae0892"), "Order name 1729", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 836.685068902768m, "усл. ед" },
                    { new Guid("5d7c4d36-5295-4225-aead-ac55d35e2b1c"), "Order name 1453", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 95.3249292252728m, "усл. ед" },
                    { new Guid("5da476c9-e505-4b3f-8318-3c9d1eb322cb"), "Order name 1675", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 32.4677392383471m, "усл. ед" },
                    { new Guid("5dd13d52-d992-4891-ad55-d4717688db94"), "Order name 1407", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 715.974649653281m, "усл. ед" },
                    { new Guid("5dd21411-808e-412b-a1ee-3be30755d82d"), "Order name 1067", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 119.8138655145m, "усл. ед" },
                    { new Guid("5ddb6969-2169-46c9-9122-b2ecb84f456a"), "Order name 2135", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 433.642630746871m, "усл. ед" },
                    { new Guid("5de14d55-7cf0-4ac1-8e6a-5085b2bb8d88"), "Order name 2344", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 6.92499343349006m, "усл. ед" },
                    { new Guid("5de5695e-b19e-467a-9b29-18aa312b79b7"), "Order name 903", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 480.900638891605m, "усл. ед" },
                    { new Guid("5de8319e-502d-4ad0-8890-68d1b14a43ca"), "Order name 162", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 144.556775600979m, "усл. ед" },
                    { new Guid("5e060efa-f9e1-4a9e-bb28-c6e069cd52b3"), "Order name 202", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 433.129537711552m, "усл. ед" },
                    { new Guid("5e0dcca4-d374-4740-b8df-222726843927"), "Order name 1806", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 328.555792304279m, "усл. ед" },
                    { new Guid("5e22d55e-3b3a-430e-b919-641a2f2e1067"), "Order name 2040", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 660.006593153283m, "усл. ед" },
                    { new Guid("5e565db7-bae1-4649-af9f-0f473d4bac8b"), "Order name 1879", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 309.227578810445m, "усл. ед" },
                    { new Guid("5e59d6fd-579a-4f1b-9a69-339768b90d4e"), "Order name 495", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 78.5788266725864m, "усл. ед" },
                    { new Guid("5e6199d4-304a-4f27-bc3e-a14f9338c21e"), "Order name 945", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 183.395369444988m, "усл. ед" },
                    { new Guid("5eeca36e-c508-4147-b33c-a8b48162e9e6"), "Order name 1552", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 112.715397507523m, "усл. ед" },
                    { new Guid("5f125ee7-b240-411c-93e1-f65d5b0ea212"), "Order name 2133", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 511.750592766774m, "усл. ед" },
                    { new Guid("5f1d0686-54da-429b-8266-c25622e21ed3"), "Order name 174", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 272.131350848798m, "усл. ед" },
                    { new Guid("5f24cf7e-19e8-412c-8338-f8756a067c83"), "Order name 2499", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 581.68407238517m, "усл. ед" },
                    { new Guid("5f3bfa21-a692-4178-8673-2c0cf842f1f8"), "Order name 2125", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 581.596173088584m, "усл. ед" },
                    { new Guid("5f480664-de22-4815-8bc0-2d456ba94632"), "Order name 1455", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 209.52633770536m, "усл. ед" },
                    { new Guid("5f4915e0-bfb2-4c14-9bcf-77362e28979c"), "Order name 366", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 186.342788200089m, "усл. ед" },
                    { new Guid("5f514c1a-6ea7-443e-8931-455595883de3"), "Order name 1393", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 40.8733074160607m, "усл. ед" },
                    { new Guid("5f545a27-af24-4533-a9e4-cbe22d637d2f"), "Order name 2368", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 556.516853587486m, "усл. ед" },
                    { new Guid("5f6ff80d-0779-49e8-8855-2b470442f575"), "Order name 28", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 99.3876177856592m, "усл. ед" },
                    { new Guid("5f7e9dfc-f7e4-42a1-a414-4f93968d41f6"), "Order name 562", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 247.671014909384m, "усл. ед" },
                    { new Guid("5fa69579-31a8-44f8-9576-4bf7f12b6269"), "Order name 2195", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 393.933244857888m, "усл. ед" },
                    { new Guid("5fe060c1-f049-461d-a668-ab088cc71c70"), "Order name 88", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 225.362261512175m, "усл. ед" },
                    { new Guid("5fe25373-2520-426c-9ac8-be9854f2f468"), "Order name 1222", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 28.9987233075068m, "усл. ед" },
                    { new Guid("6027a363-d08c-4920-85e3-0e8d5055f467"), "Order name 111", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 240.505942139326m, "усл. ед" },
                    { new Guid("603c5ba0-d1de-47dd-ac72-08acd2e312e3"), "Order name 2413", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 291.727887607106m, "усл. ед" },
                    { new Guid("605ebbb5-510d-4a5e-b2de-b81bcd6fda05"), "Order name 1182", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 234.48363991302m, "усл. ед" },
                    { new Guid("606cd734-bd71-4ac9-8341-9619273319b9"), "Order name 227", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 357.5310980902m, "усл. ед" },
                    { new Guid("6082e956-4128-4a7a-8613-146246254e7c"), "Order name 56", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 107.525757355632m, "усл. ед" },
                    { new Guid("60895f9a-86e0-4b17-9b8f-bf643a1ac52a"), "Order name 1885", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 319.021852079641m, "усл. ед" },
                    { new Guid("60c45553-5a86-475b-897d-c6ec75b2ae28"), "Order name 671", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 163.193964575179m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("60ea13e9-9ec3-426e-828d-3d2bb988e3b2"), "Order name 497", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 227.930282212684m, "усл. ед" },
                    { new Guid("60f29b6e-dd79-407a-937f-690df814b713"), "Order name 631", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 168.079397071677m, "усл. ед" },
                    { new Guid("60f5b95b-a33d-4ac6-8f55-77b093f16062"), "Order name 2129", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 22.7287666969726m, "усл. ед" },
                    { new Guid("61031e0b-749d-44fb-8b4e-f554f43d7869"), "Order name 1559", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 9.43709804574563m, "усл. ед" },
                    { new Guid("610da39f-77c5-466b-bd8c-d34f7f66a856"), "Order name 530", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 274.77332873569m, "усл. ед" },
                    { new Guid("61194a90-369f-4922-bfdc-878c94ef3dcd"), "Order name 1935", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 659.584183541903m, "усл. ед" },
                    { new Guid("611e1019-68ee-4555-a386-caf160bb7211"), "Order name 362", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 145.185067517493m, "усл. ед" },
                    { new Guid("617e345b-2a90-43a3-be69-8724f264c105"), "Order name 789", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 206.182472998007m, "усл. ед" },
                    { new Guid("61a8db48-89a9-4448-a47b-356b66691047"), "Order name 2495", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 132.690831231792m, "усл. ед" },
                    { new Guid("61f9ea4b-41dc-4565-a3f0-172510df65be"), "Order name 1621", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 256.748965811635m, "усл. ед" },
                    { new Guid("6215f858-7d01-4088-88ea-3b1fab8a24f8"), "Order name 44", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 29.9766535127321m, "усл. ед" },
                    { new Guid("621d2ff8-1faf-434e-a1bf-68e554430f3f"), "Order name 2030", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 179.084252718972m, "усл. ед" },
                    { new Guid("622f8ffe-ba8a-4244-a581-7bcfd52a3ffb"), "Order name 642", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 819.623278930639m, "усл. ед" },
                    { new Guid("6235eeee-4f1a-462d-9871-1963a6fec2b2"), "Order name 161", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 485.404072691127m, "усл. ед" },
                    { new Guid("62589a8b-82e7-4fbf-bde0-80dba7338a11"), "Order name 1607", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 102.917723894848m, "усл. ед" },
                    { new Guid("6262967e-947c-4ca1-b4a9-998a3c4db75b"), "Order name 1638", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 27.2387606842134m, "усл. ед" },
                    { new Guid("62826c74-6357-454e-beb9-d64d2cb34055"), "Order name 1003", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 29.8578546117196m, "усл. ед" },
                    { new Guid("62a17ae2-d872-4b54-9370-2308db60fe2d"), "Order name 582", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 646.953573936409m, "усл. ед" },
                    { new Guid("62d7ee4a-84ad-49a5-8da7-4d9224ed0522"), "Order name 359", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 411.446112971103m, "усл. ед" },
                    { new Guid("634b31f9-f212-40b7-964a-0b6bb03b3474"), "Order name 2093", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 340.602700524736m, "усл. ед" },
                    { new Guid("6365a4a0-ab61-4bce-8af9-d4f47de51b1c"), "Order name 474", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 193.620819768105m, "усл. ед" },
                    { new Guid("636bf59d-4fd7-411d-a8f0-1ee57a1805b6"), "Order name 1215", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 98.5458602314484m, "усл. ед" },
                    { new Guid("638bb504-6704-4c02-bbdc-caa561ad711e"), "Order name 1400", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 628.577905014672m, "усл. ед" },
                    { new Guid("63cb0261-ae7c-4c0b-ba1a-1d4614ce12de"), "Order name 2241", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 401.980146015753m, "усл. ед" },
                    { new Guid("63e66a17-eff4-4af4-83b0-9ca77ab3c789"), "Order name 1855", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 34.7267204576405m, "усл. ед" },
                    { new Guid("642cdc3c-0d08-4e46-be6b-0b57e80b3cc1"), "Order name 476", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 133.945818243629m, "усл. ед" },
                    { new Guid("643f94e4-4e98-4498-9c0f-6b0f7a2da661"), "Order name 360", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 157.848134726349m, "усл. ед" },
                    { new Guid("644fed00-9ec3-45aa-9d4b-8e5357033aff"), "Order name 1762", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 451.050977915175m, "усл. ед" },
                    { new Guid("6463feb1-78ed-4333-bb1d-597d6f3e0135"), "Order name 487", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 81.7652387475321m, "усл. ед" },
                    { new Guid("64775065-26d2-4ba2-b32c-5f5e96c0dc0c"), "Order name 1565", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 496.470359036894m, "усл. ед" },
                    { new Guid("64a88a1c-e5ff-4496-9784-fe743a80ddd0"), "Order name 601", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 742.192659417162m, "усл. ед" },
                    { new Guid("64defce8-bbad-439d-b3b9-e66acc953fa8"), "Order name 263", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 236.445116017133m, "усл. ед" },
                    { new Guid("64e2f696-e383-4f00-a176-1ff6b439612e"), "Order name 488", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 125.413076553376m, "усл. ед" },
                    { new Guid("64e99743-7a07-4e8c-9d47-666900f95b29"), "Order name 1833", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 176.899444827151m, "усл. ед" },
                    { new Guid("64ee5f1b-e4f7-47c7-87b3-480e7ae72335"), "Order name 2182", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 183.226522392988m, "усл. ед" },
                    { new Guid("6507e2ec-6217-4d83-ade8-950bf73526d9"), "Order name 1913", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 650.278552693455m, "усл. ед" },
                    { new Guid("6510648a-bd5a-44ec-999c-7c67bbf54094"), "Order name 1082", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 314.356684048665m, "усл. ед" },
                    { new Guid("651ccb07-0b6e-49af-8c4d-b8fed5292f4c"), "Order name 887", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 165.693027585699m, "усл. ед" },
                    { new Guid("6551c945-67f3-47ff-9e0f-12d8250db68c"), "Order name 1690", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 256.721512256251m, "усл. ед" },
                    { new Guid("655d5cf5-7c3a-41f1-a872-8bb728c2e82f"), "Order name 1134", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 469.592775843133m, "усл. ед" },
                    { new Guid("656319bd-d94e-467b-9dab-eb83657cfd27"), "Order name 134", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 29.6870900644602m, "усл. ед" },
                    { new Guid("658796ee-5240-4414-9df1-4a05865dd6ca"), "Order name 832", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 77.3664584018571m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("65907a18-17a5-42b4-95fe-01048ec04e8c"), "Order name 660", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 251.778181293353m, "усл. ед" },
                    { new Guid("65c7a8e7-8566-4a85-9904-3ae8adbc9451"), "Order name 12", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 370.671374590416m, "усл. ед" },
                    { new Guid("65d30800-f955-435b-b59f-eb358e76448a"), "Order name 2102", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 20.5896243593296m, "усл. ед" },
                    { new Guid("660e4dad-52fd-402b-9fe7-e47929c8b098"), "Order name 854", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 173.744250985674m, "усл. ед" },
                    { new Guid("661cb894-8e67-4e46-8576-2f34c24e2119"), "Order name 1726", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 385.837548245534m, "усл. ед" },
                    { new Guid("664f8622-73f5-4dd5-8d36-1d84877b5b61"), "Order name 2223", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 127.169350954368m, "усл. ед" },
                    { new Guid("66a38b71-6cc9-481c-a475-4ac6788c0d66"), "Order name 182", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 788.23593814218m, "усл. ед" },
                    { new Guid("66d162c3-08e2-4e15-bb22-d3566afe3361"), "Order name 1232", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 236.453763279404m, "усл. ед" },
                    { new Guid("66ea177d-bb92-4b1b-9004-0829659db502"), "Order name 1171", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 24.1902620394148m, "усл. ед" },
                    { new Guid("671a791d-de0d-429a-8f87-f2f2ba0f113d"), "Order name 1106", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 108.56495182766m, "усл. ед" },
                    { new Guid("671c3e58-33f1-4ab2-822d-a4fde20de4da"), "Order name 2221", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 264.354563223776m, "усл. ед" },
                    { new Guid("672878c1-54c1-4e81-97fe-bfbd4a127e2c"), "Order name 1960", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 458.057551940045m, "усл. ед" },
                    { new Guid("672ce338-12cf-4b03-9ee6-231a91eacbc7"), "Order name 1728", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 254.440456183747m, "усл. ед" },
                    { new Guid("672f8fc3-0dd3-436d-b3fd-01d331257452"), "Order name 1192", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 74.4042161050531m, "усл. ед" },
                    { new Guid("67361b5d-291f-4b48-8e71-0c6c8e9b45ac"), "Order name 61", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 386.724590419722m, "усл. ед" },
                    { new Guid("6753e645-517b-4d27-be9b-fd483df25080"), "Order name 1874", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 32.6170565887889m, "усл. ед" },
                    { new Guid("675fc3d2-6877-4fa6-8625-cc220b2db5d7"), "Order name 99", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 736.624828224886m, "усл. ед" },
                    { new Guid("67747efc-f485-4c6c-88c1-bc407b04bcc7"), "Order name 394", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 34.1343714315104m, "усл. ед" },
                    { new Guid("67912e84-aba8-4c4d-bac6-3a574a03ec8a"), "Order name 1465", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 329.733400864485m, "усл. ед" },
                    { new Guid("67ceabdd-180e-463a-b41a-46e19b19b6b4"), "Order name 555", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 99.5996364889032m, "усл. ед" },
                    { new Guid("67da7d9f-67b6-4620-b74b-a2e9a188e9bd"), "Order name 737", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 25.2546473743542m, "усл. ед" },
                    { new Guid("67e07bdb-c8cc-4570-881b-d0c65e9c9993"), "Order name 792", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 30.1238814435361m, "усл. ед" },
                    { new Guid("681bb612-be31-46cb-818b-e0a87acefcf7"), "Order name 9", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 306.270776789185m, "усл. ед" },
                    { new Guid("68231118-a221-46d2-be11-27249387b7cc"), "Order name 1686", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 286.487706772421m, "усл. ед" },
                    { new Guid("6828ba9e-1925-449f-b7de-d0a4be7861e3"), "Order name 603", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 290.397986373886m, "усл. ед" },
                    { new Guid("682e77f1-4f7c-4826-947d-7737dd1dd81a"), "Order name 639", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 246.455534151229m, "усл. ед" },
                    { new Guid("68671eb9-462f-41e6-949e-8d8e4897ac09"), "Order name 1261", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 142.034806041336m, "усл. ед" },
                    { new Guid("687b5c3b-7448-4291-ac72-c91210220818"), "Order name 2157", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 745.080784154153m, "усл. ед" },
                    { new Guid("688515aa-95f1-4b5c-9f70-3e622305ce5a"), "Order name 802", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 194.675117484793m, "усл. ед" },
                    { new Guid("68971e82-f968-4a78-9b1f-6c1a54a112c0"), "Order name 1051", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 212.887457181903m, "усл. ед" },
                    { new Guid("68d7c96c-51e9-4d1d-a79b-4e4ab11c17e5"), "Order name 2280", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 324.649433508035m, "усл. ед" },
                    { new Guid("690cb0d1-3c53-4283-8cda-af9f335f3127"), "Order name 1278", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 3.78323322441385m, "усл. ед" },
                    { new Guid("691baf1d-d666-489a-a097-0bde9e04111e"), "Order name 156", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 112.402494367534m, "усл. ед" },
                    { new Guid("6929c744-4a64-468f-8fc3-ba55c76bfb10"), "Order name 1310", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 279.130319573247m, "усл. ед" },
                    { new Guid("692f39c1-2623-45e2-8583-29276b973636"), "Order name 674", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 206.762767696068m, "усл. ед" },
                    { new Guid("6957f234-1998-4891-8ef1-2461418c4372"), "Order name 383", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 147.602703499576m, "усл. ед" },
                    { new Guid("69616039-3b22-4fd8-96e8-ed5f48b28ee8"), "Order name 1664", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 260.465629445611m, "усл. ед" },
                    { new Guid("697d5115-b49c-4f31-bf4d-2f82d96e36c1"), "Order name 130", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 246.95698942692m, "усл. ед" },
                    { new Guid("69869d73-187e-439a-a266-59f0945797d0"), "Order name 1024", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 123.154568162475m, "усл. ед" },
                    { new Guid("69948220-4000-40f9-b744-92c2085632c6"), "Order name 2175", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 492.16701396599m, "усл. ед" },
                    { new Guid("6999d344-6bb5-477a-a71a-6d3d77e0c5a8"), "Order name 768", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 2.89884997905663m, "усл. ед" },
                    { new Guid("69a69b4d-2c45-4eea-bc0c-bd40d8d8f586"), "Order name 1796", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 201.315764318809m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("69e89e2e-cd89-4c14-8abb-eb021b43567d"), "Order name 1412", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 292.436294047209m, "усл. ед" },
                    { new Guid("69eca20f-0673-4435-bc69-8510eda8df9a"), "Order name 950", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 62.6370946337073m, "усл. ед" },
                    { new Guid("69f3f498-c58e-42bb-9f25-69630136a44b"), "Order name 532", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 113.475769694508m, "усл. ед" },
                    { new Guid("69f9f41a-d0cd-4969-b9b1-d3f95c772fff"), "Order name 2362", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 468.203975867344m, "усл. ед" },
                    { new Guid("6a13dff2-32fa-4fe1-b59e-78e6c5e0c410"), "Order name 1132", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 126.782316148157m, "усл. ед" },
                    { new Guid("6a21ade6-800f-45ca-bfba-4cb74fc0099b"), "Order name 560", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 708.073281430289m, "усл. ед" },
                    { new Guid("6a4c2a52-bd32-4c39-8a0d-dcb6a297921e"), "Order name 1018", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 45.7363092656156m, "усл. ед" },
                    { new Guid("6a7168b5-cd68-4391-9171-e725000a6db8"), "Order name 403", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 103.71005543876m, "усл. ед" },
                    { new Guid("6a747517-a62d-418b-9c32-41b612114e59"), "Order name 1338", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 44.0160570041712m, "усл. ед" },
                    { new Guid("6a791826-e877-4cba-90c8-150a323ecc22"), "Order name 2214", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 222.375944115506m, "усл. ед" },
                    { new Guid("6a917d10-0dff-4cb3-b1c2-8b27fdb2f410"), "Order name 2054", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 538.38017269742m, "усл. ед" },
                    { new Guid("6a92760a-e171-4d49-a34b-c3c41b391bce"), "Order name 1043", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 213.591991214984m, "усл. ед" },
                    { new Guid("6ac39b7d-3c83-4583-b3e1-ed0cd016f6f6"), "Order name 1975", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 239.205806496716m, "усл. ед" },
                    { new Guid("6adfa25d-30df-4b8e-aa77-5d2588387bba"), "Order name 1088", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 226.478447170189m, "усл. ед" },
                    { new Guid("6af97d2b-24e9-47bc-be43-0677818fc236"), "Order name 75", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 118.455792597006m, "усл. ед" },
                    { new Guid("6afafe9d-9e34-4b0a-98d7-5cc814fd2b3d"), "Order name 1085", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 667.70472529168m, "усл. ед" },
                    { new Guid("6b09e232-51bb-4a62-b674-3fc31b99c687"), "Order name 796", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 61.7175874813246m, "усл. ед" },
                    { new Guid("6b2518ac-f5a6-4670-877f-24a6b99d23fa"), "Order name 993", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 202.938755738871m, "усл. ед" },
                    { new Guid("6b415ef6-d3ce-4c48-860c-3bb08c951fd1"), "Order name 1298", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 480.306296348573m, "усл. ед" },
                    { new Guid("6b585540-ba63-4e8a-8d22-c2d77fabc329"), "Order name 1490", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 102.326994645471m, "усл. ед" },
                    { new Guid("6b6fb30a-dc76-4099-9f45-8b0d6c18d5d8"), "Order name 439", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 149.238110831289m, "усл. ед" },
                    { new Guid("6b81b2d7-ea2d-4a7e-b359-8b58994a49bf"), "Order name 1953", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 630.676105063976m, "усл. ед" },
                    { new Guid("6b9dd652-6d4f-42d4-9b73-217e4cdbc6b6"), "Order name 2074", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 63.4823840446218m, "усл. ед" },
                    { new Guid("6b9ff7f4-d1ca-481e-9bac-340ad74e8b8e"), "Order name 953", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 147.164547521483m, "усл. ед" },
                    { new Guid("6ba52752-2ba5-4866-aa8f-cc0c68f83a7d"), "Order name 103", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 694.652812719922m, "усл. ед" },
                    { new Guid("6c13fa7e-d79b-4e09-9e79-b703103f2525"), "Order name 1570", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 743.397760825502m, "усл. ед" },
                    { new Guid("6c33c66c-508b-461e-916b-e4f08317b569"), "Order name 1319", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 139.558082182575m, "усл. ед" },
                    { new Guid("6c4e119a-0011-4c72-a9eb-7304c234a612"), "Order name 42", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 279.215535989225m, "усл. ед" },
                    { new Guid("6c647146-fc6d-4504-bce2-2f4bdb096a68"), "Order name 1392", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 156.566337127691m, "усл. ед" },
                    { new Guid("6c76fcb0-e52d-4054-8d47-e1d5f26bbd8c"), "Order name 465", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 59.8149935734473m, "усл. ед" },
                    { new Guid("6c7aef80-496f-4b2b-8d0b-6edcad56f1a4"), "Order name 113", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 135.657970666603m, "усл. ед" },
                    { new Guid("6c7c0ca5-92ea-4246-83fd-4a2d61e7052b"), "Order name 1266", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 578.935635926893m, "усл. ед" },
                    { new Guid("6c958c25-a600-48b7-a062-4a14a213227d"), "Order name 1611", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 484.051967524737m, "усл. ед" },
                    { new Guid("6cf27e12-e7fd-4586-917a-b8cc25061687"), "Order name 2230", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 1.98488400138662m, "усл. ед" },
                    { new Guid("6d14e58a-8668-45ba-8166-9ffdd0a9999f"), "Order name 1030", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 95.3730746707377m, "усл. ед" },
                    { new Guid("6d2f9c65-aa3b-4a1e-912d-3425a1a74a85"), "Order name 958", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 190.902413737551m, "усл. ед" },
                    { new Guid("6d40a151-4e71-41e8-9344-d7ad3b277916"), "Order name 1493", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 312.155594373748m, "усл. ед" },
                    { new Guid("6d67619e-f458-4878-99da-f411c29cda13"), "Order name 2228", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 186.921241772717m, "усл. ед" },
                    { new Guid("6d944f5a-beb4-4592-85b3-dce75b720e72"), "Order name 421", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 421.270692665697m, "усл. ед" },
                    { new Guid("6dbd907b-5b57-48eb-9442-a12de75aaef8"), "Order name 1508", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 88.7781555471792m, "усл. ед" },
                    { new Guid("6dbe386c-a347-488d-a1df-6618775e2441"), "Order name 1842", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 326.425269771125m, "усл. ед" },
                    { new Guid("6dc14e49-4281-43ea-8491-cf72648f3dac"), "Order name 348", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 29.2467726325509m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("6dd093dd-7ea0-4d62-8c0c-1d7012fe837e"), "Order name 541", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 46.9470703119828m, "усл. ед" },
                    { new Guid("6de6f428-57a1-41e7-be7a-4adbae1c9570"), "Order name 2168", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 519.103148996538m, "усл. ед" },
                    { new Guid("6dec4892-143e-46d0-a118-0fab1e83a8ff"), "Order name 1937", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 239.2143068367m, "усл. ед" },
                    { new Guid("6ded9fec-560b-4d7a-971c-c31721a40958"), "Order name 1249", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 92.4137295900436m, "усл. ед" },
                    { new Guid("6df27475-c2c5-4659-8752-cdc98463de3b"), "Order name 204", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 280.003424310897m, "усл. ед" },
                    { new Guid("6df9e74e-3ceb-4ed6-a5c9-3c330d72d367"), "Order name 1557", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 328.523623956639m, "усл. ед" },
                    { new Guid("6e487003-044f-40b2-8d69-29c946d85119"), "Order name 635", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 1.2256522381306m, "усл. ед" },
                    { new Guid("6e5bd5fe-cc2c-4ae6-8bd6-1617c626f393"), "Order name 1040", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 59.3590216837178m, "усл. ед" },
                    { new Guid("6e600775-c4b6-4fd6-9989-f3a3a01500e5"), "Order name 2488", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 68.1000552946818m, "усл. ед" },
                    { new Guid("6e8a0db5-1c08-4ed7-8c55-07a9c74b55c0"), "Order name 1869", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 54.4097581558763m, "усл. ед" },
                    { new Guid("6e90ceea-ef56-4912-aa5d-74a8cd35a973"), "Order name 1808", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 198.82899744791m, "усл. ед" },
                    { new Guid("6eb2714e-6e26-45d5-b744-bfedb5080c4f"), "Order name 2378", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 735.835951065159m, "усл. ед" },
                    { new Guid("6eb951f0-c5e4-4318-a095-4449d9de7c57"), "Order name 561", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 665.794180707359m, "усл. ед" },
                    { new Guid("6ebd91c9-3b94-42f4-ac99-1fa2d3ba4c4f"), "Order name 1748", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 40.3846426881697m, "усл. ед" },
                    { new Guid("6ed4b2cd-753c-4750-a1bc-63e01c128d4b"), "Order name 743", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 395.972075679941m, "усл. ед" },
                    { new Guid("6eeb1d3f-c46e-4db7-9880-5c257bb70925"), "Order name 2300", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 554.5969521245m, "усл. ед" },
                    { new Guid("6efe2765-901e-4b43-9551-bce5d15ae875"), "Order name 1774", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 588.783638522825m, "усл. ед" },
                    { new Guid("6f0ff877-e118-47d1-9c1b-8c01e77645a3"), "Order name 1094", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 287.195934260316m, "усл. ед" },
                    { new Guid("6f2a3f2e-faa0-49e4-8679-eb82d2af83aa"), "Order name 2191", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 240.710039108515m, "усл. ед" },
                    { new Guid("6f2c3e16-34bc-4c37-8c4d-821b0fd93abd"), "Order name 31", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 783.521880949129m, "усл. ед" },
                    { new Guid("6f3c433a-f305-4211-a863-7b227fef5440"), "Order name 333", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 305.52553293964m, "усл. ед" },
                    { new Guid("6f461430-5996-4dc7-b2e3-524cdce08e36"), "Order name 416", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 488.670951100929m, "усл. ед" },
                    { new Guid("6f76daae-39c1-449e-b9d5-14cbf41c5368"), "Order name 708", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 130.358542831326m, "усл. ед" },
                    { new Guid("6f8fdf35-8de7-4943-831f-36689032aaec"), "Order name 1771", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 401.312464142967m, "усл. ед" },
                    { new Guid("6f927c0a-f202-4ad7-9752-17b7bc668894"), "Order name 1708", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 131.100460427681m, "усл. ед" },
                    { new Guid("6fe7dc56-830d-4db1-afa8-371c899a118c"), "Order name 472", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 67.7870088408084m, "усл. ед" },
                    { new Guid("6ff9d7c5-e0b4-4e29-84a9-9c7fe4d47372"), "Order name 2044", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 191.389207585278m, "усл. ед" },
                    { new Guid("700e6be1-816e-4fd6-8d3b-314125d6fd53"), "Order name 1958", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 111.578898098902m, "усл. ед" },
                    { new Guid("7017d316-1012-4a77-9252-347c29ad0d89"), "Order name 1292", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 258.901181145108m, "усл. ед" },
                    { new Guid("701c1274-4faf-4080-be3f-b05a9622d94d"), "Order name 38", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 166.884374822051m, "усл. ед" },
                    { new Guid("702b49d3-e10b-4e94-9179-75623194cb8e"), "Order name 165", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 11.5611483738364m, "усл. ед" },
                    { new Guid("70381cb0-f6cc-4e65-99a4-bf36829b0f4b"), "Order name 1738", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 45.183350020808m, "усл. ед" },
                    { new Guid("7065c2b1-f055-47c2-b295-f89da37f7d98"), "Order name 51", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 446.528424902105m, "усл. ед" },
                    { new Guid("70b7ab3c-66c2-48d1-b170-7363156878cf"), "Order name 459", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 807.297459140686m, "усл. ед" },
                    { new Guid("70b9131f-575f-4328-bc15-56abc5929319"), "Order name 2090", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 587.086119324291m, "усл. ед" },
                    { new Guid("710ff5e4-6b56-429a-b1db-3d9584e970ee"), "Order name 2180", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 121.355717741915m, "усл. ед" },
                    { new Guid("71103a54-119b-4713-a3d8-640274a3c446"), "Order name 1914", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 586.047395272811m, "усл. ед" },
                    { new Guid("712648ad-e90f-44dd-8832-0e17842459d0"), "Order name 1444", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 90.1867422192257m, "усл. ед" },
                    { new Guid("712c7e50-9014-4b6e-89ed-d03b1d2dd89b"), "Order name 1562", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 109.683045362463m, "усл. ед" },
                    { new Guid("7142263a-f3a7-45d5-8897-a85f9f4871cd"), "Order name 609", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 385.620082397557m, "усл. ед" },
                    { new Guid("714eccf3-9e00-4bc7-884f-f2fc59468150"), "Order name 1208", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 449.415144428026m, "усл. ед" },
                    { new Guid("715c1950-cb56-4219-b1fb-147ef9d4ec13"), "Order name 586", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 659.74975550046m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("7163af11-def5-479e-a92d-a5a23e5b7096"), "Order name 2479", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 36.3914896581037m, "усл. ед" },
                    { new Guid("717090f2-be8c-4ee6-868c-e5936ac90616"), "Order name 767", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 727.292400285592m, "усл. ед" },
                    { new Guid("7184b117-944e-4ab7-8191-c85356e2845e"), "Order name 1511", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 1.72689202135731m, "усл. ед" },
                    { new Guid("718ed472-9d39-46ed-a946-fb9561dd1a58"), "Order name 696", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 667.382332889574m, "усл. ед" },
                    { new Guid("71dcc4a2-6859-45bf-9411-5337644aab5c"), "Order name 2384", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 34.3487544023633m, "усл. ед" },
                    { new Guid("71f69107-ae3c-48bb-94b5-86ab3abac239"), "Order name 1408", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 183.93889745284m, "усл. ед" },
                    { new Guid("71f9e6be-878c-45db-943d-96ca6eeba2db"), "Order name 1097", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 186.597117655461m, "усл. ед" },
                    { new Guid("72050a60-2c6c-4433-b634-f30e05629ec8"), "Order name 1168", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 51.5887361347458m, "усл. ед" },
                    { new Guid("721c6e03-9aec-465d-aeda-85927db8388c"), "Order name 2167", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 158.970494928272m, "усл. ед" },
                    { new Guid("725a9dbe-d642-4710-b204-a7c3df93ad6b"), "Order name 2219", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 417.691904931734m, "усл. ед" },
                    { new Guid("725d7fdf-56ab-4675-8133-eb04251f64e6"), "Order name 2380", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 465.362341709487m, "усл. ед" },
                    { new Guid("725f933f-906f-41ca-a9d9-0ad54e80280f"), "Order name 1163", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 205.47139208842m, "усл. ед" },
                    { new Guid("72aebc69-618b-4a94-bb1e-92450bcaa8cc"), "Order name 138", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 93.7721227592886m, "усл. ед" },
                    { new Guid("72e5aa02-1906-482f-a5e5-78cf6427f987"), "Order name 1968", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 268.99759411726m, "усл. ед" },
                    { new Guid("72f37cde-c562-40d4-9db7-16e230b601db"), "Order name 1489", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 98.5969896561058m, "усл. ед" },
                    { new Guid("72fd0d2d-2f60-4976-831c-8f0cf1367a80"), "Order name 186", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 566.654122653309m, "усл. ед" },
                    { new Guid("7305e81c-423f-44ac-b8d1-4c44d56f4d38"), "Order name 1129", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 495.425762411029m, "усл. ед" },
                    { new Guid("7358dfc0-4778-492a-8a1a-593408b9b583"), "Order name 1308", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 238.014694345143m, "усл. ед" },
                    { new Guid("73732d01-23f0-4fa4-9150-8229d6eb2810"), "Order name 2452", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 385.009277697225m, "усл. ед" },
                    { new Guid("73ac3f38-3ce2-45f9-8e44-e7a24b6d8963"), "Order name 1725", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 8.81968837270167m, "усл. ед" },
                    { new Guid("73b53b0f-60bc-40ea-80d9-470ebbcbe2f9"), "Order name 1255", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 177.294898959817m, "усл. ед" },
                    { new Guid("73c05c9f-42e2-4379-a1ac-df1f1b307cea"), "Order name 2120", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 14.374436363147m, "усл. ед" },
                    { new Guid("73e59fce-cbe6-42bc-bf0a-8ea50c1bd8a4"), "Order name 1086", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 142.307745070972m, "усл. ед" },
                    { new Guid("73ed3509-55d8-477c-9f97-9ec420c56a83"), "Order name 909", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 194.029997045074m, "усл. ед" },
                    { new Guid("73ef4ece-5e00-4d79-ac7f-21fa7c264585"), "Order name 1430", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 108.145268098437m, "усл. ед" },
                    { new Guid("73ff3050-bbb4-4121-b257-ef02d42a7bf6"), "Order name 2139", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 438.007886127433m, "усл. ед" },
                    { new Guid("73fffa0d-3131-41a6-9d12-becde1080503"), "Order name 2152", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 103.581541590591m, "усл. ед" },
                    { new Guid("7409db0f-9307-42f8-bb4f-68aebbdb25e5"), "Order name 1711", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 125.822196773178m, "усл. ед" },
                    { new Guid("74124eed-9c42-484e-b2f7-f86ac8c073fe"), "Order name 610", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 276.158947250684m, "усл. ед" },
                    { new Guid("7413871f-e257-4cd2-8dc1-47ad9fd1752c"), "Order name 1537", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 105.468844206968m, "усл. ед" },
                    { new Guid("7420ff63-76b0-443d-9c79-bea842465439"), "Order name 223", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 555.574327493749m, "усл. ед" },
                    { new Guid("74449430-789d-410d-a37b-a2e3e55cd11e"), "Order name 1348", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 246.005276882443m, "усл. ед" },
                    { new Guid("744f33b4-300b-4e1e-b577-79ed65e62e86"), "Order name 2298", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 745.046006068223m, "усл. ед" },
                    { new Guid("74583361-8b45-4ff3-9cac-ac3388611e6e"), "Order name 1723", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 129.330023776609m, "усл. ед" },
                    { new Guid("74732c69-a2cd-4b56-99d2-1f9a24e179e2"), "Order name 2448", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 369.51035651124m, "усл. ед" },
                    { new Guid("7474b1bb-b771-4806-b684-a74c8e7da054"), "Order name 2011", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 507.352587226456m, "усл. ед" },
                    { new Guid("748c147b-e64b-438e-916d-f947da0ac8b9"), "Order name 1754", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 137.806168873473m, "усл. ед" },
                    { new Guid("749ca25b-5047-4e5c-bddf-3cf0b3b52b60"), "Order name 2308", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 597.589343378506m, "усл. ед" },
                    { new Guid("74b4e48a-90f9-4c2e-84ab-55f63e952e2e"), "Order name 2369", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 276.652381893489m, "усл. ед" },
                    { new Guid("74d55ece-5f1c-4e83-ad77-3ea82dee034e"), "Order name 1454", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 280.304165812547m, "усл. ед" },
                    { new Guid("74e4baab-d5e6-41c8-aa7c-7fd1197fc7a4"), "Order name 1191", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 192.69631996542m, "усл. ед" },
                    { new Guid("7501c891-1e24-4fc6-895a-e190f7fa7600"), "Order name 2055", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 78.5141523863796m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("75096270-55f0-4f65-9ba2-ca46e7dbd530"), "Order name 354", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 21.054097129942m, "усл. ед" },
                    { new Guid("75163357-b87b-4c01-9cd4-df8ed8a3ece5"), "Order name 2144", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 505.092573874086m, "усл. ед" },
                    { new Guid("75390916-8e3d-4b2b-8f2f-0e658111545a"), "Order name 1144", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 77.9883232651711m, "усл. ед" },
                    { new Guid("7559f549-c45e-462a-b6f4-9289b5ac31e6"), "Order name 545", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 164.398890051866m, "усл. ед" },
                    { new Guid("75603ba8-d1f7-4896-a934-ded6fa0afd02"), "Order name 922", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 4.59186209287617m, "усл. ед" },
                    { new Guid("75d00e47-c573-4e70-b2a3-35fc3a043aa4"), "Order name 158", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 280.700023808361m, "усл. ед" },
                    { new Guid("76116547-ee24-4a7b-9d91-4fb1875a39b0"), "Order name 1429", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 108.327896431758m, "усл. ед" },
                    { new Guid("76256488-d49e-4963-9041-663ba83f4447"), "Order name 1792", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 339.545320794684m, "усл. ед" },
                    { new Guid("76698168-6459-4d82-a38c-5c286cca06c0"), "Order name 2382", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 582.781817794014m, "усл. ед" },
                    { new Guid("769bcb6b-0ce0-426d-a9b1-402f7b503af6"), "Order name 1734", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 154.98645195845m, "усл. ед" },
                    { new Guid("769fe22f-2327-4499-9143-ab9b113e34bc"), "Order name 94", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 526.56237326032m, "усл. ед" },
                    { new Guid("76be0800-2a7f-452a-ab11-e6546017ce84"), "Order name 438", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 465.690128971383m, "усл. ед" },
                    { new Guid("76d40bcf-cf2b-4157-b35f-0f2002107fab"), "Order name 2400", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 28.778413941721m, "усл. ед" },
                    { new Guid("770f9dc1-5ca4-456c-a0b1-cc38ee98a106"), "Order name 1279", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 331.534855110851m, "усл. ед" },
                    { new Guid("77174e21-eabc-4eb3-b415-c1339728b7c1"), "Order name 779", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 390.865436935079m, "усл. ед" },
                    { new Guid("77195650-10df-4dc6-a43e-bec18d43b992"), "Order name 1460", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 140.122818614296m, "усл. ед" },
                    { new Guid("773ac6b1-1525-4e4a-8664-9e152fee37fb"), "Order name 1996", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 186.359612942441m, "усл. ед" },
                    { new Guid("77593e01-fc88-43f6-a5ce-aca4819b4ff4"), "Order name 2119", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 255.674368728952m, "усл. ед" },
                    { new Guid("77650e63-cc79-4c11-a7c4-8f7ce922e7b0"), "Order name 982", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 25.338060909999m, "усл. ед" },
                    { new Guid("7783c641-4151-484f-9274-15209207d439"), "Order name 870", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 90.9883445494973m, "усл. ед" },
                    { new Guid("7794c2b5-95e4-4784-a952-422a8e34fa9b"), "Order name 698", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 128.97480076812m, "усл. ед" },
                    { new Guid("779716a8-8abb-46dd-a8a0-2c78120bc20b"), "Order name 432", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 304.677792925325m, "усл. ед" },
                    { new Guid("77e2dfa9-47d2-452b-b56c-953761f09119"), "Order name 1016", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 125.919972987689m, "усл. ед" },
                    { new Guid("77eb2c3b-d608-4644-8f93-333ecf097499"), "Order name 2359", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 58.180460717842m, "усл. ед" },
                    { new Guid("77fda73b-0c87-4f33-8151-7d60b0a8799f"), "Order name 2270", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 388.261845505917m, "усл. ед" },
                    { new Guid("780ea2f3-f13c-4274-a1b7-320f5d2f7351"), "Order name 1527", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 88.5736417538872m, "усл. ед" },
                    { new Guid("78256471-8fc6-452d-9a38-5dcf54f19102"), "Order name 449", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 157.957269242075m, "усл. ед" },
                    { new Guid("78461b77-a339-4322-ae99-5205b909cc45"), "Order name 2463", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 11.6256121727643m, "усл. ед" },
                    { new Guid("7854e672-28c6-433f-ad01-dd411d7cacd7"), "Order name 1928", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 297.309036422316m, "усл. ед" },
                    { new Guid("78616ca0-a1f0-4fc6-9258-7eb353d3fc4b"), "Order name 2024", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 52.5480638961159m, "усл. ед" },
                    { new Guid("7871369c-53bc-4fcc-ab3f-48d875784fa2"), "Order name 1533", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 381.801243589884m, "усл. ед" },
                    { new Guid("7871f0a4-2380-488b-836d-aa35a5e8576a"), "Order name 1794", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 169.635682683399m, "усл. ед" },
                    { new Guid("788720d8-c1c2-43d9-b88a-a90b8ce4fb7b"), "Order name 508", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 37.048961817266m, "усл. ед" },
                    { new Guid("78d0d459-09a9-4b0c-8d93-5b7fe726ba3e"), "Order name 286", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 190.088343684916m, "усл. ед" },
                    { new Guid("78d4bbfc-81f4-4f1b-bfa8-ac1b41286862"), "Order name 2459", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 346.135131007378m, "усл. ед" },
                    { new Guid("78f0a9f7-c708-4678-9950-ff04586ff7a9"), "Order name 380", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 166.247875318032m, "усл. ед" },
                    { new Guid("7900e4e1-ab77-4ba4-8601-4c0005b995d4"), "Order name 1423", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 695.067101657813m, "усл. ед" },
                    { new Guid("79665698-2c01-4f15-80c7-7961619cd876"), "Order name 546", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 213.87214289092m, "усл. ед" },
                    { new Guid("79780998-5c93-4ff5-8f8d-b8e2c61bc0f2"), "Order name 1201", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 26.7327056364282m, "усл. ед" },
                    { new Guid("798ffa99-7d7d-4fb1-ac41-f19940b46a6d"), "Order name 2354", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 748.268959630084m, "усл. ед" },
                    { new Guid("79cca88a-9ecd-4332-a76e-3b3e6cfce442"), "Order name 2080", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 201.815360830801m, "усл. ед" },
                    { new Guid("7a17b6f5-e4c3-46b7-a346-95b17d329ee3"), "Order name 1136", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 519.775674702034m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("7a1a8476-2cce-4fc6-a6e1-43667abd2203"), "Order name 1936", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 444.027665703655m, "усл. ед" },
                    { new Guid("7a2f159c-fb05-486d-91a9-f818e6009093"), "Order name 1970", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 186.454157310151m, "усл. ед" },
                    { new Guid("7a48e2de-a3a4-4243-8363-38e2aff9abd1"), "Order name 701", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 558.658496025461m, "усл. ед" },
                    { new Guid("7a4a10e6-6cf1-4733-84fd-eb008f70799a"), "Order name 1102", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 156.020581763625m, "усл. ед" },
                    { new Guid("7a6d0edc-43be-4cbd-8b4c-4c0da9669ed6"), "Order name 1627", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 216.99249806811m, "усл. ед" },
                    { new Guid("7aa1143d-9105-47e3-a2b9-c76bc04f1a07"), "Order name 445", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 209.762602959951m, "усл. ед" },
                    { new Guid("7ad46bd1-c075-4ac7-a5b2-a41e21b53b03"), "Order name 1986", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 420.310256132122m, "усл. ед" },
                    { new Guid("7aee03ee-cd56-46b5-b235-ec5c4006f3f2"), "Order name 831", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 242.176202356461m, "усл. ед" },
                    { new Guid("7af9b47b-6503-444f-bbfa-f1428449885b"), "Order name 1234", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 143.010315665103m, "усл. ед" },
                    { new Guid("7b04e430-1f1a-4755-a5ba-c2d7529ca9ee"), "Order name 1877", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 177.652948553314m, "усл. ед" },
                    { new Guid("7b0a50b7-8a00-4403-a86f-d3f6051c63ca"), "Order name 1837", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 42.8246965617496m, "усл. ед" },
                    { new Guid("7b0f6dbc-7a98-4701-ae8d-55ba33b510a4"), "Order name 2330", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 382.055922984406m, "усл. ед" },
                    { new Guid("7b1f5ab1-0278-499e-9b71-3f26701bcd9d"), "Order name 871", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 49.1442277006782m, "усл. ед" },
                    { new Guid("7b2c353c-9d92-4754-a0ca-3bf9faac5c7a"), "Order name 819", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 171.686535709012m, "усл. ед" },
                    { new Guid("7b76f13f-5eed-48cf-83f1-1b82027c62ba"), "Order name 294", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 417.493180929825m, "усл. ед" },
                    { new Guid("7b9a1fc4-b98a-4211-8635-00dce4bfb235"), "Order name 2007", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 133.17876971443m, "усл. ед" },
                    { new Guid("7bc047bd-f027-4f22-aa06-190353536930"), "Order name 2249", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 959.993007609084m, "усл. ед" },
                    { new Guid("7bdda444-5cbb-41da-ba2f-af4d9cf3df31"), "Order name 1503", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 23.3953866607033m, "усл. ед" },
                    { new Guid("7be987dd-3291-4fc2-b839-049ebc1232c1"), "Order name 151", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 229.135788303054m, "усл. ед" },
                    { new Guid("7bfc7d2b-7eef-4bca-9bb9-d062062e8c9f"), "Order name 136", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 95.1949846214508m, "усл. ед" },
                    { new Guid("7c0197f6-1eb6-472e-a338-e50a26c5096d"), "Order name 559", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 453.16065860716m, "усл. ед" },
                    { new Guid("7c260cef-3d7f-41ef-a5a5-5500a94a1e8c"), "Order name 2282", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 587.72310213429m, "усл. ед" },
                    { new Guid("7c39a7d6-cb6b-49d1-8cf1-6ac730d286d1"), "Order name 1534", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 130.304173051896m, "усл. ед" },
                    { new Guid("7c512c47-fe9c-43c2-83dd-1d46f0ca5a1c"), "Order name 2407", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 413.220813357908m, "усл. ед" },
                    { new Guid("7c60d519-43dc-4c7e-aa56-33e25c4eef11"), "Order name 1696", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 304.663225471724m, "усл. ед" },
                    { new Guid("7c60fa16-0ea9-44b3-beec-07517d4aee46"), "Order name 788", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 808.171692298941m, "усл. ед" },
                    { new Guid("7cc419bf-69eb-439c-b4d3-4610ec29d007"), "Order name 1720", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 347.316719902918m, "усл. ед" },
                    { new Guid("7ce8c049-ff58-4a98-b834-237023a83cd9"), "Order name 1068", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 77.2989453204334m, "усл. ед" },
                    { new Guid("7cea9546-6a2e-4044-b477-daded4c83df2"), "Order name 1277", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 370.667067742448m, "усл. ед" },
                    { new Guid("7ceb3906-d4fd-4bd3-8675-513fd4006288"), "Order name 716", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 289.747197709843m, "усл. ед" },
                    { new Guid("7ceecac4-3085-4159-a7b2-aec989606320"), "Order name 1033", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 61.040090768986m, "усл. ед" },
                    { new Guid("7cf2dffd-a48f-416b-948e-b60f28bc8a99"), "Order name 1660", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 360.710993207889m, "усл. ед" },
                    { new Guid("7d64bcc7-ef8e-486f-9d79-701dcc47aea8"), "Order name 71", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 709.837269850612m, "усл. ед" },
                    { new Guid("7d9ba64c-7221-4545-8042-731fed2a41e6"), "Order name 1076", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 91.6177492479016m, "усл. ед" },
                    { new Guid("7da15579-889d-45e9-9a5f-63b78c81be0b"), "Order name 87", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 37.6109974458115m, "усл. ед" },
                    { new Guid("7dab5692-ae09-4b78-8cf8-c6ca4a9fd511"), "Order name 1451", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 401.989842698196m, "усл. ед" },
                    { new Guid("7dad9654-3400-4f46-bff1-6745fa080371"), "Order name 150", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 93.3289443645679m, "усл. ед" },
                    { new Guid("7dc1acd0-dbc2-4a82-ac47-ad0ead94897d"), "Order name 892", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 721.726385062817m, "усл. ед" },
                    { new Guid("7dcc6b3b-4f18-4dd4-b02b-9f2de0c642d6"), "Order name 534", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 243.560167454092m, "усл. ед" },
                    { new Guid("7dfaa1d2-0aa9-48a5-8e55-d1eb54d4f42a"), "Order name 1510", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 341.58195244867m, "усл. ед" },
                    { new Guid("7e2753c9-ad22-44f8-9ccb-8ccedce6d35b"), "Order name 537", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 23.0872476429624m, "усл. ед" },
                    { new Guid("7e5499c0-292d-4989-b1e5-35bc281fa944"), "Order name 2099", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 286.078586439434m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("7e624672-1fa3-4d68-8dd4-ed7b0e31e1de"), "Order name 1954", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 512.846221721859m, "усл. ед" },
                    { new Guid("7e69fb38-ab34-4bac-a691-a8203c95a6ac"), "Order name 1297", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 24.4856090462036m, "усл. ед" },
                    { new Guid("7e6ef19e-0e19-4fc4-bf07-97c875e4c339"), "Order name 1661", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 83.4076311211881m, "усл. ед" },
                    { new Guid("7e917721-b551-42a7-8f21-889ed89f3aba"), "Order name 2301", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 660.88256089274m, "усл. ед" },
                    { new Guid("7ecf3d49-3205-4614-98c3-659f37c0b244"), "Order name 2066", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 218.510304913425m, "усл. ед" },
                    { new Guid("7ee21f1b-95b2-4aaa-a35c-eea50a12af93"), "Order name 2250", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 105.360097594184m, "усл. ед" },
                    { new Guid("7efe8424-f04e-45bf-8344-61fd6fec711e"), "Order name 877", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 182.700795081949m, "усл. ед" },
                    { new Guid("7f3749e5-55da-4647-a28a-84241ec1d890"), "Order name 2457", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 15.9391951672157m, "усл. ед" },
                    { new Guid("7f723503-c130-4c1e-a1f4-90b6ecb7c336"), "Order name 1066", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 329.899946295102m, "усл. ед" },
                    { new Guid("7fa99b72-6246-443e-b0a8-82524d4af247"), "Order name 1721", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 221.770666224331m, "усл. ед" },
                    { new Guid("7fda423d-e0a9-4788-8435-656a5052cae3"), "Order name 368", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 46.2074014889232m, "усл. ед" },
                    { new Guid("7ff52d6a-bb2b-40be-b25d-89c8f112d053"), "Order name 1719", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 255.515576861699m, "усл. ед" },
                    { new Guid("801c557b-9f6d-4920-8519-cdf4f409f73c"), "Order name 937", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 813.30885483095m, "усл. ед" },
                    { new Guid("803a43b6-2f58-49dd-8c95-2697e29b8f8c"), "Order name 123", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 83.1824682886151m, "усл. ед" },
                    { new Guid("803c9a26-7cd7-4e49-b603-07f3e89a5cf1"), "Order name 1560", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 812.610713754579m, "усл. ед" },
                    { new Guid("80596a76-1e3d-4b98-b7fe-40c7ce5419d9"), "Order name 261", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 594.930667483553m, "усл. ед" },
                    { new Guid("807784fb-7d0a-4b66-8f30-eac2f1393f05"), "Order name 2248", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 29.7509771657376m, "усл. ед" },
                    { new Guid("807eebb7-ecb1-4d69-be6f-842b792d978b"), "Order name 1822", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 218.38448079889m, "усл. ед" },
                    { new Guid("80a4d907-666a-44a4-8cd6-92e5be419a8b"), "Order name 706", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 147.296822925535m, "усл. ед" },
                    { new Guid("80bf246c-df9c-42b9-a8d1-dab23fd224e0"), "Order name 301", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 122.011865778808m, "усл. ед" },
                    { new Guid("80ea3b82-8908-40c3-8a85-27d8161bef21"), "Order name 2405", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 505.249418966765m, "усл. ед" },
                    { new Guid("8108cff9-1f6a-4acd-9aa0-139d4ded33d6"), "Order name 637", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 61.0513639562218m, "усл. ед" },
                    { new Guid("8112c35b-8722-4b50-89f0-4b9b86ab675d"), "Order name 1662", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 269.721654130988m, "усл. ед" },
                    { new Guid("8126e78e-4de1-4699-b18a-3479aaa1059a"), "Order name 1250", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 54.1576657436152m, "усл. ед" },
                    { new Guid("812c801a-a835-4504-a4ca-18ffae4950e0"), "Order name 1010", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 361.195533502792m, "усл. ед" },
                    { new Guid("81657116-3188-46b1-ad4e-12397b119dd7"), "Order name 1924", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 240.247722055733m, "усл. ед" },
                    { new Guid("817b3665-496a-4bd1-bb32-5b369d4c22f2"), "Order name 1045", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 449.468632589858m, "усл. ед" },
                    { new Guid("817decd6-9db5-41db-a412-daf65f41deba"), "Order name 572", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 76.9998641939496m, "усл. ед" },
                    { new Guid("81a57f3c-f8d2-4f87-8875-13a0b3c7b061"), "Order name 1364", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 217.377062203833m, "усл. ед" },
                    { new Guid("81a90c3c-0c98-4c71-b5fd-a20092e2a4b2"), "Order name 756", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 928.235346014768m, "усл. ед" },
                    { new Guid("81c1d951-17ae-4cd8-924c-3ba8a7226caf"), "Order name 911", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 3.19150619133058m, "усл. ед" },
                    { new Guid("81c9ef36-0dad-4de0-be6c-635c8c47b542"), "Order name 1768", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 338.58204906621m, "усл. ед" },
                    { new Guid("81e4d242-33a4-49c8-9417-b11920218ec1"), "Order name 1858", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 406.308077937826m, "усл. ед" },
                    { new Guid("81ed8798-a898-4928-84ab-da24d4cd605d"), "Order name 426", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 370.836212864998m, "усл. ед" },
                    { new Guid("81f592bf-b7f0-44bc-8fda-2764bfed8426"), "Order name 65", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 325.193629292591m, "усл. ед" },
                    { new Guid("820ec661-0f79-4de6-ab27-4170087b9dff"), "Order name 868", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 784.335676959067m, "усл. ед" },
                    { new Guid("8246c4d4-119b-46f7-a362-cabcf940cab9"), "Order name 675", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 7.95179114069149m, "усл. ед" },
                    { new Guid("826591dc-d180-4752-81f1-349ea065819f"), "Order name 2188", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 252.251150777681m, "усл. ед" },
                    { new Guid("829819e6-88b7-4db8-84ae-50f23f7ac31a"), "Order name 577", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 55.8387950636126m, "усл. ед" },
                    { new Guid("82ddd641-6059-4238-a300-c4f09e2e99c4"), "Order name 6", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 280.274507340528m, "усл. ед" },
                    { new Guid("82ff43b3-6f32-4c56-9c23-57927a58f154"), "Order name 1563", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 57.5350892156111m, "усл. ед" },
                    { new Guid("831f985f-4606-4480-9e69-97e31c53ec91"), "Order name 2134", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 22.300922560021m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("8337d61c-f080-4a5c-ac5b-7420168dbafa"), "Order name 1671", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 413.268495704882m, "усл. ед" },
                    { new Guid("8344824c-db50-4341-bde4-24d32908e8ed"), "Order name 2015", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 41.8553445511958m, "усл. ед" },
                    { new Guid("834be5af-4c95-4578-90ea-e97ce1dd6161"), "Order name 1772", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 270.496570371492m, "усл. ед" },
                    { new Guid("83673bb2-9d3d-4c58-bfdd-d3adf3e23dfc"), "Order name 810", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 329.232997640845m, "усл. ед" },
                    { new Guid("837cb4d4-223f-4ef8-80c6-23c23db45dfd"), "Order name 1314", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 608.837153847969m, "усл. ед" },
                    { new Guid("83ba4553-5cd1-4f5c-ab7e-f957cc0efbf2"), "Order name 2444", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 268.169138929482m, "усл. ед" },
                    { new Guid("83c282c1-440a-4c63-af66-f3e329af8f9b"), "Order name 869", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 24.2212769677779m, "усл. ед" },
                    { new Guid("83d19c92-71a5-4dad-a95b-cf969870de36"), "Order name 108", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 262.175582818646m, "усл. ед" },
                    { new Guid("83d9be44-6947-4bc6-81a4-a2b9f49df072"), "Order name 112", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 413.624322480999m, "усл. ед" },
                    { new Guid("83e18151-ba0d-42f6-b063-57b9ce56106b"), "Order name 1514", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 270.038321352118m, "усл. ед" },
                    { new Guid("83f77ed1-e949-4f97-99af-6b5f430aac4d"), "Order name 1065", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 644.670373789929m, "усл. ед" },
                    { new Guid("83fca229-67fb-4323-b8d4-67ed26a64e93"), "Order name 845", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 709.516775782163m, "усл. ед" },
                    { new Guid("840dd369-57f4-4ae5-81a0-82ae208b3eb6"), "Order name 1487", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 71.5557277369355m, "усл. ед" },
                    { new Guid("8412c060-d1b4-49ee-aac7-2eecbceabb80"), "Order name 1676", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 83.2123150111534m, "усл. ед" },
                    { new Guid("84207603-70c2-4e4d-9507-42d0a19d9ec6"), "Order name 1169", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 836.133660227204m, "усл. ед" },
                    { new Guid("8456dffa-239d-4a71-8545-92f39e71c920"), "Order name 1553", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 353.089925807986m, "усл. ед" },
                    { new Guid("847ca87f-bec0-4f97-a59b-7feb6e216fa7"), "Order name 1987", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 904.360137544178m, "усл. ед" },
                    { new Guid("84adbc00-08e8-4b9b-acc7-4d66fcd6606b"), "Order name 830", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 54.3302249759372m, "усл. ед" },
                    { new Guid("84b74256-c1fa-42f6-b267-b71da7b3b03f"), "Order name 116", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 649.091704023529m, "усл. ед" },
                    { new Guid("84bb634b-ca4c-46e7-9cf5-a86467cb064f"), "Order name 39", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 123.584961104416m, "усл. ед" },
                    { new Guid("84eeafb3-9786-4675-b13e-3750417c5da8"), "Order name 501", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 177.718261801216m, "усл. ед" },
                    { new Guid("853f34bc-d479-4be5-8242-21249713f712"), "Order name 1861", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 41.0047248438364m, "усл. ед" },
                    { new Guid("8571ccc1-f3d7-490c-9762-9136fe00bd71"), "Order name 1972", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 74.5261136525255m, "усл. ед" },
                    { new Guid("8582f660-8c82-455c-9e11-93d7dade2687"), "Order name 1900", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 465.838485024646m, "усл. ед" },
                    { new Guid("8599a122-aaf1-4250-a775-506d0553df41"), "Order name 2267", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 312.008895574519m, "усл. ед" },
                    { new Guid("85a4a2d6-a266-4dc3-9525-e57598ed0bf1"), "Order name 934", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 206.52814861543m, "усл. ед" },
                    { new Guid("85b8d760-262f-4555-927c-205872fbd4b0"), "Order name 236", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 239.747358080144m, "усл. ед" },
                    { new Guid("85cf66e7-5633-41af-a2bf-5ee17c061857"), "Order name 1643", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 158.114235774376m, "усл. ед" },
                    { new Guid("85d974d8-534c-4f63-a488-96a412479962"), "Order name 1486", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 267.100151038828m, "усл. ед" },
                    { new Guid("85f30308-ed79-49cb-88a8-87db72414e9c"), "Order name 1103", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 312.096796221562m, "усл. ед" },
                    { new Guid("85f4b097-78b2-47d8-90a7-11e13c4e127b"), "Order name 2401", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 563.796099953132m, "усл. ед" },
                    { new Guid("85f9e67a-af41-42ed-9e36-dcd2ecb14d5a"), "Order name 1657", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 41.2508300477233m, "усл. ед" },
                    { new Guid("8601a841-063f-45cf-8e85-2f11864efb7a"), "Order name 1718", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 849.102484109348m, "усл. ед" },
                    { new Guid("860ed303-d67d-4076-9037-2de5b1c023a6"), "Order name 507", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 533.926991955777m, "усл. ед" },
                    { new Guid("862812cc-2384-4d84-9ee5-1832d06fbdd1"), "Order name 1415", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 594.299317756018m, "усл. ед" },
                    { new Guid("865a58d9-9c1f-4922-9fe5-b34e2a8f7d49"), "Order name 1090", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 151.300349942568m, "усл. ед" },
                    { new Guid("865f7cca-0185-415f-812c-b6476dd0e3b5"), "Order name 1545", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 658.004923116055m, "усл. ед" },
                    { new Guid("866b5391-cb37-4320-b66a-9bd28acbe214"), "Order name 117", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 324.457808715953m, "усл. ед" },
                    { new Guid("86761575-6163-4dfa-9400-9354b96335a1"), "Order name 2151", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 70.7471420675829m, "усл. ед" },
                    { new Guid("867e263f-a90f-4326-bff2-479bd3fc854f"), "Order name 178", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 374.636169841249m, "усл. ед" },
                    { new Guid("8682e32b-e29a-4a10-91de-94e4b493caa6"), "Order name 1104", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 254.562095162652m, "усл. ед" },
                    { new Guid("86b1098c-6c07-4e4f-80f6-1593a39357e9"), "Order name 3", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 200.402536337164m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("86b72c09-0aad-4882-bf2b-c8d122515a65"), "Order name 503", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 632.239411940722m, "усл. ед" },
                    { new Guid("86c9725e-9417-4dde-a09e-de0e35d28558"), "Order name 1394", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 209.573113761124m, "усл. ед" },
                    { new Guid("86e1a40b-89df-4423-9653-4bd461d11d80"), "Order name 478", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 256.796288337981m, "усл. ед" },
                    { new Guid("86f03206-d4d5-479a-93d8-b65cc993b79c"), "Order name 2472", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 122.623806518554m, "усл. ед" },
                    { new Guid("87029dde-463a-44c7-87e0-23dc18eb1a80"), "Order name 121", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 881.444053035881m, "усл. ед" },
                    { new Guid("8711613b-7872-401a-8af1-19e512d90a01"), "Order name 1025", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 510.85059091826m, "усл. ед" },
                    { new Guid("871791cf-d0d3-45cc-b563-298f761f836f"), "Order name 1994", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 0.148656430181648m, "усл. ед" },
                    { new Guid("874d729d-9b9d-4f07-87fc-366fe7f0e371"), "Order name 1783", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 165.677486886731m, "усл. ед" },
                    { new Guid("877493ba-ab67-49d3-8ed1-0bbf6e035bd3"), "Order name 838", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 48.524164040109m, "усл. ед" },
                    { new Guid("8781ab92-7f66-4671-b70e-57b48dd8eed6"), "Order name 279", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 563.940327785849m, "усл. ед" },
                    { new Guid("87a60442-d913-49c5-851a-184d27fe5a80"), "Order name 1074", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 205.697216712087m, "усл. ед" },
                    { new Guid("8821a423-0766-45ea-a39f-d90c9d135412"), "Order name 2108", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 15.4674820666805m, "усл. ед" },
                    { new Guid("8839993b-2adb-4740-acc3-cd600861a19f"), "Order name 1497", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 145.838868981694m, "усл. ед" },
                    { new Guid("888e9909-636a-486a-aef0-a12470972525"), "Order name 1143", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 160.255779186653m, "усл. ед" },
                    { new Guid("88c4d5f1-0d21-4d13-848a-4e1a4a3d68dc"), "Order name 173", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 445.986145596396m, "усл. ед" },
                    { new Guid("88d95e6f-4791-4fdb-9bfe-0eff274a107e"), "Order name 1678", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 454.889730624417m, "усл. ед" },
                    { new Guid("89063cb5-d2f7-4ef0-a7e8-0e181976dd89"), "Order name 1037", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 290.389124342172m, "усл. ед" },
                    { new Guid("890dde22-7419-4edd-938f-7cb462c68e50"), "Order name 309", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 152.517995518452m, "усл. ед" },
                    { new Guid("89318c76-6724-4c01-bfa4-71a35fc5247d"), "Order name 1603", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 331.648418551323m, "усл. ед" },
                    { new Guid("893cc0eb-1a94-48d2-8cbf-b6d3c8657567"), "Order name 1593", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 34.398746518797m, "усл. ед" },
                    { new Guid("89cb78b9-17c4-409f-bdbe-1ede7c3cf329"), "Order name 1401", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 902.740021339781m, "усл. ед" },
                    { new Guid("89e49a21-1f55-44cd-94e7-9fc852bac638"), "Order name 2225", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 451.197886546829m, "усл. ед" },
                    { new Guid("89e76f40-9805-4ef7-ad7d-68882e663f63"), "Order name 254", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 714.902237981018m, "усл. ед" },
                    { new Guid("8a35de75-b850-43fc-82af-c6f677366b72"), "Order name 2037", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 361.39293688732m, "усл. ед" },
                    { new Guid("8a705a8c-bedc-4ff7-beda-c957a35f6ecc"), "Order name 2169", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 454.658559555594m, "усл. ед" },
                    { new Guid("8a8490b2-b16c-45ca-a37a-838a776ddd94"), "Order name 1876", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 89.0750901336775m, "усл. ед" },
                    { new Guid("8aaa6b9a-3064-4db7-ae2b-44fd85f7609b"), "Order name 2365", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 382.026032399386m, "усл. ед" },
                    { new Guid("8ac75a76-fcdf-4f38-8870-272902b37905"), "Order name 965", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 52.9845597178929m, "усл. ед" },
                    { new Guid("8ae16229-59b1-431c-9fbf-ea7250cacac5"), "Order name 1886", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 193.847303900638m, "усл. ед" },
                    { new Guid("8ba8aff8-6f27-49ee-b848-2c68a04960a1"), "Order name 2466", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 371.637900092995m, "усл. ед" },
                    { new Guid("8be83beb-9178-4242-b642-81b8f26f8d96"), "Order name 1867", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 164.939821878227m, "усл. ед" },
                    { new Guid("8bf3c973-772c-447c-8ae1-70d733fb7e30"), "Order name 633", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 327.757131791931m, "усл. ед" },
                    { new Guid("8bfbaa8b-b6be-44d6-8d58-ca6b1ab37283"), "Order name 1892", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 269.482371809737m, "усл. ед" },
                    { new Guid("8bfe0155-275f-47bd-8394-5e75b5b1e058"), "Order name 1582", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 199.379740717436m, "усл. ед" },
                    { new Guid("8c0afdca-fb5e-4c3f-b5bb-f155755dcc00"), "Order name 1656", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 20.3727756291182m, "усл. ед" },
                    { new Guid("8c14f455-190b-4e2a-8f5b-039e51bc507a"), "Order name 1926", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 74.7510768762717m, "усл. ед" },
                    { new Guid("8ca44861-8ba7-4728-ab2d-ac28c8326e67"), "Order name 1912", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 729.94510948367m, "усл. ед" },
                    { new Guid("8cc0ab9d-e5b5-40d6-853e-4eaa8c2a2210"), "Order name 571", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 439.054526241936m, "усл. ед" },
                    { new Guid("8cde45af-1555-4d61-913e-7e60abdc5702"), "Order name 883", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 107.649281932762m, "усл. ед" },
                    { new Guid("8cfb901f-f496-4701-aadd-09112d91ba27"), "Order name 1863", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 684.743730708262m, "усл. ед" },
                    { new Guid("8d082dbf-25dd-4545-a7a2-d03cf4345ab6"), "Order name 405", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 208.376181565125m, "усл. ед" },
                    { new Guid("8d1b69ee-d717-4906-addf-bb670756a78e"), "Order name 375", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 486.923556391732m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("8d694c18-ec43-4dde-b6d7-ad5d0892c653"), "Order name 612", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 176.382803906629m, "усл. ед" },
                    { new Guid("8d6f4123-966f-4ad0-b789-3abffc17469d"), "Order name 617", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 239.222612849529m, "усл. ед" },
                    { new Guid("8db57fc6-f558-411d-98ae-85b8d9a9087f"), "Order name 536", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 692.608510328109m, "усл. ед" },
                    { new Guid("8db8fe6d-ff7d-409c-a9bc-5345e6368825"), "Order name 1238", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 57.317906524393m, "усл. ед" },
                    { new Guid("8de4513d-c702-472f-be35-8ef394fb879b"), "Order name 1959", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 52.1741774755601m, "усл. ед" },
                    { new Guid("8de84af6-0648-46db-b073-fa746c3529f4"), "Order name 608", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 165.96700326479m, "усл. ед" },
                    { new Guid("8dea5b4b-7846-408b-bf3f-f57efa5330b9"), "Order name 2424", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 285.579987478688m, "усл. ед" },
                    { new Guid("8e2cc316-4ce8-4d53-ba9e-3f7f0a68f0eb"), "Order name 689", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 4.13726343282503m, "усл. ед" },
                    { new Guid("8e32c5a3-5658-48d5-8a5c-b26aec197e83"), "Order name 135", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 18.6140971465346m, "усл. ед" },
                    { new Guid("8e53defd-29f7-48d7-8ee3-583f0341a15b"), "Order name 670", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 267.825118177581m, "усл. ед" },
                    { new Guid("8e6fe6fb-e5dd-4166-aa68-b78641a4e611"), "Order name 1118", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 209.837615579706m, "усл. ед" },
                    { new Guid("8e885823-1e8a-4b44-9626-98a798fa6b31"), "Order name 655", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 228.369383071315m, "усл. ед" },
                    { new Guid("8e9e6dbe-aad7-4ece-af10-386c7a9f28ac"), "Order name 155", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 677.686525704375m, "усл. ед" },
                    { new Guid("8ec5a78e-73b5-4ef7-bcfc-30360e575be2"), "Order name 1071", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 517.436146422195m, "усл. ед" },
                    { new Guid("8ecc295d-18c3-4ac7-9269-129b3e2f382f"), "Order name 636", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 3.9523480986361m, "усл. ед" },
                    { new Guid("8ee10a3b-626a-4b26-a208-9e298b6f3860"), "Order name 384", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 69.0241118596284m, "усл. ед" },
                    { new Guid("8efe37a7-faed-4dc1-8bca-ff82c7d6a3d1"), "Order name 1564", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 333.002206910241m, "усл. ед" },
                    { new Guid("8f525ea1-b0bb-4b96-a322-42ae95d628cf"), "Order name 2412", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 508.816222613391m, "усл. ед" },
                    { new Guid("8f55e2a5-8b2b-47fb-b14e-cf902f7f26c5"), "Order name 778", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 314.34102616086m, "усл. ед" },
                    { new Guid("8f561bfe-3c9a-4f15-a859-25203a47dac2"), "Order name 1176", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 163.206239833459m, "усл. ед" },
                    { new Guid("8f682ea9-99ba-432f-8e34-fb4dcaff7e82"), "Order name 782", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 435.173713278386m, "усл. ед" },
                    { new Guid("8f745ea8-f62e-4ede-8ea0-9c8040bbf90c"), "Order name 358", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 274.392866287553m, "усл. ед" },
                    { new Guid("8f82324b-0903-4f71-96e5-1573a9b0682a"), "Order name 146", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 54.8502835133169m, "усл. ед" },
                    { new Guid("8f907047-23bd-4e47-80c0-a400d7577180"), "Order name 50", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 404.077676805455m, "усл. ед" },
                    { new Guid("8f977813-d0b2-4478-b393-9749ec046e62"), "Order name 1614", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 145.494408114173m, "усл. ед" },
                    { new Guid("8fc915a8-6692-4522-9e18-510cd33d806d"), "Order name 623", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 68.5658600254118m, "усл. ед" },
                    { new Guid("8fd799ff-a6f9-4bfa-af21-7d2a8197e464"), "Order name 1325", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 43.3054072127443m, "усл. ед" },
                    { new Guid("8ffe9ee1-0a22-4f82-8026-c3407b689161"), "Order name 750", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 598.254612829039m, "усл. ед" },
                    { new Guid("90005f93-f962-4ae2-b425-7343dc93bbd3"), "Order name 23", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 166.320030234227m, "усл. ед" },
                    { new Guid("90269f22-1231-4603-865c-8f66223e436c"), "Order name 89", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 38.9050017119469m, "усл. ед" },
                    { new Guid("90275f9a-8b13-4336-83c1-ebd2d7d3a590"), "Order name 2036", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 125.037848353105m, "усл. ед" },
                    { new Guid("9030e870-caf4-4c31-b71e-9a4b79ae0932"), "Order name 2181", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 188.385664070042m, "усл. ед" },
                    { new Guid("903a273f-7781-46a2-a840-77fce67a2a63"), "Order name 2138", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 31.6172141254288m, "усл. ед" },
                    { new Guid("90443ff5-cc9e-4eae-92bd-4cb1dfa637c8"), "Order name 388", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 100.236726103959m, "усл. ед" },
                    { new Guid("904b68c7-d821-4076-8007-f2fc8f938578"), "Order name 1817", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 219.585809443151m, "усл. ед" },
                    { new Guid("905095bb-d27d-49ca-a3aa-6ee6074c356f"), "Order name 2023", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 60.7332276308286m, "усл. ед" },
                    { new Guid("9057578c-23d6-4f15-8b7e-d9291e7d274c"), "Order name 1447", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 296.525537750869m, "усл. ед" },
                    { new Guid("905dec50-b2b6-4196-b1fb-ff0c37015b43"), "Order name 1300", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 39.6932585342755m, "усл. ед" },
                    { new Guid("907e674f-50e2-481e-8312-e36b411232d2"), "Order name 2176", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 195.262462571761m, "усл. ед" },
                    { new Guid("90813a26-d756-46f9-83e5-c8c160fb169c"), "Order name 1149", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 40.26201729122m, "усл. ед" },
                    { new Guid("90939bbc-5597-4995-99c8-91ec60cc3843"), "Order name 2233", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 2.4472118367525m, "усл. ед" },
                    { new Guid("90b7783b-9366-4978-95bb-13162ce7a287"), "Order name 341", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 267.947881761535m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("90cecb7b-9216-4274-8b1e-72f37f13a940"), "Order name 1253", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 210.430425284553m, "усл. ед" },
                    { new Guid("90e68ebc-5676-473e-87a7-b5d3e6c778fb"), "Order name 382", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 463.482627929153m, "усл. ед" },
                    { new Guid("90ec6a20-d042-46b1-8ac5-878d8d6138f4"), "Order name 1154", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 187.003298747875m, "усл. ед" },
                    { new Guid("90f237a1-e614-4181-8bd0-091da161f02d"), "Order name 808", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 203.911495129774m, "усл. ед" },
                    { new Guid("910065ff-9906-48c2-9937-9a702b9590df"), "Order name 2311", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 624.701637641228m, "усл. ед" },
                    { new Guid("91036c28-91e7-4e96-a280-482399791c21"), "Order name 1205", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 80.6285505237704m, "усл. ед" },
                    { new Guid("9141a081-45e5-40fb-a75d-54171a4f5d08"), "Order name 2434", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 160.850936215908m, "усл. ед" },
                    { new Guid("9159c87f-76fe-4160-96b2-5a3a2ad9ff5c"), "Order name 145", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 131.413934073841m, "усл. ед" },
                    { new Guid("91832047-fd74-48f3-996f-35a617ffdcd8"), "Order name 1437", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 480.530550712595m, "усл. ед" },
                    { new Guid("91843083-c66a-4f73-b875-78495d175ab9"), "Order name 321", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 385.659011868234m, "усл. ед" },
                    { new Guid("91ba4b03-5e26-4130-975e-de26c6cc4f7c"), "Order name 442", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 302.795063953503m, "усл. ед" },
                    { new Guid("91d91ef3-60f7-4813-bcd7-9e0596a3fbcd"), "Order name 1591", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 470.937605853628m, "усл. ед" },
                    { new Guid("91f0e56d-c940-42a5-adbe-13c10512b6ce"), "Order name 1901", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 260.002979607135m, "усл. ед" },
                    { new Guid("9217a64e-f08a-4fe7-8e00-83791f2e4a66"), "Order name 1947", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 111.579010872199m, "усл. ед" },
                    { new Guid("9242c465-c286-4b0d-8f41-863f1dccdf41"), "Order name 703", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 358.856517230775m, "усл. ед" },
                    { new Guid("9275d323-598d-40ae-b11d-3bc4f9aa1229"), "Order name 147", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 409.030278363514m, "усл. ед" },
                    { new Guid("9289ded0-c436-429d-ab7f-68f5d7d4abe5"), "Order name 1645", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 267.264138527755m, "усл. ед" },
                    { new Guid("92b91c96-3906-4bfe-aa8f-3798233afa08"), "Order name 1147", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 90.2647994840268m, "усл. ед" },
                    { new Guid("92d62005-2c41-4e93-b037-fc6a7705de76"), "Order name 493", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 391.369806490395m, "усл. ед" },
                    { new Guid("92e12a61-e0a1-423f-957a-e75ddd3bf1fe"), "Order name 1896", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 133.422913099452m, "усл. ед" },
                    { new Guid("92f02cee-6876-462d-8d3a-9ab4b31fa849"), "Order name 266", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 5.96602173209818m, "усл. ед" },
                    { new Guid("93171ec0-c261-439f-ae7f-07f221a4b475"), "Order name 2127", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 11.5443293438968m, "усл. ед" },
                    { new Guid("936af3da-9389-4cee-b7c6-0472687c8085"), "Order name 1399", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 466.015745574673m, "усл. ед" },
                    { new Guid("9372b2db-4cb4-408f-833d-faef42526cd3"), "Order name 1006", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 68.2378165012967m, "усл. ед" },
                    { new Guid("938fce8b-e89b-4f87-b323-3d753be38b43"), "Order name 2374", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 376.399218121478m, "усл. ед" },
                    { new Guid("939e55db-748b-499e-8249-b1969d749845"), "Order name 1470", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 561.85765534386m, "усл. ед" },
                    { new Guid("93b601fd-c797-42a8-b567-69c34fffa8cf"), "Order name 648", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 105.284290428723m, "усл. ед" },
                    { new Guid("93c2e745-cac9-4fbb-9bce-8cfbe24ab75b"), "Order name 2388", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 290.520600558288m, "усл. ед" },
                    { new Guid("93c9cc78-149d-4b9b-b689-348700c2255b"), "Order name 1700", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 100.107929796359m, "усл. ед" },
                    { new Guid("93e84bbf-494a-43ea-8804-24688b6b78bf"), "Order name 1276", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 20.0585120980021m, "усл. ед" },
                    { new Guid("93f54a6e-6e16-459b-8873-79902e6da544"), "Order name 2115", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 577.269409909786m, "усл. ед" },
                    { new Guid("93fb6889-4233-4c1b-83a6-add6d8f527f0"), "Order name 752", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 227.848264701526m, "усл. ед" },
                    { new Guid("94038c34-99b9-4aad-a534-393d3fafec66"), "Order name 770", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 160.245925532249m, "усл. ед" },
                    { new Guid("9413e5c5-4951-4964-bb20-ee86cf3e8f8b"), "Order name 2162", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 93.8510411656295m, "усл. ед" },
                    { new Guid("94167762-d563-42d3-9cd6-60abfca805c6"), "Order name 2089", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 267.986608307858m, "усл. ед" },
                    { new Guid("942e3bc3-aaed-4dee-a2a9-86a94eea9573"), "Order name 251", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 423.501959427346m, "усл. ед" },
                    { new Guid("9465c238-b473-41f2-9192-d57ab7117e38"), "Order name 1807", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 95.8757507044108m, "усл. ед" },
                    { new Guid("947cc840-9946-4dbf-aa11-8f125ae7110d"), "Order name 433", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 32.6965580573401m, "усл. ед" },
                    { new Guid("947dcaf4-dd6d-442e-948d-c5d525e6df6d"), "Order name 1520", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 37.3888315503946m, "усл. ед" },
                    { new Guid("9483d0e2-1e68-4bf5-938d-7d22a1324c11"), "Order name 2067", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 918.826154220384m, "усл. ед" },
                    { new Guid("94a53168-088d-4c30-bbd5-61716accf3f6"), "Order name 1178", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 558.100919146404m, "усл. ед" },
                    { new Guid("94b994a1-b890-4e5a-9177-e4f9162940ff"), "Order name 1577", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 486.67987951982m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("94b9e95e-72bc-4b40-a930-1ce00146e24a"), "Order name 2355", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 200.321930241896m, "усл. ед" },
                    { new Guid("94c6cb01-b5d7-4968-bc9f-06ecebad2e0e"), "Order name 1140", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 527.934925870916m, "усл. ед" },
                    { new Guid("94da92c9-9888-43ed-bd3d-ab15dc98c365"), "Order name 78", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 89.909600805188m, "усл. ед" },
                    { new Guid("94e6bf6a-9e2d-436f-8419-931ff3822af7"), "Order name 607", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 99.0650415237698m, "усл. ед" },
                    { new Guid("94ea1527-e549-462c-8767-5d47d548dfce"), "Order name 774", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 74.7874234333446m, "усл. ед" },
                    { new Guid("95013b02-7180-4322-973e-e9090de6d811"), "Order name 221", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 60.9375123753353m, "усл. ед" },
                    { new Guid("951556dc-9474-4553-89a3-e0072dd3099e"), "Order name 1609", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 379.047292240957m, "усл. ед" },
                    { new Guid("95171b09-d7de-49c8-9d91-d96e68aac9b9"), "Order name 214", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 655.920652810298m, "усл. ед" },
                    { new Guid("9523366d-f234-44c2-8d8e-db9588ff898d"), "Order name 1011", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 11.9409980369907m, "усл. ед" },
                    { new Guid("95250d84-5274-4ac3-ab3c-b9da3748e403"), "Order name 1727", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 460.725200497271m, "усл. ед" },
                    { new Guid("952d2dde-9f9e-4c1e-9546-2a48be23ab39"), "Order name 978", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 23.7127513809608m, "усл. ед" },
                    { new Guid("95401462-a632-40cb-a91a-205c51cc4bd3"), "Order name 1294", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 502.118333525947m, "усл. ед" },
                    { new Guid("954721cf-6dec-4d22-aea2-141d3d36d048"), "Order name 1539", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 12.0876284967281m, "усл. ед" },
                    { new Guid("954f4adc-e97f-4cbe-bb27-82478cefc4cf"), "Order name 231", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 465.732563522738m, "усл. ед" },
                    { new Guid("955fae60-aae3-4887-a441-b400a41f0120"), "Order name 1235", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 278.125999126271m, "усл. ед" },
                    { new Guid("95932424-0fab-4e9b-a760-c5ab95f372f1"), "Order name 1578", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 61.8496576919202m, "усл. ед" },
                    { new Guid("95b2761b-7f99-4a5e-872a-542f1fcfa82b"), "Order name 305", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 12.2669382495617m, "усл. ед" },
                    { new Guid("95ccf932-9826-4df3-bf41-404a1eb47b16"), "Order name 988", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 285.90500340968m, "усл. ед" },
                    { new Guid("95d2f925-9ea1-499a-bdb8-30fb7e4283d4"), "Order name 2085", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 362.806373105071m, "усл. ед" },
                    { new Guid("95d39a74-c3e2-4150-a441-a5e33a334db5"), "Order name 70", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 267.399169579145m, "усл. ед" },
                    { new Guid("95d9a3f7-5b90-4e9d-98ec-2d49d319215c"), "Order name 1717", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 55.0697801692359m, "усл. ед" },
                    { new Guid("9659fe39-0831-403a-852c-59e158bc4cb4"), "Order name 225", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 379.1238663764m, "усл. ед" },
                    { new Guid("966f21f0-1fec-4c6b-8e5a-7e08ece65e0d"), "Order name 1093", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 150.845894030687m, "усл. ед" },
                    { new Guid("968608ea-ffcc-4a7f-baf2-2217eb392136"), "Order name 1216", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 250.55217047945m, "усл. ед" },
                    { new Guid("968b4a95-f640-4c4f-b07d-8c2fc0d517be"), "Order name 567", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 31.6440752128707m, "усл. ед" },
                    { new Guid("96a3bfff-8fa7-41c1-afa5-72723acf4efe"), "Order name 1963", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 227.669505628612m, "усл. ед" },
                    { new Guid("96d13bbf-22e0-43f0-978d-4df500502a0f"), "Order name 863", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 112.344046670946m, "усл. ед" },
                    { new Guid("96e0370d-b7c9-43cf-868c-d6960b5a4174"), "Order name 1573", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 200.128245230226m, "усл. ед" },
                    { new Guid("96e1ea1e-5010-4a22-b652-5d08d36be13c"), "Order name 1839", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 70.2850649890929m, "усл. ед" },
                    { new Guid("970e938c-6c1b-4bbe-b9c6-395bf5222061"), "Order name 1270", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 139.068953065793m, "усл. ед" },
                    { new Guid("9737d5eb-11bd-4d2f-bef5-118be956d76a"), "Order name 1403", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 247.076116659067m, "усл. ед" },
                    { new Guid("9748845b-2bce-46a5-a333-37ad48fb37e5"), "Order name 1739", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 137.115650612793m, "усл. ед" },
                    { new Guid("97492f39-70ac-4f7c-8006-319ede0f0b23"), "Order name 1411", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 85.5516027595455m, "усл. ед" },
                    { new Guid("974bd905-468d-421c-8818-128816e94855"), "Order name 2314", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 154.062310533855m, "усл. ед" },
                    { new Guid("97781bc9-ce37-4355-93d5-c490199bad04"), "Order name 783", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 411.391028005233m, "усл. ед" },
                    { new Guid("9782fb98-4ceb-4405-9281-5eecf6cea2af"), "Order name 1117", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 177.532104522637m, "усл. ед" },
                    { new Guid("97a7ec97-1dac-4886-8845-a46be507457b"), "Order name 2338", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 427.03077153377m, "усл. ед" },
                    { new Guid("97b28122-bb54-43ac-8782-ed142bb21bbf"), "Order name 141", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 840.6341333363m, "усл. ед" },
                    { new Guid("97b82350-a00c-4693-80ce-7d6da8cb20b4"), "Order name 188", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 175.637943602518m, "усл. ед" },
                    { new Guid("97cada6f-2914-480e-9149-a2ee63c07cb5"), "Order name 640", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 178.855047344799m, "усл. ед" },
                    { new Guid("97d1f5e7-3822-4129-a507-340f4bbf6179"), "Order name 340", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 261.798481034828m, "усл. ед" },
                    { new Guid("97df1a10-6a72-4d52-8321-2fbad4246501"), "Order name 1433", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 178.218831286784m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("97e40f84-a25f-46e9-a78a-916183d7c920"), "Order name 1041", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 192.791105819237m, "усл. ед" },
                    { new Guid("97e43f01-0f4f-4093-b77a-81359dcd4a28"), "Order name 2174", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 347.992350240706m, "усл. ед" },
                    { new Guid("97f2f284-be89-4cec-aa92-b1bf5855c089"), "Order name 2451", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 811.614566799342m, "усл. ед" },
                    { new Guid("97fd5531-46ac-4bbb-9414-851641a2f4f6"), "Order name 818", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 366.498060662944m, "усл. ед" },
                    { new Guid("98057ee6-d9bf-4737-b0fa-ba2eb08751cb"), "Order name 751", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 49.2427111391465m, "усл. ед" },
                    { new Guid("980eb5fd-597a-4a02-af3e-5a08271f4e8c"), "Order name 1989", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 676.144757393175m, "усл. ед" },
                    { new Guid("983559a5-07d3-4c4e-acd0-0f78a4e4b957"), "Order name 1980", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 152.500746010352m, "усл. ед" },
                    { new Guid("983a727c-aedd-4891-94e4-ef6ae1c005e5"), "Order name 557", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 193.160751908137m, "усл. ед" },
                    { new Guid("984f5a0e-547c-4dc8-b366-d1cdd5ba6329"), "Order name 2106", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 499.400864826914m, "усл. ед" },
                    { new Guid("985b1efc-2055-45d8-ae14-95e2cff8e38d"), "Order name 1702", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 229.457524954078m, "усл. ед" },
                    { new Guid("98630637-ae18-4250-995a-98e9b7663328"), "Order name 19", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 281.58736780342m, "усл. ед" },
                    { new Guid("987db8ae-4f29-4c4b-81aa-8df05afbd695"), "Order name 1640", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 559.314951561567m, "усл. ед" },
                    { new Guid("98a08f00-8975-457c-9d9b-60dddc637c07"), "Order name 1835", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 240.110810919292m, "усл. ед" },
                    { new Guid("98ca7004-84de-4eca-8d20-738f550cc99a"), "Order name 840", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 177.867038033715m, "усл. ед" },
                    { new Guid("98de2f6a-4c5b-4438-ad42-b80bc79873ab"), "Order name 1847", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 458.089716894106m, "усл. ед" },
                    { new Guid("98e5d26c-ee6f-4d01-ac1d-fa5ed15cc58d"), "Order name 2123", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 419.180837646952m, "усл. ед" },
                    { new Guid("98eda227-c4a5-4aee-b541-b0e7b755648c"), "Order name 510", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 125.452630574374m, "усл. ед" },
                    { new Guid("98efbcac-6238-4abc-874b-28da02f0132f"), "Order name 2315", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 524.88127977895m, "усл. ед" },
                    { new Guid("9923daaf-d027-4eb1-9129-a04862edb9af"), "Order name 1333", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 339.18577250062m, "усл. ед" },
                    { new Guid("992aa195-06b1-4897-932e-e4b093e526e7"), "Order name 2064", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 52.6522983100995m, "усл. ед" },
                    { new Guid("9956bea6-bf8d-4c46-b455-0608b28bb4ff"), "Order name 2310", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 182.996393310533m, "усл. ед" },
                    { new Guid("99b4da9e-2042-4cf3-afd5-6565ffa0bd05"), "Order name 2042", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 277.267355076206m, "усл. ед" },
                    { new Guid("99cd96f8-73f2-49d4-b641-f854ed87aebd"), "Order name 1530", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 30.3115694259585m, "усл. ед" },
                    { new Guid("99d43bfd-d063-4be9-a758-0fdf0a4a2c4f"), "Order name 1247", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 262.145713315384m, "усл. ед" },
                    { new Guid("99e78cc3-9054-4156-813b-071de0d559eb"), "Order name 1280", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 381.245368880578m, "усл. ед" },
                    { new Guid("99f332f8-c2f5-45e4-ad3f-8d19db555e44"), "Order name 191", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 450.794628897139m, "усл. ед" },
                    { new Guid("99f5bfbf-fdc3-4b7f-a42f-998354e929a6"), "Order name 1145", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 250.320555943311m, "усл. ед" },
                    { new Guid("9a0cb725-c3a1-41a9-9c1d-e87036775e08"), "Order name 1589", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 151.555131959883m, "усл. ед" },
                    { new Guid("9a14c5ad-b3fb-4bce-b0f0-b3b702aa7b63"), "Order name 1052", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 16.8374882784707m, "усл. ед" },
                    { new Guid("9a37de78-6007-4884-a7c1-2bf065fef15d"), "Order name 373", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 183.122792497277m, "усл. ед" },
                    { new Guid("9a4067c6-7348-4dea-800e-4a493be4cb8c"), "Order name 744", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 200.078718281492m, "усл. ед" },
                    { new Guid("9a5cb0e3-f374-4d60-9389-106fc6a42d0b"), "Order name 2306", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 116.739438356652m, "усл. ед" },
                    { new Guid("9a99e964-3ecb-451f-8a89-172690fc04ed"), "Order name 1262", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 138.160628084131m, "усл. ед" },
                    { new Guid("9a9c48b1-190e-43b3-bf56-055f22c3b826"), "Order name 525", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 264.584482510566m, "усл. ед" },
                    { new Guid("9aae51c1-29d6-4a44-9a3d-9836e8448aca"), "Order name 1883", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 44.0206163003373m, "усл. ед" },
                    { new Guid("9ab5a605-91e0-41b6-b970-033072122bb5"), "Order name 128", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 4.69715745258727m, "усл. ед" },
                    { new Guid("9aee31a3-00d0-49fa-a822-e0f7ee6ed190"), "Order name 1967", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 454.089103310461m, "усл. ед" },
                    { new Guid("9b0ca3c7-1f9e-447f-b31f-a2f428c223ac"), "Order name 804", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 155.524028676642m, "усл. ед" },
                    { new Guid("9b0cd627-552a-4b03-8ea8-a8d12bf0c614"), "Order name 2211", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 297.841815460694m, "усл. ед" },
                    { new Guid("9b0d8260-8c66-45aa-a66d-1c328a1d8fed"), "Order name 413", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 793.223101861829m, "усл. ед" },
                    { new Guid("9b100e92-51d9-445e-9f35-8c99e612ba03"), "Order name 2158", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 458.899021443486m, "усл. ед" },
                    { new Guid("9b4a4026-d236-4543-b670-babf41196c31"), "Order name 2328", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 739.019982488948m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("9b5b0b54-658a-4647-a6a6-10a8a67ebeac"), "Order name 1488", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 2.19790383020374m, "усл. ед" },
                    { new Guid("9bbd3e3d-43a0-47a6-8ecb-1215fa8cc21d"), "Order name 1655", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 465.038960149202m, "усл. ед" },
                    { new Guid("9bd902de-80ec-4965-8e61-e7fa6075c20a"), "Order name 40", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 60.903100780376m, "усл. ед" },
                    { new Guid("9bfb7649-dd98-44fe-bcd5-aecd4846329b"), "Order name 300", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 39.1330557810172m, "усл. ед" },
                    { new Guid("9c0c9817-e336-4245-ad79-f00eb2fadaf0"), "Order name 2399", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 53.8369662685135m, "усл. ед" },
                    { new Guid("9c2681b7-fee4-4ee8-98da-7c9cf04b3120"), "Order name 1737", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 338.969116920226m, "усл. ед" },
                    { new Guid("9c370874-86df-4116-8b73-c98985f52c9c"), "Order name 1854", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 28.7041278406145m, "усл. ед" },
                    { new Guid("9c447694-7ed2-4dcd-8e25-39637b7778e1"), "Order name 304", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 7.2139754023547m, "усл. ед" },
                    { new Guid("9c7e611c-b631-4933-ac03-ac466cb3b9ff"), "Order name 1778", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 652.411823515582m, "усл. ед" },
                    { new Guid("9c8928a4-57c9-426d-83de-4aea4f411d5e"), "Order name 185", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 80.3502456282855m, "усл. ед" },
                    { new Guid("9ce2c8d3-8507-4205-a7df-faacd0c95aca"), "Order name 944", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 504.406852901945m, "усл. ед" },
                    { new Guid("9ce42212-14aa-4b13-b417-3e8ed34e6424"), "Order name 898", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 138.879744245958m, "усл. ед" },
                    { new Guid("9cf536e6-7441-4f68-b3d1-4e247917b1ac"), "Order name 1473", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 716.493301767966m, "усл. ед" },
                    { new Guid("9d17e3bf-8770-4917-918c-3293f976c181"), "Order name 30", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 21.4518722931482m, "усл. ед" },
                    { new Guid("9d392193-d6dd-456e-9459-63af1e5b000a"), "Order name 594", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 42.7787272668102m, "усл. ед" },
                    { new Guid("9d5183ac-781f-48d7-b16e-7b75d3918ac9"), "Order name 314", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 84.6937566935133m, "усл. ед" },
                    { new Guid("9d78f69b-f5a2-4152-a7b9-de1f55e1ebbc"), "Order name 1897", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 154.453442817153m, "усл. ед" },
                    { new Guid("9d7ea035-8583-4a96-bdaf-0a1843244514"), "Order name 86", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 62.1429454060556m, "усл. ед" },
                    { new Guid("9d94bfeb-09f0-4acc-851a-5c984ad2f9df"), "Order name 2358", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 6.94750575375641m, "усл. ед" },
                    { new Guid("9d9692ec-f38e-4641-b0d5-fd18e1d241e8"), "Order name 249", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 16.5398053652499m, "усл. ед" },
                    { new Guid("9da09b38-767f-4b1c-bf18-534e8da498bc"), "Order name 1731", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 562.624256272944m, "усл. ед" },
                    { new Guid("9daf2bcf-d496-4e57-955c-3fd6e6f8c873"), "Order name 1207", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 473.439674581325m, "усл. ед" },
                    { new Guid("9daff05f-0ce5-466c-ade6-a386f0c5562c"), "Order name 1073", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 874.985720902449m, "усл. ед" },
                    { new Guid("9dd2c4c0-debf-437a-8e39-42a4ee902798"), "Order name 1624", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 209.944108091983m, "усл. ед" },
                    { new Guid("9dde5ec4-1f84-49fc-98ca-130a72e44471"), "Order name 1233", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 386.426509725704m, "усл. ед" },
                    { new Guid("9de7959d-f567-4865-ade8-43fa9b01a2f3"), "Order name 859", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 114.941651129754m, "усл. ед" },
                    { new Guid("9dea2aef-e88a-422d-a54e-b80c22165a49"), "Order name 454", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 167.748588310583m, "усл. ед" },
                    { new Guid("9e20f2bd-db04-4f38-8f57-c1cef8ce05e5"), "Order name 1518", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 607.408472120004m, "усл. ед" },
                    { new Guid("9e3d2bae-cc30-492a-9b92-e91646e10f16"), "Order name 918", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 53.9631832557197m, "усл. ед" },
                    { new Guid("9e8b4d93-3c98-4fa0-a4ef-d1f78eb1274d"), "Order name 1395", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 606.156536098886m, "усл. ед" },
                    { new Guid("9e9f9ed5-d92e-43d6-871c-4858f796456d"), "Order name 2335", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 263.119658789825m, "усл. ед" },
                    { new Guid("9ed982a9-a02e-40ec-9b03-8907530282e1"), "Order name 2192", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 109.831420453553m, "усл. ед" },
                    { new Guid("9ede6a55-8dcf-4b99-adbd-0e24bcb02ac3"), "Order name 2258", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 945.053952963886m, "усл. ед" },
                    { new Guid("9f072be8-f230-44d5-b865-21e2a677f878"), "Order name 1406", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 445.112694632564m, "усл. ед" },
                    { new Guid("9f089476-c48b-4dd1-b9dc-e24ac80d0cb4"), "Order name 470", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 223.514689010369m, "усл. ед" },
                    { new Guid("9f08c39c-adc7-487b-a33a-972f8776343b"), "Order name 1872", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 351.616036097818m, "усл. ед" },
                    { new Guid("9f249a4c-1466-49f6-959e-cb09a04f450b"), "Order name 1242", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 287.115562212044m, "усл. ед" },
                    { new Guid("9f3d9f5a-8c64-4ce4-b09d-ff63a0ff3cd9"), "Order name 2275", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 168.790879943971m, "усл. ед" },
                    { new Guid("9f4445c1-25c8-4109-a30f-d0612147c8c0"), "Order name 1687", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 128.111683608224m, "усл. ед" },
                    { new Guid("9f47e43d-0f16-4938-84f8-da510947d396"), "Order name 583", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 92.9145327054788m, "усл. ед" },
                    { new Guid("9f79901d-6aca-4ee6-a52e-1694b68c039a"), "Order name 1059", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 23.2709023264825m, "усл. ед" },
                    { new Guid("9f83691d-dfa1-4bd0-8e3d-2a37ec0a539e"), "Order name 1355", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 269.610887959206m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("9fc5a50d-f188-43dc-b321-127b9fbbd226"), "Order name 15", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 604.987213293788m, "усл. ед" },
                    { new Guid("9fdab55a-2476-44a0-8852-8302a944aa9f"), "Order name 371", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 911.109121198011m, "усл. ед" },
                    { new Guid("9ff28339-3b41-4e6a-a4a2-307dd15d0611"), "Order name 1810", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 107.317281614935m, "усл. ед" },
                    { new Guid("9ffb09b7-399b-4052-b883-f89c46d3d9b9"), "Order name 364", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 442.881237350929m, "усл. ед" },
                    { new Guid("a00df357-413c-4fa5-86c9-d849d311ed59"), "Order name 351", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 349.852743409415m, "усл. ед" },
                    { new Guid("a0189ddd-ea06-4f58-85c6-b5fbdc2436f2"), "Order name 338", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 18.230811297822m, "усл. ед" },
                    { new Guid("a0354d76-1334-4031-8e25-49132ba0e4d2"), "Order name 1773", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 524.522275247798m, "усл. ед" },
                    { new Guid("a03fabad-fe60-4bd1-9d24-7d321beb7d77"), "Order name 1313", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 471.882448451614m, "усл. ед" },
                    { new Guid("a07ea3e8-5b49-4204-b188-13d38b307172"), "Order name 1689", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 21.6705094448587m, "усл. ед" },
                    { new Guid("a08b0113-ae2b-4c40-bd9f-48b01a93386c"), "Order name 2235", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 46.8755246456455m, "усл. ед" },
                    { new Guid("a0a720bf-8092-49a1-b926-cb2d8d4ae167"), "Order name 1283", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 413.69333344623m, "усл. ед" },
                    { new Guid("a0b9c9df-eb44-4894-8c54-864ea30cff2a"), "Order name 1769", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 286.816338317671m, "усл. ед" },
                    { new Guid("a0f68cae-0bc5-4b05-b9f4-6ecf423294fe"), "Order name 376", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 757.015791261333m, "усл. ед" },
                    { new Guid("a12940a4-f24a-4895-be33-dbecbb8137b9"), "Order name 942", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 247.146189748709m, "усл. ед" },
                    { new Guid("a12b2e33-b9c1-43c8-a69a-64d7bacdef10"), "Order name 1831", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 70.3659496097744m, "усл. ед" },
                    { new Guid("a13769dc-a062-4a00-8793-abf7ca8b7297"), "Order name 1620", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 212.149777702985m, "усл. ед" },
                    { new Guid("a188eb21-ebd7-4a24-b42d-9bba1e02b10f"), "Order name 2244", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 209.597215891903m, "усл. ед" },
                    { new Guid("a1962f96-516a-4aa1-b79d-1f315b2cd0b6"), "Order name 920", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 40.5376482177883m, "усл. ед" },
                    { new Guid("a19ec909-d945-4288-9d86-c4a3d5a9aa54"), "Order name 1063", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 701.929848916529m, "усл. ед" },
                    { new Guid("a1b5ddbc-ea9a-4e4c-aa77-3306c93bafe6"), "Order name 1667", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 727.862080875626m, "усл. ед" },
                    { new Guid("a2018aed-c7b4-4388-8195-216601858a73"), "Order name 2265", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 308.791627770957m, "усл. ед" },
                    { new Guid("a2034499-5250-445e-9dab-4334b5aa7249"), "Order name 1427", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 354.274984192847m, "усл. ед" },
                    { new Guid("a206e524-5c45-4d60-85a1-04bd0630a03d"), "Order name 2078", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 699.382059500059m, "усл. ед" },
                    { new Guid("a2a7a201-2ad4-4f07-b929-9fcd5db1b53f"), "Order name 591", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 473.892777315522m, "усл. ед" },
                    { new Guid("a2bec7b3-6b18-47d8-acbb-f767f923c0e0"), "Order name 62", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 259.481975071062m, "усл. ед" },
                    { new Guid("a2ce9040-8a0c-4bdb-8824-17e2f3a94d08"), "Order name 423", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 838.08925380927m, "усл. ед" },
                    { new Guid("a2d3578e-506c-46ed-84f3-9887d3c17df0"), "Order name 1544", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 833.585989639666m, "усл. ед" },
                    { new Guid("a2f616a7-72e2-4fd6-a318-de5675035aa9"), "Order name 33", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 60.7393329116207m, "усл. ед" },
                    { new Guid("a304063e-085b-4f49-bb1f-e344308c98da"), "Order name 1663", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 581.822962028563m, "усл. ед" },
                    { new Guid("a31f4ee9-4154-437a-a54c-77392134616e"), "Order name 865", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 151.7096881444m, "усл. ед" },
                    { new Guid("a325c41a-e1d3-4594-8f4e-a37867dbc2ce"), "Order name 11", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 528.748534671314m, "усл. ед" },
                    { new Guid("a32fbc9d-ef92-40ab-bac2-5048a25b7ad3"), "Order name 2286", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 588.273279316859m, "усл. ед" },
                    { new Guid("a34ea3e1-b2ac-4786-8903-73cee657d2f9"), "Order name 241", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 124.77347763319m, "усл. ед" },
                    { new Guid("a356ee62-63c4-4c08-aa72-cf7f4aa3d182"), "Order name 864", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 320.780114649632m, "усл. ед" },
                    { new Guid("a36974d8-589b-46aa-8d91-58e43820d650"), "Order name 1764", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 140.145306710698m, "усл. ед" },
                    { new Guid("a36d27d7-fa59-461a-b9b5-ee17a9256246"), "Order name 469", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 135.519370224425m, "усл. ед" },
                    { new Guid("a381ebc8-2922-4b3f-bdea-71fbae6e37c3"), "Order name 1386", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 410.951086457616m, "усл. ед" },
                    { new Guid("a3b85705-339f-453d-89d2-fd1ec28bb26d"), "Order name 1921", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 555.1996528771m, "усл. ед" },
                    { new Guid("a3c9d973-fd02-421d-88af-6bd9c9da900c"), "Order name 1763", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 856.371798994551m, "усл. ед" },
                    { new Guid("a3d06ba5-78df-41d5-b06d-a0cb6d6b3778"), "Order name 1226", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 492.297562270405m, "усл. ед" },
                    { new Guid("a3e2c43c-c17a-40f0-bbad-ff92fd797dcc"), "Order name 2200", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 157.536681343255m, "усл. ед" },
                    { new Guid("a3ea528a-677c-4b68-b3c6-8af1120964cc"), "Order name 943", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 470.482107276708m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("a401049a-7e5a-4932-9fec-59dae14f9ef2"), "Order name 1218", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 261.639527301929m, "усл. ед" },
                    { new Guid("a40fc1dc-1f60-4a8f-8ac1-cec9c423a4e1"), "Order name 1878", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 1.46430337427306m, "усл. ед" },
                    { new Guid("a411bc14-4d34-4df8-bf95-357079958218"), "Order name 1759", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 48.1344573956687m, "усл. ед" },
                    { new Guid("a42a1ac5-9291-49d6-a082-d25eecfed232"), "Order name 315", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 374.421674039928m, "усл. ед" },
                    { new Guid("a4302fb2-bc84-40ab-89b5-4797a510685f"), "Order name 1317", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 589.202912693804m, "усл. ед" },
                    { new Guid("a46e490e-3c75-4aa9-8629-3bdc0d8d51b6"), "Order name 277", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 533.305850237431m, "усл. ед" },
                    { new Guid("a49cc52e-f4e8-48a2-b5cf-15b1bf6967be"), "Order name 1779", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 221.081143670674m, "усл. ед" },
                    { new Guid("a4d3db82-ee9b-491e-8663-a0724ade4123"), "Order name 2406", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 107.483964163792m, "усл. ед" },
                    { new Guid("a4dc1045-f92f-4550-8be5-62f3c8f63cfe"), "Order name 1949", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 378.162036940393m, "усл. ед" },
                    { new Guid("a531ba43-6fef-43cc-892c-cdfc0ad6500a"), "Order name 749", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 166.870036715659m, "усл. ед" },
                    { new Guid("a566ead6-c817-403c-a178-17fcc1509c4f"), "Order name 2293", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 383.723177060407m, "усл. ед" },
                    { new Guid("a59ede88-6861-4548-905b-2ef5b11806aa"), "Order name 2031", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 10.2184042842502m, "усл. ед" },
                    { new Guid("a5a18c88-3e78-4e5a-8f1c-1e4a98f79740"), "Order name 1551", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 119.814801340398m, "усл. ед" },
                    { new Guid("a5a71e46-425e-48c9-bdca-2cf07832914c"), "Order name 1343", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 9.73167812410784m, "усл. ед" },
                    { new Guid("a5b2c31c-59fd-4aa8-ba19-8b40ddf547cf"), "Order name 805", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 127.140400127769m, "усл. ед" },
                    { new Guid("a5c1c958-be07-49ac-b91c-a9d5b09c57e8"), "Order name 1121", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 146.343829265707m, "усл. ед" },
                    { new Guid("a5eea62a-5fcc-4fd6-b09c-29985702dbce"), "Order name 317", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 114.424925743823m, "усл. ед" },
                    { new Guid("a60a0d3b-10c8-4a06-a17e-e1eb9204665b"), "Order name 599", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 23.2118150676083m, "усл. ед" },
                    { new Guid("a6292eb1-167a-4431-9490-18cc8d1b892a"), "Order name 1756", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 14.7429989309001m, "усл. ед" },
                    { new Guid("a640d4e9-8695-499a-bdac-5d44616506b3"), "Order name 2081", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 88.6484349852631m, "усл. ед" },
                    { new Guid("a65a18ac-eef3-4657-b1b9-c1c6e5605638"), "Order name 402", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 220.604305861926m, "усл. ед" },
                    { new Guid("a668e861-adba-4eb5-9f1c-98f3024d12cf"), "Order name 1538", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 593.875090240552m, "усл. ед" },
                    { new Guid("a675678b-0041-4c43-93c8-f3af862a82cd"), "Order name 718", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 237.389841186356m, "усл. ед" },
                    { new Guid("a6c30d64-822f-4f18-8e64-321f3a9c56dd"), "Order name 2269", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 87.0617458118671m, "усл. ед" },
                    { new Guid("a702f43d-2579-4415-bd2d-642025380b26"), "Order name 665", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 624.710684454254m, "усл. ед" },
                    { new Guid("a721722b-2263-45d7-940e-4aeea9c5dce4"), "Order name 1770", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 175.527463336451m, "усл. ед" },
                    { new Guid("a72b348e-8b8e-4412-b265-70bfe4a869e4"), "Order name 1659", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 190.471597273077m, "усл. ед" },
                    { new Guid("a74d4fcf-b6f0-45c4-89b8-ce7d3f012adc"), "Order name 105", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 12.1239850255671m, "усл. ед" },
                    { new Guid("a773dc00-a6a1-4b45-a66d-b65da7cfc489"), "Order name 1898", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 238.266201959688m, "усл. ед" },
                    { new Guid("a776a194-a156-4705-80a2-07e85d98fd67"), "Order name 226", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 61.0046180468146m, "усл. ед" },
                    { new Guid("a79b70ae-5f25-41eb-97c5-51d50fb550c2"), "Order name 1013", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 168.602709198047m, "усл. ед" },
                    { new Guid("a79f98ac-383a-4ef6-b258-086e2fceb750"), "Order name 7", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 22.2206140521146m, "усл. ед" },
                    { new Guid("a7a7ba95-2aaf-475b-99a6-e3058b830452"), "Order name 2453", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 25.8120818333186m, "усл. ед" },
                    { new Guid("a7b2a1a1-52b9-431f-af4b-cf30e8a4609d"), "Order name 2118", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 334.998989812024m, "усл. ед" },
                    { new Guid("a7b533a6-6e6f-4d0b-a3c1-076d5dce6171"), "Order name 999", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 29.6859019653901m, "усл. ед" },
                    { new Guid("a7b603e4-9a04-4fad-a561-f75b8e7d2321"), "Order name 919", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 293.2356900409m, "усл. ед" },
                    { new Guid("a7bea7e6-fa09-4313-b07a-2c525eb77344"), "Order name 1592", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 11.6786085407523m, "усл. ед" },
                    { new Guid("a7c1c38b-fd01-40a4-9611-b7c295d098c9"), "Order name 196", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 161.552301928245m, "усл. ед" },
                    { new Guid("a7c4388d-0390-44f5-a1ce-673e1150eac0"), "Order name 882", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 114.779711804654m, "усл. ед" },
                    { new Guid("a7ceba32-dfdd-42cb-b11c-ad930b61ff3a"), "Order name 385", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 901.402914609939m, "усл. ед" },
                    { new Guid("a7ec4216-a531-402c-a048-caf9de84760c"), "Order name 1985", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 6.77350653519508m, "усл. ед" },
                    { new Guid("a867996c-0e64-4c79-86e8-c5fef30c690c"), "Order name 370", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 131.424880262309m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("a88471dc-d8ad-45b3-9558-2ebeb23c6f74"), "Order name 1290", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 841.622684488058m, "усл. ед" },
                    { new Guid("a88dfdf1-9bea-4053-bcce-86f2882512d0"), "Order name 1135", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 11.0584130551705m, "усл. ед" },
                    { new Guid("a8b20b6e-af26-45f6-bb9a-08994015baea"), "Order name 2205", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 372.654771595068m, "усл. ед" },
                    { new Guid("a8b54588-22a1-40fa-8fee-b41905d26087"), "Order name 684", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 224.280197395157m, "усл. ед" },
                    { new Guid("a8bf2d7f-588e-4e52-8d3e-2e8e73ba7fdd"), "Order name 244", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 420.512362770913m, "усл. ед" },
                    { new Guid("a8d8e538-4373-471f-845b-a4423da7bb20"), "Order name 812", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 399.304548721211m, "усл. ед" },
                    { new Guid("a9084e7f-a280-4a7c-a4ac-b1ee5ecd1362"), "Order name 22", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 709.562472234132m, "усл. ед" },
                    { new Guid("a9126c3b-fe79-445e-9e68-bcbf5196199a"), "Order name 2010", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 81.6794182990253m, "усл. ед" },
                    { new Guid("a913be2c-ff24-483d-97d7-57c5d3b9d306"), "Order name 1133", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 173.019497889949m, "усл. ед" },
                    { new Guid("a91b04af-1ff5-4a53-9b3f-0c994ff390da"), "Order name 2204", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 201.028809170997m, "усл. ед" },
                    { new Guid("a93a4d6d-dd37-4e8f-bc79-d69dd66ea4b2"), "Order name 834", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 35.3622682080932m, "усл. ед" },
                    { new Guid("a953656b-0808-48c7-af6c-7a40bd1a16e3"), "Order name 1265", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 283.871899443676m, "усл. ед" },
                    { new Guid("a96080a4-47e4-498e-b6b2-6327e554264a"), "Order name 2304", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 189.019043484585m, "усл. ед" },
                    { new Guid("a97d7db6-a9c6-45e3-b366-6a540f5b9b2c"), "Order name 1556", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 219.659114182112m, "усл. ед" },
                    { new Guid("a9918d5e-e57c-4476-aa6b-dcdd58ada6da"), "Order name 1802", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 709.620588952613m, "усл. ед" },
                    { new Guid("a998e961-6b8b-4a5d-bb62-01d0ea99b0f5"), "Order name 2500", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 866.062711342794m, "усл. ед" },
                    { new Guid("a99c6b73-15ef-4026-b783-ae2c0df4b9c8"), "Order name 2068", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 174.552072482332m, "усл. ед" },
                    { new Guid("a9fa4b7b-36d7-4804-9e02-a1ab1c2879ca"), "Order name 1342", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 270.411912172872m, "усл. ед" },
                    { new Guid("aa102be2-e6e3-4335-befd-c57267e6dfd7"), "Order name 2409", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 186.15714986321m, "усл. ед" },
                    { new Guid("aa2de2e1-aad4-4664-b635-e990a61f1eb8"), "Order name 711", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 247.062716111425m, "усл. ед" },
                    { new Guid("aa6d2671-5186-4126-82c7-7ba1c19b53db"), "Order name 1639", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 165.390269588423m, "усл. ед" },
                    { new Guid("aa8dce88-ec91-4bd5-bc90-b57b2d22173f"), "Order name 2397", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 466.741896338549m, "усл. ед" },
                    { new Guid("aa9bce3a-7497-4fef-a1e4-1856b7520798"), "Order name 2367", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 192.692669029574m, "усл. ед" },
                    { new Guid("ab19f62a-e611-4268-8369-ad46c0edec8c"), "Order name 1969", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 324.591025660559m, "усл. ед" },
                    { new Guid("ab226e2d-fc06-4e05-a9a4-c997a3ca34b0"), "Order name 206", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 630.258682967224m, "усл. ед" },
                    { new Guid("ab557a98-22f3-44d2-9d28-ef680b9a71ef"), "Order name 1574", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 531.892180760718m, "усл. ед" },
                    { new Guid("ab591149-3904-4d5f-9846-700a13bdc115"), "Order name 133", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 258.311925743058m, "усл. ед" },
                    { new Guid("ab65b5df-d605-4963-ac83-8860fc91344a"), "Order name 80", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 351.496521350664m, "усл. ед" },
                    { new Guid("ab7f0369-dcf9-4e1c-8a0c-865a4a5fec47"), "Order name 41", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 278.605554439432m, "усл. ед" },
                    { new Guid("ab87af4c-21d4-43a9-8792-c377b3dbf650"), "Order name 1461", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 368.235981919247m, "усл. ед" },
                    { new Guid("ab90ff28-3b82-4124-bb06-b962736d5742"), "Order name 420", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 322.814939213013m, "усл. ед" },
                    { new Guid("aba5f641-3ba0-4680-89a7-0bbae41fdfad"), "Order name 310", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 205.707607145639m, "усл. ед" },
                    { new Guid("aba7b3df-3413-4844-89f1-f9f7e1f5d1d3"), "Order name 1072", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 305.44690270369m, "усл. ед" },
                    { new Guid("aba95cdc-5fa3-4fd1-b8c1-576711be2590"), "Order name 974", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 141.563544814536m, "усл. ед" },
                    { new Guid("abac7a8f-7f0d-473a-8a12-c2e2a4b11d66"), "Order name 931", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 142.490673590371m, "усл. ед" },
                    { new Guid("abd2111e-a9ee-4815-b2b2-6132ce021b4f"), "Order name 2014", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 154.945409006502m, "усл. ед" },
                    { new Guid("abfc724e-e0fa-4bf8-9331-8d0ffbbed29b"), "Order name 390", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 592.317329458406m, "усл. ед" },
                    { new Guid("ac0874a9-6223-4557-a26b-5c00daaea9f1"), "Order name 710", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 7.12869757906895m, "усл. ед" },
                    { new Guid("ac185d4e-9963-49fd-8ef2-71026b14d0be"), "Order name 1237", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 781.535375267701m, "усл. ед" },
                    { new Guid("ac3323fd-f657-4951-9a5a-f0394488ad08"), "Order name 515", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 422.886492646301m, "усл. ед" },
                    { new Guid("ac543331-0e99-419d-8f44-0f33788fb807"), "Order name 1381", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 234.858719790399m, "усл. ед" },
                    { new Guid("acd78717-ebb8-4b0a-b030-9531c2188f90"), "Order name 2194", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 62.7044720754752m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("acf7a0c7-f47d-418c-8adb-72deeee8b7a6"), "Order name 1021", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 169.448437280378m, "усл. ед" },
                    { new Guid("ad013933-515e-4211-a45e-191d0e602bfb"), "Order name 989", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 29.0965056732298m, "усл. ед" },
                    { new Guid("ad2a867b-9b3b-4253-9cce-55b2a5d6c110"), "Order name 889", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 515.497303355914m, "усл. ед" },
                    { new Guid("ad56ab68-fa21-46a9-a453-1320965d3663"), "Order name 1264", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 539.445217607001m, "усл. ед" },
                    { new Guid("ad5f25d4-f46a-49f1-9fac-062ce486839d"), "Order name 695", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 267.552790000165m, "усл. ед" },
                    { new Guid("ad614d6e-15a1-4c07-94b1-7aee8cecaea2"), "Order name 928", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 0.0410641360896293m, "усл. ед" },
                    { new Guid("add2b288-0b4d-49c9-ae7f-426b7109a82d"), "Order name 2402", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 195.263532025962m, "усл. ед" },
                    { new Guid("ade906e8-150c-47c3-8289-7da149fbc2c4"), "Order name 1418", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 57.4651938537198m, "усл. ед" },
                    { new Guid("ae16cc57-89dc-4b14-8e3e-ef1ce5e214ca"), "Order name 389", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 298.325513294197m, "усл. ед" },
                    { new Guid("ae3e951b-dbd1-42f1-9b40-45aa986e81f0"), "Order name 480", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 144.465087619914m, "усл. ед" },
                    { new Guid("ae6b3fe5-6fc0-4f99-8d3e-e494b263ca0c"), "Order name 1080", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 4.91580525101688m, "усл. ед" },
                    { new Guid("ae9dba0b-0331-40ee-880b-8dde751d9830"), "Order name 1602", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 18.1206109543713m, "усл. ед" },
                    { new Guid("aeb52038-958a-4374-acdb-388d88712bf5"), "Order name 2268", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 85.7084167829965m, "усл. ед" },
                    { new Guid("aebe686a-f280-4cd1-b7f8-73bbb4438479"), "Order name 969", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 121.671460869771m, "усл. ед" },
                    { new Guid("aee604c4-b962-4709-93f8-234ac12eadfd"), "Order name 2410", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 25.2882500182604m, "усл. ед" },
                    { new Guid("aefac107-fd44-40e7-b316-8f567ec19b95"), "Order name 538", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 242.598401191398m, "усл. ед" },
                    { new Guid("af161887-3405-4f38-b765-1066240d65cd"), "Order name 1441", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 497.796958838996m, "усл. ед" },
                    { new Guid("af1bb910-059f-470b-ab16-07cec8559ef7"), "Order name 1138", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 183.802312288149m, "усл. ед" },
                    { new Guid("af3f4b23-6c01-4658-82bb-0b7c54ac85f7"), "Order name 1569", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 166.143390001023m, "усл. ед" },
                    { new Guid("af4059eb-f5fe-4466-85ee-4ed742d0c0b4"), "Order name 1541", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 475.369459957607m, "усл. ед" },
                    { new Guid("af4c805c-ac54-4c81-90e1-b0e678ff8bef"), "Order name 1125", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 508.466299502895m, "усл. ед" },
                    { new Guid("af51aee0-87fd-4326-85fa-3ba7d5302725"), "Order name 676", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 232.14640199388m, "усл. ед" },
                    { new Guid("af68af52-446c-4607-aeec-48bfb6134949"), "Order name 533", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 255.565734947999m, "усл. ед" },
                    { new Guid("af6bc953-0222-4b19-8b1f-5f9e12e70389"), "Order name 197", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 143.300971013053m, "усл. ед" },
                    { new Guid("af770f31-a384-4681-b241-5ccd9e60c866"), "Order name 1653", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 326.240300127553m, "усл. ед" },
                    { new Guid("afb5d101-6031-43c8-bf07-02aeb0a490dd"), "Order name 761", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 841.088545981806m, "усл. ед" },
                    { new Guid("afd0fa63-1499-492c-bbc6-0f6b77aa25aa"), "Order name 575", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 212.474261416965m, "усл. ед" },
                    { new Guid("afd13e1e-b84c-448a-8213-4a56df7a9388"), "Order name 1775", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 31.4346041101291m, "усл. ед" },
                    { new Guid("afe2ddb5-7b76-42d0-b7a9-796ef3227ec6"), "Order name 2445", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 91.5157941408532m, "усл. ед" },
                    { new Guid("aff1437a-3f21-4af3-ac71-569150537b74"), "Order name 846", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 357.438713212192m, "усл. ед" },
                    { new Guid("aff59d66-bc34-451f-9e55-5ebe5b0ce7bb"), "Order name 1434", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 700.715246268648m, "усл. ед" },
                    { new Guid("b00044f9-50c2-4d30-aaf2-13121f915933"), "Order name 1187", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 79.2621695531523m, "усл. ед" },
                    { new Guid("b001d52a-cca8-4586-9230-f455ab51774d"), "Order name 81", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 68.6329288541809m, "усл. ед" },
                    { new Guid("b021615a-f55b-4e87-b0d2-ee3ee2ab1a46"), "Order name 733", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 323.444442693943m, "усл. ед" },
                    { new Guid("b03ba18f-2316-4bec-894e-50e2987a03eb"), "Order name 2083", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 256.641212494368m, "усл. ед" },
                    { new Guid("b08ab26f-5f33-4718-80f8-fcc9209ad200"), "Order name 929", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 19.2809472797027m, "усл. ед" },
                    { new Guid("b0bfa910-3a9c-4010-8904-a034834dde23"), "Order name 653", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 60.0248039163674m, "усл. ед" },
                    { new Guid("b0c697a1-fcd4-4c98-8ff7-4256c0c26aed"), "Order name 843", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 439.326763510301m, "усл. ед" },
                    { new Guid("b0d6945f-cfa5-40ad-870d-f190751d6fc8"), "Order name 209", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 871.504343298788m, "усл. ед" },
                    { new Guid("b0df46c8-9ea6-4f2c-a79a-928cb85a585f"), "Order name 1440", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 297.573450810408m, "усл. ед" },
                    { new Guid("b0e5850a-01d6-49da-b542-d19d48c6f721"), "Order name 1162", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 318.963322628363m, "усл. ед" },
                    { new Guid("b1031885-3d07-47ea-a874-184a4a8a63d0"), "Order name 2421", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 708.11038872663m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("b10730a1-6455-4059-99ac-4a6cf4967f48"), "Order name 516", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 365.480978161981m, "усл. ед" },
                    { new Guid("b12337a8-e503-4d03-90b9-311bebab6aaa"), "Order name 1830", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 876.268265426899m, "усл. ед" },
                    { new Guid("b12d6dfa-19df-481c-98e2-6d1ad66b8add"), "Order name 2206", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 216.249705609747m, "усл. ед" },
                    { new Guid("b1657003-69c6-443d-adb6-8570d82475f6"), "Order name 807", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 199.158724319526m, "усл. ед" },
                    { new Guid("b1657b72-d10d-4d78-ac22-3dbe98c0c3dc"), "Order name 986", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 314.421235940055m, "усл. ед" },
                    { new Guid("b182ccb0-df6b-43bd-a3a0-9a3005f24ead"), "Order name 17", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 143.730616627143m, "усл. ед" },
                    { new Guid("b1c2469e-d52c-41cc-a482-981d76ac97cf"), "Order name 1122", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 656.610977791715m, "усл. ед" },
                    { new Guid("b1d2d6bb-491a-4fde-ab80-d2797428a9ed"), "Order name 1012", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 34.3868503624495m, "усл. ед" },
                    { new Guid("b1d8a696-132b-4b76-b62d-74145ebc36f8"), "Order name 1230", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 560.321069579229m, "усл. ед" },
                    { new Guid("b1f9a4cc-d38f-40b7-90c2-62154dce6f1b"), "Order name 2435", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 266.526322097046m, "усл. ед" },
                    { new Guid("b216dbb1-d420-4c96-ac05-6b3cce159e30"), "Order name 2029", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 596.878975396278m, "усл. ед" },
                    { new Guid("b228c102-53fe-4c8f-8514-024f6cd2d780"), "Order name 566", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 515.380026742003m, "усл. ед" },
                    { new Guid("b2349f2f-24e9-4288-b4f2-24098519d2c6"), "Order name 2212", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 170.099481386385m, "усл. ед" },
                    { new Guid("b24b67d8-897f-44d0-b486-cb5424dada35"), "Order name 647", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 234.041548260288m, "усл. ед" },
                    { new Guid("b2584877-da03-45aa-b68e-a825edf14efd"), "Order name 1389", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 306.541600882903m, "усл. ед" },
                    { new Guid("b273b44c-a917-4db1-9ce7-23445503703f"), "Order name 1156", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 301.814741513105m, "усл. ед" },
                    { new Guid("b28847ad-3c3a-4749-93f5-d4f2c82b26f6"), "Order name 1973", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 271.788938584802m, "усл. ед" },
                    { new Guid("b2bdeb53-919d-4eaf-b3bf-0bdcd84817a9"), "Order name 1616", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 40.3093747823075m, "усл. ед" },
                    { new Guid("b2ce3796-972d-479d-b10f-1d9d2dcf1754"), "Order name 1035", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 84.1700741531621m, "усл. ед" },
                    { new Guid("b2fe5621-1de5-4a30-9c5c-8fc898024dc6"), "Order name 1981", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 108.780475889679m, "усл. ед" },
                    { new Guid("b30ef6aa-78bd-433f-92bb-712682ed7066"), "Order name 851", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 389.421144366336m, "усл. ед" },
                    { new Guid("b3152343-aece-45a0-b550-4421b6e03ee4"), "Order name 2240", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 72.1497839795435m, "усл. ед" },
                    { new Guid("b32b6d41-dcb0-4710-96a4-92759b372f56"), "Order name 628", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 503.787051691433m, "усл. ед" },
                    { new Guid("b3691b97-76d2-474e-b9c6-0eb4bad588e8"), "Order name 1956", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 143.911056724274m, "усл. ед" },
                    { new Guid("b3739c42-616a-4979-96f0-b8c41d86e1f3"), "Order name 763", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 48.5660233576158m, "усл. ед" },
                    { new Guid("b3928d95-a5ab-460d-93b4-4d46fb407f2e"), "Order name 2303", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 4.6438108167939m, "усл. ед" },
                    { new Guid("b3ba51d6-6e61-4fb9-b25c-916479b70f08"), "Order name 957", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 270.886910645353m, "усл. ед" },
                    { new Guid("b3efee25-29f5-485c-bcca-6a37e15e133d"), "Order name 21", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 757.128364541991m, "усл. ед" },
                    { new Guid("b4144c41-4cbe-426a-9a24-89f9f8d13bbf"), "Order name 842", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 26.8846540893616m, "усл. ед" },
                    { new Guid("b4202390-05cd-4ed3-8b7d-3f9594744f2c"), "Order name 2455", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 463.929243697869m, "усл. ед" },
                    { new Guid("b42a9901-5c9f-42b8-b03b-3c0ff666f8cd"), "Order name 1471", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 128.137132098962m, "усл. ед" },
                    { new Guid("b469e77b-6b70-4b01-96aa-3e17e16dc8cb"), "Order name 1385", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 430.875012966531m, "усл. ед" },
                    { new Guid("b46b9791-7c6e-4096-ac8a-2e7f34f7c8fc"), "Order name 1363", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 268.788974548556m, "усл. ед" },
                    { new Guid("b47fab5c-f707-47ea-af11-286764c7eb14"), "Order name 189", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 300.761537086366m, "усл. ед" },
                    { new Guid("b483bb7c-213a-449b-a3ae-c6c63e2945c0"), "Order name 1151", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 92.0263204634004m, "усл. ед" },
                    { new Guid("b4990d4e-d401-4845-af9b-38afc0b90010"), "Order name 1047", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 126.405950458503m, "усл. ед" },
                    { new Guid("b49edadb-0d2e-4661-b75c-189a3149c569"), "Order name 644", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 45.8114146553092m, "усл. ед" },
                    { new Guid("b4b2777b-1f38-48cc-80d5-f4b4c01bfc30"), "Order name 2351", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 114.131179863468m, "усл. ед" },
                    { new Guid("b4b4d386-0b54-4f01-b70d-dfd15744f617"), "Order name 2245", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 140.46620844456m, "усл. ед" },
                    { new Guid("b4c22ec5-e8a9-4ec6-aaa2-5147ddc75c40"), "Order name 738", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 66.9613545218302m, "усл. ед" },
                    { new Guid("b4ce3b9a-b83c-4931-af57-3c2aa03f4ddb"), "Order name 1483", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 288.346252488336m, "усл. ед" },
                    { new Guid("b4e14753-dc43-42a2-a3fc-778b0de056bd"), "Order name 1579", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 202.793335111061m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("b527178b-ba8b-4cba-8d45-f6e2b93355c7"), "Order name 991", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 89.0512865259059m, "усл. ед" },
                    { new Guid("b5323369-9145-42b0-9018-716516c0f76c"), "Order name 691", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 82.8652167287735m, "усл. ед" },
                    { new Guid("b54e3a62-56d8-4ae7-938f-5ce48c0fe1a7"), "Order name 2149", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 259.03240336588m, "усл. ед" },
                    { new Guid("b550c8b4-1f06-45cf-9a34-86938296c683"), "Order name 2432", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 472.941301518398m, "усл. ед" },
                    { new Guid("b57ab3c3-c14c-4fe8-bc66-6c13fbf64e5c"), "Order name 554", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 238.884464049274m, "усл. ед" },
                    { new Guid("b5c617bc-6a7c-4dc8-9495-a3c181fb4db0"), "Order name 821", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 6.66529082587854m, "усл. ед" },
                    { new Guid("b60d4377-b56a-4e0a-85f1-b23a7cf675a0"), "Order name 35", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 248.346585001261m, "усл. ед" },
                    { new Guid("b61d8509-342e-42e8-96fc-ced9955417d2"), "Order name 1398", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 393.951769678627m, "усл. ед" },
                    { new Guid("b659c34c-f419-4736-845d-77eec170e1c7"), "Order name 2391", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 227.14580963997m, "усл. ед" },
                    { new Guid("b66ea4fb-a32e-41ed-9b94-5ba73a1c17d9"), "Order name 337", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 408.495152195558m, "усл. ед" },
                    { new Guid("b6754d89-7b49-4d02-b480-b3545f055e5c"), "Order name 2227", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 598.047986888921m, "усл. ед" },
                    { new Guid("b6776ad6-f422-4067-820a-3e68cb0cefcb"), "Order name 1561", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 393.425021840847m, "усл. ед" },
                    { new Guid("b67e9c3e-21a0-4762-8d76-de52ca323555"), "Order name 1017", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 10.5000205053266m, "усл. ед" },
                    { new Guid("b6c47a38-1d88-4cac-a24a-8a78583989a6"), "Order name 1584", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 784.23117753553m, "усл. ед" },
                    { new Guid("b6cfcdf5-4a37-458c-9669-94ff25757369"), "Order name 1155", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 29.723446979917m, "усл. ед" },
                    { new Guid("b6fe68ce-3673-4531-8efd-00846e0b67ba"), "Order name 1554", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 348.932211583651m, "усл. ед" },
                    { new Guid("b70eb3b0-7bd6-492f-a0e7-1eff574f6435"), "Order name 2414", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 614.514568654193m, "усл. ед" },
                    { new Guid("b71e4c01-8069-4fba-911b-a7431db9453a"), "Order name 2021", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 441.323191788264m, "усл. ед" },
                    { new Guid("b729ab88-b0f5-4153-bfcf-f1e6a1f81fe8"), "Order name 1767", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 43.4300083497613m, "усл. ед" },
                    { new Guid("b76b9d61-6654-48ea-bd7a-542b2fcda4e5"), "Order name 2339", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 286.506260198392m, "усл. ед" },
                    { new Guid("b7b4667e-2917-4468-8f3a-793e0d3ac5c6"), "Order name 1153", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 185.350106805256m, "усл. ед" },
                    { new Guid("b7bef3b9-85e5-4225-9815-a28b9b1f0514"), "Order name 1971", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 142.921198501372m, "усл. ед" },
                    { new Guid("b7bf8ad9-72bc-4789-b949-371ac9e805e6"), "Order name 2189", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 114.609631781392m, "усл. ед" },
                    { new Guid("b7c560fe-73fa-4ad6-8006-6f147ae81e17"), "Order name 257", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 394.689987687844m, "усл. ед" },
                    { new Guid("b7cd4cc6-5567-48bc-999e-f34cc0f95e2c"), "Order name 127", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 798.328470168757m, "усл. ед" },
                    { new Guid("b7fe874e-fe3b-4442-b95c-801c2f9fca14"), "Order name 504", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 249.014433487598m, "усл. ед" },
                    { new Guid("b828a49c-efc7-4db2-ba28-e4eb566e23f0"), "Order name 471", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 317.030720711315m, "усл. ед" },
                    { new Guid("b84b5755-bde5-425d-aa08-e982540adaa2"), "Order name 766", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 90.9844679353363m, "усл. ед" },
                    { new Guid("b880cfb8-7003-4f3f-bab2-d4d0f4068396"), "Order name 1083", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 244.128784909103m, "усл. ед" },
                    { new Guid("b882cc1e-9508-4132-b9b4-1367ec42521c"), "Order name 1942", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 563.587729229891m, "усл. ед" },
                    { new Guid("b88408a1-2458-4685-8c55-a439d44f9a35"), "Order name 1850", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 152.619118572748m, "усл. ед" },
                    { new Guid("b8c93f95-7428-4cb6-984d-56cef6fe7e18"), "Order name 2263", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 119.20939276542m, "усл. ед" },
                    { new Guid("b8cbd037-9816-4c39-8e01-320f72c76c7f"), "Order name 1521", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 233.184708010093m, "усл. ед" },
                    { new Guid("b8d029d5-2d6a-4b6a-9689-d8a7f6cefb49"), "Order name 1884", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 269.671841701012m, "усл. ед" },
                    { new Guid("b8d30267-d9a2-46e6-a715-3d7e4887b762"), "Order name 1436", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 177.786293541375m, "усл. ед" },
                    { new Guid("b8d85f5f-3341-4c7a-bd6a-8e9f8e93981e"), "Order name 1246", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 560.703944974923m, "усл. ед" },
                    { new Guid("b8f13e7f-242b-4cff-89b2-bcae5b62b9b0"), "Order name 1391", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 129.519126862003m, "усл. ед" },
                    { new Guid("b8fe349b-71e0-4710-9bd6-b560ca63676b"), "Order name 1303", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 353.68580304651m, "усл. ед" },
                    { new Guid("b903aa92-c83a-4690-9a82-6535dfafc2d4"), "Order name 215", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 495.625389749921m, "усл. ед" },
                    { new Guid("b9733e14-0aef-4d73-afd4-38267fce98c6"), "Order name 624", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 610.123336882474m, "усл. ед" },
                    { new Guid("b97947ab-f2c6-41cf-8732-4dd5c864c5ef"), "Order name 2126", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 471.175984198331m, "усл. ед" },
                    { new Guid("b987936d-a44e-4cb5-a69a-5fc67c9669a0"), "Order name 1359", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 139.757423972788m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("b9a90d14-2f99-4a73-aa5b-5506a5a26622"), "Order name 2364", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 25.1166856095573m, "усл. ед" },
                    { new Guid("b9ec13a6-3a94-44ef-a691-d8b120d28af8"), "Order name 100", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 172.783916397754m, "усл. ед" },
                    { new Guid("ba1e6368-8313-490a-9ee3-d9d3bfdf120b"), "Order name 1452", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 329.64165843785m, "усл. ед" },
                    { new Guid("ba2301ba-3371-4cd0-ad5e-c8ff50a387fc"), "Order name 823", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 185.736543735982m, "усл. ед" },
                    { new Guid("ba2e3c47-574d-4e90-aee8-8ab292c878a8"), "Order name 2417", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 302.087976249161m, "усл. ед" },
                    { new Guid("ba320666-31ab-4c02-98d5-5d5889c3a8d1"), "Order name 1853", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 592.710294849534m, "усл. ед" },
                    { new Guid("ba466de3-bdac-4e79-b9d0-7aab6c0165f6"), "Order name 2327", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 126.755621920462m, "усл. ед" },
                    { new Guid("ba48a287-32eb-4e46-b0a0-24a9d132a3d7"), "Order name 976", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 229.969200812466m, "усл. ед" },
                    { new Guid("ba4bd798-ffa9-4689-9cb7-8393ff087ee9"), "Order name 1695", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 164.051727779252m, "усл. ед" },
                    { new Guid("ba4c48ef-2689-4f94-9056-640fbe5a7cbd"), "Order name 727", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 132.945315343591m, "усл. ед" },
                    { new Guid("ba514b41-421b-442c-83df-85ae6e533c91"), "Order name 1540", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 193.897888394659m, "усл. ед" },
                    { new Guid("ba728c1a-00d3-4257-82b5-9e6f23f6e3b3"), "Order name 912", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 586.126959176474m, "усл. ед" },
                    { new Guid("ba7f77a0-6a01-4c43-ae26-9ed100149fb0"), "Order name 1390", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 553.425019815749m, "усл. ед" },
                    { new Guid("bacee893-9dd2-4508-8642-f6ea07241d63"), "Order name 144", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 251.391882817186m, "усл. ед" },
                    { new Guid("badc1a7a-42fd-4a9c-8f5f-8c64a2afd68d"), "Order name 2356", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 141.663386413521m, "усл. ед" },
                    { new Guid("bae1bbb1-8607-42bf-8655-4d1c055af59f"), "Order name 1915", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 120.611076321732m, "усл. ед" },
                    { new Guid("bb2b7621-5dbd-4582-99e3-ab74c49aeae1"), "Order name 1929", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 132.80990023041m, "усл. ед" },
                    { new Guid("bb43c584-d9ac-4386-b722-f9930f8dc0da"), "Order name 1120", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 311.305474899334m, "усл. ед" },
                    { new Guid("bb4ee73d-e0fb-490a-9926-b1a977b2debc"), "Order name 897", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 284.429747488701m, "усл. ед" },
                    { new Guid("bb55444d-7e08-4872-b7f0-8afa84ae9ebf"), "Order name 245", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 57.1455729720096m, "усл. ед" },
                    { new Guid("bb60bae8-6643-4102-9458-7b0a2af0a88f"), "Order name 444", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 165.734659096106m, "усл. ед" },
                    { new Guid("bb68bb25-bdac-49cf-a8a3-0f09925a632f"), "Order name 780", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 518.503324222514m, "усл. ед" },
                    { new Guid("bb79fda8-370b-429b-9c0d-efa852a3322e"), "Order name 1354", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 255.097641497019m, "усл. ед" },
                    { new Guid("bb889e3b-e188-4799-be2e-77d56226c006"), "Order name 973", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 438.821658841789m, "усл. ед" },
                    { new Guid("bb9cac86-dbc6-4986-aae4-3274ae3cdfae"), "Order name 2473", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 97.9235510165964m, "усл. ед" },
                    { new Guid("bbb8d7d7-14e9-4e1b-8d61-4db98a640949"), "Order name 26", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 159.547493953778m, "усл. ед" },
                    { new Guid("bbe1e463-62ae-4d2c-950b-1deb1ea53e46"), "Order name 152", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 69.3950745949916m, "усл. ед" },
                    { new Guid("bc07125d-07b6-4e4b-aa7e-0a07c35edd67"), "Order name 1824", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 67.6855146452578m, "усл. ед" },
                    { new Guid("bc0923a1-9238-4dae-a603-a9a3d530abb0"), "Order name 1852", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 66.3191897219584m, "усл. ед" },
                    { new Guid("bc249837-bb1a-4a58-a8a2-449741822610"), "Order name 1312", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 245.310226927475m, "усл. ед" },
                    { new Guid("bc32a7bd-2362-485d-859b-290549dfb6f7"), "Order name 2312", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 140.033426800331m, "усл. ед" },
                    { new Guid("bc526d1f-ab4c-437e-b384-5841a994641d"), "Order name 712", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 5.278574519764m, "усл. ед" },
                    { new Guid("bc5b5e99-b527-4586-ac0d-0585cbc6a129"), "Order name 1722", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 210.41629883744m, "усл. ед" },
                    { new Guid("bc6af5dc-d971-4b60-b0e6-8c362d400add"), "Order name 36", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 184.296809846325m, "усл. ед" },
                    { new Guid("bc71bf46-f935-450b-95de-231269204400"), "Order name 1358", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 515.213790892453m, "усл. ед" },
                    { new Guid("bc755ac5-ea6f-4b84-8306-79dd93545891"), "Order name 619", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 107.926846454438m, "усл. ед" },
                    { new Guid("bcabbf28-5091-4d23-901a-e4592796ce49"), "Order name 1864", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 43.4830197613073m, "усл. ед" },
                    { new Guid("bcac4dfd-e6c4-417f-a0ee-0bdb5aed9ca4"), "Order name 418", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 134.985293571702m, "усл. ед" },
                    { new Guid("bccdb109-af88-4868-bc4e-03940801a571"), "Order name 429", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 182.281247528269m, "усл. ед" },
                    { new Guid("bce7dab4-8fd2-456f-afe8-2cc062cc3475"), "Order name 1598", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 371.191097064958m, "усл. ед" },
                    { new Guid("bcf2cd34-5a3a-4c7a-92af-cb31ad5fd2cb"), "Order name 1217", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 662.544204778273m, "усл. ед" },
                    { new Guid("bd0a015d-fb83-4455-a6a4-3714247f1987"), "Order name 217", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 164.55150394389m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("bd1552d2-f9bc-48f5-a92e-396ed24d61d4"), "Order name 230", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 62.2139748392817m, "усл. ед" },
                    { new Guid("bd1c5ea6-a5b5-4542-bf4d-47479cd02f8f"), "Order name 1091", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 174.986382479351m, "усл. ед" },
                    { new Guid("bd278e31-7ae9-4139-b66c-e816335f60eb"), "Order name 2177", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 111.136409934768m, "усл. ед" },
                    { new Guid("bd2b2000-d36a-4996-919f-e49b25a08929"), "Order name 2474", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 396.126632099866m, "усл. ед" },
                    { new Guid("bd336eda-a2d9-4cac-ae9b-72dc8c810526"), "Order name 1622", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 191.237035106449m, "усл. ед" },
                    { new Guid("bd5cd382-23a6-4cba-8aef-2ccc3b3e0b96"), "Order name 2130", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 742.578083854837m, "усл. ед" },
                    { new Guid("bd659be7-894d-4e4f-9269-c6c37d1a27c0"), "Order name 1733", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 125.484078437861m, "усл. ед" },
                    { new Guid("bd7b1b10-f0f6-4124-abc9-25783c53a320"), "Order name 59", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 303.421540158851m, "усл. ед" },
                    { new Guid("bd83c7a2-ecfe-4029-a256-fb0033e940f7"), "Order name 1078", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 260.975271965563m, "усл. ед" },
                    { new Guid("bd8c5bfa-2aa9-495e-950a-1d4b75e9d1b7"), "Order name 1032", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 73.6951679447421m, "усл. ед" },
                    { new Guid("bdd0952f-c326-4a75-862b-6b265d9d446c"), "Order name 342", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 600.962713164335m, "усл. ед" },
                    { new Guid("bde4e103-8555-4126-9c40-00405c0fe550"), "Order name 798", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 715.191994734397m, "усл. ед" },
                    { new Guid("bdf1337c-eee8-45d4-8743-557ab51c3f7c"), "Order name 92", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 254.933483983852m, "усл. ед" },
                    { new Guid("bdfb333b-c4a6-4484-9430-619f4a0c4bb3"), "Order name 24", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 348.634053320137m, "усл. ед" },
                    { new Guid("be228bc3-aab7-4d50-9a79-5e9e6e3ff45b"), "Order name 1001", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 555.079223965168m, "усл. ед" },
                    { new Guid("be29f1ae-9802-44f2-b28f-4340b8484ecb"), "Order name 764", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 685.352309705744m, "усл. ед" },
                    { new Guid("be31b12d-f0e3-4ab1-8b07-3bbe85b62308"), "Order name 765", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 84.5539349476628m, "усл. ед" },
                    { new Guid("be5f9eaa-7bd8-41a6-ab01-5466298782bc"), "Order name 543", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 260.402172021304m, "усл. ед" },
                    { new Guid("be73ad6b-438b-4440-b7b7-6a12dbe1b5c2"), "Order name 43", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 121.801728466736m, "усл. ед" },
                    { new Guid("be740b72-d559-4985-ba5c-6cbc25974527"), "Order name 2061", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 311.00543066331m, "усл. ед" },
                    { new Guid("be8239ee-d103-47bd-8fdb-907b168a58ce"), "Order name 2491", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 181.408845598504m, "усл. ед" },
                    { new Guid("be84e7b3-e715-415a-a158-da83dcf9097b"), "Order name 1931", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 46.0636379200283m, "усл. ед" },
                    { new Guid("be9fa7aa-b89b-4706-8e8c-63fd37cc026a"), "Order name 203", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 172.970812930184m, "усл. ед" },
                    { new Guid("bea71f8b-4b9b-4587-b14a-c5990e364920"), "Order name 1922", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 660.042862271397m, "усл. ед" },
                    { new Guid("bec1f087-7f57-4535-82e1-ee8fc7a13e33"), "Order name 626", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 76.3537120368295m, "усл. ед" },
                    { new Guid("bec8f70a-0fe7-4620-a666-17c06ed4f509"), "Order name 856", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 71.9906033991483m, "усл. ед" },
                    { new Guid("bed880b8-124e-4610-91aa-288fed624e35"), "Order name 693", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 102.236427665519m, "усл. ед" },
                    { new Guid("bedbc9ab-36c8-4251-8e5a-104d9b467001"), "Order name 1934", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 122.055077061039m, "усл. ед" },
                    { new Guid("bee1b28e-41c5-4711-a933-4f4babbf0daa"), "Order name 377", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 320.819637030622m, "усл. ед" },
                    { new Guid("bee4dc59-b84b-47a3-bc5e-a22cdd6acf49"), "Order name 1615", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 41.8642797897303m, "усл. ед" },
                    { new Guid("bee788d5-8a86-4f38-8d20-28d826c229e8"), "Order name 2373", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 546.297068174164m, "усл. ед" },
                    { new Guid("bf14e83a-6a18-4853-858c-69b467421247"), "Order name 68", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 163.708979566443m, "усл. ед" },
                    { new Guid("bf718afb-9d92-4241-a1b9-0c4cd69835ae"), "Order name 1345", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 474.568892024952m, "усл. ед" },
                    { new Guid("bf8c8e34-7805-4b05-b155-a017576f7dff"), "Order name 1758", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 281.353726375078m, "усл. ед" },
                    { new Guid("bf994736-e53e-4122-bd20-1a6c156ff5d9"), "Order name 521", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 253.801603733178m, "усл. ед" },
                    { new Guid("bfa2a137-9379-48a1-9540-e4505e287020"), "Order name 2440", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 432.888552410935m, "усл. ед" },
                    { new Guid("bfa54c82-3d02-4e11-a78c-504d950847d9"), "Order name 2476", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 644.831336361086m, "усл. ед" },
                    { new Guid("bfd4ca4c-0dfc-48f9-b403-115955de46c8"), "Order name 430", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 42.1079611140951m, "усл. ед" },
                    { new Guid("bfdb0501-41c2-43ca-8825-b78e012e54bc"), "Order name 345", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 423.623200118102m, "усл. ед" },
                    { new Guid("bfde84a5-1d8e-4845-b8d6-eb66011ddd07"), "Order name 1421", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 539.803390028231m, "усл. ед" },
                    { new Guid("bfe0474d-b797-41b0-93e5-80d4dde5dca6"), "Order name 1999", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 87.5674017082313m, "усл. ед" },
                    { new Guid("c001aba4-6afc-430d-af9b-c396abccff12"), "Order name 1715", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 150.925213891442m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("c058afdc-ab96-4f3e-bb79-f44532c6b3d3"), "Order name 732", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 547.291509318083m, "усл. ед" },
                    { new Guid("c05b6470-4642-487d-995d-9171495cedb7"), "Order name 2458", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 590.103964377435m, "усл. ед" },
                    { new Guid("c063e8c0-c908-4f72-8005-c8731d9b4a12"), "Order name 1374", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 478.414894264234m, "усл. ед" },
                    { new Guid("c0888ab6-b5f6-48db-b649-7afe26d3be9a"), "Order name 110", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 692.149189607412m, "усл. ед" },
                    { new Guid("c0a827ef-d0a0-4a27-851b-489f43096944"), "Order name 2478", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 594.336571934623m, "усл. ед" },
                    { new Guid("c0cec6b3-ec70-482c-8800-60766137a81d"), "Order name 220", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 104.788339390548m, "усл. ед" },
                    { new Guid("c0d68237-9a32-470d-a9f5-bb41d44e09b5"), "Order name 499", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 836.398443274418m, "усл. ед" },
                    { new Guid("c1044d3a-152a-4178-9074-0601a5582b7a"), "Order name 1836", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 324.490327436102m, "усл. ед" },
                    { new Guid("c1492135-6400-4fcc-8f38-b3d62e611568"), "Order name 486", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 63.8421570432721m, "усл. ед" },
                    { new Guid("c15939fc-0363-49d2-8aae-eecc452c32f3"), "Order name 1652", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 57.7304350523825m, "усл. ед" },
                    { new Guid("c15ee3b5-6dd1-43d0-a279-97d3d512c1c7"), "Order name 720", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 680.336425169155m, "усл. ед" },
                    { new Guid("c1606d29-5c3c-4a8a-b07a-fe71ed38f520"), "Order name 1605", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 230.918351694256m, "усл. ед" },
                    { new Guid("c16e14fe-360a-4459-8623-3b5d1b2a3496"), "Order name 2041", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 401.7347127426m, "усл. ед" },
                    { new Guid("c171f4b6-4892-476d-9234-f9b85272bb1e"), "Order name 1549", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 80.9897685244365m, "усл. ед" },
                    { new Guid("c17702d5-687b-41a6-b57e-ebd54a994ae2"), "Order name 1583", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 298.070808691422m, "усл. ед" },
                    { new Guid("c17beb91-cb03-4052-9798-b201a6b3e21f"), "Order name 256", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 789.818119796233m, "усл. ед" },
                    { new Guid("c1c4685b-4510-4db2-b172-0aa84e13d2de"), "Order name 1903", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 101.098902975428m, "усл. ед" },
                    { new Guid("c1d2ce44-0c48-42aa-8930-595f3f26da44"), "Order name 1825", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 652.363507785972m, "усл. ед" },
                    { new Guid("c1dd56e6-8218-4e03-bdfb-ce5d0fe276ae"), "Order name 1780", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 23.6298238733208m, "усл. ед" },
                    { new Guid("c1e54952-a179-44f6-aae4-fd4f9a3f3358"), "Order name 492", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 914.600685647566m, "усл. ед" },
                    { new Guid("c2087797-98fd-4ef3-8156-1b63749c1ba7"), "Order name 1550", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 20.9794519718962m, "усл. ед" },
                    { new Guid("c21c4fc9-9a28-4590-855a-ff99cd27e594"), "Order name 570", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 94.9975951667697m, "усл. ед" },
                    { new Guid("c284244a-63d1-41dd-bf73-43210073c88c"), "Order name 2053", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 284.860801591915m, "усл. ед" },
                    { new Guid("c28866d0-fa28-4798-9561-4f9679d708e7"), "Order name 250", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 78.4795689785884m, "усл. ед" },
                    { new Guid("c28bfd2e-4232-45b8-90fd-49294a4032f6"), "Order name 2429", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 496.857746238512m, "усл. ед" },
                    { new Guid("c295008f-cc37-444c-b09a-7dbc643da034"), "Order name 176", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 157.297658308226m, "усл. ед" },
                    { new Guid("c2975546-2b49-469b-aad8-423dfa378df4"), "Order name 921", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 103.205725599772m, "усл. ед" },
                    { new Guid("c2a2e4b2-937d-4b7c-a04c-07870883aa7c"), "Order name 2091", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 136.160765711903m, "усл. ед" },
                    { new Guid("c2be6365-769e-4eef-acf2-4164ec108209"), "Order name 981", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 45.9911122832504m, "усл. ед" },
                    { new Guid("c2cacab5-3840-4db1-a95a-e2aa3274c368"), "Order name 629", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 461.843427631643m, "усл. ед" },
                    { new Guid("c2d475e3-d1f1-4280-8ff7-7927976d7cb4"), "Order name 1894", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 194.995689820018m, "усл. ед" },
                    { new Guid("c2ded2dc-983c-4800-a175-a2ed3793e0ad"), "Order name 1752", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 631.154694411884m, "усл. ед" },
                    { new Guid("c2f6af01-8d5d-4a1c-9ecf-7e608d0c0669"), "Order name 1281", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 306.321346106252m, "усл. ед" },
                    { new Guid("c308347c-774b-450e-addd-ab7133c5fe57"), "Order name 1357", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 38.9651402048235m, "усл. ед" },
                    { new Guid("c37e0f13-cc01-4166-81ca-376163f2c6aa"), "Order name 109", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 703.434623574482m, "усл. ед" },
                    { new Guid("c38fc5dc-5326-41e7-a06d-f9ac802aeaf8"), "Order name 916", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 602.577985975531m, "усл. ед" },
                    { new Guid("c3a5a355-d433-49a5-bdb1-e62323f64c2e"), "Order name 1889", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 284.145750461474m, "усл. ед" },
                    { new Guid("c3b73973-337a-4de7-b855-115b4b367ac3"), "Order name 1274", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 427.094296592598m, "усл. ед" },
                    { new Guid("c3bc1b2c-5f55-4324-b5af-1619b1185da6"), "Order name 1713", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 149.980036917563m, "усл. ед" },
                    { new Guid("c3c0a42a-354e-4fae-9094-501bfe473f5f"), "Order name 1505", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 175.877862918907m, "усл. ед" },
                    { new Guid("c3c948c6-dcf0-4645-93dc-4c7d24733015"), "Order name 1057", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 244.874019502193m, "усл. ед" },
                    { new Guid("c3d3906d-d5a6-41c5-aa38-9ef332cfa3ee"), "Order name 2187", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 220.686427025782m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("c3d6b875-c01c-4996-b0a0-b0716ca2a497"), "Order name 2159", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 68.262369628481m, "усл. ед" },
                    { new Guid("c4006591-da88-4106-b5d3-09f325e8468b"), "Order name 587", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 111.763631500416m, "усл. ед" },
                    { new Guid("c40a27b6-0988-4ea9-8f11-016cabf1a699"), "Order name 1948", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 147.188557990648m, "усл. ед" },
                    { new Guid("c43eb7ad-da42-47d3-ab14-1efebc0ba119"), "Order name 229", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 78.0958072510584m, "усл. ед" },
                    { new Guid("c4479850-346c-44f6-94ed-59ad7f1efc97"), "Order name 190", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 172.931836264467m, "усл. ед" },
                    { new Guid("c4816dfe-7d5b-4714-ad37-796b3e6f79f3"), "Order name 2415", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 66.9905912819988m, "усл. ед" },
                    { new Guid("c4a9e53b-3c2a-4595-8fd9-27a621bf410e"), "Order name 1791", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 270.683932334759m, "усл. ед" },
                    { new Guid("c4c36985-7dd9-4cfc-ab40-8b2ee987fd3b"), "Order name 952", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 315.237843896036m, "усл. ед" },
                    { new Guid("c4c895c1-d4c2-4642-a40c-4327b0fb480b"), "Order name 1904", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 610.030742114104m, "усл. ед" },
                    { new Guid("c4d478a6-33aa-43ff-96c0-d85523f03645"), "Order name 1028", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 258.338235447219m, "усл. ед" },
                    { new Guid("c506ffa7-84be-4b1e-a471-891506cab22c"), "Order name 2164", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 48.3577465396153m, "усл. ед" },
                    { new Guid("c5261e6a-6aca-4afe-b780-672ead1b403a"), "Order name 1128", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 34.7076668295736m, "усл. ед" },
                    { new Guid("c5593510-e766-45e3-9813-3214c224a3db"), "Order name 451", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 345.062509161226m, "усл. ед" },
                    { new Guid("c55d4e6a-34e8-4462-a92f-b2b37dd1d1a3"), "Order name 1476", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 317.835830711731m, "усл. ед" },
                    { new Guid("c55f64d2-d0d5-4364-bd89-33c337acee0c"), "Order name 748", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 141.27999221116m, "усл. ед" },
                    { new Guid("c56deebf-3393-4ecd-933a-3ce335a7c437"), "Order name 436", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 378.887606119076m, "усл. ед" },
                    { new Guid("c5946e79-b62d-4088-a36b-4bc42910e30b"), "Order name 940", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 0.919651392711588m, "усл. ед" },
                    { new Guid("c5952fa9-86ce-4b9e-8d49-28b6c4d43ea5"), "Order name 1781", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 179.204211119361m, "усл. ед" },
                    { new Guid("c5b09c98-7906-4980-a0f4-f4945446f80b"), "Order name 268", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 31.7103960121352m, "усл. ед" },
                    { new Guid("c60eeffc-362b-421a-9a97-93d8ef3de248"), "Order name 638", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 272.253671293827m, "усл. ед" },
                    { new Guid("c6431623-e12a-4a6a-8024-66c0717d91e6"), "Order name 613", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 352.961532123861m, "усл. ед" },
                    { new Guid("c6461af0-4dca-401f-af15-3f4f91291b89"), "Order name 1397", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 283.416159069556m, "усл. ед" },
                    { new Guid("c64817c9-65b3-452d-b59a-9fe4b2529985"), "Order name 717", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 22.2382089184707m, "усл. ед" },
                    { new Guid("c66d992a-5c1f-443e-9c17-5da786444d62"), "Order name 1101", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 63.515009319969m, "усл. ед" },
                    { new Guid("c683f6d7-8125-4d90-a091-6ca76e48b960"), "Order name 25", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 29.5916410788027m, "усл. ед" },
                    { new Guid("c6868b7d-f6a5-40f3-99e4-eabfd9f06d3d"), "Order name 2185", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 767.71544276389m, "усл. ед" },
                    { new Guid("c69868e6-4fd4-4a6b-b918-09b662802001"), "Order name 2222", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 244.554736159136m, "усл. ед" },
                    { new Guid("c698ff5d-309c-46c7-9174-caa3dcb0f689"), "Order name 954", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 20.1353900767837m, "усл. ед" },
                    { new Guid("c6adb4ec-36da-4748-b495-4399caff8d89"), "Order name 799", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 310.818390649772m, "усл. ед" },
                    { new Guid("c6ae5146-3027-48d6-954d-500c07a21c94"), "Order name 297", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 441.412164452366m, "усл. ед" },
                    { new Guid("c6c90308-f9e5-47ae-a44d-bd30755e0c49"), "Order name 453", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 492.267714882533m, "усл. ед" },
                    { new Guid("c6ced219-6409-45d8-a505-c8b82e0080ce"), "Order name 2003", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 113.39041980817m, "усл. ед" },
                    { new Guid("c6d82a57-a752-425d-9b94-c1e39665209a"), "Order name 822", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 136.258341719986m, "усл. ед" },
                    { new Guid("c6f28f43-1ae3-40b1-b192-6efdf95626bb"), "Order name 1405", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 287.25162138996m, "усл. ед" },
                    { new Guid("c700bc42-0d08-4bbe-918f-d0a9809062ac"), "Order name 1180", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 209.659108528087m, "усл. ед" },
                    { new Guid("c70b5f1e-98bd-46ce-a358-a0033930d97e"), "Order name 288", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 424.391685822086m, "усл. ед" },
                    { new Guid("c70c534f-1b92-42b2-8cee-291d4eec52c0"), "Order name 2013", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 696.317029172787m, "усл. ед" },
                    { new Guid("c738e858-e6ce-459d-8b81-18d3b6822d80"), "Order name 1542", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 672.656231248328m, "усл. ед" },
                    { new Guid("c7616c44-c6d4-4161-ac31-043042ff6c63"), "Order name 2116", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 40.8303510113411m, "усл. ед" },
                    { new Guid("c7fea4c8-f331-4f93-a2b9-c35625390506"), "Order name 962", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 232.064616549355m, "усл. ед" },
                    { new Guid("c800c147-c93a-48e1-952a-d434e6615641"), "Order name 1923", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 261.479007476311m, "усл. ед" },
                    { new Guid("c808efd6-99ee-423a-a791-f8f0211a3c2f"), "Order name 741", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 173.933003692468m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("c83061e9-7592-4f45-a0f1-f3a813aec6d7"), "Order name 2334", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 88.3649960668632m, "усл. ед" },
                    { new Guid("c84caa81-5f0c-420a-b355-e1ae61e9182c"), "Order name 1880", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 784.875708433635m, "усл. ед" },
                    { new Guid("c85270eb-6212-4f26-9ade-8b3ecd64c36d"), "Order name 356", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 786.218619757314m, "усл. ед" },
                    { new Guid("c8587c3c-f518-4cff-8857-cd7abad89a2f"), "Order name 926", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 243.149210455533m, "усл. ед" },
                    { new Guid("c87b44dc-a3da-4fbd-b45b-f37eab0ffa61"), "Order name 312", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 908.419653185062m, "усл. ед" },
                    { new Guid("c8939179-c834-4e43-8a3f-a87e53a022c6"), "Order name 1919", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 226.332904055898m, "усл. ед" },
                    { new Guid("c89413db-ea02-46c8-8f34-db5925b52f4f"), "Order name 2375", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 0.746257322537183m, "усл. ед" },
                    { new Guid("c89a3d3b-d959-40d6-8289-8c3328f354a1"), "Order name 1443", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 136.402916563032m, "усл. ед" },
                    { new Guid("c8c7a900-8a7f-46ef-a0f4-20cba7914456"), "Order name 195", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 509.917131487707m, "усл. ед" },
                    { new Guid("c8dda3d7-01e1-4eb7-89a6-08f3087ba59a"), "Order name 166", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 127.384284344575m, "усл. ед" },
                    { new Guid("c8eff02c-a7f6-4f72-b4a2-834e35ed323d"), "Order name 614", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 404.947059559772m, "усл. ед" },
                    { new Guid("c91ed626-7aef-4149-be6a-4949eeaa1c20"), "Order name 72", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 74.6559886519179m, "усл. ед" },
                    { new Guid("c9598b2f-54d3-46bb-a970-75a205ee8075"), "Order name 776", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 38.5798027529044m, "усл. ед" },
                    { new Guid("c959d505-51b5-4b11-94dc-b9d497ab63d6"), "Order name 1938", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 361.172350270174m, "усл. ед" },
                    { new Guid("c98ddd52-5eea-4b3c-bfd3-a9eda5f39842"), "Order name 1289", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 733.777160632584m, "усл. ед" },
                    { new Guid("c9b23e33-ae61-42ac-ace4-ce00fcfb6b96"), "Order name 2122", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 182.234531734502m, "усл. ед" },
                    { new Guid("c9b65f83-0a00-438f-8b82-4b02ef776750"), "Order name 2331", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 557.111556038533m, "усл. ед" },
                    { new Guid("c9e41f78-e985-4cbc-9192-847f3670a101"), "Order name 13", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 539.341496620967m, "усл. ед" },
                    { new Guid("c9e667fd-ee4f-45d9-b29b-1f678d719a8d"), "Order name 885", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 226.756806866512m, "усл. ед" },
                    { new Guid("c9eaa994-a66c-428f-af85-83e710574c3d"), "Order name 2043", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 127.489711598199m, "усл. ед" },
                    { new Guid("c9f27fb9-d605-4d23-a762-ca94d7849917"), "Order name 1457", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 532.373283287052m, "усл. ед" },
                    { new Guid("ca1b2433-904f-4e28-98e1-aa70405a7474"), "Order name 326", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 369.866164327436m, "усл. ед" },
                    { new Guid("ca24face-a91e-454e-b45d-113f3152aeca"), "Order name 564", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 700.93156209063m, "усл. ед" },
                    { new Guid("ca329c0b-b1af-4e2a-afbd-49857d8a4fa8"), "Order name 2065", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 760.409449184787m, "усл. ед" },
                    { new Guid("ca49cb64-422b-44b1-b8e8-ecc2fca91fd9"), "Order name 811", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 7.51586844015441m, "усл. ед" },
                    { new Guid("ca76fb90-37f2-4fe1-bee5-4896cc1bb9f4"), "Order name 1823", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 315.470766362473m, "усл. ед" },
                    { new Guid("ca97131a-3dc7-49c3-b9f3-a5633999ad4e"), "Order name 1410", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 85.1608381484486m, "усл. ед" },
                    { new Guid("cab0be31-710f-4453-9c0a-a95f001f29bd"), "Order name 98", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 395.458420134523m, "усл. ед" },
                    { new Guid("cab3cade-6ec2-493e-9436-78dd752a774c"), "Order name 84", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 236.458000573181m, "усл. ед" },
                    { new Guid("cad5117c-d177-4a06-88a6-474e5533e1b0"), "Order name 284", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 84.8417218156354m, "усл. ед" },
                    { new Guid("caf9c6f3-ea8e-40f1-b85c-01ef19b3d4db"), "Order name 597", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 99.0434534066746m, "усл. ед" },
                    { new Guid("cafdde4c-0c49-41f9-8ce5-b7c785e51477"), "Order name 1449", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 779.583129520799m, "усл. ед" },
                    { new Guid("cb4b0982-b3c9-4053-9f92-09e29a751568"), "Order name 260", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 70.4556002264145m, "усл. ед" },
                    { new Guid("cb6fd765-6b25-4761-a2d3-247ca8c1fe72"), "Order name 1706", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 543.323376822951m, "усл. ед" },
                    { new Guid("cb78c279-6c72-4c7a-a232-be044eba3a18"), "Order name 199", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 463.169330118089m, "усл. ед" },
                    { new Guid("cb7c5a03-432b-4c15-b027-04aad8fdc842"), "Order name 1328", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 277.031812830247m, "усл. ед" },
                    { new Guid("cb8fd59b-9232-4fa4-8b6f-17e0ed1adaeb"), "Order name 334", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 479.492676184211m, "усл. ед" },
                    { new Guid("cbe3760f-6a74-4681-8e29-40263486be61"), "Order name 1998", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 133.354760271973m, "усл. ед" },
                    { new Guid("cc136c17-9699-434e-9747-c0d3ee117fdc"), "Order name 734", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 104.953069551921m, "усл. ед" },
                    { new Guid("cc490bf4-3e2a-4f6b-a802-9431b87460fe"), "Order name 1369", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 79.081180313444m, "усл. ед" },
                    { new Guid("cc49caa2-66c1-4e8a-9c05-3e9f8c4ddcab"), "Order name 1504", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 730.229024665728m, "усл. ед" },
                    { new Guid("cc51942d-d616-48be-bc50-3ed24fe10d2f"), "Order name 1925", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 793.149744117687m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("cc9eee1d-a029-4e79-873a-2ae03a76a1d0"), "Order name 1275", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 453.131038113483m, "усл. ед" },
                    { new Guid("cce55bfb-44cc-4aef-a640-e0686e0c82a4"), "Order name 412", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 493.521479731555m, "усл. ед" },
                    { new Guid("ccf4b288-0e2d-42c0-b16e-a8fe978c7d6f"), "Order name 2285", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 19.4345419594989m, "усл. ед" },
                    { new Guid("cd002fb1-bddb-4ffe-9aa4-15d04069ef3f"), "Order name 2276", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 101.727706682939m, "усл. ед" },
                    { new Guid("cd1ee7d5-c15f-459b-b0d4-bf8c9a78293d"), "Order name 1818", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 157.007582808381m, "усл. ед" },
                    { new Guid("cd467fa4-b3ae-4bdf-b465-f2be80dadc26"), "Order name 518", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 125.263457794416m, "усл. ед" },
                    { new Guid("cd5f274c-0b93-4333-934f-883a8e6523f6"), "Order name 2454", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 84.005675936824m, "усл. ед" },
                    { new Guid("cd68a398-9438-4aa4-8292-24bcf5ab6c27"), "Order name 1417", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 774.949413176306m, "усл. ед" },
                    { new Guid("cd7861fe-79ec-4729-9306-8b1480f06327"), "Order name 2283", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 250.324915814864m, "усл. ед" },
                    { new Guid("cd7bad4c-47a0-4944-8377-2ac40bfebf6c"), "Order name 2497", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 665.393953369546m, "усл. ед" },
                    { new Guid("cd7cc57b-ac9d-420f-8ef8-a4835a752579"), "Order name 1595", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 88.0566581365287m, "усл. ед" },
                    { new Guid("cd8af45a-9b56-4894-8698-5a62df2d6c29"), "Order name 2146", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 97.5433318183678m, "усл. ед" },
                    { new Guid("cda07d5f-1d1e-483b-93ad-d6a84e669acb"), "Order name 2217", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 305.100828428896m, "усл. ед" },
                    { new Guid("cdb590c2-3c6e-449d-92d3-b0f21cc24839"), "Order name 450", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 79.2392003700806m, "усл. ед" },
                    { new Guid("cdc84906-a836-432b-8035-425016a554a5"), "Order name 992", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 85.4093825648905m, "усл. ед" },
                    { new Guid("cde73af8-8e36-49d4-a0a3-c58019b547f3"), "Order name 947", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 7.2650966379862m, "усл. ед" },
                    { new Guid("cdecce16-76c2-45a2-bbec-40b94c128191"), "Order name 122", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 324.008398047257m, "усл. ед" },
                    { new Guid("cdfd00e4-a586-4db9-a9b2-d97a528366ea"), "Order name 1056", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 423.481705558534m, "усл. ед" },
                    { new Guid("ce2008c5-8c27-4f21-b7dd-dcd1304a00ed"), "Order name 1857", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 100.821278863914m, "усл. ед" },
                    { new Guid("ce27ad8b-dd00-4032-9987-ba0427a4632b"), "Order name 2376", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 189.780703987122m, "усл. ед" },
                    { new Guid("ce3b191a-ec8c-4d56-8de3-9643836d25ff"), "Order name 552", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 77.850761542739m, "усл. ед" },
                    { new Guid("ce3c39d5-2674-41b7-aea6-d063ad7cf546"), "Order name 2070", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 468.673188642702m, "усл. ед" },
                    { new Guid("ce55d3aa-a370-4a3c-8662-e5588180dbef"), "Order name 58", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 637.562554130757m, "усл. ед" },
                    { new Guid("ce655eb1-fea9-41f9-be4f-a85b2c9fe2a7"), "Order name 2261", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 41.4902957589348m, "усл. ед" },
                    { new Guid("ce99833f-6f27-447f-a01d-ce95810e7db6"), "Order name 956", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 436.205040561879m, "усл. ед" },
                    { new Guid("ceb2240c-16d3-49b7-84f4-dcebecf92574"), "Order name 407", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 129.040140364076m, "усл. ед" },
                    { new Guid("cec28ba8-56b1-4ce2-a6be-fc7b914dab52"), "Order name 460", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 558.142495535201m, "усл. ед" },
                    { new Guid("cf1ed193-8faa-42c7-9357-9825eb356cfa"), "Order name 2266", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 246.805793118208m, "усл. ед" },
                    { new Guid("cf4933cb-632f-4c78-a7a8-be90a9c82486"), "Order name 987", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 99.1455724099993m, "усл. ед" },
                    { new Guid("cf814b2b-84f5-4011-bd36-6ea8209b35f8"), "Order name 1108", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 285.981918605732m, "усл. ед" },
                    { new Guid("cf8390f8-5b01-41ce-9f21-c6f387386660"), "Order name 1177", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 6.80601191597196m, "усл. ед" },
                    { new Guid("cfdbd4ed-3bf4-4dc7-b688-2e592c305397"), "Order name 2279", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 205.929277232156m, "усл. ед" },
                    { new Guid("cfef18de-2e8a-4906-9627-7deaf4a4f5ea"), "Order name 1529", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 319.290653134296m, "усл. ед" },
                    { new Guid("d00ba8ed-74d7-4d9e-b516-0964f1d5cc7e"), "Order name 2218", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 103.110974888541m, "усл. ед" },
                    { new Guid("d01225e9-6001-40e2-ab2f-2c2728fdbc41"), "Order name 998", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 371.831275654876m, "усл. ед" },
                    { new Guid("d02a312e-0c18-485c-8f66-b932ce4315fd"), "Order name 886", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 32.8417198528439m, "усл. ед" },
                    { new Guid("d032d5dd-58bc-4898-bb06-07ad9d4a893f"), "Order name 316", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 674.546644532814m, "усл. ед" },
                    { new Guid("d0389acc-3a00-45b9-b0b7-6841c87052ba"), "Order name 1730", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 559.972228996228m, "усл. ед" },
                    { new Guid("d03b19f1-490d-40cd-a5d8-6e263420fddd"), "Order name 2234", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 140.313133764009m, "усл. ед" },
                    { new Guid("d03ba1f5-d3b2-4fb4-ac9e-be76a05ee35a"), "Order name 1586", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 273.143077490296m, "усл. ед" },
                    { new Guid("d03f6c38-f912-4ce6-a1f6-54d6005722bc"), "Order name 363", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 153.002926302576m, "усл. ед" },
                    { new Guid("d04242be-71f7-477e-9e04-db47b19dd110"), "Order name 724", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 174.443947953732m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("d046e35e-fa68-45e9-a69f-c195db05ec4b"), "Order name 1594", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 82.3729001404853m, "усл. ед" },
                    { new Guid("d04daffb-8d70-4361-85fc-d3ba9ec683ff"), "Order name 1599", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 424.778595316261m, "усл. ед" },
                    { new Guid("d064e6d7-130a-466c-8acf-12bd4e26336c"), "Order name 1198", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 853.007383944298m, "усл. ед" },
                    { new Guid("d090c3bb-bcd6-4c0e-8a6c-8953bdbb8bd9"), "Order name 2114", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 124.141484010579m, "усл. ед" },
                    { new Guid("d09a6de3-211a-4626-9a68-6617465504ff"), "Order name 1211", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 393.376692579412m, "усл. ед" },
                    { new Guid("d0e12eda-e122-4906-8d8f-379cf2a9392f"), "Order name 970", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 330.000896107415m, "усл. ед" },
                    { new Guid("d0f2321e-73c2-4f6f-b489-f01b1ef67853"), "Order name 860", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 349.664672219304m, "усл. ед" },
                    { new Guid("d1054703-f7d5-455e-97fa-e80c042a1632"), "Order name 2097", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 211.531614174654m, "усл. ед" },
                    { new Guid("d10761bd-f458-49dc-95e5-a0d98251326a"), "Order name 2498", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 329.587493845819m, "усл. ед" },
                    { new Guid("d10a72e9-7a34-4608-9adb-c7739d5838bf"), "Order name 1435", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 57.6437393933292m, "усл. ед" },
                    { new Guid("d127bdfb-24ec-4af1-b329-30ee67c58e95"), "Order name 350", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 389.28850871666m, "усл. ед" },
                    { new Guid("d148a348-f468-446d-9560-a2bed42dee2b"), "Order name 1092", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 16.349542172556m, "усл. ед" },
                    { new Guid("d15aacb0-813f-42bd-a446-a53875979003"), "Order name 120", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 284.647597156032m, "усл. ед" },
                    { new Guid("d1709b9d-9ed0-4095-a92d-1381c3a0d4dc"), "Order name 1081", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 557.252688096904m, "усл. ед" },
                    { new Guid("d1772e15-6281-4d4f-a7bc-155496d5b0a6"), "Order name 496", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 68.210801133056m, "усл. ед" },
                    { new Guid("d17b1ba3-7dcf-4758-9902-36bdad7863ba"), "Order name 1673", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 953.537018803512m, "усл. ед" },
                    { new Guid("d1816026-5bc7-406c-98b4-244b4bf9f19f"), "Order name 1829", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 247.591487852557m, "усл. ед" },
                    { new Guid("d193e3d7-33c3-421a-826a-4ca1909b84df"), "Order name 1200", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 594.126954777167m, "усл. ед" },
                    { new Guid("d1da4c8a-6efc-43f1-8b3e-542cdccb0a0f"), "Order name 2484", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 652.536158445587m, "усл. ед" },
                    { new Guid("d1ea5c7e-1d0d-4358-93da-444cf724610c"), "Order name 1848", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 218.51036665241m, "усл. ед" },
                    { new Guid("d20013d8-382f-4d9b-aaf7-13585940b8ac"), "Order name 1340", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 243.912849687104m, "усл. ед" },
                    { new Guid("d20327d5-1e1d-40bc-afc1-16ff0ea9eb42"), "Order name 959", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 206.641441238679m, "усл. ед" },
                    { new Guid("d20e16ec-047c-4552-97d6-ae5f7ab01475"), "Order name 1378", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 7.42364492877258m, "усл. ед" },
                    { new Guid("d2352a2a-ec2a-48e0-b302-232c9d9e7bf0"), "Order name 1670", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 464.061756167221m, "усл. ед" },
                    { new Guid("d23f1bd8-250b-46a4-8a90-d45f79d59dcd"), "Order name 700", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 622.225859318028m, "усл. ед" },
                    { new Guid("d24541d3-2c94-46c3-99f7-9f91a6c3bed0"), "Order name 1019", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 188.394849214546m, "усл. ед" },
                    { new Guid("d253d419-2a4a-4a84-ae82-97f1690804dc"), "Order name 891", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 761.704242631175m, "усл. ед" },
                    { new Guid("d25ae670-057b-4b6d-8807-c20162b92b43"), "Order name 1672", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 381.120381363288m, "усл. ед" },
                    { new Guid("d277a599-40e4-4943-a543-acd99abbc3b3"), "Order name 2202", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 424.006421670234m, "усл. ед" },
                    { new Guid("d2925109-1fa0-487f-a386-0380ba6264ce"), "Order name 735", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 103.317116272802m, "усл. ед" },
                    { new Guid("d2ae4f61-81b7-4375-a9bf-d6c49c7f69b3"), "Order name 941", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 159.695260849692m, "усл. ед" },
                    { new Guid("d2af468b-b80d-4d60-bdb8-9edcf949bfe6"), "Order name 713", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 130.093128208436m, "усл. ед" },
                    { new Guid("d2c0dc07-77fd-472c-892c-295560e8deb9"), "Order name 2349", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 330.79826517924m, "усл. ед" },
                    { new Guid("d2e1daaf-ef09-4715-bc7b-721a0034e39e"), "Order name 1299", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 98.452222578969m, "усл. ед" },
                    { new Guid("d3101b51-118a-4623-8f31-31773fb5df39"), "Order name 736", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 93.9250521226323m, "усл. ед" },
                    { new Guid("d32321b7-eceb-4b13-b3a1-08f0d5b7f7c0"), "Order name 295", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 5.93231792015706m, "усл. ед" },
                    { new Guid("d32fa6cd-18b4-4d77-bc9c-954f02dee719"), "Order name 298", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 189.486583459046m, "усл. ед" },
                    { new Guid("d336ecc3-3515-4c6b-a4ed-426f3975de54"), "Order name 1685", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 61.8596615936871m, "усл. ед" },
                    { new Guid("d33a0b7d-963c-47be-b033-c06f79962f32"), "Order name 2436", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 545.392934284503m, "усл. ед" },
                    { new Guid("d3442dba-80f3-4d3c-ae5e-af38b063c4f0"), "Order name 2442", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 583.446710813795m, "усл. ед" },
                    { new Guid("d36fcb74-db9e-4dd5-b2bb-80f827cb19a0"), "Order name 1747", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 13.8658489079886m, "усл. ед" },
                    { new Guid("d376befe-431e-4509-ad6b-f7d4ef544888"), "Order name 801", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 132.951795428208m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("d38c2164-061c-4870-8fbe-8633c0967bc0"), "Order name 645", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 50.7072093024414m, "усл. ед" },
                    { new Guid("d3b1939e-e1f8-49fd-a51f-8344a8b01766"), "Order name 2216", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 212.866477473916m, "усл. ед" },
                    { new Guid("d3b73047-1a8b-497e-9360-b18a8b2a1186"), "Order name 2324", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 271.247016230449m, "усл. ед" },
                    { new Guid("d3c1b004-1470-4844-b84e-78654c8831dd"), "Order name 949", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 664.642851055698m, "усл. ед" },
                    { new Guid("d3f78f2f-95b5-418e-a77d-04b24bf21cd6"), "Order name 1813", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 291.984623139914m, "усл. ед" },
                    { new Guid("d411b748-5f6c-4c75-bb97-6c64bec1ad11"), "Order name 1546", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 392.637014563372m, "усл. ед" },
                    { new Guid("d44afb59-76ff-484f-9806-9dd24f8aa4ee"), "Order name 1337", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 249.143784130105m, "усл. ед" },
                    { new Guid("d45ab8b4-1ce5-4d2e-b98b-1066083f8f2c"), "Order name 1693", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 58.0875603480618m, "усл. ед" },
                    { new Guid("d4bb3598-d807-48b2-9a43-728b94fc5eaf"), "Order name 972", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 417.664723011855m, "усл. ед" },
                    { new Guid("d5325e13-1bbd-4094-affe-8b873d43a056"), "Order name 126", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 135.241456900171m, "усл. ед" },
                    { new Guid("d53f525c-df00-4e6e-ac5f-e975b639b1c5"), "Order name 409", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 41.890662552308m, "усл. ед" },
                    { new Guid("d55ae9c6-33ad-4e4d-b9b8-e83bfd16626f"), "Order name 1642", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 11.1193231064277m, "усл. ед" },
                    { new Guid("d560e503-f411-445f-8d87-1b26e57f76a3"), "Order name 1450", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 202.111615206294m, "усл. ед" },
                    { new Guid("d59641d6-0e41-477e-9112-d89dbef1155a"), "Order name 2005", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 133.478444268412m, "усл. ед" },
                    { new Guid("d5b72d59-5552-460f-b554-139ec80ee44e"), "Order name 524", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 17.3256971410584m, "усл. ед" },
                    { new Guid("d5b7d56d-a449-4ef4-a013-06bd4d46e74f"), "Order name 1887", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 11.1637462491977m, "усл. ед" },
                    { new Guid("d5ced50f-6de2-40f3-9ec4-0909a2c646e6"), "Order name 473", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 889.048639689955m, "усл. ед" },
                    { new Guid("d5f7b993-558b-4b12-b6b1-5da3158ae34d"), "Order name 34", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 268.238884605221m, "усл. ед" },
                    { new Guid("d6557d0b-2f78-4bde-bd83-ddd2546a17a7"), "Order name 1424", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 119.055895233621m, "усл. ед" },
                    { new Guid("d6694328-4cb3-4ab9-b372-56d6752a086b"), "Order name 344", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 431.346607133105m, "усл. ед" },
                    { new Guid("d683d156-4ebf-4cd9-b82d-9f27dfde4e8b"), "Order name 884", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 139.086489839007m, "усл. ед" },
                    { new Guid("d6894a30-cba3-4132-b114-22bd689df811"), "Order name 806", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 63.8917389214812m, "усл. ед" },
                    { new Guid("d68d5fa8-5000-4ed4-a58b-a0e3928a094b"), "Order name 861", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 199.816830834842m, "усл. ед" },
                    { new Guid("d6bc3ecd-3d65-4920-af07-8e837a96679b"), "Order name 192", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 488.458744452359m, "усл. ед" },
                    { new Guid("d6c2d899-eb45-4f16-8546-93dcdeea370c"), "Order name 1568", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 444.489852056649m, "усл. ед" },
                    { new Guid("d6c44efb-e2d4-4398-b1c3-999abf7e0219"), "Order name 569", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 597.856981623943m, "усл. ед" },
                    { new Guid("d6d662cc-ecc4-4fb1-bdee-e575708e04da"), "Order name 293", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 482.152366548296m, "усл. ед" },
                    { new Guid("d6f2abf1-0343-4b67-a304-f15eb141d7ac"), "Order name 490", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 235.449271566565m, "усл. ед" },
                    { new Guid("d6fd5d5e-6c01-4f87-8e1c-03bcaf22062b"), "Order name 1761", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 297.751724462291m, "усл. ед" },
                    { new Guid("d707b44e-1759-41d5-9fef-b9d56e4cdf7e"), "Order name 2325", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 250.675607446115m, "усл. ед" },
                    { new Guid("d7187d06-12a7-4cc2-ad77-ba45c12b22f0"), "Order name 124", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 80.474028770556m, "усл. ед" },
                    { new Guid("d72aa4dd-2ab0-4e54-8cbd-9964ba300df9"), "Order name 2098", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 333.569462412942m, "усл. ед" },
                    { new Guid("d73befc5-c8e3-42e2-973a-bb4bb1384cf0"), "Order name 1146", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 204.974965691752m, "усл. ед" },
                    { new Guid("d73e5b95-8747-4a99-a872-de1fd421f050"), "Order name 2229", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 253.868963333341m, "усл. ед" },
                    { new Guid("d73e840a-1284-4626-b766-46652c459403"), "Order name 879", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 582.928439984751m, "усл. ед" },
                    { new Guid("d753793b-d53b-4a67-aec3-f9d4f0fd3360"), "Order name 2273", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 156.918787028127m, "усл. ед" },
                    { new Guid("d75507c9-b207-4e60-9a97-6c3c925d34f9"), "Order name 1442", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 89.6700485677989m, "усл. ед" },
                    { new Guid("d766cdaf-828d-4c21-8c73-5e853e4f0600"), "Order name 283", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 524.616942689179m, "усл. ед" },
                    { new Guid("d79e5b5c-bf1f-4fb9-9316-b3190c60844d"), "Order name 2058", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 73.0273051398986m, "усл. ед" },
                    { new Guid("d7ae631d-1ace-4290-9322-b913acb43f8d"), "Order name 1697", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 195.433449052869m, "усл. ед" },
                    { new Guid("d7bc76e0-6862-4b89-ac93-ff384fd39999"), "Order name 2105", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 506.384617634569m, "усл. ед" },
                    { new Guid("d7d31904-0c6c-468d-896c-4934c7210355"), "Order name 2154", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 162.132443794113m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("d7d4c253-349b-4915-b89b-18158a9e8567"), "Order name 1601", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 108.855211022062m, "усл. ед" },
                    { new Guid("d7ff6d5e-439e-4484-a02a-afcade300c05"), "Order name 1209", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 464.343560212736m, "усл. ед" },
                    { new Guid("d87455f9-726f-42b6-bda0-dc55292901f7"), "Order name 1893", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 152.34493239639m, "усл. ед" },
                    { new Guid("d87f2929-1b86-4bb2-a8fe-9f3447d4bca3"), "Order name 2309", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 474.765371756646m, "усл. ед" },
                    { new Guid("d88b4a6d-2e8c-4e65-a64b-d9a6c371cee7"), "Order name 49", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 14.2821899554375m, "усл. ед" },
                    { new Guid("d8ece687-df13-4600-a9db-736b2a5944b7"), "Order name 1352", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 44.5277459426246m, "усл. ед" },
                    { new Guid("d907931e-0701-42e2-ba81-5c09bcd0cad9"), "Order name 1688", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 435.289275527648m, "усл. ед" },
                    { new Guid("d908f5ba-2585-4ea0-aa38-3b1193538e12"), "Order name 285", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 320.055036454485m, "усл. ед" },
                    { new Guid("d94b67da-4dd0-4f1e-b51f-160c61b5553d"), "Order name 1992", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 71.5135393219821m, "усл. ед" },
                    { new Guid("d987d08b-ef3e-4366-81e3-8041584d5ea4"), "Order name 553", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 170.444834848649m, "усл. ед" },
                    { new Guid("d9a8647b-67b2-402e-b788-6899636e251c"), "Order name 1809", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 139.024989059159m, "усл. ед" },
                    { new Guid("d9b164f3-2550-4e9e-89c1-5b86bd723a0e"), "Order name 1950", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 737.095683747485m, "усл. ед" },
                    { new Guid("d9b41098-f4b9-4f8e-a651-ad5a29d3c5c1"), "Order name 1862", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 107.772946169637m, "усл. ед" },
                    { new Guid("d9cc3ee5-782a-4c69-8e04-ec2294b38d4e"), "Order name 2475", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 559.454077380001m, "усл. ед" },
                    { new Guid("d9d4c1cb-977d-4b6b-97b7-79aabd6b2f9d"), "Order name 1484", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 472.589092221764m, "усл. ед" },
                    { new Guid("d9e22126-18d3-4ec3-91a2-3c2f48c60522"), "Order name 814", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 360.090700870946m, "усл. ед" },
                    { new Guid("d9e8f493-42cd-48a9-b9da-4a4e967ac3fb"), "Order name 1637", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 31.346617709737m, "усл. ед" },
                    { new Guid("d9f5113a-197f-4a8e-bebe-9b19d464509d"), "Order name 858", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 196.670836553205m, "усл. ед" },
                    { new Guid("d9f5e780-c231-4190-a40c-e7c594389b3b"), "Order name 1069", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 203.555156511324m, "усл. ед" },
                    { new Guid("da06cb38-ac4c-4383-aed6-c63ffb2a733a"), "Order name 983", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 341.77841277804m, "усл. ед" },
                    { new Guid("da0b9c1c-2e08-48c9-8b87-9f43c54cb91a"), "Order name 1787", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 140.359159365802m, "усл. ед" },
                    { new Guid("da0c11fb-acea-40a2-9b0f-9acff6990ab3"), "Order name 139", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 488.41566490858m, "усл. ед" },
                    { new Guid("da28b730-07e9-4ba1-b358-6ccaab972495"), "Order name 880", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 375.31577607021m, "усл. ед" },
                    { new Guid("da43ea0e-aa2e-49c7-92a8-b58be75e7569"), "Order name 276", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 44.6034907481829m, "усл. ед" },
                    { new Guid("da82a4a2-43c3-46dd-aec0-75a505c14ccf"), "Order name 1351", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 541.315513055784m, "усл. ед" },
                    { new Guid("dad0c734-dc62-480e-b397-51c991965c10"), "Order name 625", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 245.743583593738m, "усл. ед" },
                    { new Guid("dadc2d89-7ef3-46f9-acea-6e7d15bf67ad"), "Order name 654", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 152.220372157773m, "усл. ед" },
                    { new Guid("daf0f5e8-3d46-45d1-9ad1-d9c8bf77c977"), "Order name 2243", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 402.030760071669m, "усл. ед" },
                    { new Guid("dafc43c6-f2c6-4b4d-8652-3174971eaed1"), "Order name 2124", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 651.454139346214m, "усл. ед" },
                    { new Guid("db27bfd9-7e07-4053-984a-5793e19fe833"), "Order name 699", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 161.972120767185m, "усл. ед" },
                    { new Guid("db2bdce9-299c-428c-815c-3f66be9142c6"), "Order name 1581", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 112.227104466978m, "усл. ед" },
                    { new Guid("db40c9c8-56d0-4003-ac6d-39c20a8f43d9"), "Order name 740", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 521.361793202747m, "усл. ед" },
                    { new Guid("db675629-7f67-4223-9395-50587464e386"), "Order name 1271", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 600.210395643184m, "усл. ед" },
                    { new Guid("db6bd6ea-888b-4eae-8937-00849cbb7229"), "Order name 1755", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 58.4904172668288m, "усл. ед" },
                    { new Guid("db7faf51-b6ae-4799-9036-119ca2496ab3"), "Order name 76", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 540.200741842098m, "усл. ед" },
                    { new Guid("db9ed22c-2326-48f7-b892-f3064989ab34"), "Order name 2259", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 288.313120130371m, "усл. ед" },
                    { new Guid("dbcb120f-129f-4fd8-ac47-1da27d5435e7"), "Order name 1732", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 119.86263747125m, "усл. ед" },
                    { new Guid("dc0bb3da-fd0b-4123-9b3f-a1d5ef1fa89d"), "Order name 1307", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 67.7928526501674m, "усл. ед" },
                    { new Guid("dc1f7761-c884-4335-867a-397486ab5994"), "Order name 1096", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 879.184056618406m, "усл. ед" },
                    { new Guid("dc28bae8-d43a-48c4-b267-3cde3a20bde4"), "Order name 234", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 137.651895011093m, "усл. ед" },
                    { new Guid("dc35f750-b064-45c9-98ef-1aa2b2dab3dd"), "Order name 1888", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 426.117188076695m, "усл. ед" },
                    { new Guid("dc5d5bdc-8d67-42bc-9ee5-3d1c53c75c19"), "Order name 2492", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 786.03062084607m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("dc62de45-4c6c-4c87-a5e1-a90cf929914a"), "Order name 2045", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 781.521297253207m, "усл. ед" },
                    { new Guid("dc66ae9f-d44c-414f-998f-52b172c341ff"), "Order name 1629", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 429.014927662434m, "усл. ед" },
                    { new Guid("dc81c874-a404-4b5b-9b07-06e0a924b4f3"), "Order name 1588", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 248.971603084203m, "усл. ед" },
                    { new Guid("dc87cc0a-d1b2-466e-bf87-f36bedbe957e"), "Order name 1075", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 308.880563088394m, "усл. ед" },
                    { new Guid("dd11c065-f9ab-4c80-84a2-843ae017572c"), "Order name 686", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 191.926409478642m, "усл. ед" },
                    { new Guid("dd67b17f-c940-4a5b-ae8d-7a1348d23cf6"), "Order name 1682", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 129.002742973586m, "усл. ед" },
                    { new Guid("dd9547e0-cced-445c-b9ec-42083ada0457"), "Order name 64", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 386.394498789858m, "усл. ед" },
                    { new Guid("dda4c7d4-7975-458b-bcec-48b4ecb129e6"), "Order name 1812", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 499.672510151529m, "усл. ед" },
                    { new Guid("ddac2acc-3199-48b6-a1b5-c6f2a3960923"), "Order name 704", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 493.852162938286m, "усл. ед" },
                    { new Guid("ddb60a43-7f0c-4017-a53e-2e23ed9ca9fe"), "Order name 747", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 143.476659144405m, "усл. ед" },
                    { new Guid("dde9020b-64ea-4ac6-a23e-17fa58b34ad3"), "Order name 784", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 624.030173311948m, "усл. ед" },
                    { new Guid("dde9477f-77a2-46e8-aa79-5ac6e1f1228c"), "Order name 2449", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 314.176213908642m, "усл. ед" },
                    { new Guid("de18cd39-9940-4d19-84e5-f6db5ddc07b2"), "Order name 1166", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 130.894013529441m, "усл. ед" },
                    { new Guid("de1d135d-7f62-449f-a24a-e91ab8e03fd4"), "Order name 2025", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 91.9945533968712m, "усл. ед" },
                    { new Guid("de2946a5-cbcc-449e-badd-c78b55c5dd0f"), "Order name 259", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 154.250522909791m, "усл. ед" },
                    { new Guid("de40d4e7-ef07-4498-b4de-0a2b42df610d"), "Order name 1701", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 299.574020791883m, "усл. ед" },
                    { new Guid("de6513f5-1e49-430c-9751-2429763ec6f5"), "Order name 461", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 145.272132521137m, "усл. ед" },
                    { new Guid("de94703a-e3f9-4fe5-b38d-b7cd5cf5f6c3"), "Order name 2050", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 129.714055725937m, "усл. ед" },
                    { new Guid("de9e5312-797d-4d55-8389-a8581e8702df"), "Order name 291", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 108.115393043638m, "усл. ед" },
                    { new Guid("deaf1663-3e88-4fd3-bd78-566e12e33708"), "Order name 2296", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 14.7235660361093m, "усл. ед" },
                    { new Guid("dec548ea-d2be-4a3b-a8f5-955bd724c3ca"), "Order name 406", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 136.733248408133m, "усл. ед" },
                    { new Guid("dec67d3a-370b-4795-a8dc-5565ec022f0e"), "Order name 2141", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 24.0487443671188m, "усл. ед" },
                    { new Guid("ded62c45-e10a-4f79-822c-2f63a2e8b31e"), "Order name 1636", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 311.691500280439m, "усл. ед" },
                    { new Guid("df0d565b-0b28-4413-aefb-452802fa2cdb"), "Order name 1062", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 198.256427786546m, "усл. ед" },
                    { new Guid("df26c5c5-6e15-4cc8-8c25-27d7878175d0"), "Order name 677", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 2.65120825787254m, "усл. ед" },
                    { new Guid("df295207-e6c3-4d17-babb-c5ff2a5c0add"), "Order name 2136", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 80.3055377078936m, "усл. ед" },
                    { new Guid("df366f50-f9fd-46e6-a46f-39ab25f050b6"), "Order name 157", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 8.49228834462116m, "усл. ед" },
                    { new Guid("df44f9e9-a82c-44a2-b47b-bdd17d3fa92d"), "Order name 477", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 486.182670775699m, "усл. ед" },
                    { new Guid("df7f789a-b9ae-4e73-929a-a3ba262e6de8"), "Order name 1203", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 170.466560571445m, "усл. ед" },
                    { new Guid("df805527-4e7d-40c6-9b54-0d417b752ac9"), "Order name 1124", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 344.460458772817m, "усл. ед" },
                    { new Guid("df84acb1-7573-4e69-a1e5-6526ff35b04f"), "Order name 1126", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 402.537929997234m, "усл. ед" },
                    { new Guid("df8887f3-6346-4e80-9b24-25f44ab70f10"), "Order name 2477", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 51.3933245034955m, "усл. ед" },
                    { new Guid("df8a1799-f159-4e38-a3f8-d80275003e4b"), "Order name 1231", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 109.147685462054m, "усл. ед" },
                    { new Guid("df9c4b9a-beed-4483-b3ab-d6c862a04c19"), "Order name 731", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 112.261080063813m, "усл. ед" },
                    { new Guid("dfba0dd6-e85b-4fb4-a98c-12662d9edfc4"), "Order name 2082", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 31.2937138839888m, "усл. ед" },
                    { new Guid("dfdd9d31-5512-4a15-ab84-ff8ad4e31e79"), "Order name 1268", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 731.47695048559m, "усл. ед" },
                    { new Guid("e02c1df9-5e29-4ed7-8cfb-cec4ec961ff7"), "Order name 2341", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 216.383133148589m, "усл. ед" },
                    { new Guid("e0721f85-9038-46d7-8055-24f367b196b3"), "Order name 2236", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 562.750659813111m, "усл. ед" },
                    { new Guid("e095e572-3266-46e5-ae57-1ca001705369"), "Order name 1494", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 497.162291061085m, "усл. ед" },
                    { new Guid("e0c6c706-6eb6-40eb-acce-c20ff7819def"), "Order name 1908", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 239.584603077881m, "усл. ед" },
                    { new Guid("e0c98bfc-76e7-4d28-b793-da505dfd5001"), "Order name 2145", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 0.791452318740706m, "усл. ед" },
                    { new Guid("e0cbca2e-db97-4a3d-b505-7685d49177a5"), "Order name 593", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 611.916336317178m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("e0d7f0da-aca0-4fa8-a6cb-09fb78d3ecfc"), "Order name 985", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 124.849213660947m, "усл. ед" },
                    { new Guid("e10194ed-4bb6-44aa-96a7-d331d198b63a"), "Order name 1254", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 22.8511092310947m, "усл. ед" },
                    { new Guid("e108450d-e0e4-4581-be8e-478321699a6c"), "Order name 1183", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 51.1244482478441m, "усл. ед" },
                    { new Guid("e109d05b-7dba-40d3-b1c6-35a36a45790a"), "Order name 2416", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 214.054974536441m, "усл. ед" },
                    { new Guid("e1102777-f884-442c-b74e-78ba08a5b39d"), "Order name 2190", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 452.816998411095m, "усл. ед" },
                    { new Guid("e11f415f-f1b8-4684-9ead-31faaf5331c1"), "Order name 374", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 186.215394439178m, "усл. ед" },
                    { new Guid("e13f8807-6431-451c-926e-3ec9b6a7ef9b"), "Order name 201", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 42.2756839328071m, "усл. ед" },
                    { new Guid("e1821c94-1a8a-49d6-b9cc-aacfdac5557d"), "Order name 652", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 193.681943972658m, "усл. ед" },
                    { new Guid("e1900437-b9e1-43ee-bb88-f137e16867f7"), "Order name 1760", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 186.49189161983m, "усл. ед" },
                    { new Guid("e1a39264-fedf-4900-b01b-562ec906f6ea"), "Order name 1604", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 119.876781978218m, "усл. ед" },
                    { new Guid("e1c0804e-f687-4866-9bee-651dabb6483e"), "Order name 1681", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 29.3764765354654m, "усл. ед" },
                    { new Guid("e1c7ee43-d709-4460-979d-d16c717a19ee"), "Order name 1130", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 228.247405976113m, "усл. ед" },
                    { new Guid("e2114374-e431-4a62-8448-4689ed28b983"), "Order name 1742", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 104.388212390057m, "усл. ед" },
                    { new Guid("e215c2bd-dfac-4c38-bcfe-d109008cd74f"), "Order name 2137", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 121.582175773371m, "усл. ед" },
                    { new Guid("e21ddcf1-6a2b-461e-8f2f-cbc99ba1a967"), "Order name 2002", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 44.4371917066634m, "усл. ед" },
                    { new Guid("e223d94e-be41-48c6-93d4-e042a69954c0"), "Order name 1334", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 310.481713139976m, "усл. ед" },
                    { new Guid("e224a9fe-8863-46ea-a930-2a8bb763e2a4"), "Order name 2422", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 220.425750014322m, "усл. ед" },
                    { new Guid("e226db5b-affa-4d9d-b208-5f9b45b74df5"), "Order name 509", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 99.3726609508751m, "усл. ед" },
                    { new Guid("e2290446-a787-4d5d-acad-004ebe73c6e0"), "Order name 1213", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 520.610760632799m, "усл. ед" },
                    { new Guid("e26bf986-6888-464f-a5e9-f7aed837e8be"), "Order name 274", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 71.6207340149858m, "усл. ед" },
                    { new Guid("e2815e11-2df6-4575-bb8a-756e8a91d4cf"), "Order name 1330", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 334.68254894246m, "усл. ед" },
                    { new Guid("e28c5e63-5c7b-47ca-a26b-3c6d4d57d2c6"), "Order name 246", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 404.300091266356m, "усл. ед" },
                    { new Guid("e29d5b78-c52b-4242-b60b-eb2134a95db2"), "Order name 18", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 355.875896668304m, "усл. ед" },
                    { new Guid("e2b91bfc-5ad8-4d04-88f8-14c9741e3067"), "Order name 996", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 101.383046759449m, "усл. ед" },
                    { new Guid("e2c005a8-c1e6-4fbb-8a48-09d69e41b0ee"), "Order name 795", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 621.480981912361m, "усл. ед" },
                    { new Guid("e2e129ec-46b7-483e-82b5-ab633b977c8c"), "Order name 1158", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 304.288132058238m, "усл. ед" },
                    { new Guid("e2f03092-664d-409a-9583-1323085824de"), "Order name 2170", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 77.3582211213996m, "усл. ед" },
                    { new Guid("e3077391-3dad-4cb2-a1dc-fc4df23307a9"), "Order name 1456", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 496.809789148143m, "усл. ед" },
                    { new Guid("e31264b2-8de4-4e58-a897-4ab20c009e9b"), "Order name 841", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 764.421827111498m, "усл. ед" },
                    { new Guid("e3157f9c-4f18-4c19-b91c-286b1f8b9686"), "Order name 306", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 133.260427114396m, "усл. ед" },
                    { new Guid("e3248f73-29e8-4590-9c19-11db00672518"), "Order name 1336", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 220.279443108027m, "усл. ед" },
                    { new Guid("e3369034-9d3a-4e22-b95e-a7b70f7e8315"), "Order name 2199", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 140.476454565454m, "усл. ед" },
                    { new Guid("e35f9c0e-0116-4d83-a684-7a5959ec063a"), "Order name 1263", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 376.288897137692m, "усл. ед" },
                    { new Guid("e36168f1-3e77-43df-97db-a0edbb8f2e24"), "Order name 1039", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 7.01187026015787m, "усл. ед" },
                    { new Guid("e394efca-691c-406d-8240-3c8403327b19"), "Order name 2302", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 880.082825636042m, "усл. ед" },
                    { new Guid("e3ae432c-1d42-4842-9c61-be17f9a44576"), "Order name 502", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 84.4757562764873m, "усл. ед" },
                    { new Guid("e42d6920-e444-4fe3-8d16-c5726cb643d3"), "Order name 771", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 420.548865475162m, "усл. ед" },
                    { new Guid("e42ec9ef-723d-4a79-85e4-24b77782223a"), "Order name 1841", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 131.056679574783m, "усл. ед" },
                    { new Guid("e46459bd-974d-474e-8fa3-b7b9d04ac944"), "Order name 1952", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 348.305268194664m, "усл. ед" },
                    { new Guid("e4979392-7ad4-4860-bc2c-6329dd909166"), "Order name 2092", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 371.273450346211m, "усл. ед" },
                    { new Guid("e49afdeb-14c7-4237-a836-b77c6cc88378"), "Order name 239", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 396.05677401108m, "усл. ед" },
                    { new Guid("e49e2038-680e-480f-95a1-81124e090c44"), "Order name 1907", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 225.108405307384m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("e4a62760-2399-4c24-b2c5-12ac87d1d2ab"), "Order name 1749", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 209.809394449066m, "усл. ед" },
                    { new Guid("e4b2bd60-b4b8-4e00-9793-cbf600d95734"), "Order name 539", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 566.191161800722m, "усл. ед" },
                    { new Guid("e4c0286e-479a-4749-80b1-b609eb3c39bd"), "Order name 2153", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 77.4088105806885m, "усл. ед" },
                    { new Guid("e4f1a2e9-cc3d-4870-9674-ef033bef5b63"), "Order name 2131", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 154.752683861819m, "усл. ед" },
                    { new Guid("e4f7908e-fab7-4d38-a15a-8801c802cad3"), "Order name 1509", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 158.405614320366m, "усл. ед" },
                    { new Guid("e4f89c24-5045-45ac-baac-0bb0e2e90026"), "Order name 2173", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 232.471940620477m, "усл. ед" },
                    { new Guid("e50a7cc7-5e16-46cd-b88f-42bffb6dd7d7"), "Order name 1172", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 635.329239116666m, "усл. ед" },
                    { new Guid("e51144bb-a722-4d26-9536-604d0517d249"), "Order name 1055", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 19.4718549544927m, "усл. ед" },
                    { new Guid("e519994c-ddc7-4cb7-a37d-2aa5aedf4c22"), "Order name 327", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 100.334518830553m, "усл. ед" },
                    { new Guid("e56ec019-0539-48b5-b970-2364c89ab0a2"), "Order name 1683", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 514.40903095139m, "усл. ед" },
                    { new Guid("e583b0a2-05c5-4ab2-bf10-8671ae327dfe"), "Order name 1976", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 592.129435321906m, "усл. ед" },
                    { new Guid("e5a7c6f9-4e9e-40ba-ab66-554926f2724b"), "Order name 2203", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 447.462193272836m, "усл. ед" },
                    { new Guid("e5e8061e-69ff-43fa-aa4d-825bd41106bc"), "Order name 269", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 455.372448330634m, "усл. ед" },
                    { new Guid("e60d08c2-bca4-407d-a973-b0803d5d8da7"), "Order name 1743", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 778.152356512934m, "усл. ед" },
                    { new Guid("e65a6666-0944-4580-841b-870771543422"), "Order name 1804", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 460.272222197213m, "усл. ед" },
                    { new Guid("e6bd2d24-dfec-4955-b35d-af3b090e0ff0"), "Order name 1939", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 10.4575791130402m, "усл. ед" },
                    { new Guid("e6df0391-0cb5-4015-883b-e0d5c598fc14"), "Order name 2353", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 127.934438502458m, "усл. ед" },
                    { new Guid("e6fc4de5-8dc7-4964-b0b2-27fec00756e1"), "Order name 1439", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 217.040438025149m, "усл. ед" },
                    { new Guid("e70fe5a6-fcf2-48f3-b27b-8cfd1a366ab8"), "Order name 379", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 78.7447286850444m, "усл. ед" },
                    { new Guid("e729286d-7812-4f3b-a9c4-9f7cbb6ab151"), "Order name 2215", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 290.48523515904m, "усл. ед" },
                    { new Guid("e7639f5c-cc51-4288-b245-9bdd7310842f"), "Order name 924", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 104.085101751906m, "усл. ед" },
                    { new Guid("e779941b-62d6-497d-824c-061d021e34c4"), "Order name 1650", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 112.868973530035m, "усл. ед" },
                    { new Guid("e7818ef7-5d3d-4190-8518-dfc7c90c68c1"), "Order name 2272", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 49.2967096999571m, "усл. ед" },
                    { new Guid("e7e4cf1b-92ff-4287-b675-470e68265cca"), "Order name 791", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 573.379814411855m, "усл. ед" },
                    { new Guid("e7f389fe-8189-4579-97a7-94af5825293e"), "Order name 542", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 13.915841288499m, "усл. ед" },
                    { new Guid("e811bf1e-86b9-4910-ad25-72584c5db21c"), "Order name 2430", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 126.917491842959m, "усл. ед" },
                    { new Guid("e8199267-5963-4e4c-a367-18a5f463f05f"), "Order name 1666", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 769.371511829419m, "усл. ед" },
                    { new Guid("e84360a5-0515-4cc7-83f9-c866ba2b310f"), "Order name 208", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 103.465402265207m, "усл. ед" },
                    { new Guid("e8436dfe-ed5a-4455-975c-03e918383ea9"), "Order name 2447", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 44.7312457026649m, "усл. ед" },
                    { new Guid("e8500ec0-f405-4c40-b867-b7f79c8c259b"), "Order name 419", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 74.2813973298207m, "усл. ед" },
                    { new Guid("e86adfb0-3352-4241-903c-243e7a5d7f79"), "Order name 1377", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 13.2538270821238m, "усл. ед" },
                    { new Guid("e8c7f88f-4915-4a88-a79b-a7c325ce585f"), "Order name 866", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 15.7708143293708m, "усл. ед" },
                    { new Guid("e8d1854d-9d73-4c5c-8cfb-616a2f738103"), "Order name 505", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 444.320152587359m, "усл. ед" },
                    { new Guid("e8d280e5-9943-4aa4-9a6e-63b8cce5e414"), "Order name 2288", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 11.4396087065967m, "усл. ед" },
                    { new Guid("e8fe7ee5-f5a3-48df-99b4-fee8bc3b82e7"), "Order name 2443", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 296.493238016362m, "усл. ед" },
                    { new Guid("e9090fbd-dcb5-4834-bd89-85cfa38524ad"), "Order name 1383", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 231.196946263949m, "усл. ед" },
                    { new Guid("e934b41c-2dc9-4794-a16b-4ad5bf7084bc"), "Order name 211", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 661.500376111118m, "усл. ед" },
                    { new Guid("e975e0e8-732c-46d2-8693-da782924c8bc"), "Order name 1567", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 439.91869869118m, "усл. ед" },
                    { new Guid("e99222d3-c479-4047-abc5-90071854cf02"), "Order name 548", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 687.388332452596m, "усл. ед" },
                    { new Guid("e9a0c9f0-73a9-4479-8882-39b566aad97a"), "Order name 1782", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 102.969961521715m, "усл. ед" },
                    { new Guid("e9a36ac5-921a-47aa-b86f-76d5a0a1c801"), "Order name 1425", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 11.240319235974m, "усл. ед" },
                    { new Guid("e9afa527-2f11-4e01-80e2-93e81898ef2e"), "Order name 1909", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 46.2716459912808m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("e9c1ec32-18fa-4e81-9992-b54af981a506"), "Order name 184", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 276.299047559163m, "усл. ед" },
                    { new Guid("e9c77196-2db0-4810-a29f-c692aeee3c1e"), "Order name 194", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 40.5438747667982m, "усл. ед" },
                    { new Guid("e9ea98c0-c0be-4fa0-b491-6babf25c9002"), "Order name 1119", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 259.062815440541m, "усл. ед" },
                    { new Guid("e9eee8f9-5904-48e7-8890-7f229ce0ad1b"), "Order name 1458", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 108.17745123091m, "усл. ед" },
                    { new Guid("ea0f47dd-4176-4df9-88a0-13331ef9c411"), "Order name 1751", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 536.794426415017m, "усл. ед" },
                    { new Guid("ea0fc1e2-763d-46da-8d6c-98c3993cebdf"), "Order name 697", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 24.111694687389m, "усл. ед" },
                    { new Guid("ea23d48e-1fea-4781-befa-f1a79289e8e1"), "Order name 1798", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 136.523701757491m, "усл. ед" },
                    { new Guid("ea41a364-b53e-4baf-a3b2-af4796d2935f"), "Order name 308", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 220.983271526421m, "усл. ед" },
                    { new Guid("ea4778c7-89f4-4df4-a332-012f5819955e"), "Order name 1630", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 149.655173029463m, "усл. ед" },
                    { new Guid("ea678b72-39c1-4bed-b080-1c0429768788"), "Order name 2075", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 119.371532699548m, "усл. ед" },
                    { new Guid("eabfddac-2dea-42c1-ab9d-d64b26cb0233"), "Order name 2305", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 5.43346564057887m, "усл. ед" },
                    { new Guid("eac51795-ba2f-4669-961b-470b0a9ccca6"), "Order name 1776", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 281.074713250679m, "усл. ед" },
                    { new Guid("eaf1aaf1-16af-43f1-9b7a-202a7ce9b473"), "Order name 2086", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 450.467146385893m, "усл. ед" },
                    { new Guid("eb2a8f51-52b4-4719-8a6a-3294c8225507"), "Order name 2321", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 760.80674133881m, "усл. ед" },
                    { new Guid("eb2ee424-20ec-4cb1-90eb-af7061252789"), "Order name 1046", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 551.94394775383m, "усл. ед" },
                    { new Guid("eb418122-3b84-4a86-9092-6d3402d75a00"), "Order name 1757", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 23.6550937927514m, "усл. ед" },
                    { new Guid("eb5fdcf1-79bd-4525-90ea-7dad9e075710"), "Order name 417", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 57.0532326901078m, "усл. ед" },
                    { new Guid("eb917e3d-abc6-4a80-a24c-f822261e9c5a"), "Order name 1891", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 170.850768657007m, "усл. ед" },
                    { new Guid("eba97c35-33a6-4f66-a6c1-47aac7c33b4e"), "Order name 1819", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 97.3632030379796m, "усл. ед" },
                    { new Guid("ebbdba33-d983-4605-bd6a-92766dbd4afa"), "Order name 2340", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 532.60769457531m, "усл. ед" },
                    { new Guid("ebbfa279-36e8-4869-8992-47afbb83b0ef"), "Order name 2428", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 137.160015787304m, "усл. ед" },
                    { new Guid("ebe19948-63c7-48dd-8293-74b0914f13a6"), "Order name 1918", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 859.470334366125m, "усл. ед" },
                    { new Guid("ec2020da-47cf-4f91-9ec7-0c05d4ca8ebd"), "Order name 292", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 159.924309098356m, "усл. ед" },
                    { new Guid("ec2efd79-aa09-4b4d-a657-5065b9a4be7e"), "Order name 475", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 257.651664674453m, "усл. ед" },
                    { new Guid("ec475e29-1bdb-40f8-a5e5-919ef6782b73"), "Order name 1152", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 141.454288629136m, "усл. ед" },
                    { new Guid("ec59152d-aee3-4ed2-8b65-404d762e3999"), "Order name 1571", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 341.75678566509m, "усл. ед" },
                    { new Guid("ec5d722d-825f-4ded-8a6d-e4777da00830"), "Order name 622", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 377.021268891392m, "усл. ед" },
                    { new Guid("ec921c25-b1af-4439-8f69-4139926198b8"), "Order name 1799", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 753.056657937196m, "усл. ед" },
                    { new Guid("eca6809a-e67c-436d-b4f5-8f1bf0553f53"), "Order name 1365", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 422.266010204702m, "усл. ед" },
                    { new Guid("ecaa2d86-0135-4b95-a2ff-54e62f4ba0c2"), "Order name 913", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 141.869009838286m, "усл. ед" },
                    { new Guid("ecae1fae-1306-4f45-af2a-97459ca3903a"), "Order name 563", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 13.0341802015051m, "усл. ед" },
                    { new Guid("ecaf60bd-0fb6-4d16-8a4e-a87a1bc8ecfb"), "Order name 2197", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 606.448625622003m, "усл. ед" },
                    { new Guid("ecf8ef9a-aa6a-4b96-a09c-a9a02965e510"), "Order name 874", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 60.3654230391611m, "усл. ед" },
                    { new Guid("ed1276e7-1bf0-4d22-9fc2-12bfb53b8cfd"), "Order name 427", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 421.529648238644m, "усл. ед" },
                    { new Guid("ed3ef6d1-f3aa-4aed-abfc-3cd4abcae532"), "Order name 514", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 420.620106145356m, "усл. ед" },
                    { new Guid("ed80a09f-3978-4b50-a749-db69bb9edf46"), "Order name 446", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 390.656670388396m, "усл. ед" },
                    { new Guid("ed9bac6a-f23b-4778-ad55-ad22de3a703f"), "Order name 772", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 201.066547132521m, "усл. ед" },
                    { new Guid("edaa0931-b346-4145-938b-d545296d3273"), "Order name 425", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 401.061062663817m, "усл. ед" },
                    { new Guid("edd38e51-f269-4db8-b0c0-d692da44ad14"), "Order name 2371", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 363.896442091011m, "усл. ед" },
                    { new Guid("edd897c3-728c-4864-88dd-6d6ab2a3b40a"), "Order name 1832", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 465.243467250555m, "усл. ед" },
                    { new Guid("ede7490f-8c99-4a43-a2e8-25d7821997ec"), "Order name 816", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 432.845274073937m, "усл. ед" },
                    { new Guid("ee3d857a-4e72-44db-ada1-777a73394f80"), "Order name 1513", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 134.161858082888m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("ee470297-35ca-41b6-9037-91ae3930ec6b"), "Order name 579", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 291.927989700305m, "усл. ед" },
                    { new Guid("ee74539f-3336-4813-85ff-5362b4ef1796"), "Order name 1911", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 425.937877183887m, "усл. ед" },
                    { new Guid("eec139da-64a3-4043-85d1-01f18bd5110f"), "Order name 857", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 281.173846089971m, "усл. ед" },
                    { new Guid("eee5f76e-1b6f-4b3e-8572-8d037ff83531"), "Order name 396", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 661.536972892155m, "усл. ед" },
                    { new Guid("ef01041c-d35c-466d-ae21-4659b2c04a9d"), "Order name 52", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 469.415060242859m, "усл. ед" },
                    { new Guid("ef129a73-c8b0-4bc7-8d8e-71ef435de77b"), "Order name 1710", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 902.930711364575m, "усл. ед" },
                    { new Guid("ef140634-68bf-4b95-9b8c-b7fc2a4966ff"), "Order name 265", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 99.7689141883896m, "усл. ед" },
                    { new Guid("ef200522-2a31-490b-857d-75da47f542ca"), "Order name 890", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 605.109330587831m, "усл. ед" },
                    { new Guid("ef26cda9-3cb6-4ea6-938e-733aa5f4bfef"), "Order name 1159", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 588.358976985527m, "усл. ед" },
                    { new Guid("ef2e5329-e2a6-48c1-b868-39a57102b1ed"), "Order name 2109", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 40.7369188233167m, "усл. ед" },
                    { new Guid("ef538230-db80-4f5e-b8bb-a2791c805088"), "Order name 252", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 246.030649115503m, "усл. ед" },
                    { new Guid("ef7e8025-f18e-45ad-897e-7baa16c8cef6"), "Order name 1875", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 60.9147488487567m, "усл. ед" },
                    { new Guid("efbc7521-aa45-4788-8b7a-f3a51722abbb"), "Order name 2246", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 228.414058704109m, "усл. ед" },
                    { new Guid("efc11ef5-cd9f-417b-a5ee-d77dd9e6ce71"), "Order name 1964", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 505.512558115404m, "усл. ед" },
                    { new Guid("efcc07c5-1f4f-4d3a-b809-c33f7c89a6eb"), "Order name 456", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 329.217312359708m, "усл. ед" },
                    { new Guid("effd661e-4cb7-4c7d-8037-ea09412ab8e5"), "Order name 964", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 223.319000019031m, "усл. ед" },
                    { new Guid("f0227ddc-6538-4fb3-bdbb-8660ec851d8b"), "Order name 435", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 316.411447966382m, "усл. ед" },
                    { new Guid("f02e9671-2fda-4b76-8376-d030f3dbe621"), "Order name 1840", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 97.5643441102946m, "усл. ед" },
                    { new Guid("f03ff5b4-597c-41e6-9780-ac7b31ef17ce"), "Order name 1677", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 727.056218118863m, "усл. ед" },
                    { new Guid("f0422c2e-6b30-4989-9d09-dd5f31fdba4d"), "Order name 1014", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 767.26351751882m, "усл. ед" },
                    { new Guid("f0577298-98c3-4fbf-b19f-7262f5d79721"), "Order name 2147", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 105.70626553502m, "усл. ед" },
                    { new Guid("f097a074-a44a-4376-be2c-03f442bc14c6"), "Order name 181", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 280.301574309442m, "усл. ед" },
                    { new Guid("f0a8309c-1dd9-4eee-8c45-99b2c82ea7a2"), "Order name 1376", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 158.312185548947m, "усл. ед" },
                    { new Guid("f0af756d-505d-4a19-af23-969949fc37d1"), "Order name 1414", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 290.074942201235m, "усл. ед" },
                    { new Guid("f0c65314-3be6-4bf3-848b-5c0388efc3fd"), "Order name 1865", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 105.938782043882m, "усл. ед" },
                    { new Guid("f101ea4a-05a2-40f9-94bd-d3f46fde16a1"), "Order name 1811", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 752.58943787418m, "усл. ед" },
                    { new Guid("f1032db2-f7b8-4f96-8933-54920e090f38"), "Order name 620", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 717.500762636336m, "усл. ед" },
                    { new Guid("f119b73d-c149-49bb-bcab-87db42d35a47"), "Order name 967", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 186.16214976617m, "усл. ед" },
                    { new Guid("f1379d7e-644c-405f-961f-7b980a21d362"), "Order name 2294", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 197.06427755284m, "усл. ед" },
                    { new Guid("f13d716d-a3fa-4ec0-8598-9e2004cc47ba"), "Order name 1311", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 416.010016317907m, "усл. ед" },
                    { new Guid("f14d2474-be83-4156-8c05-137a15d4fa06"), "Order name 391", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 101.780989628992m, "усл. ед" },
                    { new Guid("f1788b47-0594-4e5e-8975-55490137ab13"), "Order name 925", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 72.5674693287394m, "усл. ед" },
                    { new Guid("f193930c-bfe3-4ac9-aef5-5d567bac9c33"), "Order name 2278", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 144.029093771953m, "усл. ед" },
                    { new Guid("f196b36d-476e-42cc-ad45-a9a5b1f70015"), "Order name 1580", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 177.700011231114m, "усл. ед" },
                    { new Guid("f19ee912-219c-473c-ab27-876d7d666433"), "Order name 721", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 115.687258978524m, "усл. ед" },
                    { new Guid("f1b0b514-0255-4a48-bc00-0034169785c5"), "Order name 1526", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 181.938456317741m, "усл. ед" },
                    { new Guid("f1da103a-c3b3-444c-9ac5-eb213fa5ea5d"), "Order name 1316", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 68.5764316294218m, "усл. ед" },
                    { new Guid("f1dba031-be87-4530-81a9-18f120a2221f"), "Order name 1173", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 15.6959681062819m, "усл. ед" },
                    { new Guid("f200fe17-bd56-4591-af39-f51854fd3ed1"), "Order name 809", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 588.794238482749m, "усл. ед" },
                    { new Guid("f218bdaf-d2d1-4622-ae5b-445875b7b27a"), "Order name 1597", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 412.21046915491m, "усл. ед" },
                    { new Guid("f28ba277-c090-4276-a34a-e09ce08c289e"), "Order name 894", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 615.928452077512m, "усл. ед" },
                    { new Guid("f29e50d8-6c9b-44e9-acdc-4f51469cc606"), "Order name 1983", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 372.351568670595m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("f2b5590f-64b7-4fb7-a2c3-46dceed80805"), "Order name 2392", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 193.200072513127m, "усл. ед" },
                    { new Guid("f2b7ba04-13c5-4189-b8f5-c61ffcda0177"), "Order name 753", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 149.039170400465m, "усл. ед" },
                    { new Guid("f2c549e8-1708-4e0a-a136-7d5d40abc5a8"), "Order name 1535", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 34.5576124130093m, "усл. ед" },
                    { new Guid("f373f7f0-23b6-414e-b2c2-ea4104b0dacb"), "Order name 1709", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 253.054854073476m, "усл. ед" },
                    { new Guid("f3861270-c076-43a7-bb89-575baed2aa63"), "Order name 1331", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 249.168707796931m, "усл. ед" },
                    { new Guid("f398143f-2895-4726-9636-dfadbe4735a0"), "Order name 1895", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 11.7892548785802m, "усл. ед" },
                    { new Guid("f3a5a1b4-b49c-4c45-b0f8-5f1f5c212e89"), "Order name 1651", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 709.227211584248m, "усл. ед" },
                    { new Guid("f3b51701-08d3-4e70-817a-572fccd85696"), "Order name 513", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 142.503048789126m, "усл. ед" },
                    { new Guid("f4322cd7-e953-44f6-ace6-660ad23504a5"), "Order name 414", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 385.938667720286m, "усл. ед" },
                    { new Guid("f45d5ea9-3b31-413c-b639-e01047564570"), "Order name 1326", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 298.721196684142m, "усл. ед" },
                    { new Guid("f46ad5e2-f3bc-4ffd-b11e-f2b7b988bdd1"), "Order name 1105", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 480.603845769183m, "усл. ед" },
                    { new Guid("f4932571-fc86-4c3e-9351-3ba0b3549dc6"), "Order name 826", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 50.1789706897028m, "усл. ед" },
                    { new Guid("f49c035d-630f-4977-96ca-84d3916a8b5e"), "Order name 1849", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 50.4583953372574m, "усл. ед" },
                    { new Guid("f4a76f00-84d8-497f-b0a2-554a7ec1ee4f"), "Order name 1724", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 526.049029979776m, "усл. ед" },
                    { new Guid("f4b97ed0-b3b7-4d41-86c4-1c3ca5e63c17"), "Order name 1506", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 570.803639550484m, "усл. ед" },
                    { new Guid("f4b9e475-721d-46ef-b219-359bb48246e3"), "Order name 2027", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 180.43618323745m, "усл. ед" },
                    { new Guid("f4d289e1-095d-4713-89b4-3aaccec7df27"), "Order name 709", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 341.559573573324m, "усл. ед" },
                    { new Guid("f503d056-b4fd-4820-a1e1-18f2c18c176b"), "Order name 2047", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 76.1500338456058m, "усл. ед" },
                    { new Guid("f50c5016-aded-490a-8638-79df26a3883f"), "Order name 2357", new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"), 6.53407064672505m, "усл. ед" },
                    { new Guid("f5116e97-e856-4409-a815-e8738ce83067"), "Order name 482", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 89.975818264062m, "усл. ед" },
                    { new Guid("f54200c1-61ec-4e65-8000-cb485e5840a7"), "Order name 46", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 136.856849944206m, "усл. ед" },
                    { new Guid("f5f1b20e-d600-4cda-be5a-0b2b7036abc7"), "Order name 746", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 127.825621529m, "усл. ед" },
                    { new Guid("f60fde1b-2a1b-4fc2-97c9-80f63fa312c1"), "Order name 1267", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 108.442785112113m, "усл. ед" },
                    { new Guid("f67266de-f62a-462a-8f68-c5ff9daf0921"), "Order name 1965", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 311.003274670887m, "усл. ед" },
                    { new Guid("f68ca73c-cea3-49eb-ad81-9e5d5a4c50d5"), "Order name 431", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 192.881637400946m, "усл. ед" },
                    { new Guid("f69bcc68-c5b2-4068-9ea1-cf960228adde"), "Order name 797", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 186.88829234963m, "усл. ед" },
                    { new Guid("f6a6f967-9daa-4589-923b-2a376d07ef9d"), "Order name 2395", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 198.996391877739m, "усл. ед" },
                    { new Guid("f6c2e836-daac-403a-b463-1354a67d877d"), "Order name 754", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 446.312802564239m, "усл. ед" },
                    { new Guid("f6d247aa-2844-48b7-b929-89cda5396528"), "Order name 651", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 799.069860254737m, "усл. ед" },
                    { new Guid("f6e3ec88-fac1-4573-b855-884d31465049"), "Order name 2277", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 254.832921039763m, "усл. ед" },
                    { new Guid("f6f55350-e315-4199-aca0-65ef3307ab76"), "Order name 824", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 666.332942630862m, "усл. ед" },
                    { new Guid("f6fb03d0-8be2-466e-a070-6059bf2f8b80"), "Order name 2079", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 149.814031415844m, "усл. ед" },
                    { new Guid("f6ff7260-c7b3-4bb2-823a-d3026f9d5c30"), "Order name 464", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 272.308604231705m, "усл. ед" },
                    { new Guid("f7260045-8b98-4dbc-9ec7-1dd8d693a2ee"), "Order name 467", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 248.053586094371m, "усл. ед" },
                    { new Guid("f7260871-be7a-41bc-9da9-ddefc2d5df83"), "Order name 387", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 50.1600291484412m, "усл. ед" },
                    { new Guid("f733be91-5892-461a-81d5-d4397048134c"), "Order name 410", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 397.60918601477m, "усл. ед" },
                    { new Guid("f7340ef0-d9ec-4534-baad-9a6f12841e78"), "Order name 1107", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 4.15931954436934m, "усл. ед" },
                    { new Guid("f7901940-5137-4574-9db3-8c7436f76c9c"), "Order name 1220", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 887.290868900739m, "усл. ед" },
                    { new Guid("f795ddd9-f826-402d-8036-5d83768b1156"), "Order name 1692", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 237.659563374769m, "усл. ед" },
                    { new Guid("f7a7df8f-53ca-4818-b34b-406b046e11e2"), "Order name 820", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 78.425483418835m, "усл. ед" },
                    { new Guid("f7c92b01-dad6-4fc0-844e-ce4366e862bb"), "Order name 240", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 163.140697419403m, "усл. ед" },
                    { new Guid("f7d98e58-2458-4918-9fc4-06723d54a659"), "Order name 2336", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 124.747830183623m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("f813eb11-13a8-4118-80d5-fd2cd6f3bf81"), "Order name 1288", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 340.36906754868m, "усл. ед" },
                    { new Guid("f83d662c-c692-49c6-8614-72d4e81d30c3"), "Order name 2150", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 314.588911791002m, "усл. ед" },
                    { new Guid("f84efea5-e984-45e1-a0d1-9fdcc0f6dad1"), "Order name 896", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 189.584685494788m, "усл. ед" },
                    { new Guid("f875b8f5-95ce-43fb-a49e-d57daf27ae50"), "Order name 48", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 407.873284868046m, "усл. ед" },
                    { new Guid("f89133ea-a9c2-48ee-92fb-a87d487c35a8"), "Order name 1674", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 342.025285288568m, "усл. ед" },
                    { new Guid("f8bc15ee-d97d-4727-9e12-4145041968b5"), "Order name 1244", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 235.242263464372m, "усл. ед" },
                    { new Guid("f8c69c31-abdc-4abd-958c-4530f2b0aafe"), "Order name 27", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 98.4144521795682m, "усл. ед" },
                    { new Guid("f8cda2a9-bb60-4e14-82c3-6cbe5ad69c97"), "Order name 2209", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 61.3523312317961m, "усл. ед" },
                    { new Guid("f9458ea8-f7f3-4d85-b5e4-0d6d540440a4"), "Order name 923", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 293.137391128504m, "усл. ед" },
                    { new Guid("f9635b87-f1d4-4395-9710-0161532aeb71"), "Order name 630", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 669.917558880565m, "усл. ед" },
                    { new Guid("f97556a1-f07b-462d-8f0d-4b8e35203229"), "Order name 1957", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 303.544988193079m, "усл. ед" },
                    { new Guid("f983ece5-71f4-4820-a83d-31e67945f0c1"), "Order name 455", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 251.882125075101m, "усл. ед" },
                    { new Guid("f98ae42f-beb0-4ec3-aa78-90f6a09fa8f6"), "Order name 2439", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 20.3023562166532m, "усл. ед" },
                    { new Guid("f99ed38c-201e-43c8-87ac-3aa9493700c3"), "Order name 893", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 8.48487102186392m, "усл. ед" },
                    { new Guid("f9e99d15-5fa0-4f51-85b2-1680f59becf1"), "Order name 800", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 411.103137328598m, "усл. ед" },
                    { new Guid("f9ea1167-5467-46fb-8ecd-05626b2a3acc"), "Order name 2423", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 539.414514978285m, "усл. ед" },
                    { new Guid("fa0a4205-a2f7-4406-b46d-7eeaf0298060"), "Order name 2073", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 572.03602468735m, "усл. ед" },
                    { new Guid("fa39f830-01ea-4491-ba76-5d04fd770912"), "Order name 1448", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 784.511207386292m, "усл. ед" },
                    { new Guid("fa475a93-3166-4077-a989-b648c0eaab7a"), "Order name 523", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 854.271608404682m, "усл. ед" },
                    { new Guid("fa5fdb59-34de-4693-8510-80ec3da77df2"), "Order name 32", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 30.6359677914204m, "усл. ед" },
                    { new Guid("fa6da289-3294-4b0c-a7ae-7abad9c3d8cb"), "Order name 2332", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 55.269428488054m, "усл. ед" },
                    { new Guid("fa83b4f9-b622-4dad-bdfa-e6148a632793"), "Order name 2032", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 184.767912389835m, "усл. ед" },
                    { new Guid("fa990961-efbf-4a83-91cf-407b67e170a4"), "Order name 1881", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 632.450828655741m, "усл. ед" },
                    { new Guid("fb0fe3a7-dba2-4fc7-b89c-1de6305a563e"), "Order name 322", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 227.946400971176m, "усл. ед" },
                    { new Guid("fb478abe-1fb4-4010-b4af-f45a4e83c2fb"), "Order name 685", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 326.073253761739m, "усл. ед" },
                    { new Guid("fb62ea26-fad1-4a92-849e-dde4606c3b21"), "Order name 1228", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 240.141767780539m, "усл. ед" },
                    { new Guid("fb692b3a-ae72-47dc-9adb-69caa15b10ce"), "Order name 2363", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 279.284376912059m, "усл. ед" },
                    { new Guid("fb6e55e5-c09f-4d77-8ba0-08d587da117c"), "Order name 1684", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 573.823337661439m, "усл. ед" },
                    { new Guid("fb97224d-c658-438e-9f52-0bc26846348c"), "Order name 463", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 28.0927468243921m, "усл. ед" },
                    { new Guid("fbc5d04b-385c-428d-8719-214ff37f8abc"), "Order name 574", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 22.2204867985287m, "усл. ед" },
                    { new Guid("fc023140-65fc-4c17-ab06-2cc6682bb7f3"), "Order name 1002", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 139.500610948641m, "усл. ед" },
                    { new Guid("fc78830f-31d2-4149-bf64-94e4dc5c5f1e"), "Order name 2389", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 174.6418102551m, "усл. ед" },
                    { new Guid("fc91cefe-e5c0-424d-be1e-7bbbf9a5dad1"), "Order name 330", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 208.868133395583m, "усл. ед" },
                    { new Guid("fcdcbf76-f5aa-4d95-af04-d643d93da4a6"), "Order name 2140", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 78.8665108240302m, "усл. ед" },
                    { new Guid("fd0e5422-fa71-4af4-b983-bb703a729872"), "Order name 299", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 596.910201076584m, "усл. ед" },
                    { new Guid("fd1b7834-b34d-4fd0-abd9-db283ad9cde1"), "Order name 397", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 129.405847050308m, "усл. ед" },
                    { new Guid("fd1e5176-3b89-45df-9cc3-ec5a902fe9a3"), "Order name 762", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 15.1105826419995m, "усл. ед" },
                    { new Guid("fd2486f3-073b-42f1-b0e5-018e71fa3ae1"), "Order name 1199", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 99.6189359161194m, "усл. ед" },
                    { new Guid("fd56068e-d291-4c0b-8ed3-b5a39a933e5f"), "Order name 1716", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 28.9001021646984m, "усл. ед" },
                    { new Guid("fd620925-d927-4fb6-aa59-34802229be95"), "Order name 1585", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 218.126327484146m, "усл. ед" },
                    { new Guid("fd6a4cbe-f9d1-4617-807a-3090f16c586e"), "Order name 1413", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 368.971722249337m, "усл. ед" },
                    { new Guid("fd6a6b02-c146-4be1-9294-c71d191b34ea"), "Order name 1927", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 287.888821183251m, "усл. ед" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Name", "OrderId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { new Guid("fdae7224-8ec0-4ea6-a387-5a6b7859a931"), "Order name 313", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 816.852208529806m, "усл. ед" },
                    { new Guid("fdc85764-ccb7-4f6e-916c-e9c4a73070c4"), "Order name 994", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 351.250682160831m, "усл. ед" },
                    { new Guid("fde3f4ec-5219-493b-838e-68f3fd5b747d"), "Order name 1572", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 33.5646114645875m, "усл. ед" },
                    { new Guid("fe06862e-275e-4419-907e-c0d2206b468d"), "Order name 1993", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 814.852386790957m, "усл. ед" },
                    { new Guid("fe16af91-0966-49ea-bd6a-86ef92ef8f23"), "Order name 1736", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 89.3121695289642m, "усл. ед" },
                    { new Guid("fe223e7b-2327-41b6-b3de-953b6e7c4afe"), "Order name 1951", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 17.0599079186115m, "усл. ед" },
                    { new Guid("fe48da15-1d00-435d-94a5-9729154a8021"), "Order name 2201", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 572.172882423644m, "усл. ед" },
                    { new Guid("fe56ef72-3e05-4902-ab32-5f2bb6b78cf8"), "Order name 1740", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 30.2104608436818m, "усл. ед" },
                    { new Guid("fe7a2a96-4937-4d4c-acde-2c561693871a"), "Order name 1628", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 182.318052072975m, "усл. ед" },
                    { new Guid("fe98f65e-ccdd-47ba-b29e-633a3dbe8fdf"), "Order name 1212", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 314.461844509069m, "усл. ед" },
                    { new Guid("fea32fd2-0718-42bd-905b-af0f17b2c8b1"), "Order name 1944", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 504.553930924284m, "усл. ед" },
                    { new Guid("fea7835f-c930-490d-8ca2-6345f8be8b5c"), "Order name 1786", new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"), 85.4981406221338m, "усл. ед" },
                    { new Guid("feb3d60d-ace2-4f9d-b5c8-23f336c45bf7"), "Order name 1027", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 158.898672931799m, "усл. ед" },
                    { new Guid("fee38800-dd09-435c-9045-4189f76f94c5"), "Order name 1165", new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"), 558.373441142826m, "усл. ед" },
                    { new Guid("ff1dcaf9-3e5f-454f-aee2-75ec47514897"), "Order name 1225", new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"), 462.056206557666m, "усл. ед" },
                    { new Guid("ff385c98-d8ec-46b5-81a2-ee5bc5dbac73"), "Order name 2020", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 56.994242402148m, "усл. ед" },
                    { new Guid("ff5986ca-77d0-4544-9d43-b06b37c9c7ec"), "Order name 641", new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"), 219.644764818171m, "усл. ед" },
                    { new Guid("ff636b58-8d64-4ce3-b161-b5980f7f52c0"), "Order name 578", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 367.225882179228m, "усл. ед" },
                    { new Guid("ff70b9d9-1d46-44e7-9835-f368a565bda1"), "Order name 500", new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"), 77.7128734907207m, "усл. ед" },
                    { new Guid("ffa6319a-684d-4825-aee4-3a20b7ce67f6"), "Order name 2333", new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"), 434.259190700254m, "усл. ед" },
                    { new Guid("ffc352a1-aa99-4961-8446-979c4f9f3ced"), "Order name 8", new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"), 427.051219737426m, "усл. ед" },
                    { new Guid("ffd333d5-9d85-42ae-a6c0-20cebba49202"), "Order name 1260", new Guid("f1237230-5506-47d9-8b7f-596f3851b117"), 233.469918309595m, "усл. ед" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("001a2108-8ca3-4b92-8a86-c77f5fee1f1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("001dc2f3-107b-4a46-92ef-f57f3f3689b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00291f5d-fa17-4b3d-aeb7-d39b53a4ee12"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("002fe6e0-63ad-432f-9561-38770abba875"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("003acff3-78bd-417a-ba76-548d5fb0356c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("007765f0-2a07-4447-887d-40dd30a04245"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("007a4898-017b-4b24-808e-c79692b4877a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("007a96b6-2607-4220-83ad-912ee1009fc3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("00d31a14-4475-443e-87af-45307543a4e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("01799c79-df7e-4dc3-b880-9336d2831e64"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("018ab7aa-c904-4f9d-918c-817869c42dce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("019b1a2c-aa41-4cff-9a62-7d40a8ef9c9b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("01bd4069-21f9-4254-a248-04b92e560abb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("01c8c4b4-a105-4b73-9b8d-625628c717d5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("01f00d18-740a-4293-8135-e51c10e76935"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("020a6e09-db53-4d86-8b3e-dcbf59ee52a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("020f6443-9431-4799-b5b6-2bbb641f2815"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("024dc8f8-87b0-4085-9f27-747523fb4bca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0253303f-1d6c-4c3c-88ea-11e23aa16c1b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("026ea321-f2a5-412d-aaa0-ac73a28d2867"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("027cb3b1-b4aa-460d-ae71-6f22b84b8cdb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("02826810-8136-4f4c-9338-ce9205c4aa67"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("02bb59a9-b9a0-4983-b4ce-4626902adf20"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("02d8520e-ab0d-414c-b906-d75ec689c598"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("030dc9f5-440d-42de-b7a8-b90c03f4f984"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("03214401-5337-449f-95de-a107489283d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0345adfd-4d90-4d9d-b8a0-b3048e7480d3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("034efe5d-ea68-4632-a67a-b5cd887b9c32"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("035ab447-abd7-489c-a3db-1fefe48e0faf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0381b2b0-5681-4a5e-8437-ed0215a05ff7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("03a3ddff-de65-4eda-b92e-2ab45cf44e69"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("03d55b5f-964f-45c5-a0c5-a25945c03c3e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("03d7cb86-5384-4ddc-89fa-e178301e510f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("03f05adb-e824-4507-823c-a5d0bdcc87f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("040199cc-97dd-465c-a6ed-b0136d89f363"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("044f204c-fe8c-467c-90ff-585c6fb416ea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0459b543-85e9-44f0-af33-d9498e5770d5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("04a30e9e-4c1d-4cc3-a085-d817ae2d026f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("04b2b899-34a7-4a91-89d5-1c9faf9b5594"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("052b03ba-7b3a-4745-a73d-d3ffa1f7ad23"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0548e6ed-1740-419f-982f-a5fc6b9c6afe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("054a5100-0c81-4c23-b6eb-7b783bd993e2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("05a38850-b7bb-462c-860e-8b18d0491d24"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("05a9d378-c9b9-4dad-960f-c8d709f1c06f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("05c280fa-e64f-417a-8674-34d9efdd057a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("05c4119a-b972-4435-8606-08c11c9be0f4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("05c9694b-0bda-4aea-92e1-8511018c0790"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0619d5ee-fba6-4acd-85a2-10105322bb1b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("062c31ca-d2c2-409b-b38f-f7a80c81994d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("062d4d90-ecc8-401f-9923-cccca8b7c2a1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0653cbaa-89bd-47f7-8cea-8b8c659533b7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("067a7510-d8ca-4957-94f7-104a65343dd8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("068883f5-aaa6-48c6-8b5c-fe64cdbbebe1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("068accf0-901f-4bcd-9143-09e452b5e6ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("068d402c-5136-451e-9531-81a32ff13a2b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("06991f0e-d160-442b-bfd6-db4e85f0afe9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("06c4320e-8564-4bf2-86d4-a4151274ab9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("06fb58b1-0fa6-4fc2-8974-f219a2993450"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("076c68d2-7182-4e1f-90d1-4eb83b73d7d3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0775b64f-8535-4e22-8a7c-c919e12ffd16"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0780eedb-b3bb-406d-bf1c-593c0783cc94"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("078af6fa-7469-4d07-9ae9-740f9591ec53"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("07d453d6-f00d-417e-b0c9-df25dbf16c1a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("07e6b139-cd73-4e92-99f9-55fbf3255cbc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("07f939ea-7f2b-4113-b265-c0d95466c7aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("07fd449e-0e1e-4393-982c-2b5fe1c69664"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("07fe6eaf-07eb-4fe6-9bd6-56f0d1978003"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("080abe67-77ba-4a95-a0f9-d15b547c3634"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0811fa0f-3f8c-42b0-b420-a145bea01fc7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0819c5fb-38ee-4d6e-bbe8-14252230568e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("08334c9a-742e-4773-8d11-eabd36ecc610"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0836375c-e069-4fe4-9f4c-8836200c9349"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0838c9c3-38cd-4310-9f2d-4a24603129a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("084283f5-30df-4ee0-a491-939184f951ad"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0860ac36-db12-4967-9e3b-0111d1f8711d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("087345b7-959e-4047-846a-c53c2f078de6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0883e527-9bfe-40c0-a459-f833c90fa396"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("08d02302-3a89-4902-9b2a-6a54afe98882"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("08d06c7f-0819-4e72-a5b8-384e52513283"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("08db1b8d-6d1a-4a1e-961e-1bd5a5ab5be9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("08f45c84-b4ed-4c18-81f2-ce53184ad620"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("090cd5c1-5445-4acd-ae53-b1880cfddf7d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0912fe2c-40a1-4277-aab4-48fb55b065ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0933706f-9eb9-4771-afc5-4f5728939ef6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0947d409-a573-4214-8486-32ad43568f0d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("094c70e2-7a17-4cba-a536-0fdc23ae7b6b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0956ff99-8d96-4762-a05f-62f2a906586e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0968a6e6-5809-4bfe-a19e-c6f9f7d6f88b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("099c5a75-32ef-4a9f-8745-7f7e9b340a98"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("099c6277-1ada-4682-b1b9-c50bd8af944d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09ba6ea7-85e3-4a76-a5ec-24c8ab657e33"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09c3277f-1159-4b46-8252-af0b18538b58"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09c935d5-a82e-4c71-8ca6-fd16fb0a674f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09d73000-11d7-491e-bc53-75ed4fcdc7a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09da24c5-f071-4481-9b8a-8c3d353aa7e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09e330c6-9682-47a9-8d4d-414092c6ffa2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("09ea2050-c710-4fbf-89d7-cbb2e631d05d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0a01af49-404f-4278-876c-0394f5cbe384"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0a38aa33-0836-45ab-b7c4-45494f34fc60"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0a6ddc8d-e2dc-4ccb-87c5-db4615ee9653"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0a81e32a-0799-4313-a9f5-ab63124883cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0aa3db71-492e-4684-9b4d-e20be1ccecb1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ac69804-5586-41c6-b183-5f4c4cd31360"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0add9829-1d1f-48eb-8ebf-34d538dbb49f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ae096ff-470a-42c8-baec-7e287c7adf74"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0aedb046-6b3f-466c-915c-4414e176d2b1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0b12ed7e-ccd6-4230-8050-5362ff496f4c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0b2acfb9-861e-4d79-9e27-1e941d74df61"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0b405fb4-b85c-441a-8aa4-d3e15d331763"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0b5a6d3b-a13f-4ca8-b1d4-433391539f34"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0b931010-6d55-493b-a499-da9ba12eb508"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0b98e2ed-1bfe-4233-a52c-7451808d8991"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0bbcb5b3-1f98-45b5-a348-bb41fd6da180"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0bcb3134-f15e-459c-a3d1-9ef7db1ef8fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0bd199a6-60ac-4278-ab50-cfdd3d2e8fc0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0c0b3c31-b29e-44c5-af28-0a65a576cf6a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0c7bb548-3a29-4abf-94c7-0ead86ca13d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0c8e3910-ad56-4783-acb3-670236f32680"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ca8746e-a1d4-4898-b155-c5517bb5d212"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0cba4068-a8e5-45b0-8883-1e7b78895080"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ce64f7c-d980-481f-84a3-aaac24cb614d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0cea65c1-6597-4547-a0e5-37b38618f4a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0cf1e676-3797-46db-95a8-bbec3b404115"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d004afb-412e-4dca-821e-025156b79f59"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d08a697-4815-42de-a3ac-f78167849d50"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d4987be-0e30-4923-b302-188261768153"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d62a51b-1bfe-48c9-8c3b-c92d0bee820f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d7b1bc2-f55d-4afa-8ba5-3858a3be93fa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d7c2f99-09be-4115-bb36-a6cc1e036747"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d930677-f3cf-4a35-b088-fa8e4fec5bbe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0d9bad56-ce35-4573-9c34-adaab83c624c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0dc3ab65-4f9d-4ed1-af5e-e598e0e4cff9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0dc40599-54ce-4ecb-aa0b-cd3300cc88d5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0dd3e57f-0a8f-49ce-82de-fa26987deae8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ddd5e50-10e5-4665-b9fd-cf8927123c51"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0df08ffb-5c88-470e-958b-c19012113e8a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0e1f7c32-cc1b-4027-9006-85b5c936eb90"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0e36f6d8-4801-43b0-803c-7884457cd3ad"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0e4117bb-24e8-431b-92ab-9905cbc18971"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0e565715-1c4b-48be-a3f3-a916f8403247"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0e649abb-1a77-4670-b302-0640a2e00fa6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0e86dcfd-2336-4cad-8e8c-65bd24b33d8e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ea45977-06ff-4337-a16b-f91e725d5328"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ece095f-2161-4aef-a0c7-7f02f96b990a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ecf16ae-a0e5-484b-861e-57e19451e9f8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ee5850e-8a40-4a19-be51-8e38391091be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0eed1a5a-caea-42ee-a834-1b6e62d32116"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ef5155e-2c10-4216-9169-409545babf25"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0f30a008-4404-4f7e-a68e-33bce744384e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0f4183c5-8918-47b1-9d79-094ad7545385"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0f4979f6-2f40-47cf-9090-fe1476b9869a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0f5b0735-b09c-486d-b796-d661152fdf5f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0fa5d9a0-bac1-4c62-8ab1-cf9ad70bddc8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0fc0b1e7-6b40-4d21-84d8-95b24850a8be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0fe157ab-ef1e-4876-8849-2e19efca6011"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0fedf0d1-f4c2-4a40-95fd-885ca036ccd5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("0ffd71e0-8ca9-4629-b524-9aebe71b0799"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10266060-7a18-40c4-9e5e-e937b4a237ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("102ade4a-0a0b-45a6-9c41-0582ef4b9e13"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10662180-6b7b-4c2c-9369-e1a22ed22573"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10b187fa-2d72-4dfe-9263-b45afecff182"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10b634aa-d539-4565-a6a6-d2a9566d57c9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10cd66d1-da6e-47c1-96b6-0d849b2af4c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10d9ce50-6e06-4274-b437-3fd1b5b39eb1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("10dcf379-603c-4400-9696-effb4f3809c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("110c2321-19fb-499a-9248-00a3980f0fc6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11231a20-1b68-48a5-84cb-a6ef920d84a5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11313b33-c12a-46ff-950b-ab72d29fcdd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("114567a1-5880-499e-a2f6-036104117888"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11500121-c574-4764-802d-941c99c107b8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1163fdfe-3800-4aa6-84d5-475fff7f0003"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11bf60f0-948c-4da2-9c5c-db673787cee5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11c48230-cb80-4e48-b721-44b496f77f87"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11c536ec-2076-4e8e-9ce7-dcb9afbe11b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11d1dfd5-5b5a-4a53-9be5-b4e5ee31d6c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11dbb989-662f-4534-82a7-310d28e4943b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("11e3a1b8-7c1f-43b1-a54c-a510673b7486"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1202dfde-74d6-4b36-86f7-b007dc9f3089"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("120ce2c1-e145-49af-a3c9-e62ac85afb0e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("12238a2f-ee98-49cd-943e-01f6421e6ee6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("122d7a13-0133-47ab-896e-e6c9e6a3eb05"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("122eeab0-35a9-45dc-8b78-f3f4843a9526"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("125d6b76-ecff-4dfa-8e83-7a472c6c85a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("126c4ea3-ccba-4ceb-b5b6-a3c2f1077d75"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("12a4d1bf-9ef0-435e-8c15-1b5235064432"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("12aa9ad6-8619-427f-a1e4-50a2359bf62e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("12e721f6-9918-4fb5-a627-370d5f0dbfb7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("12e8fdb6-3aef-4fc8-be73-2ffeb8ecf873"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("12f62493-3f1c-4a1d-89ae-2c0a52f10b58"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1300d0a6-c5bd-4595-87ce-049c292147c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1314df3b-a18d-4d79-a7aa-da3b4de42ab4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("135f7e53-796e-425a-94cf-a2697d40f6b4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1391745b-abff-445a-bec1-de70fa5bd72b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("139d1919-a604-424c-b9ba-5b16eeea55a7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("13b3c5f0-ddd2-438c-8187-b212df656da1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("13d4673a-0572-4695-940d-60da051b615b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("13d75ebd-3b7f-4882-ba6f-75fb245aabea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("13f9cc2b-27d3-402e-8621-45a8c4167167"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("142daea7-19b2-48f5-a298-122aa04cbf58"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("14418a1a-3b74-4046-bbe2-2c1adb337fe3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("144369be-ce6b-496a-9175-ee2f3cf3e91b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("144bbbcb-8e1f-405b-91fc-16d1f8fe05b7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1450768d-8df6-4284-b80a-0256c1c2180d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("145e4575-3f00-406c-bba8-02bf4cb291b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("146b4078-38d7-4f1c-81e2-f462434aba75"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("14c97146-b3b1-458f-8b6b-46430ddd7790"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("14cc381b-4c36-4a63-8098-ea075ba40bab"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("14d0247a-5939-4380-9f0d-57fcfcd08101"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("14efd7ed-bf44-4f60-aaa6-4052eabe047b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("14f89b0c-caaf-4364-8796-a719df2a08c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("15112501-5f23-43a4-b116-75831680a7df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("151c299a-53b7-460a-a8c9-4178f82792a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1560289b-869a-4702-9e34-73b91690c174"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1575734e-000a-4897-b3d5-47b8ecb46172"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("15adb229-e9e9-47b9-98ba-cf559730a76e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1604d424-c94f-4499-9222-a23675b034d8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("16064017-392b-4729-8f62-bcb5ecef3251"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("163b7212-38f6-4000-8900-1d18ad705ddb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1668a9b7-36aa-4d3e-9db0-38818188c421"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("169fa834-c0a9-4986-a830-97ebaa39f0ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("16b5fae3-e34d-48c0-bced-d8bda4175667"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("16e5cc0d-16b4-4bc7-929e-10a18e611a86"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1702c952-d63c-4603-af8e-679ede5f0391"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1703603f-65e6-439e-a796-211b6dff35f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("17073229-2fd1-4763-a8a9-333cce382a33"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("172b2816-4c4f-42ba-8346-a21fad73465b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1737633f-6a86-4030-8246-9b52fe4df563"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1748e162-be24-470a-98fa-226215176d81"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("174909af-dbaa-44c8-9802-2bde2259ede3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("175ab321-a685-4b3b-a33a-60af446bd9b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("17636fff-4289-4fe2-95c0-edc26f83261e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("17785a9b-6347-4d54-9732-f8331eb26806"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("17c05ea9-7819-4dbb-b4aa-7e6f14b30596"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("17c8f198-c85d-4ff0-8a86-6cb9fb59fce9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("17d2f9cc-d65e-402d-bb4c-6f436064205d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("180a4518-03b0-4c19-9fdb-6d5954bcf5ab"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("183d334f-537e-4d6d-a9b6-2f27c9932e92"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1846ba64-a71b-4024-bc16-f7cba0e90e46"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("186214b7-b4db-44d8-bce8-878fd1b239b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("186f2f64-2505-4da6-9029-bc10e1cf22fc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18708277-ebd7-4e9c-a03f-5f47a5ba264a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("189911ef-57cb-4fd6-8a6a-f7b96fafa0aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18a270cd-27cd-428a-8597-f0e83ae55435"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18acfbbb-a384-4a88-9088-e8757c84b0df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18d0fbf7-f2cf-498e-86dd-ac5e370cf443"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18d5b65e-46e3-4748-a79b-d934f35da86f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18d61502-5d11-45a2-826e-238558baad91"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18d62501-5e74-4462-acf1-a250fca564e0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18f104f9-0019-4648-ae12-ac2881023b1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18f9768d-5734-445a-a6f6-5cb4b7f9526e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("18fdeb7a-2b5c-40fe-bec4-8b0cf7f488a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1921b60c-90cb-4e5d-8f2c-ecd873af8290"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("192b7252-8159-4f31-9069-5b93268478a8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("193f017c-3c6b-4aaa-8ede-0060fc519b59"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("194d958e-d119-4110-bfd9-97586ba51884"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("196845b8-f72d-4de8-aef7-44af0b886bc3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("196b9143-d025-4ae7-b51d-e435033a2c2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("197d7446-36bb-459d-9a1a-fd804167ccbe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19862f77-6709-4cc0-aef6-f58e940936c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("198d7173-5696-4bff-a3f5-ac933a28b452"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("198e6abf-247a-42a5-abee-3865445565e9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19990c3e-74ef-42e8-a2d5-f8670304c95a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19ad521b-1d44-417d-8bf8-0fd38e1ef661"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19c249bc-ae0c-4268-a8d8-aac6fe0f3a2a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19db33bd-b967-42bc-90ae-1d47377de7fa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19ddc90d-6563-4f8e-ad83-de349834295f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19f13593-94dc-45e1-ac42-e045e314c6bf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("19f57228-5e0d-456a-a52e-e52b37ea1a23"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1a35f355-12d9-41ea-8f7f-a18d2118c90c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1a456bec-53c0-44e9-880a-53e770bd8c2f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1a765bba-74c2-46da-b576-a705ab65ffcf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1a7f4989-8180-4709-bd03-23b9f7015bbf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1abe1748-9ad5-420a-85a0-cff8f44a9517"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1b396783-90e1-4504-9e2c-be9231309bf3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1b4ff530-c46d-41e6-8e81-bf46d5222668"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1b6e6ab6-0902-416f-bd23-35bdf0eb8334"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1bae668c-33b6-4fc1-88ac-d7f2aeb77640"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1bb16770-5502-498e-bc26-102170bae759"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1bb8820c-6a65-4737-a7a2-7e6a5697b3c5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1be3fa74-1834-45aa-9f89-12adbe937d70"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1bf61ae3-2ed4-4efc-a713-56c771ea989e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1c2e6271-a1ec-466f-b70b-bf4a49a2f3d7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1cce263e-a7be-43d1-b51f-5ce6a3d3379a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1ce9ca4b-eb87-41b1-a6b6-9b42f49dab10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1cec41c6-44d1-4df3-b70e-697698783969"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1cf14ac1-92f4-44fa-8316-700d3297b5fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1d66f3b3-cf59-440c-91dd-8d46155ee3dc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1d98e58f-f273-4675-8435-087444874035"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1dae81ad-ddda-45c9-8d5a-fddaed8f3153"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1db5f9ad-17bf-4a58-992b-1c4a511ee604"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1dbe896c-2025-4fbe-97fd-6efa7dfe7dfe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1ddda406-6ee6-4b34-b3a4-495dc2cb5bd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e062d39-e5c3-4632-90b3-561f2e495c5a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e13d7e3-8a22-4a70-a0d6-d05fd2de83fa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e28ea08-035b-439f-b168-9ada092eb920"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e321f9a-1bbd-4bd6-8b28-b21252372fda"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e69dcdb-a2ec-42d4-885c-b7267238942e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e8273b0-55ee-4856-8ff9-6451ac557c99"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e924c92-0855-4c0f-b92b-76c33e9788d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1e93fda4-3e15-45ac-baa4-e1d95748ce7f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1ebce3c5-bf70-4fc5-b94e-6d76a46f3846"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1ef8abbc-ce19-4159-99b3-995691f5bc9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1efcc774-3346-4b4e-a2a8-ef8882837b80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f09bc22-ad17-4ee9-b6b9-e703557e131e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f30247b-8660-4142-a9de-508923523020"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f54dc6c-d578-4989-a6fc-82058c9f548b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f5fc438-64a4-4b63-9721-6f2710cec3d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f72901c-b772-455f-94f8-851d58996d96"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f8d1aa7-df7a-4648-83b5-51c8b1970606"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1f8f659b-2589-4c7d-9be3-bc9cebb8261c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1faa73fd-d969-4827-8756-15d8de165224"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1fde05d6-b8c6-4838-98a0-47c86c4fbcf3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("1fe70050-9067-4a3a-b82a-7520e04afa8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("20567d15-8dc7-4712-b799-8456992868ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2065f983-78cb-4f4e-a79c-0a9ec1eedbd8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("206a7a2e-3c9a-46e4-ad2d-54e0a994a4d7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("206dbc0f-c0cf-4e27-8d17-0b4149a665b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("206dd2dd-5d93-44e5-9649-24e161940f8d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("207766b5-20dd-49cf-a2c3-b8a2d1f97c3f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("207b963d-9f48-4638-8d65-9ccc0e91e6b8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("20821be8-a33d-495f-ab90-669e68df87f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("208dd436-fb55-45e4-af63-a37a469f35c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2097f0b4-bc55-4e75-9f15-6e4dfd1b3551"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("20e53c33-2047-4f64-a4d7-ed260bece7f5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("21026fb7-352e-4900-b145-8100f46b0429"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("21134a21-13f6-484a-b598-a3b09f2673f4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2167608b-f7d0-447b-8839-3adbf2099570"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("217d45a1-a68e-4509-9f00-f66517db6d28"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("218f9e9e-d98a-4bc7-9b84-a79a4614752a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("21c8fd14-b87b-4c40-afe6-3f853672c620"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("221d717c-8fe2-4361-8ac0-c938866662bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("22321b41-24e1-4297-b0da-8d54e213cedf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2252b75a-053d-4c4c-a14f-edc29270738a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("226a95cb-4e43-480c-8598-104112f92663"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("228d8017-a930-4061-9663-db802523c4a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("22b8d321-6b2d-4b94-b4c5-c0443d1d388e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("22c159ca-f8d0-4879-b1ae-9bccfed4b140"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("22f5a087-a96a-4cae-9f77-4b9fa0a460e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2314d820-e03f-44f6-8d07-ac99ef6ca502"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2355c00a-c5f1-4bf7-a5e0-6576e179abb6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("23593f95-8d45-40dd-8035-8b1fcd521954"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("23bcaf3d-56c8-4dc7-9909-365f868dbd40"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2405487a-b972-44e1-9261-ed92d04a8c7d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2408d1fc-d4ea-4b65-82e4-0d7dfcf13d84"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("24113990-6687-4ea2-843c-849b1d419efa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2430b65a-728d-4f41-9c40-e6e1b53ebccc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("246a4b17-e75a-4560-a2ae-8483736d4284"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("248a0956-8fcb-4f05-a42c-dd31ab029989"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("24d6590f-ad64-4c5b-914b-afb13b4f3e1e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("24f23c5d-86b5-4453-b70a-65d369e9be4c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("25079c3b-e715-47d9-a96d-a5e7d9dd995c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("25151089-f308-4ec1-a9b0-41aa5cfd196d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2515306a-9878-4623-b33b-4b38c5ebdc27"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2561af09-0346-4b87-ab91-63f6777eb58e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("25629676-5c7d-4754-99d1-482ab5d40ce0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("256f0ba7-9069-42f0-ad3c-f1cbd07224a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("258ec2d9-fc09-4f4c-9423-5be9e16dee8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("259ebb59-203d-4a9c-9591-758bec3e101c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("25d17e78-b2f1-4e48-a171-d4f1b5f28ae7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("25f1b6ac-9337-43af-894a-80ade87d14d1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("262f4451-7f8a-41e6-a6d9-2d9272a65409"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("26d3462e-350d-4f43-9a66-c349213583eb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("26dfc5ce-6bec-4cc8-bc98-3ef114919be1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("26ebd9ff-bb17-44d9-ab42-72b5a1c04f0a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27080de3-cadf-4712-adb7-89430c118aac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("271c7b7e-dd07-49f3-b8b3-357cc2a2a159"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("274bef20-8c9a-45aa-8fed-5c7af75d465c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27597e71-1869-4bf4-bfec-b617d34f7dba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27783a0e-cba3-4cd5-9774-169bc79c4203"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("278fc94a-2559-4b26-a467-9898edc9567e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27926465-37d9-43c2-8ec5-4dd92f6b50a7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27961e26-314d-4983-b4cc-f5d68e9b3557"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27a7000b-bbd8-4d81-b97e-741fa34b5c2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27b622d7-bc77-43a0-9cc6-91d21cd86629"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27bf4ab4-8207-429a-9ac6-319ddded1326"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("27ef9146-eb9b-4ecf-96f1-516c7f2537c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("28280c20-ec9f-4313-a875-d4c07f91b76c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2835fc4b-5bdf-4036-af2f-96575b9927f2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2842b3ae-84b9-451d-ad6d-15abf9df5ebd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2868891a-04dd-44fe-803b-d4f630ae3747"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("286adb0b-a7cc-4749-9b0d-1848926d1f52"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("28a2a333-b150-4e58-a168-3d9c76e594fc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("28aae314-b760-4644-adae-275ea39fdc32"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("28bd80e7-2853-4358-b566-e2dfc809c6c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("28f76412-8b1d-411a-9be0-7565a4e2f824"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2926e3f1-edb4-465c-aa17-f16592756387"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("29330684-556b-43b7-890a-f2d91adf9215"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("29334b34-79ad-4f30-b605-4847a65bfa08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("29554099-d81b-4bef-add0-bc1e622bd2e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("296cac93-21af-433d-9e28-0ad1a9d9b776"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2985379d-905d-4d8c-9691-c1caf8671a89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2990a680-38d9-4463-8dde-dfdf1c15a450"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2991398a-8191-42c7-be54-d925d3d4b9e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("29aad370-ceab-44d3-b221-d386877e0ac0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("29ea3eed-e4bd-42ba-a177-04090e8d2997"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2a086083-b604-4a82-9698-57d67c610dc9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2a10e27c-3835-4995-9175-7793f79263c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2a1a93e0-bfe6-46a7-b2d7-7f74224bf163"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2a201c71-e18b-4187-8dff-74f0d9574045"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2a4fdb6e-bc3f-480b-9114-22b70b5219e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2a8d68c7-c18d-42e5-8ae5-848347027635"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ac033d4-cbb4-4c53-86a4-f755737dacd5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ac58ed5-be65-44cb-8882-f022e8b7c2ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2aca3cba-9de4-4ab6-b3a1-f311a19bc119"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ace4f38-6269-4524-becd-9a7302f6001e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ad4f820-4754-418c-8ac4-c0f468360c97"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2adfb9cb-91a5-4399-aac5-a36e70f61786"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2b0e7a2d-65cb-483d-958a-820b2f7e5d95"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2b3f2773-3c67-4c89-b80e-e927536443f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2b520892-fcd0-4b4b-b5be-1d9d4259d03b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2b718da6-09e2-42be-9087-7be44e8f9f5a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2bb58cbf-e648-4d2f-b269-7deb82e46999"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2bbe8303-b8d8-468f-8387-c981b454c3c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2bcbb369-20db-4338-af03-b573fb1e95cc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2bd381a1-27ac-42d2-b28c-f48dba38adec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2bec21b2-c8bf-4ed9-b6db-750ad231026b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c36edf2-8a0d-423d-8782-92f178aa618d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c3a3058-12f6-415c-a847-5ccd3bc8b3b1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c65680b-75a2-4520-8a94-22fda6b4ca56"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c69a676-8a2f-4741-93f2-c9fa04e5257a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c8ce22f-9d3e-4346-9e20-2db6ceb443cc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c901d83-b6e2-48df-b6c3-7b05588865bb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c95b5c4-d7ac-4c75-8f97-ce39a1e80590"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2c9cf941-4d80-4d7e-8f41-d8c300973aac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2cdb0ab5-5e3c-48b2-9a84-a788c17610da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2cf56870-2c52-4afa-8b42-08866ac2854e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2d307287-05b6-4d74-a439-14cc1c22ef10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2d70e7e7-4452-4603-981d-6119427eadbb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2d84495b-91fe-4af7-be66-c70925ccffb3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2dc31fb1-cb1c-4a76-8802-fb9db45f5110"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2dcbc560-9e5d-43a0-a7f1-2a656c5f6edf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2df1ea53-5518-4240-965a-da997b57db4b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2df55467-06a7-47e4-ae92-342fe4c869bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2dff57c5-3847-440b-b9dd-d6989b8bb55a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2e0504ab-7600-4419-b0fb-a3c3af00e50c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2e4377bd-3926-410a-a41a-80d4e9a1908d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2e457111-4751-4108-bf05-4cb31b526d03"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2e8a0608-a585-48bf-b65c-e3858023b830"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2eb53fe3-b887-4b54-bfdd-2fd267017ac1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ec1d6b5-2559-48a9-81f6-560243f0768b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ed86ed1-9eb5-42bf-a0e8-b32fcc8f4ef0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2eed6404-de97-4a06-a925-0e51d76ac330"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2ef347c8-5132-4b34-8ca5-24319086be1f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2f1cf0f4-544b-4c89-a50a-014ebe875d50"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2f505606-0cac-450b-a58f-eeed53e698c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2f6f168c-d7f2-4150-a7ce-d6995112fe0c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("2f78c97c-af6d-45f5-99f4-87bb5c14041f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("300dd8c5-452d-4e4e-b31f-a933c91a2d59"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("301f5c8c-fdb1-45e0-ae57-1247e67adf04"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("302d13e1-adf3-4be6-83c9-893de626a679"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("303820e6-0e4c-4580-b250-97cc752d2cce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("303b06c2-5b7e-4db0-9466-2a6364b146ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("305d64fc-656a-456f-b390-d96fb6b685df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3070781b-ff1a-4b36-8691-f6ab4f0fefc3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("30919909-0440-49eb-a87b-1ae559ff1a22"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("30bb95e2-1f1f-45b0-aa31-f2005de6e6a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("30bd268d-17d8-4218-8e37-3f2643937251"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("30cdb3d1-4de0-4f4a-9bed-32357a54efcf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("30ef6d01-7061-4937-adad-fedd187728af"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3106bda0-b5a7-4364-b069-c99486bd12d3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3119ba5d-ec02-4bca-a3a5-fb7d672965de"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("311c2ae7-d001-4bae-9717-b70fbfb6ede2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("316f4490-96df-4d4f-a25e-0c5dd06da9a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("31c03c75-6e24-441c-b7f2-7811e4c3cb42"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("31f2b0b1-c975-4dda-a7b4-5ae18d368c02"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("321224fc-03bc-46e2-91b7-85e0d9ec9927"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3218f193-c698-474d-ac39-a89a43636930"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3235a74e-d54d-4bf6-956c-ff6a94ca9fdb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3245b676-2321-4ffc-aa96-f271ea973e29"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("325d8b9e-65fc-45f9-aade-acac3cb7307f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("32643896-d09c-4394-a8d0-85752971c095"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3273052e-6f69-492c-8855-b7b0367cd5df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("32848ca9-f61b-420e-8898-e5780379a501"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3312a8af-6e0a-4648-b6ac-2966bb36fe57"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3315e0f2-d51b-4f00-801f-cde13ac76382"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("332fa9dc-59b5-4618-a7cd-536784385e12"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("338d1d2f-3e9c-4298-beeb-2cbca99e24d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33a2275f-e2c7-4e8d-a2e1-254573e51bbe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33a9e048-7ae4-415d-9c52-954eb7a8252c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33aa8150-51a4-4e0f-8d3f-7d5e9c8a5db2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33b5ec6a-f6d3-406f-bce9-52486eb2f0fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33b6faed-e046-4db4-9d0b-92bc5e8093e0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33c448da-ce73-4735-89fd-0602ece01dfc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33df96de-80cb-4176-bb51-2221b0ee5865"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33e80db8-1fa2-4d81-b5ec-6c9ad7b8e67a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33eda944-5f10-4ac6-9479-dbf91e709d86"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("33f4ecc5-45b7-4782-8e10-348d4644360a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34028ee4-4a63-4910-a81d-75d489b7bb7a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("343edb2b-03bb-4cf6-892e-21715f4dce73"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3459b40e-0b2f-4155-9278-177d607bed57"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("345b0d67-b6d8-4d8e-814f-f037927ad1c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34757354-6f5a-4bd5-a4d6-542433316f1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3481cc85-0b39-4c56-9458-9e23478ea0b8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("348452a6-9ed6-45bf-9388-d6c45f2fcecd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("348df6d5-2a96-4ed9-8af7-b83754689c4e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34cc5eae-feac-4ec2-9ef8-0d09a74e53b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34e18843-ac87-43d7-bcf1-a8c9e8f88241"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34e9335e-9787-441b-9f84-e126c0fe6116"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34fa72b4-1aad-402f-b6a7-717c4b80bc7d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("34ff295c-d5f5-4b3c-87df-8b251a1946e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35090ba0-cf8e-4ca9-b071-27111444acb6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3520957d-a1a2-4b25-959d-4e94eb171880"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35230d70-f616-4505-9370-d74bb0b28e07"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3526be1f-e8f4-4d16-be5b-d7153f1ac37c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("353612cb-7759-449c-af97-311f7d0b0f59"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35397ba2-e0eb-4b53-bd3f-cc30075d9e89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35475998-d28f-4f3d-bd1c-930d6bd6aa48"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35563c92-2894-4f44-a490-7fe514f141ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35593bc9-c493-476b-9017-2c45c66d877e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("355d5674-d438-46ad-9f9e-536e583acfd4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3566360d-7b13-4a31-9845-dfedfc8133a5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("356c0087-ecd1-4d15-b17e-4f02da960a10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("357876c9-dcc4-4a43-9afb-0e9a67253780"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("358004ee-f039-4a48-bb60-75012a1b1567"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3587644d-8345-4e05-a79b-54364dba1a87"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("359b0bd5-4b68-4f31-a9ad-9c1738a13125"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35a8f050-f222-4a73-8894-487da29d8c9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35bc52f1-07c8-4254-98b4-9e86c5a7e70a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35ddaa15-75c0-4a10-9705-60b925927427"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("35ed1ec6-5570-4f17-8aee-ad55c96eb479"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("360808ca-1327-4d37-a88b-bbb3216b2fb9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("362463c3-a837-4652-95cb-9123b8b1bbca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3634e64c-6461-4d66-9c50-e34ddd4781e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("363b9c3a-7a3b-482d-9dac-01e816590f11"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3663a7bf-6af2-4b96-aaee-ba383ad7c01b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("36681169-a306-47a1-81ad-8f274ece72d2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("36827779-1a3c-47b8-b01a-471fabc193f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("36b13b75-58b5-42d1-983b-3e9bcecb522f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("36c02911-463d-4602-bcd7-994939ecac19"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("36d967fc-d8ae-430b-befc-8424cfcfa184"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("36fac5ae-46ac-45a5-9b6e-f5cf2d6e4e51"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3710a4cf-f4e6-4077-8534-8b92d5b0a86d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3737f7d6-76a7-49e5-a1b8-3e7031ba89e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("376ab6fd-842c-44c6-a262-f809a584b0a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3770e7a4-afdc-4b52-a838-61e5fc10f114"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3776bf9d-f828-4939-b4b7-9ad33f39592f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("37c0aeb0-e110-4696-baf6-5d6a36a2b838"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("38098f57-ea4f-4715-bb80-d1d811912b4d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3814a24d-7f04-459e-a243-627f2fa7afd3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("387a6d6f-9dda-45ee-818f-9b19aaf4c79f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("38824a93-e431-495e-8a0d-6e961c75f578"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("38b0ce1e-e886-4cf5-b7f1-67b86bc9dc9f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("38c11a02-5dca-45e8-b4d5-d0ed7ea18e8a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3959f1c1-201a-4ab0-8ecf-fecc10c9991e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3964ba30-c2cd-4e50-830c-203fdc7def99"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3976cdf7-0e39-480c-9dad-65fbe9b5cfb2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3982a006-86fc-4a9a-9abd-6a5bef1604f2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("398ab8a1-dde5-4869-a22a-1d8b4d74ce6e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("398e7a52-c4ec-421f-9545-bcc9cddad5ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("39ab4df2-36dd-41f3-9e32-0c795fe3e5ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("39bd62b7-afd1-41bf-a633-c72abb85c7c8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("39ce811b-5c66-4775-b36e-1df9124c213c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("39ef8f5c-02b9-4708-a5f0-a319cba08d1e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a26e08d-53a7-49e7-8c25-9b3e935bf96f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a29850d-0107-4b24-8e49-1cf923cb18b1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a44ed50-9694-4083-a035-32424baab993"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a55d681-dfbc-4b66-83af-237386865932"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a6ce34a-ab1d-4985-a3d7-ef614b8c7012"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a6ff30f-826c-49a1-8331-6d7a0c8c29aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3a92a6a8-a5ef-45e6-9255-e72da8835866"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3aa9fbcc-06e2-42b8-912b-ff28e0f5ca5f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3abbfc74-fd6e-47f8-af40-d22e5914d378"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ae2e067-35c2-4499-afc3-422830972b41"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ae90e29-532e-46ee-946f-4f343e37e717"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3af691ed-5572-4b9b-8e92-a5186ec8a68f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3afc0b1b-6444-4d93-9314-529dff7bb1a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3b0d0391-72e3-408d-b027-2f1477329e99"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3b1c02d5-8489-4cbf-ac20-a6601eae34c8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3b1c049d-d065-47d0-9ae9-834a1794a5fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3b3b75f7-fda3-4d3d-b56a-d45d0f1ad0e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3b5812b3-6bef-4460-8ad3-5027453fb36f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ba16e83-d3a3-4738-ab91-0c3b9611ac85"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3baa047b-fd26-47d6-9a01-b71e89b288a1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3bd91ac4-d5d1-4839-b81f-45b96bfddf17"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3bdab7dc-0dad-40d3-9355-6d1a9948393d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3c4594b1-9e98-4d2e-b1b7-f797e5846fd2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3c8f8ac0-87ab-422a-9d15-88424823b61c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3c92efd6-fb16-436c-97a2-b5714aa31ffe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3cb8f5c5-c208-4ccd-baf1-ce5e37df20bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ccf203d-88c2-43d6-812c-3cd49bcaf239"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ce6ac97-4c23-4724-8a9c-3cb77eb5be53"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3cec0baf-1176-4568-821b-4fc9860efe7f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3cf392f8-2031-4b5a-8efc-62d62d53241b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3d1ab66d-3d83-4ea7-9ff6-23066d8dac06"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3d1bdc9f-17e8-40d3-90de-6c226cdd9e50"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3d1ca5e5-9339-4f6e-b36a-a4324226bd5e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3d2ebee0-8e23-4af4-a2ad-ffdc3eaa5daa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3d4e0af9-211e-4ade-95fe-cc5504d3ae1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3d82851d-edd7-45e0-8e73-de2b4fcc8d2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3dbbc695-c581-4f21-8fa9-04c044d25eef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3dbeb699-2154-4dbf-bbe7-7a9e6a1132cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3de32a8a-f2a7-4d65-98d8-469cf18ad19d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3e00ea17-e219-4415-bd7b-96eece32132e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3e36445f-8716-4b4e-8b23-984b897ca55b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3e6d51e4-7224-4b26-a4e8-adcac5417ebe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3e832ca0-b4e7-4872-b522-f2ba19a0e3f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ebf1c9c-acc4-4f5c-8562-db7f8f703191"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ebfd36e-5901-440a-9098-ba3bb4df1cfa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ec68aad-bb34-4a7e-938a-c55079c5852b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3eeb285a-f30f-4da7-9d4f-fcfcf1f63f4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3f02f4d4-5695-4848-95e8-e56513e9b8b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3f05c7cc-e5af-451d-b25f-912bf3ba060d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3f3c866d-3c76-4f63-9758-fa4d9c6206ae"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3f4ca354-220b-4da6-9eee-894ff4657599"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3f6a861e-e695-4f22-94d5-b0f98241354c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3f73e559-980d-4330-85fd-fe389c8b529c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3feb464a-7cb5-4e5b-8639-a4624d9ee541"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("3ff10718-dc5c-4a82-b8d1-ef66acbca291"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4009028f-7b0b-4045-8bd5-5c471ed77179"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("40246848-b063-4823-b01e-e51bee28786f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("403cb780-34e0-49a5-862d-bf21bb223d78"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("404af286-1b44-4b33-a9df-aad92ea748bf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("406033d9-e495-4f47-bc72-45d3cfba887f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("40617073-fac5-48de-a981-2494ed805fd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("406a2310-b170-4852-a0fd-5b674ea8e513"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("406ce06b-df00-49d6-a00e-dc13b577bfea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("407fb29d-e480-4a99-b214-2e457f2e0356"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("40becd5d-4e53-4d9e-b015-8a74729714c2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("40ccaeae-d086-4368-94e6-6791d5e64f72"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4118604c-5b85-4010-8f25-dddf93f7dfd0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41337758-89df-4dba-acdd-4899ccae8248"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41496f48-d3ab-4cc2-9d10-cedeba341764"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4161f370-0689-4dab-86dc-e8d7f9689f27"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4184eeed-6338-45c2-a1f6-264c100f3559"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("418ca577-e89e-4073-872c-00c6999b3ba7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41ab665a-1039-41b8-9ee3-e34f65973a7f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41abf746-8279-49e5-9e22-a3041b0a7d2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41d60631-66c4-425c-b637-ed452821e029"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41d80b5e-e7d4-4f33-9db4-943e95a2924a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41e8475e-8b98-41cc-a970-b57cc8a26955"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("41fb40f4-69f6-4857-af38-a008115aacf0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("42299701-689c-44e0-b205-bcf1dee7a402"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("423df230-f21e-4a5b-aad8-d70b57d8388a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("429c2df7-e2fa-44eb-b4b1-3379af3ca78a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("42a42d12-63df-4a1c-8f09-34f3d2931958"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("42ad4464-c5bf-4d5e-b2f0-26e2cc0bca70"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("42b13967-a8e8-4082-8030-38ab0d79c8cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("42e7127a-5993-418b-91a8-cafab6e8ff5f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("42eb188d-5381-413e-98cf-0b19d07c8a7e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("430a6095-0370-4967-9ba4-0b23e294e47c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("430b3991-4067-4e9d-a981-0d4c674b7d2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4314db52-7a99-4619-ab6e-1f369d4a8904"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4335e85e-a40e-4459-b941-8baf3ad3099a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("433b9d3e-3ddb-4ce2-b4e4-8dfa47dcf5ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("435b57fb-b62e-4f4c-af46-f8410e6133af"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("435b7158-524b-4078-af84-56300fd8bca1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4386a3b6-a2b6-4aa3-9ab2-aba3951c3a01"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4386ec1a-8a78-4642-a489-1d479da1b672"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("438ceff2-a576-42fe-a7bb-82da9739367f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4391607d-701a-4335-b83d-5872ef39837b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("43993116-fbe1-4209-b52d-e5cb2e5b74dc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("43e1f9d0-f36e-42e6-b3f5-fa92df40b380"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("43ef1129-ade9-42e4-b14f-f716273f7755"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("43f44989-03e9-491e-a7e6-c922d7450356"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("43fddd10-1106-4f52-91a6-a01fd1e81e1a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("444b894b-881c-4909-96c0-cc60044a504d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("447ef4a8-5279-4460-9995-67730a2cf931"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4484931e-d8c5-4092-96ae-53a012490c61"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("44b745dd-a255-4969-bb45-b700531c726e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("44ce55e1-78bb-433a-bc5f-0af2fb2f6c9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("44d81048-e052-407d-ac13-4065db71fc14"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("44d9a0ff-bf29-4880-9b5e-b2bd3c487e8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("44f04795-0a56-45b5-b1a2-4d906a238dbd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("44fc9936-3299-4424-94ee-aa50f8f0a325"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4517a8db-3917-4d7c-921b-2a9063512c4e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("45463435-4040-4914-a0d2-0bd0acdfe42e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("457dad94-01d9-4dc3-985f-422d0a55eb51"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4582da4a-a8ef-4927-8ed5-3e8f2d295803"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("45965b74-dd19-4dd2-bd05-a51d55418d7d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("45b6efb8-a423-4e41-b6e8-262aeffd8f20"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("45dfc0b7-9b88-4e1f-826b-83438a36a0bf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("45fe0574-ba61-45d1-92cd-932751175d8f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4613509d-abcd-4b39-b832-2add77de9e1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4613b5fe-fe26-4d35-8ecb-d4f01c4a8dcc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("462212f1-d31a-4fae-88ac-896f15c1e89f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4630d95f-3e15-4e53-b1b6-89a3597fb964"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4642aa84-905a-4b6d-b6ba-91f5bc38e7c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4665f205-f955-4b06-b67a-26364d1ae7c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("46da5c31-2625-444f-bac7-10b7a632d07c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("46e460be-b239-4024-a5bd-e7ec9c4862c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("46ec0780-65a4-43d0-830e-c3955ea499e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("474ded5a-79e9-4977-85e4-6e314baaef1f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4754a800-1503-42bf-ad00-d332f83027be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("47684194-fc4d-4859-bdbf-24986b6e59db"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4771b853-63f5-4d03-84a7-764887716c26"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("47973501-48e7-47a9-a805-cda0896528b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("479dfce4-05c2-48e7-a0da-68c26b072ab5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("47b7dd65-bbc6-408e-b4ec-226745ec5cb0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("47d5e737-da38-44fa-ba74-b392b173d85d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("47f62dff-5f2b-4196-a49a-c15ec5cb32b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("483a347f-0658-470f-9155-651a7d663219"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("48570b03-c597-4672-95b8-5727ace8fc25"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("48bc7576-716f-445d-b080-85b206addfa3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("48d7b877-62a5-4cc4-b2d6-a702a149588b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("48db5e84-0d0c-415c-b65d-9d5993cdf8ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("48efe6d1-cbcd-46d1-8491-12df649d6bc5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("49004aaf-f85c-4e56-b394-3d14b8e18e11"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4915a543-dfcf-4e9a-8162-7e40d5df134e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4915e8a3-359b-4e6f-b442-f6a239e56eb1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4948d85c-de96-453b-b9a5-48d9c7dbd924"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("49503316-7340-4ccf-9e8a-6897963ef42f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("49562187-ebf9-4c32-ad51-6c7d6a2d3e77"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4961add2-0958-4e9c-a86a-1eeaf70d0c1b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("49886294-4420-4270-9160-641c8cbc6091"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("499d4c21-154c-47dc-881e-d7368eb2ef61"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("49c781ff-46fa-464f-841b-a6177807ddbb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("49fc91ef-397c-40bc-8d2f-c21bd5cc4074"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a0f7eea-6081-4d45-8c7f-e584b8ec3941"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a268ca5-d146-4b4b-a784-5b72ae8fdde2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a2b32d0-3250-45f7-a994-d099b3de755a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a2d4002-180e-4e7c-9b87-cdb2d577444e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a34b54c-2f55-4408-bdd4-8381ad176a23"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a3a059f-6109-40dc-88c2-97c485266c8f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a3b4548-101a-4b45-afe0-91dca6a2829e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a6e05fc-1b0b-4b2b-acf3-0fb609bb1bae"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4a74d186-1c36-48fd-8811-85c99ad33c95"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4ac51abd-8066-4e6d-9e18-3d64e08cdb82"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4aebc8ac-1539-47f5-857a-dfa270a432f0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b02581f-8708-4c0e-9ffd-d4347457725d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b1a215c-d7fb-4900-a21d-accf31b08ea8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b367f56-1e89-4ab2-92c9-e6a08ddaa4e1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b4f356f-30cd-4598-a836-68770ada5dc0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b6000c8-d56b-469b-9f5a-066b6540faef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b615f36-4a32-4528-a81e-a147cf7e9f52"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b664d63-92c0-41fa-9895-2f568cb84cb4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4b806e50-487c-43f3-a1de-41ec85706d13"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4bc7db3d-1004-4780-80b0-dbc57a3aa996"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4bc92514-9229-4dae-9a2f-4d3dbc142ef9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4bdad751-f217-4e15-a8b9-b6d874278e9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4bdea723-c313-44b8-925f-9c6f9e98f65e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4bf7f365-a589-4fe8-b086-a39586e30674"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c0d17a9-6fd7-453b-9578-31291de955e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c14aaa6-140b-4dab-adde-54b2597b5c43"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c17d13f-2494-4096-a0f2-edc79dfb3001"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c1eee5a-f7b9-42a9-a3fb-86bc23a1968e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c2fa627-8b83-461c-b235-2b9378159485"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c305855-3125-4e00-9251-4f09a26cde22"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c6a22a5-39a6-41ed-b9df-1a713ca843c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c7feb40-c4ec-4da8-9f05-3d9b58eede5a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c937327-50c5-4b48-92f9-d48fcc7e9b92"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4c9c4c95-5516-470f-8877-e72f417f43a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4ccf487d-5954-4dbe-99cd-a329703b4a15"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4cd6191b-ed74-4af6-8834-a3eeca6cd4d2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4cd98b38-bc6c-4583-bc7a-3a896a6d05a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4d18e4ba-61e1-4e56-b689-2b0fb32d9cbf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4d300d91-868a-4de8-973c-26ef8fc27637"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4d62c9ab-808a-4dd1-ab4c-3ed0022048a3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4dde7722-3195-469d-abdb-d71be611a707"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e01019c-b86e-4b0c-ae3b-aa9500194916"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e0b272e-cafc-4fa2-9254-ef5f3c6b6b74"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e18f8a4-e4f4-4aeb-9c2b-d731ad656e16"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e2306e6-75e3-4725-af06-b49b6b6c2129"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e6086d9-53b4-4d75-9db6-c68afd0e2e0d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e632b47-2901-4942-bea1-5c326a850442"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4e8924fd-5267-4265-8417-f66de2b705e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4ea5b173-9510-4060-8d21-e9c41e5de127"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4eb0cf0e-955c-409c-8268-07ff4966f70e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4ecd9325-9864-4b1d-ad20-c040cd5c88be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4f17728b-3ef0-4b77-b1e1-a927bf04de6f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4f216ffe-05be-41cd-83c0-de065eac4763"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4f75ac22-d281-4679-9041-e83785e29044"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4f9370bb-d953-4971-8e7c-78cca470332e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4faa153a-ce3f-42cb-a5ae-696088966a18"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4fb195f7-457e-4ca2-965b-1924bf44e2b2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4fba176a-93db-463d-bc5a-86bc93287aea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4fcd4f3a-28cb-4ad8-9117-8e8c26c04573"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4fd35175-03da-4e42-9d11-a125471d549c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4fd5bb86-e504-4c7e-91cd-2a7f0f8e45e4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("4fdb31f7-170b-4fcc-890e-96136a772125"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50205bb0-ba9e-4916-a994-25de7f4911ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5025e014-8e57-4e5b-a077-cf30ad03b012"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50625626-fad0-4cf9-9b68-54aaa747c13d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5070a4cc-9097-41b3-a8a1-8e4403074ada"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50907af5-db12-4ad0-a2bf-7eeae7490f1d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5099ecab-a7a9-4e8e-8513-83733f1684b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50b734cf-7fb8-4cfb-a81f-e7547da1469b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50bb4d15-ecaa-4fd9-b0de-be26d909ccc8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50e3bcdc-73bc-4a5c-8105-785c4d530467"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50f4f3b2-5411-4578-ba6c-56be43eb6686"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("50f56c1b-9f13-49bf-9dfc-fa38335e337a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("511615bd-1a8e-481f-99ff-a537b9edfea9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("51585654-84c6-4640-abc6-cad98f4433e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("515e85e5-3607-446f-b09d-6d244daba3dd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("51b50b7f-2156-4818-ac18-3e6a1bd63d1f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("51e967fd-fc78-4c26-b752-0f86467ecd5e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("520d836a-ef23-419c-8b1d-5f68359e4760"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("525a2001-b215-4ad0-beb3-88d3eaefa58d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5270f01a-6027-4a96-95e9-985499fa69fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("529d393f-63e2-45fc-b6be-2dfe46cd3db4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("52dc23c3-f354-4764-b605-0d842e4e70ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5316b843-51c9-4674-bb4a-82105b21ccff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("53310eb0-1a02-48ce-bd9e-a6d2f411c405"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("535a4fb8-7631-4e03-aff1-f2cc53236c3c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("539f527b-09f3-4ff9-8f4f-0edfea42b4c2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("53aa364c-a130-4494-838c-b5f249ffcf0e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("53b83884-47c7-409d-92b1-950aca380a6c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("53c68bbb-c133-47fa-bf2c-bf6cbc9f8546"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("53c9f3e7-f2e9-4116-a6e5-b9bf24686162"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("53e8603f-5be9-487d-81a9-b60150105624"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5407e1a8-11cb-48db-b415-9dee2b61e487"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5410a0b7-9c73-4fb9-99d0-f2ec62c965d5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("54384381-fb0d-41b9-85a4-6a175ba24659"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5449fa05-0186-44ae-991c-e29440848405"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5456a02b-4a82-459c-acc4-47e42d5fc398"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("547b9c7c-f1e1-4770-81e8-d671d2f42010"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("54b7af70-e470-4798-9a82-9447cd4e275c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("54ebce93-1c57-40e8-a4bc-158d3e7c6a55"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("54ef99d4-84c4-4615-90a3-2c7ab90b6fb6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("54fc01bd-408d-43c2-8ede-6cd4e05de146"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5501225d-0560-40e3-b900-a8b9a73c7f6f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("552d967f-022c-48a9-bad3-21f803266182"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("55377d2f-bb91-4e27-bb83-04063aee89ec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5557be34-5520-43b3-90f7-bfc6b2a937d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("555a2fda-1a98-42be-b9d3-388af1113e19"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("557ca2fe-7049-4911-80ab-bd16fdfc52a8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("55a1327c-92bc-4499-8cfe-96aaa36547aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("55a56377-da90-415c-8c58-f9d999f57e47"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("55b7e6c7-ba4d-4a88-9ca1-b6ab059c4cef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("55de2d1f-60b4-40c4-af63-a4d3a33be102"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("56654f6b-28da-4669-a8fb-0e1bccce270d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5679a5ac-2642-4e22-8701-8b1633242d98"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("56826478-8707-41df-869c-c714bdf9514d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5695835f-db04-4e9d-a80e-051e7248a527"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("569a94f7-608d-4aad-80cb-d7fe22cbbf41"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("56a97307-9b7d-46d3-bdd0-da0ed9e93b15"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5734d4e7-7107-4ffc-a0f5-473ca0049696"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("577092c9-aa29-4c30-b921-c0d158acc3a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("58013aff-e33f-466b-a2ab-e8beb1badaf9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("580cfc41-bc35-498a-b338-712209a3a96d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5817140c-1d18-462d-82b0-a6e1296ad1ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("582cbc3d-7f8e-4dec-abeb-07f301d03e3f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("583921c2-22cd-46d6-9074-bb9cf29ef3d8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("583dfc0b-cae6-4948-ba57-2c8cbfa2d3f5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("58464870-4a8c-4d8a-8cbc-7a91737714e9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5858a839-049b-4a35-b960-128053df7777"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("588055ad-0de7-4fed-b5c6-33132301b753"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("588bc6fa-80e6-4ebc-81f8-4b9e657bf1f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("58aad8c6-7ce2-4391-bd40-8902e810723b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("58e4cc10-1f44-4025-ae6a-ed28b66963d2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("58eb5839-4cc4-4b82-879a-9bdf1d5ba50e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("590d9861-2d5f-43a7-8207-dee23c9a5f4a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("591c8eeb-681b-45fe-a701-f233b8601daa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("591d5878-d9e9-468e-9066-9b633cea6946"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("592dcd76-c6bf-48e4-84aa-41602d91d729"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("59384444-d89a-43fd-8d90-9b358d59b191"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("593c22fb-2b0d-4a07-bebd-ebbb33cd7e79"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5946ad22-1ba5-4bc8-ac61-4a04429f4b15"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("59657796-dab8-4c4e-8dba-4386a5238d3e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("59705217-6c45-4c45-88c6-c384817f9c50"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5976608c-cfb1-413c-b33a-2578d5191f57"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("599ee65f-9a81-4bda-a7a4-dd81fd9b6ac8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a104114-8c41-4a23-a2f9-72a38033ec20"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a16e59f-3960-49ff-84e0-bbfd4edfd71a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a314010-c6e4-4fa6-baad-8d2cd802d65e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a3cc180-0693-45fd-9ea2-a0551677359e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a50b0f3-1c7d-4eb2-8bfe-51c5bdc2fbf3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a72fd81-1c99-43fa-9a4b-9bbcd77179ec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5a7e9f63-a243-4f4a-9888-9fd5dafdd7ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5ab1391d-5ee7-4484-9d2d-29ec914108ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5acea618-7d29-420a-b1c9-6f07229b64e4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5ad4261e-dc93-40b8-aa94-32e433961f6f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5ad71012-3b70-4fde-987f-dbc534c649ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5afd9938-457d-4a88-9102-f8b843226cd2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b0c4fe1-849d-4880-8b33-c353cc679c8e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b100e96-d83a-4385-80be-4a0b835187fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b13bab9-d6a2-4b26-97e2-c0968cdaffcd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b312f4a-e2f7-48cf-9bd5-07208bfdebfc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b6e8cb3-71c4-438a-a24c-dc57359dabc1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b73dbb4-c08e-47c9-9fb2-7fa96df114c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b875032-c278-435f-b3c1-1c2bbd927f12"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5b8c2a46-e5e6-4a72-a52c-6b48811557cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5ba96b27-674d-4cd3-a7f0-3e3eff05e5df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5badf873-1dd1-4b50-b6ba-b27210a4072d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5bbc2faa-2bf5-4144-ae22-54a26baece70"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5be32d93-293e-42b3-aa14-8fa96defa68a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5bfbbe05-2422-4a86-98f7-68cbceb2fa1f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5c2a4659-24b4-481a-886d-8afbeea524de"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5c41d63d-33f5-4c24-94c0-e2b4d95b4741"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5c41e1d5-fc4c-4ec1-9e21-7d3603fdc9e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5c4290cf-25f3-4b2a-a87c-9fc3e363caec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5c6c6809-0b8c-42ba-90d5-c07bcba044a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5cb3008b-76f8-425b-8577-c96c042013c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5cbd2af4-7559-44ba-b83b-94dd30b842a5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5ceb0f01-f88b-4b72-9528-f9135511cbdf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5cf37d49-dd74-4506-910a-dc3c5e84d953"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5d243432-91c3-4301-b0ab-a4784dc25d04"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5d41c3ad-19ec-4d51-b482-0002dae479c5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5d4fb5e3-a825-426d-a9c4-0183e3c0c22a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5d79c2bf-e3f0-42ab-9750-993618ae0892"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5d7c4d36-5295-4225-aead-ac55d35e2b1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5da476c9-e505-4b3f-8318-3c9d1eb322cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5dd13d52-d992-4891-ad55-d4717688db94"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5dd21411-808e-412b-a1ee-3be30755d82d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5ddb6969-2169-46c9-9122-b2ecb84f456a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5de14d55-7cf0-4ac1-8e6a-5085b2bb8d88"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5de5695e-b19e-467a-9b29-18aa312b79b7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5de8319e-502d-4ad0-8890-68d1b14a43ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5e060efa-f9e1-4a9e-bb28-c6e069cd52b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5e0dcca4-d374-4740-b8df-222726843927"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5e22d55e-3b3a-430e-b919-641a2f2e1067"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5e565db7-bae1-4649-af9f-0f473d4bac8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5e59d6fd-579a-4f1b-9a69-339768b90d4e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5e6199d4-304a-4f27-bc3e-a14f9338c21e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5eeca36e-c508-4147-b33c-a8b48162e9e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f125ee7-b240-411c-93e1-f65d5b0ea212"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f1d0686-54da-429b-8266-c25622e21ed3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f24cf7e-19e8-412c-8338-f8756a067c83"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f3bfa21-a692-4178-8673-2c0cf842f1f8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f480664-de22-4815-8bc0-2d456ba94632"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f4915e0-bfb2-4c14-9bcf-77362e28979c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f514c1a-6ea7-443e-8931-455595883de3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f545a27-af24-4533-a9e4-cbe22d637d2f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f6ff80d-0779-49e8-8855-2b470442f575"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5f7e9dfc-f7e4-42a1-a414-4f93968d41f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5fa69579-31a8-44f8-9576-4bf7f12b6269"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5fe060c1-f049-461d-a668-ab088cc71c70"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("5fe25373-2520-426c-9ac8-be9854f2f468"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6027a363-d08c-4920-85e3-0e8d5055f467"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("603c5ba0-d1de-47dd-ac72-08acd2e312e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("605ebbb5-510d-4a5e-b2de-b81bcd6fda05"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("606cd734-bd71-4ac9-8341-9619273319b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6082e956-4128-4a7a-8613-146246254e7c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("60895f9a-86e0-4b17-9b8f-bf643a1ac52a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("60c45553-5a86-475b-897d-c6ec75b2ae28"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("60ea13e9-9ec3-426e-828d-3d2bb988e3b2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("60f29b6e-dd79-407a-937f-690df814b713"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("60f5b95b-a33d-4ac6-8f55-77b093f16062"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("61031e0b-749d-44fb-8b4e-f554f43d7869"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("610da39f-77c5-466b-bd8c-d34f7f66a856"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("61194a90-369f-4922-bfdc-878c94ef3dcd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("611e1019-68ee-4555-a386-caf160bb7211"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("617e345b-2a90-43a3-be69-8724f264c105"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("61a8db48-89a9-4448-a47b-356b66691047"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("61f9ea4b-41dc-4565-a3f0-172510df65be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6215f858-7d01-4088-88ea-3b1fab8a24f8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("621d2ff8-1faf-434e-a1bf-68e554430f3f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("622f8ffe-ba8a-4244-a581-7bcfd52a3ffb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6235eeee-4f1a-462d-9871-1963a6fec2b2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("62589a8b-82e7-4fbf-bde0-80dba7338a11"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6262967e-947c-4ca1-b4a9-998a3c4db75b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("62826c74-6357-454e-beb9-d64d2cb34055"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("62a17ae2-d872-4b54-9370-2308db60fe2d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("62d7ee4a-84ad-49a5-8da7-4d9224ed0522"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("634b31f9-f212-40b7-964a-0b6bb03b3474"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6365a4a0-ab61-4bce-8af9-d4f47de51b1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("636bf59d-4fd7-411d-a8f0-1ee57a1805b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("638bb504-6704-4c02-bbdc-caa561ad711e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("63cb0261-ae7c-4c0b-ba1a-1d4614ce12de"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("63e66a17-eff4-4af4-83b0-9ca77ab3c789"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("642cdc3c-0d08-4e46-be6b-0b57e80b3cc1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("643f94e4-4e98-4498-9c0f-6b0f7a2da661"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("644fed00-9ec3-45aa-9d4b-8e5357033aff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6463feb1-78ed-4333-bb1d-597d6f3e0135"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("64775065-26d2-4ba2-b32c-5f5e96c0dc0c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("64a88a1c-e5ff-4496-9784-fe743a80ddd0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("64defce8-bbad-439d-b3b9-e66acc953fa8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("64e2f696-e383-4f00-a176-1ff6b439612e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("64e99743-7a07-4e8c-9d47-666900f95b29"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("64ee5f1b-e4f7-47c7-87b3-480e7ae72335"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6507e2ec-6217-4d83-ade8-950bf73526d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6510648a-bd5a-44ec-999c-7c67bbf54094"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("651ccb07-0b6e-49af-8c4d-b8fed5292f4c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6551c945-67f3-47ff-9e0f-12d8250db68c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("655d5cf5-7c3a-41f1-a872-8bb728c2e82f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("656319bd-d94e-467b-9dab-eb83657cfd27"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("658796ee-5240-4414-9df1-4a05865dd6ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("65907a18-17a5-42b4-95fe-01048ec04e8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("65c7a8e7-8566-4a85-9904-3ae8adbc9451"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("65d30800-f955-435b-b59f-eb358e76448a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("660e4dad-52fd-402b-9fe7-e47929c8b098"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("661cb894-8e67-4e46-8576-2f34c24e2119"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("664f8622-73f5-4dd5-8d36-1d84877b5b61"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("66a38b71-6cc9-481c-a475-4ac6788c0d66"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("66d162c3-08e2-4e15-bb22-d3566afe3361"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("66ea177d-bb92-4b1b-9004-0829659db502"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("671a791d-de0d-429a-8f87-f2f2ba0f113d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("671c3e58-33f1-4ab2-822d-a4fde20de4da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("672878c1-54c1-4e81-97fe-bfbd4a127e2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("672ce338-12cf-4b03-9ee6-231a91eacbc7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("672f8fc3-0dd3-436d-b3fd-01d331257452"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("67361b5d-291f-4b48-8e71-0c6c8e9b45ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6753e645-517b-4d27-be9b-fd483df25080"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("675fc3d2-6877-4fa6-8625-cc220b2db5d7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("67747efc-f485-4c6c-88c1-bc407b04bcc7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("67912e84-aba8-4c4d-bac6-3a574a03ec8a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("67ceabdd-180e-463a-b41a-46e19b19b6b4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("67da7d9f-67b6-4620-b74b-a2e9a188e9bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("67e07bdb-c8cc-4570-881b-d0c65e9c9993"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("681bb612-be31-46cb-818b-e0a87acefcf7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("68231118-a221-46d2-be11-27249387b7cc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6828ba9e-1925-449f-b7de-d0a4be7861e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("682e77f1-4f7c-4826-947d-7737dd1dd81a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("68671eb9-462f-41e6-949e-8d8e4897ac09"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("687b5c3b-7448-4291-ac72-c91210220818"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("688515aa-95f1-4b5c-9f70-3e622305ce5a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("68971e82-f968-4a78-9b1f-6c1a54a112c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("68d7c96c-51e9-4d1d-a79b-4e4ab11c17e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("690cb0d1-3c53-4283-8cda-af9f335f3127"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("691baf1d-d666-489a-a097-0bde9e04111e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6929c744-4a64-468f-8fc3-ba55c76bfb10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("692f39c1-2623-45e2-8583-29276b973636"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6957f234-1998-4891-8ef1-2461418c4372"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69616039-3b22-4fd8-96e8-ed5f48b28ee8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("697d5115-b49c-4f31-bf4d-2f82d96e36c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69869d73-187e-439a-a266-59f0945797d0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69948220-4000-40f9-b744-92c2085632c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6999d344-6bb5-477a-a71a-6d3d77e0c5a8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69a69b4d-2c45-4eea-bc0c-bd40d8d8f586"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69e89e2e-cd89-4c14-8abb-eb021b43567d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69eca20f-0673-4435-bc69-8510eda8df9a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69f3f498-c58e-42bb-9f25-69630136a44b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("69f9f41a-d0cd-4969-b9b1-d3f95c772fff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a13dff2-32fa-4fe1-b59e-78e6c5e0c410"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a21ade6-800f-45ca-bfba-4cb74fc0099b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a4c2a52-bd32-4c39-8a0d-dcb6a297921e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a7168b5-cd68-4391-9171-e725000a6db8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a747517-a62d-418b-9c32-41b612114e59"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a791826-e877-4cba-90c8-150a323ecc22"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a917d10-0dff-4cb3-b1c2-8b27fdb2f410"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6a92760a-e171-4d49-a34b-c3c41b391bce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6ac39b7d-3c83-4583-b3e1-ed0cd016f6f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6adfa25d-30df-4b8e-aa77-5d2588387bba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6af97d2b-24e9-47bc-be43-0677818fc236"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6afafe9d-9e34-4b0a-98d7-5cc814fd2b3d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b09e232-51bb-4a62-b674-3fc31b99c687"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b2518ac-f5a6-4670-877f-24a6b99d23fa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b415ef6-d3ce-4c48-860c-3bb08c951fd1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b585540-ba63-4e8a-8d22-c2d77fabc329"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b6fb30a-dc76-4099-9f45-8b0d6c18d5d8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b81b2d7-ea2d-4a7e-b359-8b58994a49bf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b9dd652-6d4f-42d4-9b73-217e4cdbc6b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6b9ff7f4-d1ca-481e-9bac-340ad74e8b8e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6ba52752-2ba5-4866-aa8f-cc0c68f83a7d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c13fa7e-d79b-4e09-9e79-b703103f2525"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c33c66c-508b-461e-916b-e4f08317b569"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c4e119a-0011-4c72-a9eb-7304c234a612"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c647146-fc6d-4504-bce2-2f4bdb096a68"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c76fcb0-e52d-4054-8d47-e1d5f26bbd8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c7aef80-496f-4b2b-8d0b-6edcad56f1a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c7c0ca5-92ea-4246-83fd-4a2d61e7052b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6c958c25-a600-48b7-a062-4a14a213227d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6cf27e12-e7fd-4586-917a-b8cc25061687"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6d14e58a-8668-45ba-8166-9ffdd0a9999f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6d2f9c65-aa3b-4a1e-912d-3425a1a74a85"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6d40a151-4e71-41e8-9344-d7ad3b277916"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6d67619e-f458-4878-99da-f411c29cda13"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6d944f5a-beb4-4592-85b3-dce75b720e72"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6dbd907b-5b57-48eb-9442-a12de75aaef8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6dbe386c-a347-488d-a1df-6618775e2441"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6dc14e49-4281-43ea-8491-cf72648f3dac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6dd093dd-7ea0-4d62-8c0c-1d7012fe837e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6de6f428-57a1-41e7-be7a-4adbae1c9570"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6dec4892-143e-46d0-a118-0fab1e83a8ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6ded9fec-560b-4d7a-971c-c31721a40958"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6df27475-c2c5-4659-8752-cdc98463de3b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6df9e74e-3ceb-4ed6-a5c9-3c330d72d367"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6e487003-044f-40b2-8d69-29c946d85119"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6e5bd5fe-cc2c-4ae6-8bd6-1617c626f393"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6e600775-c4b6-4fd6-9989-f3a3a01500e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6e8a0db5-1c08-4ed7-8c55-07a9c74b55c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6e90ceea-ef56-4912-aa5d-74a8cd35a973"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6eb2714e-6e26-45d5-b744-bfedb5080c4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6eb951f0-c5e4-4318-a095-4449d9de7c57"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6ebd91c9-3b94-42f4-ac99-1fa2d3ba4c4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6ed4b2cd-753c-4750-a1bc-63e01c128d4b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6eeb1d3f-c46e-4db7-9880-5c257bb70925"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6efe2765-901e-4b43-9551-bce5d15ae875"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f0ff877-e118-47d1-9c1b-8c01e77645a3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f2a3f2e-faa0-49e4-8679-eb82d2af83aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f2c3e16-34bc-4c37-8c4d-821b0fd93abd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f3c433a-f305-4211-a863-7b227fef5440"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f461430-5996-4dc7-b2e3-524cdce08e36"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f76daae-39c1-449e-b9d5-14cbf41c5368"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f8fdf35-8de7-4943-831f-36689032aaec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6f927c0a-f202-4ad7-9752-17b7bc668894"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6fe7dc56-830d-4db1-afa8-371c899a118c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("6ff9d7c5-e0b4-4e29-84a9-9c7fe4d47372"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("700e6be1-816e-4fd6-8d3b-314125d6fd53"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7017d316-1012-4a77-9252-347c29ad0d89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("701c1274-4faf-4080-be3f-b05a9622d94d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("702b49d3-e10b-4e94-9179-75623194cb8e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("70381cb0-f6cc-4e65-99a4-bf36829b0f4b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7065c2b1-f055-47c2-b295-f89da37f7d98"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("70b7ab3c-66c2-48d1-b170-7363156878cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("70b9131f-575f-4328-bc15-56abc5929319"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("710ff5e4-6b56-429a-b1db-3d9584e970ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("71103a54-119b-4713-a3d8-640274a3c446"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("712648ad-e90f-44dd-8832-0e17842459d0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("712c7e50-9014-4b6e-89ed-d03b1d2dd89b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7142263a-f3a7-45d5-8897-a85f9f4871cd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("714eccf3-9e00-4bc7-884f-f2fc59468150"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("715c1950-cb56-4219-b1fb-147ef9d4ec13"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7163af11-def5-479e-a92d-a5a23e5b7096"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("717090f2-be8c-4ee6-868c-e5936ac90616"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7184b117-944e-4ab7-8191-c85356e2845e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("718ed472-9d39-46ed-a946-fb9561dd1a58"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("71dcc4a2-6859-45bf-9411-5337644aab5c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("71f69107-ae3c-48bb-94b5-86ab3abac239"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("71f9e6be-878c-45db-943d-96ca6eeba2db"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("72050a60-2c6c-4433-b634-f30e05629ec8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("721c6e03-9aec-465d-aeda-85927db8388c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("725a9dbe-d642-4710-b204-a7c3df93ad6b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("725d7fdf-56ab-4675-8133-eb04251f64e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("725f933f-906f-41ca-a9d9-0ad54e80280f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("72aebc69-618b-4a94-bb1e-92450bcaa8cc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("72e5aa02-1906-482f-a5e5-78cf6427f987"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("72f37cde-c562-40d4-9db7-16e230b601db"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("72fd0d2d-2f60-4976-831c-8f0cf1367a80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7305e81c-423f-44ac-b8d1-4c44d56f4d38"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7358dfc0-4778-492a-8a1a-593408b9b583"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73732d01-23f0-4fa4-9150-8229d6eb2810"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73ac3f38-3ce2-45f9-8e44-e7a24b6d8963"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73b53b0f-60bc-40ea-80d9-470ebbcbe2f9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73c05c9f-42e2-4379-a1ac-df1f1b307cea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73e59fce-cbe6-42bc-bf0a-8ea50c1bd8a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73ed3509-55d8-477c-9f97-9ec420c56a83"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73ef4ece-5e00-4d79-ac7f-21fa7c264585"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73ff3050-bbb4-4121-b257-ef02d42a7bf6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("73fffa0d-3131-41a6-9d12-becde1080503"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7409db0f-9307-42f8-bb4f-68aebbdb25e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74124eed-9c42-484e-b2f7-f86ac8c073fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7413871f-e257-4cd2-8dc1-47ad9fd1752c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7420ff63-76b0-443d-9c79-bea842465439"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74449430-789d-410d-a37b-a2e3e55cd11e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("744f33b4-300b-4e1e-b577-79ed65e62e86"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74583361-8b45-4ff3-9cac-ac3388611e6e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74732c69-a2cd-4b56-99d2-1f9a24e179e2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7474b1bb-b771-4806-b684-a74c8e7da054"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("748c147b-e64b-438e-916d-f947da0ac8b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("749ca25b-5047-4e5c-bddf-3cf0b3b52b60"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74b4e48a-90f9-4c2e-84ab-55f63e952e2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74d55ece-5f1c-4e83-ad77-3ea82dee034e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("74e4baab-d5e6-41c8-aa7c-7fd1197fc7a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7501c891-1e24-4fc6-895a-e190f7fa7600"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("75096270-55f0-4f65-9ba2-ca46e7dbd530"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("75163357-b87b-4c01-9cd4-df8ed8a3ece5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("75390916-8e3d-4b2b-8f2f-0e658111545a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7559f549-c45e-462a-b6f4-9289b5ac31e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("75603ba8-d1f7-4896-a934-ded6fa0afd02"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("75d00e47-c573-4e70-b2a3-35fc3a043aa4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("76116547-ee24-4a7b-9d91-4fb1875a39b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("76256488-d49e-4963-9041-663ba83f4447"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("76698168-6459-4d82-a38c-5c286cca06c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("769bcb6b-0ce0-426d-a9b1-402f7b503af6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("769fe22f-2327-4499-9143-ab9b113e34bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("76be0800-2a7f-452a-ab11-e6546017ce84"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("76d40bcf-cf2b-4157-b35f-0f2002107fab"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("770f9dc1-5ca4-456c-a0b1-cc38ee98a106"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77174e21-eabc-4eb3-b415-c1339728b7c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77195650-10df-4dc6-a43e-bec18d43b992"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("773ac6b1-1525-4e4a-8664-9e152fee37fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77593e01-fc88-43f6-a5ce-aca4819b4ff4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77650e63-cc79-4c11-a7c4-8f7ce922e7b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7783c641-4151-484f-9274-15209207d439"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7794c2b5-95e4-4784-a952-422a8e34fa9b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("779716a8-8abb-46dd-a8a0-2c78120bc20b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77e2dfa9-47d2-452b-b56c-953761f09119"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77eb2c3b-d608-4644-8f93-333ecf097499"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("77fda73b-0c87-4f33-8151-7d60b0a8799f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("780ea2f3-f13c-4274-a1b7-320f5d2f7351"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("78256471-8fc6-452d-9a38-5dcf54f19102"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("78461b77-a339-4322-ae99-5205b909cc45"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7854e672-28c6-433f-ad01-dd411d7cacd7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("78616ca0-a1f0-4fc6-9258-7eb353d3fc4b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7871369c-53bc-4fcc-ab3f-48d875784fa2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7871f0a4-2380-488b-836d-aa35a5e8576a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("788720d8-c1c2-43d9-b88a-a90b8ce4fb7b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("78d0d459-09a9-4b0c-8d93-5b7fe726ba3e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("78d4bbfc-81f4-4f1b-bfa8-ac1b41286862"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("78f0a9f7-c708-4678-9950-ff04586ff7a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7900e4e1-ab77-4ba4-8601-4c0005b995d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("79665698-2c01-4f15-80c7-7961619cd876"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("79780998-5c93-4ff5-8f8d-b8e2c61bc0f2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("798ffa99-7d7d-4fb1-ac41-f19940b46a6d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("79cca88a-9ecd-4332-a76e-3b3e6cfce442"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7a17b6f5-e4c3-46b7-a346-95b17d329ee3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7a1a8476-2cce-4fc6-a6e1-43667abd2203"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7a2f159c-fb05-486d-91a9-f818e6009093"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7a48e2de-a3a4-4243-8363-38e2aff9abd1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7a4a10e6-6cf1-4733-84fd-eb008f70799a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7a6d0edc-43be-4cbd-8b4c-4c0da9669ed6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7aa1143d-9105-47e3-a2b9-c76bc04f1a07"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ad46bd1-c075-4ac7-a5b2-a41e21b53b03"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7aee03ee-cd56-46b5-b235-ec5c4006f3f2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7af9b47b-6503-444f-bbfa-f1428449885b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b04e430-1f1a-4755-a5ba-c2d7529ca9ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b0a50b7-8a00-4403-a86f-d3f6051c63ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b0f6dbc-7a98-4701-ae8d-55ba33b510a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b1f5ab1-0278-499e-9b71-3f26701bcd9d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b2c353c-9d92-4754-a0ca-3bf9faac5c7a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b76f13f-5eed-48cf-83f1-1b82027c62ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7b9a1fc4-b98a-4211-8635-00dce4bfb235"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7bc047bd-f027-4f22-aa06-190353536930"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7bdda444-5cbb-41da-ba2f-af4d9cf3df31"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7be987dd-3291-4fc2-b839-049ebc1232c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7bfc7d2b-7eef-4bca-9bb9-d062062e8c9f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7c0197f6-1eb6-472e-a338-e50a26c5096d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7c260cef-3d7f-41ef-a5a5-5500a94a1e8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7c39a7d6-cb6b-49d1-8cf1-6ac730d286d1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7c512c47-fe9c-43c2-83dd-1d46f0ca5a1c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7c60d519-43dc-4c7e-aa56-33e25c4eef11"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7c60fa16-0ea9-44b3-beec-07517d4aee46"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7cc419bf-69eb-439c-b4d3-4610ec29d007"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ce8c049-ff58-4a98-b834-237023a83cd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7cea9546-6a2e-4044-b477-daded4c83df2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ceb3906-d4fd-4bd3-8675-513fd4006288"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ceecac4-3085-4159-a7b2-aec989606320"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7cf2dffd-a48f-416b-948e-b60f28bc8a99"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7d64bcc7-ef8e-486f-9d79-701dcc47aea8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7d9ba64c-7221-4545-8042-731fed2a41e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7da15579-889d-45e9-9a5f-63b78c81be0b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7dab5692-ae09-4b78-8cf8-c6ca4a9fd511"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7dad9654-3400-4f46-bff1-6745fa080371"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7dc1acd0-dbc2-4a82-ac47-ad0ead94897d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7dcc6b3b-4f18-4dd4-b02b-9f2de0c642d6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7dfaa1d2-0aa9-48a5-8e55-d1eb54d4f42a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7e2753c9-ad22-44f8-9ccb-8ccedce6d35b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7e5499c0-292d-4989-b1e5-35bc281fa944"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7e624672-1fa3-4d68-8dd4-ed7b0e31e1de"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7e69fb38-ab34-4bac-a691-a8203c95a6ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7e6ef19e-0e19-4fc4-bf07-97c875e4c339"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7e917721-b551-42a7-8f21-889ed89f3aba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ecf3d49-3205-4614-98c3-659f37c0b244"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ee21f1b-95b2-4aaa-a35c-eea50a12af93"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7efe8424-f04e-45bf-8344-61fd6fec711e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7f3749e5-55da-4647-a28a-84241ec1d890"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7f723503-c130-4c1e-a1f4-90b6ecb7c336"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7fa99b72-6246-443e-b0a8-82524d4af247"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7fda423d-e0a9-4788-8435-656a5052cae3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("7ff52d6a-bb2b-40be-b25d-89c8f112d053"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("801c557b-9f6d-4920-8519-cdf4f409f73c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("803a43b6-2f58-49dd-8c95-2697e29b8f8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("803c9a26-7cd7-4e49-b603-07f3e89a5cf1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("80596a76-1e3d-4b98-b7fe-40c7ce5419d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("807784fb-7d0a-4b66-8f30-eac2f1393f05"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("807eebb7-ecb1-4d69-be6f-842b792d978b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("80a4d907-666a-44a4-8cd6-92e5be419a8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("80bf246c-df9c-42b9-a8d1-dab23fd224e0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("80ea3b82-8908-40c3-8a85-27d8161bef21"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8108cff9-1f6a-4acd-9aa0-139d4ded33d6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8112c35b-8722-4b50-89f0-4b9b86ab675d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8126e78e-4de1-4699-b18a-3479aaa1059a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("812c801a-a835-4504-a4ca-18ffae4950e0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81657116-3188-46b1-ad4e-12397b119dd7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("817b3665-496a-4bd1-bb32-5b369d4c22f2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("817decd6-9db5-41db-a412-daf65f41deba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81a57f3c-f8d2-4f87-8875-13a0b3c7b061"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81a90c3c-0c98-4c71-b5fd-a20092e2a4b2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81c1d951-17ae-4cd8-924c-3ba8a7226caf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81c9ef36-0dad-4de0-be6c-635c8c47b542"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81e4d242-33a4-49c8-9417-b11920218ec1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81ed8798-a898-4928-84ab-da24d4cd605d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("81f592bf-b7f0-44bc-8fda-2764bfed8426"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("820ec661-0f79-4de6-ab27-4170087b9dff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8246c4d4-119b-46f7-a362-cabcf940cab9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("826591dc-d180-4752-81f1-349ea065819f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("829819e6-88b7-4db8-84ae-50f23f7ac31a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("82ddd641-6059-4238-a300-c4f09e2e99c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("82ff43b3-6f32-4c56-9c23-57927a58f154"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("831f985f-4606-4480-9e69-97e31c53ec91"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8337d61c-f080-4a5c-ac5b-7420168dbafa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8344824c-db50-4341-bde4-24d32908e8ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("834be5af-4c95-4578-90ea-e97ce1dd6161"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83673bb2-9d3d-4c58-bfdd-d3adf3e23dfc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("837cb4d4-223f-4ef8-80c6-23c23db45dfd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83ba4553-5cd1-4f5c-ab7e-f957cc0efbf2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83c282c1-440a-4c63-af66-f3e329af8f9b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83d19c92-71a5-4dad-a95b-cf969870de36"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83d9be44-6947-4bc6-81a4-a2b9f49df072"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83e18151-ba0d-42f6-b063-57b9ce56106b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83f77ed1-e949-4f97-99af-6b5f430aac4d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("83fca229-67fb-4323-b8d4-67ed26a64e93"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("840dd369-57f4-4ae5-81a0-82ae208b3eb6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8412c060-d1b4-49ee-aac7-2eecbceabb80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("84207603-70c2-4e4d-9507-42d0a19d9ec6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8456dffa-239d-4a71-8545-92f39e71c920"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("847ca87f-bec0-4f97-a59b-7feb6e216fa7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("84adbc00-08e8-4b9b-acc7-4d66fcd6606b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("84b74256-c1fa-42f6-b267-b71da7b3b03f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("84bb634b-ca4c-46e7-9cf5-a86467cb064f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("84eeafb3-9786-4675-b13e-3750417c5da8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("853f34bc-d479-4be5-8242-21249713f712"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8571ccc1-f3d7-490c-9762-9136fe00bd71"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8582f660-8c82-455c-9e11-93d7dade2687"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8599a122-aaf1-4250-a775-506d0553df41"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85a4a2d6-a266-4dc3-9525-e57598ed0bf1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85b8d760-262f-4555-927c-205872fbd4b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85cf66e7-5633-41af-a2bf-5ee17c061857"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85d974d8-534c-4f63-a488-96a412479962"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85f30308-ed79-49cb-88a8-87db72414e9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85f4b097-78b2-47d8-90a7-11e13c4e127b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("85f9e67a-af41-42ed-9e36-dcd2ecb14d5a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8601a841-063f-45cf-8e85-2f11864efb7a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("860ed303-d67d-4076-9037-2de5b1c023a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("862812cc-2384-4d84-9ee5-1832d06fbdd1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("865a58d9-9c1f-4922-9fe5-b34e2a8f7d49"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("865f7cca-0185-415f-812c-b6476dd0e3b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("866b5391-cb37-4320-b66a-9bd28acbe214"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("86761575-6163-4dfa-9400-9354b96335a1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("867e263f-a90f-4326-bff2-479bd3fc854f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8682e32b-e29a-4a10-91de-94e4b493caa6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("86b1098c-6c07-4e4f-80f6-1593a39357e9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("86b72c09-0aad-4882-bf2b-c8d122515a65"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("86c9725e-9417-4dde-a09e-de0e35d28558"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("86e1a40b-89df-4423-9653-4bd461d11d80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("86f03206-d4d5-479a-93d8-b65cc993b79c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("87029dde-463a-44c7-87e0-23dc18eb1a80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8711613b-7872-401a-8af1-19e512d90a01"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("871791cf-d0d3-45cc-b563-298f761f836f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("874d729d-9b9d-4f07-87fc-366fe7f0e371"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("877493ba-ab67-49d3-8ed1-0bbf6e035bd3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8781ab92-7f66-4671-b70e-57b48dd8eed6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("87a60442-d913-49c5-851a-184d27fe5a80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8821a423-0766-45ea-a39f-d90c9d135412"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8839993b-2adb-4740-acc3-cd600861a19f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("888e9909-636a-486a-aef0-a12470972525"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("88c4d5f1-0d21-4d13-848a-4e1a4a3d68dc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("88d95e6f-4791-4fdb-9bfe-0eff274a107e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("89063cb5-d2f7-4ef0-a7e8-0e181976dd89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("890dde22-7419-4edd-938f-7cb462c68e50"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("89318c76-6724-4c01-bfa4-71a35fc5247d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("893cc0eb-1a94-48d2-8cbf-b6d3c8657567"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("89cb78b9-17c4-409f-bdbe-1ede7c3cf329"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("89e49a21-1f55-44cd-94e7-9fc852bac638"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("89e76f40-9805-4ef7-ad7d-68882e663f63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8a35de75-b850-43fc-82af-c6f677366b72"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8a705a8c-bedc-4ff7-beda-c957a35f6ecc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8a8490b2-b16c-45ca-a37a-838a776ddd94"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8aaa6b9a-3064-4db7-ae2b-44fd85f7609b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ac75a76-fcdf-4f38-8870-272902b37905"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ae16229-59b1-431c-9fbf-ea7250cacac5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ba8aff8-6f27-49ee-b848-2c68a04960a1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8be83beb-9178-4242-b642-81b8f26f8d96"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8bf3c973-772c-447c-8ae1-70d733fb7e30"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8bfbaa8b-b6be-44d6-8d58-ca6b1ab37283"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8bfe0155-275f-47bd-8394-5e75b5b1e058"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8c0afdca-fb5e-4c3f-b5bb-f155755dcc00"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8c14f455-190b-4e2a-8f5b-039e51bc507a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ca44861-8ba7-4728-ab2d-ac28c8326e67"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8cc0ab9d-e5b5-40d6-853e-4eaa8c2a2210"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8cde45af-1555-4d61-913e-7e60abdc5702"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8cfb901f-f496-4701-aadd-09112d91ba27"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8d082dbf-25dd-4545-a7a2-d03cf4345ab6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8d1b69ee-d717-4906-addf-bb670756a78e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8d694c18-ec43-4dde-b6d7-ad5d0892c653"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8d6f4123-966f-4ad0-b789-3abffc17469d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8db57fc6-f558-411d-98ae-85b8d9a9087f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8db8fe6d-ff7d-409c-a9bc-5345e6368825"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8de4513d-c702-472f-be35-8ef394fb879b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8de84af6-0648-46db-b073-fa746c3529f4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8dea5b4b-7846-408b-bf3f-f57efa5330b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8e2cc316-4ce8-4d53-ba9e-3f7f0a68f0eb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8e32c5a3-5658-48d5-8a5c-b26aec197e83"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8e53defd-29f7-48d7-8ee3-583f0341a15b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8e6fe6fb-e5dd-4166-aa68-b78641a4e611"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8e885823-1e8a-4b44-9626-98a798fa6b31"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8e9e6dbe-aad7-4ece-af10-386c7a9f28ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ec5a78e-73b5-4ef7-bcfc-30360e575be2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ecc295d-18c3-4ac7-9269-129b3e2f382f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ee10a3b-626a-4b26-a208-9e298b6f3860"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8efe37a7-faed-4dc1-8bca-ff82c7d6a3d1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f525ea1-b0bb-4b96-a322-42ae95d628cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f55e2a5-8b2b-47fb-b14e-cf902f7f26c5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f561bfe-3c9a-4f15-a859-25203a47dac2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f682ea9-99ba-432f-8e34-fb4dcaff7e82"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f745ea8-f62e-4ede-8ea0-9c8040bbf90c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f82324b-0903-4f71-96e5-1573a9b0682a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f907047-23bd-4e47-80c0-a400d7577180"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8f977813-d0b2-4478-b393-9749ec046e62"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8fc915a8-6692-4522-9e18-510cd33d806d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8fd799ff-a6f9-4bfa-af21-7d2a8197e464"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("8ffe9ee1-0a22-4f82-8026-c3407b689161"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90005f93-f962-4ae2-b425-7343dc93bbd3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90269f22-1231-4603-865c-8f66223e436c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90275f9a-8b13-4336-83c1-ebd2d7d3a590"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9030e870-caf4-4c31-b71e-9a4b79ae0932"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("903a273f-7781-46a2-a840-77fce67a2a63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90443ff5-cc9e-4eae-92bd-4cb1dfa637c8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("904b68c7-d821-4076-8007-f2fc8f938578"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("905095bb-d27d-49ca-a3aa-6ee6074c356f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9057578c-23d6-4f15-8b7e-d9291e7d274c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("905dec50-b2b6-4196-b1fb-ff0c37015b43"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("907e674f-50e2-481e-8312-e36b411232d2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90813a26-d756-46f9-83e5-c8c160fb169c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90939bbc-5597-4995-99c8-91ec60cc3843"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90b7783b-9366-4978-95bb-13162ce7a287"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90cecb7b-9216-4274-8b1e-72f37f13a940"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90e68ebc-5676-473e-87a7-b5d3e6c778fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90ec6a20-d042-46b1-8ac5-878d8d6138f4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("90f237a1-e614-4181-8bd0-091da161f02d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("910065ff-9906-48c2-9937-9a702b9590df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("91036c28-91e7-4e96-a280-482399791c21"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9141a081-45e5-40fb-a75d-54171a4f5d08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9159c87f-76fe-4160-96b2-5a3a2ad9ff5c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("91832047-fd74-48f3-996f-35a617ffdcd8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("91843083-c66a-4f73-b875-78495d175ab9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("91ba4b03-5e26-4130-975e-de26c6cc4f7c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("91d91ef3-60f7-4813-bcd7-9e0596a3fbcd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("91f0e56d-c940-42a5-adbe-13c10512b6ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9217a64e-f08a-4fe7-8e00-83791f2e4a66"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9242c465-c286-4b0d-8f41-863f1dccdf41"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9275d323-598d-40ae-b11d-3bc4f9aa1229"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9289ded0-c436-429d-ab7f-68f5d7d4abe5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("92b91c96-3906-4bfe-aa8f-3798233afa08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("92d62005-2c41-4e93-b037-fc6a7705de76"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("92e12a61-e0a1-423f-957a-e75ddd3bf1fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("92f02cee-6876-462d-8d3a-9ab4b31fa849"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93171ec0-c261-439f-ae7f-07f221a4b475"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("936af3da-9389-4cee-b7c6-0472687c8085"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9372b2db-4cb4-408f-833d-faef42526cd3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("938fce8b-e89b-4f87-b323-3d753be38b43"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("939e55db-748b-499e-8249-b1969d749845"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93b601fd-c797-42a8-b567-69c34fffa8cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93c2e745-cac9-4fbb-9bce-8cfbe24ab75b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93c9cc78-149d-4b9b-b689-348700c2255b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93e84bbf-494a-43ea-8804-24688b6b78bf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93f54a6e-6e16-459b-8873-79902e6da544"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("93fb6889-4233-4c1b-83a6-add6d8f527f0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94038c34-99b9-4aad-a534-393d3fafec66"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9413e5c5-4951-4964-bb20-ee86cf3e8f8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94167762-d563-42d3-9cd6-60abfca805c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("942e3bc3-aaed-4dee-a2a9-86a94eea9573"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9465c238-b473-41f2-9192-d57ab7117e38"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("947cc840-9946-4dbf-aa11-8f125ae7110d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("947dcaf4-dd6d-442e-948d-c5d525e6df6d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9483d0e2-1e68-4bf5-938d-7d22a1324c11"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94a53168-088d-4c30-bbd5-61716accf3f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94b994a1-b890-4e5a-9177-e4f9162940ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94b9e95e-72bc-4b40-a930-1ce00146e24a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94c6cb01-b5d7-4968-bc9f-06ecebad2e0e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94da92c9-9888-43ed-bd3d-ab15dc98c365"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94e6bf6a-9e2d-436f-8419-931ff3822af7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("94ea1527-e549-462c-8767-5d47d548dfce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95013b02-7180-4322-973e-e9090de6d811"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("951556dc-9474-4553-89a3-e0072dd3099e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95171b09-d7de-49c8-9d91-d96e68aac9b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9523366d-f234-44c2-8d8e-db9588ff898d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95250d84-5274-4ac3-ab3c-b9da3748e403"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("952d2dde-9f9e-4c1e-9546-2a48be23ab39"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95401462-a632-40cb-a91a-205c51cc4bd3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("954721cf-6dec-4d22-aea2-141d3d36d048"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("954f4adc-e97f-4cbe-bb27-82478cefc4cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("955fae60-aae3-4887-a441-b400a41f0120"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95932424-0fab-4e9b-a760-c5ab95f372f1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95b2761b-7f99-4a5e-872a-542f1fcfa82b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95ccf932-9826-4df3-bf41-404a1eb47b16"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95d2f925-9ea1-499a-bdb8-30fb7e4283d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95d39a74-c3e2-4150-a441-a5e33a334db5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("95d9a3f7-5b90-4e9d-98ec-2d49d319215c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9659fe39-0831-403a-852c-59e158bc4cb4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("966f21f0-1fec-4c6b-8e5a-7e08ece65e0d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("968608ea-ffcc-4a7f-baf2-2217eb392136"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("968b4a95-f640-4c4f-b07d-8c2fc0d517be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("96a3bfff-8fa7-41c1-afa5-72723acf4efe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("96d13bbf-22e0-43f0-978d-4df500502a0f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("96e0370d-b7c9-43cf-868c-d6960b5a4174"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("96e1ea1e-5010-4a22-b652-5d08d36be13c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("970e938c-6c1b-4bbe-b9c6-395bf5222061"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9737d5eb-11bd-4d2f-bef5-118be956d76a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9748845b-2bce-46a5-a333-37ad48fb37e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97492f39-70ac-4f7c-8006-319ede0f0b23"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("974bd905-468d-421c-8818-128816e94855"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97781bc9-ce37-4355-93d5-c490199bad04"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9782fb98-4ceb-4405-9281-5eecf6cea2af"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97a7ec97-1dac-4886-8845-a46be507457b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97b28122-bb54-43ac-8782-ed142bb21bbf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97b82350-a00c-4693-80ce-7d6da8cb20b4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97cada6f-2914-480e-9149-a2ee63c07cb5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97d1f5e7-3822-4129-a507-340f4bbf6179"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97df1a10-6a72-4d52-8321-2fbad4246501"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97e40f84-a25f-46e9-a78a-916183d7c920"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97e43f01-0f4f-4093-b77a-81359dcd4a28"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97f2f284-be89-4cec-aa92-b1bf5855c089"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("97fd5531-46ac-4bbb-9414-851641a2f4f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98057ee6-d9bf-4737-b0fa-ba2eb08751cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("980eb5fd-597a-4a02-af3e-5a08271f4e8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("983559a5-07d3-4c4e-acd0-0f78a4e4b957"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("983a727c-aedd-4891-94e4-ef6ae1c005e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("984f5a0e-547c-4dc8-b366-d1cdd5ba6329"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("985b1efc-2055-45d8-ae14-95e2cff8e38d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98630637-ae18-4250-995a-98e9b7663328"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("987db8ae-4f29-4c4b-81aa-8df05afbd695"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98a08f00-8975-457c-9d9b-60dddc637c07"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98ca7004-84de-4eca-8d20-738f550cc99a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98de2f6a-4c5b-4438-ad42-b80bc79873ab"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98e5d26c-ee6f-4d01-ac1d-fa5ed15cc58d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98eda227-c4a5-4aee-b541-b0e7b755648c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("98efbcac-6238-4abc-874b-28da02f0132f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9923daaf-d027-4eb1-9129-a04862edb9af"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("992aa195-06b1-4897-932e-e4b093e526e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9956bea6-bf8d-4c46-b455-0608b28bb4ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("99b4da9e-2042-4cf3-afd5-6565ffa0bd05"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("99cd96f8-73f2-49d4-b641-f854ed87aebd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("99d43bfd-d063-4be9-a758-0fdf0a4a2c4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("99e78cc3-9054-4156-813b-071de0d559eb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("99f332f8-c2f5-45e4-ad3f-8d19db555e44"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("99f5bfbf-fdc3-4b7f-a42f-998354e929a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a0cb725-c3a1-41a9-9c1d-e87036775e08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a14c5ad-b3fb-4bce-b0f0-b3b702aa7b63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a37de78-6007-4884-a7c1-2bf065fef15d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a4067c6-7348-4dea-800e-4a493be4cb8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a5cb0e3-f374-4d60-9389-106fc6a42d0b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a99e964-3ecb-451f-8a89-172690fc04ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9a9c48b1-190e-43b3-bf56-055f22c3b826"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9aae51c1-29d6-4a44-9a3d-9836e8448aca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ab5a605-91e0-41b6-b970-033072122bb5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9aee31a3-00d0-49fa-a822-e0f7ee6ed190"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9b0ca3c7-1f9e-447f-b31f-a2f428c223ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9b0cd627-552a-4b03-8ea8-a8d12bf0c614"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9b0d8260-8c66-45aa-a66d-1c328a1d8fed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9b100e92-51d9-445e-9f35-8c99e612ba03"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9b4a4026-d236-4543-b670-babf41196c31"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9b5b0b54-658a-4647-a6a6-10a8a67ebeac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9bbd3e3d-43a0-47a6-8ecb-1215fa8cc21d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9bd902de-80ec-4965-8e61-e7fa6075c20a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9bfb7649-dd98-44fe-bcd5-aecd4846329b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9c0c9817-e336-4245-ad79-f00eb2fadaf0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9c2681b7-fee4-4ee8-98da-7c9cf04b3120"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9c370874-86df-4116-8b73-c98985f52c9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9c447694-7ed2-4dcd-8e25-39637b7778e1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9c7e611c-b631-4933-ac03-ac466cb3b9ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9c8928a4-57c9-426d-83de-4aea4f411d5e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ce2c8d3-8507-4205-a7df-faacd0c95aca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ce42212-14aa-4b13-b417-3e8ed34e6424"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9cf536e6-7441-4f68-b3d1-4e247917b1ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d17e3bf-8770-4917-918c-3293f976c181"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d392193-d6dd-456e-9459-63af1e5b000a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d5183ac-781f-48d7-b16e-7b75d3918ac9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d78f69b-f5a2-4152-a7b9-de1f55e1ebbc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d7ea035-8583-4a96-bdaf-0a1843244514"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d94bfeb-09f0-4acc-851a-5c984ad2f9df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9d9692ec-f38e-4641-b0d5-fd18e1d241e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9da09b38-767f-4b1c-bf18-534e8da498bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9daf2bcf-d496-4e57-955c-3fd6e6f8c873"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9daff05f-0ce5-466c-ade6-a386f0c5562c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9dd2c4c0-debf-437a-8e39-42a4ee902798"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9dde5ec4-1f84-49fc-98ca-130a72e44471"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9de7959d-f567-4865-ade8-43fa9b01a2f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9dea2aef-e88a-422d-a54e-b80c22165a49"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9e20f2bd-db04-4f38-8f57-c1cef8ce05e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9e3d2bae-cc30-492a-9b92-e91646e10f16"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9e8b4d93-3c98-4fa0-a4ef-d1f78eb1274d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9e9f9ed5-d92e-43d6-871c-4858f796456d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ed982a9-a02e-40ec-9b03-8907530282e1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ede6a55-8dcf-4b99-adbd-0e24bcb02ac3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f072be8-f230-44d5-b865-21e2a677f878"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f089476-c48b-4dd1-b9dc-e24ac80d0cb4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f08c39c-adc7-487b-a33a-972f8776343b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f249a4c-1466-49f6-959e-cb09a04f450b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f3d9f5a-8c64-4ce4-b09d-ff63a0ff3cd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f4445c1-25c8-4109-a30f-d0612147c8c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f47e43d-0f16-4938-84f8-da510947d396"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f79901d-6aca-4ee6-a52e-1694b68c039a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9f83691d-dfa1-4bd0-8e3d-2a37ec0a539e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9fc5a50d-f188-43dc-b321-127b9fbbd226"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9fdab55a-2476-44a0-8852-8302a944aa9f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ff28339-3b41-4e6a-a4a2-307dd15d0611"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("9ffb09b7-399b-4052-b883-f89c46d3d9b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a00df357-413c-4fa5-86c9-d849d311ed59"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a0189ddd-ea06-4f58-85c6-b5fbdc2436f2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a0354d76-1334-4031-8e25-49132ba0e4d2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a03fabad-fe60-4bd1-9d24-7d321beb7d77"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a07ea3e8-5b49-4204-b188-13d38b307172"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a08b0113-ae2b-4c40-bd9f-48b01a93386c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a0a720bf-8092-49a1-b926-cb2d8d4ae167"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a0b9c9df-eb44-4894-8c54-864ea30cff2a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a0f68cae-0bc5-4b05-b9f4-6ecf423294fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a12940a4-f24a-4895-be33-dbecbb8137b9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a12b2e33-b9c1-43c8-a69a-64d7bacdef10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a13769dc-a062-4a00-8793-abf7ca8b7297"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a188eb21-ebd7-4a24-b42d-9bba1e02b10f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a1962f96-516a-4aa1-b79d-1f315b2cd0b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a19ec909-d945-4288-9d86-c4a3d5a9aa54"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a1b5ddbc-ea9a-4e4c-aa77-3306c93bafe6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2018aed-c7b4-4388-8195-216601858a73"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2034499-5250-445e-9dab-4334b5aa7249"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a206e524-5c45-4d60-85a1-04bd0630a03d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2a7a201-2ad4-4f07-b929-9fcd5db1b53f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2bec7b3-6b18-47d8-acbb-f767f923c0e0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2ce9040-8a0c-4bdb-8824-17e2f3a94d08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2d3578e-506c-46ed-84f3-9887d3c17df0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a2f616a7-72e2-4fd6-a318-de5675035aa9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a304063e-085b-4f49-bb1f-e344308c98da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a31f4ee9-4154-437a-a54c-77392134616e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a325c41a-e1d3-4594-8f4e-a37867dbc2ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a32fbc9d-ef92-40ab-bac2-5048a25b7ad3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a34ea3e1-b2ac-4786-8903-73cee657d2f9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a356ee62-63c4-4c08-aa72-cf7f4aa3d182"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a36974d8-589b-46aa-8d91-58e43820d650"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a36d27d7-fa59-461a-b9b5-ee17a9256246"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a381ebc8-2922-4b3f-bdea-71fbae6e37c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a3b85705-339f-453d-89d2-fd1ec28bb26d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a3c9d973-fd02-421d-88af-6bd9c9da900c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a3d06ba5-78df-41d5-b06d-a0cb6d6b3778"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a3e2c43c-c17a-40f0-bbad-ff92fd797dcc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a3ea528a-677c-4b68-b3c6-8af1120964cc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a401049a-7e5a-4932-9fec-59dae14f9ef2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a40fc1dc-1f60-4a8f-8ac1-cec9c423a4e1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a411bc14-4d34-4df8-bf95-357079958218"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a42a1ac5-9291-49d6-a082-d25eecfed232"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a4302fb2-bc84-40ab-89b5-4797a510685f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a46e490e-3c75-4aa9-8629-3bdc0d8d51b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a49cc52e-f4e8-48a2-b5cf-15b1bf6967be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a4d3db82-ee9b-491e-8663-a0724ade4123"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a4dc1045-f92f-4550-8be5-62f3c8f63cfe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a531ba43-6fef-43cc-892c-cdfc0ad6500a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a566ead6-c817-403c-a178-17fcc1509c4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a59ede88-6861-4548-905b-2ef5b11806aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a5a18c88-3e78-4e5a-8f1c-1e4a98f79740"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a5a71e46-425e-48c9-bdca-2cf07832914c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a5b2c31c-59fd-4aa8-ba19-8b40ddf547cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a5c1c958-be07-49ac-b91c-a9d5b09c57e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a5eea62a-5fcc-4fd6-b09c-29985702dbce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a60a0d3b-10c8-4a06-a17e-e1eb9204665b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a6292eb1-167a-4431-9490-18cc8d1b892a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a640d4e9-8695-499a-bdac-5d44616506b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a65a18ac-eef3-4657-b1b9-c1c6e5605638"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a668e861-adba-4eb5-9f1c-98f3024d12cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a675678b-0041-4c43-93c8-f3af862a82cd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a6c30d64-822f-4f18-8e64-321f3a9c56dd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a702f43d-2579-4415-bd2d-642025380b26"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a721722b-2263-45d7-940e-4aeea9c5dce4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a72b348e-8b8e-4412-b265-70bfe4a869e4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a74d4fcf-b6f0-45c4-89b8-ce7d3f012adc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a773dc00-a6a1-4b45-a66d-b65da7cfc489"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a776a194-a156-4705-80a2-07e85d98fd67"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a79b70ae-5f25-41eb-97c5-51d50fb550c2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a79f98ac-383a-4ef6-b258-086e2fceb750"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7a7ba95-2aaf-475b-99a6-e3058b830452"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7b2a1a1-52b9-431f-af4b-cf30e8a4609d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7b533a6-6e6f-4d0b-a3c1-076d5dce6171"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7b603e4-9a04-4fad-a561-f75b8e7d2321"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7bea7e6-fa09-4313-b07a-2c525eb77344"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7c1c38b-fd01-40a4-9611-b7c295d098c9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7c4388d-0390-44f5-a1ce-673e1150eac0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7ceba32-dfdd-42cb-b11c-ad930b61ff3a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a7ec4216-a531-402c-a048-caf9de84760c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a867996c-0e64-4c79-86e8-c5fef30c690c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a88471dc-d8ad-45b3-9558-2ebeb23c6f74"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a88dfdf1-9bea-4053-bcce-86f2882512d0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a8b20b6e-af26-45f6-bb9a-08994015baea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a8b54588-22a1-40fa-8fee-b41905d26087"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a8bf2d7f-588e-4e52-8d3e-2e8e73ba7fdd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a8d8e538-4373-471f-845b-a4423da7bb20"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a9084e7f-a280-4a7c-a4ac-b1ee5ecd1362"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a9126c3b-fe79-445e-9e68-bcbf5196199a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a913be2c-ff24-483d-97d7-57c5d3b9d306"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a91b04af-1ff5-4a53-9b3f-0c994ff390da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a93a4d6d-dd37-4e8f-bc79-d69dd66ea4b2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a953656b-0808-48c7-af6c-7a40bd1a16e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a96080a4-47e4-498e-b6b2-6327e554264a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a97d7db6-a9c6-45e3-b366-6a540f5b9b2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a9918d5e-e57c-4476-aa6b-dcdd58ada6da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a998e961-6b8b-4a5d-bb62-01d0ea99b0f5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a99c6b73-15ef-4026-b783-ae2c0df4b9c8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("a9fa4b7b-36d7-4804-9e02-a1ab1c2879ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aa102be2-e6e3-4335-befd-c57267e6dfd7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aa2de2e1-aad4-4664-b635-e990a61f1eb8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aa6d2671-5186-4126-82c7-7ba1c19b53db"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aa8dce88-ec91-4bd5-bc90-b57b2d22173f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aa9bce3a-7497-4fef-a1e4-1856b7520798"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab19f62a-e611-4268-8369-ad46c0edec8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab226e2d-fc06-4e05-a9a4-c997a3ca34b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab557a98-22f3-44d2-9d28-ef680b9a71ef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab591149-3904-4d5f-9846-700a13bdc115"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab65b5df-d605-4963-ac83-8860fc91344a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab7f0369-dcf9-4e1c-8a0c-865a4a5fec47"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab87af4c-21d4-43a9-8792-c377b3dbf650"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ab90ff28-3b82-4124-bb06-b962736d5742"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aba5f641-3ba0-4680-89a7-0bbae41fdfad"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aba7b3df-3413-4844-89f1-f9f7e1f5d1d3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aba95cdc-5fa3-4fd1-b8c1-576711be2590"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("abac7a8f-7f0d-473a-8a12-c2e2a4b11d66"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("abd2111e-a9ee-4815-b2b2-6132ce021b4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("abfc724e-e0fa-4bf8-9331-8d0ffbbed29b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ac0874a9-6223-4557-a26b-5c00daaea9f1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ac185d4e-9963-49fd-8ef2-71026b14d0be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ac3323fd-f657-4951-9a5a-f0394488ad08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ac543331-0e99-419d-8f44-0f33788fb807"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("acd78717-ebb8-4b0a-b030-9531c2188f90"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("acf7a0c7-f47d-418c-8adb-72deeee8b7a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ad013933-515e-4211-a45e-191d0e602bfb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ad2a867b-9b3b-4253-9cce-55b2a5d6c110"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ad56ab68-fa21-46a9-a453-1320965d3663"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ad5f25d4-f46a-49f1-9fac-062ce486839d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ad614d6e-15a1-4c07-94b1-7aee8cecaea2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("add2b288-0b4d-49c9-ae7f-426b7109a82d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ade906e8-150c-47c3-8289-7da149fbc2c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ae16cc57-89dc-4b14-8e3e-ef1ce5e214ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ae3e951b-dbd1-42f1-9b40-45aa986e81f0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ae6b3fe5-6fc0-4f99-8d3e-e494b263ca0c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ae9dba0b-0331-40ee-880b-8dde751d9830"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aeb52038-958a-4374-acdb-388d88712bf5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aebe686a-f280-4cd1-b7f8-73bbb4438479"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aee604c4-b962-4709-93f8-234ac12eadfd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aefac107-fd44-40e7-b316-8f567ec19b95"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af161887-3405-4f38-b765-1066240d65cd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af1bb910-059f-470b-ab16-07cec8559ef7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af3f4b23-6c01-4658-82bb-0b7c54ac85f7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af4059eb-f5fe-4466-85ee-4ed742d0c0b4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af4c805c-ac54-4c81-90e1-b0e678ff8bef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af51aee0-87fd-4326-85fa-3ba7d5302725"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af68af52-446c-4607-aeec-48bfb6134949"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af6bc953-0222-4b19-8b1f-5f9e12e70389"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("af770f31-a384-4681-b241-5ccd9e60c866"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("afb5d101-6031-43c8-bf07-02aeb0a490dd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("afd0fa63-1499-492c-bbc6-0f6b77aa25aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("afd13e1e-b84c-448a-8213-4a56df7a9388"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("afe2ddb5-7b76-42d0-b7a9-796ef3227ec6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aff1437a-3f21-4af3-ac71-569150537b74"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("aff59d66-bc34-451f-9e55-5ebe5b0ce7bb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b00044f9-50c2-4d30-aaf2-13121f915933"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b001d52a-cca8-4586-9230-f455ab51774d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b021615a-f55b-4e87-b0d2-ee3ee2ab1a46"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b03ba18f-2316-4bec-894e-50e2987a03eb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b08ab26f-5f33-4718-80f8-fcc9209ad200"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b0bfa910-3a9c-4010-8904-a034834dde23"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b0c697a1-fcd4-4c98-8ff7-4256c0c26aed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b0d6945f-cfa5-40ad-870d-f190751d6fc8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b0df46c8-9ea6-4f2c-a79a-928cb85a585f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b0e5850a-01d6-49da-b542-d19d48c6f721"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1031885-3d07-47ea-a874-184a4a8a63d0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b10730a1-6455-4059-99ac-4a6cf4967f48"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b12337a8-e503-4d03-90b9-311bebab6aaa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b12d6dfa-19df-481c-98e2-6d1ad66b8add"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1657003-69c6-443d-adb6-8570d82475f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1657b72-d10d-4d78-ac22-3dbe98c0c3dc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b182ccb0-df6b-43bd-a3a0-9a3005f24ead"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1c2469e-d52c-41cc-a482-981d76ac97cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1d2d6bb-491a-4fde-ab80-d2797428a9ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1d8a696-132b-4b76-b62d-74145ebc36f8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b1f9a4cc-d38f-40b7-90c2-62154dce6f1b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b216dbb1-d420-4c96-ac05-6b3cce159e30"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b228c102-53fe-4c8f-8514-024f6cd2d780"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b2349f2f-24e9-4288-b4f2-24098519d2c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b24b67d8-897f-44d0-b486-cb5424dada35"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b2584877-da03-45aa-b68e-a825edf14efd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b273b44c-a917-4db1-9ce7-23445503703f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b28847ad-3c3a-4749-93f5-d4f2c82b26f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b2bdeb53-919d-4eaf-b3bf-0bdcd84817a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b2ce3796-972d-479d-b10f-1d9d2dcf1754"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b2fe5621-1de5-4a30-9c5c-8fc898024dc6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b30ef6aa-78bd-433f-92bb-712682ed7066"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b3152343-aece-45a0-b550-4421b6e03ee4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b32b6d41-dcb0-4710-96a4-92759b372f56"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b3691b97-76d2-474e-b9c6-0eb4bad588e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b3739c42-616a-4979-96f0-b8c41d86e1f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b3928d95-a5ab-460d-93b4-4d46fb407f2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b3ba51d6-6e61-4fb9-b25c-916479b70f08"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b3efee25-29f5-485c-bcca-6a37e15e133d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4144c41-4cbe-426a-9a24-89f9f8d13bbf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4202390-05cd-4ed3-8b7d-3f9594744f2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b42a9901-5c9f-42b8-b03b-3c0ff666f8cd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b469e77b-6b70-4b01-96aa-3e17e16dc8cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b46b9791-7c6e-4096-ac8a-2e7f34f7c8fc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b47fab5c-f707-47ea-af11-286764c7eb14"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b483bb7c-213a-449b-a3ae-c6c63e2945c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4990d4e-d401-4845-af9b-38afc0b90010"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b49edadb-0d2e-4661-b75c-189a3149c569"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4b2777b-1f38-48cc-80d5-f4b4c01bfc30"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4b4d386-0b54-4f01-b70d-dfd15744f617"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4c22ec5-e8a9-4ec6-aaa2-5147ddc75c40"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4ce3b9a-b83c-4931-af57-3c2aa03f4ddb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b4e14753-dc43-42a2-a3fc-778b0de056bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b527178b-ba8b-4cba-8d45-f6e2b93355c7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b5323369-9145-42b0-9018-716516c0f76c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b54e3a62-56d8-4ae7-938f-5ce48c0fe1a7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b550c8b4-1f06-45cf-9a34-86938296c683"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b57ab3c3-c14c-4fe8-bc66-6c13fbf64e5c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b5c617bc-6a7c-4dc8-9495-a3c181fb4db0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b60d4377-b56a-4e0a-85f1-b23a7cf675a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b61d8509-342e-42e8-96fc-ced9955417d2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b659c34c-f419-4736-845d-77eec170e1c7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b66ea4fb-a32e-41ed-9b94-5ba73a1c17d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b6754d89-7b49-4d02-b480-b3545f055e5c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b6776ad6-f422-4067-820a-3e68cb0cefcb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b67e9c3e-21a0-4762-8d76-de52ca323555"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b6c47a38-1d88-4cac-a24a-8a78583989a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b6cfcdf5-4a37-458c-9669-94ff25757369"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b6fe68ce-3673-4531-8efd-00846e0b67ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b70eb3b0-7bd6-492f-a0e7-1eff574f6435"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b71e4c01-8069-4fba-911b-a7431db9453a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b729ab88-b0f5-4153-bfcf-f1e6a1f81fe8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b76b9d61-6654-48ea-bd7a-542b2fcda4e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b7b4667e-2917-4468-8f3a-793e0d3ac5c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b7bef3b9-85e5-4225-9815-a28b9b1f0514"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b7bf8ad9-72bc-4789-b949-371ac9e805e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b7c560fe-73fa-4ad6-8006-6f147ae81e17"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b7cd4cc6-5567-48bc-999e-f34cc0f95e2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b7fe874e-fe3b-4442-b95c-801c2f9fca14"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b828a49c-efc7-4db2-ba28-e4eb566e23f0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b84b5755-bde5-425d-aa08-e982540adaa2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b880cfb8-7003-4f3f-bab2-d4d0f4068396"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b882cc1e-9508-4132-b9b4-1367ec42521c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b88408a1-2458-4685-8c55-a439d44f9a35"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8c93f95-7428-4cb6-984d-56cef6fe7e18"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8cbd037-9816-4c39-8e01-320f72c76c7f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8d029d5-2d6a-4b6a-9689-d8a7f6cefb49"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8d30267-d9a2-46e6-a715-3d7e4887b762"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8d85f5f-3341-4c7a-bd6a-8e9f8e93981e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8f13e7f-242b-4cff-89b2-bcae5b62b9b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b8fe349b-71e0-4710-9bd6-b560ca63676b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b903aa92-c83a-4690-9a82-6535dfafc2d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b9733e14-0aef-4d73-afd4-38267fce98c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b97947ab-f2c6-41cf-8732-4dd5c864c5ef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b987936d-a44e-4cb5-a69a-5fc67c9669a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b9a90d14-2f99-4a73-aa5b-5506a5a26622"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("b9ec13a6-3a94-44ef-a691-d8b120d28af8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba1e6368-8313-490a-9ee3-d9d3bfdf120b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba2301ba-3371-4cd0-ad5e-c8ff50a387fc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba2e3c47-574d-4e90-aee8-8ab292c878a8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba320666-31ab-4c02-98d5-5d5889c3a8d1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba466de3-bdac-4e79-b9d0-7aab6c0165f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba48a287-32eb-4e46-b0a0-24a9d132a3d7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba4bd798-ffa9-4689-9cb7-8393ff087ee9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba4c48ef-2689-4f94-9056-640fbe5a7cbd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba514b41-421b-442c-83df-85ae6e533c91"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba728c1a-00d3-4257-82b5-9e6f23f6e3b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ba7f77a0-6a01-4c43-ae26-9ed100149fb0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bacee893-9dd2-4508-8642-f6ea07241d63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("badc1a7a-42fd-4a9c-8f5f-8c64a2afd68d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bae1bbb1-8607-42bf-8655-4d1c055af59f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb2b7621-5dbd-4582-99e3-ab74c49aeae1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb43c584-d9ac-4386-b722-f9930f8dc0da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb4ee73d-e0fb-490a-9926-b1a977b2debc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb55444d-7e08-4872-b7f0-8afa84ae9ebf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb60bae8-6643-4102-9458-7b0a2af0a88f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb68bb25-bdac-49cf-a8a3-0f09925a632f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb79fda8-370b-429b-9c0d-efa852a3322e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb889e3b-e188-4799-be2e-77d56226c006"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bb9cac86-dbc6-4986-aae4-3274ae3cdfae"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bbb8d7d7-14e9-4e1b-8d61-4db98a640949"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bbe1e463-62ae-4d2c-950b-1deb1ea53e46"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc07125d-07b6-4e4b-aa7e-0a07c35edd67"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc0923a1-9238-4dae-a603-a9a3d530abb0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc249837-bb1a-4a58-a8a2-449741822610"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc32a7bd-2362-485d-859b-290549dfb6f7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc526d1f-ab4c-437e-b384-5841a994641d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc5b5e99-b527-4586-ac0d-0585cbc6a129"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc6af5dc-d971-4b60-b0e6-8c362d400add"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc71bf46-f935-450b-95de-231269204400"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bc755ac5-ea6f-4b84-8306-79dd93545891"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bcabbf28-5091-4d23-901a-e4592796ce49"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bcac4dfd-e6c4-417f-a0ee-0bdb5aed9ca4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bccdb109-af88-4868-bc4e-03940801a571"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bce7dab4-8fd2-456f-afe8-2cc062cc3475"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bcf2cd34-5a3a-4c7a-92af-cb31ad5fd2cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd0a015d-fb83-4455-a6a4-3714247f1987"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd1552d2-f9bc-48f5-a92e-396ed24d61d4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd1c5ea6-a5b5-4542-bf4d-47479cd02f8f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd278e31-7ae9-4139-b66c-e816335f60eb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd2b2000-d36a-4996-919f-e49b25a08929"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd336eda-a2d9-4cac-ae9b-72dc8c810526"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd5cd382-23a6-4cba-8aef-2ccc3b3e0b96"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd659be7-894d-4e4f-9269-c6c37d1a27c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd7b1b10-f0f6-4124-abc9-25783c53a320"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd83c7a2-ecfe-4029-a256-fb0033e940f7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bd8c5bfa-2aa9-495e-950a-1d4b75e9d1b7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bdd0952f-c326-4a75-862b-6b265d9d446c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bde4e103-8555-4126-9c40-00405c0fe550"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bdf1337c-eee8-45d4-8743-557ab51c3f7c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bdfb333b-c4a6-4484-9430-619f4a0c4bb3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be228bc3-aab7-4d50-9a79-5e9e6e3ff45b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be29f1ae-9802-44f2-b28f-4340b8484ecb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be31b12d-f0e3-4ab1-8b07-3bbe85b62308"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be5f9eaa-7bd8-41a6-ab01-5466298782bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be73ad6b-438b-4440-b7b7-6a12dbe1b5c2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be740b72-d559-4985-ba5c-6cbc25974527"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be8239ee-d103-47bd-8fdb-907b168a58ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be84e7b3-e715-415a-a158-da83dcf9097b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("be9fa7aa-b89b-4706-8e8c-63fd37cc026a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bea71f8b-4b9b-4587-b14a-c5990e364920"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bec1f087-7f57-4535-82e1-ee8fc7a13e33"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bec8f70a-0fe7-4620-a666-17c06ed4f509"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bed880b8-124e-4610-91aa-288fed624e35"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bedbc9ab-36c8-4251-8e5a-104d9b467001"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bee1b28e-41c5-4711-a933-4f4babbf0daa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bee4dc59-b84b-47a3-bc5e-a22cdd6acf49"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bee788d5-8a86-4f38-8d20-28d826c229e8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bf14e83a-6a18-4853-858c-69b467421247"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bf718afb-9d92-4241-a1b9-0c4cd69835ae"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bf8c8e34-7805-4b05-b155-a017576f7dff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bf994736-e53e-4122-bd20-1a6c156ff5d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bfa2a137-9379-48a1-9540-e4505e287020"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bfa54c82-3d02-4e11-a78c-504d950847d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bfd4ca4c-0dfc-48f9-b403-115955de46c8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bfdb0501-41c2-43ca-8825-b78e012e54bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bfde84a5-1d8e-4845-b8d6-eb66011ddd07"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("bfe0474d-b797-41b0-93e5-80d4dde5dca6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c001aba4-6afc-430d-af9b-c396abccff12"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c058afdc-ab96-4f3e-bb79-f44532c6b3d3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c05b6470-4642-487d-995d-9171495cedb7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c063e8c0-c908-4f72-8005-c8731d9b4a12"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c0888ab6-b5f6-48db-b649-7afe26d3be9a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c0a827ef-d0a0-4a27-851b-489f43096944"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c0cec6b3-ec70-482c-8800-60766137a81d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c0d68237-9a32-470d-a9f5-bb41d44e09b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1044d3a-152a-4178-9074-0601a5582b7a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1492135-6400-4fcc-8f38-b3d62e611568"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c15939fc-0363-49d2-8aae-eecc452c32f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c15ee3b5-6dd1-43d0-a279-97d3d512c1c7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1606d29-5c3c-4a8a-b07a-fe71ed38f520"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c16e14fe-360a-4459-8623-3b5d1b2a3496"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c171f4b6-4892-476d-9234-f9b85272bb1e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c17702d5-687b-41a6-b57e-ebd54a994ae2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c17beb91-cb03-4052-9798-b201a6b3e21f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1c4685b-4510-4db2-b172-0aa84e13d2de"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1d2ce44-0c48-42aa-8930-595f3f26da44"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1dd56e6-8218-4e03-bdfb-ce5d0fe276ae"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c1e54952-a179-44f6-aae4-fd4f9a3f3358"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2087797-98fd-4ef3-8156-1b63749c1ba7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c21c4fc9-9a28-4590-855a-ff99cd27e594"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c284244a-63d1-41dd-bf73-43210073c88c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c28866d0-fa28-4798-9561-4f9679d708e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c28bfd2e-4232-45b8-90fd-49294a4032f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c295008f-cc37-444c-b09a-7dbc643da034"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2975546-2b49-469b-aad8-423dfa378df4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2a2e4b2-937d-4b7c-a04c-07870883aa7c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2be6365-769e-4eef-acf2-4164ec108209"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2cacab5-3840-4db1-a95a-e2aa3274c368"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2d475e3-d1f1-4280-8ff7-7927976d7cb4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2ded2dc-983c-4800-a175-a2ed3793e0ad"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c2f6af01-8d5d-4a1c-9ecf-7e608d0c0669"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c308347c-774b-450e-addd-ab7133c5fe57"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c37e0f13-cc01-4166-81ca-376163f2c6aa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c38fc5dc-5326-41e7-a06d-f9ac802aeaf8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3a5a355-d433-49a5-bdb1-e62323f64c2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3b73973-337a-4de7-b855-115b4b367ac3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3bc1b2c-5f55-4324-b5af-1619b1185da6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3c0a42a-354e-4fae-9094-501bfe473f5f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3c948c6-dcf0-4645-93dc-4c7d24733015"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3d3906d-d5a6-41c5-aa38-9ef332cfa3ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c3d6b875-c01c-4996-b0a0-b0716ca2a497"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4006591-da88-4106-b5d3-09f325e8468b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c40a27b6-0988-4ea9-8f11-016cabf1a699"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c43eb7ad-da42-47d3-ab14-1efebc0ba119"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4479850-346c-44f6-94ed-59ad7f1efc97"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4816dfe-7d5b-4714-ad37-796b3e6f79f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4a9e53b-3c2a-4595-8fd9-27a621bf410e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4c36985-7dd9-4cfc-ab40-8b2ee987fd3b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4c895c1-d4c2-4642-a40c-4327b0fb480b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c4d478a6-33aa-43ff-96c0-d85523f03645"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c506ffa7-84be-4b1e-a471-891506cab22c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c5261e6a-6aca-4afe-b780-672ead1b403a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c5593510-e766-45e3-9813-3214c224a3db"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c55d4e6a-34e8-4462-a92f-b2b37dd1d1a3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c55f64d2-d0d5-4364-bd89-33c337acee0c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c56deebf-3393-4ecd-933a-3ce335a7c437"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c5946e79-b62d-4088-a36b-4bc42910e30b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c5952fa9-86ce-4b9e-8d49-28b6c4d43ea5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c5b09c98-7906-4980-a0f4-f4945446f80b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c60eeffc-362b-421a-9a97-93d8ef3de248"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6431623-e12a-4a6a-8024-66c0717d91e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6461af0-4dca-401f-af15-3f4f91291b89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c64817c9-65b3-452d-b59a-9fe4b2529985"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c66d992a-5c1f-443e-9c17-5da786444d62"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c683f6d7-8125-4d90-a091-6ca76e48b960"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6868b7d-f6a5-40f3-99e4-eabfd9f06d3d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c69868e6-4fd4-4a6b-b918-09b662802001"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c698ff5d-309c-46c7-9174-caa3dcb0f689"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6adb4ec-36da-4748-b495-4399caff8d89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6ae5146-3027-48d6-954d-500c07a21c94"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6c90308-f9e5-47ae-a44d-bd30755e0c49"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6ced219-6409-45d8-a505-c8b82e0080ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6d82a57-a752-425d-9b94-c1e39665209a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c6f28f43-1ae3-40b1-b192-6efdf95626bb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c700bc42-0d08-4bbe-918f-d0a9809062ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c70b5f1e-98bd-46ce-a358-a0033930d97e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c70c534f-1b92-42b2-8cee-291d4eec52c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c738e858-e6ce-459d-8b81-18d3b6822d80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c7616c44-c6d4-4161-ac31-043042ff6c63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c7fea4c8-f331-4f93-a2b9-c35625390506"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c800c147-c93a-48e1-952a-d434e6615641"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c808efd6-99ee-423a-a791-f8f0211a3c2f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c83061e9-7592-4f45-a0f1-f3a813aec6d7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c84caa81-5f0c-420a-b355-e1ae61e9182c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c85270eb-6212-4f26-9ade-8b3ecd64c36d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c8587c3c-f518-4cff-8857-cd7abad89a2f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c87b44dc-a3da-4fbd-b45b-f37eab0ffa61"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c8939179-c834-4e43-8a3f-a87e53a022c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c89413db-ea02-46c8-8f34-db5925b52f4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c89a3d3b-d959-40d6-8289-8c3328f354a1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c8c7a900-8a7f-46ef-a0f4-20cba7914456"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c8dda3d7-01e1-4eb7-89a6-08f3087ba59a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c8eff02c-a7f6-4f72-b4a2-834e35ed323d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c91ed626-7aef-4149-be6a-4949eeaa1c20"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9598b2f-54d3-46bb-a970-75a205ee8075"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c959d505-51b5-4b11-94dc-b9d497ab63d6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c98ddd52-5eea-4b3c-bfd3-a9eda5f39842"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9b23e33-ae61-42ac-ace4-ce00fcfb6b96"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9b65f83-0a00-438f-8b82-4b02ef776750"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9e41f78-e985-4cbc-9192-847f3670a101"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9e667fd-ee4f-45d9-b29b-1f678d719a8d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9eaa994-a66c-428f-af85-83e710574c3d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("c9f27fb9-d605-4d23-a762-ca94d7849917"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ca1b2433-904f-4e28-98e1-aa70405a7474"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ca24face-a91e-454e-b45d-113f3152aeca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ca329c0b-b1af-4e2a-afbd-49857d8a4fa8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ca49cb64-422b-44b1-b8e8-ecc2fca91fd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ca76fb90-37f2-4fe1-bee5-4896cc1bb9f4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ca97131a-3dc7-49c3-b9f3-a5633999ad4e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cab0be31-710f-4453-9c0a-a95f001f29bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cab3cade-6ec2-493e-9436-78dd752a774c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cad5117c-d177-4a06-88a6-474e5533e1b0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("caf9c6f3-ea8e-40f1-b85c-01ef19b3d4db"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cafdde4c-0c49-41f9-8ce5-b7c785e51477"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cb4b0982-b3c9-4053-9f92-09e29a751568"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cb6fd765-6b25-4761-a2d3-247ca8c1fe72"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cb78c279-6c72-4c7a-a232-be044eba3a18"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cb7c5a03-432b-4c15-b027-04aad8fdc842"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cb8fd59b-9232-4fa4-8b6f-17e0ed1adaeb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cbe3760f-6a74-4681-8e29-40263486be61"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cc136c17-9699-434e-9747-c0d3ee117fdc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cc490bf4-3e2a-4f6b-a802-9431b87460fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cc49caa2-66c1-4e8a-9c05-3e9f8c4ddcab"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cc51942d-d616-48be-bc50-3ed24fe10d2f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cc9eee1d-a029-4e79-873a-2ae03a76a1d0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cce55bfb-44cc-4aef-a640-e0686e0c82a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ccf4b288-0e2d-42c0-b16e-a8fe978c7d6f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd002fb1-bddb-4ffe-9aa4-15d04069ef3f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd1ee7d5-c15f-459b-b0d4-bf8c9a78293d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd467fa4-b3ae-4bdf-b465-f2be80dadc26"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd5f274c-0b93-4333-934f-883a8e6523f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd68a398-9438-4aa4-8292-24bcf5ab6c27"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd7861fe-79ec-4729-9306-8b1480f06327"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd7bad4c-47a0-4944-8377-2ac40bfebf6c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd7cc57b-ac9d-420f-8ef8-a4835a752579"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cd8af45a-9b56-4894-8698-5a62df2d6c29"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cda07d5f-1d1e-483b-93ad-d6a84e669acb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cdb590c2-3c6e-449d-92d3-b0f21cc24839"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cdc84906-a836-432b-8035-425016a554a5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cde73af8-8e36-49d4-a0a3-c58019b547f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cdecce16-76c2-45a2-bbec-40b94c128191"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cdfd00e4-a586-4db9-a9b2-d97a528366ea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce2008c5-8c27-4f21-b7dd-dcd1304a00ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce27ad8b-dd00-4032-9987-ba0427a4632b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce3b191a-ec8c-4d56-8de3-9643836d25ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce3c39d5-2674-41b7-aea6-d063ad7cf546"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce55d3aa-a370-4a3c-8662-e5588180dbef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce655eb1-fea9-41f9-be4f-a85b2c9fe2a7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ce99833f-6f27-447f-a01d-ce95810e7db6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ceb2240c-16d3-49b7-84f4-dcebecf92574"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cec28ba8-56b1-4ce2-a6be-fc7b914dab52"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cf1ed193-8faa-42c7-9357-9825eb356cfa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cf4933cb-632f-4c78-a7a8-be90a9c82486"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cf814b2b-84f5-4011-bd36-6ea8209b35f8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cf8390f8-5b01-41ce-9f21-c6f387386660"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cfdbd4ed-3bf4-4dc7-b688-2e592c305397"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("cfef18de-2e8a-4906-9627-7deaf4a4f5ea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d00ba8ed-74d7-4d9e-b516-0964f1d5cc7e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d01225e9-6001-40e2-ab2f-2c2728fdbc41"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d02a312e-0c18-485c-8f66-b932ce4315fd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d032d5dd-58bc-4898-bb06-07ad9d4a893f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d0389acc-3a00-45b9-b0b7-6841c87052ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d03b19f1-490d-40cd-a5d8-6e263420fddd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d03ba1f5-d3b2-4fb4-ac9e-be76a05ee35a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d03f6c38-f912-4ce6-a1f6-54d6005722bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d04242be-71f7-477e-9e04-db47b19dd110"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d046e35e-fa68-45e9-a69f-c195db05ec4b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d04daffb-8d70-4361-85fc-d3ba9ec683ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d064e6d7-130a-466c-8acf-12bd4e26336c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d090c3bb-bcd6-4c0e-8a6c-8953bdbb8bd9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d09a6de3-211a-4626-9a68-6617465504ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d0e12eda-e122-4906-8d8f-379cf2a9392f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d0f2321e-73c2-4f6f-b489-f01b1ef67853"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d1054703-f7d5-455e-97fa-e80c042a1632"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d10761bd-f458-49dc-95e5-a0d98251326a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d10a72e9-7a34-4608-9adb-c7739d5838bf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d127bdfb-24ec-4af1-b329-30ee67c58e95"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d148a348-f468-446d-9560-a2bed42dee2b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d15aacb0-813f-42bd-a446-a53875979003"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d1709b9d-9ed0-4095-a92d-1381c3a0d4dc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d1772e15-6281-4d4f-a7bc-155496d5b0a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d17b1ba3-7dcf-4758-9902-36bdad7863ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d1816026-5bc7-406c-98b4-244b4bf9f19f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d193e3d7-33c3-421a-826a-4ca1909b84df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d1da4c8a-6efc-43f1-8b3e-542cdccb0a0f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d1ea5c7e-1d0d-4358-93da-444cf724610c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d20013d8-382f-4d9b-aaf7-13585940b8ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d20327d5-1e1d-40bc-afc1-16ff0ea9eb42"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d20e16ec-047c-4552-97d6-ae5f7ab01475"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d2352a2a-ec2a-48e0-b302-232c9d9e7bf0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d23f1bd8-250b-46a4-8a90-d45f79d59dcd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d24541d3-2c94-46c3-99f7-9f91a6c3bed0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d253d419-2a4a-4a84-ae82-97f1690804dc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d25ae670-057b-4b6d-8807-c20162b92b43"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d277a599-40e4-4943-a543-acd99abbc3b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d2925109-1fa0-487f-a386-0380ba6264ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d2ae4f61-81b7-4375-a9bf-d6c49c7f69b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d2af468b-b80d-4d60-bdb8-9edcf949bfe6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d2c0dc07-77fd-472c-892c-295560e8deb9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d2e1daaf-ef09-4715-bc7b-721a0034e39e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d3101b51-118a-4623-8f31-31773fb5df39"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d32321b7-eceb-4b13-b3a1-08f0d5b7f7c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d32fa6cd-18b4-4d77-bc9c-954f02dee719"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d336ecc3-3515-4c6b-a4ed-426f3975de54"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d33a0b7d-963c-47be-b033-c06f79962f32"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d3442dba-80f3-4d3c-ae5e-af38b063c4f0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d36fcb74-db9e-4dd5-b2bb-80f827cb19a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d376befe-431e-4509-ad6b-f7d4ef544888"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d38c2164-061c-4870-8fbe-8633c0967bc0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d3b1939e-e1f8-49fd-a51f-8344a8b01766"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d3b73047-1a8b-497e-9360-b18a8b2a1186"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d3c1b004-1470-4844-b84e-78654c8831dd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d3f78f2f-95b5-418e-a77d-04b24bf21cd6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d411b748-5f6c-4c75-bb97-6c64bec1ad11"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d44afb59-76ff-484f-9806-9dd24f8aa4ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d45ab8b4-1ce5-4d2e-b98b-1066083f8f2c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d4bb3598-d807-48b2-9a43-728b94fc5eaf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d5325e13-1bbd-4094-affe-8b873d43a056"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d53f525c-df00-4e6e-ac5f-e975b639b1c5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d55ae9c6-33ad-4e4d-b9b8-e83bfd16626f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d560e503-f411-445f-8d87-1b26e57f76a3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d59641d6-0e41-477e-9112-d89dbef1155a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d5b72d59-5552-460f-b554-139ec80ee44e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d5b7d56d-a449-4ef4-a013-06bd4d46e74f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d5ced50f-6de2-40f3-9ec4-0909a2c646e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d5f7b993-558b-4b12-b6b1-5da3158ae34d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6557d0b-2f78-4bde-bd83-ddd2546a17a7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6694328-4cb3-4ab9-b372-56d6752a086b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d683d156-4ebf-4cd9-b82d-9f27dfde4e8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6894a30-cba3-4132-b114-22bd689df811"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d68d5fa8-5000-4ed4-a58b-a0e3928a094b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6bc3ecd-3d65-4920-af07-8e837a96679b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6c2d899-eb45-4f16-8546-93dcdeea370c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6c44efb-e2d4-4398-b1c3-999abf7e0219"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6d662cc-ecc4-4fb1-bdee-e575708e04da"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6f2abf1-0343-4b67-a304-f15eb141d7ac"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d6fd5d5e-6c01-4f87-8e1c-03bcaf22062b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d707b44e-1759-41d5-9fef-b9d56e4cdf7e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d7187d06-12a7-4cc2-ad77-ba45c12b22f0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d72aa4dd-2ab0-4e54-8cbd-9964ba300df9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d73befc5-c8e3-42e2-973a-bb4bb1384cf0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d73e5b95-8747-4a99-a872-de1fd421f050"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d73e840a-1284-4626-b766-46652c459403"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d753793b-d53b-4a67-aec3-f9d4f0fd3360"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d75507c9-b207-4e60-9a97-6c3c925d34f9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d766cdaf-828d-4c21-8c73-5e853e4f0600"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d79e5b5c-bf1f-4fb9-9316-b3190c60844d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d7ae631d-1ace-4290-9322-b913acb43f8d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d7bc76e0-6862-4b89-ac93-ff384fd39999"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d7d31904-0c6c-468d-896c-4934c7210355"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d7d4c253-349b-4915-b89b-18158a9e8567"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d7ff6d5e-439e-4484-a02a-afcade300c05"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d87455f9-726f-42b6-bda0-dc55292901f7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d87f2929-1b86-4bb2-a8fe-9f3447d4bca3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d88b4a6d-2e8c-4e65-a64b-d9a6c371cee7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d8ece687-df13-4600-a9db-736b2a5944b7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d907931e-0701-42e2-ba81-5c09bcd0cad9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d908f5ba-2585-4ea0-aa38-3b1193538e12"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d94b67da-4dd0-4f1e-b51f-160c61b5553d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d987d08b-ef3e-4366-81e3-8041584d5ea4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9a8647b-67b2-402e-b788-6899636e251c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9b164f3-2550-4e9e-89c1-5b86bd723a0e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9b41098-f4b9-4f8e-a651-ad5a29d3c5c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9cc3ee5-782a-4c69-8e04-ec2294b38d4e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9d4c1cb-977d-4b6b-97b7-79aabd6b2f9d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9e22126-18d3-4ec3-91a2-3c2f48c60522"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9e8f493-42cd-48a9-b9da-4a4e967ac3fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9f5113a-197f-4a8e-bebe-9b19d464509d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("d9f5e780-c231-4190-a40c-e7c594389b3b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("da06cb38-ac4c-4383-aed6-c63ffb2a733a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("da0b9c1c-2e08-48c9-8b87-9f43c54cb91a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("da0c11fb-acea-40a2-9b0f-9acff6990ab3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("da28b730-07e9-4ba1-b358-6ccaab972495"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("da43ea0e-aa2e-49c7-92a8-b58be75e7569"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("da82a4a2-43c3-46dd-aec0-75a505c14ccf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dad0c734-dc62-480e-b397-51c991965c10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dadc2d89-7ef3-46f9-acea-6e7d15bf67ad"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("daf0f5e8-3d46-45d1-9ad1-d9c8bf77c977"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dafc43c6-f2c6-4b4d-8652-3174971eaed1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db27bfd9-7e07-4053-984a-5793e19fe833"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db2bdce9-299c-428c-815c-3f66be9142c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db40c9c8-56d0-4003-ac6d-39c20a8f43d9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db675629-7f67-4223-9395-50587464e386"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db6bd6ea-888b-4eae-8937-00849cbb7229"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db7faf51-b6ae-4799-9036-119ca2496ab3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("db9ed22c-2326-48f7-b892-f3064989ab34"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dbcb120f-129f-4fd8-ac47-1da27d5435e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc0bb3da-fd0b-4123-9b3f-a1d5ef1fa89d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc1f7761-c884-4335-867a-397486ab5994"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc28bae8-d43a-48c4-b267-3cde3a20bde4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc35f750-b064-45c9-98ef-1aa2b2dab3dd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc5d5bdc-8d67-42bc-9ee5-3d1c53c75c19"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc62de45-4c6c-4c87-a5e1-a90cf929914a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc66ae9f-d44c-414f-998f-52b172c341ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc81c874-a404-4b5b-9b07-06e0a924b4f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dc87cc0a-d1b2-466e-bf87-f36bedbe957e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dd11c065-f9ab-4c80-84a2-843ae017572c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dd67b17f-c940-4a5b-ae8d-7a1348d23cf6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dd9547e0-cced-445c-b9ec-42083ada0457"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dda4c7d4-7975-458b-bcec-48b4ecb129e6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ddac2acc-3199-48b6-a1b5-c6f2a3960923"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ddb60a43-7f0c-4017-a53e-2e23ed9ca9fe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dde9020b-64ea-4ac6-a23e-17fa58b34ad3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dde9477f-77a2-46e8-aa79-5ac6e1f1228c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de18cd39-9940-4d19-84e5-f6db5ddc07b2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de1d135d-7f62-449f-a24a-e91ab8e03fd4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de2946a5-cbcc-449e-badd-c78b55c5dd0f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de40d4e7-ef07-4498-b4de-0a2b42df610d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de6513f5-1e49-430c-9751-2429763ec6f5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de94703a-e3f9-4fe5-b38d-b7cd5cf5f6c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("de9e5312-797d-4d55-8389-a8581e8702df"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("deaf1663-3e88-4fd3-bd78-566e12e33708"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dec548ea-d2be-4a3b-a8f5-955bd724c3ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dec67d3a-370b-4795-a8dc-5565ec022f0e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ded62c45-e10a-4f79-822c-2f63a2e8b31e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df0d565b-0b28-4413-aefb-452802fa2cdb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df26c5c5-6e15-4cc8-8c25-27d7878175d0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df295207-e6c3-4d17-babb-c5ff2a5c0add"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df366f50-f9fd-46e6-a46f-39ab25f050b6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df44f9e9-a82c-44a2-b47b-bdd17d3fa92d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df7f789a-b9ae-4e73-929a-a3ba262e6de8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df805527-4e7d-40c6-9b54-0d417b752ac9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df84acb1-7573-4e69-a1e5-6526ff35b04f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df8887f3-6346-4e80-9b24-25f44ab70f10"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df8a1799-f159-4e38-a3f8-d80275003e4b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("df9c4b9a-beed-4483-b3ab-d6c862a04c19"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dfba0dd6-e85b-4fb4-a98c-12662d9edfc4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("dfdd9d31-5512-4a15-ab84-ff8ad4e31e79"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e02c1df9-5e29-4ed7-8cfb-cec4ec961ff7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e0721f85-9038-46d7-8055-24f367b196b3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e095e572-3266-46e5-ae57-1ca001705369"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e0c6c706-6eb6-40eb-acce-c20ff7819def"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e0c98bfc-76e7-4d28-b793-da505dfd5001"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e0cbca2e-db97-4a3d-b505-7685d49177a5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e0d7f0da-aca0-4fa8-a6cb-09fb78d3ecfc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e10194ed-4bb6-44aa-96a7-d331d198b63a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e108450d-e0e4-4581-be8e-478321699a6c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e109d05b-7dba-40d3-b1c6-35a36a45790a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e1102777-f884-442c-b74e-78ba08a5b39d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e11f415f-f1b8-4684-9ead-31faaf5331c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e13f8807-6431-451c-926e-3ec9b6a7ef9b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e1821c94-1a8a-49d6-b9cc-aacfdac5557d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e1900437-b9e1-43ee-bb88-f137e16867f7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e1a39264-fedf-4900-b01b-562ec906f6ea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e1c0804e-f687-4866-9bee-651dabb6483e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e1c7ee43-d709-4460-979d-d16c717a19ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2114374-e431-4a62-8448-4689ed28b983"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e215c2bd-dfac-4c38-bcfe-d109008cd74f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e21ddcf1-6a2b-461e-8f2f-cbc99ba1a967"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e223d94e-be41-48c6-93d4-e042a69954c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e224a9fe-8863-46ea-a930-2a8bb763e2a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e226db5b-affa-4d9d-b208-5f9b45b74df5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2290446-a787-4d5d-acad-004ebe73c6e0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e26bf986-6888-464f-a5e9-f7aed837e8be"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2815e11-2df6-4575-bb8a-756e8a91d4cf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e28c5e63-5c7b-47ca-a26b-3c6d4d57d2c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e29d5b78-c52b-4242-b60b-eb2134a95db2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2b91bfc-5ad8-4d04-88f8-14c9741e3067"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2c005a8-c1e6-4fbb-8a48-09d69e41b0ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2e129ec-46b7-483e-82b5-ab633b977c8c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e2f03092-664d-409a-9583-1323085824de"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e3077391-3dad-4cb2-a1dc-fc4df23307a9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e31264b2-8de4-4e58-a897-4ab20c009e9b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e3157f9c-4f18-4c19-b91c-286b1f8b9686"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e3248f73-29e8-4590-9c19-11db00672518"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e3369034-9d3a-4e22-b95e-a7b70f7e8315"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e35f9c0e-0116-4d83-a684-7a5959ec063a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e36168f1-3e77-43df-97db-a0edbb8f2e24"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e394efca-691c-406d-8240-3c8403327b19"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e3ae432c-1d42-4842-9c61-be17f9a44576"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e42d6920-e444-4fe3-8d16-c5726cb643d3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e42ec9ef-723d-4a79-85e4-24b77782223a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e46459bd-974d-474e-8fa3-b7b9d04ac944"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4979392-7ad4-4860-bc2c-6329dd909166"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e49afdeb-14c7-4237-a836-b77c6cc88378"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e49e2038-680e-480f-95a1-81124e090c44"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4a62760-2399-4c24-b2c5-12ac87d1d2ab"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4b2bd60-b4b8-4e00-9793-cbf600d95734"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4c0286e-479a-4749-80b1-b609eb3c39bd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4f1a2e9-cc3d-4870-9674-ef033bef5b63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4f7908e-fab7-4d38-a15a-8801c802cad3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e4f89c24-5045-45ac-baac-0bb0e2e90026"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e50a7cc7-5e16-46cd-b88f-42bffb6dd7d7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e51144bb-a722-4d26-9536-604d0517d249"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e519994c-ddc7-4cb7-a37d-2aa5aedf4c22"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e56ec019-0539-48b5-b970-2364c89ab0a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e583b0a2-05c5-4ab2-bf10-8671ae327dfe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e5a7c6f9-4e9e-40ba-ab66-554926f2724b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e5e8061e-69ff-43fa-aa4d-825bd41106bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e60d08c2-bca4-407d-a973-b0803d5d8da7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e65a6666-0944-4580-841b-870771543422"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e6bd2d24-dfec-4955-b35d-af3b090e0ff0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e6df0391-0cb5-4015-883b-e0d5c598fc14"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e6fc4de5-8dc7-4964-b0b2-27fec00756e1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e70fe5a6-fcf2-48f3-b27b-8cfd1a366ab8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e729286d-7812-4f3b-a9c4-9f7cbb6ab151"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e7639f5c-cc51-4288-b245-9bdd7310842f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e779941b-62d6-497d-824c-061d021e34c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e7818ef7-5d3d-4190-8518-dfc7c90c68c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e7e4cf1b-92ff-4287-b675-470e68265cca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e7f389fe-8189-4579-97a7-94af5825293e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e811bf1e-86b9-4910-ad25-72584c5db21c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8199267-5963-4e4c-a367-18a5f463f05f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e84360a5-0515-4cc7-83f9-c866ba2b310f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8436dfe-ed5a-4455-975c-03e918383ea9"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8500ec0-f405-4c40-b867-b7f79c8c259b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e86adfb0-3352-4241-903c-243e7a5d7f79"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8c7f88f-4915-4a88-a79b-a7c325ce585f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8d1854d-9d73-4c5c-8cfb-616a2f738103"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8d280e5-9943-4aa4-9a6e-63b8cce5e414"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e8fe7ee5-f5a3-48df-99b4-fee8bc3b82e7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9090fbd-dcb5-4834-bd89-85cfa38524ad"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e934b41c-2dc9-4794-a16b-4ad5bf7084bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e975e0e8-732c-46d2-8693-da782924c8bc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e99222d3-c479-4047-abc5-90071854cf02"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9a0c9f0-73a9-4479-8882-39b566aad97a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9a36ac5-921a-47aa-b86f-76d5a0a1c801"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9afa527-2f11-4e01-80e2-93e81898ef2e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9c1ec32-18fa-4e81-9992-b54af981a506"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9c77196-2db0-4810-a29f-c692aeee3c1e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9ea98c0-c0be-4fa0-b491-6babf25c9002"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("e9eee8f9-5904-48e7-8890-7f229ce0ad1b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ea0f47dd-4176-4df9-88a0-13331ef9c411"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ea0fc1e2-763d-46da-8d6c-98c3993cebdf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ea23d48e-1fea-4781-befa-f1a79289e8e1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ea41a364-b53e-4baf-a3b2-af4796d2935f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ea4778c7-89f4-4df4-a332-012f5819955e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ea678b72-39c1-4bed-b080-1c0429768788"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eabfddac-2dea-42c1-ab9d-d64b26cb0233"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eac51795-ba2f-4669-961b-470b0a9ccca6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eaf1aaf1-16af-43f1-9b7a-202a7ce9b473"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eb2a8f51-52b4-4719-8a6a-3294c8225507"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eb2ee424-20ec-4cb1-90eb-af7061252789"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eb418122-3b84-4a86-9092-6d3402d75a00"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eb5fdcf1-79bd-4525-90ea-7dad9e075710"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eb917e3d-abc6-4a80-a24c-f822261e9c5a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eba97c35-33a6-4f66-a6c1-47aac7c33b4e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ebbdba33-d983-4605-bd6a-92766dbd4afa"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ebbfa279-36e8-4869-8992-47afbb83b0ef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ebe19948-63c7-48dd-8293-74b0914f13a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ec2020da-47cf-4f91-9ec7-0c05d4ca8ebd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ec2efd79-aa09-4b4d-a657-5065b9a4be7e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ec475e29-1bdb-40f8-a5e5-919ef6782b73"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ec59152d-aee3-4ed2-8b65-404d762e3999"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ec5d722d-825f-4ded-8a6d-e4777da00830"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ec921c25-b1af-4439-8f69-4139926198b8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eca6809a-e67c-436d-b4f5-8f1bf0553f53"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ecaa2d86-0135-4b95-a2ff-54e62f4ba0c2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ecae1fae-1306-4f45-af2a-97459ca3903a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ecaf60bd-0fb6-4d16-8a4e-a87a1bc8ecfb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ecf8ef9a-aa6a-4b96-a09c-a9a02965e510"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ed1276e7-1bf0-4d22-9fc2-12bfb53b8cfd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ed3ef6d1-f3aa-4aed-abfc-3cd4abcae532"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ed80a09f-3978-4b50-a749-db69bb9edf46"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ed9bac6a-f23b-4778-ad55-ad22de3a703f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("edaa0931-b346-4145-938b-d545296d3273"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("edd38e51-f269-4db8-b0c0-d692da44ad14"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("edd897c3-728c-4864-88dd-6d6ab2a3b40a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ede7490f-8c99-4a43-a2e8-25d7821997ec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ee3d857a-4e72-44db-ada1-777a73394f80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ee470297-35ca-41b6-9037-91ae3930ec6b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ee74539f-3336-4813-85ff-5362b4ef1796"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eec139da-64a3-4043-85d1-01f18bd5110f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("eee5f76e-1b6f-4b3e-8572-8d037ff83531"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef01041c-d35c-466d-ae21-4659b2c04a9d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef129a73-c8b0-4bc7-8d8e-71ef435de77b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef140634-68bf-4b95-9b8c-b7fc2a4966ff"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef200522-2a31-490b-857d-75da47f542ca"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef26cda9-3cb6-4ea6-938e-733aa5f4bfef"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef2e5329-e2a6-48c1-b868-39a57102b1ed"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef538230-db80-4f5e-b8bb-a2791c805088"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ef7e8025-f18e-45ad-897e-7baa16c8cef6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("efbc7521-aa45-4788-8b7a-f3a51722abbb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("efc11ef5-cd9f-417b-a5ee-d77dd9e6ce71"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("efcc07c5-1f4f-4d3a-b809-c33f7c89a6eb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("effd661e-4cb7-4c7d-8037-ea09412ab8e5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f0227ddc-6538-4fb3-bdbb-8660ec851d8b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f02e9671-2fda-4b76-8376-d030f3dbe621"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f03ff5b4-597c-41e6-9780-ac7b31ef17ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f0422c2e-6b30-4989-9d09-dd5f31fdba4d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f0577298-98c3-4fbf-b19f-7262f5d79721"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f097a074-a44a-4376-be2c-03f442bc14c6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f0a8309c-1dd9-4eee-8c45-99b2c82ea7a2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f0af756d-505d-4a19-af23-969949fc37d1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f0c65314-3be6-4bf3-848b-5c0388efc3fd"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f101ea4a-05a2-40f9-94bd-d3f46fde16a1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f1032db2-f7b8-4f96-8933-54920e090f38"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f119b73d-c149-49bb-bcab-87db42d35a47"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f1379d7e-644c-405f-961f-7b980a21d362"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f13d716d-a3fa-4ec0-8598-9e2004cc47ba"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f14d2474-be83-4156-8c05-137a15d4fa06"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f1788b47-0594-4e5e-8975-55490137ab13"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f193930c-bfe3-4ac9-aef5-5d567bac9c33"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f196b36d-476e-42cc-ad45-a9a5b1f70015"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f19ee912-219c-473c-ab27-876d7d666433"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f1b0b514-0255-4a48-bc00-0034169785c5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f1da103a-c3b3-444c-9ac5-eb213fa5ea5d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f1dba031-be87-4530-81a9-18f120a2221f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f200fe17-bd56-4591-af39-f51854fd3ed1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f218bdaf-d2d1-4622-ae5b-445875b7b27a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f28ba277-c090-4276-a34a-e09ce08c289e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f29e50d8-6c9b-44e9-acdc-4f51469cc606"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f2b5590f-64b7-4fb7-a2c3-46dceed80805"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f2b7ba04-13c5-4189-b8f5-c61ffcda0177"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f2c549e8-1708-4e0a-a136-7d5d40abc5a8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f373f7f0-23b6-414e-b2c2-ea4104b0dacb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f3861270-c076-43a7-bb89-575baed2aa63"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f398143f-2895-4726-9636-dfadbe4735a0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f3a5a1b4-b49c-4c45-b0f8-5f1f5c212e89"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f3b51701-08d3-4e70-817a-572fccd85696"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f4322cd7-e953-44f6-ace6-660ad23504a5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f45d5ea9-3b31-413c-b639-e01047564570"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f46ad5e2-f3bc-4ffd-b11e-f2b7b988bdd1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f4932571-fc86-4c3e-9351-3ba0b3549dc6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f49c035d-630f-4977-96ca-84d3916a8b5e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f4a76f00-84d8-497f-b0a2-554a7ec1ee4f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f4b97ed0-b3b7-4d41-86c4-1c3ca5e63c17"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f4b9e475-721d-46ef-b219-359bb48246e3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f4d289e1-095d-4713-89b4-3aaccec7df27"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f503d056-b4fd-4820-a1e1-18f2c18c176b"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f50c5016-aded-490a-8638-79df26a3883f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f5116e97-e856-4409-a815-e8738ce83067"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f54200c1-61ec-4e65-8000-cb485e5840a7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f5f1b20e-d600-4cda-be5a-0b2b7036abc7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f60fde1b-2a1b-4fc2-97c9-80f63fa312c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f67266de-f62a-462a-8f68-c5ff9daf0921"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f68ca73c-cea3-49eb-ad81-9e5d5a4c50d5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f69bcc68-c5b2-4068-9ea1-cf960228adde"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6a6f967-9daa-4589-923b-2a376d07ef9d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6c2e836-daac-403a-b463-1354a67d877d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6d247aa-2844-48b7-b929-89cda5396528"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6e3ec88-fac1-4573-b855-884d31465049"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6f55350-e315-4199-aca0-65ef3307ab76"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6fb03d0-8be2-466e-a070-6059bf2f8b80"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f6ff7260-c7b3-4bb2-823a-d3026f9d5c30"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7260045-8b98-4dbc-9ec7-1dd8d693a2ee"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7260871-be7a-41bc-9da9-ddefc2d5df83"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f733be91-5892-461a-81d5-d4397048134c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7340ef0-d9ec-4534-baad-9a6f12841e78"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7901940-5137-4574-9db3-8c7436f76c9c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f795ddd9-f826-402d-8036-5d83768b1156"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7a7df8f-53ca-4818-b34b-406b046e11e2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7c92b01-dad6-4fc0-844e-ce4366e862bb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f7d98e58-2458-4918-9fc4-06723d54a659"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f813eb11-13a8-4118-80d5-fd2cd6f3bf81"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f83d662c-c692-49c6-8614-72d4e81d30c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f84efea5-e984-45e1-a0d1-9fdcc0f6dad1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f875b8f5-95ce-43fb-a49e-d57daf27ae50"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f89133ea-a9c2-48ee-92fb-a87d487c35a8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f8bc15ee-d97d-4727-9e12-4145041968b5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f8c69c31-abdc-4abd-958c-4530f2b0aafe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f8cda2a9-bb60-4e14-82c3-6cbe5ad69c97"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f9458ea8-f7f3-4d85-b5e4-0d6d540440a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f9635b87-f1d4-4395-9710-0161532aeb71"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f97556a1-f07b-462d-8f0d-4b8e35203229"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f983ece5-71f4-4820-a83d-31e67945f0c1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f98ae42f-beb0-4ec3-aa78-90f6a09fa8f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f99ed38c-201e-43c8-87ac-3aa9493700c3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f9e99d15-5fa0-4f51-85b2-1680f59becf1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("f9ea1167-5467-46fb-8ecd-05626b2a3acc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa0a4205-a2f7-4406-b46d-7eeaf0298060"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa39f830-01ea-4491-ba76-5d04fd770912"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa475a93-3166-4077-a989-b648c0eaab7a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa5fdb59-34de-4693-8510-80ec3da77df2"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa6da289-3294-4b0c-a7ae-7abad9c3d8cb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa83b4f9-b622-4dad-bdfa-e6148a632793"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fa990961-efbf-4a83-91cf-407b67e170a4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fb0fe3a7-dba2-4fc7-b89c-1de6305a563e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fb478abe-1fb4-4010-b4af-f45a4e83c2fb"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fb62ea26-fad1-4a92-849e-dde4606c3b21"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fb692b3a-ae72-47dc-9adb-69caa15b10ce"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fb6e55e5-c09f-4d77-8ba0-08d587da117c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fb97224d-c658-438e-9f52-0bc26846348c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fbc5d04b-385c-428d-8719-214ff37f8abc"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fc023140-65fc-4c17-ab06-2cc6682bb7f3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fc78830f-31d2-4149-bf64-94e4dc5c5f1e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fc91cefe-e5c0-424d-be1e-7bbbf9a5dad1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fcdcbf76-f5aa-4d95-af04-d643d93da4a6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd0e5422-fa71-4af4-b983-bb703a729872"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd1b7834-b34d-4fd0-abd9-db283ad9cde1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd1e5176-3b89-45df-9cc3-ec5a902fe9a3"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd2486f3-073b-42f1-b0e5-018e71fa3ae1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd56068e-d291-4c0b-8ed3-b5a39a933e5f"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd620925-d927-4fb6-aa59-34802229be95"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd6a4cbe-f9d1-4617-807a-3090f16c586e"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fd6a6b02-c146-4be1-9294-c71d191b34ea"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fdae7224-8ec0-4ea6-a387-5a6b7859a931"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fdc85764-ccb7-4f6e-916c-e9c4a73070c4"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fde3f4ec-5219-493b-838e-68f3fd5b747d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe06862e-275e-4419-907e-c0d2206b468d"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe16af91-0966-49ea-bd6a-86ef92ef8f23"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe223e7b-2327-41b6-b3de-953b6e7c4afe"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe48da15-1d00-435d-94a5-9729154a8021"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe56ef72-3e05-4902-ab32-5f2bb6b78cf8"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe7a2a96-4937-4d4c-acde-2c561693871a"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fe98f65e-ccdd-47ba-b29e-633a3dbe8fdf"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fea32fd2-0718-42bd-905b-af0f17b2c8b1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fea7835f-c930-490d-8ca2-6345f8be8b5c"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("feb3d60d-ace2-4f9d-b5c8-23f336c45bf7"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("fee38800-dd09-435c-9045-4189f76f94c5"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ff1dcaf9-3e5f-454f-aee2-75ec47514897"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ff385c98-d8ec-46b5-81a2-ee5bc5dbac73"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ff5986ca-77d0-4544-9d43-b06b37c9c7ec"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ff636b58-8d64-4ce3-b161-b5980f7f52c0"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ff70b9d9-1d46-44e7-9835-f368a565bda1"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ffa6319a-684d-4825-aee4-3a20b7ce67f6"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ffc352a1-aa99-4961-8446-979c4f9f3ced"));

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: new Guid("ffd333d5-9d85-42ae-a6c0-20cebba49202"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("01526436-ef97-49fb-a116-79ea2f3bd998"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("04bf5f18-89a5-4514-a894-91ef8fc8da8d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("084931b4-a40a-4138-ba24-76cdf9211a7f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("090153e9-e8c7-4a5e-a5c3-2fa167c428cd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0b465603-7552-4166-9bb7-45f0eb417942"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c1a3180-bea8-47a7-9ac9-be086b2c5827"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d72980c-51d6-42fd-ad27-d17d3643fc17"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("10719052-86d2-4211-9a9d-56253f755e2f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("11d09bd2-1668-4e35-925f-c53b64a72183"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1262a8ad-7bc8-489a-a7ad-ab5ea39c2cad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("12803dd8-5796-4a50-9728-fc28923f5c3f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("145ec164-05ca-40bd-baed-65609836a604"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("160099d9-a007-4483-b2e3-e62804f45764"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1838b2a4-5cff-496d-bac6-c57af3f77e45"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("19572e85-a7da-4e36-81fb-829598fe5e1c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1a6b264b-8ad3-41ab-a41f-678eda249305"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1bb6129a-bac2-4cc0-958e-633b55e0fbdb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1e1330d7-a965-44bd-9547-0822e5ea7b85"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("272db8a6-f1ac-40f2-b953-616c64e35e36"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2a4b0e0d-af54-49c0-87fe-de44fbc2f0d0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2cd61684-e451-4000-a710-89e34f1e6570"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2fd775e2-18f1-4b4d-810f-b0fe37364a5c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3ba8f6b5-f798-4222-8671-8f4ca198785a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3bb4e587-2af3-413a-aa80-22fcb8c467cb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3f1ab819-5eb6-4148-8dd7-6361a82a6e6e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("46617cb6-7616-4d03-bb54-2506a58cd806"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4b05c169-11a7-4961-acc7-2dd219e38dc9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4b60d0e2-c619-45e4-8551-6b0903ac4f63"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4bfc294a-f523-4c65-9a20-a98dcb111bca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cdae84a-81c2-4970-8020-068df69e59bf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("52d02f35-2684-45f0-9cb3-3ac27164908c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5385b7cf-d465-433f-8f44-af9be6d701e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("57dfb404-75de-4511-9c2e-c5b56ed50d60"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("595a083d-f3d3-45b8-b61c-278639cebdc4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("597e5628-6694-48ce-bac6-29845d4b336b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("59d779df-d7fe-41b6-ab0e-6c6aeb167575"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5ad0e195-ddc9-4a82-bcdd-3d29c56623c0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5b2ba735-71f0-4f75-8a03-9a10b5e37d64"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6493bb8a-6c60-4606-871f-cf24588d140f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("64f69b25-90f8-44fb-bfae-989315b7e1a5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6561f98a-6215-4f2e-a046-540efb80a9dd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("68bc16d1-a4f2-4242-81e7-4ea75f210924"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("68cbf284-e3a0-42a7-9cb5-7145bf3d8050"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6ed839fe-65f5-420e-9a9f-33cec41e200e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("74e6aa6f-01c6-4125-a8f0-31244ab09b86"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7654dc0b-184c-4cb4-978c-088576a561f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("784ff4fa-5323-494a-882e-66247bdb05b9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7a985332-b894-4a3f-86a5-6d1fada79be2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7b338430-7f6e-4c73-a08b-f5660dffce91"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7b8b3bff-ef52-45fd-afd3-a1317c49ec42"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7d2271c0-dcea-4815-8bad-4ed558a5f515"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8266f08d-5a7c-48b1-ac90-d399ec096a02"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("82d7d2b0-5123-4fa2-8d4d-82dc94904801"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8300a4fe-0b4e-4494-9294-c4421207c32b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("83a62f53-8afc-490b-8c17-208a08182865"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86cf6bdc-26b6-477c-befe-a7138456c191"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8de743b4-55ca-47f6-9f96-95b3da4734d4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("93895494-a7b9-413c-a5cf-72875d731d12"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("93d1b04d-52c7-4b96-9bce-d5dca899c6ec"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("962396dc-815b-4e11-8ebc-b11b918f93c9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("987ad455-25de-45f3-b5c0-ea0c483b176d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9b31f26c-c4fa-4440-87d1-b83ae27774f9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9c55efaf-841c-4983-b9c9-5f3269af1462"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9d86c5d4-b981-433b-89de-b27910f40459"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a069f4bf-9872-41cf-a9a5-74859b5043c3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a4923ad7-01d2-4dad-9437-6af33551b66a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a6203626-9654-4f13-a2a0-9062f639a934"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ab8df664-2d2a-4d4e-95d4-cdbbdd7c9df6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ac4cd0e2-22ad-442b-924f-d9b4bd1a1ebe"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b514bea5-743e-4eb1-bb2b-b0b8af4fa852"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b59c5966-75b8-4941-90a4-7a7171926864"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b61aa13e-ebe9-4ca8-94dd-2bfff574ff41"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("be1c761a-b85f-4766-b9f6-876b137f35fd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c1c732db-f42a-4b10-aa52-5e2e26cd6b16"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c2a4d653-2702-4c1d-adf0-05d0529afc0c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ce6341d3-a77f-4a3e-bdc7-396e0d1ad83f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d393093c-63f7-4fe7-8c61-2cd5427cb240"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d4aa2494-1833-4c5a-af24-1ce3fbca45a3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d5da9966-419f-414e-ab40-854bf5289321"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d8699396-f62a-41ad-a43a-deb410155039"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e12c0168-11d8-4ec0-bd3e-3d09b9ed80e6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e98e0ee3-a240-47da-bd32-c91836f28499"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("eac29e7d-3190-4b9f-8641-0d66e82189f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ed179fc1-63ba-4d8d-9f2e-a139a1d60bb2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f03e13e5-a1f6-44be-973e-7608cb4f6c34"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f19c473a-5027-4d87-9240-ca414d15d070"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f2c1bdfc-e74e-4a76-8465-e805916fbb20"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f83e6284-5958-4602-8632-0c193868430e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f938b536-0ab5-4fff-9a3d-bde888e29966"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fe3b902c-6e65-491a-9faa-bacbcc0e9f63"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fff0888a-9780-42de-8541-aee3bbe01f4b"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("b25bcd85-0d3f-493b-949b-381d7f4e3aa2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("07f575f6-452f-43b8-bd22-9672e1da9bcf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("19c4b445-99ee-4662-ba33-bb25679878d5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3eace1bc-baaa-4ca9-83ef-fe1dcfe0f810"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4ccecfaa-7979-4464-99da-de8037484a3b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("80a6f5a2-e48a-4dc8-bc47-17101ae1d127"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b464eda6-4c2e-414f-baf6-641aa17ee02c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b4876e47-96b6-4fc9-b3e2-d7794324aa9d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d9aff370-416b-4466-af64-6fbf772b45f3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f1237230-5506-47d9-8b7f-596f3851b117"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("ade564a8-a676-4cdd-ad36-487f915e40d3"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("ff9a8308-4f2e-4f11-8b46-9175d5f86a49"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("1c6cb779-4dee-4469-b0b5-40e9be930bd2"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("79efdf08-20bd-4e26-8f2d-ec5e891d9e56"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("80be323d-e95f-44ce-9fc4-b3ba3a9b8e1c"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("9c156f7f-120e-49a8-819b-1c6a7597207e"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("a4c3112d-38b9-490c-8759-420a24352125"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("dc4934b1-7b4e-4af9-8926-648b0bddc2c1"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("eac41c07-cecf-4298-adb6-879caff5e60f"));
        }
    }
}
