using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Data;



namespace CalculadoraMatriz
{
    static class Matriz
    {
        /// <summary>
        /// Cria matriz de ordem escolhida pelo usuário
        /// </summary>
        /// <param name="linhas">Número de linhas da matriz que será criada</param>
        /// <param name="colunas">Número de colunas da matriz que será criada</param>
        /// <param name="painel">Painel em que a matriz será criada</param>
        
        public static void CriarMatriz(Panel painel, int linhas, int colunas)
        {
            painel.Controls.Clear();
            TextBox[,] Matriz = new TextBox[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Matriz[i, j] = new TextBox();
                    Matriz[i, j].Text = "0";
                    Matriz[i, j].Size = new Size(painel.Width / colunas, painel.Height / linhas);
                    Matriz[i, j].Location = new Point(j * Matriz[i, j].Width, i * Matriz[i, j].Height);
                    painel.Controls.Add(Matriz[i, j]);
                }
            }
        }
        /// <summary>
        /// Guarda a matriz de um painel em um array float[,]
        /// </summary>
        /// <param name="panel">Painel da matriz que será guardada</param>
        /// <param name="linhas">Número de linhas da matriz que será guardada</param>
        /// <param name="colunas">Número de colunas da matriz que será guardada</param>
        /// <returns>Retorna um float[,] com os numeros preenchidos nos numericUpDowns da matriz</returns>
        
        public static float[,] GuardarMatriz(Panel painel, int linhas, int colunas)
        {
            float[,] matrix = new float[linhas, colunas];
            int i = 0;
            int j = 0;

            foreach (TextBox M in painel.Controls)
            {
                matrix[i, j] = float.Parse(M.Text); 

                if (j == colunas - 1)
                {
                    j = 0;
                    i++;
                }
                else j++;
            }
            return matrix;
        }
        /// <summary>
        /// Desenha uma matriz em um painel
        /// </summary>
        /// <param name="Painel a ser desenhado">Painel onde a matriz será desenhada</param>
        /// <param name="matrix">Matriz a ser desenhada no painel</param>
        /// 
        public static float[,] SalvarMatriz(Panel panel, int lines, int col)
        {
            float[,] matrix = new float[lines, col];
            int i = 0;
            int j = 0;
            foreach (TextBox nu in panel.Controls)
            {
                matrix[i, j] = float.Parse(nu.Text);

                if (j == col - 1)
                {
                    j = 0;
                    i++;
                }
                else j++;
            }
            return matrix;
        }

        public static void DesenhaMatrixText(Panel painel, float[,] matrix)
        {
            painel.Controls.Clear();
            TextBox[,] M = new TextBox[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    M[i, j] = new TextBox();
                    M[i, j].Text = ((float)matrix[i, j]).ToString();
                    M[i, j].Size = new Size(painel.Width / 2, painel.Height / 2);
                    M[i, j].Location = new Point(j * M[i, j].Width, i * M[i, j].Height);
                    painel.Controls.Add(M[i, j]);
                }
            }
        }
       
        /// <summary>
        /// Somar Matrizes Feito
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        #region Somar Matrizes
        public static float[,] SomarMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            int linhas = matrix1.GetLength(0);
            int colunas = matrix1.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrixfinal[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrixfinal;
        }
        #endregion

        /// <summary>
        /// Subtrair Matrizes *Feito
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        #region Subtrair Matrizes
        public static float[,] SubtrairMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix1.GetLength(1)];
            int linhas = matrix1.GetLength(0);
            int colunas = matrix1.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrixfinal[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrixfinal;
        }
        #endregion

        /// <summary>
        /// Multiplicar Matrizes *Feito
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        #region Multiplicar Matrizes
        public static float[,] MultMatrizes(float[,] matrix1, float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new Multiplicação();
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int c = 0; c < matrix1.GetLength(1); c++)
                    {
                        matrixfinal[i, j] += matrix1[i, c] * matrix2[c, j];
                    }
                    if (Math.Round(matrixfinal[i, j]) == 1)
                        matrixfinal[i, j] = 1;
                    else if (Math.Round(matrixfinal[i, j]) == 0)
                    {
                        matrixfinal[i, j] = 0;
                    }
                    else matrixfinal[i, j] = matrixfinal[i, j];
                }
            }
            return matrixfinal;
        }
        #endregion

        #region MultiplicaçãoNormal
        public static float[,] MultiplicacaoNormal(float[,] matriz1, float M)
        {
            float[,] matrizResposta = new float[matriz1.GetLength(0), matriz1.GetLength(1)];
            for (int i = 0; i < matrizResposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResposta.GetLength(1); j++)
                {
                    matrizResposta[i, j] = matriz1[i, j] * M;
                }
            }
            return matrizResposta;
        }
