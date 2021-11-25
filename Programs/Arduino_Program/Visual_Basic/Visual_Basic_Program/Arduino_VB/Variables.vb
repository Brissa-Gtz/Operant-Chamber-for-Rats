Imports System.IO.Ports
Imports System.IO


Module Variables

    Public Max_Time As Integer = 0
    Public Max_Reinforcers As Integer = 0
    
    Public Schedule_value As Integer = 0
    Public Schedule_Type As String = "NULO"
    Public Subject As String = "NULO"
    Public Communication_Port As String = "NULO"
    Public Session_Number As String = "NULO"
    Public x As Integer = 0

    Public Delay_requested As Integer = 0
    Public Delay_State As Boolean = False

    Public Iterations As Integer = 0
    Public Iterations_State As Boolean = False


End Module
