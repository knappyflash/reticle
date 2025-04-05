Imports System.Data.Sql
Imports System.Data.SQLite
Public Class MySQLite_db

    Public Sub New()

    End Sub

    Public Sub Save_to_Database()

    End Sub

    Public Sub Load_From_Database(ByRef MyX As Long, ByRef MyY As Long, ByRef MySize As Long, ByRef ScreenIndex As Integer)
        ' Define the connection string (adjust the file path as needed)
        Dim connectionString As String = "Data Source=save_file.db;Version=3;"

        Try
            ' Create and open a connection to the database
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Define a query to fetch data
                Dim query As String = "SELECT * FROM save_file"

                ' Create a SQLiteCommand to execute the query
                Using command As New SQLiteCommand(query, connection)
                    ' Execute the command and retrieve data using SQLiteDataReader
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Access column data using reader(columnIndex or columnName)
                            MyX = reader("X").ToString()
                            MyY = reader("Y").ToString()
                            MySize = reader("Size")
                            ScreenIndex = reader("Screen_Index")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Save_To_Database(ByVal MyX As Long, ByVal MyY As Long, ByVal MySize As Long, ByVal ScreenIndex As Integer)
        ' Define the connection string (adjust the file path as needed)
        Dim connectionString As String = "Data Source=save_file.db;Version=3;"

        Try
            ' Create and open a connection to the database
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                ' Define the UPDATE query
                Dim query As String = "
                    UPDATE save_file SET 
                    X = @X, 
                    Y = @Y, 
                    Size = @Size,
                    Screen_Index = @Screen_Index
                    WHERE ROWID = (SELECT ROWID FROM save_file LIMIT 1);
                "

                ' Create a SQLiteCommand to execute the query
                Using command As New SQLiteCommand(query, connection)
                    ' Bind parameters to the query
                    command.Parameters.AddWithValue("@X", MyX)
                    command.Parameters.AddWithValue("@Y", MyY)
                    command.Parameters.AddWithValue("@Size", MySize)
                    command.Parameters.AddWithValue("@Screen_Index", ScreenIndex)

                    ' Execute the command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Console.WriteLine($"Rows updated: {rowsAffected}")
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub


End Class
