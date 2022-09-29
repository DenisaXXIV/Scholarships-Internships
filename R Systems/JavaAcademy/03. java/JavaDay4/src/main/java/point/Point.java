package point;

import annotation.CheckIfNegative;

import java.util.ArrayList;

public class Point {
    private int keyName;
    private float coordX;
    private float coordY;

    public Point(float coordX, float coordY) {
        this.coordX = coordX;
        this.coordY = coordY;
    }

    public Point(Integer key, ArrayList<Float> arrayList) {
        this.coordX = arrayList.get(0) + arrayList.get(1);
        this.coordY = arrayList.get(2) + arrayList.get(3);
        this.keyName = key;
    }

    @CheckIfNegative
    public float getCoordX() {
        return coordX;
    }

    public void setCoordX(float coordX) {
        this.coordX = coordX;
    }

    @CheckIfNegative
    public float getCoordY() {
        return coordY;
    }

    public void setCoordY(float coordY) {
        this.coordY = coordY;
    }

    @Override
    public String toString() {
        return "Point " + keyName +"{" +
                "coordX=" + coordX +
                ", coordY=" + coordY +
                '}';
    }
}
