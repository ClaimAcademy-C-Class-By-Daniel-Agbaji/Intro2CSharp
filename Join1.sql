--CREATE DATABASE Sales;

CREATE TABLE tblSalesman(
	Salesman_ID INT PRIMARY KEY NOT NULL,
	Sname VARCHAR (200) NULL, 
	Scity VARCHAR (200) NULL,
	Scommission DECIMAL (3,2) NULL
	);
	USE Sales;

CREATE TABLE tblCustomer(
	Customer_ID INT PRIMARY KEY NOT NULL,
	Cname VARCHAR (200) NULL,
	Ccity VARCHAR (200) NULL,
	Grade INT NULL, 
	Salesman_ID INT FOREIGN KEY(Salesman_ID) references tblSalesman(Salesman_ID)
	);
	USE Sales;

INSERT INTO tblSalesman (Salesman_ID, Sname, Scity, Scommission)
VALUES(
	5001, 'James Hoog', 'New York', 0.15),
	(5002, 'Nail Knite', 'Paris', 0.13),
	(5005, 'Pit Alex', 'London', 0.11),
	(5006, 'Mc Lyon', 'Paris', 0.12),
	(5003, 'Lauson Hen', '', 0.12),
	(5007, 'Paul Adam', 'Rome', 0.13);

INSERT INTO tblCustomer (Customer_ID, Cname, Ccity, Grade, Salesman_ID)
VALUES(
	3002, 'Nick Rimando', 'New York', 100, 5001),
	(3005, 'Graham Zusi', 'California', 200, 5002),
	(3001, 'Brad Guzan', 'London', null, 5005),
	(3004, 'Fabian Johns', 'Paris', 300, 5006),
	(3007, 'Brad Davis', 'New York', 200, 5001),
	(3009, 'Geoff Camero', 'Berlin', 100, 5003),
	(3008, 'Julian Green', 'London', 300, 5002);

SELECT Sname, Scity, Cname, Ccity
FROM tblSalesman
INNER JOIN tblCustomer
on tblSalesman.Scity = tblCustomer.Ccity;

SELECT Sname, Scity, Scommission, Customer_ID, Cname, Ccity, Grade
FROM tblSalesman
FULL OUTER JOIN tblCustomer
ON tblSalesman.Salesman_ID = tblCustomer.Salesman_ID;

SELECT Sname, Cname, Scommission
FROM tblSalesman
INNER JOIN tblCustomer
ON tblSalesman.Salesman_ID = tblCustomer.Salesman_ID
WHERE Scommission > .12;

SELECT Sname 
FROM tblSalesman
INNER JOIN tblCustomer
ON tblSalesman.Salesman_ID = tblCustomer.Salesman_ID
WHERE Scommission > .12 and Scity != Ccity;

select Cname, tblSalesman.Salesman_ID, Sname, Scity, Scommission
from tblCustomer
inner join tblSalesman
on tblCustomer.Salesman_ID = tblSalesman.Salesman_ID
order by Cname asc;