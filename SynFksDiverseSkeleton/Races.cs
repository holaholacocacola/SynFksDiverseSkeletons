using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;


namespace SynFksDiverseSkeleton
{
    public static partial class Races
    {
        public static class AllowableRaces
        {
            public static readonly HashSet<FormLink<IRaceGetter>> formLinks = new HashSet<FormLink<IRaceGetter>>{
            Skyrim.Race.ArgonianRace,
            Skyrim.Race.BretonRace,
            Skyrim.Race.DarkElfRace,
            Skyrim.Race.HighElfRace,
            Skyrim.Race.ImperialRace,
            Skyrim.Race.KhajiitRace,
            Skyrim.Race.NordRace,
            Skyrim.Race.OrcRace,
            Skyrim.Race.RedguardRace,
            Skyrim.Race.WoodElfRace,
            Skyrim.Race.ElderRace,
            Skyrim.Race.InvisibleRace,
            Skyrim.Race.NordRaceAstrid,
            Skyrim.Race.NordRaceVampire,
            Skyrim.Race.ArgonianRaceVampire,
            Skyrim.Race.BretonRaceVampire,
            Skyrim.Race.DarkElfRaceVampire,
            Skyrim.Race.HighElfRaceVampire,
            Skyrim.Race.ImperialRaceVampire,
            Skyrim.Race.KhajiitRaceVampire,
            Skyrim.Race.RedguardRaceVampire,
            Skyrim.Race.WoodElfRaceVampire,
            Skyrim.Race.DA13AfflictedRace,
            Skyrim.Race.OrcRaceVampire,
            Skyrim.Race.ElderRaceVampire,
            Dawnguard.Race.SnowElfRace,
            Dawnguard.Race.DLC1NordRace,
            Dragonborn.Race.DLC2MiraakRace

            };
        }

        /// <summary>
        /// Used for doing loads/dumps of of height profiles
        /// </summary>
        public class HeightData
        {
            public float MaleHeight { get; set; }
            public float FemaleHeight { get; set; }
            public HeightData(float mHeight, float fHeight)
            {
                MaleHeight = mHeight;
                FemaleHeight = fHeight;

            }
        }

        /// <summary>
        /// Used for doing loads/dumps of skeleton profiles
        /// </summary>
        public class SkeletonData
        {

            public string MalePath { get; set; }
            public string FemalePath { get; set; }
            public SkeletonData(string mPath, string fPath)
            {
                MalePath = mPath;
                FemalePath = fPath;
            }
        }

    }
}
