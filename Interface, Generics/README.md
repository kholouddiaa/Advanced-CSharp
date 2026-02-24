# Day 4 Advanced C# Tasks

Interface, Generics, and Generic Stack

## Overview

This repository contains solutions for **Day3 Advanced C#** tasks, covering:

* Basic interface implementation using `IShape`
* Real-world interface-based payment system demonstrating polymorphism
* Generic class `Calculator<T>` (adding integers and doubles)
* Generic stack implementation `MyStack<T>` using an array with overflow protection

---

## Tasks Implemented

### Task 1: Basic Interface Implementation

**Goal:** Create an interface `IShape` and implement it using two classes.

#### Requirements

* Create interface `IShape` with:

  * `void Area()`
  * `float Perimeter()`
* Create:

  * `Circle` (with `Radius`)
  * `Rectangle` (with `Width` and `Height`)
* Both classes must implement `IShape`

#### Notes

* `Area()` prints the calculated area.
* `Perimeter()` returns the calculated perimeter (and may optionally print it in the implementation).

---

### Task 2: Real-World Application – Payment System

**Goal:** Design a payment system using interfaces and demonstrate polymorphism.

#### Requirements

* Create interface `IPaymentGateway` with:

  * `void ProcessPayment(double amount);`
* Implement it in:

  * `CreditCardPayment`

    * prints: `Processing credit card payment of [amount]...`
  * `PayPalPayment`

    * prints: `Processing PayPal payment of [amount]...`
* In `Main()`, demonstrate polymorphism using:

  * `ProcessTransaction(IPaymentGateway payment, double amount)`

#### Key Concept

* The transaction method depends on the **interface**, not the concrete class.
* Switching from credit card to PayPal requires no changes in `ProcessTransaction`.

---

### Task 3: Generic Constraint Example

**Goal:** Create a generic calculator that supports adding numeric types.

#### Requirements

* Create a generic class `Calculator<T>` with method:

  * `T Add(T a, T b);`
* Demonstrate adding:

  * integers
  * doubles

#### Notes

* If you used `static Add` then it should be called using the type name:

  * `Calculator<int>.Add(…)`
* If you used instance method `Add`, call it through an object:

  * `calc.Add(…)`

---

### Task 4: Implement Generic Stack Using Array

**Goal:** Implement a generic stack using a private array.

#### Requirements

* Create `MyStack<T>`
* Use private array `T[] items`
* Implement:

  * `void Push(T item)`
  * `T Pop()`
  * `bool IsEmpty()`
  * `void Display()`
* Prevent stack overflow when capacity is exceeded.
* Test using:

  * `int`
  * `string`

#### Key Concepts

* Stack follows **LIFO** (Last In First Out).
* Overflow protection prevents adding items when the stack is full.
* Underflow protection prevents popping from an empty stack.

---

## Project Structure (Suggested)

```text
Day3-AdvancedCSharp/
│
├── Task1_Shapes/
│   ├── IShape.cs
│   ├── Circle.cs
│   ├── Rectangle.cs
│   └── Program.cs
│
├── Task2_PaymentSystem/
│   ├── IPaymentGateway.cs
│   ├── CreditCardPayment.cs
│   ├── PayPalPayment.cs
│   └── Program.cs
│
├── Task3_GenericCalculator/
│   ├── Calculator.cs
│   └── Program.cs
│
├── Task4_GenericStack/
│   ├── MyStack.cs
│   └── Program.cs
│
└── README.md
```

If you implemented everything in a single project, the repo may contain fewer files (e.g., only `Program.cs` plus related classes).

---

## How to Run

1. Open the solution/project in Visual Studio.
2. Set the startup project (if multiple projects exist).
3. Run the program:

   * `Ctrl + F5` (Run without debugging)

---

## Example Output (Typical)

* Shapes: prints area and perimeter results
* Payments: prints processing messages for selected gateway
* Calculator: prints sum of integers and doubles
* Stack: prints stack content, shows overflow behavior, and pop results

---

## Learning Outcomes

By completing these tasks, you practice:

* Interface-based design
* Polymorphism and loose coupling
* Generic programming with type safety
* Implementing data structures using generics (stack)
* Defensive programming (overflow/underflow handling)

---
