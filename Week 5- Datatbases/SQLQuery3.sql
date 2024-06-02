CREATE TABLE Book (
	Id int,
	Title varchar(50),
	Author varchar(50),
	Fiction bit,
	);

CREATE TABLE Location (
	Id int,
	FirstName varchar(50),
	LastName varchar(50),
	StreetAddress varchar(75),
	City varchar(50),
	State varchar (2),
	PostalCode varchar (10),
	EmailAddress varchar(50),
	);

INSERT INTO Book VALUES
(1,'East of Eden', 'John Steinbeck', 1),
(2, 'Catcher in the Rye', 'J.D. Salinger', 1),
(3, 'The Last Thing He Told Me', 'Laura Dave', 1), 
(4, 'Washingtons Spies', 'Alexander Rose', 0);

INSERT INTO Location VALUES
(1, 'Kat', 'Piper', '1411 Buckner Street', 'Fredericksburg', 'VA', '22401', 'kpiper@gmail.com'),
(2, 'Liz', 'Belcher', '1018 Rappahannock Avenue', 'Fredericksburg', 'VA', '22401', 'LBelcher@gmail.com'),
(3, 'Seth', 'Smith', '917 Sylvania Avenue', 'Fredericksburg', 'VA', '22401', 'SSmith@gmail.com'),
(4, 'Juliet', 'Brown', '311 Lee Avenue', 'Fredericksburg', 'VA', '22401', 'JBrown@gmail.com' );


