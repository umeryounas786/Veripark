Imports System
Imports SLACalculation.Startup

Public Class ComplaintRegistration
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then

            BindComplaintType()
            BindCostumerType()
            LoadGridView()
        End If
    End Sub

    Sub BindComplaintType()

        Try


            Dim col As Collection = ComplaintPriorty.getAll()

            ddlComplaintType.DataSource = col
            ddlComplaintType.DataTextField = "ComplaintType"
            ddlComplaintType.DataValueField = "ID"
            ddlComplaintType.DataBind()
            ddlComplaintType.Items.Insert(0, "--Select--")

        Catch ex As Exception

        End Try
    End Sub
    Sub BindCostumerType()

        Try


            Dim col As Collection = CustomerType.getAll()

            ddlCustomerType.DataSource = col
            ddlCustomerType.DataTextField = "CustomerType"
            ddlCustomerType.DataValueField = "ID"
            ddlCustomerType.DataBind()
            ddlCustomerType.Items.Insert(0, "--Select--")

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub cmdComplaintRegistration_Click(sender As Object, e As EventArgs) Handles cmdComplaintRegistration.Click
        Try
            If ddlComplaintType.SelectedItem.Text = "--Select--" Then
                lblError.Text = "Choose Complaint Type"
            ElseIf ddlCustomerType.SelectedItem.Text = "--Select--" Then

                lblError.Text = "Choose Customer Type"
            End If
            Dim status As Int16 = ComplainantInfo.addNew(txtNameOfCustomer.Text, ddlCustomerType.SelectedValue, txtMobileNumber.Text, System.DateTime.Now, ddlComplaintType.SelectedValue, System.DateTime.Now)
            If status > 0 Then
                lblError.Text = "Added Successfully"
                LoadGridView()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub LoadGridView()

        Try

            Dim dt As DataTable = ComplainantInfo.getAllRegistered()
            Dim i As Integer = 0

            For i = 0 To dt.Rows.Count - 1

                dt.Rows(i).Item("Solution_Date_Time") = getSolutionDate(dt.Rows(i).Item("Case_Date"), CInt(Replace(dt.Rows(i).Item("MaxResolutionHours"), " Hours", "")))
            Next

            GridView1.DataSource = dt
            GridView1.DataBind()

        Catch ex As Exception

        End Try

    End Sub

    Function getSolutionDate(ByVal cd As DateTime, ByVal whours As Integer) As DateTime

        Dim dayEnd As Integer = 18
        Dim dayStart As Integer = 9

        Dim offsetHour As Integer = 0
        Dim offsetMinute As Integer = 0

        If (cd.Hour + whours) >= dayEnd Then

            offsetHour = Math.Abs(dayEnd - (cd.Hour + whours))
            offsetMinute = cd.Minute
            Dim daysToAdd As Integer = 0
            daysToAdd = (offsetHour / 9) + 1
            Dim nextDay As DateTime = cd.AddDays(daysToAdd)
            Dim dt As DateTime = New DateTime(nextDay.Year, nextDay.Month, nextDay.Day, dayStart, 0, 0)
            dt = dt.AddHours(offsetHour)
            dt = dt.AddMinutes(offsetMinute)

            Return dt

        End If

        cd = cd.AddHours(whours)
        Return cd

    End Function



End Class