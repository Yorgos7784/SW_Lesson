using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_20210218
{
    class MemberInfo
    {
        private string name;
        private string tel;
        private string address;
        private string email;
        private static MemberInfo inst;

        public static MemberInfo getInst()
        {
            if (inst == null)
            {
                inst = new MemberInfo();
            }
            return inst;
        }

        public MemberInfo()
        {

        }

        public MemberInfo(string name, string tel, string address, string email)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        /*public void showMemberInfo()
        {
            Console.WriteLine("----- 학생 정보 -----");
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화번호 : " + tel);
            Console.WriteLine("주소 : " + address);
            Console.WriteLine("이메일 : " + email);
            Console.WriteLine("---------------------");
        }*/
        
        /*public MemberInfo()
        {
            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();
            Console.Write("전화번호를 입력하세요 : ");
            tel = Console.ReadLine();
            Console.Write("주소를 입력하세요 : ");
            address = Console.ReadLine();
            Console.Write("이메일을 입력하세요 : ");
            email = Console.ReadLine();
        }*/

    }
}
