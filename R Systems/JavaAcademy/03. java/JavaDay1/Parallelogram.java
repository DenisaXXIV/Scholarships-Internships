package geometry;

public class Parallelogram extends Figura{
    
    public Parallelogram(String name) {
        super(name);
    }

    public float area(float baseLength, float height) {
        return baseLength * height;
    }

    public float perimeter(float baseLength, float adjacentSideLenght) {
        return 2 * (baseLength + adjacentSideLenght);
    }
}
