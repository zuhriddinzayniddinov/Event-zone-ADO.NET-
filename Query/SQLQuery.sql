CREATE DATABASE [EventRoom];

USE EventRoom;

CREATE TABLE [Users] (
  [id] integer PRIMARY KEY IDENTITY(1,1),
  [FirstName] varchar(15),
  [LastName] varchar(15),
  [PhoneNumber] varchar(12),
  [Password] varchar(10),
  [Rol] integer
)
GO

CREATE TABLE [Room] (
  [id] integer PRIMARY KEY IDENTITY(1,1),
  [RoomName] varchar(20),
  [Capasity] integer
)
GO

CREATE TABLE [Order] (
  [id] integer PRIMARY KEY IDENTITY(1,1),
  [user_id] integer,
  [StartTime] datetime,
  [FinishTime] datetime,
  [RoomId] integer,
  [EventName] varchar(50),
  [Status] integer
)
GO

CREATE TABLE [Messenge] (
  [id] integer IDENTITY(1,1),
  [SendUserId] integer,
  [ReceiveUserId] integer,
  [MessengeTime] datetime,
  [TextMesseng] varchar(100),
  [ViewMessenge] integer
)
GO

ALTER TABLE [Order] ADD FOREIGN KEY ([user_id]) REFERENCES [Users] ([id])
GO

ALTER TABLE [Messenge] ADD FOREIGN KEY ([SendUserId]) REFERENCES [Users] ([id])
GO

ALTER TABLE [Messenge] ADD FOREIGN KEY ([ReceiveUserId]) REFERENCES [Users] ([id])
GO

ALTER TABLE [Order] ADD FOREIGN KEY ([RoomId]) REFERENCES [Room] ([id])
GO

/* Users.Rol 
1 oddiy foydalanuvchi
2 Admin
3 Company
*/

INSERT INTO [Users]
([FirstName],[LastName],[PhoneNumber],[Password],[Rol])
VALUES
('ZUHRIDDIN','ZAYNIDDINOV','936675925','DOTNET199',3);


-- bu Users yaratish
GO  
CREATE PROCEDURE  [CreateAccaunt]
	@FirstName varchar(15),
	@LastName varchar(15),
    @PhoneNumber varchar(12),
	@Password varchar(10),
	@Rol integer
AS   
INSERT INTO [Users]
([FirstName],[LastName],[PhoneNumber],[Password],[Rol])
VALUES
(@FirstName,@LastName,@PhoneNumber,@Password,@Rol);
GO  

-- bu usersning o'z akkauntiga kirishi
GO  
CREATE PROCEDURE  [GetAccaunt]
    @PhoneNumber varchar(12),
	@Password varchar(10)
AS   
SELECT * FROM [Users]
WHERE PhoneNumber = @PhoneNumber AND Password = @Password
GO  
-- MISOL UCHUN ;-)
EXECUTE [GetAccaunt] N'936675925',N'DOTNET199'
EXECUTE [CreateAccaunt] N'Sherali',N'Jurayev',N'999999999',N'kechaoqsom',1
SELECT * FROM [Users]

INSERT INTO [Room]
([RoomName],[Capasity])
VALUES
('Robototexnika',20);

--bu xona yaratish
GO  
CREATE PROCEDURE  [CreateRoom]
	@RoomName varchar(20),
	@Capasity integer
AS   
INSERT INTO [Room]
([RoomName],[Capasity])
VALUES
(@RoomName,@Capasity);
GO 

GO  
CREATE PROCEDURE  [GetRoom]
AS   
SELECT * FROM [Room]
GO 

-- Misol uchun
EXECUTE [CreateRoom] N'Uber',25
EXECUTE [GetRoom]


/*Status
1. tastiqlanmagan
2. RAD ELILGAN
3. jarayonda
4. tUGAGAN
*/


INSERT INTO [Order]
([user_id],[StartTime],[FinishTime],[RoomId],[EventName],[Status])
VALUES
(3,'2022.12.15','2022.12.16',1,'Yaponiyada chiqqan robottacha',3)


GO  
CREATE PROCEDURE  [GetOrders]
	@NowTime datetime
AS   
SELECT [Users].FirstName,[Room].RoomName,EventName,[Order].StartTime FROM [Order],[Room],[Users]
WHERE [Order].user_id = [Users].id and [Order].RoomId = [Room].id and [Order].Status = 3 and [Order].StartTime >= @NowTime
GO

GO  
CREATE PROCEDURE  [CreateOrders]
	@user_id integer,
    @StartTime datetime,
	@FinishTime datetime,
	@RoomId integer,
	@EventName varchar(50)
AS   
INSERT INTO [Order]
([user_id],[StartTime],[FinishTime],[RoomId],[EventName],[Status])
VALUES
(@user_id,@StartTime,@FinishTime,@RoomId,@EventName,1)
GO


SELECT * FROM [Order]

--Misol uchun
EXECUTE [GetOrders] N'2022.12.15'
EXECUTE [CreateOrders] 4,'2022.12.18','2022.12.18',2,'Taksi haydovchilari uchun yangi prolejenniya'