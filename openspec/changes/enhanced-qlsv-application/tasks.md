# Tasks: Xây dựng hệ thống QLSV nâng cao

## Giai đoạn 1: Chuẩn bị và Thiết kế
- [ ] Rà soát lại Cơ sở dữ liệu và Entity Framework.
- [ ] Thiết kế Layout tổng thể cho Main Form (frmQLSV).

## Giai đoạn 2: Phát triển Lớp Nghiệp vụ (BUS)
- [ ] Triển khai Logic Validation mạnh (Regex cho MSSV, Range cho Điểm).
- [ ] Xây dựng `SearchService` với các hàm lọc động (Dynamic Filtering).
- [ ] Hoàn thiện `FacultyService` với các ràng buộc khi xóa (Integrity Check).

## Giai đoạn 3: Phát triển Giao diện (GUI)
- [ ] Áp dụng Style chuẩn (Color, Font) cho toàn bộ Form.
- [ ] Thiết kế lại `frmQLSV`: Bổ sung khu vực lọc và xem trước ảnh chuyên nghiệp.
- [ ] Hoàn thiện `frmFaculty`: CRUD khoa với giao diện sạch sẽ.
- [ ] Hoàn thiện `frmRegisterMajor`: Đăng ký chuyên ngành với danh sách checkbox.
- [ ] Xây dựng `frmSearch`: Form tìm kiếm đa tiêu chí độc lập.

## Giai đoạn 4: Hoàn thiện và Kiểm thử
- [ ] Kiểm tra lỗi build và tham chiếu (Fix CS0006).
- [ ] Kiểm thử luồng dữ liệu giữa các Form.
- [ ] Viết tài liệu hướng dẫn và Walkthrough.
