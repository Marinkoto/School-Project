
namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbBoxDogSelect = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblBreedId = new System.Windows.Forms.Label();
            this.cmbBoxBreeds = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxOutput.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 26;
            this.listBoxOutput.Location = new System.Drawing.Point(407, 86);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(227, 186);
            this.listBoxOutput.TabIndex = 6;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(261, 130);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(261, 177);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(261, 224);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbBoxDogSelect
            // 
            this.cmbBoxDogSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxDogSelect.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxDogSelect.FormattingEnabled = true;
            this.cmbBoxDogSelect.Location = new System.Drawing.Point(245, 82);
            this.cmbBoxDogSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxDogSelect.Name = "cmbBoxDogSelect";
            this.cmbBoxDogSelect.Size = new System.Drawing.Size(145, 34);
            this.cmbBoxDogSelect.TabIndex = 10;
            this.cmbBoxDogSelect.SelectedIndexChanged += new System.EventHandler(this.cmbBoxDogSelect_SelectedIndexChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(45, 82);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 26);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Номер";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnimalName.Location = new System.Drawing.Point(45, 122);
            this.lblAnimalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(47, 26);
            this.lblAnimalName.TabIndex = 1;
            this.lblAnimalName.Text = "Име";
            this.lblAnimalName.Click += new System.EventHandler(this.lblAnimalName_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(23, 154);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 26);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.Location = new System.Drawing.Point(45, 192);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(66, 26);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Години";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxId.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxId.Location = new System.Drawing.Point(119, 74);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(119, 34);
            this.txtBoxId.TabIndex = 11;
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxName.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxName.Location = new System.Drawing.Point(119, 112);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(119, 34);
            this.txtBoxName.TabIndex = 12;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDescription.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxDescription.Location = new System.Drawing.Point(119, 149);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(119, 34);
            this.txtBoxDescription.TabIndex = 13;
            this.txtBoxDescription.TextChanged += new System.EventHandler(this.txtBoxDescription_TextChanged);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxAge.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxAge.Location = new System.Drawing.Point(119, 189);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(119, 34);
            this.txtBoxAge.TabIndex = 14;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.txtBoxAge_TextChanged);
            // 
            // lblBreedId
            // 
            this.lblBreedId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBreedId.AutoSize = true;
            this.lblBreedId.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBreedId.Location = new System.Drawing.Point(49, 232);
            this.lblBreedId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreedId.Name = "lblBreedId";
            this.lblBreedId.Size = new System.Drawing.Size(63, 26);
            this.lblBreedId.TabIndex = 17;
            this.lblBreedId.Text = "Breed ";
            this.lblBreedId.Click += new System.EventHandler(this.lblBreedId_Click);
            // 
            // cmbBoxBreeds
            // 
            this.cmbBoxBreeds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBoxBreeds.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbBoxBreeds.FormattingEnabled = true;
            this.cmbBoxBreeds.Location = new System.Drawing.Point(119, 227);
            this.cmbBoxBreeds.Name = "cmbBoxBreeds";
            this.cmbBoxBreeds.Size = new System.Drawing.Size(119, 34);
            this.cmbBoxBreeds.TabIndex = 18;
            this.cmbBoxBreeds.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBreeds_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(108, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 65);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Приют за животни ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(650, 345);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbBoxBreeds);
            this.Controls.Add(this.lblBreedId);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.cmbBoxDogSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.lblNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Приют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbBoxDogSelect;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblBreedId;
        private System.Windows.Forms.ComboBox cmbBoxBreeds;
        private System.Windows.Forms.Label lblTitle;
    }
}

