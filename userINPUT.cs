namespace Hisenberg;


[Serializable]
public class Input
{
    public string? name { get; set; }
    public int age { get; set; }

    public int quntyMETH { get; set; }
    public int price { get; set; }

    public Input() { }
    public Input(string name, int age, int quntyMETH, int price)
    {
        this.name = name;
        this.age = age;
        this.quntyMETH = quntyMETH;
        this.price = price;
    }

}