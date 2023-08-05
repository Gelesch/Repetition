public class Programm
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        bool isTrue = false;
        
        
        int [,] array=new int[n,m];
        
        
        //filling in the array
        
        for (var row = 0; row < array.GetLength(0); row++)
        {
            for (var colum = 0; colum < array.GetLength(1); colum++)
            {
                array[row, colum] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int theFirstElement = array[0, 0];
        
        //cheking the array
        
        for (var row = 0; row < array.GetLength(0); row++)
        {
            for (var colum = 0; colum < array.GetLength(1); colum++)
            {
                if (array[row,colum]==array[0,0])
                {
                    isTrue = true; 
                    
                }
                else
                {
                    isTrue = false;
                    break;
                }
                if (array[row,colum]==3)
                {
                    isTrue = false;
                    break;
                }
               

                
            }

            if (isTrue ==false)
            {
                break;
            }


        }
        
        //print array
        if (isTrue==true)
        {
            
                    Console.WriteLine("Да вы медвежатник,шеф!");
                
            
        }
        else
        {

            Console.WriteLine("М-да, друг, взломщик из тебя так себе, попробуй еще раз!");
            
        }
       
    }
     
    
}