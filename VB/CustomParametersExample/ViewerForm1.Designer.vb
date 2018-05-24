Namespace CustomParametersExample
    Partial Public Class ViewerForm1
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
            Me.dashboardViewer = New DevExpress.DashboardWin.DashboardViewer(Me.components)
            CType(Me.dashboardViewer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            ' dashboardViewer
            '
            Me.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardViewer.Location = New System.Drawing.Point(0, 0)
            Me.dashboardViewer.Name = "dashboardViewer"
            Me.dashboardViewer.Size = New System.Drawing.Size(986, 628)
            Me.dashboardViewer.TabIndex = 0
            '
            ' ViewerForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(986, 628)
            Me.Controls.Add(Me.dashboardViewer)
            Me.Name = "ViewerForm"
            Me.Text = "Dashboard Viewer"
            CType(Me.dashboardViewer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dashboardViewer As DevExpress.DashboardWin.DashboardViewer
    End Class
End Namespace

