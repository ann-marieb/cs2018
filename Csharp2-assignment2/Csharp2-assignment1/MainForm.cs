/// MainForm.cs
/// Ann-Marie Bergström  ai2436 2018-02-13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2_assignment
{
    /// <summary>
    /// Handle user interface. New animal category or species do not require changes.
    /// </summary>
    public partial class MainForm : Form
    {
        private AnimalManager animalManagerObj; //declare animalManagerObj as type AnimalManager

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
            animalManagerObj = new AnimalManager(); // create animalManagerObj
        }

        #region Methods for user interface

        /// <summary>
        /// Main method used to initialize user interface 
        /// </summary>
        private void InitializeGui()
        {
            txtName.Text = string.Empty; //clear textbox
            txtAge.Text = string.Empty; //clear textbox
            lstGender.DataSource = GetAllGenderNames(); //populate Gender listbox
            lstGender.SelectedIndex = -1; //unselect
            lstAnimalCategory.DataSource = GetAllAnimalCategoryNames(); //populate Animal Category listbox
            lstAnimalCategory.SelectedIndex = -1; //unselect
            gbxAnimalCategory.Visible = false; //hide groupbox
            txtAnimalCatInfo.Text = string.Empty; //clear textbox
            lstSpecies.SelectedIndex = -1; //unselect
            gbxSpecies.Visible = false; //hide groupbox
            txtSpeciesInfo.Text = string.Empty; //clear textbox
            InitAnimalList(); //initialize Animal list
        }

        /// <summary>
        /// Create Gender strings
        /// </summary>
        /// <returns>Gender list </returns>
        private static List<string> GetAllGenderNames()
        {
            List<string> genders = new List<string>();
            foreach (string gender in Enum.GetNames(typeof(Gender)))
            {
                genders.Add(gender);
            }
            return genders;
        }

        /// <summary>
        /// Create Animal Category strings
        /// </summary>
        /// <returns>returns Animal Category list </returns>
        private static List<string> GetAllAnimalCategoryNames()
        {
            List<string> categories = new List<string>();
            foreach (string cat in Enum.GetNames(typeof(AnimalCategory)))
            {
                categories.Add(cat);
            }
            return categories;
        }

        /// <summary>
        /// When Animal Category is selected display groupbox for category specific info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstAnimalCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxAnimalCategory.Visible = true; //make groupbox visible
            gbxAnimalCategory.Text = lstAnimalCategory.Text; //name groupbox with selected animal category

            lstSpecies.DataSource = AnimalMaker.GetSpeciesNames(lstAnimalCategory.Text); //populate Species listbox
            lstSpecies.SelectedIndex = -1; //unselect

            if (lstAnimalCategory.Text != "all")
            {
                lblAnimalCatInfo.Text = AnimalMaker.LabelText(lstAnimalCategory.Text); //label for animal category specific info
            }
            gbxSpecies.Visible = false; //hide groupbox
        }

        /// <summary>
        /// When Species is selected, display groupbox for species specific info.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxSpecies.Text = lstSpecies.Text;// name groupbox with selected species
            lblSpeciesInfo.Text = AnimalMaker.LabelText(lstSpecies.Text); //label for species specific info

            //if Animal Category "all" is selected, species selection generates groupbox name and 
            //label for animal category specific info.
            if (lstAnimalCategory.Text == "all")
            {
                gbxAnimalCategory.Text = AnimalMaker.GroupBoxName(lstSpecies.Text);
                lblAnimalCatInfo.Text = AnimalMaker.AnimalCategoryInfoWhenAnimalSelected(lstSpecies.Text);
            }
            gbxSpecies.Visible = true; //make groupbox visible
        }

        /// <summary>
        /// Define the columns of the animal list
        /// </summary>
        private void InitAnimalList()
        {
            lvAnimals.Columns.Clear();
            lvAnimals.Columns.Add("SPECIES", 70, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("ID", 40, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("NAME", 100, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("AGE", 40, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("GENDER", 70, HorizontalAlignment.Center);
            lvAnimals.Columns.Add("SPECIAL CHARACTERISTICS", 250, HorizontalAlignment.Center);
        }
        #endregion

        /// <summary>
        /// Validate and add animal on Add animal button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            {
                //send animal info for validation and receive errorText. 
                string errorText = AnimalMaker.ValidateInput(txtName.Text, txtAge.Text, lstGender.SelectedIndex,
                    lstSpecies.Text, txtAnimalCatInfo.Text, txtSpeciesInfo.Text);

                //if errorText is not empty, input is not valid.
                if (!string.IsNullOrEmpty(errorText)) MessageBox.Show(errorText);

                //if errorText is empty, input is valid.
                else
                {
                    bool notUsed = int.TryParse(txtAge.Text, out int ageInt); //convert age from string to integer
                    var animal = AnimalMaker.MakeAnimal(txtName.Text, ageInt, lstGender.Text,
                        lstSpecies.Text, txtAnimalCatInfo.Text, txtSpeciesInfo.Text); //send info to AnimalMaker for creation of animal
                    animalManagerObj.AddAnimal(animal); //send animal to AnimalManager to be added 
                    UpdateAnimalList(); //display animal in Animal list
                    InitializeGui(); //clear form
                }
            }
        }

        /// <summary>
        /// Update total list of animals.
        /// </summary>
        private void UpdateAnimalList()
        {
            lvAnimals.Items.Clear();
            foreach (var animalRow in animalManagerObj.AnimalsAsRows)
            {
                // Create a row of the data
                var row = new ListViewItem(animalRow);
                // and add it to the ListView
                lvAnimals.Items.Add(row);
            }
        }

        /// <summary>
        /// When an individual animal is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxFoodSchedule.Items.Clear();

            var indices = lvAnimals.SelectedIndices;

            if (indices.Count == 1) // There will never be more than one row selected.
            {
                var index = indices[0];

                bool indexOK = animalManagerObj.ValidateIndex(index);

                if (indexOK)
                {
                    IAnimal animal = animalManagerObj.GetAnimal(index); //Get animal from Animal Manager
                    tbxEaterType.Text = animal.GetEaterType().ToString(); //Display eater type in form

                    List<string> feedDescriptionList = animal.GetFoodSchedule(); //Get food description list from Animal
                    lbxFoodSchedule.Items.AddRange(feedDescriptionList.ToArray()); //Display food items 
                }
            }
        }
    }
}
