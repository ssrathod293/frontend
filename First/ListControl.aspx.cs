using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class ListControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCities();
                loadGendr();
                loadSkills();
                loadSelctedItems();
            }
        }
private void LoadCities()
        {
            ListItem li1 = new ListItem("Pune","1");
            ListItem li2 = new ListItem("Mumbai","2");
            ListItem li3 = new ListItem("Satara","3");

            ddlcities.Items.Add(li1);
            ddlcities.Items.Add(li2);
            ddlcities.Items.Add(li3);

            ListItem li = new ListItem("--Select City--");
            ddlcities.Items.Insert(0,li);
        }
        private void loadGendr()
        {
            ListItem li1 = new ListItem("Male","1");
            ListItem li2 = new ListItem("Female","2");
            rblgender.Items.Add(li1);
            rblgender.Items.Add(li2);
        }

        private void loadSkills()
        {
            cblist.Items.Add(new ListItem() {Text="sql",Value="sql" });
            cblist.Items.Add(new ListItem() {Text="C#",Value="C#" });
            cblist.Items.Add(new ListItem() {Text="JS",Value="JS" });
            cblist.Items.Add(new ListItem() {Text="CSS",Value="CSS" });
            cblist.Items.Add(new ListItem() {Text="ADO",Value="ADO" });
        }

        private void loadSelctedItems()
        {
            lbSelectedSkills.Items.Add(new ListItem() { Text="SQL",Value="SQL"});
            lbSelectedSkills.Items.Add(new ListItem() { Text="C#",Value="S#"});


        }

        protected void btnread_Click(object sender, EventArgs e)
        {
            string city = ddlcities.SelectedItem.Text;
            string gender = string.Empty;
            foreach (ListItem item in rblgender.Items )
            {
                if (item.Selected)
                {
                    gender = item.Text;
                    break;
                }
            }
            string skills = string.Empty;
            foreach (ListItem item in cblist.Items )
            {
                if (item.Selected)
                {
                    skills += item.Text + ",";
                    
                }
            }
           skills= skills.Trim(',');
            string selectskill = string.Empty;
            foreach (ListItem item in lbSelectedSkills.Items )
            {
                if (item.Selected)
                {
                    selectskill += item.Text + ",";
                    
                }
            }
           selectskill= selectskill.Trim(',');
            Response.Write($"City:{city} <br/>");
            Response.Write($"Gender:{gender} <br/>");
            Response.Write($"Skills:{skills}  <br/> ");
            Response.Write($"slected skill:{selectskill}  <br/> ");
        }

        protected void btnset_Click(object sender, EventArgs e)
        {
            string selectedCity = "2";
            ddlcities.SelectedValue = selectedCity;

            rblgender.SelectedValue = "1";
            foreach (ListItem item in cblist.Items)
            {
                if (item.Text=="sql"||item.Text=="C#")
                {
                    item.Selected = true;
                }
            }
            foreach (ListItem item in lbSelectedSkills.Items)
            {
                if (item.Text == "SQL" )
                {
                    item.Selected = true;
                }
            }
        }
    }
}