#endregion


        /// <summary>
        /// Transpostas da Matriz A e B *Feito
        /// </summary>
        /// <param name="matrix1"></param>
        /// <returns></returns>
        #region TranspostaA
        public static float[,] TranspostaA(float[,] matrix1)
        {
            float[,] matrixfinal = new float[matrix1.GetLength(1), matrix1.GetLength(0)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrixfinal[j, i] = matrix1[i, j];
                }
            }
            return matrixfinal;
        }
        #endregion

        #region TranspostaB
        public static float[,] TranspostaB(float[,] matrix2)
        {
            float[,] matrixfinal = new float[matrix2.GetLength(1), matrix2.GetLength(0)];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrixfinal[j, i] = matrix2[i, j];
                }
            }
            return matrixfinal;
        }
        #endregion

       /* #region TranspostaResult
        public static float[,] TranspostaResult(float[,] MatrizResut)
        {
            float[,] matrixfinal = new float[MatrizResut.GetLength(1), MatrizResut.GetLength(0)];
            for (int i = 0; i < MatrizResut.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizResut.GetLength(1); j++)
                {
                    matrixfinal[j, i] = MatrizResut[i, j];
                }
            }
            return matrixfinal;
        }
        #endregion*/

        /// <summary>
        /// Oposta Pronta
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        #region OpostaA

        public static float[,] GerarOpostaA(float[,] matriz)
        {
            float[,] matrizOposta = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < matrizOposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizOposta.GetLength(1); y++)
                {
                    matrizOposta[x, y] += matriz[x, y] * -1;
                }
            }
            return matrizOposta;
        }

        #endregion

        #region OpostaB

        public static float[,] GerarOpostaB(float[,] matriz)
        {
            float[,] matrizOposta = new float[matriz.GetLength(0), matriz.GetLength(1)];
            for (int x = 0; x < matrizOposta.GetLength(0); x++)
            {
                for (int y = 0; y < matrizOposta.GetLength(1); y++)
                {
                    matrizOposta[x, y] += matriz[x, y] * -1;
                }
            }
            return matrizOposta;
        }

        #endregion


        /// <summary>
        /// Determinantes Feito
        /// </summary>
        /// <param name="Matriz1"></param>
        /// <returns></returns>
        #region Determinantes

        public static float Determinantes (float[,] Matriz1)
        {
            float num1;
            float num2;
            float Resp = 0;
            float a = 1;
            if (Matriz1.GetLength(0) == 1)
            {
                return Matriz1[0, 0];
            }
            else if (Matriz1.GetLength(0) == 2)
            {
                Console.WriteLine("2x2");
                num1 = (Matriz1[0, 0]) * (Matriz1[1, 1]);
                num2 = (Matriz1[0, 1]) * (Matriz1[1, 0]);
                Resp = num1 - num2;
            }
            else if (Matriz1.GetLength(0) == 3)
            {
                num1 = ((Matriz1[0, 0]) * (Matriz1[1, 1]) * (Matriz1[2, 2])) +
                       ((Matriz1[0, 1]) * (Matriz1[1, 2]) * (Matriz1[2, 0])) +
                       ((Matriz1[0, 2]) * (Matriz1[1, 0]) * (Matriz1[2, 1]));

                num2 = ((Matriz1[0, 1]) * (Matriz1[1, 0]) * (Matriz1[2, 2])) +
                       ((Matriz1[0, 0]) * (Matriz1[1, 2]) * (Matriz1[2, 1])) +
                       ((Matriz1[0, 2]) * (Matriz1[1, 1]) * (Matriz1[2, 0]));

                Resp = num1 - num2;

            }
            else
            {
                bool foi = false;
                for (int j = 0; j < Matriz1.GetLength(0); j++)
                {
                    if (Matriz1[j, 0] != 0)
                    {

                        if (j != 0)
                        {
                            a *= -1;
                            float[] temp = new float[Matriz1.GetLength(0)];
                            for (int i = 0; i < Matriz1.GetLength(0); i++)
                            {
                                temp[i] = Matriz1[j, i];
                                Matriz1[j, i] = Matriz1[0, i];
                                Matriz1[0, i] = temp[i];
                            }
                        }
                        j = Matriz1.GetLength(0);
                        foi = true;
                    }
                }
                if (foi)
                {
                    a /= (Matriz1[0, 0]);
                    float[,] M2 = new float[Matriz1.GetLength(0) - 1, Matriz1.GetLength(1) - 1];
                    for (int i = 0; i < Matriz1.GetLength(0); i++)
                    {
                        Matriz1[i, 0] *= a;
                    }
                    for (int i = 1; i < Matriz1.GetLength(0); i++)
                    {
                        for (int j = 1; j < Matriz1.GetLength(1); j++)
                        {
                            M2[i - 1, j - 1] = (Matriz1[i, j]) - (Matriz1[0, j]) * (Matriz1[i, 0]);
                            Console.WriteLine(Resp);
                        }
                    }
                    Resp = Determinantes (M2);
                }
                else
                    Resp = 0;
            }
            return Resp / a;
        }

        #endregion

        #region Cofator

        public static float Cofator(float[,] Matriz1, int linha, int coluna)
        {
            float[,] M2 = new float[Matriz1.GetLength(0) - 1, Matriz1.GetLength(1) - 1];
            int i2 = 0;
            int j2 = 0;
            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                if (i == linha) i++;
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    if (j == coluna) j++;
                    if (i < Matriz1.GetLength(0) && j < Matriz1.GetLength(1)) M2[i2, j2] = Matriz1[i, j];
                    j2++;
                }
                i2++;
                j2 = 0;
            }

            return (float)Math.Pow(-1, linha + coluna + 2) * Determinantes(M2);
        }
        #endregion

        #region Adjunta

        public static float[,] Adjunta(float[,] Matriz1)
        {
            float[,] resposta = new float[Matriz1.GetLength(0), Matriz1.GetLength(1)];
            for (int i = 0; i < Matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz1.GetLength(1); j++)
                {
                    resposta[i, j] = Cofator(Matriz1, i, j);
                }
            }

            return TranspostaA(resposta);
        }
        #endregion

        /// <summary>
        /// InversaA e B feito
        /// </summary>
        /// <param name="Matriz1"></param>
        /// <returns></returns>
        #region Inversa
        public static float [,] InversaA(float[,] Matriz1)
        {
            float[,] MatrizI = MultiplicacaoNormal(Adjunta(Matriz1), 1 / Determinantes(Matriz1));
            return MatrizI;
        }

        public static float[,] InversaB(float[,] Matriz2)
        {
            float[,] MatrizI = MultiplicacaoNormal(Adjunta(Matriz2), 1 / Determinantes(Matriz2));
            return MatrizI;
        }

        #endregion
    }
}
