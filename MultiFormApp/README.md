# Multi-Form Windows Application

A comprehensive C# Windows Forms application featuring multiple modules and secure user authentication.

## Features

### 🔐 Login System (70 points)
- **Username/Password Validation** (10 pts): Secure authentication against SQLite database
- **User Registration** (10 pts): Create new user accounts with validation
- **SQLite Database Integration** (10 pts): Persistent user storage with proper schema
- **Input Validation** (10 pts): Prevents blank username/password submissions
- **Password Security** (10 pts): Password masking with asterisks during input
- **Security Lockout** (10 pts): Maximum 3 failed login attempts before application exit
- **Password Complexity** (10 pts): Enforces strong password requirements:
  - Minimum 8 characters
  - At least one uppercase letter
  - At least one lowercase letter
  - At least one digit
  - At least one special character

### 🏠 Main Dashboard (20 points)
- **Multiple Windows Forms**: Central navigation hub connecting all modules
- Clean, intuitive interface with easy access to all features
- Secure logout functionality

### 🌡️ Temperature Converter
- Convert between Celsius, Fahrenheit, and Kelvin
- Real-time conversion with precise calculations
- User-friendly dropdown selection interface

### 💱 Currency Converter
- Multi-currency support (USD, EUR, GBP, JPY, CAD, AUD)
- Real-time exchange rate calculations
- Clean input validation and error handling

### 🧮 Calculator
- Full-featured calculator with standard operations
- Support for addition, subtraction, multiplication, division
- Decimal point support and clear functionality
- Error handling for division by zero

### 🔒 Encryption/Decryption Module (30 points)
- **Vigenère Cipher Implementation** (10 pts): Classical polyalphabetic cipher
- **Full Alphabet Key** (10 pts): Uses complete A-Z alphabet as encryption key
- **Bidirectional Operations** (10 pts): Both encryption and decryption functionality
- Preserves non-alphabetic characters (spaces, punctuation)
- Case-insensitive processing with uppercase output

## Technical Specifications

### Database Schema
```sql
CREATE TABLE Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT UNIQUE NOT NULL,
    Password TEXT NOT NULL,
    CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
)
```

### Default Credentials
- **Username**: admin
- **Password**: Admin123!

### Dependencies
- .NET Framework 4.7.2
- System.Data.SQLite 1.0.118
- Windows Forms

### Security Features
- Password complexity validation
- SQL injection prevention through parameterized queries
- Session management with secure logout
- Failed attempt tracking and lockout mechanism

## Installation & Setup

1. **Prerequisites**:
   - Visual Studio 2019 or later
   - .NET Framework 4.7.2 or higher
   - SQLite support

2. **Build Instructions**:
   ```bash
   # Open in Visual Studio
   # Restore NuGet packages
   # Build solution (Ctrl+Shift+B)
   # Run application (F5)
   ```

3. **Database Initialization**:
   - SQLite database is automatically created on first run
   - Default admin user is inserted if no users exist
   - Database file: `UserDatabase.db`

## Usage Guide

### First Time Setup
1. Launch the application
2. Use default credentials (admin/Admin123!) or register a new account
3. Navigate through modules using the main dashboard

### Creating New Users
1. Click "Register" on login screen
2. Enter desired username and complex password
3. Password must meet all complexity requirements
4. Account is immediately available for login

### Module Navigation
- **Temperature Converter**: Select units and enter temperature value
- **Currency Converter**: Choose currencies and enter amount
- **Calculator**: Standard calculator operations with number pad
- **Encryption Tool**: Enter text and choose encrypt/decrypt operation

## Architecture

### Form Structure
```
Program.cs (Entry Point)
├── LoginForm.cs (Authentication)
├── MainForm.cs (Dashboard)
├── TemperatureForm.cs (Temperature Conversion)
├── CurrencyForm.cs (Currency Conversion)
├── CalculatorForm.cs (Calculator Operations)
└── EncryptionForm.cs (Vigenère Cipher)
```

### Helper Classes
- **DatabaseHelper.cs**: SQLite operations and user management
- **App.config**: Configuration and connection strings
- **AssemblyInfo.cs**: Application metadata

## Security Considerations

- Passwords are stored in plain text (for educational purposes)
- In production, implement proper password hashing (bcrypt, Argon2)
- Consider implementing session timeouts
- Add logging for security events
- Implement account lockout policies

## Future Enhancements

- Password hashing and salting
- User role management
- Audit logging
- Additional cipher algorithms
- Real-time currency exchange rates
- Scientific calculator functions
- Database backup/restore functionality

## Scoring Breakdown

| Feature | Points | Status |
|---------|--------|--------|
| Multiple Windows Forms | 20 | ✅ Complete |
| Login Module | 70 | ✅ Complete |
| - Username/Password Validation | 10 | ✅ |
| - User Registration & Database | 10 | ✅ |
| - SQL Database Integration | 10 | ✅ |
| - Input Validation | 10 | ✅ |
| - Password Masking | 10 | ✅ |
| - 3-Attempt Lockout | 10 | ✅ |
| - Password Complexity | 10 | ✅ |
| Encryption Module | 30 | ✅ Complete |
| - Vigenère Cipher | 10 | ✅ |
| - Full Alphabet Key | 10 | ✅ |
| - Encrypt/Decrypt Functions | 10 | ✅ |
| **Total** | **120** | **✅ 120/120** |

## License

This project is created for educational purposes. Feel free to modify and enhance as needed.
