# Order Filtering System – C# Console Application

## Project Overview

This project is a C# Console Application that demonstrates how to dynamically filter a collection of orders using:

* Delegates (Predicate<T>)
* Lambda Expressions
* Generic Methods
* Enum for structured menu handling
* Date validation using DateTime.TryParseExact

The system allows users to filter orders based on multiple criteria through an interactive console menu.

---

## Concepts Applied

This project focuses on practicing:

* Object-Oriented Programming (OOP)
* Delegates and Predicate
* Generic Methods
* IEnumerable and yield return
* Enum usage for clean menu structure
* Input validation and error handling
* Case-insensitive string comparison

---

## Project Structure

### Order Class

Represents the order entity with the following properties:

* Id
* CustomerName
* TotalPrice
* Date
* IsDelivered

The class also overrides ToString() to control how order details are displayed in the console.

---

### FilterOption Enum

The Enum is used to manage menu choices in a structured and readable way instead of relying on raw numeric values.

FilterOption includes:

* Exit
* FilterByCustomerName
* FilterByDeliveryStatus
* FilterByPriceGreaterThan1000
* FilterBeforeDate
* FilterAfterDate
* ShowAll

---

### Generic Filter Method

The core logic of the system is implemented using a reusable generic method:

static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> fn)

This method:

* Accepts any collection (generic type T)
* Accepts a delegate (Predicate<T>) that represents the filtering condition
* Iterates over each item
* Returns only the elements that satisfy the condition
* Uses yield return to enable lazy execution

This makes the filtering logic flexible and reusable across different data types.

---

## Features

The application allows the user to:

1. Filter by Customer Name (case-insensitive)
2. Filter by Delivery Status (Delivered or Not Delivered)
3. Filter orders with Total Price greater than 1000
4. Filter orders before a specific date
5. Filter orders after a specific date
6. Display all orders
7. Exit the program

---

## How It Works

1. The program initializes a List<Order> with sample data.
2. A menu is displayed using an Enum-based selection system.
3. The user selects an option.
4. Based on the selection, a delegate (lambda expression) is passed to the Filter method.
5. The filtered results are printed to the console.

---

## Technical Highlights

* Clean separation of responsibilities (menu, filtering, printing, validation)
* Safe parsing using Enum.TryParse
* Date validation using DateTime.TryParseExact
* Delegate-based dynamic behavior
* Reusable generic filtering logic

---

## Technologies Used

* C#
* .NET Console Application
* Generics
* Delegates
* Lambda Expressions
* Basic LINQ (Any)
