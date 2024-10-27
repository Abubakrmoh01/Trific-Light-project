namespace Trific_Light_project
{
    partial class ctrlTriaficLight
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
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLight
            // 
            this.pbLight.Image = global::Trific_Light_project.Properties.Resources.Red;
            this.pbLight.Location = new System.Drawing.Point(15, 3);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(73, 178);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLight.TabIndex = 0;
            this.pbLight.TabStop = false;
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(37, 195);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(29, 20);
            this.lblCountDown.TabIndex = 1;
            this.lblCountDown.Text = "??";
            this.lblCountDown.Click += new System.EventHandler(this.label1_Click);
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // ctrlTriaficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.pbLight);
            this.Name = "ctrlTriaficLight";
            this.Size = new System.Drawing.Size(92, 223);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer LightTimer;
    }
}
