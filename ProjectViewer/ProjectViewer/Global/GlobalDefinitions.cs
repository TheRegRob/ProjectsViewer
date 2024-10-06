using ProjectViewer.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectViewer.Global {
  internal class GlobalDefinitions {
    #region Declared Variables
    public static string folderPath;
    private static readonly string filesPath = Properties.Settings.Default.FilesFolder;
    private static readonly string projectsFilePath = Properties.Settings.Default.ProjectsFile;

    public static List<ProjectNode> instanceProjects;
    #endregion

    #region Getters and Setters
    public static string FolderPath {
      get { return folderPath; }
      set { folderPath = value; }
    }
    public static string FilesPath {
      get { return folderPath + filesPath; }
    }
    public static string AccountsFilePath {
      get { return FilesPath + projectsFilePath; }
    }
    #endregion
  }
}
