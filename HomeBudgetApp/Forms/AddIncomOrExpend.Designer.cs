namespace HomeBudgetApp.Forms
{
    partial class AddIncomOrExpend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionTypeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbIncomeTypes = new System.Windows.Forms.ComboBox();
            this.incomeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetAppDataSet = new HomeBudgetApp.BudgetAppDataSet();
            this.incomeTypesTableAdapter = new HomeBudgetApp.BudgetAppDataSetTableAdapters.IncomeTypesTableAdapter();
            this.cbExpendsType = new System.Windows.Forms.ComboBox();
            this.budgetAppDataSet1 = new HomeBudgetApp.BudgetAppDataSet1();
            this.expenceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenceTypesTableAdapter = new HomeBudgetApp.BudgetAppDataSet1TableAdapters.ExpenceTypesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenceTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbExpendsType);
            this.panel1.Controls.Add(this.nudValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.transactionTypeLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbIncomeTypes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 211);
            this.panel1.TabIndex = 0;
            // 
            // nudValue
            // 
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Location = new System.Drawing.Point(56, 108);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(121, 20);
            this.nudValue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сума:";
            // 
            // transactionTypeLabel
            // 
            this.transactionTypeLabel.AutoSize = true;
            this.transactionTypeLabel.Location = new System.Drawing.Point(53, 23);
            this.transactionTypeLabel.Name = "transactionTypeLabel";
            this.transactionTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.transactionTypeLabel.TabIndex = 3;
            this.transactionTypeLabel.Text = "Вид приход:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 35);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(150, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Запиши";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Изход";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cbIncomeTypes
            // 
            this.cbIncomeTypes.DataSource = this.incomeTypesBindingSource;
            this.cbIncomeTypes.DisplayMember = "IncomeType";
            this.cbIncomeTypes.FormattingEnabled = true;
            this.cbIncomeTypes.Location = new System.Drawing.Point(56, 39);
            this.cbIncomeTypes.Name = "cbIncomeTypes";
            this.cbIncomeTypes.Size = new System.Drawing.Size(121, 21);
            this.cbIncomeTypes.TabIndex = 0;
            this.cbIncomeTypes.ValueMember = "Id";
            // 
            // incomeTypesBindingSource
            // 
            this.incomeTypesBindingSource.DataMember = "IncomeTypes";
            this.incomeTypesBindingSource.DataSource = this.budgetAppDataSet;
            // 
            // budgetAppDataSet
            // 
            this.budgetAppDataSet.DataSetName = "BudgetAppDataSet";
            this.budgetAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeTypesTableAdapter
            // 
            this.incomeTypesTableAdapter.ClearBeforeFill = true;
            // 
            // cbExpendsType
            // 
            this.cbExpendsType.DataSource = this.expenceTypesBindingSource;
            this.cbExpendsType.DisplayMember = "ExpenceType";
            this.cbExpendsType.FormattingEnabled = true;
            this.cbExpendsType.Location = new System.Drawing.Point(56, 66);
            this.cbExpendsType.Name = "cbExpendsType";
            this.cbExpendsType.Size = new System.Drawing.Size(121, 21);
            this.cbExpendsType.TabIndex = 6;
            this.cbExpendsType.ValueMember = "Id";
            this.cbExpendsType.Visible = false;
            // 
            // budgetAppDataSet1
            // 
            this.budgetAppDataSet1.DataSetName = "BudgetAppDataSet1";
            this.budgetAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenceTypesBindingSource
            // 
            this.expenceTypesBindingSource.DataMember = "ExpenceTypes";
            this.expenceTypesBindingSource.DataSource = this.budgetAppDataSet1;
            // 
            // expenceTypesTableAdapter
            // 
            this.expenceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // AddIncomOrExpend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 211);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddIncomOrExpend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на приход";
            this.Load += new System.EventHandler(this.AddIncom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incomeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenceTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label transactionTypeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbIncomeTypes;
        private BudgetAppDataSet budgetAppDataSet;
        private System.Windows.Forms.BindingSource incomeTypesBindingSource;
        private BudgetAppDataSetTableAdapters.IncomeTypesTableAdapter incomeTypesTableAdapter;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.ComboBox cbExpendsType;
        private BudgetAppDataSet1 budgetAppDataSet1;
        private System.Windows.Forms.BindingSource expenceTypesBindingSource;
        private BudgetAppDataSet1TableAdapters.ExpenceTypesTableAdapter expenceTypesTableAdapter;
    }
}