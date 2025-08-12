# How to Run the Multi-Form Windows Application in Visual Studio

## Prerequisites
- **Visual Studio 2019 or later** (Community, Professional, or Enterprise)
- **.NET Framework 4.7.2 or higher** (usually included with Visual Studio)
- **Windows operating system** (Windows Forms applications run on Windows)

## Step-by-Step Setup Instructions

### Method 1: Open Project File Directly

1. **Download/Copy all files** to a folder on your computer (e.g., `C:\Projects\MultiFormApp\`)

2. **Open Visual Studio**

3. **Open the Project**:
   - Click `File` → `Open` → `Project/Solution`
   - Navigate to your project folder
   - Select `MultiFormApp.csproj` file
   - Click `Open`

### Method 2: Create New Project and Add Files

1. **Create New Project**:
   - Open Visual Studio
   - Click `Create a new project`
   - Search for "Windows Forms App (.NET Framework)"
   - Select it and click `Next`
   - Project name: `MultiFormApp`
   - Choose location and click `Create`

2. **Replace Generated Files**:
   - Delete the default `Form1.cs` and `Form1.Designer.cs` files
   - Copy all the provided files into your project folder
   - In Solution Explorer, right-click project → `Add` → `Existing Item`
   - Add all the `.cs` files one by one

## Installing Required NuGet Package

The application uses SQLite database, so you need to install the SQLite package:

1. **Open Package Manager Console**:
   - Go to `Tools` → `NuGet Package Manager` → `Package Manager Console`

2. **Install SQLite Package**:
   ```
   Install-Package System.Data.SQLite
   ```

   OR use Package Manager UI:
   - Right-click on project in Solution Explorer
   - Select `Manage NuGet Packages`
   - Click `Browse` tab
   - Search for "System.Data.SQLite"
   - Install the package by System.Data.SQLite team

## Building and Running the Application

### Build the Project
1. **Build Solution**:
   - Press `Ctrl + Shift + B`
   - OR go to `Build` → `Build Solution`
   - Check the Output window for any errors

### Run the Application
1. **Start Debugging**:
   - Press `F5`
   - OR click the green "Start" button in toolbar
   - OR go to `Debug` → `Start Debugging`

2. **Run Without Debugging**:
   - Press `Ctrl + F5`
   - OR go to `Debug` → `Start Without Debugging`

## What Should Happen

1. **Login Form Opens**: The application will start with the login screen
2. **Database Creation**: SQLite database file `UserDatabase.db` is automatically created
3. **Default Account**: Admin account is created (username: `admin`, password: `Admin123!`)

## Default Login Credentials
- **Username**: `admin`
- **Password**: `Admin123!`

## Troubleshooting Common Issues

### Issue 1: SQLite Package Not Found
**Solution**: Install the SQLite NuGet package as described above

### Issue 2: Build Errors
**Solution**: 
- Make sure all `.cs` files are included in the project
- Check that the target framework is .NET Framework 4.7.2
- Rebuild the solution (`Build` → `Rebuild Solution`)

### Issue 3: Database Errors
**Solution**: 
- Make sure the application has write permissions in the project folder
- The database file will be created automatically in the `bin\Debug` folder

### Issue 4: Forms Not Displaying
**Solution**: 
- Check that `Program.cs` has the correct startup form: `Application.Run(new LoginForm());`
- Make sure all form files are properly included in the project

## Project Structure After Setup
```
MultiFormApp/
├── Program.cs (Entry point)
├── DatabaseHelper.cs (Database operations)
├── LoginForm.cs (Login interface)
├── MainForm.cs (Main dashboard)
├── TemperatureForm.cs (Temperature converter)
├── CurrencyForm.cs (Currency converter)
├── CalculatorForm.cs (Calculator)
├── EncryptionForm.cs (Encryption tool)
├── App.config (Configuration)
├── packages.config (NuGet packages)
├── MultiFormApp.csproj (Project file)
└── Properties/
    └── AssemblyInfo.cs (Assembly info)
```

## Testing the Application

1. **Login Test**: Use admin/Admin123! to login
2. **Registration Test**: Create a new user account
3. **Navigation Test**: Access all modules from main dashboard
4. **Module Tests**: Try each converter and calculator
5. **Encryption Test**: Encrypt/decrypt some text
6. **Security Test**: Try wrong passwords (max 3 attempts)

## Additional Notes

- The SQLite database file (`UserDatabase.db`) will be created in your `bin\Debug` or `bin\Release` folder
- You can view the database using SQLite browser tools if needed
- All forms are designed to be modal dialogs except the main dashboard
- The application automatically handles form navigation and cleanup

If you encounter any issues, check the Visual Studio Output window and Error List for detailed error messages.
