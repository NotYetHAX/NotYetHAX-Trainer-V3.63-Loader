﻿
namespace NotYetHAX
{
    partial class NotYetHAX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotYetHAX));
            this.CheckProcess = new System.Windows.Forms.Timer(this.components);
            this.CETimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CheckProcess
            // 
            this.CheckProcess.Interval = 1000;
            this.CheckProcess.Tick += new System.EventHandler(this.CheckProcess_Tick);
            // 
            // CETimer
            // 
            this.CETimer.Interval = 4000;
            this.CETimer.Tick += new System.EventHandler(this.CETimer_Tick);
            // 
            // NotYetHAX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NotYetHAX";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotYetHAX";
            this.Load += new System.EventHandler(this.NotYetHAX_Load);
            this.Shown += new System.EventHandler(this.NotYetHAX_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CheckProcess;
        private System.Windows.Forms.Timer CETimer;
    }
}

