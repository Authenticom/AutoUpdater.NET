﻿using System.Threading;

namespace AutoUpdaterDVSync
{
    partial class UpdateForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
      this.webBrowser = new System.Windows.Forms.WebBrowser();
      this.labelUpdate = new System.Windows.Forms.Label();
      this.labelDescription = new System.Windows.Forms.Label();
      this.labelReleaseNotes = new System.Windows.Forms.Label();
      this.buttonUpdate = new System.Windows.Forms.Button();
      this.buttonRemindLater = new System.Windows.Forms.Button();
      this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
      this.buttonSkip = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
      this.SuspendLayout();
      // 
      // webBrowser
      // 
      resources.ApplyResources(this.webBrowser, "webBrowser");
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.ScriptErrorsSuppressed = true;
      this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
      // 
      // labelUpdate
      // 
      resources.ApplyResources(this.labelUpdate, "labelUpdate");
      this.labelUpdate.Name = "labelUpdate";
      this.labelUpdate.Click += new System.EventHandler(this.labelUpdate_Click);
      // 
      // labelDescription
      // 
      resources.ApplyResources(this.labelDescription, "labelDescription");
      this.labelDescription.Name = "labelDescription";
      this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
      // 
      // labelReleaseNotes
      // 
      resources.ApplyResources(this.labelReleaseNotes, "labelReleaseNotes");
      this.labelReleaseNotes.Name = "labelReleaseNotes";
      this.labelReleaseNotes.Click += new System.EventHandler(this.labelReleaseNotes_Click);
      // 
      // buttonUpdate
      // 
      resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
      this.buttonUpdate.Image = global::AutoUpdaterDVSync.Properties.Resources.download;
      this.buttonUpdate.Name = "buttonUpdate";
      this.buttonUpdate.UseVisualStyleBackColor = true;
      this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
      // 
      // buttonRemindLater
      // 
      resources.ApplyResources(this.buttonRemindLater, "buttonRemindLater");
      this.buttonRemindLater.Image = global::AutoUpdaterDVSync.Properties.Resources.clock_go;
      this.buttonRemindLater.Name = "buttonRemindLater";
      this.buttonRemindLater.UseVisualStyleBackColor = true;
      this.buttonRemindLater.Click += new System.EventHandler(this.ButtonRemindLaterClick);
      // 
      // pictureBoxIcon
      // 
      this.pictureBoxIcon.Image = global::AutoUpdaterDVSync.Properties.Resources.logo;
      resources.ApplyResources(this.pictureBoxIcon, "pictureBoxIcon");
      this.pictureBoxIcon.Name = "pictureBoxIcon";
      this.pictureBoxIcon.TabStop = false;
      this.pictureBoxIcon.Click += new System.EventHandler(this.pictureBoxIcon_Click);
      // 
      // buttonSkip
      // 
      this.buttonSkip.DialogResult = System.Windows.Forms.DialogResult.Abort;
      resources.ApplyResources(this.buttonSkip, "buttonSkip");
      this.buttonSkip.Image = global::AutoUpdaterDVSync.Properties.Resources.hand_point;
      this.buttonSkip.Name = "buttonSkip";
      this.buttonSkip.UseVisualStyleBackColor = true;
      this.buttonSkip.Click += new System.EventHandler(this.ButtonSkipClick);
      // 
      // UpdateForm
      // 
      this.AcceptButton = this.buttonUpdate;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pictureBoxIcon);
      this.Controls.Add(this.labelReleaseNotes);
      this.Controls.Add(this.labelDescription);
      this.Controls.Add(this.labelUpdate);
      this.Controls.Add(this.webBrowser);
      this.Controls.Add(this.buttonUpdate);
      this.Controls.Add(this.buttonSkip);
      this.Controls.Add(this.buttonRemindLater);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UpdateForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateForm_FormClosed);
      this.Load += new System.EventHandler(this.UpdateFormLoad);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemindLater;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelReleaseNotes;
        private System.Windows.Forms.PictureBox pictureBoxIcon;

    }
}