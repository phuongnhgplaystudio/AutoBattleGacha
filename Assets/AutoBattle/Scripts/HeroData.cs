using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.Serialization;
using Sirenix.OdinInspector;

namespace AutoBattle
{
    public class HeroData : SerializedScriptableObject
    {
        public int HeroID;

        public FactionType HeroFactionType;


    }
}