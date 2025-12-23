# Design: Hệ thống QLSV nâng cao

## Kiến trúc 3 lớp (Review)
Giữ nguyên mô hình 3 lớp hiện tại nhưng tối ưu hóa giao tiếp giữa các lớp:
- **DAL**: Duy trì Entity Framework 6. Đảm bảo Lazy Loading được cấu hình phù hợp.
- **BUS**: Tách biệt logic Validation thành các phương thức private để tái sử dụng.
- **GUI**: Sử dụng các Pattern như Observer hoặc đơn giản là các Event để cập nhật dữ liệu đồng bộ giữa các Form.

## Tiêu chuẩn giao diện (UI Standards)
- **Màu sắc**: 
  - Màu chủ đạo: Blue Grey (#2C3E50).
  - Màu hành động: Emerald Green (#2ECC71).
  - Màu cảnh báo: Alizarin Red (#E74C3C).
- **Font chữ**: Segoe UI, size 10pt cho text bình thường, 12pt Bold cho Header.
- **Layout**: 
  - Sử dụng `Dock` và `Anchor` để giao diện co giãn tốt.
  - Sidebar cho điều hướng chính (QLSV, Khoa, Đăng ký).

## Xử lý Logic ảnh đại diện
- Lưu trữ ảnh tại `<AppPath>\Images\`.
- Tên file lưu trong DB theo định dạng `<MSSV>_<Timestamp>.jpg` để tránh trùng lặp khi sinh viên thay đổi ảnh.

## Chức năng Tìm kiếm
- Sử dụng kỹ thuật `LINQ` để lọc dữ liệu động tại BUS, trả về `List<StudentViewModel>` để tối ưu hiển thị.
