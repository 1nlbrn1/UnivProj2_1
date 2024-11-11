using System;
public class Logus {
    protected bool alpha;
    protected bool beta;
    public bool Alpha { get { return alpha; } set { alpha = value; } }
    public bool Beta { get { return beta; } set { beta = value; } }

    public Logus() {
        alpha = false;
        beta = false;
    }
    public Logus(bool alpha, bool beta) {
        this.alpha = alpha;
        this.beta = beta;
    }
    public Logus(Logus L) {
        this.alpha = L.alpha;
        this.beta = L.beta;
    }
    public bool ekviv() {
        return this.alpha == this.beta;
    }
    public new string ToString()
    {
        return "Alpha = " + this.alpha + " Beta = " + this.beta;
    }
}
public class Implication : Logus {
    private bool result;
    private bool isresset;
    public bool Result;
    public bool Isresset { get; }
    public Implication() : base() { isresset = false; }
    public Implication(bool alpha, bool beta) : base(alpha, beta) { isresset = false; }
    public Implication(Implication im) {
        this.alpha = im.alpha;
        this.beta = im.beta;
        this.result = im.result;
        this.isresset = im.isresset;
    }
    public new string ToString() {
        if(isresset == false) {
            return "Alpha = " + this.alpha + " Beta = " + this.beta + " Result is not set";
        }
        return "Alpha = " + this.alpha + " Beta = " + this.beta + " Result = " + this.result;
    }
    public bool CalcAndGetRes() {
        isresset = true;
        if (alpha == true && beta == false) {
            result = false;
            return false;
        }
        result = true;
        return true;
    }
    public string AlphaPossibilities() {
        if(Isresset == false) {
            return "Result is not set";
        }
        if(Beta == false && result == false) {
            return "Alpha = true";
        }
        if(Beta == false && result == true) {
            return "Alpha = false";
        }
        if(Beta == true) {
            return "Alpha = true or false";
        }
        return "Alpha = true";
    }
    public string BetaPossibilities() {
        if(Isresset == false) {
            return "Result is not set";
        }
        if(Alpha == true && result == false) {
            return "Beta = false";
        }
        if(Alpha == true) {
            return "Alpha = true or false";
        }
        return "Alpha = true";
    }
}
public static class MainClass {
    public static void Main(string[] args) {
        Console.WriteLine("");
        Logus l = new Logus();
        Console.WriteLine("Logus().ToString:");
        Console.WriteLine(l.ToString());
        Console.WriteLine("");

        Console.WriteLine("Alpha set true -> Logus().ToString:");
        l.Alpha = true;
        Console.WriteLine(l.ToString());
        Console.WriteLine("");

        Console.WriteLine("Beta set true -> Logus().ToString:");
        l.Beta = true;
        Console.WriteLine(l.ToString());
        Console.WriteLine("");

        Console.WriteLine("Logus.Alpha:");
        Console.WriteLine(l.Alpha);
        Console.WriteLine("");

        Console.WriteLine("Logus.Beta:");
        Console.WriteLine(l.Beta);
        Console.WriteLine("");

        Logus l1 = new Logus(true, true);
        Console.WriteLine("Logus1(true, true).ToString:");
        Console.WriteLine(l1.ToString());
        Console.WriteLine("");

        Logus l2 = new Logus(l1);
        Console.WriteLine("Logus2(Logus1).ToString:");
        Console.WriteLine(l1.ToString());
        Console.WriteLine("");

        Console.WriteLine("Logus2(Logus1).ekviv: " + l2.ekviv());
        Console.WriteLine("Logus().ekviv: " + l.ekviv());
        Console.WriteLine("");

        Implication imp = new Implication(true, false);
        //Console.WriteLine(im.CalcAndGetRes());
        Console.WriteLine(imp.Result);
    }

}
