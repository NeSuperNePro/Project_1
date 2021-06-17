namespace Selezneff_DATA
{
    partial class UserControlShop
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
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonProductAvailability = new System.Windows.Forms.Button();
            this.buttonBUY = new System.Windows.Forms.Button();
            this.buttonSELL = new System.Windows.Forms.Button();
            this.labelSortProduct = new System.Windows.Forms.Label();
            this.buttonSortProductUP = new System.Windows.Forms.Button();
            this.buttonSortProductDOWN = new System.Windows.Forms.Button();
            this.buttonClearConsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Магазин";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.comboBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProduct.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxProduct.ForeColor = System.Drawing.Color.White;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "Топливо",
            "Компоненты",
            "Компьютеры",
            "Биомасса",
            "Топливный Генератор",
            "Космическая карта",
            "Космический ускоритель",
            "Варп Двигатель"});
            this.comboBoxProduct.Location = new System.Drawing.Point(115, 54);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(334, 35);
            this.comboBoxProduct.TabIndex = 16;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelProduct.ForeColor = System.Drawing.Color.White;
            this.labelProduct.Location = new System.Drawing.Point(3, 54);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(106, 23);
            this.labelProduct.TabIndex = 15;
            this.labelProduct.Text = "Продукт :";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxInfo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo.ForeColor = System.Drawing.Color.Green;
            this.textBoxInfo.Location = new System.Drawing.Point(115, 95);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInfo.Size = new System.Drawing.Size(334, 222);
            this.textBoxInfo.TabIndex = 17;
            // 
            // buttonProductAvailability
            // 
            this.buttonProductAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonProductAvailability.FlatAppearance.BorderSize = 0;
            this.buttonProductAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductAvailability.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProductAvailability.Location = new System.Drawing.Point(455, 54);
            this.buttonProductAvailability.Name = "buttonProductAvailability";
            this.buttonProductAvailability.Size = new System.Drawing.Size(108, 35);
            this.buttonProductAvailability.TabIndex = 18;
            this.buttonProductAvailability.Text = "НАЛИЧИЕ";
            this.buttonProductAvailability.UseVisualStyleBackColor = false;
            this.buttonProductAvailability.Click += new System.EventHandler(this.buttonProductAvailability_Click);
            // 
            // buttonBUY
            // 
            this.buttonBUY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonBUY.FlatAppearance.BorderSize = 0;
            this.buttonBUY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBUY.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBUY.Location = new System.Drawing.Point(455, 95);
            this.buttonBUY.Name = "buttonBUY";
            this.buttonBUY.Size = new System.Drawing.Size(108, 35);
            this.buttonBUY.TabIndex = 19;
            this.buttonBUY.Text = "КУПИТЬ";
            this.buttonBUY.UseVisualStyleBackColor = false;
            this.buttonBUY.Click += new System.EventHandler(this.buttonBUY_Click);
            // 
            // buttonSELL
            // 
            this.buttonSELL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonSELL.FlatAppearance.BorderSize = 0;
            this.buttonSELL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSELL.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSELL.Location = new System.Drawing.Point(455, 136);
            this.buttonSELL.Name = "buttonSELL";
            this.buttonSELL.Size = new System.Drawing.Size(108, 35);
            this.buttonSELL.TabIndex = 20;
            this.buttonSELL.Text = "ПРОДАТЬ";
            this.buttonSELL.UseVisualStyleBackColor = false;
            this.buttonSELL.Click += new System.EventHandler(this.buttonSELL_Click);
            // 
            // labelSortProduct
            // 
            this.labelSortProduct.AutoSize = true;
            this.labelSortProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelSortProduct.ForeColor = System.Drawing.Color.White;
            this.labelSortProduct.Location = new System.Drawing.Point(455, 215);
            this.labelSortProduct.Name = "labelSortProduct";
            this.labelSortProduct.Size = new System.Drawing.Size(180, 23);
            this.labelSortProduct.TabIndex = 21;
            this.labelSortProduct.Text = "Сортировать по :";
            // 
            // buttonSortProductUP
            // 
            this.buttonSortProductUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonSortProductUP.FlatAppearance.BorderSize = 0;
            this.buttonSortProductUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortProductUP.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortProductUP.Location = new System.Drawing.Point(459, 241);
            this.buttonSortProductUP.Name = "buttonSortProductUP";
            this.buttonSortProductUP.Size = new System.Drawing.Size(149, 35);
            this.buttonSortProductUP.TabIndex = 22;
            this.buttonSortProductUP.Text = "Возрастанию";
            this.buttonSortProductUP.UseVisualStyleBackColor = false;
            this.buttonSortProductUP.Click += new System.EventHandler(this.buttonSortProductUP_Click);
            // 
            // buttonSortProductDOWN
            // 
            this.buttonSortProductDOWN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonSortProductDOWN.FlatAppearance.BorderSize = 0;
            this.buttonSortProductDOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortProductDOWN.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortProductDOWN.Location = new System.Drawing.Point(459, 282);
            this.buttonSortProductDOWN.Name = "buttonSortProductDOWN";
            this.buttonSortProductDOWN.Size = new System.Drawing.Size(149, 35);
            this.buttonSortProductDOWN.TabIndex = 23;
            this.buttonSortProductDOWN.Text = "Убыванию";
            this.buttonSortProductDOWN.UseVisualStyleBackColor = false;
            this.buttonSortProductDOWN.Click += new System.EventHandler(this.buttonSortProductDOWN_Click);
            // 
            // buttonClearConsole
            // 
            this.buttonClearConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(107)))));
            this.buttonClearConsole.FlatAppearance.BorderSize = 0;
            this.buttonClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearConsole.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearConsole.Location = new System.Drawing.Point(455, 177);
            this.buttonClearConsole.Name = "buttonClearConsole";
            this.buttonClearConsole.Size = new System.Drawing.Size(108, 35);
            this.buttonClearConsole.TabIndex = 24;
            this.buttonClearConsole.Text = "Clear";
            this.buttonClearConsole.UseVisualStyleBackColor = false;
            this.buttonClearConsole.Click += new System.EventHandler(this.buttonClearConsole_Click);
            // 
            // UserControlShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.buttonClearConsole);
            this.Controls.Add(this.buttonSortProductDOWN);
            this.Controls.Add(this.buttonSortProductUP);
            this.Controls.Add(this.labelSortProduct);
            this.Controls.Add(this.buttonSELL);
            this.Controls.Add(this.buttonBUY);
            this.Controls.Add(this.buttonProductAvailability);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.label1);
            this.Name = "UserControlShop";
            this.Size = new System.Drawing.Size(668, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonProductAvailability;
        private System.Windows.Forms.Button buttonBUY;
        private System.Windows.Forms.Button buttonSELL;
        private System.Windows.Forms.Label labelSortProduct;
        private System.Windows.Forms.Button buttonSortProductUP;
        private System.Windows.Forms.Button buttonSortProductDOWN;
        private System.Windows.Forms.Button buttonClearConsole;
    }
}
