import helper.FileHandler;

public class Main {
    public static void main(String[] args) {
        String PATH_SOURCE = "FileReverseCopy/src/main/resources/input.txt";
        String PATH_COPY = "FileReverseCopy/src/main/resources/output.txt";
        FileHandler fileHandler = new FileHandler();

        fileHandler.reverseFile(PATH_SOURCE,PATH_COPY);
    }
}
