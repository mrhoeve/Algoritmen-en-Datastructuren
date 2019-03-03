using System;

namespace Algoritmen_en_Datastructuren
{
    public class PopulateFCNSTree
    {
        public PopulateFCNSTree()
        {
            FCNSTree<string> tree =new FCNSTree<string>();
            FCNSNode<string> nodeB = new FCNSNode<string>("B");
            FCNSNode<string> nodeC = new FCNSNode<string>("C");
            FCNSNode<string> nodeD = new FCNSNode<string>("D");
            FCNSNode<string> nodeE = new FCNSNode<string>("E");
            FCNSNode<string> nodeF = new FCNSNode<string>("F");
            FCNSNode<string> nodeG = new FCNSNode<string>("G");
            FCNSNode<string> nodeH = new FCNSNode<string>("H");
            FCNSNode<string> nodeI = new FCNSNode<string>("I");
            FCNSNode<string> nodeJ = new FCNSNode<string>("J");
            FCNSNode<string> nodeK = new FCNSNode<string>("K");

            nodeJ.FirstChild = nodeK;
            nodeI.NextSibling = nodeJ;
            nodeE.FirstChild = nodeI;
            nodeD.FirstChild = nodeH;
            nodeD.NextSibling = nodeE;
            nodeC.NextSibling = nodeD;
            nodeB.NextSibling = nodeC;
            nodeB.FirstChild = nodeF;
            nodeF.NextSibling = nodeG;

            tree.addNode(nodeB);
            Console.WriteLine($"De grootte van de tree is {tree.Size()}");

            tree.PrintPreOrder();
        }
    }
}
