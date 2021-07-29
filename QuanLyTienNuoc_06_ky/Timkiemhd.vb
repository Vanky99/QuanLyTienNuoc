Imports System.Data.OleDb
Public Class Hoadon2
    Private con As OleDbConnection
    Private WithEvents tim_hoa_don As BindingManagerBase
    Public timhoadon As String
    Private lenh As String
    Private Sub Hoadon2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constring As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = " & Application.StartupPath & "\TimHoaDon.mdb;"
        con = New OleDbConnection(constring)
        xuat_timhoadon()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub xuat_timhoadon()
        Dim lenh As String
        lenh = "select *from timhoadon"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("timhoadon")
        dttable.Load(bang, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        tim_hoa_don = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        TextBox1.Text = tim_hoa_don.Current("MaHoaDon")
        TextBox4.Text = tim_hoa_don.Current("MaKhachHang")
        TextBox2.Text = tim_hoa_don.Current("TenKhachHang")
        TextBox3.Text = tim_hoa_don.Current("Thang")
        TextBox6.Text = tim_hoa_don.Current("Nam")
        TextBox5.Text = tim_hoa_don.Current("TongTien")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim_hoa_don.PositionChanged
        xuat()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Bạn có muốn lưu hóa đơn không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox4.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Chưa Nhập Giá Trị!!!")
            Else
                lenh = "insert into timhoadon(MaHoaDon,MaKhachHang,TenKhachHang,Thang,Nam,TongTien) values('" & _
                    TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_timhoadon()
                MsgBox("Đã Thêm!")
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Bạn có muốn xóa  hóa đơn không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "xóa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("Phải chọn giá trị cần xóa!!!")
            Else
                lenh = "delete * from timhoadon where MaHoaDon = '" & tim_hoa_don.Current("MaHoaDon") & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_timhoadon()
                MsgBox("Xóa Thành Công!")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lenh As String
        lenh = "select * from timhoadon where MaHoaDon ='" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("timhoadon")
        dttable.Load(bang, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        tim_hoa_don = Me.BindingContext(dttable)
    End Sub
End Class