namespace dz22_11_2
{
    abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Президент: Керує всією компанією");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Охоронець: Відповідає за безпеку працівників");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Менеджер: Керує проектами");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Інженер: Розробляє");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
               
                Worker[] workers = new Worker[]
                {
            new President(),
            new Security(),
            new Manager(),
            new Engineer()
                };

                
                foreach (Worker worker in workers)
                {
                    worker.Print();
                }
            }
        }
    }
}
