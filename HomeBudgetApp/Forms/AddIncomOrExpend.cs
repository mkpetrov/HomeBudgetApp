using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBudgetApp.Forms
{
    public partial class AddIncomOrExpend : Form
    {
        private int _transactionType; // 0 - Income , 1 = Expend

        public AddIncomOrExpend(int transactionType)
        {
            InitializeComponent();

            _transactionType = transactionType;
            if(_transactionType == 1)
            {
                this.Text = "Добавяне на разход";
                transactionTypeLabel.Text = "Вид разход";
                this.Text = "Добавяне на разход";

                cbIncomeTypes.Visible = false;
                cbExpendsType.Location = cbIncomeTypes.Location;
                cbExpendsType.Visible = true;
            }
            nudValue.Maximum = decimal.MaxValue;
            LoadEvents();
        }

        private void LoadEvents()
        {
            btnClose.Click += BtnClose_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(nudValue.Value != default(decimal))
            {
                var context = new DbModel();

                using (context)
                {
                    if (_transactionType == default(int))
                    {
                        var income = new Incomes
                        {
                            Date = DateTime.Now,
                            Value = nudValue.Value,
                            IncomeTypeId = cbIncomeTypes.SelectedIndex + 1
                        };

                        context.Incomes.Add(income);
                    }
                    else
                    {
                        var expence = new Expences
                        {
                            Date = DateTime.Now,
                            Value = nudValue.Value,
                            ExpenceTypeId = cbIncomeTypes.SelectedIndex + 1
                        };

                        context.Expences.Add(expence);
                    }

                    context.SaveChanges();

                    Dispose();
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddIncom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgetAppDataSet1.ExpenceTypes' table. You can move, or remove it, as needed.
            this.expenceTypesTableAdapter.Fill(this.budgetAppDataSet1.ExpenceTypes);
            // TODO: This line of code loads data into the 'budgetAppDataSet.IncomeTypes' table. You can move, or remove it, as needed.
            this.incomeTypesTableAdapter.Fill(this.budgetAppDataSet.IncomeTypes);

        }
    }
}
