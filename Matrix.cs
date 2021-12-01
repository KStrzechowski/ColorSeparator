using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSeparator
{
    public static class Matrix
    {
        static double[,] MatrixCreate(int rows, int cols)
        {
            double[,] result = new double[rows, cols];
            return result;
        }

        public static double[,] MatrixInverse(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] result = MatrixDuplicate(matrix);

            int[] perm;
            double[,] lum = MatrixDecompose(matrix, out perm, out _);
            if (lum == null)
                throw new Exception("Unable to compute inverse");

            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }

                double[] x = HelperSolve(lum, b);

                for (int j = 0; j < n; ++j)
                    result[j, i] = x[j];
            }
            return result;
        }

        static double[,] MatrixDuplicate(double[,] matrix)
        {
            double[,] result = MatrixCreate(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < matrix.GetLength(0); ++i) // copy the values
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    result[i, j] = matrix[i, j];
            return result;
        }

        static double[] HelperSolve(double[,] luMatrix, double[] b)
        {
            // before calling this helper, permute b using the perm array
            // from MatrixDecompose that generated luMatrix
            int n = luMatrix.GetLength(0);
            double[] x = new double[n];
            b.CopyTo(x, 0);

            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix[i, j] * x[j];
                x[i] = sum;
            }

            x[n - 1] /= luMatrix[n - 1, n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix[i, j] * x[j];
                x[i] = sum / luMatrix[i, i];
            }

            return x;
        }

        static double[,] MatrixDecompose(double[,] matrix, out int[] perm, out int toggle)
        {
            // Doolittle LUP decomposition with partial pivoting.
            // rerturns: result is L (with 1s on diagonal) and U;
            // perm holds row permutations; toggle is +1 or -1 (even or odd)
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1); // assume square
            if (rows != cols)
                throw new Exception("Attempt to decompose a non-square m");

            int n = rows; // convenience

            double[,] result = MatrixDuplicate(matrix);

            perm = new int[n]; // set up row permutation result
            for (int i = 0; i < n; ++i) { perm[i] = i; }

            toggle = 1; // toggle tracks row swaps.
                        // +1 -greater-than even, -1 -greater-than odd. used by MatrixDeterminant

            for (int j = 0; j < n - 1; ++j) // each column
            {
                double colMax = Math.Abs(result[j, j]); // find largest val in col
                int pRow = j;
                //for (int i = j + 1; i less-than n; ++i)
                //{
                //  if (result[i, j] greater-than colMax)
                //  {
                //    colMax = result[i, j];
                //    pRow = i;
                //  }
                //}

                // reader Matt V needed this:
                for (int i = j + 1; i < n; ++i)
                {
                    if (Math.Abs(result[i, j]) > colMax)
                    {
                        colMax = Math.Abs(result[i, j]);
                        pRow = i;
                    }
                }
                // Not sure if this approach is needed always, or not.

                if (pRow != j) // if largest value not on pivot, swap rows
                {
               double[] rowPtr = Enumerable.Range(0, result.GetLength(1))
                                           .Select(x => result[pRow, x])
                                           .ToArray();
                    for (int i = 0; i < result.GetLength(1); i++)
                    {
                        result[pRow, i] = result[j, i];
                        result[j, i] = rowPtr[i];
                    }

                    int tmp = perm[pRow]; // and swap perm info
                    perm[pRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle; // adjust the row-swap toggle
                }

                // --------------------------------------------------
                // This part added later (not in original)
                // and replaces the 'return null' below.
                // if there is a 0 on the diagonal, find a good row
                // from i = j+1 down that doesn't have
                // a 0 in column j, and swap that good row with row j
                // --------------------------------------------------

                if (result[j, j] == 0.0)
                {
                    // find a good row to swap
                    int goodRow = -1;
                    for (int row = j + 1; row < n; ++row)
                    {
                        if (result[row, j] != 0.0)
                            goodRow = row;
                    }

                    if (goodRow == -1)
                        throw new Exception("Cannot use Doolittle's method");

                    // swap rows so 0.0 no longer on diagonal
                    double[] rowPtr = Enumerable.Range(0, result.GetLength(1))
                                                .Select(x => result[goodRow, x])
                                                .ToArray();
                    for (int i = 0; i < result.GetLength(1); i++)
                    {
                        result[goodRow, i] = result[j, i];
                        result[j, i] = rowPtr[i];
                    }

                    int tmp = perm[goodRow]; // and swap perm info
                    perm[goodRow] = perm[j];
                    perm[j] = tmp;

                    toggle = -toggle; // adjust the row-swap toggle
                }
                // --------------------------------------------------
                // if diagonal after swap is zero . .
                //if (Math.Abs(result[j, j]) less-than 1.0E-20) 
                //  return null; // consider a throw

                for (int i = j + 1; i < n; ++i)
                {
                    result[i, j] /= result[j, j];
                    for (int k = j + 1; k < n; ++k)
                    {
                        result[i, k] -= result[i, j] * result[j, k];
                    }
                }


            } // main j column loop

            return result;
        }
    }
}
