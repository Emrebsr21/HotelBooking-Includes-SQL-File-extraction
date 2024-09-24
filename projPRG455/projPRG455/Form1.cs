using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projPRG455
{
    public partial class welcomePage : Form
    {
        string dataDirectory = AppDomain.CurrentDomain.BaseDirectory ?? ".";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projEmreBaser.mdf;Integrated Security=True;";
        private string selectedAccommodationType = string.Empty;


        public welcomePage()
        {
            InitializeComponent();
            pictureBoxExit.Click += new EventHandler(CloseApp);
            pictureBoxMin.Click += new EventHandler(MinimizeApp);
            buttonSearch.Click += new EventHandler(ShowDetails);
            buttonProceedToCheckout.Click += new EventHandler(Proceed);
            LoadAccommodationTypes();
            panelSearch.Visible = false;
        }

        private void CloseApp(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeApp(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void welcomePage_Load(object sender, EventArgs e)
        {
            this.vacationDataTableAdapter1.Fill(this.projEmreBaserDataSet1.VacationData);
            LoadAccommodationTypes();
        }

        private void LoadAccommodationTypes()
        {
            listBoxAccomodationType.DataSource = null; // Clear the data binding
            listBoxAccomodationType.Items.Clear();     // Clear existing items

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT AccommodationType FROM VacationData";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        listBoxAccomodationType.Items.Add(reader["AccommodationType"].ToString());
                    }
                    reader.Close();
                }
            }


        }

        private void listBoxAccomodationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccommodationType = listBoxAccomodationType.SelectedItem.ToString();
        }

        private void ShowDetails(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedAccommodationType))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM VacationData WHERE AccommodationType = @AccommodationType";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccommodationType", selectedAccommodationType);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];

                            // Fill panel properties with corresponding data
                            labelAccomodationType.Text = $"Accommodation: {row["AccommodationType"]}";
                            labelLocation.Text = $"Location: {row["Location"]}";
                            labelDateAvailableFrom.Text = $"Available from: {((DateTime)row["DateAvailableFrom"]).ToString("yyyy-MM-dd")}";
                            labelDateAvailableTo.Text = $"Available until: {((DateTime)row["DateAvailableUntil"]).ToString("yyyy-MM-dd")}";
                            labelCostPerNight.Text = $"Cost per day: {Convert.ToDecimal(row["CostPerDay"]):C}";

                            // Load corresponding image based on accommodation type
                            pictureBoxAccomodationType.ImageLocation = GetImagePath(selectedAccommodationType);

                            panelSearch.Visible = true; // Show panel to display details

                        }
                        else
                        {
                            MessageBox.Show("Accommodation details not found.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an accommodation type.");
            }

        }
        private string GetImagePath(string accommodationType)
        {
            if (accommodationType == "Luxury Hotel")
                 return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\luxeryhotel.jpg";
            else if (accommodationType == "Beach House")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\beach house.jpg";
            else if (accommodationType == "Ski Resort Cabin")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\ski-log-cabin.jpg";
            else if (accommodationType == "Mountain Lodge")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Mountainlosge.jpg";
            else if (accommodationType == "Lakefront Cottage")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Lakefront Cottage.jpg";
            else if (accommodationType == "Treehouse Retreat")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Treehouse Retreat.jpg";
            else if (accommodationType == "Historic Inn")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Historic Inn.jpg";
            else if (accommodationType == "Desert Oasis")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Desert Oasis.jpg";
            else if (accommodationType == "Turkish Villa")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Turkish Villa.jpg";
            else if (accommodationType == "Cabin in the Woods")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Cabin in the Woods.jpg";
            else if (accommodationType == "City Loft")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\City Loft.jpg";
            else if (accommodationType == "Ranch Retreat")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Ranch Retreat.jpg";
            else if (accommodationType == "Countryside Farmhouse")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Countryside Farmhouse.jpg";
            else if (accommodationType == "Cozy Cabin")
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\Cozy Cabin.jpg";
            else
                return "C:\\Users\\emreb_knxeiac\\OneDrive\\Masaüstü\\prgPics\\default.jpg";
        }

        private void Proceed(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.SelectedAccommodationType = selectedAccommodationType;
            Form2.Show();
        }
    }
}
