# Đặc tả: Quản lý Sinh viên và Tìm kiếm

## ADDED Requirements

### Quản lý Sinh viên (Enhanced CRUD)
- **Requirement 1**: Hệ thống phải tự động kiểm tra định dạng MSSV (10 ký tự số).
- **Requirement 2**: Điểm trung bình phải nằm trong khoảng 0 - 10, hiển thị tối đa 2 chữ số thập phân.
- **Requirement 3**: Khi thêm/sửa sinh viên, hệ thống phải cho phép xem trước (Preview) ảnh đại diện trước khi lưu.

#### Scenario: Thêm sinh viên với MSSV sai định dạng
- **Given**: Người dùng nhập MSSV "ABC123" (không hợp lệ).
- **When**: Nhấn nút "Thêm/Cập nhật".
- **Then**: Hiển thị thông báo lỗi "MSSV phải là chuỗi 10 ký tự số".

### Tìm kiếm nâng cao (Advanced Search)
- **Requirement 4**: Cho phép người dùng tìm kiếm theo Tên sinh viên (không phân biệt hoa thường).
- **Requirement 5**: Cho phép lọc kết quả theo Khoa và Chuyên ngành đồng thời.
- **Requirement 6**: Hiển thị tổng số sinh viên tìm thấy sau mỗi lần lọc.

#### Scenario: Tìm kiếm sinh viên theo tên và khoa
- **Given**: Có sinh viên "Nguyễn Văn A" thuộc khoa "CNTT".
- **When**: Người dùng nhập "Văn A" và chọn khoa "CNTT" trong bộ lọc.
- **Then**: Danh sách hiển thị sinh viên "Nguyễn Văn A" và thông báo số lượng tìm thấy là 1.
