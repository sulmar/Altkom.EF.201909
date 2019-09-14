using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Altkom.Shop.DbRepositories.Migrations
{
    public partial class ChangeAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceAddress_City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoiceAddress_Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoiceAddress_PostCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "InvoiceAddress_Street",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_PostCode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingAddress_Street",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "InvoiceAddresses",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceAddresses", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_InvoiceAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddresses",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddresses", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_ShippingAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Concrete Fish", 95.70880515440773m, "0394265785506", "white", "11008439" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Cotton Bike", 47.201401303616053m, "5993752760412", "purple", "62999489" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Rustic Soft Sausages", 18.698335359198175m, "7474139718168", "38749858" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Wooden Salad", 77.973625656205102m, "6195691777097", "azure", "98077656" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Generic Plastic Table", 13.937438478664216m, "6571978996311", "03426647" });

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
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Tasty Rubber Sausages", 52.06198219305931m, "6714461366356", "16033207" });

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
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 359.315683440918000m, new TimeSpan(12878340165) });

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
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 112.0812935810914800m, new TimeSpan(12407921808) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceAddresses");

            migrationBuilder.DropTable(
                name: "ShippingAddresses");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceAddress_City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceAddress_Country",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceAddress_PostCode",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceAddress_Street",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Country",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_PostCode",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Street",
                table: "Customers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Granite Hat", 74.07055433423746m, "1751935716465", "lime", "97995623" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Rubber Fish", 13.550668418663848m, "7357642687902", "teal", "69207587" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Fresh Gloves", 12.938523177028888m, "9919276503454", "olive", "87074772" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Fresh Gloves", 25.859236867101505m, "4195764808866", "plum", "23401303" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Rubber Keyboard", 1.55752176584560456m, "4169028065418", "blue", "81838554" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Granite Towels", 61.832900529183871m, "3794700808161", "yellow", "94780895" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Plastic Mouse", 97.639821566473636m, "4630012955638", "red", "23265608" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Concrete Shoes", 35.230096775679904m, "7790592059915", "maroon", "70786101" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Cotton Soap", 26.501203671331168m, "5302220229236", "olive", "12463688" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Wooden Salad", 75.743980650205174m, "9238115213416", "tan", "89839782" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Plastic Chicken", 85.639617577493011m, "7492632445398", "grey", "81013920" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Concrete Fish", 28.488877696212823m, "7436217559063", "maroon", "13670078" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Fresh Shoes", 87.832370592203203m, "6737085575416", "ivory", "06128746" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Cotton Chips", 54.996291053945317m, "2587447905948", "blue", "89574591" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Rubber Fish", 50.291526794103649m, "8548456382452", "pink", "98027507" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Metal Table", 54.56246965823809m, "2645442784897", "azure", "09448667" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Steel Fish", 50.526603358111594m, "5672425105575", "plum", "11849773" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Wooden Bike", 53.063279598049489m, "1661094298972", "gold", "60258687" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Metal Pants", 25.513481609296768m, "7257226349182", "olive", "54110281" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Wooden Fish", 73.295679236899888m, "4162273429387", "lavender", "37962623" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Cotton Chair", 61.896160097744356m, "5741804556212", "maroon", "64075655" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Plastic Cheese", 75.919414734430354m, "2105890012756", "pink", "21624728" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Soft Car", 43.654262516952229m, "5513932191869", "indigo", "09755208" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Handcrafted Granite Shoes", 12.353543557856929m, "9313008512033", "87179569" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Steel Keyboard", 80.132089973023252m, "0712661007358", "salmon", "28182351" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Cotton Chicken", 7.4827726671857644m, "1341830915324", "cyan", "86841924" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Granite Table", 69.331051205439022m, "4789436612136", "green", "19267449" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Fresh Chair", 56.36960535513682m, "5069165594606", "olive", "51489618" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Granite Pants", 71.363331212831371m, "6539175571441", "yellow", "66557531" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Concrete Keyboard", 37.890895205033452m, "9678741065353", "plum", "25419122" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Frozen Computer", 15.411469485336715m, "1679168447041", "white", "96829370" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Steel Ball", 49.664956162993291m, "0281978955701", "black", "72907801" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Frozen Mouse", 45.519909342061681m, "2033298135985", "white", "86468091" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Soft Towels", 21.421192532135725m, "4744977005892", "indigo", "35756668" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Steel Mouse", 28.913186398760047m, "4464973446948", "green", "54167889" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Granite Ball", 78.455119222614529m, "3473034353058", "pink", "12022359" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Concrete Chips", 17.162504877970792m, "4044292912159", "white", "99401696" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Metal Table", 86.275868937967279m, "8503947045995", "sky blue", "90160035" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Granite Pants", 37.867683481363405m, "9469288768667", "white", "89965009" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Cotton Keyboard", 5.1735756342176182m, "4303354227359", "green", "87867237" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Granite Cheese", 9.9729783912063493m, "1639491536492", "mint green", "75304331" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Granite Pizza", 21.604243012892209m, "2468005959262", "lime", "24825719" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Fresh Pizza", 85.538995885075501m, "8360166686794", "white", "33520544" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Metal Cheese", 66.176788485691333m, "5057264454075", "lavender", "44882570" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Soft Sausages", 93.222306737779834m, "2918409156502", "white", "18321241" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Fresh Cheese", 83.847746206376569m, "7557912712536", "sky blue", "46054913" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Soft Fish", 90.275399356743028m, "2544409316082", "maroon", "42144892" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Frozen Cheese", 78.22243462746142m, "2844695981439", "plum", "67313112" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Wooden Keyboard", 24.428779422970834m, "7740880278252", "black", "54720107" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Soft Cheese", 77.301831665123713m, "5752800061792", "olive", "54101258" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Metal Towels", 37.433492359907104m, "4873195997501", "fuchsia", "27478196" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Soft Cheese", 75.872860039059445m, "0004201826896", "salmon", "26976808" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Steel Cheese", 58.861683818447212m, "8893720611302", "maroon", "81696789" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Granite Shoes", 17.131864847676787m, "1279706926634", "yellow", "07005183" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Frozen Pizza", 20.126595655049509m, "1111214338250", "sky blue", "41914373" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Plastic Pizza", 22.54130992737658m, "7807627232851", "fuchsia", "84711298" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Granite Towels", 25.503250947456457m, "2669160823447", "violet", "17700016" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Plastic Ball", 55.364615763707359m, "6602363125594", "silver", "67061037" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Plastic Sausages", 59.647294516045312m, "5915331846348", "turquoise", "67559213" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Soft Shoes", 93.621343901670199m, "9402079275739", "orange", "58894651" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Rubber Chair", 12.123817091399683m, "5757132748588", "turquoise", "28877073" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Wooden Computer", 68.445065867828671m, "4215259345727", "mint green", "11133094" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Frozen Chicken", 67.340768954409631m, "8723895364393", "plum", "27599242" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Rubber Soap", 74.211700826981926m, "9489149455642", "sky blue", "36450466" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Concrete Keyboard", 65.784707882341282m, "5079505226333", "salmon", "15124937" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Steel Soap", 64.358644596468067m, "8856987732319", "orange", "60850423" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Steel Table", 87.393190478157838m, "2328845444161", "turquoise", "49239508" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Steel Soap", 15.774877810745866m, "1865890741469", "violet", "58986875" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Wooden Computer", 32.172936208161022m, "1866952178797", "blue", "89644324" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Metal Cheese", 71.917159501424566m, "6213245975499", "blue", "23798281" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Steel Chair", 27.035139838715623m, "2365976406071", "lime", "39923813" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Metal Keyboard", 68.087476343422909m, "6342709624090", "yellow", "70999983" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Incredible Steel Towels", 90.346899844867654m, "3642872515861", "33706443" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Steel Shoes", 20.051243426767717m, "8235847675919", "black", "67752577" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Rustic Plastic Tuna", 79.975645501155238m, "2808560311462", "plum", "46677297" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Practical Rubber Pants", 51.243631496673274m, "6962230556303", "azure", "49014600" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Wooden Car", 75.188953057950775m, "8049481641151", "orchid", "98080908" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Gorgeous Metal Gloves", 27.723544750233892m, "1737586590425", "fuchsia", "81075751" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Rubber Computer", 97.450974920043271m, "5243133275869", "orchid", "44165666" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Fantastic Soft Salad", 34.91599064130145m, "8225101567128", "azure", "42466154" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Incredible Granite Ball", 76.9260619603684m, "5970912835586", "blue", "07174292" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Intelligent Fresh Bike", 89.285753568301795m, "2931255301018", "teal", "20654399" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handmade Rubber Towels", 89.926929196308775m, "0891558675891", "cyan", "80579182" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Frozen Table", 72.57388961155609m, "5338934644041", "grey", "64852348" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "UnitPrice", "Barcode", "SerialNumber" },
                values: new object[] { "Intelligent Metal Fish", 39.032076410964163m, "8295860135517", "10730249" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Steel Car", 14.127883889306329m, "3364471869977", "turquoise", "38873904" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Unbranded Metal Gloves", 26.017401854515708m, "5169233714254", "black", "06763657" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Steel Chair", 88.041687459704362m, "4700995693831", "mint green", "01625257" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Plastic Fish", 73.766415720231046m, "2472102514545", "olive", "33819655" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Refined Cotton Soap", 60.187569866509942m, "0378415003856", "mint green", "12590223" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Wooden Sausages", 94.61064458201203m, "4399898885285", "mint green", "34098547" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Awesome Plastic Chair", 58.967612596679302m, "1565195835305", "olive", "16205963" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Small Metal Towels", 83.481115780994788m, "2270696132820", "orchid", "33789347" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Ergonomic Steel Cheese", 92.128398334201558m, "2445646400384", "white", "25138269" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Licensed Steel Fish", 27.415747603129456m, "2856275144820", "teal", "50596423" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Tasty Fresh Soap", 79.48286105435479m, "2098384172374", "tan", "89124130" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Frozen Pizza", 36.75806210225359m, "7623842320421", "gold", "77860743" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Handcrafted Soft Keyboard", 73.901588606602327m, "2978488221164", "lime", "61239050" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Sleek Frozen Shoes", 66.572182191336634m, "2779441955092", "ivory", "63932102" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "UnitPrice", "Barcode", "Color", "SerialNumber" },
                values: new object[] { "Generic Concrete Chair", 9.7783239156838192m, "4136142340561", "azure", "09879119" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 271.219475647071200m, new TimeSpan(48783663601) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 351.281255973168400m, new TimeSpan(67651735110) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 393.596391330285200m, new TimeSpan(27375611065) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 286.597106692659200m, new TimeSpan(52165475408) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 132.3942268418121200m, new TimeSpan(384231035) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 424.573352525277600m, new TimeSpan(71575524162) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 493.04346348766400m, new TimeSpan(56221428566) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 267.333056483107200m, new TimeSpan(58485270039) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 228.097397521183600m, new TimeSpan(46895253404) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 249.133016424781200m, new TimeSpan(64802867305) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "navigate", 276.411061257315200m, new TimeSpan(64978325181) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "input", 255.426374522702000m, new TimeSpan(50519316697) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 309.451721706172400m, new TimeSpan(27193155406) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 432.192629544154000m, new TimeSpan(34194425219) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 441.384829367224400m, new TimeSpan(61346845816) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 161.36335826542400m, new TimeSpan(6961476594) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 351.51323352545200m, new TimeSpan(32299035244) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 120.6132235101485600m, new TimeSpan(45069190486) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "reboot", 470.05739992952800m, new TimeSpan(699555450) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 457.251176590682400m, new TimeSpan(22173094521) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 290.512378416262800m, new TimeSpan(26003407483) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 426.068212057495600m, new TimeSpan(1833488178) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 176.480701601356400m, new TimeSpan(49854213417) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 217.426055165671600m, new TimeSpan(20721893547) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 379.927377533133600m, new TimeSpan(10953150110) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "copy", 475.458021636800m, new TimeSpan(40670680881) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "parse", 149.296020925648400m, new TimeSpan(12012127066) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 373.159755148533600m, new TimeSpan(53571560922) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 302.313079592917600m, new TimeSpan(28043610794) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 423.808911779806400m, new TimeSpan(33366415427) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "synthesize", 235.82838780052400m, new TimeSpan(45396098121) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "bypass", 306.103414579342800m, new TimeSpan(25502445203) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 325.793171965420800m, new TimeSpan(2756991116) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 218.099743741610800m, new TimeSpan(69278878200) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 318.557580103426000m, new TimeSpan(24135692105) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 205.575818431366000m, new TimeSpan(25323452276) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 354.14883413079600m, new TimeSpan(71027888093) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 461.999829654581600m, new TimeSpan(55431928020) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "hack", 393.459471638062800m, new TimeSpan(57123472188) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 111.4939538815496400m, new TimeSpan(22275923844) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 318.211197395907200m, new TimeSpan(27480922168) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "compress", 344.695294948618400m, new TimeSpan(68687580126) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "calculate", 318.679488179590400m, new TimeSpan(13288313332) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "transmit", 176.866586728425200m, new TimeSpan(26939672941) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "generate", 153.472592147752800m, new TimeSpan(59615329893) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "override", 160.147297969156400m, new TimeSpan(9828391508) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "index", 216.259390914933600m, new TimeSpan(17412707009) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "back up", 421.072746217750400m, new TimeSpan(12538813977) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "connect", 198.838259325753200m, new TimeSpan(31289140466) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "UnitPrice", "Duration" },
                values: new object[] { "program", 471.439407938830400m, new TimeSpan(56275909729) });
        }
    }
}
