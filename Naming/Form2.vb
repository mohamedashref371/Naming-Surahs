﻿Public Class Form2
    Public Ihash As String = "pULIUS4lIIoFMk2BkLn2XudZtxuCp6TJ5tbRul4G2P0="

    Private Sub Sega2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Now.Day = 5 And Now.Month = 11 Then
            ClientSize = New Size(548, 158)
            MyP.Location = New Point(100, 125) : I.Location = New Point(123, 101)
            f1.Location = New Point(95, 101) : f2.Location = New Point(434, 101) : f3.Location = New Point(75, 125) : f4.Location = New Point(450, 125)
            A.Location = New Point(12, 109) : B.Location = New Point(486, 109)
            LMhmd.Location = New Point(160, 77)
            dy.Visible = True
        End If
    End Sub

    Private Sub MyP_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MyP.LinkClicked
        Process.Start("https://facebook.com/FamilyKingsandQueensofcomputer371")
    End Sub

    Private Sub I_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles I.LinkClicked
        Process.Start("https://facebook.com/Mohamed3713317")
    End Sub

    Private Sub ckh_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ckh.LinkClicked
        Process.Start("http://www.mediafire.com/file/hlmjv4ril4p5ci3")
    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles A.Click
        Process.Start("http://www.mediafire.com/folder/f7ywtgzgczv3b")
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        Process.Start("http://www.mediafire.com/file/zy4teu5v14uf7ls")
    End Sub
End Class