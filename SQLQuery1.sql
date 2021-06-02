create table Subscribers(
	subscriber_id int not null primary key identity,
	username varchar(100) not null,
	password varchar(100) not null,
	name varchar(100) not null
)

create table Books(
	book_id int not null primary key identity,
	title varchar(100) not null,
	author varchar(100) not null,
	rating varchar(100) not null
)

create table Librarians(
	librarian_id int not null primary key identity,
	username varchar(100) not null,
	password varchar(100) not null,
	name varchar(100) not null
)

insert into Librarians values
('AlexF', '123456', 'Alexandru')

select * from Subscribers

create table ReservedBooks(
	reserved_id int not null primary key identity,
	id_carte int not null,
	id_subscriber int not null
)

create table BorrowedBooks(
	borrowed_id int not null primary key identity,
	id_carte int not null,
	id_subscriber int not null
)

create table ReturnedBooks(
	returned_id int not null primary key identity,
	id_carte int not null,
	id_subscriber int not null
)

select * from Books
select * from BorrowedBooks
select * from ReturnedBooks
select * from ReservedBooks


insert into Books values
('Fundatia','Asimov','4.5',6),
('Metro 2033','Dimitry Glukhovsky','4',8),
('Carrie','Stephen Edwin King','4',5),
('The Shining','Stephen Edwin King','4',6),
('The Stand','Stephen Edwin King','4',7),
('Mr. Mercedes','Stephen Edwin King','4',8),
('Pet Sematary','Stephen Edwin King','4',9),
('11.22.63','Stephen Edwin King','4',10)