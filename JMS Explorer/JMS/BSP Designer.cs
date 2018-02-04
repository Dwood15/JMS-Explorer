using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
//using Microsoft.DirectX.DirectDraw;

namespace JMS_Explorer
{
    public partial class testBasicForm : Form
    {
        //private System.Windows.Forms.Panel panel1;
        static public Device device;


        public void InitializeGraphics()
        {
            //try
            //{
            //    // Now let's setup our D3D stuff
            //    PresentParameters presentParams =
            //                                                     new PresentParameters();
            //    presentParams.SwapEffect = SwapEffect.Discard;
            //    presentParams.Windowed = true;

            //    device = new Device(0,
            //                                                   DeviceType.Hardware,
            //                                                   panel1,
            //                                                   CreateFlags.MixedVertexProcessing,
            //                                                   presentParams);
            //    device.DeviceReset += new System.EventHandler(this.OnD);
            //}
            //catch (DirectXException e)
            //{

            //    MessageBox.Show(null, "Error intializing graphics: "
            //                                               + e.Message, "Error");
            //    Close();
            //}
        }

       protected override void  OnPaint(PaintEventArgs e)
        {
            device.Clear(ClearFlags.Target,
                                             System.Drawing.Color.Magenta,
                                             1.0f,
                                             0);
            device.Present();
            base.OnPaint(e);
        }


        public testBasicForm()
        {
            InitializeComponent();
            InitializeGraphics();
        }

    }
}
