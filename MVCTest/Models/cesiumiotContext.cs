using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MVCTest.Models;

#nullable disable

namespace MVCTest
{
    public partial class cesiumiotContext : DbContext
    {
        public cesiumiotContext()
        {
        }

        public cesiumiotContext(DbContextOptions<cesiumiotContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlaHuaGua> AlaHuaGuas { get; set; }
        public virtual DbSet<Foo> Foos { get; set; }
        public virtual DbSet<PdDynamicBikeCondition> PdDynamicBikeConditions { get; set; }
        public virtual DbSet<PdDynamicBusChanghuacounty> PdDynamicBusChanghuacounties { get; set; }
        public virtual DbSet<PdDynamicBusChiayi> PdDynamicBusChiayis { get; set; }
        public virtual DbSet<PdDynamicBusChiayicounty> PdDynamicBusChiayicounties { get; set; }
        public virtual DbSet<PdDynamicBusHsinchu> PdDynamicBusHsinchus { get; set; }
        public virtual DbSet<PdDynamicBusHsinchucounty> PdDynamicBusHsinchucounties { get; set; }
        public virtual DbSet<PdDynamicBusHualiencounty> PdDynamicBusHualiencounties { get; set; }
        public virtual DbSet<PdDynamicBusKaohsiung> PdDynamicBusKaohsiungs { get; set; }
        public virtual DbSet<PdDynamicBusKeelung> PdDynamicBusKeelungs { get; set; }
        public virtual DbSet<PdDynamicBusKinmencounty> PdDynamicBusKinmencounties { get; set; }
        public virtual DbSet<PdDynamicBusMiaolicounty> PdDynamicBusMiaolicounties { get; set; }
        public virtual DbSet<PdDynamicBusNantoucounty> PdDynamicBusNantoucounties { get; set; }
        public virtual DbSet<PdDynamicBusNewtaipei> PdDynamicBusNewtaipeis { get; set; }
        public virtual DbSet<PdDynamicBusPingtungcounty> PdDynamicBusPingtungcounties { get; set; }
        public virtual DbSet<PdDynamicBusTaichung> PdDynamicBusTaichungs { get; set; }
        public virtual DbSet<PdDynamicBusTainan> PdDynamicBusTainans { get; set; }
        public virtual DbSet<PdDynamicBusTaipei> PdDynamicBusTaipeis { get; set; }
        public virtual DbSet<PdDynamicBusTaitungcounty> PdDynamicBusTaitungcounties { get; set; }
        public virtual DbSet<PdDynamicBusTaoyuan> PdDynamicBusTaoyuans { get; set; }
        public virtual DbSet<PdDynamicBusYilancounty> PdDynamicBusYilancounties { get; set; }
        public virtual DbSet<PdDynamicBusYunlincounty> PdDynamicBusYunlincounties { get; set; }
        public virtual DbSet<PdStaticBikeStopdetail> PdStaticBikeStopdetails { get; set; }
        public virtual DbSet<PdStaticBusLine> PdStaticBusLines { get; set; }
        public virtual DbSet<PdStaticBusRoute> PdStaticBusRoutes { get; set; }
        public virtual DbSet<PdStaticBusRoutedetail> PdStaticBusRoutedetails { get; set; }
        public virtual DbSet<PdStaticMrtRoute> PdStaticMrtRoutes { get; set; }
        public virtual DbSet<PdStaticMrtRoutesshape> PdStaticMrtRoutesshapes { get; set; }
        public virtual DbSet<PdStaticMrtStop> PdStaticMrtStops { get; set; }
        public virtual DbSet<PdStaticMrtStopexit> PdStaticMrtStopexits { get; set; }
        public virtual DbSet<UdUserInfo> UdUserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID = postgres;Password=jim60308;Server=localhost;Port=5432;Database=cesiumiot;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese (Traditional)_Taiwan.950");

            modelBuilder.Entity<AlaHuaGua>(entity =>
            {
                entity.ToTable("ALaHuaGuas");
            });

            modelBuilder.Entity<PdDynamicBikeCondition>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_dynamic_bike_conditions_pkey");

                entity.ToTable("pd_dynamic_bike_conditions");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Rents).HasColumnName("rents");

                entity.Property(e => e.Returns).HasColumnName("returns");

