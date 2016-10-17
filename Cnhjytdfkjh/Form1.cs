using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMatriz
{
    public partial class Form1 : Form
    {
        static int LMatriz1, CMatriz1, LMatriz2, CMatriz2;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValorX_ValueChanged(object sender, EventArgs e)
        {

        }
        #region  Criar MatrizA

        private void CriarMatrizA_Click(object sender, EventArgs e)
        {
            LMatriz1 = (int)LinhaA.Value;
            CMatriz1 = (int)ColunaA.Value;
            Matriz.CriarMatriz(Matriz1, LMatriz1, CMatriz1);
        }
        #endregion

        #region Criar MAtrizB
        private void CriarMatrizB_Click(object sender, EventArgs e)
        {
            LMatriz2 = (int)LinhaB.Value;
            CMatriz2 = (int)ColunaB.Value;
            Matriz.CriarMatriz(Matriz2, LMatriz2, CMatriz2);
        }
        #endregion

        private void Matriz1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupMatriz1_Enter(object sender, EventArgs e)
        {

        }
        private void ButtonMultiplicar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Somar Matrizes *Feito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BTSomar
        private void Soma_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LMatriz1, CMatriz1];
            float[,] matriz2 = new float[LMatriz2, CMatriz2];
            float[,] Resultado = new float[LMatriz2, CMatriz2];
            matriz1 = Matriz.GuardarMatriz(Matriz1, LMatriz1, CMatriz1);
            matriz2 = Matriz.GuardarMatriz(Matriz2, LMatriz2, CMatriz2);
            Resultado = Matriz.SomarMatrizes(matriz1, matriz2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    Resultado = Matriz.SomarMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(MatrizResut, Resultado);
                }
                catch
                {
                    MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        /// <summary>
        /// Subtrair Matrizes *Feito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BTSubtrair

        private void Sub_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LMatriz1, CMatriz1];
            float[,] matriz2 = new float[LMatriz2, CMatriz2];
            float[,] Resultado = new float[LMatriz2, CMatriz2];
            matriz1 = Matriz.GuardarMatriz(Matriz1, LMatriz1, CMatriz1);
            matriz2 = Matriz.GuardarMatriz(Matriz2, LMatriz2, CMatriz2);
            Resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);

            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    Resultado = Matriz.SubtrairMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(MatrizResut, Resultado);
                }
                catch
                {
                    MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de linhas e colunas das matrizes não são iguais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        /// <summary>
        /// Inversa *Fazendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region InversaA e B
        private void InversaA_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LMatriz1, CMatriz1];
            float[,] resultado = new float[CMatriz1, LMatriz1];
            matriz1 = Matriz.SalvarMatriz(Matriz1, LMatriz1, CMatriz1);
            resultado = Matriz.InversaA(matriz1);
            Matriz.DesenhaMatrixText(Matriz1, resultado);
            LMatriz1 = resultado.GetLength(0);
            CMatriz1 = resultado.GetLength(1);
        }

        private void InversaB_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[LMatriz2, CMatriz2];
            float[,] resultado = new float[CMatriz2, LMatriz2];
            matriz2 = Matriz.SalvarMatriz(Matriz2, LMatriz2, CMatriz2);
            resultado = Matriz.InversaB(matriz2);
            Matriz.DesenhaMatrixText(Matriz2, resultado);
            LMatriz2 = resultado.GetLength(0);
            CMatriz2 = resultado.GetLength(1);
        }
