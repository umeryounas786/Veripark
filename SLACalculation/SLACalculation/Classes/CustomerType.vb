Imports SystemImports System.Data
Public Class CustomerType
    Private ID_ As Int32
    Private CustomerType_ As String
    Private Shared Function getObjectFromDataRow(ByVal objDataRow As DataRow) As CustomerType
        Dim objCustomerType As New CustomerType
        objCustomerType.ID = SqlHelper.GetInteger(objDataRow("ID"))
        objCustomerType.CustomerType = SqlHelper.GetString(objDataRow("CustomerType"))

        Return objCustomerType
    End Function
    Private Shared Function getObjectFromDataTable(ByVal objDataTable As DataTable) As Collection
        Dim allObjects As New Collection
        Dim objDataRow As DataRow
        Dim objCustomerType As CustomerType
        For Each objDataRow In objDataTable.Rows
            objCustomerType = getObjectFromDataRow(objDataRow)
            allObjects.Add(objCustomerType, objCustomerType.ID)
        Next
        Return allObjects
    End Function


    Public Shared Function getAll() As Collection
        Dim allObjects As New Collection
        Dim objDataTable As DataTable
        objDataTable = SqlHelper.ExecuteDataTable(util.ConnectionString, "p_CustomerType_GetALL")
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

    Public Property CustomerType
        Get
            Return CustomerType_
        End Get
        Set(ByVal value)
            CustomerType_ = value
        End Set
    End PropertyEnd Class
