CREATE TABLE table_persons (
	id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	last_name TEXT NOT NULL,
	first_name TEXT NOT NULL,
	date_of_birth TEXT NOT NULL 
);

INSERT INTO table_persons(last_name, first_name, date_of_birth) 
VALUES('Starinin', 'Andrey', '1986-02-18'),
		('Anonimus', 'Anonim', '2024-03-18');
		
SELECT * FROM table_persons;