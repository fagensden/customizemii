﻿/* This file is part of CustomizeMii
 * Copyright (C) 2009 Leathl
 * 
 * CustomizeMii is free software: you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * CustomizeMii is distributed in the hope that it will be
 * useful, but WITHOUT ANY WARRANTY; without even the implied warranty
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
 
namespace CustomizeMii
{
    partial class CustomizeMii_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizeMii_Main));
            this.btnCreateWad = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btnBrowseReplace = new System.Windows.Forms.Button();
            this.btnClearReplace = new System.Windows.Forms.Button();
            this.cmbReplace = new System.Windows.Forms.ComboBox();
            this.btnSaveBaseWad = new System.Windows.Forms.Button();
            this.btnPreviewBaseWad = new System.Windows.Forms.Button();
            this.btnLoadBaseWad = new System.Windows.Forms.Button();
            this.lbxBaseWads = new System.Windows.Forms.ListBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.tbSourceWad = new System.Windows.Forms.TextBox();
            this.lbSource = new System.Windows.Forms.Label();
            this.tabTitle = new System.Windows.Forms.TabPage();
            this.tbItalian = new System.Windows.Forms.TextBox();
            this.tbFrench = new System.Windows.Forms.TextBox();
            this.tbJapanese = new System.Windows.Forms.TextBox();
            this.tbDutch = new System.Windows.Forms.TextBox();
            this.tbSpanish = new System.Windows.Forms.TextBox();
            this.tbGerman = new System.Windows.Forms.TextBox();
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.lbDutch = new System.Windows.Forms.Label();
            this.lbItalian = new System.Windows.Forms.Label();
            this.lbSpanish = new System.Windows.Forms.Label();
            this.lbFrench = new System.Windows.Forms.Label();
            this.lbGerman = new System.Windows.Forms.Label();
            this.lbJapanese = new System.Windows.Forms.Label();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.lbSpecificLanguageTitles = new System.Windows.Forms.Label();
            this.tbAllLanguages = new System.Windows.Forms.TextBox();
            this.lbAllLanguages = new System.Windows.Forms.Label();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.cbLz77 = new System.Windows.Forms.CheckBox();
            this.lbOptionsOptional = new System.Windows.Forms.Label();
            this.btnBrowseSound = new System.Windows.Forms.Button();
            this.tbSound = new System.Windows.Forms.TextBox();
            this.cmbNandLoader = new System.Windows.Forms.ComboBox();
            this.btnBrowseDol = new System.Windows.Forms.Button();
            this.tbDol = new System.Windows.Forms.TextBox();
            this.tbTitleID = new System.Windows.Forms.TextBox();
            this.lbNewSound = new System.Windows.Forms.Label();
            this.lbNandLoader = new System.Windows.Forms.Label();
            this.lbNewDol = new System.Windows.Forms.Label();
            this.lbTitleID = new System.Windows.Forms.Label();
            this.tabBanner = new System.Windows.Forms.TabPage();
            this.cbBannerMakeTransparent = new System.Windows.Forms.CheckBox();
            this.cmbFormatBanner = new System.Windows.Forms.ComboBox();
            this.lbFormatBanner = new System.Windows.Forms.Label();
            this.btnPreviewBanner = new System.Windows.Forms.Button();
            this.btnExtractBanner = new System.Windows.Forms.Button();
            this.btnDeleteBanner = new System.Windows.Forms.Button();
            this.btnAddBanner = new System.Windows.Forms.Button();
            this.btnReplaceBanner = new System.Windows.Forms.Button();
            this.lbxBannerTpls = new System.Windows.Forms.ListBox();
            this.tabIcon = new System.Windows.Forms.TabPage();
            this.cbIconMakeTransparent = new System.Windows.Forms.CheckBox();
            this.cmbFormatIcon = new System.Windows.Forms.ComboBox();
            this.lbFormatIcon = new System.Windows.Forms.Label();
            this.btnPreviewIcon = new System.Windows.Forms.Button();
            this.btnExtractIcon = new System.Windows.Forms.Button();
            this.btnAddIcon = new System.Windows.Forms.Button();
            this.btnDeleteIcon = new System.Windows.Forms.Button();
            this.btnReplaceIcon = new System.Windows.Forms.Button();
            this.lbxIconTpls = new System.Windows.Forms.ListBox();
            this.tabBrlyt = new System.Windows.Forms.TabPage();
            this.btnBrlytListTpls = new System.Windows.Forms.Button();
            this.lbBrlytWarning = new System.Windows.Forms.Label();
            this.lbBrlytActions = new System.Windows.Forms.Label();
            this.btnBrlytExtract = new System.Windows.Forms.Button();
            this.btnBrlytReplace = new System.Windows.Forms.Button();
            this.lbBrlytIcon = new System.Windows.Forms.Label();
            this.lbBrlytBanner = new System.Windows.Forms.Label();
            this.lbxBrlytIcon = new System.Windows.Forms.ListBox();
            this.lbxBrlytBanner = new System.Windows.Forms.ListBox();
            this.tabBrlan = new System.Windows.Forms.TabPage();
            this.lbBrlanWarning = new System.Windows.Forms.Label();
            this.lbBrlanActions = new System.Windows.Forms.Label();
            this.btnBrlanExtract = new System.Windows.Forms.Button();
            this.btnBrlanDelete = new System.Windows.Forms.Button();
            this.btnBrlanReplace = new System.Windows.Forms.Button();
            this.lbBrlanIcon = new System.Windows.Forms.Label();
            this.lbBrlanBanner = new System.Windows.Forms.Label();
            this.btnBrlanAdd = new System.Windows.Forms.Button();
            this.lbxBrlanIcon = new System.Windows.Forms.ListBox();
            this.lbxBrlanBanner = new System.Windows.Forms.ListBox();
            this.tabInstructions = new System.Windows.Forms.TabPage();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.tabCredits = new System.Windows.Forms.TabPage();
            this.llbUpdateAvailabe = new System.Windows.Forms.LinkLabel();
            this.llbSite = new System.Windows.Forms.LinkLabel();
            this.lbCreditThanks = new System.Windows.Forms.Label();
            this.lbCreditVersion = new System.Windows.Forms.Label();
            this.lbCreditInfo = new System.Windows.Forms.Label();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabTitle.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.tabBanner.SuspendLayout();
            this.tabIcon.SuspendLayout();
            this.tabBrlyt.SuspendLayout();
            this.tabBrlan.SuspendLayout();
            this.tabInstructions.SuspendLayout();
            this.tabCredits.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateWad
            // 
            this.btnCreateWad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateWad.Location = new System.Drawing.Point(0, 235);
            this.btnCreateWad.Name = "btnCreateWad";
            this.btnCreateWad.Size = new System.Drawing.Size(451, 33);
            this.btnCreateWad.TabIndex = 0;
            this.btnCreateWad.Text = "Create WAD";
            this.btnCreateWad.UseVisualStyleBackColor = true;
            this.btnCreateWad.Click += new System.EventHandler(this.btnCreateWad_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSource);
            this.tabControl.Controls.Add(this.tabTitle);
            this.tabControl.Controls.Add(this.tabOptions);
            this.tabControl.Controls.Add(this.tabBanner);
            this.tabControl.Controls.Add(this.tabIcon);
            this.tabControl.Controls.Add(this.tabBrlyt);
            this.tabControl.Controls.Add(this.tabBrlan);
            this.tabControl.Controls.Add(this.tabInstructions);
            this.tabControl.Controls.Add(this.tabCredits);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(451, 235);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.tbReplace);
            this.tabSource.Controls.Add(this.btnBrowseReplace);
            this.tabSource.Controls.Add(this.btnClearReplace);
            this.tabSource.Controls.Add(this.cmbReplace);
            this.tabSource.Controls.Add(this.btnSaveBaseWad);
            this.tabSource.Controls.Add(this.btnPreviewBaseWad);
            this.tabSource.Controls.Add(this.btnLoadBaseWad);
            this.tabSource.Controls.Add(this.lbxBaseWads);
            this.tabSource.Controls.Add(this.btnBrowseSource);
            this.tabSource.Controls.Add(this.tbSourceWad);
            this.tabSource.Controls.Add(this.lbSource);
            this.tabSource.Location = new System.Drawing.Point(4, 22);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(443, 209);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(100, 173);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.ReadOnly = true;
            this.tbReplace.Size = new System.Drawing.Size(173, 20);
            this.tbReplace.TabIndex = 10;
            this.tbReplace.Tag = "Disabled";
            // 
            // btnBrowseReplace
            // 
            this.btnBrowseReplace.Location = new System.Drawing.Point(279, 172);
            this.btnBrowseReplace.Name = "btnBrowseReplace";
            this.btnBrowseReplace.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseReplace.TabIndex = 9;
            this.btnBrowseReplace.Text = "Browse...";
            this.btnBrowseReplace.UseVisualStyleBackColor = true;
            this.btnBrowseReplace.Click += new System.EventHandler(this.btnBrowseReplace_Click);
            // 
            // btnClearReplace
            // 
            this.btnClearReplace.Location = new System.Drawing.Point(360, 172);
            this.btnClearReplace.Name = "btnClearReplace";
            this.btnClearReplace.Size = new System.Drawing.Size(75, 23);
            this.btnClearReplace.TabIndex = 8;
            this.btnClearReplace.Text = "Clear";
            this.btnClearReplace.UseVisualStyleBackColor = true;
            this.btnClearReplace.Click += new System.EventHandler(this.btnClearReplace_Click);
            // 
            // cmbReplace
            // 
            this.cmbReplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplace.FormattingEnabled = true;
            this.cmbReplace.Items.AddRange(new object[] {
            "Banner",
            "Icon",
            "Sound"});
            this.cmbReplace.Location = new System.Drawing.Point(11, 172);
            this.cmbReplace.Name = "cmbReplace";
            this.cmbReplace.Size = new System.Drawing.Size(83, 21);
            this.cmbReplace.TabIndex = 7;
            this.cmbReplace.SelectedIndexChanged += new System.EventHandler(this.cmbReplace_SelectedIndexChanged);
            // 
            // btnSaveBaseWad
            // 
            this.btnSaveBaseWad.Location = new System.Drawing.Point(360, 127);
            this.btnSaveBaseWad.Name = "btnSaveBaseWad";
            this.btnSaveBaseWad.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBaseWad.TabIndex = 6;
            this.btnSaveBaseWad.Text = "Save";
            this.btnSaveBaseWad.UseVisualStyleBackColor = true;
            this.btnSaveBaseWad.Click += new System.EventHandler(this.btnSaveBaseWad_Click);
            // 
            // btnPreviewBaseWad
            // 
            this.btnPreviewBaseWad.Location = new System.Drawing.Point(360, 93);
            this.btnPreviewBaseWad.Name = "btnPreviewBaseWad";
            this.btnPreviewBaseWad.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewBaseWad.TabIndex = 5;
            this.btnPreviewBaseWad.Text = "Preview";
            this.btnPreviewBaseWad.UseVisualStyleBackColor = true;
            this.btnPreviewBaseWad.Click += new System.EventHandler(this.btnPreviewBaseWad_Click);
            // 
            // btnLoadBaseWad
            // 
            this.btnLoadBaseWad.Location = new System.Drawing.Point(360, 59);
            this.btnLoadBaseWad.Name = "btnLoadBaseWad";
            this.btnLoadBaseWad.Size = new System.Drawing.Size(75, 23);
            this.btnLoadBaseWad.TabIndex = 4;
            this.btnLoadBaseWad.Text = "Load";
            this.btnLoadBaseWad.UseVisualStyleBackColor = true;
            this.btnLoadBaseWad.Click += new System.EventHandler(this.btnLoadBaseWad_Click);
            // 
            // lbxBaseWads
            // 
            this.lbxBaseWads.FormattingEnabled = true;
            this.lbxBaseWads.Items.AddRange(new object[] {
            "Static Base",
            "Genesis Plus GX",
            "MPlayer CE (No Wii)",
            "MPlayer CE (With Wii)",
            "Snes9xGX",
            "FCE Ultra (Wilsoff)",
            "FCE Ultra (Leathl)",
            "Wii64",
            "WiiSX Full",
            "WiiSX Retro",
            "WADder Base 1",
            "WADder Base 2",
            "WADder Base 3",
            "UniiLoader",
            "Backup Channel"});
            this.lbxBaseWads.Location = new System.Drawing.Point(11, 51);
            this.lbxBaseWads.Name = "lbxBaseWads";
            this.lbxBaseWads.Size = new System.Drawing.Size(343, 108);
            this.lbxBaseWads.TabIndex = 3;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(360, 12);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse...";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // tbSourceWad
            // 
            this.tbSourceWad.Location = new System.Drawing.Point(84, 15);
            this.tbSourceWad.Name = "tbSourceWad";
            this.tbSourceWad.ReadOnly = true;
            this.tbSourceWad.Size = new System.Drawing.Size(270, 20);
            this.tbSourceWad.TabIndex = 1;
            this.tbSourceWad.Tag = "Disabled";
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Location = new System.Drawing.Point(8, 18);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(70, 13);
            this.lbSource.TabIndex = 0;
            this.lbSource.Text = "Source Wad:";
            // 
            // tabTitle
            // 
            this.tabTitle.Controls.Add(this.tbItalian);
            this.tabTitle.Controls.Add(this.tbFrench);
            this.tabTitle.Controls.Add(this.tbJapanese);
            this.tabTitle.Controls.Add(this.tbDutch);
            this.tabTitle.Controls.Add(this.tbSpanish);
            this.tabTitle.Controls.Add(this.tbGerman);
            this.tabTitle.Controls.Add(this.tbEnglish);
            this.tabTitle.Controls.Add(this.lbDutch);
            this.tabTitle.Controls.Add(this.lbItalian);
            this.tabTitle.Controls.Add(this.lbSpanish);
            this.tabTitle.Controls.Add(this.lbFrench);
            this.tabTitle.Controls.Add(this.lbGerman);
            this.tabTitle.Controls.Add(this.lbJapanese);
            this.tabTitle.Controls.Add(this.lbEnglish);
            this.tabTitle.Controls.Add(this.lbSpecificLanguageTitles);
            this.tabTitle.Controls.Add(this.tbAllLanguages);
            this.tabTitle.Controls.Add(this.lbAllLanguages);
            this.tabTitle.Location = new System.Drawing.Point(4, 22);
            this.tabTitle.Name = "tabTitle";
            this.tabTitle.Padding = new System.Windows.Forms.Padding(3);
            this.tabTitle.Size = new System.Drawing.Size(443, 209);
            this.tabTitle.TabIndex = 1;
            this.tabTitle.Text = "Title";
            this.tabTitle.UseVisualStyleBackColor = true;
            // 
            // tbItalian
            // 
            this.tbItalian.Location = new System.Drawing.Point(301, 143);
            this.tbItalian.MaxLength = 20;
            this.tbItalian.Name = "tbItalian";
            this.tbItalian.Size = new System.Drawing.Size(124, 20);
            this.tbItalian.TabIndex = 16;
            // 
            // tbFrench
            // 
            this.tbFrench.Location = new System.Drawing.Point(301, 115);
            this.tbFrench.MaxLength = 20;
            this.tbFrench.Name = "tbFrench";
            this.tbFrench.Size = new System.Drawing.Size(124, 20);
            this.tbFrench.TabIndex = 15;
            // 
            // tbJapanese
            // 
            this.tbJapanese.Location = new System.Drawing.Point(301, 87);
            this.tbJapanese.MaxLength = 20;
            this.tbJapanese.Name = "tbJapanese";
            this.tbJapanese.Size = new System.Drawing.Size(124, 20);
            this.tbJapanese.TabIndex = 14;
            // 
            // tbDutch
            // 
            this.tbDutch.Location = new System.Drawing.Point(70, 171);
            this.tbDutch.MaxLength = 20;
            this.tbDutch.Name = "tbDutch";
            this.tbDutch.Size = new System.Drawing.Size(124, 20);
            this.tbDutch.TabIndex = 13;
            // 
            // tbSpanish
            // 
            this.tbSpanish.Location = new System.Drawing.Point(70, 143);
            this.tbSpanish.MaxLength = 20;
            this.tbSpanish.Name = "tbSpanish";
            this.tbSpanish.Size = new System.Drawing.Size(124, 20);
            this.tbSpanish.TabIndex = 12;
            // 
            // tbGerman
            // 
            this.tbGerman.Location = new System.Drawing.Point(70, 115);
            this.tbGerman.MaxLength = 20;
            this.tbGerman.Name = "tbGerman";
            this.tbGerman.Size = new System.Drawing.Size(124, 20);
            this.tbGerman.TabIndex = 11;
            // 
            // tbEnglish
            // 
            this.tbEnglish.Location = new System.Drawing.Point(70, 87);
            this.tbEnglish.MaxLength = 20;
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(124, 20);
            this.tbEnglish.TabIndex = 10;
            // 
            // lbDutch
            // 
            this.lbDutch.AutoSize = true;
            this.lbDutch.Location = new System.Drawing.Point(8, 174);
            this.lbDutch.Name = "lbDutch";
            this.lbDutch.Size = new System.Drawing.Size(39, 13);
            this.lbDutch.TabIndex = 9;
            this.lbDutch.Text = "Dutch:";
            // 
            // lbItalian
            // 
            this.lbItalian.AutoSize = true;
            this.lbItalian.Location = new System.Drawing.Point(221, 146);
            this.lbItalian.Name = "lbItalian";
            this.lbItalian.Size = new System.Drawing.Size(38, 13);
            this.lbItalian.TabIndex = 8;
            this.lbItalian.Text = "Italian:";
            // 
            // lbSpanish
            // 
            this.lbSpanish.AutoSize = true;
            this.lbSpanish.Location = new System.Drawing.Point(8, 146);
            this.lbSpanish.Name = "lbSpanish";
            this.lbSpanish.Size = new System.Drawing.Size(48, 13);
            this.lbSpanish.TabIndex = 7;
            this.lbSpanish.Text = "Spanish:";
            // 
            // lbFrench
            // 
            this.lbFrench.AutoSize = true;
            this.lbFrench.Location = new System.Drawing.Point(221, 118);
            this.lbFrench.Name = "lbFrench";
            this.lbFrench.Size = new System.Drawing.Size(43, 13);
            this.lbFrench.TabIndex = 6;
            this.lbFrench.Text = "French:";
            // 
            // lbGerman
            // 
            this.lbGerman.AutoSize = true;
            this.lbGerman.Location = new System.Drawing.Point(8, 118);
            this.lbGerman.Name = "lbGerman";
            this.lbGerman.Size = new System.Drawing.Size(47, 13);
            this.lbGerman.TabIndex = 5;
            this.lbGerman.Text = "German:";
            // 
            // lbJapanese
            // 
            this.lbJapanese.AutoSize = true;
            this.lbJapanese.Location = new System.Drawing.Point(221, 90);
            this.lbJapanese.Name = "lbJapanese";
            this.lbJapanese.Size = new System.Drawing.Size(56, 13);
            this.lbJapanese.TabIndex = 4;
            this.lbJapanese.Text = "Japanese:";
            // 
            // lbEnglish
            // 
            this.lbEnglish.AutoSize = true;
            this.lbEnglish.Location = new System.Drawing.Point(8, 90);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(44, 13);
            this.lbEnglish.TabIndex = 3;
            this.lbEnglish.Text = "English:";
            // 
            // lbSpecificLanguageTitles
            // 
            this.lbSpecificLanguageTitles.AutoSize = true;
            this.lbSpecificLanguageTitles.Location = new System.Drawing.Point(8, 63);
            this.lbSpecificLanguageTitles.Name = "lbSpecificLanguageTitles";
            this.lbSpecificLanguageTitles.Size = new System.Drawing.Size(175, 13);
            this.lbSpecificLanguageTitles.TabIndex = 2;
            this.lbSpecificLanguageTitles.Text = "Specific Language Titles (Optional):";
            // 
            // tbAllLanguages
            // 
            this.tbAllLanguages.Location = new System.Drawing.Point(114, 19);
            this.tbAllLanguages.MaxLength = 20;
            this.tbAllLanguages.Name = "tbAllLanguages";
            this.tbAllLanguages.Size = new System.Drawing.Size(311, 20);
            this.tbAllLanguages.TabIndex = 1;
            // 
            // lbAllLanguages
            // 
            this.lbAllLanguages.AutoSize = true;
            this.lbAllLanguages.Location = new System.Drawing.Point(8, 22);
            this.lbAllLanguages.Name = "lbAllLanguages";
            this.lbAllLanguages.Size = new System.Drawing.Size(77, 13);
            this.lbAllLanguages.TabIndex = 0;
            this.lbAllLanguages.Text = "All Languages:";
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.cbLz77);
            this.tabOptions.Controls.Add(this.lbOptionsOptional);
            this.tabOptions.Controls.Add(this.btnBrowseSound);
            this.tabOptions.Controls.Add(this.tbSound);
            this.tabOptions.Controls.Add(this.cmbNandLoader);
            this.tabOptions.Controls.Add(this.btnBrowseDol);
            this.tabOptions.Controls.Add(this.tbDol);
            this.tabOptions.Controls.Add(this.tbTitleID);
            this.tabOptions.Controls.Add(this.lbNewSound);
            this.tabOptions.Controls.Add(this.lbNandLoader);
            this.tabOptions.Controls.Add(this.lbNewDol);
            this.tabOptions.Controls.Add(this.lbTitleID);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(443, 209);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // cbLz77
            // 
            this.cbLz77.AutoSize = true;
            this.cbLz77.Location = new System.Drawing.Point(11, 180);
            this.cbLz77.Name = "cbLz77";
            this.cbLz77.Size = new System.Drawing.Size(134, 17);
            this.cbLz77.TabIndex = 11;
            this.cbLz77.Text = "Use Lz77 Compression";
            this.cbLz77.UseVisualStyleBackColor = true;
            // 
            // lbOptionsOptional
            // 
            this.lbOptionsOptional.Location = new System.Drawing.Point(-7, 9);
            this.lbOptionsOptional.Name = "lbOptionsOptional";
            this.lbOptionsOptional.Size = new System.Drawing.Size(457, 34);
            this.lbOptionsOptional.TabIndex = 10;
            this.lbOptionsOptional.Text = "These are optional. Fill them in only if you want to change them.\r\nIf you want a " +
                "looped sound, set the loop points first (e.g. with Wavosaur).";
            this.lbOptionsOptional.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBrowseSound
            // 
            this.btnBrowseSound.Location = new System.Drawing.Point(360, 144);
            this.btnBrowseSound.Name = "btnBrowseSound";
            this.btnBrowseSound.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSound.TabIndex = 9;
            this.btnBrowseSound.Text = "Browse...";
            this.btnBrowseSound.UseVisualStyleBackColor = true;
            this.btnBrowseSound.Click += new System.EventHandler(this.btnBrowseSound_Click);
            // 
            // tbSound
            // 
            this.tbSound.Location = new System.Drawing.Point(90, 147);
            this.tbSound.Name = "tbSound";
            this.tbSound.ReadOnly = true;
            this.tbSound.Size = new System.Drawing.Size(264, 20);
            this.tbSound.TabIndex = 8;
            this.tbSound.Tag = "Disabled";
            // 
            // cmbNandLoader
            // 
            this.cmbNandLoader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNandLoader.FormattingEnabled = true;
            this.cmbNandLoader.Items.AddRange(new object[] {
            "comex",
            "Waninkoko"});
            this.cmbNandLoader.Location = new System.Drawing.Point(143, 111);
            this.cmbNandLoader.Name = "cmbNandLoader";
            this.cmbNandLoader.Size = new System.Drawing.Size(211, 21);
            this.cmbNandLoader.TabIndex = 7;
            // 
            // btnBrowseDol
            // 
            this.btnBrowseDol.Location = new System.Drawing.Point(360, 80);
            this.btnBrowseDol.Name = "btnBrowseDol";
            this.btnBrowseDol.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDol.TabIndex = 6;
            this.btnBrowseDol.Text = "Browse...";
            this.btnBrowseDol.UseVisualStyleBackColor = true;
            this.btnBrowseDol.Click += new System.EventHandler(this.btnBrowseDol_Click);
            // 
            // tbDol
            // 
            this.tbDol.Location = new System.Drawing.Point(90, 83);
            this.tbDol.Name = "tbDol";
            this.tbDol.ReadOnly = true;
            this.tbDol.Size = new System.Drawing.Size(264, 20);
            this.tbDol.TabIndex = 5;
            this.tbDol.Tag = "Disabled";
            // 
            // tbTitleID
            // 
            this.tbTitleID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTitleID.Location = new System.Drawing.Point(90, 49);
            this.tbTitleID.MaxLength = 4;
            this.tbTitleID.Name = "tbTitleID";
            this.tbTitleID.Size = new System.Drawing.Size(55, 20);
            this.tbTitleID.TabIndex = 4;
            // 
            // lbNewSound
            // 
            this.lbNewSound.AutoSize = true;
            this.lbNewSound.Location = new System.Drawing.Point(8, 150);
            this.lbNewSound.Name = "lbNewSound";
            this.lbNewSound.Size = new System.Drawing.Size(66, 13);
            this.lbNewSound.TabIndex = 3;
            this.lbNewSound.Text = "New Sound:";
            // 
            // lbNandLoader
            // 
            this.lbNandLoader.AutoSize = true;
            this.lbNandLoader.Location = new System.Drawing.Point(49, 114);
            this.lbNandLoader.Name = "lbNandLoader";
            this.lbNandLoader.Size = new System.Drawing.Size(77, 13);
            this.lbNandLoader.TabIndex = 2;
            this.lbNandLoader.Text = "NAND Loader:";
            // 
            // lbNewDol
            // 
            this.lbNewDol.AutoSize = true;
            this.lbNewDol.Location = new System.Drawing.Point(8, 86);
            this.lbNewDol.Name = "lbNewDol";
            this.lbNewDol.Size = new System.Drawing.Size(57, 13);
            this.lbNewDol.TabIndex = 1;
            this.lbNewDol.Text = "New DOL:";
            // 
            // lbTitleID
            // 
            this.lbTitleID.AutoSize = true;
            this.lbTitleID.Location = new System.Drawing.Point(8, 52);
            this.lbTitleID.Name = "lbTitleID";
            this.lbTitleID.Size = new System.Drawing.Size(44, 13);
            this.lbTitleID.TabIndex = 0;
            this.lbTitleID.Text = "Title ID:";
            // 
            // tabBanner
            // 
            this.tabBanner.Controls.Add(this.cbBannerMakeTransparent);
            this.tabBanner.Controls.Add(this.cmbFormatBanner);
            this.tabBanner.Controls.Add(this.lbFormatBanner);
            this.tabBanner.Controls.Add(this.btnPreviewBanner);
            this.tabBanner.Controls.Add(this.btnExtractBanner);
            this.tabBanner.Controls.Add(this.btnDeleteBanner);
            this.tabBanner.Controls.Add(this.btnAddBanner);
            this.tabBanner.Controls.Add(this.btnReplaceBanner);
            this.tabBanner.Controls.Add(this.lbxBannerTpls);
            this.tabBanner.Location = new System.Drawing.Point(4, 22);
            this.tabBanner.Name = "tabBanner";
            this.tabBanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabBanner.Size = new System.Drawing.Size(443, 209);
            this.tabBanner.TabIndex = 3;
            this.tabBanner.Text = "Banner";
            this.tabBanner.UseVisualStyleBackColor = true;
            // 
            // cbBannerMakeTransparent
            // 
            this.cbBannerMakeTransparent.AutoSize = true;
            this.cbBannerMakeTransparent.Location = new System.Drawing.Point(11, 189);
            this.cbBannerMakeTransparent.Name = "cbBannerMakeTransparent";
            this.cbBannerMakeTransparent.Size = new System.Drawing.Size(113, 17);
            this.cbBannerMakeTransparent.TabIndex = 6;
            this.cbBannerMakeTransparent.Text = "Make Transparent";
            this.cbBannerMakeTransparent.UseVisualStyleBackColor = true;
            this.cbBannerMakeTransparent.CheckedChanged += new System.EventHandler(this.cbBannerMakeTransparent_CheckedChanged);
            // 
            // cmbFormatBanner
            // 
            this.cmbFormatBanner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatBanner.FormattingEnabled = true;
            this.cmbFormatBanner.Items.AddRange(new object[] {
            "RGBA8",
            "RGB565",
            "RGB5A3",
            "IA8",
            "IA4",
            "I8",
            "I4",
            "CMP"});
            this.cmbFormatBanner.Location = new System.Drawing.Point(360, 182);
            this.cmbFormatBanner.Name = "cmbFormatBanner";
            this.cmbFormatBanner.Size = new System.Drawing.Size(75, 21);
            this.cmbFormatBanner.TabIndex = 5;
            // 
            // lbFormatBanner
            // 
            this.lbFormatBanner.AutoSize = true;
            this.lbFormatBanner.Location = new System.Drawing.Point(360, 166);
            this.lbFormatBanner.Name = "lbFormatBanner";
            this.lbFormatBanner.Size = new System.Drawing.Size(42, 13);
            this.lbFormatBanner.TabIndex = 4;
            this.lbFormatBanner.Text = "Format:";
            // 
            // btnPreviewBanner
            // 
            this.btnPreviewBanner.Location = new System.Drawing.Point(360, 132);
            this.btnPreviewBanner.Name = "btnPreviewBanner";
            this.btnPreviewBanner.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewBanner.TabIndex = 3;
            this.btnPreviewBanner.Text = "Preview";
            this.btnPreviewBanner.UseVisualStyleBackColor = true;
            this.btnPreviewBanner.Click += new System.EventHandler(this.btnPreviewBanner_Click);
            // 
            // btnExtractBanner
            // 
            this.btnExtractBanner.Location = new System.Drawing.Point(360, 102);
            this.btnExtractBanner.Name = "btnExtractBanner";
            this.btnExtractBanner.Size = new System.Drawing.Size(75, 23);
            this.btnExtractBanner.TabIndex = 2;
            this.btnExtractBanner.Text = "Extract";
            this.btnExtractBanner.UseVisualStyleBackColor = true;
            this.btnExtractBanner.Click += new System.EventHandler(this.btnExtractBanner_Click);
            // 
            // btnDeleteBanner
            // 
            this.btnDeleteBanner.Location = new System.Drawing.Point(360, 42);
            this.btnDeleteBanner.Name = "btnDeleteBanner";
            this.btnDeleteBanner.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBanner.TabIndex = 1;
            this.btnDeleteBanner.Text = "Delete";
            this.btnDeleteBanner.UseVisualStyleBackColor = true;
            this.btnDeleteBanner.Click += new System.EventHandler(this.btnDeleteBanner_Click);
            // 
            // btnAddBanner
            // 
            this.btnAddBanner.Location = new System.Drawing.Point(360, 12);
            this.btnAddBanner.Name = "btnAddBanner";
            this.btnAddBanner.Size = new System.Drawing.Size(75, 23);
            this.btnAddBanner.TabIndex = 1;
            this.btnAddBanner.Text = "Add";
            this.btnAddBanner.UseVisualStyleBackColor = true;
            this.btnAddBanner.Click += new System.EventHandler(this.btnAddBanner_Click);
            // 
            // btnReplaceBanner
            // 
            this.btnReplaceBanner.Location = new System.Drawing.Point(360, 72);
            this.btnReplaceBanner.Name = "btnReplaceBanner";
            this.btnReplaceBanner.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceBanner.TabIndex = 1;
            this.btnReplaceBanner.Text = "Replace";
            this.btnReplaceBanner.UseVisualStyleBackColor = true;
            this.btnReplaceBanner.Click += new System.EventHandler(this.btnReplaceBanner_Click);
            // 
            // lbxBannerTpls
            // 
            this.lbxBannerTpls.FormattingEnabled = true;
            this.lbxBannerTpls.Location = new System.Drawing.Point(11, 12);
            this.lbxBannerTpls.Name = "lbxBannerTpls";
            this.lbxBannerTpls.Size = new System.Drawing.Size(343, 173);
            this.lbxBannerTpls.Sorted = true;
            this.lbxBannerTpls.TabIndex = 0;
            this.lbxBannerTpls.SelectedIndexChanged += new System.EventHandler(this.lbxBannerTpls_SelectedIndexChanged);
            // 
            // tabIcon
            // 
            this.tabIcon.Controls.Add(this.cbIconMakeTransparent);
            this.tabIcon.Controls.Add(this.cmbFormatIcon);
            this.tabIcon.Controls.Add(this.lbFormatIcon);
            this.tabIcon.Controls.Add(this.btnPreviewIcon);
            this.tabIcon.Controls.Add(this.btnExtractIcon);
            this.tabIcon.Controls.Add(this.btnAddIcon);
            this.tabIcon.Controls.Add(this.btnDeleteIcon);
            this.tabIcon.Controls.Add(this.btnReplaceIcon);
            this.tabIcon.Controls.Add(this.lbxIconTpls);
            this.tabIcon.Location = new System.Drawing.Point(4, 22);
            this.tabIcon.Name = "tabIcon";
            this.tabIcon.Padding = new System.Windows.Forms.Padding(3);
            this.tabIcon.Size = new System.Drawing.Size(443, 209);
            this.tabIcon.TabIndex = 4;
            this.tabIcon.Text = "Icon";
            this.tabIcon.UseVisualStyleBackColor = true;
            // 
            // cbIconMakeTransparent
            // 
            this.cbIconMakeTransparent.AutoSize = true;
            this.cbIconMakeTransparent.Location = new System.Drawing.Point(11, 189);
            this.cbIconMakeTransparent.Name = "cbIconMakeTransparent";
            this.cbIconMakeTransparent.Size = new System.Drawing.Size(113, 17);
            this.cbIconMakeTransparent.TabIndex = 12;
            this.cbIconMakeTransparent.Text = "Make Transparent";
            this.cbIconMakeTransparent.UseVisualStyleBackColor = true;
            this.cbIconMakeTransparent.CheckedChanged += new System.EventHandler(this.cbIconMakeTransparent_CheckedChanged);
            // 
            // cmbFormatIcon
            // 
            this.cmbFormatIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormatIcon.FormattingEnabled = true;
            this.cmbFormatIcon.Items.AddRange(new object[] {
            "RGBA8",
            "RGB565",
            "RGB5A3",
            "IA8",
            "IA4",
            "I8",
            "I4",
            "CMP"});
            this.cmbFormatIcon.Location = new System.Drawing.Point(360, 182);
            this.cmbFormatIcon.Name = "cmbFormatIcon";
            this.cmbFormatIcon.Size = new System.Drawing.Size(75, 21);
            this.cmbFormatIcon.TabIndex = 11;
            // 
            // lbFormatIcon
            // 
            this.lbFormatIcon.AutoSize = true;
            this.lbFormatIcon.Location = new System.Drawing.Point(360, 166);
            this.lbFormatIcon.Name = "lbFormatIcon";
            this.lbFormatIcon.Size = new System.Drawing.Size(42, 13);
            this.lbFormatIcon.TabIndex = 10;
            this.lbFormatIcon.Text = "Format:";
            // 
            // btnPreviewIcon
            // 
            this.btnPreviewIcon.Location = new System.Drawing.Point(360, 132);
            this.btnPreviewIcon.Name = "btnPreviewIcon";
            this.btnPreviewIcon.Size = new System.Drawing.Size(75, 23);
            this.btnPreviewIcon.TabIndex = 9;
            this.btnPreviewIcon.Text = "Preview";
            this.btnPreviewIcon.UseVisualStyleBackColor = true;
            this.btnPreviewIcon.Click += new System.EventHandler(this.btnPreviewIcon_Click);
            // 
            // btnExtractIcon
            // 
            this.btnExtractIcon.Location = new System.Drawing.Point(360, 102);
            this.btnExtractIcon.Name = "btnExtractIcon";
            this.btnExtractIcon.Size = new System.Drawing.Size(75, 23);
            this.btnExtractIcon.TabIndex = 8;
            this.btnExtractIcon.Text = "Extract";
            this.btnExtractIcon.UseVisualStyleBackColor = true;
            this.btnExtractIcon.Click += new System.EventHandler(this.btnExtractIcon_Click);
            // 
            // btnAddIcon
            // 
            this.btnAddIcon.Location = new System.Drawing.Point(360, 12);
            this.btnAddIcon.Name = "btnAddIcon";
            this.btnAddIcon.Size = new System.Drawing.Size(75, 23);
            this.btnAddIcon.TabIndex = 7;
            this.btnAddIcon.Text = "Add";
            this.btnAddIcon.UseVisualStyleBackColor = true;
            this.btnAddIcon.Click += new System.EventHandler(this.btnAddIcon_Click);
            // 
            // btnDeleteIcon
            // 
            this.btnDeleteIcon.Location = new System.Drawing.Point(360, 42);
            this.btnDeleteIcon.Name = "btnDeleteIcon";
            this.btnDeleteIcon.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIcon.TabIndex = 7;
            this.btnDeleteIcon.Text = "Delete";
            this.btnDeleteIcon.UseVisualStyleBackColor = true;
            this.btnDeleteIcon.Click += new System.EventHandler(this.btnDeleteIcon_Click);
            // 
            // btnReplaceIcon
            // 
            this.btnReplaceIcon.Location = new System.Drawing.Point(360, 72);
            this.btnReplaceIcon.Name = "btnReplaceIcon";
            this.btnReplaceIcon.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceIcon.TabIndex = 7;
            this.btnReplaceIcon.Text = "Replace";
            this.btnReplaceIcon.UseVisualStyleBackColor = true;
            this.btnReplaceIcon.Click += new System.EventHandler(this.btnReplaceIcon_Click);
            // 
            // lbxIconTpls
            // 
            this.lbxIconTpls.FormattingEnabled = true;
            this.lbxIconTpls.Location = new System.Drawing.Point(11, 12);
            this.lbxIconTpls.Name = "lbxIconTpls";
            this.lbxIconTpls.Size = new System.Drawing.Size(343, 173);
            this.lbxIconTpls.Sorted = true;
            this.lbxIconTpls.TabIndex = 6;
            this.lbxIconTpls.SelectedIndexChanged += new System.EventHandler(this.lbxIconTpls_SelectedIndexChanged);
            // 
            // tabBrlyt
            // 
            this.tabBrlyt.Controls.Add(this.btnBrlytListTpls);
            this.tabBrlyt.Controls.Add(this.lbBrlytWarning);
            this.tabBrlyt.Controls.Add(this.lbBrlytActions);
            this.tabBrlyt.Controls.Add(this.btnBrlytExtract);
            this.tabBrlyt.Controls.Add(this.btnBrlytReplace);
            this.tabBrlyt.Controls.Add(this.lbBrlytIcon);
            this.tabBrlyt.Controls.Add(this.lbBrlytBanner);
            this.tabBrlyt.Controls.Add(this.lbxBrlytIcon);
            this.tabBrlyt.Controls.Add(this.lbxBrlytBanner);
            this.tabBrlyt.Location = new System.Drawing.Point(4, 22);
            this.tabBrlyt.Name = "tabBrlyt";
            this.tabBrlyt.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrlyt.Size = new System.Drawing.Size(443, 209);
            this.tabBrlyt.TabIndex = 6;
            this.tabBrlyt.Text = "brlyt";
            this.tabBrlyt.UseVisualStyleBackColor = true;
            // 
            // btnBrlytListTpls
            // 
            this.btnBrlytListTpls.Location = new System.Drawing.Point(360, 131);
            this.btnBrlytListTpls.Name = "btnBrlytListTpls";
            this.btnBrlytListTpls.Size = new System.Drawing.Size(75, 23);
            this.btnBrlytListTpls.TabIndex = 8;
            this.btnBrlytListTpls.Text = "List TPLs";
            this.btnBrlytListTpls.UseVisualStyleBackColor = true;
            this.btnBrlytListTpls.Click += new System.EventHandler(this.btnBrlytListTpls_Click);
            // 
            // lbBrlytWarning
            // 
            this.lbBrlytWarning.ForeColor = System.Drawing.Color.Red;
            this.lbBrlytWarning.Location = new System.Drawing.Point(-4, 192);
            this.lbBrlytWarning.Name = "lbBrlytWarning";
            this.lbBrlytWarning.Size = new System.Drawing.Size(451, 23);
            this.lbBrlytWarning.TabIndex = 7;
            this.lbBrlytWarning.Text = "Be careful with these features, wrong handling WILL BRICK your Wii!";
            this.lbBrlytWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbBrlytActions
            // 
            this.lbBrlytActions.Location = new System.Drawing.Point(357, 42);
            this.lbBrlytActions.Name = "lbBrlytActions";
            this.lbBrlytActions.Size = new System.Drawing.Size(78, 11);
            this.lbBrlytActions.TabIndex = 6;
            this.lbBrlytActions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBrlytExtract
            // 
            this.btnBrlytExtract.Location = new System.Drawing.Point(360, 98);
            this.btnBrlytExtract.Name = "btnBrlytExtract";
            this.btnBrlytExtract.Size = new System.Drawing.Size(75, 23);
            this.btnBrlytExtract.TabIndex = 5;
            this.btnBrlytExtract.Text = "Extract";
            this.btnBrlytExtract.UseVisualStyleBackColor = true;
            this.btnBrlytExtract.Click += new System.EventHandler(this.btnBrlytExtract_Click);
            // 
            // btnBrlytReplace
            // 
            this.btnBrlytReplace.Location = new System.Drawing.Point(360, 65);
            this.btnBrlytReplace.Name = "btnBrlytReplace";
            this.btnBrlytReplace.Size = new System.Drawing.Size(75, 23);
            this.btnBrlytReplace.TabIndex = 5;
            this.btnBrlytReplace.Text = "Replace";
            this.btnBrlytReplace.UseVisualStyleBackColor = true;
            this.btnBrlytReplace.Click += new System.EventHandler(this.btnBrlytReplace_Click);
            // 
            // lbBrlytIcon
            // 
            this.lbBrlytIcon.AutoSize = true;
            this.lbBrlytIcon.Location = new System.Drawing.Point(11, 102);
            this.lbBrlytIcon.Name = "lbBrlytIcon";
            this.lbBrlytIcon.Size = new System.Drawing.Size(31, 13);
            this.lbBrlytIcon.TabIndex = 4;
            this.lbBrlytIcon.Text = "Icon:";
            // 
            // lbBrlytBanner
            // 
            this.lbBrlytBanner.AutoSize = true;
            this.lbBrlytBanner.Location = new System.Drawing.Point(11, 11);
            this.lbBrlytBanner.Name = "lbBrlytBanner";
            this.lbBrlytBanner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBrlytBanner.Size = new System.Drawing.Size(44, 13);
            this.lbBrlytBanner.TabIndex = 3;
            this.lbBrlytBanner.Text = "Banner:";
            // 
            // lbxBrlytIcon
            // 
            this.lbxBrlytIcon.FormattingEnabled = true;
            this.lbxBrlytIcon.Location = new System.Drawing.Point(11, 120);
            this.lbxBrlytIcon.Name = "lbxBrlytIcon";
            this.lbxBrlytIcon.Size = new System.Drawing.Size(343, 69);
            this.lbxBrlytIcon.Sorted = true;
            this.lbxBrlytIcon.TabIndex = 1;
            this.lbxBrlytIcon.SelectedIndexChanged += new System.EventHandler(this.lbxBrlytIcon_SelectedIndexChanged);
            // 
            // lbxBrlytBanner
            // 
            this.lbxBrlytBanner.FormattingEnabled = true;
            this.lbxBrlytBanner.Location = new System.Drawing.Point(11, 29);
            this.lbxBrlytBanner.Name = "lbxBrlytBanner";
            this.lbxBrlytBanner.Size = new System.Drawing.Size(343, 69);
            this.lbxBrlytBanner.Sorted = true;
            this.lbxBrlytBanner.TabIndex = 0;
            this.lbxBrlytBanner.SelectedIndexChanged += new System.EventHandler(this.lbxBrlytBanner_SelectedIndexChanged);
            // 
            // tabBrlan
            // 
            this.tabBrlan.Controls.Add(this.lbBrlanWarning);
            this.tabBrlan.Controls.Add(this.lbBrlanActions);
            this.tabBrlan.Controls.Add(this.btnBrlanExtract);
            this.tabBrlan.Controls.Add(this.btnBrlanDelete);
            this.tabBrlan.Controls.Add(this.btnBrlanReplace);
            this.tabBrlan.Controls.Add(this.lbBrlanIcon);
            this.tabBrlan.Controls.Add(this.lbBrlanBanner);
            this.tabBrlan.Controls.Add(this.btnBrlanAdd);
            this.tabBrlan.Controls.Add(this.lbxBrlanIcon);
            this.tabBrlan.Controls.Add(this.lbxBrlanBanner);
            this.tabBrlan.Location = new System.Drawing.Point(4, 22);
            this.tabBrlan.Name = "tabBrlan";
            this.tabBrlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrlan.Size = new System.Drawing.Size(443, 209);
            this.tabBrlan.TabIndex = 7;
            this.tabBrlan.Text = "brlan";
            this.tabBrlan.UseVisualStyleBackColor = true;
            // 
            // lbBrlanWarning
            // 
            this.lbBrlanWarning.ForeColor = System.Drawing.Color.Red;
            this.lbBrlanWarning.Location = new System.Drawing.Point(-4, 192);
            this.lbBrlanWarning.Name = "lbBrlanWarning";
            this.lbBrlanWarning.Size = new System.Drawing.Size(451, 23);
            this.lbBrlanWarning.TabIndex = 15;
            this.lbBrlanWarning.Text = "Be careful with these features, wrong handling WILL BRICK your Wii!";
            this.lbBrlanWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbBrlanActions
            // 
            this.lbBrlanActions.Location = new System.Drawing.Point(357, 14);
            this.lbBrlanActions.Name = "lbBrlanActions";
            this.lbBrlanActions.Size = new System.Drawing.Size(78, 13);
            this.lbBrlanActions.TabIndex = 14;
            this.lbBrlanActions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBrlanExtract
            // 
            this.btnBrlanExtract.Location = new System.Drawing.Point(360, 153);
            this.btnBrlanExtract.Name = "btnBrlanExtract";
            this.btnBrlanExtract.Size = new System.Drawing.Size(75, 23);
            this.btnBrlanExtract.TabIndex = 11;
            this.btnBrlanExtract.Text = "Extract";
            this.btnBrlanExtract.UseVisualStyleBackColor = true;
            this.btnBrlanExtract.Click += new System.EventHandler(this.btnBrlanExtract_Click);
            // 
            // btnBrlanDelete
            // 
            this.btnBrlanDelete.Location = new System.Drawing.Point(360, 77);
            this.btnBrlanDelete.Name = "btnBrlanDelete";
            this.btnBrlanDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBrlanDelete.TabIndex = 12;
            this.btnBrlanDelete.Text = "Delete";
            this.btnBrlanDelete.UseVisualStyleBackColor = true;
            this.btnBrlanDelete.Click += new System.EventHandler(this.btnBrlanDelete_Click);
            // 
            // btnBrlanReplace
            // 
            this.btnBrlanReplace.Location = new System.Drawing.Point(360, 115);
            this.btnBrlanReplace.Name = "btnBrlanReplace";
            this.btnBrlanReplace.Size = new System.Drawing.Size(75, 23);
            this.btnBrlanReplace.TabIndex = 13;
            this.btnBrlanReplace.Text = "Replace";
            this.btnBrlanReplace.UseVisualStyleBackColor = true;
            this.btnBrlanReplace.Click += new System.EventHandler(this.btnBrlanReplace_Click);
            // 
            // lbBrlanIcon
            // 
            this.lbBrlanIcon.AutoSize = true;
            this.lbBrlanIcon.Location = new System.Drawing.Point(11, 102);
            this.lbBrlanIcon.Name = "lbBrlanIcon";
            this.lbBrlanIcon.Size = new System.Drawing.Size(31, 13);
            this.lbBrlanIcon.TabIndex = 10;
            this.lbBrlanIcon.Text = "Icon:";
            // 
            // lbBrlanBanner
            // 
            this.lbBrlanBanner.AutoSize = true;
            this.lbBrlanBanner.Location = new System.Drawing.Point(11, 11);
            this.lbBrlanBanner.Name = "lbBrlanBanner";
            this.lbBrlanBanner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBrlanBanner.Size = new System.Drawing.Size(44, 13);
            this.lbBrlanBanner.TabIndex = 9;
            this.lbBrlanBanner.Text = "Banner:";
            // 
            // btnBrlanAdd
            // 
            this.btnBrlanAdd.Location = new System.Drawing.Point(360, 39);
            this.btnBrlanAdd.Name = "btnBrlanAdd";
            this.btnBrlanAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBrlanAdd.TabIndex = 8;
            this.btnBrlanAdd.Text = "Add";
            this.btnBrlanAdd.UseVisualStyleBackColor = true;
            this.btnBrlanAdd.Click += new System.EventHandler(this.btnBrlanAdd_Click);
            // 
            // lbxBrlanIcon
            // 
            this.lbxBrlanIcon.FormattingEnabled = true;
            this.lbxBrlanIcon.Location = new System.Drawing.Point(11, 120);
            this.lbxBrlanIcon.Name = "lbxBrlanIcon";
            this.lbxBrlanIcon.Size = new System.Drawing.Size(343, 69);
            this.lbxBrlanIcon.Sorted = true;
            this.lbxBrlanIcon.TabIndex = 7;
            this.lbxBrlanIcon.SelectedIndexChanged += new System.EventHandler(this.lbxBrlanIcon_SelectedIndexChanged);
            // 
            // lbxBrlanBanner
            // 
            this.lbxBrlanBanner.FormattingEnabled = true;
            this.lbxBrlanBanner.Location = new System.Drawing.Point(11, 29);
            this.lbxBrlanBanner.Name = "lbxBrlanBanner";
            this.lbxBrlanBanner.Size = new System.Drawing.Size(343, 69);
            this.lbxBrlanBanner.Sorted = true;
            this.lbxBrlanBanner.TabIndex = 6;
            this.lbxBrlanBanner.SelectedIndexChanged += new System.EventHandler(this.lbxBrlanBanner_SelectedIndexChanged);
            // 
            // tabInstructions
            // 
            this.tabInstructions.Controls.Add(this.rtbInstructions);
            this.tabInstructions.Location = new System.Drawing.Point(4, 22);
            this.tabInstructions.Name = "tabInstructions";
            this.tabInstructions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructions.Size = new System.Drawing.Size(443, 209);
            this.tabInstructions.TabIndex = 8;
            this.tabInstructions.Text = "Instructions";
            this.tabInstructions.UseVisualStyleBackColor = true;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.rtbInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInstructions.Location = new System.Drawing.Point(3, 3);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(437, 203);
            this.rtbInstructions.TabIndex = 0;
            this.rtbInstructions.Text = "";
            // 
            // tabCredits
            // 
            this.tabCredits.Controls.Add(this.llbUpdateAvailabe);
            this.tabCredits.Controls.Add(this.llbSite);
            this.tabCredits.Controls.Add(this.lbCreditThanks);
            this.tabCredits.Controls.Add(this.lbCreditVersion);
            this.tabCredits.Controls.Add(this.lbCreditInfo);
            this.tabCredits.Location = new System.Drawing.Point(4, 22);
            this.tabCredits.Name = "tabCredits";
            this.tabCredits.Padding = new System.Windows.Forms.Padding(3);
            this.tabCredits.Size = new System.Drawing.Size(443, 209);
            this.tabCredits.TabIndex = 5;
            this.tabCredits.Text = "Credits";
            this.tabCredits.UseVisualStyleBackColor = true;
            // 
            // llbUpdateAvailabe
            // 
            this.llbUpdateAvailabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUpdateAvailabe.Location = new System.Drawing.Point(0, 62);
            this.llbUpdateAvailabe.Name = "llbUpdateAvailabe";
            this.llbUpdateAvailabe.Size = new System.Drawing.Size(443, 13);
            this.llbUpdateAvailabe.TabIndex = 4;
            this.llbUpdateAvailabe.TabStop = true;
            this.llbUpdateAvailabe.Text = "Version X is availabe, get it here!";
            this.llbUpdateAvailabe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llbUpdateAvailabe.Visible = false;
            this.llbUpdateAvailabe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdateAvailabe_LinkClicked);
            // 
            // llbSite
            // 
            this.llbSite.Location = new System.Drawing.Point(0, 35);
            this.llbSite.Name = "llbSite";
            this.llbSite.Size = new System.Drawing.Size(443, 13);
            this.llbSite.TabIndex = 3;
            this.llbSite.TabStop = true;
            this.llbSite.Text = "http://customizemii.googlecode.com";
            this.llbSite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llbSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSite_LinkClicked);
            // 
            // lbCreditThanks
            // 
            this.lbCreditThanks.Location = new System.Drawing.Point(0, 91);
            this.lbCreditThanks.Name = "lbCreditThanks";
            this.lbCreditThanks.Size = new System.Drawing.Size(443, 79);
            this.lbCreditThanks.TabIndex = 2;
            this.lbCreditThanks.Text = resources.GetString("lbCreditThanks.Text");
            this.lbCreditThanks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCreditVersion
            // 
            this.lbCreditVersion.Location = new System.Drawing.Point(0, 13);
            this.lbCreditVersion.Name = "lbCreditVersion";
            this.lbCreditVersion.Size = new System.Drawing.Size(443, 13);
            this.lbCreditVersion.TabIndex = 1;
            this.lbCreditVersion.Text = "CustomizeMii Version X by Leathl";
            this.lbCreditVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCreditInfo
            // 
            this.lbCreditInfo.ForeColor = System.Drawing.Color.Red;
            this.lbCreditInfo.Location = new System.Drawing.Point(0, 189);
            this.lbCreditInfo.Name = "lbCreditInfo";
            this.lbCreditInfo.Size = new System.Drawing.Size(443, 16);
            this.lbCreditInfo.TabIndex = 0;
            this.lbCreditInfo.Text = "Thanks to icefire / Xuzz for the basic idea of this Application!";
            this.lbCreditInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.lbStatusText,
            this.pbProgress});
            this.ssMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ssMain.Location = new System.Drawing.Point(0, 268);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(451, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "ssMain";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(45, 17);
            this.lbStatus.Text = "Status: ";
            // 
            // lbStatusText
            // 
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(0, 17);
            this.lbStatusText.Spring = true;
            this.lbStatusText.TextChanged += new System.EventHandler(this.lbStatusText_TextChanged);
            // 
            // pbProgress
            // 
            this.pbProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Value = 100;
            // 
            // CustomizeMii_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 290);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCreateWad);
            this.Controls.Add(this.ssMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomizeMii_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomizeMii X by Leathl";
            this.Load += new System.EventHandler(this.CustomizeMii_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomizeMii_Main_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabTitle.ResumeLayout(false);
            this.tabTitle.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.tabBanner.ResumeLayout(false);
            this.tabBanner.PerformLayout();
            this.tabIcon.ResumeLayout(false);
            this.tabIcon.PerformLayout();
            this.tabBrlyt.ResumeLayout(false);
            this.tabBrlyt.PerformLayout();
            this.tabBrlan.ResumeLayout(false);
            this.tabBrlan.PerformLayout();
            this.tabInstructions.ResumeLayout(false);
            this.tabCredits.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateWad;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabTitle;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TabPage tabBanner;
        private System.Windows.Forms.TabPage tabIcon;
        private System.Windows.Forms.TabPage tabCredits;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.TextBox tbSourceWad;
        private System.Windows.Forms.ListBox lbxBaseWads;
        private System.Windows.Forms.Button btnSaveBaseWad;
        private System.Windows.Forms.Button btnPreviewBaseWad;
        private System.Windows.Forms.Button btnLoadBaseWad;
        private System.Windows.Forms.TextBox tbAllLanguages;
        private System.Windows.Forms.Label lbAllLanguages;
        private System.Windows.Forms.Label lbSpecificLanguageTitles;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.Label lbJapanese;
        private System.Windows.Forms.Label lbDutch;
        private System.Windows.Forms.Label lbItalian;
        private System.Windows.Forms.Label lbSpanish;
        private System.Windows.Forms.Label lbFrench;
        private System.Windows.Forms.Label lbGerman;
        private System.Windows.Forms.TextBox tbItalian;
        private System.Windows.Forms.TextBox tbFrench;
        private System.Windows.Forms.TextBox tbJapanese;
        private System.Windows.Forms.TextBox tbDutch;
        private System.Windows.Forms.TextBox tbSpanish;
        private System.Windows.Forms.TextBox tbGerman;
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.Label lbNewDol;
        private System.Windows.Forms.Label lbTitleID;
        private System.Windows.Forms.Label lbNandLoader;
        private System.Windows.Forms.Label lbNewSound;
        private System.Windows.Forms.Button btnBrowseDol;
        private System.Windows.Forms.TextBox tbDol;
        private System.Windows.Forms.TextBox tbTitleID;
        private System.Windows.Forms.ComboBox cmbNandLoader;
        private System.Windows.Forms.TextBox tbSound;
        private System.Windows.Forms.Button btnBrowseSound;
        private System.Windows.Forms.Label lbOptionsOptional;
        private System.Windows.Forms.Button btnPreviewBanner;
        private System.Windows.Forms.Button btnExtractBanner;
        private System.Windows.Forms.Button btnReplaceBanner;
        private System.Windows.Forms.ListBox lbxBannerTpls;
        private System.Windows.Forms.Label lbFormatBanner;
        private System.Windows.Forms.ComboBox cmbFormatBanner;
        private System.Windows.Forms.ComboBox cmbFormatIcon;
        private System.Windows.Forms.Label lbFormatIcon;
        private System.Windows.Forms.Button btnPreviewIcon;
        private System.Windows.Forms.Button btnExtractIcon;
        private System.Windows.Forms.Button btnReplaceIcon;
        private System.Windows.Forms.ListBox lbxIconTpls;
        private System.Windows.Forms.Label lbCreditInfo;
        private System.Windows.Forms.Label lbCreditVersion;
        private System.Windows.Forms.Label lbCreditThanks;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripProgressBar pbProgress;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.ComboBox cmbReplace;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btnBrowseReplace;
        private System.Windows.Forms.Button btnClearReplace;
        private System.Windows.Forms.CheckBox cbLz77;
        private System.Windows.Forms.LinkLabel llbSite;
        private System.Windows.Forms.TabPage tabBrlyt;
        private System.Windows.Forms.TabPage tabBrlan;
        private System.Windows.Forms.ListBox lbxBrlytIcon;
        private System.Windows.Forms.ListBox lbxBrlytBanner;
        private System.Windows.Forms.Label lbBrlytIcon;
        private System.Windows.Forms.Label lbBrlytBanner;
        private System.Windows.Forms.Button btnBrlytReplace;
        private System.Windows.Forms.Button btnBrlytExtract;
        private System.Windows.Forms.Button btnBrlanExtract;
        private System.Windows.Forms.Button btnBrlanDelete;
        private System.Windows.Forms.Button btnBrlanReplace;
        private System.Windows.Forms.Label lbBrlanIcon;
        private System.Windows.Forms.Label lbBrlanBanner;
        private System.Windows.Forms.Button btnBrlanAdd;
        private System.Windows.Forms.ListBox lbxBrlanIcon;
        private System.Windows.Forms.ListBox lbxBrlanBanner;
        private System.Windows.Forms.Label lbBrlytActions;
        private System.Windows.Forms.Label lbBrlanActions;
        private System.Windows.Forms.Label lbBrlytWarning;
        private System.Windows.Forms.Label lbBrlanWarning;
        private System.Windows.Forms.LinkLabel llbUpdateAvailabe;
        private System.Windows.Forms.Button btnDeleteBanner;
        private System.Windows.Forms.Button btnAddBanner;
        private System.Windows.Forms.Button btnAddIcon;
        private System.Windows.Forms.Button btnDeleteIcon;
        private System.Windows.Forms.Button btnBrlytListTpls;
        private System.Windows.Forms.CheckBox cbBannerMakeTransparent;
        private System.Windows.Forms.CheckBox cbIconMakeTransparent;
        private System.Windows.Forms.TabPage tabInstructions;
        private System.Windows.Forms.RichTextBox rtbInstructions;
    }
}

