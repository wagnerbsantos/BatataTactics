using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    public class Node
    {
        public bool passable;
        public int value;

        public Node(bool passable, int value)
        {
            this.passable = passable;
            this.value = value;
        }
    }
}