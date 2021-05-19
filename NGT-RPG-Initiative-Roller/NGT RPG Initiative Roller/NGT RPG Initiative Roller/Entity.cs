using System;
using System.Collections.Generic;
using System.Text;

namespace NGT_RPG_Initiative_Roller
{
  class Entity
  {
    public string Name { get; set; }
    public int Initiative { get; set; }

    public bool PlayerWin { get; set; }
  }
}