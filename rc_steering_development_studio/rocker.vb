Imports System.Math
Public Class rocker
    Private rocker_X As Integer = 0
    Private rocker_Y As Integer = 0
    Private rocker_X2 As Integer = 0
    Private rocker_Y2 As Integer = 0
    Private rocker_X3 As Integer = 0
    Private rocker_Y3 As Integer = 0
    Private rocker_R As Integer = 30
    Private rocker_R2 As Integer = 30
    Private rocker_Angle As Double = 200
    Private rocker_AngleMin As Double = 0
    Private rocker_AngleMax As Double = 360
    Private rocker_point As Integer = 3
    Private Const rocker_type = "rocker" ' rocker type
    Private Structure attach_structure
        Dim attachID As Integer
        Dim attachTYPE As String
        Dim attachPOINT1 As Integer
        Dim attachPOINT2 As Integer
    End Structure
    Private attached As attach_structure

    Private Sub eraseMe(ByRef graph As Graphics)
        graph.DrawLine(Pens.LightGray, rocker_X, rocker_Y, rocker_X2, rocker_Y2)
        graph.DrawLine(Pens.LightGray, rocker_X, rocker_Y, rocker_X3, rocker_Y3)
        'graph.DrawEllipse(Pens.LightGray, rocker_X - rocker_point, rocker_Y - rocker_point, rocker_point * 2, rocker_point * 2)
        'graph.DrawEllipse(Pens.LightGray, rocker_X2 - rocker_point, rocker_Y2 - rocker_point, rocker_point * 2, rocker_point * 2)
        'graph.DrawEllipse(Pens.LightGray, rocker_X3 - rocker_point, rocker_Y3 - rocker_point, rocker_point * 2, rocker_point * 2)
        graph.FillEllipse(Brushes.LightGray, rocker_X - rocker_point, rocker_Y - rocker_point, rocker_point * 2, rocker_point * 2)
        graph.FillEllipse(Brushes.LightGray, rocker_X2 - rocker_point, rocker_Y2 - rocker_point, rocker_point * 2, rocker_point * 2)
        graph.FillEllipse(Brushes.LightGray, rocker_X3 - rocker_point, rocker_Y3 - rocker_point, rocker_point * 2, rocker_point * 2)
    End Sub
    Private Sub drawMe(ByRef graph As Graphics)
        rocker_X2 = rocker_X - CInt(Cos((rocker_Angle * PI) / 180) * rocker_R)
        rocker_Y2 = rocker_Y - CInt(Sin((rocker_Angle * PI) / 180) * rocker_R)
        rocker_X3 = rocker_X - CInt(Cos(((rocker_Angle + 90) * PI) / 180) * rocker_R2)
        rocker_Y3 = rocker_Y - CInt(Sin(((rocker_Angle + 90) * PI) / 180) * rocker_R2)
        graph.DrawLine(Pens.Blue, rocker_X, rocker_Y, rocker_X2, rocker_Y2)
        graph.DrawLine(Pens.Blue, rocker_X, rocker_Y, rocker_X3, rocker_Y3)
        'graph.DrawEllipse(Pens.Red, rocker_X - rocker_point, rocker_Y - rocker_point, rocker_point * 2, rocker_point * 2)
        'graph.DrawEllipse(Pens.Green, rocker_X2 - rocker_point, rocker_Y2 - rocker_point, rocker_point * 2, rocker_point * 2)
        'graph.DrawEllipse(Pens.Black, rocker_X3 - rocker_point, rocker_Y3 - rocker_point, rocker_point * 2, rocker_point * 2)
        'graph.FillEllipse (Brushes.Black ,
        graph.FillEllipse(Brushes.Red, rocker_X - rocker_point, rocker_Y - rocker_point, rocker_point * 2, rocker_point * 2)
        graph.FillEllipse(Brushes.Green, rocker_X2 - rocker_point, rocker_Y2 - rocker_point, rocker_point * 2, rocker_point * 2)
        graph.FillEllipse(Brushes.Black, rocker_X3 - rocker_point, rocker_Y3 - rocker_point, rocker_point * 2, rocker_point * 2)
    End Sub
    Public Sub Dispose(ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
    End Sub
    Public Sub draw(ByVal x As Integer, ByVal y As Integer, ByVal r As Integer, ByVal angle As Double, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        rocker_X = x
        rocker_Y = y
        rocker_R = r
        rocker_Angle = angle
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
        rocker_X = x
        rocker_Y = y
        drawMe(graph)
    End Sub
    Public Sub setAngle(ByVal angle As Double, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        rocker_Angle = angle
        drawMe(graph)
    End Sub
    Public Sub setRadius(ByVal r As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        rocker_R = r
        drawMe(graph)
    End Sub
    Public Sub setRadius2(ByVal r As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        rocker_R2 = r
        drawMe(graph)
    End Sub
    Public ReadOnly Property X() As Integer
        Get
            Return rocker_X
        End Get
    End Property
    Public ReadOnly Property Y() As Integer
        Get
            Return rocker_Y
        End Get
    End Property
    Public ReadOnly Property X2() As Integer
        Get
            Return rocker_X2
        End Get
    End Property
    Public ReadOnly Property Y2() As Integer
        Get
            Return rocker_Y2
        End Get
    End Property
    Public ReadOnly Property X3() As Integer
        Get
            Return rocker_X3
        End Get
    End Property
    Public ReadOnly Property Y3() As Integer
        Get
            Return rocker_Y3
        End Get
    End Property
    Public ReadOnly Property R() As Integer
        Get
            Return rocker_R
        End Get
    End Property
    Public ReadOnly Property R2() As Integer
        Get
            Return rocker_R2
        End Get
    End Property
    Public ReadOnly Property Angle() As Integer
        Get
            Return rocker_Angle
        End Get
    End Property
    Public Property AngleMin() As Integer
        Get
            Return rocker_AngleMin
        End Get
        Set(ByVal value As Integer)
            rocker_AngleMin = value
        End Set
    End Property
    Public Property AngleMax() As Integer
        Get
            Return rocker_AngleMax
        End Get
        Set(ByVal value As Integer)
            rocker_AngleMax = value
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
            Return rocker_type
        End Get
    End Property
End Class
