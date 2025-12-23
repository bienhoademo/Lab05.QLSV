# Spec: Quản lý Khoa (Faculty Management)

## MODIFIED Requirements

### Khả năng nghiệp vụ: Quản lý thông tin khoa

#### Requirement: Liệt kê danh sách Khoa
- **Scenario**: Người dùng mở Form Quản lý Khoa.
- **Hành động**: Hiển thị bảng chứa mã số khoa và tên khoa từ database.

#### Requirement: Thêm/Sửa/Xóa Khoa
- **Scenario**: Người dùng nhập thông tin khoa và nhấn nút tương ứng (Thêm, Sửa, Xóa).
- **Validation**: Tên khoa không được để trống.
- **Ràng buộc**: Không cho phép xóa khoa nếu khoa đó đang có sinh viên thuộc về.
