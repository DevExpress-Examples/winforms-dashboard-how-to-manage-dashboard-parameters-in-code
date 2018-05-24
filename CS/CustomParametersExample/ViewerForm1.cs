using DevExpress.XtraEditors;
using System.Linq;
using System.Collections.Generic;
using DevExpress.DashboardCommon;

namespace CustomParametersExample
{
    public partial class ViewerForm1 : XtraForm
    {
        public ViewerForm1()
        {
            InitializeComponent();
            dashboardViewer.CustomParameters += DashboardViewer_CustomParameters;
            dashboardViewer.DashboardSource = typeof(SampleDashboard);

            AddParameter(dashboardViewer.Dashboard);
            dashboardViewer.Dashboard.DataSources[0].Filter = "[State] In (?parameterState)";
            dashboardViewer.ReloadData();
        }

        private void AddParameter(Dashboard dBoard)
        {
            DashboardParameter myDashboardParameter = new DashboardParameter();
            StaticListLookUpSettings staticListLookUpSettings1 = new StaticListLookUpSettings();
            myDashboardParameter.AllowMultiselect = true;
            // Parameter values displayed in the look-up editor.
            staticListLookUpSettings1.Values = new string[] {"Alabama", "Ohio", "Utah"};
            myDashboardParameter.LookUpSettings = staticListLookUpSettings1;
            myDashboardParameter.Name = "parameterState";
            myDashboardParameter.Type = typeof(string);
            // Default parameter value.
            myDashboardParameter.Value = new List<string> { "Ohio", "Utah" };
            dBoard.Parameters.Add(myDashboardParameter);
        }

        private void DashboardViewer_CustomParameters(object sender, CustomParametersEventArgs e)
        {
            var customParameter = e.Parameters.FirstOrDefault(p => p.Name == "parameterState");
            if (customParameter != null)
            {
                // Actual value used when retrieving data from the data source.
                customParameter.Value = "Nevada";
            }
        }
    }
}
