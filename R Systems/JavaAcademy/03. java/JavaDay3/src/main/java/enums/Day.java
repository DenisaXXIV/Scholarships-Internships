package enums;

import java.util.HashMap;
import java.util.Map;

public enum Day {
    Sunday(1),
    Monday(2),
    Tuesday(3),
    Wednesday(4),
    Thursday(5),
    Friday(6),
    Saturday(7);

    private int value;
    private static Map<Integer, Day> intToDay = new HashMap<>();

    Day(int value) {
        this.value = value;
    }

    public int getValue() {
        return value;
    }

    static {
        for(Day day : Day.values()) {
            intToDay.put(day.getValue(),day);
        }
    }

    public static Day castIntToEnum(int value) {
        return intToDay.get(value);
    }
}
