<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeattle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        lblNumberOfTickets = New Label()
        txtNumberOfTickets = New TextBox()
        lblPricePerTour = New Label()
        PictureBox1 = New PictureBox()
        btnDisplayCost = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblTotalCost = New Label()
        lblCost = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(42, 21)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(285, 23)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Seattle Walking Tour Tickets"
        ' 
        ' lblNumberOfTickets
        ' 
        lblNumberOfTickets.AutoSize = True
        lblNumberOfTickets.Font = New Font("Tahoma", 11.25F)
        lblNumberOfTickets.ForeColor = Color.White
        lblNumberOfTickets.Location = New Point(12, 96)
        lblNumberOfTickets.Name = "lblNumberOfTickets"
        lblNumberOfTickets.Size = New Size(137, 18)
        lblNumberOfTickets.TabIndex = 1
        lblNumberOfTickets.Text = "Number Of Tickets:"
        ' 
        ' txtNumberOfTickets
        ' 
        txtNumberOfTickets.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNumberOfTickets.Location = New Point(155, 96)
        txtNumberOfTickets.Name = "txtNumberOfTickets"
        txtNumberOfTickets.Size = New Size(38, 26)
        txtNumberOfTickets.TabIndex = 2
        txtNumberOfTickets.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPricePerTour
        ' 
        lblPricePerTour.AutoSize = True
        lblPricePerTour.Font = New Font("Tahoma", 11.25F)
        lblPricePerTour.ForeColor = Color.White
        lblPricePerTour.Location = New Point(162, 58)
        lblPricePerTour.Name = "lblPricePerTour"
        lblPricePerTour.Size = New Size(48, 18)
        lblPricePerTour.TabIndex = 3
        lblPricePerTour.Text = "$X.XX"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Image = My.Resources.Resources.Seattle
        PictureBox1.Location = New Point(390, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(410, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnDisplayCost
        ' 
        btnDisplayCost.BackColor = Color.White
        btnDisplayCost.Font = New Font("Tahoma", 9.75F)
        btnDisplayCost.Location = New Point(13, 272)
        btnDisplayCost.Name = "btnDisplayCost"
        btnDisplayCost.Size = New Size(85, 23)
        btnDisplayCost.TabIndex = 5
        btnDisplayCost.Text = "Display Cost"
        btnDisplayCost.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Font = New Font("Tahoma", 9.75F)
        btnClear.Location = New Point(125, 272)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.White
        btnExit.Font = New Font("Tahoma", 9.75F)
        btnExit.Location = New Point(222, 272)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(85, 23)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Tahoma", 11.25F)
        lblTotalCost.ForeColor = Color.White
        lblTotalCost.Location = New Point(12, 150)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(149, 18)
        lblTotalCost.TabIndex = 8
        lblTotalCost.Text = "Total Cost of Tickets:"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 11.25F)
        lblCost.ForeColor = Color.White
        lblCost.Location = New Point(155, 150)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(37, 18)
        lblCost.TabIndex = 9
        lblCost.Text = "Cost"
        ' 
        ' frmSeattle
        ' 
        AcceptButton = btnDisplayCost
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        CancelButton = btnClear
        ClientSize = New Size(800, 450)
        Controls.Add(lblCost)
        Controls.Add(lblTotalCost)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnDisplayCost)
        Controls.Add(PictureBox1)
        Controls.Add(lblPricePerTour)
        Controls.Add(txtNumberOfTickets)
        Controls.Add(lblNumberOfTickets)
        Controls.Add(lblHeading)
        Name = "frmSeattle"
        Text = "Seattle Walking Tour"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents txtNumberOfTickets As TextBox
    Friend WithEvents lblPricePerTour As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCost As Label

End Class
