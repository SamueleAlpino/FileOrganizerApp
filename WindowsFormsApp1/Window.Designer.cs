namespace WindowsFormsApp1
{
    partial class Window
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.Visualizer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolderButton.Location = new System.Drawing.Point(26, 23);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(195, 39);
            this.OpenFolderButton.TabIndex = 0;
            this.OpenFolderButton.Text = "SELECT FOLDER";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Visualizer
            // 
            this.Visualizer.BackColor = System.Drawing.Color.LightGray;
            this.Visualizer.Font = new System.Drawing.Font("Miriam CLM", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Visualizer.Location = new System.Drawing.Point(29, 72);
            this.Visualizer.Margin = new System.Windows.Forms.Padding(0);
            this.Visualizer.Name = "Visualizer";
            this.Visualizer.Size = new System.Drawing.Size(193, 23);
            this.Visualizer.TabIndex = 1;
            this.Visualizer.Text = "Temporary";
            this.Visualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "ORDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(243, 168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Visualizer);
            this.Controls.Add(this.OpenFolderButton);
            this.Name = "Window";
            this.Text = "Organizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.Label Visualizer;
        private System.Windows.Forms.Button button1;
    }
}

