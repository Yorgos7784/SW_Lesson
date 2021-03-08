using adressTest0218.util;
using System;
using System.Collections.Generic;

namespace adressTest0218.control
{
    class StudentCtrl
    {
        public const int MENU_UPDATE_NAME = 1;
        public const int MENU_UPDATE_TEL = 2;
        public const int MENU_UPDATE_ADDR = 3;
        public const int MENU_UPDATE_EMAIL = 4;
        public const int MENU_UPDATE_EXIT = 5;

        //static StudentCtrl inst;
        List<Student> addrList = new List<Student>();
        RandomData rand;

        //public static StudentCtrl getInst()
        //{
        //    if (inst == null)
        //    {
        //        inst = new StudentCtrl();
        //    }
        //    return inst;
        //}

        public StudentCtrl()
        {
            rand = new RandomData();
        }

        public List<Student> getList()
        {
            return addrList;
        }

        public void addItem()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();
            addrList.Add(new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine("ID: " + addrList[i].Id);
                Console.WriteLine("이름: " + addrList[i].Name);
                Console.WriteLine("전화: " + addrList[i].Tel);
                Console.WriteLine("주소: " + addrList[i].Address);
                Console.WriteLine("이메일: " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }

        public void delItem(string name)
        {
            //Console.Write("삭제할 이름 입력 : ");
            //string name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }
        }

        public void delItem(string name, string tel)
        {
            //Console.Write("삭제할 이름 입력 : ");
            //string name = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name) && tel.Equals(addrList[i].Tel))
                {
                    addrList.RemoveAt(i--);
                }
            }
        }

        public void delItemAll()
        {
            addrList.Clear();
        }

        public void randData(int num)
        {
            for (int i = 0; i < num; i++)
            {
                addrList.Add(new Student(rand.getId(), rand.getName(), rand.getTel(), rand.getAddr(), rand.getEmail()));
            }
        }

        public void updateItem(int num, string name, string tel, string addr, string email)
        {
            addrList[num].Name = name;
            addrList[num].Tel = tel;
            addrList[num].Address = addr;
            addrList[num].Email = email;
        }

        public int counter(string name)
        {
            int count = 0;
            for (int i = 0; i < addrList.Count; i++)
            {
                if (name == addrList[i].Name)
                    count++;
            }
            return count;
        }
    }
}