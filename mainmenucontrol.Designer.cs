namespace Kadoma_City_Council_V2
{
    partial class mainmenucontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenucontrol));
            this.HelpButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.allGraves1 = new Kadoma_City_Council_V2.AllGraves();
            this.helpUserControl1 = new Kadoma_City_Council_V2.HelpUserControl();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpButton.BackgroundImage")));
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Source Code Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.Location = new System.Drawing.Point(335, 96);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(274, 195);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Help Info";
            this.HelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Source Code Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(28, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 195);
            this.button3.TabIndex = 10;
            this.button3.Text = "Grave Statistics";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // allGraves1
            // 
            this.allGraves1.Location = new System.Drawing.Point(0, 21);
            this.allGraves1.Name = "allGraves1";
            this.allGraves1.Size = new System.Drawing.Size(644, 379);
            this.allGraves1.TabIndex = 11;
            // 
            // helpUserControl1
            // 
            this.helpUserControl1.Location = new System.Drawing.Point(0, 0);
            this.helpUserControl1.Name = "helpUserControl1";
            this.helpUserControl1.Size = new System.Drawing.Size(644, 400);
            this.helpUserControl1.TabIndex = 12;
            // 
            // mainmenucontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.allGraves1);
            this.Controls.Add(this.helpUserControl1);
            this.Name = "mainmenucontrol";
            this.Size = new System.Drawing.Size(644, 400);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button button3;
        private AllGraves allGraves1;
        private HelpUserControl helpUserControl1;
    }
}
