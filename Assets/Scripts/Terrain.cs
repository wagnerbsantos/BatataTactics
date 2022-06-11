using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    [Serializable]
    public class Terrain
    {
        [SerializeField]
        private bool walkable;
        [SerializeField]
        private bool flyable;
        [SerializeField]
        private bool swimmable;
        [SerializeField]
        private bool climbable;
        [SerializeField]
        private Treasure treasure;
        [SerializeField]
        private int prefabIndex;
        [SerializeField]
        private string prefabName;

        public Terrain(int prefabIndex, string prefabName, 
            bool walkable = true, bool flyable = false, bool swimmable = false, 
            bool climbable = false, Treasure treasure = null)
        {
            this.prefabIndex = prefabIndex;
            this.prefabName = prefabName;
            this.treasure = treasure;
            this.walkable = walkable;
            this.flyable = flyable;
            this.swimmable = swimmable;
            this.climbable = climbable;
        }

        public int GetPrefabIndex()
        {
            return prefabIndex;
        }

        public string GetPrefabName()
        {
            return prefabName;
        }

        public bool IsWalkable()
        {
            return walkable;
        }

        public bool IsFlyable()
        {
            return flyable;
        }

        public bool IsSwimmable()
        {
            return swimmable;
        }

        public bool IsClimbable()
        {
            return climbable;
        }

        public bool HasTreasure()
        {
            return treasure != null;
        }
    }
}