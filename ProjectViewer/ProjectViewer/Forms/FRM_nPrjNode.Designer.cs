namespace ProjectViewer.Forms {
  partial class FRM_nPrjNode {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lbl_PrjName = new System.Windows.Forms.Label();
      this.tb_PrjName = new System.Windows.Forms.TextBox();
      this.lbl_PrjRootPath = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lbl_PrjName
      // 
      this.lbl_PrjName.AutoSize = true;
      this.lbl_PrjName.Location = new System.Drawing.Point(12, 9);
      this.lbl_PrjName.Name = "lbl_PrjName";
      this.lbl_PrjName.Size = new System.Drawing.Size(94, 13);
      this.lbl_PrjName.TabIndex = 0;
      this.lbl_PrjName.Text = "Nome del progetto";
      // 
      // tb_PrjName
      // 
      this.tb_PrjName.Location = new System.Drawing.Point(12, 30);
      this.tb_PrjName.Name = "tb_PrjName";
      this.tb_PrjName.Size = new System.Drawing.Size(205, 20);
      this.tb_PrjName.TabIndex = 1;
      // 
      // lbl_PrjRootPath
      // 
      this.lbl_PrjRootPath.AutoSize = true;
      this.lbl_PrjRootPath.Location = new System.Drawing.Point(9, 93);
      this.lbl_PrjRootPath.Name = "lbl_PrjRootPath";
      this.lbl_PrjRootPath.Size = new System.Drawing.Size(94, 13);
      this.lbl_PrjRootPath.TabIndex = 0;
      this.lbl_PrjRootPath.Text = "Nome del progetto";
      // 
      // FRM_nPrjNode
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(291, 189);
      this.Controls.Add(this.tb_PrjName);
      this.Controls.Add(this.lbl_PrjRootPath);
      this.Controls.Add(this.lbl_PrjName);
      this.Name = "FRM_nPrjNode";
      this.Text = "FRM_nPrjNode";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_PrjName;
    private System.Windows.Forms.TextBox tb_PrjName;
    private System.Windows.Forms.Label lbl_PrjRootPath;
  }
}