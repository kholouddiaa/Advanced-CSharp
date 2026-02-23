# Order Management System

Using Struct and Enum in C#

## Project Overview

This project is a simple Order Management System implemented in C#.
It demonstrates the use of:

* Enum with a custom base type
* Struct as a value type
* Enum.GetNames()
* Enum.TryParse()
* Value equality comparison
* Console-based interaction

The system simulates a restaurant order workflow where each order has a status that can be updated by the user.

---

## Concepts Applied

* Enum as a strongly typed set of constants
* Enum base type (`byte`)
* Struct as a value type
* Value equality using `Equals()`
* Parsing string input into enum using `Enum.TryParse()`
* Retrieving enum names using `Enum.GetNames()`

---

## Enum Definition

```csharp
enum OrderStatus : byte
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}
```

### Why use `: byte`?

By default, enums use `int` as the underlying type (4 bytes).
In this project, `byte` is used to reduce memory usage since the number of status values is small (0–255 range is sufficient).

---

## Struct Definition

```csharp
struct Order
{
    public int OrderId;
    public string CustomerName;
    public double TotalPrice;
    public OrderStatus Status;

    public Order(int id, string name, double price, OrderStatus status)
    {
        OrderId = id;
        CustomerName = name;
        TotalPrice = price;
        Status = status;
    }

    public void Display()
    {
        Console.WriteLine($"OrderId: {OrderId}");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Total Price: {TotalPrice}");
        Console.WriteLine($"Status: {Status}");
    }
}
```

### Why use Struct?

`Order` is implemented as a struct to demonstrate value-type behavior in C#.
Structs are copied by value, not by reference.

---

## Features

### 1. Creating Orders

Two orders are created using the parameterized constructor.

### 2. Displaying Orders

Each order has a `Display()` method that prints its details.

### 3. Listing All Order Statuses

```csharp
foreach (string name in Enum.GetNames(typeof(OrderStatus)))
{
    Console.WriteLine(name);
}
```

This displays all available enum values.

### 4. Updating Order Status from User Input

```csharp
if (Enum.TryParse(order, true, out OrderStatus newStatus))
{
    order1.Status = newStatus;
}
```

* Converts user input (string) to enum
* Ignores case sensitivity
* Prevents invalid values

### 5. Comparing Orders

```csharp
Console.WriteLine(order1.Equals(order2));
```

Since `Order` is a struct, `Equals()` performs value comparison.

---

## Example Output

```
OrderId: 1
Customer: abc
Total Price: 55.22
Status: Pending

OrderId: 2
Customer: abjkkkc
Total Price: 100.225
Status: Processing

All Order Statuses:
Pending
Processing
Shipped
Delivered
Cancelled
```

---

## Learning Outcomes

After completing this project, you understand:

* How enums improve readability and safety over integers
* How to define and use enums with custom base types
* The difference between value types and reference types
* How struct behaves differently from class
* How to safely parse user input into an enum
* How value equality works with structs

---

## Possible Improvements

* Add a menu-based interactive system
* Store multiple orders in a `List<Order>`
* Add update and delete functionality
* Add input validation for price
* Save orders to a file
* Implement comparison operators for orders
