# Spec: Quản lý Sinh viên (Student CRUD)

## MODIFIED Requirements

### Khả năng nghiệp vụ: Quản lý thông tin sinh viên cơ bản

#### Requirement: Thêm sinh viên mới
- **Scenario**: Người dùng nhập đầy đủ thông tin (MSSV, Họ tên, Điểm TB, Khoa) và nhấn Thêm.
- **Validation**:
  - MSSV phải là duy nhất và có 10 ký tự.
  - Họ tên không được để trống.
  - Điểm TB phải nằm trong khoảng 0-10.
- **Hành động**: Lưu thông tin vào database và cập nhật danh sách hiển thị.

#### Requirement: Cập nhật thông tin sinh viên
- **Scenario**: Người dùng chọn một sinh viên từ danh sách, sửa thông tin và nhấn Sửa.
- **Mô tả**: Cho phép sửa tất cả các trường ngoại trừ MSSV.

#### Requirement: Xóa sinh viên
- **Scenario**: Người dùng chọn sinh viên và nhấn Xóa.
- **Hành động**: Xác nhận xóa và gỡ bỏ khỏi database.

### Khả năng nghiệp vụ: Quản lý Ảnh đại diện (Avatar)

#### Requirement: Tải ảnh đại diện cho sinh viên
- **Scenario**: Người dùng chọn nút chọn ảnh khi đang thêm/sửa sinh viên.
- **Hành động**: Mở hộp thoại chọn tệp (OpenFileDialog), sao chép ảnh vào thư mục cục bộ của ứng dụng và lưu đường dẫn.
