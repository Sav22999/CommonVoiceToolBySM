<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ScegliFile = New System.Windows.Forms.Button()
        Me.VediFile = New System.Windows.Forms.Button()
        Me.PercorsoFile = New System.Windows.Forms.Label()
        Me.ScegliFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.AnalizzaFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LunghezzaMin = New System.Windows.Forms.TextBox()
        Me.LunghezzaMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Corte = New System.Windows.Forms.TextBox()
        Me.Lunghe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DettagliCorte = New System.Windows.Forms.Button()
        Me.DettagliLunghe = New System.Windows.Forms.Button()
        Me.Risultato = New System.Windows.Forms.Panel()
        Me.Fine = New System.Windows.Forms.Label()
        Me.Inizio = New System.Windows.Forms.Label()
        Me.CopiaRigheLunghe = New System.Windows.Forms.Button()
        Me.CopiaRigheCorte = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumeroRighe = New System.Windows.Forms.TextBox()
        Me.DuplicatePanel = New System.Windows.Forms.Panel()
        Me.CopiaRigheDuplicate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DettagliDuplicate = New System.Windows.Forms.Button()
        Me.Duplicate = New System.Windows.Forms.TextBox()
        Me.FileSelezionatoText = New System.Windows.Forms.TextBox()
        Me.VerificaStringheDuplicate = New System.Windows.Forms.CheckBox()
        Me.Risultato.SuspendLayout()
        Me.DuplicatePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScegliFile
        '
        Me.ScegliFile.BackColor = System.Drawing.Color.Black
        Me.ScegliFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ScegliFile.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ScegliFile.FlatAppearance.BorderSize = 0
        Me.ScegliFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ScegliFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ScegliFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScegliFile.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScegliFile.ForeColor = System.Drawing.Color.White
        Me.ScegliFile.Location = New System.Drawing.Point(12, 12)
        Me.ScegliFile.Name = "ScegliFile"
        Me.ScegliFile.Size = New System.Drawing.Size(144, 43)
        Me.ScegliFile.TabIndex = 0
        Me.ScegliFile.Text = "Scegli file..."
        Me.ScegliFile.UseVisualStyleBackColor = False
        '
        'VediFile
        '
        Me.VediFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VediFile.BackColor = System.Drawing.Color.Black
        Me.VediFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VediFile.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.VediFile.FlatAppearance.BorderSize = 0
        Me.VediFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VediFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.VediFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VediFile.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VediFile.ForeColor = System.Drawing.Color.White
        Me.VediFile.Location = New System.Drawing.Point(557, 12)
        Me.VediFile.Name = "VediFile"
        Me.VediFile.Size = New System.Drawing.Size(208, 43)
        Me.VediFile.TabIndex = 1
        Me.VediFile.Text = "Vedi file selezionato"
        Me.VediFile.UseVisualStyleBackColor = False
        Me.VediFile.Visible = False
        '
        'PercorsoFile
        '
        Me.PercorsoFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercorsoFile.AutoEllipsis = True
        Me.PercorsoFile.Location = New System.Drawing.Point(162, 12)
        Me.PercorsoFile.Name = "PercorsoFile"
        Me.PercorsoFile.Size = New System.Drawing.Size(389, 43)
        Me.PercorsoFile.TabIndex = 2
        Me.PercorsoFile.Text = "Nessun file selezionato"
        Me.PercorsoFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ScegliFileDialog
        '
        Me.ScegliFileDialog.FileName = "OpenFileDialog1"
        Me.ScegliFileDialog.Filter = "File di testo|*.txt"
        Me.ScegliFileDialog.Title = "Scegli file da analizzare"
        '
        'AnalizzaFile
        '
        Me.AnalizzaFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AnalizzaFile.BackColor = System.Drawing.Color.Black
        Me.AnalizzaFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnalizzaFile.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AnalizzaFile.FlatAppearance.BorderSize = 0
        Me.AnalizzaFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AnalizzaFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AnalizzaFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnalizzaFile.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalizzaFile.ForeColor = System.Drawing.Color.White
        Me.AnalizzaFile.Location = New System.Drawing.Point(266, 184)
        Me.AnalizzaFile.Name = "AnalizzaFile"
        Me.AnalizzaFile.Size = New System.Drawing.Size(261, 43)
        Me.AnalizzaFile.TabIndex = 3
        Me.AnalizzaFile.Text = "Analizza file"
        Me.AnalizzaFile.UseVisualStyleBackColor = False
        Me.AnalizzaFile.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lunghezza minima riga:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lunghezza massima riga:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LunghezzaMin
        '
        Me.LunghezzaMin.BackColor = System.Drawing.Color.White
        Me.LunghezzaMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LunghezzaMin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LunghezzaMin.ForeColor = System.Drawing.Color.Black
        Me.LunghezzaMin.Location = New System.Drawing.Point(203, 78)
        Me.LunghezzaMin.Name = "LunghezzaMin"
        Me.LunghezzaMin.Size = New System.Drawing.Size(100, 26)
        Me.LunghezzaMin.TabIndex = 6
        Me.LunghezzaMin.Text = "0"
        '
        'LunghezzaMax
        '
        Me.LunghezzaMax.BackColor = System.Drawing.Color.White
        Me.LunghezzaMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LunghezzaMax.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LunghezzaMax.ForeColor = System.Drawing.Color.Black
        Me.LunghezzaMax.Location = New System.Drawing.Point(203, 110)
        Me.LunghezzaMax.Name = "LunghezzaMax"
        Me.LunghezzaMax.Size = New System.Drawing.Size(100, 26)
        Me.LunghezzaMax.TabIndex = 7
        Me.LunghezzaMax.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Location = New System.Drawing.Point(3, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Righe troppo corte:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Corte
        '
        Me.Corte.BackColor = System.Drawing.Color.White
        Me.Corte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Corte.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte.ForeColor = System.Drawing.Color.Black
        Me.Corte.Location = New System.Drawing.Point(182, 33)
        Me.Corte.Name = "Corte"
        Me.Corte.ReadOnly = True
        Me.Corte.Size = New System.Drawing.Size(100, 26)
        Me.Corte.TabIndex = 12
        Me.Corte.Text = "0"
        '
        'Lunghe
        '
        Me.Lunghe.BackColor = System.Drawing.Color.White
        Me.Lunghe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lunghe.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lunghe.ForeColor = System.Drawing.Color.Black
        Me.Lunghe.Location = New System.Drawing.Point(182, 65)
        Me.Lunghe.Name = "Lunghe"
        Me.Lunghe.ReadOnly = True
        Me.Lunghe.Size = New System.Drawing.Size(100, 26)
        Me.Lunghe.TabIndex = 13
        Me.Lunghe.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.Location = New System.Drawing.Point(3, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Righe troppo lunghe:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DettagliCorte
        '
        Me.DettagliCorte.BackColor = System.Drawing.Color.Black
        Me.DettagliCorte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DettagliCorte.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DettagliCorte.FlatAppearance.BorderSize = 0
        Me.DettagliCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DettagliCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DettagliCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DettagliCorte.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DettagliCorte.ForeColor = System.Drawing.Color.White
        Me.DettagliCorte.Location = New System.Drawing.Point(288, 33)
        Me.DettagliCorte.Name = "DettagliCorte"
        Me.DettagliCorte.Size = New System.Drawing.Size(192, 26)
        Me.DettagliCorte.TabIndex = 15
        Me.DettagliCorte.Text = "Mostra dettagli"
        Me.DettagliCorte.UseVisualStyleBackColor = False
        Me.DettagliCorte.Visible = False
        '
        'DettagliLunghe
        '
        Me.DettagliLunghe.BackColor = System.Drawing.Color.Black
        Me.DettagliLunghe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DettagliLunghe.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DettagliLunghe.FlatAppearance.BorderSize = 0
        Me.DettagliLunghe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DettagliLunghe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DettagliLunghe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DettagliLunghe.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DettagliLunghe.ForeColor = System.Drawing.Color.White
        Me.DettagliLunghe.Location = New System.Drawing.Point(288, 65)
        Me.DettagliLunghe.Name = "DettagliLunghe"
        Me.DettagliLunghe.Size = New System.Drawing.Size(192, 26)
        Me.DettagliLunghe.TabIndex = 16
        Me.DettagliLunghe.Text = "Mostra dettagli"
        Me.DettagliLunghe.UseVisualStyleBackColor = False
        Me.DettagliLunghe.Visible = False
        '
        'Risultato
        '
        Me.Risultato.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Risultato.Controls.Add(Me.Fine)
        Me.Risultato.Controls.Add(Me.Inizio)
        Me.Risultato.Controls.Add(Me.CopiaRigheLunghe)
        Me.Risultato.Controls.Add(Me.CopiaRigheCorte)
        Me.Risultato.Controls.Add(Me.Label5)
        Me.Risultato.Controls.Add(Me.NumeroRighe)
        Me.Risultato.Controls.Add(Me.DettagliLunghe)
        Me.Risultato.Controls.Add(Me.Label3)
        Me.Risultato.Controls.Add(Me.DettagliCorte)
        Me.Risultato.Controls.Add(Me.Corte)
        Me.Risultato.Controls.Add(Me.Label4)
        Me.Risultato.Controls.Add(Me.Lunghe)
        Me.Risultato.Controls.Add(Me.DuplicatePanel)
        Me.Risultato.Location = New System.Drawing.Point(12, 233)
        Me.Risultato.Name = "Risultato"
        Me.Risultato.Size = New System.Drawing.Size(753, 131)
        Me.Risultato.TabIndex = 17
        Me.Risultato.Visible = False
        '
        'Fine
        '
        Me.Fine.AutoEllipsis = True
        Me.Fine.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fine.Location = New System.Drawing.Point(642, 39)
        Me.Fine.Name = "Fine"
        Me.Fine.Size = New System.Drawing.Size(111, 39)
        Me.Fine.TabIndex = 27
        Me.Fine.Text = "Fine:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00:00"
        Me.Fine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Inizio
        '
        Me.Inizio.AutoEllipsis = True
        Me.Inizio.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inizio.Location = New System.Drawing.Point(642, 0)
        Me.Inizio.Name = "Inizio"
        Me.Inizio.Size = New System.Drawing.Size(111, 39)
        Me.Inizio.TabIndex = 26
        Me.Inizio.Text = "Inizio:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00:00:00"
        Me.Inizio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CopiaRigheLunghe
        '
        Me.CopiaRigheLunghe.BackColor = System.Drawing.Color.Black
        Me.CopiaRigheLunghe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopiaRigheLunghe.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CopiaRigheLunghe.FlatAppearance.BorderSize = 0
        Me.CopiaRigheLunghe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopiaRigheLunghe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CopiaRigheLunghe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopiaRigheLunghe.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopiaRigheLunghe.ForeColor = System.Drawing.Color.White
        Me.CopiaRigheLunghe.Location = New System.Drawing.Point(481, 65)
        Me.CopiaRigheLunghe.Name = "CopiaRigheLunghe"
        Me.CopiaRigheLunghe.Size = New System.Drawing.Size(127, 26)
        Me.CopiaRigheLunghe.TabIndex = 20
        Me.CopiaRigheLunghe.Text = "Copia righe"
        Me.CopiaRigheLunghe.UseVisualStyleBackColor = False
        Me.CopiaRigheLunghe.Visible = False
        '
        'CopiaRigheCorte
        '
        Me.CopiaRigheCorte.BackColor = System.Drawing.Color.Black
        Me.CopiaRigheCorte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopiaRigheCorte.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CopiaRigheCorte.FlatAppearance.BorderSize = 0
        Me.CopiaRigheCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopiaRigheCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CopiaRigheCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopiaRigheCorte.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopiaRigheCorte.ForeColor = System.Drawing.Color.White
        Me.CopiaRigheCorte.Location = New System.Drawing.Point(481, 33)
        Me.CopiaRigheCorte.Name = "CopiaRigheCorte"
        Me.CopiaRigheCorte.Size = New System.Drawing.Size(127, 26)
        Me.CopiaRigheCorte.TabIndex = 19
        Me.CopiaRigheCorte.Text = "Copia righe"
        Me.CopiaRigheCorte.UseVisualStyleBackColor = False
        Me.CopiaRigheCorte.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Location = New System.Drawing.Point(3, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 26)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Numero di righe:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumeroRighe
        '
        Me.NumeroRighe.BackColor = System.Drawing.Color.White
        Me.NumeroRighe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroRighe.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroRighe.ForeColor = System.Drawing.Color.Black
        Me.NumeroRighe.Location = New System.Drawing.Point(182, 1)
        Me.NumeroRighe.Name = "NumeroRighe"
        Me.NumeroRighe.ReadOnly = True
        Me.NumeroRighe.Size = New System.Drawing.Size(100, 26)
        Me.NumeroRighe.TabIndex = 18
        Me.NumeroRighe.Text = "0"
        '
        'DuplicatePanel
        '
        Me.DuplicatePanel.Controls.Add(Me.CopiaRigheDuplicate)
        Me.DuplicatePanel.Controls.Add(Me.Label6)
        Me.DuplicatePanel.Controls.Add(Me.DettagliDuplicate)
        Me.DuplicatePanel.Controls.Add(Me.Duplicate)
        Me.DuplicatePanel.Location = New System.Drawing.Point(4, 97)
        Me.DuplicatePanel.Name = "DuplicatePanel"
        Me.DuplicatePanel.Size = New System.Drawing.Size(601, 26)
        Me.DuplicatePanel.TabIndex = 25
        '
        'CopiaRigheDuplicate
        '
        Me.CopiaRigheDuplicate.BackColor = System.Drawing.Color.Black
        Me.CopiaRigheDuplicate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CopiaRigheDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CopiaRigheDuplicate.FlatAppearance.BorderSize = 0
        Me.CopiaRigheDuplicate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CopiaRigheDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CopiaRigheDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopiaRigheDuplicate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopiaRigheDuplicate.ForeColor = System.Drawing.Color.White
        Me.CopiaRigheDuplicate.Location = New System.Drawing.Point(477, 0)
        Me.CopiaRigheDuplicate.Name = "CopiaRigheDuplicate"
        Me.CopiaRigheDuplicate.Size = New System.Drawing.Size(127, 26)
        Me.CopiaRigheDuplicate.TabIndex = 24
        Me.CopiaRigheDuplicate.Text = "Copia righe"
        Me.CopiaRigheDuplicate.UseVisualStyleBackColor = False
        Me.CopiaRigheDuplicate.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.Location = New System.Drawing.Point(-1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 26)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Righe duplicate:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DettagliDuplicate
        '
        Me.DettagliDuplicate.BackColor = System.Drawing.Color.Black
        Me.DettagliDuplicate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DettagliDuplicate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.DettagliDuplicate.FlatAppearance.BorderSize = 0
        Me.DettagliDuplicate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DettagliDuplicate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DettagliDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DettagliDuplicate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DettagliDuplicate.ForeColor = System.Drawing.Color.White
        Me.DettagliDuplicate.Location = New System.Drawing.Point(284, 0)
        Me.DettagliDuplicate.Name = "DettagliDuplicate"
        Me.DettagliDuplicate.Size = New System.Drawing.Size(192, 26)
        Me.DettagliDuplicate.TabIndex = 23
        Me.DettagliDuplicate.Text = "Mostra dettagli"
        Me.DettagliDuplicate.UseVisualStyleBackColor = False
        Me.DettagliDuplicate.Visible = False
        '
        'Duplicate
        '
        Me.Duplicate.BackColor = System.Drawing.Color.White
        Me.Duplicate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Duplicate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duplicate.ForeColor = System.Drawing.Color.Black
        Me.Duplicate.Location = New System.Drawing.Point(178, 0)
        Me.Duplicate.Name = "Duplicate"
        Me.Duplicate.ReadOnly = True
        Me.Duplicate.Size = New System.Drawing.Size(100, 26)
        Me.Duplicate.TabIndex = 21
        Me.Duplicate.Text = "0"
        '
        'FileSelezionatoText
        '
        Me.FileSelezionatoText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileSelezionatoText.BackColor = System.Drawing.Color.White
        Me.FileSelezionatoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileSelezionatoText.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSelezionatoText.ForeColor = System.Drawing.Color.Black
        Me.FileSelezionatoText.Location = New System.Drawing.Point(12, 58)
        Me.FileSelezionatoText.Multiline = True
        Me.FileSelezionatoText.Name = "FileSelezionatoText"
        Me.FileSelezionatoText.ReadOnly = True
        Me.FileSelezionatoText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.FileSelezionatoText.Size = New System.Drawing.Size(753, 306)
        Me.FileSelezionatoText.TabIndex = 18
        Me.FileSelezionatoText.Visible = False
        Me.FileSelezionatoText.WordWrap = False
        '
        'VerificaStringheDuplicate
        '
        Me.VerificaStringheDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerificaStringheDuplicate.Location = New System.Drawing.Point(12, 142)
        Me.VerificaStringheDuplicate.Name = "VerificaStringheDuplicate"
        Me.VerificaStringheDuplicate.Size = New System.Drawing.Size(291, 28)
        Me.VerificaStringheDuplicate.TabIndex = 19
        Me.VerificaStringheDuplicate.Text = "Verifica stringhe duplicate"
        Me.VerificaStringheDuplicate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(777, 376)
        Me.Controls.Add(Me.FileSelezionatoText)
        Me.Controls.Add(Me.VerificaStringheDuplicate)
        Me.Controls.Add(Me.LunghezzaMax)
        Me.Controls.Add(Me.LunghezzaMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AnalizzaFile)
        Me.Controls.Add(Me.PercorsoFile)
        Me.Controls.Add(Me.VediFile)
        Me.Controls.Add(Me.ScegliFile)
        Me.Controls.Add(Me.Risultato)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Common Voice Tool - by SM || versione 1.0"
        Me.Risultato.ResumeLayout(False)
        Me.Risultato.PerformLayout()
        Me.DuplicatePanel.ResumeLayout(False)
        Me.DuplicatePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScegliFile As Button
    Friend WithEvents VediFile As Button
    Friend WithEvents PercorsoFile As Label
    Friend WithEvents ScegliFileDialog As OpenFileDialog
    Friend WithEvents AnalizzaFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LunghezzaMin As TextBox
    Friend WithEvents LunghezzaMax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Corte As TextBox
    Friend WithEvents Lunghe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DettagliCorte As Button
    Friend WithEvents DettagliLunghe As Button
    Friend WithEvents Risultato As Panel
    Friend WithEvents FileSelezionatoText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumeroRighe As TextBox
    Friend WithEvents CopiaRigheLunghe As Button
    Friend WithEvents CopiaRigheCorte As Button
    Friend WithEvents CopiaRigheDuplicate As Button
    Friend WithEvents DettagliDuplicate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Duplicate As TextBox
    Friend WithEvents VerificaStringheDuplicate As CheckBox
    Friend WithEvents DuplicatePanel As Panel
    Friend WithEvents Fine As Label
    Friend WithEvents Inizio As Label
End Class
