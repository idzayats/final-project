namespace LogisticProject
{
    partial class CalculationCargoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbxVolume = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(128, 83);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(143, 20);
            this.tbxFrom.TabIndex = 0;
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(128, 125);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(143, 20);
            this.tbxTo.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(125, 64);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 16);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Откуда:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(125, 106);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(46, 16);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Куда:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.Location = new System.Drawing.Point(303, 64);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(67, 16);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Ширина:";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(306, 83);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(143, 20);
            this.tbxWidth.TabIndex = 4;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLength.Location = new System.Drawing.Point(303, 106);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 16);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Длина:";
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(306, 125);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(143, 20);
            this.tbxLength.TabIndex = 6;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolume.Location = new System.Drawing.Point(474, 106);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(56, 16);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Обьем:";
            // 
            // tbxVolume
            // 
            this.tbxVolume.Location = new System.Drawing.Point(477, 125);
            this.tbxVolume.Name = "tbxVolume";
            this.tbxVolume.Size = new System.Drawing.Size(143, 20);
            this.tbxVolume.TabIndex = 10;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.Location = new System.Drawing.Point(474, 64);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(62, 16);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "Высота:";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(477, 83);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(143, 20);
            this.tbxHeight.TabIndex = 8;
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(128, 151);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(492, 23);
            this.btnCalculation.TabIndex = 12;
            this.btnCalculation.Text = "Расчитать";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // CalculationCargoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.tbxVolume);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.tbxHeight);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.tbxFrom);
            this.Name = "CalculationCargoUC";
            this.Size = new System.Drawing.Size(763, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox tbxVolume;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Button btnCalculation;
    }
}
