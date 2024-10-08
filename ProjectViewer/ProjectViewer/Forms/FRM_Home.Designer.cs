﻿namespace ProjectViewer {
  partial class FRM_Home {
    /// <summary>
    /// Variabile di progettazione necessaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Pulire le risorse in uso.
    /// </summary>
    /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Codice generato da Progettazione Windows Form

    /// <summary>
    /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
    /// il contenuto del metodo con l'editor di codice.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Home));
      this.ts_TopMenu = new System.Windows.Forms.ToolStrip();
      this.tsb_AddPrj = new System.Windows.Forms.ToolStripButton();
      this.PNL_SideMenu = new System.Windows.Forms.Panel();
      this.PNL_Buttons = new System.Windows.Forms.Panel();
      this.PNL_ProjectData = new System.Windows.Forms.Panel();
      this.LBL_ProjectName = new System.Windows.Forms.Label();
      this.PB_ProjectIcon = new System.Windows.Forms.PictureBox();
      this.PNL_ChildForm = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tv_Folders = new System.Windows.Forms.TreeView();
      this.ts_TopMenu.SuspendLayout();
      this.PNL_SideMenu.SuspendLayout();
      this.PNL_ProjectData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PB_ProjectIcon)).BeginInit();
      this.PNL_ChildForm.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ts_TopMenu
      // 
      this.ts_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddPrj});
      this.ts_TopMenu.Location = new System.Drawing.Point(0, 0);
      this.ts_TopMenu.Name = "ts_TopMenu";
      this.ts_TopMenu.Size = new System.Drawing.Size(787, 25);
      this.ts_TopMenu.TabIndex = 0;
      this.ts_TopMenu.Text = "toolStrip1";
      // 
      // tsb_AddPrj
      // 
      this.tsb_AddPrj.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AddPrj.Image")));
      this.tsb_AddPrj.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_AddPrj.Name = "tsb_AddPrj";
      this.tsb_AddPrj.Size = new System.Drawing.Size(125, 22);
      this.tsb_AddPrj.Text = "Aggiungi progetto";
      this.tsb_AddPrj.Click += new System.EventHandler(this.tsb_AddPrj_Click);
      // 
      // PNL_SideMenu
      // 
      this.PNL_SideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.PNL_SideMenu.AutoScroll = true;
      this.PNL_SideMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.PNL_SideMenu.Controls.Add(this.PNL_Buttons);
      this.PNL_SideMenu.Controls.Add(this.PNL_ProjectData);
      this.PNL_SideMenu.Location = new System.Drawing.Point(0, 28);
      this.PNL_SideMenu.Name = "PNL_SideMenu";
      this.PNL_SideMenu.Size = new System.Drawing.Size(212, 685);
      this.PNL_SideMenu.TabIndex = 1;
      // 
      // PNL_Buttons
      // 
      this.PNL_Buttons.AutoScroll = true;
      this.PNL_Buttons.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.PNL_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
      this.PNL_Buttons.Location = new System.Drawing.Point(0, 174);
      this.PNL_Buttons.Name = "PNL_Buttons";
      this.PNL_Buttons.Size = new System.Drawing.Size(212, 511);
      this.PNL_Buttons.TabIndex = 2;
      // 
      // PNL_ProjectData
      // 
      this.PNL_ProjectData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
      this.PNL_ProjectData.Controls.Add(this.LBL_ProjectName);
      this.PNL_ProjectData.Controls.Add(this.PB_ProjectIcon);
      this.PNL_ProjectData.Dock = System.Windows.Forms.DockStyle.Top;
      this.PNL_ProjectData.Location = new System.Drawing.Point(0, 0);
      this.PNL_ProjectData.Name = "PNL_ProjectData";
      this.PNL_ProjectData.Size = new System.Drawing.Size(212, 174);
      this.PNL_ProjectData.TabIndex = 1;
      // 
      // LBL_ProjectName
      // 
      this.LBL_ProjectName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
      this.LBL_ProjectName.ForeColor = System.Drawing.Color.White;
      this.LBL_ProjectName.Location = new System.Drawing.Point(10, 130);
      this.LBL_ProjectName.Name = "LBL_ProjectName";
      this.LBL_ProjectName.Size = new System.Drawing.Size(196, 29);
      this.LBL_ProjectName.TabIndex = 1;
      this.LBL_ProjectName.Text = "<PROJECT_NAME>";
      this.LBL_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PB_ProjectIcon
      // 
      this.PB_ProjectIcon.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.PB_ProjectIcon.Location = new System.Drawing.Point(59, 14);
      this.PB_ProjectIcon.Name = "PB_ProjectIcon";
      this.PB_ProjectIcon.Size = new System.Drawing.Size(100, 100);
      this.PB_ProjectIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.PB_ProjectIcon.TabIndex = 0;
      this.PB_ProjectIcon.TabStop = false;
      // 
      // PNL_ChildForm
      // 
      this.PNL_ChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PNL_ChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
      this.PNL_ChildForm.Controls.Add(this.tableLayoutPanel1);
      this.PNL_ChildForm.Location = new System.Drawing.Point(212, 28);
      this.PNL_ChildForm.Name = "PNL_ChildForm";
      this.PNL_ChildForm.Size = new System.Drawing.Size(575, 685);
      this.PNL_ChildForm.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.tv_Folders, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 685);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tv_Folders
      // 
      this.tv_Folders.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tv_Folders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tv_Folders.Location = new System.Drawing.Point(3, 3);
      this.tv_Folders.Name = "tv_Folders";
      this.tv_Folders.Size = new System.Drawing.Size(281, 679);
      this.tv_Folders.TabIndex = 0;
      // 
      // FRM_Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(787, 713);
      this.Controls.Add(this.PNL_ChildForm);
      this.Controls.Add(this.PNL_SideMenu);
      this.Controls.Add(this.ts_TopMenu);
      this.DoubleBuffered = true;
      this.Name = "FRM_Home";
      this.Text = "ProjectViewer";
      this.Load += new System.EventHandler(this.FRM_Home_Load);
      this.ts_TopMenu.ResumeLayout(false);
      this.ts_TopMenu.PerformLayout();
      this.PNL_SideMenu.ResumeLayout(false);
      this.PNL_ProjectData.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PB_ProjectIcon)).EndInit();
      this.PNL_ChildForm.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip ts_TopMenu;
    private System.Windows.Forms.ToolStripButton tsb_AddPrj;
    private System.Windows.Forms.Panel PNL_SideMenu;
    private System.Windows.Forms.Panel PNL_ProjectData;
    private System.Windows.Forms.Label LBL_ProjectName;
    private System.Windows.Forms.PictureBox PB_ProjectIcon;
    private System.Windows.Forms.Panel PNL_ChildForm;
    private System.Windows.Forms.Panel PNL_Buttons;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TreeView tv_Folders;
  }
}

