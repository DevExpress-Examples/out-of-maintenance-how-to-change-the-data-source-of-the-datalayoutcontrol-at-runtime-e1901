<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q154615/Form1.cs) (VB: [Form1.vb](./VB/Q154615/Form1.vb))
<!-- default file list end -->
# How to change the data source of the DataLayoutControl at runtime


<p>Usually, to display different data based on the user choice, the predefined UserControls are used to display data in the most convenient manner for the end user. This sample, demonstrates how a single DataLayoutControl can be used for this purpose.</p>


<h3>Description</h3>

<p>In this example, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraDataLayoutDataLayoutControl_RetrieveFieldstopic">DataLayoutControl.RetrieveFields</a> method is used to populate the DataLayoutControl with items, when the data source is changed. By default, items are placed in one column. The user can customize the layout, and it will be saved when another data table is selected, and restored again for the same data table. The <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraLayoutLayoutControl_SaveLayoutToXmltopic">DataLayoutControl.SaveLayoutToXml</a> and <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraLayoutLayoutControl_RestoreLayoutFromXmltopic">DataLayoutControl.RestoreLayoutFromXml</a> methods are used for this purpose.</p>

<br/>


