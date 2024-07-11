namespace ADO_03._DbDataAdapter
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
            fillButton = new Button();
            updateButton = new Button();
            resultDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(12, 12);
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(411, 23);
            queryTextBox.TabIndex = 0;
            // 
            // fillButton
            // 
            fillButton.Location = new Point(246, 41);
            fillButton.Name = "fillButton";
            fillButton.RightToLeft = RightToLeft.No;
            fillButton.Size = new Size(75, 23);
            fillButton.TabIndex = 1;
            fillButton.Text = "Fill";
            fillButton.UseVisualStyleBackColor = true;
            fillButton.Click += fillButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(348, 41);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Location = new Point(12, 85);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.Size = new Size(409, 353);
            resultDataGridView.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(resultDataGridView);
            Controls.Add(updateButton);
            Controls.Add(fillButton);
            Controls.Add(queryTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryTextBox;
        private Button fillButton;
        private Button updateButton;
        private DataGridView resultDataGridView;
    }
}
