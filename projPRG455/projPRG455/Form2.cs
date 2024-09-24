using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projPRG455
{
    public partial class Form2 : Form
    {
        public string SelectedAccommodationType { get; set; }
        string dataDirectory = AppDomain.CurrentDomain.BaseDirectory ?? ".";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projEmreBaser.mdf;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
            pictureBoxExit.Click += new EventHandler(Exit);
            pictureBoxMin.Click += new EventHandler(Minimize);
            pictureBoxBack.Click += new EventHandler(Back);
            buttonConfirm.Click += new EventHandler(Confirm);
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back(object sender, EventArgs e)
        {
            this.Close();
            Form form1 = new welcomePage();
            form1.Show();
        }


        private bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }

        // Function to generate a random 7-digit CustomerID
        private int GenerateBookingID()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }

        // Function to calculate the total cost based on the occupied days and cost per day
        private decimal CalculateTotalCost(DateTime startDate, DateTime endDate, decimal costPerDay)
        {
            TimeSpan totalDays = endDate - startDate;
            int occupiedDays = totalDays.Days;

            return occupiedDays * costPerDay;
        }

        // Function to validate the selected dates against the available dates
        private bool ValidateSelectedDates(DateTime startDate, DateTime endDate, DateTime availableFrom, DateTime availableUntil)
        {
            return startDate >= availableFrom && endDate <= availableUntil && startDate < endDate;
        }

        public int GetRentalID(string accommodationType)
        {
            int rentalID = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RentalID FROM VacationData WHERE AccommodationType = @AccommodationType";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationType", accommodationType);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        rentalID = Convert.ToInt32(result);
                    }
                }
            }
            return rentalID;
        }

        // Method to get DateAvailableFrom based on RentalID
        public DateTime GetAvailableFromDate(int rentalID)
        {
            DateTime availableFrom = DateTime.MinValue;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DateAvailableFrom FROM VacationData WHERE RentalID = @RentalID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalID", rentalID);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        availableFrom = Convert.ToDateTime(result);
                    }
                }
            }
            return availableFrom;
        }

        // Method to get DateAvailableUntil based on RentalID
        public DateTime GetAvailableUntilDate(int rentalID)
        {
            DateTime availableUntil = DateTime.MinValue;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DateAvailableUntil FROM VacationData WHERE RentalID = @RentalID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalID", rentalID);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        availableUntil = Convert.ToDateTime(result);
                    }
                }
            }
            return availableUntil;
        }

        // Method to get CostPerDay based on RentalID
        public decimal GetCostPerDay(int rentalID)
        {
            decimal costPerDay = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CostPerDay FROM VacationData WHERE RentalID = @RentalID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalID", rentalID);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        costPerDay = Convert.ToDecimal(result);
                    }
                }
            }
            return costPerDay;
        }




        private void Confirm(object sender, EventArgs e)
        {
            // Gather user input
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string telephoneNumber = textBoxTelephoneNumber.Text.Trim();
            string creditCardData = textBoxCreditCardData.Text.Trim();
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            // Validate inputs
            if (firstName.Length > 9 || lastName.Length > 9)
            {
                MessageBox.Show("Name must not exceed 9 characters.");
                return;
            }

            if (!IsNumeric(telephoneNumber) || telephoneNumber.Length != 10)
            {
                MessageBox.Show("Telephone number should contain 10 digits only.");
                return;
            }

            if (!IsNumeric(creditCardData) || creditCardData.Length != 16)
            {
                MessageBox.Show("Credit card data should contain 16 digits only.");
                return;
            }

            // Get RentalID (assuming you have it already)
            int rentalID = GetRentalID(SelectedAccommodationType); // Replace with the actual method to retrieve RentalID

            // Get AvailableFrom and AvailableUntil from VacationRental table
            DateTime availableFrom = GetAvailableFromDate(rentalID); // Replace with actual query
            DateTime availableUntil = GetAvailableUntilDate(rentalID); // Replace with actual query

            // Validate selected dates against available dates
            if (!ValidateSelectedDates(startDate, endDate, availableFrom, availableUntil))
            {
                MessageBox.Show("Selected dates are not within available dates.");
                return;
            }

            // Calculate total cost per day from the VacationRental table
            decimal costPerDay = GetCostPerDay(rentalID); // Replace with actual query

            // Calculate Total Cost
            decimal totalCost = CalculateTotalCost(startDate, endDate, costPerDay);

            // Generate a CustomerID
            int customerID = GenerateBookingID();

            // Insert into Customer table
            string insertCustomerQuery = "INSERT INTO Customer (CustomerID, FirstName, LastName, TelephoneNumber, CreditCardData) VALUES (@CustomerID, @FirstName, @LastName, @TelephoneNumber, @CreditCardData)";
            // Insert into Bookings table
            string insertBookingQuery = "INSERT INTO Bookings (BookingID, RentalID, CustomerID, StartDate, EndDate, TotalCost) VALUES (@BookingID, @RentalID, @CustomerID, @StartDate, @EndDate, @TotalCost)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into Customer table
                using (SqlCommand command = new SqlCommand(insertCustomerQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@TelephoneNumber", telephoneNumber);
                    command.Parameters.AddWithValue("@CreditCardData", creditCardData);

                    command.ExecuteNonQuery();
                }

                // Insert into Bookings table
                using (SqlCommand command = new SqlCommand(insertBookingQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookingID", GenerateBookingID()); // Replace with actual generation logic
                    command.Parameters.AddWithValue("@RentalID", rentalID);
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@TotalCost", totalCost);

                    command.ExecuteNonQuery();
                }
                this.Close();
                Form form3 = new Form3();
                form3.Show();
            }

            MessageBox.Show("Booking saved successfully.");
        }



    }
}
