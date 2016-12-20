using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Xml.Linq;

using System.Xml;
using System.Xml.Schema;
using System.IO;
/** Author: Scott Robinson
 *  December 2016
 *  XML Final Project 
 The goal of this application is to allow users to select a variety of football leagues and view the teams with the most titles won and the amount of European
    titles they have won.*/
public partial class _Default : System.Web.UI.Page
{
    private static String validationError = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            XDocument xDoc = XDocument.Load(Server.MapPath("/App_Data/Teams.xml"));
            var x = (from c in xDoc.Descendants("teams").Descendants()
                     let mLev = (String)c.Attribute("league")
                     where mLev != null
                     select mLev).Distinct();
            foreach (String categ in x)
                ddlCats.Items.Add(categ);
        }
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        if (ddlCats.SelectedIndex > -1)
        {
            String teamLeague = ddlCats.SelectedValue;
            XDocument xDoc = XDocument.Load(Server.MapPath("/App_Data/Teams.xml"));
            var x = from c in xDoc.Descendants("teams").Descendants()
                    let teamLeagueInfo = (String)c.Attribute("league")
                    where teamLeagueInfo == teamLeague
                    select c;
            lstItems.Items.Clear();
            foreach (var chk in x)
                //Creating the local variables in order to populate the text box. 
            {
                String name = chk.Element("name").Value;
                String titles = chk.Element("titles").Value;
                String europeanTitles = chk.Element("europeantitles").Value;
                lstItems.Items.Add(name + " has won " + titles + " domestic titles and " + europeanTitles + " European titles ");              
            }
        }
    }
}