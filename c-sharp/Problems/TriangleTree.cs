using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class TriangleTree
    {
        public TriangleTreeNode Root;

        // Takes a string that looks like:
        // 
        //      3
        //     7 4
        //    2 4 6
        //   8 5 9 3
        //
        // and parses it into a TriangleTree object.
        //
        public static TriangleTree Parse(string s)
        {
            TriangleTree tree = new TriangleTree();
            StringReader reader = new StringReader(s.Trim());

            // Start by putting them in a list of arrays
            List<TriangleTreeNode[]> treelist = new List<TriangleTreeNode[]>();
            while(reader.Peek() != -1)
            {
                string line = reader.ReadLine().Trim();
                string[] itemsInLine = line.Split(new char[] { ' ' }).Where(i => !string.IsNullOrEmpty(i)).ToArray();
                int[] ints = itemsInLine.Select(i => int.Parse(i)).ToArray();
                treelist.Add(ints.Select(i => new TriangleTreeNode { Value = i }).ToArray());
            }

            // Set the relationships
            for (int i = 1; i < treelist.Count; i++)
            {
                var parentArray = treelist[i - 1];
                for (int j = 0; j < treelist[i].Length; j++)
                {
                    var node = treelist[i][j];
                    var leftParent = j == 0 ? null : parentArray[j - 1];
                    var rightParent = j == treelist[i].Length - 1 ? null : parentArray[j];

                    if (leftParent != null)
                    {
                        node.LeftParent = leftParent;
                        leftParent.RightChild = node;
                    }

                    if (rightParent != null)
                    {
                        node.RightParent = rightParent;
                        rightParent.LeftChild = node;
                    }
                }
            }

            // Assign the root
            tree.Root = treelist[0][0];

            return tree;
        }

        public int Depth
        {
            get
            {
                int depth = 0;
                var node = Root;
                while(node != null)
                {
                    depth++;
                    node = node.LeftChild;
                }
                return depth;
            }
        }

        // Level 0 is the Root, level 1 is the children of level 0, etc.
        private TriangleTreeNode[] GetLevel(int level)
        {
            List<TriangleTreeNode> nodesInLevel = new List<TriangleTreeNode>();
            
            if (level < 0 || level >= Depth) throw new ArgumentOutOfRangeException();

            // Go down the left side until we reach the level
            int currentLevel = 0;
            var node = Root;
            while(currentLevel != level)
            {
                node = node.LeftChild;
                currentLevel++;
            }

            while(true)
            {
                // Add the node
                nodesInLevel.Add(node);

                // Is there a next node?
                if (node.RightParent == null) break;
                
                // Set to the next sibling
                node = node.RightParent.RightChild;
            }

            return nodesInLevel.ToArray();
        }

        // For now, we'll assume all are 2-digit numbers
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            // Get the depth
            int depth = Depth;

            for (int level = 0; level < depth; level++)
            {
                var nodesInLevel = GetLevel(level);

                builder.Append(' ', (depth - level) * 2);
                for (int i = 0; i < nodesInLevel.Length; i++)
                {
                    builder.Append(nodesInLevel[i].Value.ToString().PadLeft(2));
                    builder.Append("  ");
                }
                builder.AppendLine();
            }            

            return builder.ToString();
        }

        public TriangleTree Clone()
        {
            TriangleTree clone = TriangleTree.Parse(this.ToString());
            return clone;
        }

        public int CalculateMaximumPathSum()
        {
            var tree = this.Clone();
            while(tree.Depth > 1)
            {
                // Remove the bottom level by adding the largest child to the next level up
                var level = tree.GetLevel(tree.Depth - 2);

                foreach(var node in level)
                {
                    node.Value += Math.Max(node.LeftChild.Value, node.RightChild.Value);
                    node.LeftChild = null;
                    node.RightChild = null;
                }
            }
            return tree.Root.Value;
        }
    }

    public class TriangleTreeNode
    {
        public TriangleTreeNode LeftParent;
        public TriangleTreeNode RightParent;
        public TriangleTreeNode LeftChild;
        public TriangleTreeNode RightChild;
        public int Value;
    }
}
