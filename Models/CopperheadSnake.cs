namespace DiggersAndFliers {
  public class CopperheadSnake : IMove {
    public string Name { get; set; }
    public bool Move { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} snake, is slithering.");
    }
  }
}