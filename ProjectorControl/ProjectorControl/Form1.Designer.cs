namespace ProjectorControl
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
            this.On = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.button_rgb = new System.Windows.Forms.Button();
            this.button_video = new System.Windows.Forms.Button();
            this.button_digital = new System.Windows.Forms.Button();
            this.button_strage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // On
            // 
            this.On.Location = new System.Drawing.Point(308, 145);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(80, 66);
            this.On.TabIndex = 0;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = true;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(394, 145);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(78, 66);
            this.Off.TabIndex = 1;
            this.Off.Text = "Off";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Status.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(53, 251);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(422, 153);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            // 
            // ipAddress
            // 
            this.ipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddress.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.Location = new System.Drawing.Point(54, 34);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(222, 29);
            this.ipAddress.TabIndex = 3;
            this.ipAddress.Text = "192.168.1.150";
            this.ipAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipAddress.WordWrap = false;
            this.ipAddress.TextChanged += new System.EventHandler(this.ipAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projector Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(308, 84);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(164, 55);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // button_rgb
            // 
            this.button_rgb.Location = new System.Drawing.Point(54, 109);
            this.button_rgb.Name = "button_rgb";
            this.button_rgb.Size = new System.Drawing.Size(100, 48);
            this.button_rgb.TabIndex = 6;
            this.button_rgb.Text = "RGB";
            this.button_rgb.UseVisualStyleBackColor = true;
            this.button_rgb.Click += new System.EventHandler(this.button_vga_Click);
            // 
            // button_video
            // 
            this.button_video.Location = new System.Drawing.Point(160, 109);
            this.button_video.Name = "button_video";
            this.button_video.Size = new System.Drawing.Size(100, 48);
            this.button_video.TabIndex = 7;
            this.button_video.Text = "VIDEO";
            this.button_video.UseVisualStyleBackColor = true;
            this.button_video.Click += new System.EventHandler(this.button_video_Click);
            // 
            // button_digital
            // 
            this.button_digital.Location = new System.Drawing.Point(54, 163);
            this.button_digital.Name = "button_digital";
            this.button_digital.Size = new System.Drawing.Size(100, 48);
            this.button_digital.TabIndex = 8;
            this.button_digital.Text = "DIGITAL";
            this.button_digital.UseVisualStyleBackColor = true;
            this.button_digital.Click += new System.EventHandler(this.button_digital_Click);
            // 
            // button_strage
            // 
            this.button_strage.Location = new System.Drawing.Point(160, 163);
            this.button_strage.Name = "button_strage";
            this.button_strage.Size = new System.Drawing.Size(100, 48);
            this.button_strage.TabIndex = 9;
            this.button_strage.Text = "NETWORK";
            this.button_strage.UseVisualStyleBackColor = true;
            this.button_strage.Click += new System.EventHandler(this.button_network_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(73, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input Select";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(304, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Projector Control";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(535, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_strage);
            this.Controls.Add(this.button_digital);
            this.Controls.Add(this.button_video);
            this.Controls.Add(this.button_rgb);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.On);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pork-Jector Control (Version 0.1)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button On;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button button_rgb;
        private System.Windows.Forms.Button button_video;
        private System.Windows.Forms.Button button_digital;
        private System.Windows.Forms.Button button_strage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

