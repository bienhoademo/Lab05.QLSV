# Proposal: Xây dựng hệ thống QLSV nâng cao (Enhanced QLSV System)

## Tóm tắt (Summary)
Dự án này tập trung vào việc hiện đại hóa ứng dụng Quản lý Sinh viên (Lab05.QLSV). Mục tiêu là tạo ra một ứng dụng WinForms chuyên nghiệp với giao diện đẹp mắt, logic nghiệp vụ vững chắc và chức năng tìm kiếm mạnh mẽ.

## Động lực (Motivation)
Các phiên bản trước đó chỉ tập trung vào chức năng cơ bản. Người dùng cần một ứng dụng không chỉ chạy đúng mà còn phải dễ sử dụng và có tính thẩm mỹ cao để nâng cao hiệu suất làm việc.

## Phạm vi (Scope)
- **UI/UX Revolution**: Thay đổi hoàn toàn diện mạo Form với các tiêu chuẩn thiết kế hiện đại.
- **Robust CRUD**: Quản lý Sinh viên và Khoa với đầy đủ các kiểm tra ràng buộc.
- **Major Registration**: Quy trình đăng ký chuyên ngành khoa học, lọc dữ liệu thông minh.
- **Advanced Search**: Tìm kiếm linh hoạt theo nhiều tiêu chí (Search-as-you-type).

## Rủi ro và Cân nhắc (Risks & Considerations)
- **WinForms UI Limitations**: Cần khéo léo sử dụng các controls cơ bản của .NET để tạo cảm giác hiện đại mà không cần thư viện bên thứ ba quá nặng.
- **Data Integrity**: Đảm bảo các ràng buộc khóa ngoại trong DB được BUS xử lý một cách thân thiện với người dùng.
