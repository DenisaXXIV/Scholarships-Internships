package gson.helper;

import java.io.File;
import java.io.IOException;
import java.io.FileWriter;

public class Writer {

    public void writeJson(String json) {
        try {
            File file = new File("denisa/src/main/resources/output.txt");
            file.createNewFile();
            FileWriter fileWriter = new FileWriter(file);

            fileWriter.write(json.toString());

            fileWriter.close();

            System.out.println("Successfully wrote to the file");

        } catch (IOException e) {
            throw new RuntimeException(e);
        }




    }
}
