namespace DiggersAndFliers {
  public class Terrapin : ISwim {
    public string Name { get; set; }
    public bool Swim { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} turtle, is basking.");
    }
  }
}