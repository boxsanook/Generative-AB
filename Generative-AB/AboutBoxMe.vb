Imports System.Deployment.Application
Imports System.Reflection

Public NotInheritable Class AboutBoxMe

    Private Sub AboutBoxMe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "Description :

(At runtime, the labels' text will be replaced with the application's assembly information.
Customize the application's assembly information in the Application pane of Project Designer.)"


        If ApplicationDeployment.IsNetworkDeployed Then
            Dim publishedVersion As Version = ApplicationDeployment.CurrentDeployment.CurrentVersion
            Dim versionString As String = publishedVersion.ToString()
            Console.WriteLine("Published Version: " & versionString)
            Me.LabelVersion.Text = String.Format("Published Version: {0}", versionString)
            ' You can use the 'versionString' variable in your application as needed.
        Else
            Dim version As Version = Assembly.GetEntryAssembly().GetName().Version
            Dim publishedVersion As String = version.ToString()
            Me.LabelVersion.Text = publishedVersion
            Console.WriteLine("Published Version: " & publishedVersion)
            Me.LabelVersion.Text = String.Format("Published Version: {0}", publishedVersion)
            Console.WriteLine("This application is not ClickOnce deployed.")
        End If


    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
