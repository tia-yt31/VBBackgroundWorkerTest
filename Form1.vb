Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For I As Integer = 1 To 100
            System.Threading.Thread.Sleep(200)
            BackgroundWorker1.ReportProgress(I)
        Next
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        btnStart.Enabled = True
    End Sub

End Class
