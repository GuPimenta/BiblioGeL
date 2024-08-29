namespace Biblio
{
    public partial class Form1 : Form
    {
        List<Livro> lista = new List<Livro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro()
            {
                id = TBoxID.Text,
                titulo = TBoxTitulo.Text,
                autor = TBoxAutor.Text,
                ano = int.Parse(TBoxAno.Text),
                genero = TBoxGenero.Text,
                isbn = TBoxISBN.Text
            };

            if (lista.Any(a => a.id == livro.id))
            {
                TBoxStatus.Text = "Erro! Livro já cadastrado!";
            }

            else
            {
                lista.Add(livro);
                DGridList.Rows.Add(livro.id, livro.titulo, livro.autor, livro.ano, livro.genero, livro.isbn);
                TBoxStatus.Text = "Livro cadastrado com sucesso!";
            }
        }

        private void BRemover_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro()
            {
                id = TBoxID.Text,
                titulo = TBoxTitulo.Text,
                autor = TBoxAutor.Text,
                ano = int.Parse(TBoxAno.Text),
                genero = TBoxGenero.Text,
                isbn = TBoxISBN.Text
            };

            if (lista.Any(a => a.id == livro.id))
            {
                for (int v = 0; v < DGridList.Rows.Count; v++)
                {
                    if (string.Equals(DGridList[0, v].Value as string, livro.id))
                    {
                        lista.RemoveAll(l => l.id == livro.id);
                        DGridList.Rows.RemoveAt(v);
                        TBoxStatus.Text = "Livro apagado com sucesso!";
                    }
                }
            }

            else
            {
                TBoxStatus.Text = "Erro! Livro não encontrado!";
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro()
            {
                id = TBoxID.Text,
                titulo = TBoxTitulo.Text,
                autor = TBoxAutor.Text,
                ano = int.Parse(TBoxAno.Text),
                genero = TBoxGenero.Text,
                isbn = TBoxISBN.Text
            };

            if (lista.Any(a => a.id == livro.id))
            {
                lista.Find(a => a.id == livro.id).titulo = livro.titulo;
                lista.Find(a => a.id == livro.id).autor = livro.autor;
                lista.Find(a => a.id == livro.id).ano = livro.ano;
                lista.Find(a => a.id == livro.id).genero = livro.genero;
                lista.Find(a => a.id == livro.id).genero = livro.isbn;

                for (int v = 0; v < DGridList.Rows.Count; v++)
                {
                    if (string.Equals(DGridList[0, v].Value as string, livro.id))
                    {
                        DGridList.Rows[v].Cells["Título"].Value = livro.titulo;
                        DGridList.Rows[v].Cells["Autor"].Value = livro.autor;
                        DGridList.Rows[v].Cells["Ano"].Value = livro.ano;
                        DGridList.Rows[v].Cells["Gênero"].Value = livro.genero;
                        DGridList.Rows[v].Cells["ISBN"].Value = livro.isbn;
                        TBoxStatus.Text = "Cadastro atualizado com sucesso!";
                    }
                }
            }

            else
            {
                TBoxStatus.Text = "Erro! Livro não encontrado!";
            }

        }

    }
}
