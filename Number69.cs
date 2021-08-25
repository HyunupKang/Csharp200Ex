using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Number69
{
    // 필드를 public으로 선언하면 원치 않게 클래스 외부에서 값을 바꿀 수 있기 때문에 캡슐화 원칙에 위배
    // 따라서 일반적으로 private로 선언하는데, 
    // 이러면 외부에서 접근할 수 없으므로 public 메소드를 사용해서 값을 가져오거나 바꿀 수 있게 함

    // 일반작으로 값을 가져오는 메소드를 겟터, 설정하는 메소드를 셋터라고 함.
    // 문제는 필드마다 겟터와 셋터를 사용하게 되면 코드가 너무 길어짐

    // 그래서 속성을 이용. 속성은 겟터와 셋터를 손쉽게 만들 수 있는 방법
    // get, set, value 라는 키워드가 사용. 

    class Rectangle // // 속성을 사용하지 않은 클래스의 정의. width 필드에 대해 GetWidth(),SetWidth(double)의 겟터, 셋터 메소드가 필요.
    {
        private double width;
        private double height;

        public double GetWidth() // Getter
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetWidth(double width) // Setter
        {
            if (width > 0)
                this.width = width;  // 매개변수의 이름이 필드의 이름과 같은 경우, 매개변수와 필드를 구분해주기 위한 this키워드 필요. this는 '이 클래스'를 의미
        }

        public void SetHeight(double height)
        {
            if (height > 0)
                this.height = height;
        }
    }

    class RectWithProp // 속성을 사용한 클래스 정의.
    {
        public double Width { get; set; } // Width 속성
        public double Height { get; set; } // Height 속성 

    }

    class RectWithPropFull // 속성을 사용한 클래스 정의. 위 클래스보다 길지만, 예외 처리 가능
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; } // value 키워드는 r2.Width = 10;과 같이 셋터에 사용되는 값을 의미
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { if (value >= 0) height = value; }
        }
    }
    class PropertyTest
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(); 
            r.SetHeight(10.0);
            r.SetWidth(10.0);
            Console.WriteLine("r의 면적은 {0}", r.GetWidth() * r.GetWidth()); // r의 면적은 100

            RectWithProp r1 = new RectWithProp();
            r1.Width = 10.0;// 속성 사용
            r1.Height = 10.0;
            Console.WriteLine("r1의 면적은 {0}", r1.Width * r1.Height); // r1의 면적은 100


            RectWithPropFull r2 = new RectWithPropFull();
            r2.Width = 10.0; // 속성 사용
            r2.Height = 10.0;
            Console.WriteLine("r2의 면적은 {0}", r2.Width * r2.Height); // r2의 면적은 100

            RectWithPropFull r3 = new RectWithPropFull();
            r3.Width = 10.0;// 속성 사용
            r3.Height = -10.0;
            Console.WriteLine("r3의 면적은 {0}", r3.Width * r3.Height); // r3의 면적은 0
        }
    }
}