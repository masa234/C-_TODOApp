using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_TodoApp2
{
    public class EnumValue
    {
        //ユーザ種類
        public enum UserType
        {
            Admin = 1,
            Normal = 2
        }


        //ロックされているか
        public enum IsLock
        {
            NotLock = 0,
            Locked = 1
        }


        //優先度
        public enum Priority
        {
            High = 1,
            Middle = 2,
            Low = 3
        }
    }
}
