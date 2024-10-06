namespace ProjectViewer {
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
      this.PNL_ProjectData = new System.Windows.Forms.Panel();
      this.LBL_ProjectName = new System.Windows.Forms.Label();
      this.PB_ProjectIcon = new System.Windows.Forms.PictureBox();
      this.PNL_ChildForm = new System.Windows.Forms.Panel();
      this.PNL_Buttons = new System.Windows.Forms.Panel();
      this.ts_TopMenu.SuspendLayout();
      this.PNL_SideMenu.SuspendLayout();
      this.PNL_ProjectData.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PB_ProjectIcon)).BeginInit();
      this.SuspendLayout();
      // 
      // ts_TopMenu
      // 
      this.ts_TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddPrj});
      this.ts_TopMenu.Location = new System.Drawing.Point(0, 0);
      this.ts_TopMenu.Name = "ts_TopMenu";
      this.ts_TopMenu.Size = new System.Drawing.Size(716, 25);
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
      this.PNL_SideMenu.Size = new System.Drawing.Size(257, 653);
      this.PNL_SideMenu.TabIndex = 1;
      // 
      // PNL_ProjectData
      // 
      this.PNL_ProjectData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(52)))));
      this.PNL_ProjectData.Controls.Add(this.LBL_ProjectName);
      this.PNL_ProjectData.Controls.Add(this.PB_ProjectIcon);
      this.PNL_ProjectData.Dock = System.Windows.Forms.DockStyle.Top;
      this.PNL_ProjectData.Location = new System.Drawing.Point(0, 0);
      this.PNL_ProjectData.Name = "PNL_ProjectData";
      this.PNL_ProjectData.Size = new System.Drawing.Size(257, 207);
      this.PNL_ProjectData.TabIndex = 1;
      // 
      // LBL_ProjectName
      // 
      this.LBL_ProjectName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
      this.LBL_ProjectName.ForeColor = System.Drawing.Color.White;
      this.LBL_ProjectName.Location = new System.Drawing.Point(7, 151);
      this.LBL_ProjectName.Name = "LBL_ProjectName";
      this.LBL_ProjectName.Size = new System.Drawing.Size(233, 29);
      this.LBL_ProjectName.TabIndex = 1;
      this.LBL_ProjectName.Text = "<PROJECT_NAME>";
      this.LBL_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PB_ProjectIcon
      // 
      this.PB_ProjectIcon.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.PB_ProjectIcon.Location = new System.Drawing.Point(64, 13);
      this.PB_ProjectIcon.Name = "PB_ProjectIcon";
      this.PB_ProjectIcon.Size = new System.Drawing.Size(130, 130);
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
      this.PNL_ChildForm.Location = new System.Drawing.Point(257, 28);
      this.PNL_ChildForm.Name = "PNL_ChildForm";
      this.PNL_ChildForm.Size = new System.Drawing.Size(459, 653);
      this.PNL_ChildForm.TabIndex = 2;
      // 
      // PNL_Buttons
      // 
      this.PNL_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.PNL_Buttons.AutoScroll = true;
      this.PNL_Buttons.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.PNL_Buttons.Location = new System.Drawing.Point(0, 204);
      this.PNL_Buttons.Name = "PNL_Buttons";
      this.PNL_Buttons.Size = new System.Drawing.Size(257, 449);
      this.PNL_Buttons.TabIndex = 2;
      // 
      // FRM_Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(716, 681);
      this.Controls.Add(this.PNL_ChildForm);
      this.Controls.Add(this.PNL_SideMenu);
      this.Controls.Add(this.ts_TopMenu);
      this.Name = "FRM_Home";
      this.Text = "ProjectViewer";
      this.Load += new System.EventHandler(this.FRM_Home_Load);
      this.Shown += new System.EventHandler(this.FRM_Home_Shown);
      this.ts_TopMenu.ResumeLayout(false);
      this.ts_TopMenu.PerformLayout();
      this.PNL_SideMenu.ResumeLayout(false);
      this.PNL_ProjectData.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PB_ProjectIcon)).EndInit();
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
  }
}

