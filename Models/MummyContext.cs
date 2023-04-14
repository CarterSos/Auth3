using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Auth3.Models
{
    public partial class MummyContext : DbContext
    {
        public MummyContext()
        {
        }

        public MummyContext(DbContextOptions<MummyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Masterburialsummary3> masterburialsummary3 { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=fagelgamous_database;User Id=postgres;Password=ironman6;");
//            }
//        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Masterburialsummary3>(entity =>
        //    {
        //        entity.HasNoKey();

        //        entity.ToTable("masterburialsummary3");

        //        entity.Property(e => e.Ageatdeath)
        //            .HasColumnName("ageatdeath")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Analysisdoneby)
        //            .HasColumnName("analysisdoneby")
        //            .HasMaxLength(100);

        //        entity.Property(e => e.Analysistype).HasColumnName("analysistype");

        //        entity.Property(e => e.Area).HasColumnName("area");

        //        entity.Property(e => e.Burialid).HasColumnName("burialid");

        //        entity.Property(e => e.Burialid2).HasColumnName("burialid2");

        //        entity.Property(e => e.Burialnumber).HasColumnName("burialnumber");

        //        entity.Property(e => e.Burialtext)
        //            .HasColumnName("burialtext")
        //            .HasMaxLength(2000);

        //        entity.Property(e => e.CariesPeriodontalDisease).HasColumnName("caries_periodontal_disease");

        //        entity.Property(e => e.Color)
        //            .HasColumnName("color")
        //            .HasMaxLength(500);

        //        entity.Property(e => e.Component)
        //            .HasColumnName("component")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Dateofexamination).HasColumnName("dateofexamination");

        //        entity.Property(e => e.Dateofexcavation).HasColumnName("dateofexcavation");

        //        entity.Property(e => e.Depth)
        //            .HasColumnName("depth")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Dorsalpitting).HasColumnName("dorsalpitting");

        //        entity.Property(e => e.Eastwest).HasColumnName("eastwest");

        //        entity.Property(e => e.Estimatestature).HasColumnName("estimatestature");

        //        entity.Property(e => e.Facebundles)
        //            .HasColumnName("facebundles")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Femur).HasColumnName("femur");

        //        entity.Property(e => e.Femurheaddiameter).HasColumnName("femurheaddiameter");

        //        entity.Property(e => e.Femurlength).HasColumnName("femurlength");

        //        entity.Property(e => e.Gonion).HasColumnName("gonion");

        //        entity.Property(e => e.Goods)
        //            .HasColumnName("goods")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Haircolor)
        //            .HasColumnName("haircolor")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Haircolordescription).HasColumnName("haircolordescription");

        //        entity.Property(e => e.Headdirection)
        //            .HasColumnName("headdirection")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Humerus).HasColumnName("humerus");

        //        entity.Property(e => e.Humerusheaddiameter).HasColumnName("humerusheaddiameter");

        //        entity.Property(e => e.Humeruslength).HasColumnName("humeruslength");

        //        entity.Property(e => e.Id).HasColumnName("id");

        //        entity.Property(e => e.Lamboidsuture).HasColumnName("lamboidsuture");

        //        entity.Property(e => e.Length)
        //            .HasColumnName("length")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Manipulation)
        //            .HasColumnName("manipulation")
        //            .HasMaxLength(100);

        //        entity.Property(e => e.Material)
        //            .HasColumnName("material")
        //            .HasMaxLength(100);

        //        entity.Property(e => e.MedialIpRamus).HasColumnName("medial_ip_ramus");

        //        entity.Property(e => e.Northsouth).HasColumnName("northsouth");

        //        entity.Property(e => e.Notes).HasColumnName("notes");

        //        entity.Property(e => e.Notes1).HasColumnName("notes.1");

        //        entity.Property(e => e.Nuchalcrest).HasColumnName("nuchalcrest");

        //        entity.Property(e => e.Observations).HasColumnName("observations");

        //        entity.Property(e => e.Orbitedge).HasColumnName("orbitedge");

        //        entity.Property(e => e.Osteophytosis).HasColumnName("osteophytosis");

        //        entity.Property(e => e.Parietalbossing).HasColumnName("parietalbossing");

        //        entity.Property(e => e.Photodescription)
        //            .HasColumnName("photodescription")
        //            .HasMaxLength(500);

        //        entity.Property(e => e.Photofilename)
        //            .HasColumnName("photofilename")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Photourl)
        //            .HasColumnName("photourl")
        //            .HasMaxLength(500);

        //        entity.Property(e => e.Ply)
        //            .HasColumnName("ply")
        //            .HasMaxLength(20);

        //        entity.Property(e => e.Preauricularsulcus).HasColumnName("preauricularsulcus");

        //        entity.Property(e => e.Preservationindex).HasColumnName("preservationindex");

        //        entity.Property(e => e.Pubicbone).HasColumnName("pubicbone");

        //        entity.Property(e => e.Robust).HasColumnName("robust");

        //        entity.Property(e => e.Sciaticnotch).HasColumnName("sciaticnotch");

        //        entity.Property(e => e.Sex)
        //            .HasColumnName("sex")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Sphenooccipitalsynchrondrosis).HasColumnName("sphenooccipitalsynchrondrosis");

        //        entity.Property(e => e.Squamossuture).HasColumnName("squamossuture");

        //        entity.Property(e => e.Squareeastwest).HasColumnName("squareeastwest");

        //        entity.Property(e => e.Squarenorthsouth).HasColumnName("squarenorthsouth");

        //        entity.Property(e => e.Structure)
        //            .HasColumnName("structure")
        //            .HasMaxLength(500);

        //        entity.Property(e => e.Subpubicangle).HasColumnName("subpubicangle");

        //        entity.Property(e => e.Supraorbitalridges).HasColumnName("supraorbitalridges");

        //        entity.Property(e => e.Textiledescription)
        //            .HasColumnName("textiledescription")
        //            .HasColumnType("character varying");

        //        entity.Property(e => e.Textiledimensiontype)
        //            .HasColumnName("textiledimensiontype")
        //            .HasMaxLength(500);

        //        entity.Property(e => e.Textiledimensionvalue)
        //            .HasColumnName("textiledimensionvalue")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Textilefunction)
        //            .HasColumnName("textilefunction")
        //            .HasMaxLength(200);

        //        entity.Property(e => e.Tibia).HasColumnName("tibia");

        //        entity.Property(e => e.Toothattrition).HasColumnName("toothattrition");

        //        entity.Property(e => e.Tootheruption).HasColumnName("tootheruption");

        //        entity.Property(e => e.Tootheruptionageestimate).HasColumnName("tootheruptionageestimate");

        //        entity.Property(e => e.Ventralarc).HasColumnName("ventralarc");

        //        entity.Property(e => e.Yarncount)
        //            .HasColumnName("yarncount")
        //            .HasMaxLength(100);

        //        entity.Property(e => e.Yarnthickness)
        //            .HasColumnName("yarnthickness")
        //            .HasMaxLength(20);

        //        entity.Property(e => e.Zygomaticcrest).HasColumnName("zygomaticcrest");
        //    });

        //    modelBuilder.HasSequence("excelimporter$template_nr_mxseq");

        //    modelBuilder.HasSequence("system$filedocument_fileid_mxseq");

        //    modelBuilder.HasSequence("system$queuedtask_sequence_mxseq");

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
