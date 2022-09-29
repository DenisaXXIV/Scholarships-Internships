package helpers;

import java.io.*;

public class FileHandler {
    public void copyFile(String pathSource, String pathOutput) {
        File file = new File(pathSource);
        File copy = new File(pathOutput);

        try {
            DataInputStream fin = new DataInputStream(new FileInputStream(file));
            DataOutputStream fout = new DataOutputStream(new FileOutputStream(copy));

            copy.createNewFile();

            int numBytes = -1;
            while ((numBytes = fin.read()) != -1) {
                fout.write((byte) numBytes);
            }

            System.out.println("Source file is successfully copied to " + pathOutput);

            fin.close();
            fout.close();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
