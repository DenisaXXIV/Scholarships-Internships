package gson.helper;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import gson.custom.Dog;
import gson.helper.Writer;

import java.time.LocalDateTime;

public class Serializer {

    public void SerializeDog() {
        Gson gson = new GsonBuilder().setPrettyPrinting().create();
        Writer writer = new Writer();

        Dog dog = new Dog(10,"Bolt",true,45.789,10.38,70,false,"unknown");

        writer.writeJson(gson.toJson(dog));
    }

    public void SerializeDogWithoutExpose() {
        Gson gson = new GsonBuilder().excludeFieldsWithoutExposeAnnotation()
                .serializeNulls()
                .create();
        Writer writer = new Writer();

        Dog dog = new Dog(10,"Bolt",true,45.789,10.38,70,false,"unknown");

        writer.writeJson(gson.toJson(dog));
    }
}
