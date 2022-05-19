using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    public class Node: IMapNode
    {
        private bool _walkable;
        private bool _flyable;
        private bool _swimmable;
        private bool _climbable;
        private Treasure _treasure;
        private int _prefabIndex;
        private string _prefabName;

        public Node(int prefabIndex, string prefabName, 
            bool walkable = true, bool flyable = false, bool swimmable = false, 
            bool climbable = false, Treasure treasure = null)
        {
            _prefabIndex = prefabIndex;
            _prefabName = prefabName;
            _treasure = treasure;
            _walkable = walkable;
            _flyable = flyable;
            _swimmable = swimmable;
            _climbable = climbable;
        }

        public int GetPrefabIndex()
        {
            return _prefabIndex;
        }

        public string GetPrefabName()
        {
            return _prefabName;
        }

        public bool IsWalkable()
        {
            return _walkable;
        }

        public bool IsFlyable()
        {
            return _flyable;
        }

        public bool IsSwimmable()
        {
            return _swimmable;
        }

        public bool IsClimbable()
        {
            return _climbable;
        }

        public bool HasTreasure()
        {
            return _treasure != null;
        }
    }
}