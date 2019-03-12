using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolveSudoku
{
    public partial class FormResolve : Form
    {   // Para inserir o sudoku, só mudar os números abaixo conforme o desejado.
        // aqui é uma variavel global para pegar os dados dela depois, que fica mais facil.
        int[,] Sudoku = new int[9, 9] {
        { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
        { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
        { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
        { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
        { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
        { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
        { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
        { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
        { 0, 0, 0, 0, 8, 0, 0, 7, 9 } };

        public FormResolve()
        {    //Só pra mostrar no datagrid
            InitializeComponent();
            DgvSukodu.RowCount = 9;
            DgvSukodu.ColumnCount = 9;
            DgvSukodu.Columns[2].DividerWidth = 3; // para deixar igual um sudoku
            DgvSukodu.Columns[5].DividerWidth = 3;
            DgvSukodu.Rows[2].DividerHeight = 3;
            DgvSukodu.Rows[5].DividerHeight = 3;
            for (int k = 0; k < 9; k++)
            {
                DataGridViewColumn column = DgvSukodu.Columns[k];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            for (int linha = 0; linha < 9; linha++)// Mostra o sudoku no datagrid.
            {
                for (int coluna = 0; coluna < 9; coluna++)
                {
                    DgvSukodu.Rows[linha].Cells[coluna].Value = Sudoku[linha, coluna];
                }
            }
        }
        private void BtnResolve_Click(object sender, EventArgs e)
        {   // aqui é so chamar as funçôes 
            PreencheSudoku(0, 0);
            ApresentaGrade();          
        }
        int EstaDisponivel(int linha, int coluna, int digito)
        {
            int inicioLinha = (linha / 3) * 3,
            inicioColuna = (coluna / 3) * 3,
            i;
            for (i = 0; i < 9; ++i)
            {

                if (Sudoku[linha, i] == digito) /* Verifica se o dígito já ocorre em alguma linha */
                    return 0; /* Dígito já aparece na linha */

                if (Sudoku[i, coluna] == digito)/* Verifica se o dígito já ocorre em alguma coluna */
                    return 0; /* Dígito já aparece na coluna */

                if (Sudoku[inicioLinha + (i % 3), inicioColuna + (i / 3)] == digito)/* Verifica se o dígito já ocorre em alguma subgrade */
                    return 0; /* Dígito já aparece em subgrade */
            }
            /* O dígito está disponível */
            return 1;
        }
        int PreencheSudoku(/*int[,] Sudoku,*/ int linha, int coluna)
        {
            if (linha < 9 && coluna < 9)// Ponto de parada, se ele não entrar aqui me retorna 1 e para.
            {
                if (Sudoku[linha, coluna] != 0)
                {
                    if (linha + 1 < 9)
                        return PreencheSudoku(linha + 1, coluna);
                    else if (coluna + 1 < 9)
                        return PreencheSudoku(0, coluna + 1);
                    else
                        return 1;
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (EstaDisponivel(linha, coluna, i + 1) == 1)
                        {   /* Se ele entrar neste if significa que o número pode ser inserido na matriz */
                            Sudoku[linha, coluna] = i + 1;
                            //Mostra os números sendo inseridos 
                            Thread MostraNumeros1 = new Thread(ApresentaGrade);
                            MostraNumeros1.Start();
                            MostraNumeros1.Join();
                            Thread.Sleep(70);
                           
                            if (linha + 1 < 9)
                            {   /* Se a linha for de 0 a 8 ele irá tentar a resolução na próxima linha */
                                if (PreencheSudoku(linha + 1, coluna) == 1)
                                    return 1;
                                else
                                {   // Caso a resolução do if não dê certo significa que ele precisa pegar o próximo então ele irá zerar a variavel
                                    Sudoku[linha, coluna] = 0;
                                    //Mostra os  0 sendo inseridos.
                                    Thread MostraNumeros2 = new Thread(ApresentaGrade);
                                    MostraNumeros2.Start();
                                    MostraNumeros2.Join();
                                    Thread.Sleep(70);
                                }
                            }
                            else if (coluna + 1 < 9)
                            {
                                if (PreencheSudoku(0, coluna + 1) == 1)
                                    return 1;
                                else
                                { // Caso a resolução do if não dê certo significa que ele precisa pegar o próximo então ele irá zerar a variavel
                                    Sudoku[linha, coluna] = 0;  // Passa linha como 0 para voltar do inicio a próxima coluna 
                                    //Mostra os  0 sendo inseridos.
                                    Thread MostraNumeros3 = new Thread(ApresentaGrade);
                                    MostraNumeros3.Start();
                                    MostraNumeros3.Join();
                                    Thread.Sleep(70);
                                }
                            }
                            else
                                return 1;
                        }
                    }
                }
                return 0;
            }
            else
                return 1;
        }
        void ApresentaGrade()
        {
            int linhas, colunas;
            DgvSukodu.RowCount = 9;
            DgvSukodu.ColumnCount = 9;
            for (linhas = 0; linhas < 9; linhas++)
            {
                for (colunas = 0; colunas < 9; colunas++)
                    DgvSukodu.Rows[linhas].Cells[colunas].Value = Sudoku[linhas, colunas];
            }
        }
        private void DgvSukodu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
        }
    }
}