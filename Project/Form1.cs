using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Project.Business;
using Project.Models;

namespace Project
{
    public partial class Form1 : Form
    {
        public AnimalLogic animalController = new AnimalLogic();
        public BreedLogic breedController = new BreedLogic();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbBoxDogSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimal(cmbBoxDogSelect.SelectedItem as Animal);
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblAnimalName_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblBreed_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxName.Text) && string.IsNullOrEmpty(txtBoxAge.Text))
            {
                MessageBox.Show("Въведи данни!");
                return;
            }
            Animal animal = new Animal();
            animal.Age = int.Parse(txtBoxId.Text);
            animal.Name = txtBoxName.Text;
            animal.Description = txtBoxDescription.Text;
            animal.BreedId = (int)cmbBoxBreeds.SelectedValue;
            animalController.Create(animal);
            MessageBox.Show("Записът е успешно добавен!");
            LoadComboBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int foundId = 0;
            if (string.IsNullOrEmpty(txtBoxId.Text) || !txtBoxId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за редактиране!");
                txtBoxId.Focus();
                return;
            }
            else
            {
                foundId = int.Parse(txtBoxId.Text);
            }
            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                Animal foundAnimal = animalController.Get(foundId);
                if (foundAnimal == null)
                {
                    MessageBox.Show("Няма такъв запис въведи ново Id");
                    txtBoxId.Focus();
                    return;
                }
                LoadAnimal(foundAnimal);
            }
            else
            {
                Animal newAnimal = new Animal
                {
                    Name = txtBoxName.Text,
                    Age = int.Parse(txtBoxAge.Text),
                    BreedId = (int)cmbBoxBreeds.SelectedValue
                };
                animalController.Update(foundId, newAnimal);
                MessageBox.Show($"Успешно е редактиран записът с Id {foundId}");
                LoadComboBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int foundId = 0;
            if (string.IsNullOrEmpty(txtBoxId.Text) || !txtBoxId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за редактиране!");
                txtBoxId.Focus();
                return;
            }
            else
            {
                foundId = int.Parse(txtBoxId.Text);
            }
            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                Animal foundAnimal = animalController.Get(foundId);
                if (foundAnimal == null)
                {
                    MessageBox.Show("Няма такъв запис въведи ново Id");
                    txtBoxId.Focus();
                    return;
                }
                LoadAnimal(foundAnimal);
            }
            DialogResult result = MessageBox.Show($"Наистина ли искате да изтриете запис No {foundId}?", "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                animalController.Delete(foundId);
                MessageBox.Show($"Успешно изтрихте запис с Id {foundId}");
            }
            LoadComboBox();
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAnimal(listBoxOutput.SelectedItem as Animal);
        }
        private void LoadComboBox()
        {
            cmbBoxBreeds.DataSource = breedController.GetAllBreeds();
            cmbBoxBreeds.ValueMember = "Id";
            cmbBoxBreeds.DisplayMember = "Name";
            cmbBoxDogSelect.DataSource = animalController.GetAll();
            cmbBoxDogSelect.ValueMember = "Id";
            cmbBoxDogSelect.DisplayMember = "Name";
            PopulateListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
        private void PopulateListBox()
        {
            listBoxOutput.DataSource = animalController.GetAll();
        }

        private void LoadAnimal(Animal selectedAnimal)
        {
            txtBoxName.Text = selectedAnimal.Name;
            txtBoxDescription.Text = selectedAnimal.Description;
            txtBoxAge.Text = selectedAnimal.Age.ToString();
            cmbBoxBreeds.SelectedIndex = selectedAnimal.BreedId - 1;
            txtBoxId.Text = selectedAnimal.Id.ToString();
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxBreed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxBreeds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBreedId_Click(object sender, EventArgs e)
        {

        }
    }
}
