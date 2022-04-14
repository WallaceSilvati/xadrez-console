namespace tabuleiro
{
     class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] TabPeca;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            TabPeca = new Peca[linhas, colunas];
        }

        public Peca Pecas(int linha, int coluna)
        {
            return TabPeca[linha, coluna];
        }
    }
}
