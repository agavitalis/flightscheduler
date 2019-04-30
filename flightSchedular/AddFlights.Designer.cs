namespace flightSchedular
{
    partial class AddFlights
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
            this.flight_name = new System.Windows.Forms.TextBox();
            this.flight_weight = new System.Windows.Forms.TextBox();
            this.register_flight = new System.Windows.Forms.Button();
            this.base_airport = new System.Windows.Forms.TextBox();
            this.destination_airport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrival_time = new System.Windows.Forms.DateTimePicker();
            this.departure_time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flight_name
            // 
            this.flight_name.Location = new System.Drawing.Point(297, 44);
            this.flight_name.Multiline = true;
            this.flight_name.Name = "flight_name";
            this.flight_name.Size = new System.Drawing.Size(290, 34);
            this.flight_name.TabIndex = 0;
            this.flight_name.Text = "Flight Name";
            this.flight_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flight_weight
            // 
            this.flight_weight.AcceptsReturn = true;
            this.flight_weight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flight_weight.Location = new System.Drawing.Point(634, 44);
            this.flight_weight.Multiline = true;
            this.flight_weight.Name = "flight_weight";
            this.flight_weight.Size = new System.Drawing.Size(293, 34);
            this.flight_weight.TabIndex = 1;
            this.flight_weight.Text = "Flight Weight";
            this.flight_weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_flight
            // 
            this.register_flight.BackColor = System.Drawing.Color.Chartreuse;
            this.register_flight.Location = new System.Drawing.Point(297, 258);
            this.register_flight.Name = "register_flight";
            this.register_flight.Size = new System.Drawing.Size(630, 39);
            this.register_flight.TabIndex = 4;
            this.register_flight.Text = "Register Flight";
            this.register_flight.UseVisualStyleBackColor = false;
            this.register_flight.Click += new System.EventHandler(this.register_flight_Click);
            // 
            // base_airport
            // 
            this.base_airport.Location = new System.Drawing.Point(297, 114);
            this.base_airport.Multiline = true;
            this.base_airport.Name = "base_airport";
            this.base_airport.Size = new System.Drawing.Size(290, 34);
            this.base_airport.TabIndex = 5;
            this.base_airport.Text = "Base Airport";
            this.base_airport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // destination_airport
            // 
            this.destination_airport.Location = new System.Drawing.Point(634, 114);
            this.destination_airport.Multiline = true;
            this.destination_airport.Name = "destination_airport";
            this.destination_airport.Size = new System.Drawing.Size(290, 34);
            this.destination_airport.TabIndex = 6;
            this.destination_airport.Text = "Destination Airport";
            this.destination_airport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Register a Flight here";
            // 
            // arrival_time
            // 
            this.arrival_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrival_time.Location = new System.Drawing.Point(631, 213);
            this.arrival_time.MinDate = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.ShowUpDown = true;
            this.arrival_time.Size = new System.Drawing.Size(293, 26);
            this.arrival_time.TabIndex = 9;
            // 
            // departure_time
            // 
            this.departure_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departure_time.Location = new System.Drawing.Point(297, 212);
            this.departure_time.MinDate = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            this.departure_time.Name = "departure_time";
            this.departure_time.ShowUpDown = true;
            this.departure_time.Size = new System.Drawing.Size(290, 26);
            this.departure_time.TabIndex = 8;
            this.departure_time.ValueChanged += new System.EventHandler(this.departure_time_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Departure Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arrival Time";
            // 
            // AddFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrival_time);
            this.Controls.Add(this.departure_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destination_airport);
            this.Controls.Add(this.base_airport);
            this.Controls.Add(this.register_flight);
            this.Controls.Add(this.flight_weight);
            this.Controls.Add(this.flight_name);
            this.Name = "AddFlights";
            this.Size = new System.Drawing.Size(1239, 327);
            this.Load += new System.EventHandler(this.AddFlights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox flight_name;
        private System.Windows.Forms.TextBox flight_weight;
        private System.Windows.Forms.Button register_flight;
        private System.Windows.Forms.TextBox base_airport;
        private System.Windows.Forms.TextBox destination_airport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker arrival_time;
        private System.Windows.Forms.DateTimePicker departure_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
