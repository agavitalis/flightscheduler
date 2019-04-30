namespace flightSchedular
{
    partial class weather
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
            this.rainy_btn = new System.Windows.Forms.Button();
            this.rainy_textbox = new System.Windows.Forms.RichTextBox();
            this.humidy_textbox = new System.Windows.Forms.RichTextBox();
            this.bright_textbox = new System.Windows.Forms.RichTextBox();
            this.humid_btn = new System.Windows.Forms.Button();
            this.bright_btn = new System.Windows.Forms.Button();
            this.clear_weather_btn = new System.Windows.Forms.Button();
            this.display_weather_textbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_weather = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rainy_btn
            // 
            this.rainy_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rainy_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainy_btn.Location = new System.Drawing.Point(195, 222);
            this.rainy_btn.Name = "rainy_btn";
            this.rainy_btn.Size = new System.Drawing.Size(126, 42);
            this.rainy_btn.TabIndex = 0;
            this.rainy_btn.Text = "Set as Current Weather Condition";
            this.rainy_btn.UseVisualStyleBackColor = false;
            this.rainy_btn.Click += new System.EventHandler(this.rainy_btn_Click);
            // 
            // rainy_textbox
            // 
            this.rainy_textbox.AcceptsTab = true;
            this.rainy_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.rainy_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainy_textbox.Location = new System.Drawing.Point(3, 222);
            this.rainy_textbox.Name = "rainy_textbox";
            this.rainy_textbox.ReadOnly = true;
            this.rainy_textbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rainy_textbox.Size = new System.Drawing.Size(186, 42);
            this.rainy_textbox.TabIndex = 2;
            this.rainy_textbox.Text = "\t  RAINY";
            // 
            // humidy_textbox
            // 
            this.humidy_textbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.humidy_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.humidy_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidy_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.humidy_textbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.humidy_textbox.Location = new System.Drawing.Point(3, 126);
            this.humidy_textbox.Name = "humidy_textbox";
            this.humidy_textbox.ReadOnly = true;
            this.humidy_textbox.Size = new System.Drawing.Size(186, 42);
            this.humidy_textbox.TabIndex = 4;
            this.humidy_textbox.Text = "\tHUMIDY";
            this.humidy_textbox.TextChanged += new System.EventHandler(this.humidy_textbox_TextChanged);
            // 
            // bright_textbox
            // 
            this.bright_textbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.bright_textbox.Cursor = System.Windows.Forms.Cursors.No;
            this.bright_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bright_textbox.Location = new System.Drawing.Point(3, 39);
            this.bright_textbox.Name = "bright_textbox";
            this.bright_textbox.Size = new System.Drawing.Size(186, 42);
            this.bright_textbox.TabIndex = 4;
            this.bright_textbox.Text = "\tBRIGHT";
            // 
            // humid_btn
            // 
            this.humid_btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.humid_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humid_btn.Location = new System.Drawing.Point(195, 126);
            this.humid_btn.Name = "humid_btn";
            this.humid_btn.Size = new System.Drawing.Size(126, 42);
            this.humid_btn.TabIndex = 5;
            this.humid_btn.Text = "Set as Current Weather Condition";
            this.humid_btn.UseVisualStyleBackColor = false;
            this.humid_btn.Click += new System.EventHandler(this.humid_btn_Click);
            // 
            // bright_btn
            // 
            this.bright_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.bright_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bright_btn.Location = new System.Drawing.Point(195, 39);
            this.bright_btn.Name = "bright_btn";
            this.bright_btn.Size = new System.Drawing.Size(126, 42);
            this.bright_btn.TabIndex = 5;
            this.bright_btn.Text = "Set as Current Weather Condition";
            this.bright_btn.UseVisualStyleBackColor = false;
            this.bright_btn.Click += new System.EventHandler(this.bright_btn_Click);
            // 
            // clear_weather_btn
            // 
            this.clear_weather_btn.BackColor = System.Drawing.Color.Red;
            this.clear_weather_btn.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_weather_btn.Location = new System.Drawing.Point(3, 293);
            this.clear_weather_btn.Name = "clear_weather_btn";
            this.clear_weather_btn.Size = new System.Drawing.Size(318, 42);
            this.clear_weather_btn.TabIndex = 6;
            this.clear_weather_btn.Text = "Clear all Weather Conditions";
            this.clear_weather_btn.UseVisualStyleBackColor = false;
            this.clear_weather_btn.Click += new System.EventHandler(this.clear_weather_btn_Click);
            // 
            // display_weather_textbox
            // 
            this.display_weather_textbox.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_weather_textbox.Location = new System.Drawing.Point(371, 39);
            this.display_weather_textbox.Name = "display_weather_textbox";
            this.display_weather_textbox.ReadOnly = true;
            this.display_weather_textbox.Size = new System.Drawing.Size(773, 296);
            this.display_weather_textbox.TabIndex = 7;
            this.display_weather_textbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set the current weather condition";
            // 
            // label_weather
            // 
            this.label_weather.AutoSize = true;
            this.label_weather.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weather.Location = new System.Drawing.Point(374, 169);
            this.label_weather.Name = "label_weather";
            this.label_weather.Size = new System.Drawing.Size(354, 28);
            this.label_weather.TabIndex = 10;
            this.label_weather.Text = "Set Current Weather Cndition Here";
            // 
            // weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_weather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_weather_textbox);
            this.Controls.Add(this.clear_weather_btn);
            this.Controls.Add(this.bright_btn);
            this.Controls.Add(this.humid_btn);
            this.Controls.Add(this.bright_textbox);
            this.Controls.Add(this.humidy_textbox);
            this.Controls.Add(this.rainy_textbox);
            this.Controls.Add(this.rainy_btn);
            this.Name = "weather";
            this.Size = new System.Drawing.Size(1147, 357);
            this.Load += new System.EventHandler(this.weather_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rainy_btn;
        private System.Windows.Forms.RichTextBox rainy_textbox;
        private System.Windows.Forms.RichTextBox humidy_textbox;
        private System.Windows.Forms.RichTextBox bright_textbox;
        private System.Windows.Forms.Button humid_btn;
        private System.Windows.Forms.Button bright_btn;
        private System.Windows.Forms.Button clear_weather_btn;
        private System.Windows.Forms.RichTextBox display_weather_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_weather;
    }
}
