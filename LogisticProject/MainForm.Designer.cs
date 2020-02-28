namespace LogisticProject
{
    partial class MainForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCalculationOrder = new System.Windows.Forms.Button();
            this.btnPersonalAccount = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.calculationCargoUC1 = new LogisticProject.CalculationCargoUC();
            this.pnlTop.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblNameCompany);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(763, 38);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnContacts);
            this.pnlNavigation.Controls.Add(this.btnOrders);
            this.pnlNavigation.Controls.Add(this.btnCalculationOrder);
            this.pnlNavigation.Controls.Add(this.btnPersonalAccount);
            this.pnlNavigation.Controls.Add(this.btnMainPage);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 38);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(763, 36);
            this.pnlNavigation.TabIndex = 1;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameCompany.Location = new System.Drawing.Point(12, 9);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(218, 18);
            this.lblNameCompany.TabIndex = 0;
            this.lblNameCompany.Text = "Логистическая компания";
            // 
            // pnlFill
            // 
            this.pnlFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFill.Controls.Add(this.calculationCargoUC1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 74);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(763, 368);
            this.pnlFill.TabIndex = 2;
            // 
            // btnContacts
            // 
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Image = global::LogisticProject.Properties.Resources.icons8_адрес_32;
            this.btnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Location = new System.Drawing.Point(603, 0);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(159, 36);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "Контакты";
            this.btnContacts.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Image = global::LogisticProject.Properties.Resources.icons8_оценить_32;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(460, 0);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(146, 36);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCalculationOrder
            // 
            this.btnCalculationOrder.FlatAppearance.BorderSize = 0;
            this.btnCalculationOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculationOrder.Image = global::LogisticProject.Properties.Resources.icons8_оценить_32;
            this.btnCalculationOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculationOrder.Location = new System.Drawing.Point(288, 0);
            this.btnCalculationOrder.Name = "btnCalculationOrder";
            this.btnCalculationOrder.Size = new System.Drawing.Size(174, 36);
            this.btnCalculationOrder.TabIndex = 2;
            this.btnCalculationOrder.Text = "Расчет грузоперевозки";
            this.btnCalculationOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculationOrder.UseVisualStyleBackColor = true;
            this.btnCalculationOrder.Click += new System.EventHandler(this.btnCalculationOrder_Click);
            // 
            // btnPersonalAccount
            // 
            this.btnPersonalAccount.FlatAppearance.BorderSize = 0;
            this.btnPersonalAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalAccount.Image = global::LogisticProject.Properties.Resources.icons8_пользователь_32;
            this.btnPersonalAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalAccount.Location = new System.Drawing.Point(144, 0);
            this.btnPersonalAccount.Name = "btnPersonalAccount";
            this.btnPersonalAccount.Size = new System.Drawing.Size(146, 36);
            this.btnPersonalAccount.TabIndex = 1;
            this.btnPersonalAccount.Text = "Личный кабинет";
            this.btnPersonalAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalAccount.UseVisualStyleBackColor = true;
            // 
            // btnMainPage
            // 
            this.btnMainPage.FlatAppearance.BorderSize = 0;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPage.Image = global::LogisticProject.Properties.Resources.icons8_главная_страница_32;
            this.btnMainPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPage.Location = new System.Drawing.Point(0, 0);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(146, 36);
            this.btnMainPage.TabIndex = 0;
            this.btnMainPage.Text = "Главная страница";
            this.btnMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainPage.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::LogisticProject.Properties.Resources.icons8_макос_закрыть_32;
            this.btnClose.Location = new System.Drawing.Point(725, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // calculationCargoUC1
            // 
            this.calculationCargoUC1.Location = new System.Drawing.Point(-1, -1);
            this.calculationCargoUC1.Name = "calculationCargoUC1";
            this.calculationCargoUC1.Size = new System.Drawing.Size(763, 368);
            this.calculationCargoUC1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 442);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnPersonalAccount;
        private System.Windows.Forms.Button btnCalculationOrder;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.Panel pnlFill;
        private CalculationCargoUC calculationCargoUC1;
    }
}

