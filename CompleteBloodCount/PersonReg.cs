using System;
using System.Windows.Forms;

namespace CompleteBloodCount
{
    public partial class PersonReg : Form
    {
        public PersonReg()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbFName.Text) || String.IsNullOrEmpty(tbLName.Text)) throw new Exception("Enter your full name");
                if (!rbMale.Checked && !rbFemale.Checked) throw new Exception("Choose you gender");
                if (rbMale.Checked && cbPregnancy.Checked) throw new Exception("It can not be real");
                if (birthDayPicker.Value > DateTime.Now) throw new Exception("Choose the correct date");
                Person person = new Person(Convert.ToString(tbFName.Text), Convert.ToString(tbLName .Text), DateTime.Now.Year - birthDayPicker.Value.Year - (DateTime.Now.DayOfYear < birthDayPicker.Value.DayOfYear ? 1 : 0), rbMale.Checked, cbPregnancy.Checked);
                person.save();
                RadioButton Checkedradio = new RadioButton();
                this.Hide();
                BloodCheck bloodCheck = new BloodCheck();
                bloodCheck.ShowDialog();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetlinkLabelPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbFName.Clear();
            tbLName.Clear();
            birthDayPicker.Text = string.Empty;
            cbPregnancy.Checked = false;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }
    }
}