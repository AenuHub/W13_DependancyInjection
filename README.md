## W13_DependancyInjection
This project demonstrates the principles of Dependency Injection in C#. 
The main goal is to decouple the dependencies between classes and provide a flexible architecture for 
improved maintainability and testability.

### Project Structure

The project is structured as follows:
### Interfaces:

#### 1. `ITeacher`
Defines the base interface for the `Teacher` class with:
- `string FirstName { get; set; }`
- `string LastName { get; set; }`
- `string GetInfo();`

### Classes:

#### 1. `Teacher`
Represents a teacher with the following properties:
- `string FirstName { get; set; }`
- `string LastName { get; set; }`
- `string GetInfo();` -> Returns a formatted string containing the teacher's full name.

#### 2. `ClassRoom`
Represents a classroom that depends on a `Teacher` instance.
- `ITeacher Teacher { get; set; }`
- `string GetTeacherInfo();` -> Returns a formatted string containing the classroom's teacher's full name.

### Features

1. **Constructor Injection**
    - The `ClassRoom` class accepts an instance of the `Teacher` class (or any class implementing `ITeacher`) 
as a constructor parameter.

2. **Encapsulation and Decoupling**
    - Encapsulation of the teacher-related functionality within the `Teacher` class.
    - Decoupling of the `ClassRoom` and `Teacher` classes using the `ITeacher` interface.

### Learning Objectives

- Understand the concept of Dependency Injection.
- Implement Constructor Injection.
- Use interfaces to achieve flexibility and reduce coupling.

### Notes

Dependency Injection is a design pattern that allows a class to receive its dependencies from an external 
source rather than creating them internally. This approach improves the code's scalability, testability, and reusability.

