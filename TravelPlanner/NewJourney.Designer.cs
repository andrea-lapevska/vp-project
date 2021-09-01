namespace TravelPlanner
{
    partial class NewJourney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewJourney));
            this.lblStart = new System.Windows.Forms.Label();
            this.tbStartingPoint = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.lblAccomodation = new System.Windows.Forms.Label();
            this.tbAccomodation = new System.Windows.Forms.TextBox();
            this.lblSights = new System.Windows.Forms.Label();
            this.btnAddSight = new System.Windows.Forms.Button();
            this.tbNewSight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPackingItem = new System.Windows.Forms.TextBox();
            this.btnNewPackItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTransport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAccCost = new System.Windows.Forms.TextBox();
            this.lblPM = new System.Windows.Forms.Label();
            this.tbPocketMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblStart.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(24, 17);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(143, 30);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Starting Point:";
            // 
            // tbStartingPoint
            // 
            this.tbStartingPoint.Location = new System.Drawing.Point(29, 50);
            this.tbStartingPoint.Name = "tbStartingPoint";
            this.tbStartingPoint.Size = new System.Drawing.Size(144, 22);
            this.tbStartingPoint.TabIndex = 1;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(24, 78);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(115, 30);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "Destination:";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(29, 111);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(144, 22);
            this.tbDestination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(218, 279);
            this.calDate.MaxSelectionCount = 50;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 7;
            // 
            // lblAccomodation
            // 
            this.lblAccomodation.AutoSize = true;
            this.lblAccomodation.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccomodation.Location = new System.Drawing.Point(24, 138);
            this.lblAccomodation.Name = "lblAccomodation";
            this.lblAccomodation.Size = new System.Drawing.Size(141, 30);
            this.lblAccomodation.TabIndex = 8;
            this.lblAccomodation.Text = "Accomodation:";
            // 
            // tbAccomodation
            // 
            this.tbAccomodation.Location = new System.Drawing.Point(29, 171);
            this.tbAccomodation.Name = "tbAccomodation";
            this.tbAccomodation.Size = new System.Drawing.Size(144, 22);
            this.tbAccomodation.TabIndex = 9;
            // 
            // lblSights
            // 
            this.lblSights.AutoSize = true;
            this.lblSights.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSights.Location = new System.Drawing.Point(24, 287);
            this.lblSights.Name = "lblSights";
            this.lblSights.Size = new System.Drawing.Size(127, 30);
            this.lblSights.TabIndex = 12;
            this.lblSights.Text = "Sights to see:";
            // 
            // btnAddSight
            // 
            this.btnAddSight.Location = new System.Drawing.Point(29, 348);
            this.btnAddSight.Name = "btnAddSight";
            this.btnAddSight.Size = new System.Drawing.Size(144, 23);
            this.btnAddSight.TabIndex = 13;
            this.btnAddSight.Text = "Add To List";
            this.btnAddSight.UseVisualStyleBackColor = true;
            this.btnAddSight.Click += new System.EventHandler(this.btnAddSight_Click);
            // 
            // tbNewSight
            // 
            this.tbNewSight.Location = new System.Drawing.Point(29, 320);
            this.tbNewSight.Name = "tbNewSight";
            this.tbNewSight.Size = new System.Drawing.Size(144, 22);
            this.tbNewSight.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Packing List:";
            // 
            // tbPackingItem
            // 
            this.tbPackingItem.Location = new System.Drawing.Point(29, 231);
            this.tbPackingItem.Name = "tbPackingItem";
            this.tbPackingItem.Size = new System.Drawing.Size(144, 22);
            this.tbPackingItem.TabIndex = 16;
            // 
            // btnNewPackItem
            // 
            this.btnNewPackItem.Location = new System.Drawing.Point(29, 259);
            this.btnNewPackItem.Name = "btnNewPackItem";
            this.btnNewPackItem.Size = new System.Drawing.Size(144, 23);
            this.btnNewPackItem.TabIndex = 17;
            this.btnNewPackItem.Text = "Add To Packing List";
            this.btnNewPackItem.UseVisualStyleBackColor = true;
            this.btnNewPackItem.Click += new System.EventHandler(this.btnNewPackItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Transport cost:";
            // 
            // tbTransport
            // 
            this.tbTransport.Location = new System.Drawing.Point(287, 77);
            this.tbTransport.Name = "tbTransport";
            this.tbTransport.Size = new System.Drawing.Size(100, 22);
            this.tbTransport.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "Accomodation cost:";
            // 
            // tbAccCost
            // 
            this.tbAccCost.Location = new System.Drawing.Point(290, 144);
            this.tbAccCost.Name = "tbAccCost";
            this.tbAccCost.Size = new System.Drawing.Size(100, 22);
            this.tbAccCost.TabIndex = 22;
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPM.Location = new System.Drawing.Point(284, 173);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(139, 30);
            this.lblPM.TabIndex = 23;
            this.lblPM.Text = "Pocket Money:";
            // 
            // tbPocketMoney
            // 
            this.tbPocketMoney.Location = new System.Drawing.Point(290, 206);
            this.tbPocketMoney.Name = "tbPocketMoney";
            this.tbPocketMoney.Size = new System.Drawing.Size(100, 22);
            this.tbPocketMoney.TabIndex = 24;
            // 
            // NewJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(576, 508);
            this.Controls.Add(this.tbPocketMoney);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.tbAccCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTransport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewPackItem);
            this.Controls.Add(this.tbPackingItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewSight);
            this.Controls.Add(this.btnAddSight);
            this.Controls.Add(this.lblSights);
            this.Controls.Add(this.tbAccomodation);
            this.Controls.Add(this.lblAccomodation);
            this.Controls.Add(this.calDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.tbStartingPoint);
            this.Controls.Add(this.lblStart);
            this.Name = "NewJourney";
            this.Text = "New Journey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox tbStartingPoint;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.Label lblAccomodation;
        private System.Windows.Forms.TextBox tbAccomodation;
        private System.Windows.Forms.Label lblSights;
        private System.Windows.Forms.Button btnAddSight;
        private System.Windows.Forms.TextBox tbNewSight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPackingItem;
        private System.Windows.Forms.Button btnNewPackItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTransport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAccCost;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.TextBox tbPocketMoney;
    }
}