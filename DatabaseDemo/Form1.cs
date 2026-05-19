using MySqlConnector;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Xml.Linq;
namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection con = connect();
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string SQL = "SELECT ISBN FROM Books"; // write your SQL query to get the ISBNs from the database
            cmd.CommandText = SQL;
            MySqlDataReader reader = cmd.ExecuteReader();// select which type of query to execute (Scalar, Reader, NonQuery)
            while (reader.Read())
            {
                string ISBN = reader.GetString("ISBN");
                cboISBN.Items.Add(ISBN);
                // add each read item to your combo box
            }
            con.Close();
        }

        private void cboISBN_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection con = connect();
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            string SQL = "SELECT BookTitle, Price, Type, FirstName, LastName FROM Books, Authors WHERE ISBN = @ISBN AND Books.AuthorID = Authors.AuthorID";
            cmd.CommandText = SQL;
            string ISBN = cboISBN.Text;
            // add the parameter
            // To use parameters in the SQL substitute the parameter with @identifier.
            //WHERE name = @name
            //After the command text has been assigned tell C# to replace the parameter with a variable/value
            //cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.CommandText = SQL;
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string title = reader.GetString("BookTitle");//
                int price = reader.GetInt32("Price");
                string type = reader.GetString("Type");//
                txtTitle.Text = title;
                txtPrice.Text = price.ToString("£0.00");
                txtType.Text = type;
                txtAuthor.Text = reader.GetString("FirstName") + " " + reader.GetString("LastName");
            }
            con.Close();
        }
        private MySqlConnection connect()
        {
            MySqlConnection con = new MySqlConnection("server=192.168.35.129;user=astone;password=letmein;database=astone_books"); // fill in your details
            return con;

        }
    }
}
