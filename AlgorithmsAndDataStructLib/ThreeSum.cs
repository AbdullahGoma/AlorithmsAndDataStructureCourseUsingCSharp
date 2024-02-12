namespace AlgorithmsAndDataStructLib
{
	public class ThreeSum
	{
		public static int Count(int[] a)
		{
			int n = a.Length;
			int counter = 0;
			
			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					for (int k = j + 1; k < n; k++)
					{
						if (a[i] + a[j] + a[k] == 0)
							counter++;
					}
				}
			}
			return counter;
		}
		
		public static int CountBetter(int[] a)
		{
			Array.Sort(a); 
			int n = a.Length;
			int counter = 0;

			for (int i = 0; i < n - 2; i++) 
			{
				int left = i + 1; 
				int right = n - 1;

				while (left < right) 
				{
					int sum = a[i] + a[left] + a[right]; 

					if (sum == 0)
					{
						counter++; 
						left++;
						right--;
					}
					else if (sum < 0) 
					{
						left++;
					}
					else 
					{
						right--;
					}
				}
			}

			return counter;
		}
	}
}