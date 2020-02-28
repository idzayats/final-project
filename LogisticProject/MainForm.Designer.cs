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
            this.btnCalculationOrder = new System.Windows.Forms.Button();
            this.btnPersonalAccount = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
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
            // btnCalculationOrder
            // 
            this.btnCalculationOrder.Image = global::LogisticProject.Properties.Resources.icons8_оценить_32;
            this.btnCalculationOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculationOrder.Location = new System.Drawing.Point(288, 0);
            this.btnCalculationOrder.Name = "btnCalculationOrder";
            this.btnCalculationOrder.Size = new System.Drawing.Size(174, 36);
            this.btnCalculationOrder.TabIndex = 2;
            this.btnCalculationOrder.Text = "Расчет грузоперевозки";
            this.btnCalculationOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculationOrder.UseVisualStyleBackColor = true;
            // 
            // btnPersonalAccount
            // 
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
            // btnOrders
            // 
            this.btnOrders.Image = global::LogisticProject.Properties.Resources.icons8_оценить_32;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(460, 0);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(146, 36);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Заказы";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnContacts
            // 
            this.btnContacts.Image = global::LogisticProject.Properties.Resources.icons8_оценить_32;
            this.btnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Location = new System.Drawing.Point(604, 0);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(159, 36);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "Контакты";
            this.btnContacts.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 442);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.pnlNavigation.ResumeLayout(false);
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
    }
}

