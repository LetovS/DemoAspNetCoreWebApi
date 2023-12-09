using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations.Migrations
{
    public partial class Add_initial_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Providers_ProviderId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderName",
                table: "Providers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "ProviderId1",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "OrderItems",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OrderItems",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "ProviderName" },
                values: new object[,]
                {
                    { new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), "Provider name 8" },
                    { new Guid("29afc549-565b-487a-9b3d-724d1072259d"), "Provider name 2" },
                    { new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), "Provider name 6" },
                    { new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), "Provider name 3" },
                    { new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), "Provider name 7" },
                    { new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), "Provider name 10" },
                    { new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), "Provider name 5" },
                    { new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), "Provider name 9" },
                    { new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), "Provider name 4" },
                    { new Guid("c832765a-58c5-4534-8ab0-42966208dbc7"), "Provider name 1" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "ProviderId", "ProviderId1" },
                values: new object[,]
                {
                    { new Guid("003ce923-ff62-410f-929c-114cee23030a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3669), "Order number 100", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("01890182-c06c-4974-9ee5-6e6a1b6accf9"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3564), "Order number 66", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("0376227e-2ea7-4dc2-aba5-3899b453e313"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3410), "Order number 13", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("06548f64-39a3-4bf8-9d96-4fee910d92d8"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3365), "Order number 4", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("07deb86b-9ad0-4454-8b63-995d753c257d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3575), "Order number 71", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("08900692-cd6b-45dd-a424-1ff059e5c921"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3587), "Order number 77", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("0ac69bce-4815-4edb-84c7-e99a81b3de1b"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3619), "Order number 93", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("0d6af5b0-a045-4285-828b-8803888eae3f"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3542), "Order number 56", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("0f6226a0-c100-447a-b321-f455d4ee7029"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3582), "Order number 75", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("0fdf550e-e274-4fbb-9df7-8f3946718392"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3571), "Order number 69", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("11ddf150-41ce-4b2d-9b4e-8879ddd985de"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3356), "Order number 2", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("176e1a0e-3068-4615-83bf-8a4c4f77ba75"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3469), "Order number 41", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("190f793e-45b0-4492-bd41-63aceaa52c8a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3610), "Order number 89", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("22bf7954-6d69-4199-8d26-83ffcbf7d568"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3566), "Order number 67", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("22cbeb59-4e82-4f49-9b08-28bb58766cbb"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3412), "Order number 14", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("26d90544-1f35-4aea-b667-0e50ea4ff547"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3489), "Order number 51", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("27f224c3-4c61-410c-a1cb-050635fd634e"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3425), "Order number 20", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("28b684f2-7b1c-4ec6-9b95-1af1f658034c"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3449), "Order number 32", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("2aa52600-42f2-47b7-8795-4ebb9bcbbac8"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3658), "Order number 95", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("2c755551-d26f-43d0-9ebb-2b11006145f0"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3591), "Order number 79", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("2faa13ff-a815-45ae-97f6-17d21e9e445f"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3379), "Order number 10", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("2fefba6d-702c-4b55-a11d-11b8d1274698"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3476), "Order number 44", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("310e1dcd-74d1-44b9-b344-bc8e7fa4948b"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3666), "Order number 99", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("314f4dc7-0e70-415f-bf50-867853da93df"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3494), "Order number 53", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("31ec3d9d-ed95-44a9-8fde-6e9d12908890"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3664), "Order number 98", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("32058e85-307a-45d7-a0cf-565635e5ef61"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3543), "Order number 57", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("33f56b0c-8f70-48b3-af46-c586177024d5"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3359), "Order number 3", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("3d42f3ac-5fea-4cb6-9761-485c1964f1dd"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3553), "Order number 61", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("405ee9f5-6799-4b28-ac94-d575015af397"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3573), "Order number 70", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("40d4e899-90cc-4657-878d-d507fa219d4a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3609), "Order number 88", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("48d7903f-41e4-431b-96d8-8479d64a6380"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3473), "Order number 43", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("49d32423-9905-4614-b7af-6d0a9f9f7366"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3451), "Order number 33", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("5a5baa0c-14ea-4d9d-89fc-6489cdd5164e"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3456), "Order number 35", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("5b398dd2-652a-4a2d-9cad-ac8f1af0df46"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3431), "Order number 23", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("5be20cbf-21f2-4ba6-a3ae-55a9e5ffb39b"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3551), "Order number 60", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("62dee05c-9282-4ef6-a1ad-6cfb648719b0"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3443), "Order number 29", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("639a70eb-d45b-4dc1-addb-7b35f9770a4e"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3561), "Order number 65", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("63ca1eee-dbbf-4eb7-b69d-a4c839c69046"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3461), "Order number 37", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("66fdb037-8224-47e3-83c2-aa89dbe3b707"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3447), "Order number 31", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("68d42dfc-c9ce-4363-bb96-302f41530da0"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3376), "Order number 9", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("6b10a57f-040a-4c3d-a565-418535b93ae4"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3415), "Order number 16", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("7376855b-2f14-4bbc-b209-4b76b2370453"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3607), "Order number 87", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "ProviderId", "ProviderId1" },
                values: new object[,]
                {
                    { new Guid("7396ac0e-e7ac-4c12-a305-a716795a036d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3420), "Order number 18", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("74cdbd0a-3815-4754-a3b9-02c06901ca88"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3660), "Order number 96", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("756ea9d9-73fe-42d3-9f33-a3500c36c317"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3617), "Order number 92", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("7782ccb4-a9de-4dea-a61c-321c76646e29"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3593), "Order number 80", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("81676e78-0692-4df6-a7a0-52f19b71742c"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3454), "Order number 34", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("87675b4a-e3d1-4154-a0e8-99e8a8dc21c9"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3594), "Order number 81", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("88410a8f-93d3-4f83-8a6c-08cb78687af9"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3372), "Order number 7", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("888202ab-ea3c-4785-a861-871ccca2f88f"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3441), "Order number 28", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("88a4f5a8-a1ac-4f77-a70b-fae71329b6fa"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3480), "Order number 46", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("8c92f769-2d3b-407d-af29-eb386379b23a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3548), "Order number 59", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("8dc7aa4a-e666-442d-94d0-eb53efde6778"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3427), "Order number 21", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("8fcb66a6-ebe6-4a93-bb05-4aa7e3beb738"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3621), "Order number 94", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("90d0aabd-4536-49ab-b902-780e865dee7c"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3605), "Order number 86", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("91484d8a-93f5-41b2-81c7-bb4d98f63f75"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3580), "Order number 74", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("95857335-f7c9-4ad8-b3bd-54af06d898ad"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3428), "Order number 22", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("9774dd2f-e772-4948-82f8-28cefc04bbfa"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3487), "Order number 50", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("9cacc8bc-d1bb-43f4-a0f4-71e453692ffe"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3414), "Order number 15", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("9e609923-0659-4c40-b30d-b065ae10005c"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3437), "Order number 26", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("a0552349-b812-486c-8253-06be5d5832ae"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3662), "Order number 97", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("a4a44c64-f225-45db-bd36-d02cfd597025"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3485), "Order number 49", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("a5aac90f-5ac8-49ca-ae5f-2d61e8a9b71d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3614), "Order number 91", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("a7184a4c-d6ab-4053-a1bd-8eeceab88d21"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3478), "Order number 45", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("a760de11-89d4-425a-91ce-d4a8e7ba34d4"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3417), "Order number 17", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("a9648626-e9ed-4d80-9844-186705d7b7a7"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3601), "Order number 84", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("ae68103f-a8d3-4f8f-91e1-63c6e57f23aa"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3445), "Order number 30", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("b1ed5375-e7b7-48c5-9246-17abac8873b0"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3432), "Order number 24", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("b450aa68-0ca7-4db0-a0ea-ad62adc9722d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3557), "Order number 63", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("b5075a9d-7e7d-4aad-83aa-bf9ce30d67a1"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3492), "Order number 52", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("b6095ef2-45f1-4124-9956-c82a8d3b166b"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3589), "Order number 78", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("b64badd1-447f-4dca-a828-26afcad6971a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3559), "Order number 64", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("b77dc246-f818-4772-9601-d79b6107fb64"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3483), "Order number 48", new Guid("abf69a2d-f358-48be-9b84-717b53df248c"), null },
                    { new Guid("bdb4d7eb-d69b-4eaf-a8ac-c0307abafff7"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3380), "Order number 11", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("bdc7106f-0056-4fe5-8ddc-76b1f33ca190"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3555), "Order number 62", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("c0777ac6-d5d3-4337-9deb-e2151f0f018d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3370), "Order number 6", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("c224ff94-0f95-4066-904b-f9b34d132844"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3578), "Order number 73", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("c2e61215-72c3-49e5-9478-6c970a021af5"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3596), "Order number 82", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("c4c5a2f1-68ff-4109-b4a4-6e6147be043d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3471), "Order number 42", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("cac7bdc9-18c3-449f-b157-8b1c1ec95850"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3576), "Order number 72", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("cc46af6e-1f0d-4419-b896-39446c8f2ead"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3612), "Order number 90", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("d005215e-57c4-4ed6-8323-c34f390d9c4d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3463), "Order number 38", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("d1ba3c65-f697-4bca-b983-16357856f3cf"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3569), "Order number 68", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("d59a0bd8-9eaa-4b1a-bb52-80f566671497"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3482), "Order number 47", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "ProviderId", "ProviderId1" },
                values: new object[,]
                {
                    { new Guid("d84ffd14-8a54-4a2f-b70c-df81a3a8796d"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3585), "Order number 76", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("d8b93273-654d-4f05-9e62-b7875af25dcb"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3384), "Order number 12", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("d90e9a82-fdb0-408e-94c9-db5c40792d69"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3434), "Order number 25", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("dbb37c88-37fd-4f6c-aa29-9478eb4d57cf"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3546), "Order number 58", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null },
                    { new Guid("df73e4fd-a944-4608-b793-db010a16e39a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3465), "Order number 39", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("e33f53ff-cc79-4dd2-88b0-619cb8a2b407"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3422), "Order number 19", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("e44844c8-429f-4597-855c-9b20f1ed8b44"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3438), "Order number 27", new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"), null },
                    { new Guid("e7f3b81c-ad30-4ab7-950a-3bf80f2448a5"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3319), "Order number 1", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("edcbfcb3-c99b-40fc-8ee9-a6e6ede61a2a"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3374), "Order number 8", new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"), null },
                    { new Guid("f0f2a5bd-9b48-4bb8-94b8-9396c21735a9"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3603), "Order number 85", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("f1415cd4-851e-474c-837f-8b931770a656"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3540), "Order number 55", new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"), null },
                    { new Guid("f5bdffc8-e663-4b83-b7f5-cff9236e18ff"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3495), "Order number 54", new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"), null },
                    { new Guid("f7abd686-8f5f-460c-89ff-15eb406e0a12"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3459), "Order number 36", new Guid("3d99a289-f66d-449e-b808-4a9d94979830"), null },
                    { new Guid("f89a3ccd-f3d6-4384-a98a-a47904c5bef1"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3598), "Order number 83", new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"), null },
                    { new Guid("fa21ca76-5238-432a-8bb8-da05a2a844e9"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3367), "Order number 5", new Guid("31148c84-057b-4de3-b1f9-31437bb57605"), null },
                    { new Guid("fb83a020-ce8a-4fec-b09f-f9b7747567d8"), new DateTime(2023, 12, 9, 23, 37, 54, 495, DateTimeKind.Local).AddTicks(3467), "Order number 40", new Guid("29afc549-565b-487a-9b3d-724d1072259d"), null }
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Providers_Name",
                table: "Providers",
                column: "ProviderName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Number_ProviderId",
                table: "Orders",
                columns: new[] { "OrderNumber", "ProviderId" },
                unique: true,
                filter: "[ProviderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProviderId1",
                table: "Orders",
                column: "ProviderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Providers_ProviderId",
                table: "Orders",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Providers_ProviderId1",
                table: "Orders",
                column: "ProviderId1",
                principalTable: "Providers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Providers_ProviderId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Providers_ProviderId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "UQ_Providers_Name",
                table: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Number_ProviderId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProviderId1",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("003ce923-ff62-410f-929c-114cee23030a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("01890182-c06c-4974-9ee5-6e6a1b6accf9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0376227e-2ea7-4dc2-aba5-3899b453e313"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("06548f64-39a3-4bf8-9d96-4fee910d92d8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("07deb86b-9ad0-4454-8b63-995d753c257d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("08900692-cd6b-45dd-a424-1ff059e5c921"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0ac69bce-4815-4edb-84c7-e99a81b3de1b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0d6af5b0-a045-4285-828b-8803888eae3f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0f6226a0-c100-447a-b321-f455d4ee7029"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0fdf550e-e274-4fbb-9df7-8f3946718392"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("11ddf150-41ce-4b2d-9b4e-8879ddd985de"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("176e1a0e-3068-4615-83bf-8a4c4f77ba75"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("190f793e-45b0-4492-bd41-63aceaa52c8a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("22bf7954-6d69-4199-8d26-83ffcbf7d568"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("22cbeb59-4e82-4f49-9b08-28bb58766cbb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("26d90544-1f35-4aea-b667-0e50ea4ff547"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("27f224c3-4c61-410c-a1cb-050635fd634e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("28b684f2-7b1c-4ec6-9b95-1af1f658034c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2aa52600-42f2-47b7-8795-4ebb9bcbbac8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2c755551-d26f-43d0-9ebb-2b11006145f0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2faa13ff-a815-45ae-97f6-17d21e9e445f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2fefba6d-702c-4b55-a11d-11b8d1274698"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("310e1dcd-74d1-44b9-b344-bc8e7fa4948b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("314f4dc7-0e70-415f-bf50-867853da93df"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("31ec3d9d-ed95-44a9-8fde-6e9d12908890"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("32058e85-307a-45d7-a0cf-565635e5ef61"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("33f56b0c-8f70-48b3-af46-c586177024d5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3d42f3ac-5fea-4cb6-9761-485c1964f1dd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("405ee9f5-6799-4b28-ac94-d575015af397"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("40d4e899-90cc-4657-878d-d507fa219d4a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("48d7903f-41e4-431b-96d8-8479d64a6380"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("49d32423-9905-4614-b7af-6d0a9f9f7366"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5a5baa0c-14ea-4d9d-89fc-6489cdd5164e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5b398dd2-652a-4a2d-9cad-ac8f1af0df46"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5be20cbf-21f2-4ba6-a3ae-55a9e5ffb39b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("62dee05c-9282-4ef6-a1ad-6cfb648719b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("639a70eb-d45b-4dc1-addb-7b35f9770a4e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("63ca1eee-dbbf-4eb7-b69d-a4c839c69046"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("66fdb037-8224-47e3-83c2-aa89dbe3b707"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("68d42dfc-c9ce-4363-bb96-302f41530da0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6b10a57f-040a-4c3d-a565-418535b93ae4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7376855b-2f14-4bbc-b209-4b76b2370453"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7396ac0e-e7ac-4c12-a305-a716795a036d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("74cdbd0a-3815-4754-a3b9-02c06901ca88"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("756ea9d9-73fe-42d3-9f33-a3500c36c317"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7782ccb4-a9de-4dea-a61c-321c76646e29"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81676e78-0692-4df6-a7a0-52f19b71742c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("87675b4a-e3d1-4154-a0e8-99e8a8dc21c9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("88410a8f-93d3-4f83-8a6c-08cb78687af9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("888202ab-ea3c-4785-a861-871ccca2f88f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("88a4f5a8-a1ac-4f77-a70b-fae71329b6fa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8c92f769-2d3b-407d-af29-eb386379b23a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8dc7aa4a-e666-442d-94d0-eb53efde6778"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8fcb66a6-ebe6-4a93-bb05-4aa7e3beb738"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("90d0aabd-4536-49ab-b902-780e865dee7c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("91484d8a-93f5-41b2-81c7-bb4d98f63f75"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("95857335-f7c9-4ad8-b3bd-54af06d898ad"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9774dd2f-e772-4948-82f8-28cefc04bbfa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9cacc8bc-d1bb-43f4-a0f4-71e453692ffe"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9e609923-0659-4c40-b30d-b065ae10005c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a0552349-b812-486c-8253-06be5d5832ae"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a4a44c64-f225-45db-bd36-d02cfd597025"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a5aac90f-5ac8-49ca-ae5f-2d61e8a9b71d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a7184a4c-d6ab-4053-a1bd-8eeceab88d21"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a760de11-89d4-425a-91ce-d4a8e7ba34d4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a9648626-e9ed-4d80-9844-186705d7b7a7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ae68103f-a8d3-4f8f-91e1-63c6e57f23aa"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b1ed5375-e7b7-48c5-9246-17abac8873b0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b450aa68-0ca7-4db0-a0ea-ad62adc9722d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b5075a9d-7e7d-4aad-83aa-bf9ce30d67a1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b6095ef2-45f1-4124-9956-c82a8d3b166b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b64badd1-447f-4dca-a828-26afcad6971a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b77dc246-f818-4772-9601-d79b6107fb64"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bdb4d7eb-d69b-4eaf-a8ac-c0307abafff7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("bdc7106f-0056-4fe5-8ddc-76b1f33ca190"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c0777ac6-d5d3-4337-9deb-e2151f0f018d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c224ff94-0f95-4066-904b-f9b34d132844"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c2e61215-72c3-49e5-9478-6c970a021af5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c4c5a2f1-68ff-4109-b4a4-6e6147be043d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cac7bdc9-18c3-449f-b157-8b1c1ec95850"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cc46af6e-1f0d-4419-b896-39446c8f2ead"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d005215e-57c4-4ed6-8323-c34f390d9c4d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d1ba3c65-f697-4bca-b983-16357856f3cf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d59a0bd8-9eaa-4b1a-bb52-80f566671497"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d84ffd14-8a54-4a2f-b70c-df81a3a8796d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d8b93273-654d-4f05-9e62-b7875af25dcb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d90e9a82-fdb0-408e-94c9-db5c40792d69"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("dbb37c88-37fd-4f6c-aa29-9478eb4d57cf"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("df73e4fd-a944-4608-b793-db010a16e39a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e33f53ff-cc79-4dd2-88b0-619cb8a2b407"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e44844c8-429f-4597-855c-9b20f1ed8b44"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e7f3b81c-ad30-4ab7-950a-3bf80f2448a5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("edcbfcb3-c99b-40fc-8ee9-a6e6ede61a2a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f0f2a5bd-9b48-4bb8-94b8-9396c21735a9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f1415cd4-851e-474c-837f-8b931770a656"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f5bdffc8-e663-4b83-b7f5-cff9236e18ff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f7abd686-8f5f-460c-89ff-15eb406e0a12"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f89a3ccd-f3d6-4384-a98a-a47904c5bef1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fa21ca76-5238-432a-8bb8-da05a2a844e9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fb83a020-ce8a-4fec-b09f-f9b7747567d8"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("c832765a-58c5-4534-8ab0-42966208dbc7"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("22bca438-c3d3-41c5-a439-90a435d15dfc"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("29afc549-565b-487a-9b3d-724d1072259d"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("31148c84-057b-4de3-b1f9-31437bb57605"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("3d99a289-f66d-449e-b808-4a9d94979830"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("59f6586a-3f3d-44fb-a34e-f77024371f84"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("603fc2e9-7224-4ab9-8c41-e6ea30f629fb"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("a50e90a2-2d1b-4448-9865-d21d029800a5"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("abf69a2d-f358-48be-9b84-717b53df248c"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("b84f0c12-b6e5-4f16-a09a-6197dfd1f55c"));

            migrationBuilder.DropColumn(
                name: "ProviderId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderName",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Providers_ProviderId",
                table: "Orders",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id");
        }
    }
}
