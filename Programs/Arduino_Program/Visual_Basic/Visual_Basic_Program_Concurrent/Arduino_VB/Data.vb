Public Class Data



    Public form1
    Public Box_delay_select As Boolean = True

    Public Sub Continue1btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Continue1btn.Click

        Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0
    Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                            String.Join(",", emptyTextBoxes)))
            Exit Sub
        End If


        Session_Number = Session_Box.Text
        Subject = Subject_Box.Text
        Communication_Port = Port_CBox.Text
        Schedule_Type = Schedule_Box.Text
        Schedule_Type_2 = Schedule_Box_2.Text

        Try
            Schedule_value = Convert.ToInt32(Value_Box.Text)
            Schedule_value_2 = Convert.ToInt32(Value_Box_2.Text)

            Max_Time = Convert.ToInt32(Session_Time_Maxbox.Text)
            Max_Reinforcers = Convert.ToInt32(Reinforcers_Maxbox.Text)
        Catch ex As Exception
            MsgBox("Make sure numeric values were entered in Time, Reinforcers, and Schedule-Value boxes", MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        

        If CheckBox2.Checked = True Then

            Iterations_State = True
            Iterations = Convert.ToInt32(Iterations_Box.Text)

        End If

        If CheckBox2.Checked = False Then

            Iterations_State = False

        End If

        If CheckBox4.Checked = True Then

            Iterations_State_2 = True
            Iterations_2 = Convert.ToInt32(Iterations_Box_2.Text)

        End If

        If CheckBox4.Checked = False Then

            Iterations_State_2 = False

        End If

        form1 = New Confirm
        form1.Show()
        form1.initialize()

        My.Application.DoEvents()

    End Sub

    

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then

            Label14.Visible = True
            Iterations_Box.Visible = True

        End If

        If CheckBox2.Checked = False Then

            Box_delay_select = False
            Label14.Visible = False
            Iterations_Box.Visible = False

        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then

            Label14.Visible = True
            Iterations_Box_2.Visible = True

        End If

        If CheckBox4.Checked = False Then

            Box_delay_select = False
            Label14.Visible = False
            Iterations_Box_2.Visible = False

        End If

    End Sub
    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim infoForm As Form
        infoForm = New About()
        infoForm.Show()
        infoForm = Nothing
    End Sub
End Class
