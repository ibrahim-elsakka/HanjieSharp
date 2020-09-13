using System;
using System.Collections.Generic;

namespace HanjieSharp.Domain
{
    internal sealed class Row
    {
        public IReadOnlyCollection<Objective> Objectives { get; }

        public IReadOnlyCollection<Node> Nodes { get; }
        
        public Row(IReadOnlyCollection<Objective> objectives, IReadOnlyCollection<Node> nodes)
        {
            Objectives = objectives ?? throw new ArgumentNullException(nameof(objectives));
            Nodes = nodes ?? throw new ArgumentNullException(nameof(nodes));
        }
    }

    internal sealed class Node
    {
        public NodeState State { get; set; }
        
        public int X { get; }
        
        public int Y { get; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
            State = NodeState.None;
        }
    }
}