package helper;

import java.io.*;

public class FileHandler {
    public void reverseFile(String pathSource, String pathOutput) {
        File file = new File(pathSource);
        File reverse = new File(pathOutput);

        try {
            FileInputStream fin = new FileInputStream(file);
            FileOutputStream fout = new FileOutputStream(reverse);

            BufferedInputStream buffin = new BufferedInputStream(fin);
            BufferedOutputStream buffout = new BufferedOutputStream(fout);

            byte[] buffer = buffin.readAllBytes().clone();

            reverse.createNewFile();

            for(int currentByte = buffer.length -1 ; currentByte >= 0 ; currentByte--) {
                buffout.write((byte) buffer[currentByte]);
            }

            System.out.println("Source file is successfully reversed to " + pathOutput);

            buffin.close();
            buffout.close();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
