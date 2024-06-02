﻿namespace CookBook.UI
{
    partial class RecipeIngredientsForm
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
            label1 = new Label();
            label2 = new Label();
            AllIngredientsLbx = new ListBox();
            RecipeIngredientsLbx = new ListBox();
            AddIngredientBtn = new Button();
            RemoveIngredientBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 31);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "All ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 31);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 1;
            label2.Text = "Recipe ingredients";
            // 
            // AllIngredientsLbx
            // 
            AllIngredientsLbx.FormattingEnabled = true;
            AllIngredientsLbx.ItemHeight = 30;
            AllIngredientsLbx.Location = new Point(30, 79);
            AllIngredientsLbx.Name = "AllIngredientsLbx";
            AllIngredientsLbx.Size = new Size(274, 334);
            AllIngredientsLbx.TabIndex = 2;
            // 
            // RecipeIngredientsLbx
            // 
            RecipeIngredientsLbx.FormattingEnabled = true;
            RecipeIngredientsLbx.ItemHeight = 30;
            RecipeIngredientsLbx.Location = new Point(343, 79);
            RecipeIngredientsLbx.Name = "RecipeIngredientsLbx";
            RecipeIngredientsLbx.Size = new Size(269, 334);
            RecipeIngredientsLbx.TabIndex = 3;
            // 
            // AddIngredientBtn
            // 
            AddIngredientBtn.Location = new Point(30, 431);
            AddIngredientBtn.Name = "AddIngredientBtn";
            AddIngredientBtn.Size = new Size(274, 48);
            AddIngredientBtn.TabIndex = 4;
            AddIngredientBtn.Text = "Add ingredient";
            AddIngredientBtn.UseVisualStyleBackColor = true;
            AddIngredientBtn.Click += AddIngredientBtn_Click;
            // 
            // RemoveIngredientBtn
            // 
            RemoveIngredientBtn.Location = new Point(343, 431);
            RemoveIngredientBtn.Name = "RemoveIngredientBtn";
            RemoveIngredientBtn.Size = new Size(269, 48);
            RemoveIngredientBtn.TabIndex = 5;
            RemoveIngredientBtn.Text = "Remove ingredient";
            RemoveIngredientBtn.UseVisualStyleBackColor = true;
            RemoveIngredientBtn.Click += RemoveIngredientBtn_Click;
            // 
            // RecipeIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 512);
            Controls.Add(RemoveIngredientBtn);
            Controls.Add(AddIngredientBtn);
            Controls.Add(RecipeIngredientsLbx);
            Controls.Add(AllIngredientsLbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipeIngredientsForm";
            Text = "RecipeIngredientsForm";
            Load += RecipeIngredientsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox AllIngredientsLbx;
        private ListBox RecipeIngredientsLbx;
        private Button AddIngredientBtn;
        private Button RemoveIngredientBtn;
    }
}