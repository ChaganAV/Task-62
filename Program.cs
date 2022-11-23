int N = 4;
string[,] matrix = new string[N,N]; // массив
int[,] mas = new int[N,N];
int[] coord = {0,0};
//
//FillEmptyArray(matrix);
//FillArray();
//Print2DArray(matrix);
SpiralPath();
Print2DArray2(mas);

// Console.WriteLine();

// Функции
void SpiralPath()
{
    int x = 0;
    int y = 0;
    int sx = 1; // смещение x
    int sy = 0; // смещение y
    Console.WriteLine($"mas[{y},{x}]");
    int countNum = 1;
    bool stop;
    do 
    {
        stop = false;
        while(InRange(x+sx, y+sy, countNum ))
        {
            mas[y,x] = countNum;
            Console.WriteLine($"mas[{y},{x}]={countNum}");
            x+=sx;
            y+=sy;
            countNum++;
            stop = true;
        }
        int sx_old = sx;
        sx = -sy;
        sy = sx_old;
        //Console.WriteLine($"countNum={countNum}");
    }while(stop);
    
}
bool InRange(int x, int y, int count)
{
    if(x < 0 || x >= N)
        return false;
    if(y < 0 || y >= N)
        return false;
    if(count > 16)
        return false;
    if(mas[y,x]>0)
        return false;
    return true;
}
void FillArray()
{
    int count = 1; 
    for(int step = 0; step < 1; step++)
    {
        // columns
        for(int i = 0; i< matrix.GetLength(1); i++)
        {
            matrix[0,i] = $"0{count++}"; 
        }
        // rows
        for(int i = 1; i< matrix.GetLength(0); i++)
        {
            matrix[i,matrix.GetLength(1)-1] = $"0{count++}"; 
        }
        // columns
        for(int i = matrix.GetLength(1)-2; i > 0; i--)
        {
            matrix[matrix.GetLength(0)-1,i] = $"0{count++}"; 
        }
        // rows
        for(int i = matrix.GetLength(0)-1; i > 0; i--)
        {
            matrix[i,0] = $"0{count++}"; 
        }  
        
        ////// repeat  /////
        // columns
        for(int i = 1; i< matrix.GetLength(1)-1; i++)
        {
            matrix[1,i] = $"0{count++}"; 
        }
        // columns
        for(int i = matrix.GetLength(1)-2; i > 0; i--)
        {
            matrix[matrix.GetLength(0)-1-1,i] = $"0{count++}"; 
        }
    }
}

void FillEmptyArray(string[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            array[i,j] = String.Empty;
        }
    }
}

void Print2DArray(string[,] array)
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
void Print2DArray2(int[,] array)
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