namespace memoriaJatek
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.par9 = new System.Windows.Forms.RadioButton();
            this.par6 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Kezdes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.egyjegyu = new System.Windows.Forms.RadioButton();
            this.ketjegyu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.masodperc5 = new System.Windows.Forms.RadioButton();
            this.masodperc10 = new System.Windows.Forms.RadioButton();
            this.masodperc20 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.par9);
            this.groupBox1.Controls.Add(this.par6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(581, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // par9
            // 
            this.par9.AutoSize = true;
            this.par9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.par9.Location = new System.Drawing.Point(352, 50);
            this.par9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.par9.Name = "par9";
            this.par9.Size = new System.Drawing.Size(42, 30);
            this.par9.TabIndex = 2;
            this.par9.Text = "9";
            this.par9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.par9.UseVisualStyleBackColor = true;
            this.par9.CheckedChanged += new System.EventHandler(this.par9_CheckedChanged);
            // 
            // par6
            // 
            this.par6.AutoSize = true;
            this.par6.Checked = true;
            this.par6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.par6.Location = new System.Drawing.Point(184, 50);
            this.par6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.par6.Name = "par6";
            this.par6.Size = new System.Drawing.Size(42, 30);
            this.par6.TabIndex = 1;
            this.par6.TabStop = true;
            this.par6.Text = "6";
            this.par6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.par6.UseVisualStyleBackColor = true;
            this.par6.CheckedChanged += new System.EventHandler(this.par6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hány pár (szám)kártya legyen?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kezdes
            // 
            this.Kezdes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Kezdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kezdes.Location = new System.Drawing.Point(254, 342);
            this.Kezdes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Kezdes.Name = "Kezdes";
            this.Kezdes.Size = new System.Drawing.Size(98, 41);
            this.Kezdes.TabIndex = 4;
            this.Kezdes.Text = "Start";
            this.Kezdes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(572, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hány jegyűek legyenek a számok a kártykon?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // egyjegyu
            // 
            this.egyjegyu.AutoSize = true;
            this.egyjegyu.Checked = true;
            this.egyjegyu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.egyjegyu.Location = new System.Drawing.Point(184, 50);
            this.egyjegyu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.egyjegyu.Name = "egyjegyu";
            this.egyjegyu.Size = new System.Drawing.Size(42, 30);
            this.egyjegyu.TabIndex = 1;
            this.egyjegyu.TabStop = true;
            this.egyjegyu.Text = "1";
            this.egyjegyu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.egyjegyu.UseVisualStyleBackColor = true;
            // 
            // ketjegyu
            // 
            this.ketjegyu.AutoSize = true;
            this.ketjegyu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ketjegyu.Location = new System.Drawing.Point(352, 50);
            this.ketjegyu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ketjegyu.Name = "ketjegyu";
            this.ketjegyu.Size = new System.Drawing.Size(42, 30);
            this.ketjegyu.TabIndex = 2;
            this.ketjegyu.Text = "2";
            this.ketjegyu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ketjegyu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mennyi ideig látszódjanak a kártyák?(mp)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // masodperc5
            // 
            this.masodperc5.AutoSize = true;
            this.masodperc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masodperc5.Location = new System.Drawing.Point(98, 50);
            this.masodperc5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masodperc5.Name = "masodperc5";
            this.masodperc5.Size = new System.Drawing.Size(42, 30);
            this.masodperc5.TabIndex = 1;
            this.masodperc5.Text = "5";
            this.masodperc5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masodperc5.UseVisualStyleBackColor = true;
            // 
            // masodperc10
            // 
            this.masodperc10.AutoSize = true;
            this.masodperc10.Checked = true;
            this.masodperc10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masodperc10.Location = new System.Drawing.Point(267, 50);
            this.masodperc10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masodperc10.Name = "masodperc10";
            this.masodperc10.Size = new System.Drawing.Size(54, 30);
            this.masodperc10.TabIndex = 2;
            this.masodperc10.TabStop = true;
            this.masodperc10.Text = "10";
            this.masodperc10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masodperc10.UseVisualStyleBackColor = true;
            // 
            // masodperc20
            // 
            this.masodperc20.AutoSize = true;
            this.masodperc20.Enabled = false;
            this.masodperc20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masodperc20.Location = new System.Drawing.Point(442, 50);
            this.masodperc20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masodperc20.Name = "masodperc20";
            this.masodperc20.Size = new System.Drawing.Size(54, 30);
            this.masodperc20.TabIndex = 3;
            this.masodperc20.Text = "20";
            this.masodperc20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.masodperc20.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.masodperc5);
            this.groupBox2.Controls.Add(this.masodperc20);
            this.groupBox2.Controls.Add(this.masodperc10);
            this.groupBox2.Location = new System.Drawing.Point(10, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(581, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.egyjegyu);
            this.groupBox3.Controls.Add(this.ketjegyu);
            this.groupBox3.Location = new System.Drawing.Point(10, 217);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(581, 81);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 392);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Kezdes);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton par6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton par9;
        private System.Windows.Forms.Button Kezdes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton egyjegyu;
        private System.Windows.Forms.RadioButton ketjegyu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton masodperc5;
        private System.Windows.Forms.RadioButton masodperc10;
        private System.Windows.Forms.RadioButton masodperc20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}