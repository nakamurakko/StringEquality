using System;

namespace StringEquality;

class Program
{
    static void Main(string[] args)
    {
        Case1();

        Case2();

        Case3();

        Case4();

        Case5();
    }

    /// <summary>
    /// ケース1。
    /// 
    /// ネットでよく見るパターン。
    /// stringとintを==演算子で比較するとビルドエラーになるから、
    /// Equalsではなく==演算子を使用した方が良いという主張。
    /// (==演算子で比較すればC#のタイプセーフの特性が活かせる、という事が結構書いてある。)
    /// 
    /// stringとintを正しく比較する方法を言及していない。
    /// </summary>
    public static void Case1()
    {
        string stringValue = "0";
        int intValue = 0;

        // stringとintを==演算子で比較するとビルドエラーになる。
        //Console.WriteLine(stringValue == intValue);
    }

    /// <summary>
    /// ケース2。
    /// 
    /// stringとobject型にボックス化したstringを==演算子で比較。
    /// </summary>
    public static void Case2()
    {
        string stringValue = "0";
        object objectValue = "0";

        // object型とstringの比較は警告が出るがビルドエラーにはならない。
        Console.WriteLine(stringValue == objectValue);
    }

    /// <summary>
    /// ケース3。
    /// 
    /// ケース2と似ているが、stringとobject型にボックス化したintegerを==演算子で比較。
    /// </summary>
    public static void Case3()
    {
        string stringValue = "0";
        object objectValue = 0;

        // object型とstringの比較は警告が出るがビルドエラーにはならない。
        Console.WriteLine(stringValue == objectValue);
    }

    /// <summary>
    /// ケース4。
    /// 
    /// ==演算子はstring.Equals(String, String)を呼んでいるため、
    /// 2つの比較は同じ動作。
    /// </summary>
    public static void Case4()
    {
        string stringValue1 = "0";
        string stringValue2 = "0";

        Console.WriteLine(stringValue1 == stringValue2);
        Console.WriteLine(string.Equals(stringValue1, stringValue2));
    }

    /// <summary>
    /// ケース5。
    /// 
    /// 連結した文字列を型キャストした場合、==演算子で一致しない。
    /// </summary>
    public static void Case5()
    {
        string a = "hello";
        string b = "h";
        // Append to contents of 'b'
        b += "ello";

        Console.WriteLine(a == b);
        Console.WriteLine((object)a == (object)b); // false

        Console.WriteLine(a.Equals(b));
        Console.WriteLine((object)a.Equals((object)b)); // true
    }
}
