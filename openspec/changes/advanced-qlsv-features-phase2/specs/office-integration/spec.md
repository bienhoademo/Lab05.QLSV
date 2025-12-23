# Spec: Data Portability

## ADDED Requirements [Office Integration]

### Requirement: Xuất dữ liệu Excel
#### Scenario: Xuất danh sách sinh viên hiện tại
- **Given** Người dùng đang xem danh sách sinh viên tại Form Quản lý.
- **When** Người dùng nhấn nút "Xuất Excel".
- **Then** Hệ thống mở hộp thoại lưu tệp (`SaveFileDialog`).
- **And** Tạo thành công tệp .xlsx chứa toàn bộ dữ liệu đang hiển thị trên lưới với định dạng cột chuyên nghiệp, tiêu đề in đậm và có màu nền.
