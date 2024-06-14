# Gasolin Management System

Gasolin Management System is a Windows Forms application developed in C# that allows you to keep track of refueling and manage vehicles and persons. The application uses SQL Server 2019 for the database.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Database Schema](#database-schema)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/Jaymian-Lee/Gasolin.git
    ```

2. **Open the project**:
    Open the project in Visual Studio.

3. **Configure the database**:
    - Ensure that SQL Server 2019 is installed.
    - Execute the SQL script `database.sql` to create the database and tables.

4. **Update the connection string**:
    - Open `DAL.cs` and ensure the `connectionString` variable points to your SQL Server instance.

## Usage

1. **Start the application**:
    Press `F5` in Visual Studio to build and start the application.

2. **Add vehicles and persons**:
    Use the application to add vehicles and persons.

3. **Add refuel records**:
    Register refuel records by selecting a vehicle and person.

## Database Schema

The database schema consists of the following tables:

- **Person**
    - Id (int, Primary Key)
    - GivenName (varchar(50))
    - FamilyName (varchar(50))
    - Birthdate (datetime)
    - DriverLicenseDate (datetime)

- **Vehicle**
    - Id (int, Primary Key)
    - Description (varchar(50))
    - LicensePlate (varchar(50))
    - Brand (varchar(50))
    - Type (varchar(50))
    - ConstructionYear (int)
    - PurchaseDate (datetime)
    - InitialKm (int)
    - SaleDate (datetime)
    - Active (int)
    - Fuel (varchar(50))

- **Refuel**
    - Id (int, Primary Key)
    - TimeStamp (datetime)
    - Liters (int)
    - CurrentKm (int)
    - AmountEuro (float)
    - RefueledVehicle (int, Foreign Key references Vehicle.Id)
    - PersonThatRefueled (int, Foreign Key references Person.Id)

## Project Structure

- **Gasolin**
    - **forms**
        - AddRefueling.cs
        - ChangeRefueling.cs
        - RefuelingForm.cs
        - PersonForm.cs
        - CarsForm.cs
        - Landing.cs
    - **models**
        - DAL.cs
        - Person.cs
        - Refuel.cs
        - Vehicle.cs
    - Program.cs

## Contributing

Contributions to this project are welcome. Follow these steps to contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/feature-name`).
3. Commit your changes (`git commit -am 'Add a feature'`).
4. Push to the branch (`git push origin feature/feature-name`).
5. Open a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
