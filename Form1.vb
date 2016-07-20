Imports System.IO
Module Energycalc
    Sub Main()
        Dim ObjectVar As StreamWriter
        File.CreateText()
       


    End Sub
End Module

Public Class Form1

    Dim Wattage As Double
    Dim UsageTime As Integer
    Dim Total As Double
    Dim KiloWatt As Double = 1000    'varibles



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Wattage = TextBox1.Text
        UsageTime = TextBox2.Text
        Total = Wattage * UsageTime / KiloWatt       'Equation that calculates Kilowatts used based
        ' on hours of use per day 

        MessageBox.Show(Total & "kilowatts")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)Handles 

    End Sub

    Private Sub SavAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavAsToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub
End Class