import helpers.FileHandler;

import java.io.IOException;

public class Main {
    public static void main(String[] args) {
        String PATH_SOURCE = "FileCopy/src/main/resources/input.txt";
        String PATH_COPY = "FileCopy/src/main/resources/output.txt";
        FileHandler fileHandler = new FileHandler();

        fileHandler.copyFile(PATH_SOURCE,PATH_COPY);
    }
}
