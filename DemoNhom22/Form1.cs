using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoNhom22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdOpenFile.ShowDialog();
            string file = ofdOpenFile.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image myImage = Image.FromFile(file);
            pictureBoxSource.Image = myImage;
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxSource.Image.Save(stream, ImageFormat.Jpeg);
            MyBdContextDataContext myBd = new MyBdContextDataContext();
            Employee emp = new Employee();
            emp.EmployeeName = "My Name";
            emp.Picture = stream.ToArray();
            myBd.Employees.InsertOnSubmit(emp);
            myBd.SubmitChanges();
        }

        private void btnLoadImageFromDatabase_Click(object sender, EventArgs e)
        {
            MyBdContextDataContext myBd = new MyBdContextDataContext();
            Employee emp = myBd.Employees.Where(em => em.EmployeeName == "My Name").FirstOrDefault();
            if (emp == null
                return;
            MemoryStream memoryStream = new MemoryStream(emp.Picture.ToArray());
            Image img = Image.FromStream(memoryStream);
            if (img == null)
                return;
            pictureBoxDes.Image = img;
        }
    }
}
