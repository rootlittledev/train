namespace WindowsFormsApp2
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.flyght = new System.Windows.Forms.ComboBox();
            this.vagon = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.ComboBox();
            this.race = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(151, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flyght
            // 
            this.flyght.FormattingEnabled = true;
            this.flyght.Location = new System.Drawing.Point(24, 73);
            this.flyght.Name = "flyght";
            this.flyght.Size = new System.Drawing.Size(121, 21);
            this.flyght.TabIndex = 1;
            this.flyght.SelectedIndexChanged += new System.EventHandler(this.flyght_SelectedIndexChanged);
            // 
            // vagon
            // 
            this.vagon.FormattingEnabled = true;
            this.vagon.Location = new System.Drawing.Point(151, 73);
            this.vagon.Name = "vagon";
            this.vagon.Size = new System.Drawing.Size(121, 21);
            this.vagon.TabIndex = 2;
            this.vagon.SelectedIndexChanged += new System.EventHandler(this.vagon_SelectedIndexChanged);
            // 
            // time
            // 
            this.time.FormattingEnabled = true;
            this.time.Location = new System.Drawing.Point(278, 73);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(121, 21);
            this.time.TabIndex = 3;
            this.time.SelectedIndexChanged += new System.EventHandler(this.time_SelectedIndexChanged);
            // 
            // race
            // 
            this.race.FormattingEnabled = true;
            this.race.Location = new System.Drawing.Point(151, 104);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(121, 21);
            this.race.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 262);
            this.Controls.Add(this.race);
            this.Controls.Add(this.time);
            this.Controls.Add(this.vagon);
            this.Controls.Add(this.flyght);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox flyght;
        private System.Windows.Forms.ComboBox vagon;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.ComboBox race;
    }
}