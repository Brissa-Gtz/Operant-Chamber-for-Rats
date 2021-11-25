Imports System.Threading

Public Class Confirm
    Public Second_Thread As Thread
    Public form(10) As session

    Function Create_new_arduino() As Integer
        form(x) = New session()

        x = x + 1

        Return 0
    End Function

    Function initialize() As Integer

        Me.Subjectlblconf.Text = Subject
        Me.Sessionlblconf.Text = Session_Number
        Me.Portlblconf.Text = Communication_Port
        Me.Proglblconf.Text = (Schedule_Type & Schedule_value)
        Me.RMAXlblconf.Text = Max_Reinforcers
        Me.TMAXlblconf.Text = Max_Time
        Return 0

    End Function

    Private Sub Return1btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Return1btn.Click
        Close()
    End Sub

    Private Sub Continue2btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Continue2btn.Click

        Create_new_arduino()
        Second_Thread = New Thread(New ThreadStart(AddressOf form(x - 1).Start))
        Second_Thread.IsBackground = True
        Second_Thread.Start()
        Me.Close()

    End Sub


End Class