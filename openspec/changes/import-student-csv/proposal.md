# Proposal: Import Student Data from CSV

## Summary
Add functionality to import student records from CSV files into the system. This feature will allow users to bulk-upload student data, ensuring that Faculty and Major associations are correctly handled and data integrity is maintained.

## Motivation
Manually entering large numbers of students is time-consuming and prone to errors. Providing a CSV import feature improves data entry efficiency and allows for easier integration with external data sources.

## Scope
- **Import Service**: A new service to parse CSV files and convert lines into `Student` entities.
- **Validation**: Strict validation of student data (MSSV format, required fields) and referential integrity (checking if the Faculty and Major exist in the database).
- **GUI Integration**: Adding an "Import CSV" button to the `frmQLSV` interface.
- **Reporting**: Brief summary after import (e.g., "Successfully imported X students, failed Y students").

## Risks and Considerations
- **Data Duplication**: Deciding whether to update existing students (by MSSV) or skip them. Given the current `InsertUpdate` logic, updating existing records is the most consistent approach.
- **Foreign Key Constraints**: Faculty name or ID in the CSV must match existing database entries.
- **File Encoding**: Ensuring UTF-8 support for Vietnamese names.
