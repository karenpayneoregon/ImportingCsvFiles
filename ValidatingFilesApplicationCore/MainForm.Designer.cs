
namespace ValidatingFilesApplicationCore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdProcess = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.cmdInspectRow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InspectButton = new System.Windows.Forms.Button();
            this.OleDbLoadButton = new System.Windows.Forms.Button();
            this.cmdReview = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cboInspectRowIndices = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewInvalid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvalid)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdProcess
            // 
            this.cmdProcess.Location = new System.Drawing.Point(14, 28);
            this.cmdProcess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdProcess.Name = "cmdProcess";
            this.cmdProcess.Size = new System.Drawing.Size(88, 27);
            this.cmdProcess.TabIndex = 0;
            this.cmdProcess.Text = "Process";
            this.cmdProcess.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(881, 303);
            this.dataGridViewMain.TabIndex = 1;
            // 
            // cmdInspectRow
            // 
            this.cmdInspectRow.Location = new System.Drawing.Point(290, 28);
            this.cmdInspectRow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdInspectRow.Name = "cmdInspectRow";
            this.cmdInspectRow.Size = new System.Drawing.Size(88, 27);
            this.cmdInspectRow.TabIndex = 2;
            this.cmdInspectRow.Text = "Inspect row";
            this.cmdInspectRow.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InspectButton);
            this.panel1.Controls.Add(this.OleDbLoadButton);
            this.panel1.Controls.Add(this.cmdReview);
            this.panel1.Controls.Add(this.cmdExit);
            this.panel1.Controls.Add(this.cboInspectRowIndices);
            this.panel1.Controls.Add(this.cmdProcess);
            this.panel1.Controls.Add(this.cmdInspectRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 68);
            this.panel1.TabIndex = 3;
            // 
            // InspectButton
            // 
            this.InspectButton.Location = new System.Drawing.Point(479, 28);
            this.InspectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(88, 27);
            this.InspectButton.TabIndex = 7;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = true;
            // 
            // OleDbLoadButton
            // 
            this.OleDbLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OleDbLoadButton.Location = new System.Drawing.Point(639, 28);
            this.OleDbLoadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OleDbLoadButton.Name = "OleDbLoadButton";
            this.OleDbLoadButton.Size = new System.Drawing.Size(88, 27);
            this.OleDbLoadButton.TabIndex = 6;
            this.OleDbLoadButton.Text = "OleDb load";
            this.OleDbLoadButton.UseVisualStyleBackColor = true;
            // 
            // cmdReview
            // 
            this.cmdReview.Location = new System.Drawing.Point(385, 28);
            this.cmdReview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdReview.Name = "cmdReview";
            this.cmdReview.Size = new System.Drawing.Size(88, 27);
            this.cmdReview.TabIndex = 5;
            this.cmdReview.Text = "Review";
            this.cmdReview.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(779, 28);
            this.cmdExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(88, 27);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // cboInspectRowIndices
            // 
            this.cboInspectRowIndices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInspectRowIndices.FormattingEnabled = true;
            this.cboInspectRowIndices.Location = new System.Drawing.Point(132, 28);
            this.cboInspectRowIndices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboInspectRowIndices.Name = "cboInspectRowIndices";
            this.cboInspectRowIndices.Size = new System.Drawing.Size(140, 23);
            this.cboInspectRowIndices.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewInvalid);
            this.splitContainer1.Size = new System.Drawing.Size(881, 471);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataGridViewInvalid
            // 
            this.dataGridViewInvalid.AllowUserToAddRows = false;
            this.dataGridViewInvalid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvalid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInvalid.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInvalid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewInvalid.Name = "dataGridViewInvalid";
            this.dataGridViewInvalid.Size = new System.Drawing.Size(881, 163);
            this.dataGridViewInvalid.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 539);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvalid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdProcess;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button cmdInspectRow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewInvalid;
        private System.Windows.Forms.ComboBox cboInspectRowIndices;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdReview;
        private System.Windows.Forms.Button OleDbLoadButton;
        private System.Windows.Forms.Button InspectButton;
    }
}

