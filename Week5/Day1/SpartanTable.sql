DROP TABLE IF EXISTS SPARTA;

CREATE TABLE SPARTA
(
Title VARCHAR(10),
FirstName VARCHAR(20),
LastName VARCHAR(20),
AttendedUniversity BIT,
CourseTaken VARCHAR(20),
MarkAchieved INT
);

INSERT INTO SPARTA
(
Title,
FirstName,
LastName,
AttendedUniversity,
CourseTaken,
MarkAchieved
) VALUES (
'MR',
'Labahang',
'Limbu',
1,
'Theoretical Physics',
75
);

select * from SPARTA;