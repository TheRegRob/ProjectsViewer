using ProjectViewer.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectViewer.Classes {
    [Serializable]
  public class ProjectNode : ISerializable {
    #region Properties
    public string RootPath;
    public List<string> OtherRes {  get; set; }
    #endregion

    #region Constants

    #endregion

    #region Constructors
    public ProjectNode(string rootPath) {
      RootPath = rootPath;
      OtherRes = new List<string>();
    }

    public ProjectNode(SerializationInfo info, StreamingContext context) {
      try {
        this.RootPath = (string)info.GetValue("rootpath", typeof(string));
      } catch {
        this.RootPath = "Not Found";
      }
      try {
        this.OtherRes = (List<string>)info.GetValue("other_res", typeof(List<string>));
      } catch {
        this.OtherRes= new List<string>();
      }
    }
    #endregion

    #region Getters and Setters
    #endregion

    #region Functions and Methods
    public void GetObjectData(SerializationInfo info, StreamingContext context) {
      info.AddValue("rootpath", this.RootPath, typeof(string));
      info.AddValue("other_res", this.OtherRes, typeof(List<string>));
    }
    #endregion

  }
}
