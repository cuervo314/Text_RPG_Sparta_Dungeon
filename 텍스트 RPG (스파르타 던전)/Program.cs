using System;
using System.Runtime.InteropServices;

namespace 텍스트_RPG__스파르타_던전_
{
    //클래스와 함수를 최대한 사용해보고 싶었지만 그렇지 못 했습니다. 강의 후반부의 고급 문법들도 아직 숙달하지 못 했습니다.
    //그래서 코드가 비효율적이고 가독성이 떨어지는 것 같습니다. 그렇기에 예외 처리 같은 다른 영역에 신경을 좀 썼습니다.
    //감사합니다.
    internal class Program
    {
        //유저 스탯 클래스
        public class UserStat
        {
            public int Lv { get; set; }
            public string UserName { get; set; }
            public string UserClass { get; set; }
            public float Atk { get; set; }
            public int Def { get; set; }
            public int Health { get; set; }
            public float Gold { get; set; }
        }

        // 던전 권장 방어도
        public class DefNeeded
        {
            public int Easy;
            public int Normal;
            public int Hard;
        }


        //선택 함수(스탯, 던전 클리어)
        static string UserAct(string first)
        {
            string userChoice = null;
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }

        //선택 함수(이름, 직업)
        static string UserAct(string first, string second)
        {
            string userChoice = null;
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine($"{second}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            userChoice = Console.ReadLine();
            return userChoice;
        }

        //선택 함수(상점)
        static string UserAct(string first, string second, string third)
        {
            string userChoice = null;
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine($"{second}");
            Console.WriteLine($"{third}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }

        //선택 함수(던전)
        static string UserAct(string first, string second, string third, string fourth)
        {
            string userChoice = null;
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine($"{second}");
            Console.WriteLine($"{third}");
            Console.WriteLine($"{fourth}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }

        //선택 함수(마을)
        static string UserAct(string first, string second, string third, string fourth, string fifth)
        {
            string userChoice = null;
            Console.WriteLine();
            Console.WriteLine($"{first}");
            Console.WriteLine($"{second}");
            Console.WriteLine($"{third}");
            Console.WriteLine($"{fourth}");
            Console.WriteLine($"{fifth}");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            userChoice = Console.ReadLine();
            Console.Clear();
            return userChoice;
        }

        //게임 실행
        static void Main(string[] args)
        {
            //초기 스탯
            UserStat userStat = new UserStat();
            userStat.UserName = null;
            userStat.Lv = 01;
            userStat.Atk = 10f;
            userStat.Def = 5;
            userStat.Health = 100;
            userStat.Gold = 1500;
            int atkChange = 0;
            int defChange = 0;

            //아이템 관련
            List<int> storeItemCost = new List<int>();
            storeItemCost.Add(1000);
            storeItemCost.Add(2250);
            storeItemCost.Add(3500);
            storeItemCost.Add(600);
            storeItemCost.Add(1500);
            storeItemCost.Add(2400);
            storeItemCost.Add(1800);
            storeItemCost.Add(400);
            storeItemCost.Add(1650);

            List<string> userItem = new List<string>();
            List<int> userItemDefStat = new List<int>();
            List<int> userItemAtkStat = new List<int>();
            List<float> userItemCost = new List<float>();

            List<int> storeItemDefStat = new List<int>();
            storeItemDefStat.Add(5);
            storeItemDefStat.Add(9);
            storeItemDefStat.Add(15);
            storeItemDefStat.Add(0);
            storeItemDefStat.Add(0);
            storeItemDefStat.Add(0);
            storeItemDefStat.Add(3);
            storeItemDefStat.Add(2);
            storeItemDefStat.Add(5);

            List<int> storeItemAtkStat = new List<int>();
            storeItemAtkStat.Add(0);
            storeItemAtkStat.Add(0);
            storeItemAtkStat.Add(0);
            storeItemAtkStat.Add(2);
            storeItemAtkStat.Add(5);
            storeItemAtkStat.Add(7);
            storeItemAtkStat.Add(2);
            storeItemAtkStat.Add(0);
            storeItemAtkStat.Add(8);

            List<string> storeItem = new List<string>();
            storeItem.Add($"수련자 갑옷 | 방어력 +{storeItemDefStat[0]} | 수련에 도움을 주는 갑옷입니다. | {storeItemCost[0]} G");
            storeItem.Add($"무쇠갑옷 | 방어력 +{storeItemDefStat[1]} | 무쇠로 만들어져 튼튼한 갑옷입니다. | {storeItemCost[1]} G");
            storeItem.Add($"스파르타의 갑옷 | 방어력 +{storeItemDefStat[2]} | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | {storeItemCost[2]} G");
            storeItem.Add($"낡은 검 | 공격력 +{storeItemAtkStat[3]} | 쉽게 볼 수 있는 낡은 검입니다. | {storeItemCost[3]} G");
            storeItem.Add($"청동 도끼 | 공격력 +{storeItemAtkStat[4]} | 어디선가 사용됐던 것 같은 도끼입니다. | {storeItemCost[4]} G");
            storeItem.Add($"스파르타의 창 | 공격력 +{storeItemAtkStat[5]} | 스파르타의 전사들이 사용했다는 전설의 창입니다. | {storeItemCost[5]} G");
            storeItem.Add($"원형 방패 | 방어력 +{storeItemDefStat[6]}, 공격력 +{storeItemAtkStat[6]} | 방패만으로 싸우던 사내가 있었습니다. | {storeItemCost[6]} G");
            storeItem.Add($"스파르타의 투구 | 방어력 +{storeItemDefStat[7]} | 갑옷은 없어도 투구는 써야 합니다. | {storeItemCost[7]} G");
            storeItem.Add($"나무 활과 화살 | 방어력 -{storeItemDefStat[8]}, 공격력 +{storeItemAtkStat[8]} | 때로는 공격이 최선의 방어입니다. | {storeItemCost[8]} G");

            string userChoice;

            string nameChosen;
            bool nameFixed = false;

            //스탯 확인 함수
            void ShowStat()
            {
                string userChoice = null;
                Console.WriteLine("Lv. " + userStat.Lv);
                Console.WriteLine(userStat.UserName + " ( " + userStat.UserClass + " )");

                if (atkChange == 0)
                {
                    if (defChange == 0)
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk);
                        Console.WriteLine("방어력 : " + userStat.Def);
                    }
                    else if (defChange > 0)
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk);
                        Console.WriteLine("방어력 : " + userStat.Def + $" (+{defChange})");
                    }
                    else
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk);
                        Console.WriteLine("방어력 : " + userStat.Def + $" ({defChange})");
                    }
                }
                else if (atkChange > 0)
                {
                    if (defChange == 0)
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk + $" (+{atkChange})");
                        Console.WriteLine("방어력 : " + userStat.Def);
                    }
                    else if (defChange > 0)
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk + $" (+{atkChange})");
                        Console.WriteLine("방어력 : " + userStat.Def + $" (+{defChange})");
                    }
                    else
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk + $" (+{atkChange})");
                        Console.WriteLine("방어력 : " + userStat.Def + $" ({defChange})");
                    }
                }
                else
                {
                    if (defChange == 0)
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk + $" ({atkChange})");
                        Console.WriteLine("방어력 : " + userStat.Def);
                    }
                    else if (defChange > 0)
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk + $" ({atkChange})");
                        Console.WriteLine("방어력 : " + userStat.Def + $" (+{defChange})");
                    }
                    else
                    {
                        Console.WriteLine("공격력 : " + userStat.Atk + $" ({atkChange})");
                        Console.WriteLine("방어력 : " + userStat.Def + $" ({defChange})");
                    }
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

            //던전
            void DungeonClear(string dungeon, int defNeeded, int reward)
            {
                Random random = new Random();
                int healthDecrease = random.Next(20, 36) - userStat.Def + defNeeded;
                if (userStat.Health-healthDecrease <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("던전 공략 실패...");
                    Console.WriteLine($"{dungeon} 공략에 실패했습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[탐험 결과]");
                    Console.WriteLine($"체력 {userStat.Health} -> 0");
                    Console.WriteLine();
                    Console.WriteLine("당신은 사망하였습니다");
                    Console.WriteLine($"{userStat.UserName}의 이름은 기억될 것입니다.");
                    Console.Read();
                    Environment.Exit(0);
                }
                else if (userStat.Def < defNeeded)
                {                    
                    int success = random.Next(0, 100);                    
                    int bonus = reward * random.Next((int)userStat.Atk, (int)userStat.Atk * 2 + 1) / 100;
                    int goldChange = reward + bonus;

                    if (success >= 40)
                    {
                        Console.Clear();
                        Console.WriteLine("던전 클리어");
                        Console.WriteLine("축하합니다!!");
                        Console.WriteLine($"{dungeon}을 클리어 하였습니다.");
                        Console.WriteLine();
                        Console.WriteLine("[탐험 결과]");
                        Console.WriteLine($"체력 {userStat.Health} -> {userStat.Health - healthDecrease}");
                        userStat.Health -= healthDecrease;
                        Console.WriteLine($"Gold {userStat.Gold} G -> {userStat.Gold + goldChange} G");
                        userStat.Gold += goldChange;
                        Console.WriteLine($"레벨 Lv{userStat.Lv} -> Lv{userStat.Lv + 1}");
                        userStat.Lv++;
                        Console.WriteLine($"공격력 {userStat.Atk} + 0.5, 방어력 {userStat.Def} + 1");
                        userStat.Atk += 0.5f;
                        userStat.Def++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("던전 공략 실패...");
                        Console.WriteLine($"{dungeon} 공략에 실패했습니다.");
                        Console.WriteLine();
                        Console.WriteLine("[탐험 결과]");
                        Console.WriteLine($"체력 {userStat.Health} -> {userStat.Health/2}");
                        userStat.Health /= 2;
                    }
                }
                else if (userStat.Def == defNeeded)
                {
                    int success = random.Next(0, 100);
                    int bonus = reward * random.Next((int)userStat.Atk, (int)userStat.Atk * 2 + 1) / 100;
                    int goldChange = reward + bonus;

                    if (success >= 20)
                    {
                        Console.Clear();
                        Console.WriteLine("던전 클리어");
                        Console.WriteLine("축하합니다!!");
                        Console.WriteLine($"{dungeon}을 클리어 하였습니다.");
                        Console.WriteLine();
                        Console.WriteLine("[탐험 결과]");
                        Console.WriteLine($"체력 {userStat.Health} -> {userStat.Health - healthDecrease}");
                        userStat.Health -= healthDecrease;
                        Console.WriteLine($"Gold {userStat.Gold} G -> {userStat.Gold + goldChange} G");
                        userStat.Gold += goldChange;
                        Console.WriteLine($"레벨 Lv{userStat.Lv} -> Lv{userStat.Lv + 1}");
                        userStat.Lv++;
                        Console.WriteLine($"공격력 {userStat.Atk} + 0.5, 방어력 {userStat.Def} + 1");
                        userStat.Atk += 0.5f;
                        userStat.Def++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("던전 공략 실패...");
                        Console.WriteLine($"{dungeon} 공략에 실패했습니다.");
                        Console.WriteLine();
                        Console.WriteLine("[탐험 결과]");
                        Console.WriteLine($"체력 {userStat.Health} -> {userStat.Health / 2}");
                        userStat.Health /= 2;
                    }
                }
                else
                {
                    int bonus = reward * random.Next((int)userStat.Atk, (int)userStat.Atk * 2 + 1) / 100;
                    int goldChange = reward + bonus;
                    Console.Clear();
                    Console.WriteLine("던전 클리어");
                    Console.WriteLine("축하합니다!!");
                    Console.WriteLine($"{dungeon}을 클리어 하였습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[탐험 결과]");
                    Console.WriteLine($"체력 {userStat.Health} -> {userStat.Health - healthDecrease}");
                    userStat.Health -= healthDecrease;
                    Console.WriteLine($"Gold {userStat.Gold} G -> {userStat.Gold + goldChange} G");
                    userStat.Gold += goldChange;
                    Console.WriteLine($"레벨 Lv{userStat.Lv} -> Lv{userStat.Lv + 1}");
                    userStat.Lv++;
                    Console.WriteLine($"공격력 {userStat.Atk} + 0.5, 방어력 {userStat.Def} + 1");
                    userStat.Atk += 0.5f;
                    userStat.Def++;
                }
            }

            // 마을 행동
            void Town()
            {
                Console.Clear();
                string userChoice = null;
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                userChoice = UserAct("1. 상태 보기", "2. 인벤토리", "3. 상점", "4. 던전입장", "5. 휴식하기");

                //스탯 확인
                if (userChoice == "1")
                {
                    ShowStat();
                }
                //인벤토리
                else if (userChoice == "2")
                {
                ReItem:
                    Console.Clear();
                    Console.WriteLine("인벤토리");
                    Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");

                    foreach (string item in userItem)
                    {
                        Console.WriteLine("- " + item);
                    }

                    userChoice = UserAct("1. 장착 관리", "0. 나가기");
                    //장착 관리
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
                            Town();
                        }

                        int num;

                        if (!int.TryParse(userChoice, out num))
                        {                            
                            goto ReManage;
                        }
                                                
                        if (int.Parse(userChoice) <= userItem.Count)
                        {
                            if ((userItem[int.Parse(userChoice) - 1]).Contains("[E]") == true)
                            {
                                userItem[int.Parse(userChoice) - 1] = userItem[int.Parse(userChoice) - 1].Remove(0, 3);

                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 +")) == true)
                                {                                    
                                    userStat.Def -= userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange -= userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
                                {
                                    userStat.Atk += userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange += userItemAtkStat[int.Parse(userChoice) - 1];
                                }

                            }
                            else
                            {
                                userItem[int.Parse(userChoice) - 1] = userItem[int.Parse(userChoice) - 1].Insert(0, "[E]");     

                                if (userItem[int.Parse(userChoice) - 1].Contains("공격력"))
                                {
                                    for (int i = 0; i < userItem.Count; i++)
                                    {
                                        if (userItem[i].Contains("[E]") && userItem[i].Contains("공격력") && userItem[i] != userItem[int.Parse(userChoice) - 1])
                                        {
                                            userItem[i] = userItem[i].Remove(0, 3);

                                            if ((userItem[i].Contains("방어력 +")) == true)
                                            {
                                                userStat.Def -= userItemDefStat[i];
                                                defChange -= userItemDefStat[i];
                                            }
                                            else if ((userItem[i].Contains("방어력 -")) == true)
                                            {
                                                userStat.Def += userItemDefStat[i];
                                                defChange += userItemDefStat[i];
                                            }

                                            if ((userItem[i].Contains("공격력 +")) == true)
                                            {
                                                userStat.Atk -= userItemAtkStat[i];
                                                atkChange -= userItemAtkStat[i];
                                            }
                                            else if ((userItem[i].Contains("공격력 -")) == true)
                                            {
                                                userStat.Atk += userItemAtkStat[i];
                                                atkChange += userItemAtkStat[i];
                                            }

                                        }
                                    }
                                }
                                else if (userItem[int.Parse(userChoice) - 1].Contains("방어력"))
                                {
                                    for (int i = 0; i < userItem.Count; i++)
                                    {
                                        if (userItem[i].Contains("[E]") && userItem[i].Contains("방어력") && !userItem[i].Contains("공격력") && userItem[i] != userItem[int.Parse(userChoice) - 1])
                                        {
                                            userItem[i] = userItem[i].Remove(0, 3);
                                            Console.WriteLine(userItem[i]);


                                            if ((userItem[i].Contains("방어력 +")) == true)
                                            {
                                                userStat.Def -= userItemDefStat[i];
                                                defChange -= userItemDefStat[i];
                                            }
                                            else if ((userItem[i].Contains("방어력 -")) == true)
                                            {
                                                userStat.Def += userItemDefStat[i];
                                                defChange += userItemDefStat[i];
                                            }

                                            if ((userItem[i].Contains("공격력 +")) == true)
                                            {
                                                userStat.Atk -= userItemAtkStat[i];
                                                atkChange -= userItemAtkStat[i];
                                            }
                                            else if ((userItem[i].Contains("공격력 -")) == true)
                                            {
                                                userStat.Atk += userItemAtkStat[i];
                                                atkChange += userItemAtkStat[i];
                                            }

                                        }
                                    }
                                }
                                

                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 +")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def -= userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange -= userItemDefStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk += userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange += userItemAtkStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }
                            }

                            goto ReManage;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            goto ReManage;
                        }
                    }
                    else if (userChoice == "0")
                    {
                        Town();
                    }
                    else
                    {
                        goto ReItem;
                    }
                }
                //상점
                else if (userChoice == "3")
                {
                    ReMarket:
                    Console.Clear();
                    Console.WriteLine("상점");
                    Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                    Console.WriteLine();
                    Console.WriteLine("[보유 골드]");
                    Console.WriteLine(userStat.Gold + " G");
                    Console.WriteLine();
                    Console.WriteLine("[아이템 목록]");

                    foreach (string item in  storeItem)
                    {                        
                        Console.WriteLine("- " + item);
                    }

                    userChoice = UserAct("1. 아이템 구매", "2. 아이템 판매", "0. 나가기");
                    // 아이템 구매
                    if (userChoice == "1")
                    {
                        ReBuy:
                        Console.Clear();
                        Console.WriteLine("상점 - 아이템 구매");
                        Console.WriteLine("필여한 아이템을 얻을 수 있는 상점입니다.");
                        Console.WriteLine();
                        Console.WriteLine("[보유 골드]" + " G");
                        Console.WriteLine(userStat.Gold);
                        Console.WriteLine();
                        Console.WriteLine("[아이템 목록]");

                        for (int i = 1; i <= storeItem.Count; i++)
                        {
                            Console.WriteLine("- " + i + " " + storeItem[i - 1]);
                        }
                        userChoice = UserAct("0. 나가기");

                        int num;

                        if (!int.TryParse(userChoice, out num))
                        {
                            goto ReBuy;
                        }

                        if (int.Parse(userChoice) <= storeItem.Count && int.Parse(userChoice) > 0)
                        {
                            if ((storeItem[int.Parse(userChoice) - 1]).Contains("구매완료") == true)
                            {
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                                goto ReBuy;
                            }
                            else
                            {
                                if (((storeItem[int.Parse(userChoice) - 1]).Contains("구매완료") == false) && (int.Parse((storeItem[int.Parse(userChoice) - 1].Substring(storeItem[int.Parse(userChoice) - 1].LastIndexOf("|") + 2)).Replace(" G", "")) <= userStat.Gold))
                                {
                                    userStat.Gold -= storeItemCost[int.Parse(userChoice) - 1];
                                    userItem.Add(storeItem[int.Parse(userChoice) - 1].Replace((storeItem[int.Parse(userChoice) - 1].Substring(storeItem[int.Parse(userChoice) - 1].LastIndexOf("|"))), ""));
                                    userItemDefStat.Add(storeItemDefStat[int.Parse(userChoice) - 1]);
                                    userItemAtkStat.Add(storeItemAtkStat[int.Parse(userChoice) - 1]);
                                    userItemCost.Add(storeItemCost[int.Parse(userChoice) - 1]);
                                    storeItem[int.Parse(userChoice) - 1] = storeItem[int.Parse(userChoice) - 1].Replace($"{storeItemCost[int.Parse(userChoice) - 1]} G", "[구매완료]");
                                    Console.WriteLine("구매를 완료했습니다.");
                                    Console.ReadLine();
                                    goto ReBuy;
                                }
                                else
                                {
                                    Console.WriteLine("Gold가 부족합니다.");
                                    Console.ReadLine();
                                    goto ReBuy;
                                }
                            }
                        }
                        else if (userChoice == "0")
                        {
                            goto ReMarket;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            goto ReBuy;
                        }

                    }
                    //아이템 판매
                    else if (userChoice == "2")
                    {
                        ReSell:
                        Console.Clear();
                        Console.WriteLine("상점 - 아이템 판매");
                        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                        Console.WriteLine();
                        Console.WriteLine("[보유 골드]");
                        Console.WriteLine(userStat.Gold + " G");
                        Console.WriteLine();
                        Console.WriteLine("[아이템 목록]");

                        for (int i = 0; i < userItem.Count; i++)
                        {
                                Console.WriteLine("- " + userItem[i] + "| " + userItemCost[i] * 0.8 + " G");
                        }

                        userChoice = UserAct("0. 나가기");

                        int num;

                        if (!int.TryParse(userChoice, out num))
                        {
                            goto ReSell;
                        }

                        if (int.Parse(userChoice) <= userItem.Count && int.Parse(userChoice) > 0)
                        {
                            if ((userItem[int.Parse(userChoice) - 1]).Contains("[E]") == true)
                            {
                                userItem[int.Parse(userChoice) - 1] = userItem[int.Parse(userChoice) - 1].Remove(0, 3);

                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 +")) == true)
                                {
                                    userStat.Def -= userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange -= userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
                                {
                                    userStat.Atk += userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange += userItemAtkStat[int.Parse(userChoice) - 1];
                                }

                                userItem.Remove(userItem[int.Parse(userChoice) - 1]);
                                userStat.Gold += userItemCost[int.Parse(userChoice) - 1] * 0.80f;
                                userItemCost.Remove(userItemCost[int.Parse(userChoice) - 1]);
                                userItemDefStat.Remove(userItemDefStat[int.Parse(userChoice) - 1]);
                                userItemAtkStat.Remove(userItemAtkStat[int.Parse(userChoice) - 1]);

                                goto ReSell;
                            }
                            else
                            {
                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 +")) == true)
                                {
                                    userStat.Def -= userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange -= userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }
                                else if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
                                {
                                    userStat.Atk += userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange += userItemAtkStat[int.Parse(userChoice) - 1];
                                }

                                userItem.Remove(userItem[int.Parse(userChoice) - 1]);
                                userStat.Gold += userItemCost[int.Parse(userChoice) - 1] * 0.80f;
                                userItemCost.Remove(userItemCost[int.Parse(userChoice) - 1]);
                                userItemDefStat.Remove(userItemDefStat[int.Parse(userChoice) - 1]);
                                userItemAtkStat.Remove(userItemAtkStat[int.Parse(userChoice) - 1]);

                                goto ReSell;
                            }
                        }
                        else if (userChoice == "0")
                        {
                            goto ReMarket;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            goto ReSell;
                        }
                    }
                    else if (userChoice == "0")
                    {
                        Town();
                    }
                    else
                    {
                        goto ReMarket;
                    }
                }
                //던전입장
                else if (userChoice == "4")
                {
                    ReDungeon:
                    Console.Clear();
                    Console.WriteLine("던전입장");
                    Console.WriteLine("당신은 진정한 스파르타의 전사입니까?");
                    userChoice = UserAct("1. 쉬운 던전 | 방어력 6 이상 권장", "2. 일반 던전 | 방어력 12 이상 권장", "3. 어려운 던전 | 방어력 19 이상 권장", "0. 나가기");

                    if (userChoice == "1")
                    {
                        DungeonClear("쉬운 던전", 6, 1000);
                        userChoice = UserAct("0. 나가기");

                        Town();
                    }
                    else if (userChoice == "2")
                    {
                        DungeonClear("일반 던전", 12, 1700);
                        userChoice = UserAct("0. 나가기");

                        Town();
                    }
                    else if (userChoice == "3")
                    {
                        DungeonClear("어려운 던전", 19, 2500);
                        userChoice = UserAct("0. 나가기");

                        Town();
                    }
                    else if (userChoice == "0")
                    {
                        Town();
                    }
                    else
                    {
                        goto ReDungeon;
                    }

                }
                //휴식하기
                else if (userChoice == "5")
                {
                    ReRest:
                    Console.Clear();
                    Console.WriteLine("휴식하기");
                    Console.WriteLine($"500 G를 내면 체력을 회복할 수 있습니다. (보유 골드 : {userStat.Gold} G)");
                    userChoice = UserAct("1. 휴식하기", "0. 나가기");

                    if (userChoice == "1")
                    {
                        if (userStat.Gold >= 500)
                        {
                            Console.Clear();
                            Console.WriteLine("휴식을 완료했습니다.");
                            userStat.Gold -= 500;
                            userStat.Health = 100;
                            Console.ReadLine();
                            goto ReRest;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Gold가 부족합니다.");
                            Console.ReadLine();
                            goto ReRest;
                        }
                    }
                    else if (userChoice == "0")
                    {
                        Town();
                    }
                    else
                    {
                        goto ReRest;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.ReadLine();
                    Town();
                }
            }

            // 이름 생성
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

                    if (userChoice == "1")
                    {
                        userStat.UserName = nameChosen;
                        nameFixed = true;
                    }
                }


                if (userChoice != "1" && userChoice != "2")
                {
                    Console.Clear();
                    Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                    Console.WriteLine("원하시는 이름을 설정해주세요");
                    Console.WriteLine();
                    goto ReName;
                }

            }


        // 직업 정하기
        ReClass:
            Console.Clear ();
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 직업을 선택해주세요");            
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
                goto ReClass;
            }
            Town();
        }
    }
}

