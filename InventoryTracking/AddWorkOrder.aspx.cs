﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryTracking
{
    public partial class AddWorkOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void NETAddClicked(object sender, EventArgs e)
        {
        }
        protected void AddClicked(object sender, EventArgs e)
        {
            // String test = Request.Form["HiddenInput"];
            String test = HiddenField.Value;
            String[] testlist = test.Split(';');

            //Response.Write(test);
            StreamWriter sw = default(StreamWriter);
            string strFile = "C:\\Users\\Anuradha\\Documents\\visual studio 2015\\Projects\\InventoryTracking\\InventoryTracking\\DataLog Files\\TextFile.txt";
            if ((!File.Exists(strFile)))
            {
                File.Create(strFile).Close();
                sw = File.CreateText(strFile);
                foreach (string teststr in testlist)
                {
                    sw.WriteLine(teststr);
                }


                sw.Close();

            }
            else
            {
                sw = File.AppendText(strFile);
                foreach (string teststr in testlist)
                {
                    sw.WriteLine(teststr);
                }
                sw.Close();
            }
        }
    }
}