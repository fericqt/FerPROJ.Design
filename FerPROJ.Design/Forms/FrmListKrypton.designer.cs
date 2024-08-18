﻿
using FerPROJ.Design.Controls;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FerPROJ.Design.Forms
{
    partial class FrmListKrypton {
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
        /// 

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListKrypton));
            this.baseLbl1 = new System.Windows.Forms.Label();
            this.basePnl1 = new System.Windows.Forms.Panel();
            this.customLabelDescMain1 = new FerPROJ.Design.Controls.CLabelDesc();
            this.SearchTextBox = new FerPROJ.Design.Controls.CTextBox();
            this.basePnl2 = new System.Windows.Forms.Panel();
            this.baseButtonSelect = new FerPROJ.Design.Controls.CButton();
            this.baseButtonCancel = new FerPROJ.Design.Controls.CButton();
            this.baseDateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customLabelDescMain3 = new FerPROJ.Design.Controls.CLabelDesc();
            this.baseDateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customLabelDescMain2 = new FerPROJ.Design.Controls.CLabelDesc();
            this.PanelMain1 = new System.Windows.Forms.Panel();
            this.PanelMain4 = new System.Windows.Forms.Panel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelMain11 = new System.Windows.Forms.Panel();
            this.PnlFormList = new System.Windows.Forms.Panel();
            this.baselabelmain12 = new System.Windows.Forms.Label();
            this.customLabelDescMain11 = new FerPROJ.Design.Controls.CLabelDesc();
            this.customLabelDescMain10 = new FerPROJ.Design.Controls.CLabelDesc();
            this.tsbMainAddItem = new System.Windows.Forms.ToolStripButton();
            this.tsbMainEditItem = new System.Windows.Forms.ToolStripButton();
            this.tsbMainDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tsbMainViewItem = new System.Windows.Forms.ToolStripButton();
            this.tsbMainRefresh = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxMain1 = new System.Windows.Forms.PictureBox();
            this.basePnl1.SuspendLayout();
            this.basePnl2.SuspendLayout();
            this.PanelMain1.SuspendLayout();
            this.PanelMain4.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.panelMain11.SuspendLayout();
            this.PnlFormList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseLbl1
            // 
            this.baseLbl1.BackColor = System.Drawing.Color.DimGray;
            this.baseLbl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseLbl1.Location = new System.Drawing.Point(0, 0);
            this.baseLbl1.Name = "baseLbl1";
            this.baseLbl1.Size = new System.Drawing.Size(754, 1);
            this.baseLbl1.TabIndex = 0;
            this.baseLbl1.Text = "1";
            // 
            // basePnl1
            // 
            this.basePnl1.BackColor = System.Drawing.Color.Navy;
            this.basePnl1.Controls.Add(this.customLabelDescMain1);
            this.basePnl1.Controls.Add(this.SearchTextBox);
            this.basePnl1.Controls.Add(this.basePnl2);
            this.basePnl1.Controls.Add(this.baseLbl1);
            this.basePnl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.basePnl1.Location = new System.Drawing.Point(0, 363);
            this.basePnl1.Name = "basePnl1";
            this.basePnl1.Size = new System.Drawing.Size(754, 71);
            this.basePnl1.TabIndex = 1;
            // 
            // customLabelDescMain1
            // 
            this.customLabelDescMain1.AutoSize = true;
            this.customLabelDescMain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customLabelDescMain1.ForeColor = System.Drawing.Color.White;
            this.customLabelDescMain1.Location = new System.Drawing.Point(15, 8);
            this.customLabelDescMain1.Name = "customLabelDescMain1";
            this.customLabelDescMain1.Size = new System.Drawing.Size(57, 17);
            this.customLabelDescMain1.TabIndex = 3;
            this.customLabelDescMain1.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.SearchTextBox.BorderRadius = 15;
            this.SearchTextBox.BorderSize = 2;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextBox.Location = new System.Drawing.Point(75, 26);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.OnFocus = false;
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.SearchTextBox.PasswordChar = false;
            this.SearchTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(305, 31);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextProperty = null;
            this.SearchTextBox.Texts = "";
            this.SearchTextBox.UnderlinedStyle = false;
            // 
            // basePnl2
            // 
            this.basePnl2.Controls.Add(this.baseButtonSelect);
            this.basePnl2.Controls.Add(this.baseButtonCancel);
            this.basePnl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.basePnl2.Location = new System.Drawing.Point(512, 1);
            this.basePnl2.Name = "basePnl2";
            this.basePnl2.Size = new System.Drawing.Size(242, 70);
            this.basePnl2.TabIndex = 2;
            // 
            // baseButtonSelect
            // 
            this.baseButtonSelect.BackColor = System.Drawing.Color.DodgerBlue;
            this.baseButtonSelect.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.baseButtonSelect.BorderColor = System.Drawing.Color.Green;
            this.baseButtonSelect.BorderRadius = 20;
            this.baseButtonSelect.BorderSize = 0;
            this.baseButtonSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseButtonSelect.FlatAppearance.BorderSize = 0;
            this.baseButtonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButtonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseButtonSelect.ForeColor = System.Drawing.Color.White;
            this.baseButtonSelect.Location = new System.Drawing.Point(20, 14);
            this.baseButtonSelect.Name = "baseButtonSelect";
            this.baseButtonSelect.Size = new System.Drawing.Size(101, 40);
            this.baseButtonSelect.TabIndex = 0;
            this.baseButtonSelect.Text = "Select";
            this.baseButtonSelect.TextColor = System.Drawing.Color.White;
            this.baseButtonSelect.UseVisualStyleBackColor = false;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Crimson;
            this.baseButtonCancel.BackgroundColor = System.Drawing.Color.Crimson;
            this.baseButtonCancel.BorderColor = System.Drawing.Color.Green;
            this.baseButtonCancel.BorderRadius = 20;
            this.baseButtonCancel.BorderSize = 0;
            this.baseButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseButtonCancel.FlatAppearance.BorderSize = 0;
            this.baseButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baseButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseButtonCancel.ForeColor = System.Drawing.Color.White;
            this.baseButtonCancel.Location = new System.Drawing.Point(127, 14);
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.Size = new System.Drawing.Size(101, 40);
            this.baseButtonCancel.TabIndex = 1;
            this.baseButtonCancel.Text = "Cancel";
            this.baseButtonCancel.TextColor = System.Drawing.Color.White;
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            // 
            // baseDateToDateTimePicker
            // 
            this.baseDateToDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDateToDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDateToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baseDateToDateTimePicker.Location = new System.Drawing.Point(131, 36);
            this.baseDateToDateTimePicker.Name = "baseDateToDateTimePicker";
            this.baseDateToDateTimePicker.Size = new System.Drawing.Size(115, 22);
            this.baseDateToDateTimePicker.TabIndex = 7;
            // 
            // customLabelDescMain3
            // 
            this.customLabelDescMain3.AutoSize = true;
            this.customLabelDescMain3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customLabelDescMain3.ForeColor = System.Drawing.Color.White;
            this.customLabelDescMain3.Location = new System.Drawing.Point(131, 8);
            this.customLabelDescMain3.Name = "customLabelDescMain3";
            this.customLabelDescMain3.Size = new System.Drawing.Size(63, 17);
            this.customLabelDescMain3.TabIndex = 6;
            this.customLabelDescMain3.Text = "Date To:";
            // 
            // baseDateFromDateTimePicker
            // 
            this.baseDateFromDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDateFromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDateFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baseDateFromDateTimePicker.Location = new System.Drawing.Point(9, 36);
            this.baseDateFromDateTimePicker.Name = "baseDateFromDateTimePicker";
            this.baseDateFromDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.baseDateFromDateTimePicker.TabIndex = 5;
            // 
            // customLabelDescMain2
            // 
            this.customLabelDescMain2.AutoSize = true;
            this.customLabelDescMain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customLabelDescMain2.ForeColor = System.Drawing.Color.White;
            this.customLabelDescMain2.Location = new System.Drawing.Point(9, 8);
            this.customLabelDescMain2.Name = "customLabelDescMain2";
            this.customLabelDescMain2.Size = new System.Drawing.Size(78, 17);
            this.customLabelDescMain2.TabIndex = 4;
            this.customLabelDescMain2.Text = "Date From:";
            // 
            // PanelMain1
            // 
            this.PanelMain1.Controls.Add(this.PanelMain4);
            this.PanelMain1.Controls.Add(this.panelMain11);
            this.PanelMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain1.Location = new System.Drawing.Point(7, 7);
            this.PanelMain1.Name = "PanelMain1";
            this.PanelMain1.Size = new System.Drawing.Size(754, 507);
            this.PanelMain1.TabIndex = 2;
            // 
            // PanelMain4
            // 
            this.PanelMain4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelMain4.Controls.Add(this.mainToolStrip);
            this.PanelMain4.Controls.Add(this.basePnl1);
            this.PanelMain4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain4.Location = new System.Drawing.Point(0, 73);
            this.PanelMain4.Name = "PanelMain4";
            this.PanelMain4.Size = new System.Drawing.Size(754, 434);
            this.PanelMain4.TabIndex = 1;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.tsbMainAddItem,
            this.toolStripSeparator1,
            this.tsbMainEditItem,
            this.toolStripSeparator2,
            this.tsbMainDeleteItem,
            this.toolStripSeparator3,
            this.tsbMainViewItem,
            this.tsbMainRefresh});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainToolStrip.Size = new System.Drawing.Size(754, 41);
            this.mainToolStrip.TabIndex = 4;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // panelMain11
            // 
            this.panelMain11.BackColor = System.Drawing.Color.Navy;
            this.panelMain11.Controls.Add(this.PnlFormList);
            this.panelMain11.Controls.Add(this.baselabelmain12);
            this.panelMain11.Controls.Add(this.customLabelDescMain11);
            this.panelMain11.Controls.Add(this.pictureBoxMain1);
            this.panelMain11.Controls.Add(this.customLabelDescMain10);
            this.panelMain11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain11.Location = new System.Drawing.Point(0, 0);
            this.panelMain11.Name = "panelMain11";
            this.panelMain11.Size = new System.Drawing.Size(754, 73);
            this.panelMain11.TabIndex = 3;
            // 
            // PnlFormList
            // 
            this.PnlFormList.Controls.Add(this.baseDateToDateTimePicker);
            this.PnlFormList.Controls.Add(this.customLabelDescMain2);
            this.PnlFormList.Controls.Add(this.baseDateFromDateTimePicker);
            this.PnlFormList.Controls.Add(this.customLabelDescMain3);
            this.PnlFormList.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlFormList.Location = new System.Drawing.Point(499, 0);
            this.PnlFormList.Name = "PnlFormList";
            this.PnlFormList.Size = new System.Drawing.Size(255, 72);
            this.PnlFormList.TabIndex = 4;
            // 
            // baselabelmain12
            // 
            this.baselabelmain12.BackColor = System.Drawing.Color.DimGray;
            this.baselabelmain12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baselabelmain12.Location = new System.Drawing.Point(0, 72);
            this.baselabelmain12.Name = "baselabelmain12";
            this.baselabelmain12.Size = new System.Drawing.Size(754, 1);
            this.baselabelmain12.TabIndex = 3;
            this.baselabelmain12.Text = "1";
            // 
            // customLabelDescMain11
            // 
            this.customLabelDescMain11.AutoSize = true;
            this.customLabelDescMain11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabelDescMain11.ForeColor = System.Drawing.Color.White;
            this.customLabelDescMain11.Location = new System.Drawing.Point(103, 39);
            this.customLabelDescMain11.Name = "customLabelDescMain11";
            this.customLabelDescMain11.Size = new System.Drawing.Size(327, 16);
            this.customLabelDescMain11.TabIndex = 2;
            this.customLabelDescMain11.Text = "Centralized control and insights for efficient operations.";
            // 
            // customLabelDescMain10
            // 
            this.customLabelDescMain10.AutoSize = true;
            this.customLabelDescMain10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabelDescMain10.ForeColor = System.Drawing.Color.White;
            this.customLabelDescMain10.Location = new System.Drawing.Point(86, 14);
            this.customLabelDescMain10.Name = "customLabelDescMain10";
            this.customLabelDescMain10.Size = new System.Drawing.Size(128, 16);
            this.customLabelDescMain10.TabIndex = 1;
            this.customLabelDescMain10.Text = "Management Hub";
            // 
            // tsbMainAddItem
            // 
            this.tsbMainAddItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbMainAddItem.Image")));
            this.tsbMainAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMainAddItem.Name = "tsbMainAddItem";
            this.tsbMainAddItem.Size = new System.Drawing.Size(76, 38);
            this.tsbMainAddItem.Text = "Add Item";
            // 
            // tsbMainEditItem
            // 
            this.tsbMainEditItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbMainEditItem.Image")));
            this.tsbMainEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMainEditItem.Name = "tsbMainEditItem";
            this.tsbMainEditItem.Size = new System.Drawing.Size(74, 38);
            this.tsbMainEditItem.Text = "Edit Item";
            // 
            // tsbMainDeleteItem
            // 
            this.tsbMainDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbMainDeleteItem.Image")));
            this.tsbMainDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMainDeleteItem.Name = "tsbMainDeleteItem";
            this.tsbMainDeleteItem.Size = new System.Drawing.Size(87, 38);
            this.tsbMainDeleteItem.Text = "Delete Item";
            // 
            // tsbMainViewItem
            // 
            this.tsbMainViewItem.Image = ((System.Drawing.Image)(resources.GetObject("tsbMainViewItem.Image")));
            this.tsbMainViewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMainViewItem.Name = "tsbMainViewItem";
            this.tsbMainViewItem.Size = new System.Drawing.Size(79, 38);
            this.tsbMainViewItem.Text = "View Item";
            // 
            // tsbMainRefresh
            // 
            this.tsbMainRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbMainRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbMainRefresh.Image")));
            this.tsbMainRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMainRefresh.Name = "tsbMainRefresh";
            this.tsbMainRefresh.Size = new System.Drawing.Size(71, 38);
            this.tsbMainRefresh.Text = "Resfresh";
            // 
            // pictureBoxMain1
            // 
            this.pictureBoxMain1.BackgroundImage = global::FerPROJ.Design.Properties.Resources.Hopstarter_Button_Button_Info_64;
            this.pictureBoxMain1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMain1.Location = new System.Drawing.Point(20, 11);
            this.pictureBoxMain1.Name = "pictureBoxMain1";
            this.pictureBoxMain1.Size = new System.Drawing.Size(60, 50);
            this.pictureBoxMain1.TabIndex = 0;
            this.pictureBoxMain1.TabStop = false;
            // 
            // FrmListKrypton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(768, 521);
            this.Controls.Add(this.PanelMain1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListKrypton";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListMain";
            this.basePnl1.ResumeLayout(false);
            this.basePnl1.PerformLayout();
            this.basePnl2.ResumeLayout(false);
            this.PanelMain1.ResumeLayout(false);
            this.PanelMain4.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.panelMain11.ResumeLayout(false);
            this.panelMain11.PerformLayout();
            this.PnlFormList.ResumeLayout(false);
            this.PnlFormList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Label baseLbl1;
        private System.Windows.Forms.Panel basePnl1;
        private System.Windows.Forms.Panel basePnl2;
        protected CButton baseButtonSelect;
        protected CButton baseButtonCancel;
        private System.Windows.Forms.Panel PanelMain1;
        protected System.Windows.Forms.Panel PanelMain4;
        private Controls.CLabelDesc customLabelDescMain11;
        private Controls.CLabelDesc customLabelDescMain10;
        private System.Windows.Forms.PictureBox pictureBoxMain1;
        private Controls.CLabelDesc customLabelDescMain1;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        protected System.Windows.Forms.ToolStripButton tsbMainAddItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton tsbMainEditItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        protected System.Windows.Forms.ToolStripButton tsbMainDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        protected System.Windows.Forms.ToolStripButton tsbMainViewItem;
        protected System.Windows.Forms.ToolStripButton tsbMainRefresh;
        protected CTextBox SearchTextBox;
        private System.Windows.Forms.Label baselabelmain12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DateTimePicker baseDateToDateTimePicker;
        private Controls.CLabelDesc customLabelDescMain3;
        private System.Windows.Forms.DateTimePicker baseDateFromDateTimePicker;
        private Controls.CLabelDesc customLabelDescMain2;
        private System.Windows.Forms.Panel PnlFormList;
        protected System.Windows.Forms.Panel panelMain11;
    }
}