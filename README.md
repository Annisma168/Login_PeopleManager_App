# WPF Login & Person Manager – Udemy Practice Project

## 📚 Description
This is a simple WPF application developed as a practical exercise during the course **“Master C# Programming from A to Z. Dive deep into .NET, OOP, Clean Code, LINQ, WPF, Generics, Unit Testing, and more”** on Udemy. This project was built to solidify and demonstrate what I’ve learned. It connects multiple areas of knowledge into one real-world-style interface.

It combines multiple core C# and WPF concepts:
- A **login screen** that uses system environment variables for authentication
- A **person management screen** where users can add and remove people from a list using a modern WPF UI

---

## ✅ Features Implemented

- **WPF User Interface** with `UserControl` and `ContentControl` for navigation  
- **Password authentication** via `PasswordBox` and environment variable lookup  
- **Data binding** using `ObservableCollection<Person>` for dynamic list updates  
- **Event handling** for input validation, button enabling, and item deletion  
- **Simple form logic**: adding name + age, clearing fields, input validation  
- **Dynamic content switching**: login → person manager screen  
- **Safe collection updates** using `.ToList()` during removal  

---

## 🧠 Technologies & Concepts Practiced

- C# fundamentals  
- OOP: classes, properties, methods  
- Collections: `List<T>`, `ObservableCollection<T>`  
- WPF: XAML layout, controls, events  
- Data binding & `DataContext`  
- Clean code practices (separation of logic, naming)  
- Environment variable access with `Environment.GetEnvironmentVariable`  
- LINQ (`.Cast<Person>().ToList()`)

---

## 🚀 Getting Started

1. Clone this repository
2. Open the solution in Visual Studio
3. Set an environment variable on your system:

   **Windows example**: ` setx LoginApp_Udemy_Lesson278 "Test123" `

Enter the password to access the Invoice Manager screen

## 📄 Screenshots

Login screen and invoice management view with a list of people:
![image](https://github.com/user-attachments/assets/4efcc00f-5a04-45fa-9f5e-5095b06142ec)
![image](https://github.com/user-attachments/assets/dcff395b-3846-448a-98cc-010a943e9ecf)
![image](https://github.com/user-attachments/assets/155ae3ef-e350-4e80-8055-e8f5548bfcdd)

## 📘 Based On

**Udemy Course:** Master C# Programming from A to Z by Denis Panjuta


