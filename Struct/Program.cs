using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{

    // valueType:-we can directly initialize the value, 
    //it is assing the value directly,valuetype is drived from System .ValueType, int float short,
    //it is directly containt the data, valuetype always stored in stack memory
    // this is all value type, it is faster
    //when we are calling by value in called method it will not reflect by caller method
    //refrence Type:-refrence is assing to another memory, refrence type variable stored in heap memmory,
    //refrence type is referces the memory, refrence type example is object, DynamicKeyword, Var , string is refrence type
    //it is slower
    //when we calling by 
    //it is drived from System.Object
    //when we are calling by value in called method it will  refleact by caller method

    class Program//Struct:-Struct also a value type then struct is inheriting from system.ValueType. It is also called as structure.
    //when we have to decleared struct we have to use struct keyword 
    //we can declear insied the method 
    //it inheriting from system .ValueType
    // we can not decleare default constructor in struct 
    //we can declear parameterized constractor ,we can also create the object 
    // we can't used inheritence 
    //struct are used small amount of data
    //we can also make the non-static and static method insied the structore

    {
        public Program(int i , int j)
        {
        }

        static void Main(string[] args)
        {
            Program p1 = new Program(19,29);//we can't call default constractore
            int i = 10;
            long j = 100;
            string k = "abcd";//refrencetype string is class
        }
    }
    public struct student
    {
        public void sum()
        {
            Console.WriteLine("I am from Sum ");
        }
        public static string GetName(string fn, string ln)
        {
            return fn + ln;  
        }
        public student (int i, int j)
        {

        }
        // we can't inherit the struct it is value type
        //we can't make default constructor.
        //we can make default object
        //we can make the static and non-static method.
       

    }
}
