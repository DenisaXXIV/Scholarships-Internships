package gson;

import gson.helper.Deserializer;
import gson.helper.Serializer;

public class Main {
    public static void main(String[] args) {
        Serializer serializer = new Serializer();
        Deserializer deserializer = new Deserializer();

        serializer.SerializeDog();
        //serializer.SerializeDogWithoutExpose();

        //deserializer.simpleDeserialize();
        //deserializer.simpleDeserializeNull();
        deserializer.simpleDeserialize2Null();

    }
}
