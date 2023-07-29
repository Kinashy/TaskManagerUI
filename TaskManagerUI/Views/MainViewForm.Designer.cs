namespace TaskManagerUI
{
    partial class MainViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ProcessDataGridView = new PascalEgyUI.PascalEgyControls.PEDataGrid();
            tableLayoutPanel2 = new TableLayoutPanel();
            ProcessNameTitleLabel = new Label();
            ProcessNameLabel = new Label();
            BasePriorityTitleLabel = new Label();
            BasePriorityLabel = new Label();
            WorkingSetTitleLabel = new Label();
            WorkingSetLabel = new Label();
            ProcentTitleLabel = new Label();
            ProcentLabel = new Label();
            panel1 = new Panel();
            IDTitleLabel = new Label();
            IDLabel = new Label();
            menuStrip1 = new MenuStrip();
            MenuButton = new ToolStripMenuItem();
            StartButton = new ToolStripMenuItem();
            StopButton = new ToolStripMenuItem();
            DetailedButton = new ToolStripMenuItem();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProcessDataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanel1);
            toolStripContainer1.ContentPanel.Size = new Size(807, 418);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(807, 464);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(807, 22);
            statusStrip1.TabIndex = 0;
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(45, 17);
            StatusLabel.Text = "Status: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(ProcessDataGridView, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(807, 418);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ProcessDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            ProcessDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProcessDataGridView.BackgroundColor = Color.Gainsboro;
            ProcessDataGridView.BorderStyle = BorderStyle.None;
            ProcessDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaGreen;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProcessDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProcessDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProcessDataGridView.Dock = DockStyle.Fill;
            ProcessDataGridView.EnableHeadersVisualStyles = false;
            ProcessDataGridView.Location = new Point(3, 3);
            ProcessDataGridView.Name = "ProcessDataGridView";
            ProcessDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ProcessDataGridView.RowHeadersWidth = 20;
            ProcessDataGridView.RowTemplate.Height = 25;
            ProcessDataGridView.Size = new Size(262, 412);
            ProcessDataGridView.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ProcessNameTitleLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(ProcessNameLabel, 1, 1);
            tableLayoutPanel2.Controls.Add(BasePriorityTitleLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(BasePriorityLabel, 1, 2);
            tableLayoutPanel2.Controls.Add(WorkingSetTitleLabel, 0, 3);
            tableLayoutPanel2.Controls.Add(WorkingSetLabel, 1, 3);
            tableLayoutPanel2.Controls.Add(ProcentTitleLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(ProcentLabel, 1, 4);
            tableLayoutPanel2.Controls.Add(panel1, 0, 5);
            tableLayoutPanel2.Controls.Add(IDTitleLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(IDLabel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(271, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(533, 412);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // ProcessNameTitleLabel
            // 
            ProcessNameTitleLabel.Dock = DockStyle.Fill;
            ProcessNameTitleLabel.ImageAlign = ContentAlignment.MiddleRight;
            ProcessNameTitleLabel.Location = new Point(4, 22);
            ProcessNameTitleLabel.Name = "ProcessNameTitleLabel";
            ProcessNameTitleLabel.Size = new Size(89, 20);
            ProcessNameTitleLabel.TabIndex = 0;
            ProcessNameTitleLabel.Text = "Process name:";
            ProcessNameTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProcessNameLabel
            // 
            ProcessNameLabel.AutoSize = true;
            ProcessNameLabel.Dock = DockStyle.Fill;
            ProcessNameLabel.Location = new Point(100, 22);
            ProcessNameLabel.Name = "ProcessNameLabel";
            ProcessNameLabel.Size = new Size(429, 20);
            ProcessNameLabel.TabIndex = 1;
            ProcessNameLabel.Text = "_";
            ProcessNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BasePriorityTitleLabel
            // 
            BasePriorityTitleLabel.Dock = DockStyle.Fill;
            BasePriorityTitleLabel.ImageAlign = ContentAlignment.MiddleRight;
            BasePriorityTitleLabel.Location = new Point(4, 43);
            BasePriorityTitleLabel.Name = "BasePriorityTitleLabel";
            BasePriorityTitleLabel.Size = new Size(89, 20);
            BasePriorityTitleLabel.TabIndex = 2;
            BasePriorityTitleLabel.Text = "Base priority:";
            BasePriorityTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BasePriorityLabel
            // 
            BasePriorityLabel.AutoSize = true;
            BasePriorityLabel.Dock = DockStyle.Fill;
            BasePriorityLabel.Location = new Point(100, 43);
            BasePriorityLabel.Name = "BasePriorityLabel";
            BasePriorityLabel.Size = new Size(429, 20);
            BasePriorityLabel.TabIndex = 3;
            BasePriorityLabel.Text = "_";
            BasePriorityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WorkingSetTitleLabel
            // 
            WorkingSetTitleLabel.Dock = DockStyle.Fill;
            WorkingSetTitleLabel.ImageAlign = ContentAlignment.MiddleRight;
            WorkingSetTitleLabel.Location = new Point(4, 64);
            WorkingSetTitleLabel.Name = "WorkingSetTitleLabel";
            WorkingSetTitleLabel.Size = new Size(89, 20);
            WorkingSetTitleLabel.TabIndex = 4;
            WorkingSetTitleLabel.Text = "Working set:";
            WorkingSetTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // WorkingSetLabel
            // 
            WorkingSetLabel.AutoSize = true;
            WorkingSetLabel.Dock = DockStyle.Fill;
            WorkingSetLabel.Location = new Point(100, 64);
            WorkingSetLabel.Name = "WorkingSetLabel";
            WorkingSetLabel.Size = new Size(429, 20);
            WorkingSetLabel.TabIndex = 5;
            WorkingSetLabel.Text = "_";
            WorkingSetLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProcentTitleLabel
            // 
            ProcentTitleLabel.Dock = DockStyle.Fill;
            ProcentTitleLabel.ImageAlign = ContentAlignment.MiddleRight;
            ProcentTitleLabel.Location = new Point(4, 85);
            ProcentTitleLabel.Name = "ProcentTitleLabel";
            ProcentTitleLabel.Size = new Size(89, 20);
            ProcentTitleLabel.TabIndex = 6;
            ProcentTitleLabel.Text = "%:";
            ProcentTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProcentLabel
            // 
            ProcentLabel.AutoSize = true;
            ProcentLabel.Dock = DockStyle.Fill;
            ProcentLabel.Location = new Point(100, 85);
            ProcentLabel.Name = "ProcentLabel";
            ProcentLabel.Size = new Size(429, 20);
            ProcentLabel.TabIndex = 7;
            ProcentLabel.Text = "_";
            ProcentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            tableLayoutPanel2.SetColumnSpan(panel1, 2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 106);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 305);
            panel1.TabIndex = 8;
            // 
            // IDTitleLabel
            // 
            IDTitleLabel.Dock = DockStyle.Fill;
            IDTitleLabel.Location = new Point(4, 1);
            IDTitleLabel.Name = "IDTitleLabel";
            IDTitleLabel.Size = new Size(89, 20);
            IDTitleLabel.TabIndex = 9;
            IDTitleLabel.Text = "ID:";
            IDTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Dock = DockStyle.Fill;
            IDLabel.Location = new Point(100, 1);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(429, 20);
            IDLabel.TabIndex = 10;
            IDLabel.Text = "_";
            IDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuButton });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuButton
            // 
            MenuButton.DropDownItems.AddRange(new ToolStripItem[] { StartButton, StopButton, DetailedButton });
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(50, 20);
            MenuButton.Text = "Menu";
            // 
            // StartButton
            // 
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(260, 22);
            StartButton.Text = "Start updating list";
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(260, 22);
            StopButton.Text = "Stop updating list";
            // 
            // DetailedButton
            // 
            DetailedButton.Name = "DetailedButton";
            DetailedButton.Size = new Size(260, 22);
            DetailedButton.Text = "Get detailed about selected process";
            // 
            // MainViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 464);
            Controls.Add(toolStripContainer1);
            Name = "MainViewForm";
            Text = "Task manager: Main";
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProcessDataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private PascalEgyUI.PascalEgyControls.PEDataGrid ProcessDataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private Label ProcessNameTitleLabel;
        private Label ProcessNameLabel;
        private Label BasePriorityTitleLabel;
        private Label BasePriorityLabel;
        private Label WorkingSetTitleLabel;
        private Label WorkingSetLabel;
        private Label ProcentTitleLabel;
        private Label ProcentLabel;
        private Panel panel1;
        private Label IDTitleLabel;
        private Label IDLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuButton;
        private ToolStripMenuItem StartButton;
        private ToolStripMenuItem StopButton;
        private ToolStripMenuItem DetailedButton;
    }
}