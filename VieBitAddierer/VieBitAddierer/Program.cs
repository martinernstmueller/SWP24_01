static void Main()
{

}
public class FourBitAdd
{
   public (bool s, bool c) HalfAdding(bool x, bool y)
    {
        var res1 = !x && y;
        var res2 = x && !y;
        var s = res1 || res2;
        var c = x && y;
        return (s, c);
    }

    public (bool s, bool cOut) FullAdding(bool a0, bool b0, bool ue)
    {
        var res1 = HalfAdding(b0, ue);
        var res2 = HalfAdding(a0, res1.s);
        return (res2.s, res1.c || res2.c);
    }

    public void  a(out int testInt)
    {
        testInt = 42;
    }
    //public int Add(int x, int y)
    //{

    //}
}
