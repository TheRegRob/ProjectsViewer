using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViewer {
  public partial class FRM_Home : Form {
    private string[] prjs = ["prj1", "prj2", "prj3", "prj4", "prj5", "prj6", "prj7", "prj8", "prj9",
      "prj10", "prj11", "prj12", "prj13", "prj14", "prj15", "prj16", "prj17", "prj18", "prj19", "prj20",
      "prj21", "prj22", "prj23", "prj24", "prj25", "prj26", "prj27", "prj28", "prj29", "prj30", "prj31"];
    private Control uponCtr = null;

    public FRM_Home() {
      InitializeComponent();
      
    }

    #region Form Events
    private void FRM_Home_Load(object sender, EventArgs e) {
     
    }

    #endregion

    private void FRM_Home_Shown(object sender, EventArgs e) {
      FRM_Home myParent = (FRM_Home)this.Parent;
      var counter = 0;
      var lastcounter = 0;
      foreach (string prj in prjs) {
        var nButton = new CTR_SideButton(prj);
        PNL_Buttons.Controls.Add(nButton);
        PNL_Buttons.Controls.SetChildIndex(nButton, counter - lastcounter);
        counter++;
        lastcounter = counter;
      }
    }
  }
}
