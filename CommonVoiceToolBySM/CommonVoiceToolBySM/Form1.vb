Public Class Form1
    Private RigheCorte As String = "Corte("
    Private RigheLunghe As String = "Lunghe("
    Private RigheDuplicate As String = "Duplicate("
    Private Sub ScegliFile_Click(sender As Object, e As EventArgs) Handles ScegliFile.Click
        If (ScegliFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            PercorsoFile.Text = ScegliFileDialog.FileName
            FileSelezionatoText.Text = (New IO.StreamReader(ScegliFileDialog.FileName())).ReadToEnd
            VediFile.Visible = True
            AnalizzaFile.Visible = True
            Risultato.Visible = False
        End If
    End Sub

    Private Sub VediFile_Click(sender As Object, e As EventArgs) Handles VediFile.Click
        If FileSelezionatoText.Visible Then
            FileSelezionatoText.Visible = False
            VediFile.Text = "Vedi file selezionato"
        Else
            FileSelezionatoText.Visible = True
            VediFile.Text = "Nascondi file selezionato"
        End If
    End Sub

    Private Sub AnalizzaFile_Click(sender As Object, e As EventArgs) Handles AnalizzaFile.Click
        Dim inizioTime As String = ("Inizio:" & vbNewLine & DateTime.Now.ToString("HH:mm:ss"))
        RigheCorte = "Corte("
        RigheLunghe = "Lunghe("
        RigheDuplicate = "Duplicate("
        If (PercorsoFile.Text <> "Nessun file selezionato") Then
            NumeroRighe.Text = FileSelezionatoText.Lines.Length.ToString()
            Dim min As Integer = Int(LunghezzaMin.Text)
            Dim max As Integer = Int(LunghezzaMax.Text)
            Dim nmin As Integer = 0
            Dim nmax As Integer = 0
            Dim nriga As Integer = 0
            While (nriga < Int(NumeroRighe.Text))
                If (FileSelezionatoText.Lines(nriga).Length > max) Then
                    nmax += 1
                    If (nmax > 1) Then
                        RigheLunghe &= (", " & (nriga + 1))
                    Else
                        RigheLunghe &= ("" & (nriga + 1))
                    End If
                ElseIf (FileSelezionatoText.Lines(nriga).Length < min) Then
                    nmin += 1
                    If (nmin > 1) Then
                        RigheCorte &= (", " & (nriga + 1))
                    Else
                        RigheCorte &= ("" & (nriga + 1))
                    End If
                End If
                nriga += 1
            End While
            Dim nduplicate As Integer = 0
            If (VerificaStringheDuplicate.Checked) Then
                nriga = 0
                Dim nriga2 As Integer = 0
                While (nriga < Int(NumeroRighe.Text) - 1)
                    nriga2 = nriga + 1
                    Dim rigaPrincipale As String = FileSelezionatoText.Lines(nriga)
                    If (Not RigheDuplicate.Contains("[" & (nriga + 1) & "][") And Not RigheDuplicate.Contains("][" & (nriga + 1) & "]")) Then
                        While (nriga2 < Int(NumeroRighe.Text))
                            If (Not RigheDuplicate.Contains("][" & (nriga2 + 1) & "]")) Then
                                If (rigaPrincipale = FileSelezionatoText.Lines(nriga2)) Then
                                    nduplicate += 1
                                    If (nduplicate > 1) Then
                                        RigheDuplicate &= (", [" & (nriga + 1) & "][" & (nriga2 + 1) & "]")
                                    Else
                                        RigheDuplicate &= ("[" & (nriga + 1) & "][" & (nriga2 + 1) & "]")
                                    End If
                                End If
                            End If
                            nriga2 += 1
                        End While
                    End If
                    nriga += 1
                End While
                DuplicatePanel.Visible = True
            Else
                DuplicatePanel.Visible = False
            End If
            Corte.Text = nmin
            If (nmin > 0) Then
                DettagliCorte.Visible = True
                CopiaRigheCorte.Visible = True
            End If
            RigheCorte &= ")"
            Lunghe.Text = nmax
            If (nmax > 0) Then
                DettagliLunghe.Visible = True
                CopiaRigheLunghe.Visible = True
            End If
            RigheLunghe &= ")"
            If VerificaStringheDuplicate.Checked Then
                Duplicate.Text = nduplicate
                If (nduplicate > 0) Then
                    DettagliDuplicate.Visible = True
                    CopiaRigheDuplicate.Visible = True
                End If
                RigheDuplicate &= ")"
            End If

            Risultato.Visible = True
        End If
        Dim fineTime As String = ("Fine:" & vbNewLine & DateTime.Now.ToString("HH:mm:ss"))
        Inizio.Text = inizioTime
        Fine.Text = fineTime
    End Sub

    Private Sub DettagliCorte_Click(sender As Object, e As EventArgs) Handles DettagliCorte.Click
        MsgBox(RigheCorte)
    End Sub

    Private Sub DettagliLunghe_Click(sender As Object, e As EventArgs) Handles DettagliLunghe.Click
        MsgBox(RigheLunghe)
    End Sub

    Private Sub CopiaRigheCorte_Click(sender As Object, e As EventArgs) Handles CopiaRigheCorte.Click
        Clipboard.SetText(RigheCorte)
    End Sub

    Private Sub CopiaRigheLunghe_Click(sender As Object, e As EventArgs) Handles CopiaRigheLunghe.Click
        Clipboard.SetText(RigheLunghe)
    End Sub

    Private Sub DettagliDuplicate_Click(sender As Object, e As EventArgs) Handles DettagliDuplicate.Click
        MsgBox(RigheDuplicate)
    End Sub

    Private Sub CopiaRigheDuplicate_Click(sender As Object, e As EventArgs) Handles CopiaRigheDuplicate.Click
        Clipboard.SetText(RigheDuplicate)
    End Sub
End Class
