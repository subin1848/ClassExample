﻿using System;

namespace ClassExample
{
    public class Cat : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("고양이가 사료를 먹습니다.");
        }
    }
}