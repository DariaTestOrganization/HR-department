using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace HR_Department
{
    public partial class Form1 : Form
    {
        string path1;
        string path2;
        string photoPath;

        XDocument doc1;
        XDocument doc2;


        public Form1()
        {
            InitializeComponent();
            path1 = @"..\..\Data\Departments.xml";
            path2 = @"..\..\Data\Employees.xml";

            doc1 = XDocument.Load(path1);
            doc2 = XDocument.Load(path2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var deps = doc1.Element("root").Elements("department").ToList();
            foreach (var dep in deps)
                depList.Items.Add(dep.Attribute("name").Value);
            if(depList.Items.Count >0)
                depList.SelectedIndex = 0;
        }

        private void addDepButton_Click(object sender, EventArgs e)
        {
            string name = depName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Вы не указали имя департамента", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                depList.Items.Add(name);
                doc1.Element("root").Add(new XElement("department", new XAttribute("name", name)));
                doc1.Save(path1);
                depName.Clear();
                MessageBox.Show("Департамент успешно добавлен", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
            }
        }

        private void depList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = depList.SelectedItem.ToString();
            var employees = doc2.Element("root").Elements("employee").
                Where(emp => emp.Attribute("dep_name").Value == name).ToList();
            empList.Items.Clear();
            foreach (var emp in employees)
                empList.Items.Add(emp.Attribute("name").Value);
        }

        private void empList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp_name = empList.SelectedItem.ToString();
            var employee = doc2.Element("root").Elements("employee").
                Where(emp => emp.Attribute("name").Value == emp_name).FirstOrDefault();
            if(employee != null)
            {
                string file = employee.Attribute("photo").Value;
                string path = @"..\..\Images\"+file;
                empPhoto.Image = Image.FromFile(path);

                fioEmp.Text = employee.Attribute("name").Value;
                dateBirthEmp.Text = employee.Attribute("birth").Value;
                addressEmp.Text = employee.Attribute("addr").Value;
                telEmp.Text = employee.Attribute("phone").Value;
                emailEmp.Text = employee.Attribute("email").Value;
                positionEmp.Text = employee.Attribute("pos").Value;
                salaryEmp.Text = employee.Attribute("salary").Value;
                workYears.Text = employee.Attribute("workYears").Value;




            }

        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPath = ofd.FileName;
                empPhoto.Image = Image.FromFile(photoPath);
            }
        }
    }
}
