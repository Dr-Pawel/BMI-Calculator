
namespace BMI_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weightValue = new System.Windows.Forms.NumericUpDown();
            this.heightValue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bmiResult = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight (kg)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height (cm)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightValue
            // 
            this.weightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weightValue.Location = new System.Drawing.Point(277, 79);
            this.weightValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.weightValue.Name = "weightValue";
            this.weightValue.Size = new System.Drawing.Size(157, 29);
            this.weightValue.TabIndex = 0;
            this.weightValue.Click += new System.EventHandler(this.answer_Enter);
            // 
            // heightValue
            // 
            this.heightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightValue.Location = new System.Drawing.Point(277, 151);
            this.heightValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(157, 29);
            this.heightValue.TabIndex = 1;
            this.heightValue.Click += new System.EventHandler(this.answer_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(49, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 56);
            this.label3.TabIndex = 6;
            this.label3.Text = "BMI Calculator";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(308, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "made by Dr.Pawel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(44, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "BMI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmiResult
            // 
            this.bmiResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bmiResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiResult.Location = new System.Drawing.Point(272, 257);
            this.bmiResult.Name = "bmiResult";
            this.bmiResult.Size = new System.Drawing.Size(157, 40);
            this.bmiResult.TabIndex = 9;
            this.bmiResult.Text = "Height (cm)";
            this.bmiResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsLabel
            // 
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultsLabel.Location = new System.Drawing.Point(49, 335);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(385, 104);
            this.resultsLabel.TabIndex = 10;
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(163, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "result";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.bmiResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.weightValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.weightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown weightValue;
        private System.Windows.Forms.NumericUpDown heightValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bmiResult;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label label6;
    }
}

