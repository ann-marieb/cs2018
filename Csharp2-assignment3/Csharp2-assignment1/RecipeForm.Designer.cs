namespace Csharp2_assignment
{
    partial class RecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.tbxRecipeName = new System.Windows.Forms.TextBox();
            this.gbxIngredients = new System.Windows.Forms.GroupBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnDeleteIngr = new System.Windows.Forms.Button();
            this.btnEditIngr = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.tbxIngredient = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.btnCloseRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.toolTipIngredient = new System.Windows.Forms.ToolTip(this.components);
            this.lbxRecipes = new System.Windows.Forms.ListBox();
            this.gbxIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(39, 25);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(91, 17);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe name";
            // 
            // tbxRecipeName
            // 
            this.tbxRecipeName.Location = new System.Drawing.Point(159, 28);
            this.tbxRecipeName.Name = "tbxRecipeName";
            this.tbxRecipeName.Size = new System.Drawing.Size(428, 22);
            this.tbxRecipeName.TabIndex = 1;
            // 
            // gbxIngredients
            // 
            this.gbxIngredients.Controls.Add(this.lstIngredients);
            this.gbxIngredients.Controls.Add(this.btnDeleteIngr);
            this.gbxIngredients.Controls.Add(this.btnEditIngr);
            this.gbxIngredients.Controls.Add(this.btnAddIngr);
            this.gbxIngredients.Controls.Add(this.tbxIngredient);
            this.gbxIngredients.Controls.Add(this.lblIngredient);
            this.gbxIngredients.Location = new System.Drawing.Point(47, 77);
            this.gbxIngredients.Name = "gbxIngredients";
            this.gbxIngredients.Size = new System.Drawing.Size(539, 253);
            this.gbxIngredients.TabIndex = 2;
            this.gbxIngredients.TabStop = false;
            this.gbxIngredients.Text = "Ingredients list";
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 16;
            this.lstIngredients.Location = new System.Drawing.Point(153, 88);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(347, 148);
            this.lstIngredients.TabIndex = 13;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // btnDeleteIngr
            // 
            this.btnDeleteIngr.Location = new System.Drawing.Point(29, 201);
            this.btnDeleteIngr.Name = "btnDeleteIngr";
            this.btnDeleteIngr.Size = new System.Drawing.Size(81, 33);
            this.btnDeleteIngr.TabIndex = 12;
            this.btnDeleteIngr.Text = "Delete";
            this.btnDeleteIngr.UseVisualStyleBackColor = true;
            this.btnDeleteIngr.Click += new System.EventHandler(this.btnDeleteIngr_Click);
            // 
            // btnEditIngr
            // 
            this.btnEditIngr.Location = new System.Drawing.Point(29, 145);
            this.btnEditIngr.Name = "btnEditIngr";
            this.btnEditIngr.Size = new System.Drawing.Size(81, 33);
            this.btnEditIngr.TabIndex = 11;
            this.btnEditIngr.Text = "Update";
            this.btnEditIngr.UseVisualStyleBackColor = true;
            this.btnEditIngr.Click += new System.EventHandler(this.btnEditIngr_Click);
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.Location = new System.Drawing.Point(29, 89);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.Size = new System.Drawing.Size(81, 33);
            this.btnAddIngr.TabIndex = 2;
            this.btnAddIngr.Text = "Add";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // tbxIngredient
            // 
            this.tbxIngredient.Location = new System.Drawing.Point(146, 38);
            this.tbxIngredient.Name = "tbxIngredient";
            this.tbxIngredient.Size = new System.Drawing.Size(355, 22);
            this.tbxIngredient.TabIndex = 1;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(26, 41);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(71, 17);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Ingredient";
            // 
            // btnCloseRecipe
            // 
            this.btnCloseRecipe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseRecipe.Location = new System.Drawing.Point(244, 345);
            this.btnCloseRecipe.Name = "btnCloseRecipe";
            this.btnCloseRecipe.Size = new System.Drawing.Size(157, 43);
            this.btnCloseRecipe.TabIndex = 8;
            this.btnCloseRecipe.Text = "Close";
            this.btnCloseRecipe.UseVisualStyleBackColor = true;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(76, 345);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(157, 43);
            this.btnAddRecipe.TabIndex = 7;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lbxRecipes
            // 
            this.lbxRecipes.FormattingEnabled = true;
            this.lbxRecipes.ItemHeight = 16;
            this.lbxRecipes.Location = new System.Drawing.Point(615, 32);
            this.lbxRecipes.Name = "lbxRecipes";
            this.lbxRecipes.Size = new System.Drawing.Size(511, 340);
            this.lbxRecipes.TabIndex = 9;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 414);
            this.Controls.Add(this.lbxRecipes);
            this.Controls.Add(this.btnCloseRecipe);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.gbxIngredients);
            this.Controls.Add(this.tbxRecipeName);
            this.Controls.Add(this.lblRecipeName);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            this.gbxIngredients.ResumeLayout(false);
            this.gbxIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox tbxRecipeName;
        private System.Windows.Forms.GroupBox gbxIngredients;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnDeleteIngr;
        private System.Windows.Forms.Button btnEditIngr;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.TextBox tbxIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Button btnCloseRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.ToolTip toolTipIngredient;
        private System.Windows.Forms.ListBox lbxRecipes;
    }
}