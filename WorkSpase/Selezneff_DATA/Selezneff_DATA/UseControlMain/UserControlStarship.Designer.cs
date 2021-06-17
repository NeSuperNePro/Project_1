namespace Selezneff_DATA.UseControl
{
    partial class UserControlStarship
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStarshipModule = new System.Windows.Forms.Button();
            this.userControlStarshipModule1 = new Selezneff_DATA.UseControlMain.UserControlStarshipModule();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Корабль";
            // 
            // buttonStarshipModule
            // 
            this.buttonStarshipModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStarshipModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonStarshipModule.FlatAppearance.BorderSize = 0;
            this.buttonStarshipModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStarshipModule.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStarshipModule.Location = new System.Drawing.Point(570, 444);
            this.buttonStarshipModule.Name = "buttonStarshipModule";
            this.buttonStarshipModule.Size = new System.Drawing.Size(95, 31);
            this.buttonStarshipModule.TabIndex = 8;
            this.buttonStarshipModule.Text = "Модули";
            this.buttonStarshipModule.UseVisualStyleBackColor = false;
            this.buttonStarshipModule.Click += new System.EventHandler(this.buttonStarshipModule_Click);
            // 
            // userControlStarshipModule1
            // 
            this.userControlStarshipModule1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.userControlStarshipModule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStarshipModule1.Location = new System.Drawing.Point(0, 0);
            this.userControlStarshipModule1.Name = "userControlStarshipModule1";
            this.userControlStarshipModule1.Size = new System.Drawing.Size(668, 478);
            this.userControlStarshipModule1.TabIndex = 9;
            this.userControlStarshipModule1.Load += new System.EventHandler(this.userControlStarshipModule1_Load);
            // 
            // UserControlStarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.userControlStarshipModule1);
            this.Controls.Add(this.buttonStarshipModule);
            this.Controls.Add(this.label1);
            this.Name = "UserControlStarship";
            this.Size = new System.Drawing.Size(668, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStarshipModule;
        private UseControlMain.UserControlStarshipModule userControlStarshipModule1;
    }
}
