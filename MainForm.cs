using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeitProject.forms;
using WeitProject.lib.elements;

namespace WeitProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadStudent();

        }

        private void MenuStrip_Item_Tool_Student_Clicked(object sender, EventArgs e)
        {
            StudentForm stdForm = new StudentForm();
            stdForm.ShowDialog();
            LoadStudent();
        }


        private void LoadStudent()
        {
            var students = Context.GetAllStudent();

            foreach (var std in students)
            {
                object[] row =
                {
                    std.MatriculationNumber,
                    std.Name,
                    std.Surname,
                    ""
                };

                this.dataGridStudent.Rows.Add(row);
            }
        }
    }
}
