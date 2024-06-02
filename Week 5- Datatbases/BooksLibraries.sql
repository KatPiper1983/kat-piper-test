CREATE TABLE [User] (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(50) UNIQUE NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Role VARCHAR(50) NOT NULL CHECK(Role in ('user', 'admin'))
	);

	Drop table Book

	CREATE TABLE Books (
	Id INT IDENTITY PRIMARY KEY,
	Title VARCHAR(75) NOT NULL,
	Author VARCHAR(50) NOT NULL,
	Fiction BIT,
	LocationsId INT,
	CONSTRAINT FK_LocationsBooks FOREIGN KEY (LocationsID)
		REFERENCES Locations(Id)
	);

	Drop table [Location]

	CREATE TABLE Locations (
	Id INT IDENTITY PRIMARY KEY,
	FirstName varchar(50),
	LastName varchar(50),
	StreetAddress varchar(75) NOT NULL,
	City varchar(50) NOT NULL,
	State varchar (2) NOT NULL,
	PostalCode varchar (10) NOT NULL,
	EmailAddress varchar(50) UNIQUE,
	);

INSERT INTO [User] VALUES ('ryan', 'pass1', 'user');
INSERT INTO [User] VALUES ( 'jonathan', 'pass2', 'user'),
('admin', 'pass3', 'admin');
SELECT * FROM [User];

Insert INTO Books VALUES ('East of Eden', 'John Steinbeck', 1, 1);

Insert INTO Locations Values ('Kat', 'Piper', '1411 Buckner St.', 'Fredericksburg', 'VA', '22401', 'kpiper@geico.com');