namespace Hisenberg;


[Serializable]
public class Input
{
    public string? name { get; set; }
    public int age { get; set; }

    public int quntyMETH { get; set; }

    public Input() { }
    public Input(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.quntyMETH = quntyMETH;
    }
}