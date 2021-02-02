<!-- default file list -->
*Files to look at*:

* [ViewerForm1.cs](./CS/CustomParametersExample/ViewerForm1.cs) (VB: [ViewerForm1.vb](./VB/CustomParametersExample/ViewerForm1.vb))
<!-- default file list end -->

# WinForms Dashboard - How to manage dashboard parameters in code 

The following example shows how to override an initial or user-defined [dashboard parameter](https://docs.devexpress.com/Dashboard/16135/creating-dashboards/creating-dashboards-in-the-winforms-designer/data-analysis/using-dashboard-parameters) value when you handle the [CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters) event.

The effective parameter value is hidden from a user, and if you set the [DashboardParameter.Visible](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter.Visible) property to _false_, the parameter will be hidden, too.

A parameter named _parameterState_ is added to the dashboard in code. It has a default value and a list of values to show in a look-up editor. A [Dashboard Parameters dialog](https://docs.devexpress.com/Dashboard/17632/winforms-dashboard/winforms-viewer/manage-dashboard-parameters) displays the values and allows a user to select a parameter value in the list. When you handle the **CustomParameters** event, you can validate the parameter value and ignore the value selected by the user. Use the _parameterState_ parameter to filter source data and change its value at runtime in the **CustomParameters** event handler, because the **CustomParameters** event occurs before the dashboard sends a query to a database. That means that only the value passed in the **CustomParameters** event is in effect.

**C#**

```cs
private void DashboardViewer_CustomParameters(object sender, CustomParametersEventArgs e) {
	var customParameter = e.Parameters.FirstOrDefault(p => p.Name == "parameterState");
	if (customParameter != null) {
		// Actual value used when retrieving data from the data source.
		customParameter.Value = "Nevada";
	}
}
```

**Visual Basic**

```vb
Private Sub DashboardViewer_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersEventArgs)
	Dim customParameter = e.Parameters.FirstOrDefault(Function(p) p.Name = "parameterState")
	If customParameter IsNot Nothing Then
		' Actual value used when retrieving data from the data source.
		customParameter.Value = "Nevada"
	End If
End Sub
```

![](/media/8133e08d-3d51-483d-920f-44f642b751cb.png)

## Documentation

- [WinForms Viewer - Manage Dashboard Parameters](https://docs.devexpress.com/Dashboard/17632/winforms-dashboard/winforms-viewer/manage-dashboard-parameters?p=netframework)
