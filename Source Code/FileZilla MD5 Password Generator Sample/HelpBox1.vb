Public NotInheritable Class HelpBox1

    Private Sub HelpBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = ApplicationTitle & " Help File"
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "General Help:"
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Help.txt") Then
            Me.TextBoxDescription.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Help.txt")
        Else
            Me.TextBoxDescription.Text = "No help file detected."
        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
