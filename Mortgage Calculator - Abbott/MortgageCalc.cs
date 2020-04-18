using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3___Mortgage_Calculator___Abbott
{
    public partial class MainPage : Form
    {
        //double _homePrice, _downPayment, _downPaymentPerc, _loanTerm, _loanTermInterest, _propertyTax, 
        //    _homeInsurance, _feeHOA, _feePMI;
        public MainPage()
        {
            InitializeComponent();
        }
        
        // Home Price -----------------------------------------------------------------     1
        internal string HomePrice
        {
            get => txtHomePrice.Text;
            set => txtHomePrice.Text = value;
        }

        private void txtHomePrice_Validating(object sender, CancelEventArgs e)
        {
            double homePrice;
            bool valid = true;

            if (!double.TryParse(txtHomePrice.Text, out homePrice)) valid = false;
            else if (homePrice <= 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtHomePrice.SelectAll();
                errorProviderHomePrice.SetError(txtHomePrice, "Invalid Home Price");
            }
        }

        private void txtHomePrice_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtHomePrice, "");
        }

        // Down Payment -----------------------------------------------------------------   2
        internal string DownPayment
        {
            get => txtDownPayment.Text;
            set => txtDownPayment.Text = value;
        }

        private void txtDownPayment_Validating(object sender, CancelEventArgs e)
        {
            double downPayment;
            bool valid = true;

            if (!double.TryParse(txtDownPayment.Text, out downPayment)) valid = false;
            else if (downPayment < 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtDownPayment.SelectAll();
                errorProviderHomePrice.SetError(txtDownPayment, "Invalid Down Payment");
            }
        }

        private void txtDownPayment_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtDownPayment, "");
        }

        // Loan Term -----------------------------------------------------------------  4
        internal string LoanTerm
        {
            get => txtLoanTerm.Text;
            set => txtLoanTerm.Text = value;
        }

        private void txtLoanTerm_Validating(object sender, CancelEventArgs e)
        {
            double loanTerm;
            bool valid = true;

            if (!double.TryParse(txtLoanTerm.Text, out loanTerm)) valid = false;
            else if (loanTerm <= 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtLoanTerm.SelectAll();
                errorProviderHomePrice.SetError(txtLoanTerm, "Invalid Loan Term");
            }
        }

        private void txtLoanTerm_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtLoanTerm, "");
        }

        // Interest -----------------------------------------------------------------  5
        internal string LoanInterest
        {
            get => txtLoanTermInterest.Text;
            set => txtLoanTermInterest.Text = value;
        }

        private void txtLoanTermInterest_Validating(object sender, CancelEventArgs e)
        {
            double interest;
            bool valid = true;

            if (!double.TryParse(txtLoanTermInterest.Text, out interest)) valid = false;
            else if (interest <= 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtLoanTermInterest.SelectAll();
                errorProviderHomePrice.SetError(txtLoanTermInterest, "Invalid interest rate");
            }
        }

        private void txtLoanTermInterest_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtLoanTermInterest, "");
        }

        // PropertyTax -----------------------------------------------------------------    6
        internal string PropertyTax
        {
            get => txtPropertyTax.Text;
            set => txtPropertyTax.Text = value;
        }

        private void txtPropertyTax_Validating(object sender, CancelEventArgs e)
        {
            double propertyTax;
            bool valid = true;

            if (!double.TryParse(txtPropertyTax.Text, out propertyTax)) valid = false;
            else if (propertyTax < 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtPropertyTax.SelectAll();
                errorProviderHomePrice.SetError(txtPropertyTax, "Invalid property Tax");
            }
        }

        private void txtPropertyTax_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtLoanTerm, "");
        }


        // HOA -----------------------------------------------------------------    7
        internal string HOA
        {
            get => txtHOA.Text;
            set => txtHOA.Text = value;
        }

        private void txtHOA_Validating(object sender, CancelEventArgs e)
        {
            double feeHOA;
            bool valid = true;

            if (!double.TryParse(txtHOA.Text, out feeHOA)) valid = false;
            else if (feeHOA < 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtHOA.SelectAll();
                errorProviderHomePrice.SetError(txtHOA, "Invalid HOA");
            }
        }

        private void txtHOA_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtHOA, "");
        }


        // Home Insurance -----------------------------------------------------------------    8
        internal string HomeInsurance
        {
            get => txtHomeInsurance.Text;
            set => txtHomeInsurance.Text = value;
        }

        private void txtHomeInsurance_Validating(object sender, CancelEventArgs e)
        {
            double homeInsurance;
            bool valid = true;

            if (!double.TryParse(txtHomeInsurance.Text, out homeInsurance)) valid = false;
            else if (homeInsurance < 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtHomeInsurance.SelectAll();
                errorProviderHomePrice.SetError(txtHomeInsurance, "Invalid home Insurance");
            }
        }

        private void txtHomeInsurance_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtHomeInsurance, "");
        }


        // PMI -----------------------------------------------------------------    9
        internal string PMI
        {
            get => txtPMI.Text;
            set => txtPMI.Text = value;
        }

        private void txtPMI_Validating(object sender, CancelEventArgs e)
        {
            double feePMI;
            bool valid = true;

            if (!double.TryParse(txtPMI.Text, out feePMI)) valid = false;
            else if (feePMI < 0) valid = false;

            if (!valid)
            {
                e.Cancel = true;
                txtPMI.SelectAll();
                errorProviderHomePrice.SetError(txtPMI, "Invalid PMI");
            }
        }

        private void txtPMI_Validated(object sender, EventArgs e)
        {
            errorProviderHomePrice.SetError(txtPMI, "");
        }


        // Calculations
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                double homePrice = Double.Parse(HomePrice);
                double downPayment = Double.Parse(DownPayment);
                double totalPayments = Double.Parse(LoanTerm) * 12;
                double interest = Double.Parse(LoanInterest);
                double propertyTax = Double.Parse(PropertyTax);
                double feeHOA = Double.Parse(HOA);
                double homeInsurance = Double.Parse(HomeInsurance);
                double feePMI = Double.Parse(PMI);

                if (interest > 1) { interest = interest / 100; }

                double baseMortgage = homePrice - downPayment;
                double powerCalc = Math.Pow((1 + interest / 12), totalPayments);
                double baseMonthlyCost = baseMortgage * (powerCalc * interest)/(12 * (powerCalc - 1));
                double monthlyCost = baseMonthlyCost + (propertyTax + homeInsurance + feeHOA + feePMI) / 12;
                double baseTotalPaid = baseMonthlyCost * totalPayments;
                double totalPaid = monthlyCost * totalPayments;

                lblMonthlyCost.Text = $"{monthlyCost:C2} / mo";
                lblLoanAmount.Text = $"{baseMonthlyCost:C2}";
                lblPropertyTaxAmount.Text = $"{(propertyTax / 12):C2}";
                lblHomeInsuranceAmount.Text = $"{(homeInsurance / 12):C2}";

                lblTotalPaidAmount.Text = $"{(totalPaid):C2}";
                lblTotalInterestPaidAmount.Text = $"{(baseTotalPaid - baseMortgage):C2}";


                // Amortization -----------------------------------------------------

                DateTime today = new DateTime(int.Parse(DateTime.Now.Year.ToString()),
                    int.Parse(DateTime.Now.Month.ToString()),
                   int.Parse(DateTime.Now.Day.ToString()));

                double newMortgage = baseMortgage;

                dataGridView.Rows.Clear();

                for (int i=0; i<totalPayments; i++)
                {
                    dataGridView.EndEdit();
                    
                    today = today.AddMonths(1);
                    double oldMortgage = newMortgage;
                    double paidInterest = oldMortgage * (interest / 12);
                    double principal = baseMonthlyCost - paidInterest;
                    newMortgage = newMortgage - (principal);
                    double balance = oldMortgage - principal;

                    string theDate = today.ToString("MMMM, yyyy");
                    string thePaidInterest = $"{paidInterest:C2}";
                    string thePrincipal = $"{principal:C2}";
                    string theBalance = $"{(balance):C2}";

                    dataGridView.Rows.Add(i+1, theDate, thePaidInterest, thePrincipal, theBalance); //date, interest, principal, balance
                }
            }
        }

        private void LblMonthlyCost_Click(object sender, EventArgs e)
        {

        }
    }
}
