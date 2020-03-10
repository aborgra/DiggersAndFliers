namespace DiggersAndFliers {
  public class Earthworm : IDig {
    public string Name { get; set; }
    public bool Dig { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} worm, is digging.");
    }
  }
}