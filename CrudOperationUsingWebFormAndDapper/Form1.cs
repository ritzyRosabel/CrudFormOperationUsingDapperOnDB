using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CrudOperationUsingWebFormAndDapper
{
    public partial class myform : Form
    {
        public List<Person> person = new List<Person>();
        public myform()
        {
            InitializeComponent();
            Update();
        }
        private void Update()
        {
            Found.DataSource = person;
            Found.DisplayMember = "info";
        }
     

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            person = dataAccess.GetPeople(NameTextBox.Text);
            Update();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertDetail(NameInsTextBox.Text, int.Parse(AgeInsTextBox.Text));
            NameInsTextBox.Text = "";
            AgeInsTextBox.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.UpdateDetails(int.Parse(IdTextBox.Text),NameInsTextBox.Text, int.Parse(AgeInsTextBox.Text));
            IdTextBox.Text = "";
            NameInsTextBox.Text = "";
            AgeInsTextBox.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteDetails(int.Parse(IdTextBox.Text), NameInsTextBox.Text, int.Parse(AgeInsTextBox.Text));
            IdTextBox.Text = "";
            NameInsTextBox.Text = "";
            AgeInsTextBox.Text = "";
        }


    }
}
