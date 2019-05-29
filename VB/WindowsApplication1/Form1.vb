Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Private random As Random = New Random()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.ShowPrintPreview()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            productsBindingSource.DataSource = GetProductsDataTable()
        End Sub

        Private Function GetProductsDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Products"
            table.Columns.Add(New DataColumn("ProductName", GetType(String)))
            table.Columns.Add(New DataColumn("UnitPrice", GetType(Double)))
            table.Columns.Add(New DataColumn("UnitsOnOrder", GetType(Integer)))

            For i As Integer = 0 To 20 - 1
                Dim index As Integer = i + 1
                table.Rows.Add("Product " & index, Math.Round(random.NextDouble() * 1000, 2), random.[Next](0, 9) * 10)
            Next

            Return table
        End Function
    End Class
End Namespace
