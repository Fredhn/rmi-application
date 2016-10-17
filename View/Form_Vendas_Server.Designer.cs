using System;

namespace Vendas.Server.View
{
    partial class Form_Vendas_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vendas_Server));
            this.pnlMain_Form = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain_2 = new System.Windows.Forms.Panel();
            this.pb_serverStatus = new System.Windows.Forms.PictureBox();
            this.radioButton_serverOffline = new System.Windows.Forms.RadioButton();
            this.radioButton_serverOnline = new System.Windows.Forms.RadioButton();
            this.lbl_pnlMain_Title = new System.Windows.Forms.Label();
            this.notifyIcon_ServerApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlMain_Form.SuspendLayout();
            this.pnlMain_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_serverStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain_Form
            // 
            this.pnlMain_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlMain_Form.Controls.Add(this.label1);
            this.pnlMain_Form.Controls.Add(this.pnlMain_2);
            this.pnlMain_Form.Controls.Add(this.lbl_pnlMain_Title);
            this.pnlMain_Form.Location = new System.Drawing.Point(0, 0);
            this.pnlMain_Form.Name = "pnlMain_Form";
            this.pnlMain_Form.Size = new System.Drawing.Size(246, 148);
            this.pnlMain_Form.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Application";
            // 
            // pnlMain_2
            // 
            this.pnlMain_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMain_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain_2.Controls.Add(this.pb_serverStatus);
            this.pnlMain_2.Controls.Add(this.radioButton_serverOffline);
            this.pnlMain_2.Controls.Add(this.radioButton_serverOnline);
            this.pnlMain_2.Location = new System.Drawing.Point(4, 47);
            this.pnlMain_2.Name = "pnlMain_2";
            this.pnlMain_2.Size = new System.Drawing.Size(238, 97);
            this.pnlMain_2.TabIndex = 1;
            // 
            // pb_serverStatus
            // 
            this.pb_serverStatus.Image = global::Vendas.View.Properties.Resources.Network_Offline_Alt;
            this.pb_serverStatus.Location = new System.Drawing.Point(142, 3);
            this.pb_serverStatus.Name = "pb_serverStatus";
            this.pb_serverStatus.Size = new System.Drawing.Size(90, 90);
            this.pb_serverStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_serverStatus.TabIndex = 2;
            this.pb_serverStatus.TabStop = false;
            // 
            // radioButton_serverOffline
            // 
            this.radioButton_serverOffline.AutoSize = true;
            this.radioButton_serverOffline.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_serverOffline.Location = new System.Drawing.Point(7, 59);
            this.radioButton_serverOffline.Name = "radioButton_serverOffline";
            this.radioButton_serverOffline.Size = new System.Drawing.Size(137, 19);
            this.radioButton_serverOffline.TabIndex = 0;
            this.radioButton_serverOffline.TabStop = true;
            this.radioButton_serverOffline.Text = "Server Offline";
            this.radioButton_serverOffline.UseVisualStyleBackColor = true;
            this.radioButton_serverOffline.CheckedChanged += new System.EventHandler(this.radioButton_serverOffline_CheckedChanged);
            this.radioButton_serverOffline.Click += new System.EventHandler(this.radioButton_serverOffline_Click);
            // 
            // radioButton_serverOnline
            // 
            this.radioButton_serverOnline.AutoSize = true;
            this.radioButton_serverOnline.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_serverOnline.Location = new System.Drawing.Point(7, 20);
            this.radioButton_serverOnline.Name = "radioButton_serverOnline";
            this.radioButton_serverOnline.Size = new System.Drawing.Size(129, 19);
            this.radioButton_serverOnline.TabIndex = 1;
            this.radioButton_serverOnline.TabStop = true;
            this.radioButton_serverOnline.Text = "Server Online";
            this.radioButton_serverOnline.UseVisualStyleBackColor = true;
            this.radioButton_serverOnline.CheckedChanged += new System.EventHandler(this.radioButton_serverOnline_CheckedChanged);
            // 
            // lbl_pnlMain_Title
            // 
            this.lbl_pnlMain_Title.AutoSize = true;
            this.lbl_pnlMain_Title.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlMain_Title.Location = new System.Drawing.Point(34, 5);
            this.lbl_pnlMain_Title.Name = "lbl_pnlMain_Title";
            this.lbl_pnlMain_Title.Size = new System.Drawing.Size(178, 18);
            this.lbl_pnlMain_Title.TabIndex = 0;
            this.lbl_pnlMain_Title.Text = "Sistema de Vendas";
            // 
            // notifyIcon_ServerApp
            // 
            this.notifyIcon_ServerApp.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon_ServerApp.BalloonTipText = "Vendas - Server App";
            this.notifyIcon_ServerApp.BalloonTipTitle = "Vendas - Server App";
            this.notifyIcon_ServerApp.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_ServerApp.Icon")));
            this.notifyIcon_ServerApp.Text = "Vendas - Server App";
            this.notifyIcon_ServerApp.Visible = true;
            this.notifyIcon_ServerApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_ServerApp_MouseDoubleClick);
            // 
            // Form_Vendas_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 148);
            this.Controls.Add(this.pnlMain_Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Vendas_Server";
            this.Text = "Vendas - Server";
            this.pnlMain_Form.ResumeLayout(false);
            this.pnlMain_Form.PerformLayout();
            this.pnlMain_2.ResumeLayout(false);
            this.pnlMain_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_serverStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain_Form;
        private System.Windows.Forms.Label lbl_pnlMain_Title;
        private System.Windows.Forms.Panel pnlMain_2;
        private System.Windows.Forms.PictureBox pb_serverStatus;
        private System.Windows.Forms.RadioButton radioButton_serverOffline;
        private System.Windows.Forms.RadioButton radioButton_serverOnline;
        private System.Windows.Forms.NotifyIcon notifyIcon_ServerApp;
        private System.Windows.Forms.Label label1;
    }
}

