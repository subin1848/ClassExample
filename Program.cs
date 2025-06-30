using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public int varibale = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void MethodO()
            {
                Console.WriteLine("부모의 메서드");
            }

            public void CountParent()
            {
                Parent.counter++;
            }

            public Parent()
            {
                Console.WriteLine("Parent()");
            }
            public Parent(String name)
            {
                Console.WriteLine("Parent(string name)");
            }
            public Parent(int param)
            {
                Console.WriteLine("Parent(int param)");
            }
            public Parent(double param)
            {
                Console.WriteLine("Parent(double param)");
            }
        }

        class Child : Parent
        {
            public new string varibale = "hiding";      // 자식에도 똑같은 것이 있으니 상속 x

            public new void Method()    // new의 위치 주의!
            {

                Console.WriteLine("자식의 메서드");
            }
            public override void MethodO()    // new의 위치 주의!
            {

                Console.WriteLine("자식의 메서드");
            }
            public void CountChild()
            {
                Child.counter++;
            }

            public Child() : base("child")
            {
                Console.WriteLine("자식 생성자");
            }

            public Child(string name) : base(name)
            {
                Console.WriteLine("Child(string name)");
            }

            public Child(int param) : base(param)
            {
                Console.WriteLine("Child(int param)");
            }

            public Child(double param) : base(param)
            {
                Console.WriteLine("Child(double param)");
            }
        }

        public static int number = 10;


        static void Main(string[] args)
        {

            // 셰도잉
            int number = 20;
            Console.WriteLine(number);  // 20, 클래스 변수 이름이 가려짐(Shadowing)
            Console.WriteLine(Program.number);  // 10, 호출하고 싶으면 클래스 변수명으로 사용

            Child childA = new Child("abc");
            Child childB = new Child(3);
            // int(4) < long(8) < float(4) < double(8) 

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

            // 변수 하이딩
            Child child3 = new Child();
            Console.WriteLine(child3.varibale);         // 문자열 variable 출력
            Console.WriteLine(((Parent)child3).varibale);   // 숫자 variable 출력

            // 메서드 하이딩
            child3.Method();        // 자식의 메소드 출력
            ((Parent)child3).Method();      // 부모의 메소드 출력

            // 메서드 오버라이딩
            child3.MethodO();        // 자식의 메소드 출력
            ((Parent)child3).MethodO();      // 자식의 메소드 출력
        }

    }
}
