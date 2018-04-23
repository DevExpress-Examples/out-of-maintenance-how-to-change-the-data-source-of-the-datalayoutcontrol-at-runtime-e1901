Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.IO
Imports System.Data.Common
Imports Q154615.nwindDataSetTableAdapters

Namespace Q154615
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			PopulateSelectDataSourceComboBox()
			PopulateTables()
		End Sub

		Private Sub PopulateSelectDataSourceComboBox()
			For Each table As DataTable In nwindDataSet.Tables
				cbeSelectDataSource.Properties.Items.Add(table.TableName)
			Next table
		End Sub

		Private Sub PopulateTables()
			categoriesTableAdapter.Fill(nwindDataSet.Categories)
			productsTableAdapter.Fill(nwindDataSet.Products)
			order_DetailsTableAdapter.Fill(nwindDataSet.Order_Details)
			ordersTableAdapter.Fill(nwindDataSet.Orders)
		End Sub

		Private Sub OnSelectedDataSourceChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeSelectDataSource.SelectedIndexChanged
			DoChangeDataSource((CType(sender, BaseEdit)).Text)
		End Sub

		Private Sub DoChangeDataSource(ByVal dataMember As String)
			If (Not String.IsNullOrEmpty(nwindBindingSource.DataMember)) Then
				layout.SaveLayoutToXml(GetLayoutPath(nwindBindingSource.DataMember))
			End If
			layout.Clear()
			nwindBindingSource.DataMember = dataMember
			layout.RetrieveFields()
			Dim layoutPath As String = GetLayoutPath(dataMember)
			If File.Exists(layoutPath) Then
				layout.RestoreLayoutFromXml(layoutPath)
			Else
				layout.ShowCustomizationForm()
			End If
		End Sub

		Private Function GetLayoutPath(ByVal dataMember As String) As String
			Return String.Format("..\..\{0}_layout.xml", dataMember)
		End Function
	End Class
End Namespace