using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLOSoltuion.Data.Entities;

namespace TLOSoltuion.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                 new Category
                 {
                     Id = 1,
                     Name = "Luận văn - báo cáo",
                     Imagepath = "/image-content/category/LuanVanBaoCao.png",
                     Description = "Luận văn đại học, cao học, tiếng anh, các đề tài nghiên cứu"
                 },
                 new Category
                 {
                     Id = 2,
                     Name = "Công nghệ thông tin",
                     Imagepath = "/image-content/category/CNTT.png",
                     Description = "Tài liệu lĩnh vực công nghệ thông tin"
                 },
                 new Category
                 {
                     Id = 3,
                     Name = "Kỹ năng mềm",
                     Imagepath = "/image-content/category/KNMem.png",
                     Description = "Tài liệu về các kỹ năng tư duy, quản lý, giao tiếp, đối nhân xử thế"
                 },
                 new Category
                 {
                     Id = 4,
                     Name = "Kinh doanh - tiếp thị",
                     Imagepath = "/image-content/category/KinhDoanh.png",
                     Description = "Quản trị, internet, marketing"
                 },
                new Category
                {
                    Id = 5,
                    Name = "Kinh tế - Quản lý",
                    Imagepath = "/image-content/category/KinhTeQuanLy.png",
                    Description = "Tài liệu về kinh tế, quản lý"
                },
                new Category
                {
                    Id = 6,
                    Name = "Tài chính - ngân hàng",
                    Imagepath = "/image-content/category/LuanVanBaoCao.png",
                    Description = "Báo cáo tài chính, kế toán,..."
                },
                new Category
                {
                    Id = 7,
                    Name = "Biểu mẫu - Văn bản",
                    Imagepath = "/image-content/category/BieuMauVanBan.png",
                    Description = "Biểu mẫu, văn bản, đơn, thư từ, thủ tục"
                },
                new Category
                {
                    Id = 8,
                    Name = "Giáo dục đào tạo",
                    Imagepath = "/image-content/category/GiaoDuc.png",
                    Description = "Tài liệu về đề thi, câu hỏi"
                },
                new Category
                {
                    Id = 9,
                    Name = "Giáo án bài giảng",
                    Imagepath = "/image-content/category/BaiGiang.png",
                    Description = "Tài liệu về các bài giảng môn học"
                },
                new Category
                {
                    Id = 10,
                    Name = "Văn bản pháp luật",
                    Imagepath = "/image-content/category/PhapLuat.jpg",
                    Description = "Thông tư, nghị định, pháp lệnh"
                },
                new Category
                {
                    Id = 11,
                    Name = "Học tiếng Anh",
                    Imagepath = "/image-content/category/English.jpg",
                    Description = "Các tài liệu liên quan đến học tiếng anh, giao tiếp,..."
                },
                new Category
                {
                    Id = 12,
                    Name = "Các bài văn khấn nôm",
                    Imagepath = "/image-content/category/VanKhanNom.png",
                    Description = "Các bài văn khấn nôm"
                },
                new Category
                {
                    Id = 13,
                    Name = "Mẫu slide",
                    Imagepath = "/image-content/category/MauSlide.png",
                    Description = "Các mẫu slide đẹp"
                },
                new Category
                {
                    Id = 14,
                    Name = "Lĩnh vực khác",
                    Imagepath = "/image-content/category/PhapLuat.jpg",
                    Description = "Nấu ăn, mẹo vặt, hoạt động,..."
                }
                );
        }
    }
}
