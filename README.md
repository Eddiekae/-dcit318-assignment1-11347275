# DCIT318 Assignment 1 - C# Console Application

## Overview
This project is a C# console application developed for DCIT318 (Introduction to Computer Science) Assignment 1. The application provides three utility programs: a grade calculator, a ticket price calculator, and a triangle type identifier.

## Student Information
- **Student ID**: 11347275
- **Course**: DCIT318 -
- **Assignment**: Assignment 1
- **Language**: C# (.NET 7.0)

## Features

### 1. Grade Calculator
Converts numerical grades (0-100) into letter grades:
- **A**: 90-100
- **B**: 80-89
- **C**: 70-79
- **D**: 60-69
- **F**: Below 60

### 2. Ticket Price Calculator
Calculates ticket prices based on age:
- **GHC 7**: Children (12 and under) and Seniors (65 and above)
- **GHC 10**: Adults (13-64 years)

### 3. Triangle Type Identifier
Identifies triangle types based on side lengths:
- **Equilateral**: All three sides equal
- **Isosceles**: Two sides equal
- **Scalene**: All sides different

## Project Structure
```
DCIT318_Assignment1_11347275/
├── DCIT318_Assignment1_11347275.csproj    # Project configuration file
├── Program.cs                             # Main application code
├── obj/                                   # Build output directory
└── bin/                                   # Compiled binaries
```

## Prerequisites
- .NET 7.0 SDK or later
- Visual Studio 2022 or Visual Studio Code
- Windows, macOS, or Linux operating system

## Installation & Setup

### Option 1: Using Visual Studio
1. Open Visual Studio 2022
2. Click "Open a project or solution"
3. Navigate to the project folder and select `DCIT318_Assignment1_11347275.csproj`
4. Build the solution (F5 or Ctrl+Shift+B)

### Option 2: Using Command Line
1. Open terminal/command prompt
2. Navigate to the project directory:
   ```bash
   cd DCIT318_Assignment1_11347275
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Build the project:
   ```bash
   dotnet build
   ```

## Usage

### Running the Application

#### Using Visual Studio:
- Press `F5` to run with debugging
- Press `Ctrl+F5` to run without debugging

#### Using Command Line:
```bash
dotnet run
```

### Application Menu
When you run the application, you'll see the following menu:
```
Select a Program to Run:
1. Grade Calculator
2. Ticket Price Calculator
3. Triangle Type Identifier
Enter your choice (1-3):
```

### Example Usage

#### Grade Calculator
```
Enter numerical grade (0-100): 85
Grade: B
```

#### Ticket Price Calculator
```
Enter your age: 25
Ticket Price: GHC 10
```

#### Triangle Type Identifier
```
Enter side 1: 5
Enter side 2: 5
Enter side 3: 5
Triangle Type: Equilateral
```

## Technical Details

### Technologies Used
- **Language**: C# 11.0
- **Framework**: .NET 7.0
- **Project Type**: Console Application
- **IDE Support**: Visual Studio 2022, Visual Studio Code

### Key Concepts Demonstrated
- Console I/O operations
- Conditional statements (if-else)
- Switch statements
- Method creation and organization
- User input validation
- Basic arithmetic operations

## Error Handling
The application includes basic input validation:
- Expects numeric input for grades, ages, and side lengths
- Provides clear error messages for invalid menu choices

## Build Configuration
- **Target Framework**: .NET 7.0
- **Output Type**: Console Application
- **Nullable Reference Types**: Enabled
- **Implicit Usings**: Enabled

## Testing
The application has been tested with various input scenarios:
- Boundary values for grade ranges
- Edge cases for age calculations
- Different triangle configurations

## Future Enhancements
Potential improvements could include:
- More sophisticated input validation
- Additional mathematical utilities
- File input/output operations
- Graphical user interface (GUI)
- Unit tests for each calculator function

## Contributing
This is an individual assignment. Please do not submit this as your own work without proper attribution.

## License
This project is created for educational purposes as part of DCIT318 coursework at the University of Ghana.

## Support
For questions or issues regarding this assignment, please contact:
- Course Instructor: DCIT318 Teaching Team
- Student: 11347275
