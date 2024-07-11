namespace ADO_02._DataTable
{
    partial class Form1
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
            queryTextBox = new TextBox();
            execButton = new Button();
            ResultDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ResultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(12, 12);
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(312, 23);
            queryTextBox.TabIndex = 0;
            // 
            // execButton
            // 
            execButton.Location = new Point(339, 12);
            execButton.Name = "execButton";
            execButton.Size = new Size(102, 23);
            execButton.TabIndex = 1;
            execButton.Text = "Execute";
            execButton.UseVisualStyleBackColor = true;
            execButton.Click += execButton_Click;
            // 
            // ResultDataGridView
            // 
            ResultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultDataGridView.Location = new Point(12, 51);
            ResultDataGridView.Name = "ResultDataGridView";
            ResultDataGridView.Size = new Size(429, 288);
            ResultDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 358);
            Controls.Add(ResultDataGridView);
            Controls.Add(execButton);
            Controls.Add(queryTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ResultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryTextBox;
        private Button execButton;
        private DataGridView ResultDataGridView;
    }
}
