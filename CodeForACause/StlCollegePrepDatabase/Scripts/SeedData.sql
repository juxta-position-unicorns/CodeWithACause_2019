-- Period
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 1', '9:00', '9:53');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 2', '9:56', '10:49');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 3', '10:52', '11:45');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 4', '11:48', '12:41');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 5', '1:40', '2:33');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 6', '2:36', '3:29');
INSERT INTO Period (PeriodName, StartTime, EndTime)  VALUES ('Period 7', '3:32', '4:25');

-- SubjectLevel
 -- Mathematics
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Algebra', 'Mathematics', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Geometry', 'Mathematics', '2', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Algebra II', 'Mathematics', '3', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Trigonometry', 'Mathematics', '4', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Pre Calc', 'Mathematics', '5', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Calculus', 'Mathematics', '6', 'No', '1')
 -- English 
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng I', 'English', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng II', 'English', '2', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng III', 'English', '3', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Eng IV', 'English', '4', 'No', '1')
 --Social Studies
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('World History', 'Social Studies', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('American History', 'Social Studies', '2', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Government', 'Social Studies', '3', 'No', '1')
 -- Science
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Physics', 'Science', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Biology', 'Science', '2', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Chemistry', 'Science', '3', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Psychology', 'Science', '1', 'No', '1')
 -- Fine Arts
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Music', 'Fine Arts', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Theatre', 'Fine Arts', '2', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Art', 'Fine Arts', '3', 'No', '1')
 -- Practical Arts
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Computer Fundementals', 'Practical Arts', '1', 'No', '.5')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Interior Design', 'Practical Arts', '1', 'No', '.5')
 -- Personal Finance
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Persoanl Finance', 'Personal Finance', '1', 'No', '.5')
 -- Physical Education
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('PE', 'Physical Education', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Yoga', 'Physical Education', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Body Conditioning', 'Physical Education', '1', 'No', '1')
 -- Health
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Health', 'Health', '1', 'No', '.5')
 -- Electives (Foreign Languages)
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Spanish I', 'Foreign Languages', '1', 'No', '1')
insert into SubjectLevel (CourseName, Subject, Level, IsElective, CreditHours) values ('Spanish II', 'Foreign Languages', '1', 'No', '1')

-- Instuctor
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
 -- Spanish I
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 1', '9:00', '9:53', '1', 'Full Year');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 4', '11:48', '12:41', '1', 'Full Year');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 6', '2:36', '3:29', '1', 'Full Year');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish I', 'Foreign Languages', '1', 'Period 7', '3:32', '4:25', '1', 'Full Year');
 -- Spanish II
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Spanish II', 'Foreign Languages', '1', 'Period 5', '1:40', '2:33', '1', 'Full Year'); 
 -- P.E.
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 1', '9:00', '9:53', '1', 'Full Year');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 2', '9:56', '10:49', '1', 'Full Year');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 3', '10:52', '11:45', '1', 'Full Year');
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('P.E.', 'Physical Education', '1', 'Period 7', '3:32', '4:25', '1', 'Full Year');
 -- Body Conditioning
insert into Course (CourseName, Subject, Level, CreditHours, PeriodName, StartTime, EndTime, Year, Semester) values ('Body Conditioning', 'Physical Education', '1', 'Period 6', '2:36', '3:29', '1', 'Full Year');
