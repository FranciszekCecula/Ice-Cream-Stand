# Ice Cream Factory - Design Pattern Simulation 

## Project Overview
This project is a C# simulation of an ice cream stand that utilizes the **Factory Method design pattern**[cite: 4, 62]. It demonstrates how to decouple object creation from the main logic, allowing for a flexible production system with multiple product variations.

## Features
* **Product Hierarchy:** Implements a base abstract `IceCream` class with four specialized types: Creamy, Fruity, Sorbet, and Italian ice cream.
* **Dynamic Factory:** A `IceCreamFactory` class that manages 7 different production modes (one for each day of the week), ensuring a unique "Daily Special" without repetition.
* **Polymorphic Logic:**
    * **Resource Management:** Handles specific attributes like cones, various frostings, and chocolate sprinkles based on the ice cream type.
    * **Decoupled Salesman:** A `Salesman` class that interacts only with the factory and the abstract product, following the principle of dependency inversion.
* **Weekly Simulation:** A console-based simulation of a full week of sales, updating production modes daily.

## Core Concepts
* **Factory Method Pattern:** Encapsulating object creation to keep the code scalable and maintainable.
* **Inheritance & Encapsulation:** Proper use of access modifiers (`protected`, `private`) and base constructors.
* **String Formatting:** Overriding `ToString()` for detailed, user-friendly console output.
* **SOLID:** Project structure follows SOLID rules.
## How to Run
1. Ensure you have **.NET SDK** installed.
2. Navigate to the project folder and run:
   ```bash
   dotnet run