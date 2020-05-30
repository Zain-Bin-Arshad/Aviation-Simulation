namespace SchedulingOnPriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crashedlabel = new System.Windows.Forms.Label();
            this.landedlabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.planelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.showQueue_button = new System.Windows.Forms.Button();
            this.planeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeID_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.fuel_textBox = new System.Windows.Forms.TextBox();
            this.rate_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priority_textBox = new System.Windows.Forms.TextBox();
            this.insertPlane_button = new System.Windows.Forms.Button();
            this.generatePlane_button = new System.Windows.Forms.Button();
            this.groupBox_planeInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeDataGridView)).BeginInit();
            this.groupBox_planeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crashedlabel);
            this.groupBox1.Controls.Add(this.landedlabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.planelabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.run_button);
            this.groupBox1.Controls.Add(this.showQueue_button);
            this.groupBox1.Controls.Add(this.planeDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes Information";
            // 
            // crashedlabel
            // 
            this.crashedlabel.AutoSize = true;
            this.crashedlabel.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashedlabel.ForeColor = System.Drawing.Color.Red;
            this.crashedlabel.Location = new System.Drawing.Point(880, 278);
            this.crashedlabel.Name = "crashedlabel";
            this.crashedlabel.Size = new System.Drawing.Size(25, 30);
            this.crashedlabel.TabIndex = 25;
            this.crashedlabel.Text = "0";
            this.crashedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // landedlabel
            // 
            this.landedlabel.AutoSize = true;
            this.landedlabel.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landedlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.landedlabel.Location = new System.Drawing.Point(880, 204);
            this.landedlabel.Name = "landedlabel";
            this.landedlabel.Size = new System.Drawing.Size(25, 30);
            this.landedlabel.TabIndex = 24;
            this.landedlabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(817, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Planes Landed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(810, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "Planes Crashed";
            // 
            // planelabel
            // 
            this.planelabel.AutoSize = true;
            this.planelabel.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.planelabel.Location = new System.Drawing.Point(880, 120);
            this.planelabel.Name = "planelabel";
            this.planelabel.Size = new System.Drawing.Size(25, 30);
            this.planelabel.TabIndex = 21;
            this.planelabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(825, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total Planes";
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(227, 35);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(177, 27);
            this.run_button.TabIndex = 18;
            this.run_button.Text = "Run Simulation";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // showQueue_button
            // 
            this.showQueue_button.Location = new System.Drawing.Point(11, 35);
            this.showQueue_button.Name = "showQueue_button";
            this.showQueue_button.Size = new System.Drawing.Size(177, 27);
            this.showQueue_button.TabIndex = 12;
            this.showQueue_button.Text = "Show Planes Queue";
            this.showQueue_button.UseVisualStyleBackColor = true;
            this.showQueue_button.Click += new System.EventHandler(this.showQueue_button_Click);
            // 
            // planeDataGridView
            // 
            this.planeDataGridView.AllowUserToAddRows = false;
            this.planeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.planeDataGridView.Location = new System.Drawing.Point(11, 70);
            this.planeDataGridView.Name = "planeDataGridView";
            this.planeDataGridView.Size = new System.Drawing.Size(793, 283);
            this.planeDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Plane ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Shows the ID of each Process";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DividerWidth = 3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Passengers";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Shows the Arrival Time of each Process";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DividerWidth = 3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Runway Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "Shows the Burst Time of each Process";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DividerWidth = 3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Remaining Fuel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.ToolTipText = "Shows the TurnAround Time of each Process";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DividerWidth = 3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Buring Rate/Sec";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.ToolTipText = "Shows the Waiting Time of each Process";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DividerWidth = 3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Priority";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // planeID_label
            // 
            this.planeID_label.AutoSize = true;
            this.planeID_label.Location = new System.Drawing.Point(7, 52);
            this.planeID_label.Name = "planeID_label";
            this.planeID_label.Size = new System.Drawing.Size(72, 20);
            this.planeID_label.TabIndex = 0;
            this.planeID_label.Text = "Plane ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fuel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passengers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Burning Rate/Sec. ";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(111, 49);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(77, 27);
            this.id_textBox.TabIndex = 4;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(111, 85);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.ReadOnly = true;
            this.pass_textBox.Size = new System.Drawing.Size(77, 27);
            this.pass_textBox.TabIndex = 5;
            // 
            // fuel_textBox
            // 
            this.fuel_textBox.Location = new System.Drawing.Point(340, 43);
            this.fuel_textBox.Name = "fuel_textBox";
            this.fuel_textBox.ReadOnly = true;
            this.fuel_textBox.Size = new System.Drawing.Size(77, 27);
            this.fuel_textBox.TabIndex = 6;
            // 
            // rate_textBox
            // 
            this.rate_textBox.Location = new System.Drawing.Point(340, 88);
            this.rate_textBox.Name = "rate_textBox";
            this.rate_textBox.ReadOnly = true;
            this.rate_textBox.Size = new System.Drawing.Size(77, 27);
            this.rate_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priority";
            // 
            // priority_textBox
            // 
            this.priority_textBox.Location = new System.Drawing.Point(520, 43);
            this.priority_textBox.Name = "priority_textBox";
            this.priority_textBox.ReadOnly = true;
            this.priority_textBox.Size = new System.Drawing.Size(77, 27);
            this.priority_textBox.TabIndex = 9;
            // 
            // insertPlane_button
            // 
            this.insertPlane_button.Location = new System.Drawing.Point(562, 92);
            this.insertPlane_button.Name = "insertPlane_button";
            this.insertPlane_button.Size = new System.Drawing.Size(87, 27);
            this.insertPlane_button.TabIndex = 10;
            this.insertPlane_button.Text = "Insert";
            this.insertPlane_button.UseVisualStyleBackColor = true;
            this.insertPlane_button.Click += new System.EventHandler(this.insertPlane_button_Click);
            // 
            // generatePlane_button
            // 
            this.generatePlane_button.Location = new System.Drawing.Point(442, 92);
            this.generatePlane_button.Name = "generatePlane_button";
            this.generatePlane_button.Size = new System.Drawing.Size(114, 27);
            this.generatePlane_button.TabIndex = 11;
            this.generatePlane_button.Text = "Generate";
            this.generatePlane_button.UseVisualStyleBackColor = true;
            this.generatePlane_button.Click += new System.EventHandler(this.generatePlane_button_Click);
            // 
            // groupBox_planeInfo
            // 
            this.groupBox_planeInfo.Controls.Add(this.pictureBox1);
            this.groupBox_planeInfo.Controls.Add(this.generatePlane_button);
            this.groupBox_planeInfo.Controls.Add(this.insertPlane_button);
            this.groupBox_planeInfo.Controls.Add(this.priority_textBox);
            this.groupBox_planeInfo.Controls.Add(this.label4);
            this.groupBox_planeInfo.Controls.Add(this.rate_textBox);
            this.groupBox_planeInfo.Controls.Add(this.fuel_textBox);
            this.groupBox_planeInfo.Controls.Add(this.pass_textBox);
            this.groupBox_planeInfo.Controls.Add(this.id_textBox);
            this.groupBox_planeInfo.Controls.Add(this.label1);
            this.groupBox_planeInfo.Controls.Add(this.label3);
            this.groupBox_planeInfo.Controls.Add(this.label2);
            this.groupBox_planeInfo.Controls.Add(this.planeID_label);
            this.groupBox_planeInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 10.75F, System.Drawing.FontStyle.Bold);
            this.groupBox_planeInfo.Location = new System.Drawing.Point(15, 2);
            this.groupBox_planeInfo.Name = "groupBox_planeInfo";
            this.groupBox_planeInfo.Size = new System.Drawing.Size(983, 137);
            this.groupBox_planeInfo.TabIndex = 0;
            this.groupBox_planeInfo.TabStop = false;
            this.groupBox_planeInfo.Text = "New Plane";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 107);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1013, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_planeInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Name = "Form1";
            this.Text = "Air Traffic Control (Simulating OS\'s Scheduling techniques)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeDataGridView)).EndInit();
            this.groupBox_planeInfo.ResumeLayout(false);
            this.groupBox_planeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView planeDataGridView;
        private System.Windows.Forms.Button showQueue_button;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label crashedlabel;
        private System.Windows.Forms.Label landedlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label planelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label planeID_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.TextBox fuel_textBox;
        private System.Windows.Forms.TextBox rate_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priority_textBox;
        private System.Windows.Forms.Button insertPlane_button;
        private System.Windows.Forms.Button generatePlane_button;
        private System.Windows.Forms.GroupBox groupBox_planeInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

