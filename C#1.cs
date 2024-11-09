using System;
    public class Logus
    {
        bool Alpha;
        bool Beta;
        public Logus()
        {
            Alpha = false;
            Beta = false;
        }
        public Logus(bool alpha, bool beta)
        {
            Alpha = alpha;
            Beta = beta;
        }
        public Logus(Logus L)
        {
            this.Alpha = L.Alpha;
            this.Beta = L.Beta;
        }
        public bool ekviv()
        {
            return this.Alpha == this.Beta;
        }
        /*public new string ToString()
        {

        }
        */
    }
public static class MainClass
{
    public static Main()
    {

    }
}
