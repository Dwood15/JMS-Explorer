using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpExample
{
    // Implement the ITooPlugin interface
    public class ExampleClass : ToolSharp.IToolPlugin
    {
        Exporter _frm = new Exporter();
        ToolSharp.Scanner _scanner = new ToolSharp.Scanner();
        ToolSharp.ToolManager _manager = new ToolSharp.ToolManager();


        /// <summary>
        /// The Base returns the underlying form this control houses. Required.
        /// </summary>
        public System.Windows.Forms.Form Base
        {
            get { return _frm; }
        }

        /// <summary>
        /// This is the 'Category' of the plug-in. Used in sorting in the menus. Required.
        /// </summary>
        public string Category
        {
            get { return "Tag test"; }
        }

        /// <summary>
        /// This is the description of the plug-in. It's used in the manager window. Can return a String.Empty if you
        /// don't wanna bother with it.
        /// </summary>
        public string Description
        {
            get { return "An SBSP Viewer."; }
        }

        /// <summary>
        /// You need to have this implemented but you don't have to use it yourself. As long as the get and set statements
        /// are in place you can generally ignore this.
        /// </summary>
        public ToolSharp.Scanner Engine
        {
            get
            {
                return _scanner;
            }
            set
            {
                _scanner = value;
            }
        }

        /// <summary>
        /// The initialization routine is where all the dirty work happens. This is where you setup your window
        /// for the plugin to launch. Anything that needs to be done will happen here to get the plug-in off the ground.
        /// 
        /// The passed 'parentForm' control allows you to set the Icon of your plug-in window, as well as set the MdiParent
        /// property to make the plug-in housed inside Tool #. This is not a requirement to make it an MdiChild but it
        /// definitely helps things out when it comes to cleaning things up.
        /// </summary>
        /// <param name="parentForm">The parent form, aka the main Multi-Document Interface (MDI) Window.</param>
        /// 
        public void startCounter()
        {

        }
        public void Initialize(System.Windows.Forms.Form parentForm)
        {

            // Create new form
            _frm = new Editor();


            // Set the Parent.
            _frm.MdiParent = parentForm;
            // Set the Icon
            _frm.Icon = parentForm.Icon;

            //_frm.InitGraphics();
            // Show!
            _frm.Show();

            // Thread hello = new Thread(new ThreadStart(startCounter));
            //hello.Start();

        }

        /// <summary>
        /// Not required, don't throw an exception and things will be fine. Use only if you implement IToolWindow on the main form.
        /// If you don't know what IToolWindow is, don't worry about this.
        /// </summary>
        /// <param name="_path"></param>
        public void Load(string _path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Just have the get and set statements return and set a local variable. The Tool manager allows you to view what
        /// Tools you want to use, such as custom tools like toolio and OS_Tool.
        /// </summary>
        public ToolSharp.ToolManager Manager
        {
            get
            {
                return _manager;
            }
            set
            {
                _manager = value;
            }
        }

        /// <summary>
        /// Required. Your name goes here.
        /// </summary>
        public string PluginAuthor
        {
            get { return "Dwood"; }
        }

        /// <summary>
        /// Required, name of the plugin.
        /// </summary>
        public string PluginName
        {
            get { return "Bsp Viewer"; }
        }

        /// <summary>
        /// Required, this is where the cleanup occurs for the plug-in. This is where you, the plugin author, cleans up the
        /// mess you made. :D
        /// </summary>
        public void Remove()
        {
            if (_frm != null)
            {
                if (!_frm.IsDisposed)
                    _frm.Dispose();
            }
        }

        /// <summary>
        /// See load comment. Same applies here.
        /// </summary>
        /// <param name="_path"></param>
        public void Save(string _path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Optional to implement. It can be ruled useless since you can create your own instance of this.
        /// Don't owrry about implementing if you aren't doing Tool manipulations.
        /// </summary>
        public ToolSharp.ToolHandler Tool
        {
            get
            {
                return null;
                //throw new NotImplementedException();
            }
            set
            {
                //throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Required for giving what version your plug-in is.
        /// </summary>
        public Version Version
        {
            get { return new Version(1, 0, 15, 2); }
        }
    }
}
