using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number65
{
    // Ŭ������ ������ : �Ҵ�� �޸� ������ ���� ������(��ü)�� ���� ����(�޸� �ּ�) ���� -> �׷��� �ݵ�� new Ű���带 ����Ͽ� ����
    //                   ���ÿ� ������ ��ġ�ϰ� ��
    // ����ü�� ���� : �Ҵ�� �޸� ������ ���� ���� ����
    //                 �޸��� ���� ������ ������ ���� ��

    struct DateStruct // ����ü�� �ַ� ���� �Ŀ� �������� �������� �����͸� �����ϴ� ���� ������ ������ ������
    {
        public int year, month, day; // ��� ������ �ʵ��� �θ�
    }
    class DateClass  // ������ �����̳� ��ü�� ���� �� �����Ϸ��� �����͸� �𵨸��ϴµ� ����
    {
        public int year, month, day;
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateStruct sDay; // ����ü�� Ŭ������ ��������� ������ �ν��Ͻ�, �� ��ü��� ��
            sDay.year = 2018; // ��ü�� �ʵ�� ��� ������(.)�� ����Ͽ� ����
            sDay.month = 11;
            sDay.day = 22;
            Console.WriteLine("sDay : {0}/{1}/{2}", sDay.year, sDay.month, sDay.day); // sDay: 2018 / 11 / 22

            DateClass cDay = new DateClass(); // new�� �ϸ� ��ü�� �ʵ尪�� ������ ������ �ʱ�ȭ �ǵ�
            cDay.year = 2018;
            cDay.month = 11;
            cDay.day = 22;
            Console.WriteLine("sDay : {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);  // sDay: 2018 / 11 / 22

            DateStruct sDay2 = new DateStruct();
            Console.WriteLine("sDay2 : {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day); // sDay2: 0 / 0 / 0

            DateClass cDay2 = new DateClass();
            Console.WriteLine("cDay2 : {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day); // cDay2: 0 / 0 / 0

            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2000;

            Console.WriteLine("s : {0}/{1}/{2}", s.year, s.month, s.day); // s: 2000 / 11 / 22
            Console.WriteLine("c : {0}/{1}/{2}", c.year, c.month, c.day); // c: 2000 / 11 / 22
            Console.WriteLine("sDay : {0}/{1}/{2}", sDay.year, sDay.month, sDay.day); // sDay: 2018 / 11 / 22
            Console.WriteLine("cDay : {0}/{1}/{2}", cDay.year, cDay.month, cDay.day); // cDay: 2000 / 11 / 22
        }
    }
}