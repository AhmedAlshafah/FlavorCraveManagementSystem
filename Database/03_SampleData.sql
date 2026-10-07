USE FlavorCraveDB;
GO


-- =============================================
-- 1. Roles
-- =============================================
INSERT INTO Roles (RoleName)
VALUES
('SystemAdmin'),
('Manager'),
('Cashier'),
('Chef'),
('Customer');
GO


-- =============================================
-- 2. Test Users
-- =============================================

-- NOTE:
-- These passwords are plain text only for early development/testing.
-- Later the C# application should use password hashing.

INSERT INTO Users
(
    RoleId,
    FullName,
    Email,
    PasswordHash,
    Phone
)
VALUES
(
    (SELECT RoleId FROM Roles WHERE RoleName = 'SystemAdmin'),
    'Test Admin',
    'admin@gmail.com',
    'test123',
    '0121111111'
),
(
    (SELECT RoleId FROM Roles WHERE RoleName = 'Manager'),
    'Test Manager',
    'manager@gmail.com',
    'test123',
    '0122222222'
),
(
    (SELECT RoleId FROM Roles WHERE RoleName = 'Cashier'),
    'Test Cashier',
    'cashier@gmail.com',
    'test123',
    '0123333333'
),
(
    (SELECT RoleId FROM Roles WHERE RoleName = 'Chef'),
    'Test Chef',
    'chef@flavorcrave.com',
    'test123',
    '0124444444'
),
(
    (SELECT RoleId FROM Roles WHERE RoleName = 'Customer'),
    'Test Customer',
    'customer@flavorcrave.com',
    'test123',
    '0125555555'
);
GO


-- =============================================
-- 3. Customer Wallet
-- =============================================
INSERT INTO Wallets
(
    UserId,
    Balance
)
SELECT
    UserId,
    100.00
FROM Users
WHERE Email = 'customer@flavorcrave.com';
GO


-- =============================================
-- 4. Menu Categories
-- =============================================
INSERT INTO MenuCategories (CategoryName)
VALUES
('Breakfast'),
('Lunch'),
('Dinner'),
('Snacks'),
('Drinks');
GO


-- =============================================
-- 5. Ingredients
-- =============================================
INSERT INTO Ingredients
(
    Name,
    Unit,
    QuantityInStock,
    LowStockLevel
)
VALUES
('Chicken',       'gram',  20000, 5000),
('Rice',          'gram',  30000, 5000),
('Burger Bun',    'piece', 100,   20),
('Cheese',        'slice', 80,    15),
('Lettuce',       'gram',  5000,  1000),
('Coffee Powder', 'gram',  3000,  500),
('Milk',          'ml',    10000, 2000);
GO


-- =============================================
-- 6. Menu Items
-- =============================================
INSERT INTO MenuItems
(
    CategoryId,
    Name,
    Price
)
VALUES
(
    (SELECT CategoryId
     FROM MenuCategories
     WHERE CategoryName = 'Lunch'),

    'Chicken Burger',

    15.90
),
(
    (SELECT CategoryId
     FROM MenuCategories
     WHERE CategoryName = 'Lunch'),

    'Chicken Rice',

    12.90
),
(
    (SELECT CategoryId
     FROM MenuCategories
     WHERE CategoryName = 'Drinks'),

    'Coffee',

    5.50
);
GO


-- =============================================
-- 7. Map Menu Items to Ingredients
-- =============================================

-- Chicken Burger
INSERT INTO MenuIngredients
(
    MenuItemId,
    IngredientId,
    QuantityRequired
)
VALUES
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Chicken Burger'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Chicken'),

    150
),
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Chicken Burger'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Burger Bun'),

    1
),
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Chicken Burger'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Cheese'),

    1
),
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Chicken Burger'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Lettuce'),

    20
),

-- Chicken Rice
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Chicken Rice'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Chicken'),

    120
),
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Chicken Rice'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Rice'),

    200
),

-- Coffee
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Coffee'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Coffee Powder'),

    15
),
(
    (SELECT MenuItemId
     FROM MenuItems
     WHERE Name = 'Coffee'),

    (SELECT IngredientId
     FROM Ingredients
     WHERE Name = 'Milk'),

    100
);
GO


-- =============================================
-- 8. Initial Wallet Top-Up History
-- =============================================
INSERT INTO WalletTransactions
(
    WalletId,
    OrderId,
    TransactionType,
    Amount
)
SELECT
    WalletId,
    NULL,
    'TopUp',
    100.00
FROM Wallets
WHERE UserId =
(
    SELECT UserId
    FROM Users
    WHERE Email = 'customer@flavorcrave.com'
);
GO