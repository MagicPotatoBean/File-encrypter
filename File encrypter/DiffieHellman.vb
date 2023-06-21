Imports System.Numerics
Imports System.Security.Cryptography

Public Class DiffieHellman
    Dim a As BigInteger
    Dim g As BigInteger
    Dim p As BigInteger
    Dim ready As Boolean
    Private Sub GeneratePublicValues(sender As Object, e As EventArgs) Handles Generator.TextChanged, Modulus.TextChanged
        ready = True
        Try
            g = BigInteger.Parse(Generator.Text)
        Catch ex As Exception
            ready = False
        End Try
        Try
            p = BigInteger.Parse(Modulus.Text)
        Catch ex As Exception
            ready = False
        End Try
        If ready Then
            Dim bytes(532532) As Byte
            Dim rng As New RNGCryptoServiceProvider
            rng.GetBytes(bytes)
            a = New BigInteger(bytes)
            If a.Sign < 0 Then
                a = BigInteger.Negate(a)
            End If
            GA.Text = BigInteger.ModPow(g, a, p).ToString
        Else
        End If
    End Sub
    'Private Sub DH_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    p = generatePrime(4738248)
    '    Dim bytes(4654354655 / 8) As Byte
    '    Dim rng As New RNGCryptoServiceProvider
    '    rng.GetBytes(bytes)
    '    Dim g As New BigInteger(bytes)
    'End Sub
    Private Function generatePrime(bitlength As Long) As BigInteger
        Do
            Dim bytes(bitlength / 8) As Byte
            Dim rng As New RNGCryptoServiceProvider
            rng.GetBytes(bytes)
            Dim newRand As BigInteger
            If isPrime(newRand) Then
                Return newRand
            End If
        Loop
    End Function
    Private Function isPrime(num As BigInteger) As Boolean
        If num < 2 Then
            Return False
        End If
        If num.IsEven Then
            Return num = 2
        End If
        Dim limit As BigInteger = num / 2
        For factor As BigInteger = 3 To limit Step 2
            If num Mod factor = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub GB_TextChanged(sender As Object, e As EventArgs) Handles GB.TextChanged
        Try
            GAB.Text = BigInteger.ModPow(BigInteger.Parse(GB.Text), a, p).ToString
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub saveToKeyBtn_Click(sender As Object, e As EventArgs) Handles saveToKeyBtn.Click
        Form1.Key.Text = GAB.Text
    End Sub

    Private Sub saveToIVBtn_Click(sender As Object, e As EventArgs) Handles saveToIVBtn.Click
        Form1.IV.Text = GAB.Text
    End Sub

    Private Sub DiffieHellman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class