DROP TABLE IF EXISTS Products;
CREATE TABLE Products
(
    Id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_ProductId PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

DROP TABLE IF EXISTS Categories;
CREATE TABLE Categories
(
    Id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_CategoryId PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

DROP TABLE IF EXISTS CategoriesOfProducts;
CREATE TABLE CategoriesOfProducts
(
    ProductId INT,
    CategoryId INT
);

SELECT Products.Name AS product_name, ResultTable.category_name AS category_name
FROM Products
    LEFT JOIN 
        (SELECT CategoriesOfProducts.ProductId AS product_id, Categories.Name AS category_name
         FROM CategoriesOfProducts
            JOIN Categories ON CategoriesOfProducts.CategoryId = Categories.Id) AS ResultTable
    ON (ResultTable.product_id = Products.Id)