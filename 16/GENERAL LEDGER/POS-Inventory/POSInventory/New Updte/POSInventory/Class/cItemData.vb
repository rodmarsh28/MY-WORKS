﻿Public Class cItemData

#Region "Variables"
    Private mySql As String
    Private ds As DataSet

    Const TABLE As String = "ITEMMASTER"
    Friend hasLoaded As Boolean = False
#End Region

#Region "Properties"
    Private _itemID As Integer
    Public Property ItemID() As Integer
        Get
            Return _itemID
        End Get
        Set(ByVal value As Integer)
            _itemID = value
        End Set
    End Property

    Private _itemCode As String
    Public Property ItemCode() As String
        Get
            Return _itemCode
        End Get
        Set(ByVal value As String)
            _itemCode = value
        End Set
    End Property

    Private _description As String = ""
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _category As String
    Public Property Category() As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property

    Private _subCat As String
    Public Property SubCategory() As String
        Get
            Return _subCat
        End Get
        Set(ByVal value As String)
            _subCat = value
        End Set
    End Property

    Private _salePrice As Double
    Public Property SalePrice() As Double
        Get
            Return _salePrice
        End Get
        Set(ByVal value As Double)
            _salePrice = value
        End Set
    End Property

    Private _unitPrice As Double
    Public Property UnitPrice() As Double
        Get
            Return _unitPrice
        End Get
        Set(ByVal value As Double)
            _unitPrice = value
        End Set
    End Property

    Private _UoM As String
    Public Property UnitofMeasure() As String
        Get
            Return _UoM
        End Get
        Set(ByVal value As String)
            _UoM = value
        End Set
    End Property

    Private _isInv As Boolean
    Public Property isInventoriable() As Boolean
        Get
            Return _isInv
        End Get
        Set(ByVal value As Boolean)
            _isInv = value
        End Set
    End Property

    Private _isSale As Boolean
    Public Property isSaleable() As Boolean
        Get
            Return _isSale
        End Get
        Set(ByVal value As Boolean)
            _isSale = value
        End Set
    End Property

    Private _onHand As Double
    Public Property onHand() As Double
        Get
            Return _onHand
        End Get
        Set(ByVal value As Double)
            _onHand = value
        End Set
    End Property

    Private _onHold As Boolean
    Public Property onHold() As Boolean
        Get
            Return _onHold
        End Get
        Set(ByVal value As Boolean)
            _onHold = value
        End Set
    End Property

    Private _remarks As String
    Public Property Remarks() As String
        Get
            Return _remarks
        End Get
        Set(ByVal value As String)
            _remarks = value
        End Set
    End Property

    Private _srp As Double
    Public Property SRP() As Double
        Get
            Return _srp
        End Get
        Set(ByVal value As Double)
            _srp = value
        End Set
    End Property

    Private _tags As String
    Public Property Tags() As String
        Get
            Return _tags
        End Get
        Set(ByVal value As String)
            _tags = value
        End Set
    End Property

    Private _qty As Double
    Public Property Quantity() As Double
        Get
            Return _qty
        End Get
        Set(ByVal value As Double)
            _qty = value
        End Set
    End Property
#End Region

