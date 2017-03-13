
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
namespace BO.AssetInventoryTracking
{
	[Serializable()]
	public class inventory_item
	{
		public inventory_item()
		{
			_inventoryID = -1;
			_length_of_warranty = -1;
			_make = "";
			_model = "";
			_date_purchased = null;
			_percent_change_cost = -1;
			_status_of_item = "";
		}
		private int _inventoryID;
		private int _length_of_warranty;
		private string _make;
		private string _model;
		private DateTime? _date_purchased;
		private int _percent_change_cost;
		private string _status_of_item;
		public int inventoryID {
			get { return _inventoryID; }
			set { _inventoryID = value; }
		}
		public int length_of_warranty {
			get { return _length_of_warranty; }
			set { _length_of_warranty = value; }
		}
		public string make {
			get { return _make; }
			set { _make = value; }
		}
		public string model {
			get { return _model; }
			set { _model = value; }
		}
		public DateTime? date_purchased {
			get { return _date_purchased; }
			set { _date_purchased = value; }
		}
		public int percent_change_cost {
			get { return _percent_change_cost; }
			set { _percent_change_cost = value; }
		}
		public string status_of_item {
			get { return _status_of_item; }
			set { _status_of_item = value; }
		}
	}
}

