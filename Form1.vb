Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PRECEDENT_GRIS.Hide()
		SUIVANT_GRIS.Hide()
		RECHERCHER_GRIS.Hide()
		WEEB_SM_FENETRE.Hide()
		WEEB_SM_CROIX_ROUGE.Hide()
		WEEB_BOUTTON()
		If Weeb_SM.Text = "BLOCKED" Then
			WebBrowser1.Navigate(SAUVEGARDE_URL.Text)
		Else
			WebBrowser1.Navigate(PAGEACC.Text)
			WEEBMASQ.Hide()
		End If

	End Sub

	Private Sub WEEB_BOUTTON()
		If Weeb_SM.Text = "BLOCKED" Then
			WEEB_SM_BOUTTON_OFF.Hide()
			WEEB_SM_BOUTTON_ON.Show()
		Else
			WEEB_SM_BOUTTON_OFF.Show()
			WEEB_SM_BOUTTON_ON.Hide()
		End If
	End Sub
	Private Sub PRECEDENT_GRIS_MouseLeave(sender As Object, e As EventArgs) Handles PRECEDENT_GRIS.MouseLeave
		PRECEDENT_GRIS.Hide()
	End Sub

	Private Sub PRECEDENT_TRANSPARENT_MouseMove(sender As Object, e As MouseEventArgs) Handles PRECEDENT_TRANSPARENT.MouseMove
		PRECEDENT_GRIS.Show()
	End Sub

	Private Sub SUIVANT_TRANSPARENT_MouseMove(sender As Object, e As MouseEventArgs) Handles SUIVANT_TRANSPARENT.MouseMove
		SUIVANT_GRIS.Show()
	End Sub

	Private Sub SUIVANT_GRIS_MouseLeave(sender As Object, e As EventArgs) Handles SUIVANT_GRIS.MouseLeave
		SUIVANT_GRIS.Hide()
	End Sub

	Private Sub RECHERCHER_TRANSPARENT_MouseMove(sender As Object, e As MouseEventArgs) Handles RECHERCHER_TRANSPARENT.MouseMove
		RECHERCHER_GRIS.Show()
	End Sub

	Private Sub RECHERCHER_GRIS_MouseLeave(sender As Object, e As EventArgs) Handles RECHERCHER_GRIS.MouseLeave
		RECHERCHER_GRIS.Hide()
	End Sub

	Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
		URL_WEBROWSER.Text = WebBrowser1.Document.Url.AbsoluteUri
		Dim iconURL = "http://" & WebBrowser1.Url.Host & "/favicon.ico"
		Dim request As System.Net.WebRequest = Net.WebRequest.Create(iconURL)
		Dim response As System.Net.HttpWebResponse = request.GetResponse()
		Dim stream As System.IO.Stream = response.GetResponseStream()
		Dim favicon = Image.FromStream(stream)
		If stream.WriteTimeout Then
			Fav_ico.Image = favicon
		Else
		End If
		Pagewebtitle.Text = WebBrowser1.DocumentTitle()
	End Sub

	Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
		ProgressBar1.Visible = True
		With ProgressBar1
			.Minimum = 0
			.Maximum = 50
			.Step = 5
		End With
		For index As Integer = 0 To 50 Step 5
			ProgressBar1.Value = index
			System.Threading.Thread.Sleep(35)
		Next
	End Sub

	Private Sub PRECEDENT_GRIS_Click(sender As Object, e As EventArgs) Handles PRECEDENT_GRIS.Click
		If Weeb_SM.Text = "BLOCKED" Then
			Weeb_SMB()
		Else
			WebBrowser1.GoBack()
		End If
	End Sub
	Private Sub Weeb_SMB()
		Dim Rep As Integer

		Rep = MsgBox("Voulez-vous dévérouiller Weeb ?", vbYesNo + vbQuestion, "Avertisement")
		If Rep = vbYes Then
			SMBOUTTONON()
		Else

		End If
	End Sub

	Private Sub SUIVANT_GRIS_Click(sender As Object, e As EventArgs) Handles SUIVANT_GRIS.Click
		If Weeb_SM.Text = "BLOCKED" Then
			Weeb_SMB()
		Else
			WebBrowser1.GoForward()
		End If
	End Sub

	Private Sub RECHERCHER_GRIS_Click(sender As Object, e As EventArgs) Handles RECHERCHER_GRIS.Click
		If Weeb_SM.Text = "BLOCKED" Then
			Weeb_SMB()
		Else
			WebBrowser1.Navigate(URL_WEBROWSER.Text)
		End If
	End Sub

	Private Sub WEEB_SM_CRIOX_TRANSPARENT_MouseMove(sender As Object, e As MouseEventArgs) Handles WEEB_SM_CRIOX_TRANSPARENT.MouseMove
		WEEB_SM_CROIX_ROUGE.Show()
	End Sub

	Private Sub WEEB_SM_CROIX_ROUGE_MouseLeave(sender As Object, e As EventArgs) Handles WEEB_SM_CROIX_ROUGE.MouseLeave
		WEEB_SM_CROIX_ROUGE.Hide()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ACTIVER_SM.Click
		If SM_NOUVMP1.Text = SM_NOUVMP2.Text Then
			Weeb_SM.Clear()
			Weeb_SM.Text = ("BLOCKED")
			WEEB_BOUTTON()
			WEEB_SM_FENETRE.Hide()
			SAUVEGARDE_URL.Text = (URL_WEBROWSER.Text)
			WEEBMASQ.Show()
		Else
			MsgBox("Les deux mots de passe ne sont pas identiques ! ", vbExclamation, "Avertisement")
		End If

	End Sub

	Private Sub B_MP_Click(sender As Object, e As EventArgs) Handles B_MP.Click
		SM_NOUVMP1.Enabled = True
		SM_NOUVMP2.Enabled = True
	End Sub
	Private Sub SMBOUTTONoff()
		PANEL_SM_OFF.Show()
		PANEL_SM_ON.Hide()
		SM_NOUVMP1.Enabled = False
		SM_NOUVMP2.Enabled = False
		WEEB_SM_FENETRE.Show()
	End Sub
	Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles WEEB_SM_BOUTTON_OFF.Click
		SMBOUTTONoff()
	End Sub

	Private Sub WEEB_SM_CROIX_ROUGE_Click(sender As Object, e As EventArgs) Handles WEEB_SM_CROIX_ROUGE.Click
		WEEB_SM_FENETRE.Hide()
	End Sub
	Private Sub SMBOUTTONON()
		PANEL_SM_ON.Show()
		PANEL_SM_OFF.Hide()
		WEEB_SM_FENETRE.Show()
	End Sub
	Private Sub WEEB_SM_BOUTTON_ON_Click(sender As Object, e As EventArgs) Handles WEEB_SM_BOUTTON_ON.Click
		SMBOUTTONON()
	End Sub

	Private Sub WEEB_SM_DESACTIVER_Click(sender As Object, e As EventArgs) Handles WEEB_SM_DESACTIVER.Click
		If SM_NOUVMP2.Text = MP_SM.Text Then
			MP_SM.Clear()
			Weeb_SM.Clear()
			WEEB_BOUTTON()
			WEEB_SM_FENETRE.Hide()
			SAUVEGARDE_URL.Clear()
			WEEBMASQ.Hide()
		Else
			MsgBox("Mot de passe incorrect", vbCritical, "ACCE REFUSE")
		End If
	End Sub
End Class
