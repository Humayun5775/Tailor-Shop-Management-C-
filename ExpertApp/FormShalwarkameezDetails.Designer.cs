namespace ExpertApp
{
    partial class FormShalwarkameezDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShalwarkameezDetails));
            this.dt = new System.Windows.Forms.DataGridView();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbsr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(12, 214);
            this.dt.MultiSelect = false;
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt.RowTemplate.Height = 24;
            this.dt.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(2289, 907);
            this.dt.TabIndex = 1;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(665, 149);
            this.tbname.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(200, 22);
            this.tbname.TabIndex = 282;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(879, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 288;
            this.label2.Text = "Phone Number :";
            // 
            // tbnumber
            // 
            this.tbnumber.Location = new System.Drawing.Point(1023, 149);
            this.tbnumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(200, 22);
            this.tbnumber.TabIndex = 283;
            this.tbnumber.TextChanged += new System.EventHandler(this.tbnumber_TextChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCompanyName.Location = new System.Drawing.Point(510, 149);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(141, 20);
            this.lblCompanyName.TabIndex = 286;
            this.lblCompanyName.Text = "Customer Name :";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(1260, 122);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(162, 65);
            this.btnsearch.TabIndex = 290;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(1472, 122);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(156, 65);
            this.btnexit.TabIndex = 291;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("ROG Fonts", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(151, -1);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(1946, 101);
            this.label55.TabIndex = 297;
            this.label55.Text = "Search Details Shalwar Kameez";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 298;
            this.pictureBox1.TabStop = false;
            // 
            // tbsr
            // 
            this.tbsr.Location = new System.Drawing.Point(296, 147);
            this.tbsr.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.tbsr.Name = "tbsr";
            this.tbsr.Size = new System.Drawing.Size(200, 22);
            this.tbsr.TabIndex = 299;
            this.tbsr.TextChanged += new System.EventHandler(this.tbsr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(216, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 300;
            this.label1.Text = "Sr. No :";
            // 
            // FormShalwarkameezDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2313, 1133);
            this.Controls.Add(this.tbsr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnumber);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.dt);
            this.Name = "FormShalwarkameezDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbsr;
        private System.Windows.Forms.Label label1;
    }
}