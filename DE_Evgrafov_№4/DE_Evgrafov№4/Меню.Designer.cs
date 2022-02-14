
namespace DE_Evgrafov_4
{
    partial class Menu
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
            this.knopkaVAvtorizatsiyu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // knopkaVAvtorizatsiyu
            // 
            this.knopkaVAvtorizatsiyu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.knopkaVAvtorizatsiyu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.knopkaVAvtorizatsiyu.Location = new System.Drawing.Point(298, 310);
            this.knopkaVAvtorizatsiyu.Name = "knopkaVAvtorizatsiyu";
            this.knopkaVAvtorizatsiyu.Size = new System.Drawing.Size(188, 67);
            this.knopkaVAvtorizatsiyu.TabIndex = 0;
            this.knopkaVAvtorizatsiyu.Text = "Авторизация";
            this.knopkaVAvtorizatsiyu.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.knopkaVAvtorizatsiyu);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button knopkaVAvtorizatsiyu;
    }
}