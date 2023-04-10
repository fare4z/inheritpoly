Public Class Animal
    Public Property Name As String
    Public Property Age As Integer
    Public Sub Sleep()
        MsgBox(Name & " is sleeping.")
    End Sub

    Public Overridable Sub Speak()
        MsgBox(Name & " makes a noise.")
    End Sub
End Class

Public Class Dog
    Inherits Animal

    Public Function PictureSpeak() As Bitmap
        PictureSpeak = My.Resources.dog_bark
    End Function

    Public Function PictureSleep() As Bitmap
        PictureSleep = My.Resources.dog_sleep
    End Function
    Public Sub Sound()
        Dim player As New System.Media.SoundPlayer(My.Resources.dog_barking_6296)
        player.Play()
        MsgBox(Name & " is barking.")
    End Sub

    Public Overrides Sub Speak()
        MsgBox(Name & " says woof.")
    End Sub
End Class

Public Class Cat
    Inherits Animal
    Public Sub Sound()
        Dim player As New System.Media.SoundPlayer(My.Resources.nonino_new_141718)
        player.Play()
        MsgBox(Name & " is meowing.")
    End Sub

    Public Overrides Sub Speak()
        MsgBox(Name & " says meow.")
    End Sub

    Public Function PictureSpeak() As Bitmap
        PictureSpeak = My.Resources.cat_meow
    End Function

    Public Function PictureSleep() As Bitmap
        PictureSleep = My.Resources.cat_sleep
    End Function
End Class