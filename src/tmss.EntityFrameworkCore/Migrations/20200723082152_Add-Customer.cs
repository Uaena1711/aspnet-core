using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tmss.Migrations
{
    public partial class AddCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 30, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    CustType = table.Column<int>(nullable: false),
                    Owner = table.Column<string>(maxLength: 50, nullable: true),
                    CustName = table.Column<string>(maxLength: 30, nullable: false),
                    CustTel = table.Column<string>(maxLength: 12, nullable: false),
                    CustDetailAddress = table.Column<string>(maxLength: 90, nullable: false),
                    CustSource = table.Column<int>(nullable: false),
                    ProvincaId = table.Column<int>(maxLength: 10, nullable: false),
                    DistrictId = table.Column<int>(maxLength: 10, nullable: false),
                    Hotness = table.Column<int>(nullable: false),
                    ExpectedDelTime = table.Column<int>(nullable: false),
                    Payment = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Occupation = table.Column<string>(maxLength: 50, nullable: true),
                    Input = table.Column<string>(maxLength: 50, nullable: true),
                    Hobby = table.Column<int>(nullable: false),
                    SocialChannel = table.Column<int>(nullable: false),
                    SocialID = table.Column<string>(maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DrinkFood = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
