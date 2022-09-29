import helpers.FileHandler;

public class Main {
    public static void main(String[] args) {
        String PATH_SOURCE = "FileCopyWithBuffering/src/main/resources/input.txt";
        String PATH_COPY = "FileCopyWithBuffering/src/main/resources/output.txt";
        FileHandler fileHandler = new FileHandler();

        fileHandler.copyFile(PATH_SOURCE,PATH_COPY);
    }
}
