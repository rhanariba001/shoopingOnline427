﻿namespace Shopping_Online.Win
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.reportesVentasporProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportesVentasporProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportesVentasporProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesVentasporProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportesVentasporProductosDataGridView
            // 
            this.reportesVentasporProductosDataGridView.AutoGenerateColumns = false;
            this.reportesVentasporProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportesVentasporProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.reportesVentasporProductosDataGridView.DataSource = this.reportesVentasporProductosBindingSource;
            this.reportesVentasporProductosDataGridView.Location = new System.Drawing.Point(43, 12);
            this.reportesVentasporProductosDataGridView.Name = "reportesVentasporProductosDataGridView";
            this.reportesVentasporProductosDataGridView.Size = new System.Drawing.Size(340, 220);
            this.reportesVentasporProductosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // reportesVentasporProductosBindingSource
            // 
            this.reportesVentasporProductosBindingSource.DataSource = typeof(Shopping_Online.BL.ReportesVentasporProductos);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportesVentasporProductosDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportesVentasporProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesVentasporProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reportesVentasporProductosBindingSource;
        private System.Windows.Forms.DataGridView reportesVentasporProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}