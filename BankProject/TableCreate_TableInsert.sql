CREATE TABLE [Customer] (
  [AccountNo] Int IDENTITY(10000000,1),
  [Name] Varchar(60),
  [Address] Varchar(80),
  [PhoneNo] Varchar(12),
  [Balance] Varchar(20),
  PRIMARY KEY ([AccountNo])
);

CREATE TABLE [Login] (
  [AccountNo] Int IDENTITY (10000000,1),
  [Password] Varchar(8),
  PRIMARY KEY ([AccountNo])
);


INSERT INTO Customer
VALUES('Daiane Silva', 'Dublin','+35301010101','200.000'),
     ('John Mayer', 'Cork', '+35302020202', '10.000')

select * from Customer

INSERT INTO Login
VALUES('Pass1@')   

INSERT INTO Login
VALUES('Pass2@') 

SELECT * FROM Customer AS C JOIN Login AS L ON C.AccountNo = L.AccountNo



      
