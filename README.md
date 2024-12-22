# Technologies Used
* Language: C#
* Framework: ASP.NET Core MVC
* Data Storage: JSON file (data.json)
* Design Patterns: Dependency Injection, Decorator Pattern
* Frontend: HTML and Razor Views
* Asynchronous Programming: Async/Await for non-blocking I/O operations

# Technical Features Implemented:
1. [10 points] Dependency Injection:
* IDataService is injected into the controller to handle data operations.

2. [10 points] Single Responsibility Principle (SRP):
* The application is divided into separate classes, each with a clear responsibility:
- JsonDataService handles data operations.
- LoggingDataService provides logging functionality.
- ItemsController handles user requests.

3. [10 points] JSON Handling:
* The application reads, writes, and deletes data to/from a data.json file, providing persistent storage for the shopping list.

4. [10 points] Asynchronous Programming:
* Data operations are implemented using async/await to perform non-blocking I/O operations.

5. [10 points] Interface Usage:
* IDataService defines operations for data retrieval and storage, ensuring the separation of concerns.

6. [10 points] Decorator Pattern:
* LoggingDataService wraps JsonDataService to add logging functionality without altering the core data handling logic.

7. [10 points] Inheritance:
* BaseEntity and Item demonstrate a parent-child relationship, with Item inheriting from BaseEntity.

8. [10 points] Multiple Web Pages:
* The application includes multiple pages:
- Home Page: Provides a welcome message and navigation links.
- Shopping List Page: Allows users to add, view, and delete items.
