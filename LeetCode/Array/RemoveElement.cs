namespace LeetCode.Array
{
    /// <summary>
    /// Given an array and a value, remove all instances of that>value in place and return the new length.
    /// The order of elements can be changed.It doesn't matter what you leave beyond the new length
    /// </summary>
    public class RemoveElement
    {
        public int RemoveElements(int[] array, int index, int element)
        {
            var j = 0;

            for (var i = 0; i < index; i++)
            {
                if (array[i] == element)
                {
                    continue;
                }

                array[j] = array[i];
                j++;
            }

            return j;
        }
    }
}
