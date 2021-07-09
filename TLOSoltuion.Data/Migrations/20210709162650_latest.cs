using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TLOSoltuion.Data.Migrations
{
    public partial class latest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b6468d-489f-49a3-b2b7-58761b249566");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12578aed-2d84-4fd8-8b06-c2e8eb738ab1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0bfa98c-42ef-45c8-a459-3c7cdd943655");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b5b2f7f7-36bc-4685-9543-4fa2271ccede", "a9abe8b8-5d9d-4b3a-8faf-e8f40b9172c2", "User", "USER" },
                    { "767205ac-b5ab-42f6-a48b-e5023a6f4549", "f136dace-14e4-43d6-b42b-4f9e42a23e4b", "Publisher", "PUBLISHER" },
                    { "4067a657-29d1-4588-baaa-b7c93d9626a4", "55587c4a-2453-4d9b-afc1-0eeb591bc464", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2dce503c-3842-4350-891b-c4c339882ece", 0, "7a3db7d8-f867-49da-9e29-340eafc42f6d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "publisher@gmail.com", false, "Publiser 1", "TailieuOnline", false, null, null, null, null, null, false, "30de84a1-54ad-449b-89ed-13c3cac68d0b", false, "publisher@gmail.com" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Imagepath", "Name" },
                values: new object[,]
                {
                    { 2, "Tài liệu lĩnh vực công nghệ thông tin", "/image-content/category/CNTT.png", "Công nghệ thông tin" },
                    { 3, "Tài liệu về các kỹ năng tư duy, quản lý, giao tiếp, đối nhân xử thế", "/image-content/category/KNMem.png", "Kỹ năng mềm" },
                    { 4, "Quản trị, internet, marketing", "/image-content/category/KinhDoanh.png", "Kinh doanh - tiếp thị" },
                    { 5, "Tài liệu về kinh tế, quản lý", "/image-content/category/KinhTeQuanLy.png", "Kinh tế - Quản lý" },
                    { 14, "Nấu ăn, mẹo vặt, hoạt động,...", "/image-content/category/PhapLuat.jpg", "Lĩnh vực khác" },
                    { 7, "Biểu mẫu, văn bản, đơn, thư từ, thủ tục", "/image-content/category/BieuMauVanBan.png", "Biểu mẫu - Văn bản" },
                    { 8, "Tài liệu về đề thi, câu hỏi", "/image-content/category/GiaoDuc.png", "Giáo dục đào tạo" },
                    { 9, "Tài liệu về các bài giảng môn học", "/image-content/category/BaiGiang.png", "Giáo án bài giảng" },
                    { 10, "Thông tư, nghị định, pháp lệnh", "/image-content/category/PhapLuat.jpg", "Văn bản pháp luật" },
                    { 11, "Các tài liệu liên quan đến học tiếng anh, giao tiếp,...", "/image-content/category/English.jpg", "Học tiếng Anh" },
                    { 12, "Các bài văn khấn nôm", "/image-content/category/VanKhanNom.png", "Các bài văn khấn nôm" },
                    { 13, "Các mẫu slide đẹp", "/image-content/category/MauSlide.png", "Mẫu slide" },
                    { 1, "Luận văn đại học, cao học, tiếng anh, các đề tài nghiên cứu", "/image-content/category/LuanVanBaoCao.png", "Luận văn - báo cáo" },
                    { 6, "Báo cáo tài chính, kế toán,...", "/image-content/category/LuanVanBaoCao.png", "Tài chính - ngân hàng" }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "CategoryId", "Description", "DocumentPath", "DocumentType", "DowloadCount", "ImagePath", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, "Khái niệm, và các thành phần liên quan của polyme blend", "/content/LuanVan1pdf.pdf", "pdf", 25, "/image-content/post/LuanVan1.png", "TỔNG QUAN VỀ VẬT LIỆU POLYME BLEND", "2dce503c-3842-4350-891b-c4c339882ece", 12 },
                    { 32, 13, "SLIDE", "/content/SL1pdf.pdf", "pdf", 25, "/image-content/post/SL1.png", "MẪU SLIDE CẢM ƠN ĐẸP", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 31, 12, "VĂN HỌC", "/content/V1pdf.pdf", "pdf", 25, "/image-content/post/V1.png", "CÁC BÀI VĂN KHẤN NÔM", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 30, 11, "TÀI LIỆU TIẾNG ANH", "/content/TA2pdf.pdf", "pdf", 25, "/image-content/post/TA2.png", "HỌC TỪ VỰNG", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 29, 11, "TIẾNG ANH NGỮ ÂM HAY", "/content/TA1pdf.pdf", "pdf", 25, "/image-content/post/TA1.png'", "HỌC NGỮ ÂM", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 28, 10, "VĂN BẢN PHÁP LUẬT", "/content/VBPL.pdf", "pdf", 100, "/image-content/post/PL1.png", "CƠ SỞ DỮ LIỆU VĂN BẢN PHÁP LUẬT", "2dce503c-3842-4350-891b-c4c339882ece", 200 },
                    { 27, 9, "TÀI LIỆU", "/content/BG3pdf.pdf", "pdf", 25, "/image-content/post/BG3.png", "BÀI GIẢNG USE CASE CNPM", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 26, 9, "TÀI LIỆU", "/content/BG2pdf.pdf", "pdf", 25, "/image-content/post/BG2.png", "BÀI GIẢNG AN TOÀN HỆ ĐIỀU HÀNH", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 25, 9, "TÀI LIỆU", "/content/BG1pdf.pdf", "pdf", 25, "/image-content/post/BG1.png", "BÀI GIẢNG MÔN AN TOÀN HỆ ĐIỀU HÀNH", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 24, 8, "TÀI LIỆU", "/content/GD3pdf.pdf", "pdf", 25, "/image-content/post/GD3.png", "TÀI LIỆU ÔN THI THPT 2019", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 23, 8, "ĐỀ THI CẤP 3", "/content/GD2pdf.pdf", "pdf", 120, "/image-content/post/GD2.png", "ĐỀ THI CẤP 3 HÀ NỘI 2019", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 22, 8, "ĐỀ THI", "/content/GD1pdf.pdf", "pdf", 120, "/image-content/post/GD1.png", "ĐỀ THI TOÁN 2019", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 21, 7, "ĐƠN KHIẾU NẠI", "/content/VB3pdf.pdf", "pdf", 120, "/image-content/post/VB3.png", "ĐƠN KHIẾU NẠI", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 20, 7, "ĐƠN XIN VIỆC", "/content/VB2pdf.pdf", "pdf", 120, "/image-content/post/VB2.png", "ĐƠN XIN VIỆC", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 19, 7, "HỢP ĐỒNG THUÊ NHÀ", "/content/VB1pdf.pdf", "pdf", 120, "/image-content/post/VB1.png", "HỢP ĐỒNG THUÊ NHÀ", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 18, 6, "SÁCH HAY VỀ TÀI CHÍNH", "/content/TC3pdf.pdf", "pdf", 120, "/image-content/post/TC3.png", "TOÁN TÀI CHÍNH", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 17, 6, "QUẢN LÝ TÀI CHÍNH", "/content/TC2pdf.pdf", "pdf", 120, "/image-content/post/TC2.png", "TRÍ TUỆ TÀI CHÍNH", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 16, 6, "QUẢN LÝ TÀI CHÍNH", "/content/TC1pdf.pdf", "pdf", 120, "/image-content/post/TC1.png", "TIỀN VÀ HOẠT ĐỘNG NGÂN HÀNG", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 2, 1, "Cách thức nuôi cấy, cấu tạo tế bào thực vật", "/content/LuanVan2pdf.pdf", "pdf", 36, "/image-content/post/LuanVan2.png", "NUÔI CẤY MÔ - TẾ BÀO THỰC VẬT", "2dce503c-3842-4350-891b-c4c339882ece", 15 },
                    { 3, 1, "Đào tạo nguồn lực cho sự nghiệp giáo dục", "/content/LuanVan3pdf.pdf", "pdf", 50, "/image-content/post/LuanVan3.png", "ĐÀO TẠO NGUỒN LỰC CHO SỰ NGHIỆP GIÁO DỤC", "2dce503c-3842-4350-891b-c4c339882ece", 26 },
                    { 4, 2, "GIỚI THIỆU BOOTSTRAP", "/content/CNTT1pdf.pdf", "pdf", 50, "/image-content/post/CNTT1.png", "GIỚI THIỆU BOOTSTRAP", "2dce503c-3842-4350-891b-c4c339882ece", 26 },
                    { 5, 2, "HƯỚNG DẪN ASP", "/content/CNTT2pdf.pdf", "pdf", 120, "/image-content/post/CNTT2.png", "XÂY DỰNG ỨNG DỤNG ASP", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 6, 2, "Giới thiệu REACTjs cơ bản", "/content/CNTT3pdf.pdf", "pdf", 120, "/image-content/post/CNTT3.png", "HỌC REACTJS CƠ BẢN", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 7, 3, "KỸ NĂNG CÔ GIÁO MẦM NON", "/content/KN1pdf.pdf", "pdf", 120, "/image-content/post/KN1.jpg", "KỸ NĂNG CÔ GIÁO MẦM NON", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 33, 13, "SLIDE", "/content/SL2pdf.pdf", "pdf", 25, "/image-content/post/SL1.png", "MẪU SLIDE ĐẸP", "2dce503c-3842-4350-891b-c4c339882ece", 56 },
                    { 8, 3, "KỸ NĂNG GIAO TIẾP", "/content/KN2pdf.pdf", "pdf", 120, "/image-content/post/KN2.jpg", "KỸ NĂNG GIAO TIẾP", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 10, 4, "SÁCH KINH DOANH", "/content/KD1pdf.pdf", "pdf", 120, "/image-content/post/KD1.png", "KHỞI NGHIỆP TINH GỌN", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 11, 4, "SÁCH HAY KINH DOANH", "/content/KD2pdf.pdf", "pdf", 120, "/image-content/post/KD2.png", "NGƯỜI GIÀU CÓ NHẤT THÀNH BABYLON", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 12, 4, "SÁCH HAY KINH DOANH", "/content/KD3pdf.pdf", "pdf", 120, "/image-content/post/KD3.png", "CHA GIÀU CHA NGHÈO", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 13, 5, "SÁCH HAY VỀ QUẢN LÝ", "/content/KT1pdf.pdf", "pdf", 120, "/image-content/post/KT1.png", "NGHỀ QUẢN LÝ", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 14, 5, "SÁCH HAY QUẢN LÝ", "/content/KT2pdf.pdf", "pdf", 120, "/image-content/post/KT2.png", "SÁCH QUẢN TRỊ NGUỒN LỰC", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 15, 5, "QUẢN LÝ TÀI CHÍNH", "/content/KT3pdf.pdf", "pdf", 120, "/image-content/post/KT2.png", "QUẢN LÝ TÀI CHÍNH", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 9, 3, "KỸ NĂNG QUẢN LÝ THỜI GIAN", "/content/KN3pdf.pdf", "pdf", 120, "/image-content/post/KN3.jpg", "KỸ NĂNG QUẢN LÝ THỜI GIAN", "2dce503c-3842-4350-891b-c4c339882ece", 39 },
                    { 34, 14, "EBOOK NẤU ĂN HAY", "/content/K1pdf.pdf", "pdf", 25, "/image-content/post/K1.png", "SÁCH DẠY NẤU ĂN", "2dce503c-3842-4350-891b-c4c339882ece", 56 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4067a657-29d1-4588-baaa-b7c93d9626a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "767205ac-b5ab-42f6-a48b-e5023a6f4549");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5b2f7f7-36bc-4685-9543-4fa2271ccede");

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dce503c-3842-4350-891b-c4c339882ece");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0bfa98c-42ef-45c8-a459-3c7cdd943655", "2d52f129-af07-4136-ad25-960bb7a82350", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05b6468d-489f-49a3-b2b7-58761b249566", "36507cb4-e75d-4117-b95a-7b3aa777ab6c", "Publisher", "PUBLISHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12578aed-2d84-4fd8-8b06-c2e8eb738ab1", "6076f60f-bee4-4b5f-baa7-7510653ae9a0", "Admin", "ADMIN" });
        }
    }
}
