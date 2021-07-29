Public Class Form6
    Public form5 As Form5
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tkh.Text = form5.tb1.Text
        snk.Text = form5.sonhankhau.Text
        csc.Text = form5.chisocu.Text
        csm.Text = form5.chisomoi.Text
        ttmk.Text = form5.tieuthumetkhoi.Text
        smktdm.Text = form5.sometkhoitrongdm.Text
        smkvdm.Text = form5.sometkhoivuotdm.Text
        ttsd.Text = form5.tiensd.Text
        pbvmt.Text = form5.phibaovemt.Text
        ttt.Text = form5.tongtien.Text
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label7.Text = DateTime.Now.Date.ToShortDateString
        Label5.Text = DateTime.Now.TimeOfDay.ToString
    End Sub

    Private Sub Form6_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tkh.Text = form5.tb1.Text
        snk.Text = form5.sonhankhau.Text
        csc.Text = form5.chisocu.Text
        csm.Text = form5.chisomoi.Text
        ttmk.Text = form5.tieuthumetkhoi.Text
        smktdm.Text = form5.sometkhoitrongdm.Text
        smkvdm.Text = form5.sometkhoivuotdm.Text
        ttsd.Text = form5.tiensd.Text
        pbvmt.Text = form5.phibaovemt.Text
        ttt.Text = form5.tongtien.Text
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class