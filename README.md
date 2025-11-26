# LibManager

A comprehensive Windows Forms application developed in C# for managing library operations in educational institutions. This system provides secure access, member management, and book inventory control with a user-friendly Persian interface.

## 📋 Project Overview

This library management system was designed specifically for school libraries, featuring a secure login system, member registration, book cataloging, and advanced search capabilities. The application follows a structured approach to data management using multi-dimensional arrays for efficient storage and retrieval.

## Features

### 🔐 Authentication System
- Secure admin login with attempt limiting
- Account lockout after 3 failed attempts (1-minute timer)
- Session management and access control

### 👥 Member Management
- Complete member profile registration
- Personal information storage (name, contact, national ID)
- Profile picture upload and management
- Member ID generation and tracking

### 📚 Book Catalog System
- Comprehensive book information storage
- Support for multiple book attributes (title, author, publisher, etc.)
- ISBN and publication year tracking
- Book cover image management

### 🔍 Advanced Search
- Multi-criteria search functionality
- Search by book title, author, subject, or publication year
- Real-time results display
- Persian text support

### 🎨 User Interface
- Persian RTL interface design
- Real-time clock and date display
- Tab-based navigation
- Responsive form controls

## 🛠 Technical Implementation

### Data Structure
```csharp
// Member data storage: [6 attributes] × [100 members]
string[,] member = new string[6, 100];

// Book data storage: [7 attributes] × [100 books]
string[,] book = new string[7, 100];

// Tracking variables
int memberCount = 0;
int bookCount = 0;
```

## Core Components

Login Form: Authentication and access control

Main Form: Primary application interface with tab controls

Member Management: Registration and data handling

Book Management: Cataloging and search functionality

🚀 Installation & Setup
Prerequisites
.NET Framework 4.7.2 or later

Visual Studio 2019+

Windows OS

Running the Application
Clone the repository

Open the solution in Visual Studio

Build the solution (Ctrl+Shift+B)

Run the application (F5)

Default Credentials
Username: admin

Password: 123

📁 Project Structure
text
LibraryManagementSystem/
├── Forms/
│   ├── Login.cs                 # Authentication form
│   ├── MainForm.cs              # Primary application interface
│   └── ...
├── Properties/                  # Application properties
├── Resources/                   # Images and resources
├── App.config                   # Configuration file
└── Program.cs                   # Application entry point
💻 Usage Guide
Administrator Login
Launch the application

Click "Manager Login"

Enter admin credentials

Access granted to member and book management tabs

Managing Members
Navigate to "Members" tab

Fill member information form

Upload profile picture

Click "Register" to save

Use "New" to clear form

Managing Books
Navigate to "Books" tab

Enter book details

Upload book cover image

Click "Register" to catalog

Use search functionality to locate books

Searching Library
Select search criteria (title/author/subject/year)

Enter search term

Click search button

View results in message box

🔧 Technical Details
Security Features
Input validation and error handling

Attempt-limited authentication

Session-based access control

Data integrity checks

Data Management
Array-based storage system

Efficient memory utilization

Simple data retrieval methods

Scalable structure

UI/UX Design
Persian language support

Right-to-left layout

Intuitive form design

Real-time feedback

📸 Application Screenshots

(Add your screenshots here with descriptive captions)

Login Interface: Secure authentication screen

Main Dashboard: Tab-based navigation interface

Member Registration: Complete member profile form

Book Cataloging: Comprehensive book information form

Search Results: Query output display

🎯 Project Achievements

✅ Complete authentication system
✅ Dual-language support (Persian/English)
✅ Robust data management
✅ Advanced search capabilities
✅ Professional UI/UX design
✅ Comprehensive error handling
✅ Efficient memory usage
✅ Scalable architecture
