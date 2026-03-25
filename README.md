# 🧪 CSharpApiTester (.NET 10)
A lightweight, fast, and modern API testing tool built using **C# WinForms (.NET 10.0)**.
This application works as a simplified Postman‑style API tester — allowing developers to quickly send REST API requests and inspect responses.

---

## ✅ Features
- Send **GET, POST, PUT, DELETE** requests
- Add custom **headers**
- Submit raw **JSON/text body**
- View API **response body**
- View **status code** and **response time**
- Clean and simple UI
- Powered by **HttpClient**

---

## ✅ Project Structure
```
CSharpApiTester_NET10/
│── CSharpApiTester.sln
│── README.md
│
├── src/
│   └── ApiTester/
│        ├── ApiTester.csproj
│        ├── Program.cs
│        ├── ApiTesterForm.cs
│        ├── ApiTesterForm.Designer.cs
│        ├── Services/
│        ├── Models/
│        └── Helpers/
│
```

---

## ✅ Requirements
- Visual Studio 2022 (17.8 or later)
- .NET 10 SDK installed
- Windows OS

---

## ✅ How to Run
### **1. Download or Clone**
```
git clone https://github.com/your-username/CSharpApiTester_NET10.git
```

### **2. Open Solution**
Open `CSharpApiTester.sln` in Visual Studio 2022.

### **3. Build the Project**
Press **Ctrl + Shift + B**.

### **4. Run**
Press **F5**.

---

## ✅ How to Use
### **Test GET Request**
- URL: `https://jsonplaceholder.typicode.com/posts/1`
- Method: **GET**
- Click **Send**

### **Test POST Request**
URL:
```
https://jsonplaceholder.typicode.com/posts
```
Body:
```json
{
  "title": "API Test",
  "body": "Checking post request",
  "userId": 1
}
```

---

## ✅ Future Enhancements
- JSON pretty‑print
- Dark mode
- Request history
- Save collections
- Syntax highlighting

---

## ✅ License
MIT License

---

## ✅ Author
Built by **Arun A**.
