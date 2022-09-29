package gson.helper;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import gson.custom.Dog;

public class Deserializer {

    public void simpleDeserialize() {
        Gson gson = new GsonBuilder().create();
        String json = "{\"Age\":10,\"name\":\"Bolt\",\"isBoy\":true,\"chipCode\":45.789,\"weight\":10.38,\"isSenior\":false}";

        Dog dog = gson.fromJson(json, Dog.class);
        System.out.println(dog);
    }

    public void simpleDeserializeNull() {
        Gson gson = new GsonBuilder().create();
        String json = "{\"Age\":10,\"name\":\"Bolt\",\"isBoy\":true,\"weight\":10.38,\"isSenior\":false}";

        Dog dog = gson.fromJson(json, Dog.class);
        System.out.println(dog);
    }

    public void simpleDeserialize2Null() {
        Gson gson = new GsonBuilder().create();
        String json = "{\"Age\":10,\"name\":\"Bolt\",\"isBoy\":true,\"isSenior\":false}";

        Dog dog = gson.fromJson(json, Dog.class);
        System.out.println(dog);
    }
}
