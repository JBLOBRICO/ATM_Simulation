Imports MySql.Data.MySqlClient

Public Class frmMiniStatement

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmMiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMiniStatement()
    End Sub

    Private Sub LoadMiniStatement()
        Try
            connection() ' tawag sa dbConnection.connection()

            sql = "SELECT Date, Type, Amount, BalanceAfter 
                   FROM Transactions 
                   WHERE AccountNum = @acc 
                   ORDER BY Date DESC 
                   LIMIT 5"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@acc", LoggedInAccNum)

            dr = cmd.ExecuteReader()

            lstMiniStatement.Items.Clear()
            lstMiniStatement.Items.Add("Date" & vbTab & "Type" & vbTab & "Amount" & vbTab & "Balance")

            While dr.Read()
                Dim line As String = dr("Date").ToString() & vbTab &
                                     dr("Type").ToString() & vbTab &
                                     dr("Amount").ToString() & vbTab &
                                     dr("BalanceAfter").ToString()

                lstMiniStatement.Items.Add(line)
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading mini statement: " & ex.Message)
        End Try
    End Sub

End Class
