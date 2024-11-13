using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class PatternDrawing  : Pattern{
    public static void Main() {
        Console.WriteLine("Welcome to the Pattern Drawing System!");
        StartDrawing();
    }

    public static void PrintOptions() {
        Console.WriteLine("Please choose one of the following options:");
        Console.WriteLine("  1. Right-angled Triangle");
        Console.WriteLine("  2. Square with Hollow Center");
        Console.WriteLine("  3. Diamond");
        Console.WriteLine("  4. Left-angled Triangle");
        Console.WriteLine("  5. Hollow Square");
        Console.WriteLine("  6. Pyramid");
        Console.WriteLine("  7. Right-angled Triangle (Numbers)");
        Console.WriteLine("  8. Inverted Pyramid");
        Console.WriteLine("  9. Diamond (Numbers)");
        Console.WriteLine("  10. Mirrored Right-angled Triangle");
        Console.WriteLine("  11. Alternating Star-Dash Square");
        Console.WriteLine("  12. Hourglass Shape");
        Console.WriteLine("  Q: Exit");
        Console.Write("Select an option: ");
    }

    public static void EnterMessage () {
        Console.Write("Enter number of rows: ");
    }

    public static void StartDrawing() {
        while (true) {
            PrintOptions();
            SelectOptions(Console.ReadLine());
        }
    }
    public static void SelectOptions(string optionNumber) {
        EnterMessage();
        if (optionNumber == "q" || optionNumber == "Q") {
            Environment.Exit(0); 
        }
        
        switch (int.Parse(optionNumber)) {
            case 1:
                RightAngledTriangle(int.Parse(Console.ReadLine()));
                break;
            case 2:
                SquareWithHollowCenter(int.Parse(Console.ReadLine()));
                break;
            case 3:
                Diamond(int.Parse(Console.ReadLine()));
                break;
            case 4:
                LeftAngledTriangle(int.Parse(Console.ReadLine()));
                break;
            case 5:
                HollowSquare(int.Parse(Console.ReadLine()));
                break;
            case 6:
                Pyramid(int.Parse(Console.ReadLine()));
                break;
            case 7:
                RightAngledTriangleWithNumbers(int.Parse(Console.ReadLine()));
                break;
            case 8:
                InvertedPyramid(int.Parse(Console.ReadLine()));
                break;
            case 9:
                DiamondNumbers(int.Parse(Console.ReadLine()));
                break;
            case 10:
                MirroredRightAngledTriangle(int.Parse(Console.ReadLine()));
                break;
            case 11:
                AlternatingStarDashSquare(int.Parse(Console.ReadLine()));
                break;
            case 12:
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Enter number of cols: ");
                int cols = int.Parse(Console.ReadLine());
                
                HourglassShape(rows, cols);
                break;
            default:
                throw new FormatException();
        }
    }

    
}

public class Pattern {
    public static void RightAngledTriangle(int n) {
        for (int i = 1; i <= n; i++) {
            for (int j = 0; j < i; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public static void SquareWithHollowCenter(int n) {
        for (int j = 0; j < n; j++) {
            Console.Write("*");
        }
        Console.WriteLine(); 
        
        for (int i = 0; i < n / 2 + 1; i++) {
            for (int j = 0; j < n; j++) {
                if (j == 0 || j == n - 1) {
                    Console.Write("*");
                }
                else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
        for (int j = 0; j < n; j++) {
            Console.Write("*");
        }
        Console.WriteLine(); 
    }
    
    public static void Diamond(int n) {
        for (int i = 0; i < n / 2 + 1; i++) {
            Console.Write(new string(' ', n - i - 1));
            Console.WriteLine(new string('*', 2 * i + 1));
        }
        
        for (int i = n - 2; i >= 0; i--) {
            Console.Write(new string(' ', n - i - 1));
            Console.WriteLine(new string('*', 2 * i + 1));
        }
    }
    
    public static void LeftAngledTriangle(int n) {
        for (int i = 0; i < n; i++) {
            for (int j = n - i; j > 0; j--) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public static void HollowSquare(int n) {
        for (int j = 0; j < n; j++) {
            Console.Write("*");
        }
        Console.WriteLine(); 
        
        for (int i = 0; i < n / 2 + 1; i++) {
            for (int j = 0; j < n; j++) {
                if (j == 0 || j == n - 1) {
                    Console.Write("*");
                }
                else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
        for (int j = 0; j < n; j++) {
            Console.Write("*");
        }
        Console.WriteLine(); 
    }
    
    public static void Pyramid(int n) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i - 1; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public static void RightAngledTriangleWithNumbers(int n) {
        for (int i = 0; i < n; i++) {
            for (int j = 1; j <= i + 1; j++) {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
    
    public static void InvertedPyramid(int n) {
        for (int i = n; i > 0; i--) {
            for (int j = 0; j < n - i; j++) {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i - 1; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public static void DiamondNumbers(int n) {
        for (int i = 1; i <= n; i++) {
            Console.Write(new string(' ', n - i));
            
            for (int j = 1; j <= i; j++) {
                Console.Write(j);
            }
            
            for (int j = i - 1; j >= 1; j--) {
                Console.Write(j);
            }

            Console.WriteLine();
        }
        
        for (int i = n - 1; i >= 1; i--) {
            Console.Write(new string(' ', n - i));
            
            for (int j = 1; j <= i; j++) {
                Console.Write(j);
            }

            for (int j = i - 1; j >= 1; j--) {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
    
    public static void MirroredRightAngledTriangle(int n) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                Console.Write(" ");
            }

            for (int j = 0; j < i + 1; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    public static void AlternatingStarDashSquare(int n) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i % 2 == 0) {
                    if (j % 2 == 0) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write("-");
                    }
                }
                else {
                    if (j % 2 != 0) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
    
    public static void HourglassShape(int row, int col) {
        for (int i = 0; i < col; i++) {
            for (int j = 0; j < row; j++) {
                if (i % 2 == 0) {
                    if (j % 2 == 0) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write("-");
                    }
                }
                else {
                    if (j % 2 != 0) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

