package helpers;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Scanner;

public class Parser {

    final String PATH = "Sample_data.txt";

    public HashMap<Integer, ArrayList<Float>> readHashMap()
    {
        HashMap<Integer, ArrayList<Float>> hashMap = new HashMap<>();
        File file = new File(PATH);

        try {
            Scanner scanner = new Scanner(file);

            while(scanner.hasNextInt()){
                ArrayList<Float> arrayList = new ArrayList<>();
                int key = scanner.nextInt();

                for( int i=0 ; i<4 ; i++) {
                    arrayList.add(scanner.nextFloat());
                }

                hashMap.put(key, arrayList);
            }

        } catch (FileNotFoundException e) {
            throw new AssertionError("File Not Found At: " + PATH);
        }

        return hashMap;
    }
}
