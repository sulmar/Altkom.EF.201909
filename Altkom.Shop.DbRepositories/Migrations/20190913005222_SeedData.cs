using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Altkom.Shop.DbRepositories.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[,]
                {
                    { 51, "Product", "Awesome Granite Hat", 74.07055433423746m, "1751935716465", "lime", "97995623" },
                    { 147, "Product", "Generic Frozen Pizza", 36.75806210225359m, "7623842320421", "gold", "77860743" },
                    { 148, "Product", "Handcrafted Soft Keyboard", 73.901588606602327m, "2978488221164", "lime", "61239050" },
                    { 149, "Product", "Sleek Frozen Shoes", 66.572182191336634m, "2779441955092", "ivory", "63932102" },
                    { 150, "Product", "Generic Concrete Chair", 9.7783239156838192m, "4136142340561", "azure", "09879119" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Duration" },
                values: new object[,]
                {
                    { 1, "Service", "reboot", 271.219475647071200m, new TimeSpan(48783663601) },
                    { 2, "Service", "hack", 351.281255973168400m, new TimeSpan(67651735110) }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { 146, "Product", "Tasty Fresh Soap", 79.48286105435479m, "2098384172374", "tan", "89124130" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Duration" },
                values: new object[,]
                {
                    { 3, "Service", "back up", 393.596391330285200m, new TimeSpan(27375611065) },
                    { 5, "Service", "reboot", 132.3942268418121200m, new TimeSpan(384231035) },
                    { 6, "Service", "connect", 424.573352525277600m, new TimeSpan(71575524162) },
                    { 7, "Service", "generate", 493.04346348766400m, new TimeSpan(56221428566) },
                    { 8, "Service", "parse", 267.333056483107200m, new TimeSpan(58485270039) },
                    { 9, "Service", "compress", 228.097397521183600m, new TimeSpan(46895253404) },
                    { 10, "Service", "generate", 249.133016424781200m, new TimeSpan(64802867305) },
                    { 4, "Service", "override", 286.597106692659200m, new TimeSpan(52165475408) }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[,]
                {
                    { 145, "Product", "Licensed Steel Fish", 27.415747603129456m, "2856275144820", "teal", "50596423" },
                    { 144, "Product", "Ergonomic Steel Cheese", 92.128398334201558m, "2445646400384", "white", "25138269" },
                    { 143, "Product", "Small Metal Towels", 83.481115780994788m, "2270696132820", "orchid", "33789347" },
                    { 128, "Product", "Gorgeous Metal Gloves", 27.723544750233892m, "1737586590425", "fuchsia", "81075751" },
                    { 129, "Product", "Handmade Rubber Computer", 97.450974920043271m, "5243133275869", "orchid", "44165666" },
                    { 130, "Product", "Fantastic Soft Salad", 34.91599064130145m, "8225101567128", "azure", "42466154" },
                    { 131, "Product", "Incredible Granite Ball", 76.9260619603684m, "5970912835586", "blue", "07174292" },
                    { 132, "Product", "Intelligent Fresh Bike", 89.285753568301795m, "2931255301018", "teal", "20654399" },
                    { 133, "Product", "Handmade Rubber Towels", 89.926929196308775m, "0891558675891", "cyan", "80579182" },
                    { 134, "Product", "Licensed Frozen Table", 72.57388961155609m, "5338934644041", "grey", "64852348" },
                    { 135, "Product", "Intelligent Metal Fish", 39.032076410964163m, "8295860135517", "grey", "10730249" },
                    { 136, "Product", "Tasty Steel Car", 14.127883889306329m, "3364471869977", "turquoise", "38873904" },
                    { 137, "Product", "Unbranded Metal Gloves", 26.017401854515708m, "5169233714254", "black", "06763657" },
                    { 138, "Product", "Small Steel Chair", 88.041687459704362m, "4700995693831", "mint green", "01625257" },
                    { 139, "Product", "Generic Plastic Fish", 73.766415720231046m, "2472102514545", "olive", "33819655" },
                    { 140, "Product", "Refined Cotton Soap", 60.187569866509942m, "0378415003856", "mint green", "12590223" },
                    { 141, "Product", "Generic Wooden Sausages", 94.61064458201203m, "4399898885285", "mint green", "34098547" },
                    { 142, "Product", "Awesome Plastic Chair", 58.967612596679302m, "1565195835305", "olive", "16205963" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Duration" },
                values: new object[,]
                {
                    { 11, "Service", "navigate", 276.411061257315200m, new TimeSpan(64978325181) },
                    { 12, "Service", "input", 255.426374522702000m, new TimeSpan(50519316697) },
                    { 13, "Service", "override", 309.451721706172400m, new TimeSpan(27193155406) },
                    { 14, "Service", "transmit", 432.192629544154000m, new TimeSpan(34194425219) },
                    { 34, "Service", "transmit", 218.099743741610800m, new TimeSpan(69278878200) },
                    { 35, "Service", "index", 318.557580103426000m, new TimeSpan(24135692105) },
                    { 36, "Service", "hack", 205.575818431366000m, new TimeSpan(25323452276) },
                    { 37, "Service", "connect", 354.14883413079600m, new TimeSpan(71027888093) },
                    { 38, "Service", "connect", 461.999829654581600m, new TimeSpan(55431928020) },
                    { 39, "Service", "hack", 393.459471638062800m, new TimeSpan(57123472188) },
                    { 40, "Service", "calculate", 111.4939538815496400m, new TimeSpan(22275923844) },
                    { 41, "Service", "calculate", 318.211197395907200m, new TimeSpan(27480922168) },
                    { 42, "Service", "compress", 344.695294948618400m, new TimeSpan(68687580126) },
                    { 43, "Service", "calculate", 318.679488179590400m, new TimeSpan(13288313332) },
                    { 44, "Service", "transmit", 176.866586728425200m, new TimeSpan(26939672941) },
                    { 45, "Service", "generate", 153.472592147752800m, new TimeSpan(59615329893) },
                    { 46, "Service", "override", 160.147297969156400m, new TimeSpan(9828391508) },
                    { 47, "Service", "index", 216.259390914933600m, new TimeSpan(17412707009) },
                    { 48, "Service", "back up", 421.072746217750400m, new TimeSpan(12538813977) },
                    { 33, "Service", "hack", 325.793171965420800m, new TimeSpan(2756991116) }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { 127, "Product", "Gorgeous Wooden Car", 75.188953057950775m, "8049481641151", "orchid", "98080908" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Duration" },
                values: new object[,]
                {
                    { 32, "Service", "bypass", 306.103414579342800m, new TimeSpan(25502445203) },
                    { 30, "Service", "compress", 423.808911779806400m, new TimeSpan(33366415427) },
                    { 15, "Service", "back up", 441.384829367224400m, new TimeSpan(61346845816) },
                    { 16, "Service", "hack", 161.36335826542400m, new TimeSpan(6961476594) },
                    { 17, "Service", "program", 351.51323352545200m, new TimeSpan(32299035244) },
                    { 18, "Service", "program", 120.6132235101485600m, new TimeSpan(45069190486) },
                    { 19, "Service", "reboot", 470.05739992952800m, new TimeSpan(699555450) },
                    { 20, "Service", "program", 457.251176590682400m, new TimeSpan(22173094521) },
                    { 21, "Service", "copy", 290.512378416262800m, new TimeSpan(26003407483) },
                    { 22, "Service", "connect", 426.068212057495600m, new TimeSpan(1833488178) },
                    { 23, "Service", "transmit", 176.480701601356400m, new TimeSpan(49854213417) },
                    { 24, "Service", "copy", 217.426055165671600m, new TimeSpan(20721893547) },
                    { 25, "Service", "calculate", 379.927377533133600m, new TimeSpan(10953150110) },
                    { 26, "Service", "copy", 475.458021636800m, new TimeSpan(40670680881) },
                    { 27, "Service", "parse", 149.296020925648400m, new TimeSpan(12012127066) },
                    { 28, "Service", "generate", 373.159755148533600m, new TimeSpan(53571560922) },
                    { 29, "Service", "connect", 302.313079592917600m, new TimeSpan(28043610794) },
                    { 31, "Service", "synthesize", 235.82838780052400m, new TimeSpan(45396098121) }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[,]
                {
                    { 126, "Product", "Practical Rubber Pants", 51.243631496673274m, "6962230556303", "azure", "49014600" },
                    { 125, "Product", "Rustic Plastic Tuna", 79.975645501155238m, "2808560311462", "plum", "46677297" },
                    { 124, "Product", "Refined Steel Shoes", 20.051243426767717m, "8235847675919", "black", "67752577" },
                    { 71, "Product", "Unbranded Cotton Chair", 61.896160097744356m, "5741804556212", "maroon", "64075655" },
                    { 72, "Product", "Rustic Plastic Cheese", 75.919414734430354m, "2105890012756", "pink", "21624728" },
                    { 73, "Product", "Sleek Soft Car", 43.654262516952229m, "5513932191869", "indigo", "09755208" },
                    { 74, "Product", "Handcrafted Granite Shoes", 12.353543557856929m, "9313008512033", "grey", "87179569" },
                    { 75, "Product", "Incredible Steel Keyboard", 80.132089973023252m, "0712661007358", "salmon", "28182351" },
                    { 76, "Product", "Unbranded Cotton Chicken", 7.4827726671857644m, "1341830915324", "cyan", "86841924" },
                    { 77, "Product", "Fantastic Granite Table", 69.331051205439022m, "4789436612136", "green", "19267449" },
                    { 78, "Product", "Awesome Fresh Chair", 56.36960535513682m, "5069165594606", "olive", "51489618" },
                    { 79, "Product", "Sleek Granite Pants", 71.363331212831371m, "6539175571441", "yellow", "66557531" },
                    { 80, "Product", "Incredible Concrete Keyboard", 37.890895205033452m, "9678741065353", "plum", "25419122" },
                    { 81, "Product", "Handmade Frozen Computer", 15.411469485336715m, "1679168447041", "white", "96829370" },
                    { 82, "Product", "Fantastic Steel Ball", 49.664956162993291m, "0281978955701", "black", "72907801" },
                    { 83, "Product", "Awesome Frozen Mouse", 45.519909342061681m, "2033298135985", "white", "86468091" },
                    { 84, "Product", "Unbranded Soft Towels", 21.421192532135725m, "4744977005892", "indigo", "35756668" },
                    { 85, "Product", "Gorgeous Steel Mouse", 28.913186398760047m, "4464973446948", "green", "54167889" },
                    { 70, "Product", "Intelligent Wooden Fish", 73.295679236899888m, "4162273429387", "lavender", "37962623" },
                    { 86, "Product", "Licensed Granite Ball", 78.455119222614529m, "3473034353058", "pink", "12022359" },
                    { 69, "Product", "Practical Metal Pants", 25.513481609296768m, "7257226349182", "olive", "54110281" },
                    { 67, "Product", "Practical Steel Fish", 50.526603358111594m, "5672425105575", "plum", "11849773" },
                    { 52, "Product", "Ergonomic Rubber Fish", 13.550668418663848m, "7357642687902", "teal", "69207587" },
                    { 53, "Product", "Handmade Fresh Gloves", 12.938523177028888m, "9919276503454", "olive", "87074772" },
                    { 54, "Product", "Refined Fresh Gloves", 25.859236867101505m, "4195764808866", "plum", "23401303" },
                    { 55, "Product", "Awesome Rubber Keyboard", 1.55752176584560456m, "4169028065418", "blue", "81838554" },
                    { 56, "Product", "Refined Granite Towels", 61.832900529183871m, "3794700808161", "yellow", "94780895" },
                    { 57, "Product", "Unbranded Plastic Mouse", 97.639821566473636m, "4630012955638", "red", "23265608" },
                    { 58, "Product", "Small Concrete Shoes", 35.230096775679904m, "7790592059915", "maroon", "70786101" },
                    { 59, "Product", "Refined Cotton Soap", 26.501203671331168m, "5302220229236", "olive", "12463688" },
                    { 60, "Product", "Fantastic Wooden Salad", 75.743980650205174m, "9238115213416", "tan", "89839782" },
                    { 61, "Product", "Handmade Plastic Chicken", 85.639617577493011m, "7492632445398", "grey", "81013920" },
                    { 62, "Product", "Licensed Concrete Fish", 28.488877696212823m, "7436217559063", "maroon", "13670078" },
                    { 63, "Product", "Generic Fresh Shoes", 87.832370592203203m, "6737085575416", "ivory", "06128746" },
                    { 64, "Product", "Ergonomic Cotton Chips", 54.996291053945317m, "2587447905948", "blue", "89574591" },
                    { 65, "Product", "Licensed Rubber Fish", 50.291526794103649m, "8548456382452", "pink", "98027507" },
                    { 66, "Product", "Handmade Metal Table", 54.56246965823809m, "2645442784897", "azure", "09448667" },
                    { 68, "Product", "Unbranded Wooden Bike", 53.063279598049489m, "1661094298972", "gold", "60258687" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Duration" },
                values: new object[] { 49, "Service", "connect", 198.838259325753200m, new TimeSpan(31289140466) });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[,]
                {
                    { 87, "Product", "Awesome Concrete Chips", 17.162504877970792m, "4044292912159", "white", "99401696" },
                    { 89, "Product", "Ergonomic Granite Pants", 37.867683481363405m, "9469288768667", "white", "89965009" },
                    { 109, "Product", "Small Plastic Sausages", 59.647294516045312m, "5915331846348", "turquoise", "67559213" },
                    { 110, "Product", "Intelligent Soft Shoes", 93.621343901670199m, "9402079275739", "orange", "58894651" },
                    { 111, "Product", "Fantastic Rubber Chair", 12.123817091399683m, "5757132748588", "turquoise", "28877073" },
                    { 112, "Product", "Tasty Wooden Computer", 68.445065867828671m, "4215259345727", "mint green", "11133094" },
                    { 113, "Product", "Intelligent Frozen Chicken", 67.340768954409631m, "8723895364393", "plum", "27599242" },
                    { 114, "Product", "Small Rubber Soap", 74.211700826981926m, "9489149455642", "sky blue", "36450466" },
                    { 115, "Product", "Licensed Concrete Keyboard", 65.784707882341282m, "5079505226333", "salmon", "15124937" },
                    { 116, "Product", "Small Steel Soap", 64.358644596468067m, "8856987732319", "orange", "60850423" },
                    { 117, "Product", "Gorgeous Steel Table", 87.393190478157838m, "2328845444161", "turquoise", "49239508" },
                    { 118, "Product", "Intelligent Steel Soap", 15.774877810745866m, "1865890741469", "violet", "58986875" },
                    { 119, "Product", "Unbranded Wooden Computer", 32.172936208161022m, "1866952178797", "blue", "89644324" },
                    { 120, "Product", "Sleek Metal Cheese", 71.917159501424566m, "6213245975499", "blue", "23798281" },
                    { 121, "Product", "Ergonomic Steel Chair", 27.035139838715623m, "2365976406071", "lime", "39923813" },
                    { 122, "Product", "Sleek Metal Keyboard", 68.087476343422909m, "6342709624090", "yellow", "70999983" },
                    { 123, "Product", "Incredible Steel Towels", 90.346899844867654m, "3642872515861", "azure", "33706443" },
                    { 108, "Product", "Incredible Plastic Ball", 55.364615763707359m, "6602363125594", "silver", "67061037" },
                    { 88, "Product", "Fantastic Metal Table", 86.275868937967279m, "8503947045995", "sky blue", "90160035" },
                    { 107, "Product", "Sleek Granite Towels", 25.503250947456457m, "2669160823447", "violet", "17700016" },
                    { 105, "Product", "Fantastic Frozen Pizza", 20.126595655049509m, "1111214338250", "sky blue", "41914373" },
                    { 90, "Product", "Ergonomic Cotton Keyboard", 5.1735756342176182m, "4303354227359", "green", "87867237" },
                    { 91, "Product", "Practical Granite Cheese", 9.9729783912063493m, "1639491536492", "mint green", "75304331" },
                    { 92, "Product", "Awesome Granite Pizza", 21.604243012892209m, "2468005959262", "lime", "24825719" },
                    { 93, "Product", "Incredible Fresh Pizza", 85.538995885075501m, "8360166686794", "white", "33520544" },
                    { 94, "Product", "Incredible Metal Cheese", 66.176788485691333m, "5057264454075", "lavender", "44882570" },
                    { 95, "Product", "Handmade Soft Sausages", 93.222306737779834m, "2918409156502", "white", "18321241" },
                    { 96, "Product", "Incredible Fresh Cheese", 83.847746206376569m, "7557912712536", "sky blue", "46054913" },
                    { 97, "Product", "Unbranded Soft Fish", 90.275399356743028m, "2544409316082", "maroon", "42144892" },
                    { 98, "Product", "Fantastic Frozen Cheese", 78.22243462746142m, "2844695981439", "plum", "67313112" },
                    { 99, "Product", "Sleek Wooden Keyboard", 24.428779422970834m, "7740880278252", "black", "54720107" },
                    { 100, "Product", "Handmade Soft Cheese", 77.301831665123713m, "5752800061792", "olive", "54101258" },
                    { 101, "Product", "Sleek Metal Towels", 37.433492359907104m, "4873195997501", "fuchsia", "27478196" },
                    { 102, "Product", "Licensed Soft Cheese", 75.872860039059445m, "0004201826896", "salmon", "26976808" },
                    { 103, "Product", "Unbranded Steel Cheese", 58.861683818447212m, "8893720611302", "maroon", "81696789" },
                    { 104, "Product", "Unbranded Granite Shoes", 17.131864847676787m, "1279706926634", "yellow", "07005183" },
                    { 106, "Product", "Sleek Plastic Pizza", 22.54130992737658m, "7807627232851", "fuchsia", "84711298" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Discriminator", "Name", "UnitPrice", "Duration" },
                values: new object[] { 50, "Service", "program", 471.439407938830400m, new TimeSpan(56275909729) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
