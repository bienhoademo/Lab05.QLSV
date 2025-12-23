# Tasks: Advanced QLSV Features - Phase 2

## Giai đoạn 1: Chuẩn bị & Database
- [ ] [BUS] Cập nhật `StudentService` để hỗ trợ các trường thông tin mới.
- [ ] [BUS] Tạo `ReportService` để xử lý logic xuất Excel.
- [ ] [BUS] Tạo `DashboardService` để lấy dữ liệu thống kê chuyên sâu:
    - Lấy số lượng SV theo Khoa.
    - Phân loại học lực dựa trên GPA.
    - Tính điểm trung bình theo Khoa.

## Giai đoạn 3: Giao diện (GUI) - Core UI & Dashboard
- [x] Chuyển đổi giao diện chính sang Layout Sidebar hiện đại.
- [x] Nhúng `System.Windows.Forms.DataVisualization.Charting` hoặc thư viện Chart tương đương.
- [x] Thiết kế User Control Dashboard với 3 biểu đồ chính: Pie, Column, Bar.
- [x] Tạo hiệu ứng màu sắc và tooltip cho các điểm dữ liệu trên biểu đồ.

## Giai đoạn 4: Tính năng bổ sung
- [x] Cập nhật các Form thêm/sửa sinh viên với các trường Ngày sinh, Giới tính.
- [x] Triển khai nút "Xuất Excel" trên các lưới dữ liệu.
- [x] Thêm chức năng đổi mật khẩu và quản lý tài khoản. (Đã bỏ qua theo yêu cầu)

## Giai đoạn 5: Verifying & Finalizing
- [/] Chạy kiểm thử luồng đăng nhập và phân quyền.
- [/] Kiểm tra tính chính xác của dữ liệu trong file Excel xuất ra.
- [/] Kiểm tra khả năng hiển thị của Dashboard với lượng dữ liệu lớn.
