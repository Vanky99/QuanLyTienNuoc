Imports System.Data.OleDb
Public Class Form3
    Private con As OleDbConnection
    Private WithEvents nhan_vien As BindingManagerBase
    Public nhanvien As String
    Private lenh As String
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constring As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = " & Application.StartupPath & "\NhanVien.mdb;"
        con = New OleDbConnection(constring)
        xuat_nhanvien()
        danh_sach_moi(sender, e)
    End Sub
    Private Sub xuat_nhanvien()
        Dim lenh As String
        lenh = "select *from nhanvien"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("nhanvien")
        dttable.Load(bang, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        nhan_vien = Me.BindingContext(dttable)
    End Sub
    Private Sub xuat()
        TextBox1.Text = nhan_vien.Current("MaNhanVien")
        TextBox2.Text = nhan_vien.Current("HoTenNhanVien")
        TextBox3.Text = nhan_vien.Current("GioiTinh")
        TextBox4.Text = nhan_vien.Current("DiaChi")
        TextBox5.Text = nhan_vien.Current("DienThoai")
        DateTimePicker1.Value = nhan_vien.Current("NgaySinh")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nhan_vien.PositionChanged
        xuat()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Value = Date.Now.Date
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim lenh As String
        lenh = "select *from nhanvien"
        Dim cmd As New OleDbCommand(lenh, con)
        con.Open()
        Dim bang As OleDbDataReader = cmd.ExecuteReader
        Dim dttable As New DataTable("nhanvien")
        dttable.Load(bang, LoadOption.OverwriteChanges)
        con.Close()
        DataGridView1.DataSource = dttable
        nhan_vien = Me.BindingContext(dttable)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or DateTimePicker1.Value = Date.Now.Date Then
                MsgBox("Chưa Nhập Giá Trị!!!")
            Else
                lenh = "insert into nhanvien(MaNhanVien,HoTenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh) values('" & _
                    TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & DateTimePicker1.Value & "')"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_nhanvien()
                MsgBox("Đã Thêm!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Bạn có muốn Sửa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or DateTimePicker1.Value = Date.Now.Date Then
                MsgBox("Nhập Giá Trị Cần Sửa!!!")
            Else
                lenh = "Update nhanvien set MaNhanVien='" & TextBox1.Text & "',HoTenNhanVien='" & TextBox2.Text & "',GioiTinh='" & TextBox3.Text & "',DiaChi='" & TextBox4.Text & "',DienThoai='" & TextBox5.Text & "',NgaySinh='" & DateTimePicker1.Value & "' where MaNhanVien = '" & Trim(TextBox1.Text) & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_nhanvien()
                MsgBox("Đã Sửa Thành Công!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Bạn có muốn xóa không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "xóa") = MsgBoxResult.Yes Then
            If TextBox1.Text = "" Then
                MsgBox("Phải chọn giá trị cần xóa!!!")
            Else
                lenh = "delete * from nhanvien where MaNhanVien = '" & nhan_vien.Current("MaNhanVien") & "'"
                Dim cmd As New OleDbCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                xuat_nhanvien()
                MsgBox("Xóa Thành Công!")
            End If
        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class