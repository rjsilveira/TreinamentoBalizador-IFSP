﻿using System.Drawing;
using System.Windows.Forms;

namespace TreinamentoBalizador_IFSP.View
{
    partial class MainFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormView));
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenCaptureParametersForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msOpenTestForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.msOpenGroundSignalsListForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.msOpenClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBaseForm = new System.Windows.Forms.Panel();
            this.balanceamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Controls.Add(this.menuStrip1);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(777, 25);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msMainMenu
            // 
            this.msMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msOpenCaptureParametersForm,
            this.toolStripSeparator1,
            this.msOpenTestForm,
            this.toolStripSeparator4,
            this.msOpenGroundSignalsListForm,
            this.balanceamentoToolStripMenuItem,
            this.toolStripSeparator3,
            this.msOpenClose});
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(50, 20);
            this.msMainMenu.Text = "Menu";
            // 
            // msOpenCaptureParametersForm
            // 
            this.msOpenCaptureParametersForm.Name = "msOpenCaptureParametersForm";
            this.msOpenCaptureParametersForm.Size = new System.Drawing.Size(190, 22);
            this.msOpenCaptureParametersForm.Text = "Treinamento";
            this.msOpenCaptureParametersForm.Click += new System.EventHandler(this.msOpenCaptureParametersForm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // msOpenTestForm
            // 
            this.msOpenTestForm.Name = "msOpenTestForm";
            this.msOpenTestForm.Size = new System.Drawing.Size(190, 22);
            this.msOpenTestForm.Text = "Prova";
            this.msOpenTestForm.Click += new System.EventHandler(this.msOpenTestForm_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // msOpenGroundSignalsListForm
            // 
            this.msOpenGroundSignalsListForm.Name = "msOpenGroundSignalsListForm";
            this.msOpenGroundSignalsListForm.Size = new System.Drawing.Size(190, 22);
            this.msOpenGroundSignalsListForm.Text = "Adicionar movimento";
            this.msOpenGroundSignalsListForm.Click += new System.EventHandler(this.msOpenGroundSignalsListForm_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // msOpenClose
            // 
            this.msOpenClose.Name = "msOpenClose";
            this.msOpenClose.Size = new System.Drawing.Size(190, 22);
            this.msOpenClose.Text = "Sair";
            this.msOpenClose.Click += new System.EventHandler(this.msOpenClose_Click);
            // 
            // pnlBaseForm
            // 
            this.pnlBaseForm.BackgroundImage = global::TreinamentoBalizador_IFSP.Properties.Resources.logo;
            this.pnlBaseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBaseForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBaseForm.Location = new System.Drawing.Point(0, 25);
            this.pnlBaseForm.Name = "pnlBaseForm";
            this.pnlBaseForm.Size = new System.Drawing.Size(777, 546);
            this.pnlBaseForm.TabIndex = 1;
            // 
            // balanceamentoToolStripMenuItem
            // 
            this.balanceamentoToolStripMenuItem.Name = "balanceamentoToolStripMenuItem";
            this.balanceamentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.balanceamentoToolStripMenuItem.Text = "Balanceamento";
            this.balanceamentoToolStripMenuItem.Click += new System.EventHandler(this.balanceamentoToolStripMenuItem_Click);
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.pnlBaseForm);
            this.Controls.Add(this.pnlTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFormView";
            this.Text = "Treinamento para balizadores de aéronaves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem msOpenCaptureParametersForm;
        private System.Windows.Forms.ToolStripMenuItem msOpenGroundSignalsListForm;
        private System.Windows.Forms.ToolStripMenuItem msOpenClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel pnlBaseForm;
        private System.Windows.Forms.ToolStripMenuItem msOpenTestForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem balanceamentoToolStripMenuItem;
    }
}