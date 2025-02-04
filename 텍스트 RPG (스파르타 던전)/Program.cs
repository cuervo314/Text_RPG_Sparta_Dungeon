using System;
using System.Runtime.InteropServices;

namespace 텍스트_RPG__스파르타_던전_
{
    internal class Program
    {
        //유저 스탯 클래스
        public class UserStat
        {
            public int Lv { get; set; }
            public string UserName { get; set; }
            public string UserClass { get; set; }
            public int Atk { get; set; }
            public int Def { get; set; }
            public int Health { get; set; }
            public float Gold { get; set; }
        }

        //선택 함수(스탯)
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
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요");
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

        //선택 함수(마을)
        static string UserAct(string first, string second, string third, string fourth, string fifth)
        {
            string userChoice = null;
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요");
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
            userStat.Atk = 10;
            userStat.Def = 5;
            userStat.Health = 100;
            userStat.Gold = 21500;
            int atkChange = 0;
            int defChange = 0;

            //아이템 관련
            float[] storeItemCost = new float[10];
            storeItemCost[0] = 1000;
            storeItemCost[1] = 2250;
            storeItemCost[2] = 3500;
            storeItemCost[3] = 600;
            storeItemCost[4] = 1500;
            storeItemCost[5] = 2400;
            storeItemCost[6] = 1800;
            storeItemCost[7] = 400;
            storeItemCost[8] = 1650;

            List<string> userItem = new List<string>();
            List<int> userItemDefStat = new List<int>();
            List<int> userItemAtkStat = new List<int>();
            List<float> userItemCost = new List<float>();

            int[] storeItemDefStat = new int[10];
            storeItemDefStat[0] = 5;
            storeItemDefStat[1] = 9;
            storeItemDefStat[2] = 15;
            storeItemDefStat[3] = 0;
            storeItemDefStat[4] = 0;
            storeItemDefStat[5] = 0;
            storeItemDefStat[6] = 3;
            storeItemDefStat[7] = 2;
            storeItemDefStat[8] = 5;

            int[] storeItemAtkStat = new int[10];
            storeItemAtkStat[0] = 0;
            storeItemAtkStat[1] = 0;
            storeItemAtkStat[2] = 0;
            storeItemAtkStat[3] = 2;
            storeItemAtkStat[4] = 5;
            storeItemAtkStat[5] = 7;
            storeItemAtkStat[6] = 2;
            storeItemAtkStat[7] = 0;
            storeItemAtkStat[8] = 8;

            List<string> storeItem = new List<string>();
            storeItem.Add($"수련자 갑옷 | 방어력 +{storeItemDefStat[0]} | 수련에 도움을 주는 갑옷입니다. | {1000} G");
            storeItem.Add($"무쇠갑옷 | 방어력 +{storeItemDefStat[1]} | 무쇠로 만들어져 튼튼한 갑옷입니다. | {2250} G");
            storeItem.Add($"스파르타의 갑옷 | 방어력 +{storeItemDefStat[2]} | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | {3500} G");
            storeItem.Add($"낡은 검 | 공격력 +{storeItemAtkStat[3]} | 쉽게 볼 수 있는 낡은 검입니다. | {600} G");
            storeItem.Add($"청동 도끼 | 공격력 +{storeItemAtkStat[4]} | 어디선가 사용됐던 것 같은 도끼입니다. | {1500} G");
            storeItem.Add($"스파르타의 창 | 공격력 +{storeItemAtkStat[5]} | 스파르타의 전사들이 사용했다는 전설의 창입니다. | {2400} G");
            storeItem.Add($"원형 방패 | 방어력 +{storeItemDefStat[6]}, 공격력 +{storeItemAtkStat[6]} | 방패만으로 싸우던 사내가 있었습니다. | {1800} G");
            storeItem.Add($"스파르타의 투구 | 방어력 +{storeItemDefStat[7]} | 갑옷은 없어도 투구는 써야 합니다. | {400} G");
            storeItem.Add($"나무 활과 화살 | 방어력 -{storeItemDefStat[8]}, 공격력 +{storeItemAtkStat[8]} | 때로는 공격이 최선의 방어입니다. | {1650} G");

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

            void Town()
            {
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

                        int num;

                        if (!int.TryParse(userChoice, out num))
                        {
                            Console.Clear();
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
                                
                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }


                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                
                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
                                {
                                    userStat.Atk += userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange += userItemAtkStat[int.Parse(userChoice) - 1];
                                }

                            }
                            else
                            {
                                userItem[int.Parse(userChoice) - 1] = userItem[int.Parse(userChoice) - 1].Insert(0, "[E]");

                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 +")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                
                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk += userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange += userItemAtkStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def -= userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange -= userItemDefStat[int.Parse(userChoice) - 1];
                                }
                                
                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
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
                        Console.Clear();
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
                        Console.WriteLine();
                        userChoice = UserAct("0. 나가기");

                        int num;

                        if (!int.TryParse(userChoice, out num))
                        {
                            Console.Clear();
                            goto ReBuy;
                        }

                        if (int.Parse(userChoice) <= storeItem.Count && int.Parse(userChoice) > 0)
                        {
                            if ((storeItem[int.Parse(userChoice) - 1]).Contains("구매완료") == true)
                            {
                                Console.WriteLine("이미 구매한 아이템입니다.");
                                Console.ReadLine();
                                Console.Clear();
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
                            goto ReMarket;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            Console.Clear();
                            goto ReBuy;
                        }

                    }
                    //판매
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

                        Console.WriteLine();
                        userChoice = UserAct("0. 나가기");
                        //수정 중
                        int num;

                        if (!int.TryParse(userChoice, out num))
                        {
                            Console.Clear();
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

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }


                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
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

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 +")) == true)
                                {
                                    userStat.Atk -= userItemAtkStat[int.Parse(userChoice) - 1];
                                    atkChange -= userItemAtkStat[int.Parse(userChoice) - 1];
                                }


                                if ((userItem[int.Parse(userChoice) - 1].Contains("방어력 -")) == true)
                                {
                                    userStat.Def += userItemDefStat[int.Parse(userChoice) - 1];
                                    defChange += userItemDefStat[int.Parse(userChoice) - 1];
                                }

                                if ((userItem[int.Parse(userChoice) - 1].Contains("공격력 -")) == true)
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
                            Console.Clear();
                            goto ReMarket;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadLine();
                            Console.Clear();
                            goto ReSell;
                        }
                        //수정 중
                    }
                    else if (userChoice == "0")
                    {
                        Console.Clear();
                        Town();
                    }
                    else
                    {
                        Console.Clear();
                        goto ReMarket;
                    }
                }
                //던전입장
                else if (userChoice == "4")
                {

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
                        Console.Clear();
                        Town();
                    }
                    else
                    {
                        Console.Clear();
                        goto ReRest;
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

