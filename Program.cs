
int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 1,2,3 };
jaggedArray[1] = new int[] { 1,2,2};

jaggedArray = JagArray.AddElement(jaggedArray,1, 7);



for(var i=0;i<jaggedArray.Length;i++)
{
    for(var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
public class JagArray
{
    

    public static int[][] AddElement(int[][] array,int index, int element)
    {
        List<int> ArrayTolist = array[index].ToList<int>();
        var d = ArrayTolist.Append(element);
        array[index] = d.ToArray();
        return array;
    }
   
}
