using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerRanking
{
    class PlayerRanking
    {
        static void Main()
        {
            // commands
            const string ADD = "add";
            const string FIND = "find";
            const string RANKLIST = "ranklist";
            const string END = "end";

            List<Player> list = new List<Player>();


            while (true)
            {
                var line = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == ADD)
                {
                    string name = line[1];
                    string type = line[2];
                    int position = int.Parse(line[4]);
                    int age = int.Parse(line[3]);

                    if (position > list.Count)
                    {
                        list.Add(new Player(name, type, age));
                    }
                    else
                    {
                        list.Insert(position - 1, new Player(name, type, age));
                    }

                    Console.WriteLine("Added player {0} to position {1}", name, position);
                }
                else if (line[0] == FIND)
                {
                    string type = line[1];
                    List<Player> top = new List<Player>(list.Where(x => x.Type == type).Take(5).OrderBy(x => x.Name).ThenBy(x => -x.Age));

                    Console.WriteLine("Type {0}: {1}", type, string.Join("; ", top));
                }
                else if (line[0] == RANKLIST)
                {
                    int start = int.Parse(line[1]);
                    int end = int.Parse(line[2]);

                    var ranklist = list.GetRange(start - 1, end - start + 1);

                    string result = string.Empty;
                    for (int i = 0; i < ranklist.Count; i++)
                    {
                        result += (i + start) + ". " + (ranklist[i]);
                        if (i < end - start)
                        {
                            result += "; ";
                        }
                    }

                    Console.WriteLine(result);
                }
                else if (line[0] == END)
                {
                    break;
                }
            }
        }

        class Player
        {
            string name;
            string type;
            int age;

            public Player(string name, string type, int age)
            {
                this.Name = name;
                this.Type = type;
                this.Age = age;
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public string Type
            {
                get
                {
                    return type;
                }

                set
                {
                    type = value;
                }
            }

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    age = value;
                }
            }

            public override string ToString()
            {
                return this.Name + "(" + this.Age + ")";
            }
        }
    }
}
