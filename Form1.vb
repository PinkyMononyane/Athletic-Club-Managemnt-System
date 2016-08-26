Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        Dim myNewForm As New Form2
        myNewForm.ShowDialog()
    End Sub

    Private Sub AddNewEventToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEventToolStripMenuItem.Click
        Dim myNewForm1 As New Form3
        myNewForm1.ShowDialog()
    End Sub

    Private Sub EditExistingMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditExistingMemberToolStripMenuItem.Click
       
    End Sub

    Private Sub DeleteMemberToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteMemberToolStripMenuItem.Click

    End Sub

    Private Sub DeleteEventToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteEventToolStripMenuItem.Click
       
    End Sub
End Class
