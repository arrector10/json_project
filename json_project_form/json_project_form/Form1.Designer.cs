namespace json_project_form
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
            this.txt_output = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_json_file = new System.Windows.Forms.Button();
            this.txt_enter = new System.Windows.Forms.TextBox();
            this.btn_artist = new System.Windows.Forms.Button();
            this.btn_works = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(48, 21);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(964, 222);
            this.txt_output.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_output);
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON file output";
            // 
            // btn_json_file
            // 
            this.btn_json_file.Location = new System.Drawing.Point(117, 294);
            this.btn_json_file.Name = "btn_json_file";
            this.btn_json_file.Size = new System.Drawing.Size(75, 23);
            this.btn_json_file.TabIndex = 2;
            this.btn_json_file.Text = "Display";
            this.btn_json_file.UseVisualStyleBackColor = true;
            this.btn_json_file.Click += new System.EventHandler(this.btn_json_file_Click);
            // 
            // txt_enter
            // 
            this.txt_enter.Location = new System.Drawing.Point(79, 323);
            this.txt_enter.Multiline = true;
            this.txt_enter.Name = "txt_enter";
            this.txt_enter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_enter.Size = new System.Drawing.Size(964, 241);
            this.txt_enter.TabIndex = 3;
            // 
            // btn_artist
            // 
            this.btn_artist.Location = new System.Drawing.Point(264, 590);
            this.btn_artist.Name = "btn_artist";
            this.btn_artist.Size = new System.Drawing.Size(96, 23);
            this.btn_artist.TabIndex = 4;
            this.btn_artist.Text = "Add Artist";
            this.btn_artist.UseVisualStyleBackColor = true;
            this.btn_artist.Click += new System.EventHandler(this.btn_artist_Click);
            // 
            // btn_works
            // 
            this.btn_works.Location = new System.Drawing.Point(535, 590);
            this.btn_works.Name = "btn_works";
            this.btn_works.Size = new System.Drawing.Size(91, 23);
            this.btn_works.TabIndex = 5;
            this.btn_works.Text = "Add Works";
            this.btn_works.UseVisualStyleBackColor = true;
            this.btn_works.Click += new System.EventHandler(this.btn_works_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(801, 590);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 659);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_works);
            this.Controls.Add(this.btn_artist);
            this.Controls.Add(this.txt_enter);
            this.Controls.Add(this.btn_json_file);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_json_file;
        private System.Windows.Forms.TextBox txt_enter;
        private System.Windows.Forms.Button btn_artist;
        private System.Windows.Forms.Button btn_works;
        private System.Windows.Forms.Button btn_clear;
    }
}

