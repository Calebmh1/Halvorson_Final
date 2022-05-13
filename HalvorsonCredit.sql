USE HalvorsonCredit
GO

CREATE TABLE Users(
UserID int NOT NULL IDENTITY(1,1),
UserFirstName varchar(30) NOT NULL,
UserLastName varchar(30) NOT NULL,
UserLogin varchar(30) NOT NULL,
UserPassword varchar(30) NOT NULL
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE Institutions(
InstitutionID int NOT NULL IDENTITY(1,1),
InstitutionName varchar(20) NOT NULL,
InstitutionDescription varchar(200) NOT NULL,
RoutingNumber varchar(20) NOT NULL,
InstitutionAddress varchar(30) NOT NULL
 CONSTRAINT [PK_Institutions] PRIMARY KEY CLUSTERED 
(
	[InstitutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE Accounts(
AccountID int NOT NULL IDENTITY(1,1),
UserID varchar(30) NOT NULL,
Balance Money NOT NULL

 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




CREATE TABLE UserInstitutions(

UserID int NOT NULL,
InstitutionID int NOT NULL,

CONSTRAINT FK_UserInstitution_UserID FOREIGN KEY (UserID) REFERENCES Users(UserID),
CONSTRAINT FK_UserInstitution_InstitutionID FOREIGN KEY (InstitutionID) REFERENCES Institutions(InstitutionID)
)
GO



INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Jimmy','Barr','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Carol','Cann','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Timmy','fills','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Jesse',' Carr','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Raven ', 'Bowman','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Anabelle ', 'Wells','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Rodney ', 'Bowen','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Dante ', 'Rojas','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Penelope', 'Leblanc','1234','1234')
INSERT Users ( UserFirstName,UserLastName,UserLogin,UserPassword) VALUES ('Conner ', 'Pineda','1234','1234')
GO

INSERT Institutions (InstitutionName, InstitutionDescription, RoutingNumber, InstitutionAddress) VALUES ('Big Credit','Big Credit Union', '12345656','1234 Main Street')
INSERT Institutions (InstitutionName, InstitutionDescription, RoutingNumber, InstitutionAddress) VALUES ('Small Credit','Small Credit Union', '543256357','234 Second Street')
INSERT Institutions (InstitutionName, InstitutionDescription, RoutingNumber, InstitutionAddress) VALUES ('North Credit','North Credit Union', '987664545','345 North Street')

INSERT Accounts (UserID, Balance) VALUES (1,5000)
INSERT Accounts (UserID, Balance) VALUES (2,500)
INSERT Accounts (UserID, Balance) VALUES (3,2000)
INSERT Accounts (UserID, Balance) VALUES (4,75000)
INSERT Accounts (UserID, Balance) VALUES (5,10000)
INSERT Accounts (UserID, Balance) VALUES (6,250)
INSERT Accounts (UserID, Balance) VALUES (7,100)
INSERT Accounts (UserID, Balance) VALUES (8,1500)
INSERT Accounts (UserID, Balance) VALUES (9,2500)
INSERT Accounts (UserID, Balance) VALUES (10,50000)




INSERT UserInstitutions (UserID,InstitutionID) VALUES (1,1)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (2,1)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (3,1)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (4,2)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (5,2)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (6,3)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (7,2)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (8,3)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (9,1)
INSERT UserInstitutions (UserID,InstitutionID) VALUES (10,3)
GO





