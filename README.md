# Bits Bites

A C# (CSharp) Console App exercise project developed during my retraining as an IT Specialist in Application Development at Lutz + Grub Academy.

The program simulates placing an order at a fictional shop for different types of products — drinks, food, and internet tickets. It demonstrates the use of polymorphism, class hierarchies, and discount calculation logic.

### Features

- Products are grouped into three categories:
  - **Drinks**: Supports alcoholic beverages with "Happy Hour" discounts.
  - **Food**: Can be ordered in "normal" or "extra large" portions, with a surcharge for the latter.
  - **Internet Tickets**: Include ticket type, duration, and start time.
- If the customer owns a *Bits & Bites Card*, a 5% discount is applied to the total price.

### Structure

The code uses inheritance and polymorphism through an abstract `Posten` base class with derived classes like `Getraenk`, `Essen`, and `Ticket`. The final price is calculated dynamically depending on the item type and conditions like discounts or surcharges.

---

### How to Run

To run the Console App directly, launch  
`Bits & Bites.exe` located in  
`bin/Debug/net6.0`.

> **Note**: German language used in console output.

---

The code was written independently by me. The class only provided a general idea of what the project should do. 
