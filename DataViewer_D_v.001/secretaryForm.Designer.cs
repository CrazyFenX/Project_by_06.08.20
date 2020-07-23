namespace DataViewer_D_v._001
{
    partial class secretaryForm
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
            this.CreateNewTournirButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewTournirButton
            // 
            this.CreateNewTournirButton.Location = new System.Drawing.Point(591, 15);
            this.CreateNewTournirButton.Name = "CreateNewTournirButton";
            this.CreateNewTournirButton.Size = new System.Drawing.Size(165, 60);
            this.CreateNewTournirButton.TabIndex = 0;
            this.CreateNewTournirButton.Text = "Создать Турнир";
            this.CreateNewTournirButton.UseVisualStyleBackColor = true;
            this.CreateNewTournirButton.Click += new System.EventHandler(this.CreateNewTournirButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(591, 81);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(165, 60);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "Назад";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // secretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.CreateNewTournirButton);
            this.Name = "secretaryForm";
            this.Text = "secretaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.secretaryForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewTournirButton;
        private System.Windows.Forms.Button backbutton;
    }
}