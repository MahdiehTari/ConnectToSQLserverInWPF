using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testsqlserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connectionstring = new SqlConnection("Data Source=.;Initial Catalog=Register;Integrated Security=True");
            connectionstring.Open();

            // 2
            // Create new DataAdapter
            SqlDataAdapter a = new SqlDataAdapter("SELECT ID as 'ردیف',Company as 'شرکت',OprUser as  'درخواست دهنده',RegDate as 'تاریخ ثبت',Services as 'سرویس',Cost as 'هزینه' FROM Register", connectionstring);


            DataTable t = new DataTable();
            a.Fill(t);
            show_list.ItemsSource = t.DefaultView;
            connectionstring.Close();
        }
    }

        
    
}
