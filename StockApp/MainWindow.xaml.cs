using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
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
using StockApp.ProductManagerService;

namespace StockApp
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

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductManagerServiceClient client = null;

            try
            {
                client = new ProductManagerServiceClient();
                client.Open();
                if (!decimal.TryParse(txtPrice.Text, out var price))
                {
                    //show error
                    MessageBox.Show("Invalid price! Only numbers accepted");
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out var quantity))
                {
                    //show error
                    MessageBox.Show("Invalid quantity! Only numbers accepted");
                    return;
                }

                client.AddProduct(
                    txtName.Text,
                    txtDescription.Text,
                    price,
                    quantity
                );
                MessageBox.Show("Success");
            }
            catch (FaultException<ArgumentException> exception)
            {
                MessageBox.Show(exception.Message ?? "Something went wrong");
            }
            catch (Exception exception)
            {
                MessageBox.Show("TESTES");
            }
            finally
            {
                client?.Close();
            }
        }

        private void btnClearFields_Click(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            //Obtem produtos do WCF
            ProductManagerServiceClient client = null;

            try
            {
                client = new ProductManagerServiceClient();
                client.Open();

                var products = client.GetAllProducts();
                listProducts.Items.Clear();
                foreach (var product in products)
                {
                    listProducts.Items
                        .Add($"{product.Name} - R${product.Price} - {product.Quantity}");
                }
            }
            finally
            {
                client?.Close();
            }
        }
    }
}