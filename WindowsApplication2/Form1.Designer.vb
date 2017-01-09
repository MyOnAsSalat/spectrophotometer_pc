<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.SP = New System.IO.Ports.SerialPort(Me.components)
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.interval = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.start = New System.Windows.Forms.Button()
        Me.st = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.c, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB2
        '
        Me.TB2.AcceptsTab = True
        Me.TB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TB2.Location = New System.Drawing.Point(12, 12)
        Me.TB2.Multiline = True
        Me.TB2.Name = "TB2"
        Me.TB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TB2.Size = New System.Drawing.Size(251, 390)
        Me.TB2.TabIndex = 0
        '
        'TB1
        '
        Me.TB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TB1.Location = New System.Drawing.Point(357, 12)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(82, 31)
        Me.TB1.TabIndex = 2
        Me.TB1.Text = "COM5"
        '
        'T1
        '
        Me.T1.Interval = 250
        '
        'interval
        '
        Me.interval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.interval.Location = New System.Drawing.Point(269, 12)
        Me.interval.Name = "interval"
        Me.interval.Size = New System.Drawing.Size(82, 31)
        Me.interval.TabIndex = 4
        Me.interval.Text = "1"
        '
        'c
        '
        ChartArea8.Name = "ChartArea1"
        Me.c.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.c.Legends.Add(Legend8)
        Me.c.Location = New System.Drawing.Point(269, 51)
        Me.c.Margin = New System.Windows.Forms.Padding(2)
        Me.c.Name = "c"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series8.Legend = "Legend1"
        Series8.Name = "graph"
        Me.c.Series.Add(Series8)
        Me.c.Size = New System.Drawing.Size(558, 351)
        Me.c.TabIndex = 6
        Me.c.Text = "Chart1"
        '
        'start
        '
        Me.start.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.start.Location = New System.Drawing.Point(445, 12)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(87, 31)
        Me.start.TabIndex = 7
        Me.start.Text = "start"
        Me.start.UseVisualStyleBackColor = True
        '
        'st
        '
        Me.st.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st.Location = New System.Drawing.Point(538, 12)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(87, 31)
        Me.st.TabIndex = 8
        Me.st.Text = "stop"
        Me.st.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.save.Location = New System.Drawing.Point(631, 12)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(87, 31)
        Me.save.TabIndex = 9
        Me.save.Text = "save"
        Me.save.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 409)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.interval)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.TB2)
        Me.Name = "Form1"
        Me.Text = "Получения данных comport"
        CType(Me.c, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB2 As TextBox
    Friend WithEvents SP As IO.Ports.SerialPort
    Friend WithEvents TB1 As TextBox
    Friend WithEvents T1 As Timer
    Friend WithEvents interval As TextBox
    Friend WithEvents c As DataVisualization.Charting.Chart
    Friend WithEvents st As Button
    Friend WithEvents start As Button
    Friend WithEvents save As Button
    Friend WithEvents SFD1 As SaveFileDialog
End Class
