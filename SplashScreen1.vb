'Author: Robert Zeelie
'Version: 1.0.00
'
'Description: A contacts application that stores the names, emails and countries of up to 10 different people and allows the user to lookup an address based on its index number. This is the splash screen.


Public NotInheritable Class SplashScreen1
    'declare progressbar value and original contact list
    Private iProgressBarValue As Integer = 0
    Public OriginalContactInfo(9, 3) As String

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'adds the information to the form
        ApplicationTitle.Text = "Contact List"
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        'Copyright info
        Copyright.Text = "Made by Robert Zeelie."

        'Defining the max and min for progress bar
        ProgressBar1.Maximum = 1000
        ProgressBar1.Minimum = 0

        'enable timer and set interval time
        Timer1.Enabled = True
        Timer1.Interval = 200
        Timer1.Start()

        'populate contact list with required info
        OriginalContactInfo = {
            {"Joseph", "Grant", "j.grant@gmail.com", "Switzerland"},
            {"Katie", "Jerad", "katie@jeradsolutions.com", "France"},
            {"Reuben", "Drake", "r.drake@gmail.com", "Germany"},
            {"Terry", "Wayne", "terry@wayneenterprises.com", "South Africa"},
            {"Angela", "Kobin", "kobin@kobincrafts.com", "Indonesia"},
            {"Tommy", "Baxton", "t.baxton@baxmedia.co.uk", "England"},
            {"Diane", "Leonard", "d.leonard@gmail.com", "USA"},
            {"Tim", "Folley", "folley.t@yahoo.com", "USA"},
            {"", "", "", ""},
            {"", "", "", ""}
            }

        'set form state
        Form1.FormState = "SplashScreen"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Increment by 1
        iProgressBarValue += 1

        'select case to move progress bar and finally stop
        Select Case iProgressBarValue
            Case 1, 3, 5, 7, 9,
                ProgressBar1.ForeColor = Color.White
                ProgressBar1.Value = (iProgressBarValue * 100)
            Case 2, 4, 6, 8, 10
                ProgressBar1.Value = (iProgressBarValue * 100)
            Case 13
                Timer1.Stop()
                Timer1.Enabled = False
                Form1.Show()
                Me.Close()
        End Select

    End Sub


End Class
