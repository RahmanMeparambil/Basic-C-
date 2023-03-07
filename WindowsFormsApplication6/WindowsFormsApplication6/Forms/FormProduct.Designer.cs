namespace WindowsFormsApplication6.Forms
{
    partial class FormProduct
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pf_SaveButton = new System.Windows.Forms.Button();
            this.pf_DeleteButton = new System.Windows.Forms.Button();
            this.pf_EditButton = new System.Windows.Forms.Button();
            this.pf_ClearButton = new System.Windows.Forms.Button();
            this.pf_FindButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pf_slnoTextbox = new System.Windows.Forms.TextBox();
            this.pf_slnoLabel = new System.Windows.Forms.Label();
            this.productRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDbDataSet = new WindowsFormsApplication6.TestDbDataSet();
            this.productRegistrationTableAdapter = new WindowsFormsApplication6.TestDbDataSetTableAdapters.ProductRegistrationTableAdapter();
            this.pf_UpdateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pf_SaveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pf_DeleteButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pf_EditButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pf_ClearButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pf_FindButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pf_SaveButton
            // 
            this.pf_SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pf_SaveButton.Location = new System.Drawing.Point(3, 3);
            this.pf_SaveButton.Name = "pf_SaveButton";
            this.pf_SaveButton.Size = new System.Drawing.Size(272, 94);
            this.pf_SaveButton.TabIndex = 1;
            this.pf_SaveButton.Text = "SAVE";
            this.pf_SaveButton.UseVisualStyleBackColor = true;
            this.pf_SaveButton.Click += new System.EventHandler(this.pf_SaveButton_Click);
            // 
            // pf_DeleteButton
            // 
            this.pf_DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pf_DeleteButton.Location = new System.Drawing.Point(1115, 3);
            this.pf_DeleteButton.Name = "pf_DeleteButton";
            this.pf_DeleteButton.Size = new System.Drawing.Size(276, 94);
            this.pf_DeleteButton.TabIndex = 1;
            this.pf_DeleteButton.Text = "DELETE";
            this.pf_DeleteButton.UseVisualStyleBackColor = true;
            this.pf_DeleteButton.Click += new System.EventHandler(this.pf_DeleteButton_Click);
            // 
            // pf_EditButton
            // 
            this.pf_EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pf_EditButton.Location = new System.Drawing.Point(837, 3);
            this.pf_EditButton.Name = "pf_EditButton";
            this.pf_EditButton.Size = new System.Drawing.Size(272, 94);
            this.pf_EditButton.TabIndex = 0;
            this.pf_EditButton.Text = "EDIT";
            this.pf_EditButton.UseVisualStyleBackColor = true;
            this.pf_EditButton.Click += new System.EventHandler(this.pf_EditButton_Click);
            // 
            // pf_ClearButton
            // 
            this.pf_ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pf_ClearButton.Location = new System.Drawing.Point(281, 3);
            this.pf_ClearButton.Name = "pf_ClearButton";
            this.pf_ClearButton.Size = new System.Drawing.Size(272, 94);
            this.pf_ClearButton.TabIndex = 0;
            this.pf_ClearButton.Text = "CLEAR";
            this.pf_ClearButton.UseVisualStyleBackColor = true;
            this.pf_ClearButton.Click += new System.EventHandler(this.pf_ClearButton_Click);
            // 
            // pf_FindButton
            // 
            this.pf_FindButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pf_FindButton.Location = new System.Drawing.Point(559, 3);
            this.pf_FindButton.Name = "pf_FindButton";
            this.pf_FindButton.Size = new System.Drawing.Size(272, 94);
            this.pf_FindButton.TabIndex = 0;
            this.pf_FindButton.Text = "FIND";
            this.pf_FindButton.UseVisualStyleBackColor = true;
            this.pf_FindButton.Click += new System.EventHandler(this.pf_FindButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01527F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.98473F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.itemCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemName, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 146);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 90);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM CODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "ITEM NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemCode
            // 
            this.itemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCode.Location = new System.Drawing.Point(121, 3);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(531, 34);
            this.itemCode.TabIndex = 2;
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(121, 48);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(531, 34);
            this.itemName.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(196, 236);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 421);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(458, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.27957F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.72043F));
            this.tableLayoutPanel4.Controls.Add(this.pf_slnoTextbox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pf_slnoLabel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(657, 40);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // pf_slnoTextbox
            // 
            this.pf_slnoTextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pf_slnoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pf_slnoTextbox.Location = new System.Drawing.Point(123, 3);
            this.pf_slnoTextbox.Name = "pf_slnoTextbox";
            this.pf_slnoTextbox.Size = new System.Drawing.Size(73, 34);
            this.pf_slnoTextbox.TabIndex = 3;
            this.pf_slnoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pf_slnoLabel
            // 
            this.pf_slnoLabel.AutoSize = true;
            this.pf_slnoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pf_slnoLabel.Location = new System.Drawing.Point(3, 0);
            this.pf_slnoLabel.Name = "pf_slnoLabel";
            this.pf_slnoLabel.Size = new System.Drawing.Size(114, 40);
            this.pf_slnoLabel.TabIndex = 0;
            this.pf_slnoLabel.Text = "SLNO";
            this.pf_slnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productRegistrationBindingSource
            // 
            this.productRegistrationBindingSource.DataMember = "ProductRegistration";
            this.productRegistrationBindingSource.DataSource = this.testDbDataSet;
            // 
            // testDbDataSet
            // 
            this.testDbDataSet.DataSetName = "TestDbDataSet";
            this.testDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productRegistrationTableAdapter
            // 
            this.productRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // pf_UpdateButton
            // 
            this.pf_UpdateButton.FlatAppearance.BorderSize = 0;
            this.pf_UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pf_UpdateButton.Image = global::WindowsFormsApplication6.Properties.Resources.icons8_update_24;
            this.pf_UpdateButton.Location = new System.Drawing.Point(666, 191);
            this.pf_UpdateButton.Name = "pf_UpdateButton";
            this.pf_UpdateButton.Size = new System.Drawing.Size(40, 42);
            this.pf_UpdateButton.TabIndex = 3;
            this.pf_UpdateButton.UseVisualStyleBackColor = true;
            this.pf_UpdateButton.Click += new System.EventHandler(this.pf_UpdateButton_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 767);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.pf_UpdateButton);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button pf_SaveButton;
        private System.Windows.Forms.Button pf_DeleteButton;
        private System.Windows.Forms.Button pf_EditButton;
        private System.Windows.Forms.Button pf_ClearButton;
        private System.Windows.Forms.Button pf_FindButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pf_UpdateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox pf_slnoTextbox;
        private System.Windows.Forms.Label pf_slnoLabel;
        private TestDbDataSet testDbDataSet;
        private System.Windows.Forms.BindingSource productRegistrationBindingSource;
        private TestDbDataSetTableAdapters.ProductRegistrationTableAdapter productRegistrationTableAdapter;
    }
}