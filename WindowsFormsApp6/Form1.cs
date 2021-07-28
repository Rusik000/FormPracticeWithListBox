using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PersonListBox.Items.Add(new Person
            {
                Name = "Ruslan",
                Surname = "Mustafayev",
                Email = "Rusik00@gmail.com",
                Phone = "+(994)55-528-00-08",
                Birthdate = new DateTime(2000,12,15)
            });

            PersonListBox.Items.Add(new Person
            {
                Name = "Kamran",
                Surname = "Aliyev",
                Email = "Aliyev.k009@gmail.com",
                Phone = "+(994)70-220-70-07",
                Birthdate = new DateTime(1998,10,09)
            });

            PersonListBox.DisplayMember = "Name";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {


            Point AddLocation = AddBtn.Location;
            AddBtn.Location = ChangeBtn.Location;
            ChangeBtn.Location = AddLocation;

            string name = "";
            string surname = "";
            string email = "";
            string phone = "";
            DateTime date = new DateTime();

            if (NameTxtBx.Text != String.Empty)
            {
                name = NameTxtBx.Text;
            }
            if (SurnameTxtBx.Text != String.Empty)
            {
                surname = SurnameTxtBx.Text;
            }

            if (EmailTxtBx.Text != String.Empty)
            {
                email = EmailTxtBx.Text;
            }
            if (PhoneTxtBx.Text != String.Empty)
            {
                phone = PhoneTxtBx.Text;
            }

            date = Convert.ToDateTime(BirthdateTxtBx.Text);



            PersonListBox.Items.Add(new Person
            {
                Name = name,
                Surname = surname,
                Email = email,
                Phone = phone,
                Birthdate = date
            });


        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Point changebtn = ChangeBtn.Location;
            ChangeBtn.Location = AddBtn.Location;
            AddBtn.Location = changebtn;

            var item = PersonListBox.SelectedItem as Person;

            item.Name = NameTxtBx?.Text;
            item.Surname = SurnameTxtBx?.Text;
            item.Email = EmailTxtBx?.Text;
            item.Phone = PhoneTxtBx?.Text;
            item.Birthdate = Convert.ToDateTime(BirthdateTxtBx?.Text);
        }

        private void PersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = PersonListBox.SelectedItem as Person;
            FilenameLbl.Text = item?.Name;
            FilenameLbl.Text = FilenameLbl.Text += ".json";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            var item = PersonListBox.SelectedItem as Person;
            FileHelper.WritePersonToJson(FilenameLbl.Text, item);
            MessageBox.Show("Data is writed to json file");
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var item = PersonListBox.SelectedItem as Person;
            var person = FileHelper.ReadPersonFromJson(FilenameLbl.Text);
            NameTxtBx.Text = person.Name;
            SurnameTxtBx.Text = person.Surname;
            EmailTxtBx.Text = person.Email;
            PhoneTxtBx.Text = person.Phone;
            BirthdateTxtBx.Text = person.Birthdate.ToString("yyyy/MM/dd");
        }
    }
}
