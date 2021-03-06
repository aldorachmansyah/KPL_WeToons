﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.KomikObjects;

namespace WeeToons.Tools.Selection_Tools
{
    public class SelectionTool : ITool
    {
        private IPanelContainer panelContainer;

        private static KomikObject selectedObject;
        private int xInitial;
        private int yInitial;


        public Cursor Cursor
        {
            get
            {
                return Cursors.Arrow;
            }
        }

        public IPanelContainer PanelContainer
        {
            get
            {
                return this.panelContainer;
            }

            set
            {
                this.panelContainer = value;
            }
        }


        public void ToolMouseDown(object sender, MouseEventArgs e)
        {
            this.xInitial = e.X;
            this.yInitial = e.Y;

            IPanel panel = this.panelContainer.ActivePanel;
            if (e.Button == MouseButtons.Left && panel != null)
            {
                if (Form.ModifierKeys != Keys.Control)
                {
                    // Debug.Write("wow");
                    panel.DeselectAllObjects();
                }
                selectedObject = panel.SelectObjectAt(e.X, e.Y);
            }
        }



        public void ToolMouseMove(object sender, MouseEventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (e.Button == MouseButtons.Left && panel != null)
            {
                if (selectedObject != null)
                {
                    int xAmount = e.X - xInitial;
                    int yAmount = e.Y - yInitial;
                    xInitial = e.X;
                    yInitial = e.Y;
                    selectedObject.Translate(e.X, e.Y, xAmount, yAmount);
                }
            }
        }

        public void ToolMouseUp(object sender, MouseEventArgs e)
        {


        }

        public void ToolMouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*Text text = new Text();
            text.Value = "Untitled";
            selectedObject.Add(text);
            Debug.WriteLine("selection tool double click");*/

        }

        public void ToolKeyUp(object sender, KeyEventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        public void ToolKeyDown(object sender, KeyEventArgs e)
        {

        }

        public void ToolHotKeysDown(object sender, Keys e)
        {

        }


        public void tool_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        internal static void expandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedObject.Expand();


        }

        internal static void shrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedObject.Shrink();

        }
    }
}