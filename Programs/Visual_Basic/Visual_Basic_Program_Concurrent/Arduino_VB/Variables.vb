Imports System.IO.Ports
Imports System.IO


Module Variables

    Public Max_Time As Integer = 0
    Public Max_Reinforcers As Integer = 0
    
    Public Schedule_value As Integer = 0
    Public Schedule_value_2 As Integer = 0
    Public Schedule_Type As String = "NULL"
    Public Schedule_Type_2 As String = "NULL"
    Public Subject As String = "NULL"
    Public Communication_Port As String = "NULL"
    Public Session_Number As String = "NULL"

    Public x As Integer = 0
    Public x2 As Integer = 0

    Public Delay_requested As Integer = 0
    Public Delay_State As Boolean = False

    Public Iterations As Integer = 0
    Public Iterations_State As Boolean = False

    Public Iterations_2 As Integer = 0
    Public Iterations_State_2 As Boolean = False

End Module
