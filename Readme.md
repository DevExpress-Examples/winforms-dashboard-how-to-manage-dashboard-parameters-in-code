<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061847/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T635871)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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

## Files to Review:

* [ViewerForm1.cs](./CS/CustomParametersExample/ViewerForm1.cs) (VB: [ViewerForm1.vb](./VB/CustomParametersExample/ViewerForm1.vb))

## Documentation

- [WinForms Viewer - Manage Dashboard Parameters](https://docs.devexpress.com/Dashboard/17632/winforms-dashboard/winforms-viewer/manage-dashboard-parameters)
- [Dashboard Parameters](https://docs.devexpress.com/Dashboard/116918)

## More Examples

* [How to: Pass a Dashboard Parameter to a Filter String in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-filter-string-in-code-e5117)
* [How to: Pass a Dashboard Parameter to a Calculated Field's Expression in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-calculated-fields-expression-in-code-e5135)
* [How to: Pass a Dashboard Parameter to a Custom SQL Query in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-custom-sql-query-in-code-e5120)
* [How to: Pass a Hidden Dashboard Parameter to a Custom SQL Query in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-pass-a-hidden-dashboard-parameter-to-a-custom-sql-query-in-the-winforms-viewer-t338459)
* [How to: Specify Default Parameter Values in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-specify-default-parameter-values-in-the-winforms-viewer-t475858)
* [How to: Use Dashboard Parameters with the Expression Format Condition](https://github.com/DevExpress-Examples/how-to-usedashboard-parameters-with-the-expressionformat-condition-t260065)
* [How to: Display the Others Slice in the Pie Chart](https://github.com/DevExpress-Examples/how-to-display-pie-chart-others-slice)
