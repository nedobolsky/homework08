//Задача №54

Console.Clear();
int UserMatrixSize(string text)
{
    Console.Write($"Введите число {text}: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int column = UserMatrixSize("столбцов");
int row = UserMatrixSize("строк");

Console.WriteLine();

int[,] matrix = new int[column, row];

int[,] RndMatrix(int[,] mtrx){
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = new Random().Next(10);
        }
    }
    return mtrx;
}
matrix = RndMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int[,] SortColumnsMatrix(int[,] mtrx)
{
    for (int k = 0; k < mtrx.GetLength(0); k++)
    {
        int temp;
        for (int j = mtrx.GetLength(1) - 1; j > 0; j--)
        {
            for (int i = 0; i < j; i++)
            {
                if (matrix[k,i] > matrix[k, i + 1])
                {
                    temp = matrix[k,i];
                    matrix[k,i] = matrix[k,i + 1];
                    matrix[k,i + 1] = temp;
                }
            }
        }
    }
    return mtrx;
}
int[,] matrixNew = SortColumnsMatrix(matrix);

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i, j] < 10)
            {
                Console.Write($"{"0" + Convert.ToString(mtrx[i, j])} ");
            }
            else
            {
                Console.Write($"{mtrx[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrixNew);

// Задача №56

Console.Clear();
int UserMatrixSize(string text)
{
    Console.Write($"Введите число {text}: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int column = UserMatrixSize("столбцов");
int row = CheckInequalityNumber("строк");

int CheckInequalityNumber(string text){ //По условиям задачи должена быть прямоугольная матрица
    Console.Write($"Введите число {text}: ");
    int size = Convert.ToInt32(Console.ReadLine());
    while(column == size){
        if(column != size) return size;
        else {
            Console.Write("Введите число другое число, отличное от количества столбцов: ");
            size = Convert.ToInt32(Console.ReadLine());
        }
    }
    return size;
}

int[,] matrix = new int[column,row];

int[,] RndMatrix(int[,] mtrx){
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = new Random().Next(10);
        }
    }
    return mtrx;
}
matrix = RndMatrix(matrix);

int MinSumColums(int[,] mtrx){
    int minSum = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            temp = temp + mtrx[i,j];
        }
        if(i == 0){
            minSum = temp;
        }
        if(temp < minSum){
            minSum = temp;
        }
    }

    return minSum;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i, j] < 10)
            {
                Console.Write($"{"0" + Convert.ToString(mtrx[i, j])} ");
            }
            else
            {
                Console.Write($"{mtrx[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);
Console.WriteLine(MinSumColums(matrix));

// Задача №58
Console.Clear();
int UserMatrixSize()
{
    Console.Write($"Введите размер матрицы (столбцы, строки): ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int sizeMtrx = UserMatrixSize();


int[,] matrixA = new int[sizeMtrx, sizeMtrx];
int[,] matrixB = new int[sizeMtrx, sizeMtrx];
int[,] matrixC = new int[sizeMtrx, sizeMtrx];


int[,] RndMatrix(int[,] mtrx){
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i,j] = new Random().Next(10);
        }
    }
    return mtrx;
}
matrixA = RndMatrix(matrixA);
matrixB = RndMatrix(matrixB);

int[,] MatrixProduct(int[,]mtrxA, int[,]mtrxB, int[,]mtrxC)
{   
    for (int i = 0; i < mtrxC.GetLength(0); i++)
    {
        for (int j = 0; j < mtrxC.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < mtrxA.GetLength(1); k++)
            {
                temp = temp + mtrxA[i, k] * mtrxB[k, j];
            }
            mtrxC[i,j] = temp;
        }        
    }

    return mtrxC;
}

matrixC = MatrixProduct(matrixA, matrixB, matrixC);

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (mtrx[i, j] < 10)
            {
                Console.Write($"{"0" + Convert.ToString(mtrx[i, j])} ");
            }
            else
            {
                Console.Write($"{mtrx[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
PrintMatrix(matrixC);


// Задача №60
Console.Clear();
int UserMatrixSize(string text)
{
    Console.Write($"Введите число {text}: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int column = UserMatrixSize("столбцов");
int row = UserMatrixSize("строк");
int depth = UserMatrixSize("глубины");

int[,,] matrix = new int[column, row, depth]; 

int[,,] RndMatrix(int[,,] mtrx){
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                mtrx[i,j,k] = new Random().Next(10, 99);
            }
        }
    }
    return mtrx;
}
matrix = RndMatrix(matrix);

void PrintMatrix(int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);


// Задача №62

Console.Clear();
int UserMatrixSize(string text)
{
    Console.Write($"Введите число {text}: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int column = UserMatrixSize("столбцов");
int row = UserMatrixSize("строк");
Console.WriteLine(); // Отделим ввод от вывода программы

int[,] matrix = new int[column, row]; // Задает юзер

int[,] FillingMatrix(int[,] mtrx)
{
    int i = 0;
    int j = -1; // Начинаю с -1, так как в цикл захожу сначала с увличение j на 1, а уже следующей строкой присваюваю значение
    int count = 1;
    int spiralIndex = 1; //С каждым циклом заполнения, уменьшает число заполнения строк и столбцов
    while (count <= mtrx.GetLength(0) * mtrx.GetLength(1))
    { //двойную проверку (здесь и в циклах ниже), сделал чтобы он не презаписывал элементы в прямоугольных матрицах.
        while ((j < mtrx.GetLength(1) - spiralIndex) && (count <= mtrx.GetLength(0) * mtrx.GetLength(1)))
        {
            j++;
            mtrx[i, j] = count;
            count++;
        }
        while ((i < mtrx.GetLength(0) - spiralIndex) && (count <= mtrx.GetLength(0) * mtrx.GetLength(1)))
        {
            i++;
            mtrx[i, j] = count;
            count++;
        }
        while ((j >= 0 + spiralIndex) && (count <= mtrx.GetLength(0) * mtrx.GetLength(1)))
        {
            j--;
            mtrx[i, j] = count;
            count++;
        }
        spiralIndex++;
        while ((i >= 0 + spiralIndex) && (count <= mtrx.GetLength(0) * mtrx.GetLength(1)))
        {
            i--;
            mtrx[i, j] = count;
            count++;
        }

    }
    return mtrx;
}

int[,] matrixNew = FillingMatrix(matrix);


void PrintMatrix()
{
    for (int i = 0; i < matrixNew.GetLength(0); i++)
    {
        for (int j = 0; j < matrixNew.GetLength(1); j++)
        {
            if (matrixNew[i, j] < 10)
            {
                Console.Write($"{"0" + Convert.ToString(matrix[i, j])} ");
            }
            else
            {
                Console.Write($"{matrixNew[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
PrintMatrix();

