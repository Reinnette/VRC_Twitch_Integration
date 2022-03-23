using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VRC_Twitch_Integration.Data;

namespace VRC_Twitch_Integration.Views
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();

            PopulateTable();
            UpdateParameterList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigation.Navigate(NavigationForms.Home);
        }

        #region Menu Buttons
        private void btnTwitchPanel_Click(object sender, EventArgs e)
        {
            pnlTwitch.Visible = true;
            pnlServers.Visible = false;
            pnlParameters.Visible = false;

            pnlTwitch.Location = new Point(240,0);
            pnlServers.Location = new Point(240, 0);
            pnlParameters.Location = new Point(240, 0);
        }

        private void btnServersPanel_Click(object sender, EventArgs e)
        {
            pnlTwitch.Visible = false;
            pnlServers.Visible = true;
            pnlParameters.Visible = false;

            pnlTwitch.Location = new Point(240, 0);
            pnlServers.Location = new Point(240, 0);
            pnlParameters.Location = new Point(240, 0);
        }

        private void btnParametersPanel_Click(object sender, EventArgs e)
        {
            pnlTwitch.Visible = false;
            pnlServers.Visible = false;
            pnlParameters.Visible = true;

            pnlTwitch.Location = new Point(240, 0);
            pnlServers.Location = new Point(240, 0);
            pnlParameters.Location = new Point(240, 0);
        }

        #endregion

        #region Parameter Panel
        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            ParameterData.Parameters.Add(txtNewParameter.Text);

            txtNewParameter.Text = "";

            UpdateParameterList();
        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            //TODO read from file
            List<string> inputParameters = new List<string>(); //Replace with file values

            foreach (var inputParams in inputParameters)
                ParameterData.Parameters.Add(inputParams);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for(int count = 0; count < lstParameterView.Items.Count; count++)
                if(lstParameterView.Items[count].Text.Contains(txtSearch.Text))
                    lstParameterView.Items[count].BackColor = Color.Yellow;
                else
                    lstParameterView.Items[count].BackColor = Color.Transparent;
        }

        private void UpdateParameterList()
        { 
            lstParameterView.Items.Clear();

            foreach (var lstItem in ParameterData.Parameters)
            {
                lstParameterView.Items.Add(lstItem);
            }
        }

        #endregion

        #region Servers Panel

        private void cellChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var col = e.ColumnIndex;

            if (row < 0 || col < 0)
                return;

            if (dataGridView1.Rows.Count < 0)
                return;

            var value = dataGridView1.Rows[row].Cells[col].Value.ToString();
            var tableData = ServerData.RegisteredServers;

            //If its null than this must be a new row
            if (tableData.Count <= row)
            {
                var fieldData = new ServerInfo();
                fieldData.ServerName = "NewServer";
                fieldData.ServerURL = "";
                fieldData.ServerPort = 0;

                tableData.Add(SetValueChanged(fieldData, col, value));
            }
            else //User is modifying a row in the table
            {
                tableData[row] = SetValueChanged(tableData[row], col, value);
            }

            //We updated the table
            //Its posible some out side source updated the values
            //or only the url or port were entered. 
            //Lest redraw the table
            PopulateTable();
        }

        private ServerInfo SetValueChanged(ServerInfo rowData, int column, string value)
        {
            switch (column)
            {
                case 0:
                    rowData.ServerName = value;
                    break;
                case 1:
                    rowData.ServerURL = value;
                    break;
                case 2:
                    rowData.ServerPort = int.Parse(value);
                    break;
            }

            return rowData;
        }

        private void PopulateTable()
        {
            //Start by clearing all of the data
            dataGridView1.Rows.Clear();

            //Populate the table with the saved data
            var tableData = ServerData.RegisteredServers;

            for (int count = 0; count < tableData.Count; count++)
            {
                dataGridView1.Rows[count].Cells[0].Value = tableData[count].ServerName;
                dataGridView1.Rows[count].Cells[1].Value = tableData[count].ServerURL;
                dataGridView1.Rows[count].Cells[2].Value = tableData[count].ServerPort;

                dataGridView1.Rows.Add();
            }
        }

        #endregion
    }
}