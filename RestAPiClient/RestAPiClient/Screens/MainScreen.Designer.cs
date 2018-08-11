namespace RestAPiClient
{
    partial class MainScreen
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.btnsPanel = new System.Windows.Forms.Panel();
            this.toCustomersScreen = new System.Windows.Forms.Button();
            this.toTaskScreenBtn = new System.Windows.Forms.Button();
            this.toWorkPackagesScreen = new System.Windows.Forms.Button();
            this.toEmployeesScreen = new System.Windows.Forms.Button();
            this.toProjectsScreen = new System.Windows.Forms.Button();
            this.btnsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(218, 20);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(570, 446);
            this.contentPanel.TabIndex = 6;
            // 
            // btnsPanel
            // 
            this.btnsPanel.Controls.Add(this.toProjectsScreen);
            this.btnsPanel.Controls.Add(this.toEmployeesScreen);
            this.btnsPanel.Controls.Add(this.toCustomersScreen);
            this.btnsPanel.Controls.Add(this.toWorkPackagesScreen);
            this.btnsPanel.Controls.Add(this.toTaskScreenBtn);
            this.btnsPanel.Location = new System.Drawing.Point(12, 20);
            this.btnsPanel.Name = "btnsPanel";
            this.btnsPanel.Size = new System.Drawing.Size(200, 446);
            this.btnsPanel.TabIndex = 7;
            // 
            // toCustomersScreen
            // 
            this.toCustomersScreen.Location = new System.Drawing.Point(26, 6);
            this.toCustomersScreen.Name = "toCustomersScreen";
            this.toCustomersScreen.Size = new System.Drawing.Size(148, 82);
            this.toCustomersScreen.TabIndex = 9;
            this.toCustomersScreen.Text = "view customers";
            this.toCustomersScreen.UseVisualStyleBackColor = true;
            this.toCustomersScreen.Click += new System.EventHandler(this.ToScreen_Click);
            // 
            // toTaskScreenBtn
            // 
            this.toTaskScreenBtn.Location = new System.Drawing.Point(26, 362);
            this.toTaskScreenBtn.Name = "toTaskScreenBtn";
            this.toTaskScreenBtn.Size = new System.Drawing.Size(148, 82);
            this.toTaskScreenBtn.TabIndex = 6;
            this.toTaskScreenBtn.Text = "view tasks";
            this.toTaskScreenBtn.UseVisualStyleBackColor = true;
            this.toTaskScreenBtn.Click += new System.EventHandler(this.ToScreen_Click);
            // 
            // toWorkPackagesScreen
            // 
            this.toWorkPackagesScreen.Location = new System.Drawing.Point(26, 186);
            this.toWorkPackagesScreen.Name = "toWorkPackagesScreen";
            this.toWorkPackagesScreen.Size = new System.Drawing.Size(148, 82);
            this.toWorkPackagesScreen.TabIndex = 7;
            this.toWorkPackagesScreen.Text = "view work pakages";
            this.toWorkPackagesScreen.UseVisualStyleBackColor = true;
            this.toWorkPackagesScreen.Click += new System.EventHandler(this.ToScreen_Click);
            // 
            // toEmployeesScreen
            // 
            this.toEmployeesScreen.Location = new System.Drawing.Point(26, 274);
            this.toEmployeesScreen.Name = "toEmployeesScreen";
            this.toEmployeesScreen.Size = new System.Drawing.Size(148, 82);
            this.toEmployeesScreen.TabIndex = 8;
            this.toEmployeesScreen.Text = "view employess";
            this.toEmployeesScreen.UseVisualStyleBackColor = true;
            this.toEmployeesScreen.Click += new System.EventHandler(this.ToScreen_Click);
            // 
            // toProjectsScreen
            // 
            this.toProjectsScreen.Location = new System.Drawing.Point(26, 98);
            this.toProjectsScreen.Name = "toProjectsScreen";
            this.toProjectsScreen.Size = new System.Drawing.Size(148, 82);
            this.toProjectsScreen.TabIndex = 10;
            this.toProjectsScreen.Text = "view projects";
            this.toProjectsScreen.UseVisualStyleBackColor = true;
            this.toProjectsScreen.Click += new System.EventHandler(this.ToScreen_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnsPanel);
            this.Controls.Add(this.contentPanel);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.btnsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel btnsPanel;
        private System.Windows.Forms.Button toCustomersScreen;
        private System.Windows.Forms.Button toProjectsScreen;
        private System.Windows.Forms.Button toEmployeesScreen;
        private System.Windows.Forms.Button toWorkPackagesScreen;
        private System.Windows.Forms.Button toTaskScreenBtn;
    }
}

