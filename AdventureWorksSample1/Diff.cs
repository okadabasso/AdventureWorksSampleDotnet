using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffSample
{
    /// <summary>
    /// implementation with O(NP) algorithm from S. Wu, U. Manber, G. Myers and W. Miller, "An O(NP) Sequence Comparison Algorithm", August 1989
    /// (https://publications.mpi-cbg.de/Wu_1990_6334.pdf)
    /// </summary>
    public class Diff<TElement>
    {
        private TElement[] A;
        private TElement[] B;

        private int M;
        private int N;
        private bool swapped;

        private CommonSubsequence[] commonSubsequenceChains;
        private int[] fp;
        public Diff()
        {

        }
        public IEnumerable<Difference> Calculate(IEnumerable<TElement> a, IEnumerable<TElement> b)
        {
            this.A = a.ToArray();
            this.B = b.ToArray();
            M = A.Length;
            N = B.Length;
            if (M < N)
            {
            }
            else
            {
                var temp = this.A;
                this.A = this.B;
                this.B = temp;
                Swap(ref M, ref N);
                swapped = true;
            }

            var distance = EditDistance();
            var result = CreateDifference();
            return result;
        }
        private int EditDistance()
        {
            int offset = M + 1;
            int delta = N - M;
            int size = M + N + 3;

            fp = new int[size];
            for (int i = 0; i < size; ++i) fp[i] = -1;

            commonSubsequenceChains = new CommonSubsequence[size];

            int p = -1;
            do
            {
                ++p;
                for (int k = -p; k <= delta - 1; ++k)
                {
                    fp[k + offset] = Snake(k, Math.Max(fp[k - 1 + offset] + 1, fp[k + 1 + offset]));
                }
                for (int k = delta + p; k >= delta + 1; --k)
                {
                    fp[k + offset] = Snake(k, Math.Max(fp[k - 1 + offset] + 1, fp[k + 1 + offset]));
                }
                fp[delta + offset] = Snake(delta, Math.Max(fp[delta - 1 + offset] + 1, fp[delta + 1 + offset]));
            } while (fp[delta + offset] != N);


            return delta + 2 * p;
        }
        private int Snake(int k, int y)
        {

            int x = y - k;
            int startX = x;
            int startY = y;
            while (x < M && y < N && A[x].Equals(B[y]))
            {
                ++x;
                ++y;
            }
            AddCommonSubsequenceChain(k, startX, startY, x - startX);
            return y;
        }
        void AddCommonSubsequenceChain(int k, int x, int y, int length)
        {
            int kk = M + 1 + k;

            int lk = kk - 1;
            int rk = kk + 1;
            int lb = fp[lk];
            int rb = fp[rk];
            CommonSubsequence previousSubsequence = null;
            if (lb >= rb)
            {
                previousSubsequence = commonSubsequenceChains[lk];
            }
            else
            {
                previousSubsequence = commonSubsequenceChains[rk];
            }
            if (length > 0)
            {
                commonSubsequenceChains[kk] = new CommonSubsequence()
                {
                    X = x,
                    Y = y,
                    Length = length,
                    Next = previousSubsequence

                };
            }
            else
            {
                commonSubsequenceChains[kk] = previousSubsequence;
            }

        }
        List<Difference> CreateDifference()
        {
            var reversed = CommonSubsequence.Reverse(new CommonSubsequence()
            {
                X = M,
                Y = N,
                Length = 0,
                Next = commonSubsequenceChains[N + 1]
            });

            List<Difference> list = new List<Difference>();
            int originalStart = 0;
            int modifiedStart = 0;

            var subsequence = reversed;
            while (true)
            {
                int x = swapped ? subsequence.Y : subsequence.X;
                int y = swapped ? subsequence.X : subsequence.Y;
                if (originalStart < x || modifiedStart < y)
                {
                    list.Add(new Difference(
                        true,
                        originalStart, x - originalStart,
                        modifiedStart, y - modifiedStart));
                }

                // 末尾検出
                if (subsequence.Length == 0) break;

                originalStart = x;
                modifiedStart = y;

                list.Add(new Difference(
                    false,
                    originalStart, subsequence.Length,
                    modifiedStart, subsequence.Length));

                originalStart += subsequence.Length;
                modifiedStart += subsequence.Length;

                subsequence = subsequence.Next;
            }
            return list;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            var t = a;
            a = b;
            b = t;
        }

    }


    public class CommonSubsequence
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Length { get; set; }
        public CommonSubsequence Next { get; set; }

        public static CommonSubsequence Reverse(CommonSubsequence bottom)
        {
            CommonSubsequence top = null;
            while (bottom != null)
            {
                CommonSubsequence next = bottom.Next;
                bottom.Next = top;
                top = bottom;
                bottom = next;
            }
            return top;

        }
    }

}
