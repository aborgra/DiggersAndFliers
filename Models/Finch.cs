namespace DiggersAndFliers {
  public class Finch : IFly {
    public string Name { get; set; }
    public bool Fly { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} bird, is flying.");
    }
  }
}