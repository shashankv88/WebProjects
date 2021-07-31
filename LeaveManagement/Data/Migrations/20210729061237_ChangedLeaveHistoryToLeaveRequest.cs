using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Data.Migrations
{
    public partial class ChangedLeaveHistoryToLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveHistories");

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingEmployeeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeID = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateActioned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    ApprovedByID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_ApprovedByID",
                        column: x => x.ApprovedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_RequestingEmployeeID",
                        column: x => x.RequestingEmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

           
          migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_ApprovedByID",
                table: "LeaveRequests",
                column: "ApprovedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeID",
                table: "LeaveRequests",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_RequestingEmployeeID",
                table: "LeaveRequests",
                column: "RequestingEmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.CreateTable(
                name: "LeaveHistories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    ApprovedByID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateActioned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeID = table.Column<int>(type: "int", nullable: false),
                    RequestingEmployeeID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveHistories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LeaveHistories_AspNetUsers_ApprovedByID",
                        column: x => x.ApprovedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveHistories_AspNetUsers_RequestingEmployeeID",
                        column: x => x.RequestingEmployeeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LeaveHistories_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistories_ApprovedByID",
                table: "LeaveHistories",
                column: "ApprovedByID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistories_LeaveTypeID",
                table: "LeaveHistories",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistories_RequestingEmployeeID",
                table: "LeaveHistories",
                column: "RequestingEmployeeID");
        }
    }
}
