# Proposal: Professional Student Reporting with RDLC

## Summary
Integrate Microsoft Reporting Services (RDLC) into the QLSV application to provide professional, printable student reports. This feature will allow users to generate formatted reports (e.g., student lists, academic transcripts) with the ability to export to PDF, Excel, and Word.

## Motivation
While CSV export is useful for data processing, professional reporting requires formatting, headers, footers, and official layouts. RDLC reports provide a standard way to achieve this within WinForms applications.

## Scope
- **Report Templates (.rdlc)**: Designing a layout for "Danh sách sinh viên" (Student List) with all 9 attributes.
- **Reporting Viewer**: Integrating the `ReportViewer` control into a new form `frmReport`.
- **Data Binding**: Connecting the `StudentService` data to the Report Data Source.
- **Filtering**: Allowing users to generate reports based on selected criteria (e.g., by Faculty).

## Risks and Considerations
- **Dependencies**: Requires `Microsoft.ReportingServices.ReportViewerControl.Winforms`. I will check if it's already installed or if it needs to be added via NuGet.
- **Visual Studio Toolbox**: The user may need to have the Report Designer extension installed to modify `.rdlc` files visually, although I will provide the XML content.
- **Deployment**: The ReportViewer runtime must be present on the target machine.
