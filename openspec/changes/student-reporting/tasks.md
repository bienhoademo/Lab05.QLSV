# Tasks: Professional Student Reporting with RDLC

## Phase 1: Preparation
- [ ] Install `Microsoft.ReportingServices.ReportViewerControl.Winforms` via NuGet.
- [ ] Ensure `Microsoft.SqlServer.Types` is present (dependency for ReportViewer).

## Phase 2: Report Design
- [ ] Create folder `Lab05.GUI/Reports/`.
- [ ] Create `rptStudentList.rdlc` file with a tabular layout.
- [ ] Define Report Parameters (e.g., Report Title, Current Date).

## Phase 3: GUI Implementation
- [ ] Create `frmReport.cs` and `frmReport.Designer.cs`.
- [ ] Add `ReportViewer` control to the form.
- [ ] Implement `LoadReport(List<Student> data)` method.
- [ ] Add "Xuất Báo Cáo" button to the main Sidebar in `frmMain`.

## Phase 4: Verification
- [ ] Generate report for all students.
- [ ] Generate report filtered by Faculty.
- [ ] Verify that Vietnamese characters (UTF-8) display correctly.
- [ ] Test exporting to PDF from the ReportViewer toolbar.
