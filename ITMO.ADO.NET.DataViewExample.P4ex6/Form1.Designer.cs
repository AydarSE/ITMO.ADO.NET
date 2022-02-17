namespace ITMO.ADO.NET.DataViewExample.P4ex6
{
    partial class DataView
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SetDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(30, 13);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.RowHeadersWidth = 62;
            this.CustomersGrid.RowTemplate.Height = 28;
            this.CustomersGrid.Size = new System.Drawing.Size(410, 601);
            this.CustomersGrid.TabIndex = 0;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(476, 22);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(208, 26);
            this.SortTextBox.TabIndex = 1;
            this.SortTextBox.Text = "CustomerID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(476, 74);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(208, 26);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.Text = "City = \'London\'";
            // 
            // SetDataViewPropertiesButton
            // 
            this.SetDataViewPropertiesButton.Location = new System.Drawing.Point(476, 134);
            this.SetDataViewPropertiesButton.Name = "SetDataViewPropertiesButton";
            this.SetDataViewPropertiesButton.Size = new System.Drawing.Size(147, 48);
            this.SetDataViewPropertiesButton.TabIndex = 3;
            this.SetDataViewPropertiesButton.Text = "Set DataView Properties";
            this.SetDataViewPropertiesButton.UseVisualStyleBackColor = true;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(476, 198);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(147, 49);
            this.AddRowButton.TabIndex = 4;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 651);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.SetDataViewPropertiesButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "DataView";
            this.Text = "DataView";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Button SetDataViewPropertiesButton;
        private System.Windows.Forms.Button AddRowButton;
    }
}

