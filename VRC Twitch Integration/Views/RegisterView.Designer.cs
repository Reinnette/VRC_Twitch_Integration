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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServers = new System.Windows.Forms.Button();
            this.btnParameters = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnParameters);
            this.panel1.Controls.Add(this.btnServers);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 458);
            this.panel1.TabIndex = 0;
            // 
            // btnServers
            // 
            this.btnServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServers.ForeColor = System.Drawing.Color.White;
            this.btnServers.Location = new System.Drawing.Point(3, 3);
            this.btnServers.Name = "btnServers";
            this.btnServers.Size = new System.Drawing.Size(195, 75);
            this.btnServers.TabIndex = 0;
            this.btnServers.Text = "Servers";
            this.btnServers.UseVisualStyleBackColor = false;
            // 
            // btnParameters
            // 
            this.btnParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParameters.ForeColor = System.Drawing.Color.White;
            this.btnParameters.Location = new System.Drawing.Point(3, 75);
            this.btnParameters.Name = "btnParameters";
            this.btnParameters.Size = new System.Drawing.Size(195, 75);
            this.btnParameters.TabIndex = 1;
            this.btnParameters.Text = "Parameters";
            this.btnParameters.UseVisualStyleBackColor = false;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnParameters;
        private Button btnServers;
    }
}