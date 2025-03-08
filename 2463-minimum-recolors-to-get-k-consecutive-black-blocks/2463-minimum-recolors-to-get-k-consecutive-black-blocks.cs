public class Solution {
   
       
    private const char White = 'W';

    public int MinimumRecolors(string blocks, int k)
    {
        var minRecolorsCount = int.MaxValue;
        var currentCountOfWhiteBlocks = 0;

        for (var i = 0; i < k; i++)
        {
            if (blocks[i] is White)
            {
                currentCountOfWhiteBlocks++;
            }
        }

        minRecolorsCount = currentCountOfWhiteBlocks;

        for (var i = k; i < blocks.Length; i++)
        {
            if (blocks[i - k] is White)
            {
                currentCountOfWhiteBlocks--;
            }

            if(blocks[i] is White)
            {
                currentCountOfWhiteBlocks++;
            }

            minRecolorsCount = Math.Min(currentCountOfWhiteBlocks, minRecolorsCount);
        }

        return minRecolorsCount;
    }
}
    