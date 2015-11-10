void Multiplicacion()
{
     private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int[,] aMatrix = new int[3, 2] { { 1, 4 }, { 2, 5 }, { 3, 6 } };
            int[,] bMatrix = new int[2, 3] { { 7, 8, 9 }, { 10, 11, 12 } };
            int[,] product = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    for (int inner = 0; inner < 2; inner++)
                    {
                        product[row, col] += aMatrix[row, inner] * bMatrix[inner, col];
                    }
                    Console.WriteLine(product[row, col] + "  ");
                }
                Console.WriteLine("\n");
            }
        }
}