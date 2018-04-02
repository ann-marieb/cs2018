/// MainForm.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2_assignment
{
    /// <summary>
    /// Handle user interface. New animal category or species does not require changes.
    /// </summary>
    public partial class MainForm : Form
    {
        #region fields
        private AnimalManager animalManagerObj = new AnimalManager(); //declare and create animalManagerObj as type AnimalManager
        private RecipeManager recipeManagerObj = new RecipeManager(); //declare and create recipeManagerObj as type RecipeManager
        private ListManager<Staff> staffListObj = new ListManager<Staff>(); // declare and create staffListObj as type ListManager<Staff>
        private string binFileName;  //file to save list to
        private bool animalListChangedButNotSaved = false;
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        #region User interface methods 
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
            tbxEaterType.Clear();
            lbxFoodSchedule.Items.Clear();
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
            animalListChangedButNotSaved = true;
        }
        #endregion

        #region animal event handlers
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
                    bool addOK = animalManagerObj.AddAnimal(animal); //send animal to AnimalManager to be added 
                    if (addOK)
                    {
                        UpdateAnimalList(); //display animal in Animal list
                        InitializeGui(); //clear form
                    }
                    else MessageBox.Show("Animal not added");
                }
            }
        }

        /// <summary>
        /// When an individual animal is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxFoodSchedule.Items.Clear(); // clear listbox

            var indices = lvAnimals.SelectedIndices;

            if (indices.Count == 1) // if only one animal is selected
            {
                var index = indices[0];

                bool indexOK = animalManagerObj.ValidateIndex(index); // validate index

                if (indexOK)
                {
                    IAnimal animal = animalManagerObj.GetAnimal(index); // get animal from Animal Manager
                    tbxEaterType.Text = animal.GetEaterType().ToString(); // display eater type in form

                    List<string> feedDescriptionList = animal.GetFoodSchedule(); // get food description list from Animal
                    lbxFoodSchedule.Items.AddRange(feedDescriptionList.ToArray()); // display food items 
                }
            }
        }
        
        /// <summary>
        /// delete animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            var indices = lvAnimals.SelectedIndices;

            if (indices.Count == 1) // if only one animal is selected
            {
                var index = indices[0];

                bool indexOK = animalManagerObj.ValidateIndex(index); // validate index

                if (indexOK)
                {
                    animalManagerObj.RemoveItem(index);
                    UpdateAnimalList(); //display animal in Animal list
                    InitializeGui(); //clear form
                }
            }
        }

        #region animal sort event handlers
        /// <summary>
        /// Sort animals based on species
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortSpecies_Click(object sender, EventArgs e)
        {
            animalManagerObj.Sort(new CompareBySpecies());
            UpdateAnimalList();
        }

        /// <summary>
        /// Sort animals based on ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnID_Click(object sender, EventArgs e)
        {
            animalManagerObj.Sort(new CompareByID());
            UpdateAnimalList();
        }

        /// <summary>
        /// Sort animals based on name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortName_Click(object sender, EventArgs e)
        {
            animalManagerObj.Sort(new CompareByName());
            UpdateAnimalList();
        }
        #endregion

        /// <summary>
        /// Create example animals to enable testing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPop_Click(object sender, EventArgs e)
        {
            var someAnimals = AnimalMaker.makeSomeAnimals(); //make example
            foreach (var animal in someAnimals)
                animalManagerObj.AddAnimal(animal);
            UpdateAnimalList(); //display animal in Animal list
        }
        #endregion

        #region Compare classes to support sort
        /// <summary>
        /// Compare animals by species.
        /// </summary>
        private class CompareBySpecies : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                return (string.CompareOrdinal(a1.Species, a2.Species));
            }
        }
        /// <summary>
        /// Compare animals by ID
        /// </summary>
        private class CompareByID : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                return (a1.AnimalID.CompareTo(a2.AnimalID));
            }
        }
        /// <summary>
        /// Compare animals by name.
        /// </summary>
        private class CompareByName : IComparer<IAnimal>
        {
            public int Compare(IAnimal animal1, IAnimal animal2)
            {
                var a1 = animal1;
                var a2 = animal2;
                return (string.CompareOrdinal(a1.Name, a2.Name));
            }
        }

        #endregion

        #region recipes and staff event handlers
        /// <summary>
        /// When button Recipes is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecipes_Click(object sender, EventArgs e)
        {
            //create an instance of Recipeform
            RecipeForm recipeFormObj = new RecipeForm();
            recipeFormObj.RecipeManager = recipeManagerObj; //give recipeFormObj access to recipeManagerObj
            DialogResult dialogResult = recipeFormObj.ShowDialog();
        }

        /// <summary>
        /// when button Staff is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStaff_Click(object sender, EventArgs e)
        {
            //create an instance of StaffForm
            StaffForm staffFormObj = new StaffForm();
            staffFormObj.StaffList = staffListObj; //give recipeFormObj access to recipeManagerObj

            DialogResult dialogResult = staffFormObj.ShowDialog();

        }
        #endregion

        #region file handling
        /// <summary>
        /// initialize the animal part of the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileNew_Click(object sender, EventArgs e)
        {

            DialogResult result = DialogResult.OK;
            if (animalListChangedButNotSaved)
            {
                //ask if it is ok that unsavedanimal list will be lost
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                result = MessageBox.Show("Current animal list has not been saved and will be lost?",
                    "Confirmation", buttons);
            }

            if (result == DialogResult.OK)
            {
                InitializeGui();
                lvAnimals.Items.Clear();
                animalManagerObj.ClearList();
                animalListChangedButNotSaved = false;
            }
        }

        /// <summary>
        /// open file to display saved animal list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                binFileName = openFileDialog1.FileName;
                ReadBinaryFile();
                UpdateAnimalList();
            }
        }

        /// <summary>
        /// save file if no file have been saved else call method to save new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(binFileName))
            {
                mnuFileSaveAs_Click(sender, e);
            }
            else
                SaveToBinaryFile();
        }

        /// <summary>
        /// save new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                binFileName = saveFileDialog1.FileName;
                SaveToBinaryFile();
            }
        }

        /// <summary>
        /// save the animal list to file
        /// </summary>
        private void SaveToBinaryFile()
        {
            string message = "";

            try
            {
               animalManagerObj.BinarySerialize(binFileName);
               animalListChangedButNotSaved = false; //animal list has been saved
            }
            catch (Exception e)
            {
                message = e.Message; //error message
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message); //write error message
            }
        }

        /// <summary>
        /// Read the animal list from a binary file.
        /// </summary>
        private void ReadBinaryFile()
        {
            string message = "";

            try
            {
                animalManagerObj.BinaryDeSerialize(binFileName);
            }
            catch (Exception e)
            {
                message = e.Message; //error message
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message); //write error message
            }
        }
        #endregion
    }
}
