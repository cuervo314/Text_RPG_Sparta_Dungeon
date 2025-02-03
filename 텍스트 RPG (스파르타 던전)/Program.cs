using System.Runtime.InteropServices;

namespace 텍스트_RPG__스파르타_던전_
{
    internal class Program
    {
        string asdasdasd;
        //유저 스탯 클래스
        public class UserStat
        {
            public int Lv { get; set; }
            public string UserName { get; set; }
            public string UserClass { get; set; }
            public int Atk { get; set; }
            public int Def { get; set; }
            public int Health { get; set; }
            public int Gold { get; set; }
        }

        // 선택 함수(스탯)
        static string UserAct(string first)
        {
            string userChoice = null;

            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }

        // 선택 함수(이름, 직업)
        static string UserAct(string first, string second)
        {
            string userChoice = null;
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine($"{second}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            userChoice = Console.ReadLine();
            return userChoice;
        }

        // 선택 함수(마을)
        static string UserAct(string first, string second, string third)
        {
            string userChoice = null;
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요");
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine($"{second}");
            Console.WriteLine($"{third}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }


        // 게임 실행
        static void Main(string[] args)
        {
            UserStat userStat = new UserStat();
            userStat.UserName = null;
            userStat.Lv = 01;
            userStat.Atk = 10;
            userStat.Def = 5;
            userStat.Health = 100;
            userStat.Gold = 21500;
            int atkChange = 0;
            int defChange = 0;

            List<string> userItem = new List<string>(); 
            
            List<string> storeItem = new List<string>();
            storeItem.Add("수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다. | 1000 G");
            storeItem.Add("무쇠갑옷 | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | 2250 G");
            storeItem.Add("스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | 3500 G");
            storeItem.Add("낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검입니다. | 600 G");
            storeItem.Add("청동 도끼 | 공격력 +5 | 어디선가 사용됐던 것 같은 도끼입니다. | 1500 G");
            storeItem.Add("스파르타의 창 | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | 2400 G");

            string userChoice;

            string nameChosen;
            bool nameFixed = false;

            //스탯 확인 함수
            void ShowStat()
            {
                string userChoice = null;
                Console.WriteLine("Lv. " + userStat.Lv);
                Console.WriteLine(userStat.UserName + " ( " + userStat.UserClass + " )");

                if (atkChange == 0 && defChange == 0)
                {
                    Console.WriteLine("공격력 : " + userStat.Atk);
                    Console.WriteLine("방어력 : " + userStat.Def);
                }
                else if (atkChange != 0 && defChange == 0)
                {
                    Console.WriteLine("공격력 : " + userStat.Atk + $" (+{atkChange})");
                    Console.WriteLine("방어력 : " + userStat.Def);
                }
                else if (atkChange == 0 && defChange != 0)
                {
                    Console.WriteLine("공격력 : " + userStat.Atk);
                    Console.WriteLine("방어력 : " + userStat.Def + $" (+{defChange})");
                }
                else
                {
                    Console.WriteLine("공격력 : " + userStat.Atk + $" (+{atkChange})");
                    Console.WriteLine("방어력 : " + userStat.Def + $" (+{defChange})");
                }

                Console.WriteLine("체력 : " + userStat.Health);
                Console.WriteLine("Gold : " + userStat.Gold + " G");
                userChoice = UserAct("0. 나가기");

                if (userChoice == "0")
                {
                    Town();
                }
                else
                {
                    ShowStat();
                }
            }

            void Town()
            {
                string userChoice = null;
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                userChoice = UserAct("1. 상태 보기", "2. 인벤토리", "3. 상점");

                if (userChoice == "1")
                {
                    ShowStat();
                }
                else if (userChoice == "2")
                {
                ReItem:
                    Console.WriteLine("인벤토리");
                    Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");

                    foreach (string item in userItem)
                    {
                        Console.WriteLine("- " + item);
                    }

                    userChoice = UserAct("1. 장착 관리", "0. 나가기");

                    if (userChoice == "1")
                    {
                        ReManage:
                        Console.Clear();
                        Console.WriteLine("인벤토리");
                        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                        Console.WriteLine();
                        Console.WriteLine("[아이템 목록]");

                        for (int i = 1; i <= userItem.Count; i++)
                        {
                            Console.WriteLine("- " + i + " " + userItem[i - 1]);
                        }

                        userChoice = UserAct("0. 나가기");

                        if (userChoice == "0")
                        {
                            Console.Clear();
                            Town();
                        }
                        
                        if (int.Parse(userChoice) <= userItem.Count)
                        {
                            if ((userItem[(int.Parse(userChoice)) - 1]).Contains("[E]") == true)
                            {
                                userItem[(int.Parse(userChoice)) - 1] = userItem[(int.Parse(userChoice)) - 1].Remove(0, 3);

                                if ((userItem[(int.Parse(userChoice)) - 1].Contains("방어력")) == true)
                                {
                                    int defDown = int.Parse((userItem[(int.Parse(userChoice)) - 1].ElementAt(((userItem[(int.Parse(userChoice)) - 1].IndexOf("+")) + 1))).ToString());
                                    userStat.Def -= defDown;
                                    defChange -= defDown;
                                }
                                else if ((userItem[(int.Parse(userChoice)) - 1].Contains("공격력")) == true)
                                {
                                    int atkDown = int.Parse((userItem[(int.Parse(userChoice)) - 1].ElementAt(((userItem[(int.Parse(userChoice)) - 1].IndexOf("+")) + 1))).ToString());
                                    userStat.Atk -= atkDown;
                                    atkChange -= atkDown;
                                }

                            }
                            else
                            {
                                userItem[(int.Parse(userChoice)) - 1] = userItem[(int.Parse(userChoice)) - 1].Insert(0, "[E]");

                                if ((userItem[(int.Parse(userChoice)) - 1].Contains("방어력")) == true)
                                {
                                    int defUp = int.Parse((userItem[(int.Parse(userChoice)) - 1].ElementAt(((userItem[(int.Parse(userChoice)) - 1].IndexOf("+")) + 1))).ToString());
                                    userStat.Def += defUp;
                                    defChange += defUp;
                                }
                                else if ((userItem[(int.Parse(userChoice)) - 1].Contains("공격력")) == true)
                                {
                                    int atkUp = int.Parse((userItem[(int.Parse(userChoice)) - 1].ElementAt(((userItem[(int.Parse(userChoice)) - 1].IndexOf("+")) + 1))).ToString());
                                    userStat.Atk += atkUp;
                                    atkChange += atkUp;
                                }
                            }

                            goto ReManage;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            Console.Clear();
                            goto ReManage;
                        }
                    }
                    else if (userChoice == "0")
                    {
                        Console.Clear();
                        Town();
                    }
                    else
                    {
                        goto ReItem;
                    }
                }
                else if (userChoice == "3")
                {
                    ReMarket:
                    Console.Clear();
                    Console.WriteLine("상점");
                    Console.WriteLine("필여한 아이템을 얻을 수 있는 상점입니다.");
                    Console.WriteLine();
                    Console.WriteLine("[보유 골드]");
                    Console.WriteLine(userStat.Gold);
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");

                    foreach (string item in  storeItem)
                    {
                        Console.WriteLine("- " + item);
                    }

                    userChoice = UserAct("1. 아이템 구매", "0. 나가기");

                    if (userChoice == "1")
                    {
                        ReBuy:
                        Console.Clear();
                        Console.WriteLine("상점 - 아이템 구매");
                        Console.WriteLine("필여한 아이템을 얻을 수 있는 상점입니다.");
                        Console.WriteLine();
                        Console.WriteLine("[보유 골드]");
                        Console.WriteLine(userStat.Gold);
                        Console.WriteLine();
                        Console.WriteLine("[아이템 목록]");

                        for (int i = 1; i <= storeItem.Count; i++)
                        {
                            Console.WriteLine("- " + i + " " + storeItem[i - 1]);
                        }
                        Console.WriteLine();
                        userChoice = UserAct("0. 나가기");

                        if (int.Parse(userChoice) <= storeItem.Count && int.Parse(userChoice) > 0)
                        {
                            if ((storeItem[(int.Parse(userChoice)) - 1]).Contains("구매완료") == true)
                            {
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                                Console.Clear();
                                goto ReBuy;
                            }
                            else
                            {
                                if (((storeItem[(int.Parse(userChoice)) - 1]).Contains("구매완료") == false) && (int.Parse((storeItem[(int.Parse(userChoice)) - 1].Substring(storeItem[(int.Parse(userChoice)) - 1].LastIndexOf("|") + 2)).Replace(" G", "")) <= userStat.Gold))
                                {
                                    userStat.Gold -= int.Parse((storeItem[(int.Parse(userChoice)) - 1].Substring(storeItem[(int.Parse(userChoice)) - 1].LastIndexOf("|") + 2)).Replace(" G", ""));
                                    userItem.Add(storeItem[(int.Parse(userChoice)) - 1].Replace((storeItem[(int.Parse(userChoice)) - 1].Substring(storeItem[(int.Parse(userChoice)) - 1].LastIndexOf("|"))), ""));
                                    storeItem[(int.Parse(userChoice)) - 1] = storeItem[(int.Parse(userChoice)) - 1].Replace((storeItem[(int.Parse(userChoice)) - 1].Substring(storeItem[(int.Parse(userChoice)) - 1].LastIndexOf("|"))), "[구매완료]");
                                    Console.WriteLine("구매를 완료했습니다.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReBuy;
                                }
                                else
                                {
                                    Console.WriteLine("Gold가 부족합니다.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    goto ReBuy;
                                }
                            }
                        }
                        else if (userChoice == "0")
                        {
                            Console.Clear();
                            Town();
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            Console.Clear();
                            goto ReBuy;
                        }

                    }
                    else if (userChoice == "0")
                    {
                        Town();
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadLine();
                    Console.Clear();
                    Town();
                }
            }


            while (nameFixed == false)
            {
                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 이름을 설정해주세요");
                Console.WriteLine();
                nameChosen = Console.ReadLine();
            ReName:
                Console.WriteLine();
                Console.WriteLine($"입력하신 이름은 {nameChosen} 입니다.");
                userChoice = UserAct("1. 저장", "2. 취소");

                if (userChoice == "1")
                {
                    userStat.UserName = nameChosen;
                    nameFixed = true;
                }


                if (userChoice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                    Console.WriteLine("원하시는 이름을 설정해주세요");
                    Console.WriteLine();
                    nameChosen = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine($"입력하신 이름은 {nameChosen} 입니다.");
                    userChoice = UserAct("1. 저장", "2. 취소");
                }


                if (userChoice != "1" && userChoice != "2")
                {
                    Console.Clear();
                    Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                    Console.WriteLine("원하시는 이름을 설정해주세요");
                    Console.WriteLine();
                    goto ReName;
                }

                Console.Clear();
            }


            // 직업 정하기
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 직업을 선택해주세요");
        ReClass:
            userChoice = UserAct("1. 전사", "2. 도적");

            if (userChoice == "1")
            {
                userStat.UserClass = "전사";
            }


            if (userChoice == "2")
            {
                userStat.UserClass = "도적";
            }


            if (userChoice != "1" && userChoice != "2")
            {
                Console.Clear();
                Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                Console.WriteLine("원하시는 직업을 선택해주세요");
                goto ReClass;
            }

            Console.Clear();

            Town();
        }
    }
}

