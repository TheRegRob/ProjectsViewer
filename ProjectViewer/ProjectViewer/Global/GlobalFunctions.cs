using ProjectViewer.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViewer.Global {
  internal class GlobalFunctions {
    #region Functions and Subroutines
    #region Folders Setups
    public static void SetupGlobalFolders() {
      if (Debugger.IsAttached) {
        GlobalDefinitions.folderPath = AppDomain.CurrentDomain.BaseDirectory;
      } else {
        GlobalDefinitions.folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
      }
      if (!Directory.Exists(GlobalDefinitions.FilesPath))
        Directory.CreateDirectory(GlobalDefinitions.FilesPath);
    }
    #endregion
    #region Files Setups
    public static bool SetupProjects() {
      BinaryFormatter bf = new BinaryFormatter();
      if (!File.Exists(GlobalDefinitions.AccountsFilePath)) {
        var nFile = File.Create(GlobalDefinitions.AccountsFilePath);
        nFile.Close();
      }
      FileStream fStream = new FileStream(GlobalDefinitions.AccountsFilePath, FileMode.Open, FileAccess.Read);
      if (fStream.Length == 0) {
        GlobalDefinitions.instanceProjects = new List<ProjectNode>();
        fStream.Close();
        return false;
      } else {
        try {
          List<ProjectNode> existingProjects = (List<ProjectNode>)bf.Deserialize(fStream);
          if (existingProjects != null) {
            GlobalDefinitions.instanceProjects = existingProjects;
            fStream.Close();
            return true;
          }
        } catch {
          MessageBox.Show("File corrotto", "C'è stato un errore nella lettura del file", MessageBoxButtons.OK, MessageBoxIcon.Error);
          fStream.Close();
          return false;
        }
        fStream.Close();
        return false;
      }
    }
    #endregion
    #endregion
  }
}
