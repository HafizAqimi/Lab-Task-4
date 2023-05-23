<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabTask4Customer1 = New LabTask4.LabTask4Customer1()
        Me.CustomersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter2 = New LabTask4.LabTask4Customer1TableAdapters.customersTableAdapter()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestaurantNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestaurantLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabTask4Customer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ReservationDateDataGridViewTextBoxColumn, Me.RestaurantNameDataGridViewTextBoxColumn, Me.RestaurantLocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 228)
        Me.DataGridView1.TabIndex = 0
        '
        'LabTask4Customer1
        '
        Me.LabTask4Customer1.DataSetName = "LabTask4Customer1"
        Me.LabTask4Customer1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource2
        '
        Me.CustomersBindingSource2.DataMember = "customers"
        Me.CustomersBindingSource2.DataSource = Me.LabTask4Customer1
        '
        'CustomersTableAdapter2
        '
        Me.CustomersTableAdapter2.ClearBeforeFill = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'ReservationDateDataGridViewTextBoxColumn
        '
        Me.ReservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate"
        Me.ReservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate"
        Me.ReservationDateDataGridViewTextBoxColumn.Name = "ReservationDateDataGridViewTextBoxColumn"
        '
        'RestaurantNameDataGridViewTextBoxColumn
        '
        Me.RestaurantNameDataGridViewTextBoxColumn.DataPropertyName = "RestaurantName"
        Me.RestaurantNameDataGridViewTextBoxColumn.HeaderText = "RestaurantName"
        Me.RestaurantNameDataGridViewTextBoxColumn.Name = "RestaurantNameDataGridViewTextBoxColumn"
        '
        'RestaurantLocationDataGridViewTextBoxColumn
        '
        Me.RestaurantLocationDataGridViewTextBoxColumn.DataPropertyName = "RestaurantLocation"
        Me.RestaurantLocationDataGridViewTextBoxColumn.HeaderText = "RestaurantLocation"
        Me.RestaurantLocationDataGridViewTextBoxColumn.Name = "RestaurantLocationDataGridViewTextBoxColumn"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(643, 228)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer's Reservation Histories"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabTask4Customer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabTask4Customer1 As LabTask4Customer1
    Friend WithEvents CustomersBindingSource2 As BindingSource
    Friend WithEvents CustomersTableAdapter2 As LabTask4Customer1TableAdapters.customersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestaurantNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RestaurantLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
