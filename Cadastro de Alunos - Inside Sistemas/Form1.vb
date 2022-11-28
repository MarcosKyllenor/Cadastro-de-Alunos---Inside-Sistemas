Imports System.Data.SqlClient

Public Class HomeVIEW
    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private strSQL As String
    Private id As Integer
    Private RA As Integer
    Private Nome As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'AlunosDB.Alunos'. Você pode movê-la ou removê-la conforme necessário.
        Me.AlunosTableAdapter.Fill(Me.AlunosDB.Alunos)
        'TODO: esta linha de código carrega dados na tabela 'AlunosDB.View_Alunos'. Você pode movê-la ou removê-la conforme necessário.
        Me.View_AlunosTableAdapter.Fill(Me.AlunosDB.View_Alunos)

    End Sub

    Private Sub SalvarCadastro_Click(sender As Object, e As EventArgs) Handles BtnSalvarCadastro.Click
        If ChecarCampos() Then
            SalvarCadastro()

        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim Confirmação As Integer = MsgBox("Tem certeza que deseja cancelar? os dados preenchidos serão perdidos!", MsgBoxStyle.Question + MsgBoxStyle.OkCancel)
        If Confirmação = 1 Then
            Cancelar()

        Else
        End If

    End Sub

    Private Sub BtnExcluirAluno_Click(sender As Object, e As EventArgs) Handles BtnExcluirAluno.Click
        ExcluirAluno()
        AtualizarLista()

    End Sub

    Private Sub BtnCadastrarAluno_Click(sender As Object, e As EventArgs) Handles BtnCadastrarAluno.Click
        LimparCampos()
        RATxt.Enabled = True
        NomeTxt.Enabled = True
        EscolaridadeComboBox.Enabled = True
        NascimentoDateTimePicker.Enabled = True
        CidadeTxt.Enabled = True
        EstadoComboBox.Enabled = True
        CATitulo.Visible = True
        EATitle.Visible = False
        MATitle.Visible = False
        PainelEdt.Visible = False
        PainelCadastro.Visible = True

    End Sub

    Private Sub BtnCancelarEdt_Click(sender As Object, e As EventArgs) Handles BtnCancelarEdt.Click
        Dim Confirmação As Integer = MsgBox("Tem certeza que deseja cancelar? os dados preenchidos serão perdidos!", MsgBoxStyle.Question + MsgBoxStyle.OkCancel)
        If Confirmação = 1 Then
            Cancelar()
        Else
        End If

    End Sub

    Private Sub BtnEditarAluno_Click(sender As Object, e As EventArgs) Handles BtnEditarAluno.Click
        LimparCampos()
        id = View_AlunosDataGridView.CurrentRow.Cells(0).Value
        RATxt.Enabled = True
        RATxt.SelectedText = View_AlunosDataGridView.CurrentRow.Cells(1).Value
        NomeTxt.Enabled = True
        NomeTxt.SelectedText = View_AlunosDataGridView.CurrentRow.Cells(2).Value
        EscolaridadeComboBox.Enabled = True
        EscolaridadeComboBox.SelectedIndex = View_AlunosDataGridView.CurrentRow.Cells(3).ColumnIndex
        NascimentoDateTimePicker.Enabled = True
        CidadeTxt.Enabled = True
        CidadeTxt.SelectedText = View_AlunosDataGridView.CurrentRow.Cells(5).Value
        EstadoComboBox.Enabled = True
        EstadoComboBox.SelectedIndex = View_AlunosDataGridView.CurrentRow.Cells(6).ColumnIndex
        CATitulo.Visible = False
        EATitle.Visible = True
        MATitle.Visible = False
        PainelCadastro.Visible = False
        PainelEdt.Visible = True

    End Sub

    Private Sub BtnSalvarEdt_Click(sender As Object, e As EventArgs) Handles BtnSalvarEdt.Click
        If ChecarCampos() Then
            SalvarEdt()

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.insidesistemas.com.br/")
    End Sub

    Function SalvarCadastro()
        Try
            Dim Confirmação As Integer = MsgBox("Confirmar o cadastro do aluno", MsgBoxStyle.Question + MsgBoxStyle.OkCancel)
            If Confirmação = 1 Then

                conexao = New SqlConnection("Server=Marcos;Database=AlunosDB;User Id=Marcos;Password=0204;")
                strSQL = "Insert Into Alunos (RA,Nome,Escolaridade,Nascimento,Cidade,Estado) Values (@RA,@Nome,@Escolaridade,@Nascimento,@Cidade,@Estado)"
                comando = New SqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("RA", RATxt.Text)
                comando.Parameters.AddWithValue("Nome", NomeTxt.Text)
                comando.Parameters.AddWithValue("Escolaridade", EscolaridadeComboBox.Text)
                comando.Parameters.AddWithValue("Nascimento", NascimentoDateTimePicker.Text)
                comando.Parameters.AddWithValue("Cidade", CidadeTxt.Text)
                comando.Parameters.AddWithValue("Estado", EstadoComboBox.Text)
                conexao.Open()
                comando.ExecuteNonQuery()
                MsgBox("Aluno cadastrado com sucesso!")
                AtualizarLista()
                LimparCampos()
                Cancelar()

            Else

                MsgBox("Cadastro Cancelado")
            End If

        Catch erro As Exception
            MsgBox("Erro ao cadastrar aluno" + erro.Message)

        End Try
    End Function

    Function SalvarEdt()
        Try
            id = View_AlunosDataGridView.CurrentRow.Cells(0).Value
            RA = View_AlunosDataGridView.CurrentRow.Cells(1).Value
            Nome = View_AlunosDataGridView.CurrentRow.Cells(2).Value
            Dim Confirmação As Integer = MsgBox("Confirmar edição do aluno: " & Nome & ", RA:" & RA & " ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel)
            If Confirmação = 1 Then

                conexao = New SqlConnection("Server=Marcos;Database=AlunosDB;User Id=Marcos;Password=0204;")
                strSQL = "update Alunos set RA = @RA, nome = @Nome, Escolaridade = @Escolaridade, Nascimento = @Nascimento, Cidade = @Cidade, Estado = @Estado where id = @ID"
                comando = New SqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("ID", id)
                comando.Parameters.AddWithValue("RA", RATxt.Text)
                comando.Parameters.AddWithValue("Nome", NomeTxt.Text)
                comando.Parameters.AddWithValue("Escolaridade", EscolaridadeComboBox.Text)
                comando.Parameters.AddWithValue("Nascimento", NascimentoDateTimePicker.Text)
                comando.Parameters.AddWithValue("Cidade", CidadeTxt.Text)
                comando.Parameters.AddWithValue("Estado", EstadoComboBox.Text)
                conexao.Open()
                comando.ExecuteNonQuery()
                MsgBox("Aluno " & Nome & " editado com sucesso!")
                AtualizarLista()
                LimparCampos()
                Cancelar()

            Else

                MsgBox("Edição Cancelado")
            End If

        Catch erro As Exception
            MsgBox("Erro ao editar aluno" + erro.Message)

        End Try
    End Function

    Function ChecarCampos() As Boolean
        If RATxt.Text = "" Then
            MsgBox("Preencha o campo RA!")
            RATxt.Focus()
        ElseIf NomeTxt.Text = "" Then
            MsgBox("Preencha o campo Nome!")
            NomeTxt.Focus()
        ElseIf EscolaridadeComboBox.Text = "" Then
            MsgBox("Preencha o campo Escolaridade!")
            EscolaridadeComboBox.Focus()
        ElseIf NascimentoDateTimePicker.Text = "" Then
            MsgBox("Preencha a data de Nascimento!")
            EscolaridadeComboBox.Focus()
        ElseIf CidadeTxt.Text = "" Then
            MsgBox("Preencha o campo Cidade!")
            CidadeTxt.Focus()
        ElseIf EstadoComboBox.Text = "" Then
            MsgBox("Preencha o campo Estado!")
            EstadoComboBox.Focus()
        Else
            ChecarCampos = True
        End If
    End Function

    Function AtualizarLista()
        Try
            conexao = New SqlConnection("Server=Marcos;Database=AlunosDB;User Id=Marcos;Password=0204;")
            strSQL = "SELECT ID, RA, Nome, Nascimento, Cidade, Estado, Escolaridade, Idade FROM View_Alunos"
            comando = New SqlCommand(strSQL, conexao)
            da = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()
            Dim ds As New DataSet
            da.Fill(ds)
            comando.ExecuteNonQuery()
            View_AlunosDataGridView.DataSource = ds.Tables(0)
        Catch erro As Exception
            MsgBox("Erro ao atualizar lista" + erro.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing

        End Try
    End Function

    Function LimparCampos()
        RATxt.ResetText()
        NomeTxt.ResetText()
        EscolaridadeComboBox.ResetText()
        NascimentoDateTimePicker.ResetText()
        CidadeTxt.ResetText()
        EstadoComboBox.ResetText()
    End Function

    Function ExcluirAluno()
        Try
            id = View_AlunosDataGridView.CurrentRow.Cells(0).Value
            RA = View_AlunosDataGridView.CurrentRow.Cells(1).Value
            Nome = View_AlunosDataGridView.CurrentRow.Cells(2).Value
            Dim Confirmação As Integer = MsgBox("Tem certeza que deseja excluir o Aluno " & Nome & " RA: " & RA, MsgBoxStyle.Question + MsgBoxStyle.OkCancel)

            If Confirmação = 1 Then

                conexao = New SqlConnection("Server=Marcos;Database=AlunosDB;User Id=Marcos;Password=0204;")
                strSQL = "delete Alunos where id= @ID"
                comando = New SqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("ID", id)
                conexao.Open()
                comando.ExecuteNonQuery()
                MsgBox("Aluno excluido com sucesso!")
                AtualizarLista()
            Else
                MsgBox("Exclusão cancelada!")
            End If

        Catch erro As Exception
            MsgBox("Erro ao excluir aluno" + erro.Message)

        End Try
    End Function

    Function Cancelar()
        RATxt.ResetText()
        NomeTxt.ResetText()
        EscolaridadeComboBox.ResetText()
        NascimentoDateTimePicker.ResetText()
        CidadeTxt.ResetText()
        EstadoComboBox.ResetText()
        RATxt.Enabled = False
        NomeTxt.Enabled = False
        EscolaridadeComboBox.Enabled = False
        NascimentoDateTimePicker.Enabled = False
        CidadeTxt.Enabled = False
        EstadoComboBox.Enabled = False
        MATitle.Visible = True
        CATitulo.Visible = False
        EATitle.Visible = False
        PainelCadastro.Visible = False
        PainelEdt.Visible = False


    End Function

End Class

