﻿namespace DiagTool_Kanwairen
{
    partial class SetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.ScriptTimeIntervalLabel = new System.Windows.Forms.Label();
            this.ScriptTimeIntervalTextBox = new System.Windows.Forms.TextBox();
            this.ScriptTimeUnitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "125k",
            "250k",
            "500k"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(157, 41);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(254, 22);
            this.BaudRateComboBox.TabIndex = 9;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateLabel.Location = new System.Drawing.Point(77, 41);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(71, 23);
            this.BaudRateLabel.TabIndex = 8;
            this.BaudRateLabel.Text = "BaudRate:";
            this.BaudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScriptTimeIntervalLabel
            // 
            this.ScriptTimeIntervalLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptTimeIntervalLabel.Location = new System.Drawing.Point(33, 83);
            this.ScriptTimeIntervalLabel.Name = "ScriptTimeIntervalLabel";
            this.ScriptTimeIntervalLabel.Size = new System.Drawing.Size(115, 23);
            this.ScriptTimeIntervalLabel.TabIndex = 10;
            this.ScriptTimeIntervalLabel.Text = "ScriptTimeInterval:";
            this.ScriptTimeIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScriptTimeIntervalTextBox
            // 
            this.ScriptTimeIntervalTextBox.Location = new System.Drawing.Point(158, 83);
            this.ScriptTimeIntervalTextBox.Name = "ScriptTimeIntervalTextBox";
            this.ScriptTimeIntervalTextBox.Size = new System.Drawing.Size(253, 21);
            this.ScriptTimeIntervalTextBox.TabIndex = 11;
            this.ScriptTimeIntervalTextBox.Text = "100";
            // 
            // ScriptTimeUnitLabel
            // 
            this.ScriptTimeUnitLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptTimeUnitLabel.Location = new System.Drawing.Point(414, 81);
            this.ScriptTimeUnitLabel.Name = "ScriptTimeUnitLabel";
            this.ScriptTimeUnitLabel.Size = new System.Drawing.Size(35, 23);
            this.ScriptTimeUnitLabel.TabIndex = 12;
            this.ScriptTimeUnitLabel.Text = "ms";
            this.ScriptTimeUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.ScriptTimeUnitLabel);
            this.Controls.Add(this.ScriptTimeIntervalTextBox);
            this.Controls.Add(this.ScriptTimeIntervalLabel);
            this.Controls.Add(this.BaudRateComboBox);
            this.Controls.Add(this.BaudRateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupFormClosing);
            this.Load += new System.EventHandler(this.SetupWindowLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label ScriptTimeIntervalLabel;
        private System.Windows.Forms.TextBox ScriptTimeIntervalTextBox;
        private System.Windows.Forms.Label ScriptTimeUnitLabel;
    }
}