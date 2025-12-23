# Specification: Major CRUD

## ADDED Requirements

### Requirement: Manage Specializations
The system must allow administrators to define specific majors for each faculty.

#### Scenario: Add a New Major
- **Given** I am in the Major Management screen.
- **When** I enter a name and select a faculty, then click Add.
- **Then** the major should be saved to the database and linked to that faculty.

#### Scenario: Delete a Major
- **Given** a major exists.
- **When** I click Delete and confirm.
- **Then** if no students are assigned to this major, it is removed.
- **And** if students are assigned, the system must block the deletion and inform the user.
