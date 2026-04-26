namespace HomeAffairsIdentityProcessor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picHomeAffairs = new PictureBox();
            lblHeader = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            cmbCitizen = new ComboBox();
            btnValidate = new Button();
            lblValidConfirmation = new Label();
            btnGenerate = new Button();
            txtProfile = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picHomeAffairs).BeginInit();
            SuspendLayout();
            // 
            // picHomeAffairs
            // 
            picHomeAffairs.Image = (Image)resources.GetObject("picHomeAffairs.Image");
            picHomeAffairs.InitialImage = (Image)resources.GetObject("picHomeAffairs.InitialImage");
            picHomeAffairs.Location = new Point(12, 12);
            picHomeAffairs.Name = "picHomeAffairs";
            picHomeAffairs.Size = new Size(419, 501);
            picHomeAffairs.SizeMode = PictureBoxSizeMode.Zoom;
            picHomeAffairs.TabIndex = 0;
            picHomeAffairs.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.ForestGreen;
            lblHeader.Location = new Point(470, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(397, 30);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Home Affairs Digital Identity Processor";
            lblHeader.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 75);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 2;
            label2.Text = "Enter your Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(454, 114);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 3;
            label3.Text = "Enter your ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(454, 147);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 4;
            label4.Text = "Choose your Citizen:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(665, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(263, 25);
            txtName.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(665, 110);
            txtId.Name = "txtId";
            txtId.Size = new Size(263, 25);
            txtId.TabIndex = 6;
            // 
            // cmbCitizen
            // 
            cmbCitizen.FormattingEnabled = true;
            cmbCitizen.Location = new Point(665, 147);
            cmbCitizen.Name = "cmbCitizen";
            cmbCitizen.Size = new Size(263, 23);
            cmbCitizen.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.Green;
            btnValidate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.Location = new Point(743, 205);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(124, 32);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblValidConfirmation
            // 
            lblValidConfirmation.AutoSize = true;
            lblValidConfirmation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValidConfirmation.Location = new Point(665, 272);
            lblValidConfirmation.Name = "lblValidConfirmation";
            lblValidConfirmation.Size = new Size(102, 21);
            lblValidConfirmation.TabIndex = 9;
            lblValidConfirmation.Text = "Valid Id Label";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Green;
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(743, 482);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(124, 31);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtProfile
            // 
            txtProfile.Location = new Point(665, 308);
            txtProfile.Multiline = true;
            txtProfile.Name = "txtProfile";
            txtProfile.Size = new Size(283, 168);
            txtProfile.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1046, 539);
            Controls.Add(txtProfile);
            Controls.Add(btnGenerate);
            Controls.Add(lblValidConfirmation);
            Controls.Add(btnValidate);
            Controls.Add(cmbCitizen);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblHeader);
            Controls.Add(picHomeAffairs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picHomeAffairs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHomeAffairs;
        private Label lblHeader;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtId;
        private ComboBox cmbCitizen;
        private Button btnValidate;
        private Label lblValidConfirmation;
        private Button btnGenerate;
        private TextBox txtProfile;
    }
}
