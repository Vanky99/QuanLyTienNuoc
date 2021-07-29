Imports System.Data.OleDb
Public Class Hoadon
    Private con As OleDbConnection
    Private WithEvents hoa_don As BindingManagerBase
    Public hoadon As String
    Private lenh As String
    Private Sub Hoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constring As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = " & Application.StartupPath & "\HoaDon.mdb;"
        con = New OleDbConnection(constring)
        xuat_hoadon()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub xuat_hoadon()
        Dim lenh As String
        lenh = "select *from hoadon"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("hoadon")
        dttable.Load(bang, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        hoa_don = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        TextBox1.Text = hoa_don.Current("MaHoaDon")
        TextBox2.Text = hoa_don.Current("NgayThu")
        TextBox3.Text = hoa_don.Current("MaNhanVien")
        TextBox4.Text = hoa_don.Current("TenNhanVien")
        TextBox5.Text = hoa_don.Current("MaKhachHang")
        TextBox6.Text = hoa_don.Current("TenKhachHang")
        TextBox7.Text = hoa_don.Current("DiaChi")
        TextBox8.Text = hoa_don.Current("SoDienThoai")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoa_don.PositionChanged
        xuat()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Bạn có muốn lưu hóa đơn không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Chưa Nhập Giá Trị!!!")
            Else
                lenh = "insert into hoadon(MaHoaDon,NgayThu,MaNhanVien,TenNhanVien,MaKhachHang,TenKhachHang,DiaChi,SoDienThoai) values('" & _
                    TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_hoadon()
                MsgBox("Đã Thêm!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Bạn có muốn xóa  hóa đơn không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "xóa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("Phải chọn giá trị cần xóa!!!")
            Else
                lenh = "delete * from hoadon where MaHoaDon = '" & hoa_don.Current("MaHoaDon") & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_hoadon()
                MsgBox("Xóa Thành Công!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Bạn có muốn Sửa hóa đơn không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
                MsgBox("Nhập Giá Trị Cần Sửa!!!")
            Else
                lenh = "Update hoadon set MaHoaDon='" & TextBox1.Text & "',NgayThu='" _
                    & TextBox2.Text & "',MaNhanVien='" & TextBox3.Text & "',TenNhanVien='" & TextBox4.Text & "',MaKhachHang='" & TextBox5.Text & "',TenKhachHang='" _
                    & TextBox6.Text & "',DiaChi='" & TextBox7.Text & "',SoDienThoai='" & TextBox8.Text & ", ' where MaHoaDon = '" & Trim(TextBox1.Text) & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_hoadon()
                MsgBox("Đã Sửa Thành Công!")
            End If
        End If
    End Sub
End Class