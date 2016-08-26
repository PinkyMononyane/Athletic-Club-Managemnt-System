Public Class Form3

    Public Sub btnSave2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave2.Click

        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub btnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel2.Click

        If txtEvent.Text > "" Then
            txtEvent.Text = txtEvent.Text.Substring(txtEvent.Text.Length)
            txtDateEvent.Text = txtDateEvent.Text.Substring(txtDateEvent.Text.Length)
            txtFee2.Text = txtFee2.Text.Substring(txtFee2.Text.Length)
            txtLocation.Text = txtLocation.Text.Substring(txtLocation.Text.Length)
            txtDistance.Text = txtDistance.Text.Substring(txtDistance.Text.Length)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtEvent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEvent.TextChanged

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim myDocument As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString()
        Dim FileToSaveAs As String = SaveFileDialog1.FileName
        Dim objwriter As New System.IO.StreamWriter(FileToSaveAs)
        objwriter.Write(txtEvent.Text)
        objwriter.Write(txtDateEvent.Text)
        objwriter.Write(txtFee2.Text)
        objwriter.Write(txtLocation.Text)
        objwriter.Write(txtDistance.Text)
        objwriter.Close()
    End Sub
End Class