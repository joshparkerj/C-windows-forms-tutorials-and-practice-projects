namespace WindowsFormsApp1
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
            this.Statistician_selector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number_input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Statistician_generator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number_input)).BeginInit();
            this.SuspendLayout();
            // 
            // Statistician_selector
            // 
            this.Statistician_selector.FormattingEnabled = true;
            this.Statistician_selector.Location = new System.Drawing.Point(204, 84);
            this.Statistician_selector.Name = "Statistician_selector";
            this.Statistician_selector.Size = new System.Drawing.Size(121, 21);
            this.Statistician_selector.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a Statistician";
            // 
            // number_input
            // 
            this.number_input.DecimalPlaces = 3;
            this.number_input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.number_input.Location = new System.Drawing.Point(504, 84);
            this.number_input.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.number_input.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.number_input.Name = "number_input";
            this.number_input.Size = new System.Drawing.Size(120, 20);
            this.number_input.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Feed a number to the currently selected statistician";
            // 
            // Statistician_generator
            // 
            this.Statistician_generator.AutoSize = true;
            this.Statistician_generator.Location = new System.Drawing.Point(207, 202);
            this.Statistician_generator.Name = "Statistician_generator";
            this.Statistician_generator.Size = new System.Drawing.Size(122, 23);
            this.Statistician_generator.TabIndex = 5;
            this.Statistician_generator.Text = "Add a new Statistician";
            this.Statistician_generator.UseVisualStyleBackColor = true;
            this.Statistician_generator.Click += new System.EventHandler(this.Statistician_generator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 762);
            this.Controls.Add(this.Statistician_generator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Statistician_selector);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.number_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Statistician_selector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown number_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Statistician_generator;
    }
}

