using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerUI.Views
{
    public partial class TemplateViewForm : Form
    {
        public TemplateViewForm()
        {
            InitializeComponent();
            this.Text = "Task manager: ";
        }
        public static void RecursiveSetDoubleBuffered(Control.ControlCollection collection)
        {
            if (collection.Count > 0)
            {
                foreach (Control col in collection)
                {
                    SetDoubleBuffered(col);
                    RecursiveSetDoubleBuffered(col.Controls);
                }
            }
        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ContainerControl | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    }
}
