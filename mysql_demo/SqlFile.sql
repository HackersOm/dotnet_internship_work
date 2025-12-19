create database sunbeam;

use sunbeam;

create table student(roll int primary key , name varchar(20),courseId int);

create table course(courseId int primary key, course_name varchar(20) );

insert into student values(1,"om",1);
insert into student values(2,"shreyash",1);
insert into student values(3,"rohan",2);
insert into student values(4,"sham",2);

select * from student;


insert into course values(1,"AIML");
insert into course values(2,"CSE");
insert into course values(3,"IT");

select * from course;