create database Books;
use BOOKS
GO

create table Details(Book_id INT identity(1,1) Primary Key NOT Null ,
Book_name nvarchar(60), 
Book_Author nvarchar(30),
Book_seller nvarchar(30),
Book_code bigint Unique Not Null,
Total_pages int,
Book_price nvarchar(10));