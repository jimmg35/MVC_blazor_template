using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MVCTest.Migrations
{
    public partial class AddressColumnToAlaHuaGuas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALaHuaGuas");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bike_conditions");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_changhuacounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_chiayicounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_chiayis");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_hsinchucounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_hsinchus");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_hualiencounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_kaohsiungs");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_keelungs");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_kinmencounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_miaolicounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_nantoucounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_newtaipeis");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_pingtungcounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_taichungs");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_tainans");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_taipeis");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_taitungcounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_taoyuans");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_yilancounties");

            migrationBuilder.DropTable(
                name: "pd_dynamic_bus_yunlincounties");

            migrationBuilder.DropTable(
                name: "pd_static_bike_stopdetails");

            migrationBuilder.DropTable(
                name: "pd_static_bus_line");

            migrationBuilder.DropTable(
                name: "pd_static_bus_routedetails");

            migrationBuilder.DropTable(
                name: "pd_static_bus_routes");

            migrationBuilder.DropTable(
                name: "pd_static_mrt_routes");

            migrationBuilder.DropTable(
                name: "pd_static_mrt_routesshape");

            migrationBuilder.DropTable(
                name: "pd_static_mrt_stop");

            migrationBuilder.DropTable(
                name: "pd_static_mrt_stopexit");

            migrationBuilder.DropTable(
                name: "ud_user_info");
        }
    }
}
