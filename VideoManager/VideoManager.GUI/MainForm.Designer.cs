﻿
namespace VideoManager.GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GetAirtableDataBtn = new System.Windows.Forms.Button();
            this.VideoDGV = new System.Windows.Forms.DataGridView();
            this.UpdateLiveBtn = new System.Windows.Forms.Button();
            this.UploadMainVideoBtn = new System.Windows.Forms.Button();
            this.UpdateAirtableForLiveDataBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VideoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UpdateMainVideoBtn = new System.Windows.Forms.Button();
            this.CommentMainVideoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GetAirtableDataBtn
            // 
            this.GetAirtableDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GetAirtableDataBtn.Image = ((System.Drawing.Image)(resources.GetObject("GetAirtableDataBtn.Image")));
            this.GetAirtableDataBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetAirtableDataBtn.Location = new System.Drawing.Point(35, 12);
            this.GetAirtableDataBtn.Name = "GetAirtableDataBtn";
            this.GetAirtableDataBtn.Size = new System.Drawing.Size(233, 62);
            this.GetAirtableDataBtn.TabIndex = 0;
            this.GetAirtableDataBtn.Text = "Récupérer les données Airtable";
            this.GetAirtableDataBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GetAirtableDataBtn.UseVisualStyleBackColor = true;
            this.GetAirtableDataBtn.Click += new System.EventHandler(this.GetAirtableDataBtn_Click);
            // 
            // VideoDGV
            // 
            this.VideoDGV.AllowUserToAddRows = false;
            this.VideoDGV.AllowUserToDeleteRows = false;
            this.VideoDGV.AllowUserToOrderColumns = true;
            this.VideoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideoDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.VideoDGV.Location = new System.Drawing.Point(12, 80);
            this.VideoDGV.MultiSelect = false;
            this.VideoDGV.Name = "VideoDGV";
            this.VideoDGV.ReadOnly = true;
            this.VideoDGV.RowHeadersVisible = false;
            this.VideoDGV.RowTemplate.Height = 25;
            this.VideoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VideoDGV.ShowEditingIcon = false;
            this.VideoDGV.Size = new System.Drawing.Size(776, 150);
            this.VideoDGV.TabIndex = 1;
            // 
            // UpdateLiveBtn
            // 
            this.UpdateLiveBtn.Location = new System.Drawing.Point(35, 295);
            this.UpdateLiveBtn.Name = "UpdateLiveBtn";
            this.UpdateLiveBtn.Size = new System.Drawing.Size(233, 56);
            this.UpdateLiveBtn.TabIndex = 6;
            this.UpdateLiveBtn.Text = "Mettre à jour le live sur YT";
            this.UpdateLiveBtn.UseVisualStyleBackColor = true;
            this.UpdateLiveBtn.Click += new System.EventHandler(this.UpdateLiveBtn_Click);
            // 
            // UploadMainVideoBtn
            // 
            this.UploadMainVideoBtn.Location = new System.Drawing.Point(35, 425);
            this.UploadMainVideoBtn.Name = "UploadMainVideoBtn";
            this.UploadMainVideoBtn.Size = new System.Drawing.Size(233, 40);
            this.UploadMainVideoBtn.TabIndex = 2;
            this.UploadMainVideoBtn.Text = "Mettre en ligne la vidéo principale...";
            this.UploadMainVideoBtn.UseVisualStyleBackColor = true;
            this.UploadMainVideoBtn.Click += new System.EventHandler(this.UploadMainVideoBtn_Click);
            // 
            // UpdateAirtableForLiveDataBtn
            // 
            this.UpdateAirtableForLiveDataBtn.Location = new System.Drawing.Point(35, 236);
            this.UpdateAirtableForLiveDataBtn.Name = "UpdateAirtableForLiveDataBtn";
            this.UpdateAirtableForLiveDataBtn.Size = new System.Drawing.Size(233, 53);
            this.UpdateAirtableForLiveDataBtn.TabIndex = 7;
            this.UpdateAirtableForLiveDataBtn.Text = "Récupère le lien du live, et met à jour dans Airtable";
            this.UpdateAirtableForLiveDataBtn.UseVisualStyleBackColor = true;
            this.UpdateAirtableForLiveDataBtn.Click += new System.EventHandler(this.UpdateAirtableForLiveDataBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Récupérer les données Airtable";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetAirtableDataBtn_Click);
            // 
            // VideoFileDialog
            // 
            this.VideoFileDialog.Filter = "Vidéos|*.mov,*.mp4|Tous les fichiers|*.*";
            this.VideoFileDialog.Title = "Sélectionner la vidéo à uploader";
            // 
            // UpdateMainVideoBtn
            // 
            this.UpdateMainVideoBtn.Location = new System.Drawing.Point(555, 268);
            this.UpdateMainVideoBtn.Name = "UpdateMainVideoBtn";
            this.UpdateMainVideoBtn.Size = new System.Drawing.Size(233, 44);
            this.UpdateMainVideoBtn.TabIndex = 9;
            this.UpdateMainVideoBtn.Text = "Mettre à jour la vidéo principale";
            this.UpdateMainVideoBtn.UseVisualStyleBackColor = true;
            this.UpdateMainVideoBtn.Click += new System.EventHandler(this.UpdateMainVideoBtn_Click);
            // 
            // CommentMainVideoBtn
            // 
            this.CommentMainVideoBtn.Location = new System.Drawing.Point(35, 472);
            this.CommentMainVideoBtn.Name = "CommentMainVideoBtn";
            this.CommentMainVideoBtn.Size = new System.Drawing.Size(232, 43);
            this.CommentMainVideoBtn.TabIndex = 10;
            this.CommentMainVideoBtn.Text = "Ajouter commentaire sur la vidéo principale";
            this.CommentMainVideoBtn.UseVisualStyleBackColor = true;
            this.CommentMainVideoBtn.Click += new System.EventHandler(this.CommentMainVideoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Au cas où...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentMainVideoBtn);
            this.Controls.Add(this.UpdateMainVideoBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateAirtableForLiveDataBtn);
            this.Controls.Add(this.UpdateLiveBtn);
            this.Controls.Add(this.UploadMainVideoBtn);
            this.Controls.Add(this.VideoDGV);
            this.Controls.Add(this.GetAirtableDataBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.VideoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetAirtableDataBtn;
        private System.Windows.Forms.DataGridView VideoDGV;
        private System.Windows.Forms.Button UpdateLiveBtn;
        private System.Windows.Forms.Button UploadMainVideoBtn;
        private System.Windows.Forms.Button UpdateAirtableForLiveDataBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog VideoFileDialog;
        private System.Windows.Forms.Button UpdateMainVideoBtn;
        private System.Windows.Forms.Button CommentMainVideoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

