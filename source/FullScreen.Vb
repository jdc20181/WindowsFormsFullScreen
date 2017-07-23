'Read Setup.md for setup instructions









Public Sub MakeFullScreen()
        Me.SetVisibleCore(False)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.SetVisibleCore(True)
    End Sub
    
Public Sub ExitFullScreen()
        Me.WindowState = FormWindowState.Normal
        Me.Size = New Drawing.Size(1446, 772)  ' MaximumSize
        FormBorderStyle = FormBorderStyle.Sizable
        Fullscreen.Visible = True
        ControlBox = True
        Me.TopMost = False
   End Sub
