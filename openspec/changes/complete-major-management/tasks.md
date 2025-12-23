# Tasks: Complete Major Management

## Phase 1: Business Logic Layer (BUS)
- [ ] Implement `MajorService.InsertUpdate(Major m)` to save or update major details.
- [ ] Implement `MajorService.Delete(int majorId)` with a check for existing students.
- [ ] Implement `MajorService.FindById(int majorId)`.
- [ ] Update `StudentService.GetAll(int facultyId)` to filter students by faculty (even if they have a major).

## Phase 2: User Interface (GUI) - CRUD
- [ ] Design `frmMajor` interface (DataGridView, TextBoxes for Name/ID, Buttons).
- [ ] Implement logic for `frmMajor` (Loading list, Add/Update, Delete).
- [ ] Update `frmMain.Designer.cs` and `frmMain.cs` to add "Quản lý Chuyên ngành" to the Sidebar.

## Phase 3: User Interface (GUI) - Assignment Enrichment
- [ ] Refactor `frmRegisterMajor.cs` to show all students of a faculty when a checkbox is toggled.
- [ ] Ensure the "Register" button correctly handles the "Change" scenario (it already does in BUS, just need GUI awareness).

## Phase 4: Verification
- [ ] Verify adding a new major appearing in the assignment dropdown.
- [ ] Verify changing a student's existing major.
- [ ] Verify that a major cannot be deleted if students are currently enrolled in it.
