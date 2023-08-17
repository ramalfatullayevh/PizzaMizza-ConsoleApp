create database pizzamizza
use pizzamizza

Create table Ingredients
(
	Id int identity Primary key,
	Name nvarchar(50) Not null unique Check(len(Name)>0)
)

insert into Ingredients values
(N'Gobelek'),
(N'Ketchup'),
(N'Toyuq eti')

Create table Pizzas
(
	Id int identity Primary key,
	Name nvarchar(50) Not null unique Check(len(Name)>0),
	Image nvarchar(100) Not null unique Check(len(Image)>0)      
)

insert into Pizzas values
(N'Salyami', N'https://pizzamizza.az/upload/iblock/f59/f59ed0dec6a9812b3b48a6fd32d32f76.jpg?1617617212127733' ),
(N'Texas', N'https://pizzamizza.az/upload/iblock/bb9/bb95f54208c5251eb47e8b2ac9a1b4f8.jpg?1617617212115139' ),
(N'Amerikana', N'https://pizzamizza.az/upload/iblock/2d4/2d42014a85efcde85f020c2071c5551e.jpg?1632152460123364' )

Create table Sizes
(
	Id int identity Primary key,
	Size varchar(50) Not null unique Check(len(Size)>0)
)

insert into Sizes values
(N'Small'),
(N'Medium')



Create table PizzaIngredients
(
	Id int identity Primary key,
	PizzaId int references Pizzas(Id),
	IngredientId int references Ingredients(Id)
)

Create table PizzaSizes
(
	Id int identity Primary key,
	Price decimal(6,2),
	PizzaId int references Pizzas(Id),
	SizeId int references Sizes(Id)
)

Create table Bucket 
(
	Id int identity Primary key,
	TotalPrice decimal(6,2),
)

Create table BucketItems
(
	Id int identity Primary key,
	Count int not null Check(Count>=1),
	PizzaId int references Pizzas(Id),
	BucketId int references Bucket(Id)
)
------------------------------------
ALTER TABLE Pizzas
ADD DeletedTime datetime

Alter TRIGGER DeletePizzas
ON Pizzas
INSTEAD OF DELETE
AS
BEGIN 
	DECLARE @Id int , @DeletedDate datetime
	SELECT @Id =Id , @DeletedDate = DeletedTime FROM deleted
		DELETE PizzaIngredients WHERE PizzaId = @Id
		DELETE PizzaSizes WHERE PizzaId = @Id
		IF(@DeletedDate IS NULL)
		UPDATE Pizzas
		SET DeletedTime = GETUTCDATE()
		WHERE Id = @Id
		ELSE
		DELETE Pizzas WHERE Id = @Id
END
--------------------------------------------
ALTER TABLE Ingredients
ADD DeletedTime datetime

Create TRIGGER DeleteIngredient
ON Ingredients
INSTEAD OF DELETE
AS
BEGIN 
	DECLARE @Id int , @DeletedDate datetime
	SELECT @Id =Id , @DeletedDate = DeletedTime FROM deleted
		DELETE PizzaIngredients WHERE IngredientId = @Id
		IF(@DeletedDate IS NULL)
		UPDATE Ingredients
		SET DeletedTime = GETUTCDATE()
		WHERE Id = @Id
		ELSE
		DELETE Ingredients WHERE Id = @Id
END
--------------------------------------------
ALTER TABLE Sizes
ADD DeletedTime datetime

Create TRIGGER DeleteSize
ON Sizes
INSTEAD OF DELETE
AS
BEGIN 
	DECLARE @Id int , @DeletedDate datetime
	SELECT @Id =Id , @DeletedDate = DeletedTime FROM deleted
		DELETE PizzaSizes WHERE SizeId = @Id
		IF(@DeletedDate IS NULL)
		UPDATE Sizes
		SET DeletedTime = GETUTCDATE()
		WHERE Id = @Id
		ELSE
		DELETE Sizes WHERE Id = @Id
END




