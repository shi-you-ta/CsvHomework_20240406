Imports System.IO       'Fileを使うのに必要
Imports System.Text     'Encoding（テキストやデータを倍と列に変換する方法）を使うのに必要
Imports Csv


Public Class Form1
    '内部でデータを保持するテーブルを用意します
    '2つのイベントハンドラーのメソッドから呼び出されるのでクラスで定義
    Dim dataTable As New DataTable()

    'csv取得ボタンクリック時の処理
    Private Sub ButtonCSVRead_Click(sender As Object, e As EventArgs) Handles ButtonCSVRead.Click
        'ファイルを開くウィンドウでCSVファイルを選択し、OKボタンを押した時
        If (OpenFileDialogCsv.ShowDialog() = DialogResult.OK) Then
            'TextBoxInputCSVFileNameのtextにCSVファイル名を反映させる
            TextBoxInputCSVFileName.Text = OpenFileDialogCsv.FileName
            'ファイルの全内容を文字列に読み込む
            '日本語が読み込めるように文字はUTF-8でエンコードします。
            Dim csv = File.ReadAllText(OpenFileDialogCsv.FileName, Encoding.UTF8)
            dataTable.TableName = "CSVTable"              '内部でテーブルを生成します
            dataTable.Columns.Clear()                     '内部テーブルのヘッダーを初期化
            dataTable.Clear()                             '内部テーブルのデータを初期化

            'CSVのヘッダー部分のデータを取得し、内部のテーブルカラムに設定
            'csvから1行取得し、結果をline変数に入れる
            For Each line In CsvReader.ReadFromText(csv)
                '1行分のデータのヘッダーの情報を取り出す
                For Each item In line.Headers
                    dataTable.Columns.Add(item)         '内部テーブルのカラムに設定
                Next
                Exit For                                '2列目以降のデータもカラム名は同じなのでCSV読み込み終了
            Next

            '読み込んだcsvデータを内部テーブルに割り当てる
            'もう一度csvから1行取得し、結果をline変数に入れる
            For Each line In CsvReader.ReadFromText(csv)
                dataTable.Rows.Add(line.Values)         '1レコード分まとめて設定
            Next
            '表示用のDataGridViewに内部のテーブルを割り当てる
            DataGridViewCsv.DataSource = dataTable
        End If

    End Sub

    'CSV出力ボタンクリック時の処理
    Private Sub ButtonCsvWrite_Click(sender As Object, e As EventArgs) Handles ButtonCsvWrite.Click
        'ファイルを保存するウィンドウで選んだCSVファイルを選択し、OKボタンをクリックした時
        If (SaveFileDialogCsv.ShowDialog() = DialogResult.OK) Then
            'TextBoxOutputCSVFileNameのtextにCSVファイル名を反映させる
            TextBoxOutputCSVFileName.Text = SaveFileDialogCsv.FileName
            'headerという変数に内部のテーブルのカラム名を設定
            Dim header(dataTable.Columns.Count - 1) As String
            'カラムの数だけループしてカラムのデータを設定
            For i = 0 To dataTable.Columns.Count - 1
                header(i) = dataTable.Columns(i).ColumnName
            Next

            'newLineという変数に内部のテーブルを表のイメージ（2次元配列）で設定
            Dim newLine(dataTable.Rows.Count - 1)() As String
            'データの数分ループして、データを取得
            For i = 0 To dataTable.Rows.Count - 1
                ReDim newLine(i)(dataTable.Columns.Count - 1)
                '該当するカラム、列の値を内部のテーブルから、newLineに設定
                For j As Integer = 0 To dataTable.Columns.Count - 1
                    'Nothing（DBの値がnull）の場合、""としてnewLineを設定
                    newLine(i)(j) = IIf(Convert.IsDBNull(dataTable.Rows(i)(j)), "",
                                        dataTable.Rows(i)(j))
                Next
            Next
            'データからCSV形式の文字列を生成
            Dim outcsv = CsvWriter.WriteToText(header, newLine)
            'FileNameという名前で、outcsvの値を保存します。文字はUTF8でエンコードします。
            File.WriteAllText(SaveFileDialogCsv.FileName, outcsv, Encoding.UTF8)
        End If
    End Sub

    'CSV出力2ボタンクリック時の処理
    Private Sub ButtonCsvWrite2_Click(sender As Object, e As EventArgs) Handles ButtonCsvWrite2.Click
        'ファイルを保存するウィンドウで選んだCSVファイルを選択しOKをクリックする場合
        If (SaveFileDialogCsv.ShowDialog() = DialogResult.OK) Then
            'TextBoxOutputCSVFileName2のtextにCSVファイル名を反映させる
            TextBoxOutputCSVFileName2.Text = SaveFileDialogCsv.FileName
            'header2という変数に内部のテーブルのカラム名を設定
            Dim header2(dataTable.Columns.Count - 1) As String
            'カラムの数だけループしてカラムのデータを設定
            For i = 0 To dataTable.Columns.Count - 1
                header2(i) = dataTable.Columns(i).ColumnName
            Next

            'newLine2という変数に内部のテーブルを表のイメージ（2次元配列）で設定
            Dim newLine2(dataTable.Rows.Count)() As String

            'データの数分ループしてデータを取得
            For i = 0 To dataTable.Rows.Count - 1
                ReDim newLine2(i)(dataTable.Columns.Count - 1)
                For j = 0 To dataTable.Columns.Count - 1
                    'Nothing（DBの値がnullの場合）、""としてnewLine2を設定
                    newLine2(i)(j) = IIf(Convert.IsDBNull(dataTable.Rows(i)(j)), "", dataTable.Rows(i)(j))
                Next
            Next

            '各列の合計値を格納する配列
            Dim sumRow(dataTable.Columns.Count - 1) As String
            For i As Integer = 0 To dataTable.Columns.Count - 1
                Dim totalValue As Integer = 0
                For j As Integer = 0 To dataTable.Rows.Count - 1
                    '各列の合計値を計算
                    If Not Convert.IsDBNull(dataTable.Rows(j)(i)) Then
                        totalValue += Convert.ToInt32(dataTable.Rows(j)(i))
                    End If
                Next
                sumRow(i) = totalValue.ToString()
            Next
            newLine2(dataTable.Rows.Count) = sumRow

            'データからCSV形式の文字列を生成
            Dim outcsv2 = CsvWriter.WriteToText(header2, newLine2)
            'FileNameという名前で、outcsvの値を保存する。文字はUTF-8でエンコード
            File.WriteAllText(SaveFileDialogCsv.FileName, outcsv2, Encoding.UTF8)
        End If
    End Sub

End Class
