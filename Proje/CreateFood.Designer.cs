﻿namespace Proje
{
    partial class CreateFood
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
            this.txtFat = new System.Windows.Forms.TextBox();
            this.txtProt = new System.Windows.Forms.TextBox();
            this.txtCarbonh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddCategoryy = new FontAwesome.Sharp.IconButton();
            this.btnRemoveCategoryy = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFat
            // 
            this.txtFat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtFat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFat.Location = new System.Drawing.Point(221, 137);
            this.txtFat.Name = "txtFat";
            this.txtFat.Size = new System.Drawing.Size(121, 16);
            this.txtFat.TabIndex = 13;
            // 
            // txtProt
            // 
            this.txtProt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtProt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProt.Location = new System.Drawing.Point(221, 108);
            this.txtProt.Name = "txtProt";
            this.txtProt.Size = new System.Drawing.Size(121, 16);
            this.txtProt.TabIndex = 14;
            // 
            // txtCarbonh
            // 
            this.txtCarbonh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtCarbonh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarbonh.Location = new System.Drawing.Point(221, 79);
            this.txtCarbonh.Name = "txtCarbonh";
            this.txtCarbonh.Size = new System.Drawing.Size(121, 16);
            this.txtCarbonh.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(149, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fat:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFoodName.Location = new System.Drawing.Point(221, 49);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(121, 16);
            this.txtFoodName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(119, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Protein:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carbonhydrate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(84, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Food Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(111, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calories:";
            // 
            // txtCal
            // 
            this.txtCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.txtCal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCal.Location = new System.Drawing.Point(221, 166);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(121, 16);
            this.txtCal.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Create Food";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(70, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Please enter values ​​per 100 grams!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label7.Location = new System.Drawing.Point(104, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(117)))), ((int)(((byte)(132)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(221, 195);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 23);
            this.cmbCategory.TabIndex = 19;
            // 
            // dgvFood
            // 
            this.dgvFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(365, 49);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowTemplate.Height = 25;
            this.dgvFood.Size = new System.Drawing.Size(412, 169);
            this.dgvFood.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(638, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 30);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Selected Food";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCategoryy
            // 
            this.btnAddCategoryy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnAddCategoryy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategoryy.FlatAppearance.BorderSize = 0;
            this.btnAddCategoryy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoryy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategoryy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAddCategoryy.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddCategoryy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnAddCategoryy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategoryy.IconSize = 32;
            this.btnAddCategoryy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategoryy.Location = new System.Drawing.Point(109, 225);
            this.btnAddCategoryy.Name = "btnAddCategoryy";
            this.btnAddCategoryy.Size = new System.Drawing.Size(245, 34);
            this.btnAddCategoryy.TabIndex = 24;
            this.btnAddCategoryy.Text = "       Add Food Into Database";
            this.btnAddCategoryy.UseVisualStyleBackColor = false;
            // 
            // btnRemoveCategoryy
            // 
            this.btnRemoveCategoryy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnRemoveCategoryy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCategoryy.FlatAppearance.BorderSize = 0;
            this.btnRemoveCategoryy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategoryy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCategoryy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnRemoveCategoryy.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.btnRemoveCategoryy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btnRemoveCategoryy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveCategoryy.IconSize = 32;
            this.btnRemoveCategoryy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCategoryy.Location = new System.Drawing.Point(500, 224);
            this.btnRemoveCategoryy.Name = "btnRemoveCategoryy";
            this.btnRemoveCategoryy.Size = new System.Drawing.Size(277, 34);
            this.btnRemoveCategoryy.TabIndex = 23;
            this.btnRemoveCategoryy.Text = "      Remove Food From Database";
            this.btnRemoveCategoryy.UseVisualStyleBackColor = false;
            // 
            // CreateFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(789, 307);
            this.Controls.Add(this.btnAddCategoryy);
            this.Controls.Add(this.btnRemoveCategoryy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtFat);
            this.Controls.Add(this.txtProt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCarbonh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateFood";
            this.Text = "CreateFood";
            this.Load += new System.EventHandler(this.CreateFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtFat;
        private TextBox txtProt;
        private TextBox txtCarbonh;
        private Label label4;
        private TextBox txtFoodName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtCal;
        private Button button1;
        private Label label6;
        private Label label7;
        private ComboBox cmbCategory;
        private DataGridView dgvFood;
        private Button btnDelete;
        private FontAwesome.Sharp.IconButton btnAddCategoryy;
        private FontAwesome.Sharp.IconButton btnRemoveCategoryy;
    }
}