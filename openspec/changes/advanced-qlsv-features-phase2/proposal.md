# Proposal: Advanced QLSV Features - Phase 2 (advanced-qlsv-features-phase2)

## Summary
Nâng cấp ứng dụng Quản lý Sinh viên (QLSV) lên một tầm cao mới bằng cách bổ sung các tính năng phân tích dữ liệu chuyên nghiệp, bảo mật hệ thống và công cụ quản lý hành chính hiệu quả.

## Motivation & Goals
- **Chuyên nghiệp hóa**: Thay đổi giao diện dạng Form rời rạc bằng một Dashboard trung tâm.
- **Hiệu quả hành chính**: Cho phép xuất dữ liệu ra Excel để phục vụ báo cáo.
- **Bảo mật**: Triển khai hệ thống đăng nhập để bảo vệ dữ liệu nhạy cảm.
- **Tính năng mở rộng**: Theo dõi chi tiết hơn thông tin sinh viên (Ngày sinh, Địa chỉ, Giới tính).

## Scope
- **Dashboard & Analytics**: Biểu đồ thống kê sinh viên theo khoa, xếp loại học lực, và xu hướng điểm số.
- **Export System**: Xuất danh sách sinh viên ra tệp Excel (XLSX).
- **Enhanced Data**: Cập nhật Database và Entity để lưu trữ Ngày sinh, Giới tính, Quê quán.

## Risks & Considerations
- **Cơ sở dữ liệu**: Cần cập nhật schema (migrations) cho các cột mới.
- **Thư viện bên thứ ba**: Cần tích hợp thư viện xuất Excel (như EPPlus hoặc ClosedXML).
- **Phức tạp giao diện**: Chuyển đổi sang kiến trúc Dashboard/Sidebar có thể yêu cầu tái cấu trúc Form chính.
