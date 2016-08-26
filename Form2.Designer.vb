<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMembershipNum = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radioF = New System.Windows.Forms.RadioButton()
        Me.radioM = New System.Windows.Forms.RadioButton()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.lblDateJoin = New System.Windows.Forms.Label()
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lbl1stName = New System.Windows.Forms.Label()
        Me.joinDate = New System.Windows.Forms.DateTimePicker()
        Me.birthDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFees = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblAddnewMem = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMembershipNum)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.radioF)
        Me.GroupBox1.Controls.Add(Me.radioM)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblFees)
        Me.GroupBox1.Controls.Add(Me.lblDateJoin)
        Me.GroupBox1.Controls.Add(Me.lblDoB)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.lbl1stName)
        Me.GroupBox1.Controls.Add(Me.joinDate)
        Me.GroupBox1.Controls.Add(Me.birthDate)
        Me.GroupBox1.Controls.Add(Me.txtFees)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 416)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Member Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Membership No"
        '
        'txtMembershipNum
        '
        Me.txtMembershipNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembershipNum.Location = New System.Drawing.Point(160, 49)
        Me.txtMembershipNum.MaxLength = 14
        Me.txtMembershipNum.Name = "txtMembershipNum"
        Me.txtMembershipNum.Size = New System.Drawing.Size(437, 24)
        Me.txtMembershipNum.TabIndex = 17
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(522, 371)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radioF
        '
        Me.radioF.AutoSize = True
        Me.radioF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioF.Location = New System.Drawing.Point(294, 315)
        Me.radioF.Name = "radioF"
        Me.radioF.Size = New System.Drawing.Size(75, 22)
        Me.radioF.TabIndex = 15
        Me.radioF.TabStop = True
        Me.radioF.Text = "Female"
        Me.radioF.UseVisualStyleBackColor = True
        '
        'radioM
        '
        Me.radioM.AutoSize = True
        Me.radioM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioM.Location = New System.Drawing.Point(160, 315)
        Me.radioM.Name = "radioM"
        Me.radioM.Size = New System.Drawing.Size(58, 22)
        Me.radioM.TabIndex = 14
        Me.radioM.TabStop = True
        Me.radioM.Text = "Male"
        Me.radioM.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(22, 319)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(57, 18)
        Me.lblGender.TabIndex = 13
        Me.lblGender.Text = "Gender"
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.Location = New System.Drawing.Point(22, 260)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(124, 18)
        Me.lblFees.TabIndex = 12
        Me.lblFees.Text = "Fees Outstanding"
        '
        'lblDateJoin
        '
        Me.lblDateJoin.AutoSize = True
        Me.lblDateJoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateJoin.Location = New System.Drawing.Point(22, 217)
        Me.lblDateJoin.Name = "lblDateJoin"
        Me.lblDateJoin.Size = New System.Drawing.Size(90, 18)
        Me.lblDateJoin.TabIndex = 11
        Me.lblDateJoin.Text = "Joining Date"
        '
        'lblDoB
        '
        Me.lblDoB.AutoSize = True
        Me.lblDoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoB.Location = New System.Drawing.Point(22, 180)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(73, 18)
        Me.lblDoB.TabIndex = 10
        Me.lblDoB.Text = "Birth Date"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(22, 140)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(68, 18)
        Me.lblSurname.TabIndex = 9
        Me.lblSurname.Text = "Surname"
        '
        'lbl1stName
        '
        Me.lbl1stName.AutoSize = True
        Me.lbl1stName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1stName.Location = New System.Drawing.Point(22, 100)
        Me.lbl1stName.Name = "lbl1stName"
        Me.lbl1stName.Size = New System.Drawing.Size(81, 18)
        Me.lbl1stName.TabIndex = 8
        Me.lbl1stName.Text = "First Name"
        '
        'joinDate
        '
        Me.joinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.joinDate.Location = New System.Drawing.Point(160, 211)
        Me.joinDate.Name = "joinDate"
        Me.joinDate.Size = New System.Drawing.Size(437, 24)
        Me.joinDate.TabIndex = 7
        '
        'birthDate
        '
        Me.birthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthDate.Location = New System.Drawing.Point(160, 174)
        Me.birthDate.Name = "birthDate"
        Me.birthDate.Size = New System.Drawing.Size(437, 24)
        Me.birthDate.TabIndex = 6
        '
        'txtFees
        '
        Me.txtFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFees.Location = New System.Drawing.Point(160, 254)
        Me.txtFees.Name = "txtFees"
        Me.txtFees.Size = New System.Drawing.Size(437, 24)
        Me.txtFees.TabIndex = 5
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(160, 134)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(437, 24)
        Me.txtSurname.TabIndex = 4
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(160, 94)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(437, 24)
        Me.txtFName.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(348, 371)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Clear All"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(160, 371)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblAddnewMem
        '
        Me.lblAddnewMem.AutoSize = True
        Me.lblAddnewMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddnewMem.Location = New System.Drawing.Point(8, 18)
        Me.lblAddnewMem.Name = "lblAddnewMem"
        Me.lblAddnewMem.Size = New System.Drawing.Size(196, 25)
        Me.lblAddnewMem.TabIndex = 1
        Me.lblAddnewMem.Text = "Add New Member"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.InitialDirectory = "C:\Details"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 480)
        Me.Controls.Add(Me.lblAddnewMem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblAddnewMem As System.Windows.Forms.Label
    Friend WithEvents radioF As System.Windows.Forms.RadioButton
    Friend WithEvents radioM As System.Windows.Forms.RadioButton
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblFees As System.Windows.Forms.Label
    Friend WithEvents lblDateJoin As System.Windows.Forms.Label
    Friend WithEvents lblDoB As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lbl1stName As System.Windows.Forms.Label
    Friend WithEvents joinDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents birthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFees As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMembershipNum As System.Windows.Forms.TextBox
End Class
