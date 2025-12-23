# Tasks: Import Student Data from CSV

## Phase 1: BUS Logic
- [ ] Create `StudentImportService` class in `Lab05.BUS/Services/`.
- [ ] Implement `ImportFromCsv(string filePath)` method.
- [ ] Implement CSV parsing logic (handling quotes and commas).
- [ ] Implement Entity lookup logic (mapping Faculty Name -> FacultyID).

## Phase 2: GUI Implementation
- [ ] Update `frmQLSV.Designer.cs` to add `btnImport` button.
- [ ] Implement `btnImport_Click` event handler in `frmQLSV.cs`.
- [ ] Add error handling and success message summary.

## Phase 3: Verification
- [ ] Create a test CSV file with various scenarios (new student, existing student, invalid faculty).
- [ ] Execute import and verify database results.
- [ ] Verify that all 9 student attributes are correctly imported.
