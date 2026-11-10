# Flavor Crave Management System

## Group Assignment – C# OOP Restaurant Management System

Flavor Crave Management System is a Windows Forms application developed in C# with Microsoft SQL Server.

The system contains five user roles:

- System Admin
- Manager
- Cashier
- Chef
- Customer

Each team member is responsible for programming one role, but everyone works inside the **same Visual Studio project, same GitHub repository, and same database structure**.

---

# 1. Important Rules Before Starting

Do **not** create your own Visual Studio project.

Do **not** create your own database design.

Do **not** work directly on the `main` branch.

Do **not** rename shared classes, folders, database tables, or columns without discussing it with the group first.

Do **not** modify another member's role folder unless the group agrees.

Everyone must clone and work from this repository:

`FlavorCraveManagementSystem`

The `main` branch contains the stable shared version of the project.

Each member works on their own branch.

---

# 2. Branch Assignment

| Role | Branch |
|---|---|
| System Admin | `admin` |
| Manager | `manager` |
| Cashier | `cashier` |
| Chef | `chef` |
| Customer | `customer` |

Ahmed is responsible for the `manager` branch and project integration.

Before coding, make sure GitHub Desktop shows your correct branch.

Example:

If you are responsible for Chef, your current branch must be:

`chef`

Do **not** code on `main`.

---

# 3. Software Everyone Must Install

Every member is using Windows.

Install the following:

### Visual Studio

Install Visual Studio with:

`Desktop development with .NET`

The project is a C# Windows Forms application.

The project currently targets:

`net10.0-windows`

If Visual Studio reports that the required .NET SDK is missing, install/update the required .NET SDK or Visual Studio.

Do not change the target framework individually.

### GitHub Desktop

Download and install GitHub Desktop.

Sign in using the GitHub account that was invited to this repository.

### Microsoft SQL Server

Install Microsoft SQL Server Developer or Express.

You may also install SQL Server Management Studio (SSMS) if you want a graphical interface for the database.

---

# 4. How to Download the Project

Do not download the project as a ZIP file.

Use GitHub Desktop.

### Step 1

Open GitHub Desktop.

### Step 2

Sign in to your GitHub account.

### Step 3

Choose:

`File → Clone Repository`

### Step 4

Select:

`FlavorCraveManagementSystem`

### Step 5

Choose a local location such as:

`Documents\GitHub\FlavorCraveManagementSystem`

### Step 6

Click:

`Clone`

Cloning means GitHub creates a connected copy of the repository on your computer.

---

# 5. Switch to Your Branch

After cloning, GitHub Desktop may initially show:

`main`

Do not start coding there.

Click:

`Current Branch`

Then choose your assigned branch.

Example:

`chef`

Before doing any programming, confirm that GitHub Desktop shows your branch name at the top.

---

# 6. Open the Visual Studio Project

From the cloned repository, open the Visual Studio solution/project.

The project should already contain the shared login system and dashboard forms.

Do not create another solution.

When Visual Studio opens:

1. Build the project.
2. Confirm there are no errors.
3. Run the application.
4. Test the login.
5. Confirm that your role opens the correct dashboard.

Only start your role implementation after this works.

---

# 7. Database Setup

The database folder contains three SQL scripts:

```text
Database
├── 01_CreateDatabase.sql
├── 02_CreateTables.sql
└── 03_SampleData.sql