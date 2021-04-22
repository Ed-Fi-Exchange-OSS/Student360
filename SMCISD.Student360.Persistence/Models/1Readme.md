Please Run the Following Script in order to generate the models and context. 

 > Scaffold-DbContext "Database=; Data Source=; Persist Security Info=True; User Id=; Password=" Microsoft.EntityFrameworkCore.SqlServer -Schemas "student360" -Tables "ParentUSIToStudentUSI","TeacherToStudentUsi","LocalEducationAgencyIdToStaffUSI","ParentUSIToSchoolId", "SchoolIdToStaffUSI" -DataAnnotations -OutputDir Models -ContextDir EntityFramework -Context Student360Context -Force

 NOTE: This script will overwrite the files.