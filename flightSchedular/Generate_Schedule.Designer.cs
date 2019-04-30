namespace flightSchedular
{
    partial class Generate_Schedule
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
            this.view_previous_schedule_btn = new System.Windows.Forms.Button();
            this.generate_new_schedule_btn = new System.Windows.Forms.Button();
            this.delete_schedule_btn = new System.Windows.Forms.Button();
            this.schedule_display = new System.Windows.Forms.DataGridView();
            this.schedule_message = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_display)).BeginInit();
            this.SuspendLayout();
            // 
            // view_previous_schedule_btn
            // 
            this.view_previous_schedule_btn.BackColor = System.Drawing.Color.LightGray;
            this.view_previous_schedule_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_previous_schedule_btn.Location = new System.Drawing.Point(24, 123);
            this.view_previous_schedule_btn.Name = "view_previous_schedule_btn";
            this.view_previous_schedule_btn.Size = new System.Drawing.Size(138, 50);
            this.view_previous_schedule_btn.TabIndex = 1;
            this.view_previous_schedule_btn.Text = "View Previous Schedule";
            this.view_previous_schedule_btn.UseVisualStyleBackColor = false;
            this.view_previous_schedule_btn.Click += new System.EventHandler(this.view_previous_schedule_btn_Click);
            // 
            // generate_new_schedule_btn
            // 
            this.generate_new_schedule_btn.BackColor = System.Drawing.Color.LightGray;
            this.generate_new_schedule_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_new_schedule_btn.Location = new System.Drawing.Point(24, 41);
            this.generate_new_schedule_btn.Name = "generate_new_schedule_btn";
            this.generate_new_schedule_btn.Size = new System.Drawing.Size(138, 50);
            this.generate_new_schedule_btn.TabIndex = 2;
            this.generate_new_schedule_btn.Text = "Generate New Schedule";
            this.generate_new_schedule_btn.UseVisualStyleBackColor = false;
            this.generate_new_schedule_btn.Click += new System.EventHandler(this.generate_new_schedule_btn_Click);
            // 
            // delete_schedule_btn
            // 
            this.delete_schedule_btn.BackColor = System.Drawing.Color.Firebrick;
            this.delete_schedule_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_schedule_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.delete_schedule_btn.Location = new System.Drawing.Point(24, 293);
            this.delete_schedule_btn.Name = "delete_schedule_btn";
            this.delete_schedule_btn.Size = new System.Drawing.Size(138, 50);
            this.delete_schedule_btn.TabIndex = 1;
            this.delete_schedule_btn.Text = "Delete all Schedules";
            this.delete_schedule_btn.UseVisualStyleBackColor = false;
            this.delete_schedule_btn.Click += new System.EventHandler(this.delete_previous_schedules_btn_Click);
            // 
            // schedule_display
            // 
            this.schedule_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedule_display.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.schedule_display.Location = new System.Drawing.Point(215, 41);
            this.schedule_display.Name = "schedule_display";
            this.schedule_display.ReadOnly = true;
            this.schedule_display.Size = new System.Drawing.Size(936, 302);
            this.schedule_display.TabIndex = 3;
            this.schedule_display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schedule_display_CellContentClick);
            // 
            // schedule_message
            // 
            this.schedule_message.BackColor = System.Drawing.Color.Azure;
            this.schedule_message.Cursor = System.Windows.Forms.Cursors.No;
            this.schedule_message.Enabled = false;
            this.schedule_message.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule_message.Location = new System.Drawing.Point(307, 78);
            this.schedule_message.Margin = new System.Windows.Forms.Padding(25, 5, 25, 3);
            this.schedule_message.Multiline = true;
            this.schedule_message.Name = "schedule_message";
            this.schedule_message.ReadOnly = true;
            this.schedule_message.Size = new System.Drawing.Size(710, 206);
            this.schedule_message.TabIndex = 4;
            this.schedule_message.Text = "Generate or View Previous Schedules";
            this.schedule_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.schedule_message.TextChanged += new System.EventHandler(this.schedule_message_TextChanged);
            // 
            // Generate_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedule_message);
            this.Controls.Add(this.schedule_display);
            this.Controls.Add(this.generate_new_schedule_btn);
            this.Controls.Add(this.delete_schedule_btn);
            this.Controls.Add(this.view_previous_schedule_btn);
            this.Name = "Generate_Schedule";
            this.Size = new System.Drawing.Size(1213, 369);
            ((System.ComponentModel.ISupportInitialize)(this.schedule_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_previous_schedule_btn;
        private System.Windows.Forms.Button generate_new_schedule_btn;
        private System.Windows.Forms.Button delete_schedule_btn;
        private System.Windows.Forms.DataGridView schedule_display;
        private System.Windows.Forms.TextBox schedule_message;
    }
}
