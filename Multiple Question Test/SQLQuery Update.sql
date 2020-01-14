
drop table userInfo
drop table Test
drop table Questions
drop table Answer

 

create table userInfo (
	   userID int identity(1,1) primary key, 
       studentNumber int,
       name varchar(30),
	   surname varchar(30),
       password varchar(30),
	    islecture varchar(5) , /*true or false */ 
)


create table Test (
testID int identity (1,1) primary key,
testName varchar(30)
)

create table Questions (
		
		testID int foreign key references Test(testID),
        questionID int identity (1,1)  primary key,
		question varchar(60),
		possibleAnswer1 varchar (30),
		possibleAnswer2 varchar (30),
		possibleAnswer3 varchar (30),
		possibleAnswer4 varchar (30),
		actualAnswer char,
	
)

create table Answer (
		userID int foreign key references userInfo(userID),
		testID int foreign key references Test(testID),
        questionID int foreign key references Questions(questionID),
		userAnswer char,
)




insert into userInfo
values (100,'James','Mohr', '101','false'),

       (200,'Michael','Mohr', '101','false'),
	   (300, 'Admin','Admin', '101','true')



insert into Test
values ('Ice 1: Math Test'),
		('Ice 2: Math Test')

insert into Questions
values (1,'One angle is 56^o and one is 87^o. Which is bigger', 'They are both small','56^0','87^0','They are both big', 'C'),
		(1,'There is an angle that is 124^o. What type of angle is it', 'Acute Angle','Obtuse Angle','Right Angle','None of the above', 'B'),
		(1,'An Acute angle is one that is','Greater than 90^o','Equal to 90^o', 'Equal to 180^o', 'Less than 90^o', 'D'),
		(1,'The letter "K" has what type of angle?', 'Acute Only','Acute and right','Right Only','Caute and Obtuse', 'B'),
		(1,'What is the biggest', 'Acute Angle','Right Angle','Obtuse','They all too small', 'C'),
		
		
		(2,'Round 482 to the nearest tens', '500','490','480','485', 'C'),
		(2,'Round 158 985 to the nearest thousands', '200 00','150 000','159 000','155 000', 'C'),
		(2,'Round 53.2891 to the nearest hundredths place', '53.29','53','53.289','53.3', 'A'),
		(2,'Round 1 589 247 to the nearest millions', '1 600 000','2 000 000','1 600','1 590 000', 'B'),
		(2,'Round 0.752831', '0.75','1','0.753','0.7528', 'A'),
		(2,'Round 8 780.52 to the nearest hundreds', '8 780.52','8 880','9 000','8 700.5', 'A'),
		(2,'Round 754 812 to the nearest tens', '750 000','800 000','755 000','754 810', 'D')

insert into Answer
values (1,1,1,'D'),
		(1,1,2,'B'),
		(1,1,3,'D'),
		(1,1,4,'C'),
		(1,1,5,'C'),
		
		(1,2,6,'D'),
		(1,2,7,'C'),
		(1,2,8,'A'),
		(1,2,9,'B'),
		(1,2,10,'A'),
		(1,2,11,'A'),
		(1,2,12,'D'),
		
		(2,1,1,'C'),
		(2,1,2,'B'),
		(2,1,3,'D'),
		(2,1,4,'B'),
		(2,1,5,'C'),

		(2,2,6,'C'),
		(2,2,7,'B'),
		(2,2,8,'C'),
		(2,2,9,'C'),
		(2,2,10,'C'),
		(2,2,11,'C'),
		(2,2,12,'D')

select * from userInfo
select * from Test
select * from Questions
select * from Answer

select question, possibleAnswer1, possibleAnswer2, possibleAnswer3, possibleAnswer4, actualAnswer, testID, questionID
from Questions
create table Questions (
		
		testID int foreign key references Test(testID),
        questionID int identity (1,1)  primary key,
		question varchar(60),
		possibleAnswer1 varchar (30),
		possibleAnswer2 varchar (30),
		possibleAnswer3 varchar (30),
		possibleAnswer4 varchar (30),
		actualAnswer char,
	
)
