namespace Assignment3___Mortgage_Calculator___Abbott
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.txtHomePrice = new System.Windows.Forms.TextBox();
            this.lblHomePrice = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtLoanTermInterest = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblYearlyPropertyTax = new System.Windows.Forms.Label();
            this.txtPropertyTax = new System.Windows.Forms.TextBox();
            this.lblYearlyHomeInsurance = new System.Windows.Forms.Label();
            this.txtHomeInsurance = new System.Windows.Forms.TextBox();
            this.lblHOA = new System.Windows.Forms.Label();
            this.txtHOA = new System.Windows.Forms.TextBox();
            this.lblPMI = new System.Windows.Forms.Label();
            this.txtPMI = new System.Windows.Forms.TextBox();
            this.lblMonthlyCost = new System.Windows.Forms.Label();
            this.lblToLoan = new System.Windows.Forms.Label();
            this.lblToPropertyTax = new System.Windows.Forms.Label();
            this.lblToHomeInsurance = new System.Windows.Forms.Label();
            this.gbOoptional = new System.Windows.Forms.GroupBox();
            this.lblHomeInsuranceAmount = new System.Windows.Forms.Label();
            this.lblPropertyTaxAmount = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblTotalInterestPaidAmount = new System.Windows.Forms.Label();
            this.lblTotalPaidAmount = new System.Windows.Forms.Label();
            this.lblTotalInterestPaid = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.paymentNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAmortization = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.errorProviderHomePrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHomePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHomePrice
            // 
            this.txtHomePrice.Location = new System.Drawing.Point(74, 66);
            this.txtHomePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHomePrice.Name = "txtHomePrice";
            this.txtHomePrice.Size = new System.Drawing.Size(475, 26);
            this.txtHomePrice.TabIndex = 1;
            this.txtHomePrice.Text = "100000";
            this.txtHomePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtHomePrice_Validating);
            this.txtHomePrice.Validated += new System.EventHandler(this.txtHomePrice_Validated);
            // 
            // lblHomePrice
            // 
            this.lblHomePrice.AutoSize = true;
            this.lblHomePrice.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePrice.Location = new System.Drawing.Point(68, 31);
            this.lblHomePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomePrice.Name = "lblHomePrice";
            this.lblHomePrice.Size = new System.Drawing.Size(137, 31);
            this.lblHomePrice.TabIndex = 1;
            this.lblHomePrice.Text = "Home Price";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPayment.Location = new System.Drawing.Point(68, 123);
            this.lblDownPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(176, 31);
            this.lblDownPayment.TabIndex = 3;
            this.lblDownPayment.Text = "Down Payment";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(74, 158);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(475, 26);
            this.txtDownPayment.TabIndex = 2;
            this.txtDownPayment.Text = "0";
            this.txtDownPayment.Validating += new System.ComponentModel.CancelEventHandler(this.txtDownPayment_Validating);
            this.txtDownPayment.Validated += new System.EventHandler(this.txtDownPayment_Validated);
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTerm.Location = new System.Drawing.Point(68, 220);
            this.lblLoanTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(230, 31);
            this.lblLoanTerm.TabIndex = 5;
            this.lblLoanTerm.Text = "Loan Term (in years)";
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Location = new System.Drawing.Point(74, 255);
            this.txtLoanTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(364, 26);
            this.txtLoanTerm.TabIndex = 4;
            this.txtLoanTerm.Text = "30";
            this.txtLoanTerm.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanTerm_Validating);
            this.txtLoanTerm.Validated += new System.EventHandler(this.txtLoanTerm_Validated);
            // 
            // txtLoanTermInterest
            // 
            this.txtLoanTermInterest.Location = new System.Drawing.Point(442, 255);
            this.txtLoanTermInterest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoanTermInterest.Name = "txtLoanTermInterest";
            this.txtLoanTermInterest.Size = new System.Drawing.Size(106, 26);
            this.txtLoanTermInterest.TabIndex = 5;
            this.txtLoanTermInterest.Text = "0.06";
            this.txtLoanTermInterest.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanTermInterest_Validating);
            this.txtLoanTermInterest.Validated += new System.EventHandler(this.txtLoanTermInterest_Validated);
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(438, 226);
            this.lblInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(77, 26);
            this.lblInterest.TabIndex = 10;
            this.lblInterest.Text = "Interest";
            // 
            // lblYearlyPropertyTax
            // 
            this.lblYearlyPropertyTax.AutoSize = true;
            this.lblYearlyPropertyTax.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyPropertyTax.Location = new System.Drawing.Point(92, 369);
            this.lblYearlyPropertyTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearlyPropertyTax.Name = "lblYearlyPropertyTax";
            this.lblYearlyPropertyTax.Size = new System.Drawing.Size(191, 26);
            this.lblYearlyPropertyTax.TabIndex = 13;
            this.lblYearlyPropertyTax.Text = "Property Tax (yearly)";
            // 
            // txtPropertyTax
            // 
            this.txtPropertyTax.Location = new System.Drawing.Point(74, 398);
            this.txtPropertyTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPropertyTax.Name = "txtPropertyTax";
            this.txtPropertyTax.Size = new System.Drawing.Size(229, 26);
            this.txtPropertyTax.TabIndex = 6;
            this.txtPropertyTax.Text = "0";
            this.txtPropertyTax.Validating += new System.ComponentModel.CancelEventHandler(this.txtPropertyTax_Validating);
            this.txtPropertyTax.Validated += new System.EventHandler(this.txtPropertyTax_Validated);
            // 
            // lblYearlyHomeInsurance
            // 
            this.lblYearlyHomeInsurance.AutoSize = true;
            this.lblYearlyHomeInsurance.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyHomeInsurance.Location = new System.Drawing.Point(328, 369);
            this.lblYearlyHomeInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearlyHomeInsurance.Name = "lblYearlyHomeInsurance";
            this.lblYearlyHomeInsurance.Size = new System.Drawing.Size(221, 26);
            this.lblYearlyHomeInsurance.TabIndex = 15;
            this.lblYearlyHomeInsurance.Text = "Home Insurance (yearly)";
            // 
            // txtHomeInsurance
            // 
            this.txtHomeInsurance.Location = new System.Drawing.Point(320, 398);
            this.txtHomeInsurance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHomeInsurance.Name = "txtHomeInsurance";
            this.txtHomeInsurance.Size = new System.Drawing.Size(229, 26);
            this.txtHomeInsurance.TabIndex = 7;
            this.txtHomeInsurance.Text = "0";
            this.txtHomeInsurance.Validating += new System.ComponentModel.CancelEventHandler(this.txtHomeInsurance_Validating);
            this.txtHomeInsurance.Validated += new System.EventHandler(this.txtHomeInsurance_Validated);
            // 
            // lblHOA
            // 
            this.lblHOA.AutoSize = true;
            this.lblHOA.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOA.Location = new System.Drawing.Point(117, 463);
            this.lblHOA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHOA.Name = "lblHOA";
            this.lblHOA.Size = new System.Drawing.Size(144, 26);
            this.lblHOA.TabIndex = 17;
            this.lblHOA.Text = "HOA (monthly)";
            // 
            // txtHOA
            // 
            this.txtHOA.Location = new System.Drawing.Point(74, 492);
            this.txtHOA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHOA.Name = "txtHOA";
            this.txtHOA.Size = new System.Drawing.Size(229, 26);
            this.txtHOA.TabIndex = 8;
            this.txtHOA.Text = "0";
            this.txtHOA.Validating += new System.ComponentModel.CancelEventHandler(this.txtHOA_Validating);
            this.txtHOA.Validated += new System.EventHandler(this.txtHOA_Validated);
            // 
            // lblPMI
            // 
            this.lblPMI.AutoSize = true;
            this.lblPMI.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMI.Location = new System.Drawing.Point(369, 463);
            this.lblPMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPMI.Name = "lblPMI";
            this.lblPMI.Size = new System.Drawing.Size(136, 26);
            this.lblPMI.TabIndex = 19;
            this.lblPMI.Text = "PMI (monthly)";
            // 
            // txtPMI
            // 
            this.txtPMI.Location = new System.Drawing.Point(320, 492);
            this.txtPMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPMI.Name = "txtPMI";
            this.txtPMI.Size = new System.Drawing.Size(229, 26);
            this.txtPMI.TabIndex = 9;
            this.txtPMI.Text = "0";
            this.txtPMI.Validating += new System.ComponentModel.CancelEventHandler(this.txtPMI_Validating);
            this.txtPMI.Validated += new System.EventHandler(this.txtPMI_Validated);
            // 
            // lblMonthlyCost
            // 
            this.lblMonthlyCost.AutoSize = true;
            this.lblMonthlyCost.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyCost.Location = new System.Drawing.Point(54, 625);
            this.lblMonthlyCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyCost.Name = "lblMonthlyCost";
            this.lblMonthlyCost.Size = new System.Drawing.Size(303, 58);
            this.lblMonthlyCost.TabIndex = 20;
            this.lblMonthlyCost.Text = "Monthly Cost";
            this.lblMonthlyCost.Click += new System.EventHandler(this.LblMonthlyCost_Click);
            // 
            // lblToLoan
            // 
            this.lblToLoan.AutoSize = true;
            this.lblToLoan.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToLoan.Location = new System.Drawing.Point(60, 688);
            this.lblToLoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToLoan.Name = "lblToLoan";
            this.lblToLoan.Size = new System.Drawing.Size(54, 26);
            this.lblToLoan.TabIndex = 21;
            this.lblToLoan.Text = "Loan";
            // 
            // lblToPropertyTax
            // 
            this.lblToPropertyTax.AutoSize = true;
            this.lblToPropertyTax.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPropertyTax.Location = new System.Drawing.Point(60, 729);
            this.lblToPropertyTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToPropertyTax.Name = "lblToPropertyTax";
            this.lblToPropertyTax.Size = new System.Drawing.Size(122, 26);
            this.lblToPropertyTax.TabIndex = 22;
            this.lblToPropertyTax.Text = "Property Tax";
            // 
            // lblToHomeInsurance
            // 
            this.lblToHomeInsurance.AutoSize = true;
            this.lblToHomeInsurance.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToHomeInsurance.Location = new System.Drawing.Point(60, 771);
            this.lblToHomeInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToHomeInsurance.Name = "lblToHomeInsurance";
            this.lblToHomeInsurance.Size = new System.Drawing.Size(152, 26);
            this.lblToHomeInsurance.TabIndex = 23;
            this.lblToHomeInsurance.Text = "Home Insurance";
            // 
            // gbOoptional
            // 
            this.gbOoptional.Location = new System.Drawing.Point(64, 335);
            this.gbOoptional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOoptional.Name = "gbOoptional";
            this.gbOoptional.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOoptional.Size = new System.Drawing.Size(498, 217);
            this.gbOoptional.TabIndex = 24;
            this.gbOoptional.TabStop = false;
            this.gbOoptional.Text = "Optional";
            // 
            // lblHomeInsuranceAmount
            // 
            this.lblHomeInsuranceAmount.AutoSize = true;
            this.lblHomeInsuranceAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeInsuranceAmount.Location = new System.Drawing.Point(446, 771);
            this.lblHomeInsuranceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeInsuranceAmount.Name = "lblHomeInsuranceAmount";
            this.lblHomeInsuranceAmount.Size = new System.Drawing.Size(20, 26);
            this.lblHomeInsuranceAmount.TabIndex = 27;
            this.lblHomeInsuranceAmount.Text = "-";
            this.lblHomeInsuranceAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPropertyTaxAmount
            // 
            this.lblPropertyTaxAmount.AutoSize = true;
            this.lblPropertyTaxAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyTaxAmount.Location = new System.Drawing.Point(446, 729);
            this.lblPropertyTaxAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropertyTaxAmount.Name = "lblPropertyTaxAmount";
            this.lblPropertyTaxAmount.Size = new System.Drawing.Size(20, 26);
            this.lblPropertyTaxAmount.TabIndex = 26;
            this.lblPropertyTaxAmount.Text = "-";
            this.lblPropertyTaxAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAmount.Location = new System.Drawing.Point(446, 688);
            this.lblLoanAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(20, 26);
            this.lblLoanAmount.TabIndex = 25;
            this.lblLoanAmount.Text = "-";
            this.lblLoanAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalInterestPaidAmount
            // 
            this.lblTotalInterestPaidAmount.AutoSize = true;
            this.lblTotalInterestPaidAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterestPaidAmount.Location = new System.Drawing.Point(446, 866);
            this.lblTotalInterestPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInterestPaidAmount.Name = "lblTotalInterestPaidAmount";
            this.lblTotalInterestPaidAmount.Size = new System.Drawing.Size(20, 26);
            this.lblTotalInterestPaidAmount.TabIndex = 31;
            this.lblTotalInterestPaidAmount.Text = "-";
            this.lblTotalInterestPaidAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalPaidAmount
            // 
            this.lblTotalPaidAmount.AutoSize = true;
            this.lblTotalPaidAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaidAmount.Location = new System.Drawing.Point(446, 825);
            this.lblTotalPaidAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaidAmount.Name = "lblTotalPaidAmount";
            this.lblTotalPaidAmount.Size = new System.Drawing.Size(20, 26);
            this.lblTotalPaidAmount.TabIndex = 30;
            this.lblTotalPaidAmount.Text = "-";
            this.lblTotalPaidAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalInterestPaid
            // 
            this.lblTotalInterestPaid.AutoSize = true;
            this.lblTotalInterestPaid.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterestPaid.Location = new System.Drawing.Point(60, 866);
            this.lblTotalInterestPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInterestPaid.Name = "lblTotalInterestPaid";
            this.lblTotalInterestPaid.Size = new System.Drawing.Size(169, 26);
            this.lblTotalInterestPaid.TabIndex = 29;
            this.lblTotalInterestPaid.Text = "Total Interest Paid";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaid.Location = new System.Drawing.Point(60, 825);
            this.lblTotalPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(99, 26);
            this.lblTotalPaid.TabIndex = 28;
            this.lblTotalPaid.Text = "Total Paid";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentNumer,
            this.Date,
            this.Interest,
            this.Principal,
            this.Balance});
            this.dataGridView.Location = new System.Drawing.Point(618, 66);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(561, 837);
            this.dataGridView.TabIndex = 32;
            // 
            // paymentNumer
            // 
            this.paymentNumer.HeaderText = "#";
            this.paymentNumer.MinimumWidth = 8;
            this.paymentNumer.Name = "paymentNumer";
            this.paymentNumer.Width = 54;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 80;
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.MinimumWidth = 8;
            this.Interest.Name = "Interest";
            // 
            // Principal
            // 
            this.Principal.HeaderText = "Principal";
            this.Principal.MinimumWidth = 8;
            this.Principal.Name = "Principal";
            this.Principal.Width = 104;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.MinimumWidth = 8;
            this.Balance.Name = "Balance";
            this.Balance.Width = 103;
            // 
            // lblAmortization
            // 
            this.lblAmortization.AutoSize = true;
            this.lblAmortization.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmortization.Location = new System.Drawing.Point(644, 35);
            this.lblAmortization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmortization.Name = "lblAmortization";
            this.lblAmortization.Size = new System.Drawing.Size(304, 26);
            this.lblAmortization.TabIndex = 33;
            this.lblAmortization.Text = "Mortgage Amortization Schedule";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(450, 562);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 57);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // errorProviderHomePrice
            // 
            this.errorProviderHomePrice.ContainerControl = this;
            // 
            // MainPage
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 942);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAmortization);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblTotalInterestPaidAmount);
            this.Controls.Add(this.lblTotalPaidAmount);
            this.Controls.Add(this.lblTotalInterestPaid);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.lblHomeInsuranceAmount);
            this.Controls.Add(this.lblPropertyTaxAmount);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.lblToHomeInsurance);
            this.Controls.Add(this.lblToPropertyTax);
            this.Controls.Add(this.lblToLoan);
            this.Controls.Add(this.lblMonthlyCost);
            this.Controls.Add(this.lblPMI);
            this.Controls.Add(this.txtPMI);
            this.Controls.Add(this.lblHOA);
            this.Controls.Add(this.txtHOA);
            this.Controls.Add(this.lblYearlyHomeInsurance);
            this.Controls.Add(this.txtHomeInsurance);
            this.Controls.Add(this.lblYearlyPropertyTax);
            this.Controls.Add(this.txtPropertyTax);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtLoanTermInterest);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.lblHomePrice);
            this.Controls.Add(this.txtHomePrice);
            this.Controls.Add(this.gbOoptional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.Text = "Oa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHomePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHomePrice;
        private System.Windows.Forms.Label lblHomePrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtLoanTermInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblYearlyPropertyTax;
        private System.Windows.Forms.TextBox txtPropertyTax;
        private System.Windows.Forms.Label lblYearlyHomeInsurance;
        private System.Windows.Forms.TextBox txtHomeInsurance;
        private System.Windows.Forms.Label lblHOA;
        private System.Windows.Forms.TextBox txtHOA;
        private System.Windows.Forms.Label lblPMI;
        private System.Windows.Forms.TextBox txtPMI;
        private System.Windows.Forms.Label lblMonthlyCost;
        private System.Windows.Forms.Label lblToLoan;
        private System.Windows.Forms.Label lblToPropertyTax;
        private System.Windows.Forms.Label lblToHomeInsurance;
        private System.Windows.Forms.GroupBox gbOoptional;
        private System.Windows.Forms.Label lblHomeInsuranceAmount;
        private System.Windows.Forms.Label lblPropertyTaxAmount;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblTotalInterestPaidAmount;
        private System.Windows.Forms.Label lblTotalPaidAmount;
        private System.Windows.Forms.Label lblTotalInterestPaid;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblAmortization;
        private System.Windows.Forms.Button btnCalc;
        protected System.Windows.Forms.ErrorProvider errorProviderHomePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}

