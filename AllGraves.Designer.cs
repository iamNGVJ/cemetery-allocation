namespace Kadoma_City_Council_V2
{
    partial class AllGraves
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AllButton = new LollipopButton();
            this.BoughtButton = new LollipopButton();
            this.BuriedButton = new LollipopButton();
            this.UnsoldButton = new LollipopButton();
            this.CloseButton = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // AllButton
            // 
            this.AllButton.BackColor = System.Drawing.Color.Transparent;
            this.AllButton.BGColor = "#508ef5";
            this.AllButton.FontColor = "#ffffff";
            this.AllButton.Location = new System.Drawing.Point(3, 344);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(90, 27);
            this.AllButton.TabIndex = 1;
            this.AllButton.Text = "All";
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // BoughtButton
            // 
            this.BoughtButton.BackColor = System.Drawing.Color.Transparent;
            this.BoughtButton.BGColor = "#508ef5";
            this.BoughtButton.FontColor = "#ffffff";
            this.BoughtButton.Location = new System.Drawing.Point(99, 344);
            this.BoughtButton.Name = "BoughtButton";
            this.BoughtButton.Size = new System.Drawing.Size(90, 27);
            this.BoughtButton.TabIndex = 2;
            this.BoughtButton.Text = "Bought";
            this.BoughtButton.Click += new System.EventHandler(this.BoughtButton_Click);
            // 
            // BuriedButton
            // 
            this.BuriedButton.BackColor = System.Drawing.Color.Transparent;
            this.BuriedButton.BGColor = "#508ef5";
            this.BuriedButton.FontColor = "#ffffff";
            this.BuriedButton.Location = new System.Drawing.Point(195, 344);
            this.BuriedButton.Name = "BuriedButton";
            this.BuriedButton.Size = new System.Drawing.Size(90, 27);
            this.BuriedButton.TabIndex = 3;
            this.BuriedButton.Text = "Buried";
            this.BuriedButton.Click += new System.EventHandler(this.BuriedButton_Click);
            // 
            // UnsoldButton
            // 
            this.UnsoldButton.BackColor = System.Drawing.Color.Transparent;
            this.UnsoldButton.BGColor = "#508ef5";
            this.UnsoldButton.FontColor = "#ffffff";
            this.UnsoldButton.Location = new System.Drawing.Point(291, 344);
            this.UnsoldButton.Name = "UnsoldButton";
            this.UnsoldButton.Size = new System.Drawing.Size(90, 27);
            this.UnsoldButton.TabIndex = 4;
            this.UnsoldButton.Text = "Unsold";
            this.UnsoldButton.Click += new System.EventHandler(this.UnsoldButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BGColor = "#508ef5";
            this.CloseButton.FontColor = "#ffffff";
            this.CloseButton.Location = new System.Drawing.Point(551, 344);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 27);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AllGraves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UnsoldButton);
            this.Controls.Add(this.BuriedButton);
            this.Controls.Add(this.BoughtButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllGraves";
            this.Size = new System.Drawing.Size(644, 379);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LollipopButton AllButton;
        private LollipopButton BoughtButton;
        private LollipopButton BuriedButton;
        private LollipopButton UnsoldButton;
        private LollipopButton CloseButton;
    }
}
