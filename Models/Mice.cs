namespace DiggersAndFliers {
  public class Mice : IMove {
    public string Name { get; set; }
    public bool Move { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} mouse, is eating.");
    }
  }
}