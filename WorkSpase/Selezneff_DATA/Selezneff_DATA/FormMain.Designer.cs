namespace Selezneff_DATA
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProgramInfo = new System.Windows.Forms.Button();
            this.buttonTeam = new System.Windows.Forms.Button();
            this.buttonStarship = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlProgramInfo1 = new Selezneff_DATA.UseControlMain.UserControlProgramInfo();
            this.userControlTeam1 = new Selezneff_DATA.UseControl.UserControlTeam();
            this.userControlStarship1 = new Selezneff_DATA.UseControl.UserControlStarship();
            this.userControlShop1 = new Selezneff_DATA.pr();
            this.userControlProfile1 = new Selezneff_DATA.UserControlProfile();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.buttonProgramInfo);
            this.panel1.Controls.Add(this.buttonTeam);
            this.panel1.Controls.Add(this.buttonStarship);
            this.panel1.Controls.Add(this.buttonShop);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 478);
            this.panel1.TabIndex = 2;
            // 
            // buttonProgramInfo
            // 
            this.buttonProgramInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProgramInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonProgramInfo.FlatAppearance.BorderSize = 0;
            this.buttonProgramInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgramInfo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProgramInfo.Location = new System.Drawing.Point(0, 435);
            this.buttonProgramInfo.Name = "buttonProgramInfo";
            this.buttonProgramInfo.Size = new System.Drawing.Size(209, 31);
            this.buttonProgramInfo.TabIndex = 8;
            this.buttonProgramInfo.Text = "О программе";
            this.buttonProgramInfo.UseVisualStyleBackColor = false;
            this.buttonProgramInfo.Click += new System.EventHandler(this.buttonProgramInfo_Click);
            // 
            // buttonTeam
            // 
            this.buttonTeam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonTeam.FlatAppearance.BorderSize = 0;
            this.buttonTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeam.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeam.Location = new System.Drawing.Point(0, 186);
            this.buttonTeam.Name = "buttonTeam";
            this.buttonTeam.Size = new System.Drawing.Size(209, 31);
            this.buttonTeam.TabIndex = 7;
            this.buttonTeam.Text = "Команда";
            this.buttonTeam.UseVisualStyleBackColor = false;
            this.buttonTeam.Click += new System.EventHandler(this.buttonTeam_Click);
            // 
            // buttonStarship
            // 
            this.buttonStarship.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStarship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonStarship.FlatAppearance.BorderSize = 0;
            this.buttonStarship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStarship.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStarship.Location = new System.Drawing.Point(0, 149);
            this.buttonStarship.Name = "buttonStarship";
            this.buttonStarship.Size = new System.Drawing.Size(209, 31);
            this.buttonStarship.TabIndex = 6;
            this.buttonStarship.Text = "Корабль";
            this.buttonStarship.UseVisualStyleBackColor = false;
            this.buttonStarship.Click += new System.EventHandler(this.buttonStarship_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonShop.FlatAppearance.BorderSize = 0;
            this.buttonShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShop.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShop.Location = new System.Drawing.Point(0, 112);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(209, 31);
            this.buttonShop.TabIndex = 5;
            this.buttonShop.Text = "Магазин";
            this.buttonShop.UseVisualStyleBackColor = false;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfile.Location = new System.Drawing.Point(0, 75);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(209, 31);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.userControlProgramInfo1);
            this.panel2.Controls.Add(this.userControlTeam1);
            this.panel2.Controls.Add(this.userControlStarship1);
            this.panel2.Controls.Add(this.userControlShop1);
            this.panel2.Controls.Add(this.userControlProfile1);
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 478);
            this.panel2.TabIndex = 3;
            // 
            // userControlProgramInfo1
            // 
            this.userControlProgramInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlProgramInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.userControlProgramInfo1.Location = new System.Drawing.Point(0, 0);
            this.userControlProgramInfo1.Name = "userControlProgramInfo1";
            this.userControlProgramInfo1.Size = new System.Drawing.Size(667, 478);
            this.userControlProgramInfo1.TabIndex = 4;
            // 
            // userControlTeam1
            // 
            this.userControlTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.userControlTeam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTeam1.Location = new System.Drawing.Point(0, 0);
            this.userControlTeam1.Name = "userControlTeam1";
            this.userControlTeam1.Size = new System.Drawing.Size(667, 478);
            this.userControlTeam1.TabIndex = 3;
            // 
            // userControlStarship1
            // 
            this.userControlStarship1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.userControlStarship1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStarship1.Location = new System.Drawing.Point(0, 0);
            this.userControlStarship1.Name = "userControlStarship1";
            this.userControlStarship1.Size = new System.Drawing.Size(667, 478);
            this.userControlStarship1.TabIndex = 2;
            // 
            // userControlShop1
            // 
            this.userControlShop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.userControlShop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlShop1.Location = new System.Drawing.Point(0, 0);
            this.userControlShop1.Name = "userControlShop1";
            this.userControlShop1.Size = new System.Drawing.Size(667, 478);
            this.userControlShop1.TabIndex = 1;
            // 
            // userControlProfile1
            // 
            this.userControlProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.userControlProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlProfile1.Location = new System.Drawing.Point(0, 0);
            this.userControlProfile1.Name = "userControlProfile1";
            this.userControlProfile1.Size = new System.Drawing.Size(667, 478);
            this.userControlProfile1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(877, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бортовой журнал";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Panel panel2;
        private pr userControlShop1;
        private UserControlProfile userControlProfile1;
        private System.Windows.Forms.Button buttonTeam;
        private System.Windows.Forms.Button buttonStarship;
        private UseControl.UserControlStarship userControlStarship1;
        private UseControl.UserControlTeam userControlTeam1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProgramInfo;
        private UseControlMain.UserControlProgramInfo userControlProgramInfo1;
    }
}