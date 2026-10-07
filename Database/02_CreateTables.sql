USE FlavorCraveDB;




-- 1. Roles

CREATE TABLE Roles
(
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(30) NOT NULL UNIQUE
);




-- 2. Users

CREATE TABLE Users
(
    UserId INT PRIMARY KEY IDENTITY(1,1),

    RoleId INT NOT NULL,

    FullName NVARCHAR(100) NOT NULL,

    Email NVARCHAR(150) NOT NULL UNIQUE,

    PasswordHash NVARCHAR(255) NOT NULL,

    Phone NVARCHAR(20) NULL,

    FOREIGN KEY (RoleId)
        REFERENCES Roles(RoleId)
);




-- 3. Wallets

CREATE TABLE Wallets
(
    WalletId INT PRIMARY KEY IDENTITY(1,1),

    UserId INT NOT NULL UNIQUE,

    Balance DECIMAL(10,2)
        NOT NULL DEFAULT 0.00,

    CHECK (Balance >= 0),

    FOREIGN KEY (UserId)
        REFERENCES Users(UserId)
);




-- 4. Menu Categories

CREATE TABLE MenuCategories
(
    CategoryId INT PRIMARY KEY IDENTITY(1,1),

    CategoryName NVARCHAR(50)
        NOT NULL UNIQUE
);



-- 5. Ingredients

CREATE TABLE Ingredients
(
    IngredientId INT PRIMARY KEY IDENTITY(1,1),

    Name NVARCHAR(100)
        NOT NULL UNIQUE,

    Unit NVARCHAR(20)
        NOT NULL,

    QuantityInStock DECIMAL(10,2)
        NOT NULL DEFAULT 0.00,

    LowStockLevel DECIMAL(10,2)
        NOT NULL DEFAULT 0.00,

    IsActive BIT
        NOT NULL DEFAULT 1,

    CHECK (QuantityInStock >= 0),

    CHECK (LowStockLevel >= 0)
);




-- 6. Menu Items

CREATE TABLE MenuItems
(
    MenuItemId INT PRIMARY KEY IDENTITY(1,1),

    CategoryId INT NOT NULL,

    Name NVARCHAR(100)
        NOT NULL UNIQUE,

    Price DECIMAL(10,2)
        NOT NULL,

    IsAvailable BIT
        NOT NULL DEFAULT 1,

    IsActive BIT
        NOT NULL DEFAULT 1,

    CHECK (Price > 0),

    FOREIGN KEY (CategoryId)
        REFERENCES MenuCategories(CategoryId)
);




-- 7. Menu Ingredients
-- Bridge table: 
CREATE TABLE MenuIngredients
(
    MenuItemId INT NOT NULL,

    IngredientId INT NOT NULL,

    QuantityRequired DECIMAL(10,2)
        NOT NULL,

    PRIMARY KEY (MenuItemId, IngredientId),

    CHECK (QuantityRequired > 0),

    FOREIGN KEY (MenuItemId)
        REFERENCES MenuItems(MenuItemId),

    FOREIGN KEY (IngredientId)
        REFERENCES Ingredients(IngredientId)
);


-- 8. Orders

CREATE TABLE Orders
(
    OrderId INT PRIMARY KEY IDENTITY(1,1),

    CustomerId INT NOT NULL,

    ChefId INT NULL,

    OrderDate DATETIME2
        NOT NULL DEFAULT GETDATE(),

    Status NVARCHAR(20)
        NOT NULL DEFAULT 'Pending',

    TotalAmount DECIMAL(10,2)
        NOT NULL DEFAULT 0.00,

    CHECK
    (
        Status IN
        (
            'Pending',
            'In Progress',
            'Completed',
            'Cancelled'
        )
    ),

    CHECK (TotalAmount >= 0),

    FOREIGN KEY (CustomerId)
        REFERENCES Users(UserId),

    FOREIGN KEY (ChefId)
        REFERENCES Users(UserId)
);




-- 9. Order Items
-- Bridge table

CREATE TABLE OrderItems
(
    OrderItemId INT PRIMARY KEY IDENTITY(1,1),

    OrderId INT NOT NULL,

    MenuItemId INT NOT NULL,

    Quantity INT NOT NULL,

    UnitPrice DECIMAL(10,2)
        NOT NULL,

    CHECK (Quantity > 0),

    CHECK (UnitPrice > 0),

    FOREIGN KEY (OrderId)
        REFERENCES Orders(OrderId),

    FOREIGN KEY (MenuItemId)
        REFERENCES MenuItems(MenuItemId)
);

-- 10. Payments
CREATE TABLE Payments
(
    PaymentId INT PRIMARY KEY IDENTITY(1,1),

    OrderId INT NOT NULL UNIQUE,

    CashierId INT NOT NULL,

    Amount DECIMAL(10,2)
        NOT NULL,

    PaymentDate DATETIME2
        NOT NULL DEFAULT GETDATE(),

    PaymentStatus NVARCHAR(20)
        NOT NULL DEFAULT 'Pending',

    CHECK (Amount > 0),

    CHECK
    (
        PaymentStatus IN
        (
            'Pending',
            'Paid',
            'Failed',
            'Refunded'
        )
    ),

    FOREIGN KEY (OrderId)
        REFERENCES Orders(OrderId),

    FOREIGN KEY (CashierId)
        REFERENCES Users(UserId)
);




-- 11. Wallet Transactions
CREATE TABLE WalletTransactions
(
    TransactionId INT PRIMARY KEY IDENTITY(1,1),

    WalletId INT NOT NULL,

    OrderId INT NULL,

    TransactionType NVARCHAR(20)
        NOT NULL,

    Amount DECIMAL(10,2)
        NOT NULL,

    TransactionDate DATETIME2
        NOT NULL DEFAULT GETDATE(),

    CHECK
    (
        TransactionType IN
        (
            'TopUp',
            'Purchase',
            'Refund'
        )
    ),

    CHECK (Amount > 0),

    FOREIGN KEY (WalletId)
        REFERENCES Wallets(WalletId),

    FOREIGN KEY (OrderId)
        REFERENCES Orders(OrderId)
);
