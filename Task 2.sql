CREATE TABLE Good (
  [GoodID] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(30)
)

CREATE TABLE Category (
  [CategoryID] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(30)
)

CREATE TABLE GoodCategoryMap (
  [GCID] INT IDENTITY(1,1) PRIMARY KEY,
  [GoodID] INT NOT NULL,
  [CategoryID] INT NOT NULL
)

ALTER TABLE GoodCategoryMap ADD CONSTRAINT FK_GoodCategoryMap_Good_GoodID FOREIGN KEY (GoodID)
REFERENCES Good (GoodID)

ALTER TABLE GoodCategoryMap ADD CONSTRAINT FK_GoodCategoryMap_Category_CategoryID FOREIGN KEY (CategoryID)
REFERENCES Category (CategoryID)

INSERT Good VALUES ('Name1')
INSERT Good VALUES ('Name2')
INSERT Good VALUES ('Name3')

INSERT Category VALUES ('Category1')
INSERT Category VALUES ('Category2')
INSERT Category VALUES ('Category3')

INSERT GoodCategoryMap(GoodID, CategoryID) VALUES (1,1)
INSERT GoodCategoryMap(GoodID, CategoryID) VALUES (1,2)
INSERT GoodCategoryMap(GoodID, CategoryID) VALUES (1,3)

INSERT GoodCategoryMap(GoodID, CategoryID) VALUES (2,1)
INSERT GoodCategoryMap(GoodID, CategoryID) VALUES (2,2)

-- обычно я не использую алиасы в одну букву =)
SELECT 
  G.Name,
  C.Name
FROM
  Good G
  
  LEFT JOIN GoodCategoryMap GCM
    ON GCM.GoodID = G.GoodID

  LEFT JOIN Category C
    ON C.CategoryID = GCM.CategoryID
