//Lab 1
//Part 3 - 1

// double a = 0.1, b = 1.0, h = 0.1, eps = 0.0001;
// Console.WriteLine($"{"x",5} {"Series Approximation",25} {"Exact cos(x)",15}");
// for (double x = a; x <= b; x += h) 
// {
//     double c = 1;
//     double s = c;
//     int i = 1;
//     do 
//     {
//         c = c * ((-x*x) / ((2 * i -1)*(2*i)));
//         s += c;
//         i++;
       

       
//     } while (Math.Abs(c) > eps);

//     double exact = Math.Cos(x);

//     Console.WriteLine($"{x,5:F1} {s,20:F6} {exact,15:F6}");
// }


// //Part 3-8
// double a = 0.1, b = 1.0, h = 0.05, eps = 0.0001;
// Console.WriteLine($"{"x",5} {"Series Approximation",25} {"Exact e^2x",15}");
// for (double x = a; x <= b; x += h) 
// {
//     double c = 1;
//     double s = c;
//     int i = 1;
//     do 
//     {
//         c *= (2*x)/i;
//         s += c;
//         i++;
       

       
//     } while (Math.Abs(c) > eps);

//     double exact = Math.Exp(2 * x);

//     Console.WriteLine($"{x,5:F1} {s,20:F6} {exact,15:F6}");
// }


//Lab 5

//Part 1-1


int[,] n = new int[5,7] {{1,2,3,4,5,6,7},
                         {8,9,10,11,12,13,14},
                         {15,16,17,18,19,20,21},
                         {22,23,24,25,26,27,28},
                         {29,30,31,32,33,34,35}};

int s = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        s += n[i, j];
    }
}

Console.WriteLine(s);



