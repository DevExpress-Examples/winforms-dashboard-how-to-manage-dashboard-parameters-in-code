<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134061847/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T635871)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Dashboard for WinForms - How to manage dashboard parameters in code 

This example shows how to change a default or user-defined [dashboard parameter](https://docs.devexpress.com/Dashboard/16169) value in the [`DashboardViewer.CustomParameters`](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters) event handler. The effective parameter value is hidden from users. Set the [`Visible`](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter.Visible) property to `false` to hide the parameter from the **Dashboard Parameters** dialog.

In this example, the **parameterState** dashboard parameter with static look-up settings is added to the dashboard. This dashboard parameter is used to filter the data source. The [Dashboard Parameters](https://docs.devexpress.com/Dashboard/17632) dialog displays the values and enables users to select a parameter value from the list. In the [`DashboardViewer.CustomParameters`](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomParameters)) event handler, we can change the value supplied by the user before it is passed to the query.
In the result, the value defined in the `DashboardViewer.CustomParameters` event is in effect.

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

## Files to Review

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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-how-to-manage-dashboard-parameters-in-code&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-how-to-manage-dashboard-parameters-in-code&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
