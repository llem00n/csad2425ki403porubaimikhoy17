namespace client
{
    partial class MainForm
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
            MainLayout = new TableLayoutPanel();
            PortLabel = new Label();
            BaudRateLabel = new Label();
            InputLabel = new Label();
            OutputLogLabel = new Label();
            PortSelect = new ComboBox();
            BaudRateSelect = new ComboBox();
            OutputLog = new TextBox();
            InputTable = new TableLayoutPanel();
            InputField = new TextBox();
            SendButton = new Button();
            MainLayout.SuspendLayout();
            InputTable.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayout
            // 
            MainLayout.AutoSize = true;
            MainLayout.ColumnCount = 2;
            MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5F));
            MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.5F));
            MainLayout.Controls.Add(PortLabel, 0, 0);
            MainLayout.Controls.Add(BaudRateLabel, 0, 1);
            MainLayout.Controls.Add(InputLabel, 0, 2);
            MainLayout.Controls.Add(OutputLogLabel, 0, 3);
            MainLayout.Controls.Add(PortSelect, 1, 0);
            MainLayout.Controls.Add(BaudRateSelect, 1, 1);
            MainLayout.Controls.Add(OutputLog, 1, 3);
            MainLayout.Controls.Add(InputTable, 1, 2);
            MainLayout.Dock = DockStyle.Fill;
            MainLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            MainLayout.Location = new Point(0, 0);
            MainLayout.Margin = new Padding(3, 2, 3, 2);
            MainLayout.Name = "MainLayout";
            MainLayout.RowCount = 4;
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            MainLayout.Size = new Size(700, 338);
            MainLayout.TabIndex = 0;
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Dock = DockStyle.Right;
            PortLabel.Location = new Point(66, 0);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(32, 42);
            PortLabel.TabIndex = 0;
            PortLabel.Text = "Port:";
            PortLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BaudRateLabel
            // 
            BaudRateLabel.AutoSize = true;
            BaudRateLabel.Dock = DockStyle.Right;
            BaudRateLabel.Location = new Point(35, 42);
            BaudRateLabel.Name = "BaudRateLabel";
            BaudRateLabel.Size = new Size(63, 42);
            BaudRateLabel.TabIndex = 1;
            BaudRateLabel.Text = "Baud Rate:";
            BaudRateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Dock = DockStyle.Right;
            InputLabel.Location = new Point(60, 84);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(38, 42);
            InputLabel.TabIndex = 2;
            InputLabel.Text = "Input:";
            InputLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OutputLogLabel
            // 
            OutputLogLabel.AutoSize = true;
            OutputLogLabel.Dock = DockStyle.Right;
            OutputLogLabel.Location = new Point(27, 126);
            OutputLogLabel.Name = "OutputLogLabel";
            OutputLogLabel.Size = new Size(71, 212);
            OutputLogLabel.TabIndex = 3;
            OutputLogLabel.Text = "Output Log:";
            OutputLogLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PortSelect
            // 
            PortSelect.Anchor = AnchorStyles.Left;
            PortSelect.FormattingEnabled = true;
            PortSelect.Location = new Point(114, 9);
            PortSelect.Margin = new Padding(13, 2, 3, 2);
            PortSelect.Name = "PortSelect";
            PortSelect.Size = new Size(133, 23);
            PortSelect.TabIndex = 4;
            // 
            // BaudRateSelect
            // 
            BaudRateSelect.Anchor = AnchorStyles.Left;
            BaudRateSelect.FormattingEnabled = true;
            BaudRateSelect.Location = new Point(114, 51);
            BaudRateSelect.Margin = new Padding(13, 2, 3, 2);
            BaudRateSelect.Name = "BaudRateSelect";
            BaudRateSelect.Size = new Size(133, 23);
            BaudRateSelect.TabIndex = 5;
            // 
            // OutputLog
            // 
            OutputLog.Dock = DockStyle.Fill;
            OutputLog.Location = new Point(114, 137);
            OutputLog.Margin = new Padding(13, 11, 13, 11);
            OutputLog.Multiline = true;
            OutputLog.Name = "OutputLog";
            OutputLog.ReadOnly = true;
            OutputLog.Size = new Size(573, 190);
            OutputLog.TabIndex = 7;
            // 
            // InputTable
            // 
            InputTable.ColumnCount = 2;
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.3970947F));
            InputTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6029034F));
            InputTable.Controls.Add(InputField, 0, 0);
            InputTable.Controls.Add(SendButton, 1, 0);
            InputTable.Dock = DockStyle.Fill;
            InputTable.Location = new Point(104, 87);
            InputTable.Name = "InputTable";
            InputTable.RowCount = 1;
            InputTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            InputTable.Size = new Size(593, 36);
            InputTable.TabIndex = 8;
            // 
            // InputField
            // 
            InputField.Anchor = AnchorStyles.Left;
            InputField.Location = new Point(15, 6);
            InputField.Margin = new Padding(15, 2, 3, 2);
            InputField.Name = "InputField";
            InputField.Size = new Size(200, 23);
            InputField.TabIndex = 0;
            // 
            // SendButton
            // 
            SendButton.Dock = DockStyle.Fill;
            SendButton.Location = new Point(509, 3);
            SendButton.Margin = new Padding(3, 3, 15, 3);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(69, 30);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(MainLayout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Client";
            MainLayout.ResumeLayout(false);
            MainLayout.PerformLayout();
            InputTable.ResumeLayout(false);
            InputTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel MainLayout;
        private Label PortLabel;
        private Label BaudRateLabel;
        private Label InputLabel;
        private Label OutputLogLabel;
        private ComboBox PortSelect;
        private ComboBox BaudRateSelect;
        private TextBox OutputLog;
        private TableLayoutPanel InputTable;
        private TextBox InputField;
        private Button SendButton;
    }
}
