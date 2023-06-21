Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Linq.Expressions
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Numerics
Public Class Form1
    Private Structure ConstFileSizes
        Const nonNitro As Integer = 26214399
        Const nitroBasic As Integer = 52428799
        Const nitro As Integer = 524287999
    End Structure
    Dim fileSize As Integer = ConstFileSizes.nonNitro
    Private Function FromDTP() As Byte()
NoFilesSelected:
        Dim usingDTPInfo As MsgBoxResult = MsgBox("Use DTPInfo file?", MsgBoxStyle.YesNo, "Convert from DTP")
        Dim readPaths() As String
        Select Case usingDTPInfo
            Case Is = MsgBoxResult.Yes
                Dim DTPInfoPath As String
                With OpenFileDialog1
                    .AddExtension = False
                    .Title = "DTP DTPInfo"
                    .ValidateNames = True
                    .CheckFileExists = False
                    .Multiselect = False
                    .Filter = "DTP Info files|*.DTPInfo"
                    .ShowDialog()
                    DTPInfoPath = .FileName
                End With
                If DTPInfoPath.Length = 0 Then
                    MsgBox("Please select a DTPInfo file, or all of the .DTP files")
                    GoTo NoFilesSelected
                End If
                Dim DTPInfoData() As String = File.ReadAllLines(DTPInfoPath)
                ReDim readPaths(DTPInfoData.GetUpperBound(0))
                Dim folderLocation As String = Strings.Left(DTPInfoPath, InStrRev(DTPInfoPath, "\"))
                For pathIndex = 0 To DTPInfoData.GetUpperBound(0)
                    readPaths(pathIndex) = folderLocation & DTPInfoData(pathIndex)
                Next
            Case Is = MsgBoxResult.No
                With OpenFileDialog1
                    .AddExtension = False
                    .Title = "DTP files to convert"
                    .ValidateNames = True
                    .CheckFileExists = False
                    .Multiselect = True
                    .ShowDialog()
                    readPaths = .FileNames
                End With
        End Select
FromDTP:
        Try
            If Not File.Exists(readPaths(0)) Then
                MsgBox("Please select a DTPInfo file, or all of the .DTP files")
                GoTo NoFilesSelected
            End If
        Catch ex As IndexOutOfRangeException
            MsgBox("Please select a DTPInfo file, or all of the .DTP files")
            GoTo NoFilesSelected
        End Try
        If sort(readPaths) Then
            GoTo FromDTP
        End If
        If String.IsNullOrEmpty(readPaths(0)) Then
            Application.Exit()
        End If
        Dim msgBoxChoice As MsgBoxResult
        Dim firstPath As String = ""
        For pathSection = 0 To readPaths(0).Split(".").Length - 2
            firstPath &= readPaths(0).Split(".")(pathSection) & "."
        Next
        firstPath = Strings.Left(firstPath, firstPath.Length - 1)
        Dim filePath As String = ""
        For Each file In readPaths
            filePath = ""
            For pathSection = 0 To file.Split(".").Length - 2
                filePath &= file.Split(".")(pathSection) & "."
            Next
            filePath = Strings.Left(filePath, filePath.Length - 1)

            If firstPath <> filePath Then
                msgBoxChoice = MsgBox("Files do not have the same name, so will likely cause an error when recreating the original file.", MsgBoxStyle.AbortRetryIgnore, "Files likely to form corrupt output")
                Select Case msgBoxChoice
                    Case Is = vbAbort
                        Application.Exit()
                    Case Is = vbRetry
                        GoTo FromDTP
                    Case Is = vbIgnore
                        Exit For
                End Select
            End If
        Next
        Dim dataStream As New MemoryStream
        path = firstPath
        For Each readPath In readPaths
            Dim fileReader As FileStream
            Try
                fileReader = File.OpenRead(readPath)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Missing file")
                GoTo NoFilesSelected
            End Try
            Dim buffer() As Byte

            If readPath.Split(".")(readPath.Split(".").Length - 1)(0) = "n" Then
                ReDim buffer(ConstFileSizes.nitro)
            ElseIf readpath.Split(".")(readpath.Split(".").Length - 1)(0) = "b" Then
                ReDim buffer(ConstFileSizes.nitroBasic)
            Else
                ReDim buffer(ConstFileSizes.nonNitro)
            End If

            Dim bufferLen As UInteger
            bufferLen = fileReader.Read(buffer, 0, buffer.Length - 1)
            dataStream.Write(buffer, 0, bufferLen)
            fileReader.Close()
        Next
        Return dataStream.ToArray
    End Function
    Private Function sort(ByRef Arr() As String) As Boolean

        Dim returnArr(Arr.Length - 1) As String
        For Each path In Arr
            Try
                returnArr(Integer.Parse(path.Split("p")(path.Split("p").Length - 1)) - 1) = path
            Catch ex As Exception
                Select Case MsgBox("Files aren't in the correct format, this is likely because they are not .dtp, .bdtp or .ndtp files, e.g. file.txt.dtp1", MsgBoxStyle.RetryCancel, "Files likely incompatible")
                    Case Is = vbCancel
                        Dim emptyString(0) As String
                        Arr = emptyString
                        Return False
                    Case Is = vbRetry
                        Return True
                End Select
            End Try
        Next
        Arr = returnArr
    End Function

    Private Sub ToDTP(data() As Byte)
ToDTP:
        Dim readPath As String = path
        Dim readStream As New MemoryStream(data)
        Dim loopIndex As UInteger = 0
        Dim readFileName As String = readPath.Split("\")(readPath.Split("\").Length - 1)
        Dim buffer(fileSize) As Byte
        Dim bufferLen As UInteger = 0
        Dim writeDTPInfo As FileStream
        Dim writePath As String = ""
        Dim writeName As String = ""
        writePath = readPath
        For pathSection = 0 To writePath.Split("\").Length - 2
            writeName &= writePath.Split("\")(pathSection) & "\"
        Next
        readFileName = readFileName.Replace(" ", "_")
        writeDTPInfo = File.Create(writeName & readFileName & ".DTPInfo")
        Do
            Try
                loopIndex += 1
                bufferLen = readStream.Read(buffer, 0, fileSize)
                If 0 <> bufferLen Then
                    Dim writeStream As FileStream
                    If RadioButton1.Checked Then
                        writeStream = File.Create(writeName & readFileName & ".dtp" & loopIndex)
                        writeDTPInfo.Write(ASCIIEncoding.ASCII.GetBytes(readFileName & ".dtp" & loopIndex & vbCrLf), 0, ASCIIEncoding.ASCII.GetBytes(readFileName & ".dtp" & loopIndex).Length + 1)
                    ElseIf RadioButton2.Checked Then
                        writeStream = File.Create(writeName & readFileName & ".bdtp" & loopIndex)
                        writeDTPInfo.Write(ASCIIEncoding.ASCII.GetBytes(readFileName & ".bdtp" & loopIndex & vbCrLf), 0, ASCIIEncoding.ASCII.GetBytes(readFileName & ".bdtp" & loopIndex).Length + 1)
                    Else
                        writeStream = File.Create(writeName & readFileName & ".ndtp" & loopIndex)
                        writeDTPInfo.Write(ASCIIEncoding.ASCII.GetBytes(readFileName & ".ndtp" & loopIndex & vbCrLf), 0, ASCIIEncoding.ASCII.GetBytes(readFileName & ".ndtp" & loopIndex).Length + 1)
                    End If

                    writeStream.Write(buffer, 0, bufferLen)
                    writeStream.Close()
                Else
                    Exit Do
                End If
            Catch ex As Exception
                Select Case MsgBox("Sorry, the converted files could not be saved in this directory, try moving the file to be converted to another directory.", MsgBoxStyle.AbortRetryIgnore, "Issue trying to write to file")
                    Case Is = vbAbort
                        Application.Exit()
                    Case Is = vbRetry
                        GoTo ToDTP
                    Case Is = vbIgnore
                        Exit Try
                End Select

            End Try
        Loop
        writeDTPInfo.Close()
        readStream.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            fileSize = ConstFileSizes.nonNitro
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            fileSize = ConstFileSizes.nitroBasic
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            fileSize = ConstFileSizes.nitro
        End If
    End Sub

    'Encryption stuff -----------------------------------------------------------------

    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform
    Dim isReady As Boolean = False
    Dim encryptionData() As Byte
    Dim path As String = ""
    Dim runningFromCMD As Boolean = False
    Private Sub getEncryptionData()
        'If Not runningFromCMD Then
        path = ""
            With OpenFileDialog1
                .CheckFileExists = True
                .Multiselect = False
                .ShowDialog()
                path = .FileName
            End With
        'End If
        encryptionData = File.ReadAllBytes(path)
    End Sub
    Private Sub saveEncryptionData(encrypting As Boolean)
        If encrypting Then
            File.WriteAllBytes(path & ".enc", encryptionData)
        Else
            File.WriteAllBytes(Strings.Left(path, path.Length - 4), encryptionData)
        End If
    End Sub
    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncryptBtn.Click
        getEncryptionData()
        If isReady Then
            If encryptionData.Length <> 0 Then
                Dim memoryStream As MemoryStream = New MemoryStream()
                Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
                cryptoStream.Write(encryptionData, 0, encryptionData.Length)
                cryptoStream.FlushFinalBlock()
                encryptionData = memoryStream.ToArray()
                memoryStream.Close()
                cryptoStream.Close()
            End If
        End If
        'saveEncryptionData(True)
        path = path & ".enc"
        ToDTP(encryptionData)
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecryptBtn.Click
        If isReady Then
            Dim cypherTextBytes As Byte() = FromDTP()
            Dim cypherTextLen As Integer = cypherTextBytes.Length
            If Not cypherTextLen Mod 16 = 0 Then
                cypherTextLen = cypherTextLen + (16 - cypherTextLen Mod 16)
                ReDim Preserve cypherTextBytes(cypherTextLen)
            End If
            Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes(cypherTextBytes.Length - 1) As Byte
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            encryptionData = plainTextBytes
        End If
        saveEncryptionData(False)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim args() As String = Environment.GetCommandLineArgs
        'If args.Length = 1 Then
        '    Exit Sub
        'ElseIf args(1) = "help" Then
        '    MsgBox("FileEncrypter [enc/dec] [Path] [Key] [IV]")
        'ElseIf args.Length = 5 Then
        '    runningFromCMD = True
        '    path = args(2)
        '    Key.Text = args(3)
        '    IV.Text = args(4)
        '    If args(1) = "enc" Then
        '        btnEncrypt_Click(Me, e)
        '    ElseIf args(1) = "dec" Then
        '        btnDecrypt_Click(Me, e)
        '    Else
        '        MsgBox("Error: invalid arguments")
        '    End If
        'Else
        '    MsgBox("Error: invalid arguments")
        'End If
        'Application.Exit()
    End Sub

    Private Sub UpdateEncoder(sender As Object, e As EventArgs) Handles Key.TextChanged, IV.TextChanged
        Dim KeyString As String = Key.Text
        Dim IVString As String = IV.Text
        Dim keyNum As BigInteger
        Dim IVNum As BigInteger
        Dim KeyByteArr() As Byte
        Dim IVByteArr() As Byte
        Try
            isReady = True
            Dim KEY_256 As Byte()
            Dim IV_128 As Byte()
            If KeyString <> "" Then
                keyNum = BigInteger.Parse(KeyString)
                KeyByteArr = keyNum.ToByteArray
                ReDim Preserve KeyByteArr(31)
                KEY_256 = KeyByteArr
            Else
                isReady = False
            End If
            If IVString <> "" Then
                IVNum = BigInteger.Parse(IVString)
                IVByteArr = IVNum.ToByteArray
                ReDim Preserve IVByteArr(15)
                IV_128 = IVByteArr
            Else
                isReady = False
            End If
            If isReady Then
                Dim symmetricKey As AesCryptoServiceProvider = New AesCryptoServiceProvider
                symmetricKey.Mode = CipherMode.CBC
                symmetricKey.KeySize = 256
                symmetricKey.GenerateIV()
                symmetricKey.Padding = PaddingMode.Zeros
                enc = New System.Text.UTF8Encoding
                encryptor = symmetricKey.CreateEncryptor(KEY_256, IV_128)
                decryptor = symmetricKey.CreateDecryptor(KEY_256, IV_128)
            End If
        Catch ex As Exception
            MsgBox("Invalid key, key must be a number" & vbCrLf & vbCrLf & ex.ToString)
            isReady = False
        End Try
    End Sub

    Private Sub RandomiseKey_Click(sender As Object, e As EventArgs) Handles RandomiseKeyBtn.Click
        Dim rand As New Random
        Dim rng As New RNGCryptoServiceProvider
        Dim bytes(31) As Byte
        rng.GetBytes(bytes)
        Dim Int256 As New BigInteger(bytes)
        Key.Text = Int256.ToString
    End Sub

    Private Sub RandomiseIV_Click(sender As Object, e As EventArgs) Handles RandomiseIVBtn.Click
        Dim rand As New Random
        Dim rng As New RNGCryptoServiceProvider
        Dim bytes(15) As Byte
        rng.GetBytes(bytes)
        Dim Int256 As New BigInteger(bytes)
        IV.Text = Int256.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EstablishKeysBtn.Click
        DiffieHellman.Show()
    End Sub
    'Sub generateprimenumbersbetween()
    '    Dim starting_number As BigInteger = BigInteger.Parse("10000000000000000000000000000000000000000000000000")
    '    Dim last_number As BigInteger = BigInteger.Parse("99999999999999999999999999999999999999999999999999")
    '    Dim primenumbers As String
    '    Dim a As BigInteger
    '    Dim b As BigInteger
    '    Dim c As BigInteger
    '    primenumbers = ""
    '    For a = starting_number To last_number
    '        c = (a / 2) + 1
    '        For b = 2 To c
    '            If a = 1 Or (a Mod b = 0 And c <> b) Then
    '                Exit For
    '            Else
    '                If b = c Then
    '                    primenumbers = primenumbers & " " & a.ToString
    '                    Exit For
    '                End If
    '            End If
    '        Next b
    '    Next a
    '    MsgBox(primenumbers)
    'End Sub
End Class
