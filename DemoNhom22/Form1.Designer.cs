
namespace DemoNhom22
{
    partial class Form1
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
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxDes = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.btnLoadImageFromDatabase = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(50, 37);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(303, 272);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 0;
            this.pictureBoxSource.TabStop = false;
            // 
            // pictureBoxDes
            // 
            this.pictureBoxDes.Location = new System.Drawing.Point(443, 37);
            this.pictureBoxDes.Name = "pictureBoxDes";
            this.pictureBoxDes.Size = new System.Drawing.Size(303, 272);
            this.pictureBoxDes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDes.TabIndex = 1;
            this.pictureBoxDes.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(108, 355);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(163, 59);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(316, 355);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(163, 59);
            this.btnSaveToDatabase.TabIndex = 3;
            this.btnSaveToDatabase.Text = "Save to Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // btnLoadImageFromDatabase
            // 
            this.btnLoadImageFromDatabase.Location = new System.Drawing.Point(518, 355);
            this.btnLoadImageFromDatabase.Name = "btnLoadImageFromDatabase";
            this.btnLoadImageFromDatabase.Size = new System.Drawing.Size(163, 59);
            this.btnLoadImageFromDatabase.TabIndex = 4;
            this.btnLoadImageFromDatabase.Text = "Load Image";
            this.btnLoadImageFromDatabase.UseVisualStyleBackColor = true;
            this.btnLoadImageFromDatabase.Click += new System.EventHandler(this.btnLoadImageFromDatabase_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadImageFromDatabase);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.pictureBoxDes);
            this.Controls.Add(this.pictureBoxSource);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxDes;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveToDatabase;
        private System.Windows.Forms.Button btnLoadImageFromDatabase;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
    }
}

