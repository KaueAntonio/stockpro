namespace StockPro.Presentation.Forms.Customer
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            pnHeader = new Panel();
            lblTitleHeader = new Label();
            tbcCustomer = new TabControl();
            tbpCustomer = new TabPage();
            ptrInfo = new PictureBox();
            lblInfoEdit = new Label();
            lblBirthDate = new Label();
            mtxtBirthDate = new MaskedTextBox();
            mtxtCelNumber = new MaskedTextBox();
            mtxtTelNumber = new MaskedTextBox();
            mtxtCep = new MaskedTextBox();
            mtxtCpf = new MaskedTextBox();
            mtxtRg = new MaskedTextBox();
            lblUf = new Label();
            txtUf = new TextBox();
            txtAddressComplement = new TextBox();
            lblAddressComplement = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtDisctrict = new TextBox();
            lblDistrict = new Label();
            txtHouseNumber = new TextBox();
            lblHouseNumber = new Label();
            lblCep = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblCelNumber = new Label();
            lblTelNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblCpf = new Label();
            lblRg = new Label();
            txtName = new TextBox();
            lblName = new Label();
            tbpConsulting = new TabPage();
            dgvSearch = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbFilters = new ComboBox();
            lblFilters = new Label();
            btnConfirm = new Button();
            btnClose = new Button();
            pnHeader.SuspendLayout();
            tbcCustomer.SuspendLayout();
            tbpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrInfo).BeginInit();
            tbpConsulting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = SystemColors.Highlight;
            pnHeader.Controls.Add(lblTitleHeader);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(827, 58);
            pnHeader.TabIndex = 0;
            // 
            // lblTitleHeader
            // 
            lblTitleHeader.AutoSize = true;
            lblTitleHeader.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleHeader.ForeColor = Color.White;
            lblTitleHeader.Location = new Point(12, 9);
            lblTitleHeader.Name = "lblTitleHeader";
            lblTitleHeader.Size = new Size(91, 24);
            lblTitleHeader.TabIndex = 0;
            lblTitleHeader.Text = "Clientes";
            // 
            // tbcCustomer
            // 
            tbcCustomer.Controls.Add(tbpCustomer);
            tbcCustomer.Controls.Add(tbpConsulting);
            tbcCustomer.Location = new Point(12, 64);
            tbcCustomer.Name = "tbcCustomer";
            tbcCustomer.SelectedIndex = 0;
            tbcCustomer.Size = new Size(803, 318);
            tbcCustomer.TabIndex = 1;
            // 
            // tbpCustomer
            // 
            tbpCustomer.Controls.Add(ptrInfo);
            tbpCustomer.Controls.Add(lblInfoEdit);
            tbpCustomer.Controls.Add(lblBirthDate);
            tbpCustomer.Controls.Add(mtxtBirthDate);
            tbpCustomer.Controls.Add(mtxtCelNumber);
            tbpCustomer.Controls.Add(mtxtTelNumber);
            tbpCustomer.Controls.Add(mtxtCep);
            tbpCustomer.Controls.Add(mtxtCpf);
            tbpCustomer.Controls.Add(mtxtRg);
            tbpCustomer.Controls.Add(lblUf);
            tbpCustomer.Controls.Add(txtUf);
            tbpCustomer.Controls.Add(txtAddressComplement);
            tbpCustomer.Controls.Add(lblAddressComplement);
            tbpCustomer.Controls.Add(txtCity);
            tbpCustomer.Controls.Add(lblCity);
            tbpCustomer.Controls.Add(txtDisctrict);
            tbpCustomer.Controls.Add(lblDistrict);
            tbpCustomer.Controls.Add(txtHouseNumber);
            tbpCustomer.Controls.Add(lblHouseNumber);
            tbpCustomer.Controls.Add(lblCep);
            tbpCustomer.Controls.Add(txtAddress);
            tbpCustomer.Controls.Add(lblAddress);
            tbpCustomer.Controls.Add(lblCelNumber);
            tbpCustomer.Controls.Add(lblTelNumber);
            tbpCustomer.Controls.Add(txtEmail);
            tbpCustomer.Controls.Add(lblEmail);
            tbpCustomer.Controls.Add(lblCpf);
            tbpCustomer.Controls.Add(lblRg);
            tbpCustomer.Controls.Add(txtName);
            tbpCustomer.Controls.Add(lblName);
            tbpCustomer.Location = new Point(4, 24);
            tbpCustomer.Name = "tbpCustomer";
            tbpCustomer.Padding = new Padding(3);
            tbpCustomer.Size = new Size(795, 290);
            tbpCustomer.TabIndex = 0;
            tbpCustomer.Text = "Dados";
            tbpCustomer.UseVisualStyleBackColor = true;
            // 
            // ptrInfo
            // 
            ptrInfo.Image = (Image)resources.GetObject("ptrInfo.Image");
            ptrInfo.Location = new Point(11, 10);
            ptrInfo.Name = "ptrInfo";
            ptrInfo.Size = new Size(25, 25);
            ptrInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrInfo.TabIndex = 34;
            ptrInfo.TabStop = false;
            // 
            // lblInfoEdit
            // 
            lblInfoEdit.AutoSize = true;
            lblInfoEdit.Font = new Font("Segoe UI", 10F);
            lblInfoEdit.Location = new Point(42, 15);
            lblInfoEdit.Name = "lblInfoEdit";
            lblInfoEdit.Size = new Size(671, 19);
            lblInfoEdit.TabIndex = 33;
            lblInfoEdit.Text = "Para editar dados de um cliente basta inserir o cpf ou rg do mesmo para o sistema buscar automaticamente.";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(178, 106);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(117, 15);
            lblBirthDate.TabIndex = 32;
            lblBirthDate.Text = "Data de Nascimento:";
            // 
            // mtxtBirthDate
            // 
            mtxtBirthDate.Location = new Point(178, 124);
            mtxtBirthDate.Mask = "00/00/0000";
            mtxtBirthDate.Name = "mtxtBirthDate";
            mtxtBirthDate.Size = new Size(150, 23);
            mtxtBirthDate.TabIndex = 31;
            mtxtBirthDate.ValidatingType = typeof(DateTime);
            // 
            // mtxtCelNumber
            // 
            mtxtCelNumber.Location = new Point(178, 225);
            mtxtCelNumber.Mask = "(99) 00000-0000";
            mtxtCelNumber.Name = "mtxtCelNumber";
            mtxtCelNumber.Size = new Size(150, 23);
            mtxtCelNumber.TabIndex = 30;
            // 
            // mtxtTelNumber
            // 
            mtxtTelNumber.Location = new Point(22, 225);
            mtxtTelNumber.Mask = "(99) 0000-0000";
            mtxtTelNumber.Name = "mtxtTelNumber";
            mtxtTelNumber.Size = new Size(150, 23);
            mtxtTelNumber.TabIndex = 29;
            // 
            // mtxtCep
            // 
            mtxtCep.Location = new Point(374, 74);
            mtxtCep.Mask = "00000-999";
            mtxtCep.Name = "mtxtCep";
            mtxtCep.Size = new Size(150, 23);
            mtxtCep.TabIndex = 28;
            // 
            // mtxtCpf
            // 
            mtxtCpf.Location = new Point(178, 176);
            mtxtCpf.Mask = "000.000.000-00";
            mtxtCpf.Name = "mtxtCpf";
            mtxtCpf.Size = new Size(150, 23);
            mtxtCpf.TabIndex = 27;
            // 
            // mtxtRg
            // 
            mtxtRg.Location = new Point(22, 176);
            mtxtRg.Mask = "00.000.000-0";
            mtxtRg.Name = "mtxtRg";
            mtxtRg.Size = new Size(150, 23);
            mtxtRg.TabIndex = 26;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(642, 158);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(24, 15);
            lblUf.TabIndex = 25;
            lblUf.Text = "UF:";
            // 
            // txtUf
            // 
            txtUf.Location = new Point(642, 176);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(38, 23);
            txtUf.TabIndex = 24;
            // 
            // txtAddressComplement
            // 
            txtAddressComplement.Location = new Point(374, 225);
            txtAddressComplement.Name = "txtAddressComplement";
            txtAddressComplement.Size = new Size(306, 23);
            txtAddressComplement.TabIndex = 23;
            // 
            // lblAddressComplement
            // 
            lblAddressComplement.AutoSize = true;
            lblAddressComplement.Location = new Point(374, 207);
            lblAddressComplement.Name = "lblAddressComplement";
            lblAddressComplement.Size = new Size(87, 15);
            lblAddressComplement.TabIndex = 22;
            lblAddressComplement.Text = "Complemento:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(508, 176);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(128, 23);
            txtCity.TabIndex = 21;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(508, 158);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(47, 15);
            lblCity.TabIndex = 20;
            lblCity.Text = "Cidade:";
            // 
            // txtDisctrict
            // 
            txtDisctrict.Location = new Point(374, 176);
            txtDisctrict.Name = "txtDisctrict";
            txtDisctrict.Size = new Size(128, 23);
            txtDisctrict.TabIndex = 19;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(374, 158);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(41, 15);
            lblDistrict.TabIndex = 18;
            lblDistrict.Text = "Bairro:";
            // 
            // txtHouseNumber
            // 
            txtHouseNumber.Location = new Point(530, 74);
            txtHouseNumber.Name = "txtHouseNumber";
            txtHouseNumber.Size = new Size(150, 23);
            txtHouseNumber.TabIndex = 17;
            // 
            // lblHouseNumber
            // 
            lblHouseNumber.AutoSize = true;
            lblHouseNumber.Location = new Point(530, 56);
            lblHouseNumber.Name = "lblHouseNumber";
            lblHouseNumber.Size = new Size(54, 15);
            lblHouseNumber.TabIndex = 16;
            lblHouseNumber.Text = "Número:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(374, 56);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(31, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(374, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(306, 23);
            txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(374, 106);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(59, 15);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Endereço:";
            // 
            // lblCelNumber
            // 
            lblCelNumber.AutoSize = true;
            lblCelNumber.Location = new Point(178, 207);
            lblCelNumber.Name = "lblCelNumber";
            lblCelNumber.Size = new Size(94, 15);
            lblCelNumber.TabIndex = 10;
            lblCelNumber.Text = "Telefone Celular:";
            // 
            // lblTelNumber
            // 
            lblTelNumber.AutoSize = true;
            lblTelNumber.Location = new Point(22, 207);
            lblTelNumber.Name = "lblTelNumber";
            lblTelNumber.Size = new Size(79, 15);
            lblTelNumber.TabIndex = 8;
            lblTelNumber.Text = "Telefone Fixo:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(178, 158);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(31, 15);
            lblCpf.TabIndex = 3;
            lblCpf.Text = "CPF:";
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Location = new Point(22, 158);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(25, 15);
            lblRg.TabIndex = 2;
            lblRg.Text = "RG:";
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(306, 23);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nome Completo:";
            // 
            // tbpConsulting
            // 
            tbpConsulting.Controls.Add(dgvSearch);
            tbpConsulting.Controls.Add(btnSearch);
            tbpConsulting.Controls.Add(txtSearch);
            tbpConsulting.Controls.Add(cbFilters);
            tbpConsulting.Controls.Add(lblFilters);
            tbpConsulting.Location = new Point(4, 24);
            tbpConsulting.Name = "tbpConsulting";
            tbpConsulting.Padding = new Padding(3);
            tbpConsulting.Size = new Size(795, 290);
            tbpConsulting.TabIndex = 1;
            tbpConsulting.Text = "Consulta";
            tbpConsulting.UseVisualStyleBackColor = true;
            // 
            // dgvSearch
            // 
            dgvSearch.AllowUserToAddRows = false;
            dgvSearch.AllowUserToDeleteRows = false;
            dgvSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearch.Location = new Point(6, 85);
            dgvSearch.Name = "dgvSearch";
            dgvSearch.ReadOnly = true;
            dgvSearch.Size = new Size(783, 199);
            dgvSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Location = new Point(456, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += GetCustomerByFilter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(132, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(306, 23);
            txtSearch.TabIndex = 4;
            // 
            // cbFilters
            // 
            cbFilters.FormattingEnabled = true;
            cbFilters.Location = new Point(6, 33);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(120, 23);
            cbFilters.TabIndex = 3;
            // 
            // lblFilters
            // 
            lblFilters.AutoSize = true;
            lblFilters.Location = new Point(6, 15);
            lblFilters.Name = "lblFilters";
            lblFilters.Size = new Size(87, 15);
            lblFilters.TabIndex = 2;
            lblFilters.Text = "Filtro de Busca:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.ButtonFace;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Location = new Point(712, 393);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(103, 40);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += Create;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Location = new Point(593, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Cancelar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += Close;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 445);
            Controls.Add(btnClose);
            Controls.Add(btnConfirm);
            Controls.Add(tbcCustomer);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCustomer";
            Text = "Clientes";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            tbcCustomer.ResumeLayout(false);
            tbpCustomer.ResumeLayout(false);
            tbpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptrInfo).EndInit();
            tbpConsulting.ResumeLayout(false);
            tbpConsulting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lblTitleHeader;
        private TabControl tbcCustomer;
        private TabPage tbpCustomer;
        private TabPage tbpConsulting;
        private TextBox txtName;
        private Label lblName;
        private Label lblRg;
        private Label lblCelNumber;
        private Label lblTelNumber;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCpf;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblCep;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtDisctrict;
        private Label lblDistrict;
        private TextBox txtHouseNumber;
        private Label lblHouseNumber;
        private TextBox txtAddressComplement;
        private Label lblAddressComplement;
        private Label lblUf;
        private TextBox txtUf;
        private MaskedTextBox mtxtCelNumber;
        private MaskedTextBox mtxtTelNumber;
        private MaskedTextBox mtxtCep;
        private MaskedTextBox mtxtCpf;
        private MaskedTextBox mtxtRg;
        private Label lblBirthDate;
        private MaskedTextBox mtxtBirthDate;
        private PictureBox ptrInfo;
        private Label lblInfoEdit;
        private Button btnConfirm;
        private Button btnClose;
        private ComboBox cbFilters;
        private Label lblFilters;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvSearch;
    }
}