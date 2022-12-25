namespace kurtadam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbBranş = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Irk :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Branş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silah :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(226, 63);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(226, 158);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(139, 20);
            this.txtWeapon.TabIndex = 1;
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(226, 95);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(139, 21);
            this.cmbRace.TabIndex = 2;
            // 
            // cmbBranş
            // 
            this.cmbBranş.FormattingEnabled = true;
            this.cmbBranş.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assasin"});
            this.cmbBranş.Location = new System.Drawing.Point(226, 131);
            this.cmbBranş.Name = "cmbBranş";
            this.cmbBranş.Size = new System.Drawing.Size(139, 21);
            this.cmbBranş.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(434, 103);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 36);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Red;
            this.lblHealth.Location = new System.Drawing.Point(679, 267);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(300, 32);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(165, 249);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(158, 49);
            this.btnAttack.TabIndex = 5;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 528);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbBranş);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cmbBranş;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
    }
}

