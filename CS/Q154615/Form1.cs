using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.IO;
using System.Data.Common;
using Q154615.nwindDataSetTableAdapters;

namespace Q154615 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            PopulateSelectDataSourceComboBox();
            PopulateTables();
        }

        private void PopulateSelectDataSourceComboBox() {
            foreach (DataTable table in nwindDataSet.Tables)
                cbeSelectDataSource.Properties.Items.Add(table.TableName);
        }

        private void PopulateTables() {
            categoriesTableAdapter.Fill(nwindDataSet.Categories);
            productsTableAdapter.Fill(nwindDataSet.Products);
            order_DetailsTableAdapter.Fill(nwindDataSet.Order_Details);
            ordersTableAdapter.Fill(nwindDataSet.Orders);
        }

        private void OnSelectedDataSourceChanged(object sender, EventArgs e) {
            DoChangeDataSource(((BaseEdit)sender).Text);
        }

        private void DoChangeDataSource(string dataMember) {
            if (!string.IsNullOrEmpty(nwindBindingSource.DataMember))
                layout.SaveLayoutToXml(GetLayoutPath(nwindBindingSource.DataMember));
            layout.Clear(true, true);
            nwindBindingSource.DataMember = dataMember;
            layout.RetrieveFields();
            string layoutPath = GetLayoutPath(dataMember);
            if (File.Exists(layoutPath)) layout.RestoreLayoutFromXml(layoutPath);
            else layout.ShowCustomizationForm();
        }

        private string GetLayoutPath(string dataMember) { 
            return string.Format(@"..\..\{0}_layout.xml", dataMember); 
        }
    }
}