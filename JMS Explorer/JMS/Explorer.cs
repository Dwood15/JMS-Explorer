using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
//using ToolSharp;






























/* Old, old, old Tool Sharp stuff.
public class Explorer : ToolSharp.IToolPlugin
{   
    private JMS_Explorer.Selector _select = null;
    public System.Windows.Forms.Form Base
    {
        get { return _select; }
    }

    public string Category
    {
        get { return "JMS"; }
    }

    public ToolSharp.Scanner Engine
    {
        get { return null; }
        //_scanner = value
        set { }
    }

    public void Initialize(System.Windows.Forms.Form parentForm)
    {
        _select = new JMS_Explorer.Selector();
        _select.Base = this;
        _select.MdiParent = parentForm;
        _select.Icon = parentForm.Icon;
        _select.Show();
    }


    public void Save(string _path)
    {
        //THIS IS FOR GENERALIZED BATCH SAVING MATERIALS
    }

    public void Load(string _path)
    {
        //THIS IS FOR GENERALIZED BATCH LOADING MATERIALS
    }

    public string Description
    {
        get { return "Allows for the manipulation of Map, Model, and Weapon JMS files."; }
    }

    public Version Version
    {
        get { return new Version(1, 0, 62, 1); }
    }

    public ToolSharp.ToolManager Manager
    {
        get { return null; }

        set { }
    }

    public string PluginAuthor
    {
        get { return "Dwood"; }
    }

    public string PluginName
    {
        get { return "JMS Explorer"; }
    }

    public void Remove()
    {
        if (_select != null)
        {
            if (!_select.IsDisposed)
                _select.Close();
        }
    }

    public ToolSharp.ToolHandler Tool
    {
        get { return null; }

        set { }
    }

}
*/