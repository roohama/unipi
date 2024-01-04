<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TugasFungsi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        rbakar = New RadioButton()
        rbpangkat = New RadioButton()
        rbbagi = New RadioButton()
        rbtambah = New RadioButton()
        rbkurang = New RadioButton()
        rbkali = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(67, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(67, 119)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(253, 65)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' rbakar
        ' 
        rbakar.AutoSize = True
        rbakar.Location = New Point(67, 205)
        rbakar.Name = "rbakar"
        rbakar.Size = New Size(93, 19)
        rbakar.TabIndex = 3
        rbakar.TabStop = True
        rbakar.Text = "Akar Kuadrat"
        rbakar.UseVisualStyleBackColor = True
        ' 
        ' rbpangkat
        ' 
        rbpangkat.AutoSize = True
        rbpangkat.Location = New Point(66, 257)
        rbpangkat.Name = "rbpangkat"
        rbpangkat.Size = New Size(68, 19)
        rbpangkat.TabIndex = 4
        rbpangkat.TabStop = True
        rbpangkat.Text = "Pangkat"
        rbpangkat.UseVisualStyleBackColor = True
        ' 
        ' rbbagi
        ' 
        rbbagi.AutoSize = True
        rbbagi.Location = New Point(65, 313)
        rbbagi.Name = "rbbagi"
        rbbagi.Size = New Size(85, 19)
        rbbagi.TabIndex = 5
        rbbagi.TabStop = True
        rbbagi.Text = "Pembagian"
        rbbagi.UseVisualStyleBackColor = True
        ' 
        ' rbtambah
        ' 
        rbtambah.AutoSize = True
        rbtambah.Location = New Point(246, 205)
        rbtambah.Name = "rbtambah"
        rbtambah.Size = New Size(95, 19)
        rbtambah.TabIndex = 8
        rbtambah.TabStop = True
        rbtambah.Text = "Penjumlahan"
        rbtambah.UseVisualStyleBackColor = True
        ' 
        ' rbkurang
        ' 
        rbkurang.AutoSize = True
        rbkurang.Location = New Point(246, 257)
        rbkurang.Name = "rbkurang"
        rbkurang.Size = New Size(96, 19)
        rbkurang.TabIndex = 7
        rbkurang.TabStop = True
        rbkurang.Text = "Pengurangan"
        rbkurang.UseVisualStyleBackColor = True
        ' 
        ' rbkali
        ' 
        rbkali.AutoSize = True
        rbkali.Location = New Point(246, 313)
        rbkali.Name = "rbkali"
        rbkali.Size = New Size(73, 19)
        rbkali.TabIndex = 6
        rbkali.TabStop = True
        rbkali.Text = "Perkalian"
        rbkali.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(92, 389)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "HITUNG"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(253, 389)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "TUTUP"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(59, 171)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(294, 181)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Operasi"
        ' 
        ' TugasFungsi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(441, 493)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(rbtambah)
        Controls.Add(rbkurang)
        Controls.Add(rbkali)
        Controls.Add(rbbagi)
        Controls.Add(rbpangkat)
        Controls.Add(rbakar)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox1)
        Name = "TugasFungsi"
        Text = "TugasFungsi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents rbakar As RadioButton
    Friend WithEvents rbpangkat As RadioButton
    Friend WithEvents rbbagi As RadioButton
    Friend WithEvents rbtambah As RadioButton
    Friend WithEvents rbkurang As RadioButton
    Friend WithEvents rbkali As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
