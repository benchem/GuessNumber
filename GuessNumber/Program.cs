using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var question = new List<string[]>
            {
                new[] //1
                {
                    "2587", "3A0B",
                    "9587", "3A0B",
                    "1587", "3A0B",
                    "4587", "3A0B",
                    "3587", "3A0B",
                    "0587", "3A0B"
                },
                new[] //2
                {
                    "0269", "0A1B",
                    "5798", "0A1B",
                    "4576", "0A2B",
                    "6184", "2A2B",
                    "7430", "0A1B",
                    "2315", "0A1B"
                },
                new[] //3
                {
                    "3465", "0A2B",
                    "9632", "1A1B",
                    "2549", "0A2B",
                    "5896", "0A2B",
                    "6974", "0A2B",
                    "9753", "0A0B"
                },
                new[] //4
                {
                    "2089", "1A1B",
                    "7520", "0A2B",
                    "5028", "1A2B",
                    "8975", "0A2B",
                    "4837", "0A1B",
                    "5682", "0A3B",
                },
                new[] //5
                {
                    "5602", "0A1B",
                    "7486", "0A1B",
                    "3815", "0A1B",
                    "0149", "0A3B",
                    "1924", "0A2B",
                    "9071", "0A2B",
                },
                new[] //6
                {
                    "0139", "0A2B",
                    "4016", "0A2B",
                    "7603", "0A2B",
                    "9465", "0A1B",
                    "3840", "0A2B",
                    "1274", "0A1B",
                },
                new[] //7
                {
                    "1607", "0A1B",
                    "5273", "0A2B",
                    "0852", "0A1B",
                    "3029", "0A2B",
                    "6438", "0A1B",
                    "9315", "0A1B",
                },
                new[] //8
                {
                    "3281", "0A2B",
                    "8534", "0A2B",
                    "6307", "0A1B",
                    "4023", "0A2B",
                    "0149", "0A1B",
                    "5692", "0A1B",
                },
                new[] //9
                {
                    "0531", "1A2B",
                    "4806", "0A1B",
                    "6019", "0A2B",
                    "5967", "0A1B",
                    "1730", "0A2B",
                    "8392", "0A1B",
                },
                new[] //10
                {
                    "4170", "1A1B",
                    "6458", "0A1B",
                    "4731", "1A2B",
                    "9134", "0A2B",
                    "3016", "0A2B",
                    "0843", "0A2B",
                },
                new[] //11
                {
                    "7654", "0A2B",
                    "4061", "0A2B",
                    "8176", "0A2B",
                    "4816", "1A2B",
                    "6539", "0A1B",
                    "2497", "0A1B",
                },
                new[] //12
                {
                    "1825", "0A2B",
                    "3712", "1A1B",
                    "8362", "0A2B",
                    "0981", "0A1B",
                    "5670", "0A1B",
                    "2316", "1A2B",
                },
                new[] //13
                {
                    "7894", "1A1B",
                    "7452", "0A2B",
                    "5870", "0A1B",
                    "2985", "0A2B",
                    "6297", "1A1B",
                    "3128", "0A1B",
                },
                new[] //14
                {
                    "8673", "0A2B",
                    "6841", "1A1B",
                    "9436", "0A2B",
                    "7524", "0A1B",
                    "1967", "0A2B",
                    "5098", "0A1B",
                },
                new[] //15
                {
                    "2437", "0A1B",
                    "9054", "0A1B",
                    "3916", "0A1B",
                    "0768", "0A2B",
                    "8120", "0A2B",
                    "5178", "1A1B",
                },
                new[] //16
                {
                    "3069", "0A1B",
                    "0547", "0A2B",
                    "5291", "0A1B",
                    "4538", "1A1B",
                    "0428", "1A1B",
                    "7186", "0A1B",

                },
                new[] //17
                {
                    "6718", "0A2B",
                    "8574", "1A0B",
                    "4680", "0A2B",
                    "5201", "0A1B",
                    "1349", "0A1B",
                    "7426", "0A2B",
                },
                new[] //18
                {
                    "6491", "0A2B",
                    "5369", "0A2B",
                    "3624", "0A2B",
                    "1932", "0A2B",
                    "1543", "1A1B",
                    "2156", "0A2B",
                },
                new[] //19
                {
                    "2540", "0A2B",
                    "8412", "1A1B",
                    "5018", "1A1B",
                    "1074", "0A2B",
                    "5487", "0A2B",
                    "7082", "1A1B",
                },
                new[] //20
                {
                    "0879", "0A1B",
                    "7324", "0A2B",
                    "8245", "1A1B",
                    "2041", "0A1B",
                    "4296", "0A2B",
                    "9513", "0A1B",
                }
            };

            for (int i = 0; i < question.Count; i++)
            {
                var number = new Number(question[i]);
                var answers = number.GetAnswers();
                // Console.WriteLine("".PadLeft(20, '-'));
                Console.WriteLine($"第{i + 1}题：{answers}");
            }
            
            Console.Read();
        }

        class Number
        {
            private List<Tips> tips = new List<Tips>();

            class Tips
            {
                public string Item { get; set; }

                public int A { get; set; }

                public int B { get; set; }

                public int Total
                {
                    get { return A + B; }
                }
            }
            
            public Number(string[] rawData)
            {
                for (var i = 0; i < rawData.Length; i += 2)
                {
                    var t = new Tips
                    {
                        Item = rawData[i],
                        A =int.Parse(rawData[i+1].Substring(0,1)),
                        B =int.Parse(rawData[i+1].Substring(2,1)),
                    };

                    tips.Add(t);
                }
            }

            private Dictionary<int, double> votingTable = new Dictionary<int, double>();

            public string GetAnswers()
            {
                Console.WriteLine("".PadLeft(20, '='));
                // Console.WriteLine(" \t0123456789");
                for (int i = 0; i < 10; i++)
                {
                    // Console.Write($"{i}\t");
                    votingTable.Add(i, GetVoting(i));
                }

                var tryCount = 0;
                do
                {
                    if (IsMarch(GetTopNumber()))
                    {
                        break;
                    }

                    // Console.WriteLine($"第 {tryCount+1} 次加权");
                    Weighted(tryCount++);
                } while (tryCount < tips.Count);

                if (!IsMarch(GetTopNumber()))
                {
                    return "没找到匹配";
                }

                return GetTopNumber();
            }

            private string GetTopNumber()
            {
                var array = (from item in votingTable orderby item.Value descending select item.Key).Take(4).ToArray();
                return string.Join("", array);
            }
            
            private double GetVoting(int number)
            {
                var qCount = 0;
                var rCount = 0;
                for (int voter = 0; voter < 10; voter++)
                {
                    // 0:没意见  1:质疑  2:反对
                    var state = 0;
                    // 自己不投票
                    if (voter == number)
                    {
                        // Console.Write("O");
                        continue;
                    }

                    foreach (var t in tips)
                    {
                        if (t.Item.Contains($"{number}") && t.Item.Contains($"{voter}"))
                        {
                            if (t.Total < 2) state = 2;
                            else if (state < 2) state = 1;
                        }
                    }

                    // Console.Write($"{(state == 0 ? " " : state == 1 ? "?" : "X")}");
                    if (state == 1) qCount++;
                    if (state == 2) rCount++;
                }

                // Console.WriteLine("");

                return 9 - qCount * 0.5 - rCount * 1;
            }

            private bool IsMarch(string numbers)
            {
                var isMarch = true;
                foreach (var t in tips)
                {
                    var numberCount = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (t.Item.Contains(numbers[i])) numberCount++;
                    }

                    isMarch &= numberCount == t.Total;
                }

                return isMarch;
            }

            private void Weighted(int top)
            {
                var target = (from t in tips orderby t.Total descending select t.Item).Skip(top).Take(1).ToArray()[0];
                foreach (var number in target)
                {
                    votingTable[int.Parse(number+"")] += 1;
                }
            }
        }
    }
}
