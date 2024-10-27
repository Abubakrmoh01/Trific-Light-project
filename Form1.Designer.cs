namespace Trific_Light_project
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
            this.ctrlTriaficLight1 = new Trific_Light_project.ctrlTriaficLight();
            this.SuspendLayout();
            // 
            // ctrlTriaficLight1
            // 
            this.ctrlTriaficLight1.CurrentLight = Trific_Light_project.ctrlTriaficLight.LightEnum.Red;
            this.ctrlTriaficLight1.GreenTime = 6;
            this.ctrlTriaficLight1.Location = new System.Drawing.Point(71, 37);
            this.ctrlTriaficLight1.Name = "ctrlTriaficLight1";
            this.ctrlTriaficLight1.OrangeTime = 5;
            this.ctrlTriaficLight1.RedTime = 10;
            this.ctrlTriaficLight1.Size = new System.Drawing.Size(92, 223);
            this.ctrlTriaficLight1.TabIndex = 0;
            this.ctrlTriaficLight1.RedLightOn += new System.EventHandler<Trific_Light_project.ctrlTriaficLight.TraficLightEventArgs>(this.ctrlTriaficLight1_RedLightOn);
            this.ctrlTriaficLight1.RedLightOff += new System.EventHandler<Trific_Light_project.ctrlTriaficLight.TraficLightEventArgs>(this.ctrlTriaficLight1_RedLightOff);
            this.ctrlTriaficLight1.OrangeLightOn += new System.EventHandler<Trific_Light_project.ctrlTriaficLight.TraficLightEventArgs>(this.ctrlTriaficLight1_OrangeLightOn);
            this.ctrlTriaficLight1.GreenLightOn += new System.EventHandler<Trific_Light_project.ctrlTriaficLight.TraficLightEventArgs>(this.ctrlTriaficLight1_GreenLightOn);
            this.ctrlTriaficLight1.GreenLightOff += new System.EventHandler<Trific_Light_project.ctrlTriaficLight.TraficLightEventArgs>(this.ctrlTriaficLight1_GreenLightOff);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 558);
            this.Controls.Add(this.ctrlTriaficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTriaficLight ctrlTriaficLight1;
    }
}

