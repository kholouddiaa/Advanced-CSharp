# Company Management System (OOP6)

## Overview

This project is a simple Company Management System built using C# and Object-Oriented Programming (OOP) principles.

The system demonstrates:

* Abstraction
* Inheritance
* Polymorphism
* Interfaces
* SOLID Principles (Interface Segregation + Open/Closed)

---

## Project Structure

```
oop6
│
├── Employee.cs
├── FullTimeEmployee.cs
├── PartTimeEmployee.cs
├── Manager.cs
├── HR.cs
├── Report.cs
├── IPrintable.cs
├── IReportCreator.cs
└── Program.cs
```

---

## Features

### 1. Employee Management

There are different types of employees:

* FullTimeEmployee → Salary + Overtime
* PartTimeEmployee → HourRate × Hours
* Manager → Salary + Overtime + Bonus
* HR → Salary + Overtime

Each employee type has its own salary calculation by overriding the `CalculateSalary()` method.

---

### 2. Report System

Only:

* Manager
* HR

can create reports.

This is enforced using the `IReportCreator` interface, ensuring that only specific roles have the ability to generate reports.

---

### 3. Printing System

Any class that can be printed implements:

```csharp
IPrintable
```

This allows the program to print:

* Employees
* Reports

using a unified method:

```csharp
static void Print(IPrintable item)
{
    item.Print();
}
```

This demonstrates runtime polymorphism.

---

## OOP Concepts Used

### Abstraction

`Employee` is an abstract base class:

```csharp
public abstract decimal CalculateSalary();
```

Each derived class provides its own implementation.

---

### Inheritance

All employee types inherit from:

```csharp
Employee
```

This promotes code reuse and shared structure.

---

### Interfaces

#### IPrintable

Implemented by any class that needs printing behavior (Employee, Report).

#### IReportCreator

Implemented only by:

* Manager
* HR

This follows the Interface Segregation Principle.

---

### Polymorphism

Example usage:

```csharp
Print(e1);
Print(e2);
Print(report);
```

The same method works for different object types because they share a common interface.

---

## How to Run

1. Open the solution in Visual Studio.
2. Build the project.
3. Run the application.
4. The console will display:

   * Employee information
   * Generated reports

---

## Example Output

```
FullTime => Id: 1, Name: Ali, Base: 10000, Overtime: 500, Total: 10500
PartTime => Id: 2, Name: Omar, HourRate: 80, Hours: 120, Total: 9600
Manager => Id: 3, Name: Sara, Base: 15000, Overtime: 700, Bonus: 2000, Total: 17700
HR => Id: 4, Name: Mona, Base: 11000, Overtime: 400, Total: 11400

=== Reports ===
----- REPORT -----
Title     : Monthly Summary
Details   : Sales improved by 12%.
CreatedBy : Manager: Sara
```

---

## Design Notes

* The system is open for extension (new employee types can be added easily).
* Responsibilities are clearly separated.
* Interfaces are used to control behavior access.
* The project demonstrates practical OOP design in a clean and structured way.

