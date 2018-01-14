namespace LeetCode.Array
{
    public class RemoveDuplicate
    {
        /// <summary>
        /// Given a	sorted array, remove the duplicates	in place such that	
        /// appear only once and return the new length
        /// Do not allocate extra space for another array, you must do this in place with constant memory
        /// For	example, Given input array A = [1,1,2], Your function should return	length = 2,and A is now	[1,2]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] array, int value)
        {
            if (value == 0) return 0;

            var j = 0;

            for(var i = 1; i < array.Length; i++)
            {
                if (array[j] != array[i])
                {
                    array[++j] = array[i];
                }
            }

            return j;
        }

        /// <summary>
        /// Follow up for "Remove Duplicates": What	if duplicates are allowed at most twice?
        /// For	example, Given sorted array	A =	[1,1,1,2,2,3],Your function	should return length = 5, and A	is now [1,1,2,2,3].
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int RemoveDuplicatesForTwice(int[] array, int value)
        {
            if (value == 0) return 0;

            var j = 0;
            var duplicateTimes = 0;

            for (var i = 1; i < array.Length; i++)
            {
                if (array[j] == array[i])
                {
                    duplicateTimes++;
                    if (duplicateTimes < 2)
                    {
                        array[++j] = array[i];
                    }
                }
                else
                {
                    array[++j] = array[i];
                    duplicateTimes = 0;
                }
            }
            return j;
        }
    }
}
