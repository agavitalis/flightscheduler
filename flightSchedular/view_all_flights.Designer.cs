namespace flightSchedular
{
    partial class view_all_flights
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
            this.components = new System.ComponentModel.Container();
            this.ViewFlights = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.flightScheduleDataSet1 = new flightSchedular.FlightScheduleDataSet1();
            this.flightdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flight_detailsTableAdapter = new flightSchedular.FlightScheduleDataSet1TableAdapters.flight_detailsTableAdapter();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.delete_flight = new System.Windows.Forms.Button();
            this.flight_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewFlights
            // 
            this.ViewFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewFlights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ViewFlights.Location = new System.Drawing.Point(82, 57);
            this.ViewFlights.Name = "ViewFlights";
            this.ViewFlights.ReadOnly = true;
            this.ViewFlights.Size = new System.Drawing.Size(909, 309);
            this.ViewFlights.TabIndex = 0;
            this.ViewFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewFlights_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "These are your registered flights";
            // 
            // flightScheduleDataSet1
            // 
            this.flightScheduleDataSet1.DataSetName = "FlightScheduleDataSet1";
            this.flightScheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightdetailsBindingSource
            // 
            this.flightdetailsBindingSource.DataMember = "flight_details";
            this.flightdetailsBindingSource.DataSource = this.flightScheduleDataSet1;
            // 
            // flight_detailsTableAdapter
            // 
            this.flight_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(1039, 294);
            this.refresh_btn.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(110, 40);
            this.refresh_btn.TabIndex = 9;
            this.refresh_btn.Text = "REFRESH";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // delete_flight
            // 
            this.delete_flight.BackColor = System.Drawing.Color.Red;
            this.delete_flight.Location = new System.Drawing.Point(1037, 123);
            this.delete_flight.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.delete_flight.Name = "delete_flight";
            this.delete_flight.Size = new System.Drawing.Size(110, 39);
            this.delete_flight.TabIndex = 10;
            this.delete_flight.Text = "DELETE FLIGHT";
            this.delete_flight.UseVisualStyleBackColor = false;
            this.delete_flight.Click += new System.EventHandler(this.delete_flight_Click);
            // 
            // flight_id
            // 
            this.flight_id.Location = new System.Drawing.Point(1038, 57);
            this.flight_id.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.flight_id.Multiline = true;
            this.flight_id.Name = "flight_id";
            this.flight_id.Size = new System.Drawing.Size(110, 36);
            this.flight_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1034, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Flight ID to Delete";
            // 
            // view_all_flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flight_id);
            this.Controls.Add(this.delete_flight);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewFlights);
            this.Name = "view_all_flights";
            this.Size = new System.Drawing.Size(1221, 369);
            ((System.ComponentModel.ISupportInitialize)(this.ViewFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewFlights;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource flightdetailsBindingSource;
        private FlightScheduleDataSet1 flightScheduleDataSet1;
        private FlightScheduleDataSet1TableAdapters.flight_detailsTableAdapter flight_detailsTableAdapter;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button delete_flight;
        private System.Windows.Forms.TextBox flight_id;
        private System.Windows.Forms.Label label2;
    }
}
