using StockPro.Application.V1.Customer.Interfaces.Services;
using StockPro.Application.V1.Customer.Models.Input;

namespace StockPro.Presentation.Forms.Customer
{
    public partial class FrmCustomer : Form
    {
        private readonly ICustomerService _customerService;

        public FrmCustomer(ICustomerService customerService)
        {
            _customerService = customerService;

            InitializeComponent();
        }

        private async void Create(object sender, EventArgs e)
        {
            await _customerService.Create(new InCustomer
            {
                Address = txtAddress.Text,
                CelNumber = mtxtCelNumber.Text,
                TelNumber = mtxtTelNumber.Text,
                City = txtCity.Text,
                Complement = txtAddressComplement.Text,
                Cpf = mtxtCpf.Text,
                Email = txtEmail.Text,
                HouseNumber = txtHouseNumber.Text,
                Name = txtName.Text,
                Rg = mtxtRg.Text,
                Uf = txtUf.Text
            });
        }

        private async void GetCustomerByFilter(object sender, EventArgs e)
        {
            var result = await _customerService.GetByFilter(cbFilters.Text ,txtSearch.Text);

            dgvSearch.DataSource = result;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