#Region "Procedures"
    Public Overridable Sub Load_Item(Optional ByVal id As Integer = 0)
        If id <> 0 Then
            mySql = "SELECT * FROM ITEMMASTER WHERE ITEMID = " & If(id = 0, _itemID, id)
        Else
            mySql = String.Format("SELECT * FROM ITEMMASTER WHERE ItemCode = '{0}'", _itemCode)
        End If

        ds = New DataSet
        ds = LoadSQL(mySql)

        If ds.Tables(0).Rows.Count <> 1 Then
            MsgBox("Failed to load item", MsgBoxStyle.Critical, "ID NOT FOUND")
            Exit Sub
        End If

        Load_ItemRow(ds.Tables(0).Rows(0))

        Console.WriteLine(String.Format("{0} loaded.", _itemCode))
    End Sub

    Public Overridable Sub Save_ItemData()
        Dim isNew As Boolean = False

        mySql = "SELECT * FROM ITEMMASTER WHERE ITEMCODE = '" & _itemCode & "'"
        'If _itemID = 0 Then mySql = "SELECT * FROM ITEMMASTER ROWS 1"

        ds = New DataSet
        ds = LoadSQL(mySql, TABLE)

        If ds.Tables(0).Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables(TABLE).NewRow
            With dsNewRow
                .Item("ITEMCODE") = _itemCode
                .Item("DESCRIPTION") = _description
                .Item("CATEGORIES") = _category
                .Item("SUBCAT") = _subCat
                .Item("UOM") = _UoM
                .Item("UNITPRICE") = _unitPrice
                .Item("SALEPRICE") = _salePrice
                .Item("ISSALE") = If(_isSale, 1, 0)
                .Item("ISINV") = If(_isInv, 1, 0)
                .Item("ONHOLD") = If(_onHold, 1, 0)
                .Item("ONHAND") = _onHand
                .Item("REMARKS") = _remarks
            End With
            ds.Tables(TABLE).Rows.Add(dsNewRow)
            isNew = True
        Else
            With ds.Tables(TABLE).Rows(0)
                .Item("ITEMCODE") = _itemCode
                .Item("DESCRIPTION") = _description
                .Item("CATEGORIES") = _category
                .Item("SUBCAT") = _subCat
                .Item("UOM") = _UoM
                .Item("UNITPRICE") = _unitPrice
                .Item("SALEPRICE") = _salePrice
                .Item("ISSALE") = If(_isSale, 1, 0)
                .Item("ISINV") = If(_isInv, 1, 0)
                .Item("ONHOLD") = If(_onHold, 1, 0)
                .Item("ONHAND") = _onHand
                .Item("REMARKS") = _remarks
                .Item("UPDATETIME") = Now()
            End With
        End If

        database.SaveEntry(ds, isNew)
    End Sub

    Public Overridable Sub LoadReader_Item(ByVal rd As IDataReader)
        On Error Resume Next

        With rd
            _itemID = .Item("ITEMID")
            _itemCode = .Item("ITEMCODE")
            _description = .Item("DESCRIPTION")
            _category = .Item("CATEGORIES")
            _subCat = .Item("SUBCAT")
            _UoM = .Item("UOM")
            _unitPrice = .Item("UNITPRICE")
            _salePrice = .Item("SALEPRICE")
            _isSale = IIf(.Item("ISSALE") = 1, True, False)
            _isInv = IIf(.Item("ISINV") = 1, True, False)
            _onHold = IIf(.Item("ONHOLD") = 1, True, False)
            _remarks = .Item("REMARKS")
            _onHand = .Item("ONHAND")
        End With
    End Sub

    Public Sub Load_ItemCode()
        mySql = String.Format("SELECT * FROM ITEMMASTER WHERE ITEMCODE = '{0}'", _itemCode)
        ds = New DataSet
        ds = LoadSQL(mySql)

        If ds.Tables(0).Rows.Count <> 1 Then
            'MsgBox("Failed to load ItemCode", MsgBoxStyle.Critical)
            Console.WriteLine("Failed to load ItemCode " & _itemCode)
            Exit Sub
        End If

        Load_ItemRow(ds.Tables(0).Rows(0))
    End Sub

    Private Sub Load_ItemRow(ByVal dr As DataRow)
        On Error Resume Next

        If hasLoaded Then Exit Sub

        With dr
            _itemID = .Item("ITEMID")
            _itemCode = .Item("ITEMCODE")
            _description = .Item("DESCRIPTION")
            _category = .Item("CATEGORIES")
            If Not IsDBNull(.Item("SUBCAT")) Then _subCat = .Item("SUBCAT")
            If Not IsDBNull(.Item("UOM")) Then _UoM = .Item("UOM")
            _unitPrice = .Item("UNITPRICE")
            _salePrice = .Item("SALEPRICE")
            _isSale = If(.Item("ISSALE") = 1, True, False)
            _isInv = If(.Item("ISINV") = 1, True, False)
            _onHold = If(.Item("ONHOLD") = 1, True, False)
            _onHand = .Item("ONHAND")
            If Not IsDBNull(.Item("remarks")) Then _remarks = .Item("remarks")
            hasLoaded = True
        End With
    End Sub

    Friend Function GetsystemEnding() As Double
        mySql = "SELECT * FROM ITEMMASTER WHERE ITEMID = " & _itemID
        Dim ds As DataSet = LoadSQL(mySql, "ITEMMASTER")

        If ds.Tables(0).Rows.Count = 0 Then Return 0
        Return ds.Tables(0).Rows(0).Item("OnHand")
    End Function

    Friend Sub SetActualToInventory(ByVal itmcode As String, ByVal Onhand As Double)
        mySql = "SELECT * FROM ITEMMASTER WHERE ITEMCODE ='" & itmcode & "'"
        Dim ds As DataSet = LoadSQL(mySql, "ITEMMASTER")

        ds.Tables(0).Rows(0).Item("OnHand") = Onhand
        database.SaveEntry(ds, False)
    End Sub
#End Region
End Class
