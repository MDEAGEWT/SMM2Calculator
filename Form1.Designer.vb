<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnPng = New Button()
        CkTrace = New CheckBox()
        CkHitbox = New CheckBox()
        BtnFIns = New Button()
        CkCtrl = New CheckBox()
        BtnSave = New Button()
        CkFrame = New CheckBox()
        CkDuck = New CheckBox()
        CkMove = New CheckBox()
        BtnCls = New Button()
        CkLoc = New CheckBox()
        BUTTON_Operate = New Button()
        TR4 = New TextBox()
        BtnSrc = New Button()
        TR3 = New TextBox()
        BtnCal = New Button()
        TR2 = New TextBox()
        T1 = New TextBox()
        T2 = New TextBox()
        TSP = New CheckBox()
        TD = New TextBox()
        TS4 = New CheckBox()
        COMBOBOX_JumpAcc = New ComboBox()
        TY4 = New CheckBox()
        TS3 = New TextBox()
        TX4 = New CheckBox()
        LABEL_Hover = New Label()
        TS2 = New TextBox()
        TS1 = New TextBox()
        TxtAir = New TextBox()
        TY3 = New TextBox()
        TxtStrat = New TextBox()
        TY2 = New TextBox()
        LABEL_StrideLength = New Label()
        TxtStep = New TextBox()
        TX3 = New TextBox()
        TX2 = New TextBox()
        LblState = New Label()
        TX1 = New TextBox()
        COMBOBOX_Strat = New ComboBox()
        LblCal = New Label()
        MaterialCheckbox1 = New CheckBox()
        MaterialCheckbox2 = New CheckBox()
        MaterialCheckbox3 = New CheckBox()
        MaterialCheckbox4 = New CheckBox()
        MaterialCheckbox5 = New CheckBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        TFPS = New TextBox()
        LABEL_FPS = New Label()
        TxtFormLoc = New TextBox()
        LABEL_Position = New Label()
        TxtOpc = New TextBox()
        LABEL_Transparency = New Label()
        TDL = New TextBox()
        LABEL_FrameDelay = New Label()
        COMBOBOX_Theme = New ComboBox()
        COMBOBOX_Style = New ComboBox()
        COMBOBOX_SemiSolid = New ComboBox()
        COMBOBOX_Character = New ComboBox()
        COMBOBOX_Ground = New ComboBox()
        CHECK_Night = New CheckBox()
        BtnEmu = New Button()
        BtnScr = New Button()
        BtnPlay = New Button()
        BtnGif = New Button()
        BtnMont = New Button()
        BtnM01 = New Button()
        LABEL_StepLength = New Label()
        BtnM1 = New Button()
        LABEL_Dis = New Label()
        LABEL_StartPointY = New Label()
        BtnP1 = New Button()
        TYH = New NumericUpDown()
        BtnP01 = New Button()
        Label14 = New Label()
        TSPX2 = New TextBox()
        TY1 = New TextBox()
        Label25 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        TSY1 = New TextBox()
        TB = New NumericUpDown()
        LABEL_Height = New Label()
        LABEL_Width = New Label()
        LABEL_StartPointX = New Label()
        TYW = New NumericUpDown()
        NumH = New NumericUpDown()
        NumW = New NumericUpDown()
        TSPX1 = New TextBox()
        COMBOBOX_Item = New ComboBox()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label20 = New Label()
        CkMario = New CheckBox()
        LABEL_AC = New Label()
        Label18 = New Label()
        PBar = New ProgressBar()
        Label19 = New Label()
        CkBlk = New CheckBox()
        LBox = New ListBox()
        LABEL_FrameRate = New Label()
        LABEL_FaultTolerance = New Label()
        LABEL_Location = New Label()
        PB = New Cyotek.Windows.Forms.ImageBox()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        BUTTON_En = New Button()
        LABEL_Zoom = New Label()
        NumZoom = New NumericUpDown()
        BReadMem = New Button()
        CkMulti = New CheckBox()
        BtnTile = New Button()
        BAddHis = New Button()
        CB1F = New CheckBox()
        TSY3 = New TextBox()
        LABEL_SearchDepth = New Label()
        Label29 = New Label()
        NIns = New NumericUpDown()
        CkWU = New CheckBox()
        Label28 = New Label()
        BtnUndo = New Button()
        TSY2 = New TextBox()
        BCmdR = New Button()
        TSY4 = New CheckBox()
        T21 = New TextBox()
        BTas = New Button()
        T20 = New TextBox()
        BEmu = New Button()
        BtnTile2 = New Button()
        Panel2 = New Panel()
        LABEL_Strat = New Label()
        Panel3 = New Panel()
        BtnGenJump = New Button()
        LHis = New ListBox()
        TimerEmu = New Timer(components)
        PItem = New Cyotek.Windows.Forms.ImageBox()
        COMBOBOX_LanguageSettings = New ComboBox()
        CType(TYH, ComponentModel.ISupportInitialize).BeginInit()
        CType(TB, ComponentModel.ISupportInitialize).BeginInit()
        CType(TYW, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumH, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumW, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(NumZoom, ComponentModel.ISupportInitialize).BeginInit()
        CType(NIns, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnPng
        ' 
        BtnPng.BackColor = Color.White
        BtnPng.Enabled = False
        BtnPng.FlatStyle = FlatStyle.Flat
        BtnPng.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnPng.Location = New Point(264, 45)
        BtnPng.Name = "BtnPng"
        BtnPng.Size = New Size(43, 19)
        BtnPng.TabIndex = 82
        BtnPng.Text = "<BtnPng>"
        BtnPng.UseVisualStyleBackColor = False
        ' 
        ' CkTrace
        ' 
        CkTrace.AutoSize = True
        CkTrace.Checked = True
        CkTrace.CheckState = CheckState.Checked
        CkTrace.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkTrace.Location = New Point(291, 185)
        CkTrace.Name = "CkTrace"
        CkTrace.Size = New Size(61, 20)
        CkTrace.TabIndex = 25
        CkTrace.Text = "<Traj>"
        CkTrace.TextImageRelation = TextImageRelation.ImageBeforeText
        CkTrace.UseVisualStyleBackColor = True
        ' 
        ' CkHitbox
        ' 
        CkHitbox.AutoSize = True
        CkHitbox.Checked = True
        CkHitbox.CheckState = CheckState.Checked
        CkHitbox.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkHitbox.Location = New Point(291, 153)
        CkHitbox.Name = "CkHitbox"
        CkHitbox.Size = New Size(78, 20)
        CkHitbox.TabIndex = 23
        CkHitbox.Text = "<Hitbox>"
        CkHitbox.TextImageRelation = TextImageRelation.ImageBeforeText
        CkHitbox.UseVisualStyleBackColor = True
        ' 
        ' BtnFIns
        ' 
        BtnFIns.BackColor = SystemColors.Control
        BtnFIns.BackgroundImageLayout = ImageLayout.Zoom
        BtnFIns.FlatStyle = FlatStyle.Flat
        BtnFIns.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnFIns.Location = New Point(205, 359)
        BtnFIns.Name = "BtnFIns"
        BtnFIns.Size = New Size(72, 23)
        BtnFIns.TabIndex = 60
        BtnFIns.Text = "<Search>"
        BtnFIns.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnFIns.UseVisualStyleBackColor = False
        ' 
        ' CkCtrl
        ' 
        CkCtrl.AutoSize = True
        CkCtrl.Enabled = False
        CkCtrl.Font = New Font("Microsoft Sans Serif", 8.25F)
        CkCtrl.Location = New Point(311, 23)
        CkCtrl.Name = "CkCtrl"
        CkCtrl.Size = New Size(66, 17)
        CkCtrl.TabIndex = 78
        CkCtrl.Text = "<CkCtrl>"
        CkCtrl.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = SystemColors.Control
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnSave.Location = New Point(297, 106)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(57, 25)
        BtnSave.TabIndex = 66
        BtnSave.Text = "<Save>"
        BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' CkFrame
        ' 
        CkFrame.AutoSize = True
        CkFrame.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkFrame.Location = New Point(291, 137)
        CkFrame.Name = "CkFrame"
        CkFrame.Size = New Size(74, 20)
        CkFrame.TabIndex = 22
        CkFrame.Text = "<Frame>"
        CkFrame.TextImageRelation = TextImageRelation.ImageBeforeText
        CkFrame.UseVisualStyleBackColor = True
        ' 
        ' CkDuck
        ' 
        CkDuck.AutoSize = True
        CkDuck.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkDuck.Location = New Point(236, 4)
        CkDuck.Name = "CkDuck"
        CkDuck.Size = New Size(80, 20)
        CkDuck.TabIndex = 4
        CkDuck.Text = "<Crouch>"
        CkDuck.TextImageRelation = TextImageRelation.ImageBeforeText
        CkDuck.UseVisualStyleBackColor = True
        ' 
        ' CkMove
        ' 
        CkMove.AutoSize = True
        CkMove.Checked = True
        CkMove.CheckState = CheckState.Checked
        CkMove.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkMove.Location = New Point(291, 120)
        CkMove.Name = "CkMove"
        CkMove.Size = New Size(66, 20)
        CkMove.TabIndex = 21
        CkMove.Text = "<Cmd>"
        CkMove.TextImageRelation = TextImageRelation.ImageBeforeText
        CkMove.UseVisualStyleBackColor = True
        ' 
        ' BtnCls
        ' 
        BtnCls.BackColor = SystemColors.Control
        BtnCls.FlatStyle = FlatStyle.Flat
        BtnCls.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnCls.Location = New Point(4, 283)
        BtnCls.Name = "BtnCls"
        BtnCls.Size = New Size(51, 23)
        BtnCls.TabIndex = 45
        BtnCls.Text = "<Clear>"
        BtnCls.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCls.UseVisualStyleBackColor = False
        ' 
        ' CkLoc
        ' 
        CkLoc.AutoSize = True
        CkLoc.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkLoc.Location = New Point(291, 104)
        CkLoc.Name = "CkLoc"
        CkLoc.Size = New Size(74, 20)
        CkLoc.TabIndex = 20
        CkLoc.Text = "<Coord>"
        CkLoc.TextImageRelation = TextImageRelation.ImageBeforeText
        CkLoc.UseVisualStyleBackColor = True
        ' 
        ' BUTTON_Operate
        ' 
        BUTTON_Operate.BackColor = Color.White
        BUTTON_Operate.Enabled = False
        BUTTON_Operate.FlatStyle = FlatStyle.Flat
        BUTTON_Operate.Font = New Font("Microsoft Sans Serif", 8.25F)
        BUTTON_Operate.Location = New Point(310, 45)
        BUTTON_Operate.Name = "BUTTON_Operate"
        BUTTON_Operate.Size = New Size(43, 19)
        BUTTON_Operate.TabIndex = 83
        BUTTON_Operate.Text = "<Operate>"
        BUTTON_Operate.UseVisualStyleBackColor = False
        ' 
        ' TR4
        ' 
        TR4.BorderStyle = BorderStyle.FixedSingle
        TR4.Font = New Font("Microsoft YaHei UI", 8.25F)
        TR4.Location = New Point(99, 364)
        TR4.Name = "TR4"
        TR4.Size = New Size(43, 21)
        TR4.TabIndex = 58
        TR4.Text = "10"
        TR4.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnSrc
        ' 
        BtnSrc.BackColor = SystemColors.Control
        BtnSrc.FlatStyle = FlatStyle.Flat
        BtnSrc.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnSrc.Location = New Point(4, 238)
        BtnSrc.Name = "BtnSrc"
        BtnSrc.Size = New Size(126, 23)
        BtnSrc.TabIndex = 34
        BtnSrc.Text = "<Search>"
        BtnSrc.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSrc.UseVisualStyleBackColor = False
        ' 
        ' TR3
        ' 
        TR3.BorderStyle = BorderStyle.FixedSingle
        TR3.Font = New Font("Microsoft YaHei UI", 8.25F)
        TR3.Location = New Point(51, 364)
        TR3.Name = "TR3"
        TR3.Size = New Size(43, 21)
        TR3.TabIndex = 57
        TR3.Text = "0.1"
        TR3.TextAlign = HorizontalAlignment.Center
        ' 
        ' BtnCal
        ' 
        BtnCal.BackColor = SystemColors.Control
        BtnCal.BackgroundImageLayout = ImageLayout.Zoom
        BtnCal.FlatStyle = FlatStyle.Flat
        BtnCal.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnCal.Location = New Point(4, 211)
        BtnCal.Name = "BtnCal"
        BtnCal.Size = New Size(126, 23)
        BtnCal.TabIndex = 26
        BtnCal.Text = "<Calculate>"
        BtnCal.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCal.UseVisualStyleBackColor = False
        ' 
        ' TR2
        ' 
        TR2.BorderStyle = BorderStyle.FixedSingle
        TR2.Font = New Font("Microsoft YaHei UI", 8.25F)
        TR2.Location = New Point(4, 364)
        TR2.Name = "TR2"
        TR2.Size = New Size(43, 21)
        TR2.TabIndex = 56
        TR2.Text = "0"
        TR2.TextAlign = HorizontalAlignment.Center
        ' 
        ' T1
        ' 
        T1.BorderStyle = BorderStyle.FixedSingle
        T1.Font = New Font("Microsoft YaHei UI", 8.25F)
        T1.Location = New Point(4, 53)
        T1.Multiline = True
        T1.Name = "T1"
        T1.ScrollBars = ScrollBars.Vertical
        T1.Size = New Size(350, 35)
        T1.TabIndex = 63
        T1.Text = "1" & vbCrLf & "2" & vbCrLf & "3" & vbCrLf & "4" & vbCrLf & "5" & vbCrLf & "6"
        ' 
        ' T2
        ' 
        T2.BorderStyle = BorderStyle.FixedSingle
        T2.Font = New Font("Microsoft YaHei UI", 8.25F)
        T2.Location = New Point(4, 125)
        T2.Multiline = True
        T2.Name = "T2"
        T2.Size = New Size(279, 46)
        T2.TabIndex = 18
        T2.TabStop = False
        ' 
        ' TSP
        ' 
        TSP.AutoSize = True
        TSP.BackColor = Color.White
        TSP.Checked = True
        TSP.CheckState = CheckState.Checked
        TSP.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSP.Location = New Point(129, 264)
        TSP.Name = "TSP"
        TSP.Size = New Size(78, 20)
        TSP.TabIndex = 43
        TSP.Text = "<Hitbox>"
        TSP.UseVisualStyleBackColor = False
        ' 
        ' TD
        ' 
        TD.BorderStyle = BorderStyle.FixedSingle
        TD.Font = New Font("Microsoft YaHei UI", 8.25F)
        TD.Location = New Point(237, 49)
        TD.Name = "TD"
        TD.Size = New Size(43, 21)
        TD.TabIndex = 12
        TD.Text = "0"
        TD.TextAlign = HorizontalAlignment.Center
        ' 
        ' TS4
        ' 
        TS4.AutoSize = True
        TS4.BackColor = Color.White
        TS4.Font = New Font("Microsoft YaHei UI", 8.25F)
        TS4.Location = New Point(65, 264)
        TS4.Name = "TS4"
        TS4.Size = New Size(38, 20)
        TS4.TabIndex = 41
        TS4.Text = "Sx"
        TS4.UseVisualStyleBackColor = False
        ' 
        ' COMBOBOX_JumpAcc
        ' 
        COMBOBOX_JumpAcc.BackColor = SystemColors.Control
        COMBOBOX_JumpAcc.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_JumpAcc.Enabled = False
        COMBOBOX_JumpAcc.FlatStyle = FlatStyle.Flat
        COMBOBOX_JumpAcc.Font = New Font("Microsoft Sans Serif", 8.25F)
        COMBOBOX_JumpAcc.FormattingEnabled = True
        COMBOBOX_JumpAcc.Items.AddRange(New Object() {"3.868", "3.808", "3.748", "3.568", "3.588", "3.528", "3.468", "3.288"})
        COMBOBOX_JumpAcc.Location = New Point(257, 68)
        COMBOBOX_JumpAcc.Name = "COMBOBOX_JumpAcc"
        COMBOBOX_JumpAcc.Size = New Size(97, 21)
        COMBOBOX_JumpAcc.TabIndex = 86
        COMBOBOX_JumpAcc.Visible = False
        ' 
        ' TY4
        ' 
        TY4.AutoSize = True
        TY4.BackColor = Color.White
        TY4.Font = New Font("Microsoft YaHei UI", 8.25F)
        TY4.Location = New Point(35, 264)
        TY4.Name = "TY4"
        TY4.Size = New Size(33, 20)
        TY4.TabIndex = 40
        TY4.Text = "Y"
        TY4.UseVisualStyleBackColor = False
        ' 
        ' TS3
        ' 
        TS3.BorderStyle = BorderStyle.FixedSingle
        TS3.Font = New Font("Microsoft YaHei UI", 8.25F)
        TS3.Location = New Point(172, 49)
        TS3.Name = "TS3"
        TS3.Size = New Size(43, 21)
        TS3.TabIndex = 11
        TS3.Text = "0.001"
        TS3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TX4
        ' 
        TX4.AutoSize = True
        TX4.BackColor = Color.White
        TX4.Font = New Font("Microsoft YaHei UI", 8.25F)
        TX4.Location = New Point(5, 264)
        TX4.Name = "TX4"
        TX4.Size = New Size(33, 20)
        TX4.TabIndex = 39
        TX4.Text = "X"
        TX4.UseVisualStyleBackColor = False
        ' 
        ' LABEL_Hover
        ' 
        LABEL_Hover.AutoSize = True
        LABEL_Hover.Enabled = False
        LABEL_Hover.Font = New Font("Microsoft Sans Serif", 8.25F)
        LABEL_Hover.Location = New Point(131, 71)
        LABEL_Hover.Name = "LABEL_Hover"
        LABEL_Hover.Size = New Size(48, 13)
        LABEL_Hover.TabIndex = 40
        LABEL_Hover.Text = "<Hover>"
        LABEL_Hover.Visible = False
        ' 
        ' TS2
        ' 
        TS2.BorderStyle = BorderStyle.FixedSingle
        TS2.Font = New Font("Microsoft YaHei UI", 8.25F)
        TS2.Location = New Point(97, 49)
        TS2.Name = "TS2"
        TS2.Size = New Size(43, 21)
        TS2.TabIndex = 10
        TS2.Text = "0"
        TS2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TS1
        ' 
        TS1.BorderStyle = BorderStyle.FixedSingle
        TS1.Font = New Font("Microsoft YaHei UI", 8.25F)
        TS1.Location = New Point(27, 49)
        TS1.Name = "TS1"
        TS1.Size = New Size(43, 21)
        TS1.TabIndex = 9
        TS1.Text = "0"
        TS1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtAir
        ' 
        TxtAir.BorderStyle = BorderStyle.FixedSingle
        TxtAir.Enabled = False
        TxtAir.Font = New Font("Microsoft Sans Serif", 8.25F)
        TxtAir.Location = New Point(162, 68)
        TxtAir.Name = "TxtAir"
        TxtAir.Size = New Size(89, 20)
        TxtAir.TabIndex = 85
        TxtAir.Text = "0.00-0.00"
        TxtAir.TextAlign = HorizontalAlignment.Center
        TxtAir.Visible = False
        ' 
        ' TY3
        ' 
        TY3.BorderStyle = BorderStyle.FixedSingle
        TY3.Font = New Font("Microsoft YaHei UI", 8.25F)
        TY3.Location = New Point(172, 26)
        TY3.Name = "TY3"
        TY3.Size = New Size(43, 21)
        TY3.TabIndex = 7
        TY3.Text = "0.001"
        TY3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtStrat
        ' 
        TxtStrat.BorderStyle = BorderStyle.FixedSingle
        TxtStrat.Font = New Font("Microsoft YaHei UI", 8.25F)
        TxtStrat.Location = New Point(172, 106)
        TxtStrat.Name = "TxtStrat"
        TxtStrat.Size = New Size(120, 21)
        TxtStrat.TabIndex = 65
        ' 
        ' TY2
        ' 
        TY2.BorderStyle = BorderStyle.FixedSingle
        TY2.Font = New Font("Microsoft YaHei UI", 8.25F)
        TY2.Location = New Point(97, 26)
        TY2.Name = "TY2"
        TY2.Size = New Size(43, 21)
        TY2.TabIndex = 6
        TY2.Text = "0"
        TY2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LABEL_StrideLength
        ' 
        LABEL_StrideLength.AutoSize = True
        LABEL_StrideLength.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_StrideLength.Location = New Point(117, 288)
        LABEL_StrideLength.Name = "LABEL_StrideLength"
        LABEL_StrideLength.Size = New Size(46, 16)
        LABEL_StrideLength.TabIndex = 38
        LABEL_StrideLength.Text = "<Step>"
        ' 
        ' TxtStep
        ' 
        TxtStep.BorderStyle = BorderStyle.FixedSingle
        TxtStep.Font = New Font("Microsoft YaHei UI", 8.25F)
        TxtStep.Location = New Point(146, 286)
        TxtStep.Name = "TxtStep"
        TxtStep.Size = New Size(45, 21)
        TxtStep.TabIndex = 47
        TxtStep.Text = "0.00"
        TxtStep.TextAlign = HorizontalAlignment.Center
        ' 
        ' TX3
        ' 
        TX3.BackColor = SystemColors.Window
        TX3.BorderStyle = BorderStyle.FixedSingle
        TX3.Font = New Font("Microsoft YaHei UI", 8.25F)
        TX3.Location = New Point(172, 3)
        TX3.Name = "TX3"
        TX3.Size = New Size(43, 21)
        TX3.TabIndex = 3
        TX3.Text = "0.001"
        TX3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TX2
        ' 
        TX2.BackColor = SystemColors.Window
        TX2.BorderStyle = BorderStyle.FixedSingle
        TX2.Font = New Font("Microsoft YaHei UI", 8.25F)
        TX2.Location = New Point(97, 3)
        TX2.Name = "TX2"
        TX2.Size = New Size(43, 21)
        TX2.TabIndex = 2
        TX2.Text = "0"
        TX2.TextAlign = HorizontalAlignment.Center
        ' 
        ' LblState
        ' 
        LblState.AutoSize = True
        LblState.Font = New Font("Microsoft YaHei UI", 8.25F)
        LblState.Location = New Point(4, 3)
        LblState.Name = "LblState"
        LblState.Size = New Size(65, 16)
        LblState.TabIndex = 35
        LblState.Text = "<LblState>"
        ' 
        ' TX1
        ' 
        TX1.BackColor = SystemColors.Window
        TX1.BorderStyle = BorderStyle.FixedSingle
        TX1.Font = New Font("Microsoft YaHei UI", 8.25F)
        TX1.Location = New Point(27, 3)
        TX1.Name = "TX1"
        TX1.Size = New Size(43, 21)
        TX1.TabIndex = 1
        TX1.Text = "0"
        TX1.TextAlign = HorizontalAlignment.Center
        ' 
        ' COMBOBOX_Strat
        ' 
        COMBOBOX_Strat.BackColor = SystemColors.Control
        COMBOBOX_Strat.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_Strat.FlatStyle = FlatStyle.Flat
        COMBOBOX_Strat.Font = New Font("Microsoft YaHei UI", 8.25F)
        COMBOBOX_Strat.FormattingEnabled = True
        COMBOBOX_Strat.Location = New Point(4, 106)
        COMBOBOX_Strat.Name = "COMBOBOX_Strat"
        COMBOBOX_Strat.Size = New Size(150, 24)
        COMBOBOX_Strat.TabIndex = 64
        ' 
        ' LblCal
        ' 
        LblCal.AutoSize = True
        LblCal.Font = New Font("Microsoft YaHei UI", 8.25F)
        LblCal.Location = New Point(4, 391)
        LblCal.Name = "LblCal"
        LblCal.Size = New Size(55, 16)
        LblCal.TabIndex = 34
        LblCal.Text = "<LblCal>"
        ' 
        ' MaterialCheckbox1
        ' 
        MaterialCheckbox1.AutoSize = True
        MaterialCheckbox1.Location = New Point(0, 0)
        MaterialCheckbox1.Margin = New Padding(0)
        MaterialCheckbox1.Name = "MaterialCheckbox1"
        MaterialCheckbox1.Size = New Size(10, 10)
        MaterialCheckbox1.TabIndex = 0
        MaterialCheckbox1.Text = "MaterialCheckbox1"
        MaterialCheckbox1.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox2
        ' 
        MaterialCheckbox2.AutoSize = True
        MaterialCheckbox2.Location = New Point(0, 0)
        MaterialCheckbox2.Margin = New Padding(0)
        MaterialCheckbox2.Name = "MaterialCheckbox2"
        MaterialCheckbox2.Size = New Size(10, 10)
        MaterialCheckbox2.TabIndex = 0
        MaterialCheckbox2.Text = "MaterialCheckbox2"
        MaterialCheckbox2.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox3
        ' 
        MaterialCheckbox3.AutoSize = True
        MaterialCheckbox3.Location = New Point(0, 0)
        MaterialCheckbox3.Margin = New Padding(0)
        MaterialCheckbox3.Name = "MaterialCheckbox3"
        MaterialCheckbox3.Size = New Size(10, 10)
        MaterialCheckbox3.TabIndex = 0
        MaterialCheckbox3.Text = "MaterialCheckbox3"
        MaterialCheckbox3.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox4
        ' 
        MaterialCheckbox4.AutoSize = True
        MaterialCheckbox4.Location = New Point(0, 0)
        MaterialCheckbox4.Margin = New Padding(0)
        MaterialCheckbox4.Name = "MaterialCheckbox4"
        MaterialCheckbox4.Size = New Size(10, 10)
        MaterialCheckbox4.TabIndex = 0
        MaterialCheckbox4.Text = "MaterialCheckbox4"
        MaterialCheckbox4.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox5
        ' 
        MaterialCheckbox5.AutoSize = True
        MaterialCheckbox5.Location = New Point(0, 0)
        MaterialCheckbox5.Margin = New Padding(0)
        MaterialCheckbox5.Name = "MaterialCheckbox5"
        MaterialCheckbox5.Size = New Size(10, 10)
        MaterialCheckbox5.TabIndex = 0
        MaterialCheckbox5.Text = "MaterialCheckbox5"
        MaterialCheckbox5.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 15
        ' 
        ' TFPS
        ' 
        TFPS.BorderStyle = BorderStyle.FixedSingle
        TFPS.Font = New Font("Microsoft Sans Serif", 8.25F)
        TFPS.Location = New Point(87, 22)
        TFPS.Name = "TFPS"
        TFPS.Size = New Size(43, 20)
        TFPS.TabIndex = 73
        TFPS.Text = "60"
        TFPS.TextAlign = HorizontalAlignment.Center
        ' 
        ' LABEL_FPS
        ' 
        LABEL_FPS.AutoSize = True
        LABEL_FPS.Font = New Font("Microsoft Sans Serif", 8.25F)
        LABEL_FPS.Location = New Point(87, 7)
        LABEL_FPS.Name = "LABEL_FPS"
        LABEL_FPS.Size = New Size(27, 13)
        LABEL_FPS.TabIndex = 52
        LABEL_FPS.Text = "FPS"
        ' 
        ' TxtFormLoc
        ' 
        TxtFormLoc.BorderStyle = BorderStyle.FixedSingle
        TxtFormLoc.Font = New Font("Microsoft Sans Serif", 8.25F)
        TxtFormLoc.Location = New Point(130, 22)
        TxtFormLoc.Name = "TxtFormLoc"
        TxtFormLoc.Size = New Size(43, 20)
        TxtFormLoc.TabIndex = 74
        TxtFormLoc.Text = "0"
        TxtFormLoc.TextAlign = HorizontalAlignment.Center
        ' 
        ' LABEL_Position
        ' 
        LABEL_Position.AutoSize = True
        LABEL_Position.Font = New Font("Microsoft Sans Serif", 8.25F)
        LABEL_Position.Location = New Point(130, 7)
        LABEL_Position.Name = "LABEL_Position"
        LABEL_Position.Size = New Size(56, 13)
        LABEL_Position.TabIndex = 54
        LABEL_Position.Text = "<Position>"
        ' 
        ' TxtOpc
        ' 
        TxtOpc.BorderStyle = BorderStyle.FixedSingle
        TxtOpc.Font = New Font("Microsoft Sans Serif", 8.25F)
        TxtOpc.Location = New Point(173, 22)
        TxtOpc.Name = "TxtOpc"
        TxtOpc.Size = New Size(43, 20)
        TxtOpc.TabIndex = 75
        TxtOpc.Text = "30"
        TxtOpc.TextAlign = HorizontalAlignment.Center
        ' 
        ' LABEL_Transparency
        ' 
        LABEL_Transparency.AutoSize = True
        LABEL_Transparency.Font = New Font("Microsoft Sans Serif", 8.25F)
        LABEL_Transparency.Location = New Point(173, 7)
        LABEL_Transparency.Name = "LABEL_Transparency"
        LABEL_Transparency.Size = New Size(84, 13)
        LABEL_Transparency.TabIndex = 56
        LABEL_Transparency.Text = "<Transparency>"
        ' 
        ' TDL
        ' 
        TDL.BorderStyle = BorderStyle.FixedSingle
        TDL.Font = New Font("Microsoft Sans Serif", 8.25F)
        TDL.Location = New Point(216, 22)
        TDL.Name = "TDL"
        TDL.Size = New Size(43, 20)
        TDL.TabIndex = 76
        TDL.Text = "100"
        TDL.TextAlign = HorizontalAlignment.Center
        ' 
        ' LABEL_FrameDelay
        ' 
        LABEL_FrameDelay.AutoSize = True
        LABEL_FrameDelay.Font = New Font("Microsoft Sans Serif", 8.25F)
        LABEL_FrameDelay.Location = New Point(216, 7)
        LABEL_FrameDelay.Name = "LABEL_FrameDelay"
        LABEL_FrameDelay.Size = New Size(75, 13)
        LABEL_FrameDelay.TabIndex = 58
        LABEL_FrameDelay.Text = "<FrameDelay>"
        ' 
        ' COMBOBOX_Theme
        ' 
        COMBOBOX_Theme.BackColor = SystemColors.Control
        COMBOBOX_Theme.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_Theme.FlatStyle = FlatStyle.Flat
        COMBOBOX_Theme.Font = New Font("Microsoft Sans Serif", 8.25F)
        COMBOBOX_Theme.FormattingEnabled = True
        COMBOBOX_Theme.Location = New Point(4, 3)
        COMBOBOX_Theme.Name = "COMBOBOX_Theme"
        COMBOBOX_Theme.Size = New Size(77, 21)
        COMBOBOX_Theme.TabIndex = 67
        ' 
        ' COMBOBOX_Style
        ' 
        COMBOBOX_Style.BackColor = SystemColors.Control
        COMBOBOX_Style.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_Style.FlatStyle = FlatStyle.Flat
        COMBOBOX_Style.Font = New Font("Microsoft Sans Serif", 8.25F)
        COMBOBOX_Style.FormattingEnabled = True
        COMBOBOX_Style.Location = New Point(4, 25)
        COMBOBOX_Style.Name = "COMBOBOX_Style"
        COMBOBOX_Style.Size = New Size(76, 21)
        COMBOBOX_Style.TabIndex = 68
        ' 
        ' COMBOBOX_SemiSolid
        ' 
        COMBOBOX_SemiSolid.BackColor = SystemColors.Control
        COMBOBOX_SemiSolid.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_SemiSolid.FlatStyle = FlatStyle.Flat
        COMBOBOX_SemiSolid.Font = New Font("Microsoft Sans Serif", 8.25F)
        COMBOBOX_SemiSolid.FormattingEnabled = True
        COMBOBOX_SemiSolid.Location = New Point(4, 47)
        COMBOBOX_SemiSolid.Name = "COMBOBOX_SemiSolid"
        COMBOBOX_SemiSolid.Size = New Size(76, 21)
        COMBOBOX_SemiSolid.TabIndex = 69
        ' 
        ' COMBOBOX_Character
        ' 
        COMBOBOX_Character.BackColor = SystemColors.Control
        COMBOBOX_Character.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_Character.FlatStyle = FlatStyle.Flat
        COMBOBOX_Character.Font = New Font("Microsoft Sans Serif", 8.25F)
        COMBOBOX_Character.FormattingEnabled = True
        COMBOBOX_Character.Location = New Point(4, 69)
        COMBOBOX_Character.Name = "COMBOBOX_Character"
        COMBOBOX_Character.Size = New Size(76, 21)
        COMBOBOX_Character.TabIndex = 70
        ' 
        ' COMBOBOX_Ground
        ' 
        COMBOBOX_Ground.BackColor = SystemColors.Control
        COMBOBOX_Ground.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_Ground.FlatStyle = FlatStyle.Flat
        COMBOBOX_Ground.Font = New Font("Microsoft Sans Serif", 8.25F)
        COMBOBOX_Ground.FormattingEnabled = True
        COMBOBOX_Ground.Location = New Point(4, 91)
        COMBOBOX_Ground.Name = "COMBOBOX_Ground"
        COMBOBOX_Ground.Size = New Size(76, 21)
        COMBOBOX_Ground.TabIndex = 71
        ' 
        ' CHECK_Night
        ' 
        CHECK_Night.AutoSize = True
        CHECK_Night.Font = New Font("Microsoft Sans Serif", 8.25F)
        CHECK_Night.Location = New Point(4, 111)
        CHECK_Night.Name = "CHECK_Night"
        CHECK_Night.Size = New Size(63, 17)
        CHECK_Night.TabIndex = 72
        CHECK_Night.Text = "<Night>"
        CHECK_Night.UseVisualStyleBackColor = True
        ' 
        ' BtnEmu
        ' 
        BtnEmu.BackColor = Color.White
        BtnEmu.Enabled = False
        BtnEmu.FlatStyle = FlatStyle.Flat
        BtnEmu.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnEmu.Location = New Point(87, 45)
        BtnEmu.Name = "BtnEmu"
        BtnEmu.Size = New Size(43, 25)
        BtnEmu.TabIndex = 79
        BtnEmu.Text = "<BtnEmu>"
        BtnEmu.UseVisualStyleBackColor = False
        ' 
        ' BtnScr
        ' 
        BtnScr.BackColor = Color.White
        BtnScr.Enabled = False
        BtnScr.FlatStyle = FlatStyle.Flat
        BtnScr.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnScr.Location = New Point(130, 45)
        BtnScr.Name = "BtnScr"
        BtnScr.Size = New Size(43, 25)
        BtnScr.TabIndex = 80
        BtnScr.Text = "<BtnScr>"
        BtnScr.UseVisualStyleBackColor = False
        ' 
        ' BtnPlay
        ' 
        BtnPlay.BackColor = Color.White
        BtnPlay.Enabled = False
        BtnPlay.FlatStyle = FlatStyle.Flat
        BtnPlay.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnPlay.Location = New Point(173, 45)
        BtnPlay.Name = "BtnPlay"
        BtnPlay.Size = New Size(43, 25)
        BtnPlay.TabIndex = 81
        BtnPlay.Text = "<BtnPlay>"
        BtnPlay.UseVisualStyleBackColor = False
        ' 
        ' BtnGif
        ' 
        BtnGif.BackColor = Color.White
        BtnGif.FlatStyle = FlatStyle.Flat
        BtnGif.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnGif.Location = New Point(281, 238)
        BtnGif.Name = "BtnGif"
        BtnGif.Size = New Size(34, 25)
        BtnGif.TabIndex = 37
        BtnGif.Text = "GIF"
        BtnGif.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnGif.UseVisualStyleBackColor = False
        ' 
        ' BtnMont
        ' 
        BtnMont.BackColor = SystemColors.Control
        BtnMont.Enabled = False
        BtnMont.FlatStyle = FlatStyle.Flat
        BtnMont.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnMont.Location = New Point(263, 17)
        BtnMont.Name = "BtnMont"
        BtnMont.Size = New Size(43, 23)
        BtnMont.TabIndex = 77
        BtnMont.Text = "<BtnMont>"
        BtnMont.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMont.UseVisualStyleBackColor = False
        BtnMont.Visible = False
        ' 
        ' BtnM01
        ' 
        BtnM01.BackColor = Color.White
        BtnM01.FlatStyle = FlatStyle.Flat
        BtnM01.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnM01.Location = New Point(251, 211)
        BtnM01.Name = "BtnM01"
        BtnM01.Size = New Size(26, 23)
        BtnM01.TabIndex = 30
        BtnM01.Text = "<"
        BtnM01.UseVisualStyleBackColor = False
        ' 
        ' LABEL_StepLength
        ' 
        LABEL_StepLength.AutoSize = True
        LABEL_StepLength.BackColor = Color.White
        LABEL_StepLength.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_StepLength.Location = New Point(206, 242)
        LABEL_StepLength.Name = "LABEL_StepLength"
        LABEL_StepLength.Size = New Size(46, 16)
        LABEL_StepLength.TabIndex = 96
        LABEL_StepLength.Text = "<Step>"
        ' 
        ' BtnM1
        ' 
        BtnM1.BackColor = Color.White
        BtnM1.FlatStyle = FlatStyle.Flat
        BtnM1.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnM1.Location = New Point(277, 211)
        BtnM1.Name = "BtnM1"
        BtnM1.Size = New Size(26, 23)
        BtnM1.TabIndex = 31
        BtnM1.Text = "←"
        BtnM1.UseVisualStyleBackColor = False
        ' 
        ' LABEL_Dis
        ' 
        LABEL_Dis.AutoSize = True
        LABEL_Dis.BackColor = Color.White
        LABEL_Dis.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_Dis.Location = New Point(129, 242)
        LABEL_Dis.Name = "LABEL_Dis"
        LABEL_Dis.Size = New Size(56, 16)
        LABEL_Dis.TabIndex = 95
        LABEL_Dis.Text = "<Range>"
        ' 
        ' LABEL_StartPointY
        ' 
        LABEL_StartPointY.AutoSize = True
        LABEL_StartPointY.BackColor = Color.White
        LABEL_StartPointY.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_StartPointY.Location = New Point(63, 307)
        LABEL_StartPointY.Name = "LABEL_StartPointY"
        LABEL_StartPointY.Size = New Size(67, 16)
        LABEL_StartPointY.TabIndex = 91
        LABEL_StartPointY.Text = "<GHeight>"
        ' 
        ' BtnP1
        ' 
        BtnP1.BackColor = Color.White
        BtnP1.FlatStyle = FlatStyle.Flat
        BtnP1.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnP1.Location = New Point(302, 211)
        BtnP1.Name = "BtnP1"
        BtnP1.Size = New Size(26, 23)
        BtnP1.TabIndex = 32
        BtnP1.Text = "→"
        BtnP1.UseVisualStyleBackColor = False
        ' 
        ' TYH
        ' 
        TYH.BackColor = Color.White
        TYH.Font = New Font("Microsoft YaHei UI", 8.25F)
        TYH.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        TYH.Location = New Point(60, 323)
        TYH.Maximum = New Decimal(New Integer() {1600, 0, 0, 0})
        TYH.Name = "TYH"
        TYH.ReadOnly = True
        TYH.Size = New Size(50, 21)
        TYH.TabIndex = 51
        TYH.TextAlign = HorizontalAlignment.Center
        TYH.Value = New Decimal(New Integer() {32, 0, 0, 0})
        ' 
        ' BtnP01
        ' 
        BtnP01.BackColor = Color.White
        BtnP01.FlatStyle = FlatStyle.Flat
        BtnP01.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnP01.Location = New Point(328, 211)
        BtnP01.Name = "BtnP01"
        BtnP01.Size = New Size(26, 23)
        BtnP01.TabIndex = 33
        BtnP01.Text = ">"
        BtnP01.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.White
        Label14.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label14.Location = New Point(144, 5)
        Label14.Name = "Label14"
        Label14.Size = New Size(21, 16)
        Label14.TabIndex = 43
        Label14.Text = "△X"
        ' 
        ' TSPX2
        ' 
        TSPX2.BackColor = Color.White
        TSPX2.BorderStyle = BorderStyle.FixedSingle
        TSPX2.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSPX2.Location = New Point(235, 240)
        TSPX2.Name = "TSPX2"
        TSPX2.Size = New Size(43, 21)
        TSPX2.TabIndex = 36
        TSPX2.Text = "0.05"
        TSPX2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TY1
        ' 
        TY1.BorderStyle = BorderStyle.FixedSingle
        TY1.Font = New Font("Microsoft YaHei UI", 8.25F)
        TY1.Location = New Point(27, 26)
        TY1.Name = "TY1"
        TY1.Size = New Size(43, 21)
        TY1.TabIndex = 5
        TY1.Text = "32"
        TY1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = Color.White
        Label25.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label25.Location = New Point(4, 75)
        Label25.Name = "Label25"
        Label25.Size = New Size(23, 16)
        Label25.TabIndex = 77
        Label25.Text = "Sy₀"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.White
        Label13.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label13.Location = New Point(74, 5)
        Label13.Name = "Label13"
        Label13.Size = New Size(18, 16)
        Label13.TabIndex = 42
        Label13.Text = "X₁"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label12.Location = New Point(4, 5)
        Label12.Name = "Label12"
        Label12.Size = New Size(18, 16)
        Label12.TabIndex = 41
        Label12.Text = "X₀"
        ' 
        ' TSY1
        ' 
        TSY1.BorderStyle = BorderStyle.FixedSingle
        TSY1.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSY1.Location = New Point(27, 72)
        TSY1.Name = "TSY1"
        TSY1.Size = New Size(43, 21)
        TSY1.TabIndex = 13
        TSY1.Text = "0"
        TSY1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB
        ' 
        TB.BackColor = Color.White
        TB.Font = New Font("Microsoft YaHei UI", 8.25F)
        TB.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        TB.Location = New Point(225, 323)
        TB.Maximum = New Decimal(New Integer() {1600, 0, 0, 0})
        TB.Name = "TB"
        TB.ReadOnly = True
        TB.Size = New Size(50, 21)
        TB.TabIndex = 54
        TB.TextAlign = HorizontalAlignment.Center
        TB.Value = New Decimal(New Integer() {84, 0, 0, 0})
        ' 
        ' LABEL_Height
        ' 
        LABEL_Height.AutoSize = True
        LABEL_Height.BackColor = Color.White
        LABEL_Height.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_Height.Location = New Point(173, 307)
        LABEL_Height.Name = "LABEL_Height"
        LABEL_Height.Size = New Size(59, 16)
        LABEL_Height.TabIndex = 78
        LABEL_Height.Text = "<Height>"
        ' 
        ' LABEL_Width
        ' 
        LABEL_Width.AutoSize = True
        LABEL_Width.BackColor = Color.White
        LABEL_Width.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_Width.Location = New Point(118, 307)
        LABEL_Width.Name = "LABEL_Width"
        LABEL_Width.Size = New Size(55, 16)
        LABEL_Width.TabIndex = 77
        LABEL_Width.Text = "<Width>"
        ' 
        ' LABEL_StartPointX
        ' 
        LABEL_StartPointX.AutoSize = True
        LABEL_StartPointX.BackColor = Color.White
        LABEL_StartPointX.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_StartPointX.Location = New Point(8, 307)
        LABEL_StartPointX.Name = "LABEL_StartPointX"
        LABEL_StartPointX.Size = New Size(63, 16)
        LABEL_StartPointX.TabIndex = 87
        LABEL_StartPointX.Text = "<GWidth>"
        ' 
        ' TYW
        ' 
        TYW.BackColor = Color.White
        TYW.Font = New Font("Microsoft YaHei UI", 8.25F)
        TYW.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        TYW.Location = New Point(5, 323)
        TYW.Maximum = New Decimal(New Integer() {1600, 0, 0, 0})
        TYW.Name = "TYW"
        TYW.ReadOnly = True
        TYW.Size = New Size(50, 21)
        TYW.TabIndex = 50
        TYW.TextAlign = HorizontalAlignment.Center
        TYW.Value = New Decimal(New Integer() {160, 0, 0, 0})
        ' 
        ' NumH
        ' 
        NumH.BackColor = Color.White
        NumH.Font = New Font("Microsoft YaHei UI", 8.25F)
        NumH.Location = New Point(170, 323)
        NumH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumH.Name = "NumH"
        NumH.ReadOnly = True
        NumH.Size = New Size(50, 21)
        NumH.TabIndex = 53
        NumH.TextAlign = HorizontalAlignment.Center
        NumH.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NumW
        ' 
        NumW.BackColor = Color.White
        NumW.Font = New Font("Microsoft YaHei UI", 8.25F)
        NumW.Location = New Point(115, 323)
        NumW.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumW.Name = "NumW"
        NumW.ReadOnly = True
        NumW.Size = New Size(50, 21)
        NumW.TabIndex = 52
        NumW.TextAlign = HorizontalAlignment.Center
        NumW.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' TSPX1
        ' 
        TSPX1.BackColor = Color.White
        TSPX1.BorderStyle = BorderStyle.FixedSingle
        TSPX1.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSPX1.Location = New Point(161, 240)
        TSPX1.Name = "TSPX1"
        TSPX1.Size = New Size(43, 21)
        TSPX1.TabIndex = 35
        TSPX1.Text = "0"
        TSPX1.TextAlign = HorizontalAlignment.Center
        ' 
        ' COMBOBOX_Item
        ' 
        COMBOBOX_Item.BackColor = SystemColors.Control
        COMBOBOX_Item.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_Item.FlatStyle = FlatStyle.Flat
        COMBOBOX_Item.Font = New Font("Microsoft YaHei UI", 8.25F)
        COMBOBOX_Item.FormattingEnabled = True
        COMBOBOX_Item.Location = New Point(251, 266)
        COMBOBOX_Item.Name = "COMBOBOX_Item"
        COMBOBOX_Item.Size = New Size(103, 24)
        COMBOBOX_Item.TabIndex = 44
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.White
        Label17.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label17.Location = New Point(4, 29)
        Label17.Name = "Label17"
        Label17.Size = New Size(18, 16)
        Label17.TabIndex = 44
        Label17.Text = "Y₀"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.White
        Label16.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label16.Location = New Point(74, 29)
        Label16.Name = "Label16"
        Label16.Size = New Size(18, 16)
        Label16.TabIndex = 45
        Label16.Text = "Y₁"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.White
        Label15.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label15.Location = New Point(144, 29)
        Label15.Name = "Label15"
        Label15.Size = New Size(21, 16)
        Label15.TabIndex = 46
        Label15.Text = "△Y"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.White
        Label20.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label20.Location = New Point(4, 51)
        Label20.Name = "Label20"
        Label20.Size = New Size(23, 16)
        Label20.TabIndex = 47
        Label20.Text = "Sx₀"
        ' 
        ' CkMario
        ' 
        CkMario.AutoSize = True
        CkMario.Checked = True
        CkMario.CheckState = CheckState.Checked
        CkMario.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkMario.Location = New Point(291, 169)
        CkMario.Name = "CkMario"
        CkMario.Size = New Size(74, 20)
        CkMario.TabIndex = 24
        CkMario.Text = "<Image>"
        CkMario.TextImageRelation = TextImageRelation.ImageBeforeText
        CkMario.UseVisualStyleBackColor = True
        ' 
        ' LABEL_AC
        ' 
        LABEL_AC.AutoSize = True
        LABEL_AC.BackColor = Color.White
        LABEL_AC.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_AC.Location = New Point(218, 51)
        LABEL_AC.Name = "LABEL_AC"
        LABEL_AC.Size = New Size(37, 16)
        LABEL_AC.TabIndex = 50
        LABEL_AC.Text = "<Ac>"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.White
        Label18.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label18.Location = New Point(144, 51)
        Label18.Name = "Label18"
        Label18.Size = New Size(26, 16)
        Label18.TabIndex = 49
        Label18.Text = "△Sx"
        ' 
        ' PBar
        ' 
        PBar.ForeColor = Color.OrangeRed
        PBar.Location = New Point(4, 202)
        PBar.Name = "PBar"
        PBar.Size = New Size(279, 8)
        PBar.Step = 1
        PBar.TabIndex = 72
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.White
        Label19.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label19.Location = New Point(74, 51)
        Label19.Name = "Label19"
        Label19.Size = New Size(23, 16)
        Label19.TabIndex = 48
        Label19.Text = "Sx₁"
        ' 
        ' CkBlk
        ' 
        CkBlk.AutoSize = True
        CkBlk.BackColor = Color.White
        CkBlk.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkBlk.Location = New Point(224, 306)
        CkBlk.Name = "CkBlk"
        CkBlk.Size = New Size(68, 20)
        CkBlk.TabIndex = 82
        CkBlk.Text = "<Limit>"
        CkBlk.UseVisualStyleBackColor = False
        ' 
        ' LBox
        ' 
        LBox.BorderStyle = BorderStyle.FixedSingle
        LBox.Font = New Font("Microsoft YaHei UI", 8.25F)
        LBox.FormattingEnabled = True
        LBox.Location = New Point(4, 17)
        LBox.Name = "LBox"
        LBox.Size = New Size(350, 34)
        LBox.TabIndex = 62
        ' 
        ' LABEL_FrameRate
        ' 
        LABEL_FrameRate.AutoSize = True
        LABEL_FrameRate.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_FrameRate.Location = New Point(99, 348)
        LABEL_FrameRate.Name = "LABEL_FrameRate"
        LABEL_FrameRate.Size = New Size(55, 16)
        LABEL_FrameRate.TabIndex = 52
        LABEL_FrameRate.Text = "<Frame>"
        ' 
        ' LABEL_FaultTolerance
        ' 
        LABEL_FaultTolerance.AutoSize = True
        LABEL_FaultTolerance.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_FaultTolerance.Location = New Point(51, 348)
        LABEL_FaultTolerance.Name = "LABEL_FaultTolerance"
        LABEL_FaultTolerance.Size = New Size(56, 16)
        LABEL_FaultTolerance.TabIndex = 51
        LABEL_FaultTolerance.Text = "<Range>"
        ' 
        ' LABEL_Location
        ' 
        LABEL_Location.AutoSize = True
        LABEL_Location.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_Location.Location = New Point(4, 348)
        LABEL_Location.Name = "LABEL_Location"
        LABEL_Location.Size = New Size(56, 16)
        LABEL_Location.TabIndex = 50
        LABEL_Location.Text = "<Target>"
        ' 
        ' PB
        ' 
        PB.BorderStyle = BorderStyle.None
        PB.GridCellSize = 16
        PB.Location = New Point(364, 4)
        PB.Name = "PB"
        PB.Size = New Size(170, 94)
        PB.TabIndex = 74
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.Snow
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        DataGridView1.Location = New Point(1018, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(38, 23)
        DataGridView1.TabIndex = 75
        DataGridView1.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TSPX2)
        Panel1.Controls.Add(TSPX1)
        Panel1.Controls.Add(BUTTON_En)
        Panel1.Controls.Add(CkTrace)
        Panel1.Controls.Add(CkMario)
        Panel1.Controls.Add(LABEL_Zoom)
        Panel1.Controls.Add(NumZoom)
        Panel1.Controls.Add(BReadMem)
        Panel1.Controls.Add(BtnGif)
        Panel1.Controls.Add(CkMulti)
        Panel1.Controls.Add(LABEL_StrideLength)
        Panel1.Controls.Add(BtnTile)
        Panel1.Controls.Add(TxtStep)
        Panel1.Controls.Add(BAddHis)
        Panel1.Controls.Add(CB1F)
        Panel1.Controls.Add(COMBOBOX_Item)
        Panel1.Controls.Add(TSP)
        Panel1.Controls.Add(TSY3)
        Panel1.Controls.Add(LABEL_SearchDepth)
        Panel1.Controls.Add(Label29)
        Panel1.Controls.Add(NIns)
        Panel1.Controls.Add(CkWU)
        Panel1.Controls.Add(Label28)
        Panel1.Controls.Add(LABEL_FrameRate)
        Panel1.Controls.Add(BtnUndo)
        Panel1.Controls.Add(LblCal)
        Panel1.Controls.Add(TSY2)
        Panel1.Controls.Add(LABEL_FaultTolerance)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(BCmdR)
        Panel1.Controls.Add(BtnFIns)
        Panel1.Controls.Add(CkMove)
        Panel1.Controls.Add(TSY4)
        Panel1.Controls.Add(LABEL_Location)
        Panel1.Controls.Add(TR4)
        Panel1.Controls.Add(T21)
        Panel1.Controls.Add(CkHitbox)
        Panel1.Controls.Add(TR3)
        Panel1.Controls.Add(BTas)
        Panel1.Controls.Add(T2)
        Panel1.Controls.Add(TR2)
        Panel1.Controls.Add(CkFrame)
        Panel1.Controls.Add(T20)
        Panel1.Controls.Add(CkLoc)
        Panel1.Controls.Add(LABEL_StartPointX)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(TS1)
        Panel1.Controls.Add(NumW)
        Panel1.Controls.Add(TS2)
        Panel1.Controls.Add(TY1)
        Panel1.Controls.Add(BtnSrc)
        Panel1.Controls.Add(PBar)
        Panel1.Controls.Add(TS3)
        Panel1.Controls.Add(Label25)
        Panel1.Controls.Add(BtnM01)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(TS4)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(TSY1)
        Panel1.Controls.Add(BtnP01)
        Panel1.Controls.Add(TD)
        Panel1.Controls.Add(LABEL_AC)
        Panel1.Controls.Add(TY4)
        Panel1.Controls.Add(TX1)
        Panel1.Controls.Add(NumH)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(TY3)
        Panel1.Controls.Add(TX4)
        Panel1.Controls.Add(TY2)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(BtnP1)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(TX2)
        Panel1.Controls.Add(CkDuck)
        Panel1.Controls.Add(BtnM1)
        Panel1.Controls.Add(TX3)
        Panel1.Controls.Add(BtnCal)
        Panel1.Controls.Add(TYW)
        Panel1.Controls.Add(TB)
        Panel1.Controls.Add(BtnCls)
        Panel1.Controls.Add(TYH)
        Panel1.Controls.Add(LABEL_Height)
        Panel1.Controls.Add(LABEL_StartPointY)
        Panel1.Controls.Add(LABEL_Dis)
        Panel1.Controls.Add(LABEL_Width)
        Panel1.Controls.Add(LABEL_StepLength)
        Panel1.Controls.Add(CkBlk)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(360, 410)
        Panel1.TabIndex = 0
        ' 
        ' BUTTON_En
        ' 
        BUTTON_En.BackColor = SystemColors.Control
        BUTTON_En.FlatStyle = FlatStyle.Flat
        BUTTON_En.Font = New Font("Microsoft YaHei UI", 8.25F)
        BUTTON_En.Location = New Point(320, 238)
        BUTTON_En.Name = "BUTTON_En"
        BUTTON_En.Size = New Size(34, 25)
        BUTTON_En.TabIndex = 38
        BUTTON_En.Text = "En"
        BUTTON_En.TextImageRelation = TextImageRelation.ImageBeforeText
        BUTTON_En.UseVisualStyleBackColor = False
        ' 
        ' LABEL_Zoom
        ' 
        LABEL_Zoom.AutoSize = True
        LABEL_Zoom.BackColor = Color.White
        LABEL_Zoom.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_Zoom.Location = New Point(284, 307)
        LABEL_Zoom.Name = "LABEL_Zoom"
        LABEL_Zoom.Size = New Size(54, 16)
        LABEL_Zoom.TabIndex = 110
        LABEL_Zoom.Text = "<Zoom>"
        ' 
        ' NumZoom
        ' 
        NumZoom.BackColor = Color.White
        NumZoom.Font = New Font("Microsoft YaHei UI", 8.25F)
        NumZoom.Location = New Point(281, 323)
        NumZoom.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        NumZoom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumZoom.Name = "NumZoom"
        NumZoom.ReadOnly = True
        NumZoom.Size = New Size(50, 21)
        NumZoom.TabIndex = 55
        NumZoom.TextAlign = HorizontalAlignment.Center
        NumZoom.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' BReadMem
        ' 
        BReadMem.BackColor = SystemColors.Control
        BReadMem.FlatStyle = FlatStyle.Flat
        BReadMem.Font = New Font("Microsoft YaHei UI", 8.25F)
        BReadMem.Location = New Point(195, 278)
        BReadMem.Name = "BReadMem"
        BReadMem.Size = New Size(51, 25)
        BReadMem.TabIndex = 48
        BReadMem.Text = "!Addr"
        BReadMem.TextImageRelation = TextImageRelation.ImageBeforeText
        BReadMem.UseVisualStyleBackColor = False
        ' 
        ' CkMulti
        ' 
        CkMulti.AutoSize = True
        CkMulti.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkMulti.Location = New Point(236, 75)
        CkMulti.Name = "CkMulti"
        CkMulti.Size = New Size(69, 20)
        CkMulti.TabIndex = 16
        CkMulti.Text = "<Refer>"
        CkMulti.TextImageRelation = TextImageRelation.ImageBeforeText
        CkMulti.UseVisualStyleBackColor = True
        ' 
        ' BtnTile
        ' 
        BtnTile.BackColor = Color.White
        BtnTile.FlatStyle = FlatStyle.Flat
        BtnTile.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnTile.Location = New Point(328, 295)
        BtnTile.Name = "BtnTile"
        BtnTile.Size = New Size(26, 23)
        BtnTile.TabIndex = 49
        BtnTile.UseVisualStyleBackColor = False
        ' 
        ' BAddHis
        ' 
        BAddHis.BackColor = SystemColors.Control
        BAddHis.FlatStyle = FlatStyle.Flat
        BAddHis.Font = New Font("Microsoft YaHei UI", 8.25F)
        BAddHis.Location = New Point(222, 211)
        BAddHis.Name = "BAddHis"
        BAddHis.Size = New Size(26, 23)
        BAddHis.TabIndex = 29
        BAddHis.Text = "<S>"
        BAddHis.TextImageRelation = TextImageRelation.ImageBeforeText
        BAddHis.UseVisualStyleBackColor = False
        ' 
        ' CB1F
        ' 
        CB1F.AutoSize = True
        CB1F.BackColor = Color.White
        CB1F.Font = New Font("Microsoft YaHei UI", 8.25F)
        CB1F.Location = New Point(284, 364)
        CB1F.Name = "CB1F"
        CB1F.Size = New Size(54, 20)
        CB1F.TabIndex = 61
        CB1F.Text = "<1F>"
        CB1F.UseVisualStyleBackColor = False
        ' 
        ' TSY3
        ' 
        TSY3.BorderStyle = BorderStyle.FixedSingle
        TSY3.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSY3.Location = New Point(172, 71)
        TSY3.Name = "TSY3"
        TSY3.Size = New Size(43, 21)
        TSY3.TabIndex = 15
        TSY3.Text = "0.001"
        TSY3.TextAlign = HorizontalAlignment.Center
        ' 
        ' LABEL_SearchDepth
        ' 
        LABEL_SearchDepth.AutoSize = True
        LABEL_SearchDepth.BackColor = Color.White
        LABEL_SearchDepth.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_SearchDepth.Location = New Point(146, 348)
        LABEL_SearchDepth.Name = "LABEL_SearchDepth"
        LABEL_SearchDepth.Size = New Size(50, 16)
        LABEL_SearchDepth.TabIndex = 80
        LABEL_SearchDepth.Text = "<Deep>"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.BackColor = Color.White
        Label29.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label29.Location = New Point(144, 74)
        Label29.Name = "Label29"
        Label29.Size = New Size(26, 16)
        Label29.TabIndex = 102
        Label29.Text = "△Sy"
        ' 
        ' NIns
        ' 
        NIns.BackColor = Color.White
        NIns.Font = New Font("Microsoft YaHei UI", 8.25F)
        NIns.Location = New Point(146, 363)
        NIns.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NIns.Name = "NIns"
        NIns.ReadOnly = True
        NIns.Size = New Size(50, 21)
        NIns.TabIndex = 59
        NIns.TextAlign = HorizontalAlignment.Center
        NIns.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' CkWU
        ' 
        CkWU.AutoSize = True
        CkWU.BackColor = Color.White
        CkWU.Font = New Font("Microsoft YaHei UI", 8.25F)
        CkWU.Location = New Point(236, 28)
        CkWU.Name = "CkWU"
        CkWU.Size = New Size(66, 20)
        CkWU.TabIndex = 8
        CkWU.Text = "<W/U>"
        CkWU.UseVisualStyleBackColor = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.BackColor = Color.White
        Label28.Font = New Font("Microsoft YaHei UI", 8.25F)
        Label28.Location = New Point(75, 75)
        Label28.Name = "Label28"
        Label28.Size = New Size(23, 16)
        Label28.TabIndex = 99
        Label28.Text = "Sy₁"
        ' 
        ' BtnUndo
        ' 
        BtnUndo.BackColor = SystemColors.Control
        BtnUndo.FlatStyle = FlatStyle.Flat
        BtnUndo.Font = New Font("Microsoft YaHei UI", 8.25F)
        BtnUndo.Location = New Point(60, 283)
        BtnUndo.Name = "BtnUndo"
        BtnUndo.Size = New Size(51, 23)
        BtnUndo.TabIndex = 46
        BtnUndo.Text = "<Undo>"
        BtnUndo.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnUndo.UseVisualStyleBackColor = False
        ' 
        ' TSY2
        ' 
        TSY2.BorderStyle = BorderStyle.FixedSingle
        TSY2.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSY2.Location = New Point(97, 72)
        TSY2.Name = "TSY2"
        TSY2.Size = New Size(43, 21)
        TSY2.TabIndex = 14
        TSY2.Text = "0"
        TSY2.TextAlign = HorizontalAlignment.Center
        ' 
        ' BCmdR
        ' 
        BCmdR.BackColor = SystemColors.Control
        BCmdR.BackgroundImageLayout = ImageLayout.Zoom
        BCmdR.FlatStyle = FlatStyle.Flat
        BCmdR.Font = New Font("Microsoft YaHei UI", 8.25F)
        BCmdR.Location = New Point(192, 211)
        BCmdR.Name = "BCmdR"
        BCmdR.Size = New Size(26, 23)
        BCmdR.TabIndex = 28
        BCmdR.Text = "<R>"
        BCmdR.TextImageRelation = TextImageRelation.ImageBeforeText
        BCmdR.UseVisualStyleBackColor = False
        ' 
        ' TSY4
        ' 
        TSY4.AutoSize = True
        TSY4.BackColor = Color.White
        TSY4.Font = New Font("Microsoft YaHei UI", 8.25F)
        TSY4.Location = New Point(96, 264)
        TSY4.Name = "TSY4"
        TSY4.Size = New Size(38, 20)
        TSY4.TabIndex = 42
        TSY4.Text = "Sy"
        TSY4.UseVisualStyleBackColor = False
        ' 
        ' T21
        ' 
        T21.BorderStyle = BorderStyle.FixedSingle
        T21.Font = New Font("Microsoft YaHei UI", 8.25F)
        T21.Location = New Point(4, 170)
        T21.Multiline = True
        T21.Name = "T21"
        T21.Size = New Size(279, 31)
        T21.TabIndex = 19
        T21.TabStop = False
        ' 
        ' BTas
        ' 
        BTas.BackColor = SystemColors.Control
        BTas.FlatStyle = FlatStyle.Flat
        BTas.Font = New Font("Microsoft YaHei UI", 8.25F)
        BTas.Location = New Point(136, 211)
        BTas.Name = "BTas"
        BTas.Size = New Size(51, 23)
        BTas.TabIndex = 27
        BTas.Text = "<TAS>"
        BTas.TextImageRelation = TextImageRelation.ImageBeforeText
        BTas.UseVisualStyleBackColor = False
        ' 
        ' T20
        ' 
        T20.BorderStyle = BorderStyle.FixedSingle
        T20.Font = New Font("Microsoft YaHei UI", 8.25F)
        T20.Location = New Point(4, 96)
        T20.Multiline = True
        T20.Name = "T20"
        T20.Size = New Size(279, 31)
        T20.TabIndex = 17
        T20.TabStop = False
        ' 
        ' BEmu
        ' 
        BEmu.BackColor = SystemColors.Control
        BEmu.Enabled = False
        BEmu.FlatStyle = FlatStyle.Flat
        BEmu.Font = New Font("Microsoft Sans Serif", 8.25F)
        BEmu.Location = New Point(259, 93)
        BEmu.Name = "BEmu"
        BEmu.Size = New Size(43, 23)
        BEmu.TabIndex = 87
        BEmu.Text = "<Emu>"
        BEmu.TextImageRelation = TextImageRelation.ImageBeforeText
        BEmu.UseVisualStyleBackColor = False
        ' 
        ' BtnTile2
        ' 
        BtnTile2.BackColor = SystemColors.Control
        BtnTile2.Enabled = False
        BtnTile2.FlatStyle = FlatStyle.Flat
        BtnTile2.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnTile2.Location = New Point(99, 76)
        BtnTile2.Name = "BtnTile2"
        BtnTile2.Size = New Size(26, 23)
        BtnTile2.TabIndex = 84
        BtnTile2.UseVisualStyleBackColor = False
        BtnTile2.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(LABEL_Strat)
        Panel2.Controls.Add(LBox)
        Panel2.Controls.Add(LblState)
        Panel2.Controls.Add(T1)
        Panel2.Controls.Add(COMBOBOX_Strat)
        Panel2.Controls.Add(BtnSave)
        Panel2.Controls.Add(TxtStrat)
        Panel2.Location = New Point(3, 416)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(360, 135)
        Panel2.TabIndex = 1
        ' 
        ' LABEL_Strat
        ' 
        LABEL_Strat.AutoSize = True
        LABEL_Strat.Font = New Font("Microsoft YaHei UI", 8.25F)
        LABEL_Strat.Location = New Point(4, 91)
        LABEL_Strat.Name = "LABEL_Strat"
        LABEL_Strat.Size = New Size(47, 16)
        LABEL_Strat.TabIndex = 111
        LABEL_Strat.Text = "<Strat>"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(BtnTile2)
        Panel3.Controls.Add(BtnGenJump)
        Panel3.Controls.Add(BEmu)
        Panel3.Controls.Add(COMBOBOX_Theme)
        Panel3.Controls.Add(COMBOBOX_Style)
        Panel3.Controls.Add(BtnPng)
        Panel3.Controls.Add(BtnMont)
        Panel3.Controls.Add(COMBOBOX_SemiSolid)
        Panel3.Controls.Add(TxtAir)
        Panel3.Controls.Add(TFPS)
        Panel3.Controls.Add(COMBOBOX_Character)
        Panel3.Controls.Add(COMBOBOX_JumpAcc)
        Panel3.Controls.Add(LABEL_Hover)
        Panel3.Controls.Add(TxtFormLoc)
        Panel3.Controls.Add(LABEL_FrameDelay)
        Panel3.Controls.Add(CkCtrl)
        Panel3.Controls.Add(TxtOpc)
        Panel3.Controls.Add(COMBOBOX_Ground)
        Panel3.Controls.Add(BUTTON_Operate)
        Panel3.Controls.Add(BtnPlay)
        Panel3.Controls.Add(LABEL_Transparency)
        Panel3.Controls.Add(CHECK_Night)
        Panel3.Controls.Add(TDL)
        Panel3.Controls.Add(BtnScr)
        Panel3.Controls.Add(LABEL_Position)
        Panel3.Controls.Add(LABEL_FPS)
        Panel3.Controls.Add(BtnEmu)
        Panel3.Location = New Point(3, 554)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(360, 132)
        Panel3.TabIndex = 2
        ' 
        ' BtnGenJump
        ' 
        BtnGenJump.BackColor = SystemColors.Control
        BtnGenJump.Enabled = False
        BtnGenJump.FlatStyle = FlatStyle.Flat
        BtnGenJump.Font = New Font("Microsoft Sans Serif", 8.25F)
        BtnGenJump.Location = New Point(307, 94)
        BtnGenJump.Name = "BtnGenJump"
        BtnGenJump.Size = New Size(43, 23)
        BtnGenJump.TabIndex = 88
        BtnGenJump.Text = "<BtnGenJump>"
        BtnGenJump.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnGenJump.UseVisualStyleBackColor = False
        BtnGenJump.Visible = False
        ' 
        ' LHis
        ' 
        LHis.Font = New Font("Microsoft YaHei UI", 9F)
        LHis.FormattingEnabled = True
        LHis.ItemHeight = 17
        LHis.Location = New Point(398, 546)
        LHis.Name = "LHis"
        LHis.Size = New Size(206, 55)
        LHis.TabIndex = 89
        LHis.Visible = False
        ' 
        ' TimerEmu
        ' 
        TimerEmu.Interval = 15
        ' 
        ' PItem
        ' 
        PItem.BorderStyle = BorderStyle.FixedSingle
        PItem.GridCellSize = 16
        PItem.Location = New Point(364, 306)
        PItem.Name = "PItem"
        PItem.Size = New Size(240, 214)
        PItem.TabIndex = 81
        PItem.Visible = False
        ' 
        ' COMBOBOX_LanguageSettings
        ' 
        COMBOBOX_LanguageSettings.BackColor = SystemColors.Control
        COMBOBOX_LanguageSettings.DropDownStyle = ComboBoxStyle.DropDownList
        COMBOBOX_LanguageSettings.FlatStyle = FlatStyle.Flat
        COMBOBOX_LanguageSettings.Font = New Font("Microsoft YaHei UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        COMBOBOX_LanguageSettings.FormattingEnabled = True
        COMBOBOX_LanguageSettings.Location = New Point(550, 3)
        COMBOBOX_LanguageSettings.Name = "COMBOBOX_LanguageSettings"
        COMBOBOX_LanguageSettings.Size = New Size(120, 24)
        COMBOBOX_LanguageSettings.TabIndex = 90
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1064, 691)
        Controls.Add(COMBOBOX_LanguageSettings)
        Controls.Add(PItem)
        Controls.Add(LHis)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PB)
        Controls.Add(DataGridView1)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "<_TITLE>"
        CType(TYH, ComponentModel.ISupportInitialize).EndInit()
        CType(TB, ComponentModel.ISupportInitialize).EndInit()
        CType(TYW, ComponentModel.ISupportInitialize).EndInit()
        CType(NumH, ComponentModel.ISupportInitialize).EndInit()
        CType(NumW, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NumZoom, ComponentModel.ISupportInitialize).EndInit()
        CType(NIns, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MaterialCheckbox1 As CheckBox
    Friend WithEvents MaterialCheckbox2 As CheckBox
    Friend WithEvents MaterialCheckbox3 As CheckBox
    Friend WithEvents MaterialCheckbox4 As CheckBox
    Friend WithEvents MaterialCheckbox5 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LblCal As Label
    Friend WithEvents COMBOBOX_Strat As ComboBox
    Friend WithEvents LblState As Label
    Friend WithEvents TxtStrat As TextBox
    Friend WithEvents TxtStep As TextBox
    Friend WithEvents LABEL_StrideLength As Label
    Friend WithEvents LABEL_Hover As Label
    Friend WithEvents TxtAir As TextBox
    Friend WithEvents COMBOBOX_JumpAcc As ComboBox
    Friend WithEvents TD As TextBox
    Friend WithEvents TS3 As TextBox
    Friend WithEvents TS2 As TextBox
    Friend WithEvents TS1 As TextBox
    Friend WithEvents TY3 As TextBox
    Friend WithEvents TY2 As TextBox
    Friend WithEvents TX3 As TextBox
    Friend WithEvents TX2 As TextBox
    Friend WithEvents TX1 As TextBox
    Friend WithEvents TSP As CheckBox
    Friend WithEvents TS4 As CheckBox
    Friend WithEvents TY4 As CheckBox
    Friend WithEvents TX4 As CheckBox
    Friend WithEvents T2 As TextBox
    Friend WithEvents TR4 As TextBox
    Friend WithEvents TR3 As TextBox
    Friend WithEvents TR2 As TextBox
    Friend WithEvents T1 As TextBox
    Friend WithEvents BtnCal As Button
    Friend WithEvents BtnSrc As Button
    Friend WithEvents BUTTON_Operate As Button
    Friend WithEvents BtnCls As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents CkDuck As CheckBox
    Friend WithEvents BtnFIns As Button
    Friend WithEvents CkLoc As CheckBox
    Friend WithEvents CkMove As CheckBox
    Friend WithEvents CkFrame As CheckBox
    Friend WithEvents CkTrace As CheckBox
    Friend WithEvents CkHitbox As CheckBox
    Friend WithEvents CkCtrl As CheckBox
    Friend WithEvents BtnPng As Button
    Friend WithEvents TFPS As TextBox
    Friend WithEvents LABEL_FPS As Label
    Friend WithEvents TxtFormLoc As TextBox
    Friend WithEvents LABEL_Position As Label
    Friend WithEvents TxtOpc As TextBox
    Friend WithEvents LABEL_Transparency As Label
    Friend WithEvents TDL As TextBox
    Friend WithEvents LABEL_FrameDelay As Label
    Friend WithEvents COMBOBOX_Theme As ComboBox
    Friend WithEvents COMBOBOX_Style As ComboBox
    Friend WithEvents COMBOBOX_SemiSolid As ComboBox
    Friend WithEvents COMBOBOX_Character As ComboBox
    Friend WithEvents COMBOBOX_Ground As ComboBox
    Friend WithEvents CHECK_Night As CheckBox
    Friend WithEvents BtnEmu As Button
    Friend WithEvents BtnScr As Button
    Friend WithEvents BtnPlay As Button
    Friend WithEvents BtnGif As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LABEL_AC As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents PBar As ProgressBar
    Friend WithEvents LABEL_FrameRate As Label
    Friend WithEvents LABEL_FaultTolerance As Label
    Friend WithEvents LABEL_Location As Label
    Friend WithEvents LBox As ListBox
    Friend WithEvents PB As Cyotek.Windows.Forms.ImageBox
    Friend WithEvents NumH As NumericUpDown
    Friend WithEvents NumW As NumericUpDown
    Friend WithEvents LABEL_Height As Label
    Friend WithEvents LABEL_Width As Label
    Friend WithEvents COMBOBOX_Item As ComboBox
    Friend WithEvents CkBlk As CheckBox
    Friend WithEvents BtnP01 As Button
    Friend WithEvents BtnP1 As Button
    Friend WithEvents BtnM1 As Button
    Friend WithEvents BtnM01 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TYW As NumericUpDown
    Friend WithEvents CkMario As CheckBox
    Friend WithEvents TB As NumericUpDown
    Friend WithEvents LABEL_StartPointX As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TSY1 As TextBox
    Friend WithEvents TSPX As CheckBox
    Friend WithEvents TSPX1 As TextBox
    Friend WithEvents TSPX2 As TextBox
    Friend WithEvents TY1 As TextBox
    Friend WithEvents TYH As NumericUpDown
    Friend WithEvents LABEL_StartPointY As Label
    Friend WithEvents LABEL_StepLength As Label
    Friend WithEvents LABEL_Dis As Label
    Friend WithEvents BtnMont As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents TSY2 As TextBox
    Friend WithEvents CkWU As CheckBox
    Friend WithEvents TSY4 As CheckBox
    Friend WithEvents TSY3 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents BTas As Button
    Friend WithEvents BReadMem As Button
    Friend WithEvents LABEL_SearchDepth As Label
    Friend WithEvents NIns As NumericUpDown
    Friend WithEvents T20 As TextBox
    Friend WithEvents T21 As TextBox
    Friend WithEvents BCmdR As Button
    Friend WithEvents CB1F As CheckBox
    Friend WithEvents BtnUndo As Button
    Friend WithEvents BtnGenJump As Button
    Friend WithEvents LHis As ListBox
    Friend WithEvents BAddHis As Button
    Friend WithEvents TimerEmu As Timer
    Friend WithEvents BEmu As Button
    Friend WithEvents CkMulti As CheckBox
    Friend WithEvents BtnTile As Button
    Friend WithEvents PItem As Cyotek.Windows.Forms.ImageBox
    Friend WithEvents BtnTile2 As Button
    Friend WithEvents LABEL_Zoom As Label
    Friend WithEvents NumZoom As NumericUpDown
    Friend WithEvents BUTTON_En As Button
    Friend WithEvents COMBOBOX_LanguageSettings As ComboBox
    Friend WithEvents LABEL_Strat As Label
End Class
