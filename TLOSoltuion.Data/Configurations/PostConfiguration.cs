using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLOSoltuion.Data.Entities;

namespace TLOSoltuion.Data.Configurations
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post
                {
                    Id = 1,
                    Title = "TỔNG QUAN VỀ VẬT LIỆU POLYME BLEND",
                    Description = "Khái niệm, và các thành phần liên quan của polyme blend",
                    DocumentPath = "/content/LuanVan1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 12,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 1,
                    ImagePath = "/image-content/post/LuanVan1.png"
                },
                new Post
                {
                    Id = 2,
                    Title = "NUÔI CẤY MÔ - TẾ BÀO THỰC VẬT",
                    Description = "Cách thức nuôi cấy, cấu tạo tế bào thực vật",
                    DocumentPath = "/content/LuanVan2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 15,
                    DowloadCount = 36,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 1,
                    ImagePath = "/image-content/post/LuanVan2.png"
                },

                new Post
                {
                    Id = 3,
                    Title = "ĐÀO TẠO NGUỒN LỰC CHO SỰ NGHIỆP GIÁO DỤC",
                    Description = "Đào tạo nguồn lực cho sự nghiệp giáo dục",
                    DocumentPath = "/content/LuanVan3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 26,
                    DowloadCount = 50,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 1,
                    ImagePath = "/image-content/post/LuanVan3.png"
                },

                new Post
                {
                    Id = 4,
                    Title = "GIỚI THIỆU BOOTSTRAP",
                    Description = "GIỚI THIỆU BOOTSTRAP",
                    DocumentPath = "/content/CNTT1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 26,
                    DowloadCount = 50,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 2,
                    ImagePath = "/image-content/post/CNTT1.png"
                },

                new Post
                {
                    Id = 5,
                    Title = "XÂY DỰNG ỨNG DỤNG ASP",
                    Description = "HƯỚNG DẪN ASP",
                    DocumentPath = "/content/CNTT2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 2,
                    ImagePath = "/image-content/post/CNTT2.png"
                },

                new Post
                {
                    Id = 6,
                    Title = "HỌC REACTJS CƠ BẢN",
                    Description = "Giới thiệu REACTjs cơ bản",
                    DocumentPath = "/content/CNTT3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 2,
                    ImagePath = "/image-content/post/CNTT3.png"
                },

                new Post
                {
                    Id = 7,
                    Title = "KỸ NĂNG CÔ GIÁO MẦM NON",
                    Description = "KỸ NĂNG CÔ GIÁO MẦM NON",
                    DocumentPath = "/content/KN1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 3,
                    ImagePath = "/image-content/post/KN1.jpg"
                },

                new Post
                {
                    Id = 8,
                    Title = "KỸ NĂNG GIAO TIẾP",
                    Description = "KỸ NĂNG GIAO TIẾP",
                    DocumentPath = "/content/KN2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 3,
                    ImagePath = "/image-content/post/KN2.jpg"
                },

                new Post
                {
                    Id = 9,
                    Title = "KỸ NĂNG QUẢN LÝ THỜI GIAN",
                    Description = "KỸ NĂNG QUẢN LÝ THỜI GIAN",
                    DocumentPath = "/content/KN3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 3,
                    ImagePath = "/image-content/post/KN3.jpg"
                },

                new Post
                {
                    Id = 10,
                    Title = "KHỞI NGHIỆP TINH GỌN",
                    Description = "SÁCH KINH DOANH",
                    DocumentPath = "/content/KD1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 4,
                    ImagePath = "/image-content/post/KD1.png"
                },

                new Post
                {
                    Id = 11,
                    Title = "NGƯỜI GIÀU CÓ NHẤT THÀNH BABYLON",
                    Description = "SÁCH HAY KINH DOANH",
                    DocumentPath = "/content/KD2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 4,
                    ImagePath = "/image-content/post/KD2.png"
                },

                new Post
                {
                    Id = 12,
                    Title = "CHA GIÀU CHA NGHÈO",
                    Description = "SÁCH HAY KINH DOANH",
                    DocumentPath = "/content/KD3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 4,
                    ImagePath = "/image-content/post/KD3.png"
                },

                new Post
                {
                    Id = 13,
                    Title = "NGHỀ QUẢN LÝ",
                    Description = "SÁCH HAY VỀ QUẢN LÝ",
                    DocumentPath = "/content/KT1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 5,
                    ImagePath = "/image-content/post/KT1.png"
                },

                new Post
                {
                    Id = 14,
                    Title = "SÁCH QUẢN TRỊ NGUỒN LỰC",
                    Description = "SÁCH HAY QUẢN LÝ",
                    DocumentPath = "/content/KT2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 5,
                    ImagePath = "/image-content/post/KT2.png"
                },

                new Post
                {
                    Id = 15,
                    Title = "QUẢN LÝ TÀI CHÍNH",
                    Description = "QUẢN LÝ TÀI CHÍNH",
                    DocumentPath = "/content/KT3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 5,
                    ImagePath = "/image-content/post/KT2.png"
                },

                new Post
                {
                    Id = 16,
                    Title = "TIỀN VÀ HOẠT ĐỘNG NGÂN HÀNG",
                    Description = "QUẢN LÝ TÀI CHÍNH",
                    DocumentPath = "/content/TC1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 6,
                    ImagePath = "/image-content/post/TC1.png"
                },

                new Post
                {
                    Id = 17,
                    Title = "TRÍ TUỆ TÀI CHÍNH",
                    Description = "QUẢN LÝ TÀI CHÍNH",
                    DocumentPath = "/content/TC2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 6,
                    ImagePath = "/image-content/post/TC2.png"
                },

                new Post
                {
                    Id = 18,
                    Title = "TOÁN TÀI CHÍNH",
                    Description = "SÁCH HAY VỀ TÀI CHÍNH",
                    DocumentPath = "/content/TC3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 6,
                    ImagePath = "/image-content/post/TC3.png"
                },

                new Post
                {
                    Id = 19,
                    Title = "HỢP ĐỒNG THUÊ NHÀ",
                    Description = "HỢP ĐỒNG THUÊ NHÀ",
                    DocumentPath = "/content/VB1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 7,
                    ImagePath = "/image-content/post/VB1.png"
                },

                new Post
                {
                    Id = 20,
                    Title = "ĐƠN XIN VIỆC",
                    Description = "ĐƠN XIN VIỆC",
                    DocumentPath = "/content/VB2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 7,
                    ImagePath = "/image-content/post/VB2.png"
                },

                new Post
                {
                    Id = 21,
                    Title = "ĐƠN KHIẾU NẠI",
                    Description = "ĐƠN KHIẾU NẠI",
                    DocumentPath = "/content/VB3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 7,
                    ImagePath = "/image-content/post/VB3.png"
                },

                new Post
                {
                    Id = 22,
                    Title = "ĐỀ THI TOÁN 2019",
                    Description = "ĐỀ THI",
                    DocumentPath = "/content/GD1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 8,
                    ImagePath = "/image-content/post/GD1.png"
                },

                new Post
                {
                    Id = 23,
                    Title = "ĐỀ THI CẤP 3 HÀ NỘI 2019",
                    Description = "ĐỀ THI CẤP 3",
                    DocumentPath = "/content/GD2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 39,
                    DowloadCount = 120,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 8,
                    ImagePath = "/image-content/post/GD2.png"
                },
                new Post
                {
                    Id = 24,
                    Title = "TÀI LIỆU ÔN THI THPT 2019",
                    Description = "TÀI LIỆU",
                    DocumentPath = "/content/GD3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 8,
                    ImagePath = "/image-content/post/GD3.png"
                },
                new Post
                {
                    Id = 25,
                    Title = "BÀI GIẢNG MÔN AN TOÀN HỆ ĐIỀU HÀNH",
                    Description = "TÀI LIỆU",
                    DocumentPath = "/content/BG1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 9,
                    ImagePath = "/image-content/post/BG1.png"
                },
                new Post
                {
                    Id = 26,
                    Title = "BÀI GIẢNG AN TOÀN HỆ ĐIỀU HÀNH",
                    Description = "TÀI LIỆU",
                    DocumentPath = "/content/BG2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 9,
                    ImagePath = "/image-content/post/BG2.png"
                },
                new Post
                {
                    Id = 27,
                    Title = "BÀI GIẢNG USE CASE CNPM",
                    Description = "TÀI LIỆU",
                    DocumentPath = "/content/BG3pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 9,
                    ImagePath = "/image-content/post/BG3.png"
                },
                new Post
                {
                    Id = 28,
                    Title = "CƠ SỞ DỮ LIỆU VĂN BẢN PHÁP LUẬT",
                    Description = "VĂN BẢN PHÁP LUẬT",
                    DocumentPath = "/content/VBPL.pdf",
                    DocumentType = "pdf",
                    ViewCount = 200,
                    DowloadCount = 100,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 10,
                    ImagePath = "/image-content/post/PL1.png"
                },
                new Post
                {
                    Id = 29,
                    Title = "HỌC NGỮ ÂM",
                    Description = "TIẾNG ANH NGỮ ÂM HAY",
                    DocumentPath = "/content/TA1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 11,
                    ImagePath = "/image-content/post/TA1.png'"
                },
                new Post
                {
                    Id = 30,
                    Title = "HỌC TỪ VỰNG",
                    Description = "TÀI LIỆU TIẾNG ANH",
                    DocumentPath = "/content/TA2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 11,
                    ImagePath = "/image-content/post/TA2.png"
                },
                new Post
                {
                    Id = 31,
                    Title = "CÁC BÀI VĂN KHẤN NÔM",
                    Description = "VĂN HỌC",
                    DocumentPath = "/content/V1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 12,
                    ImagePath = "/image-content/post/V1.png"
                },
                new Post
                {
                    Id = 32,
                    Title = "MẪU SLIDE CẢM ƠN ĐẸP",
                    Description = "SLIDE",
                    DocumentPath = "/content/SL1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 13,
                    ImagePath = "/image-content/post/SL1.png"
                },
                new Post
                {
                    Id = 33,
                    Title = "MẪU SLIDE ĐẸP",
                    Description = "SLIDE",
                    DocumentPath = "/content/SL2pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 13,
                    ImagePath = "/image-content/post/SL1.png"
                },
                new Post
                {
                    Id = 34,
                    Title = "SÁCH DẠY NẤU ĂN",
                    Description = "EBOOK NẤU ĂN HAY",
                    DocumentPath = "/content/K1pdf.pdf",
                    DocumentType = "pdf",
                    ViewCount = 56,
                    DowloadCount = 25,
                    UserId = "2dce503c-3842-4350-891b-c4c339882ece",
                    CategoryId = 14,
                    ImagePath = "/image-content/post/K1.png"
                }
                );
        }
    }
}
