namespace Kadoma_City_Council_V2
{
    partial class AllUsers
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
            this.CloseButton = new LollipopButton();
            this.AllButton = new LollipopButton();
            this.ADMINButton = new LollipopButton();
            this.USERButton = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BGColor = "#508ef5";
            this.CloseButton.FontColor = "#ffffff";
            this.CloseButton.Location = new System.Drawing.Point(511, 356);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(130, 41);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AllButton
            // 
            this.AllButton.BackColor = System.Drawing.Color.Transparent;
            this.AllButton.BGColor = "#508ef5";
            this.AllButton.FontColor = "#ffffff";
            this.AllButton.Location = new System.Drawing.Point(4, 357);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(95, 30);
            this.AllButton.TabIndex = 2;
            this.AllButton.Text = "All";
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // ADMINButton
            // 
            this.ADMINButton.BackColor = System.Drawing.Color.Transparent;
            this.ADMINButton.BGColor = "#508ef5";
            this.ADMINButton.FontColor = "#ffffff";
            this.ADMINButton.Location = new System.Drawing.Point(105, 356);
            this.ADMINButton.Name = "ADMINButton";
            this.ADMINButton.Size = new System.Drawing.Size(95, 30);
            this.ADMINButton.TabIndex = 3;
            this.ADMINButton.Text = "ADMIN";
            this.ADMINButton.Click += new System.EventHandler(this.ADMINButton_Click);
            // 
            // USERButton
            // 
            this.USERButton.BackColor = System.Drawing.Color.Transparent;
            this.USERButton.BGColor = "#508ef5";
            this.USERButton.FontColor = "#ffffff";
            this.USERButton.Location = new System.Drawing.Point(206, 357);
            this.USERButton.Name = "USERButton";
            this.USERButton.Size = new System.Drawing.Size(95, 30);
            this.USERButton.TabIndex = 4;
            this.USERButton.Text = "USER";
            this.USERButton.Click += new System.EventHandler(this.USERButton_Click);
            // 
            // AllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.USERButton);
            this.Controls.Add(this.ADMINButton);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllUsers";
            this.Size = new System.Drawing.Size(644, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LollipopButton CloseButton;
        private LollipopButton AllButton;
        private LollipopButton ADMINButton;
        private LollipopButton USERButton;
    }
}
