
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using BO.AssetInventoryTracking;
using System.Configuration;
namespace DAL.AssetInventoryTracking
{
	public class inventory_item
	{
		public static List<BO.AssetInventoryTracking.inventory_item> GetAllinventory_item()
		{
			List<BO.AssetInventoryTracking.inventory_item> xinventory_itemList = new List<BO.AssetInventoryTracking.inventory_item>();
			string query = "SELECT [inventoryID],[length_of_warranty],[make],[model],[date_purchased],[percent_change_cost],[status_of_item] FROM dbo.[inventory_item]";
			using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["db_AssetInventoryTracking"].ConnectionString)) {
				using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn)) {
					conn.Open();
					using (System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)) {
						while (reader.Read()) {
							BO.AssetInventoryTracking.inventory_item xinventory_item = new BO.AssetInventoryTracking.inventory_item();
							if (!object.ReferenceEquals(reader["inventoryID"], DBNull.Value)) {
								xinventory_item.inventoryID = int.Parse(reader["inventoryID"].ToString());
							}
							if (!object.ReferenceEquals(reader["length_of_warranty"], DBNull.Value)) {
								xinventory_item.length_of_warranty = int.Parse(reader["length_of_warranty"].ToString());
							}
							if (!object.ReferenceEquals(reader["make"], DBNull.Value)) {
								xinventory_item.make = reader["make"].ToString();
							}
							if (!object.ReferenceEquals(reader["model"], DBNull.Value)) {
								xinventory_item.model = reader["model"].ToString();
							}
							if (!object.ReferenceEquals(reader["date_purchased"], DBNull.Value)) {
								xinventory_item.date_purchased = DateTime.Parse(reader["date_purchased"].ToString());
							}
							if (!object.ReferenceEquals(reader["percent_change_cost"], DBNull.Value)) {
								xinventory_item.percent_change_cost = int.Parse(reader["percent_change_cost"].ToString());
							}
							if (!object.ReferenceEquals(reader["status_of_item"], DBNull.Value)) {
								xinventory_item.status_of_item = reader["status_of_item"].ToString();
							}
							xinventory_itemList.Add(xinventory_item);
						}
					}
				}
			}
			return xinventory_itemList;
		}

		public static BO.AssetInventoryTracking.inventory_item GetByIDinventory_item(int inventory_itemID)
		{
			BO.AssetInventoryTracking.inventory_item xinventory_item = new BO.AssetInventoryTracking.inventory_item();
			string query = "SELECT [inventoryID],[length_of_warranty],[make],[model],[date_purchased],[percent_change_cost],[status_of_item] FROM dbo.[inventory_item] WHERE inventory_itemID=@inventory_itemID";
			using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["db_AssetInventoryTracking"].ConnectionString)) {
				using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn)) {
					cmd.Parameters.AddWithValue("@inventory_itemID", inventory_itemID);
					conn.Open();
					using (System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)) {
						if (reader.Read()) {
							if (!object.ReferenceEquals(reader["inventoryID"], DBNull.Value)) {
								xinventory_item.inventoryID =int.Parse( reader["inventoryID"].ToString());
							}
							if (!object.ReferenceEquals(reader["length_of_warranty"], DBNull.Value)) {
								xinventory_item.length_of_warranty = int.Parse(reader["length_of_warranty"].ToString());
							}
							if (!object.ReferenceEquals(reader["make"], DBNull.Value)) {
								xinventory_item.make = reader["make"].ToString();
							}
							if (!object.ReferenceEquals(reader["model"], DBNull.Value)) {
								xinventory_item.model = reader["model"].ToString();
							}
							if (!object.ReferenceEquals(reader["date_purchased"], DBNull.Value)) {
								xinventory_item.date_purchased = DateTime.Parse(reader["date_purchased"].ToString());
							}
							if (!object.ReferenceEquals(reader["percent_change_cost"], DBNull.Value)) {
								xinventory_item.percent_change_cost = int.Parse(reader["percent_change_cost"].ToString());
							}
							if (!object.ReferenceEquals(reader["status_of_item"], DBNull.Value)) {
								xinventory_item.status_of_item = reader["status_of_item"].ToString();
							}
						}
					}
				}
			}
			return xinventory_item;
		}

		public static int Addinventory_item(BO.AssetInventoryTracking.inventory_item inventory_item)
		{
			int inventory_itemID = 0;
			string query = "INSERT INTO dbo.[inventory_item] ([inventoryID],[length_of_warranty],[make],[model],[date_purchased],[percent_change_cost],[status_of_item]) VALUES ( @inventoryID, @length_of_warranty, @make, @model, @date_purchased, @percent_change_cost, @status_of_item) ; SELECT SCOPE_IDENTITY();";
			using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["db_AssetInventoryTracking"].ConnectionString)) {
				using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn)) {
					if ((inventory_item.inventoryID == -1)) {
						cmd.Parameters.AddWithValue("@inventoryID", DBNull.Value);
					} else {
						cmd.Parameters.AddWithValue("@inventoryID", inventory_item.inventoryID);
					}
					cmd.Parameters.AddWithValue("@length_of_warranty", inventory_item.length_of_warranty);
					cmd.Parameters.AddWithValue("@make", inventory_item.make);
					cmd.Parameters.AddWithValue("@model", inventory_item.model);
					cmd.Parameters.AddWithValue("@date_purchased", inventory_item.date_purchased);
					cmd.Parameters.AddWithValue("@percent_change_cost", inventory_item.percent_change_cost);
					cmd.Parameters.AddWithValue("@status_of_item", inventory_item.status_of_item);
					conn.Open();
					inventory_itemID = int.Parse(cmd.ExecuteScalar().ToString());
				}
			}
			return inventory_itemID;
		}

		public static int Deleteinventory_item(int inventory_itemID)
		{
			int RowsAffected = -1;
			string query = " UPDATE dbo.inventory_item SET IsDeleted = 1 WHERE inventory_itemID=@inventory_itemID ";
			using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["db_AssetInventoryTracking"].ConnectionString)) {
				using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn)) {
					cmd.Parameters.AddWithValue("@inventory_itemID", inventory_itemID);
					conn.Open();
					RowsAffected = cmd.ExecuteNonQuery();
				}
			}
			return RowsAffected;
		}

		public static int Updateinventory_item(BO.AssetInventoryTracking.inventory_item inventory_item)
		{
			int RowsAffected = -1;
			string query = "UPDATE dbo.[inventory_item] SET inventoryID = @inventoryID,length_of_warranty = @length_of_warranty,make = @make,model = @model,date_purchased = @date_purchased,percent_change_cost = @percent_change_cost,status_of_item = @status_of_item WHERE inventory_itemID=@inventory_itemID";
			using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["db_AssetInventoryTracking"].ConnectionString)) {
				using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn)) {
					if ((inventory_item.inventoryID == -1)) {
						cmd.Parameters.AddWithValue("@inventoryID", DBNull.Value);
					} else {
						cmd.Parameters.AddWithValue("@inventoryID", inventory_item.inventoryID);
					}
					cmd.Parameters.AddWithValue("@length_of_warranty", inventory_item.length_of_warranty);
					cmd.Parameters.AddWithValue("@make", inventory_item.make);
					cmd.Parameters.AddWithValue("@model", inventory_item.model);
					cmd.Parameters.AddWithValue("@date_purchased", inventory_item.date_purchased);
					cmd.Parameters.AddWithValue("@percent_change_cost", inventory_item.percent_change_cost);
					cmd.Parameters.AddWithValue("@status_of_item", inventory_item.status_of_item);
					conn.Open();
					RowsAffected = cmd.ExecuteNonQuery();
				}
			}
			return RowsAffected;
		}

	}
}
