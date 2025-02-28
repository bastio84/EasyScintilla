﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyScintilla.Stylers;

namespace ExampleProject
{
    public partial class Form1 : Form
    {

        private ExampleDisplay[] _examples = new ExampleDisplay[]
        {
            new ExampleDisplay("C#", "cs.txt", new CSharpStyler()),
            new ExampleDisplay("C# (Dark)", "cs.txt", new DarkCSharpStyler()),
            new ExampleDisplay("Windows Batch", "bat.txt", new BatchStyler()),
            new ExampleDisplay("HTML", "html.txt", HtmlStyler.HtmlStandard),
            new ExampleDisplay("HTML (with code folding)", "html.txt", HtmlStyler.HtmlWithCodeFolding),
            new ExampleDisplay("HTML (with line numbers)", "html.txt", HtmlStyler.HtmlWithLineNumbers),
            new ExampleDisplay("HTML (with line numbers and code folding)", "html.txt", HtmlStyler.HtmlWithLineNumbersAndCodeFolding),
            new ExampleDisplay("XML", "xml.txt", XmlStyler.XmlStandard),
            new ExampleDisplay("XML (with code folding)", "xml.txt", XmlStyler.XmlWithCodeFolding),
            new ExampleDisplay("XML (with line numbers)", "xml.txt", XmlStyler.XmlWithLineNumbers),
            new ExampleDisplay("XML (with line numbers and code folding)", "xml.txt", XmlStyler.XmlWithLineNumbersAndCodeFolding),
            new ExampleDisplay("JSON", "json.txt", new JsonStyler()),
            new ExampleDisplay("PowerShell", "ps1.txt", new PowerShellStyler()),
            new ExampleDisplay("Python", "py.txt", new PythonStyler()),
            new ExampleDisplay("Ruby", "rb.txt", new RubyStyler()),
            new ExampleDisplay("T-SQL", "sql.txt", new SqlStyler()),
            new ExampleDisplay("Teradata Parallel Transporter", "tpt.txt", new TptStyler()),
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stylerPicker.DataSource = _examples;
            stylerPicker.DisplayMember = "Display";
        }

        private void stylerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var example = _examples[stylerPicker.SelectedIndex];
            editor.Text = example.ReadFile();
            editor.Styler = example.Styler;
        }
    }
}
