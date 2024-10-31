<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lbl_res = New Label()
        txt_A = New TextBox()
        txt_B = New TextBox()
        btnplus = New Button()
        btnminus = New Button()
        btnmulti = New Button()
        btndiv = New Button()
        btnequal = New Button()
        btnres = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(99, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 41)
        Label1.TabIndex = 0
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(101, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 41)
        Label2.TabIndex = 1
        Label2.Text = "B"
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_res.ForeColor = SystemColors.ControlDarkDark
        lbl_res.Location = New Point(304, 222)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(149, 46)
        lbl_res.TabIndex = 2
        lbl_res.Text = "Résultat"
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(183, 88)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(270, 27)
        txt_A.TabIndex = 3
        ' 
        ' txt_B
        ' 
        txt_B.Location = New Point(183, 159)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(270, 27)
        txt_B.TabIndex = 4
        ' 
        ' btnplus
        ' 
        btnplus.BackColor = SystemColors.ActiveCaption
        btnplus.Location = New Point(85, 295)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(107, 47)
        btnplus.TabIndex = 5
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = False
        ' 
        ' btnminus
        ' 
        btnminus.BackColor = SystemColors.ActiveCaption
        btnminus.Location = New Point(251, 299)
        btnminus.Name = "btnminus"
        btnminus.Size = New Size(107, 47)
        btnminus.TabIndex = 6
        btnminus.Text = "-"
        btnminus.UseVisualStyleBackColor = False
        ' 
        ' btnmulti
        ' 
        btnmulti.BackColor = SystemColors.ActiveCaption
        btnmulti.Location = New Point(403, 299)
        btnmulti.Name = "btnmulti"
        btnmulti.Size = New Size(107, 47)
        btnmulti.TabIndex = 7
        btnmulti.Text = "*"
        btnmulti.UseVisualStyleBackColor = False
        ' 
        ' btndiv
        ' 
        btndiv.BackColor = SystemColors.ActiveCaption
        btndiv.Location = New Point(554, 299)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(107, 47)
        btndiv.TabIndex = 8
        btndiv.Text = "/"
        btndiv.UseVisualStyleBackColor = False
        ' 
        ' btnequal
        ' 
        btnequal.BackColor = SystemColors.ActiveCaption
        btnequal.Location = New Point(251, 366)
        btnequal.Name = "btnequal"
        btnequal.Size = New Size(107, 47)
        btnequal.TabIndex = 9
        btnequal.Text = "="
        btnequal.UseVisualStyleBackColor = False
        ' 
        ' btnres
        ' 
        btnres.BackColor = SystemColors.ActiveCaption
        btnres.Location = New Point(403, 366)
        btnres.Name = "btnres"
        btnres.Size = New Size(107, 47)
        btnres.TabIndex = 10
        btnres.Text = "Reset"
        btnres.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnres)
        Controls.Add(btnequal)
        Controls.Add(btndiv)
        Controls.Add(btnmulti)
        Controls.Add(btnminus)
        Controls.Add(btnplus)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(lbl_res)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_res As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents btnplus As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btnmulti As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnequal As Button
    Friend WithEvents btnres As Button

End Class
