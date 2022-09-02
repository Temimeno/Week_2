public class Converter {
    private int ratio;

    public Converter(int ratio) {
        this.ratio = ratio;
    }

    public int convert(int unit) {
        return unit*this.ratio;
    }
}