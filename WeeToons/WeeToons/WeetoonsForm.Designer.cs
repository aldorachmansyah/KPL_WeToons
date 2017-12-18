using System.Collections.Generic;

namespace WeeToons
{
    partial class WeeToonsForm
    {
        /// <summary>
        /// Required designer variable. tes
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
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.leftToolStrip = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // topToolStrip
            // 
            this.topToolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.topToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(784, 25);
            this.topToolStrip.TabIndex = 0;
            this.topToolStrip.Text = "toolStrip1";
            // 
            // leftToolStrip
            // 
            this.leftToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftToolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.leftToolStrip.Location = new System.Drawing.Point(0, 25);
            this.leftToolStrip.Name = "leftToolStrip";
            this.leftToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.leftToolStrip.Size = new System.Drawing.Size(26, 681);
            this.leftToolStrip.TabIndex = 1;
            this.leftToolStrip.Text = "toolStrip2";
            // 
            // WeeToonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 706);
            this.Controls.Add(this.leftToolStrip);
            this.Controls.Add(this.topToolStrip);
            this.Name = "WeeToonsForm";
            this.Text = "WeeToons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.ComponentResourceManager resources;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStrip leftToolStrip;
        private System.Windows.Forms.FlowLayoutPanel activePanel;
        private List<System.Windows.Forms.FlowLayoutPanel> panelGroup = new List<System.Windows.Forms.FlowLayoutPanel>();
    }
}

