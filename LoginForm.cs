
using System;
using System.Windows.Forms;

namespace student_managment_system
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Grades.GradesForm mainForm = new Grades.GradesForm();

            mainForm.StartPosition = FormStartPosition.CenterScreen;

            mainForm.FormClosed += (s, args) =>
            {
                this.Close();
            };

            mainForm.Show();
            this.Hide();
        }
    }
}
