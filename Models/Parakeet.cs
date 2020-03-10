namespace DiggersAndFliers {
  public class Parakeet : IFly {
    public string Name { get; set; }
    public bool Fly { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} parakeet, is flying.");
    }
  }
}