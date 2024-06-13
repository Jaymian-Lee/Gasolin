using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gasolin.models;

namespace Gasolin.models
{
    public static class DAL
    {
        static string connectionString = "Data Source=desktop-ir29ng7;Initial Catalog=Gasolin;Integrated Security=True;";

        // Vehicle methods
        public static void AddVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Vehicle (LicensePlate, Description, Brand, Type, ConstructionYear, PurchaseDate, InitialKm, SaleDate, Active, Fuel) VALUES (@LicensePlate, @Description, @Brand, @Type, @ConstructionYear, @PurchaseDate, @InitialKm, @SaleDate, @Active, @Fuel)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                command.Parameters.AddWithValue("@Description", vehicle.Description);
                command.Parameters.AddWithValue("@Brand", vehicle.Brand);
                command.Parameters.AddWithValue("@Type", vehicle.Type);
                command.Parameters.AddWithValue("@ConstructionYear", vehicle.ConstructionYear);
                command.Parameters.AddWithValue("@PurchaseDate", vehicle.PurchaseDate);
                command.Parameters.AddWithValue("@InitialKm", vehicle.InitialKm);
                command.Parameters.AddWithValue("@SaleDate", (object)vehicle.SaleDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@Active", vehicle.Active);
                command.Parameters.AddWithValue("@Fuel", vehicle.Fuel);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void UpdateVehicle(Vehicle vehicle)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Vehicle SET LicensePlate = @LicensePlate, Description = @Description, Brand = @Brand, Type = @Type, ConstructionYear = @ConstructionYear, PurchaseDate = @PurchaseDate, InitialKm = @InitialKm, SaleDate = @SaleDate, Active = @Active, Fuel = @Fuel WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", vehicle.Id);
                command.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                command.Parameters.AddWithValue("@Description", vehicle.Description);
                command.Parameters.AddWithValue("@Brand", vehicle.Brand);
                command.Parameters.AddWithValue("@Type", vehicle.Type);
                command.Parameters.AddWithValue("@ConstructionYear", vehicle.ConstructionYear);
                command.Parameters.AddWithValue("@PurchaseDate", vehicle.PurchaseDate);
                command.Parameters.AddWithValue("@InitialKm", vehicle.InitialKm);
                command.Parameters.AddWithValue("@SaleDate", (object)vehicle.SaleDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@Active", vehicle.Active);
                command.Parameters.AddWithValue("@Fuel", vehicle.Fuel);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void DeleteVehicle(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Vehicle WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Vehicle";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vehicle vehicle = new Vehicle
                            {
                                Id = (int)reader["Id"],
                                LicensePlate = reader["LicensePlate"].ToString(),
                                Description = reader["Description"].ToString(),
                                Brand = reader["Brand"].ToString(),
                                Type = reader["Type"].ToString(),
                                ConstructionYear = (int)reader["ConstructionYear"],
                                PurchaseDate = (DateTime)reader["PurchaseDate"],
                                InitialKm = (int)reader["InitialKm"],
                                SaleDate = reader["SaleDate"] as DateTime?,
                                Active = (int)reader["Active"],
                                Fuel = reader["Fuel"].ToString(),
                                Owners = reader["Owners"].ToString(),
                                Refills = reader["Refills"].ToString()
                            };
                            vehicles.Add(vehicle);
                        }
                    }
                    connection.Close();
                }
            }

            return vehicles;
        }

        // Person methods
        public static void AddPerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Person (GivenName, FamilyName, Birthdate, DriverLicenseDate) VALUES (@GivenName, @FamilyName, @Birthdate, @DriverLicenseDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GivenName", person.GivenName);
                command.Parameters.AddWithValue("@FamilyName", person.FamilyName);
                command.Parameters.AddWithValue("@Birthdate", person.Birthdate);
                command.Parameters.AddWithValue("@DriverLicenseDate", person.DriverLicenseDate);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static List<Person> GetAllPersons()
        {
            List<Person> people = new List<Person>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, GivenName, FamilyName, Birthdate, DriverLicenseDate FROM Person";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Person person = new Person(
                        (int)reader["Id"],
                        (string)reader["GivenName"],
                        (string)reader["FamilyName"],
                        (DateTime)reader["Birthdate"],
                        (DateTime)reader["DriverLicenseDate"]
                    );
                    people.Add(person);
                }
                connection.Close();
            }

            return people;
        }

        public static void UpdatePerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Person SET GivenName = @GivenName, FamilyName = @FamilyName, Birthdate = @Birthdate, DriverLicenseDate = @DriverLicenseDate WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@GivenName", person.GivenName);
                command.Parameters.AddWithValue("@FamilyName", person.FamilyName);
                command.Parameters.AddWithValue("@Birthdate", person.Birthdate);
                command.Parameters.AddWithValue("@DriverLicenseDate", person.DriverLicenseDate);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void DeletePerson(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Person WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
