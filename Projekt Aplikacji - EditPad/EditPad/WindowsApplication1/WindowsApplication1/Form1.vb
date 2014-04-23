Imports System.IO
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Microsoft.Win32


Public Class Form1

    Private Sub NowyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NowyToolStripMenuItem.Click
        Try
            Label2.Text = "Nazwa Pliku : "
            System.Diagnostics.Process.Start("EditPad.exe")
        Catch ex As Exception
        End Try
    End Sub



    Dim sciezka As String 'zmienna do sprawdzania czy plik istnieje i czy nadpisać go.
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles QuickSave.Click
        Label2.Text = "Nazwa Pliku : "
        Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"

        Save.RestoreDirectory = True
        Save.AddExtension = True
        Save.FileName = "Untitled"
        ' OpenFileDialog1.FilterIndex = 1
        If System.IO.File.Exists(sciezka) = True Then ' sprawdzenie czy plik istnieje po sciezce zapisanne w zmienne sciezka

            Dim Response As MsgBoxResult

            Response = MsgBox("Czy chcesz nadpisać istniejący plik?", _
                             MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, _
                              "EditPad")
            If Response = MsgBoxResult.Yes Then
                Try
                    If Save.FilterIndex = 2 Then


                        System.IO.File.WriteAllLines(sciezka, RichTextBox1.Lines) ' nadpisanie pliku
                    Else
                        RichTextBox1.SaveFile(sciezka, RichTextBoxStreamType.RichText) ' nadpisanie pliku
                    End If
                Catch ex As Exception
                End Try
            ElseIf Response = MsgBoxResult.No Then ' jesli klikami nie, to zapisujemy nowy plik i dalsze zapisywanie tyczy sie tego utworzonego
                If (Save.ShowDialog = vbOK) Then
                    Try

                        If Save.FilterIndex = 1 Then


                            System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines) ' nadpisanie pliku
                            sciezka = Save.FileName ' przypisanie scieki do pliku
                        Else
                            RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.RichText)
                            sciezka = Save.FileName ' przypisanie scieki do pliku
                        End If


                    Catch ex As Exception
                    End Try
                End If
            End If

        Else 'tworzenie nowego bo nie istnieje

            If (Save.ShowDialog = vbOK) Then
                Try


                    If Save.FilterIndex = 1 Then


                        System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines) ' 
                        sciezka = Save.FileName ' przypisanie scieki do pliku
                        Dim plik As String
                        Dim nazwa As String
                        Dim Separator As Char = CChar("\")
                        Dim Rezultat As String() = New String() {}

                        plik = sciezka
                        Rezultat = plik.Split(Separator)
                        nazwa = Rezultat(UBound(Rezultat))
                        Label1.Text = nazwa
                    Else
                        RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.RichText)
                        sciezka = Save.FileName
                        Dim plik As String
                        Dim nazwa As String
                        Dim Separator As Char = CChar("\")
                        Dim Rezultat As String() = New String() {}

                        plik = sciezka
                        Rezultat = plik.Split(Separator)
                        nazwa = Rezultat(UBound(Rezultat))
                        Label1.Text = nazwa
                    End If
                    sciezka = Save.FileName ' przypisanie scieki do pliku

                Catch ex As Exception
                End Try
            End If
        End If

    End Sub

   

    Private Sub ZapiszToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ZapiszToolStripMenuItem.Click
        'sytuacja taka sama jak w quicksave
        Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
        Label2.Text = "Nazwa Pliku : "
        Save.RestoreDirectory = True
        Save.AddExtension = True
        Save.FileName = "Untitled"
        If System.IO.File.Exists(sciezka) = True Then ' sprawdzenie czy plik istnieje po sciezce zapisanne w zmienne sciezka

            Dim Response As MsgBoxResult

            Response = MsgBox("Czy chcesz nadpisać istniejący plik?", _
                             MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, _
                              "EditPad")
            If Response = MsgBoxResult.Yes Then
                Try
                    If Save.FilterIndex = 1 Then


                        System.IO.File.WriteAllLines(sciezka, RichTextBox1.Lines) ' nadpisanie pliku
                    Else
                        RichTextBox1.SaveFile(sciezka, RichTextBoxStreamType.RichText) ' nadpisanie pliku
                    End If
                Catch ex As Exception
                End Try
            ElseIf Response = MsgBoxResult.No Then ' jesli klikami nie, to zapisujemy nowy plik i dalsze zapisywanie tyczy sie tego utworzonego
                If (Save.ShowDialog = vbOK) Then
                    Try

                        If Save.FilterIndex = 1 Then


                            System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines) ' nadpisanie pliku
                            sciezka = Save.FileName ' przypisanie scieki do pliku
                        Else
                            RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.RichText)
                            sciezka = Save.FileName ' przypisanie scieki do pliku
                        End If


                    Catch ex As Exception
                    End Try
                End If
            End If

        Else 'tworzenie nowego bo nie istnieje

            If (Save.ShowDialog = vbOK) Then
                Try


                    If Save.FilterIndex = 1 Then


                        System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines) ' 
                        sciezka = Save.FileName ' przypisanie scieki do pliku
                        Dim plik As String
                        Dim nazwa As String
                        Dim Separator As Char = CChar("\")
                        Dim Rezultat As String() = New String() {}

                        plik = sciezka
                        Rezultat = plik.Split(Separator)
                        nazwa = Rezultat(UBound(Rezultat))
                        Label1.Text = nazwa
                    Else
                        RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.RichText)
                        sciezka = Save.FileName
                        Dim plik As String
                        Dim nazwa As String
                        Dim Separator As Char = CChar("\")
                        Dim Rezultat As String() = New String() {}

                        plik = sciezka
                        Rezultat = plik.Split(Separator)
                        nazwa = Rezultat(UBound(Rezultat))
                        Label1.Text = nazwa
                    End If
                    sciezka = Save.FileName ' przypisanie scieki do pliku

                Catch ex As Exception
                End Try
            End If
        End If

    End Sub
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles TQuickOpen.Click
        Me.OpenFileDialog1.Filter = "Plik Tekstowy (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
        Dim result As DialogResult = Me.OpenFileDialog1.ShowDialog
        Label2.Text = "Nazwa Pliku : "

        If result = Windows.Forms.DialogResult.OK Then
            If RichTextBox1.TextLength > 0 Then
                Try
                    Dim fileRoad As String

                    fileRoad = OpenFileDialog1.FileName


                    Dim pi As New ProcessStartInfo("EditPad.exe", fileRoad)
                    Process.Start(pi)
                    OpenFileDialog1.FileName = sciezka 'stare okienko zapisywalo w nowym pliku tory zostal co dopiero otwarty
                Catch ex As Exception
                End Try
            Else
                If OpenFileDialog1.FilterIndex = 2 Then ' zamiast tego moglem uzyc to co zrobilem w T_form, czyli sprawdzic rozszerzenie, ale nie chcilo mi sie zmieniac :P

                    RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
                    sciezka = OpenFileDialog1.FileName
                    Dim plik As String 'wyswietlenie samej nazwy
                    Dim nazwa As String
                    Dim Separator As Char = CChar("\")
                    Dim Rezultat As String() = New String() {}

                    plik = sciezka
                    Rezultat = plik.Split(Separator)
                    nazwa = Rezultat(UBound(Rezultat))
                    Label1.Text = nazwa
                Else

                    RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    sciezka = OpenFileDialog1.FileName
                    Dim plik As String
                    Dim nazwa As String
                    Dim Separator As Char = CChar("\")
                    Dim Rezultat As String() = New String() {}

                    plik = sciezka
                    Rezultat = plik.Split(Separator)
                    nazwa = Rezultat(UBound(Rezultat))
                    Label1.Text = nazwa
                End If
                End If
        End If
    End Sub

    Private Sub OtwórzToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OtwórzToolStripMenuItem.Click
        Me.OpenFileDialog1.Filter = "Plik Tekstowy (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
        Dim result As DialogResult = Me.OpenFileDialog1.ShowDialog
        Label2.Text = "Nazwa Pliku : "

        If result = Windows.Forms.DialogResult.OK Then
            If RichTextBox1.TextLength > 0 Then
                Try
                    Dim fileRoad As String

                    fileRoad = OpenFileDialog1.FileName


                    Dim pi As New ProcessStartInfo("EditPad.exe", fileRoad)
                    Process.Start(pi)
                    OpenFileDialog1.FileName = sciezka 'stare okienko zapisywalo w nowym pliku tory zostal co dopiero otwarty
                Catch ex As Exception
                End Try
            Else
                If OpenFileDialog1.FilterIndex = 2 Then ' zamiast tego moglem uzyc to co zrobilem w T_form, czyli sprawdzic rozszerzenie, ale nie chcilo mi sie zmieniac :P

                    RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
                    sciezka = OpenFileDialog1.FileName
                    Dim plik As String
                    Dim nazwa As String
                    Dim Separator As Char = CChar("\")
                    Dim Rezultat As String() = New String() {}

                    plik = sciezka
                    Rezultat = plik.Split(Separator)
                    nazwa = Rezultat(UBound(Rezultat))
                    Label1.Text = nazwa
                Else

                    RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
                    sciezka = OpenFileDialog1.FileName
                    Dim plik As String
                    Dim nazwa As String
                    Dim Separator As Char = CChar("\")
                    Dim Rezultat As String() = New String() {}

                    plik = sciezka
                    Rezultat = plik.Split(Separator)
                    nazwa = Rezultat(UBound(Rezultat))
                    Label1.Text = nazwa

                End If
            End If
        End If
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        
        Dim arguments As String = Command() 'sciezka pliku
        Dim plik As String
        Dim nazwa As String
        Dim Separator As Char = CChar("\")
        Dim Rezultat As String() = New String() {}

        plik = arguments
        Rezultat = plik.Split(Separator)
        nazwa = Rezultat(UBound(Rezultat))
        Label1.Text = nazwa
        Label2.Text = "Nazwa Pliku : "
        sciezka = arguments
        Me.OpenFileDialog1.Filter = "Plik Tekstowy (*.txt)|*.txt |rtf files (*.rtf)|*.rtf"
        If arguments = String.Empty Then
           
            RichTextBox1.Text += ""

        Else
            

            Dim i As Long
            i = InStr(arguments, ".txt") ' sprawdzenie czy jest to rozszerzenie txt lub rtf
            If i Then ' sprawdzamy czy to prawda jesli tak odczytujemy plik jako txt 



                Dim tempstr As String = arguments.Replace("""", "")
                Dim sr As New System.IO.StreamReader(tempstr, System.Text.Encoding.Default)

                Try
                    RichTextBox1.Text = sr.ReadToEnd
                    sr.Close()

                Catch ex As Exception
                    RichTextBox1.Text = ex.ToString
                End Try
            Else
                'tu odczytujemy plik w kodowaniu richText aby z owtorzyc w .rtf czyli mieć kolory itp
                RichTextBox1.LoadFile(arguments, RichTextBoxStreamType.RichText)
            End If

        End If


    End Sub
    Dim lngTimer As Long
    Dim ileCzasZapis As Long
    Private Sub Ti_Tick(sender As System.Object, e As System.EventArgs) Handles Ti.Tick

        lngTimer = lngTimer + 1
        If lngTimer = ileCzasZapis Then
            Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
            Save.FilterIndex = 1
            Save.RestoreDirectory = True


            Dim i As Long
            i = InStr(sciezka, ".txt") ' sprawdzenie czy jest to rozszerzenie txt lub rtf
            If i Then ' sprawdzamy czy to prawda jesli tak odczytujemy plik jako txt 

                System.IO.File.WriteAllLines(sciezka, RichTextBox1.Lines) ' nadpisanie pliku

                lngTimer = 0

            Else

                RichTextBox1.SaveFile(Save.FileName, RichTextBoxStreamType.RichText)
                lngTimer = 0
            End If

        End If




    End Sub

    Private Sub piec_Click(sender As System.Object, e As System.EventArgs) Handles piec.Click
        'autosave 5 min
        Ti.Enabled = True ' odpalamy funkcje zegara wyzej
        ileCzasZapis = 300 ' jest to 5 min
        lngTimer = 0 ' odliczany czas
        Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf" ' filtr zapisu, czyli jakie sa dostepne zapisy
        Save.FilterIndex = 1
        Save.RestoreDirectory = True
        If System.IO.File.Exists(sciezka) = False Then ' sprawdzamy czy przy uruchomieniu autozapisu plik istnieje, jesli nie to go zapisuje


            If (Save.ShowDialog = vbOK) Then
                Try
                    System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines)
                    sciezka = Save.FileName ' przypisanie scieki do pliku
                Catch ex As Exception
                End Try
            End If
        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        'autosave 10 min
        Ti.Enabled = True
        ileCzasZapis = 600
        lngTimer = 0
        Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
        Save.FilterIndex = 1
        Save.RestoreDirectory = True
        If System.IO.File.Exists(sciezka) = False Then


            If (Save.ShowDialog = vbOK) Then
                Try
                    System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines)
                    sciezka = Save.FileName ' przypisanie scieki do pliku
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        'autosave 15 min
        Ti.Enabled = True
        ileCzasZapis = 900
        lngTimer = 0
        Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
        Save.FilterIndex = 1
        Save.RestoreDirectory = True
        If System.IO.File.Exists(sciezka) = False Then


            If (Save.ShowDialog = vbOK) Then
                Try
                    System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines)
                    sciezka = Save.FileName ' przypisanie scieki do pliku
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        'autosave 20 min
        Ti.Enabled = True
        ileCzasZapis = 1200
        lngTimer = 0
        Save.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf"
        Save.FilterIndex = 1
        Save.RestoreDirectory = True
        If System.IO.File.Exists(sciezka) = False Then


            If (Save.ShowDialog = vbOK) Then
                Try
                    System.IO.File.WriteAllLines(Save.FileName, RichTextBox1.Lines)
                    sciezka = Save.FileName ' przypisanie scieki do pliku
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Ti.Enabled = False ' anulowanie odliczanie czasu dla autozapisu
    End Sub

    Private Sub ToolStripButton9_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton9.Click
        Dim Font As New FontDialog() 'przykladwowe dzialanie liter T
        Font.Font = RichTextBox1.Font

        Font.ShowDialog()
        Try
            RichTextBox1.Font = Font.Font
        Catch ex As Exception
        End Try
    End Sub

    Private Sub KopiujToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopiujToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub WytnijToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WytnijToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub WklejToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WklejToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim bfont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style + FontStyle.Bold)
        Dim rfont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style - FontStyle.Bold)

            If RichTextBox1.SelectionFont.Bold Then
                RichTextBox1.SelectionFont = rfont
            Else
                RichTextBox1.SelectionFont = bfont
            End If

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim Ifont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style + FontStyle.Italic)
        Dim rfont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style - FontStyle.Italic)

        If RichTextBox1.SelectionFont.Italic Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ifont

        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Dim ufont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style + FontStyle.Underline)
        Dim rfont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style - FontStyle.Underline)

        If RichTextBox1.SelectionFont.Underline Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = ufont

        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim Sfont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style + FontStyle.Strikeout)
        Dim rfont As New Font(RichTextBox1.Font, RichTextBox1.SelectionFont.Style - FontStyle.Strikeout)

        If RichTextBox1.SelectionFont.Strikeout Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Sfont

        End If
    End Sub


End Class
