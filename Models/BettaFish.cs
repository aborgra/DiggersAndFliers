namespace DiggersAndFliers {
  public class BettaFish : ISwim {
    public string Name { get; set; }
    public bool Swim { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    public override string ToString () {
      return ($"{Name}, the {Color} fish, is swimming.");
    }
  }
}