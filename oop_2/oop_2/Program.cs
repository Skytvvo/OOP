using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace oop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - type of data
            //a)
            bool booleanType = false;
            byte byteType = 100;
            sbyte sbyteType = -100;
            char charType = 'c';
            decimal decimalType = 1.2222222m;
            double doubleType = 1.333;
            float floatType = 1.4444f;
            int intType = 22000;
            uint uintType = 4000000000;
            long longType = 99999999999;
            ulong ulongType = 999999999999;
            short shortType = 1000;
            ushort ushortType = 10000;

            dynamic dynType = 1.22f;
            string strType = "some text";
            object objT = strType;

            Console.WriteLine("types:"+booleanType+' '+ byteType + ' ' + 
                sbyteType + ' ' + charType + ' ' + decimalType + ' ' + doubleType + ' ' +
                floatType + ' ' + intType + ' ' + uintType + ' ' + longType + ' ' + 
                ulongType + ' ' + shortType + ' ' + ushortType);
            //b)
            //explicit conversion
            int floatToInt = (int)floatType;
            short byteToShort = (short)byteType;
            uint intToUint = (uint)intType;
            long intToLong = (long)intType;
            ulong ushortToUlong = (ulong)ushortType;

            //implicit conversions
            int shortToInt = shortType;
            double intToDouble = intType;
            decimal doubleToDecimal = uintType;
            float ulongToFloat = ulongType;
            long charToLong = charType;

            //System.convert
            double longToDouble = System.Convert.ToDouble(longType);
            decimal doubleToDecim = System.Convert.ToDecimal(doubleType);

            //c)
            //boxing bool to obj
            object objType = intType;

            //unboxing
            int anothertInt = (int)objType;

            //d)
            var num1 = 100;
            num1++;
            Console.WriteLine("var = " + num1);

            //e)
            int? nullVar = null;

            //f)
            var someType = 1;
            //someType = 1.2;

            //2 - string

            //a)
            string str = "some text";

            string strHello = "Hello";
            string strWorld = "Wordl";
            string sign = "!";

            //use +,+= or concat 
            string helloWorld = strHello +' '+ strWorld +' '+ sign;
            Console.WriteLine(helloWorld);
            
            //copy string
            string copied = String.Copy(strWorld);
            Console.WriteLine("Copy: " + copied);
            
            //receive substring
            copied = helloWorld.Substring(3, 8);
            Console.WriteLine("Substring: " + copied);
            
            //split string
            string[] words = helloWorld.Split(' ');
            
            //insert 
            string newStr = helloWorld.Insert(5,copied);
            Console.WriteLine("Insert " + newStr);
            
            //delete - user str.Remove(Start,End)
            helloWorld = helloWorld.Remove(2, 5);
            Console.WriteLine("Removed str: " + helloWorld);

            //string interpolation
            string userName = "Sky2";
            string realName = "Ilya";
            string userData = $"Name of PC: {userName}, owner: {realName}";
            Console.WriteLine(userData);

            string nullStr = null;

            Console.WriteLine("This string is null:" + string.IsNullOrEmpty(nullStr));

            nullStr = "";

            Console.WriteLine("This string empty:" + string.IsNullOrEmpty(nullStr));

            //stringbuilder
            StringBuilder strbuild = new StringBuilder("some text");
            
            //remove 2 sym from 2 position
            strbuild.Remove(2, 2);
            
            //str.Append - add str to the end
            strbuild.Append("|end|");

            //str.Insert - add str to the begin
            strbuild.Insert(0,"|begin|");

            Console.WriteLine(strbuild);

            //3 - array
            //a)
            int[,] matrix = new int[,] { { 1, 1, 1 }, { 2, 2, 2 },  {1, 1, 1 } };
            ushort sizeOf1DArr = (ushort)Math.Sqrt(matrix.Length);
            for (int i = 0; i < sizeOf1DArr;i++)
            {
                for(int j = 0; j < sizeOf1DArr;j++ )
                {
                    Console.Write(" "+matrix[i,j]);
                }
                Console.Write("\n\n");
            }

            //b)
            string[] strArr = { "HOME", "wasd", "ggwp", "desert", "oceon", "Lucky" };
            int sizeOfUserStrs = strArr.Length;

            foreach(string word in strArr)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Size of array: " + strArr.Length+"\n\n");

            int userPosInput;

            do
            {
                Console.WriteLine($"Enter number of position in array which you want to change(0-{sizeOfUserStrs}): ");
                userPosInput = Convert.ToInt32(Console.ReadLine());
            } while (userPosInput < 0 || userPosInput > sizeOfUserStrs);

            Console.WriteLine("Enter word:");

            string tempStr = Console.ReadLine();

            strArr[userPosInput] = tempStr;

            //c)
            float[][] floatArr = new float[3][];
            floatArr[0] = new float[2];
            floatArr[1] = new float[3];
            floatArr[2] = new float[4];

            for(int i = 0; i < floatArr.Length; i++)
            {
                for(int j = 0; j < floatArr[i].Length; j++)
                {
                    Console.WriteLine($"Enter value for {i + 1} arr in {j} position:");
                    floatArr[i][j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            //d)
            var variableSpace = new object[2]
            {
                "string", new int[2]{ 2, 3 }
            };

            //4 - Tuples

            //a)
            (int integer, string str1, char sym, string str2, ulong ulongNum) tuple = (-222,"string 1", 'R', "another string", 50000);

            //b)
           /* Console.WriteLine($"int:{tuple.integer}\n" +
                $"str 1: {tuple.str1}\n" +
                $"char: {tuple.sym}\n" +
                $"str 2: {tuple.str2}\n" +
                $"ulong: {tuple.ulongNum}\n");
            string strTemp; 
            
            or */
            Console.WriteLine(tuple);

            Console.WriteLine(tuple.Item1 + " or " + tuple.integer);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
            
            //c)
            (int unboxInt, string unboxString) unpackedTuple = (22, "some text");
            var (unboxedInt, unboxedString) = unpackedTuple;
            // or (var unboxedInt, var unboxedString) = unpackedTuple; 
            // or (int unboxedInt, string unboxedString) = unpackedTuple;
            //or use existing vars
            Console.WriteLine(unboxedInt + ' ' + unboxedString);

            (_, var notIgnoredVar, _, _, _) = tuple; // _ - empty variable

            //d)
            (int integer, string str1, char sym, string str2, ulong ulongNum) tuple2 = tuple;
            Console.WriteLine(tuple2 == tuple);
            Console.WriteLine(tuple2 != tuple);

            //5 - local function

            int[] numbers = { 2, 3, 4, 5, 6, 7, 8 }; 

            (int,int,int,char) getTuple (int[] numbers, string str){

                return (numbers.Max(), numbers.Min(), numbers.Sum(), str[0]);
                
            }

            (int, int, int, char) newTuple = getTuple(numbers, helloWorld);
            Console.WriteLine(newTuple);

            //6 - checked/unchecked

            void checkedFunction()
            {
                checked
                {
                    int max = int.MaxValue;
                    //  max++;
                    Console.WriteLine(max);
                }
            }

            void uncheckedFunction()
            {
                unchecked
                {
                    int max = int.MaxValue +  1;
                    Console.WriteLine(max);
                }
            }

            checkedFunction();
            uncheckedFunction();
        }
    }
}
