create database Restaurant;

CREATE TABLE Category
(
  categoryId INT IDENTITY(1,1) PRIMARY  KEY,
  categoryName VARCHAR(255) UNIQUE,
);

CREATE TABLE Payment
(
  paymentId INT IDENTITY(1,1) PRIMARY KEY,
  paymentOption VARCHAR(255),
  amount INT,
);

CREATE TABLE Users
(
  usersId INT IDENTITY(1,1) PRIMARY KEY,
  userName VARCHAR(255),
  [password] VARCHAR(255),
  userRole VARCHAR(255)
);

CREATE TABLE Orders
(
  ordersId INT IDENTITY(1,1) PRIMARY KEY,
  date VARCHAR(255),
  time VARCHAR(255),
  orderType VARCHAR(255),
  paymentId INT,
  usersId INT,
  FOREIGN KEY (paymentId) REFERENCES Payment(paymentId),
  FOREIGN KEY (usersId) REFERENCES Users(usersId)
);

CREATE TABLE FoodItem
(
  foodItemId INT IDENTITY(1,1) PRIMARY KEY,
  foodName VARCHAR(255) UNIQUE,
  categoryId INT,
  FOREIGN KEY (categoryId) REFERENCES Category(categoryId)
);

CREATE TABLE Price
(
  id INT IDENTITY(1,1) PRIMARY KEY,
  [type] VARCHAR(255),
  price INT,
  foodItemId INT,
  FOREIGN KEY (foodItemId) REFERENCES FoodItem(foodItemId)
);

CREATE TABLE OrderMenu
(
  foodItemId INT NOT NULL,
  ordersId INT NOT NULL,
  PRIMARY KEY (foodItemId, ordersId),
  FOREIGN KEY (foodItemId) REFERENCES FoodItem(foodItemId),
  FOREIGN KEY (ordersId) REFERENCES Orders(ordersId)
);

select * from Category;
select * from FoodItem
select * from Price;

delete from Category;


insert into Category (categoryName) values ('kottu');
select categoryId, categoryName from Category

select FoodItem.foodItemId, FoodItem.foodName, Category.categoryName from Category inner join FoodItem on FoodItem.categoryId = Category.categoryId
select Price.id, Price.type, Price.price, FoodItem.foodName from Price inner join FoodItem on Price.foodItemId = FoodItem.foodItemId 


select Price.id, Price.type, Price.price, FoodItem.foodName from Price inner join FoodItem on Price.foodItemId = FoodItem.foodItemId 