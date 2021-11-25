
Imports System.IO.Ports
Imports System.IO
Imports System.Math
Imports System.Random

Public Class session

    Public Max_Time_X As Integer = 0
    Public Max_Reinforcers_X As Integer = 0

    Public Schedule_Value_X As Integer = 0
    Public Schedule_Type_X As String = "NULL"
    Public Schedule_Value_X2 As Integer = 0
    Public Schedule_Type_X2 As String = "NULL"

    Public Subject_X As String = "NULL"
    Public Communication_Port_X As String = "NULL"
    Public Session_Number_X As String = "NULL"
    Public Iterator_X As Integer = 0
    Public Iterator_X2 As Integer = 0

    Public Time_start As Integer = 0

    Public Total_Reinforcers As Integer = 0
    Public Response_Counter As Integer = 0
    Public Total_Responses As Integer = 0
    Public Period_Start As Integer = 0
    Public Period_End As Integer = 0
    Public Total_Reinforcers2 As Integer = 0
    Public Response_Counter2 As Integer = 0
    Public Total_Responses2 As Integer = 0
    Public Period_Start2 As Integer = 0
    Public Period_End2 As Integer = 0


    Public Time_End As Integer = 0

    Public Previous_Response As Integer = 0
    Public Actual_Response As Integer = 0
    Public Active As Boolean = True

    Public Previous_Response2 As Integer = 0
    Public Actual_Response2 As Integer = 0
    Public Active2 As Boolean = True
    Dim Data_Array(2) As String

    Public Value_Variable As Integer = 0
    Public v As Integer = 0
    Public n As Integer = 0
    Public order As Integer = 0
    Public Iteration_Variable As Integer = 0
    Public rd(5) As Integer
    Public vi(5) As Double

    Public Value_Variable2 As Integer = 0
    Public v2 As Integer = 0
    Public n2 As Integer = 0
    Public order2 As Integer = 0
    Public Iteration_Variable2 As Integer = 0
    Public rd2(5) As Integer
    Public vi2(5) As Double

    Public Delay_start As Integer = 0
    Public End_Delay As Integer = 0
    Public Delay_requested_X As Integer = 0
    Public Reinforcer_Availability As Boolean = False
    Public DELAYED As Boolean = False
    Public Delay_State_X As Boolean = False

    Public Iterations_X As Integer = 0
    Public Iterations_State_X As Boolean = False
    Public Sumxser As Integer = 0
    Public Iterations_X2 As Integer = 0
    Public Iterations_State_X2 As Boolean = False
    Public Sumxser2 As Integer = 0

    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Integer) As Boolean

    Public Arduino As SerialPort
    Public Arduino_State As Boolean = False
    Public Arduino_string As String = ""

    Function Open_Arduino() As Boolean
        Try
            Arduino = New SerialPort(Communication_Port_X, 9600)
        Catch ex As Exception
            MsgBox("ERROR: COM port not selected", MsgBoxStyle.Critical)
            End
        End Try
        Try
            Arduino.Open()
        Catch ex As Exception
            MsgBox("ERROR: Please connect an Arduino board", MsgBoxStyle.Critical)
            End
        End Try

        Arduino.WriteLine("S")
        Arduino_State = True

        Return Arduino_State
    End Function

    Function Close_Arduino() As Boolean

        Arduino.WriteLine("E")
        Arduino.Close()
        Arduino_State = False
        Return Arduino_State

    End Function

    Function Read_arduino() As String

        If Arduino.BytesToRead > 0 Then
            Arduino_string = Arduino.ReadLine()
        End If
        Return Arduino_string

    End Function


    Function Data_Handling() As Integer

        Try
            Data_Array = Split(Arduino_string, ",")

            Actual_Response = Convert.ToInt32(Data_Array(0))

            Actual_Response2 = Convert.ToInt32(Data_Array(1))

            If (Actual_Response <> Previous_Response And Actual_Response <> 1) Then

                TXT.WriteLine(Time_in_miliseconds() & ".100")
                Response_Counter = Response_Counter + 1

                Total_Responses = Total_Responses + 1
            End If


            If (Actual_Response <> Previous_Response And Actual_Response <> 0) Then

            End If

            Schedule_of_Reinforcement()
            Previous_Response = Actual_Response

            If (Actual_Response2 <> Previous_Response2 And Actual_Response2 <> 1) Then

                TXT.WriteLine(Time_in_miliseconds() & ".300")
                Response_Counter2 = Response_Counter2 + 1

                Total_Responses2 = Total_Responses2 + 1
            End If

            If (Actual_Response2 <> Previous_Response2 And Actual_Response2 <> 0) Then

            End If

            Schedule_of_Reinforcement2()
            Previous_Response2 = Actual_Response2

        Catch ex As Exception

        End Try
        Return (Total_Responses)
    End Function

    Function Start() As Integer

        Max_Time_X = Max_Time
        Max_Reinforcers_X = Max_Reinforcers


        Schedule_Value_X = Schedule_value
        Schedule_Type_X = Schedule_Type

        Schedule_Value_X2 = Schedule_value_2
        Schedule_Type_X2 = Schedule_Type_2


        Subject_X = Subject
        Communication_Port_X = Communication_Port
        Session_Number_X = Session_Number
        Delay_requested_X = Delay_requested
        Delay_State_X = Delay_State


        Iterations_X = Iterations
        Iterations_State_X = Iterations_State
        Iterator_X = x

        Iterations_X2 = Iterations_2
        Iterations_State_X2 = Iterations_State_2
        Iterator_X2 = x2

        Show()
        DelayMarker.Visible = False
        btnfin.Enabled = False
        My.Application.DoEvents()
        Open_Arduino()

        Subjectlbl.Text = Subject_X
        Sesiónlbl.Text = Session_Number_X
        portlbl.Text = Communication_Port_X

        Enabled = True
        DelayMarker.Visible = False
        Start_Chronometers()
        Initialize_File_Writing()

        Do

            Text = Communication_Port_X
            Datport.Text = Read_arduino()


            Generate_Interval()

            Generate_Interval2()


            Data_Handling()

            Delay()
            'algo hay que hacer
            RespTlbl2.Text = Total_Responses2
            TimeTlbl.Text = Time_in_seconds()
            RespTlbl.Text = Total_Responses
            REFlbl.Text = Total_Reinforcers
            REFlbl2.Text = Total_Reinforcers2

            If Total_Reinforcers + Total_Reinforcers2 >= Max_Reinforcers_X Then Exit Do
            If Time_in_seconds() >= Max_Time_X Then Exit Do
            If GetAsyncKeyState(Keys.Escape) Then Exit Do



            My.Application.DoEvents()
        Loop

        Close_Arduino()
        End_File_Writing()
        btnfin.Enabled = True


        Do While Active = True
            My.Application.DoEvents()
        Loop



        Return 0


    End Function

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click

        Active = False
        Close()
        Total_Responses = 0
        Response_Counter = 0
        Response_Counter2 = 0
        Total_Reinforcers = 0
        Arduino.Close()

    End Sub

    Private Sub Reinfbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reinfbtn.Click
        Arduino.WriteLine("R")
        TXT.WriteLine(Time_in_miliseconds() & ".555")
        Total_Reinforcers = Total_Reinforcers + 1
        Response_Counter = 0
        Period_Start = Environment.TickCount

    End Sub

    Function Reinforce() As Integer

        Arduino.WriteLine("R")
        TXT.WriteLine(Time_in_miliseconds() & ".500")
        Total_Reinforcers = Total_Reinforcers + 1
        DELAYED = False
        Reinforcer_Availability = False

        Return 0

    End Function

    Function Reinforce2() As Integer

        Arduino.WriteLine("R")
        TXT.WriteLine(Time_in_miliseconds() & ".700")
        Total_Reinforcers2 = Total_Reinforcers2 + 1
        DELAYED = False
        Reinforcer_Availability = False

        Return 0

    End Function

    Function Schedule_of_Reinforcement() As Integer

        If Schedule_Type_X = "FIXED RATIO" Then

            If Response_Counter >= Schedule_Value_X And Actual_Response <> 1 Then
                If Delay_State_X = True Then
                    Activate_delay()
                End If

                If Delay_State_X = False Then

                    Reinforce()
                    Response_Counter = 0
                    Period_Start = Environment.TickCount
                End If

            End If

        End If

        If Schedule_Type_X = "VARIABLE RATIO" Then

            If Response_Counter >= rd(Value_Variable) And Actual_Response <> 1 And Response_Counter >= 1 Then

                If Delay_State_X = True Then
                    Activate_delay()
                    Value_Variable = Value_Variable + 1
                End If

                If Delay_State_X = False Then

                    Reinforce()
                    Response_Counter = 0
                    Period_Start = Environment.TickCount
                    Value_Variable = Value_Variable + 1

                End If

            End If

        End If


        If Schedule_Type_X = "FIXED INTERVAL" Then
            If Time_of_the_Period() >= (Schedule_Value_X * 1000) And Actual_Response <> Previous_Response And Actual_Response <> 1 Then
                If Delay_State_X = True Then
                    Activate_delay()
                End If

                If Delay_State_X = False Then

                    Reinforce()
                    Response_Counter = 0
                    Period_Start = Environment.TickCount
                End If
            End If
        End If

        If Schedule_Type_X = "VARIABLE INTERVAL" Then
            If Time_of_the_Period() >= (rd(Value_Variable)) And Actual_Response <> 1 And Actual_Response <> Previous_Response Then
                If Delay_State_X = True Then
                    Activate_delay()
                    Value_Variable = Value_Variable + 1
                End If

                If Delay_State_X = False Then


                    Reinforce()
                    Response_Counter = 0
                    Period_Start = Environment.TickCount
                    Value_Variable = Value_Variable + 1
                End If
            End If
        End If

        Return 0

    End Function

    Function Schedule_of_Reinforcement2() As Integer

        If Schedule_Type_X2 = "FIXED RATIO" Then

            If Response_Counter2 >= Schedule_Value_X2 And Actual_Response2 <> 1 Then
                If Delay_State_X = True Then
                    Activate_delay()
                End If

                If Delay_State_X = False Then

                    Reinforce2()
                    Response_Counter2 = 0
                    Period_Start2 = Environment.TickCount
                End If

            End If

        End If

        If Schedule_Type_X2 = "VARIABLE RATIO" Then

            If Response_Counter2 >= rd2(Value_Variable2) And Actual_Response2 <> 1 And Response_Counter2 >= 1 Then

                If Delay_State_X = True Then
                    Activate_delay()
                    Value_Variable2 = Value_Variable2 + 1
                End If

                If Delay_State_X = False Then

                    Reinforce2()
                    Response_Counter2 = 0
                    Period_Start2 = Environment.TickCount
                    Value_Variable2 = Value_Variable2 + 1

                End If

            End If

        End If


        If Schedule_Type_X2 = "FIXED INTERVAL" Then
            If Time_of_the_Period2() >= (Schedule_Value_X2 * 1000) And Actual_Response2 <> Previous_Response2 And Actual_Response2 <> 1 Then
                If Delay_State_X = True Then
                    Activate_delay()
                End If

                If Delay_State_X = False Then

                    Reinforce2()
                    Response_Counter2 = 0
                    Period_Start2 = Environment.TickCount
                End If
            End If
        End If

        If Schedule_Type_X2 = "VARIABLE INTERVAL" Then
            If Time_of_the_Period2() >= (rd2(Value_Variable2)) And Actual_Response2 <> 1 And Actual_Response2 <> Previous_Response2 Then
                If Delay_State_X = True Then
                    Activate_delay()
                    Value_Variable2 = Value_Variable2 + 1
                End If

                If Delay_State_X = False Then

                    Reinforce2()
                    Response_Counter2 = 0
                    Period_Start2 = Environment.TickCount
                    Value_Variable2 = Value_Variable2 + 1
                End If
            End If
        End If

        Return 0

    End Function
    Function Start_Chronometers() As Integer

        Time_start = Environment.TickCount
        Period_Start = Environment.TickCount
        Return (Time_start)

    End Function
    Function Time_of_the_Period() As Integer

        Period_End = Environment.TickCount
        Return (Period_End - Period_Start)

    End Function

    Function Time_of_the_Period2() As Integer

        Period_End2 = Environment.TickCount
        Return (Period_End2 - Period_Start2)

    End Function
    Function Time_of_Period_in_seconds() As Integer

        Period_End = Environment.TickCount
        Return ((Period_End - Period_Start) / 1000)

    End Function
    Function Time_of_Period_in_seconds2() As Integer

        Period_End2 = Environment.TickCount
        Return ((Period_End2 - Period_Start2) / 1000)

    End Function
    Function Time_in_miliseconds() As Integer

        Time_End = Environment.TickCount
        Return (Time_End - Time_start)

    End Function
    Function Time_in_seconds() As Integer

        Time_End = Environment.TickCount
        Return ((Time_End - Time_start) / 1000)

    End Function


    Public TXT As StreamWriter
    Function Initialize_File_Writing() As Integer


        Try
            TXT = File.CreateText("C:\Data\" & Subject_X & "." & Session_Number_X & ".txt")
        Catch dirNotFound As System.IO.DirectoryNotFoundException
            MsgBox("ERROR: Please create Data folder in C: before running", MsgBoxStyle.Critical)
            End
        End Try

        TXT.WriteLine(DateTime.Now)
        TXT.WriteLine()
        TXT.WriteLine("Subject: " & Subject_X)
        TXT.WriteLine("Session: " & Session_Number_X)
        TXT.WriteLine("Schedule: " & Schedule_Type_X & " " & Schedule_Value_X.ToString())
        TXT.WriteLine()
        TXT.WriteLine("Events:")
        TXT.WriteLine()
        TXT.WriteLine("100 = Response-ON  Note: Ignore the first datum ending with .2")
        TXT.WriteLine("200 = Response-OFF")
        TXT.WriteLine("500 = Reinforcer delivery")
        TXT.WriteLine("555 = Independent reinforcer")
        TXT.WriteLine()
        TXT.WriteLine("List of events: ")
        TXT.WriteLine()
        Return 0

    End Function
    Function End_File_Writing() As Integer

        TXT.WriteLine()
        TXT.WriteLine("Total Responses: " + Total_Responses.ToString())
        TXT.WriteLine("Total Reinforcers delivered: " + Total_Reinforcers.ToString())
        TXT.WriteLine("Time elapsed: " + Time_in_seconds().ToString())
        TXT.WriteLine()
        TXT.WriteLine("END OF THE SESSION")
        TXT.Close()
        Return (0)

    End Function

    Function Generate_Interval() As Integer
        If Value_Variable = n Then
            Value_Variable = 0
        End If

        If Value_Variable = 0 Then

            If Schedule_Type_X = "VARIABLE INTERVAL" Then

                v = Schedule_Value_X * 1000

            End If

            If Schedule_Type_X = "VARIABLE RATIO" Then

                v = Schedule_Value_X

            End If

            If Iterations_State_X = False Then

                n = Int(Max_Reinforcers_X / 3)

            End If

            If Iterations_State_X = True Then

                n = Iterations_X

            End If



            ReDim rd(n)
            ReDim vi(n)

            For i = 1 To n
                If i = n Then vi(i) = v * (1 + Log(n)) : GoTo 349
                vi(i) = Int(v * (1 + (Log(n)) + (n - i) * (Log(n - i)) - (n - i + 1) * Log(n - i + 1)))

349:            order = Int((n * Rnd(Rnd() * Convert.ToSingle(Environment.TickCount / 3333))))


                If rd(order) = 0 Then rd(order) = CInt(vi(i)) Else GoTo 349

            Next i
            For a = 0 To n
                Sumxser = Sumxser + rd(a)
            Next a

            If Sumxser <> v * n Then
                rd(0) = rd(0) + ((v * n) - Sumxser)
            End If
            Sumxser = 0
        End If

        Return 0

    End Function

    Function Generate_Interval2() As Integer
        If Value_Variable2 = n2 Then
            Value_Variable2 = 0
        End If

        If Value_Variable2 = 0 Then

            If Schedule_Type_X2 = "VARIABLE INTERVAL" Then

                v2 = Schedule_Value_X2 * 1000

            End If

            If Schedule_Type_X2 = "VARIABLE RATIO" Then

                v2 = Schedule_Value_X2

            End If

            If Iterations_State_X2 = False Then

                n2 = Int(Max_Reinforcers_X / 3)

            End If

            If Iterations_State_X2 = True Then

                n2 = Iterations_X2

            End If



            ReDim rd2(n2)
            ReDim vi2(n2)

            For i = 1 To n2
                If i = n2 Then vi2(i) = v2 * (1 + Log(n2)) : GoTo 389
                vi2(i) = Int(v2 * (1 + (Log(n2)) + (n2 - i) * (Log(n2 - i)) - (n2 - i + 1) * Log(n2 - i + 1)))

389:            order2 = Int((n2 * Rnd(Rnd() * Convert.ToSingle(Environment.TickCount / 3333))))

                If rd2(order2) = 0 Then rd2(order2) = CInt(vi2(i)) Else GoTo 389

            Next i
            For a = 0 To n2
                Sumxser2 = Sumxser2 + rd2(a)
            Next a

            If Sumxser2 <> v2 * n2 Then
                rd2(0) = rd2(0) + ((v2 * n2) - Sumxser2)
            End If
            Sumxser2 = 0
        End If

        Return 0

    End Function


    Function Delay_Time() As Integer

        End_Delay = Environment.TickCount
        Return (End_Delay - Delay_start)

    End Function


    Function Delay() As Integer

        If DELAYED = True Then

            If Delay_Time() < Delay_requested Then
                DelayMarker.Visible = True

            Else

                DelayMarker.Visible = False
                Reinforce()
                Period_Start = Environment.TickCount
                Response_Counter = 0

            End If

        End If
        Return 0
    End Function

    Function Activate_delay() As Integer

        If Reinforcer_Availability = False Then
            TXT.WriteLine(Time_in_miliseconds() & ".700")
            Delay_start = Environment.TickCount
            DELAYED = True
            Reinforcer_Availability = True


        End If
        Return 0
    End Function

End Class