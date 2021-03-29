using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynFksDiverseSkeleton
{
    public enum HeightPreset
    {
        Morrowind
        // later we can add different height presets. I.e Morrowind, oblivion, dagger fall. But we'd need to dump a height file for them.
    }
    class Settings
    {
        public HeightPreset Preset = HeightPreset.Morrowind;
    }
}
