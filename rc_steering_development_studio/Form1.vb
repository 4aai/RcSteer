Imports System.Math
Public Class Form1
    Dim bm As New Bitmap(790, 530)
    Dim graph As Graphics = Graphics.FromImage(bm)
    Dim angle As Double = 270
    Dim r As Integer = 50
    Dim x0 As Integer
    Dim y0 As Integer
    Private DynamicObject As New ArrayList()
    Sub createObject(ByVal type As String)
        Select Case type
            Case ""
            Case "rocker"
                Dim obj As New rocker
                DynamicObject.Add(obj)
                DynamicObject.Item(DynamicObject.Count - 1).attID = -1
                DynamicObject.Item(DynamicObject.Count - 1).attPOINT1 = -1
                DynamicObject.Item(DynamicObject.Count - 1).attPOINT2 = -1
                DynamicObject.Item(DynamicObject.Count - 1).attTYPE = ""
            Case "connecting_rod"
                Dim obj As New connecting_rod
                DynamicObject.Add(obj)
                DynamicObject.Item(DynamicObject.Count - 1).attID = -1
                DynamicObject.Item(DynamicObject.Count - 1).attPOINT1 = -1
                DynamicObject.Item(DynamicObject.Count - 1).attPOINT2 = -1
                DynamicObject.Item(DynamicObject.Count - 1).attTYPE = ""
            Case "ball"
                Dim obj As New ball
                DynamicObject.Add(obj)
                DynamicObject.Item(DynamicObject.Count - 1).attID = -1
                DynamicObject.Item(DynamicObject.Count - 1).attPOINT1 = -1
                DynamicObject.Item(DynamicObject.Count - 1).attPOINT2 = -1
                DynamicObject.Item(DynamicObject.Count - 1).attTYPE = ""
        End Select
    End Sub
    Sub deleteObject(ByVal ID As Integer)
        DynamicObject.Item(ID).attID = -1
        DynamicObject.Item(ID).attPOINT1 = -1
        DynamicObject.Item(ID).attPOINT2 = -1
        DynamicObject.Item(ID).attTYPE = -1
        DynamicObject.RemoveAt(ID)
    End Sub
    Sub attachObject(ByVal ID As Integer, ByVal t_ID As Integer, ByVal attachPOINT1 As Integer, ByVal attachPOINT2 As Integer, ByVal t_attachTYPE As Integer)
        DynamicObject.Item(ID).attID = t_ID
        DynamicObject.Item(ID).attPOINT1 = attachPOINT1
        DynamicObject.Item(ID).attPOINT2 = attachPOINT2
        DynamicObject.Item(ID).attTYPE = t_attachTYPE
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "rc steering development studio " & AppVersion()
        'inizObjects()
        Randomize()
        PictureBox1.Image = bm
        Label1.Text = "Resolution: " & bm.Size.ToString
    End Sub
    Function AppVersion() As String
        Return My.Application.Info.Version.ToString
        '.Major & "." & _
        'My.Application.Info.Version.Major & "." & _
        'My.Application.Info.Version.Major & "." & _
        'My.Application.Info.Version.Minor
    End Function
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        'For i = DynamicRocker.Count - 1 To 0 Step -1
        For i = 0 To DynamicObject.Count - 1
            Select Case DynamicObject.Item(i).TYPE
                Case "rocker"
                    If e.X + 10 > DynamicObject.Item(i).X And e.X - 10 < DynamicObject.Item(i).X And _
                        e.Y + 10 > DynamicObject.Item(i).Y And e.Y - 10 < DynamicObject.Item(i).Y Then
                        'MsgBox("point 1")
                        m_ID = i
                        mouse_point = 0
                    End If
                    If e.X + 10 > DynamicObject.Item(i).X2 And e.X - 10 < DynamicObject.Item(i).X2 And _
                        e.Y + 10 > DynamicObject.Item(i).Y2 And e.Y - 10 < DynamicObject.Item(i).Y2 Then
                        'MsgBox("point 2")
                        m_ID = i
                        mouse_point = 1
                    End If
                    If e.X + 10 > DynamicObject.Item(i).X3 And e.X - 10 < DynamicObject.Item(i).X3 And _
                        e.Y + 10 > DynamicObject.Item(i).Y3 And e.Y - 10 < DynamicObject.Item(i).Y3 Then
                        'MsgBox("point 3")
                        m_ID = i
                        mouse_point = 2
                    End If
                Case "connecting_rod"
                    If e.X + 10 > DynamicObject.Item(i).X And e.X - 10 < DynamicObject.Item(i).X And _
                        e.Y + 10 > DynamicObject.Item(i).Y And e.Y - 10 < DynamicObject.Item(i).Y Then
                        'MsgBox("point 1")
                        m_ID = i
                        mouse_point = 0
                    End If
                    If e.X + 10 > DynamicObject.Item(i).X2 And e.X - 10 < DynamicObject.Item(i).X2 And _
                        e.Y + 10 > DynamicObject.Item(i).Y2 And e.Y - 10 < DynamicObject.Item(i).Y2 Then
                        'MsgBox("point 2")
                        m_ID = i
                        mouse_point = 1
                    End If
                    If e.X + 10 > DynamicObject.Item(i).X3 And e.X - 10 < DynamicObject.Item(i).X3 And _
                        e.Y + 10 > DynamicObject.Item(i).Y3 And e.Y - 10 < DynamicObject.Item(i).Y3 Then
                        'MsgBox("point 2")
                        m_ID = i
                        mouse_point = 2
                    End If
                Case "ball"
                    'If e.X + 10 > DynamicObject.Item(i).X And e.X - 10 < DynamicObject.Item(i).X And _
                    '    e.Y + 10 > DynamicObject.Item(i).Y And e.Y - 10 < DynamicObject.Item(i).Y Then
                    '    'MsgBox("point 1")
                    '    m_ID = i
                    '    mouse_point = 0
                    'End If
                    'If e.X + 10 > DynamicObject.Item(i).X2 And e.X - 10 < DynamicObject.Item(i).X2 And _
                    '    e.Y + 10 > DynamicObject.Item(i).Y2 And e.Y - 10 < DynamicObject.Item(i).Y2 Then
                    '    'MsgBox("point 2")
                    '    m_ID = i
                    '    mouse_point = 1
                    'End If
                    If e.X + 10 > DynamicObject.Item(i).X3 And e.X - 10 < DynamicObject.Item(i).X3 And _
                        e.Y + 10 > DynamicObject.Item(i).Y3 And e.Y - 10 < DynamicObject.Item(i).Y3 Then
                        'MsgBox("point 2")
                        m_ID = i
                        mouse_point = 2
                    End If
            End Select
        Next
        PictureBox1.Image = bm
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        mouse_point = -1
        m_ID = -1
    End Sub
    Sub attach_object(ByVal object_id As Integer, ByVal object_id2 As Integer)
        '' point_connection As Integer(,,) ' point, object, object_type = attach 0 or 1
        'point_connection()
    End Sub
    Dim mouse_point As Integer = -1
    Dim m_ID As Integer = -1
    'Dim mouse_point_object_type As Integer = -1
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If m_ID <> -1 Then
            Select Case DynamicObject.Item(m_ID).TYPE ' тип объекта
                Case "rocker"
                    Select Case mouse_point     ' точки
                        Case 0
                            DynamicObject.Item(m_ID).setXY(e.X, e.Y, bm)
                            PictureBox1.Image = bm
                        Case 1
                            Dim ang As Double
                            ang = Atan2(e.Y - DynamicObject.Item(m_ID).Y, e.X - DynamicObject.Item(m_ID).X) * 180 / PI + 180
                            If e.Button = Windows.Forms.MouseButtons.Left Then
                                DynamicObject.Item(m_ID).setAngle(ang, bm)
                            End If
                            If e.Button = Windows.Forms.MouseButtons.Right Then
                                DynamicObject.Item(m_ID).setRadius(CInt(Sqrt((e.X - DynamicObject.Item(m_ID).X) ^ 2 + (e.Y - DynamicObject.Item(m_ID).Y) ^ 2)), bm)
                                DynamicObject.Item(m_ID).setAngle(ang, bm)
                            End If
                        Case 2
                            Dim ang As Double
                            If e.Button = Windows.Forms.MouseButtons.Left Then
                                ang = Atan2(e.Y - DynamicObject.Item(m_ID).Y, e.X - DynamicObject.Item(m_ID).X) * 180 / PI + 180
                                DynamicObject.Item(m_ID).setAngle(ang - 90, bm)
                                PictureBox1.Image = bm
                            End If
                            PictureBox1.Image = bm
                    End Select
                Case "connecting_rod"
                    Select Case mouse_point     ' точки
                        Case 0
                            DynamicObject.Item(m_ID).setXY(e.X, e.Y, bm)
                            PictureBox1.Image = bm
                        Case 1
                            DynamicObject.Item(m_ID).setX2Y2(e.X, e.Y, bm)
                            PictureBox1.Image = bm
                        Case 2
                            DynamicObject.Item(m_ID).draw(DynamicObject.Item(m_ID).X + e.X - DynamicObject.Item(m_ID).X3, _
                                                                      DynamicObject.Item(m_ID).Y + e.Y - DynamicObject.Item(m_ID).Y3, _
                                                                      DynamicObject.Item(m_ID).X2 + e.X - DynamicObject.Item(m_ID).X3, _
                                                                      DynamicObject.Item(m_ID).Y2 + e.Y - DynamicObject.Item(m_ID).Y3, bm)
                            PictureBox1.Image = bm
                    End Select
                Case "ball"
                    Select Case mouse_point     ' точки
                        '    Case 0
                        '        DynamicObject.Item(m_ID).setXY(e.X, e.Y, bm)
                        '        PictureBox1.Image = bm
                        '    Case 1
                        '        DynamicObject.Item(m_ID).setX2Y2(e.X, e.Y, bm)
                        '        PictureBox1.Image = bm
                        Case 2
                            DynamicObject.Item(m_ID).draw(DynamicObject.Item(m_ID).X + e.X - DynamicObject.Item(m_ID).X3, _
                                                                      DynamicObject.Item(m_ID).Y + e.Y - DynamicObject.Item(m_ID).Y3, _
                                                                      DynamicObject.Item(m_ID).X2 + e.X - DynamicObject.Item(m_ID).X3, _
                                                                      DynamicObject.Item(m_ID).Y2 + e.Y - DynamicObject.Item(m_ID).Y3, bm)
                            PictureBox1.Image = bm
                    End Select
            End Select

            If mouse_point <> -1 Then
                For i = 0 To DynamicObject.Count - 1
                    DynamicObject.Item(i).ReDrawMe(bm)
                Next
                PictureBox1.Image = bm
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If DynamicObject.Count > 0 Then
            DynamicObject.Item(DynamicObject.Count - 1).Dispose(bm)
            DynamicObject.RemoveAt(DynamicObject.Count - 1)
            ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)

            For i = 0 To DynamicObject.Count - 1
                DynamicObject.Item(i).ReDrawMe(bm)
            Next
            PictureBox1.Image = bm
        End If
        Label2.Text = "Objects: " & DynamicObject.Count
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x0 = PictureBox1.Size.Width \ 2
        y0 = PictureBox1.Size.Height \ 2
        createObject("rocker")
        Dim rnd As New Random
        Dim k As Integer = PictureBox1.Size.Width \ 5
        Dim f As Integer = PictureBox1.Size.Height \ 5
        Dim l As Integer = 20
        Dim ID As Integer = DynamicObject.Count - 1
        If CheckBox1.Checked = True And ID >= 1 Then
            DynamicObject.Item(ID).draw(DynamicObject.Item(ID - 1).X2, DynamicObject.Item(ID - 1).Y2, rnd.Next(10, 20) * rnd.Next(1, 3), rnd.Next(0, 359), bm)
        Else
            DynamicObject.Item(ID).draw(x0 + rnd.Next(-k, k), y0 + rnd.Next(-f, f), rnd.Next(1, l) * 10, rnd.Next(0, 359), bm)
        End If
        addToList(ID)
        PictureBox1.Image = bm
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        x0 = PictureBox1.Size.Width \ 2
        y0 = PictureBox1.Size.Height \ 2
        createObject("connecting_rod")
        Dim rnd As New Random
        Dim k As Integer = PictureBox1.Size.Width \ 5
        Dim f As Integer = PictureBox1.Size.Height \ 5
        Dim ID As Integer = DynamicObject.Count - 1

        If CheckBox1.Checked = True And ID >= 1 Then
            ' setX2Y2(ByVal x2 As Integer, ByVal y2 As Integer, ByRef bm As Bitmap)
            'DynamicObject.Item(ID).setX2Y2(, bm)
            DynamicObject.Item(ID).draw(x0 + rnd.Next(-k, k), y0 + rnd.Next(-f, f), DynamicObject.Item(ID - 1).X, DynamicObject.Item(ID - 1).Y, bm)
        Else
            DynamicObject.Item(ID).draw(x0 + rnd.Next(-k, k), y0 + rnd.Next(-f, f), x0 + rnd.Next(-k, k), y0 + rnd.Next(-f, f), bm)
        End If
        addToList(ID)
        PictureBox1.Image = bm
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        x0 = PictureBox1.Size.Width \ 2
        y0 = PictureBox1.Size.Height \ 2
        createObject("ball")
        Dim rnd As New Random
        Dim k As Integer = PictureBox1.Size.Width \ 5
        Dim f As Integer = PictureBox1.Size.Height \ 5
        Dim ID As Integer = DynamicObject.Count - 1
        DynamicObject.Item(ID).draw(x0 + rnd.Next(-k, k), y0 + rnd.Next(-f, f), x0 + rnd.Next(-k, k), y0 + rnd.Next(-f, f), bm)
        addToList(ID)
        PictureBox1.Image = bm
    End Sub
    Sub addToList(ByVal ID As Integer)
        ListBox1.Items.Add("ID: " & ID & " """ & DynamicObject.Item(ID).TYPE & """")
        Label2.Text = "Objects: " & DynamicObject.Count
    End Sub

    Private Sub PictureBox1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.SizeChanged
        bm = New Bitmap(PictureBox1.Size.Width, PictureBox1.Size.Height)
        For i = 0 To DynamicObject.Count - 1
            DynamicObject.Item(i).ReDrawMe(bm)
        Next
        PictureBox1.Image = bm
        Label1.Text = "Resolution: " & bm.Size.ToString
    End Sub
End Class
