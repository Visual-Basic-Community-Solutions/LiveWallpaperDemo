Imports LiveWallpaperEngine
Imports LiveWallpaperEngineRender.Renders

Public Class Form1
    Private VideoRender As VideoRender

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim screen = Windows.Forms.Screen.PrimaryScreen

        VideoRender = New VideoRender()

        VideoRender.Init(screen)
        VideoRender.Play("./Video.mp4")

        If Not LiveWallpaperEngineManager.Show(VideoRender, screen) Then
            MessageBox.Show("Failed to render wallpaper")
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        LiveWallpaperEngineManager.Close(VideoRender)
    End Sub
End Class

