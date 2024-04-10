﻿using IsKapisi.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IsKapisi.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();


            builder
                
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

           builder
             .Property(c => c.Description)
             .HasMaxLength(500)
             .IsRequired();

            builder
             .Property(c => c.Url)
             .HasMaxLength(500)
             .IsRequired();

            builder
            .ToTable("Categories");
            builder 
                .HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Öğretmen",
                        Description = "Eğitim Kategorisi",
                        Url = "ogretmen"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Avukat",
                        Description = "Hukuk",
                        Url = "avukat"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Yazılım Geliştirme Uzmanı",
                        Description = "Bilgi İşlem",
                        Url = "yazilim-geliştirme-uzmani"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "İnsan Kaynaklari Uzmanı",
                        Description = "İnsan Kaynaklari Uzmani",
                        Url = "insan-kaynaklari-uzmani"
                    },
                    new Category
                    {
                        Id = 5,
                        Name = "Back-End Developer",
                        Description = "Developer",
                        Url = "back-end-developer"
                    }
                );



















            // builder hoca
            //.HasData(
            //    new Category 
            //    {
            //        Id = 1,
            //        Name = "Televizyon",
            //        Description = "TV kategorisi",
            //        Url = "televizyon"
            //    },
            //    new Category
            //    {
            //        Id = 2,
            //        Name = "Bilgisayar",
            //        Description = "Bilgisayar kategorisi",
            //        Url = "bilgisayar"
            //    },
            //    new Category
            //    {
            //        Id = 3,
            //        Name = "Elektronik Eşya",
            //        Description = "Elektronik Eşya kategorisi",
            //        Url = "elektronik-esya"
            //    },
            //    new Category
            //    {
            //        Id = 4,
            //        Name = "Beyaz Eşya",
            //        Description = "Beyaz Eşya kategorisi",
            //        Url = "beyaz-esya"
            //    },
            //    new Category
            //    {
            //        Id = 5,
            //        Name = "Telefon",
            //        Description = "Telefon kategorisi",
            //        Url = "telefon"
            //    }
            //);

            //builder  benim
            // .HasData(
            //    new Category
            //    {
            //        Id = 1,
            //        Name = "Öğretmen",
            //        Description = "Eğitim",
            //        Url = "ogretmen"
            //    },
            //    new Category
            //    {
            //        Id = 2,
            //        Name = "Avukat",
            //        Description = "Hukuk",
            //        Url = "avukat"
            //    },
            //    new Category
            //    {
            //        Id = 3,
            //        Name = "Yazılım Geliştirme Uzmanı",
            //        Description = "Bilgi İşlem",
            //        Url = "yazılım-geliştirme-uzmanı"
            //    },
            //    new Category
            //    {
            //        Id = 4,
            //        Name = "İnsan Kaynakları Uzmanı",
            //        Description = "İnsan Kaynakları",
            //        Url = "insan-kaynalari-uzmani"
            //    }

            //    );

        }
    }
}