#endregion
 

        /// <summary>
        /// Determinantes A e B feito
        /// </summary>
        /// <param name="Matriz_x"></param>
        /// <returns></returns>
        #region Determinante
        private void DeterminanteA_Click(object sender, EventArgs e)
        {
          float[,] matriz1 = Matriz.SalvarMatriz(Matriz1, LMatriz1, CMatriz1);
          float resultado = Matriz.Determinantes(matriz1);
          MessageBox.Show("A determinante é " + resultado, "Determinante", MessageBoxButtons.OK);
        }

        private void DeterminanteB_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = Matriz.SalvarMatriz(Matriz2, LMatriz2, CMatriz2);
            float resultado = Matriz.Determinantes(matriz2);
            MessageBox.Show("A determinante é " + resultado, "Determinante", MessageBoxButtons.OK);
        }

        #endregion

        /// <summary>
        /// Transposta MatrizB *Feito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region TranspostaB
        private void TranspostaB_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[LMatriz2, CMatriz2];
            float[,] resultado = new float[CMatriz2, LMatriz2];
            matriz2 = Matriz.SalvarMatriz(Matriz2, LMatriz2, CMatriz2);
            resultado = Matriz.TranspostaB(matriz2);
            Matriz.DesenhaMatrixText(Matriz2, resultado);
            LMatriz2 = resultado.GetLength(0);
            CMatriz2 = resultado.GetLength(1);
        }
        #endregion

        /// <summary>
        ///  Transposta do Resultado *Quase Pronto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Multiplicar Matrizes Feito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BTMultiplicar
        private void Mult_Click(object sender, EventArgs e)
        {

            float[,] matriz1 = new float[LMatriz1, CMatriz1];
            float[,] matriz2 = new float[LMatriz2, CMatriz2];
            float[,] Resultado = new float[LMatriz2, CMatriz2];
            matriz1 = Matriz.GuardarMatriz(Matriz1, LMatriz1, CMatriz1);
            matriz2 = Matriz.GuardarMatriz(Matriz2, LMatriz2, CMatriz2);
            Resultado = Matriz.MultMatrizes(matriz1, matriz2);
            if (matriz1.GetLength(0) == matriz2.GetLength(0) && matriz1.GetLength(1) == matriz2.GetLength(1))
            {
                try
                {
                    Resultado = Matriz.MultMatrizes(matriz1, matriz2);
                    Matriz.DesenhaMatrixText(MatrizResut, Resultado);
                }
                catch
                {
                    MessageBox.Show("O número de colunas da primeira matriz e o número de linhas da segunda matriz são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("O número de colunas da primeira matriz e o número de linhas da segunda matriz são diferentes", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        /// <summary>
        /// Transposta MatrizA *Feito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BTTransposta

        private void TranspostaA_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LMatriz1, CMatriz1];
            float[,] resultado = new float[CMatriz1, LMatriz1];
            matriz1 = Matriz.SalvarMatriz(Matriz1, LMatriz1, CMatriz1);
            resultado = Matriz.TranspostaA(matriz1);
            Matriz.DesenhaMatrixText(Matriz1, resultado);
            LMatriz1 = resultado.GetLength(0);
            CMatriz1 = resultado.GetLength(1);
        }
        #endregion


        /// <summary>
        /// MAtriz Oposta A e B Pronto
        /// </summary>
        /// <param name="Matriz_x"></param>
        #region BTOposta

        private void OpostaA_Click(object sender, EventArgs e)
        {
            float[,] matriz1 = new float[LMatriz1, CMatriz1];
            float[,] resultado = new float[CMatriz1, LMatriz1];
            matriz1 = Matriz.SalvarMatriz(Matriz1, LMatriz1, CMatriz1);
            resultado = Matriz.GerarOpostaA(matriz1);
            Matriz.DesenhaMatrixText(Matriz1, resultado);
            LMatriz1 = resultado.GetLength(0);
            CMatriz1 = resultado.GetLength(1);
        }
        #endregion

        #region OpostaB
        private void OpostaB_Click(object sender, EventArgs e)
        {
            float[,] matriz2 = new float[LMatriz2, CMatriz2];
            float[,] resultado = new float[CMatriz2, LMatriz2];
            matriz2 = Matriz.SalvarMatriz(Matriz2, LMatriz2, CMatriz2);
            resultado = Matriz.GerarOpostaA(matriz2);
            Matriz.DesenhaMatrixText(Matriz2, resultado);
            LMatriz2 = resultado.GetLength(0);
            CMatriz2 = resultado.GetLength(1);
        }
        #endregion

        #region Limpar Matrizes
        private void LimparA_Click(object sender, EventArgs e)
        {
            Matriz1.Controls.Clear();
        }

        private void LimparB_Click(object sender, EventArgs e)
        {
            Matriz2.Controls.Clear();
        }

        private void LimparR_Click(object sender, EventArgs e)
        {
            MatrizResut.Controls.Clear();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

           
            }

        }

      

    }
