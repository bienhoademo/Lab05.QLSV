# Spec: Đăng ký Chuyên ngành (Major Registration)

## MODIFIED Requirements

### Khả năng nghiệp vụ: Phân bổ chuyên ngành cho sinh viên

#### Requirement: Liệt kê sinh viên chưa đăng ký chuyên ngành hoặc theo khoa
- **Scenario**: Người dùng chọn khoa trong Form Đăng ký Chuyên ngành.
- **Hành động**: Hiển thị danh sách sinh viên thuộc khoa đó kèm theo chuyên ngành hiện tại (nếu có).

#### Requirement: Đăng ký chuyên ngành cho sinh viên
- **Scenario**: Người dùng chọn sinh viên, chọn chuyên ngành và nhấn Đăng ký.
- **Hành động**: Cập nhật `MajorID` cho sinh viên được chọn trong database.
- **Ràng buộc**: Chuyên ngành phải thuộc về khoa mà sinh viên đó đang theo học.
