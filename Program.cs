using System;

namespace arr_ay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input Rount:");//แสดงหน้าจอ
            int rount = (int)double.Parse(Console.ReadLine());//เก็บค่าลงตัวแปร rount 
            int[] inputRount = new int[rount];//สร้าง array age เก็บค่าที่ user ใส่เข้ามาจำนวนรอบ
            
            for (int i = 0; i < inputRount.Length; i++)//loop ตามจำนวนรอบที่ user ใส่มา
            {
                Console.Write("Input Age = ");//แสดงหน้าจอ
                int userInput = (int)double.Parse(Console.ReadLine());//เก็บค่าลงตัวแปร userInput
                inputRount[i] = userInput;//เอาค่าแต่ล่ะตัวใส่ใน index i
            }
            int result = 0;//สร้างตัวแปร result = 0
            for (int i = 0; i < inputRount.Length; i++)//loop ตามจำนวนรอบที่ user ใส่มา
            {
                result += inputRount[i];//เอาตัวเลขที่ user ใส่เข้ามาในแต่ล่ะรอบไปบวกกันแล้วไปเก็บในตัวแปร result
            }
            Console.WriteLine("Reslt Age = " + result);//แสดงผล
        }
    }
}
