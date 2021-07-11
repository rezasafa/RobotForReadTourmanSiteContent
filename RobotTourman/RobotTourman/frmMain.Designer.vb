<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.nudEnd = New System.Windows.Forms.NumericUpDown()
        Me.nudStart = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.nudEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(12, 124)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(308, 72)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "شروع"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblCurrent
        '
        Me.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrent.Location = New System.Drawing.Point(12, 75)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(308, 46)
        Me.lblCurrent.TabIndex = 1
        Me.lblCurrent.Text = "1"
        Me.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudEnd
        '
        Me.nudEnd.Location = New System.Drawing.Point(200, 51)
        Me.nudEnd.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudEnd.Name = "nudEnd"
        Me.nudEnd.Size = New System.Drawing.Size(120, 21)
        Me.nudEnd.TabIndex = 2
        Me.nudEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudEnd.Value = New Decimal(New Integer() {6870, 0, 0, 0})
        '
        'nudStart
        '
        Me.nudStart.Location = New System.Drawing.Point(12, 51)
        Me.nudStart.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStart.Name = "nudStart"
        Me.nudStart.Size = New System.Drawing.Size(120, 21)
        Me.nudStart.TabIndex = 2
        Me.nudStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudStart.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(229, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "صفحه پایانی"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "صفحه شروع"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 208)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudStart)
        Me.Controls.Add(Me.nudEnd)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnStart)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "گرفتن تورها"
        CType(Me.nudEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lblCurrent As Label
    Friend WithEvents nudEnd As NumericUpDown
    Friend WithEvents nudStart As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
