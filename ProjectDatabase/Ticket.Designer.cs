namespace ProjectDatabase
{
    partial class Ticket
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
            this.TicketGrid = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.Panel();
            this.bid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.ArriveTime = new System.Windows.Forms.Label();
            this.DepartTime = new System.Windows.Forms.Label();
            this.Acompany = new System.Windows.Forms.Label();
            this.toSmall = new System.Windows.Forms.Label();
            this.fromSmall = new System.Windows.Forms.Label();
            this.fromToLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aname = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGrid)).BeginInit();
            this.Departure.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketGrid
            // 
            this.TicketGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TicketGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TicketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGrid.Location = new System.Drawing.Point(-3, 205);
            this.TicketGrid.Name = "TicketGrid";
            this.TicketGrid.Size = new System.Drawing.Size(966, 333);
            this.TicketGrid.TabIndex = 0;
            // 
            // Departure
            // 
            this.Departure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Departure.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Departure.Controls.Add(this.aname);
            this.Departure.Controls.Add(this.label60);
            this.Departure.Controls.Add(this.label7);
            this.Departure.Controls.Add(this.label8);
            this.Departure.Controls.Add(this.bid);
            this.Departure.Controls.Add(this.label9);
            this.Departure.Controls.Add(this.label22);
            this.Departure.Controls.Add(this.TotalTime);
            this.Departure.Controls.Add(this.ArriveTime);
            this.Departure.Controls.Add(this.DepartTime);
            this.Departure.Controls.Add(this.Acompany);
            this.Departure.Controls.Add(this.toSmall);
            this.Departure.Controls.Add(this.fromSmall);
            this.Departure.Controls.Add(this.fromToLabel);
            this.Departure.Controls.Add(this.price);
            this.Departure.Controls.Add(this.label6);
            this.Departure.Controls.Add(this.label5);
            this.Departure.Controls.Add(this.label4);
            this.Departure.Controls.Add(this.label3);
            this.Departure.Controls.Add(this.label1);
            this.Departure.Controls.Add(this.label2);
            this.Departure.Location = new System.Drawing.Point(-3, 2);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(966, 206);
            this.Departure.TabIndex = 5;
            // 
            // bid
            // 
            this.bid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bid.AutoSize = true;
            this.bid.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bid.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bid.Location = new System.Drawing.Point(325, 176);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(65, 19);
            this.bid.TabIndex = 58;
            this.bid.Text = "-------";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(325, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "Booking ID";
            // 
            // TotalTime
            // 
            this.TotalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTime.AutoSize = true;
            this.TotalTime.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTime.Location = new System.Drawing.Point(661, 89);
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(87, 19);
            this.TotalTime.TabIndex = 52;
            this.TotalTime.Text = "00:00:00";
            // 
            // ArriveTime
            // 
            this.ArriveTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArriveTime.AutoSize = true;
            this.ArriveTime.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArriveTime.Location = new System.Drawing.Point(506, 89);
            this.ArriveTime.Name = "ArriveTime";
            this.ArriveTime.Size = new System.Drawing.Size(87, 19);
            this.ArriveTime.TabIndex = 51;
            this.ArriveTime.Text = "00:00:00";
            // 
            // DepartTime
            // 
            this.DepartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepartTime.AutoSize = true;
            this.DepartTime.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartTime.Location = new System.Drawing.Point(325, 89);
            this.DepartTime.Name = "DepartTime";
            this.DepartTime.Size = new System.Drawing.Size(87, 19);
            this.DepartTime.TabIndex = 50;
            this.DepartTime.Text = "00:00:00";
            // 
            // Acompany
            // 
            this.Acompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Acompany.AutoSize = true;
            this.Acompany.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Acompany.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Acompany.Location = new System.Drawing.Point(88, 89);
            this.Acompany.Name = "Acompany";
            this.Acompany.Size = new System.Drawing.Size(85, 19);
            this.Acompany.TabIndex = 49;
            this.Acompany.Text = "Company";
            // 
            // toSmall
            // 
            this.toSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toSmall.AutoSize = true;
            this.toSmall.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSmall.Location = new System.Drawing.Point(507, 116);
            this.toSmall.Name = "toSmall";
            this.toSmall.Size = new System.Drawing.Size(0, 14);
            this.toSmall.TabIndex = 48;
            // 
            // fromSmall
            // 
            this.fromSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromSmall.AutoSize = true;
            this.fromSmall.Font = new System.Drawing.Font("SF Pro Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSmall.Location = new System.Drawing.Point(326, 116);
            this.fromSmall.Name = "fromSmall";
            this.fromSmall.Size = new System.Drawing.Size(0, 14);
            this.fromSmall.TabIndex = 47;
            // 
            // fromToLabel
            // 
            this.fromToLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromToLabel.AutoSize = true;
            this.fromToLabel.Font = new System.Drawing.Font("SF Pro Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromToLabel.Location = new System.Drawing.Point(87, 17);
            this.fromToLabel.Name = "fromToLabel";
            this.fromToLabel.Size = new System.Drawing.Size(0, 25);
            this.fromToLabel.TabIndex = 46;
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(829, 89);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 19);
            this.price.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(829, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(661, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Total Time";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Depart";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Arrive in";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "-->";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Airplane Company";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("SF Pro Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(615, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(265, 25);
            this.label22.TabIndex = 54;
            this.label22.Text = "Choose departure flight";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(506, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "-------";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Seat ID";
            // 
            // aname
            // 
            this.aname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aname.AutoSize = true;
            this.aname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aname.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.aname.Location = new System.Drawing.Point(88, 176);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(65, 19);
            this.aname.TabIndex = 62;
            this.aname.Text = "-------";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("SF Pro Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(88, 148);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(127, 19);
            this.label60.TabIndex = 61;
            this.label60.Text = "Airplane Name";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 537);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.TicketGrid);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketGrid)).EndInit();
            this.Departure.ResumeLayout(false);
            this.Departure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketGrid;
        private System.Windows.Forms.Panel Departure;
        private System.Windows.Forms.Label bid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label ArriveTime;
        private System.Windows.Forms.Label DepartTime;
        private System.Windows.Forms.Label Acompany;
        private System.Windows.Forms.Label toSmall;
        private System.Windows.Forms.Label fromSmall;
        private System.Windows.Forms.Label fromToLabel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label aname;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}