Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.Data
Imports DataTable = System.Data.DataTable

Module Module_Excel
    Public Function MasterExcel() As DataTable
        Dim MasterX As New DataTable("Excel Po No")
        ' Define columns for the DataTable 
        MasterX.Columns.Add("keyword", GetType(String))
        MasterX.Columns.Add("sub_keyword", GetType(String))
        MasterX.Columns.Add("prompt", GetType(String))
        MasterX.Columns.Add("prompt_loop", GetType(Integer))
        MasterX.Rows.Add("", "", "", "")

        Return MasterX
    End Function


    Public Sub ExportToExcel(ByVal dataGrid As DataGridView, filePath As String)
        ' Create a new Excel application
        Dim excelApp As New Excel.Application()
        ' Create a new workbook
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        ' Get the default worksheet
        Dim excelWorksheet As Excel.Worksheet = excelWorkbook.ActiveSheet
        ' Set the worksheet format to text
        excelWorksheet.Cells.NumberFormat = "@"
        ' Set the column headers in the worksheet
        For i As Integer = 0 To dataGrid.Columns.Count - 1
            excelWorksheet.Cells(1, i + 1) = dataGrid.Columns(i).HeaderText
        Next

        ' Set the data from the DataGridView to the worksheet
        For i As Integer = 0 To dataGrid.Rows.Count - 1
            For j As Integer = 0 To dataGrid.Columns.Count - 1
                excelWorksheet.Cells(i + 2, j + 1) = dataGrid.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        ' Save the workbook
        'Dim filePath As String = "C:\Path\To\Your\File.xlsx"
        excelWorkbook.SaveAs(filePath)

        ' Close the workbook and release resources
        excelWorkbook.Close()
        excelApp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        'MessageBox.Show("Working Finished.")
        Dim result As DialogResult = MessageBox.Show("Exported to Excel successfully." & vbNewLine & "คุณต้องการเปิดไฟล์หรือไม่?", "Finished  ", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' User clicked Yes, perform the desired action  
            Process.Start(filePath)
        ElseIf result = DialogResult.No Then
            ' User clicked No, handle the cancelation or alternative action
            ' ...
        End If

    End Sub

    Public Sub ExportDatatableToExcel(dt As DataTable, filePath As String)
        ' Create a new Excel application
        Dim excelApp As New Application()

        ' Create a new workbook and set it as the active workbook
        Dim workbook As Workbook = excelApp.Workbooks.Add()
        excelApp.Visible = False

        ' Get the first worksheet in the workbook
        Dim worksheet As Worksheet = workbook.ActiveSheet

        ' Write the column names to the first row of the worksheet
        For columnIndex As Integer = 0 To dt.Columns.Count - 1
            worksheet.Cells(1, columnIndex + 1) = dt.Columns(columnIndex).ColumnName
        Next

        ' Write the data to the worksheet
        For rowIndex As Integer = 0 To dt.Rows.Count - 1
            For columnIndex As Integer = 0 To dt.Columns.Count - 1
                Dim cell As Range = worksheet.Cells(rowIndex + 2, columnIndex + 1)
                cell.Value = dt.Rows(rowIndex)(columnIndex)

                ' Format the column as text if it matches a specific column name
                If dt.Columns(columnIndex).ColumnName = "ColumnNameToFormat" Then
                    cell.NumberFormat = "@"
                End If
            Next
        Next

        ' Save the workbook to the specified file path
        workbook.SaveAs(filePath)

        ' Close the workbook and Excel application
        workbook.Close()
        excelApp.Quit()

        ' Release the COM objects to avoid memory leaks
        ReleaseComObject(worksheet)
        ReleaseComObject(workbook)
        ReleaseComObject(excelApp)

        ' Display a message indicating the export is complete 
        'MessageBox.Show("Working Finished.")
        Dim result As DialogResult = MessageBox.Show("Exported to Excel successfully." & vbNewLine & "คุณต้องการเปิดไฟล์หรือไม่?", "Finished  ", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            ' User clicked Yes, perform the desired action  
            Process.Start(filePath)
        ElseIf result = DialogResult.No Then
            ' User clicked No, handle the cancelation or alternative action
            ' ...
        End If
    End Sub

    Private Sub ReleaseComObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        Catch ex As Exception
            ' Ignore the exception and continue
        Finally
            obj = Nothing
        End Try
    End Sub


    Public Function OpenFileExcel(selectedFilePath As String) As Data.DataTable
        Dim rtnData As New Data.DataTable()
        Try
            Dim excelApp As New Application()
            Dim workbookx As Workbook = excelApp.Workbooks.Open(selectedFilePath)
            'Dim excelApp As New Application()
            'Dim workbook As Workbook = excelApp.Workbooks.Open("C:\Path\To\Your\ExcelFile.xlsx")
            Dim sheetName As String = ""
            For Each worksheetx As Worksheet In workbookx.Worksheets
                sheetName = worksheetx.Name
                Console.WriteLine(sheetName)
            Next
            Dim worksheet As Worksheet = workbookx.Worksheets(sheetName)
            ' Get the used range of the worksheet
            Dim usedRange As Range = worksheet.UsedRange
            ' Create a new DataTable
            ' Iterate through each row in the used range
            For row As Integer = 1 To usedRange.Rows.Count
                ' Add columns to the DataTable based on the first row (header)
                If row = 1 Then
                    For column As Integer = 1 To usedRange.Columns.Count
                        Dim columnName As String = DirectCast(usedRange.Cells(row, column).Value, String)
                        rtnData.Columns.Add(columnName)
                    Next
                Else
                    ' Add rows to the DataTable
                    Dim dataRow As DataRow = rtnData.NewRow()
                    For column As Integer = 1 To usedRange.Columns.Count
                        dataRow(column - 1) = usedRange.Cells(row, column).Value
                    Next
                    rtnData.Rows.Add(dataRow)
                End If
            Next
            ' Close the workbook and quit Excel
            workbookx.Close()
            excelApp.Quit()

            '' Use the DataTable as needed
            'For Each dataRow As DataRow In dataTable.Rows
            '    For Each column As DataColumn In dataTable.Columns
            '        Console.Write(dataRow(column).ToString() & " ")
            '    Next
            '    Console.WriteLine()
            'Next
            Return rtnData
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Read Excel Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return rtnData
        End Try

    End Function


End Module
