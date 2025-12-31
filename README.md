# LibManager

A comprehensive Windows Forms application developed in C# for managing library operations. This system provides secure access, member management, and book inventory control with a user-friendly interface.

---

## 📋 Project Overview

This library management system was designed specifically for libraries, featuring a secure login system, member registration, book cataloging, and advanced search capabilities. The application follows a structured approach to data management using multi-dimensional arrays for efficient storage and retrieval.

## Features

### Authentication System
- Secure admin login with attempt limiting
- Account lockout after 3 failed attempts (1-minute timer)
- Session management and access control

### Member Management
- Complete member profile registration
- Personal information storage (name, contact, national ID)
- Profile picture upload and management
- Member ID generation and tracking

### Book Catalog System
- Comprehensive book information storage
- Support for multiple book attributes (title, author, publisher, etc.)
- ISBN and publication year tracking
- Book cover image management
  
### Advanced Search
- Multi-criteria search functionality
- Search by book title, author, subject, or publication year
- Real-time results display
- Persian text support

### User Interface
- Persian RTL interface design
- Real-time clock and date display
- Tab-based navigation
- Responsive form controls

## Technical Implementation

### Data Structure
```csharp
// Member data storage: [6 attributes] × [100 members]
string[,] member = new string[6, 100];

// Book data storage: [7 attributes] × [100 books]
string[,] book = new string[7, 100];
```
## Core Components

- **Login Form**: Authentication and access control
- **Main Form**: Primary application interface with tab controls
- **Member Management**: Registration and data handling
- **Book Management**: Cataloging and search functionality

## Installation & Setup

### Prerequisites
- .NET Framework 4.7.2 or later
- Visual Studio 2019+
- Windows OS

### Running the Application
1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

### Default Credentials
- Username: `admin`
- Password: `123`


## Usage Guide

### Administrator Login
1. Launch the application
2. Click "Manager Login"
3. Enter admin credentials
4. Access granted to member and book management tabs

### Managing Members
1. Navigate to "Members" tab
2. Fill member information form
3. Upload profile picture
4. Click "Register" to save
5. Use "New" to clear form

### Managing Books
1. Navigate to "Books" tab
2. Enter book details
3. Upload book cover image
4. Click "Register" to catalog
5. Use search functionality to locate books

### Searching Library
1. Select search criteria (title/author/subject/year)
2. Enter search term
3. Click search button
4. View results in message box

## Technical Details

### Security Features
- Input validation and error handling
- Attempt-limited authentication
- Session-based access control
- Data integrity checks

### Data Management
- Array-based storage system
- Efficient memory utilization
- Simple data retrieval methods
- Scalable structure

### UI/UX Design
- Persian language support
- Right-to-left layout
- Intuitive form design
- Real-time feedback


---
## Application Screenshots


<div align="center">


<img src="https://github.com/user-attachments/assets/827e1033-3a4f-4cf9-9ec4-9af1a982371a" width="35%">
<img src="https://github.com/user-attachments/assets/5caa444a-6047-4448-88d6-537e6bd6d596" width="35%">
<img src="https://github.com/user-attachments/assets/f7a108e0-8eae-4aee-b8ab-bc65a810af04"  width="35%"/>
<img src="https://github.com/user-attachments/assets/64efe871-0da6-4e15-8cf8-d08e79ffdea5" width="35%"/>

<img src="https://github.com/user-attachments/assets/45ff3000-7ca9-4853-bded-ffb68e7d1141" width="35%">


</div>

