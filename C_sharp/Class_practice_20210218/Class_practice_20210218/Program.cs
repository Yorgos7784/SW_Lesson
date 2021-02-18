using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_practice_20210218
{
    class Program
    {
        const string MENU_ADD_ITEM = "1";
        const string MENU_VIEW_ITEM = "2";
        const string MENU_FIX_ITEM = "3";
        const string MENU_DEL_ITEM = "4";
        const string MENU_EXIT = "5";

        const string VIEW_ONE = "1";
        const string VIEW_ALL = "2";
        const string VIEW_GOBACK = "3";

        const string ADD_SELF = "1";
        const string ADD_RND = "2";
        const string ADD_GOBACK = "3";

        const string DEL_SCH = "1";
        const string DEL_ALL = "2";
        const string DEL_GOBACK = "3";

        const string FIX_NAME = "1";
        const string FIX_TEL = "2";
        const string FIX_ADD = "3";
        const string FIX_EMAIL = "4";
        const string FIX_GOBACK = "5";

        static List<MemberInfo> members = new List<MemberInfo>();
        //static MemberInfo member;
        static void Main(string[] args)
        {
            Random r = new Random();
            //member = MemberInfo.getInst();
            while (true)
            {
                switch (getMenu())
                {
                    case MENU_ADD_ITEM:
                        addItemMenu(r);
                        break;
                    case MENU_VIEW_ITEM:
                        if (members.Count() < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 정보가 없습니다.");
                            break;
                        }
                        else
                        {
                            viewMenu();
                            break;
                        }
                    case MENU_FIX_ITEM:
                        if (members.Count() < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 정보가 없습니다.");
                            break;
                        }
                        else
                        {
                            fixItemMenu();
                            break;
                        }
                    case MENU_DEL_ITEM:
                        if (members.Count() < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 정보가 없습니다.");
                            break;
                        }
                        else
                        {
                            deleteItemMenu();
                            break;
                        }
                    case MENU_EXIT:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }
        }

        public static string getMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 주소록 관리 프로그램 v1.0");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 주소록 정보 수정");
            Console.WriteLine("4. 주소록 정보 삭제");
            Console.WriteLine("5. 종료");
            Console.WriteLine("---------------------------");
            Console.Write("메뉴 선택 : ");
            return Console.ReadLine();
        }

        public static void addItemMenu(Random r)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 주소록 정보 추가");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 직접 입력하기");
                Console.WriteLine("2. 랜덤 정보 추가");
                Console.WriteLine("3. 뒤로가기");
                Console.WriteLine("---------------------------");
                Console.Write("메뉴 선택 : ");

                switch (Console.ReadLine())
                {
                    case ADD_SELF:
                        addItem();
                        break;
                    case ADD_RND:
                        addRandomItem(r);
                        break;
                    case ADD_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하였습니다.");
                        break;

                }
            }
        }

        public static void addItem()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 주소록 정보 입력");
            Console.WriteLine("---------------------------");
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화번호 : ");
            string tel = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();
            Console.Write("이메일 : ");
            string email = Console.ReadLine();
            members.Add(new MemberInfo(name, tel, address, email));
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");

        }

        public static void addRandomItem(Random r)
        {
            string[] lastName = { "김", "이", "박", "최", "강" };
            string[] firstName1 = { "춘", "덕", "광", "미", "용" };
            string[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙" };
            string[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
            string[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
            string[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };
            string fullname;
            string tel;
            string email;

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.Write("추가할 주소록 수량을 입력하세요 : ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                fullname = lastName[r.Next(0, lastName.Length)] + firstName1[r.Next(0, firstName1.Length)] + firstName2[r.Next(0, firstName2.Length)];
                tel = "010 - " + Convert.ToString(r.Next(1000, 10000)) + " - " + Convert.ToString(r.Next(1000, 10000));
                email = emailId[r.Next(0, emailId.Length)] + emailadd[r.Next(0, emailadd.Length)];
                members.Add(new MemberInfo(fullname, tel, address[r.Next(0, address.Length)], email));
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("추가되었습니다!");
        }

        public static void viewMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 주소록 정보 탐색");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 주소록 선택하기");
                Console.WriteLine("2. 전체 보기");
                Console.WriteLine("3. 뒤로가기");
                Console.WriteLine("---------------------------");
                Console.Write("메뉴 선택 : ");

                switch (Console.ReadLine())
                {
                    case VIEW_ONE:
                        while (true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 길이 : " + members.Count);
                            Console.Write("보고싶은 주소록 번호를 입력해주세요 : ");
                            int show = Convert.ToInt32(Console.ReadLine());
                            if (show > members.Count)
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("없는 정보입니다. 다시 입력해 주세요");
                                continue;
                            }
                            else
                            {
                                if (members[show - 1].Name != null && members[show - 1].Tel != null && members[show - 1].Address != null && members[show - 1].Email != null)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine(show + "번 학생 정보");
                                    viewItem(members[show - 1]);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine("없는 정보입니다. 다시 입력해 주세요");
                                }
                            }
                        }
                        break;
                    case VIEW_ALL:
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (members[i].Name != null && members[i].Tel != null && members[i].Address != null && members[i].Email != null)
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine((i + 1) + "번 학생 정보");
                                viewItem(members[i]);
                            }
                        }
                        break;
                    case VIEW_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하였습니다.");
                        break;

                }
            }
        }

        public static void viewItem(MemberInfo member)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("이름 : " + member.Name);
            Console.WriteLine("전화번호 : " + member.Tel);
            Console.WriteLine("주소 : " + member.Address);
            Console.WriteLine("이메일 : " + member.Email);
            Console.WriteLine("---------------------------");
        }

        public static void deleteItemMenu()
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name != null && members[i].Tel != null && members[i].Address != null && members[i].Email != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(i + 1 + "번 학생 정보");
                    viewItem(members[i]);
                }
            }
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 주소록 정보 삭제");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 검색하여 삭제");
                Console.WriteLine("2. 전체 삭제");
                Console.WriteLine("3. 뒤로가기");
                Console.WriteLine("---------------------------");
                Console.Write("메뉴 선택 : ");

                switch (Console.ReadLine())
                {
                    case DEL_SCH:
                        deleteItem();
                        break;
                    case DEL_ALL:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("모든 정보를 삭제하시겠습니까?(y/n) : ");
                        string delCheck = Console.ReadLine();
                        if (delCheck == "y")
                        {
                            members.Clear();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("삭제되었습니다.");
                        }
                        else if (delCheck == "n")
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("취소되었습니다.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("잘못 입력하셨습니다.");
                        }
                        break;
                    case DEL_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하였습니다.");
                        break;
                }
            }
        }

        public static void deleteItem()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.Write("삭제할 학생의 이름을 입력하세요(돌아가기 : -1) : ");
                string input = Console.ReadLine();
                if (input == "-1")
                    return;
                else
                {
                    bool checkContains = false;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (input == members[i].Name)
                        {
                            checkContains = true;
                            break;
                        }
                        else
                            checkContains = false;
                    }
                    if (checkContains == true)
                    {
                        int count = 0;
                        int numcopy = 0;
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (input == members[i].Name)
                            {
                                count++;
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine((i + 1) + "번 학생 정보");
                                viewItem(members[i]);
                                numcopy = i;
                            }

                        }
                        if (count == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.Write("정보를 삭제 하시겠습니까?(y/n) : ");
                            string delCheck = Console.ReadLine();
                            if (delCheck == "y")
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(members[numcopy].Name + "의 정보를 삭제 했습니다.");
                                members[numcopy].Name = null;
                                members[numcopy].Tel = null;
                                members[numcopy].Address = null;
                                members[numcopy].Email = null;
                            }
                            else if (delCheck == "n")
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("취소되었습니다.");
                            }
                            return;
                        }
                        else
                        {
                            Console.Write("몇번을 삭제하시겠습니까? : ");
                            int delnum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine(delnum + "번 학생 정보");
                            viewItem(members[delnum - 1]);
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.Write("정보를 삭제 하시겠습니까?(y/n) : ");
                            string delCheck = Console.ReadLine();
                            if (delCheck == "y")
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine(members[delnum - 1].Name + "의 정보를 삭제 했습니다.");
                                members[delnum - 1].Name = null;
                                members[delnum - 1].Tel = null;
                                members[delnum - 1].Address = null;
                                members[delnum - 1].Email = null;
                            }
                            else if (delCheck == "n")
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------------");
                                Console.WriteLine("취소되었습니다.");
                            }
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine(input + "의 정보가 없습니다.");
                    }
                }
            }
        }

        public static void fixItemMenu()
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Name != null && members[i].Tel != null && members[i].Address != null && members[i].Email != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(i + 1 + "번 학생 정보");
                    viewItem(members[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.Write("수정할 학생의 이름을 입력하세요(돌아가기 : -1) : ");
            string input = Console.ReadLine();
            if (input == "-1")
                return;
            else
            {
                bool checkContains = false;
                for (int i = 0; i < members.Count; i++)
                {
                    if (input == members[i].Name)
                    {
                        checkContains = true;
                        break;
                    }
                    else
                        checkContains = false;
                }
                if (checkContains == true)
                {
                    int count = 0;
                    int numcopy = 0;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (input == members[i].Name)
                        {
                            count++;
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine((i + 1) + "번 학생 정보");
                            viewItem(members[i]);
                            numcopy = i;
                        }
                    }
                    if (count == 1)
                    {
                        fixItem(members[numcopy]);
                        return;
                    }
                    else
                    {
                        Console.Write("몇번을 수정하시겠습니까? : ");
                        int fixnum = Convert.ToInt32(Console.ReadLine());
                        fixItem(members[fixnum - 1]);
                        return;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(input + "의 정보가 없습니다.");
                }
            }
        }

        public static void fixItem(MemberInfo member)
        {
            Console.WriteLine();
            viewItem(member);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine(" 주소록 정보 수정");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. 이름");
                Console.WriteLine("2. 전화번호");
                Console.WriteLine("3. 주소");
                Console.WriteLine("4. 이메일");
                Console.WriteLine("5. 돌아가기");
                Console.WriteLine("---------------------------");
                Console.Write("메뉴 선택 : ");

                switch (Console.ReadLine())
                {
                    case FIX_NAME:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 이름을 입력하세요 : ");
                        member.Name = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member);
                        break;
                    case FIX_TEL:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 전화번호를 입력하세요 : ");
                        member.Tel = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member);
                        break;
                    case FIX_ADD:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 주소를 입력하세요 : ");
                        member.Address = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member);
                        break;
                    case FIX_EMAIL:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.Write("수정할 이메일을 입력하세요 : ");
                        member.Email = Console.ReadLine();
                        Console.WriteLine();
                        viewItem(member);
                        break;
                    case FIX_GOBACK:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            }

        }
    }
}