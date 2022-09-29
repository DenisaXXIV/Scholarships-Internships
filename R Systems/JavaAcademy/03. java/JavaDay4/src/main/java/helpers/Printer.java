package helpers;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import point.Point;

import java.util.Set;

public class Printer {
    public void PrintPoints(Set<Point> points) {
        Logger logger = LoggerFactory.getLogger(Printer.class);

        for(Point point : points) {
            logger.info(point.toString());
        }
    }
}
