namespace PhotoUpSet
{
    partial class frmPhoto
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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(130, 308);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(131, 61);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(349, 308);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(131, 61);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnSun
            // 
            this.btnSun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSun.Location = new System.Drawing.Point(558, 308);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(131, 61);
            this.btnSun.TabIndex = 2;
            this.btnSun.Text = "Sunrise";
            this.btnSun.UseVisualStyleBackColor = true;
            this.btnSun.Click += new System.EventHandler(this.btnSun_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.InitialImage = global::PhotoUpSet.Properties.Resources.setman;
            this.pbPhoto.Location = new System.Drawing.Point(252, 12);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(333, 268);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 3;
            this.pbPhoto.TabStop = false;
            // 
            // frmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnSun);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnUp);
            this.Name = "frmPhoto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.PictureBox pbPhoto;
    }
}

