# ProductManagementSystem

This application manages data for **products**, **customers**, and **admin login functionality** using **CRUD (Create, Read, Update, Delete)** operations. It is built using **Windows Forms (WinForms)**, a GUI framework for creating desktop applications in .NET. The application includes the following key components:

1. **Admin Login**:
   - Authenticates admin users by verifying their username and password against the database.
   - On successful login, it redirects to a form where the admin can manage products or customers.

2. **Product Management**:
   - Allows adding, updating, deleting, and viewing product details stored in a SQL database.
   - Product attributes include ID, name, description, category, price, stock quantity, manufacturer, release date, status, and additional info.
   - Implements parameterized SQL commands to prevent **SQL Injection**.

3. **Customer Management**:
   - Allows adding, updating, deleting, and viewing customer details.
   - Attributes include customer ID, name, email, phone number, address, registration date, last purchase date, total purchases, username, and password.
   - Uses parameterized queries to handle data operations securely.

4. **Product Search**:
   - Provides a search feature where customers can look up products by name.
   - Displays the matching product details in a grid view.

5. **Data Display**:
   - All data, whether products or customers, is displayed in a DataGridView, which is updated dynamically during CRUD operations.

6. **Navigation**:
   - The application provides seamless navigation between forms (e.g., admin login, product list, and customer management).

---

### **Technologies Used**

1. **C# (.NET Framework)**:
   - Core programming language for logic implementation.
   - Enables integration of SQL operations with UI components in Windows Forms.

2. **Windows Forms (WinForms)**:
   - Provides the graphical user interface for managing products and customers.
   - Facilitates the design of user-friendly forms and controls.

3. **SQL Server**:
   - Used as the database to store product and customer data.
   - Tables include:
     - `admin`: Stores admin credentials (username and password).
     - `product_basic_info`: Stores product-related information.
     - `customer_info`: Stores customer-related information.

4. **ADO.NET**:
   - Used for database connectivity and operations such as querying, inserting, updating, and deleting data.
   - Uses `SqlCommand`, `SqlDataAdapter`, and `DataSet` for interaction with the database.

5. **Exception Handling**:
   - Handles errors during data operations, such as invalid inputs or failed database connectivity.

6. **Security Features**:
   - Parameterized queries in SQL commands prevent **SQL Injection attacks**.
   - Basic input validation is applied for numeric fields and formatted dates.

7. **DataGridView**:
   - Used for dynamic data visualization of product and customer records.

8. **Data Manipulation**:
   - Handles date fields (`release_date`, `register`, `last_purchase`) and numeric fields (`price`, `stock_quantity`) for better consistency.

---

### **Potential Enhancements**
1. **Validation Enhancements**:
   - Add more input validation (e.g., ensuring emails follow a specific format).
   - Display descriptive error messages when validation fails.

2. **UI Improvements**:
   - Use modern frameworks like **WPF** or a front-end library for improved aesthetics.

3. **Encryption**:
   - Encrypt passwords in the database for enhanced security.

4. **Code Refactoring**:
   - Abstract repeated code (e.g., database operations) into reusable methods for cleaner structure.

5. **Error Logging**:
   - Implement logging for errors instead of directly displaying error messages in `MessageBox`.

Let me know if you'd like further details or assistance with enhancing this code! 
