﻿using System.Collections.Immutable;

namespace Day16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Part 2 would take 9-10 h == 38241 seconds 

			// In: 752140569
			// In: 723787243

			// Demo
			// In: 3578123
			// In: 6553288
			// In: 3065697
			string input = "\\\\.........../..............-..../....\\.......\\.................|....|..........|............-\\.....|.........\r\n................................../.......|..\\..........-....................\\........../../\\../..............\r\n.............................|...|.............\\..\\.....|.........\\....................../............/-......\r\n\\................\\.............|..../........\\\\.....\\\\........-.........../..\\.../...\\.......\\/.......|..|....\r\n......\\..............|...|..../........-../.................../....|./................./.\\........\\.|-........\r\n.............................-....................-............/.\\............../........\\/........|...\\......\r\n./........|................\\.|........\\.......\\../.-.........\\..-.............|...............................\r\n|....................|...............-/............-.|..|...........................|..................\\......\r\n................../........\\../...........|..................\\................./.......\\...-......../|........\r\n././...........-..|....................................-.....................|./........../..|.-..\\..|.....|..\r\n.............|.......................||................................../..-........./.................../...\r\n........-......\\............/.....-...\\..|...........\\..........-.........................\\...................\r\n\\/...............\\.|......................\\......\\.........\\/..........\\................./.-.../...-.....|....\r\n....\\........................................................\\.......-/.............\\/.........\\..............\r\n\\........\\.........\\..\\..|....\\..............-...../.................|.....|.................\\.-/.............\r\n.............................\\/..-..............\\....-...-............................................./......\r\n....|..../...................//.........\\.............\\......|...|....../............|.......-.|.-.-|.......\\.\r\n.........|..-.-........\\\\../...........|.....\\............................../....\\\\..\\......../......\\\\..|....\r\n.......|....................-...././...../.|../........................./...-\\...|.......|.......-....|......\\\r\n../.../........-......................|......-.....\\..............-../.......|./.......|.............|.......|\r\n........................................................./............-......\\.../........\\../../.........\\...\r\n........................./../.../............-.\\.........................|..............|....................|\r\n..-......./.--.......|.............................................\\........\\.........\\...............\\......|\r\n.|........................................|..........-....\\.......\\.......|................................../\r\n..............................................\\.....\\........|.....\\./......\\................|......../...../.\r\n./.\\......../..\\\\..|....-.-|..-.............................................../.\\|/........\\.........-|...|...\r\n........|........-.\\/................-.........-............../.|..........\\./|...--...............|..........\r\n.................-............./././...........|.|.....|....|......\\-....|...............|....................\r\n.......././..............................................|/...\\........../......./..||.\\..-...................\r\n............-..|....................\\..-./.........\\..........................................................\r\n./.-...............\\......\\...|......\\....../..........................-....................-...|......\\......\r\n.....././...-........................\\..../..|-.............../.......................................\\|......\r\n-.........................................../...............-....../.....|.........\\..-.........|.............\r\n....|.......\\....\\|.....\\.|....|.............\\..\\...-............../.....................\\....-...............\r\n.............-..-..................\\..............|..|........................-..........\\../.\\......../......\r\n.....|.....................\\.....\\.......\\...........\\....|.........\\.......//.................|........./....\r\n|.....\\-/.......|............../.....\\..........|......./......./...............\\./..........|................\r\n............../|.......................|....../..............-...................-...................../......\r\n../|....\\.......\\...............\\................-........\\..../../.................\\/.........\\....\\.........\r\n........-.....|.|......-...........\\............|...................\\...........|.......................|.....\r\n.....|....|..\\..........................|................\\..../....-..................................|.......\r\n..-........||/................/........|......................-....-..................../..|...../............\r\n............./.............\\..-.......................\\..................||.-.-..|...............\\...|...\\....\r\n............................\\....\\....../....\\...........-...................|....-.....|.....................\r\n.../...........................-..|.....|../.........\\./.................\\|..............||....|..........\\...\r\n.................../........\\...........\\........../............|...|\\....\\........|......-...\\.......|./...\\.\r\n-....|...........\\............./..\\...........||...................|.............../...............\\..........\r\n.........\\.........-..................../.../.......//.............-/...-.-|....\\.............................\r\n..-.........\\......././................-.........|-...../............|....-.............\\.....................\r\n......../.......|.............................\\....|......................../................................-\r\n..\\........./.--................/................................................................../......-...\r\n.../................|.\\....-.................................\\.../....................................\\.......\r\n.............................\\....../.|...........-............................................/....-.........\r\n...\\./..........-........./../...............................-..-........-....../..................-.....\\....\r\n.........\\........./\\........................-.-................................|.............................\r\n..../.|-.................................-............\\..................|.........|......./......-...........\r\n.-|..........................-........|...//..\\.../.........-............/|.............|..............-..\\...\r\n..../......|...\\..........|...........-.||....-..|.........-......../..........|................../...........\r\n\\.../../............./../...........\\...........\\.......................................\\./.............|.....\r\n.....|.../....|..............................\\........\\...................|.........|.........................\r\n..........|............|............./......../.../................................-.....-.........../..|.....\r\n......-.\\.........................|...../.....\\.....-/....-..|.\\.........\\|....-.........||...........\\.......\r\n..\\......\\............./...............\\-............/...|................................/...................\r\n.......|.|...|.|.........|..|.......-...\\.........|./..|..................-................|..........-.......\r\n..-\\...--..-........|......................-.....|./..............|/.................../...........\\....-.../.\r\n...........-...-........-..........-...........|.......-................\\.........|............-.............|\r\n.....|.\\..-../....\\.................../-....\\.............|......../....\\/.\\..\\...//..........|...............\r\n......-.-.|..|............................./.........-....|.......|......|..............................-...-.\r\n..|............\\...|................./\\...|........../...-.|.........\\..../.........|-...|.......\\...........-\r\n...................\\..../..............|...../.....\\....../.................\\..|.....................-........\r\n.|............-................../........-.....|..../..........................|../..\\.....\\....|............\r\n.............................................|..........|......-\\.............-..-........................\\...\r\n............./.-....|......|................................................-/|/...|../...........-...|.......\r\n......-................-..-...............|................-.-.............\\........|...-./................-..\r\n...........|...........-/........../..................../|.|...................|...................../........\r\n.....................................\\......................../...........|-...........-................../...\r\n...|.....\\.....-...../..............|.........\\....\\............-\\............\\/.........................-....\r\n..............-\\......-.............../...|.........................................|.....\\/..................\r\n.................|...|.....|.............../....\\...............-....\\..........|.-........|........../...|...\r\n..|...-.........\\....-.....\\.....................|...|.......-....\\....-..-......-.\\../........-../...........\r\n.......\\.....\\................\\......\\-................................|..\\.....//.........../..........\\.....\r\n........................../.-.................................\\--......../..-.................................\r\n.................|............|\\./....|.|..|.............//......./.......................|.....\\.....\\\\......\r\n./...|\\...................................../.......................\\.........|..............|....|....\\......\r\n......|.............................................................\\..|.................\\-..../......./......\r\n.....-.......|........../......./..\\...........|...........-..|......../...../................\\......\\........\r\n............\\....-........\\......./.......-...........................................\\........-/./...........\r\n|..................................-.........\\/..-....././.....\\.............../-....................\\........\r\n../.........-..........-....-...-.........\\/....................../.../.....\\............................-.\\.|\r\n........../...-..-........................-........................................./....\\.....-..............\r\n..|-.\\........\\....................\\.\\..........-....|.-.-...........\\..............\\..-.....|................\r\n..-.../......./\\.\\...\\\\.//.....|..........................\\........|.-||......................|.......\\/......\r\n...-........-/.............................-......................-|....\\...|..../..|.........\\...............\r\n.........|..|/........./.......\\....\\../\\.-..-...\\..|...../...........\\.............../..................../\\.\r\n.........\\.-\\|..|../...........--..........|-......|...|.................||...................................\r\n..................\\.....\\...........................|.............\\..|.........................|...........\\..\r\n....|../........../.............................|./........\\\\.....|.....|...................................|.\r\n-..........................................-........................-...\\..................\\.....\\......-.....\r\n..\\.\\......|......|........|.............-|....-.....-...........|../.-.........|........\\..\\...-...\\........\\\r\n.|.......-..|....|..............|.................../...............|.............................-.........//\r\n....................\\..\\.||./\\.......-.........-..-................../..../....................-/..........\\..\r\n.........\\.........|...-.....\\..........\\.\\....|.|..............|..........................................\\.|\r\n...|\\..|................-/..........|\\....\\/|..-...........................................\\..................\r\n.../...\\.|..............................\\.-...\\.........\\....../../...............-./............/............\r\n.....-.\\..............................................\\.|....................\\..........|...............|.....\r\n.....|................../|....-....-....\\..../...............\\.....|..|......./.................../........\\..\r\n.......................\\....................-.......-.................../..............-...\\..\\........|......\r\n...../................\\........../..|.../...........|........|............\\........-....-/.....\\....|.........\r\n.\\\\.\\............|..................................................|......\\/..........................\\......\r\n....|........../...../...-.................|......|..........-....................................../.../.....";
			string demo1 = ".|...\\....\r\n|.-.\\.....\r\n.....|-...\r\n........|.\r\n..........\r\n.........\\\r\n..../.\\\\..\r\n.-.-/..|..\r\n.|....-|.\\\r\n..//.|....";

			var temp = input;

			var start = DateTime.Now.Ticks;
			long total = 8136;

			string[] contraptionGrid = temp.Split("\r\n");


			Beam startBeam = new Beam(new int[] { 0, 0 }, Direction.Right);
			Dictionary<int, Dictionary<int, Dictionary<Direction, bool>>> energized = new Dictionary<int, Dictionary<int, Dictionary<Direction, bool>>>();
			List<Beam> nextBeams = new List<Beam>();


			//for (int i = 88; i < contraptionGrid.Length; i++)
			//{

			//	// i 89
			//	// total 8136
			//	startBeam.Possition[0] = i;
			//	OneBeam(startBeam);
			//}
   //         Console.WriteLine("checked Right: " + total);

			////========================================

			//startBeam.LightDirection = Direction.Left;
			//startBeam.Possition[1] = contraptionGrid[0].Length - 1;
			//for (int i = 0; i < contraptionGrid.Length; i++)
			//{
			//	startBeam.Possition[0] = i;
			//	OneBeam(startBeam);
			//}
			//Console.WriteLine("checked Left: " + total);
			//// To fast..?

			////========================================

			//startBeam.LightDirection = Direction.Down;
			//startBeam.Possition[0] = 0;
			//for (int i = 0; i < contraptionGrid.Length; i++)
			//{
			//	startBeam.Possition[1] = i;
			//	OneBeam(startBeam);
			//}
			//Console.WriteLine("checked Down: " + total);
			//// plausible runtime
			//// total still 8136

			////========================================

			startBeam.LightDirection = Direction.Up;
			startBeam.Possition[0] = contraptionGrid.Length - 1;
			for (int i = 0; i < contraptionGrid.Length; i++)
			{
				startBeam.Possition[1] = i;
				OneBeam(startBeam);
			}
			Console.WriteLine("checked Up: " + total);

			// still 8136
			//========================================


			void OneBeam(Beam startBeam)
			{
				Beam.AllBeams.Add(startBeam);
				for (int y = 0; y < contraptionGrid.Length; y++)
				{
					//Dictionary<Direction, bool> newDirectionDic = new Dictionary<Direction, bool> {
					//	{Direction.Up , false },
					//	{Direction.Down , false },
					//	{Direction.Right, false },
					//	{Direction.Left, false } };
					energized[y] = new Dictionary<int, Dictionary<Direction, bool>>();
					for (int x = 0; x < contraptionGrid[y].Length; x++)
					{
						energized[y][x] = new Dictionary<Direction, bool>();
					}
				}
				energized[startBeam.Possition[0]][startBeam.Possition[1]][startBeam.LightDirection] = true;

				List<Beam> beams;

				bool beaming;
				Beam beam;
				do
				{
					nextBeams.Clear();

					beams = Beam.AllBeams;

					for (int b = 0; b < beams.Count; b++)
					{
						beam = beams[b];

						//if (beam == null) continue;
						//try
						//{
						//	if (energized[beam.Possition[0]][beam.Possition[1]][beam.LightDirection] == true) continue;
						//}
						//catch { }


						//energized[beam.Possition[0]][beam.Possition[1]][beam.LightDirection] = true;


						switch (contraptionGrid[beam.Possition[0]][beam.Possition[1]])
						{
							case '.':
								nextBeam(beam);
								break;

							case '/':
								switch (beam.LightDirection)
								{
									case Direction.Up:
										beam.LightDirection = Direction.Right;
										break;
									case Direction.Right:
										beam.LightDirection = Direction.Up;
										break;
									case Direction.Down:
										beam.LightDirection = Direction.Left;
										break;
									case Direction.Left:
										beam.LightDirection = Direction.Down;
										break;
									default:
										Console.WriteLine("Something went wrong @  '/'");
										break;
								}
								nextBeam(beam);
								break;

							case '|':
								if (beam.LightDirection == Direction.Up || beam.LightDirection == Direction.Down)
								{
									nextBeam(beam);
								}
								else
								{
									nextBeam(new Beam(beam.Possition, Direction.Up));
									nextBeam(new Beam(beam.Possition, Direction.Down));
								}
								break;

							case '-':
								if (beam.LightDirection == Direction.Right || beam.LightDirection == Direction.Left)
								{
									nextBeam(beam);
								}
								else
								{
									nextBeam(new Beam(beam.Possition, Direction.Right));
									nextBeam(new Beam(beam.Possition, Direction.Left));
								}
								break;

							default:
								// '\'
								switch (beam.LightDirection)
								{
									case Direction.Up:
										beam.LightDirection = Direction.Left;
										break;
									case Direction.Right:
										beam.LightDirection = Direction.Down;
										break;
									case Direction.Down:
										beam.LightDirection = Direction.Right;
										break;
									case Direction.Left:
										beam.LightDirection = Direction.Up;
										break;
									default:
										Console.WriteLine("Something went wrong @  '/'");
										break;
								}

								nextBeam(beam);
								break;
						}
					}

					Beam.AllBeams.Clear();
					//nextBeams.RemoveAll(b => b == startBeam);
					Beam.AllBeams.AddRange(nextBeams.ToImmutableList<Beam>());


					void DebugPrint()
					{
						for (int y = 0; y < contraptionGrid.Length; y++)
						{
							string line = contraptionGrid[y];
							for (int x = 0; x < line.Length; x++)
							{
								try
								{
									if (energized[y][x].Values.Contains(true))
									{
										Console.Write('#');
									}
								}
								catch
								{
									Console.Write(contraptionGrid[y][x]);
								}
							}
							Console.WriteLine();
						}
						//Console.ReadLine();
						Console.Clear();
					}
					// DebugPrint();


				} while (nextBeams.Count > 0);

				long thisTotal = 0;

				foreach (var item in energized.Values)
				{
					foreach (var x in item.Values)
					{
						if (x.Values.Contains(true))
						{
							thisTotal++;

						}

					}

				}

				if (thisTotal > total)
				{
					total = thisTotal;
				}

			}
			

			void nextBeam(Beam beam)
			{
				int[] newPossition = new int[] { beam.Possition[0], beam.Possition[1] };


				switch (beam.LightDirection)
				{
					case Direction.Up:
						newPossition[0]--;
						if (newPossition[0] < 0) return;
						break;
					case Direction.Right:
						newPossition[1]++;
						if (newPossition[1] >= contraptionGrid.Length) return;
						break;
					case Direction.Down:
						newPossition[0]++;
						if (newPossition[0] >= contraptionGrid.Length) return;
						break;
					case Direction.Left:
						newPossition[1]--;
						if (newPossition[1] < 0) return;
						break;
					default:
						Console.WriteLine("Something went wrong @ nextBeamPossition");
						return;
						break;
				}
				try
				{
					var check = energized[newPossition[0]][newPossition[1]][beam.LightDirection];
				}
				catch
				{
					nextBeams.Add(new Beam(newPossition, beam.LightDirection));
					energized[newPossition[0]][newPossition[1]][beam.LightDirection] = true;
					return;
				}
			}



			var end = DateTime.Now.Ticks;
			Console.WriteLine(total);
			Console.WriteLine("In: " + (end - start)/10000000.00);
			Console.WriteLine();
            Console.WriteLine("Will take around: " + (end - start) * (contraptionGrid.Length * 2 + contraptionGrid[0].Length * 2 + 4) / 10000000.00 + " on part 2.");
        }
		void Part1()
		{

			// In: 896190863

			string input = "\\\\.........../..............-..../....\\.......\\.................|....|..........|............-\\.....|.........\r\n................................../.......|..\\..........-....................\\........../../\\../..............\r\n.............................|...|.............\\..\\.....|.........\\....................../............/-......\r\n\\................\\.............|..../........\\\\.....\\\\........-.........../..\\.../...\\.......\\/.......|..|....\r\n......\\..............|...|..../........-../.................../....|./................./.\\........\\.|-........\r\n.............................-....................-............/.\\............../........\\/........|...\\......\r\n./........|................\\.|........\\.......\\../.-.........\\..-.............|...............................\r\n|....................|...............-/............-.|..|...........................|..................\\......\r\n................../........\\../...........|..................\\................./.......\\...-......../|........\r\n././...........-..|....................................-.....................|./........../..|.-..\\..|.....|..\r\n.............|.......................||................................../..-........./.................../...\r\n........-......\\............/.....-...\\..|...........\\..........-.........................\\...................\r\n\\/...............\\.|......................\\......\\.........\\/..........\\................./.-.../...-.....|....\r\n....\\........................................................\\.......-/.............\\/.........\\..............\r\n\\........\\.........\\..\\..|....\\..............-...../.................|.....|.................\\.-/.............\r\n.............................\\/..-..............\\....-...-............................................./......\r\n....|..../...................//.........\\.............\\......|...|....../............|.......-.|.-.-|.......\\.\r\n.........|..-.-........\\\\../...........|.....\\............................../....\\\\..\\......../......\\\\..|....\r\n.......|....................-...././...../.|../........................./...-\\...|.......|.......-....|......\\\r\n../.../........-......................|......-.....\\..............-../.......|./.......|.............|.......|\r\n........................................................./............-......\\.../........\\../../.........\\...\r\n........................./../.../............-.\\.........................|..............|....................|\r\n..-......./.--.......|.............................................\\........\\.........\\...............\\......|\r\n.|........................................|..........-....\\.......\\.......|................................../\r\n..............................................\\.....\\........|.....\\./......\\................|......../...../.\r\n./.\\......../..\\\\..|....-.-|..-.............................................../.\\|/........\\.........-|...|...\r\n........|........-.\\/................-.........-............../.|..........\\./|...--...............|..........\r\n.................-............./././...........|.|.....|....|......\\-....|...............|....................\r\n.......././..............................................|/...\\........../......./..||.\\..-...................\r\n............-..|....................\\..-./.........\\..........................................................\r\n./.-...............\\......\\...|......\\....../..........................-....................-...|......\\......\r\n.....././...-........................\\..../..|-.............../.......................................\\|......\r\n-.........................................../...............-....../.....|.........\\..-.........|.............\r\n....|.......\\....\\|.....\\.|....|.............\\..\\...-............../.....................\\....-...............\r\n.............-..-..................\\..............|..|........................-..........\\../.\\......../......\r\n.....|.....................\\.....\\.......\\...........\\....|.........\\.......//.................|........./....\r\n|.....\\-/.......|............../.....\\..........|......./......./...............\\./..........|................\r\n............../|.......................|....../..............-...................-...................../......\r\n../|....\\.......\\...............\\................-........\\..../../.................\\/.........\\....\\.........\r\n........-.....|.|......-...........\\............|...................\\...........|.......................|.....\r\n.....|....|..\\..........................|................\\..../....-..................................|.......\r\n..-........||/................/........|......................-....-..................../..|...../............\r\n............./.............\\..-.......................\\..................||.-.-..|...............\\...|...\\....\r\n............................\\....\\....../....\\...........-...................|....-.....|.....................\r\n.../...........................-..|.....|../.........\\./.................\\|..............||....|..........\\...\r\n.................../........\\...........\\........../............|...|\\....\\........|......-...\\.......|./...\\.\r\n-....|...........\\............./..\\...........||...................|.............../...............\\..........\r\n.........\\.........-..................../.../.......//.............-/...-.-|....\\.............................\r\n..-.........\\......././................-.........|-...../............|....-.............\\.....................\r\n......../.......|.............................\\....|......................../................................-\r\n..\\........./.--................/................................................................../......-...\r\n.../................|.\\....-.................................\\.../....................................\\.......\r\n.............................\\....../.|...........-............................................/....-.........\r\n...\\./..........-........./../...............................-..-........-....../..................-.....\\....\r\n.........\\........./\\........................-.-................................|.............................\r\n..../.|-.................................-............\\..................|.........|......./......-...........\r\n.-|..........................-........|...//..\\.../.........-............/|.............|..............-..\\...\r\n..../......|...\\..........|...........-.||....-..|.........-......../..........|................../...........\r\n\\.../../............./../...........\\...........\\.......................................\\./.............|.....\r\n.....|.../....|..............................\\........\\...................|.........|.........................\r\n..........|............|............./......../.../................................-.....-.........../..|.....\r\n......-.\\.........................|...../.....\\.....-/....-..|.\\.........\\|....-.........||...........\\.......\r\n..\\......\\............./...............\\-............/...|................................/...................\r\n.......|.|...|.|.........|..|.......-...\\.........|./..|..................-................|..........-.......\r\n..-\\...--..-........|......................-.....|./..............|/.................../...........\\....-.../.\r\n...........-...-........-..........-...........|.......-................\\.........|............-.............|\r\n.....|.\\..-../....\\.................../-....\\.............|......../....\\/.\\..\\...//..........|...............\r\n......-.-.|..|............................./.........-....|.......|......|..............................-...-.\r\n..|............\\...|................./\\...|........../...-.|.........\\..../.........|-...|.......\\...........-\r\n...................\\..../..............|...../.....\\....../.................\\..|.....................-........\r\n.|............-................../........-.....|..../..........................|../..\\.....\\....|............\r\n.............................................|..........|......-\\.............-..-........................\\...\r\n............./.-....|......|................................................-/|/...|../...........-...|.......\r\n......-................-..-...............|................-.-.............\\........|...-./................-..\r\n...........|...........-/........../..................../|.|...................|...................../........\r\n.....................................\\......................../...........|-...........-................../...\r\n...|.....\\.....-...../..............|.........\\....\\............-\\............\\/.........................-....\r\n..............-\\......-.............../...|.........................................|.....\\/..................\r\n.................|...|.....|.............../....\\...............-....\\..........|.-........|........../...|...\r\n..|...-.........\\....-.....\\.....................|...|.......-....\\....-..-......-.\\../........-../...........\r\n.......\\.....\\................\\......\\-................................|..\\.....//.........../..........\\.....\r\n........................../.-.................................\\--......../..-.................................\r\n.................|............|\\./....|.|..|.............//......./.......................|.....\\.....\\\\......\r\n./...|\\...................................../.......................\\.........|..............|....|....\\......\r\n......|.............................................................\\..|.................\\-..../......./......\r\n.....-.......|........../......./..\\...........|...........-..|......../...../................\\......\\........\r\n............\\....-........\\......./.......-...........................................\\........-/./...........\r\n|..................................-.........\\/..-....././.....\\.............../-....................\\........\r\n../.........-..........-....-...-.........\\/....................../.../.....\\............................-.\\.|\r\n........../...-..-........................-........................................./....\\.....-..............\r\n..|-.\\........\\....................\\.\\..........-....|.-.-...........\\..............\\..-.....|................\r\n..-.../......./\\.\\...\\\\.//.....|..........................\\........|.-||......................|.......\\/......\r\n...-........-/.............................-......................-|....\\...|..../..|.........\\...............\r\n.........|..|/........./.......\\....\\../\\.-..-...\\..|...../...........\\.............../..................../\\.\r\n.........\\.-\\|..|../...........--..........|-......|...|.................||...................................\r\n..................\\.....\\...........................|.............\\..|.........................|...........\\..\r\n....|../........../.............................|./........\\\\.....|.....|...................................|.\r\n-..........................................-........................-...\\..................\\.....\\......-.....\r\n..\\.\\......|......|........|.............-|....-.....-...........|../.-.........|........\\..\\...-...\\........\\\r\n.|.......-..|....|..............|.................../...............|.............................-.........//\r\n....................\\..\\.||./\\.......-.........-..-................../..../....................-/..........\\..\r\n.........\\.........|...-.....\\..........\\.\\....|.|..............|..........................................\\.|\r\n...|\\..|................-/..........|\\....\\/|..-...........................................\\..................\r\n.../...\\.|..............................\\.-...\\.........\\....../../...............-./............/............\r\n.....-.\\..............................................\\.|....................\\..........|...............|.....\r\n.....|................../|....-....-....\\..../...............\\.....|..|......./.................../........\\..\r\n.......................\\....................-.......-.................../..............-...\\..\\........|......\r\n...../................\\........../..|.../...........|........|............\\........-....-/.....\\....|.........\r\n.\\\\.\\............|..................................................|......\\/..........................\\......\r\n....|........../...../...-.................|......|..........-....................................../.../.....";
			string demo1 = ".|...\\....\r\n|.-.\\.....\r\n.....|-...\r\n........|.\r\n..........\r\n.........\\\r\n..../.\\\\..\r\n.-.-/..|..\r\n.|....-|.\\\r\n..//.|....";

			var temp = input;

			var start = DateTime.Now.Ticks;
			long total = 0;

			string[] contraptionGrid = temp.Split("\r\n");


			Beam startBeam = new Beam(new int[] { 0, 0 }, Direction.Right);
			Beam.AllBeams.Add(startBeam);
			Dictionary<int, Dictionary<int, Dictionary<Direction, bool>>> energized = new Dictionary<int, Dictionary<int, Dictionary<Direction, bool>>>();

			for (int y = 0; y < contraptionGrid.Length; y++)
			{
				//Dictionary<Direction, bool> newDirectionDic = new Dictionary<Direction, bool> {
				//	{Direction.Up , false },
				//	{Direction.Down , false },
				//	{Direction.Right, false },
				//	{Direction.Left, false } };
				energized[y] = new Dictionary<int, Dictionary<Direction, bool>>();
				for (int x = 0; x < contraptionGrid[y].Length; x++)
				{
					energized[y][x] = new Dictionary<Direction, bool>();
				}
			}

			List<Beam> beams;
			List<Beam> nextBeams = new List<Beam>();

			bool beaming;
			long itterations = (contraptionGrid.Length * contraptionGrid[0].Length) + 1;
			do
			{
				itterations--;

				beaming = false;

				beams = Beam.AllBeams;

				for (int b = 0; b < beams.Count; b++)
				{
					var beam = beams[b];

					if (beam == null) continue;
					try
					{
						if (energized[beam.Possition[0]][beam.Possition[1]][beam.LightDirection] == true) continue;
					}
					catch { }


					energized[beam.Possition[0]][beam.Possition[1]][beam.LightDirection] = true;


					switch (contraptionGrid[beam.Possition[0]][beam.Possition[1]])
					{
						case '.':
							nextBeams.Add(nextBeam(beam));
							break;

						case '/':
							switch (beam.LightDirection)
							{
								case Direction.Up:
									beam.LightDirection = Direction.Right;
									break;
								case Direction.Right:
									beam.LightDirection = Direction.Up;
									break;
								case Direction.Down:
									beam.LightDirection = Direction.Left;
									break;
								case Direction.Left:
									beam.LightDirection = Direction.Down;
									break;
								default:
									Console.WriteLine("Something went wrong @  '/'");
									break;
							}
							nextBeams.Add(nextBeam(beam));
							break;

						case '|':
							if (beam.LightDirection == Direction.Up || beam.LightDirection == Direction.Down)
							{
								nextBeams.Add(nextBeam(beam));
							}
							else
							{
								nextBeams.Add(nextBeam(new Beam(beam.Possition, Direction.Up)));
								nextBeams.Add(nextBeam(new Beam(beam.Possition, Direction.Down)));
							}
							break;

						case '-':
							if (beam.LightDirection == Direction.Right || beam.LightDirection == Direction.Left)
							{
								nextBeams.Add(nextBeam(beam));
							}
							else
							{
								nextBeams.Add(nextBeam(new Beam(beam.Possition, Direction.Right)));
								nextBeams.Add(nextBeam(new Beam(beam.Possition, Direction.Left)));
							}
							break;

						default:
							// '\'
							switch (beam.LightDirection)
							{
								case Direction.Up:
									beam.LightDirection = Direction.Left;
									break;
								case Direction.Right:
									beam.LightDirection = Direction.Down;
									break;
								case Direction.Down:
									beam.LightDirection = Direction.Right;
									break;
								case Direction.Left:
									beam.LightDirection = Direction.Up;
									break;
								default:
									Console.WriteLine("Something went wrong @  '/'");
									break;
							}

							nextBeams.Add(nextBeam(beam));
							break;
					}
				}

				Beam.AllBeams.Clear();
				Beam.AllBeams.AddRange(nextBeams.ToImmutableList<Beam>());
				if (nextBeams.Count > 0) beaming = true;
				nextBeams.Clear();

				void DebugPrint()
				{
					for (int y = 0; y < contraptionGrid.Length; y++)
					{
						string line = contraptionGrid[y];
						for (int x = 0; x < line.Length; x++)
						{
							try
							{
								if (energized[y][x].Values.Contains(true))
								{
									Console.Write('#');
								}
							}
							catch
							{
								Console.Write(contraptionGrid[y][x]);
							}
						}
						Console.WriteLine();
					}
					//Console.ReadLine();
					Console.Clear();
				}
				// DebugPrint();


			} while (beaming && itterations > 0);

			Beam nextBeam(Beam beam)
			{
				int[] newPossition = new int[] { beam.Possition[0], beam.Possition[1] };


				switch (beam.LightDirection)
				{
					case Direction.Up:
						newPossition[0]--;
						if (newPossition[0] < 0) return null;
						break;
					case Direction.Right:
						newPossition[1]++;
						if (newPossition[1] >= contraptionGrid.Length) return null;
						break;
					case Direction.Down:
						newPossition[0]++;
						if (newPossition[0] >= contraptionGrid.Length) return null;
						break;
					case Direction.Left:
						newPossition[1]--;
						if (newPossition[1] < 0) return null;
						break;
					default:
						Console.WriteLine("Something went wrong @ nextBeamPossition");
						return null;
						break;
				}

				return new Beam(newPossition, beam.LightDirection);
			}


			foreach (var item in energized.Values)
			{
				foreach (var x in item.Values)
				{
					if (x.Values.Contains(true))
					{
						total++;

					}

				}

			}


			var end = DateTime.Now.Ticks;
			Console.WriteLine(total);
			Console.WriteLine("In: " + (end - start));
		}
	}
}
