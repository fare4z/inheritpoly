Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myAnimal As New Animal
        myAnimal.Name = TextBox1.Text
        myAnimal.Age = TextBox2.Text

        myAnimal.Sleep()
        myAnimal.Speak()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myDog As New Dog
        myDog.Name = TextBox1.Text
        myDog.Age = TextBox2.Text
        myDog.Sleep()
        PictureBox1.Image = myDog.PictureSleep
        myDog.Sound()
        PictureBox1.Image = myDog.PictureSpeak
        myDog.Speak()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myCat As New Cat
        myCat.Name = TextBox1.Text
        myCat.Age = TextBox2.Text
        myCat.Sleep()
        PictureBox1.Image = myCat.PictureSleep
        myCat.Sound()
        PictureBox1.Image = myCat.PictureSpeak
        myCat.Speak()
    End Sub


End Class
