﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using TreinamentoBalizador_IFSP.Data;
using TreinamentoBalizador_IFSP.Models;
using TreinamentoBalizador_IFSP.Services;

namespace TreinamentoBalizador_IFSP.View
{
    public partial class TrainingFormView : Form, FormInterface
    {
        private List<ActiveMovement> activeMovements;
        Movements movementData = Movements.Instance;
        private bool trainingFile;
        private String movementText = "";
        private String movementKey = "";
        CaptureKinectServiceNew captureService;
        CommunicationService communicationService = new CommunicationService();
        private FormatedCoordinatesModel formatedCoordinates;
        private bool shouldCancel = false;


        public TrainingFormView(bool trainingFile, String formName)
        {
            InitializeComponent();
            lblFormName.Text = formName;
            activeMovements = movementData.activeMovements;
            this.trainingFile = trainingFile;
            PopulateCombobox();
            cbxSelectMovement.SelectedIndex = -1;

            this.trainingFile = trainingFile;
        }

        private void cbxSelectMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectMovement.SelectedValue != null) {
                movementText = cbxSelectMovement.Text;
                movementKey = cbxSelectMovement.SelectedValue.ToString();
                btnTrainingMove.Enabled = true;
                lblMovement.Text = "";
            }


            try
            {
                String path = Application.StartupPath;
                wmpMovement.URL = path + "\\Videos\\" + cbxSelectMovement.SelectedValue + ".mp4";
                wmpMovement.Ctlcontrols.play();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Arquivi não encontrado", "Ops!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PopulateCombobox()
        {
            var dataSource = new List<MovementItem>();
            foreach (ActiveMovement movement in activeMovements)
            {
                dataSource.Add(new MovementItem() { Text = movement.Name, Key = movement.Key });
            }

            this.cbxSelectMovement.DataSource = dataSource;
            this.cbxSelectMovement.DisplayMember = "Text";
            this.cbxSelectMovement.ValueMember = "Key";
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            pbCapturing.Style = ProgressBarStyle.Blocks;
            pbCapturing.Value = 0;

            bgdProgressStatus.RunWorkerAsync();

            btnStartCapture.Enabled = false;
            btnStopCapture.Enabled = true;
            cbxSelectMovement.Enabled = false;

            captureService.StartSaveCoordinates();
        }

        private void btnStopCapture_Click(object sender, EventArgs e)
        {
            shouldCancel = true;
            captureService.StopAll();
            btnStopCapture.Enabled = false;
            bgdProgressStatus.CancelAsync();
            btnTrainingMove.Enabled = true;
            cbxSelectMovement.Enabled = true;
            lblMovement.Text = "";
            lblSensorReady.Text = "";
        }

        private void btnTrainingMove_Click(object sender, EventArgs e)
        {
            if (cbxSelectMovement.SelectedIndex == -1)
            {

                MessageBox.Show("Selecione um movimento!", "Ops!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                captureService = new CaptureKinectServiceNew(this, movementKey, this.trainingFile);
                captureService.StartKinectSensor();
                btnTrainingMove.Enabled = false;
                shouldCancel = false;
            }
        }

        private void bgdProgressStatus_DoWork_1(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 16; i++)
            {
                Thread.Sleep(500);
                bgdProgressStatus.ReportProgress((100 / 16) * i);
                if (shouldCancel)
                {
                    bgdProgressStatus.ReportProgress(0);
                    break;
                }
            }

            bgdProgressStatus.ReportProgress(100);
        }

        private void bgdProgressStatus_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            pbCapturing.Value = e.ProgressPercentage;
        }

        private void bgdProgressStatus_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public void SetMovementLabel()
        {
            lblMovement.Text = movementText;
        }

        public void FinishCapture()
        {
            movementText = "";
            movementKey = "";

            btnStopCapture.BeginInvoke(
                new Action(() => { btnStopCapture.Enabled = false; })
            );

            btnStartCapture.BeginInvoke(
                new Action(() => { btnStartCapture.Enabled = false; })
            );
            

            lblSensorReady.BeginInvoke(
                new Action(() => { lblSensorReady.Text = ""; })
            );

            lblMovement.BeginInvoke(
                new Action(() => { lblMovement.Text = ""; })
            );

            if (!shouldCancel)
            {
                formatedCoordinates = captureService.formatedCoordinates;
                communicationService.Communicate(formatedCoordinates, trainingFile);
            }

            if (trainingFile)
            {
                movementData.SetNull();
                movementData = Movements.Instance;
            }

            cbxSelectMovement.BeginInvoke(
                new Action(() => {
                    cbxSelectMovement.SelectedIndex = -1;
                    cbxSelectMovement.Enabled = true;
                })
            );

            btnTrainingMove.BeginInvoke(
                new Action(() => { btnTrainingMove.Enabled = true; })
            );

            // bgdProgressStatus.ReportProgress(0);
        }

        public void BodyDetected()
        {
            btnStartCapture.Enabled = true;
            lblSensorReady.Text = "Reconhecimento concluido";
        }
    }
}
