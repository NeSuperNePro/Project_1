namespace Selezneff_DATA.UseControlMain
{
    partial class UserControlStarshipModule
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.labelLVL = new System.Windows.Forms.Label();
            this.comboBoxLVL = new System.Windows.Forms.ComboBox();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.labelInfoTime = new System.Windows.Forms.Label();
            this.labelErrorMission = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.panelMonitor = new System.Windows.Forms.Panel();
            this.panelMonitorStarshipModule = new System.Windows.Forms.Panel();
            this.labelRepairCosts = new System.Windows.Forms.Label();
            this.labelStateModule = new System.Windows.Forms.Label();
            this.labelErrorModule = new System.Windows.Forms.Label();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.labelMonitorStarshipModule = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRepair = new System.Windows.Forms.Button();
            this.labelMissionCompletionTime = new System.Windows.Forms.Label();
            this.labelMissionResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMonitor.SuspendLayout();
            this.panelMonitorStarshipModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исследовательские модули";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(633, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 31);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(18, 121);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(114, 23);
            this.labelSpeed.TabIndex = 9;
            this.labelSpeed.Text = "Скорость :";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDistance.ForeColor = System.Drawing.Color.White;
            this.labelDistance.Location = new System.Drawing.Point(3, 154);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(129, 23);
            this.labelDistance.TabIndex = 10;
            this.labelDistance.Text = "Дистанция :";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.textBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSpeed.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSpeed.ForeColor = System.Drawing.Color.White;
            this.textBoxSpeed.Location = new System.Drawing.Point(138, 119);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(108, 27);
            this.textBoxSpeed.TabIndex = 11;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.textBoxDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDistance.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDistance.ForeColor = System.Drawing.Color.White;
            this.textBoxDistance.Location = new System.Drawing.Point(138, 152);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(108, 27);
            this.textBoxDistance.TabIndex = 12;
            // 
            // labelLVL
            // 
            this.labelLVL.AutoSize = true;
            this.labelLVL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelLVL.ForeColor = System.Drawing.Color.White;
            this.labelLVL.Location = new System.Drawing.Point(26, 82);
            this.labelLVL.Name = "labelLVL";
            this.labelLVL.Size = new System.Drawing.Size(106, 23);
            this.labelLVL.TabIndex = 13;
            this.labelLVL.Text = "Уровень :";
            // 
            // comboBoxLVL
            // 
            this.comboBoxLVL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.comboBoxLVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLVL.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxLVL.ForeColor = System.Drawing.Color.White;
            this.comboBoxLVL.FormattingEnabled = true;
            this.comboBoxLVL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLVL.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxLVL.Location = new System.Drawing.Point(138, 77);
            this.comboBoxLVL.Name = "comboBoxLVL";
            this.comboBoxLVL.Size = new System.Drawing.Size(108, 35);
            this.comboBoxLVL.TabIndex = 14;
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonCalculation.FlatAppearance.BorderSize = 0;
            this.buttonCalculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculation.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculation.Location = new System.Drawing.Point(138, 194);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(108, 31);
            this.buttonCalculation.TabIndex = 15;
            this.buttonCalculation.Text = "РАСЧЕТ";
            this.buttonCalculation.UseVisualStyleBackColor = false;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelInfoTime
            // 
            this.labelInfoTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInfoTime.AutoSize = true;
            this.labelInfoTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelInfoTime.Location = new System.Drawing.Point(3, 9);
            this.labelInfoTime.Name = "labelInfoTime";
            this.labelInfoTime.Size = new System.Drawing.Size(239, 16);
            this.labelInfoTime.TabIndex = 16;
            this.labelInfoTime.Text = "Время затраченное на полет :  ---";
            // 
            // labelErrorMission
            // 
            this.labelErrorMission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelErrorMission.AutoSize = true;
            this.labelErrorMission.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorMission.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelErrorMission.Location = new System.Drawing.Point(3, 82);
            this.labelErrorMission.Name = "labelErrorMission";
            this.labelErrorMission.Size = new System.Drawing.Size(142, 16);
            this.labelErrorMission.TabIndex = 17;
            this.labelErrorMission.Text = "Ошибки миссии :  ---";
            // 
            // labelFuel
            // 
            this.labelFuel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuel.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelFuel.Location = new System.Drawing.Point(3, 48);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(149, 16);
            this.labelFuel.TabIndex = 18;
            this.labelFuel.Text = "Расход топлива :  ---";
            // 
            // panelMonitor
            // 
            this.panelMonitor.BackColor = System.Drawing.Color.Black;
            this.panelMonitor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMonitor.Controls.Add(this.labelFuel);
            this.panelMonitor.Controls.Add(this.labelInfoTime);
            this.panelMonitor.Controls.Add(this.labelErrorMission);
            this.panelMonitor.Location = new System.Drawing.Point(252, 77);
            this.panelMonitor.Name = "panelMonitor";
            this.panelMonitor.Size = new System.Drawing.Size(401, 148);
            this.panelMonitor.TabIndex = 19;
            // 
            // panelMonitorStarshipModule
            // 
            this.panelMonitorStarshipModule.BackColor = System.Drawing.Color.Black;
            this.panelMonitorStarshipModule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMonitorStarshipModule.Controls.Add(this.labelMissionResult);
            this.panelMonitorStarshipModule.Controls.Add(this.labelMissionCompletionTime);
            this.panelMonitorStarshipModule.Controls.Add(this.labelRepairCosts);
            this.panelMonitorStarshipModule.Controls.Add(this.labelStateModule);
            this.panelMonitorStarshipModule.Controls.Add(this.labelErrorModule);
            this.panelMonitorStarshipModule.Location = new System.Drawing.Point(252, 257);
            this.panelMonitorStarshipModule.Name = "panelMonitorStarshipModule";
            this.panelMonitorStarshipModule.Size = new System.Drawing.Size(401, 205);
            this.panelMonitorStarshipModule.TabIndex = 20;
            // 
            // labelRepairCosts
            // 
            this.labelRepairCosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRepairCosts.AutoSize = true;
            this.labelRepairCosts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepairCosts.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelRepairCosts.Location = new System.Drawing.Point(3, 25);
            this.labelRepairCosts.Name = "labelRepairCosts";
            this.labelRepairCosts.Size = new System.Drawing.Size(163, 16);
            this.labelRepairCosts.TabIndex = 18;
            this.labelRepairCosts.Text = "Расход на ремонт :  ---";
            // 
            // labelStateModule
            // 
            this.labelStateModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStateModule.AutoSize = true;
            this.labelStateModule.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStateModule.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelStateModule.Location = new System.Drawing.Point(3, 9);
            this.labelStateModule.Name = "labelStateModule";
            this.labelStateModule.Size = new System.Drawing.Size(168, 16);
            this.labelStateModule.TabIndex = 16;
            this.labelStateModule.Text = "Состояние модуля :  ---";
            // 
            // labelErrorModule
            // 
            this.labelErrorModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelErrorModule.AutoSize = true;
            this.labelErrorModule.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorModule.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelErrorModule.Location = new System.Drawing.Point(3, 73);
            this.labelErrorModule.Name = "labelErrorModule";
            this.labelErrorModule.Size = new System.Drawing.Size(149, 16);
            this.labelErrorModule.TabIndex = 17;
            this.labelErrorModule.Text = "Ошибки модуля :  ---";
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonitor.ForeColor = System.Drawing.Color.White;
            this.labelMonitor.Location = new System.Drawing.Point(256, 51);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(208, 18);
            this.labelMonitor.TabIndex = 21;
            this.labelMonitor.Text = "Монитро расчета миссии :";
            // 
            // labelMonitorStarshipModule
            // 
            this.labelMonitorStarshipModule.AutoSize = true;
            this.labelMonitorStarshipModule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonitorStarshipModule.ForeColor = System.Drawing.Color.White;
            this.labelMonitorStarshipModule.Location = new System.Drawing.Point(256, 231);
            this.labelMonitorStarshipModule.Name = "labelMonitorStarshipModule";
            this.labelMonitorStarshipModule.Size = new System.Drawing.Size(397, 18);
            this.labelMonitorStarshipModule.TabIndex = 22;
            this.labelMonitorStarshipModule.Text = "Монитор состояния исследовательских модулей :";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(138, 257);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(108, 31);
            this.buttonStart.TabIndex = 23;
            this.buttonStart.Text = "СТАРТ";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // buttonRepair
            // 
            this.buttonRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonRepair.FlatAppearance.BorderSize = 0;
            this.buttonRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepair.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRepair.Location = new System.Drawing.Point(138, 294);
            this.buttonRepair.Name = "buttonRepair";
            this.buttonRepair.Size = new System.Drawing.Size(108, 31);
            this.buttonRepair.TabIndex = 24;
            this.buttonRepair.Text = "Ремонт";
            this.buttonRepair.UseVisualStyleBackColor = false;
            this.buttonRepair.Click += new System.EventHandler(this.buttonRepair_Click);
            // 
            // labelMissionCompletionTime
            // 
            this.labelMissionCompletionTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMissionCompletionTime.AutoSize = true;
            this.labelMissionCompletionTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMissionCompletionTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelMissionCompletionTime.Location = new System.Drawing.Point(3, 41);
            this.labelMissionCompletionTime.Name = "labelMissionCompletionTime";
            this.labelMissionCompletionTime.Size = new System.Drawing.Size(240, 16);
            this.labelMissionCompletionTime.TabIndex = 19;
            this.labelMissionCompletionTime.Text = "Время до завершения миссии :  ---";
            // 
            // labelMissionResult
            // 
            this.labelMissionResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMissionResult.AutoSize = true;
            this.labelMissionResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMissionResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelMissionResult.Location = new System.Drawing.Point(3, 57);
            this.labelMissionResult.Name = "labelMissionResult";
            this.labelMissionResult.Size = new System.Drawing.Size(161, 16);
            this.labelMissionResult.TabIndex = 20;
            this.labelMissionResult.Text = "Результат миссии :  ---";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlStarshipModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.buttonRepair);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMonitorStarshipModule);
            this.Controls.Add(this.labelMonitor);
            this.Controls.Add(this.panelMonitorStarshipModule);
            this.Controls.Add(this.panelMonitor);
            this.Controls.Add(this.buttonCalculation);
            this.Controls.Add(this.comboBoxLVL);
            this.Controls.Add(this.labelLVL);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "UserControlStarshipModule";
            this.Size = new System.Drawing.Size(668, 478);
            this.Load += new System.EventHandler(this.UserControlStarshipModule_Load);
            this.panelMonitor.ResumeLayout(false);
            this.panelMonitor.PerformLayout();
            this.panelMonitorStarshipModule.ResumeLayout(false);
            this.panelMonitorStarshipModule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label labelLVL;
        private System.Windows.Forms.ComboBox comboBoxLVL;
        private System.Windows.Forms.Button buttonCalculation;
        private System.Windows.Forms.Label labelInfoTime;
        private System.Windows.Forms.Label labelErrorMission;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Panel panelMonitor;
        private System.Windows.Forms.Panel panelMonitorStarshipModule;
        private System.Windows.Forms.Label labelMissionResult;
        private System.Windows.Forms.Label labelMissionCompletionTime;
        private System.Windows.Forms.Label labelRepairCosts;
        private System.Windows.Forms.Label labelStateModule;
        private System.Windows.Forms.Label labelErrorModule;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label labelMonitorStarshipModule;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRepair;
        private System.Windows.Forms.Timer timer1;
    }
}
