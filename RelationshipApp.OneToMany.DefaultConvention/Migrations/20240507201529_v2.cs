using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationshipApp.OneToMany.DefaultConvention.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Tasks_TasksTaskId",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "TasksTaskId",
                table: "Personels",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_TasksTaskId",
                table: "Personels",
                newName: "IX_Personels_TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Tasks_TaskId",
                table: "Personels",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Tasks_TaskId",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Personels",
                newName: "TasksTaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_TaskId",
                table: "Personels",
                newName: "IX_Personels_TasksTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Tasks_TasksTaskId",
                table: "Personels",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
