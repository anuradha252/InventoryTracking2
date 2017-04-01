<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWorkOrder.aspx.cs" Inherits="InventoryTracking.AddWorkOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
       <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
           

        });

       
    </script>
</head>
<body>
   <form id="form1" runat="server">
    <div class="container">
      <h1>Add work Order</h1>
                <div class="form-group">
                    <label for="txtInventoryID">InventoryID</label>
                    <input type="text" class="form-control" id="txtAddInventoryID" runat="server"/>
                </div>
          <div class="form-group">
                    <label for="txtComment">Comment</label>
                    <input type="text" class="form-control" id="txtComment" runat="server"/>
                </div>
        <fieldset class="form-group">
                    <legend>Status</legend>
                    <div class="form-check">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="AddoptionsRadios" id="Radio1" value="open" checked />
                            Open
                        </label>
                    </div>
                    <div class="form-check">
                        <label class="form-check-label">
                            <input type="radio" class="form-check-input" name="AddoptionsRadios" id="Radio2" value="close" />
                            Close
                        </label>
                    </div>

                </fieldset>
         <asp:Button ID="btngetvalue" runat="server" Text="Save using ASP" OnClick="AddClicked" class="btn btn-primary"/>
          <asp:Button ID="btnsaveNET" runat="server" Text="Save using .NET" OnClick="NETAddClicked" class="btn btn-primary"/>
          <input id="HiddenField" type="hidden" runat="server" value="" />
    </div>
    </form>
     <input type="hidden" id="HiddenInput" name="HiddenInput" value="" />
</body>
</html> 
