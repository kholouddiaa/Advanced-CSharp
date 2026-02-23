

#  Fraction Calculator

### Using Operator Overloading and Static Members in C#


## 📖 Overview

This project implements a **Fraction Calculator** in C# using:

* Operator Overloading
* Static Members
* Object-Oriented Programming principles

The `Fraction` class represents rational numbers and supports arithmetic operations, comparisons, and automatic simplification.

---

##  Assignment Objectives

This project fulfills the following requirements:

* Create a `Fraction` class
* Implement constructors (default and parameterized)
* Implement fraction simplification using GCD
* Overload arithmetic and comparison operators
* Use a static counter to track created objects
* Implement a static method to retrieve object count

---

##  Class Structure

###  Class: `Fraction`

| Member               | Description                               |
| -------------------- | ----------------------------------------- |
| `int Numerator`      | Represents the numerator                  |
| `int Denominator`    | Represents the denominator                |
| `static int Counter` | Tracks number of Fraction objects created |

---

##  Constructors

###  Default Constructor

```csharp
Fraction()
```

Creates a fraction with value:

```
0/1
```

###  Parameterized Constructor

```csharp
Fraction(int numerator, int denominator)
```

* Initializes numerator and denominator.
* Throws exception if denominator = 0.
* Automatically simplifies the fraction.
* Increments static counter.

---

##  Methods

###  `void Simplify()`

Reduces the fraction to its simplest form using GCD.

Example:

```
10/20 → 1/2
```

---

###  `void Display()`

Prints fraction in the format:

```
4/3
```

---

###  `static int GetFractionCount()`

Returns the number of created Fraction objects.

---

## ⚙ Operator Overloading

The following operators are overloaded:

| Operator | Description              |
| -------- | ------------------------ |
| `+`      | Adds two fractions       |
| `-`      | Subtracts two fractions  |
| `*`      | Multiplies two fractions |
| `/`      | Divides two fractions    |
| `==`     | Checks equality          |
| `!=`     | Checks inequality        |
| `>`      | Greater than comparison  |
| `<`      | Less than comparison     |

---

## Arithmetic Logic

### Addition

```
a/b + c/d = (ad + bc) / bd
```

### Subtraction

```
a/b - c/d = (ad - bc) / bd
```

### Multiplication

```
a/b * c/d = (ac) / (bd)
```

### Division

```
a/b ÷ c/d = (a × d) / (b × c)
```

---

##  Comparison Logic

Fractions are compared using cross multiplication:

```
a/b < c/d  if  a×d < c×b
```

---

##  Example Usage

```csharp
Fraction f1 = new Fraction(5, 10);
Fraction f2 = new Fraction(70, 80);

Fraction sum = f1 + f2;
Fraction diff = f1 - f2;
Fraction product = f1 * f2;
Fraction division = f1 / f2;

if (f1 == f2)
{
    Console.WriteLine("Fractions are equal");
}

Console.WriteLine("Total Fractions Created: " + Fraction.GetFractionCount());
```

---

## 🛡 Error Handling

* Throws `ArgumentException` if denominator is zero.
* Throws `DivideByZeroException` when dividing by a fraction with numerator = 0.

---

##  Project Concepts Demonstrated

* Encapsulation
* Operator Overloading
* Static Members
* Exception Handling
* Mathematical Logic Implementation
* Clean Code Practices

---

##  What This Project Demonstrates

✔ Understanding of OOP in C#
✔ Proper use of static members
✔ Custom operator overloading
✔ Mathematical implementation of rational numbers
✔ Exception-safe coding

---

##  Conclusion

This project provides a fully functional Fraction Calculator that:

* Performs all arithmetic operations
* Compares fraction values correctly
* Simplifies automatically
* Tracks created objects
* Handles errors properly
