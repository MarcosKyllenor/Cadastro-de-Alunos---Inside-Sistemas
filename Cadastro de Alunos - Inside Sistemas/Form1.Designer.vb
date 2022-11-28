<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeVIEW
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeVIEW))
        Me.View_AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosDB = New Cadastro_de_Alunos___Inside_Sistemas.AlunosDB()
        Me.AlunosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_AlunosTableAdapter = New Cadastro_de_Alunos___Inside_Sistemas.AlunosDBTableAdapters.View_AlunosTableAdapter()
        Me.TableAdapterManager = New Cadastro_de_Alunos___Inside_Sistemas.AlunosDBTableAdapters.TableAdapterManager()
        Me.AlunosTableAdapter = New Cadastro_de_Alunos___Inside_Sistemas.AlunosDBTableAdapters.AlunosTableAdapter()
        Me.View_AlunosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAlabel = New System.Windows.Forms.Label()
        Me.NomeTxt = New System.Windows.Forms.TextBox()
        Me.NomeLabel = New System.Windows.Forms.Label()
        Me.NascimentoLabel = New System.Windows.Forms.Label()
        Me.NascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EscolaridadeLabel = New System.Windows.Forms.Label()
        Me.EscolaridadeComboBox = New System.Windows.Forms.ComboBox()
        Me.CidadeLabel = New System.Windows.Forms.Label()
        Me.CidadeTxt = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.EstadoLabel = New System.Windows.Forms.Label()
        Me.BtnSalvarCadastro = New System.Windows.Forms.Button()
        Me.RATxt = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditarAluno = New System.Windows.Forms.Button()
        Me.BtnExcluirAluno = New System.Windows.Forms.Button()
        Me.PainelCadastro = New System.Windows.Forms.Panel()
        Me.PainelEdt = New System.Windows.Forms.Panel()
        Me.BtnCancelarEdt = New System.Windows.Forms.Button()
        Me.BtnSalvarEdt = New System.Windows.Forms.Button()
        Me.BtnCadastrarAluno = New System.Windows.Forms.Button()
        Me.MATitle = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CATitulo = New System.Windows.Forms.PictureBox()
        Me.EATitle = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.View_AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AlunosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PainelCadastro.SuspendLayout()
        Me.PainelEdt.SuspendLayout()
        CType(Me.MATitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EATitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_AlunosBindingSource
        '
        Me.View_AlunosBindingSource.DataMember = "View_Alunos"
        Me.View_AlunosBindingSource.DataSource = Me.AlunosDB
        '
        'AlunosDB
        '
        Me.AlunosDB.DataSetName = "AlunosDB"
        Me.AlunosDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlunosBindingSource1
        '
        Me.AlunosBindingSource1.DataMember = "Alunos"
        Me.AlunosBindingSource1.DataSource = Me.AlunosDBBindingSource
        '
        'AlunosDBBindingSource
        '
        Me.AlunosDBBindingSource.DataSource = Me.AlunosDB
        Me.AlunosDBBindingSource.Position = 0
        '
        'AlunosBindingSource2
        '
        Me.AlunosBindingSource2.DataMember = "Alunos"
        Me.AlunosBindingSource2.DataSource = Me.AlunosDBBindingSource
        '
        'AlunosBindingSource3
        '
        Me.AlunosBindingSource3.DataMember = "Alunos"
        Me.AlunosBindingSource3.DataSource = Me.AlunosDBBindingSource
        '
        'AlunosBindingSource
        '
        Me.AlunosBindingSource.DataMember = "Alunos"
        Me.AlunosBindingSource.DataSource = Me.AlunosDB
        '
        'View_AlunosTableAdapter
        '
        Me.View_AlunosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlunosTableAdapter = Me.AlunosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Cadastro_de_Alunos___Inside_Sistemas.AlunosDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlunosTableAdapter
        '
        Me.AlunosTableAdapter.ClearBeforeFill = True
        '
        'View_AlunosDataGridView
        '
        Me.View_AlunosDataGridView.AllowUserToAddRows = False
        Me.View_AlunosDataGridView.AllowUserToDeleteRows = False
        Me.View_AlunosDataGridView.AutoGenerateColumns = False
        Me.View_AlunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_AlunosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.View_AlunosDataGridView.DataSource = Me.View_AlunosBindingSource
        Me.View_AlunosDataGridView.Location = New System.Drawing.Point(348, 99)
        Me.View_AlunosDataGridView.Name = "View_AlunosDataGridView"
        Me.View_AlunosDataGridView.ReadOnly = True
        Me.View_AlunosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.View_AlunosDataGridView.Size = New System.Drawing.Size(1022, 598)
        Me.View_AlunosDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nascimento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nascimento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Idade"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Idade"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cidade"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cidade"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Escolaridade"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Escolaridade"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'RAlabel
        '
        Me.RAlabel.AutoSize = True
        Me.RAlabel.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.RAlabel.Location = New System.Drawing.Point(8, 152)
        Me.RAlabel.Name = "RAlabel"
        Me.RAlabel.Size = New System.Drawing.Size(37, 22)
        Me.RAlabel.TabIndex = 17
        Me.RAlabel.Text = "RA"
        '
        'NomeTxt
        '
        Me.NomeTxt.Enabled = False
        Me.NomeTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTxt.Location = New System.Drawing.Point(12, 244)
        Me.NomeTxt.Name = "NomeTxt"
        Me.NomeTxt.Size = New System.Drawing.Size(330, 26)
        Me.NomeTxt.TabIndex = 2
        '
        'NomeLabel
        '
        Me.NomeLabel.AutoSize = True
        Me.NomeLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeLabel.Location = New System.Drawing.Point(8, 219)
        Me.NomeLabel.Name = "NomeLabel"
        Me.NomeLabel.Size = New System.Drawing.Size(61, 22)
        Me.NomeLabel.TabIndex = 19
        Me.NomeLabel.Text = "Nome"
        '
        'NascimentoLabel
        '
        Me.NascimentoLabel.AutoSize = True
        Me.NascimentoLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NascimentoLabel.Location = New System.Drawing.Point(211, 289)
        Me.NascimentoLabel.Name = "NascimentoLabel"
        Me.NascimentoLabel.Size = New System.Drawing.Size(110, 22)
        Me.NascimentoLabel.TabIndex = 21
        Me.NascimentoLabel.Text = "Nascimento"
        '
        'NascimentoDateTimePicker
        '
        Me.NascimentoDateTimePicker.Enabled = False
        Me.NascimentoDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.NascimentoDateTimePicker.Location = New System.Drawing.Point(215, 314)
        Me.NascimentoDateTimePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.NascimentoDateTimePicker.MinDate = New Date(1950, 1, 1, 0, 0, 0, 0)
        Me.NascimentoDateTimePicker.Name = "NascimentoDateTimePicker"
        Me.NascimentoDateTimePicker.Size = New System.Drawing.Size(127, 26)
        Me.NascimentoDateTimePicker.TabIndex = 4
        Me.NascimentoDateTimePicker.Value = New Date(2022, 11, 27, 0, 0, 0, 0)
        '
        'EscolaridadeLabel
        '
        Me.EscolaridadeLabel.AutoSize = True
        Me.EscolaridadeLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EscolaridadeLabel.Location = New System.Drawing.Point(12, 289)
        Me.EscolaridadeLabel.Name = "EscolaridadeLabel"
        Me.EscolaridadeLabel.Size = New System.Drawing.Size(121, 22)
        Me.EscolaridadeLabel.TabIndex = 24
        Me.EscolaridadeLabel.Text = "Escolaridade"
        '
        'EscolaridadeComboBox
        '
        Me.EscolaridadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EscolaridadeComboBox.Enabled = False
        Me.EscolaridadeComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EscolaridadeComboBox.FormattingEnabled = True
        Me.EscolaridadeComboBox.Items.AddRange(New Object() {"Fundamental", "Médio", "Superior", "Pós-Graduação"})
        Me.EscolaridadeComboBox.Location = New System.Drawing.Point(16, 314)
        Me.EscolaridadeComboBox.Name = "EscolaridadeComboBox"
        Me.EscolaridadeComboBox.Size = New System.Drawing.Size(193, 26)
        Me.EscolaridadeComboBox.TabIndex = 3
        '
        'CidadeLabel
        '
        Me.CidadeLabel.AutoSize = True
        Me.CidadeLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeLabel.Location = New System.Drawing.Point(12, 360)
        Me.CidadeLabel.Name = "CidadeLabel"
        Me.CidadeLabel.Size = New System.Drawing.Size(71, 22)
        Me.CidadeLabel.TabIndex = 26
        Me.CidadeLabel.Text = "Cidade"
        '
        'CidadeTxt
        '
        Me.CidadeTxt.Enabled = False
        Me.CidadeTxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTxt.Location = New System.Drawing.Point(16, 384)
        Me.CidadeTxt.Name = "CidadeTxt"
        Me.CidadeTxt.Size = New System.Drawing.Size(254, 26)
        Me.CidadeTxt.TabIndex = 5
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.AutoCompleteCustomSource.AddRange(New String() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.Enabled = False
        Me.EstadoComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(276, 385)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(66, 26)
        Me.EstadoComboBox.TabIndex = 6
        '
        'EstadoLabel
        '
        Me.EstadoLabel.AutoSize = True
        Me.EstadoLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoLabel.Location = New System.Drawing.Point(272, 360)
        Me.EstadoLabel.Name = "EstadoLabel"
        Me.EstadoLabel.Size = New System.Drawing.Size(70, 22)
        Me.EstadoLabel.TabIndex = 29
        Me.EstadoLabel.Text = "Estado"
        '
        'BtnSalvarCadastro
        '
        Me.BtnSalvarCadastro.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnSalvarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSalvarCadastro.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvarCadastro.Location = New System.Drawing.Point(100, 3)
        Me.BtnSalvarCadastro.Name = "BtnSalvarCadastro"
        Me.BtnSalvarCadastro.Size = New System.Drawing.Size(75, 30)
        Me.BtnSalvarCadastro.TabIndex = 30
        Me.BtnSalvarCadastro.Text = "Salvar"
        Me.BtnSalvarCadastro.UseVisualStyleBackColor = False
        '
        'RATxt
        '
        Me.RATxt.Enabled = False
        Me.RATxt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RATxt.Location = New System.Drawing.Point(12, 177)
        Me.RATxt.Name = "RATxt"
        Me.RATxt.Size = New System.Drawing.Size(121, 26)
        Me.RATxt.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(3, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(91, 30)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEditarAluno
        '
        Me.BtnEditarAluno.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnEditarAluno.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarAluno.Location = New System.Drawing.Point(1084, 703)
        Me.BtnEditarAluno.Name = "BtnEditarAluno"
        Me.BtnEditarAluno.Size = New System.Drawing.Size(130, 30)
        Me.BtnEditarAluno.TabIndex = 33
        Me.BtnEditarAluno.Text = "Editar Aluno"
        Me.BtnEditarAluno.UseVisualStyleBackColor = False
        '
        'BtnExcluirAluno
        '
        Me.BtnExcluirAluno.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnExcluirAluno.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluirAluno.Location = New System.Drawing.Point(948, 703)
        Me.BtnExcluirAluno.Name = "BtnExcluirAluno"
        Me.BtnExcluirAluno.Size = New System.Drawing.Size(130, 30)
        Me.BtnExcluirAluno.TabIndex = 34
        Me.BtnExcluirAluno.Text = "Excluir Aluno"
        Me.BtnExcluirAluno.UseVisualStyleBackColor = False
        '
        'PainelCadastro
        '
        Me.PainelCadastro.Controls.Add(Me.BtnCancelar)
        Me.PainelCadastro.Controls.Add(Me.BtnSalvarCadastro)
        Me.PainelCadastro.Location = New System.Drawing.Point(162, 433)
        Me.PainelCadastro.Name = "PainelCadastro"
        Me.PainelCadastro.Size = New System.Drawing.Size(180, 37)
        Me.PainelCadastro.TabIndex = 35
        Me.PainelCadastro.Visible = False
        '
        'PainelEdt
        '
        Me.PainelEdt.Controls.Add(Me.BtnCancelarEdt)
        Me.PainelEdt.Controls.Add(Me.BtnSalvarEdt)
        Me.PainelEdt.Location = New System.Drawing.Point(162, 433)
        Me.PainelEdt.Name = "PainelEdt"
        Me.PainelEdt.Size = New System.Drawing.Size(180, 37)
        Me.PainelEdt.TabIndex = 36
        Me.PainelEdt.Visible = False
        '
        'BtnCancelarEdt
        '
        Me.BtnCancelarEdt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnCancelarEdt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCancelarEdt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarEdt.Location = New System.Drawing.Point(3, 3)
        Me.BtnCancelarEdt.Name = "BtnCancelarEdt"
        Me.BtnCancelarEdt.Size = New System.Drawing.Size(91, 30)
        Me.BtnCancelarEdt.TabIndex = 32
        Me.BtnCancelarEdt.Text = "Cancelar"
        Me.BtnCancelarEdt.UseVisualStyleBackColor = False
        '
        'BtnSalvarEdt
        '
        Me.BtnSalvarEdt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnSalvarEdt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnSalvarEdt.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvarEdt.Location = New System.Drawing.Point(100, 3)
        Me.BtnSalvarEdt.Name = "BtnSalvarEdt"
        Me.BtnSalvarEdt.Size = New System.Drawing.Size(75, 30)
        Me.BtnSalvarEdt.TabIndex = 7
        Me.BtnSalvarEdt.Text = "Salvar"
        Me.BtnSalvarEdt.UseVisualStyleBackColor = False
        '
        'BtnCadastrarAluno
        '
        Me.BtnCadastrarAluno.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCadastrarAluno.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCadastrarAluno.Location = New System.Drawing.Point(1220, 703)
        Me.BtnCadastrarAluno.Name = "BtnCadastrarAluno"
        Me.BtnCadastrarAluno.Size = New System.Drawing.Size(150, 30)
        Me.BtnCadastrarAluno.TabIndex = 37
        Me.BtnCadastrarAluno.Text = "Cadastrar Aluno"
        Me.BtnCadastrarAluno.UseVisualStyleBackColor = False
        '
        'MATitle
        '
        Me.MATitle.Image = Global.Cadastro_de_Alunos___Inside_Sistemas.My.Resources.Resources.Manager_de_Alunos1
        Me.MATitle.Location = New System.Drawing.Point(12, 99)
        Me.MATitle.Name = "MATitle"
        Me.MATitle.Size = New System.Drawing.Size(330, 50)
        Me.MATitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MATitle.TabIndex = 8
        Me.MATitle.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Cadastro_de_Alunos___Inside_Sistemas.My.Resources.Resources.LdS_Inside_purple
        Me.PictureBox2.Location = New System.Drawing.Point(348, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1022, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cadastro_de_Alunos___Inside_Sistemas.My.Resources.Resources.inside
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CATitulo
        '
        Me.CATitulo.Image = Global.Cadastro_de_Alunos___Inside_Sistemas.My.Resources.Resources.Cadastrando_Aluno
        Me.CATitulo.Location = New System.Drawing.Point(12, 99)
        Me.CATitulo.Name = "CATitulo"
        Me.CATitulo.Size = New System.Drawing.Size(330, 50)
        Me.CATitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CATitulo.TabIndex = 38
        Me.CATitulo.TabStop = False
        Me.CATitulo.Visible = False
        '
        'EATitle
        '
        Me.EATitle.Image = Global.Cadastro_de_Alunos___Inside_Sistemas.My.Resources.Resources.Editando_Aluno
        Me.EATitle.Location = New System.Drawing.Point(12, 99)
        Me.EATitle.Name = "EATitle"
        Me.EATitle.Size = New System.Drawing.Size(330, 50)
        Me.EATitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.EATitle.TabIndex = 39
        Me.EATitle.TabStop = False
        Me.EATitle.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 718)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(119, 18)
        Me.LinkLabel1.TabIndex = 40
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Inside Sistemas"
        '
        'HomeVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 745)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CATitulo)
        Me.Controls.Add(Me.EATitle)
        Me.Controls.Add(Me.MATitle)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(Me.BtnCadastrarAluno)
        Me.Controls.Add(Me.RAlabel)
        Me.Controls.Add(Me.NomeLabel)
        Me.Controls.Add(Me.BtnEditarAluno)
        Me.Controls.Add(Me.NomeTxt)
        Me.Controls.Add(Me.BtnExcluirAluno)
        Me.Controls.Add(Me.NascimentoLabel)
        Me.Controls.Add(Me.View_AlunosDataGridView)
        Me.Controls.Add(Me.NascimentoDateTimePicker)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.EscolaridadeLabel)
        Me.Controls.Add(Me.PainelEdt)
        Me.Controls.Add(Me.RATxt)
        Me.Controls.Add(Me.PainelCadastro)
        Me.Controls.Add(Me.EscolaridadeComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EstadoLabel)
        Me.Controls.Add(Me.CidadeTxt)
        Me.Controls.Add(Me.CidadeLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HomeVIEW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Alunos - Inside Sistemas (Marcos Bento)"
        CType(Me.View_AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AlunosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PainelCadastro.ResumeLayout(False)
        Me.PainelEdt.ResumeLayout(False)
        CType(Me.MATitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATitulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EATitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlunosDB As AlunosDB
    Friend WithEvents View_AlunosBindingSource As BindingSource
    Friend WithEvents View_AlunosTableAdapter As AlunosDBTableAdapters.View_AlunosTableAdapter
    Friend WithEvents TableAdapterManager As AlunosDBTableAdapters.TableAdapterManager
    Friend WithEvents AlunosTableAdapter As AlunosDBTableAdapters.AlunosTableAdapter
    Friend WithEvents AlunosBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MATitle As PictureBox
    Friend WithEvents AlunosDBBindingSource As BindingSource
    Friend WithEvents AlunosBindingSource1 As BindingSource
    Friend WithEvents AlunosBindingSource2 As BindingSource
    Friend WithEvents AlunosBindingSource3 As BindingSource
    Friend WithEvents View_AlunosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents RAlabel As Label
    Friend WithEvents NomeTxt As TextBox
    Friend WithEvents NomeLabel As Label
    Friend WithEvents NascimentoLabel As Label
    Friend WithEvents NascimentoDateTimePicker As DateTimePicker
    Friend WithEvents EscolaridadeLabel As Label
    Friend WithEvents EscolaridadeComboBox As ComboBox
    Friend WithEvents CidadeLabel As Label
    Friend WithEvents CidadeTxt As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents EstadoLabel As Label
    Friend WithEvents BtnSalvarCadastro As Button
    Friend WithEvents RATxt As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditarAluno As Button
    Friend WithEvents BtnExcluirAluno As Button
    Friend WithEvents PainelCadastro As Panel
    Friend WithEvents PainelEdt As Panel
    Friend WithEvents BtnCancelarEdt As Button
    Friend WithEvents BtnSalvarEdt As Button
    Friend WithEvents BtnCadastrarAluno As Button
    Friend WithEvents CATitulo As PictureBox
    Friend WithEvents EATitle As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
