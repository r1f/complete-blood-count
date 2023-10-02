using System;
using System.Windows.Forms;

namespace CompleteBloodCount
{
    public partial class BloodCheck : Form
    {
        public BloodCheck()
        {
            InitializeComponent();
            txtBoxRBC.Hide();
            txtBoxWBC.Hide();
            txtBoxHct.Hide();
            txtBoxHb.Hide();
            txtBoxPC.Hide();
            lblRBC.Hide();
            lblWBC.Hide();
            lblHC.Hide();
            lblHematocrit.Hide();
            lblPlatelets.Hide();
            gbValuesLeft.Hide();
            gbValuesRight.Hide();
        }

        private void lblResetBC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBoxRBC.Clear();
            txtBoxWBC.Clear();
            txtBoxHct.Clear();
            txtBoxHb.Clear();
            txtBoxPC.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTests.SelectedItem == null) throw new Exception("Select the test");
                if (String.IsNullOrEmpty(txtBoxWBC.Text)) throw new Exception("Enter the white blood cells Content value");
                if (String.IsNullOrEmpty(txtBoxRBC.Text)) throw new Exception("Enter the red blood cells value");
                if (String.IsNullOrEmpty(txtBoxHb.Text)) throw new Exception("Enter the hemoglobin content value");
                if (String.IsNullOrEmpty(txtBoxHct.Text)) throw new Exception("Enter the hematocrit value");
                if (String.IsNullOrEmpty(txtBoxPC.Text)) throw new Exception("Enter the platelets value");
                BloodTests bloodTest = new BloodTests();
                CBCTest cBCtest = new CBCTest(Convert.ToSingle(txtBoxWBC.Text), Convert.ToSingle(txtBoxRBC.Text), Convert.ToSingle(txtBoxHb.Text), Convert.ToSingle(txtBoxHct.Text), Convert.ToSingle(txtBoxPC.Text));
                Person person = new Person();
                person = person.getPerson();
                JsonSaveClass jsonSaveClass = new JsonSaveClass
                {
                    Person = person,
                    BloodTests = bloodTest,
                    CBCTest = cBCtest,
                };
                jsonSaveClass.save();
                MessageBox.Show($"{cBCtest.diagnosis}", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbTests_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTests.Text == "CBC test") 
            {
                gbValuesLeft.Show();
                gbValuesRight.Show();
                txtBoxRBC.Show();
                txtBoxWBC.Show();
                txtBoxHct.Show();
                txtBoxHb.Show();
                txtBoxPC.Show();
                lblRBC.Show();
                lblWBC.Show();
                lblHC.Show();
                lblHematocrit.Show();
                lblPlatelets.Show();
            }
            else
            {
                txtBoxRBC.Hide();
                txtBoxWBC.Hide();
                txtBoxHct.Hide();
                txtBoxHb.Hide();
                txtBoxPC.Hide();
                lblRBC.Hide();
                lblWBC.Hide();
                lblHC.Hide();
                lblHematocrit.Hide();
                lblPlatelets.Hide();
                gbValuesLeft.Hide();
                gbValuesRight.Hide();
            }
        }
    }
}
