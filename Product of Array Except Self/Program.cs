namespace Product_of_Array_Except_Self
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { -1, 1, 0, -3, 3 };
            var result = ProductExceptSelf(nums);
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(result[i]);
                if (i < result.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            //Length of array
            int n = nums.Length;
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];


            //حساب الاتجاه الايسر
            leftProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }

            //حساب الاتجاه الايمن
            rightProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
            }
            //حساب الناتج النهائي 
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            // Console.WriteLine($"result: {result}");
            return result;


        }
    }
}
