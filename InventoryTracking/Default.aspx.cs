using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryTracking
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BO.AssetInventoryTracking.inventory_item item = new BO.AssetInventoryTracking.inventory_item();
            List<BO.AssetInventoryTracking.inventory_item> itemlist = new List<BO.AssetInventoryTracking.inventory_item>();
            itemlist= item.GetAllinventory_item();
            gvAssetInventory.DataSource = itemlist;
            gvAssetInventory.DataBind();

        }
    }
}