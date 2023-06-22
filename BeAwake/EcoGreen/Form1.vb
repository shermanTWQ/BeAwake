Imports System.Runtime.InteropServices

Public Class Form1

    'BeAware 1.0
    'Provided for non-commercial use. Please refer to Github Repo for more information. 
    'Contact: Sherman_tan@outlook.com
    '(C) Tan Wei Qiang Sherman.

    <FlagsAttribute()>
    Public Enum EXECUTION_STATE As UInteger
        ES_SYSTEM_REQUIRED = &H1
        ES_DISPLAY_REQUIRED = &H2
        ES_CONTINUOUS = &H80000000UI
    End Enum

    <DllImport("Kernel32.DLL", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetThreadExecutionState(ByVal state As EXECUTION_STATE) As EXECUTION_STATE
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED)
        lblStatus.Text = "Active"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAwake.Click
        lblStatus.Text = "Not Active"
        Me.Close()
    End Sub
End Class
