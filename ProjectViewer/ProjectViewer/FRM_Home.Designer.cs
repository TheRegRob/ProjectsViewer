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
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.lv_Projects = new System.Windows.Forms.ListView();
      this.tlp_HomeContainer = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.tv_Folders = new System.Windows.Forms.TreeView();
      this.lbl_Treeview = new System.Windows.Forms.Label();
      this.tsb_AddPrj = new System.Windows.Forms.ToolStripButton();
      this.toolStrip1.SuspendLayout();
      this.tlp_HomeContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_AddPrj});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(395, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // lv_Projects
      // 
      this.lv_Projects.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lv_Projects.HideSelection = false;
      this.lv_Projects.Location = new System.Drawing.Point(4, 35);
      this.lv_Projects.Name = "lv_Projects";
      this.lv_Projects.Size = new System.Drawing.Size(142, 390);
      this.lv_Projects.TabIndex = 1;
      this.lv_Projects.UseCompatibleStateImageBehavior = false;
      // 
      // tlp_HomeContainer
      // 
      this.tlp_HomeContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tlp_HomeContainer.ColumnCount = 2;
      this.tlp_HomeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.97468F));
      this.tlp_HomeContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.02532F));
      this.tlp_HomeContainer.Controls.Add(this.label1, 0, 0);
      this.tlp_HomeContainer.Controls.Add(this.lv_Projects, 0, 1);
      this.tlp_HomeContainer.Controls.Add(this.tv_Folders, 1, 1);
      this.tlp_HomeContainer.Controls.Add(this.lbl_Treeview, 1, 0);
      this.tlp_HomeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlp_HomeContainer.Location = new System.Drawing.Point(0, 25);
      this.tlp_HomeContainer.Name = "tlp_HomeContainer";
      this.tlp_HomeContainer.RowCount = 2;
      this.tlp_HomeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.161125F));
      this.tlp_HomeContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.83887F));
      this.tlp_HomeContainer.Size = new System.Drawing.Size(395, 429);
      this.tlp_HomeContainer.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(4, 1);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(142, 30);
      this.label1.TabIndex = 4;
      this.label1.Text = "Progetti";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tv_Folders
      // 
      this.tv_Folders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tv_Folders.Location = new System.Drawing.Point(153, 35);
      this.tv_Folders.Name = "tv_Folders";
      this.tv_Folders.Size = new System.Drawing.Size(238, 390);
      this.tv_Folders.TabIndex = 2;
      // 
      // lbl_Treeview
      // 
      this.lbl_Treeview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbl_Treeview.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Treeview.Location = new System.Drawing.Point(153, 1);
      this.lbl_Treeview.Name = "lbl_Treeview";
      this.lbl_Treeview.Size = new System.Drawing.Size(238, 30);
      this.lbl_Treeview.TabIndex = 3;
      this.lbl_Treeview.Text = "Mappatura cartelle";
      this.lbl_Treeview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tsb_AddPrj
      // 
      this.tsb_AddPrj.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AddPrj.Image")));
      this.tsb_AddPrj.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_AddPrj.Name = "tsb_AddPrj";
      this.tsb_AddPrj.Size = new System.Drawing.Size(125, 22);
      this.tsb_AddPrj.Text = "Aggiungi progetto";
      // 
      // FRM_Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(395, 454);
      this.Controls.Add(this.tlp_HomeContainer);
      this.Controls.Add(this.toolStrip1);
      this.Name = "FRM_Home";
      this.Text = "ProjectViewer";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.tlp_HomeContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ListView lv_Projects;
    private System.Windows.Forms.TableLayoutPanel tlp_HomeContainer;
    private System.Windows.Forms.TreeView tv_Folders;
    private System.Windows.Forms.Label lbl_Treeview;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripButton tsb_AddPrj;
  }
}

