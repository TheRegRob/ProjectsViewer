using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;

namespace ProjectViewer {
  public partial class CTR_SideButton : Button {
    #region Properties
    private string btnName { get; set; }
    #endregion

    public CTR_SideButton(string btnName) {
      InitializeComponent();
      BackColor = SystemColors.WindowFrame;
      ForeColor = Color.White;
      FlatStyle = FlatStyle.Flat;
      FlatAppearance.BorderColor = BackColor;
      FlatAppearance.BorderSize = 0;
      Font = new Font("Segoe UI Semilight", 10);
      Text = btnName;
      TextAlign = ContentAlignment.MiddleLeft;
      Dock = DockStyle.Top;
      Location = new Point(0, 207);
      Padding = new Padding(10, 0, 0, 0);
      Size = new Size(257, 38);
      UseVisualStyleBackColor = true;
    }
  }
}
