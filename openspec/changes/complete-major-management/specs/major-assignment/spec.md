# Specification: Major Assignment Enrichment

## MODIFIED Requirements

### Requirement: Assign or Change Major
The system must support assigning a major to a new student OR changing the major of an existing student.

#### Scenario: Change Existing Major
- **Given** a student already has Major A.
- **When** I select this student in the Assignment screen and select Major B, then click Register.
- **Then** the student's major must be updated to Major B in the database.

#### Scenario: Filter by Assignment Status
- **Given** I am in the Assignment screen.
- **When** I check "Show only students without major".
- **Then** only students with NULL MajorID should be listed.
- **When** I uncheck it.
- **Then** all students of the selected faculty must be listed.
