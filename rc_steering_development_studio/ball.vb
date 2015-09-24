Imports System.Math
Public Class ball
    Private ball_X As Integer = 0
    Private ball_Y As Integer = 0
    Private ball_X2 As Integer = 0
    Private ball_Y2 As Integer = 0
    Private ball_X3 As Integer = 0
    Private ball_Y3 As Integer = 0
    Private ball_R As Integer = 30
    Private ball_R2 As Integer = 30
    Private ball_Angle As Double = 200
    Private ball_AngleMin As Double = 0
    Private ball_AngleMax As Double = 360
    Private ball_point As Integer = 3
    Private ball_point2 As Integer = 30
    Private ball_point3 As Integer = 29
    Private Const ball_type = "ball" '3 ' ball type
    Private Structure attach_structure
        Dim attachID As Integer
        Dim attachTYPE As String
        Dim attachPOINT1 As Integer
        Dim attachPOINT2 As Integer
    End Structure
    Private attached As attach_structure

    Private Sub eraseMe(ByRef graph As Graphics)
        ball_X3 = (ball_X2 + ball_X) \ 2
        ball_Y3 = (ball_Y2 + ball_Y) \ 2
        graph.FillEllipse(Brushes.LightGray, ball_X3 - ball_point2, ball_Y3 - ball_point2, ball_point2 * 2, ball_point2 * 2)
    End Sub
    Private Sub drawMe(ByRef graph As Graphics)
        ball_X3 = (ball_X2 + ball_X) \ 2
        ball_Y3 = (ball_Y2 + ball_Y) \ 2
        graph.FillEllipse(Brushes.LimeGreen, ball_X3 - ball_point2, ball_Y3 - ball_point2, ball_point2 * 2, ball_point2 * 2)
        graph.FillEllipse(Brushes.Black, ball_X3 - ball_point, ball_Y3 - ball_point, ball_point * 2, ball_point * 2)
        graph.DrawEllipse(Pens.Blue, ball_X3 - ball_point3, ball_Y3 - ball_point3, ball_point3 * 2, ball_point3 * 2)
    End Sub
    Public Sub Dispose(ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
    End Sub
    Public Sub draw(ByVal x As Integer, ByVal y As Integer, ByVal x2 As Integer, ByVal y2 As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        ball_X = x
        ball_Y = y
        ball_X2 = x2
        ball_Y2 = y2
        drawMe(graph)
    End Sub
    Public Sub ReDrawMe(ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        drawMe(graph)
    End Sub
    Public Sub setXY(ByVal x As Integer, ByVal y As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        ball_X = x
        ball_Y = y
        drawMe(graph)
    End Sub
    Public Sub setX2Y2(ByVal x2 As Integer, ByVal y2 As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        ball_X2 = x2
        ball_Y2 = y2
        drawMe(graph)
    End Sub
    Public Sub setAngle(ByVal angle As Double, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        ball_Angle = angle
        drawMe(graph)
    End Sub
    Public Sub setRadius(ByVal r As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        ball_R = r
        drawMe(graph)
    End Sub
    Public Sub setRadius2(ByVal r As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        ball_R2 = r
        drawMe(graph)
    End Sub
    Public ReadOnly Property X() As Integer
        Get
            Return ball_X
        End Get
    End Property
    Public ReadOnly Property Y() As Integer
        Get
            Return ball_Y
        End Get
    End Property
    Public ReadOnly Property X2() As Integer
        Get
            Return ball_X2
        End Get
    End Property
    Public ReadOnly Property Y2() As Integer
        Get
            Return ball_Y2
        End Get
    End Property
    Public ReadOnly Property X3() As Integer
        Get
            Return ball_X3
        End Get
    End Property
    Public ReadOnly Property Y3() As Integer
        Get
            Return ball_Y3
        End Get
    End Property
    Public ReadOnly Property R() As Integer
        Get
            Return ball_R
        End Get
    End Property
    Public ReadOnly Property R2() As Integer
        Get
            Return ball_R2
        End Get
    End Property
    Public ReadOnly Property Angle() As Integer
        Get
            Return ball_Angle
        End Get
    End Property
    Public Property AngleMin() As Integer
        Get
            Return ball_AngleMin
        End Get
        Set(ByVal value As Integer)
            ball_AngleMin = value
        End Set
    End Property
    Public Property AngleMax() As Integer
        Get
            Return ball_AngleMax
        End Get
        Set(ByVal value As Integer)
            ball_AngleMax = value
        End Set
    End Property
    Public Property attID() As Integer
        Get
            Return attached.attachID
        End Get
        Set(ByVal value As Integer)
            attached.attachID = value
        End Set
    End Property
    Public Property attPOINT1() As Integer
        Get
            Return attached.attachPOINT1
        End Get
        Set(ByVal value As Integer)
            attached.attachPOINT1 = value
        End Set
    End Property
    Public Property attPOINT2() As Integer
        Get
            Return attached.attachPOINT2
        End Get
        Set(ByVal value As Integer)
            attached.attachPOINT2 = value
        End Set
    End Property
    Public Property attTYPE() As String
        Get
            Return attached.attachTYPE
        End Get
        Set(ByVal value As String)
            attached.attachTYPE = value
        End Set
    End Property
    Public ReadOnly Property TYPE() As String
        Get
            Return ball_type
        End Get
    End Property
End Class
