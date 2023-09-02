Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.Data
Public Class FRM_PopupFormExcel
    Public Get_Data As New System.Data.DataTable
    Public selectedFilePath As String
    Private Sub FRM_PopupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub RunLoadExcel()
        If Not BackgroundWorker_excel.IsBusy Then
            BackgroundWorker_excel.RunWorkerAsync()
        End If
    End Sub
    Private Sub backgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_excel.DoWork
        ' Create an Excel Application instance
        Dim excelApp As New Excel.Application()
        ' Open the Excel workbook
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Open(selectedFilePath)
        ' Assuming you want to read the first worksheet in the workbook
        Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)
        ' Get the used range of the worksheet
        Dim usedRange As Excel.Range = worksheet.UsedRange
        ' Create a new DataTable to store the Excel data
        Dim dt As New Data.DataTable()
        ' Loop through each column in the header row and add them as columns in the DataTable
        For Each cell As Excel.Range In usedRange.Rows(1).Cells
            dt.Columns.Add(cell.Value.ToString())
        Next
        ' Loop through the rows starting from the second row (assuming the first row is headers)
        Dim all_row As Integer = usedRange.Rows.Count
        For row As Integer = 2 To usedRange.Rows.Count
            Dim pc As Integer = (row * 100) / all_row
            If pc > 100 Then
                pc = 100
            End If
            BackgroundWorker_excel.ReportProgress(pc)

            ' Create a new row in the DataTable
            Dim dataRow As DataRow = dt.NewRow()
            ' Loop through each cell in the row and add the cell value to the corresponding column in the DataTable
            For col As Integer = 1 To usedRange.Columns.Count
                dataRow(col - 1) = usedRange.Cells(row, col).Value
            Next
            ' Add the DataRow to the DataTable
            dt.Rows.Add(dataRow)
        Next

        ' Close the workbook and quit Excel
        workbook.Close(False)
        excelApp.Quit()

        ' Use the DataTable (dt) as needed
        ' For example, you can bind it to a DataGridView or process the data further.
        Get_Data = New Data.DataTable
        Get_Data = dt
        ' Clean up resources
        ReleaseComObject(worksheet)
        ReleaseComObject(workbook)
        ReleaseComObject(excelApp)

    End Sub
    Private Sub ReleaseComObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        Catch ex As Exception
            ' Handle the exception if needed
        Finally
            obj = Nothing
        End Try
    End Sub
    Private Sub backgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker_excel.ProgressChanged
        ' Update the progress bar value
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub backgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker_excel.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            ' Handle any errors that occurred during the background operation
            MessageBox.Show(e.Error.Message, "An error occurred: ")
        Else
            ' Access the result of the background operation
            Me.Close()
        End If
    End Sub

    Private Sub BT_Cancel_Click(sender As Object, e As EventArgs) Handles BT_Cancel.Click
        Try
            If BackgroundWorker_excel.WorkerSupportsCancellation = True Then
                ' Cancel the asynchronous operation.
                BackgroundWorker_excel.CancelAsync()
            End If
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub
End Class