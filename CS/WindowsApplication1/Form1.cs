using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> datasource = new List<int>();
            datasource.AddRange(new int[] { 0, 1, 2, 3, 4 });
            myDataNavigator1.DataSource = datasource;
        }
    }
}