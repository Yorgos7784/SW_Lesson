using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentInfo_control_20210219
{
    class Program
    {
        const string MENU_ADD_ITEM = "1";
        const string MENU_VIEW_ITEM = "2";
        const string MENU_FIX_ITEM = "3";
        const string MENU_DEL_ITEM = "4";
        const string MENU_EXIT = "5";

        static void Main(string[] args)
        {
            List<model.Student> members = controller.StudentHandler.returnMembers();
            while (true)
            {
                switch (controller.StudentHandler.getMenu())
                {
                    case MENU_ADD_ITEM:
                        controller.StudentHandler.addItemMenu();
                        break;
                    case MENU_VIEW_ITEM:
                        // 주소록이 비어있을때
                        if (members.Count() < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 정보가 없습니다.");
                            break;
                        }
                        else
                        {
                            controller.StudentHandler.viewMenu();
                            break;
                        }
                    case MENU_FIX_ITEM:
                        // 주소록이 비어있을때
                        if (members.Count() < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 정보가 없습니다.");
                            break;
                        }
                        else
                        {
                            controller.StudentHandler.fixItemMenu();
                            break;
                        }
                    case MENU_DEL_ITEM:
                        // 주소록이 비어있을때
                        if (members.Count() < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("주소록 정보가 없습니다.");
                            break;
                        }
                        else
                        {
                            controller.StudentHandler.deleteItemMenu();
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
    }
}
