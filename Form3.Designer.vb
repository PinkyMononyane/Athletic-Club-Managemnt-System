<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtFee2 = New System.Windows.Forms.TextBox()
        Me.txtDateEvent = New System.Windows.Forms.TextBox()
        Me.txtEvent = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnCancel2)
        Me.GroupBox1.Controls.Add(Me.btnSave2)
        Me.GroupBox1.Controls.Add(Me.txtDistance)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.txtFee2)
        Me.GroupBox1.Controls.Add(Me.txtDateEvent)
        Me.GroupBox1.Controls.Add(Me.txtEvent)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 303)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Event Details"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(380, 259)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(257, 259)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel2.TabIndex = 11
        Me.btnCancel2.Text = "Clear All"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.Location = New System.Drawing.Point(132, 259)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(75, 23)
        Me.btnSave2.TabIndex = 10
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(132, 197)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(323, 21)
        Me.txtDistance.TabIndex = 9
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(132, 160)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(323, 21)
        Me.txtLocation.TabIndex = 8
        '
        'txtFee2
        '
        Me.txtFee2.Location = New System.Drawing.Point(133, 120)
        Me.txtFee2.Name = "txtFee2"
        Me.txtFee2.Size = New System.Drawing.Size(323, 21)
        Me.txtFee2.TabIndex = 7
        '
        'txtDateEvent
        '
        Me.txtDateEvent.Location = New System.Drawing.Point(133, 81)
        Me.txtDateEvent.Name = "txtDateEvent"
        Me.txtDateEvent.Size = New System.Drawing.Size(323, 21)
        Me.txtDateEvent.TabIndex = 6
        '
        'txtEvent
        '
        Me.txtEvent.Location = New System.Drawing.Point(133, 47)
        Me.txtEvent.Name = "txtEvent"
        Me.txtEvent.Size = New System.Drawing.Size(323, 21)
        Me.txtEvent.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Distance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Location of the Event"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Registration Fee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date of the Event"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Title of the Event"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add New Event"
        '
        'SaveFileDialog1
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtFee2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDateEvent As System.Windows.Forms.TextBox
    Friend WithEvents txtEvent As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel2 As System.Windows.Forms.Button
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
