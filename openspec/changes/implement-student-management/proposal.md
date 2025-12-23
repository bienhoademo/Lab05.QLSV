# Proposal: Xây dựng ứng dụng Quản lý Sinh viên (QLSV) chuẩn

## Tóm tắt (Summary)
Đề xuất này nhằm hoàn thiện ứng dụng QLSV với đầy đủ các tính năng nghiệp vụ cốt lõi, tuân thủ kiến trúc 3 lớp và các quy ước đã đề ra trong dự án.

## Động lực (Motivation)
Hiện tại dự án mới chỉ có cấu trúc khung và các thực thể cơ bản. Cần triển khai các logic nghiệp vụ và giao diện người dùng để người dùng có thể quản lý sinh viên, khoa và chuyên ngành một cách hiệu quả.

## Phạm vi (Scope)
- **Quản lý Sinh viên**: Thêm, Sửa, Xóa, Liệt kê sinh viên. Hỗ trợ tải ảnh đại diện.
- **Quản lý Khoa**: Xem danh sách khoa, thêm/sửa/xóa khoa.
- **Đăng ký Chuyên ngành**: Cho phép sinh viên đăng ký chuyên ngành thuộc khoa của mình.
- **Tìm kiếm**: Tìm kiếm sinh viên theo tên hoặc mã số.

## Rủi ro và Cân nhắc (Risks & Considerations)
- Đảm bảo tính nhất quán của dữ liệu (ví dụ: không xóa khoa nếu còn sinh viên hoặc chuyên ngành).
- Xử lý lưu trữ ảnh đại diện một cách hợp lý (địa phương hoặc trong db).
