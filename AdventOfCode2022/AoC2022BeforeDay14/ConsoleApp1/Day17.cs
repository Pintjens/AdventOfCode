using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day17 // Tetris
    {
        public static void Main()
        {
            Console.Write("Part ? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Part1();
            }
            else if (choice == "2")
            {
                Part2();
            }
            else
            {
                Console.WriteLine("Not possible..");
                Main();
            }
        }
        public enum direction
        {
            left, down, right
        }
        abstract class Shape
        {

            private static ulong maxBlocks = 1000000;

            private static List<int[]> tower = new List<int[]> { new int[] { 1,2,3,4,5,6,7 } };

            public static List<int[]> previousState = new List<int[]>();
            public abstract List<int[]> Coordinats { get; }
            
            public static int HighestPoint = 0;
            
            public abstract int Left { get; }
            public abstract int Right { get; }

            public abstract int Top { get; }
            internal class Minus : Shape
            {
                int[] left = { 3, 4 };
                int[] leftCenter = { 4, 4 };
                int[] rightCenter = { 5, 4 };
                int[] right = { 6, 4 };

                public override List<int[]> Coordinats
                {
                    get
                    {
                        List<int[]> coordinats = new List<int[]>();
                        coordinats.Add(this.left);
                        coordinats.Add(this.leftCenter);
                        coordinats.Add(this.rightCenter);
                        coordinats.Add(this.right);

                        return coordinats;
                    }

                }
                public override int Left
                {
                    get
                    {
                        return this.left[0];
                    }
                }

                public override int Right
                {
                    get
                    {
                        return this.right[0];
                    }
                }

                public override int Top
                {
                    get
                    {
                        return this.left[1];
                    }
                }

                public Minus (int highestPoint)
                {
                    this.left[1] += highestPoint;
                    this.leftCenter[1] += highestPoint;
                    this.rightCenter[1] += highestPoint;
                    this.right[1] += highestPoint;
                }


            }
            internal class Plus : Shape
            {
                int[] left = { 3, 5 };
                int[] right = { 5, 5 };
                int[] center = { 4, 5 };
                int[] top = { 4, 6 };
                int[] bottom = { 4, 4 };

                public override List<int[]> Coordinats
                {
                    get
                    {
                        List<int[]> coordinats = new List<int[]>();
                        coordinats.Add(this.left);
                        coordinats.Add(this.right);
                        coordinats.Add(this.center);
                        coordinats.Add(this.top);
                        coordinats.Add(this.bottom);

                        return coordinats;
                    }
                }

                public override int Left
                {
                    get
                    {
                        return this.left[0];
                    }
                }

                public override int Right
                {
                    get
                    {
                        return this.right[0];
                    }
                }
                public override int Top
                {
                    get
                    {
                        return this.top[1];
                    }
                }

                public Plus(int highestPoint)
                {
                    this.left[1] += highestPoint;
                    this.right[1] += highestPoint;
                    this.center[1] += highestPoint;
                    this.top[1] += highestPoint;
                    this.bottom[1] += highestPoint;
                }

            }
            internal class Angle : Shape
            {
                int[] leftBottom = { 3,4};
                int[] bottomCenter = { 4, 4 };
                int[] rightBottom = { 5, 4 };
                int[] rightCenter = { 5, 5 };
                int[] top = { 5, 6 };

                public override List<int[]> Coordinats
                {
                    get
                    {
                        List<int[]> coordinats = new List<int[]>();
                        coordinats.Add(this.leftBottom);
                        coordinats.Add(this.bottomCenter);
                        coordinats.Add(this.rightBottom);
                        coordinats.Add(this.rightCenter);
                        coordinats.Add(this.top);

                        return coordinats;
                    }
                }

                public override int Left
                {
                    get
                    {
                        return this.leftBottom[0];
                    }
                }

                public override int Right
                {
                    get
                    {
                        return this.rightBottom[0];
                    }
                }
                public override int Top
                {
                    get
                    {
                        return this.top[1];
                    }
                }

                public Angle (int highestPoint)
                {
                    this.leftBottom[1] += highestPoint;
                    this.bottomCenter[1] += highestPoint;
                    this.rightBottom[1] += highestPoint;
                    this.rightCenter[1] += highestPoint;
                    this.top[1] += highestPoint;
                }

            }
            internal class Wall : Shape
            {
                int[] bottom = { 3, 4 };
                int[] centerBottom = { 3, 5 };
                int[] centerTop = { 3, 6 };
                int[] top = { 3, 7 };

                public override List<int[]> Coordinats
                {
                    get
                    {
                        List<int[]> coordinats = new List<int[]>();
                        coordinats.Add(this.bottom);
                        coordinats.Add(this.centerBottom);
                        coordinats.Add(this.centerTop);
                        coordinats.Add(this.top);

                        return coordinats;
                    }
                }

                public override int Left
                {
                    get
                    {
                        return this.bottom[0];
                    }
                }

                public override int Right
                {
                    get
                    {
                        return this.bottom[0];
                    }
                }
                public override int Top
                {
                    get
                    {
                        return this.top[1];
                    }
                }


                public Wall(int highestPoint)
                {
                    this.bottom[1] += highestPoint;
                    this.centerBottom[1] += highestPoint;
                    this.centerTop[1] += highestPoint;
                    this.top[1] += highestPoint;
                }

            }
            internal class Square : Shape
            {
                int[] bottomLeft = { 3, 4 };
                int[] bottomRight = { 4, 4 };
                int[] topRight = { 4, 5 };
                int[] topLeft = { 3, 5 };

                public override List<int[]> Coordinats
                {
                    get
                    {
                        List<int[]> coordinats = new List<int[]>();
                        coordinats.Add(this.bottomLeft);
                        coordinats.Add(this.bottomRight);
                        coordinats.Add(this.topRight);
                        coordinats.Add(this.topLeft);

                        return coordinats;
                    }
                }

                public override int Left
                {
                    get
                    {
                        return this.bottomLeft[0];
                    }
                }

                public override int Right
                {
                    get
                    {
                        return this.bottomRight[0];
                    }
                }
                public override int Top
                {
                    get
                    {
                        return this.topRight[1];
                    }
                }

                public Square(int highestPoint)
                {
                    this.bottomLeft[1] += highestPoint;
                    this.bottomRight[1] += highestPoint;
                    this.topRight[1] += highestPoint;
                    this.topLeft[1] += highestPoint;

                }
            }
            public void Move(direction movement, int fallenPlaces)
            {
                if (fallenPlaces < 3)
                {
                    if (movement == direction.down)
                    {
                        foreach (var set in this.Coordinats)
                        {
                            set[1] -= 1;
                        }
                    }
                    else if (movement == direction.left)
                    {
                        if (this.Left > 1)
                        {
                            foreach (var set in this.Coordinats)
                            {
                                set[0] -= 1;
                            }
                        }
                    }
                    else
                    {
                        if (this.Right < 7)
                        {
                            foreach (var set in this.Coordinats)
                            {
                                set[0] += 1;
                            }
                        }
                    }
                }
                else //possible landed blocks from here on
                {

                    if(movement == direction.down)
                    {
                        previousState.Clear();

                        foreach (var set in this.Coordinats)
                        {
                            previousState.Add(new int[] { set[0], set[1] });
                        }

                        int topFallingBlock = this.Top;

                        foreach (var set in this.Coordinats)
                        {

                            set[1] -= 1;

                            if (tower[set[1]].Contains(set[0]))
                            {
                                if(HighestPoint < topFallingBlock)
                                {
                                    HighestPoint = topFallingBlock;
                                }
                                throw new Exception();
                            }

                        }
                    }
                    else
                    {
                        int xDirect = -1;
                        if(movement == direction.left)
                        {
                            xDirect = +1;
                        }

                        bool ubstructed = false;

                        foreach (var set in this.Coordinats)
                        {
                            if (tower[set[1]].Contains(set[0] - xDirect) || set[0] - xDirect == 8 || set[0] - xDirect == 0)
                            {
                                ubstructed = true;
                                break;
                            }
                        }
                        if (!ubstructed)
                        {
                            foreach (var set in this.Coordinats)
                            {
                                set[0] -= xDirect;
                            }
                        }

                    }

                }

            }

            public static void Run()
            {
                for (int i = 0; i < 4; i++)
                {
                    tower.Add(new int[7]);
                }



                int blowCount = 0;

                string windDirections = Input.Day17.Demo();

                Shape fallingBlock = new Minus(HighestPoint);

                for (ulong block = 0; block < maxBlocks; block++)
                {

                    bool falling = true;
                    ulong shape = block % 5;

                    switch (shape)
                    {
                        case 0:
                            fallingBlock = new Minus(HighestPoint);
                            break;
                        case 1:
                            fallingBlock = new Plus(HighestPoint);
                            break;
                        case 2:
                            fallingBlock = new Angle(HighestPoint);
                            break;
                        case 3:
                            fallingBlock = new Wall(HighestPoint);
                            break;
                        case 4:
                            fallingBlock = new Square(HighestPoint);
                            break;

                    }

                    int fallenPlaces = 0;
                    while (falling)
                    {


                            if (windDirections[blowCount % windDirections.Length] == '>')
                            {
                                fallingBlock.Move(direction.right, fallenPlaces);
                            }
                            else
                            {
                                fallingBlock.Move(direction.left, fallenPlaces);
                            }


                        try
                        {
                            fallingBlock.Move(direction.down, fallenPlaces);
                        }
                        catch (Exception)
                        {
                            while (tower.Count - 1 < HighestPoint + 7)
                            {
                                tower.Add(new int[7]);
                            }
                            foreach (var set in previousState)
                            {
                                tower[set[1]][set[0] - 1] = set[0];
                            }
                            falling = false;
                        }


                        blowCount++;
                        fallenPlaces++;
                    }


                }

                Console.Clear();
                for (int i = tower.Count - 1; i >= tower.Count - 30; i--)
                {
                    int[] line = tower[i];

                    Console.Write("||");
                    foreach (var stone in line)
                    {
                        if (stone != 0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine("||");
                }
                Console.ReadLine();

                Console.WriteLine(HighestPoint);

            }

        }
        public static void Part1()
        {
            // shape 1 "-" // 1 substring control

            // shape 2 "+" // 3 control points

            // shape 3 "┘" // 5 control points

            // shape 4 "i" // 4 control points

            // shape 5 "■" // 4 control points



            Shape.Run();

            // 2680 is to low

            // 3151 it the right answer
        }
        public static void Part2()
        {
            //1555252374746 it to low 


        }
    }
}
