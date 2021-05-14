using System;
namespace LuigiChallenge
{
    public class Luigi
    {
        public Luigi()
        {
        }


//Guide Luigi home by following the trail of "0"s from left to right and top to bottom in the 2D matrix.

//Give him directions with two commands:

//"Down" or "Right";

//Example:
//input:

//        [4,0,4]
//        [5,0,0]
//        [6,9,0]
//        [8,3,0]

//        output:

//String "Down Right Down Down"

//(Note: In all the tests Luigi will have clear path.So there will only be a "0" below or to the right of each other.No isolated "0"s or "0"s moving back left.)


        public string GoHome2D(int[][] map)
        {
            string result = "";

            for (int i = 0; i < map.Length; i++)
            {
                for (int x = 0; x < map[i].Length; x++)
                {

                    if (map[i][x] == 0)
                    {

                        if (x < map[i].Length - 1) 
                        {
                            if (map[i][x + 1] == 0)
                            {
                                result += "Right ";
                            }
                        }

                        if (i < map.Length - 1)
                        {
                            if (map[i + 1][x] == 0)
                            {
                                result += "Down ";
                            }
                        }
                    }
                }
            }

            return result.Trim(' ');
        }
    }
}
