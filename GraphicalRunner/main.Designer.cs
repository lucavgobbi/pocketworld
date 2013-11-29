namespace GraphicalRunner
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.point = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.point)).BeginInit();
            this.SuspendLayout();
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.Red;
            this.point.Location = new System.Drawing.Point(334, 140);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(5, 5);
            this.point.TabIndex = 0;
            this.point.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.point);
            this.Name = "main";
            this.Text = "PocketWorld";
            this.Click += new System.EventHandler(this.main_Click);
            ((System.ComponentModel.ISupportInitialize)(this.point)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox point;
        private System.Windows.Forms.Timer timer1;
    }
}

