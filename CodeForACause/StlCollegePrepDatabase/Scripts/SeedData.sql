-- Period
truncate table Period;

INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 1', '9:00', '9:53');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 2', '9:56', '10:49');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 3', '10:52', '11:45');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 4', '11:48', '12:41');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 5', '1:40', '2:33');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 6', '2:36', '3:29');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 7', '3:32', '4:25');

-- SubjectLevel
truncate table SubjectLevel;

 -- Mathematics
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Algebra', 'Mathematics', '1', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Geometry', 'Mathematics', '2', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Algebra II', 'Mathematics', '3', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Trigonometry', 'Mathematics', '4', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Pre Calc', 'Mathematics', '5', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Calculus', 'Mathematics', '6', '0', '.5')
 -- English 
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng I', 'English', '1', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng II', 'English', '2', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng III', 'English', '3', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng IV', 'English', '4', '0', '.5')
 --Social Studies
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('World History', 'Social Studies', '1', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('American History', 'Social Studies', '2', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Government', 'Social Studies', '3', '0', '.5')
 -- Science
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Physics', 'Science', '1', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Biology', 'Science', '2', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Chemistry', 'Science', '3', '0', '.5')
 -- Fine Arts
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Music', 'Fine Arts', '1', '0', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Improv', 'Fine Arts', '2', '1', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Painting', 'Fine Arts', '3', '1', '.5')
 -- Practical Arts
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Computer Fundementals', 'Practical Arts', '1', '1', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Interior Design', 'Practical Arts', '1', '1', '.5')
 -- Personal Finance
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Persoanl Finance', 'Personal Finance', '1', '1', '.5')
 -- Physical Education
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('PE', 'Physical Education', '1', '1', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Yoga', 'Physical Education', '1', '1', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Body Conditioning', 'Physical Education', '1', '1', '.5')
 -- Health
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Health', 'Health', '1', '1', '.5')
 -- Electives (Foreign Languages)
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Spanish I', 'Foreign Languages', '1', '1', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Spanish II', 'Foreign Languages', '1', '1', '.5')
 -- Electives (Other)
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Psychology', 'Other', '1', '1', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Yearbook', 'Other', '1', '1', '1')

-- Instuctor
truncate table instructor;

INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Cohoon')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Lischwe')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Foster')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Wicks')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Sherod')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Fischer')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Lewis')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Bristol')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Bush')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Wiedemann')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Gallacci-Jones')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Lybarger')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Maul')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Wood')
INSERT INTO Instructor (UserId, Name) VALUES (NEWID(), 'Basler')

-- Course
truncate table Course;

 -- Spanish I
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 1', '9:00', '9:53', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 7', '3:32', '4:25', '2019', 'T2');
 -- Spanish II
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish II', 'Foreign Languages', '1', 'Period 5', '1:40', '2:33', '2019', 'T2'); 
 -- P.E.
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 1', '9:00', '9:53', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 7', '3:32', '4:25', '2019', 'T2');
 -- Body Conditioning
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Body Conditioning', 'Physical Education', '1', 'Period 6', '2:36', '3:29', '2019', 'T2');
 -- Interior Design
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Interior Design', 'Practical Arts', '1', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Interior Design', 'Practical Arts', '1', 'Period 7', '3:32', '4:25', '2019', 'T2');
 --Painting
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Painting', 'Fine Arts', '1', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Painting', 'Fine Arts', '1', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Painting', 'Fine Arts', '1', 'Period 6', '2:36', '3:29', '2019', 'T2');
 -- Yoga
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Yoga', 'Physical Education', '1', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Painting', 'Physical Education', '1', 'Period 4', '11:48', '12:41', '2019', 'T2');
 -- Health
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Health', 'Health', '1', 'Period 5', '1:40', '2:33', '2019', 'T2');
 -- Chemistry
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Chemistry', 'Sciences', '1', 'Period 1', '9:00', '9:53', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Chemistry', 'Sciences', '1', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Chemistry', 'Sciences', '1', 'Period 3', '10:52', '11:45', '2019', 'T2');
 -- Biology
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Biology', 'Sciences', '1', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Biology', 'Sciences', '1', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Biology', 'Sciences', '1', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Biology', 'Sciences', '1', 'Period 7', '3:32', '4:25', '2019', 'T2');
 -- Physics
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Physics', 'Sciences', '1', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level,  PeriodName, StartTime, EndTime, Year, Semester) values ('Physics', 'Sciences', '1', 'Period 7', '3:32', '4:25', '2019', 'T2');

insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Algebra I', 'Mathematics', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Personal Finance', 'Elective', '1', '.5', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Algebra I', 'Mathematics', '1', '.5', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Personal Finance', 'Elective', '1', '.5', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Algebra I', 'Mathematics', '1', '.5', 'Period 7', '3:32', '4:25', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Geometry I', 'Mathematics', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Geometry I', 'Mathematics', '1', '.5', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('PreCalculus', 'Mathematics', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T1');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Trigonometry', 'Mathematics', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Algebra II', 'Mathematics', '2', '.5', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Algebra II', 'Mathematics', '2', '.5', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Algebra II', 'Mathematics', '2', '.5', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('PreCalculus', 'Mathematics', '1', '.5', 'Period 7', '3:32', '4:25', '2019', 'T1');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Trigonometry', 'Mathematics', '1', '.5', 'Period 7', '3:32', '4:25', '2019', 'T2');

insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English II', 'Language', '2', '.5', 'Period 1', '9:00', '9:53', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English II', 'Language', '2', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Improv', 'Elective', '2', '.5', 'Period 7', '3:32', '4:25', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English I', 'Language', '1', '.5', 'Period 1', '9:00', '9:53', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English I', 'Language', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English I', 'Language', '1', '.5', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Computer Fundamentals', 'Elective', '1', '.5', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Computer Fundamentals', 'Elective', '1', '.5', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English III', 'Language', '3', '.5', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English III', 'Language', '3', '.5', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English IV', 'Language', '4', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English IV', 'Language', '4', '.5', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English III', 'Language', '3', '.5', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('English III', 'Language', '3', '.5', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Yearbook', 'Elective', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('World History', 'History', '1', '.5', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('World History', 'History',' 1', '.5', 'Period 4', '11:48', '12:41', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('World History', 'History', '1', '.5', 'Period 6', '2:36', '3:29', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('World History', 'History', '1', '.5', 'Period 7', '3:32', '4:25', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Psychology', 'Elective', '1', '.5', 'Period 1', '9:00', '9:53', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Government', 'Social Studies', '1', '.5', 'Period 2', '9:56', '10:49', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Government', 'Social Studies', '1', '.5', 'Period 3', '10:52', '11:45', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Government', 'Social Studies', '1', '.5', 'Period 5', '1:40', '2:33', '2019', 'T2');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Psychology', 'Elective', '1', '.5', 'Period 6', '2:36', '3:29', '2019', 'T2');