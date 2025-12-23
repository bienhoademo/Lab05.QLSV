# Proposal: Complete Major Management and Assignment

## Summary
Implement a comprehensive system for managing Majors (Specializations) and assigning/changing them for students. This includes full CRUD operations for the `Major` entity and an enhanced interface for assigning majors to any student, regardless of their current major status.

## Motivation
Currently, the application only allows registering majors for students who do not have one. There is also no way to add, edit, or delete the majors themselves within the GUI. To provide a complete management experience, users need to be able to:
1. Define and manage the list of majors available for each faculty.
2. Change the major of any student at any time (e.g., if they switch specializations).

## Scope
- **DAL**: No changes needed (entities already exist).
- **BUS**: 
    - Add CRUD methods to `MajorService`.
    - Enhance `StudentService` or `MajorService` to support retrieving students who already have majors for the assignment screen.
- **GUI**:
    - Create `frmMajor` for CRUD operations on Majors.
    - Update `frmRegisterMajor` to allow filtering/selecting students who already have a major, enabling "Change Major" functionality.
    - Link `frmMajor` to `frmMain` sidebar.

## Risks & Considerations
- Data integrity: Deleting a major that has students assigned to it should be handled (either blocked or students reset to NULL). We will block deletion if students are assigned.
- UI Consistency: Ensure the new `frmMajor` follows the modern styling established in Phase 2.
