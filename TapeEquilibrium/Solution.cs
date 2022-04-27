using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibrium
{
	public class Solution
	{
		private int calculePlace(int[] A, int index) {
			int firstSum = 0;
			int secondSum = 0;
			
			if (index == 0)
				firstSum = A[index];
			else 
				for (int i = index; i >= 0; i--)
					firstSum += A[i];
			
			for (int i = index + 1; i < A.Length; i++)
				secondSum += A[i];

			int result = firstSum - secondSum;
			
			if(result < 0)
				result *= -1;

			return result;
		}

		public int solution(int[] A) {
			int[] B = new int[A.Length-1];

			for (int i=0; i < A.Length-1; i++) 
				B[i] = calculePlace(A, i);
			
			return B.Min();
		}
	}
}
