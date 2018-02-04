using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _JMS;
namespace JMS_Explorer
{
    public partial class JMSMergeTesting : Form
    {
      //  private ToolSharp.IToolPlugin _base;
        // JMS _jms;

    //    public ToolSharp.IToolPlugin Base
    //    {
    //        get { return _base; }
    //        set { _base = value; }
    //    }

        _JMS.JMS static_jms = new _JMS.JMS();
        _JMS.JMS dynamic_jms = new _JMS.JMS();
        public JMSMergeTesting()
        {
            InitializeComponent();
        }

        private void b_LBaseJMS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _OFD = new OpenFileDialog { Title = "JMS", Filter = "JMS File|*.jms" })
            {
                if (_OFD.ShowDialog().Equals(DialogResult.OK))
                {
                    static_jms.Load(_OFD.FileName);
                }
            }
        }

        private void b_LAppendingJMS_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _OFD = new OpenFileDialog { Title = "JMS", Filter = "JMS File|*.jms" })
            {
                if (_OFD.ShowDialog().Equals(DialogResult.OK))
                {
                    dynamic_jms.Load(_OFD.FileName);
                }
            }
        }

        private void b_MergeJMS_Click(object sender, EventArgs e)
        {
            int expectFaces = (int)nUD_Merge.Value;
            if (expectFaces < 2) { misc.alertbox("You need to set the number of faces you expect per golden area"); }
            else if (tb_MatName.Text == string.Empty) { misc.alertbox("Enter the name of the material you wish to use"); }
            else
            {
                using (SaveFileDialog _SFD = new SaveFileDialog { Title = "JMS", Filter = "JMS File|*.jms" })
                {
                    bool throwAway = false;
                    if (_SFD.ShowDialog().Equals(DialogResult.OK))
                    {
                        _JMS.JMS merged = misc.mergeJMS(static_jms, dynamic_jms, tb_MatName.Text, expectFaces, out throwAway);
                        if (throwAway)
                            merged.Save(_SFD.FileName);
                    }
                }
            }
        }
    }
}
