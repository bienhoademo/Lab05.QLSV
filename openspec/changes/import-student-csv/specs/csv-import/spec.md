# Spec: CSV Import Capability

## ADDED Requirements

### Requirement: Import Student data from CSV
The system MUST allow users to upload a CSV file to bulk-insert or update student records.

#### Scenario: Successful Import of a new student
- **Given** a CSV file containing a student row with a new MSSV.
- **And** the Faculty name in the row exists in the database.
- **When** the user imports the file.
- **Then** a new student record is created in the database.

#### Scenario: Update existing student via Import
- **Given** a CSV file containing a student row with an existing MSSV.
- **When** the user imports the file.
- **Then** the existing student record is updated with the values from the CSV.

#### Scenario: Validation failure for non-existent Faculty
- **Given** a CSV file containing a student row with a Faculty name that does not exist.
- **When** the user imports the file.
- **Then** the row is skipped, and an error is reported in the final summary.

#### Scenario: Support for extended attributes
- **Given** a CSV file with columns for BirthDate, Gender, Address, and Phone.
- **When** the user imports the file.
- **Then** these attributes are correctly saved to the student record.
