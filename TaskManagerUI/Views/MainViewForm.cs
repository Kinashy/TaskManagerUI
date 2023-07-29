using MaterialSkin.Controls;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TaskManagerUI.ViewModels;
using TaskManagerUI.Views;
using Timer = System.Windows.Forms.Timer;

namespace TaskManagerUI
{
    public partial class MainViewForm : TemplateViewForm
    {
        public MainViewForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            RecursiveSetDoubleBuffered(this.Controls);
            ProcessDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProcessDataGridView.RowTemplate.Height = 35;
            ProcessDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProcessDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProcessDataGridView.EnableHeadersVisualStyles = false;
            ProcessDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ProcessDataGridView.BorderStyle = BorderStyle.FixedSingle;
            ProcessDataGridView.DefaultCellStyle.Font = new Font("Segoe", 8);
            ProcessDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProcessDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe", 8);
            ProcessDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ProcessDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProcessDataGridView.AllowUserToAddRows = false;
            ProcessDataGridView.BorderStyle = BorderStyle.FixedSingle;
            ProcessDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White;//System.Drawing.SystemColors.InactiveBorder;//Color.FromArgb(7, 50, 128);
            ProcessDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ProcessDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;//System.Drawing.SystemColors.InactiveBorder;//Color.FromArgb(7, 50, 128);
            ProcessDataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            ProcessDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(15, 100, 178);
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
            ProcessDataGridView.DataSource = mainViewModel.ProcessDataTable;
            ProcessDataGridView.AutoResizeColumns();
            ProcessDataGridView.Columns[0].ReadOnly = true;
            DetailedButton.DataBindings.Add(new Binding("Command", mainViewModel, "SelectProcess", true));
            DetailedButton.CommandParameter = this.ProcessDataGridView;

            Binding binding = new Binding("Text", this.DataContext, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = System.Convert.ToString(e.Value);
            IDLabel.DataBindings.Add(binding);
            binding = new Binding("Text", this.DataContext, "ProcessName", false, DataSourceUpdateMode.OnPropertyChanged);
            ProcessNameLabel.DataBindings.Add(binding);
            binding = new Binding("Text", this.DataContext, "BasePriority", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = System.Convert.ToString(e.Value);
            BasePriorityLabel.DataBindings.Add(binding);
            binding = new Binding("Text", this.DataContext, "WorkingSet", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = System.Convert.ToString(e.Value) + " K";
            WorkingSetLabel.DataBindings.Add(binding);
            binding = new Binding("Text", this.DataContext, "Procent", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = ((float)e.Value).ToString("0.00");
            ProcentLabel.DataBindings.Add(binding);
            binding = new Binding("Command", this.DataContext, "StartCommand", true);
            StartButton.DataBindings.Add(binding);
            binding = new Binding("Command", this.DataContext, "StopCommand", true);
            StopButton.DataBindings.Add(binding);
            binding = new Binding("Enabled", mainViewModel, "StartEnabled", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (o, e) => e.Value = !((bool)e.Value);
            StopButton.DataBindings.Add(binding);
            binding = new Binding("Enabled", mainViewModel, "StartEnabled", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (o, e) => e.Value = !((bool)e.Value);
            DetailedButton.DataBindings.Add(binding);
            StartButton.DataBindings.Add(new Binding("Enabled", mainViewModel, "StartEnabled", false, DataSourceUpdateMode.OnPropertyChanged));
            binding = new Binding("Text", mainViewModel, "Status", true);
            binding.Format += (o, e) => e.Value = "Status: " + ((string)e.Value);
            StatusLabel.DataBindings.Add(binding);

        }
    }
}