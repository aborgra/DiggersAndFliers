namespace DiggersAndFliers {
  public class Gerbil : IMove {
    public string Name { get; set; }
    public bool Move { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} gerbil, is sleeping.");
    }
  }
}