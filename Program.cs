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

//Lab 2
// //Part 1-7

// Console.Write("Enter x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// double y = 0;

// if (Math.Abs(x) > 1)
// {
//     y = 1;
// } else 
// {
//     y = Math.Abs(x);
// }

// Console.WriteLine("x = {0}, y = {1}", x, y);

//Part 2 - 4
// Console.Write("Enter the number of points: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         // Create arrays to store x and y coordinates
//         double[] x = new double[n];
//         double[] y = new double[n];

//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Enter x for point {i + 1}: ");
//             x[i] = Convert.ToDouble(Console.ReadLine());
            
//             Console.Write($"Enter y for point {i + 1}: ");
//             y[i] = Convert.ToDouble(Console.ReadLine());
//         }

//         //Radius of inner ring and outer ring

//         //Inner ring
//         int r1 = 4;

//         int r2 = 6;

//         Console.WriteLine("\nYou entered the following points:");
//         for (int i = 0; i < n; i++)
//         {
//             if ((x[i]*x[i] + y[i]*y[i]) < r1*r1)
//             {
//                 Console.WriteLine($"({x[i]}, {y[i]}) is inside the radius r1");
//             } else if ((x[i]*x[i] + y[i]*y[i]) > r1*r1 && (x[i]*x[i] + y[i]*y[i]) < r2*r2)
//             {
//                 Console.WriteLine($"({x[i]}, {y[i]}) is inside the radius r2");
//             } else 
//             {
//                 Console.WriteLine($"({x[i]}, {y[i]}) is outside both circle");
//             }
//         }

//Part 3 - (2-9)
// double bestTime = double.MaxValue; // Initialize to a very large value
// while (true)
// {
//     Console.Write("Enter the swimmer time: ");
//     string input = Console.ReadLine();
//     if (string.IsNullOrEmpty(input)) break; // Stop if input is empty (Enter is pressed)

//     double time = Convert.ToDouble(input);

//     // Update the best time if a smaller time is found
//     if (time < bestTime)
//     {
//         bestTime = time;
//     }
// }

// Console.WriteLine($"The best swimming time is: {bestTime}");

//Part 3 (2-8)



double smallest = 10000;
double x = 0, y = 0;
double closestX = 0, closestY = 0;

while (true)
{
    Console.Write("Enter x: ");
    string xinput = Console.ReadLine();
    if (string.IsNullOrEmpty(xinput)) break; // Stop if input is empty (Enter is pressed)


    Console.Write("Enter y: ");
    string yinput = Console.ReadLine();
    if (string.IsNullOrEmpty(yinput)) break;

     x = Convert.ToDouble(xinput);
     y = Convert.ToDouble(yinput);

    double distance = Math.Sqrt(x*x + y*y);
    if (distance < smallest)
            {
                smallest = distance;  // Update the smallest distance
                closestX = x;         // Store the x coordinate of the closest point
                closestY = y;         // Store the y coordinate of the closest point
            }

}

Console.WriteLine($" ({closestX}, {closestY}) is the closest with the distance of {smallest:F2}");









//Lab 4

//Part 1-1


// int[,] n = new int[5,7] {{1,2,3,4,5,6,7},
//                          {8,9,10,11,12,13,14},
//                          {15,16,17,18,19,20,21},
//                          {22,23,24,25,26,27,28},
//                          {29,30,31,32,33,34,35}};

// int s = 0;

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         s += n[i, j];
//     }
// }

// Console.WriteLine(s);

//Part 1 - 7


// int[,] n = new int[3,5]{{1,16,10,4,10}, 
//                         {8,2,17,11,19}, 
//                         {15,9,3,18,5}};

// int[] b = new int[5];


// for (int j = 0; j < 5; j++)
// {
//     int max = n[0,j];
//     for (int i = 0; i < 3; i++)
//     {
//         if (n[i, j] > max)
//         {
//             max = n[i, j];
//         }
//     }

//     b[j] = max;
// }

// Console.WriteLine(string.Join("," , b));








