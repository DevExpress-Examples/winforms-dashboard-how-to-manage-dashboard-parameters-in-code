Imports DevExpress.XtraEditors
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.DashboardCommon

Namespace CustomParametersExample

    Public Partial Class ViewerForm1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            AddHandler dashboardViewer.CustomParameters, AddressOf DashboardViewer_CustomParameters
            dashboardViewer.DashboardSource = GetType(SampleDashboard)
            dashboardViewer.Dashboard.Parameters.Add(CreateParameter())
            dashboardViewer.Dashboard.DataSources(0).Filter = "[State] In (?parameterState)"
            dashboardViewer.ReloadData()
        End Sub

        Private Function CreateParameter() As DashboardParameter
            Dim myDashboardParameter As DashboardParameter = New DashboardParameter()
            Dim staticListLookUpSettings1 As StaticListLookUpSettings = New StaticListLookUpSettings()
            myDashboardParameter.AllowMultiselect = True
            ' Parameter values displayed in the look-up editor.
            staticListLookUpSettings1.Values = New String() {"Alabama", "Ohio", "Utah"}
            myDashboardParameter.LookUpSettings = staticListLookUpSettings1
            myDashboardParameter.Name = "parameterState"
            myDashboardParameter.Type = GetType(String)
            ' Default parameter value.
            myDashboardParameter.Value = New List(Of String) From {"Ohio", "Utah"}
            Return myDashboardParameter
        End Function

        Private Sub DashboardViewer_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersEventArgs)
            Dim customParameter = e.Parameters.FirstOrDefault(Function(p) Equals(p.Name, "parameterState"))
            If customParameter IsNot Nothing Then
                ' Actual value used when retrieving data from the data source.
                customParameter.Value = "Nevada"
            End If
        End Sub
    End Class
End Namespace
