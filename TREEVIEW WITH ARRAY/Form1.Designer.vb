<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dwarfplanet = New System.Windows.Forms.Button()
        Me.planet = New System.Windows.Forms.Button()
        Me.frsttreeview = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PLANET MOONTREE VIEW"
        '
        'dwarfplanet
        '
        Me.dwarfplanet.Location = New System.Drawing.Point(306, 143)
        Me.dwarfplanet.Name = "dwarfplanet"
        Me.dwarfplanet.Size = New System.Drawing.Size(181, 35)
        Me.dwarfplanet.TabIndex = 8
        Me.dwarfplanet.Text = "LOAD DWARF PLANET"
        Me.dwarfplanet.UseVisualStyleBackColor = True
        '
        'planet
        '
        Me.planet.Location = New System.Drawing.Point(339, 102)
        Me.planet.Name = "planet"
        Me.planet.Size = New System.Drawing.Size(129, 35)
        Me.planet.TabIndex = 7
        Me.planet.Text = "LOAD PALNETS"
        Me.planet.UseVisualStyleBackColor = True
        '
        'frsttreeview
        '
        Me.frsttreeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.frsttreeview.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frsttreeview.Location = New System.Drawing.Point(35, 78)
        Me.frsttreeview.Name = "frsttreeview"
        Me.frsttreeview.Size = New System.Drawing.Size(265, 595)
        Me.frsttreeview.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 712)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dwarfplanet)
        Me.Controls.Add(Me.planet)
        Me.Controls.Add(Me.frsttreeview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dwarfplanet As Button
    Friend WithEvents planet As Button
    Friend WithEvents frsttreeview As TreeView
End Class
