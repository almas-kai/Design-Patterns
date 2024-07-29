namespace Composite;

class Program
{
    static void Main()
    {
        File fav_cat = new File("my_favourite_cat.jpg", 25);
        File fav_dog = new File("my_favourity_dog.jpg", 30);
        CompositeNode petsFolder = new CompositeNode("My Pets");
        petsFolder.AddChildNode(fav_cat);
        petsFolder.AddChildNode(fav_dog);
        petsFolder.DisplayDescription();
        petsFolder.Delete();
    }
}
