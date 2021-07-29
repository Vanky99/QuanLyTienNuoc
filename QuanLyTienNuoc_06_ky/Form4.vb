Imports System.Data.OleDb
Public Class Form4
    Private con As OleDbConnection
    Private WithEvents khach_hang As BindingManagerBase
    Public khachhang As String
    Private lenh As String
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim form As New Form5
        form.id = khach_hang.Current("TenKhachHang")
        form.Show()

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constring As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = " & Application.StartupPath & "\KhachHang.mdb;"
        con = New OleDbConnection(constring)
        xuat_khachhang()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub xuat_khachhang()
        Dim lenh As String
        lenh = "select *from khachhang"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("khachhang")
        dttable.Load(bang, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        khach_hang = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        TextBox1.Text = khach_hang.Current("MaKhachHang")
        TextBox2.Text = khach_hang.Current("TenKhachHang")
        TextBox4.Text = khach_hang.Current("DiaChi")
        TextBox5.Text = khach_hang.Current("DienThoai")
        TextBox3.Text = khach_hang.Current("SoNuocDung")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles khach_hang.PositionChanged
        xuat()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Chưa Nhập Giá Trị!!!")
            Else
                lenh = "insert into khachhang(MaKhachHang,TenKhachHang,DiaChi,DienThoai,SoNuocDung) values('" & _
                    TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox3.Text & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_khachhang()
                MsgBox("Đã Thêm!")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "xóa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("Phải chọn giá trị cần xóa!!!")
            Else
                lenh = "delete * from khachhang where MaKhachHang = '" & khach_hang.Current("MaKhachHang") & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_khachhang()
                MsgBox("Xóa Thành Công!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Bạn có muốn Sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Nhập Giá Trị Cần Sửa!!!")
            Else
                lenh = "Update khachhang set MaKhachHang='" & TextBox1.Text & "',TenKhachHang='" & TextBox2.Text & "',DiaChi='" & TextBox4.Text & "',DienThoai='" & TextBox5.Text & "',SoNuocDung='" & TextBox3.Text & ", ' where MaKhachHang = '" & Trim(TextBox1.Text) & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_khachhang()
                MsgBox("Đã Sửa Thành Công!")
            End If
        End If
    End Sub
End Class