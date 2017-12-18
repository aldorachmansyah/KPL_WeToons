using System.Collections.Generic;
using WeeToons.Tools.Selection_Tools;

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
            this.components = new System.ComponentModel.Container();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.leftToolStrip = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandToolStripMenuItem1,
            this.shrinkToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // expandToolStripMenuItem1
            // 
            this.expandToolStripMenuItem1.Name = "expandToolStripMenuItem1";
            this.expandToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.expandToolStripMenuItem1.Text = "Expand";
            this.expandToolStripMenuItem1.Click += new System.EventHandler(SelectionTool.expandToolStripMenuItem_Click);
            // 
            // shrinkToolStripMenuItem1
            // 
            this.shrinkToolStripMenuItem1.Name = "shrinkToolStripMenuItem1";
            this.shrinkToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.shrinkToolStripMenuItem1.Text = "Shrink";
            this.shrinkToolStripMenuItem1.Click += new System.EventHandler(SelectionTool.shrinkToolStripMenuItem_Click);
            // 
            // WeeToonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 706);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.leftToolStrip);
            this.Controls.Add(this.topToolStrip);
            this.Name = "WeeToonsForm";
            this.Text = "WeeToons";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.ComponentResourceManager resources;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStrip leftToolStrip;
        private System.Windows.Forms.FlowLayoutPanel activePanel;
        private List<System.Windows.Forms.FlowLayoutPanel> panelGroup = new List<System.Windows.Forms.FlowLayoutPanel>();
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shrinkToolStripMenuItem1;
    }
}

