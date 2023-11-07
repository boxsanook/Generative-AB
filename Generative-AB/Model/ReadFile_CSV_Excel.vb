Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic.FileIO
Imports System.Data
Imports System.Data.OleDb

Public Class ReadFile_CSV_Excel


    Public Shared Function ReadCsvToDataTable(filePath As String, hasHeader As Boolean) As System.Data.DataTable
        Dim dataTable As New System.Data.DataTable()

        Using parser As New TextFieldParser(filePath)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters("|")

            ' Read the header if the CSV has one
            If hasHeader Then
                Dim headerFields As String() = parser.ReadFields()
                For Each headerField As String In headerFields
                    dataTable.Columns.Add(New DataColumn(headerField))
                Next
            Else
                ' If there's no header, create columns with default names like "Column1", "Column2", etc.
                Dim firstLineFields As String() = parser.ReadFields()
                For i As Integer = 0 To firstLineFields.Length - 1
                    dataTable.Columns.Add(New DataColumn("Column" & (i + 1).ToString()))
                Next
                ' Add the first line fields as data rows
                dataTable.Rows.Add(firstLineFields)
            End If

            ' Read the rest of the CSV data and add it as rows to the DataTable
            While Not parser.EndOfData
                Dim fields As String() = parser.ReadFields()
                dataTable.Rows.Add(fields)
            End While
        End Using

        Return dataTable
    End Function

    Public Shared Function ReadExcelToDataTable(filePath As String, sheetName As String) As System.Data.DataTable
        Dim dataTable As New System.Data.DataTable()

        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0;HDR=Yes;'"

        Using connection As New System.Data.OleDb.OleDbConnection(connectionString)
            connection.Open()

            Dim query As String = $"SELECT * FROM [{sheetName}$]"
            Using adapter As New OleDbDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using
        End Using

        Return dataTable
    End Function


    Public Shared Function ReadWorksheetToDataTable(selectedFilePath As String) As Data.DataTable
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

            Return rtnData
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Read Excel Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return rtnData
        End Try

    End Function
    Public Shared Function OpenExcelFile() As (Data.DataTable, String)
        Dim dataTable As New Data.DataTable()
        Dim filePath As String = Nothing
        Using openFileDialog As New OpenFileDialog()
            ' Set the file filter to show only Excel files
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"

            ' Show the OpenFileDialog and check if the user clicked "OK"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                filePath = openFileDialog.FileName

                ' Now you can call the function to read the Excel file into the DataTable
                dataTable = ReadWorksheetToDataTable(filePath) ' Replace "Sheet1" with the desired sheet name

                ' Optionally, you can do something with the dataTable here or return it.
            End If
        End Using

        Return (dataTable, filePath)
    End Function

    Public Shared Function OpenCsvFile() As (Data.DataTable, String)
        Dim dataTable As New Data.DataTable()
        Dim filePath As String = Nothing
        Using openFileDialog As New OpenFileDialog()
            ' Set the file filter to show only CSV files
            openFileDialog.Filter = "CSV Files|*.csv"

            ' Show the OpenFileDialog and check if the user clicked "OK"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                filePath = openFileDialog.FileName

                ' Now you can call the function to read the CSV file into the DataTable
                dataTable = ReadCsvToDataTable(filePath, hasHeader:=True) ' Set hasHeader to False if your CSV file doesn't have a header row

                ' Optionally, you can do something with the dataTable here or return it.
            End If
        End Using

        Return (dataTable, filePath)
    End Function

End Class
