--Comments in SQL
/*
multi-line comment
*/

-- CREATE - DDL

CREATE TABLE Movie (
	Id int,
	Title varchar(50),
	Price numeric(12,2),
	Available bit,
	ReturnDate bigint
);
--DROP - DDL
--DROP TABLE Movie;

--Add in some new Data
--INSERT - DML
INSERT INTO Movie VALUES (1, 'Iron Man', 5, 1, 0);
INSERT INTO Movie VALUES (2, 'The Avengers', 6.6, 1, 0),
(3, 'Ant-Man', 4.5, 1, 0);
INSERT INTO Movie VALUES
(4, 'Requiem for a Dream', 6, 1, 0),
(5, 'The Goonies', 5, 1, 0),
(6, 'Lord of the Rings', 7, 1, 0),
(7, 'Black Swan', 3, 1, 0);

-- SELECT - DQL
SELECT * FROM Movie;
SELECT Title from Movie;
Select Id, Title, Price from Movie

--UPDATE-DML
UPDATE Movie SET Available=1;

--DELETE - DML
DELETE FROM Movie;

--WHERE Clause-> allows us to pick and choose which records we want to apply the statements to
-- uses a Predicate: Field = value

--SELECT
SELECT * FROM Movie WHERE Price=5;
SELECT * FROM Movie WHERE Price >=5;
SELECT * FROM Movie WHERE Available = 0; --since no bools in T-SQL-> must test bit against the value 0 or 1

--UPDATE
UPDATE Movie SET Price = 6 WHERE Id=2;
UPDATE Movie SET Price = 7 WHERE Title = 'The Avengers';

--DELETE
DELETE FROM Movie WHERE Title = 'Iron Man';

SELECT * FROM Movie;
--Other Predicates for our Where Clause
SELECT * FROM Movie WHERE Title = 'Iron Man';
SELECT * FROM Movie WHERE Title LIKE 'Iron Man%';-- any amount of text can come after %
SELECT * FROM Movie WHERE Title LIKE 'Black%';
SELECT * FROM Movie WHERE Title LIKE '%r'; --anything can come before 'r', but title must end in 'r'
SELECT * FROM Movie WHERE Title LIKE '%a%'; -- anything can precede or succeed the a, finds everything with a in it
SELECT  UPPER(Title) AS UpperName FROM Movie WHERE Title LIKE '%a%';

SELECT LOWER (Title) FROM Movie WHERE Title LIKE '%a%'; --LOWER returns data in lower case form, UPPER will do upper case

--LOWER() and UPPER()
--Scalar Functions- function that accepts 1 input (record) and produces 1 output

--Aggregate functions
-- Calculate some value (1 output) using multiple
-- records (many inputs)
-- AVG, MAX, MIN, SUM, COUNT
SELECT MAX(Price) FROM Movie;
SELECT MIN(Price) FROM Movie;
SELECT AVG(Price) FROM Movie;
SELECT ROUND(AVG(Price), 2) FROM Movie;
SELECT SUM(Price) FROM Movie WHERE Available = 1;

UPDATE Movie SET Available = 0 WHERE Title = 'Ant-Man';

SELECT COUNT(Title) FROM Movie;--number of records with a title
UPDATE Movie SET Title = NULL WHERE Title = 'Ant-Man';
SELECT COUNT(Title) FROM Movie;
SELECT COUNT(Id) FROM Movie;
SELECT COUNT(*) FROM Movie;

--GROUP BY - is used with Aggregate Functions to break records into values of that category - groups/buckets
SELECT SUM(Price) FROM Movie GROUP BY Available;
SELECT Available,SUM(Price) AS Total FROM Movie GROUP BY Available;
SELECT Available, COUNT(*) AS Count,SUM(Price) AS Total FROM Movie GROUP BY Available;

SELECT COUNT(*),Price FROM Movie GROUP By Price;
SELECT COUNT(*),Price FROM Movie WHERE Price >= 5 GROUP BY Price;

SELECT Available,SUM(Price) FROM Movie WHERE Price <=5 GROUP BY Available HAVING COUNT(*) >=2;

SELECT COUNT(*),Price FROM Movie GROUP BY Price HAVING COUNT(*) >=2;

--ORDER BY -Changes the way in which the View/Cursor is displayed/returned
-- It doesn't filter records, just organizes them-> Does not affect their order as stored in the Database
SELECT * FROM Movie ORDER BY Price; --Ascending order by default
SELECT * FROM Movie ORDER BY Price DESC; --Descending 

SELECT * FROM Movie ORDER BY Available,Price DESC,Title;

--Of available movies, get me the top 2 cheapest rentals

--Bonus Self-Study: Subqueries

SELECT TOP 2 * FROM Movie WHERE Available = 1 ORDER BY Price