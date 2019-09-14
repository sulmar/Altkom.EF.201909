using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Altkom.Shop.DbRepositories.Migrations
{
    public partial class AddRowVersionToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Customers",
                rowVersion: true,
                nullable: true);

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Fresh Gloves", 64.023615534428362m, "4169437028370", "grey", "27797617" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Generic Soft Computer", 16.455081541303162m, "4954765519726", "02582191" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Handmade Soft Chair", 50.819559520026439m, "6832492321004", "54654570" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Rubber Sausages", 13.003351267894426m, "5354168971333", "mint green", "10117477" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Plastic Table", 47.904283052731423m, "8949080170338", "violet", "20617332" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Refined Wooden Bike", 77.077794088552564m, "5217194584901", "38763373" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Frozen Gloves", 73.755355710981097m, "8077899791700", "turquoise", "25938784" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Granite Bacon", 74.336323206469609m, "1796156988246", "purple", "15577269" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Concrete Bike", 45.741459199106989m, "7287805179459", "tan", "56118841" });

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
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 327.127495886351600m, new TimeSpan(35480410164) });

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
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 351.894195122595200m, new TimeSpan(15259867414) });

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
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 496.88242561970000m, new TimeSpan(55603801124) });

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
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 268.22822474326400m, new TimeSpan(13481342896) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Cotton Tuna", 47.920179231520804m, "1612548488555", "violet", "06067274" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Rubber Shirt", 35.675093524006738m, "2560281071772", "lime", "23531703" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Steel Soap", 87.179463225034696m, "1813618524009", "ivory", "87197587" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Concrete Pants", 83.737886810087575m, "6438505188932", "grey", "77463159" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Cotton Towels", 94.937494222511335m, "5166278858721", "maroon", "80019817" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Fresh Bike", 88.781209952561785m, "1157750289236", "red", "48819084" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Small Concrete Fish", 95.70880515440773m, "0394265785506", "11008439" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Metal Cheese", 86.043723764384044m, "9097039943645", "yellow", "65913550" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Fresh Chips", 85.70325581529328m, "9805874457520", "indigo", "68655655" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Rubber Pants", 84.414890661097501m, "5163188101725", "black", "24069298" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Soft Towels", 48.307616134783048m, "8926212348063", "sky blue", "10269312" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Ergonomic Cotton Bike", 47.201401303616053m, "5993752760412", "62999489" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Cotton Hat", 10.7957204798216599m, "9296504471038", "gold", "19695204" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Steel Chair", 51.841331064627202m, "4156677130345", "magenta", "66256045" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Rubber Cheese", 10.0165062681848638m, "7891442922134", "red", "58793893" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Wooden Ball", 41.267141126220646m, "0446654845879", "cyan", "85798427" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Fresh Car", 99.010979426098486m, "2413664660097", "indigo", "95277394" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Steel Computer", 80.95359080655199m, "1021984236314", "indigo", "31170215" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Soft Chair", 24.465302333918038m, "1561808133264", "black", "43676859" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Wooden Gloves", 4.1762587740906781m, "1296932399933", "orchid", "23338173" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Granite Bike", 58.416623036571106m, "5426170920965", "magenta", "12200962" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Hat", 19.45481309688412m, "5240327602050", "black", "16128910" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Soft Mouse", 91.365305824841014m, "8799863299097", "salmon", "39692351" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Soft Sausages", 18.698335359198175m, "7474139718168", "grey", "38749858" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Concrete Pizza", 51.764756482450648m, "3290124176140", "cyan", "99150389" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Steel Soap", 69.48197182709443m, "6103177568084", "violet", "39584083" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Plastic Shoes", 8.5847207156870149m, "6912330364407", "silver", "20908577" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Plastic Mouse", 91.408672027480114m, "7907187260711", "blue", "54127715" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Granite Soap", 23.318114237076691m, "1881541370543", "grey", "23177130" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Soft Shirt", 51.664666328422993m, "3530125137635", "grey", "06728342" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Soft Chair", 55.666798012175932m, "6313130344703", "violet", "10244302" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Soft Fish", 61.468456187969236m, "4130394548478", "yellow", "12006298" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Metal Computer", 24.027423082863661m, "0905747860996", "indigo", "00050159" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Granite Shirt", 5.0731407408943108m, "3084712705931", "black", "88801513" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Steel Chips", 46.83706571340424m, "1466181657263", "orchid", "52057199" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Metal Soap", 16.601111963671168m, "2501339202335", "yellow", "56614282" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Concrete Table", 33.921716826931471m, "4521155484355", "azure", "80217060" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Soft Chair", 2.3099565847357495m, "5708844011682", "mint green", "08057846" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Wooden Pants", 66.072847790118718m, "0646600750541", "grey", "47630345" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Cotton Computer", 3.8686526673234364m, "9059209436715", "fuchsia", "08400932" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Rubber Car", 80.750160323339572m, "2109670655652", "green", "40441108" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Granite Pants", 46.927315077244876m, "8354005305717", "purple", "00766050" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Frozen Towels", 92.927484936047134m, "4891520778021", "red", "16550254" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Shoes", 16.226326319494411m, "4418988985923", "yellow", "13874933" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Cotton Hat", 58.60281328186528m, "5049466137702", "green", "02889146" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Plastic Pants", 38.474439854954608m, "4744932991383", "orchid", "49429794" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Soft Chicken", 99.850931787328336m, "1517993277566", "black", "12205714" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Frozen Shirt", 66.704505054608233m, "6269399601234", "green", "15907110" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Soft Chair", 3.0402466752753811m, "4988664111071", "magenta", "24977968" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Fresh Salad", 1.61513600946177556m, "8126777829438", "green", "11937029" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Concrete Fish", 31.232260733485294m, "2483207507059", "pink", "47444140" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Granite Towels", 41.304939637102624m, "9238685539435", "olive", "83622830" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Granite Chips", 49.978304820590761m, "6853744782497", "lavender", "68911416" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Wooden Towels", 64.965731925315088m, "4200115423282", "blue", "22895745" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Metal Hat", 33.056892940801069m, "9126346525852", "grey", "33576978" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Handcrafted Wooden Salad", 77.973625656205102m, "6195691777097", "98077656" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Plastic Towels", 64.480657412894392m, "1799927823012", "yellow", "40933177" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Rubber Cheese", 62.570091306497356m, "8960515368496", "fuchsia", "92850279" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Fresh Ball", 61.326064659900061m, "7142598591096", "orchid", "66217657" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Steel Shirt", 85.205003438147284m, "2260810079230", "green", "63860894" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Fresh Salad", 65.076146048529109m, "0581269774920", "orange", "37770020" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Fresh Hat", 26.103055877659045m, "8958058433931", "violet", "29709564" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Rubber Pants", 98.177608552005883m, "0171529104231", "black", "11625483" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Cotton Shoes", 83.587364773073875m, "3268220252785", "purple", "76914720" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Plastic Sausages", 84.493299073769398m, "8368734666827", "cyan", "50973989" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Fresh Table", 15.618644571219832m, "5750164937982", "azure", "52518119" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Metal Towels", 84.132935730336646m, "8447505097302", "pink", "84401892" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Steel Bike", 78.762667288893202m, "4601721912168", "purple", "17421997" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Granite Pants", 61.751455524820621m, "6199672823292", "violet", "04366485" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Fresh Pizza", 87.277887077665789m, "4761142925564", "maroon", "31249331" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Granite Mouse", 48.666169389461194m, "6214572825594", "ivory", "00680363" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Metal Pants", 72.450890199025579m, "1468499859582", "tan", "37353636" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Plastic Table", 13.937438478664216m, "6571978996311", "azure", "03426647" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Fresh Hat", 71.929165261764601m, "9112368807182", "orange", "18980684" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Concrete Table", 37.045776641017627m, "2009824894183", "red", "66637417" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Granite Computer", 69.918494571893692m, "6608088760928", "gold", "58073391" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Wooden Bike", 52.490605945461661m, "9590008792324", "turquoise", "25815313" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Plastic Bacon", 30.738889335533059m, "3408641546845", "cyan", "88662237" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Fresh Hat", 61.181787300008275m, "4702068671661", "indigo", "09150782" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Plastic Pants", 73.832789744172568m, "6523053592482", "ivory", "39577276" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Steel Towels", 76.372264559088442m, "0727091133546", "grey", "44527174" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Concrete Mouse", 96.933104627268898m, "2083555698227", "yellow", "25401240" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Steel Ball", 59.558470486457689m, "6590288851592", "orange", "07677854" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Plastic Sausages", 12.804189780170161m, "6762727285798", "black", "65319468" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Rubber Sausages", 52.06198219305931m, "6714461366356", "grey", "16033207" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Rubber Computer", 2.2574776104919072m, "5467682082604", "black", "02714431" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Fresh Sausages", 91.515785449424698m, "3377443058903", "grey", "03673270" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Steel Gloves", 17.962551291548863m, "4906211642335", "purple", "15638540" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Soft Computer", 81.751705057337743m, "7568103305253", "green", "37747251" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Plastic Chicken", 54.381021260926942m, "6304518780879", "ivory", "42549031" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Steel Chair", 31.524557704815889m, "8940120488178", "purple", "09787476" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Steel Chair", 56.957585469334219m, "6199914638554", "turquoise", "78559486" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Fresh Shirt", 15.679924585707403m, "2488372899398", "silver", "31474542" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Wooden Mouse", 76.014420421800772m, "9234143879655", "fuchsia", "35356769" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Rubber Keyboard", 47.268360388590175m, "0115326129912", "fuchsia", "38655425" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Fresh Shirt", 36.011181329382214m, "2855543304300", "cyan", "38452529" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Concrete Mouse", 89.96394330773686m, "1110363172258", "indigo", "71586601" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Rubber Keyboard", 14.428346313735595m, "9729602067440", "ivory", "22931238" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Frozen Cheese", 98.322114570216382m, "9470123594167", "purple", "44569280" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Wooden Soap", 82.681503265016479m, "6672202990911", "maroon", "32933857" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 273.45699880898800m, new TimeSpan(37621081280) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 308.14186511940400m, new TimeSpan(14856009516) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 215.463519336406000m, new TimeSpan(42244667684) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 203.771056469423200m, new TimeSpan(41281663452) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 417.225070817966400m, new TimeSpan(19829611489) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 232.151944251801600m, new TimeSpan(27461223220) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 403.546174011913200m, new TimeSpan(16002156489) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "navigate", 105.7130171012659600m, new TimeSpan(26777538737) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 193.417525893737200m, new TimeSpan(18679462125) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 294.513376892783200m, new TimeSpan(69444757337) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 176.248085348051200m, new TimeSpan(7154292117) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 207.548011330677200m, new TimeSpan(54163234807) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 328.727674218233600m, new TimeSpan(67818801461) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 147.054765581644400m, new TimeSpan(57480525606) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 201.999234641901600m, new TimeSpan(54600944630) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "input", 121.8711916459124400m, new TimeSpan(43570201499) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 212.2695504279200m, new TimeSpan(60943246549) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 352.998791566583600m, new TimeSpan(18281697401) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 342.386475132026800m, new TimeSpan(30193916707) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 115.6167304216030800m, new TimeSpan(20650381061) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 182.630817630622000m, new TimeSpan(57771025640) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 141.583890859775200m, new TimeSpan(4954134802) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 234.58134053954000m, new TimeSpan(37741870708) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 452.677056916373600m, new TimeSpan(54616368606) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 497.326681761688800m, new TimeSpan(46168453517) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 336.06573335643200m, new TimeSpan(54668480843) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 359.315683440918000m, new TimeSpan(12878340165) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 457.3243694181200m, new TimeSpan(14803888764) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 251.935076598047600m, new TimeSpan(40184872881) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 419.721626266707600m, new TimeSpan(47729076516) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 461.273286101070000m, new TimeSpan(38359969883) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 178.852028622688800m, new TimeSpan(65596310631) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 162.64573208179600m, new TimeSpan(10874761881) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "synthesize", 206.81402557846800m, new TimeSpan(51712173199) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 412.746679928501600m, new TimeSpan(28726648832) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 183.002177664545600m, new TimeSpan(46020979765) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 499.760194681473200m, new TimeSpan(1137733520) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 314.816380205944400m, new TimeSpan(28134188457) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 217.040482031666000m, new TimeSpan(22555160678) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 301.657775324610000m, new TimeSpan(52136786567) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 351.415425656091200m, new TimeSpan(38674748569) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 176.094769908159200m, new TimeSpan(70452678747) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 413.744451996751200m, new TimeSpan(57325437565) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "input", 271.178505090614000m, new TimeSpan(31215600229) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "quantify", 469.609912656997200m, new TimeSpan(27450298415) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 329.338499079150400m, new TimeSpan(8023984108) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "UnitPrice", "Duration" },
                values: new object[] { 112.0812935810914800m, new TimeSpan(12407921808) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 193.107504627251600m, new TimeSpan(57593057685) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 369.132679081118000m, new TimeSpan(26362243061) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 318.868775022620800m, new TimeSpan(65126078386) });
        }
    }
}
