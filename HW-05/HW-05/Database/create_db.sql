DROP DATABASE IF EXISTS MyAppDB;

CREATE DATABASE IF NOT EXISTS MyAppDB CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE MyAppDB;

CREATE TABLE Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Products (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Description TEXT
);

CREATE TABLE Tasks (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Description TEXT NOT NULL,
    Status VARCHAR(50) NOT NULL
);

CREATE TABLE Contacts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20),
    Address TEXT
);

CREATE TABLE Orders (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    DishName VARCHAR(100) NOT NULL,
    IngredientCount INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

select * from Users;
select * from Products;
select * from Tasks;
select * from Contacts;
select * from Orders;
