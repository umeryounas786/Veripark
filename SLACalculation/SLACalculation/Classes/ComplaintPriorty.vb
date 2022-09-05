Imports SystemImports System.Data
Public Class ComplaintPriorty
    Private ID_ As Int32
    Private ComplaintType_ As String
    Private PriorityID_ As Int32
    Private Shared Function getObjectFromDataRow(ByVal objDataRow As DataRow) As ComplaintPriorty
        Dim objComplaintPriorty As New ComplaintPriorty
        objComplaintPriorty.ID = SqlHelper.GetInteger(objDataRow("ID"))
        objComplaintPriorty.ComplaintType = SqlHelper.GetString(objDataRow("ComplaintType"))
        objComplaintPriorty.PriorityID = SqlHelper.GetInteger(objDataRow("PriorityID"))

        Return objComplaintPriorty
    End Function
    Private Shared Function getObjectFromDataTable(ByVal objDataTable As DataTable) As Collection
        Dim allObjects As New Collection
        Dim objDataRow As DataRow
        Dim objComplaintPriorty As ComplaintPriorty
        For Each objDataRow In objDataTable.Rows
            objComplaintPriorty = getObjectFromDataRow(objDataRow)
            allObjects.Add(objComplaintPriorty, objComplaintPriorty.ID)
        Next
        Return allObjects
    End Function


    Public Shared Function getAll() As Collection
        Dim allObjects As New Collection
        Dim objDataTable As DataTable
        objDataTable = SqlHelper.ExecuteDataTable(util.ConnectionString, "p_ComplaintPriorty_GetALL")
        allObjects = getObjectFromDataTable(objDataTable)
        Return allObjects
    End Function








    Public Property ID
        Get
            Return ID_
        End Get
        Set(ByVal value)
            ID_ = value
        End Set
    End Property

    Public Property ComplaintType
        Get
            Return ComplaintType_
        End Get
        Set(ByVal value)
            ComplaintType_ = value
        End Set
    End Property

    Public Property PriorityID
        Get
            Return PriorityID_
        End Get
        Set(ByVal value)
            PriorityID_ = value
        End Set
    End PropertyEnd Class
