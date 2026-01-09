Public Class FrmMainMenu
    Inherits Form
    Private Sub SetupMenuButton(btn As Button, text As String, img As Image)
        btn.Dock = DockStyle.Top
        btn.Height = 45
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(192, 255, 255)

        btn.Text = "  " & text
        btn.TextAlign = ContentAlignment.MiddleLeft

        btn.Image = img
        btn.ImageAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(12, 0, 0, 0)

        btn.Font = New Font("Segoe UI", 10)
        btn.Cursor = Cursors.Hand

        AddHandler btn.MouseEnter, AddressOf Menu_MouseEnter
        AddHandler btn.MouseLeave, AddressOf Menu_MouseLeave
    End Sub

    Private Sub HighlightButton(selectedBtn As Button)
        Dim btns() As Button = {BtnHome, BtnUser, BtnSalary, BtnDepartment}

        For Each btn In btns
            If btn Is selectedBtn Then
                ' Nổi bật nút được chọn
                btn.BackColor = Color.SteelBlue
                btn.ForeColor = Color.White
                btn.Font = New Font(btn.Font, FontStyle.Bold)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 2
                btn.FlatAppearance.BorderColor = Color.DarkBlue
            Else
                ' Reset các nút khác về mặc định
                btn.BackColor = Color.LightSteelBlue
                btn.ForeColor = Color.Black
                btn.Font = New Font(btn.Font, FontStyle.Regular)
                btn.FlatAppearance.BorderSize = 0
            End If
        Next
    End Sub


    ' ===== Hover effect =====
    Private Sub Menu_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Button).BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub Menu_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Button).BackColor = Color.FromArgb(192, 255, 255)
    End Sub
    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        HighlightButton(BtnHome)
        ' TODO: Hiển thị view Home
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        HighlightButton(BtnUser)
        ' TODO: Hiển thị view User
    End Sub

    Private Sub BtnSalary_Click(sender As Object, e As EventArgs) Handles BtnSalary.Click
        HighlightButton(BtnSalary)
        ' TODO: Hiển thị view Salary
    End Sub

    Private Sub BtnDepartment_Click(sender As Object, e As EventArgs) Handles BtnDepartment.Click
        HighlightButton(BtnDepartment)
        ' TODO: Hiển thị view Department
    End Sub

End Class