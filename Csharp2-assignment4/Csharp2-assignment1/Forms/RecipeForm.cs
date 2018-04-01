/// RecipeForm.cs
/// Ann-Marie Bergström  ai2436 2018

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
    public partial class RecipeForm : Form
    {
        #region fields
        Recipe recipeObj = new Recipe(); //declare and create recipeObj as type Recipe
        RecipeManager recipeManagerObj; //declare received recipeManagerObj
        #endregion

        /// <summary>
        /// default constructor
        /// </summary>
        public RecipeForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// property for access to recipeManagerObj
        /// </summary>
        public RecipeManager RecipeManager
        {
            get => recipeManagerObj;
            set
            {
                recipeManagerObj = value; //value = recipeManagerObj from Mainform
                UpdateRecipeList(); // display recipe list if there is one 
            }
        }

        #region user interface methods
        /// <summary>
        /// initialize user interface
        /// </summary>
        private void InitializeGui()
        {
            tbxRecipeName.Clear(); // clear textbox    
            lstIngredients.Items.Clear(); // clear ingredients list
            lbxRecipes.Items.Clear(); // clear recipe list
            toolTipIngredient.SetToolTip(tbxIngredient, "Example: 2 dl of milk"); //set tool tip at ingredients textbox
        }

        /// <summary>
        /// update GUI ingredients list
        /// </summary>
        private void UpdateIngredientsList()
        {
            lstIngredients.Items.Clear(); //clear ingredients list before writing new list
            lstIngredients.Items.AddRange(recipeObj.ToStringArray()); //write ingredients list

            tbxIngredient.Clear(); // Clear ingredient textbox to enable new input
            tbxIngredient.Focus(); //cursor back to ingredient textbox
        }

        /// <summary>
        /// Update GUI recipe list
        /// </summary>
        private void UpdateRecipeList()
        {
            lbxRecipes.Items.Clear();
            lbxRecipes.Items.AddRange(recipeManagerObj.ToStringArray());
        }
        #endregion

        #region button methods
        /// <summary>
        /// Add ingredient to recipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIngredient.Text))
            {
                MessageBox.Show("No ingredient!");
                return;
            }
            recipeObj.AddIngredient(tbxIngredient.Text.Trim());
            UpdateIngredientsList();
        }

        /// <summary>
        /// Enter key instead of click Add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxIngredient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAddIngr_Click(sender, e);
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// select from list, get ingredient and display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;// index of selected ingredient
            tbxIngredient.Text = recipeObj.GetIngredientAt(index); // write ingredient to textbox
        }

        /// <summary>
        /// update ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditIngr_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;// index of selected ingredient
            recipeObj.ChangeIngredientAt(index, tbxIngredient.Text.Trim());
            UpdateIngredientsList();
        }

        /// <summary>
        /// delete ingredient at selected index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteIngr_Click(object sender, EventArgs e)
        {
            int index = lstIngredients.SelectedIndex;// index of selected ingredient
            recipeObj.DeleteIngredientAt(index);
            UpdateIngredientsList();
        }

        /// <summary>
        /// Add recipe to recipe list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxRecipeName.Text))
            {
                MessageBox.Show("No name!");
                return;
            }
            recipeObj.RecipeName = tbxRecipeName.Text.Trim();
            recipeManagerObj.AddItem(recipeObj);
            InitializeGui();
            UpdateRecipeList();
            recipeObj = new Recipe(); //create new recipeObj as type Recipe

        }
        #endregion

    }
}
