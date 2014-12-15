using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Photo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      string s = (sender as Page).ClientQueryString;
      System.Collections.Specialized.NameValueCollection nv = HttpUtility.ParseQueryString(s);
      string sPID = nv["ParcelId"];
      string sAddress = nv["SiteAddress"];
      this.lblParcelID.Text = sPID;
      this.siteAddress.Text = sAddress;

      //search folder for images with this parcel ID in it's name
      string folderPath = Server.MapPath("~/PropertyPhotographs");
      
      string sSearch = "*" + sPID + "*";
      sSearch = "*";
      string[]sFiles=Directory.GetFiles(folderPath, sSearch);
      string jsonPhotos = "";
      int i = 0;
      foreach (string sFile in sFiles)
      {
        i++;
        string sImage = Path.GetFileName(sFile);
        sImage = "PropertyPhotographs/" + sImage;

        string sFileName = Path.GetFileName(sFile);

        jsonPhotos += "{'url':'" + sImage + "','name':'" + sFileName + "'}";
        if (i < sFiles.Length) jsonPhotos += ",";
        

        //sImage = urlPath + "/" + sImage;
        TableRow tr = new TableRow();
        TableCell tc=new TableCell();
        tc.Controls.Add(new Image() { ImageUrl = sImage });
        tr.Cells.Add(tc);
        this.tblImages.Rows.Add(tr);


      }
      
      Response.Clear();
      Response.ContentType = "application/json; charset=utf-8";
      //Response.Write("{'photos':[{ 'url':'http://test/me.jpg','name':'Front Photo'}   ]}");
      Response.Write("{'photos':[" + jsonPhotos + "]}");
      Response.End();


    }
}