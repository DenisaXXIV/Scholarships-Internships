package helpers;

import java.io.*;

public class FileHandler {
    public void copyFile(String pathSource, String pathOutput) {
        File file = new File(pathSource);
        File copy = new File(pathOutput);

        byte[] buffer = new byte[1000];

        try {
            FileInputStream fin = new FileInputStream(file);
            FileOutputStream fout = new FileOutputStream(copy);
            BufferedInputStream buffin = new BufferedInputStream(fin);
            BufferedOutputStream buffout = new BufferedOutputStream(fout);

            copy.createNewFile();

            int numBytes = -1;
            while ((numBytes = buffin.read(buffer)) != -1) {
                buffout.write(buffer,0,numBytes);
            }

            System.out.println("Source file is successfully copied to " + pathOutput);

            buffin.close();
            buffout.close();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
