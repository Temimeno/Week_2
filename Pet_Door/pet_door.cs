public class Pet_Door {
    private bool open;

    public Pet_Door() {
        this.open = false;
    }
    public void Open() {
        Console.WriteLine("The pet's door is Open.");
        this.open = true;
    }

    public void Close() {
        Console.WriteLine("The pet's door is Close.");
        this.open = false;
    }
    public bool isOpen() {
        return this.open;
    }
}