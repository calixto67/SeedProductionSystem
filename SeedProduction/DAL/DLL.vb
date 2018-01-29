Imports System
Imports System.Collections.Generic
Imports SeedProduction
Imports System.Data.SqlClient
Imports System.Linq


Public Class DLL

    Public Enum CRUDCode
        Create
        Retrieve
        Update
        Delete
    End Enum
    Public Property SPName As String
    Public Property SQLQuery As String
    Public Property SPParameters As Object
    Public Property CRUD As CRUDCode

    Public ReadOnly Property ConnectionString As String
        Get
            Return My.Settings.ProductionConnection
        End Get
    End Property

    Public ReadOnly Property CRUDCodeMode As DataTable
        Get

            Dim dt As New DataTable
            Dim dr As SqlDataReader

            Try
                Dim conn As New SqlConnection(ConnectionString)
                conn.Open()

                Dim cmd As New SqlCommand(SPName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CRUDCode", CRUD.ToString().First)
                cmd.Parameters.AddWithValue("@UserID", UserAccessed.ID)
                cmd.CommandTimeout = 0

                If Not IsNothing(SPParameters) Then
                    For Each var In SPParameters(0)
                        If Not IsNothing(var) Then
                            Select Case var(1).GetType()
                                Case GetType(String)
                                    cmd.Parameters.AddWithValue(var(0).ToString(), var(1).ToString())
                                Case GetType(Integer)
                                    cmd.Parameters.AddWithValue(var(0).ToString(), var(1))
                            End Select
                        End If
                    Next
                End If

                dr = cmd.ExecuteReader
                dt.Load(dr)
                dr.Close()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error Desciption: " + ex.Message, "ERROR Encountered while execution", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Throw ex
            End Try
            

            Return dt
        End Get
    End Property

    Public ReadOnly Property ExecuteSQLQuery As DataTable
        Get
            Dim dt As New DataTable
            Dim dr As SqlDataReader

            Try

                Dim conn As New SqlConnection(ConnectionString)
                conn.Open()

                Dim cmd As New SqlCommand(SQLQuery, conn)
                cmd.CommandType = CommandType.Text
                cmd.CommandTimeout = 0

                dr = cmd.ExecuteReader
                dt.Load(dr)
                dr.Close()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error Desciption: " + ex.Message, "ERROR Encountered while execution", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Throw ex
            End Try
            Return dt
        End Get
    End Property

    Public ReadOnly Property ExecuteStoredProcedure As DataTable
        Get

            Dim dt As New DataTable
            Dim dr As SqlDataReader

            Try
                Dim conn As New SqlConnection(ConnectionString)
                conn.Open()

                Dim cmd As New SqlCommand(SPName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 0

                If Not IsNothing(SPParameters) Then
                    For Each var As List(Of Object) In SPParameters
                        If Not IsNothing(var.ToArray()(1)) Then
                            Select Case var.ToArray()(1).GetType()
                                Case GetType(String)
                                    cmd.Parameters.AddWithValue(var.ToArray()(0).ToString(), var.ToArray()(1).ToString())
                            End Select
                        End If
                    Next
                End If

                dr = cmd.ExecuteReader
                dt.Load(dr)
                dr.Close()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error Desciption: " + ex.Message, "ERROR Encountered while execution", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Throw ex
            End Try

            Return dt
        End Get
    End Property



End Class
