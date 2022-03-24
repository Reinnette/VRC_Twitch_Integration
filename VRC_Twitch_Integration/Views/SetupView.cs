using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VRC_Twitch_Integration.Data;

namespace VRC_Twitch_Integration.Views
{
    public partial class SetupView : Form
    {
        public SetupView()
        {
            InitializeComponent();

            //Populate the table with the saved data
            var tableData = SetupData.RowData;

            for (int count = 0; count < tableData.Count; count++)
            {
                dataGridView1.Rows[count].Cells[0].Value = tableData[count].InboundServer;
                dataGridView1.Rows[count].Cells[1].Value = tableData[count].InboundParameters;
                dataGridView1.Rows[count].Cells[2].Value = tableData[count].OutboundServer;
                dataGridView1.Rows[count].Cells[3].Value = tableData[count].OutboundParameters;
                dataGridView1.Rows[count].Cells[4].Value = tableData[count].Conditions;

                dataGridView1.Rows.Add();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(NavigationForms.Home);
        }

        private void cellChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var col = e.ColumnIndex;

            if (row < 0 || col < 0)
                return;

            if (dataGridView1.Rows.Count < 0)
                return;

            var value = dataGridView1.Rows[row].Cells[col].Value.ToString();

            var tableData = SetupData.RowData;

            //If its null than this must be a new row
            if (tableData.Count <= row)
            {
                var fieldData = new SetupFieldData();
                fieldData.OutboundServer = "";
                fieldData.OutboundParameters = "";
                fieldData.InboundServer = "";
                fieldData.InboundParameters = "";
                fieldData.Conditions = "";

                tableData.Add(SetValueChanged(fieldData, col, value));           
            }
            else //User is modifying a row in the table
            {
                tableData[row] = SetValueChanged(tableData[row], col, value);
            }
        }

        private SetupFieldData SetValueChanged(SetupFieldData rowData, int column, string value)
        {
            switch (column)
            { 
                case 0:
                    rowData.InboundServer = value;
                    break;
                case 1:
                    rowData.InboundParameters = value;
                    break;
                case 2:
                    rowData.OutboundServer = value;
                    break;
                case 3:
                    rowData.OutboundParameters = value;
                    break;
                case 4:
                    rowData.Conditions = value;
                    break;
            }

            return rowData;
        }
    }
}
