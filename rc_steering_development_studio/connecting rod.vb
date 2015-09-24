Imports System.Math
Public Class connecting_rod
    Private connecting_rod_R As Integer = 50
    Private connecting_rod_X As Integer = 0
    Private connecting_rod_Y As Integer = 0
    Private connecting_rod_X2 As Integer = 0
    Private connecting_rod_Y2 As Integer = 0
    Private connecting_rod_X3 As Integer = 0
    Private connecting_rod_Y3 As Integer = 0
    Private connecting_rod_point As Integer = 3
    Private Const connecting_rod_type = "connecting_rod" '2 ' connecting_rod type
    Private Structure attach_structure
        Dim attachID As Integer
        Dim attachTYPE As String
        Dim attachPOINT1 As Integer
        Dim attachPOINT2 As Integer
    End Structure
    Private attached As attach_structure

    Private Sub eraseMe(ByRef graph As Graphics)
        graph.DrawLine(Pens.LightGray, connecting_rod_X, connecting_rod_Y, connecting_rod_X2, connecting_rod_Y2)
        graph.FillEllipse(Brushes.LightGray, connecting_rod_X - connecting_rod_point, connecting_rod_Y - connecting_rod_point, connecting_rod_point * 2, connecting_rod_point * 2)
        graph.FillEllipse(Brushes.LightGray, connecting_rod_X2 - connecting_rod_point, connecting_rod_Y2 - connecting_rod_point, connecting_rod_point * 2, connecting_rod_point * 2)
        connecting_rod_X3 = (connecting_rod_X2 + connecting_rod_X) \ 2
        connecting_rod_Y3 = (connecting_rod_Y2 + connecting_rod_Y) \ 2
        graph.FillEllipse(Brushes.LightGray, connecting_rod_X3 - connecting_rod_point, connecting_rod_Y3 - connecting_rod_point, connecting_rod_point * 2, connecting_rod_point * 2)
    End Sub
    Private Sub drawMe(ByRef graph As Graphics)
        graph.DrawLine(Pens.Blue, connecting_rod_X, connecting_rod_Y, connecting_rod_X2, connecting_rod_Y2)
        graph.FillEllipse(Brushes.Red, connecting_rod_X - connecting_rod_point, connecting_rod_Y - connecting_rod_point, connecting_rod_point * 2, connecting_rod_point * 2)
        graph.FillEllipse(Brushes.Green, connecting_rod_X2 - connecting_rod_point, connecting_rod_Y2 - connecting_rod_point, connecting_rod_point * 2, connecting_rod_point * 2)
        connecting_rod_X3 = (connecting_rod_X2 + connecting_rod_X) \ 2
        connecting_rod_Y3 = (connecting_rod_Y2 + connecting_rod_Y) \ 2
        graph.FillEllipse(Brushes.Black, connecting_rod_X3 - connecting_rod_point, connecting_rod_Y3 - connecting_rod_point, connecting_rod_point * 2, connecting_rod_point * 2)
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
        connecting_rod_X = x
        connecting_rod_Y = y
        connecting_rod_X2 = x2
        connecting_rod_Y2 = y2
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
        connecting_rod_X = x
        connecting_rod_Y = y
        drawMe(graph)
    End Sub
    Public Sub setX2Y2(ByVal x2 As Integer, ByVal y2 As Integer, ByRef bm As Bitmap)
        Dim graph As Graphics
        graph = Graphics.FromImage(bm)
        eraseMe(graph)
        connecting_rod_X2 = x2
        connecting_rod_Y2 = y2
        drawMe(graph)
    End Sub
    Public ReadOnly Property X() As Integer
        Get
            Return connecting_rod_X
        End Get
    End Property
    Public ReadOnly Property Y() As Integer
        Get
            Return connecting_rod_Y
        End Get
    End Property
    Public ReadOnly Property X2() As Integer
        Get
            Return connecting_rod_X2
        End Get
    End Property
    Public ReadOnly Property Y2() As Integer
        Get
            Return connecting_rod_Y2
        End Get
    End Property
    Public ReadOnly Property X3() As Integer
        Get
            Return connecting_rod_X3
        End Get
    End Property
    Public ReadOnly Property Y3() As Integer
        Get
            Return connecting_rod_Y3
        End Get
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
            Return connecting_rod_type
        End Get
    End Property
End Class
