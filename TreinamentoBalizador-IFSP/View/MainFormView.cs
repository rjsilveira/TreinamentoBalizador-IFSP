﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class MainFormView : Form
    {
        private Form _objForm;

        public MainFormView()
        {
            InitializeComponent();
        }

        private void msOpenClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void msOpenCaptureParametersForm_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new MovementList {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void msOpenGroundSignalsListForm_Click(object sender, EventArgs e)
        {
            _objForm?.Close();

            _objForm = new CaptureParametersView
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            pnlBaseForm.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