                entity.Property(e => e.Stationuid).HasColumnName("stationuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusChanghuacounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_changhuacounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusChiayi>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_chiayis");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusChiayicounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_chiayicounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusHsinchu>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_hsinchus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusHsinchucounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_hsinchucounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusHualiencounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_hualiencounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusKaohsiung>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_kaohsiungs");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusKeelung>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_keelungs");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusKinmencounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_kinmencounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusMiaolicounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_miaolicounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusNantoucounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_nantoucounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusNewtaipei>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_newtaipeis");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusPingtungcounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_pingtungcounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusTaichung>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_taichungs");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusTainan>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_tainans");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusTaipei>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_taipeis");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusTaitungcounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_taitungcounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusTaoyuan>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_taoyuans");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusYilancounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_yilancounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdDynamicBusYunlincounty>(entity =>
            {
                entity.ToTable("pd_dynamic_bus_yunlincounties");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Azimuth).HasColumnName("azimuth");

                entity.Property(e => e.Busstatus).HasColumnName("busstatus");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Platenumb).HasColumnName("platenumb");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Updatetime).HasColumnName("updatetime");
            });

            modelBuilder.Entity<PdStaticBikeStopdetail>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_bike_stopdetails_pkey");

                entity.ToTable("pd_static_bike_stopdetails");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Stationnameeng).HasColumnName("stationnameeng");

                entity.Property(e => e.Stationnamezh).HasColumnName("stationnamezh");

                entity.Property(e => e.Stationuid).HasColumnName("stationuid");
            });

            modelBuilder.Entity<PdStaticBusLine>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_bus_line_pkey");

                entity.ToTable("pd_static_bus_line");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Geometry).HasColumnName("geometry");

                entity.Property(e => e.Routename).HasColumnName("routename");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");
            });

            modelBuilder.Entity<PdStaticBusRoute>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_bus_routes_pkey");

                entity.ToTable("pd_static_bus_routes");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.Property(e => e.Routename).HasColumnName("routename");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");
            });

            modelBuilder.Entity<PdStaticBusRoutedetail>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_bus_routedetails_pkey");

                entity.ToTable("pd_static_bus_routedetails");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Routename).HasColumnName("routename");

                entity.Property(e => e.Routeuid).HasColumnName("routeuid");

                entity.Property(e => e.Stopname).HasColumnName("stopname");

                entity.Property(e => e.Stopsequence).HasColumnName("stopsequence");

                entity.Property(e => e.Stopuid).HasColumnName("stopuid");
            });

            modelBuilder.Entity<PdStaticMrtRoute>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_mrt_routes_pkey");

                entity.ToTable("pd_static_mrt_routes");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.Property(e => e.Routenameeng).HasColumnName("routenameeng");

                entity.Property(e => e.Routenamezh).HasColumnName("routenamezh");
            });

            modelBuilder.Entity<PdStaticMrtRoutesshape>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_mrt_routesshape_pkey");

                entity.ToTable("pd_static_mrt_routesshape");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.Checkdate).HasColumnName("checkdate");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Geometry).HasColumnName("geometry");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Linename).HasColumnName("linename");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<PdStaticMrtStop>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_mrt_stop_pkey");

                entity.ToTable("pd_static_mrt_stop");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.Checkdate).HasColumnName("checkdate");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Routeid).HasColumnName("routeid");

                entity.Property(e => e.Stationid).HasColumnName("stationid");

                entity.Property(e => e.Stationname).HasColumnName("stationname");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<PdStaticMrtStopexit>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("pd_static_mrt_stopexit_pkey");

                entity.ToTable("pd_static_mrt_stopexit");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Elevator).HasColumnName("elevator");

                entity.Property(e => e.Escalator).HasColumnName("escalator");

                entity.Property(e => e.Exitid).HasColumnName("exitid");

                entity.Property(e => e.Exitnameeng).HasColumnName("exitnameeng");

                entity.Property(e => e.Exitnamezh).HasColumnName("exitnamezh");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Stationid).HasColumnName("stationid");
            });

            modelBuilder.Entity<UdUserInfo>(entity =>
            {
                entity.HasKey(e => e.Ids)
                    .HasName("ud_user_info_pkey");

                entity.ToTable("ud_user_info");

                entity.Property(e => e.Ids)
                    .ValueGeneratedNever()
                    .HasColumnName("ids");

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.Checkdate).HasColumnName("checkdate");

                entity.Property(e => e.County).HasColumnName("county");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Geometry).HasColumnName("geometry");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Linename).HasColumnName("linename");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Subs).HasColumnName("subs");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
