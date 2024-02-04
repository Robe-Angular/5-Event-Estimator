
namespace _5_Event_Estimator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.isFancy = new System.Windows.Forms.CheckBox();
            this.isHealthy = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.isFancyBirthday = new System.Windows.Forms.CheckBox();
            this.realText = new System.Windows.Forms.Label();
            this.costBirthdayLabel = new System.Windows.Forms.Label();
            this.numericUpDownBirthday = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hopedText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cakeSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberPeople)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // numberPeople
            // 
            this.numberPeople.Location = new System.Drawing.Point(12, 93);
            this.numberPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPeople.Name = "numberPeople";
            this.numberPeople.Size = new System.Drawing.Size(98, 20);
            this.numberPeople.TabIndex = 0;
            this.numberPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberPeople.ValueChanged += new System.EventHandler(this.numberPeople_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of People";
            // 
            // isFancy
            // 
            this.isFancy.AutoSize = true;
            this.isFancy.Checked = true;
            this.isFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isFancy.Location = new System.Drawing.Point(12, 58);
            this.isFancy.Name = "isFancy";
            this.isFancy.Size = new System.Drawing.Size(113, 17);
            this.isFancy.TabIndex = 2;
            this.isFancy.Text = "Fancy decorations";
            this.isFancy.UseVisualStyleBackColor = true;
            this.isFancy.CheckedChanged += new System.EventHandler(this.isFancy_CheckedChanged);
            // 
            // isHealthy
            // 
            this.isHealthy.AutoSize = true;
            this.isHealthy.Location = new System.Drawing.Point(6, 16);
            this.isHealthy.Name = "isHealthy";
            this.isHealthy.Size = new System.Drawing.Size(96, 17);
            this.isHealthy.TabIndex = 3;
            this.isHealthy.Text = "Healthy Option";
            this.isHealthy.UseVisualStyleBackColor = true;
            this.isHealthy.CheckedChanged += new System.EventHandler(this.isHealthy_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(40, 116);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(255, 297);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.isFancy);
            this.tabPage1.Controls.Add(this.isHealthy);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.numberPeople);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.isFancyBirthday);
            this.tabPage2.Controls.Add(this.realText);
            this.tabPage2.Controls.Add(this.costBirthdayLabel);
            this.tabPage2.Controls.Add(this.numericUpDownBirthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.hopedText);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cakeSizeLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // isFancyBirthday
            // 
            this.isFancyBirthday.AutoSize = true;
            this.isFancyBirthday.Checked = true;
            this.isFancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isFancyBirthday.Location = new System.Drawing.Point(73, 96);
            this.isFancyBirthday.Name = "isFancyBirthday";
            this.isFancyBirthday.Size = new System.Drawing.Size(113, 17);
            this.isFancyBirthday.TabIndex = 9;
            this.isFancyBirthday.Text = "Fancy decorations";
            this.isFancyBirthday.UseVisualStyleBackColor = true;
            this.isFancyBirthday.CheckedChanged += new System.EventHandler(this.isFancyBirthday_CheckedChanged);
            // 
            // realText
            // 
            this.realText.AutoSize = true;
            this.realText.Location = new System.Drawing.Point(114, 67);
            this.realText.Name = "realText";
            this.realText.Size = new System.Drawing.Size(35, 13);
            this.realText.TabIndex = 5;
            this.realText.Text = "label6";
            // 
            // costBirthdayLabel
            // 
            this.costBirthdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costBirthdayLabel.Location = new System.Drawing.Point(101, 154);
            this.costBirthdayLabel.Name = "costBirthdayLabel";
            this.costBirthdayLabel.Size = new System.Drawing.Size(100, 23);
            this.costBirthdayLabel.TabIndex = 10;
            // 
            // numericUpDownBirthday
            // 
            this.numericUpDownBirthday.Location = new System.Drawing.Point(73, 131);
            this.numericUpDownBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBirthday.Name = "numericUpDownBirthday";
            this.numericUpDownBirthday.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownBirthday.TabIndex = 7;
            this.numericUpDownBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBirthday.ValueChanged += new System.EventHandler(this.numericUpDownBirthday_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Text:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number of People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hoped text:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cost";
            // 
            // hopedText
            // 
            this.hopedText.Location = new System.Drawing.Point(117, 36);
            this.hopedText.Name = "hopedText";
            this.hopedText.Size = new System.Drawing.Size(100, 20);
            this.hopedText.TabIndex = 2;
            this.hopedText.TextChanged += new System.EventHandler(this.hopedText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cake size:";
            // 
            // cakeSizeLabel
            // 
            this.cakeSizeLabel.AutoSize = true;
            this.cakeSizeLabel.Location = new System.Drawing.Point(114, 20);
            this.cakeSizeLabel.Name = "cakeSizeLabel";
            this.cakeSizeLabel.Size = new System.Drawing.Size(35, 13);
            this.cakeSizeLabel.TabIndex = 0;
            this.cakeSizeLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 321);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberPeople)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isFancy;
        private System.Windows.Forms.CheckBox isHealthy;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cakeSizeLabel;
        private System.Windows.Forms.Label realText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hopedText;
        private System.Windows.Forms.CheckBox isFancyBirthday;
        private System.Windows.Forms.Label costBirthdayLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

