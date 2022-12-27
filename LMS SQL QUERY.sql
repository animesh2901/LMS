SELECT * FROM ADMINS
SELECT * FROM LOGINS
select * from UserRolls
select * from Teachers
select * from Students

insert into Teachers values ('Mateen', 'Khan', 'Mateen', 8484848484, '2022/08/01', 2)
insert into Teachers values ('Mahesh', 'Singh', 'Mahesh', 2525252525, '2022/03/01', 2)

insert into Students values ('Nites', 'Kumar', 'Nites', 1122334455, '2022/09/01', 3)
insert into Students values ('Surya', 'Pratap', 'Surya', 2225556661, '2022/10/10', 3)

insert into Logins values ('Admin', 'Pass', 1)
insert into Logins values ('Mateen', 'Pass', 2)
insert into Logins values ('Nites', 'Pass', 3)
insert into Logins values ('Surya', 'Pass', 3)
insert into Logins values ('Mahesh', 'Pass', 2)
insert into Logins values ('Admin2', 'Pass', 1)


insert into UserRolls values ('ADMIN')
insert into UserRolls values ('TEACHER')
insert into UserRolls values ('STUDENT')

insert into Admins values ('Admin', '2022/12/26', 1)
insert into Admins values ('Admin2', '2000/01/20', 1)

CREATE PROC USER_ROLE (
@USERNAME NVARCHAR(50) )
AS BEGIN 
SELECT L.UserRollIDId FROM Logins L WHERE L.UserName = @USERNAME
END;

exec USER_ROLE Admin
drop proc USER_ROLE

CREATE PROC Valid_Login
(
@USERNAME NVARCHAR(50), @PASSWORD NVARCHAR(250)
) AS BEGIN
SELECT * FROM LOGINS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD
END;

Exec Valid_Login Admin, Pass

Drop Proc Valid_Login