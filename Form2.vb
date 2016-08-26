Public Class Form2

    Private Sub Add_New_Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If txtFName.Text > "" Then
            txtFName.Text = txtFName.Text.Substring(txtFName.Text.Length)
            txtSurname.Text = txtSurname.Text.Substring(txtSurname.Text.Length)
            txtFees.Text = txtFees.Text.Substring(txtFees.Text.Length)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Dim myDocument As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim FileToSaveAs As String = SaveFileDialog1.FileName
        Dim objwriter As New System.IO.StreamWriter(FileToSaveAs)
        objwriter.Write(txtFName.Text)
        objwriter.Write(txtSurname.Text)
        objwriter.Write(txtFees.Text)
        objwriter.Write(birthDate.Text)
        objwriter.Write(joinDate.Text)
        objwriter.Write(radioF.Text)
        objwriter.Write(radioM.Text)
        objwriter.Close()


    End Sub

    Private Sub txtMembershipNum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMembershipNum.TextChanged

        If txtMembershipNum.Text = "" Then
            MessageBox.Show(
                "Membership Number cannot be empty.", "Entry Error")
            txtMembershipNum.Select()

        End If

    End Sub

    Private Function generateMemberNum(ByVal bDate As Date) As Long
        Dim yearPresent As String = Date.Today.Year().ToString().Substring(2, 2)
        Dim birthDate As String = bDate.Year.ToString() & bDate.Month.ToString().PadLeft(2, "0") & bDate

        Randomize()

        Dim value As Integer = CInt(Math.Floor((999)))
        Dim Info As String = yearPresent & birthDate & value.ToString()
        Dim checkDig As String = getcheckDig(Info)
        Dim number As Long = CLng(Info & checkDig)



        Return number

    End Function

    Private Function getcheckDig(ByVal InfoIn As String) As String
        Dim total As Integer = 0

        For Each bChar As Char In InfoIn
            total += CInt(bChar.ToString)
        Next

        If (total > 0) Then
            Dim numberMod As Integer = total Mod 10
            If (numberMod = 0) Then
                Return "0"
            Else
                Return (10 - numberMod).ToString()
            End If

        Else
            Return "0"
        End If
    End Function

    Private Function dateBirth() As Object
        Throw New NotImplementedException
    End Function

   
    Private Sub radioM_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioM.CheckedChanged
        radioM.Text = "Male"
    End Sub

    Private Sub radioF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioF.CheckedChanged
        radioF.Text = "Female"
    End Sub
End Class