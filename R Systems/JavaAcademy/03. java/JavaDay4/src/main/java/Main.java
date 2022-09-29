import helpers.Parser;
import helpers.Printer;
import point.Point;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Set;

public class Main {
    public static void main(String[] args) {
        Parser parser = new Parser();
        HashMap<Integer, ArrayList<Float>> hashMap = new HashMap<Integer, ArrayList<Float>>(parser.readHashMap());
        Set<Point> points = new HashSet<>();
        Printer printer = new Printer();

        for(Integer key : hashMap.keySet()) {
            points.add(new Point(key,hashMap.get(key)));
        }

        printer.PrintPoints(points);
    }
}
