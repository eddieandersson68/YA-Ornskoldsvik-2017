using System.Windows.Forms;

namespace PersonRegistry
{
    public class HelperMethods
    {
        public void SameSex ()
        {
            MessageBox.Show("How did you figured that would work out?" +
                            "\nYou have selected two people of the same sex from the list." +
                            "\nPlease select only two people of opposite sexes :)");
        }

        public void Immoral ()
        {
            MessageBox.Show("That's not the opposite sex, and shame on you for even trying that !!! :'(");
        }
    }
}
