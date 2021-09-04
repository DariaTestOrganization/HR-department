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
        string photoName;

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
            if(empList.SelectedIndex > -1)
            {
                string emp_name = empList.SelectedItem.ToString();
                var employee = doc2.Element("root").Elements("employee").
                    Where(emp => emp.Attribute("name").Value == emp_name).FirstOrDefault();
                if (employee != null)
                {
                    string file = employee.Attribute("photo").Value;
                    string path = @"..\..\Images\" + file;
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
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg Files (*.jpg)|*.jpg|Png Files (*.png)|*.png|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photoPath = ofd.FileName;
                photoName = ofd.SafeFileName;
                empPhoto.Image = Image.FromFile(photoPath);
            }
        }

        private void saveDepButton_Click(object sender, EventArgs e)
        {
            string name = depName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Вы не указали имя департамента", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                // Смена названия в xml файле Департаментов
                int ind = depList.SelectedIndex;
                doc1.Element("root").Elements("department").
                Where(emp => emp.Attribute("name").Value == depList.SelectedItem.ToString()).FirstOrDefault().Attribute("name").Value = name;

                //Изменение названия отделов в xml файле Работников
                var employee = doc2.Element("root").Elements("employee").Where(emp => emp.Attribute("dep_name").Value == depList.SelectedItem.ToString());
                int empQuantity = employee.ToList().Count;
                for (int i = 0; i < empQuantity; i++)
                    employee.FirstOrDefault().Attribute("dep_name").Value = name;

                // Отображение изменненого названия в ComboBox
                depList.Items.Clear();
                foreach (var dep in doc1.Element("root").Elements("department").ToList())
                    depList.Items.Add(dep.Attribute("name").Value);
                depList.SelectedIndex = ind;

                doc1.Save(path1);
                doc2.Save(path2);
                depName.Clear();
                MessageBox.Show("Департамент успешно изменен", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void delDepButon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить департамент со всеми его сотрудниками?", "Удаление департамента", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                doc1.Element("root").Elements("department").
                Where(emp => emp.Attribute("name").Value == depList.SelectedItem.ToString()).FirstOrDefault().Remove();

                //Удаление сотрудников удаленного отдела в xml файле Работников
                var employee = doc2.Element("root").Elements("employee").Where(emp => emp.Attribute("dep_name").Value == depList.SelectedItem.ToString());
                int empQuantity = employee.ToList().Count;
                for (int i = 0; i < empQuantity; i++)
                    employee.FirstOrDefault().Remove();


                // Отображение списка департаментов без удаленного в ComboBox
                depList.Items.Clear();
                foreach (var dep in doc1.Element("root").Elements("department").ToList())
                    depList.Items.Add(dep.Attribute("name").Value);
                depList.SelectedIndex = 0;

                doc1.Save(path1);
                doc2.Save(path2);
                depName.Clear();
                MessageBox.Show("Департамент успешно удален", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            empList.SelectedIndex = -1;
            fioEmp.Clear();
            dateBirthEmp.Value = DateTime.Now;
            addressEmp.Clear();
            telEmp.Clear();
            emailEmp.Clear();
            positionEmp.Clear();
            salaryEmp.Value = 0;
            workYears.Value = 0;
            empPhoto.Image = Image.FromFile(@"..\..\Images\profile.png");
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            string depName = depList.SelectedItem.ToString();
            string name = fioEmp.Text;
            string birth = dateBirthEmp.Value.ToShortDateString();
            string address = addressEmp.Text;
            string phone = telEmp.Text;
            string email = emailEmp.Text;
            string position = positionEmp.Text;
            string salary = salaryEmp.Value.ToString();
            string years = workYears.Value.ToString();
            string photo = photoName;
            doc2.Element("root").Add(new XElement("employee", new XAttribute("dep_name", depName), new XAttribute("name", name),
                new XAttribute("birth", birth), new XAttribute("addr", address), new XAttribute("phone", phone),
                new XAttribute("email", email), new XAttribute("pos", position), new XAttribute("salary", salary),
                new XAttribute("workYears", years), new XAttribute("photo", photo)));
            string path = @"..\..\Images\" + photo;
            if (!File.Exists(path))
            {
                File.Copy(photoPath, path);
            }
            depList.SelectedIndex = depList.SelectedIndex;
            clearFields();

            MessageBox.Show("Сотрудник успешно добавлен", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            doc2.Save(path2);
        }

        private void saveEmpButton_Click(object sender, EventArgs e)
        {
            var employee = doc2.Element("root").Elements("employee").Where(emp => emp.Attribute("name").Value == empList.SelectedItem.ToString()).FirstOrDefault();
            string name = fioEmp.Text;
            string birth = dateBirthEmp.Value.ToShortDateString();
            string address = addressEmp.Text;
            string phone = telEmp.Text;
            string email = emailEmp.Text;
            string position = positionEmp.Text;
            string salary = salaryEmp.Value.ToString();
            string years = workYears.Value.ToString();
            string photo = photoName;
            employee.Attribute("name").Value = name;
            employee.Attribute("birth").Value = birth;
            employee.Attribute("phone").Value = phone;
            employee.Attribute("email").Value = email;
            employee.Attribute("pos").Value = position;
            employee.Attribute("salary").Value = salary;
            employee.Attribute("workYears").Value = years;

            doc2.Save(path2);

        }
    }
}
