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
            this.lblTerminals = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKazan = new System.Windows.Forms.Label();
            this.lblMoscow = new System.Windows.Forms.Label();
            this.lblSochy = new System.Windows.Forms.Label();
            this.lblNizNovgorog = new System.Windows.Forms.Label();
            this.lblKhabarovsk = new System.Windows.Forms.Label();
            this.lblMoneyName = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(206, 40);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(143, 20);
            this.tbxFrom.TabIndex = 0;
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(206, 82);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(143, 20);
            this.tbxTo.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(203, 21);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(63, 16);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Откуда:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(203, 63);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(46, 16);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Куда:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.Location = new System.Drawing.Point(381, 21);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(67, 16);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Ширина:";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(384, 40);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(143, 20);
            this.tbxWidth.TabIndex = 4;
            this.tbxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWidth_KeyPress);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLength.Location = new System.Drawing.Point(381, 63);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(56, 16);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Длина:";
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(384, 82);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(143, 20);
            this.tbxLength.TabIndex = 6;
            this.tbxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLength_KeyPress);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolume.Location = new System.Drawing.Point(552, 63);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(56, 16);
            this.lblVolume.TabIndex = 11;
            this.lblVolume.Text = "Обьем:";
            // 
            // tbxVolume
            // 
            this.tbxVolume.Location = new System.Drawing.Point(555, 82);
            this.tbxVolume.Name = "tbxVolume";
            this.tbxVolume.Size = new System.Drawing.Size(143, 20);
            this.tbxVolume.TabIndex = 10;
            this.tbxVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVolume_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.Location = new System.Drawing.Point(552, 21);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(62, 16);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "Высота:";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(555, 40);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(143, 20);
            this.tbxHeight.TabIndex = 8;
            this.tbxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHeight_KeyPress);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(206, 118);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(492, 23);
            this.btnCalculation.TabIndex = 12;
            this.btnCalculation.Text = "Расчитать";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // lblTerminals
            // 
            this.lblTerminals.AutoSize = true;
            this.lblTerminals.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTerminals.Location = new System.Drawing.Point(19, 21);
            this.lblTerminals.Name = "lblTerminals";
            this.lblTerminals.Size = new System.Drawing.Size(128, 16);
            this.lblTerminals.TabIndex = 13;
            this.lblTerminals.Text = "Наши терминалы:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblKazan);
            this.flowLayoutPanel1.Controls.Add(this.lblMoscow);
            this.flowLayoutPanel1.Controls.Add(this.lblSochy);
            this.flowLayoutPanel1.Controls.Add(this.lblNizNovgorog);
            this.flowLayoutPanel1.Controls.Add(this.lblKhabarovsk);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 101);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // lblKazan
            // 
            this.lblKazan.AutoSize = true;
            this.lblKazan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKazan.Location = new System.Drawing.Point(3, 0);
            this.lblKazan.Name = "lblKazan";
            this.lblKazan.Size = new System.Drawing.Size(54, 16);
            this.lblKazan.TabIndex = 15;
            this.lblKazan.Text = "Казань";
            // 
            // lblMoscow
            // 
            this.lblMoscow.AutoSize = true;
            this.lblMoscow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoscow.Location = new System.Drawing.Point(3, 16);
            this.lblMoscow.Name = "lblMoscow";
            this.lblMoscow.Size = new System.Drawing.Size(59, 16);
            this.lblMoscow.TabIndex = 16;
            this.lblMoscow.Text = "Москва";
            // 
            // lblSochy
            // 
            this.lblSochy.AutoSize = true;
            this.lblSochy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSochy.Location = new System.Drawing.Point(3, 32);
            this.lblSochy.Name = "lblSochy";
            this.lblSochy.Size = new System.Drawing.Size(41, 16);
            this.lblSochy.TabIndex = 17;
            this.lblSochy.Text = "Сочи";
            // 
            // lblNizNovgorog
            // 
            this.lblNizNovgorog.AutoSize = true;
            this.lblNizNovgorog.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNizNovgorog.Location = new System.Drawing.Point(3, 48);
            this.lblNizNovgorog.Name = "lblNizNovgorog";
            this.lblNizNovgorog.Size = new System.Drawing.Size(71, 32);
            this.lblNizNovgorog.TabIndex = 18;
            this.lblNizNovgorog.Text = "Нижний Новгород";
            // 
            // lblKhabarovsk
            // 
            this.lblKhabarovsk.AutoSize = true;
            this.lblKhabarovsk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKhabarovsk.Location = new System.Drawing.Point(3, 80);
            this.lblKhabarovsk.Name = "lblKhabarovsk";
            this.lblKhabarovsk.Size = new System.Drawing.Size(81, 16);
            this.lblKhabarovsk.TabIndex = 19;
            this.lblKhabarovsk.Text = "Хабаровск";
            // 
            // lblMoneyName
            // 
            this.lblMoneyName.AutoSize = true;
            this.lblMoneyName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoneyName.Location = new System.Drawing.Point(363, 144);
            this.lblMoneyName.Name = "lblMoneyName";
            this.lblMoneyName.Size = new System.Drawing.Size(74, 16);
            this.lblMoneyName.TabIndex = 15;
            this.lblMoneyName.Text = "К оплате:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoney.Location = new System.Drawing.Point(443, 144);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(16, 16);
            this.lblMoney.TabIndex = 16;
            this.lblMoney.Text = "0";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(206, 163);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(492, 23);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Оплатить";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // CalculationCargoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblMoneyName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTerminals);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label lblTerminals;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblKazan;
        private System.Windows.Forms.Label lblMoscow;
        private System.Windows.Forms.Label lblSochy;
        private System.Windows.Forms.Label lblNizNovgorog;
        private System.Windows.Forms.Label lblKhabarovsk;
        private System.Windows.Forms.Label lblMoneyName;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnPayment;
    }
}
