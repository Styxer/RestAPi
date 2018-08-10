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
            this.toProjectScreenBtn = new System.Windows.Forms.Button();
            this.toTaskScreenBtn = new System.Windows.Forms.Button();
            this.toWorkPackagesScreen = new System.Windows.Forms.Button();
            this.toEmployeesScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toProjectScreenBtn
            // 
            this.toProjectScreenBtn.Location = new System.Drawing.Point(29, 55);
            this.toProjectScreenBtn.Name = "toProjectScreenBtn";
            this.toProjectScreenBtn.Size = new System.Drawing.Size(148, 82);
            this.toProjectScreenBtn.TabIndex = 0;
            this.toProjectScreenBtn.Text = "view projects";
            this.toProjectScreenBtn.UseVisualStyleBackColor = true;
            this.toProjectScreenBtn.Click += new System.EventHandler(this.ToScreen_Click);
            // 
            // toTaskScreenBtn
            // 
            this.toTaskScreenBtn.Location = new System.Drawing.Point(214, 55);
            this.toTaskScreenBtn.Name = "toTaskScreenBtn";
            this.toTaskScreenBtn.Size = new System.Drawing.Size(148, 82);
            this.toTaskScreenBtn.TabIndex = 1;
            this.toTaskScreenBtn.Text = "view tasks";
            this.toTaskScreenBtn.UseVisualStyleBackColor = true;
            // 
            // toWorkPackagesScreen
            // 
            this.toWorkPackagesScreen.Location = new System.Drawing.Point(392, 55);
            this.toWorkPackagesScreen.Name = "toWorkPackagesScreen";
            this.toWorkPackagesScreen.Size = new System.Drawing.Size(148, 82);
            this.toWorkPackagesScreen.TabIndex = 2;
            this.toWorkPackagesScreen.Text = "view work pakages";
            this.toWorkPackagesScreen.UseVisualStyleBackColor = true;
            // 
            // toEmployeesScreen
            // 
            this.toEmployeesScreen.Location = new System.Drawing.Point(569, 55);
            this.toEmployeesScreen.Name = "toEmployeesScreen";
            this.toEmployeesScreen.Size = new System.Drawing.Size(148, 82);
            this.toEmployeesScreen.TabIndex = 3;
            this.toEmployeesScreen.Text = "view employess";
            this.toEmployeesScreen.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toEmployeesScreen);
            this.Controls.Add(this.toWorkPackagesScreen);
            this.Controls.Add(this.toTaskScreenBtn);
            this.Controls.Add(this.toProjectScreenBtn);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toProjectScreenBtn;
        private System.Windows.Forms.Button toTaskScreenBtn;
        private System.Windows.Forms.Button toWorkPackagesScreen;
        private System.Windows.Forms.Button toEmployeesScreen;
    }
}

