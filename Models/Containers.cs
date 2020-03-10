using System.Collections.Generic;

namespace DiggersAndFliers {
  public class Container {
    public List<IDig> Diggers = new List<IDig> ();
    public List<IMove> Movers = new List<IMove> ();
    public List<IFly> Fliers = new List<IFly> ();
    public List<ISwim> Swimmers = new List<ISwim> ();

  }
}