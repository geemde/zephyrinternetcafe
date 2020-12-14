<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manager_TransactionReportManagement
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 553)
        Me.Panel1.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(62, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(228, 49)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Transaction Report Management"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(62, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(228, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Computer Management"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(62, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(228, 33)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Shop Item Management"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(228, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "User Management"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Zephyr"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(203, 505)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 33)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Add"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(384, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(675, 379)
        Me.DataGridView1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Transaction Report Management"
        '
        'manager_TransactionReportManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 549)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "manager_TransactionReportManagement"
        Me.Text = "manager_TransactionReportManagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
End Class
