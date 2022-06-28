using System.Collections;
interface IData<T>
{
    public int Count { get; set; }
    public int maxsize { get; set; }
    public T[] elements { get; set; }
}
class mystack<T> : IEnumerable, IData<T>
{

    public T[] elements { get; set; }
    public int Count { get; set; }
    public int maxsize { get; set; }
    public delegate bool x(T k);
    public mystack(int maxsize, int count)
    {
        elements = new T[maxsize];
        this.maxsize = maxsize;
        Count = Count;
    }
    public T top
    {
        get { return elements[Count - 1]; }
        set { elements[Count - 1] = value; }

    }
    public IEnumerator GetEnumerator()
    {
        for (int i = elements.Length - 1; i >= 0; i--)
        {
            yield return elements[i];
        }

    }
    public void push(T x)
    {
        if (Count < maxsize)
        {


            Count++;
            elements[Count - 1] = x;
            // Console.WriteLine("the operation was done successfully");


        }
        else
        {
            Console.WriteLine("you cant add to the array.");
        }
    }
    public T pop()
    {
        if (Count >= 1)
        {

            T last = elements[Count - 1];
            elements.SkipLast(1);

            Count--;
            return last;


            //T last = elements.Last();
            //elements.SkipLast(1);
            //return last;

        }
        else
        {
            T last = elements.Last();
            Console.WriteLine("you cant delete .");
            return last;
        }
    }
    public void clear()
    {
        Array.Clear(elements, 0, Count);
        // Console.WriteLine(elements[Count-1]);
        Count = 0;
    }
    public string print(x name)
    {
        string a = "";
        List<T> list = new List<T>();
        while (Count > 0)
        {
            T poshte = pop();
            if (name(poshte) == true)
            {
                a += poshte + " ";
            }
            list.Add(poshte);

        }
        for (int i = list.Count - 1; i >= 0; i--)
        {
            push(list[i]);
        }
        return a;
    }
}
class program
{
    public static void Main()
    {
        string marhale1 = "";
        int count = 0;
        Console.WriteLine("enter tha max size of the array:");
        int maxsize = int.Parse(Console.ReadLine());
        mystack<int> y = new mystack<int>(maxsize, count);
        do
        {


            Console.WriteLine("menu\npush\npop\ntop\nprint\nclear\nexit");
            marhale1 = Console.ReadLine();

            if (marhale1 == "push")
            {

                Console.WriteLine("enter the number to add:");
                int x = int.Parse(Console.ReadLine());

                // count++;
                y.push(x);

            }
            if (marhale1 == "pop")
            {

                Console.WriteLine("the last number of the array is:");
                //mystack<int> y = new mystack<int>(maxsize, x);
                Console.WriteLine(y.pop());
            }
            else if (marhale1 == "clear")
            {
                y.clear();
            }
            else if (marhale1 == "top")
            {
                Console.WriteLine("the last item is:" + y.top);
            }
            else if (marhale1 == "print")
            {

                Console.WriteLine("even numbers are:" + y.print(x => x % 2 == 0));
                Console.WriteLine("odd numbers are:" + y.print(x => x % 2 != 0));
                Console.WriteLine("all numbers are:" + y.print(x => x % 2 == 0 || x % 2 != 0));

            }
        } while (marhale1 != "exit");
    }
}

