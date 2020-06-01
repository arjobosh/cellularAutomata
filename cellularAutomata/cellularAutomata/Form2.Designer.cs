namespace cellularAutomata
{
    partial class Form2
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
            this.GoBtn = new System.Windows.Forms.Button();
            this.ECALbl = new System.Windows.Forms.Label();
            this.RuleTb = new System.Windows.Forms.TextBox();
            this.AvailableLbl = new System.Windows.Forms.Label();
            this.RulesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(15, 51);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 23);
            this.GoBtn.TabIndex = 0;
            this.GoBtn.Text = "Go!";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // ECALbl
            // 
            this.ECALbl.AutoSize = true;
            this.ECALbl.Location = new System.Drawing.Point(12, 9);
            this.ECALbl.Name = "ECALbl";
            this.ECALbl.Size = new System.Drawing.Size(215, 13);
            this.ECALbl.TabIndex = 1;
            this.ECALbl.Text = "Elementary Cellular Automaton Rule Number";
            // 
            // RuleTb
            // 
            this.RuleTb.Location = new System.Drawing.Point(15, 25);
            this.RuleTb.Name = "RuleTb";
            this.RuleTb.Size = new System.Drawing.Size(100, 20);
            this.RuleTb.TabIndex = 2;
            // 
            // AvailableLbl
            // 
            this.AvailableLbl.AutoSize = true;
            this.AvailableLbl.Location = new System.Drawing.Point(12, 90);
            this.AvailableLbl.Name = "AvailableLbl";
            this.AvailableLbl.Size = new System.Drawing.Size(97, 13);
            this.AvailableLbl.TabIndex = 1;
            this.AvailableLbl.Text = "Available Rulesets:";
            // 
            // RulesLbl
            // 
            this.RulesLbl.AutoSize = true;
            this.RulesLbl.Location = new System.Drawing.Point(12, 103);
            this.RulesLbl.Name = "RulesLbl";
            this.RulesLbl.Size = new System.Drawing.Size(0, 13);
            this.RulesLbl.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.RuleTb);
            this.Controls.Add(this.RulesLbl);
            this.Controls.Add(this.AvailableLbl);
            this.Controls.Add(this.ECALbl);
            this.Controls.Add(this.GoBtn);
            this.Name = "Form2";
            this.Text = "Choose A Ruleset";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label ECALbl;
        private System.Windows.Forms.TextBox RuleTb;
        private System.Windows.Forms.Label AvailableLbl;
        private System.Windows.Forms.Label RulesLbl;
    }
}