using WinFormsApp1.Repositorios;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text, txtSenha.Text, txtEndereco.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Atualizar(pessoa);
            LimparCampos();
            BuscarTodos(pessoaRepositorio);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Deletar(Convert.ToInt32(txtId.Text));
            LimparCampos();
            BuscarTodos(pessoaRepositorio);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa(0, txtNome.Text, txtCpf.Text, txtEmail.Text, txtSenha.Text, txtEndereco.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Inserir(pessoa);
            LimparCampos();
            BuscarTodos(pessoaRepositorio);
        }

        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void BuscarTodos(PessoaRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarTodos();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            BuscarTodos(pessoaRepositorio);
        }

        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtId.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value?.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"]?.Value?.ToString();
            txtSenha.Text = dgv.CurrentRow.Cells["Senha"]?.Value?.ToString();
            txtEndereco.Text = dgv.CurrentRow.Cells["Endereco"]?.Value?.ToString();
        }
    }
}