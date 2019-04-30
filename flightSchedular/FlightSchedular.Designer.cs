namespace flightSchedular
{
    partial class FlightSchedular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightSchedular));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dashboard_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.view_all_flights_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.add_flight_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.schedule_flight_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.weather_button = new System.Windows.Forms.ToolStripButton();
            this.log_out_button = new System.Windows.Forms.ToolStripButton();
            this.welcome_textbox = new System.Windows.Forms.TextBox();
            this.view_all_flights1 = new flightSchedular.view_all_flights();
            this.generate_Schedule1 = new flightSchedular.Generate_Schedule();
            this.addFlights_tab = new flightSchedular.AddFlights();
            this.weather1 = new flightSchedular.weather();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard_button,
            this.toolStripSeparator1,
            this.view_all_flights_btn,
            this.toolStripSeparator4,
            this.add_flight_button,
            this.toolStripSeparator2,
            this.schedule_flight_button,
            this.toolStripSeparator3,
            this.weather_button,
            this.log_out_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1314, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dashboard_button
            // 
            this.dashboard_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dashboard_button.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_button.Image")));
            this.dashboard_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(81, 22);
            this.dashboard_button.Text = "DASHBOARD";
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // view_all_flights_btn
            // 
            this.view_all_flights_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.view_all_flights_btn.Image = ((System.Drawing.Image)(resources.GetObject("view_all_flights_btn.Image")));
            this.view_all_flights_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.view_all_flights_btn.Name = "view_all_flights_btn";
            this.view_all_flights_btn.Size = new System.Drawing.Size(109, 22);
            this.view_all_flights_btn.Text = "VIEW ALL FLIGHTS";
            this.view_all_flights_btn.ToolTipText = "VIEW ALL FLIGHTS\r\n\r\n";
            this.view_all_flights_btn.Click += new System.EventHandler(this.view_all_flights_btn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // add_flight_button
            // 
            this.add_flight_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add_flight_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_flight_button.Name = "add_flight_button";
            this.add_flight_button.Size = new System.Drawing.Size(83, 22);
            this.add_flight_button.Text = "ADD FLIGHTS";
            this.add_flight_button.Click += new System.EventHandler(this.add_flight_button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // schedule_flight_button
            // 
            this.schedule_flight_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.schedule_flight_button.Image = ((System.Drawing.Image)(resources.GetObject("schedule_flight_button.Image")));
            this.schedule_flight_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.schedule_flight_button.Name = "schedule_flight_button";
            this.schedule_flight_button.Size = new System.Drawing.Size(116, 22);
            this.schedule_flight_button.Text = "SCHEDULE FLIGHTS";
            this.schedule_flight_button.Click += new System.EventHandler(this.schedule_flight_button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // weather_button
            // 
            this.weather_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.weather_button.Image = ((System.Drawing.Image)(resources.GetObject("weather_button.Image")));
            this.weather_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.weather_button.Name = "weather_button";
            this.weather_button.Size = new System.Drawing.Size(64, 22);
            this.weather_button.Text = "WEATHER";
            this.weather_button.Click += new System.EventHandler(this.weather_button_Click);
            // 
            // log_out_button
            // 
            this.log_out_button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.log_out_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.log_out_button.Image = ((System.Drawing.Image)(resources.GetObject("log_out_button.Image")));
            this.log_out_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(61, 22);
            this.log_out_button.Text = "LOG OUT";
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // welcome_textbox
            // 
            this.welcome_textbox.BackColor = System.Drawing.Color.Azure;
            this.welcome_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.welcome_textbox.Enabled = false;
            this.welcome_textbox.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_textbox.Location = new System.Drawing.Point(173, 195);
            this.welcome_textbox.Margin = new System.Windows.Forms.Padding(25, 5, 25, 3);
            this.welcome_textbox.Multiline = true;
            this.welcome_textbox.Name = "welcome_textbox";
            this.welcome_textbox.ReadOnly = true;
            this.welcome_textbox.Size = new System.Drawing.Size(1000, 250);
            this.welcome_textbox.TabIndex = 1;
            this.welcome_textbox.Text = "HI!\r\nWELCOME TO OUR FLIGHT SCHEDULAR\r\n...we help you keep it organized ";
            this.welcome_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.welcome_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // view_all_flights1
            // 
            this.view_all_flights1.AutoScroll = true;
            this.view_all_flights1.Location = new System.Drawing.Point(108, 165);
            this.view_all_flights1.Name = "view_all_flights1";
            this.view_all_flights1.Size = new System.Drawing.Size(1125, 369);
            this.view_all_flights1.TabIndex = 4;
            this.view_all_flights1.Load += new System.EventHandler(this.view_all_flights1_Load);
            // 
            // generate_Schedule1
            // 
            this.generate_Schedule1.Location = new System.Drawing.Point(48, 165);
            this.generate_Schedule1.Name = "generate_Schedule1";
            this.generate_Schedule1.Size = new System.Drawing.Size(1239, 369);
            this.generate_Schedule1.TabIndex = 3;
            this.generate_Schedule1.Load += new System.EventHandler(this.generate_Schedule1_Load);
            // 
            // addFlights_tab
            // 
            this.addFlights_tab.Location = new System.Drawing.Point(48, 165);
            this.addFlights_tab.Name = "addFlights_tab";
            this.addFlights_tab.Size = new System.Drawing.Size(1239, 327);
            this.addFlights_tab.TabIndex = 2;
            // 
            // weather1
            // 
            this.weather1.Location = new System.Drawing.Point(97, 177);
            this.weather1.Name = "weather1";
            this.weather1.Size = new System.Drawing.Size(1147, 357);
            this.weather1.TabIndex = 5;
            this.weather1.Load += new System.EventHandler(this.weather1_Load);
            // 
            // FlightSchedular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1314, 561);
            this.Controls.Add(this.welcome_textbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.addFlights_tab);
            this.Controls.Add(this.generate_Schedule1);
            this.Controls.Add(this.view_all_flights1);
            this.Controls.Add(this.weather1);
            this.Name = "FlightSchedular";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FlightSchedular";
            this.Load += new System.EventHandler(this.dashboard_onload);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton dashboard_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton add_flight_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton schedule_flight_button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton weather_button;
        private System.Windows.Forms.ToolStripButton log_out_button;
        private System.Windows.Forms.TextBox welcome_textbox;
        private AddFlights addFlights_tab;
        private Generate_Schedule generate_Schedule1;
        private System.Windows.Forms.ToolStripButton view_all_flights_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private view_all_flights view_all_flights1;
        private weather weather1;
    }
}

