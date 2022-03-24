using System;
using System.Drawing;
using System.Windows.Forms;

namespace VRC_Twitch_Integration.Views
{
    partial class RegisterView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTwitchPanel = new System.Windows.Forms.Button();
            this.btnParametersPanel = new System.Windows.Forms.Button();
            this.btnServersPanel = new System.Windows.Forms.Button();
            this.pnlServers = new System.Windows.Forms.Panel();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.pnlTwitch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstParameterView = new System.Windows.Forms.ListView();
            this.txtNewParameter = new System.Windows.Forms.TextBox();
            this.btnFromFile = new System.Windows.Forms.Button();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlServers.SuspendLayout();
            this.pnlParameters.SuspendLayout();
            this.pnlTwitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnTwitchPanel);
            this.panel1.Controls.Add(this.btnParametersPanel);
            this.panel1.Controls.Add(this.btnServersPanel);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 458);
            this.panel1.TabIndex = 0;
            // 
            // btnTwitchPanel
            // 
            this.btnTwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTwitchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwitchPanel.ForeColor = System.Drawing.Color.White;
            this.btnTwitchPanel.Location = new System.Drawing.Point(2, 3);
            this.btnTwitchPanel.Name = "btnTwitchPanel";
            this.btnTwitchPanel.Size = new System.Drawing.Size(195, 75);
            this.btnTwitchPanel.TabIndex = 2;
            this.btnTwitchPanel.Text = "Twitch";
            this.btnTwitchPanel.UseVisualStyleBackColor = false;
            this.btnTwitchPanel.Click += new System.EventHandler(this.btnTwitchPanel_Click);
            // 
            // btnParametersPanel
            // 
            this.btnParametersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnParametersPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametersPanel.ForeColor = System.Drawing.Color.White;
            this.btnParametersPanel.Location = new System.Drawing.Point(2, 147);
            this.btnParametersPanel.Name = "btnParametersPanel";
            this.btnParametersPanel.Size = new System.Drawing.Size(195, 75);
            this.btnParametersPanel.TabIndex = 1;
            this.btnParametersPanel.Text = "Parameters";
            this.btnParametersPanel.UseVisualStyleBackColor = false;
            this.btnParametersPanel.Click += new System.EventHandler(this.btnParametersPanel_Click);
            // 
            // btnServersPanel
            // 
            this.btnServersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServersPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServersPanel.ForeColor = System.Drawing.Color.White;
            this.btnServersPanel.Location = new System.Drawing.Point(2, 75);
            this.btnServersPanel.Name = "btnServersPanel";
            this.btnServersPanel.Size = new System.Drawing.Size(195, 75);
            this.btnServersPanel.TabIndex = 0;
            this.btnServersPanel.Text = "External Servers";
            this.btnServersPanel.UseVisualStyleBackColor = false;
            this.btnServersPanel.Click += new System.EventHandler(this.btnServersPanel_Click);
            // 
            // pnlServers
            // 
            this.pnlServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlServers.Controls.Add(this.dataGridView1);
            this.pnlServers.Controls.Add(this.label1);
            this.pnlServers.Location = new System.Drawing.Point(240, 0);
            this.pnlServers.Name = "pnlServers";
            this.pnlServers.Size = new System.Drawing.Size(740, 460);
            this.pnlServers.TabIndex = 1;
            // 
            // pnlParameters
            // 
            this.pnlParameters.Controls.Add(this.txtSearch);
            this.pnlParameters.Controls.Add(this.btnSearch);
            this.pnlParameters.Controls.Add(this.lstParameterView);
            this.pnlParameters.Controls.Add(this.txtNewParameter);
            this.pnlParameters.Controls.Add(this.btnFromFile);
            this.pnlParameters.Controls.Add(this.btnAddParameter);
            this.pnlParameters.Controls.Add(this.label2);
            this.pnlParameters.Location = new System.Drawing.Point(240, 0);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(740, 460);
            this.pnlParameters.TabIndex = 2;
            // 
            // pnlTwitch
            // 
            this.pnlTwitch.Controls.Add(this.label3);
            this.pnlTwitch.Location = new System.Drawing.Point(240, 0);
            this.pnlTwitch.Name = "pnlTwitch";
            this.pnlTwitch.Size = new System.Drawing.Size(740, 460);
            this.pnlTwitch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(230, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Register Twitch";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(470, 149);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(576, 143);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstParameterView
            // 
            this.lstParameterView.HideSelection = false;
            this.lstParameterView.Location = new System.Drawing.Point(95, 174);
            this.lstParameterView.Name = "lstParameterView";
            this.lstParameterView.Size = new System.Drawing.Size(561, 258);
            this.lstParameterView.TabIndex = 4;
            this.lstParameterView.UseCompatibleStateImageBehavior = false;
            // 
            // txtNewParameter
            // 
            this.txtNewParameter.Location = new System.Drawing.Point(95, 83);
            this.txtNewParameter.Name = "txtNewParameter";
            this.txtNewParameter.Size = new System.Drawing.Size(115, 20);
            this.txtNewParameter.TabIndex = 3;
            // 
            // btnFromFile
            // 
            this.btnFromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFromFile.ForeColor = System.Drawing.Color.White;
            this.btnFromFile.Location = new System.Drawing.Point(437, 77);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(80, 30);
            this.btnFromFile.TabIndex = 2;
            this.btnFromFile.Text = "Add From File";
            this.btnFromFile.UseVisualStyleBackColor = false;
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddParameter.ForeColor = System.Drawing.Color.White;
            this.btnAddParameter.Location = new System.Drawing.Point(216, 77);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(80, 30);
            this.btnAddParameter.TabIndex = 1;
            this.btnAddParameter.Text = "Add New";
            this.btnAddParameter.UseVisualStyleBackColor = false;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register Parameters";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerName,
            this.ServerUrl,
            this.ServerPort});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 72);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Size = new System.Drawing.Size(692, 372);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellChanged);
            // 
            // ServerName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ServerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ServerName.HeaderText = "Server Name";
            this.ServerName.Name = "ServerName";
            this.ServerName.Width = 200;
            // 
            // ServerUrl
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ServerUrl.DefaultCellStyle = dataGridViewCellStyle4;
            this.ServerUrl.HeaderText = "Server Url";
            this.ServerUrl.Name = "ServerUrl";
            this.ServerUrl.Width = 200;
            // 
            // ServerPort
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.ServerPort.DefaultCellStyle = dataGridViewCellStyle5;
            this.ServerPort.HeaderText = "Server Port";
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Servers";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(203, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 63);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlTwitch);
            this.Controls.Add(this.pnlServers);
            this.Controls.Add(this.pnlParameters);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.panel1.ResumeLayout(false);
            this.pnlServers.ResumeLayout(false);
            this.pnlServers.PerformLayout();
            this.pnlParameters.ResumeLayout(false);
            this.pnlParameters.PerformLayout();
            this.pnlTwitch.ResumeLayout(false);
            this.pnlTwitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnParametersPanel;
        private Button btnServersPanel;
        private Panel pnlServers;
        private Button btnBack;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ServerName;
        private DataGridViewTextBoxColumn ServerUrl;
        private DataGridViewTextBoxColumn ServerPort;
        private Button btnTwitchPanel;
        private Panel pnlParameters;
        private Label label2;
        private ListView lstParameterView;
        private TextBox txtNewParameter;
        private Button btnFromFile;
        private Button btnAddParameter;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel pnlTwitch;
        private Label label3;
    }
}