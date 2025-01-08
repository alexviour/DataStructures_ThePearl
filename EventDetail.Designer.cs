namespace DataStructures
{
    partial class EventDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDetail));
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEvents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEvents.Location = new System.Drawing.Point(128, 258);
            this.dgvEvents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.RowHeadersWidth = 150;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.ShowCellToolTips = false;
            this.dgvEvents.ShowEditingIcon = false;
            this.dgvEvents.Size = new System.Drawing.Size(598, 236);
            this.dgvEvents.TabIndex = 22;
            // 
            // EventName
            // 
            this.EventName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventName.AutoSize = true;
            this.EventName.BackColor = System.Drawing.Color.Transparent;
            this.EventName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventName.ForeColor = System.Drawing.Color.Black;
            this.EventName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EventName.Location = new System.Drawing.Point(404, 154);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(35, 13);
            this.EventName.TabIndex = 23;
            this.EventName.Text = "label1";
            this.EventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(156)))), ((int)(((byte)(174)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(156)))), ((int)(((byte)(174)))));
            this.button5.Location = new System.Drawing.Point(80, 154);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 34);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.SystemColors.Control;
            this.btnJoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJoin.BackgroundImage")));
            this.btnJoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(209)))));
            this.btnJoin.Location = new System.Drawing.Point(638, 509);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(100, 32);
            this.btnJoin.TabIndex = 19;
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(209)))));
            this.button3.Location = new System.Drawing.Point(25, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 40);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DataStructures.Properties.Resources.THE_PEARL_s_UI__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EventDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 583);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventDetail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Label EventName;
    }
}