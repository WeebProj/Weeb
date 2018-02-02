<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.PAGEACC = New System.Windows.Forms.TextBox()
		Me.SAUVEGARDE_URL = New System.Windows.Forms.TextBox()
		Me.WEEB_SM_BOUTTON_OFF = New System.Windows.Forms.PictureBox()
		Me.WEEB_SM_BOUTTON_ON = New System.Windows.Forms.PictureBox()
		Me.Weeb_SM = New System.Windows.Forms.TextBox()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Fav_ico = New System.Windows.Forms.PictureBox()
		Me.Pagewebtitle = New System.Windows.Forms.Label()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.RECHERCHER_GRIS = New System.Windows.Forms.PictureBox()
		Me.RECHERCHER_TRANSPARENT = New System.Windows.Forms.PictureBox()
		Me.URL_WEBROWSER = New System.Windows.Forms.TextBox()
		Me.SUIVANT_GRIS = New System.Windows.Forms.PictureBox()
		Me.SUIVANT_TRANSPARENT = New System.Windows.Forms.PictureBox()
		Me.PRECEDENT_GRIS = New System.Windows.Forms.PictureBox()
		Me.PRECEDENT_TRANSPARENT = New System.Windows.Forms.PictureBox()
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.WEEB_SM_FENETRE = New System.Windows.Forms.Panel()
		Me.PANEL_SM_ON = New System.Windows.Forms.Panel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.MP_SM = New System.Windows.Forms.TextBox()
		Me.WEEB_SM_DESACTIVER = New System.Windows.Forms.Button()
		Me.PANEL_SM_OFF = New System.Windows.Forms.Panel()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.MODIFmp = New System.Windows.Forms.TextBox()
		Me.ACTIVER_SM = New System.Windows.Forms.Button()
		Me.B_MP = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SM_NOUVMP2 = New System.Windows.Forms.TextBox()
		Me.SM_NOUVMP1 = New System.Windows.Forms.TextBox()
		Me.WEEB_SM_FENETRE_BORDER = New System.Windows.Forms.Panel()
		Me.WEEB_SM_CROIX_ROUGE = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.WEEB_SM_CRIOX_TRANSPARENT = New System.Windows.Forms.PictureBox()
		Me.WEEBMASQ = New System.Windows.Forms.Panel()
		Me.Panel1.SuspendLayout()
		CType(Me.WEEB_SM_BOUTTON_OFF, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WEEB_SM_BOUTTON_ON, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel2.SuspendLayout()
		CType(Me.Fav_ico, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RECHERCHER_GRIS, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RECHERCHER_TRANSPARENT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SUIVANT_GRIS, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SUIVANT_TRANSPARENT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PRECEDENT_GRIS, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PRECEDENT_TRANSPARENT, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.WEEB_SM_FENETRE.SuspendLayout()
		Me.PANEL_SM_ON.SuspendLayout()
		Me.PANEL_SM_OFF.SuspendLayout()
		Me.WEEB_SM_FENETRE_BORDER.SuspendLayout()
		CType(Me.WEEB_SM_CROIX_ROUGE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.WEEB_SM_CRIOX_TRANSPARENT, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.WEEB_SM_BOUTTON_ON)
		Me.Panel1.Controls.Add(Me.Panel3)
		Me.Panel1.Controls.Add(Me.PAGEACC)
		Me.Panel1.Controls.Add(Me.SAUVEGARDE_URL)
		Me.Panel1.Controls.Add(Me.WEEB_SM_BOUTTON_OFF)
		Me.Panel1.Controls.Add(Me.Weeb_SM)
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Controls.Add(Me.RECHERCHER_GRIS)
		Me.Panel1.Controls.Add(Me.RECHERCHER_TRANSPARENT)
		Me.Panel1.Controls.Add(Me.URL_WEBROWSER)
		Me.Panel1.Controls.Add(Me.SUIVANT_GRIS)
		Me.Panel1.Controls.Add(Me.SUIVANT_TRANSPARENT)
		Me.Panel1.Controls.Add(Me.PRECEDENT_GRIS)
		Me.Panel1.Controls.Add(Me.PRECEDENT_TRANSPARENT)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1012, 78)
		Me.Panel1.TabIndex = 0
		'
		'Panel3
		'
		Me.Panel3.Location = New System.Drawing.Point(342, 35)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(177, 34)
		Me.Panel3.TabIndex = 9
		'
		'PAGEACC
		'
		Me.PAGEACC.Location = New System.Drawing.Point(491, 48)
		Me.PAGEACC.Name = "PAGEACC"
		Me.PAGEACC.Size = New System.Drawing.Size(28, 20)
		Me.PAGEACC.TabIndex = 13
		Me.PAGEACC.Text = "http://www.google.fr"
		'
		'SAUVEGARDE_URL
		'
		Me.SAUVEGARDE_URL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Weeb_2017_v.miniprojet.My.MySettings.Default, "SAUVEGARDE_URL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.SAUVEGARDE_URL.Location = New System.Drawing.Point(419, 45)
		Me.SAUVEGARDE_URL.Name = "SAUVEGARDE_URL"
		Me.SAUVEGARDE_URL.Size = New System.Drawing.Size(100, 20)
		Me.SAUVEGARDE_URL.TabIndex = 12
		Me.SAUVEGARDE_URL.Text = Global.Weeb_2017_v.miniprojet.My.MySettings.Default.SAUVEGARDE_URL
		'
		'WEEB_SM_BOUTTON_OFF
		'
		Me.WEEB_SM_BOUTTON_OFF.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_SM_OFF_0
		Me.WEEB_SM_BOUTTON_OFF.Location = New System.Drawing.Point(211, 34)
		Me.WEEB_SM_BOUTTON_OFF.Name = "WEEB_SM_BOUTTON_OFF"
		Me.WEEB_SM_BOUTTON_OFF.Size = New System.Drawing.Size(44, 40)
		Me.WEEB_SM_BOUTTON_OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.WEEB_SM_BOUTTON_OFF.TabIndex = 11
		Me.WEEB_SM_BOUTTON_OFF.TabStop = False
		'
		'WEEB_SM_BOUTTON_ON
		'
		Me.WEEB_SM_BOUTTON_ON.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_SM_OOF_0
		Me.WEEB_SM_BOUTTON_ON.Location = New System.Drawing.Point(211, 34)
		Me.WEEB_SM_BOUTTON_ON.Name = "WEEB_SM_BOUTTON_ON"
		Me.WEEB_SM_BOUTTON_ON.Size = New System.Drawing.Size(44, 40)
		Me.WEEB_SM_BOUTTON_ON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.WEEB_SM_BOUTTON_ON.TabIndex = 10
		Me.WEEB_SM_BOUTTON_ON.TabStop = False
		'
		'Weeb_SM
		'
		Me.Weeb_SM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Weeb_2017_v.miniprojet.My.MySettings.Default, "Weeb_SM", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.Weeb_SM.Location = New System.Drawing.Point(419, 45)
		Me.Weeb_SM.Name = "Weeb_SM"
		Me.Weeb_SM.Size = New System.Drawing.Size(100, 20)
		Me.Weeb_SM.TabIndex = 8
		Me.Weeb_SM.Text = Global.Weeb_2017_v.miniprojet.My.MySettings.Default.Weeb_SM
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
		Me.Panel2.Controls.Add(Me.Fav_ico)
		Me.Panel2.Controls.Add(Me.Pagewebtitle)
		Me.Panel2.Controls.Add(Me.ProgressBar1)
		Me.Panel2.Location = New System.Drawing.Point(0, 38)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(199, 40)
		Me.Panel2.TabIndex = 7
		'
		'Fav_ico
		'
		Me.Fav_ico.Location = New System.Drawing.Point(3, 3)
		Me.Fav_ico.Name = "Fav_ico"
		Me.Fav_ico.Size = New System.Drawing.Size(29, 28)
		Me.Fav_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Fav_ico.TabIndex = 2
		Me.Fav_ico.TabStop = False
		'
		'Pagewebtitle
		'
		Me.Pagewebtitle.AutoSize = True
		Me.Pagewebtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pagewebtitle.Location = New System.Drawing.Point(38, 11)
		Me.Pagewebtitle.Name = "Pagewebtitle"
		Me.Pagewebtitle.Size = New System.Drawing.Size(75, 16)
		Me.Pagewebtitle.TabIndex = 1
		Me.Pagewebtitle.Text = "Connection"
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Location = New System.Drawing.Point(0, 34)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(200, 6)
		Me.ProgressBar1.TabIndex = 0
		'
		'RECHERCHER_GRIS
		'
		Me.RECHERCHER_GRIS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.RECHERCHER_GRIS.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_RECHERCHER_1
		Me.RECHERCHER_GRIS.Location = New System.Drawing.Point(797, 3)
		Me.RECHERCHER_GRIS.Name = "RECHERCHER_GRIS"
		Me.RECHERCHER_GRIS.Size = New System.Drawing.Size(31, 29)
		Me.RECHERCHER_GRIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.RECHERCHER_GRIS.TabIndex = 6
		Me.RECHERCHER_GRIS.TabStop = False
		'
		'RECHERCHER_TRANSPARENT
		'
		Me.RECHERCHER_TRANSPARENT.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_RECHERCHER_0
		Me.RECHERCHER_TRANSPARENT.Location = New System.Drawing.Point(797, 3)
		Me.RECHERCHER_TRANSPARENT.Name = "RECHERCHER_TRANSPARENT"
		Me.RECHERCHER_TRANSPARENT.Size = New System.Drawing.Size(31, 29)
		Me.RECHERCHER_TRANSPARENT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.RECHERCHER_TRANSPARENT.TabIndex = 5
		Me.RECHERCHER_TRANSPARENT.TabStop = False
		'
		'URL_WEBROWSER
		'
		Me.URL_WEBROWSER.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.URL_WEBROWSER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.URL_WEBROWSER.Location = New System.Drawing.Point(78, 9)
		Me.URL_WEBROWSER.Name = "URL_WEBROWSER"
		Me.URL_WEBROWSER.Size = New System.Drawing.Size(713, 19)
		Me.URL_WEBROWSER.TabIndex = 4
		Me.URL_WEBROWSER.Text = "https://"
		'
		'SUIVANT_GRIS
		'
		Me.SUIVANT_GRIS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.SUIVANT_GRIS.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_SUIVANT_1
		Me.SUIVANT_GRIS.Location = New System.Drawing.Point(41, 3)
		Me.SUIVANT_GRIS.Name = "SUIVANT_GRIS"
		Me.SUIVANT_GRIS.Size = New System.Drawing.Size(31, 29)
		Me.SUIVANT_GRIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.SUIVANT_GRIS.TabIndex = 3
		Me.SUIVANT_GRIS.TabStop = False
		'
		'SUIVANT_TRANSPARENT
		'
		Me.SUIVANT_TRANSPARENT.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_SUIVANT_0
		Me.SUIVANT_TRANSPARENT.Location = New System.Drawing.Point(41, 3)
		Me.SUIVANT_TRANSPARENT.Name = "SUIVANT_TRANSPARENT"
		Me.SUIVANT_TRANSPARENT.Size = New System.Drawing.Size(31, 29)
		Me.SUIVANT_TRANSPARENT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.SUIVANT_TRANSPARENT.TabIndex = 2
		Me.SUIVANT_TRANSPARENT.TabStop = False
		'
		'PRECEDENT_GRIS
		'
		Me.PRECEDENT_GRIS.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PRECEDENT_GRIS.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_PRECEDENT_1
		Me.PRECEDENT_GRIS.Location = New System.Drawing.Point(3, 3)
		Me.PRECEDENT_GRIS.Name = "PRECEDENT_GRIS"
		Me.PRECEDENT_GRIS.Size = New System.Drawing.Size(31, 29)
		Me.PRECEDENT_GRIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PRECEDENT_GRIS.TabIndex = 1
		Me.PRECEDENT_GRIS.TabStop = False
		'
		'PRECEDENT_TRANSPARENT
		'
		Me.PRECEDENT_TRANSPARENT.Cursor = System.Windows.Forms.Cursors.Default
		Me.PRECEDENT_TRANSPARENT.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_PRECEDENT_0
		Me.PRECEDENT_TRANSPARENT.Location = New System.Drawing.Point(3, 3)
		Me.PRECEDENT_TRANSPARENT.Name = "PRECEDENT_TRANSPARENT"
		Me.PRECEDENT_TRANSPARENT.Size = New System.Drawing.Size(31, 29)
		Me.PRECEDENT_TRANSPARENT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PRECEDENT_TRANSPARENT.TabIndex = 0
		Me.PRECEDENT_TRANSPARENT.TabStop = False
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 78)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.ScriptErrorsSuppressed = True
		Me.WebBrowser1.Size = New System.Drawing.Size(1012, 473)
		Me.WebBrowser1.TabIndex = 1
		Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
		'
		'WEEB_SM_FENETRE
		'
		Me.WEEB_SM_FENETRE.BackColor = System.Drawing.Color.LightGray
		Me.WEEB_SM_FENETRE.Controls.Add(Me.PANEL_SM_ON)
		Me.WEEB_SM_FENETRE.Controls.Add(Me.PANEL_SM_OFF)
		Me.WEEB_SM_FENETRE.Controls.Add(Me.WEEB_SM_FENETRE_BORDER)
		Me.WEEB_SM_FENETRE.Location = New System.Drawing.Point(207, 139)
		Me.WEEB_SM_FENETRE.Name = "WEEB_SM_FENETRE"
		Me.WEEB_SM_FENETRE.Size = New System.Drawing.Size(261, 221)
		Me.WEEB_SM_FENETRE.TabIndex = 2
		'
		'PANEL_SM_ON
		'
		Me.PANEL_SM_ON.Controls.Add(Me.Label4)
		Me.PANEL_SM_ON.Controls.Add(Me.MP_SM)
		Me.PANEL_SM_ON.Controls.Add(Me.WEEB_SM_DESACTIVER)
		Me.PANEL_SM_ON.Location = New System.Drawing.Point(0, 24)
		Me.PANEL_SM_ON.Name = "PANEL_SM_ON"
		Me.PANEL_SM_ON.Size = New System.Drawing.Size(261, 196)
		Me.PANEL_SM_ON.TabIndex = 2
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.Label4.Location = New System.Drawing.Point(12, 66)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(134, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Entrer votre mot de passe :"
		'
		'MP_SM
		'
		Me.MP_SM.Location = New System.Drawing.Point(15, 82)
		Me.MP_SM.Name = "MP_SM"
		Me.MP_SM.Size = New System.Drawing.Size(224, 20)
		Me.MP_SM.TabIndex = 1
		Me.MP_SM.UseSystemPasswordChar = True
		'
		'WEEB_SM_DESACTIVER
		'
		Me.WEEB_SM_DESACTIVER.Location = New System.Drawing.Point(158, 160)
		Me.WEEB_SM_DESACTIVER.Name = "WEEB_SM_DESACTIVER"
		Me.WEEB_SM_DESACTIVER.Size = New System.Drawing.Size(81, 23)
		Me.WEEB_SM_DESACTIVER.TabIndex = 0
		Me.WEEB_SM_DESACTIVER.Text = "Déverouiller"
		Me.WEEB_SM_DESACTIVER.UseVisualStyleBackColor = True
		'
		'PANEL_SM_OFF
		'
		Me.PANEL_SM_OFF.Controls.Add(Me.Panel5)
		Me.PANEL_SM_OFF.Controls.Add(Me.MODIFmp)
		Me.PANEL_SM_OFF.Controls.Add(Me.ACTIVER_SM)
		Me.PANEL_SM_OFF.Controls.Add(Me.B_MP)
		Me.PANEL_SM_OFF.Controls.Add(Me.Label3)
		Me.PANEL_SM_OFF.Controls.Add(Me.Label2)
		Me.PANEL_SM_OFF.Controls.Add(Me.SM_NOUVMP2)
		Me.PANEL_SM_OFF.Controls.Add(Me.SM_NOUVMP1)
		Me.PANEL_SM_OFF.Location = New System.Drawing.Point(0, 24)
		Me.PANEL_SM_OFF.Name = "PANEL_SM_OFF"
		Me.PANEL_SM_OFF.Size = New System.Drawing.Size(261, 196)
		Me.PANEL_SM_OFF.TabIndex = 1
		'
		'Panel5
		'
		Me.Panel5.Location = New System.Drawing.Point(4, 4)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(122, 34)
		Me.Panel5.TabIndex = 7
		'
		'MODIFmp
		'
		Me.MODIFmp.Location = New System.Drawing.Point(15, 8)
		Me.MODIFmp.Name = "MODIFmp"
		Me.MODIFmp.Size = New System.Drawing.Size(100, 20)
		Me.MODIFmp.TabIndex = 6
		'
		'ACTIVER_SM
		'
		Me.ACTIVER_SM.Location = New System.Drawing.Point(164, 160)
		Me.ACTIVER_SM.Name = "ACTIVER_SM"
		Me.ACTIVER_SM.Size = New System.Drawing.Size(75, 23)
		Me.ACTIVER_SM.TabIndex = 5
		Me.ACTIVER_SM.Text = "Activer"
		Me.ACTIVER_SM.UseVisualStyleBackColor = True
		'
		'B_MP
		'
		Me.B_MP.Location = New System.Drawing.Point(164, 15)
		Me.B_MP.Name = "B_MP"
		Me.B_MP.Size = New System.Drawing.Size(75, 23)
		Me.B_MP.TabIndex = 4
		Me.B_MP.Text = "Modifier"
		Me.B_MP.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 89)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(152, 13)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Confirmation du mot de passe :"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(123, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Nouveau mot de passe :"
		'
		'SM_NOUVMP2
		'
		Me.SM_NOUVMP2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Weeb_2017_v.miniprojet.My.MySettings.Default, "WEEB_SM_MP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.SM_NOUVMP2.Location = New System.Drawing.Point(15, 105)
		Me.SM_NOUVMP2.Name = "SM_NOUVMP2"
		Me.SM_NOUVMP2.Size = New System.Drawing.Size(224, 20)
		Me.SM_NOUVMP2.TabIndex = 1
		Me.SM_NOUVMP2.Text = Global.Weeb_2017_v.miniprojet.My.MySettings.Default.WEEB_SM_MP
		Me.SM_NOUVMP2.UseSystemPasswordChar = True
		'
		'SM_NOUVMP1
		'
		Me.SM_NOUVMP1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Weeb_2017_v.miniprojet.My.MySettings.Default, "WEEB_SM_MP2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.SM_NOUVMP1.Location = New System.Drawing.Point(15, 57)
		Me.SM_NOUVMP1.Name = "SM_NOUVMP1"
		Me.SM_NOUVMP1.Size = New System.Drawing.Size(224, 20)
		Me.SM_NOUVMP1.TabIndex = 0
		Me.SM_NOUVMP1.Text = Global.Weeb_2017_v.miniprojet.My.MySettings.Default.WEEB_SM_MP2
		Me.SM_NOUVMP1.UseSystemPasswordChar = True
		'
		'WEEB_SM_FENETRE_BORDER
		'
		Me.WEEB_SM_FENETRE_BORDER.BackColor = System.Drawing.Color.Gray
		Me.WEEB_SM_FENETRE_BORDER.Controls.Add(Me.WEEB_SM_CROIX_ROUGE)
		Me.WEEB_SM_FENETRE_BORDER.Controls.Add(Me.Label1)
		Me.WEEB_SM_FENETRE_BORDER.Controls.Add(Me.WEEB_SM_CRIOX_TRANSPARENT)
		Me.WEEB_SM_FENETRE_BORDER.Dock = System.Windows.Forms.DockStyle.Top
		Me.WEEB_SM_FENETRE_BORDER.Location = New System.Drawing.Point(0, 0)
		Me.WEEB_SM_FENETRE_BORDER.Name = "WEEB_SM_FENETRE_BORDER"
		Me.WEEB_SM_FENETRE_BORDER.Size = New System.Drawing.Size(261, 25)
		Me.WEEB_SM_FENETRE_BORDER.TabIndex = 0
		'
		'WEEB_SM_CROIX_ROUGE
		'
		Me.WEEB_SM_CROIX_ROUGE.Cursor = System.Windows.Forms.Cursors.Hand
		Me.WEEB_SM_CROIX_ROUGE.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_CROIX_ROUGE_3
		Me.WEEB_SM_CROIX_ROUGE.Location = New System.Drawing.Point(237, 4)
		Me.WEEB_SM_CROIX_ROUGE.Name = "WEEB_SM_CROIX_ROUGE"
		Me.WEEB_SM_CROIX_ROUGE.Size = New System.Drawing.Size(18, 18)
		Me.WEEB_SM_CROIX_ROUGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.WEEB_SM_CROIX_ROUGE.TabIndex = 2
		Me.WEEB_SM_CROIX_ROUGE.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Label1.Location = New System.Drawing.Point(3, 5)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(165, 16)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Weeb securité mécanique"
		'
		'WEEB_SM_CRIOX_TRANSPARENT
		'
		Me.WEEB_SM_CRIOX_TRANSPARENT.Image = Global.Weeb_2017_v.miniprojet.My.Resources.Resources.IMG_CROIX_ROUGE_0
		Me.WEEB_SM_CRIOX_TRANSPARENT.Location = New System.Drawing.Point(237, 4)
		Me.WEEB_SM_CRIOX_TRANSPARENT.Name = "WEEB_SM_CRIOX_TRANSPARENT"
		Me.WEEB_SM_CRIOX_TRANSPARENT.Size = New System.Drawing.Size(18, 18)
		Me.WEEB_SM_CRIOX_TRANSPARENT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.WEEB_SM_CRIOX_TRANSPARENT.TabIndex = 0
		Me.WEEB_SM_CRIOX_TRANSPARENT.TabStop = False
		'
		'WEEBMASQ
		'
		Me.WEEBMASQ.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.WEEBMASQ.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WEEBMASQ.Location = New System.Drawing.Point(0, 78)
		Me.WEEBMASQ.Name = "WEEBMASQ"
		Me.WEEBMASQ.Size = New System.Drawing.Size(1012, 473)
		Me.WEEBMASQ.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1012, 551)
		Me.Controls.Add(Me.WEEB_SM_FENETRE)
		Me.Controls.Add(Me.WEEBMASQ)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Controls.Add(Me.Panel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Weeb 2017 v.miniprojet"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.WEEB_SM_BOUTTON_OFF, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WEEB_SM_BOUTTON_ON, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		CType(Me.Fav_ico, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RECHERCHER_GRIS, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RECHERCHER_TRANSPARENT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SUIVANT_GRIS, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SUIVANT_TRANSPARENT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PRECEDENT_GRIS, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PRECEDENT_TRANSPARENT, System.ComponentModel.ISupportInitialize).EndInit()
		Me.WEEB_SM_FENETRE.ResumeLayout(False)
		Me.PANEL_SM_ON.ResumeLayout(False)
		Me.PANEL_SM_ON.PerformLayout()
		Me.PANEL_SM_OFF.ResumeLayout(False)
		Me.PANEL_SM_OFF.PerformLayout()
		Me.WEEB_SM_FENETRE_BORDER.ResumeLayout(False)
		Me.WEEB_SM_FENETRE_BORDER.PerformLayout()
		CType(Me.WEEB_SM_CROIX_ROUGE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.WEEB_SM_CRIOX_TRANSPARENT, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents PRECEDENT_TRANSPARENT As PictureBox
	Friend WithEvents PRECEDENT_GRIS As PictureBox
	Friend WithEvents SUIVANT_TRANSPARENT As PictureBox
	Friend WithEvents SUIVANT_GRIS As PictureBox
	Friend WithEvents RECHERCHER_TRANSPARENT As PictureBox
	Friend WithEvents URL_WEBROWSER As TextBox
	Friend WithEvents RECHERCHER_GRIS As PictureBox
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Pagewebtitle As Label
	Friend WithEvents ProgressBar1 As ProgressBar
	Friend WithEvents Fav_ico As PictureBox
	Friend WithEvents WebBrowser1 As WebBrowser
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Weeb_SM As TextBox
	Friend WithEvents WEEB_SM_FENETRE As Panel
	Friend WithEvents WEEB_SM_FENETRE_BORDER As Panel
	Friend WithEvents WEEB_SM_CRIOX_TRANSPARENT As PictureBox
	Friend WithEvents PANEL_SM_OFF As Panel
	Friend WithEvents B_MP As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents SM_NOUVMP2 As TextBox
	Friend WithEvents SM_NOUVMP1 As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents ACTIVER_SM As Button
	Friend WithEvents WEEB_SM_CROIX_ROUGE As PictureBox
	Friend WithEvents Panel5 As Panel
	Friend WithEvents MODIFmp As TextBox
	Friend WithEvents WEEB_SM_BOUTTON_ON As PictureBox
	Friend WithEvents WEEB_SM_BOUTTON_OFF As PictureBox
	Friend WithEvents PANEL_SM_ON As Panel
	Friend WithEvents Label4 As Label
	Friend WithEvents MP_SM As TextBox
	Friend WithEvents WEEB_SM_DESACTIVER As Button
	Friend WithEvents SAUVEGARDE_URL As TextBox
	Friend WithEvents PAGEACC As TextBox
	Friend WithEvents WEEBMASQ As Panel
End Class
