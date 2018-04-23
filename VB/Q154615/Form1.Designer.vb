Namespace Q154615
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.cbeSelectDataSource = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.nwindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New Q154615.nwindDataSet()
            Me.categoriesTableAdapter = New Q154615.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.productsTableAdapter = New Q154615.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.order_DetailsTableAdapter = New Q154615.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
            Me.ordersTableAdapter = New Q154615.nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.cbeSelectDataSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layout, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' cbeSelectDataSource
            ' 
            Me.cbeSelectDataSource.Location = New System.Drawing.Point(103, 583)
            Me.cbeSelectDataSource.Name = "cbeSelectDataSource"
            Me.cbeSelectDataSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeSelectDataSource.Properties.ValidateOnEnterKey = True
            Me.cbeSelectDataSource.Size = New System.Drawing.Size(617, 20)
            Me.cbeSelectDataSource.StyleController = Me.layoutControl1
            Me.cbeSelectDataSource.TabIndex = 1
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.DataSource = Me.nwindBindingSource
            Me.dataNavigator1.Location = New System.Drawing.Point(7, 7)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(600, 19)
            Me.dataNavigator1.StyleController = Me.layoutControl1
            Me.dataNavigator1.TabIndex = 1
            Me.dataNavigator1.Text = "dataNavigator1"
            ' 
            ' nwindBindingSource
            ' 
            Me.nwindBindingSource.DataSource = Me.nwindDataSet
            Me.nwindBindingSource.Position = 0
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' order_DetailsTableAdapter
            ' 
            Me.order_DetailsTableAdapter.ClearBeforeFill = True
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.layout)
            Me.layoutControl1.Controls.Add(Me.cbeSelectDataSource)
            Me.layoutControl1.Controls.Add(Me.dataNavigator1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup4
            Me.layoutControl1.Size = New System.Drawing.Size(726, 609)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4"
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(726, 609)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "layoutControlGroup4"
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbeSelectDataSource
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 576)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(724, 31)
            Me.layoutControlItem1.Text = "Select Data Source"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(91, 20)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.dataNavigator1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(724, 30)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layout
            ' 
            Me.layout.DataSource = Me.nwindBindingSource
            Me.layout.Location = New System.Drawing.Point(7, 37)
            Me.layout.Name = "layout"
            Me.layout.Root = Me.layoutControlGroup1
            Me.layout.Size = New System.Drawing.Size(713, 535)
            Me.layout.TabIndex = 5
            Me.layout.Text = "dataLayoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(713, 535)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.layout
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 30)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(724, 546)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(726, 609)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.cbeSelectDataSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layout, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
        Private nwindDataSet As nwindDataSet
        Private nwindBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents cbeSelectDataSource As DevExpress.XtraEditors.ComboBoxEdit
        Private categoriesTableAdapter As Q154615.nwindDataSetTableAdapters.CategoriesTableAdapter
        Private productsTableAdapter As Q154615.nwindDataSetTableAdapters.ProductsTableAdapter
        Private order_DetailsTableAdapter As Q154615.nwindDataSetTableAdapters.Order_DetailsTableAdapter
        Private ordersTableAdapter As Q154615.nwindDataSetTableAdapters.OrdersTableAdapter
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private layout As DevExpress.XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

    End Class
End Namespace

