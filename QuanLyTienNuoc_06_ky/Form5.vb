Public Class Form5
    Public id As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n3 As String = tb1.Text
        Dim n4 As Integer = sonhankhau.Text
        Dim n1 As Integer = chisocu.Text
        Dim n2 As Integer = chisomoi.Text
        Dim n5 As Integer = tieuthumetkhoi.Text
        Dim n6 As String = sometkhoitrongdm.Text
        Dim n7 As String = sometkhoivuotdm.Text
        n1 = Convert.ToInt32(chisocu.Text)
        n2 = Convert.ToInt32(chisomoi.Text)
        n4 = Convert.ToInt32(sonhankhau.Text)
        n3 = n2 - n1
        If (n1 < 0) Then
            MessageBox.Show("Nhap so cu, so moi sai quy dinh !", "Thong bao...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            chisocu.Focus()
            chisocu.Clear()
            chisomoi.Clear()
            Return
        End If
        tieuthumetkhoi.Text = Convert.ToString(n1)
        n5 = n4 * 4
        sometkhoitrongdm.Text = Convert.ToString(n5)
        n6 = n3 - n5
        If (n6 < 0) Then
            n6 = 0
            sometkhoivuotdm.Text = Convert.ToString(n6)
        End If
        n7 = n5 * 4000 + n6 * 8000
        tiensd.Text = Convert.ToString(n7) + "VND"
        phibaovemt.Text = Convert.ToString(n7 / 10) + "VND"
        tongtien.Text = Convert.ToString(n7 + n7 / 10) + "VND"
        phieutinh.Text = "Khách hàng: " + tb1.Text + vbNewLine + "Số Nhân Khẩu: " + sonhankhau.Text + vbNewLine + "Chỉ Số Cũ: " + chisocu.Text + vbNewLine + "Chỉ Số Mới: " + chisomoi.Text + vbNewLine + "Tiêu Thụ Mét Khối: " + tieuthumetkhoi.Text + vbNewLine + "Số mét khối trong định mức: " + sometkhoitrongdm.Text + vbNewLine + "Số mét khối vượt định mức: " + sometkhoivuotdm.Text + vbNewLine + "Tổng tiền sử dụng: " + tiensd.Text + vbNewLine + "Phí bảo vệ môi trường: " + phibaovemt.Text + vbNewLine + "Tổng thành tiền: " + tongtien.Text + vbNewLine

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim form As New Form6
        form.form5 = Me
        form.Show()
    End Sub

    Private Sub sometkhoitrongdm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sometkhoitrongdm.TextChanged

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb1.Text = id
    End Sub
End Class