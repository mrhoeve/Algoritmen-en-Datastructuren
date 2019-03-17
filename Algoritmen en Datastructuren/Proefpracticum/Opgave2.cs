using Algoritmen_en_Datastructuren.BinarySearchTree;

namespace Algoritmen_en_Datastructuren.Proefpracticum
{
    public class Opgave2 : BinarySearchTree.BinarySearchTree
    {
        public int? geefEenNaKleinsteElement()
        {
            if (root == null) return null;
            Node n = root;
            // Zoek eerst de parent van de kleinste node aan de linkerkant
            while (n.left != null && n.left.left != null)
                n = n.left;
            // De parent van de kleinste node is gevonden
            // Nu kijken we nog even in de rechtertree van het linkerkind als die er is
            // Als daar een kleiner element is, dan is dat het op één na kleinste element
            if (n.left != null && n.left.right != null)
            {
                n = n.left.right;
                while (n.left != null)
                    n = n.left;
            }

            return n.element;
        }
    }
}
