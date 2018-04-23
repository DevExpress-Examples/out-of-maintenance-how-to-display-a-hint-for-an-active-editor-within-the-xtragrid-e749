using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new DevExpress.XtraGrid.Design.XViewsPrinting(gridControl1); 
        }


        private void gridView1_ShownEditor(object sender, System.EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView.ActiveEditor.ToolTipController != null)
            {
                gridView.ActiveEditor.ToolTipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(ToolTipController_GetActiveObjectInfo);
            }
        }

        private void ToolTipController_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            object o = gridView1.ActiveEditor.ToString();
            string text = "Test";
            e.Info = new ToolTipControlInfo(o, text);
        }
    }
}