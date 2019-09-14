using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Altkom.Shop.DbRepositories.Migrations
{
    public partial class AddOrdersSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Granite Pants", 40.959275289419728m, "4523977196850", "mint green", "35085492" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Metal Fish", 29.115057303158122m, "2550374164368", "fuchsia", "25730371" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Plastic Bike", 87.707788642825471m, "8048595784143", "sky blue", "17811699" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Plastic Tuna", 81.313919344131814m, "7632843830235", "lavender", "25669688" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Mouse", 14.301364281820813m, "5518333445191", "63830217" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Granite Salad", 75.974670754733827m, "0395485449728", "salmon", "35496793" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Metal Chips", 74.736476324375986m, "7471209065702", "plum", "37059743" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Rubber Car", 74.450739403465138m, "8147511333899", "salmon", "04140658" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Cotton Towels", 5.3213496684661864m, "6376220141309", "cyan", "51454470" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Wooden Hat", 91.463964605454286m, "5078938465029", "sky blue", "34103654" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Wooden Bacon", 1.70217751837436929m, "2033659672111", "fuchsia", "51103941" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Wooden Mouse", 13.125591175223548m, "3672554428691", "silver", "05716449" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Incredible Frozen Soap", 62.989573244000545m, "5451787083994", "76028793" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Concrete Car", 68.022158803894261m, "1336606305706", "gold", "02741505" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Soft Gloves", 26.632885415401693m, "3235097247039", "azure", "40486680" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Steel Mouse", 29.111051356937263m, "0549132304339", "salmon", "70318463" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Plastic Chips", 94.660811802214426m, "1299900317540", "yellow", "47104730" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Steel Car", 96.808484737206505m, "2744383653788", "orchid", "33394923" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Fresh Soap", 15.5539745127568m, "3584904113617", "green", "65924891" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Plastic Chicken", 99.863156755391149m, "3447711313185", "green", "09749665" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Concrete Gloves", 23.564051241410899m, "9055940087049", "azure", "56302295" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Wooden Mouse", 27.069893874726229m, "1423673015772", "turquoise", "55473095" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Plastic Salad", 2.3505767208293932m, "3574204880449", "black", "27414934" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Rubber Hat", 46.702186948015444m, "7284196859908", "olive", "98801985" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Steel Table", 32.434595454220948m, "6878984701602", "orchid", "20694685" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Cotton Bike", 82.233044233281622m, "1288705782837", "plum", "18875294" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Soft Bacon", 96.101854098076837m, "3804218161662", "blue", "95995922" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Plastic Pizza", 92.111933321744203m, "7185444348482", "plum", "00464673" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Concrete Fish", 18.70154335242766m, "2922588004615", "lavender", "32627213" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Wooden Sausages", 59.825480429374417m, "4555594538348", "turquoise", "11869481" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Pants", 48.83688301632031m, "9519058007806", "yellow", "32510171" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Concrete Car", 34.363174165768216m, "4526330124606", "olive", "74589241" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Soft Ball", 88.975532919622744m, "8652581744440", "olive", "32777680" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Granite Pants", 34.375876504171597m, "5856773625767", "sky blue", "77532855" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Wooden Towels", 72.155102361997159m, "4766949330764", "magenta", "34071816" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Wooden Sausages", 76.241880128272726m, "1468095338207", "lavender", "17686433" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Fresh Chair", 49.623140918381095m, "8822082386450", "ivory", "71335339" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Frozen Soap", 47.577522247833016m, "1210819249913", "grey", "72355817" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Wooden Keyboard", 84.791028431985094m, "1926554828183", "turquoise", "72567210" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Wooden Towels", 90.046351074262681m, "0884811906887", "teal", "92784192" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Rubber Cheese", 7.7824600966565542m, "2570022030678", "grey", "60007179" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Fantastic Metal Fish", 85.742210986903954m, "4230160405124", "30873841" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Steel Mouse", 14.565336111730612m, "0910870673580", "violet", "91860163" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Soft Chicken", 6.7856614057839223m, "3965287409021", "magenta", "59635543" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Steel Salad", 95.601007785928006m, "9785305324785", "teal", "04385172" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Metal Keyboard", 8.5309176899171017m, "4363262204644", "green", "01093704" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Soft Ball", 60.190156379337544m, "1643290267099", "green", "42052487" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Frozen Bacon", 30.371859864504982m, "0854607705161", "maroon", "19913384" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Steel Hat", 89.311637459467972m, "6488962170247", "blue", "36550395" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Cotton Table", 9.1722321725321134m, "4724152025723", "orange", "29843985" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Granite Bacon", 82.760241941437213m, "7228169305313", "indigo", "47028111" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Plastic Gloves", 73.093517761255408m, "4451536994695", "green", "24865425" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Metal Chips", 5.1139673609817277m, "9625399492369", "salmon", "08768322" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Wooden Chair", 99.178150739138074m, "3433054850180", "pink", "01594195" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Wooden Soap", 6.1797470111305534m, "6582394859180", "olive", "66338512" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Fresh Soap", 15.563634358608973m, "8359102186658", "indigo", "71465333" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Metal Ball", 3.5589287972817811m, "8516059790400", "fuchsia", "35656005" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Fresh Tuna", 70.429127921084503m, "0543548107065", "magenta", "86136853" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Cotton Ball", 61.696042947329581m, "6848629984547", "green", "05251308" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Steel Soap", 42.695001915420898m, "9730390624777", "blue", "90478178" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Metal Ball", 62.112854699656804m, "6953365623992", "yellow", "98694815" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Granite Hat", 63.481965975129052m, "8273220242334", "purple", "46368157" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Rubber Salad", 69.072966820128754m, "5892463143517", "lavender", "82303648" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Concrete Shoes", 3.9370501329829264m, "5576991238739", "gold", "28889298" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Concrete Cheese", 3.004265905825546m, "7523014231787", "salmon", "86252270" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Frozen Cheese", 11.633288156070382m, "8672347271942", "sky blue", "67213405" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Frozen Sausages", 68.509653729158278m, "9378470777533", "black", "42994404" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Soft Sausages", 85.249283305951126m, "0660964874293", "salmon", "79801164" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Fresh Fish", 92.142368297158915m, "5176825141770", "purple", "00713665" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Frozen Mouse", 52.895632389884272m, "5055103195486", "tan", "97949152" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Steel Chips", 54.538647702680305m, "3555282592080", "yellow", "79038683" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Frozen Mouse", 75.13047673559308m, "6197463504269", "salmon", "58913895" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Wooden Cheese", 28.753130646773191m, "1175145439813", "lavender", "84128577" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Cotton Bacon", 61.797196224237385m, "6726948530624", "silver", "98369720" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Fresh Ball", 81.677713299951394m, "7791442637833", "cyan", "28490371" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Fresh Ball", 23.879099208339649m, "1039119843924", "lavender", "47088993" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Frozen Table", 88.701367538748898m, "3356041949936", "green", "12517084" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Concrete Table", 51.518776604681638m, "2807809263685", "orange", "63701074" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Soft Cheese", 78.950846584956565m, "4840051082428", "salmon", "43030767" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Generic Metal Shoes", 39.398328489809431m, "2878495414309", "59101505" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Granite Soap", 1.22395353541893541m, "9440199730721", "indigo", "82697907" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Ergonomic Frozen Bacon", 58.507351983574867m, "6569615729804", "44314576" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Fresh Bike", 91.54280244398059m, "9069457053459", "cyan", "39124098" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Rubber Table", 16.822917632210491m, "5955229737051", "orange", "45262845" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Fresh Bacon", 60.961899272614075m, "4511934463459", "tan", "01733716" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Granite Cheese", 12.49182868678669m, "7265122710173", "cyan", "08702692" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Soft Tuna", 4.8959912121742909m, "1083615972367", "blue", "68230630" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Frozen Ball", 85.373028393542911m, "9133667066407", "sky blue", "49094206" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Wooden Table", 1.77610685572778149m, "3505350182453", "maroon", "82215309" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Concrete Sausages", 19.831775282431309m, "5458940769009", "purple", "62606226" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Granite Car", 94.959968062099051m, "9931149068990", "white", "01132687" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Concrete Hat", 73.142123881327984m, "6931076033903", "pink", "19620947" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Metal Car", 69.934993606496116m, "0898610749415", "violet", "07082863" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Wooden Ball", 12.763716059161198m, "0692770999112", "orange", "77422262" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Granite Ball", 8.0424383352708286m, "8644032956809", "black", "17969420" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Generic Frozen Computer", 11.502032703022531m, "3349418536419", "26857152" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Cotton Chair", 51.862512293207659m, "2019116959070", "tan", "92448360" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Fresh Gloves", 31.504614826992427m, "6734395939747", "pink", "98310555" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Wooden Tuna", 1.84357571967112609m, "7125751368346", "tan", "81553037" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Frozen Table", 13.832369520250852m, "9448207408716", "lavender", "60287373" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 314.973846736817600m, new TimeSpan(12974463562) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 280.737470733345200m, new TimeSpan(19881621467) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 245.986115255386800m, new TimeSpan(64093561623) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 263.413639815251200m, new TimeSpan(7507305123) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 161.374972602992800m, new TimeSpan(29070082428) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 373.905660898380800m, new TimeSpan(2952306726) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 484.614654809522800m, new TimeSpan(71798495393) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 297.383485453847600m, new TimeSpan(20886010105) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 175.901584921358800m, new TimeSpan(30035227566) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 469.249598667607600m, new TimeSpan(8299590908) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 301.921812166423600m, new TimeSpan(11786813160) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 343.832688892182400m, new TimeSpan(47677056413) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 388.657134533234400m, new TimeSpan(37530655230) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 325.130840123226400m, new TimeSpan(65672042769) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 291.300380877824800m, new TimeSpan(51543342123) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 213.981477969317600m, new TimeSpan(1101456844) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 291.52436824120800m, new TimeSpan(43737078989) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 103.66286859086848400m, new TimeSpan(60106726477) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 168.41040536221600m, new TimeSpan(3166265031) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 355.363211899699200m, new TimeSpan(18870459446) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 496.572066469384400m, new TimeSpan(31812572986) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "input", 153.340038868291200m, new TimeSpan(65068528977) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 450.411657407140400m, new TimeSpan(39157611068) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "input", 134.6054280337902800m, new TimeSpan(69344734746) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 204.05283090847200m, new TimeSpan(28707086644) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 350.947461207838400m, new TimeSpan(1094958824) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 254.398926791920800m, new TimeSpan(65145619251) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 415.897297820028400m, new TimeSpan(31990541477) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 490.452464851761600m, new TimeSpan(35686609844) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 391.88487617852400m, new TimeSpan(31576011035) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 266.880118924602800m, new TimeSpan(5992906074) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 289.001057385002000m, new TimeSpan(41140579258) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 356.44958739003600m, new TimeSpan(24832861562) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 160.341452835286800m, new TimeSpan(29442567701) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 131.490684501589600m, new TimeSpan(28245409237) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 275.674484379438000m, new TimeSpan(53929806783) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 269.5945714458800m, new TimeSpan(39143329948) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 226.365474856628800m, new TimeSpan(18173571319) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "navigate", 282.847906547993600m, new TimeSpan(14521458357) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 206.841437754613200m, new TimeSpan(11319763323) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 344.668918216912400m, new TimeSpan(10534820621) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 149.345747963220800m, new TimeSpan(48190555640) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 204.230309512573600m, new TimeSpan(56709319234) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 345.927682447213600m, new TimeSpan(71009617287) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "synthesize", 404.821415760005600m, new TimeSpan(16930345312) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 472.166249701830800m, new TimeSpan(51193190397) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 445.389820423624400m, new TimeSpan(38660036485) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "input", 457.113593610522000m, new TimeSpan(22012254852) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 335.774917637824400m, new TimeSpan(7292635932) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 460.751975495718400m, new TimeSpan(1107567151) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DeliveredDate", "Number", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 99, 14, null, "ZAM 967", new DateTime(2018, 10, 20, 18, 31, 45, 647, DateTimeKind.Local).AddTicks(4779), 4 },
                    { 27, 7, null, "ZAM 896", new DateTime(2018, 6, 12, 7, 35, 29, 980, DateTimeKind.Local).AddTicks(625), 4 },
                    { 28, 9, null, "ZAM 529", new DateTime(2018, 11, 27, 7, 2, 26, 298, DateTimeKind.Local).AddTicks(3685), 1 },
                    { 29, 11, null, "ZAM 235", new DateTime(2016, 10, 21, 19, 0, 18, 445, DateTimeKind.Local).AddTicks(5350), 2 },
                    { 30, 7, null, "ZAM 623", new DateTime(2017, 3, 24, 13, 37, 20, 501, DateTimeKind.Local).AddTicks(2299), 2 },
                    { 31, 1, null, "ZAM 64", new DateTime(2018, 6, 29, 2, 15, 35, 147, DateTimeKind.Local).AddTicks(5892), 1 },
                    { 32, 1, null, "ZAM 962", new DateTime(2018, 10, 4, 2, 16, 50, 958, DateTimeKind.Local).AddTicks(1251), 0 },
                    { 33, 12, null, "ZAM 841", new DateTime(2019, 8, 17, 15, 19, 43, 58, DateTimeKind.Local).AddTicks(8733), 0 },
                    { 34, 2, null, "ZAM 788", new DateTime(2019, 2, 27, 1, 18, 41, 33, DateTimeKind.Local).AddTicks(7086), 4 },
                    { 35, 5, null, "ZAM 42", new DateTime(2019, 8, 6, 21, 16, 53, 446, DateTimeKind.Local).AddTicks(6540), 4 },
                    { 36, 14, null, "ZAM 948", new DateTime(2018, 7, 10, 0, 43, 29, 642, DateTimeKind.Local).AddTicks(1898), 2 },
                    { 37, 5, null, "ZAM 585", new DateTime(2016, 11, 2, 20, 12, 38, 579, DateTimeKind.Local).AddTicks(7799), 2 },
                    { 38, 12, null, "ZAM 20", new DateTime(2018, 11, 30, 1, 39, 20, 218, DateTimeKind.Local).AddTicks(6342), 4 },
                    { 39, 2, null, "ZAM 980", new DateTime(2017, 10, 2, 23, 8, 39, 395, DateTimeKind.Local).AddTicks(8550), 4 },
                    { 40, 9, null, "ZAM 694", new DateTime(2018, 6, 23, 8, 18, 41, 528, DateTimeKind.Local).AddTicks(4356), 4 },
                    { 41, 8, null, "ZAM 329", new DateTime(2016, 12, 7, 20, 34, 52, 229, DateTimeKind.Local).AddTicks(5715), 2 },
                    { 42, 1, null, "ZAM 102", new DateTime(2018, 5, 11, 0, 35, 36, 921, DateTimeKind.Local).AddTicks(1787), 4 },
                    { 43, 9, null, "ZAM 41", new DateTime(2018, 11, 11, 14, 14, 39, 638, DateTimeKind.Local).AddTicks(4384), 3 },
                    { 44, 10, null, "ZAM 884", new DateTime(2019, 6, 2, 12, 30, 53, 925, DateTimeKind.Local).AddTicks(8386), 2 },
                    { 45, 1, null, "ZAM 817", new DateTime(2018, 12, 10, 12, 55, 56, 245, DateTimeKind.Local).AddTicks(5155), 2 },
                    { 46, 9, null, "ZAM 767", new DateTime(2017, 5, 13, 12, 40, 3, 307, DateTimeKind.Local).AddTicks(2957), 4 },
                    { 47, 2, null, "ZAM 102", new DateTime(2018, 8, 12, 20, 1, 2, 828, DateTimeKind.Local).AddTicks(9717), 4 },
                    { 26, 13, null, "ZAM 500", new DateTime(2016, 12, 9, 4, 51, 27, 862, DateTimeKind.Local).AddTicks(4468), 2 },
                    { 48, 9, null, "ZAM 293", new DateTime(2017, 3, 21, 11, 46, 12, 418, DateTimeKind.Local).AddTicks(8108), 2 },
                    { 25, 14, null, "ZAM 626", new DateTime(2018, 5, 30, 4, 59, 49, 803, DateTimeKind.Local).AddTicks(8369), 0 },
                    { 23, 11, null, "ZAM 240", new DateTime(2017, 1, 26, 11, 11, 48, 126, DateTimeKind.Local).AddTicks(4779), 2 },
                    { 2, 7, null, "ZAM 916", new DateTime(2019, 7, 13, 21, 57, 31, 982, DateTimeKind.Local).AddTicks(5588), 4 },
                    { 3, 11, null, "ZAM 786", new DateTime(2017, 11, 1, 23, 5, 18, 353, DateTimeKind.Local).AddTicks(3428), 0 },
                    { 4, 4, null, "ZAM 761", new DateTime(2018, 8, 24, 8, 39, 12, 724, DateTimeKind.Local).AddTicks(4288), 3 },
                    { 5, 10, null, "ZAM 32", new DateTime(2018, 8, 20, 17, 48, 27, 315, DateTimeKind.Local).AddTicks(891), 0 },
                    { 6, 14, null, "ZAM 76", new DateTime(2016, 11, 27, 18, 5, 6, 969, DateTimeKind.Local).AddTicks(5858), 1 },
                    { 7, 6, null, "ZAM 442", new DateTime(2018, 5, 14, 18, 38, 18, 205, DateTimeKind.Local).AddTicks(1800), 4 },
                    { 8, 2, null, "ZAM 829", new DateTime(2018, 1, 8, 10, 31, 15, 821, DateTimeKind.Local).AddTicks(6100), 1 },
                    { 9, 2, null, "ZAM 213", new DateTime(2018, 10, 26, 19, 13, 11, 656, DateTimeKind.Local).AddTicks(7183), 2 },
                    { 10, 4, null, "ZAM 151", new DateTime(2017, 9, 15, 4, 22, 12, 193, DateTimeKind.Local).AddTicks(1737), 4 },
                    { 11, 7, null, "ZAM 104", new DateTime(2018, 11, 3, 12, 29, 50, 448, DateTimeKind.Local).AddTicks(9766), 3 },
                    { 12, 5, null, "ZAM 845", new DateTime(2019, 8, 25, 9, 7, 32, 570, DateTimeKind.Local).AddTicks(5341), 1 },
                    { 13, 6, null, "ZAM 426", new DateTime(2016, 9, 22, 6, 31, 45, 367, DateTimeKind.Local).AddTicks(7226), 3 },
                    { 14, 8, null, "ZAM 286", new DateTime(2019, 5, 28, 22, 30, 41, 602, DateTimeKind.Local).AddTicks(8068), 0 },
                    { 15, 7, null, "ZAM 515", new DateTime(2018, 8, 6, 17, 48, 22, 862, DateTimeKind.Local).AddTicks(2509), 1 },
                    { 16, 4, null, "ZAM 228", new DateTime(2018, 1, 10, 18, 4, 21, 431, DateTimeKind.Local).AddTicks(264), 3 },
                    { 17, 7, null, "ZAM 353", new DateTime(2017, 1, 8, 9, 26, 37, 32, DateTimeKind.Local).AddTicks(9846), 2 },
                    { 18, 6, null, "ZAM 909", new DateTime(2018, 2, 15, 19, 6, 10, 837, DateTimeKind.Local).AddTicks(7108), 0 },
                    { 19, 12, null, "ZAM 449", new DateTime(2017, 2, 25, 23, 10, 29, 904, DateTimeKind.Local).AddTicks(556), 2 },
                    { 20, 6, null, "ZAM 275", new DateTime(2016, 12, 26, 9, 26, 9, 218, DateTimeKind.Local).AddTicks(4610), 0 },
                    { 21, 12, null, "ZAM 57", new DateTime(2018, 4, 4, 5, 41, 0, 58, DateTimeKind.Local).AddTicks(4596), 4 },
                    { 22, 2, null, "ZAM 776", new DateTime(2017, 1, 18, 10, 50, 43, 706, DateTimeKind.Local).AddTicks(4964), 4 },
                    { 24, 8, null, "ZAM 277", new DateTime(2018, 5, 25, 10, 4, 58, 712, DateTimeKind.Local).AddTicks(5802), 0 },
                    { 49, 1, null, "ZAM 95", new DateTime(2018, 8, 14, 7, 3, 37, 511, DateTimeKind.Local).AddTicks(926), 0 },
                    { 50, 2, null, "ZAM 797", new DateTime(2019, 6, 14, 17, 7, 30, 988, DateTimeKind.Local).AddTicks(7710), 4 },
                    { 51, 11, null, "ZAM 132", new DateTime(2018, 3, 21, 8, 27, 8, 532, DateTimeKind.Local).AddTicks(2824), 1 },
                    { 78, 1, null, "ZAM 839", new DateTime(2016, 11, 5, 22, 31, 0, 320, DateTimeKind.Local).AddTicks(4143), 3 },
                    { 79, 8, null, "ZAM 391", new DateTime(2019, 6, 28, 19, 22, 32, 362, DateTimeKind.Local).AddTicks(2342), 0 },
                    { 80, 4, null, "ZAM 421", new DateTime(2018, 12, 30, 6, 22, 41, 486, DateTimeKind.Local).AddTicks(8728), 1 },
                    { 81, 9, null, "ZAM 493", new DateTime(2017, 4, 3, 11, 11, 25, 844, DateTimeKind.Local).AddTicks(2143), 4 },
                    { 82, 7, null, "ZAM 2", new DateTime(2017, 12, 6, 7, 33, 3, 87, DateTimeKind.Local).AddTicks(1186), 1 },
                    { 83, 5, null, "ZAM 713", new DateTime(2018, 12, 15, 22, 44, 45, 40, DateTimeKind.Local).AddTicks(5722), 2 },
                    { 84, 6, null, "ZAM 959", new DateTime(2017, 9, 13, 11, 57, 22, 132, DateTimeKind.Local).AddTicks(1931), 4 },
                    { 85, 14, null, "ZAM 228", new DateTime(2016, 10, 15, 22, 3, 59, 609, DateTimeKind.Local).AddTicks(7465), 0 },
                    { 86, 12, null, "ZAM 314", new DateTime(2019, 9, 1, 18, 58, 14, 166, DateTimeKind.Local).AddTicks(5975), 2 },
                    { 87, 4, null, "ZAM 651", new DateTime(2018, 3, 20, 9, 15, 16, 324, DateTimeKind.Local).AddTicks(5220), 0 },
                    { 88, 13, null, "ZAM 443", new DateTime(2018, 6, 15, 21, 15, 47, 95, DateTimeKind.Local).AddTicks(7327), 3 },
                    { 89, 2, null, "ZAM 142", new DateTime(2018, 4, 7, 10, 44, 37, 894, DateTimeKind.Local).AddTicks(4846), 2 },
                    { 90, 12, null, "ZAM 128", new DateTime(2018, 4, 11, 9, 51, 15, 907, DateTimeKind.Local).AddTicks(1070), 0 },
                    { 91, 9, null, "ZAM 103", new DateTime(2018, 10, 3, 3, 1, 32, 659, DateTimeKind.Local).AddTicks(8325), 1 },
                    { 92, 11, null, "ZAM 508", new DateTime(2018, 4, 3, 2, 25, 55, 727, DateTimeKind.Local).AddTicks(7928), 0 },
                    { 93, 7, null, "ZAM 178", new DateTime(2017, 7, 23, 19, 39, 55, 356, DateTimeKind.Local).AddTicks(344), 1 },
                    { 94, 7, null, "ZAM 88", new DateTime(2018, 11, 26, 0, 37, 59, 273, DateTimeKind.Local).AddTicks(1246), 4 },
                    { 95, 8, null, "ZAM 409", new DateTime(2019, 6, 8, 12, 3, 49, 445, DateTimeKind.Local).AddTicks(5209), 4 },
                    { 96, 5, null, "ZAM 530", new DateTime(2019, 7, 28, 19, 21, 18, 419, DateTimeKind.Local).AddTicks(4353), 0 },
                    { 97, 7, null, "ZAM 621", new DateTime(2018, 2, 21, 19, 12, 23, 251, DateTimeKind.Local).AddTicks(3093), 0 },
                    { 98, 11, null, "ZAM 160", new DateTime(2017, 5, 27, 1, 30, 37, 844, DateTimeKind.Local).AddTicks(8632), 1 },
                    { 77, 1, null, "ZAM 439", new DateTime(2018, 6, 4, 7, 37, 45, 460, DateTimeKind.Local).AddTicks(9363), 3 },
                    { 76, 1, null, "ZAM 942", new DateTime(2019, 8, 20, 7, 5, 48, 90, DateTimeKind.Local).AddTicks(3623), 0 },
                    { 75, 1, null, "ZAM 160", new DateTime(2018, 7, 26, 8, 59, 20, 506, DateTimeKind.Local).AddTicks(363), 3 },
                    { 74, 1, null, "ZAM 351", new DateTime(2018, 2, 7, 12, 41, 3, 412, DateTimeKind.Local).AddTicks(770), 4 },
                    { 52, 13, null, "ZAM 559", new DateTime(2018, 9, 11, 6, 4, 49, 526, DateTimeKind.Local).AddTicks(5762), 4 },
                    { 53, 7, null, "ZAM 128", new DateTime(2019, 1, 16, 23, 19, 26, 257, DateTimeKind.Local).AddTicks(3323), 1 },
                    { 54, 8, null, "ZAM 962", new DateTime(2016, 11, 26, 5, 52, 53, 820, DateTimeKind.Local).AddTicks(2657), 4 },
                    { 55, 11, null, "ZAM 928", new DateTime(2019, 8, 24, 16, 36, 14, 281, DateTimeKind.Local).AddTicks(9282), 2 },
                    { 56, 3, null, "ZAM 583", new DateTime(2017, 8, 26, 6, 14, 33, 647, DateTimeKind.Local).AddTicks(6225), 3 },
                    { 57, 8, null, "ZAM 837", new DateTime(2019, 6, 28, 3, 1, 54, 196, DateTimeKind.Local).AddTicks(6604), 2 },
                    { 58, 11, null, "ZAM 66", new DateTime(2018, 3, 20, 9, 9, 56, 791, DateTimeKind.Local).AddTicks(4420), 4 },
                    { 59, 4, null, "ZAM 380", new DateTime(2018, 10, 8, 6, 26, 11, 774, DateTimeKind.Local).AddTicks(5655), 4 },
                    { 60, 11, null, "ZAM 509", new DateTime(2018, 12, 8, 23, 29, 11, 396, DateTimeKind.Local).AddTicks(7307), 0 },
                    { 61, 2, null, "ZAM 444", new DateTime(2016, 10, 5, 13, 54, 53, 143, DateTimeKind.Local).AddTicks(3881), 0 },
                    { 100, 3, null, "ZAM 680", new DateTime(2017, 4, 2, 1, 10, 37, 268, DateTimeKind.Local).AddTicks(8026), 1 },
                    { 62, 3, null, "ZAM 547", new DateTime(2019, 9, 10, 16, 24, 40, 465, DateTimeKind.Local).AddTicks(5997), 3 },
                    { 64, 7, null, "ZAM 681", new DateTime(2019, 4, 19, 15, 50, 59, 137, DateTimeKind.Local).AddTicks(5229), 2 },
                    { 65, 7, null, "ZAM 733", new DateTime(2019, 7, 12, 20, 0, 35, 618, DateTimeKind.Local).AddTicks(6417), 4 },
                    { 66, 9, null, "ZAM 842", new DateTime(2018, 7, 6, 16, 13, 40, 25, DateTimeKind.Local).AddTicks(7032), 4 },
                    { 67, 10, null, "ZAM 346", new DateTime(2018, 1, 22, 17, 23, 18, 416, DateTimeKind.Local).AddTicks(4425), 0 },
                    { 68, 10, null, "ZAM 57", new DateTime(2018, 1, 28, 11, 22, 45, 83, DateTimeKind.Local).AddTicks(6856), 0 },
                    { 69, 9, null, "ZAM 998", new DateTime(2017, 10, 15, 22, 27, 22, 491, DateTimeKind.Local).AddTicks(4299), 1 },
                    { 70, 12, null, "ZAM 673", new DateTime(2017, 8, 21, 8, 51, 49, 117, DateTimeKind.Local).AddTicks(5197), 3 },
                    { 71, 9, null, "ZAM 399", new DateTime(2018, 9, 14, 18, 52, 44, 222, DateTimeKind.Local).AddTicks(8000), 4 },
                    { 72, 4, null, "ZAM 397", new DateTime(2019, 6, 1, 12, 28, 34, 327, DateTimeKind.Local).AddTicks(964), 0 },
                    { 73, 7, null, "ZAM 757", new DateTime(2018, 6, 2, 21, 58, 51, 935, DateTimeKind.Local).AddTicks(6436), 2 },
                    { 63, 11, null, "ZAM 547", new DateTime(2018, 4, 6, 8, 51, 51, 587, DateTimeKind.Local).AddTicks(9709), 0 },
                    { 1, 12, null, "ZAM 499", new DateTime(2017, 1, 12, 10, 9, 47, 911, DateTimeKind.Local).AddTicks(8576), 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Wooden Gloves", 69.938194684655494m, "1646857182040", "silver", "41155134" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Soft Chair", 36.378708593258008m, "9667075291460", "magenta", "98022618" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Steel Chicken", 30.757852025217316m, "6855860367619", "grey", "99107758" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Granite Soap", 24.822890060405689m, "1042660992119", "ivory", "19430195" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Rustic Fresh Gloves", 64.023615534428362m, "4169437028370", "27797617" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Frozen Sausages", 32.97107784262447m, "2225535270850", "lime", "00465090" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Soft Computer", 16.455081541303162m, "4954765519726", "white", "02582191" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Concrete Chips", 11.546283158728075m, "2506961410158", "magenta", "81514236" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Plastic Hat", 8.6877660479805262m, "5114892208217", "pink", "58558201" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Frozen Chair", 1.84478000218271308m, "6867884907184", "blue", "56617856" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Plastic Hat", 87.387389748537625m, "6829242510702", "salmon", "25314311" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Soft Chair", 50.819559520026439m, "6832492321004", "purple", "54654570" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Unbranded Rubber Sausages", 13.003351267894426m, "5354168971333", "10117477" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Cotton Soap", 40.224768850125694m, "6541952991601", "silver", "37163020" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Plastic Table", 93.831542625013489m, "4675886176857", "maroon", "26929347" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Steel Fish", 76.872980406914416m, "2174128319738", "red", "77015532" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Rubber Pants", 26.06255537227849m, "1947850497279", "magenta", "01957440" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Rubber Table", 8.1140912776412875m, "2337690571212", "white", "71569345" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Plastic Computer", 91.542488223194326m, "6805218551443", "grey", "12796601" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Soft Fish", 57.977276730340582m, "8735138920181", "salmon", "95362762" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Steel Hat", 11.041530108564295m, "6447214814643", "olive", "82313425" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Frozen Car", 48.310370868216412m, "3461118826970", "purple", "91705372" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Frozen Bacon", 16.919878532607082m, "3422845732484", "red", "53695819" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Metal Bike", 68.412279261468097m, "7157252366873", "black", "96080238" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Fresh Towels", 93.960992461052287m, "7780766629464", "white", "88480015" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Fresh Chips", 3.1957497755977069m, "8201355853040", "silver", "62599153" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Plastic Chair", 54.414589316311531m, "7566667879241", "black", "55363501" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Steel Computer", 79.074191520490726m, "4293398428488", "gold", "89195178" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Steel Shirt", 77.506348321450135m, "8865244648140", "violet", "64570723" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Granite Cheese", 5.3714854942501897m, "3196338385449", "maroon", "32283747" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Metal Pants", 7.7788701149536576m, "5971863312218", "purple", "57309767" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Wooden Shoes", 6.2922918057498973m, "5343076678144", "gold", "66512035" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Steel Gloves", 68.430999139990156m, "3300021448643", "salmon", "19336541" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Frozen Shoes", 74.145146089207951m, "2488747408972", "pink", "66646693" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Steel Chips", 32.271400721404459m, "7945668487752", "white", "42600138" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Rubber Chicken", 96.833623506516973m, "9900073256186", "silver", "92840584" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Steel Chair", 83.288879044488424m, "9968662124568", "pink", "58413500" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Fresh Car", 55.433578836002212m, "3933771896008", "indigo", "04583059" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Wooden Pizza", 89.125216020329455m, "1752012188564", "mint green", "38352676" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Plastic Chair", 23.76011961827065m, "0140340101200", "azure", "18874822" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Fresh Shoes", 22.922951172070069m, "6920493876286", "turquoise", "61837461" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Handcrafted Plastic Table", 47.904283052731423m, "8949080170338", "20617332" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Steel Computer", 65.152816104773836m, "0844228348151", "orange", "54786110" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Granite Computer", 42.060254674898602m, "7442098780922", "lime", "35942085" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Wooden Towels", 46.047904726605814m, "6484945577775", "grey", "85259461" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Granite Hat", 62.044674643801882m, "2646678590665", "blue", "13835347" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Wooden Soap", 74.899776765564343m, "7344518087225", "lime", "08908186" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Metal Shirt", 39.549025800800416m, "5391092007929", "plum", "24082679" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Rubber Pants", 33.510290346811684m, "3476388198924", "olive", "16094215" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Metal Cheese", 45.025170373742041m, "1952895992757", "turquoise", "16728721" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Fresh Tuna", 94.814450922335671m, "6898407672531", "salmon", "36293926" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Cotton Cheese", 89.680387860946486m, "5951439239507", "gold", "06495084" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Plastic Pizza", 42.989007831080365m, "5215666100352", "purple", "55243292" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Wooden Sausages", 98.928488909233576m, "4248587103615", "magenta", "14662300" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Frozen Table", 16.030036199386252m, "8458340334033", "red", "28613145" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Wooden Bike", 77.077794088552564m, "5217194584901", "azure", "38763373" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Table", 84.552401209973014m, "7961521726318", "grey", "23240544" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Rubber Bacon", 69.040361711308492m, "3784345287926", "salmon", "32952278" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Metal Shirt", 47.974832211609379m, "1378855100787", "silver", "47380127" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Steel Computer", 30.122695412543953m, "5955710738390", "lime", "67322817" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Wooden Computer", 57.83274217594072m, "9963496120298", "sky blue", "99399047" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Cotton Keyboard", 67.076647620683788m, "7914881370684", "grey", "57242170" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Gloves", 92.662849397707192m, "5135751482647", "pink", "71248912" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Granite Table", 29.402525619325495m, "7932649468978", "teal", "46629197" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Soft Fish", 85.025092860229807m, "9285130071873", "yellow", "29732180" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Granite Chips", 30.536120808933013m, "2901510922340", "white", "64228907" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Fresh Chair", 2.4498827059054195m, "3509999435215", "silver", "39450951" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Cotton Fish", 10.5845627284536844m, "9501564390794", "gold", "11932901" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Steel Sausages", 32.250850331620744m, "4428303981943", "gold", "87960921" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Granite Shoes", 93.549768408085087m, "9277266862609", "cyan", "46096708" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Granite Shoes", 64.69946171049934m, "9402865993809", "turquoise", "26725185" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Fresh Mouse", 7.9630684512495436m, "9365456473787", "turquoise", "63006711" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Fresh Chicken", 91.302241814463547m, "0830683125345", "green", "90546334" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Fresh Soap", 5.8663771934185045m, "0703616066452", "teal", "15799555" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Rubber Car", 37.379817309034936m, "1633571121080", "sky blue", "79418386" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Frozen Ball", 98.574835581041302m, "5393351475203", "yellow", "73484332" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Fresh Mouse", 29.187590395653469m, "0416769142729", "lavender", "87869514" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Granite Shirt", 47.556754263842878m, "9982625610387", "sky blue", "35705055" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Concrete Chair", 80.568157567907206m, "4609781506778", "ivory", "86517003" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Fantastic Frozen Gloves", 73.755355710981097m, "8077899791700", "25938784" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Frozen Ball", 69.822688995312274m, "5474123535063", "azure", "14616082" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Unbranded Granite Bacon", 74.336323206469609m, "1796156988246", "15577269" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Plastic Keyboard", 37.343285454597022m, "0707150965349", "maroon", "27378175" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Concrete Sausages", 58.435905709600066m, "4096806855544", "mint green", "49827279" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Wooden Shoes", 71.895354303016936m, "8883572878206", "red", "63159585" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Frozen Gloves", 60.10213694120857m, "3559430369708", "lavender", "23283763" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Soft Chicken", 67.203826732097164m, "1265278959903", "violet", "12338948" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Wooden Gloves", 31.165246512352171m, "2034263581820", "salmon", "74180844" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Concrete Soap", 5.4683047279102276m, "4276308090319", "blue", "34685310" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Wooden Tuna", 62.716552168930219m, "7557601042098", "violet", "96283837" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Steel Hat", 9.1990628750990476m, "2570056262984", "olive", "40389363" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Metal Salad", 68.292725029072147m, "1375703709406", "azure", "21986734" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Cotton Shirt", 50.539542376315024m, "4468342668870", "teal", "80559184" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Concrete Soap", 49.615136263712854m, "3746222794033", "indigo", "34456842" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Concrete Car", 35.699827577313349m, "1765586288455", "tan", "95345178" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Small Concrete Bike", 45.741459199106989m, "7287805179459", "56118841" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Fresh Soap", 1.19065051162180045m, "5980465951732", "purple", "08473271" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Fresh Sausages", 34.73142649779628m, "0641774966187", "azure", "15604590" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Fresh Chair", 39.958843743409447m, "3618060709084", "red", "23177864" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Rubber Towels", 21.521787855085792m, "5755869154818", "gold", "66805489" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 342.579366007158400m, new TimeSpan(43527942860) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 391.794901104548400m, new TimeSpan(10001475428) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 188.921405416411200m, new TimeSpan(31450364396) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 165.460359894419200m, new TimeSpan(56704326872) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 492.961379323602400m, new TimeSpan(1056782239) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 255.652345975699200m, new TimeSpan(26345247881) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 131.62546885741200m, new TimeSpan(33730074287) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 268.482021693364800m, new TimeSpan(12729315425) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 327.127495886351600m, new TimeSpan(35480410164) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 343.417557628554000m, new TimeSpan(33907384363) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 348.960286308527200m, new TimeSpan(16141082376) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 188.588234637206400m, new TimeSpan(52721115055) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "synthesize", 292.254169002293600m, new TimeSpan(38301478918) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 180.263242535415600m, new TimeSpan(60471183093) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 384.392676634896800m, new TimeSpan(38130879226) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 242.350454694754800m, new TimeSpan(64709684816) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 141.580803525438800m, new TimeSpan(13940109803) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 457.515482025926800m, new TimeSpan(18984142227) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 486.335137666359200m, new TimeSpan(13337521976) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 161.176506458398400m, new TimeSpan(11640132939) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 295.850531289284400m, new TimeSpan(44190692602) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 129.0351590276859600m, new TimeSpan(38970013245) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 308.376772612508800m, new TimeSpan(54787166044) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 258.962429575138800m, new TimeSpan(65411671855) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 164.046115830562000m, new TimeSpan(63245200738) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 193.612149587651600m, new TimeSpan(51136082111) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 351.894195122595200m, new TimeSpan(15259867414) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 277.861118585738000m, new TimeSpan(36330615739) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 261.367042624096800m, new TimeSpan(52460064771) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 143.289711346519200m, new TimeSpan(18405557455) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 205.710144576481600m, new TimeSpan(23593979258) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "navigate", 195.731571175033200m, new TimeSpan(51194288024) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 499.212853051355600m, new TimeSpan(45964353169) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 216.946833635190000m, new TimeSpan(60115262775) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 325.259350717654000m, new TimeSpan(50871307311) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 352.4570363818000m, new TimeSpan(52824485915) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "navigate", 261.426633857854800m, new TimeSpan(52690137854) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 412.223284650698000m, new TimeSpan(37670816040) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 120.8352217547759600m, new TimeSpan(3238094287) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 375.420585961742400m, new TimeSpan(48180260953) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 341.14613525622800m, new TimeSpan(29715671028) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 394.178189474240800m, new TimeSpan(9585411300) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 285.457905468278400m, new TimeSpan(66296618038) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 260.991115011736400m, new TimeSpan(16991873377) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 363.542056765194000m, new TimeSpan(24290525068) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "navigate", 282.490036535304800m, new TimeSpan(63468318216) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 496.88242561970000m, new TimeSpan(55603801124) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 330.099992561200800m, new TimeSpan(50735353948) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 128.7897400692057600m, new TimeSpan(34827634787) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 268.22822474326400m, new TimeSpan(13481342896) });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
