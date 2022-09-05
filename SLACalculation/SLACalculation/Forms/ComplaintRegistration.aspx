<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="ComplaintRegistration.aspx.vb" Inherits="SLACalculation.ComplaintRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>

        Complaint Registration Form
    </h1>
        

    <table>
      
        <tr>
            <td>
                Complaint Type
            </td>
            <td>

                <asp:DropDownList ID="ddlComplaintType" runat="server" ></asp:DropDownList>
             </td>

        </tr>
         <tr>
            <td>
                Costumer Type
            </td>
            <td>

                <asp:DropDownList ID="ddlCustomerType" runat="server" ></asp:DropDownList>
            </td>

        </tr>
        
          <tr>
            <td>
                Name of Customer

            </td>
            <td>
                <asp:TextBox ID="txtNameOfCustomer" runat="server" ></asp:TextBox>

            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtNameOfCustomer" runat="server" ErrorMessage="Name is mandatory"></asp:RequiredFieldValidator>

            </td>

        </tr>


          <tr>
            <td>
               Mobile Number
            </td>
            <td>
                <asp:TextBox ID="txtMobileNumber" placeholder="x-xx-xxx xxxx" runat="server" ></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtMobileNumber" runat="server" ErrorMessage="Mobile Number is mandatory"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev" runat="server" ErrorMessage="Format is incorrect." ControlToValidate="txtMobileNumber" ValidationExpression="\d{1}-\d{2}-\d{3} \d{4}" ></asp:RegularExpressionValidator>

            </td>

        </tr>



          <tr>
            <td>
                &nbsp;</td>
            <td style="text-align: right">
                <asp:Button ID="cmdComplaintRegistration" runat="server" Text="Registration" Width="215px" />

            </td>

        </tr>



          <tr>
            <td colspan="2">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>    
                
                &nbsp;</td>
           

        </tr>



          <tr>
            <td colspan="2">

<asp:GridView ID="GridView1" runat="server" >
</asp:GridView>
              </td>
           

        </tr>



    </table>



</asp:Content>
