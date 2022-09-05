Imports SystemImports System.Data

Public Class ComplainantInfo
    Private ID_ As Int32
    Private CustomerName_ As String
    Private CustomerTypeID_ As Int32
    Private MobileNumber_ As String
    Private CaseCaptureAt_ As DateTime
    Private ComplaintTypeID_ As Int32
    Private updatedAt_ As DateTime
    Private ComplaintType_ As String
    Private Priority_ As String
    Private CustomerType_ As String
    Property MaxResolutionHours_ As String


    Private Shared Function getObjectFromDataRow(ByVal objDataRow As DataRow) As ComplainantInfo
        Dim objComplainantInfo As New ComplainantInfo
        objComplainantInfo.ID = SqlHelper.GetInteger(objDataRow("ID"))
        objComplainantInfo.CustomerName = SqlHelper.GetString(objDataRow("CustomerName"))
        objComplainantInfo.CustomerTypeID = SqlHelper.GetInteger(objDataRow("CustomerTypeID"))
        objComplainantInfo.MobileNumber = SqlHelper.GetString(objDataRow("MobileNumber"))
        objComplainantInfo.CaseCaptureAt = SqlHelper.GetString(objDataRow("CaseCaptureAt"))
        objComplainantInfo.ComplaintTypeID = SqlHelper.GetInteger(objDataRow("ComplaintTypeID"))
        objComplainantInfo.updatedAt = SqlHelper.GetString(objDataRow("updatedAt"))

        If objDataRow.Table.Columns.Contains("ComplaintType") Then
            objComplainantInfo.ComplaintType = SqlHelper.GetString(objDataRow("ComplaintType"))
        End If

        If objDataRow.Table.Columns.Contains("Priority") Then
            objComplainantInfo.Priority = SqlHelper.GetString(objDataRow("Priority"))
        End If

        If objDataRow.Table.Columns.Contains("CustomerType") Then
            objComplainantInfo.CustomerType = SqlHelper.GetString(objDataRow("CustomerType"))
        End If

        If objDataRow.Table.Columns.Contains("MaxResolutionHours") Then
            objComplainantInfo.MaxResolutionHours = SqlHelper.GetString(objDataRow("MaxResolutionHours"))
        End If

        Return objComplainantInfo
    End Function
    Private Shared Function getObjectFromDataTable(ByVal objDataTable As DataTable) As Collection
        Dim allObjects As New Collection
        Dim objDataRow As DataRow
        Dim objComplainantInfo As ComplainantInfo
        For Each objDataRow In objDataTable.Rows
            objComplainantInfo = getObjectFromDataRow(objDataRow)
            allObjects.Add(objComplainantInfo, objComplainantInfo.ID)
        Next
        Return allObjects
    End Function




    Public Shared Function addNew(ByVal CustomerName As String, ByVal CustomerTypeID As Int32, ByVal MobileNumber As String, ByVal CaseCaptureAt As DateTime, ByVal ComplaintTypeID As Int32, ByVal updatedAt As DateTime) As Int16
        Dim status As Int16 = SqlHelper.ExecuteNonQuery(util.ConnectionString, "p_ComplainantInfo_AddNew", CustomerName, CustomerTypeID, MobileNumber, CaseCaptureAt, ComplaintTypeID, updatedAt)
        Return status

    End Function

    Public Shared Function getAllRegistered() As DataTable

        Dim objDataTable As DataTable
        objDataTable = SqlHelper.ExecuteDataTable(util.ConnectionString, "p_ComplainantInfo_GetALLRegistered")

        Return objDataTable
    End Function

    Public Property ID
        Get
            Return ID_
        End Get
        Set(ByVal value)
            ID_ = value
        End Set
    End Property

    Public Property CustomerName
        Get
            Return CustomerName_
        End Get
        Set(ByVal value)
            CustomerName_ = value
        End Set
    End Property

    Public Property CustomerTypeID
        Get
            Return CustomerTypeID_
        End Get
        Set(ByVal value)
            CustomerTypeID_ = value
        End Set
    End Property

    Public Property MobileNumber
        Get
            Return MobileNumber_
        End Get
        Set(ByVal value)
            MobileNumber_ = value
        End Set
    End Property

    Public Property CaseCaptureAt
        Get
            Return CaseCaptureAt_
        End Get
        Set(ByVal value)
            CaseCaptureAt_ = value
        End Set
    End Property

    Public Property ComplaintTypeID
        Get
            Return ComplaintTypeID_
        End Get
        Set(ByVal value)
            ComplaintTypeID_ = value
        End Set
    End Property

    Public Property updatedAt
        Get
            Return updatedAt_
        End Get
        Set(ByVal value)
            updatedAt_ = value
        End Set
    End Property

    Public Property ComplaintType
        Get
            Return ComplaintType_
        End Get
        Set(value)
            ComplaintType_ = value
        End Set
    End Property    Public Property Priority
        Get
            Return Priority_
        End Get
        Set(value)
            Priority_ = value
        End Set
    End Property    Public Property CustomerType
        Get
            Return CustomerType_
        End Get
        Set(value)
            CustomerType_ = value
        End Set
    End Property    Public Property MaxResolutionHours
        Get
            Return MaxResolutionHours_
        End Get
        Set(value)
            MaxResolutionHours_ = value
        End Set
    End PropertyEnd Class
