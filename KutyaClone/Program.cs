namespace KutyaClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "Hello";
            s = s.ToUpper();
            Console.WriteLine(s);
        }
    }

    class Kutya: ICloneable
    {
        String név; // immutable
        int lábakSzáma;
        String[] bolhaNevek;
        bool harapos;
        public Object Clone()
        {
            Kutya myClone = new Kutya();
            myClone.név = this.név;
            myClone.lábakSzáma = this.lábakSzáma;
            myClone.bolhaNevek = (String[])this.bolhaNevek.Clone();
            myClone.harapos = this.harapos;
            return myClone;
        }
    }
}
