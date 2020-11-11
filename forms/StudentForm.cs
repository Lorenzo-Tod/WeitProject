using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeitProject.lib.elements;
using WeitProject.Lib.Elements;

namespace WeitProject.forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                MatriculationNumber = txtMatriculation.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text
            };
            Context.AddStudent(std);
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
