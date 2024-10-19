namespace Make_Genaric_Queue
{
    internal class Program
    {
        //class queue
        //{
        //    int[] arr;
        //    int top, bottom;
        //    public queue(int size=10)
        //    {
        //        arr = new int[size];
        //        top=0;
        //        bottom=0;
        //    }
        //    public void push(int value)
        //    {
        //        if (top < arr.Length) 
        //        arr[top++] = value;
        //    }
        //    public int pop()
        //    {
        //        if(bottom < top)
        //            return arr[bottom++];
        //        return 0;
        //    }
        //}
        class queue<t>
        {
            t[] arr;
            int top, bottom;
            public queue(int size = 10)
            {
                arr = new t[size];
                top = 0;
                bottom = 0;
            }
            public void push(t value)
            {
                if (top < arr.Length)
                    arr[top++] = value;
            }
            public t pop()
            {
                if (bottom < top)
                    return arr[bottom++];
                return default(t);
            }
        }
        class question
        {
            public string questionbody { get; set; }
            public float mark { get; set; }
            public question(string questionbody=null,float mark=0)
            {
                this.questionbody= questionbody;
                this.mark=mark;
            }
            public override string ToString()
            {
                return $"{questionbody}?  ({mark})";
            }

        }
        class anser
        {
            public int num { get; set; }
            public string shoossetxt { get; set; }
            public anser(int num = 0, string shoossetxt = null)
            {
                this.shoossetxt = shoossetxt;
                this.num = num;
            }
            public override string ToString()
            {
                return $"{num} - {shoossetxt}";
            }

        }
        static void Main(string[] args)
        {
            #region Queue
            //queue<int> q=new queue<int>(5);
            //q.push(1);
            //q.push(25);
            //q.push(30);
            //q.pop();
            //Console.WriteLine(q.pop());
            //Console.WriteLine(q.pop()); Console.WriteLine(q.pop());
            #endregion
            #region Dictionary
            List<question> questions = new List<question>();
            questions.Add(new question("oop Stand for", 10));
            questions.Add(new question("C#", 9));
            questions.Add(new question("Qenaric", 7));
            questions.Add(new question("List", 8));
            foreach (var item in questions)
            {
                Console.WriteLine(item.ToString());
            }
            Dictionary<question,List<anser>> exam=new Dictionary<question,List<anser>>();
            exam.Add(new question("oop Stand for", 10), new List<anser> { 
                new anser(1,"oop"),
                 new anser(2,"C#"),
                  new anser(3,"qenaric"), new anser(4,"list"),
            } );
            exam.Add(new question("C#", 10), new List<anser> {
                new anser(1,"oop1"),
                 new anser(2,"C#2"),
                  new anser(3,"qenaric1"), new anser(4,"list1"),
            });
            foreach (var item in exam)
            {
                Console.WriteLine("Quesion  is ");

                Console.WriteLine(item.Key);
                Console.WriteLine("ansers  is ");
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine(item1.ToString());
                }
            }

            #endregion
        }
    }
}
