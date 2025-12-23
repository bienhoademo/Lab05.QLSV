# Spec: Student Reporting Capability

## ADDED Requirements

### Requirement: Professional RDLC Reporting
The system MUST provide a professional report generation feature using RDLC templates.

#### Scenario: Generate generic student list report
- **Given** several students exist in the database.
- **When** the user clicks "Xuất Báo Cáo".
- **Then** a report window opens displaying a formatted table of all students.
- **And** the report includes a professional header and page numbers.

#### Scenario: Export report to PDF
- **Given** the report is currently displayed in the `ReportViewer`.
- **When** the user selects "Export to PDF" from the toolbar.
- **Then** the system prompts for a save location and successfully saves the PDF file.

#### Scenario: Verify data completeness in report
- **Given** students have advanced attributes (BirthDate, Address, Phone).
- **When** the report is generated.
- **Then** all these attributes are presented in their respective columns within the report table.
