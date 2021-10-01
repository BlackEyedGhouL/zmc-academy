CREATE DATABASE ZMC_Academy

CREATE TABLE Registration (
  Name varchar(25),
  Id varchar (10) Primary key,
  Password varchar(10),
  Address varchar(20),
  Contact_number int ,
  Birth_of_date date,
  School varchar (30)
)

CREATE TABLE Ol_Results
 (    
	Year int,
	Mathematics char,
	Science char,
	Sinhala char,
	English char,
	History char,
	Religion char,
	Bucket_1 char,
	Bucket_2 char,
	Bucket_3 char,
	Id varchar (10) foreign key references Registration (Id)
 )

 CREATE TABLE Al_Results
 (
	Year int,
	Stream varchar(30),
	Bucket_1 char,
	Bucket_2 char,
	Bucket_3 char,
	English char,
	Id varchar (10) foreign key references Registration (Id)
 )

 CREATE TABLE Other_Qualifications
 (
    Category varchar(30),
	Name varchar(30),
	Reason varchar(60),
	Year int,
	Id varchar (10) foreign key references Registration (Id)
 )
  CREATE TABLE Other_Qualifications1
 (
    Category varchar(30),
	Name varchar(30),
	Reason varchar(60),
	Year int,
	Id varchar (10) foreign key references Registration (Id)
 )

CREATE TABLE Payment(
 
  Method varchar(20),
  Type varchar(30),
  Card_no int,
  Expire_date date,
  Cvc int,
  Id varchar (10) foreign key references Registration (Id)
)

CREATE TABLE Course 
(
  Course_school varchar(30),
  Course_name varchar(30),
  Id varchar (10) foreign key references Registration (Id)
)

CREATE TABLE News 
(
  News_id varchar(5),
  News_name varchar(80),
  News_date varchar(30),
)

select*from Registration
select*from Al_Results
select*from Other_Qualifications
select*from Other_Qualifications1
select*from Payment
select*from Course
select*from Books
select*from Booklist
select*from Pastpaperlist
select*from Pastpapers
select*from Attendence1
select*from Report_problem

Insert into News(News_id,News_name,News_date)
values('A',' Celebration for the start of the academic year',' 2020-09-01')
Insert into News(News_id,News_name,News_date)
values('B',' Academy pauses athletic activities until at least Dec. 03',' 2020-09-02')
Insert into News(News_id,News_name,News_date)
values('C',' Revised spring semester academic schedule released',' 2020-09-04')
Insert into News(News_id,News_name,News_date)
values('D',' ZMC Academy remains in top 10 academies in S.L. rankings',' 2020-09-05')

CREATE TABLE Books 
(
  B_id varchar(10) primary key ,
  B_name varchar(30),
  B_author varchar(40)
)

CREATE TABLE Booklist
(
  B_addeddate date,
  B_returndate date,
  B_id varchar(10) foreign key references  Books (B_id),
  Id varchar (10) foreign key references Registration (Id)
)

Insert into Books(B_id,B_name,B_author)
values('0001','Adventures of Tom Sawyer','Mark Twain')
Insert into Books(B_id,B_name,B_author)
values('0002','Alice in Wonderland','Lewis Carrol')
Insert into Books(B_id,B_name,B_author)
values('0003','Agni Veena','Kazi Nasrul Islam')
Insert into Books(B_id,B_name,B_author)
values('0004','Animal Farm','George Orwell')
Insert into Books(B_id,B_name,B_author)
values('0005','Ben Hur','Lewis Wallace')
Insert into Books(B_id,B_name,B_author)
values('0006','Anna Karenina','Leo Tolstoy')
Insert into Books(B_id,B_name,B_author)
values('0007','The Lady of the Last Minstrel','Sir Walter Scott')
Insert into Books(B_id,B_name,B_author)
values('0008','A passage to India','E.M.Forster')
Insert into Books(B_id,B_name,B_author)
values('0009','Das Kapital','Karl Marx')

update Books
set B_name = 'The Lady of the Last Minstrel'
where B_id = 0007

update Registration
set Contact_number = '+94715627836'
where Id = 0001

update Registration
set Email = 'Nimal@gmail.com'
where Id = 0001

update Registration
set Email = '34senith@gmail.com'
where Id = 0001

update Registration
set Contact_number = '+94711997144'
where Id = 0002

CREATE TABLE Pastpapers (
P_id varchar(10) primary key,
Subject varchar (20),
Year int 
)

CREATE TABLE Pastpaperlist(
P_addeddate date,
P_returndate date,
P_id varchar(10) foreign key references  Pastpapers (P_id),
Id varchar (10) foreign key references Registration (Id)
)

Insert into Pastpapers(P_id,Subject,Year)
values('0001','GUI','2004')
Insert into Pastpapers(P_id,Subject,Year)
values('0002','OOP','2004')
Insert into Pastpapers(P_id,Subject,Year)
values('0003','CN','2004')
Insert into Pastpapers(P_id,Subject,Year)
values('0004','CT','2004')
Insert into Pastpapers(P_id,Subject,Year)
values('0005','CO','2004')
Insert into Pastpapers(P_id,Subject,Year)
values('0006','OS','2004')
Insert into Pastpapers(P_id,Subject,Year)
values('0007','GUI','2005')
Insert into Pastpapers(P_id,Subject,Year)
values('0008','OOP','2005')
Insert into Pastpapers(P_id,Subject,Year)
values('0009','CN','2005')
Insert into Pastpapers(P_id,Subject,Year)
values('0010','CT','2005')
Insert into Pastpapers(P_id,Subject,Year)
values('0011','CO','2005')
Insert into Pastpapers(P_id,Subject,Year)
values('0012','OS','2005')

CREATE TABLE Attendence1 (
 Id varchar (10) foreign key references Registration (Id),
 date date,
 Attended varchar(10)
)

CREATE TABLE Attendence2 (
 Id varchar (10) foreign key references Registration (Id),
 date date,
 Attended varchar(10)
)

Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-12','Yes')
Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-13','Yes')
Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-14','Yes')
Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-15','Yes')
Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-16','Yes')
Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-17','Yes')
Insert into Attendence2(Id,date,Attended)
values('0003','2020-05-18','Yes')

alter table Registration
alter column Contact_number varchar(12) 

exec sp_rename 'Registration.School','Email','COLUMN';

CREATE TABLE Report_problem(
  Summary varchar (50),
  Details varchar (100),
  date date,
  Id varchar (10) foreign key references Registration (Id),
)