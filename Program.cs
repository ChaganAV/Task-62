int N = 4;
//string[,] matrix = new string[N,N]; // массив
int[,] mas = new int[N,N];
//
//FillEmptyArray(matrix);
//FillArray();
//Print2DArray(matrix);
SpiralPath();
Print2DArray(mas);

// Функции
void SpiralPath()
{
    int x = 0;
    int y = 0;
    int sx = 1; // смещение x
    int sy = 0; // смещение y
    int countNum = 1;
    mas[y,x] = countNum;
    bool stop;
    int countCicle = 0;
    do 
    {
        stop = false;
        while(InRange(x+sx, y+sy, countNum ))
        {
            x+=sx;
            y+=sy;
            countNum++;
            mas[y,x] = countNum;
            //Console.WriteLine($"mas[{y},{x}]={countNum}");
            stop = true;
        }
        int sx_old = sx;
        sx = -sy;
        sy = sx_old;
        countCicle++;
    }while(stop);
    
}
bool InRange(int col, int row, int count)
{
    if(col < 0 || col >= N)
        return false;
    if(row < 0 || row >= N)
        return false;
    if(mas[row,col]>0)
        return false;
    return true;
}
// void FillArray()
// {
//     int count = 1; 
//     for(int step = 0; step < 1; step++)
//     {
//         // columns
//         for(int i = 0; i< matrix.GetLength(1); i++)
//         {
//             matrix[0,i] = $"0{count++}"; 
//         }
//         // rows
//         for(int i = 1; i< matrix.GetLength(0); i++)
//         {
//             matrix[i,matrix.GetLength(1)-1] = $"0{count++}"; 
//         }
//         // columns
//         for(int i = matrix.GetLength(1)-2; i > 0; i--)
//         {
//             matrix[matrix.GetLength(0)-1,i] = $"0{count++}"; 
//         }
//         // rows
//         for(int i = matrix.GetLength(0)-1; i > 0; i--)
//         {
//             matrix[i,0] = $"0{count++}"; 
//         }  
        
//         ////// repeat  /////
//         // columns
//         for(int i = 1; i< matrix.GetLength(1)-1; i++)
//         {
//             matrix[1,i] = $"0{count++}"; 
//         }
//         // columns
//         for(int i = matrix.GetLength(1)-2; i > 0; i--)
//         {
//             matrix[matrix.GetLength(0)-1-1,i] = $"0{count++}"; 
//         }
//     }
// }

// void FillEmptyArray(string[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {            
//             array[i,j] = String.Empty;
//         }
//     }
// }

// void Print2DArray(string[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {            
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}