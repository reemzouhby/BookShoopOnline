

# 📚 HeavenBooks – Online Bookshop Management System

## 📌 Project Overview

**HeavenBooks** is a full-featured **C# Windows Forms** application connected to **SQL Server**, designed to manage an online bookshop. It supports two main user roles: **Admin** and **Client (User)**, with secure authentication, password recovery via email, dynamic book filtering, order processing, and sales promotions.

---

## 👤 User Roles

### 🧑‍💼 Admin:
- Login using email and password
- Add, delete, and manage books
- Manage sales and discounts
- View reports on inventory and orders
- Receive email notifications when new orders are placed

### 👤 Client (User):
- Sign up with name, email, password, and phone number
- Login to the system
- Search for books by:
  - Title
  - Author
  - Subject
  - Type (language/category)
- Browse books on sale
- Add books to cart and place orders
- Reset forgotten password via email token

---

## 🔐 Password Reset Workflow

1. User clicks **Forgot Password**
2. A random secure code (token) is sent to the user’s email
3. The user enters the code to verify identity
4. The user is allowed to reset the password

---

## 🛒 Ordering Workflow

1. Client selects books and adds them to their cart
2. Client confirms the order
3. Order is stored in the `Order` and `OrderDetails` tables
4. Admin receives an email notification of the new order

---

## 🛠️ Technologies Used

- **C# (.NET Framework / Windows Forms)**
- **Microsoft SQL Server**
- **ADO.NET** for database connection
- **SMTP** for email functionality
- **Visual Studio**

---

## 🧾 Database Schema

The project uses a relational schema with the following key tables:

| Table | Description |
|-------|-------------|
| `User` | Stores admin and client accounts |
| `Author` | Stores author information |
| `Book` | Stores book details, linked to authors and admins |
| `Sales` | Sales campaigns with discounts |
| `SaleBooks` | Books that are part of a sale |
| `Order` | Orders placed by users |
| `OrderDetails` | Books in each order |
| `Pass_change` | Tokens for password reset functionality |

> Database name: **HeavenBookss**

### Sample SQL Tables:
You’ve already included the creation script. Here's a short summary of key fields:

- `Book(Title, Author_id, Subject, Price, Quantity, ISBN, Description, Language)`
- `User(Email, Password, IsAdmin)`
- `Sales(Sales_Name, Disc_percent, StartDate, EndDate)`
- `Order(Order_id, User_id, Order_Date)`
- `Pass_change(User_id, Token, Valid_until)`

---

## 📬 Email Functionality

- Email is used for:
  - Password reset (token verification)
  - Order confirmation to the admin

---

## 📈 Future Enhancements

- Implement responsive UI with WPF
- Add payment gateway integration
- Support reviews/ratings for books
- Mobile version with Xamarin or MAUI

---

## ✅ How to Run the Project

1. Open the project in **Visual Studio**
2. Ensure SQL Server is running
3. Import the database using the provided script
4. Update connection string in `App.config`
5. Run the application

---

## 🧑‍💻 Author

Developed by **Reem** ,**Sourour** and **Majdeline** ad  as a complete Windows application for managing online book sales and inventory efficiently.

