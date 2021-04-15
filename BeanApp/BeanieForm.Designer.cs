namespace BeanieApplication
{
    partial class BeanieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeanieForm));
            this.ScanBeanJarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBeanJars = new System.Windows.Forms.GroupBox();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstJars = new System.Windows.Forms.ListBox();
            this.btnAddJar = new System.Windows.Forms.Button();
            this.updnCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtStatistics = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBeanJars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanBeanJarButton
            // 
            this.ScanBeanJarButton.Location = new System.Drawing.Point(389, 192);
            this.ScanBeanJarButton.Name = "ScanBeanJarButton";
            this.ScanBeanJarButton.Size = new System.Drawing.Size(286, 23);
            this.ScanBeanJarButton.TabIndex = 0;
            this.ScanBeanJarButton.Text = "Fill All Jars and Scan";
            this.ScanBeanJarButton.UseVisualStyleBackColor = true;
            this.ScanBeanJarButton.Click += new System.EventHandler(this.FillAndScanButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::BeanieApplication.Properties.Resources.beanjar;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 329);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpBeanJars
            // 
            this.grpBeanJars.Controls.Add(this.btnRemoveAll);
            this.grpBeanJars.Controls.Add(this.btnRemove);
            this.grpBeanJars.Controls.Add(this.lstJars);
            this.grpBeanJars.Controls.Add(this.btnAddJar);
            this.grpBeanJars.Controls.Add(this.updnCapacity);
            this.grpBeanJars.Controls.Add(this.lblCapacity);
            this.grpBeanJars.Location = new System.Drawing.Point(389, 12);
            this.grpBeanJars.Name = "grpBeanJars";
            this.grpBeanJars.Size = new System.Drawing.Size(286, 142);
            this.grpBeanJars.TabIndex = 6;
            this.grpBeanJars.TabStop = false;
            this.grpBeanJars.Text = "Bean Jars";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(174, 115);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(106, 20);
            this.btnRemoveAll.TabIndex = 9;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(174, 89);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 20);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveJar_Click);
            // 
            // lstJars
            // 
            this.lstJars.FormattingEnabled = true;
            this.lstJars.Location = new System.Drawing.Point(9, 40);
            this.lstJars.Name = "lstJars";
            this.lstJars.Size = new System.Drawing.Size(159, 95);
            this.lstJars.TabIndex = 7;
            // 
            // btnAddJar
            // 
            this.btnAddJar.Location = new System.Drawing.Point(174, 14);
            this.btnAddJar.Name = "btnAddJar";
            this.btnAddJar.Size = new System.Drawing.Size(106, 20);
            this.btnAddJar.TabIndex = 6;
            this.btnAddJar.Text = "Add Empty Jar";
            this.btnAddJar.UseVisualStyleBackColor = true;
            this.btnAddJar.Click += new System.EventHandler(this.btnAddJar_Click);
            // 
            // updnCapacity
            // 
            this.updnCapacity.Location = new System.Drawing.Point(63, 14);
            this.updnCapacity.Name = "updnCapacity";
            this.updnCapacity.Size = new System.Drawing.Size(105, 20);
            this.updnCapacity.TabIndex = 5;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(6, 16);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity:";
            // 
            // txtStatistics
            // 
            this.txtStatistics.Location = new System.Drawing.Point(389, 222);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.ReadOnly = true;
            this.txtStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatistics.Size = new System.Drawing.Size(286, 117);
            this.txtStatistics.TabIndex = 7;
            // 
            // BeanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.grpBeanJars);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScanBeanJarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BeanieForm";
            this.Text = "Beanie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBeanJars.ResumeLayout(false);
            this.grpBeanJars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScanBeanJarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBeanJars;
        private System.Windows.Forms.ListBox lstJars;
        private System.Windows.Forms.Button btnAddJar;
        private System.Windows.Forms.NumericUpDown updnCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TextBox txtStatistics;
    }
}

